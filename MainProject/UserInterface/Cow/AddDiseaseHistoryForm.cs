using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MainProject.Util;
using MainProject.Database.FarmManageDataSetTableAdapters;

namespace MainProject.UserInterface.Cow
{
    public partial class AddDiseaseHistoryForm : Form
    {
        public Int32 DiseaseHistoryID { get; set; }
        public String CowNO { get; set; }

        public AddDiseaseHistoryForm()
        {
            InitializeComponent();
        }

        private void DiseaseHistoryForm_Load(object sender, EventArgs e)
        {
            this.usersViewTableAdapter.Fill(farmManageDataSet.UsersView);
            this.stockTableAdapter.Fill(farmManageDataSet.Stock);
            this.diseaseMedicineTableAdapter.Fill(farmManageDataSet.DiseaseMedicine);
            this.diseaseHistoryTableAdapter.FillByPK(farmManageDataSet.DiseaseHistory, DiseaseHistoryID);


            if (DiseaseHistoryID == 0)
            {
                this.tcSecond.TabPages.Remove(tabHistory);
                this.tbxSymptom.ReadOnly = false;
                this.dtpDate.Enabled = true;
                this.dtpDate.MaxDate = DateTime.Now;
                this.cbxBy.Enabled = true;
                this.cbxBy.SelectedValue = MainForm.User.UserID;
                this.tcMain.TabPages.Remove(this.tabRecord);
            }
            else
            {
                this.tbxSymptom.ReadOnly = true;
                this.dtpDate.Enabled = false;
                this.cbxBy.Enabled = false;

                if (!MainForm.User.SuperUser)
                {
                    this.tcMain.TabPages.Remove(this.tabRecord);
                }
                else
                {
                    this.userLogUC.FillEvent(TypeUtil.DiseaseHistory, DiseaseHistoryID.ToString());
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var form = new AddDiseaseMedicineForm();
            form.DiseaseMedicineID = 0;
            if (DialogResult.Yes == form.ShowDialog())
            {
                this.dgvAdd.Rows.Add();
                this.dgvAdd.Rows[this.dgvAdd.Rows.Count - 1].Cells["ID"].Value = this.dgvAdd.Rows.Count;
                this.dgvAdd.Rows[this.dgvAdd.Rows.Count - 1].Cells["ByID"].Value = form.OptionByID;
                this.dgvAdd.Rows[this.dgvAdd.Rows.Count - 1].Cells["Date"].Value = form.OptionDate;
                this.dgvAdd.Rows[this.dgvAdd.Rows.Count - 1].Cells["StockID"].Value = form.OptionStockID;
                this.dgvAdd.Rows[this.dgvAdd.Rows.Count - 1].Cells["Unit"].Value = form.OptionUnit;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren())
                return;

           
            var Stocks = new Dictionary<Int32, Double>();
            foreach (DataGridViewRow row in dgvAdd.Rows)
            {
                var StockID = Convert.ToInt32(row.Cells["StockID"].Value);
                var Unit = Convert.ToDouble(row.Cells["Unit"].Value);
                if (Stocks.ContainsKey(StockID))
                {
                    Stocks[StockID] += Unit;
                }
                else
                {
                    Stocks.Add(StockID, Unit);
                }
            }

            var Msg = new StringBuilder();
            foreach (KeyValuePair<Int32, Double> Stock in Stocks)
            {
                var CurrentUnit = this.stockTableAdapter.QueryCurrentUnit(Stock.Key);
                if (CurrentUnit < Stock.Value)
                {
                    Msg.Append(String.Format("{0} จำนวนปัจจุบัน:{1} จำนวนที่ต้องการ:{2}\n", stockTableAdapter.GetDataByPK(Stock.Key)[0].Name, CurrentUnit, Stock.Value));
                }
            }

            if (Msg.Length != 0)
            {
                MessageBox.Show(String.Format("พัสดุไม่พอ \n{0}\n กรุณาลองใหม่อีกครั้ง", Msg), "ข้อผิดผลาด", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (DiseaseHistoryID == 0)
            {
                DiseaseHistoryID = (int)this.diseaseHistoryTableAdapter.InsertQuery(
                    Convert.ToInt32(this.cbxBy.SelectedValue),
                    CowNO,
                    this.dtpDate.Value,
                    this.tbxSymptom.Text,
                    this.tbxTreatment.Text);

                if (DiseaseHistoryID > 0)
                {
                    var log = new UserLogTableAdapter();
                    log.Insert(TypeUtil.DiseaseHistory, DiseaseHistoryID.ToString(), MainForm.User.UserID, 0, DateTime.Now);


                    var StockRemoveID = 0;
                    var stockRemoveResult = 0;
                    if (dgvAdd.Rows.Count > 0)
                    {
                        var stockRemoveTableAdapter = new StockRemoveTableAdapter();
                        StockRemoveID = (int)stockRemoveTableAdapter.InsertQuery(
                             Convert.ToInt32(dgvAdd.Rows[0].Cells["ByID"].Value),
                             (DateTime)dgvAdd.Rows[0].Cells["Date"].Value,
                             2,
                             CowNO);

                        userLogTableAdapter.Insert(TypeUtil.StockRemove, StockRemoveID.ToString(), MainForm.User.UserID, 0, DateTime.Now);
                    }

                    var stockRemoveListTableAdapter = new StockRemoveListTableAdapter();
                    foreach (DataGridViewRow row in dgvAdd.Rows)
                    {
                        int DiseaseMedicine = (int)diseaseMedicineTableAdapter.InsertQuery(
                             Convert.ToInt32(row.Cells["ByID"].Value),
                             DiseaseHistoryID,
                             Convert.ToInt32(row.Cells["StockID"].Value),
                             Convert.ToDouble(row.Cells["Unit"].Value),
                             (DateTime)row.Cells["Date"].Value);
                        if (DiseaseMedicine > 0)
                        {
                            log.Insert(TypeUtil.DiseaseMedicine, DiseaseMedicine.ToString(), MainForm.User.UserID, 0, DateTime.Now);

                            this.stockTableAdapter.UpdateRemoveUnit(Convert.ToDouble(row.Cells["Unit"].Value), Convert.ToInt32(row.Cells["StockID"].Value));
                            if (stockRemoveResult == 1)
                            {
                                stockRemoveListTableAdapter.Insert(StockRemoveID, Convert.ToInt32(row.Cells["StockID"].Value), Convert.ToDouble(row.Cells["Unit"].Value), null);
                            }
                        }
                    }
                    DialogResult = DialogUtil.AddSuccess();
                }
                else
                {
                    DialogResult = DialogUtil.AddError();
                }
            }
            else
            {
                var StockRemoveID = 0;
                if (dgvAdd.Rows.Count > 0)
                {
                    var stockRemoveTableAdapter = new StockRemoveTableAdapter();
                    StockRemoveID = (int)stockRemoveTableAdapter.InsertQuery(
                        Convert.ToInt32(dgvAdd.Rows[0].Cells["ByID"].Value),
                        (DateTime)dgvAdd.Rows[0].Cells["Date"].Value,
                        2,
                        CowNO);

                    userLogTableAdapter.Insert(TypeUtil.StockRemove, StockRemoveID.ToString(), MainForm.User.UserID, 0, DateTime.Now);
                }

                var stockRemoveListTableAdapter = new StockRemoveListTableAdapter();
                foreach (DataGridViewRow row in dgvAdd.Rows)
                {
                    int DiseaseMedicine = (int)diseaseMedicineTableAdapter.InsertQuery(
                         Convert.ToInt32(row.Cells["ByID"].Value),
                         DiseaseHistoryID,
                         Convert.ToInt32(row.Cells["StockID"].Value),
                         Convert.ToDouble(row.Cells["Unit"].Value),
                         (DateTime)row.Cells["Date"].Value);
                    if (DiseaseMedicine < 0)
                    {
                        stockTableAdapter.UpdateRemoveUnit(Convert.ToDouble(row.Cells["Unit"].Value), Convert.ToInt32(row.Cells["StockID"].Value));
                        if (StockRemoveID > 0)
                        {
                            stockRemoveListTableAdapter.Insert(StockRemoveID, Convert.ToInt32(row.Cells["StockID"].Value), Convert.ToDouble(row.Cells["Unit"].Value), null);
                        }
                    }
                }

                var log = new UserLogTableAdapter();
                log.Insert(TypeUtil.DiseaseHistory, DiseaseHistoryID.ToString(), MainForm.User.UserID, 1, DateTime.Now);

                DialogResult = DialogUtil.SaveSuccess();
            }
        }

        private void tbxSymptom_Validating(object sender, CancelEventArgs e)
        {
            ValidatingUtil.Validating(tbxSymptom, tbxSymptom.Text.Trim().Length == 0, e);
        }

        private void cbxBy_Validating(object sender, CancelEventArgs e)
        {
            ValidatingUtil.Validating(cbxBy, cbxBy.SelectedValue == null, e);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in this.dgvAdd.SelectedRows)
            {
                this.dgvAdd.Rows.Remove(row);
            }
        }

        private void btnRemoveAll_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in this.dgvAdd.Rows)
            {
                this.dgvAdd.Rows.Remove(row);
            }
        }

        private void dgvAdd_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            this.btnRemoveAll.Enabled = this.dgvAdd.Rows.Count == 0 ? false : true;
        }

        private void dgvAdd_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            this.btnRemoveAll.Enabled = this.dgvAdd.Rows.Count == 0 ? false : true;
        }

        private void dgvAdd_SelectionChanged(object sender, EventArgs e)
        {
            this.btnRemove.Enabled = this.dgvAdd.SelectedRows.Count == 0 ? false : true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.No;
        }
    }
}

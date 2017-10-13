using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MainProject.Util;
using MainProject.UserInterface.Resource;
using MainProject.Database.FarmManageDataSetTableAdapters;

namespace MainProject.UserInterface.Supplies
{
    public partial class RemoveStockDetailForm : Form
    {
        public Int32 RemoveStockID { get; set; }

        public RemoveStockDetailForm()
        {
            InitializeComponent();
        }

        private void AddStockDetailForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'farmManageDataSet.UsersView' table. You can move, or remove it, as needed.
            this.usersViewTableAdapter.Fill(this.farmManageDataSet.UsersView);
            this.stockTableAdapter.Fill(farmManageDataSet.Stock);

            if (RemoveStockID > 0)
            {
                this.cbxBy.Enabled = false;
                this.dtpDate.Enabled = false;

                this.btnSave.Visible = false;
                this.btnCancel.Text = "ปิด";

                this.stockRemoveListTableAdapter.Fill(farmManageDataSet.StockRemoveList);
                this.stockRemoveTableAdapter.FillByPK(farmManageDataSet.StockRemove, RemoveStockID);

                this.tcSecond.TabPages.Remove(tabStockAdd);
                if (!MainForm.User.SuperUser)
                {
                    this.tcMain.TabPages.Remove(tabRecord);
                }
                else
                {
                    this.userLogUC.FillEvent(TypeUtil.StockRemove, RemoveStockID.ToString());
                }
            }
            else
            {
                this.Text = "เบิกพัสดุ";
                this.lblTitle.Text = this.Text;
                this.btnResource.Visible = false;
                this.tcMain.TabPages.Remove(tabRecord);
                this.tcSecond.TabPages.Remove(tabStockList);

                this.dtpDate.MaxDate = DateTime.Now;
                this.cbxBy.SelectedValue = MainForm.User.UserID;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (this.dgvAddList.Rows.Count == 0)
            {
                MessageBox.Show("ไม่มีรายการที่เพิ่มอย่างสมบูรณ์ กรุณาเพิ่มหรือป้อนข้อมูลให้ครบ");
                return;
            }
            for (var i = 0; i < dgvAddList.Rows.Count; i++)
            {
                if (this.dgvAddList.Rows[i].Cells[0].Value == null || Convert.ToDouble(dgvAddList.Rows[i].Cells[1].Value) == 0)
                {
                    MessageBox.Show("ข้อมูลไม่ครบ กรุณาลองใหม่อีกครั้ง", "ข้อผิดผลาก", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }



            var Stocks = new Dictionary<Int32, Double>();
            foreach (DataGridViewRow vRow in this.dgvAddList.Rows)
            {
                var StockID = Convert.ToInt32(vRow.Cells[0].Value);
                var Unit = Convert.ToDouble(vRow.Cells[1].Value);
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
                Double? CurrentUnit = this.stockTableAdapter.QueryCurrentUnit(Stock.Key);
                if (CurrentUnit.Value < Stock.Value)
                {
                    Msg.Append(String.Format("{0} จำนวนปัจจุบัน:{1} จำนวนที่ต้องการ:{2}\n", stockTableAdapter.GetDataByPK(Stock.Key)[0].Name, CurrentUnit, Stock.Value));
                }
            }

            if (Msg.Length != 0)
            {
                MessageBox.Show(String.Format("พัสดุไม่พอ \n{0}\n กรุณาลองใหม่อีกครั้ง", Msg), "ข้อผิดผลาด", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            RemoveStockID = (int)this.stockRemoveTableAdapter.InsertQuery(
                Convert.ToInt32(cbxBy.SelectedValue),
                this.dtpDate.Value,
                0,
                "0");//0 เบิกตามปกติ

            if (RemoveStockID > 0)
            {
                var log = new UserLogTableAdapter();
                log.Insert(TypeUtil.StockRemove, RemoveStockID.ToString(), MainForm.User.UserID, TypeUtil.EVENT_CREATE, DateTime.Now);



                var StockRemoveID = stockRemoveTableAdapter.QueryMaxID();
                foreach (DataGridViewRow row in this.dgvAddList.Rows)
                {
                   var result = this.stockRemoveListTableAdapter.Insert(
                        StockRemoveID.Value,
                        Convert.ToInt32(row.Cells[0].Value),
                        Convert.ToDouble(row.Cells[1].Value),
                        row.Cells[2].Value == null ? string.Empty : row.Cells[2].Value.ToString());
                    if (result == 1)
                    {
                        this.stockTableAdapter.UpdateRemoveUnit(Convert.ToDouble(row.Cells[1].Value), Convert.ToInt32(row.Cells[0].Value));
                    }
                }

                this.DialogResult = DialogUtil.SaveSuccess();
            }
            else
            {
                this.DialogResult = DialogUtil.SaveError();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.No;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            dgvAddList.Rows.Add();
            dgvAddList.Rows[dgvAddList.Rows.Count - 1].Cells[1].Value = 0;
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvAddList.SelectedRows)
            {
                dgvAddList.Rows.Remove(row);
            }
        }

        private void btnRemoveAll_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvAddList.Rows)
            {
                dgvAddList.Rows.Remove(row);
            }
        }

        private Double CellBeginValue = 0D;

        private void dgvAddList_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (e.ColumnIndex == 1)
            {
                CellBeginValue = Convert.ToDouble(dgvAddList.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
                dgvAddList.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = CellBeginValue;
            }
        }

        private void dgvAddList_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 1)
            {
                try
                {
                    var value = Convert.ToDouble(dgvAddList.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
                    dgvAddList.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = value;

                    if (value <= 0)
                    {
                        MessageBox.Show("รับตัวเลขเท่านั้น");
                        dgvAddList.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = CellBeginValue;
                    }
                }
                catch
                {
                    MessageBox.Show("รับตัวเลขเท่านั้น");
                    dgvAddList.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = CellBeginValue;
                }
            }
        }

        private void dgvAddList_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            btnRemoveAll.Enabled = dgvAddList.Rows.Count == 0 ? false : true;
        }

        private void dgvAddList_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            btnRemoveAll.Enabled = dgvAddList.Rows.Count == 0 ? false : true;
        }

        private void dgvAddList_SelectionChanged(object sender, EventArgs e)
        {
            btnRemove.Enabled = dgvAddList.SelectedRows.Count == 0 ? false : true;
        }

        private void btnResource_Click(object sender, EventArgs e)
        {
            ResourceExplorerForm form = new ResourceExplorerForm();
            form.FromID = RemoveStockID;
            form.FromType = 5;
            form.ShowDialog();
        }
    }
}

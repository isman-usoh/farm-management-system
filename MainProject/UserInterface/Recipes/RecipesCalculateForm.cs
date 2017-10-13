using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MainProject.Util;
using MainProject.Database;
using MainProject.Database.FarmManageDataSetTableAdapters;

namespace MainProject.UserInterface.Recipes
{
    public partial class RecipesCalculateForm : Form
    {
        public Int32 RecipesID { get; set; }

        public RecipesCalculateForm()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (Convert.ToDouble(tbxPercen.Text) == 0D)
            {
                MessageBox.Show("จำเป็นต้องเลือกอัตราคำนวน มากกว่า 0", "ข้อผิดผลาด", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }



            int ByID = Convert.ToInt32(cbxBy.SelectedValue);
            RecipesID = Convert.ToInt32(cbxRecipse.SelectedValue);
            if (RecipesID == 0)
            {
                MessageBox.Show("คุณยังไม่ได้เลือกสูตรอาหาร กรุณาเลือกสูตรอาหารก่อน", "ข้อผิดผลาด", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var RecipesListRows = new RecipesListTableAdapter().GetDataByRecipesID(RecipesID);


            var msg = new StringBuilder();
            foreach (FarmManageDataSet.RecipesListRow row in RecipesListRows.Rows)
            {
                var unit = (row.Unit * Double.Parse(tbxPercen.Text)) / 100;
                var StockRows = stockTableAdapter.GetDataByPK(row.StockID);
                if (StockRows.Count == 0)
                {
                    MessageBox.Show("ไม่พบพัสดุที่ต้องการจะหัก หรือพัสดุนั้นถูกลบออกจากระบบแล้วกรุนาตรวจสอบใหม่อีกครั้ง <br/>ID:" + row.StockID, "ข้อผิดผลาด", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (unit > StockRows[0].Unit)
                {
                    msg.Append(String.Format("พัสดุชื่อ {0} มีจำนวนไม่พอที่หัก จำนวนปัจจุบัน:{1} จำนวนที่ต้องการหัก:{2}<br>", StockRows[0].Name, StockRows[0].Unit, unit));
                }
            }
            if (msg.Length != 0)
            {
                MessageBox.Show(msg.ToString(), "ข้อผิดผลาด", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var RecipesHistoryID = (int)this.recipesHistoryTableAdapter.InsertQuery(
                Convert.ToInt32(cbxBy.SelectedValue), 
                RecipesID, 
                dtpDate.Value, 
                Convert.ToInt32(tbxPercen.Text));
            if (RecipesHistoryID > 0)
            {
                var log = new UserLogTableAdapter();
                log.Insert(TypeUtil.RecipesHistory, RecipesHistoryID.ToString(), MainForm.User.UserID, TypeUtil.EVENT_CREATE, DateTime.Now);

                foreach (FarmManageDataSet.RecipesListRow row in RecipesListRows.Rows)
                {
                    var Unit = (row.Unit * Double.Parse(tbxPercen.Text)) / 100;
                    int RecipesListHistoryID = (int)recipesListHistoryTableAdapter.InsertQuery(RecipesHistoryID, row.StockID, Unit);
                    if (RecipesListHistoryID > 0)
                    {
                        log.Insert(TypeUtil.RecipesListHistory, RecipesListHistoryID.ToString(), MainForm.User.UserID, TypeUtil.EVENT_CREATE, DateTime.Now);

                        int StockRemoveID = (int)this.stockRemoveTableAdapter.InsertQuery(
                            ByID, 
                            dtpDate.Value, 
                            3,
                            RecipesHistoryID.ToString());

                        if (StockRemoveID > 0)
                        {
                            log.Insert(TypeUtil.StockRemove, StockRemoveID.ToString(), MainForm.User.UserID, TypeUtil.EVENT_CREATE, DateTime.Now);

                            var StockRemoveListID = (int)new StockRemoveListTableAdapter().InsertQuery(StockRemoveID, row.StockID, Unit, null);
                            if (StockRemoveListID > 0)
                            {
                                this.stockTableAdapter.UpdateRemoveUnit(Unit, row.StockID);
                                log.Insert(TypeUtil.StockRemoveList, StockRemoveListID.ToString(), MainForm.User.UserID, TypeUtil.EVENT_CREATE, DateTime.Now);
                            }
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

        private void RecipesCalculateForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'farmManageDataSet.Recipes' table. You can move, or remove it, as needed.
            this.recipesTableAdapter.Fill(this.farmManageDataSet.Recipes);
            // TODO: This line of code loads data into the 'farmManageDataSet.UsersView' table. You can move, or remove it, as needed.
            this.usersViewTableAdapter.Fill(farmManageDataSet.UsersView);
            this.cbxBy.SelectedValue = MainForm.User.UserID;
            this.cbxRecipse.SelectedValue = RecipesID;
            this.dtpDate.MaxDate = DateTime.Now;

            if (RecipesID != 0)
                this.cbxRecipse.Enabled = false;


            if (this.recipesBindingSource.Count == 0)
            {
                MessageBox.Show("ยังไม่มีสูตรอาหาร กรุณาเพิ่มสูตรอาหารก่อนใช้งานนี้", "ข้อผิดผลาด", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.DialogResult = System.Windows.Forms.DialogResult.No;
            }
        }

        private void tbxPercen_KeyPress(object sender, KeyPressEventArgs e)
        {
            KeyPressUtil.Double(tbxPercen, e);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.No;
        }
    }
}

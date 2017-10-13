using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using MainProject.Util;
using MainProject.Database.FarmManageDataSetTableAdapters;

namespace MainProject.UserInterface.Recipes
{
    public partial class AddRecipesForm : Form
    {
        public Int32 RecipesID { get; set; }

        public AddRecipesForm()
        {
            InitializeComponent();
        }

        private void RecipesDetailForm_Load(object sender, EventArgs e)
        {
            this.stockTableAdapter.Fill(farmManageDataSet.Stock);
            this.usersViewTableAdapter.Fill(farmManageDataSet.UsersView);
            this.recipesHistoryTableAdapter.Fill(farmManageDataSet.RecipesHistory);
            this.recipesListTableAdapter.Fill(farmManageDataSet.RecipesList);

            if (RecipesID == 0)
            {
                this.tclMain.TabPages.Remove(this.tabHistory);
                this.tclMain.TabPages.Remove(this.tabRecord);
                this.tcSecond.TabPages.Remove(this.tabList);
            }
            else
            {
                this.recipesTableAdapter.FillByPK(farmManageDataSet.Recipes, RecipesID);
            }
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren())
                return;


            foreach (DataGridViewRow row in this.dgvAdd.Rows)
            {
                if (row.Cells[0].Value == null || row.Cells[1].Value == null)
                {
                    MessageBox.Show("ป้อนข้อมูลไม่ครบ", "ข้อผิดผลาด", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            if (RecipesID == 0)
            {
                RecipesID = (int)this.recipesTableAdapter.InsertQuery(tbxName.Text, tbxDescription.Text);
                if (RecipesID  > 0)
                {
                    var log = new UserLogTableAdapter();
                    log.Insert(TypeUtil.Recipes, RecipesID.ToString(), MainForm.User.UserID, TypeUtil.EVENT_CREATE, DateTime.Now);


                    RecipesID = recipesTableAdapter.GetMaxID().Value;
                    foreach (DataGridViewRow row in this.dgvAdd.Rows)
                    {
                        Int32 StockID = Convert.ToInt32(row.Cells[0].Value);
                        Double Unit = Convert.ToDouble(row.Cells[1].Value);
                        this.recipesListTableAdapter.Insert(RecipesID, StockID, Unit);
                    }

                    this.DialogResult = DialogUtil.AddSuccess();
                }
                else
                {
                    this.DialogResult = DialogUtil.AddError();
                }
            }
            else
            {
                this.Validate();
                this.recipesBindingSource.EndEdit();
                this.fKrecipeslistrecipesBindingSource.EndEdit();
                this.recipesTableAdapter.Update(farmManageDataSet.Recipes);
                this.recipesListTableAdapter.Update(farmManageDataSet.RecipesList);

                foreach (DataGridViewRow row in this.dgvAdd.Rows)
                {
                    Int32 StockID = Convert.ToInt32(row.Cells[0].Value);
                    Double Unit = Convert.ToDouble(row.Cells[1].Value);
                    this.recipesListTableAdapter.Insert(RecipesID, StockID, Unit);
                }

                var log = new UserLogTableAdapter();
                log.Insert(TypeUtil.Recipes, RecipesID.ToString(), MainForm.User.UserID, 1, DateTime.Now);


                //if (result == 1)
                //{
                    
                //    this.recipesListTableAdapter.Update(farmManageDataSet.RecipesList);


                //    foreach (DataGridViewRow row in this.dgvAdd.Rows)
                //    {
                //        Int32 StockID = Convert.ToInt32(row.Cells[0].Value);
                //        Double Unit = Convert.ToDouble(row.Cells[1].Value);
                //        this.recipesListTableAdapter.Insert(RecipesID, StockID, Unit);
                //    }

                    DialogUtil.SaveSuccess();
                    this.DialogResult = DialogResult.Yes;
                //}
                //else
                //{
                //    DialogUtil.SaveError();
                //    this.DialogResult = DialogResult.No;
                //}
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.Yes;
        }

        private void tbxName_Validating(object sender, CancelEventArgs e)
        {
            ValidatingUtil.Validating(tbxName, 0, e);
        }

        private void dgvHistory_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            RecipesCalculateDetailForm form = new RecipesCalculateDetailForm();
            form.RecipesHistoryID = Convert.ToInt32(((DataRowView)fKrecipeshistoryrecipesBindingSource[e.RowIndex]).Row[0]);
            var result = form.ShowDialog();
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                recipesHistoryTableAdapter.Fill(farmManageDataSet.RecipesHistory);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.dgvAdd.Rows.Add();
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

        private void btnListRemove_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in this.dgvList.SelectedRows)
            {
                this.dgvList.Rows.Remove(row);
            }
        }

        private void dgvList_SelectionChanged(object sender, EventArgs e)
        {
            this.btnListRemove.Enabled = this.dgvList.SelectedRows.Count == 0 ? false : true;
        }


        private Double Dvalue = 0;

        private void dgvAdd_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (e.ColumnIndex != 1)
            {
                return;
            }

            Dvalue = Convert.ToDouble(this.dgvAdd.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
        }

        private void dgvAdd_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex != 1)
            {
                return;
            }

            try
            {
                this.dgvAdd.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = Convert.ToDouble(this.dgvAdd.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
            }
            catch
            {
                MessageBox.Show("รับเฉพาะตัวเลขเท่านั้น", "ข้อผิดผลาก", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.dgvAdd.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = Dvalue;
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

        private void dgvList_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = false;
            MessageBox.Show("รับเฉพาะตัวเลขเท่านั้น","ข้อผิดผลาด",MessageBoxButtons.OK,MessageBoxIcon.Error);
        }
    }
}

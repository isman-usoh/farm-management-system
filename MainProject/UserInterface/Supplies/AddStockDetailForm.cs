using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using MainProject.Util;
using MainProject.UserInterface.Resource;
using MainProject.Database.FarmManageDataSetTableAdapters;

namespace MainProject.UserInterface.Supplies
{
    public partial class AddStockDetailForm : Form
    {
        public Int32 AddStockID { get; set; }

        public AddStockDetailForm()
        {
            InitializeComponent();
        }

        private void CallculateTotalAmount()
        {
            Double total = 0;
            foreach (DataGridViewRow row in dgvAddList.Rows)
            {
                total += Convert.ToDouble(row.Cells["colAddAmount"].Value);
            }
            tbxTotal.Text = total.ToString();
        }

        private void AddStockDetailForm_Load(object sender, EventArgs e)
        {   
            this.userLogTableAdapter.Fill(this.farmManageDataSet.UserLog);
            this.stockTableAdapter.Fill(farmManageDataSet.Stock);
            this.usersViewTableAdapter.Fill(farmManageDataSet.UsersView);

            if (AddStockID != 0)
            {
                this.cbxBy.Enabled = false;
                this.dtpDate.Enabled = false;
                this.btnSave.Visible = false;
                this.btnCancel.Text = "ปิด";
                this.tcSecond.TabPages.Remove(tabStockAdd);


                this.stockAddListTableAdapter.Fill(farmManageDataSet.StockAddList);
                this.stockAddTableAdapter.FillByPK(farmManageDataSet.StockAdd, AddStockID);

                if (!MainForm.User.SuperUser)
                    this.tcMain.TabPages.Remove(tabRecord);
            }
            else
            {
                this.Text = "เพิ่มพัสดุ";
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
            if (AddStockID == 0)
            {
                if (dgvAddList.Rows.Count == 0)
                {
                    MessageBox.Show("ไม่มีรายการที่เพิ่มอย่างสมบูรณ์ กรุณาเพิ่มหรือป้อนข้อมูลให้ครบ");
                    return;
                }
                for (var i = 0; i < dgvAddList.Rows.Count - 1; i++)
                {
                    if (dgvAddList.Rows[i].Cells[0].Value == null || Convert.ToDouble(dgvAddList.Rows[i].Cells[1].Value) == 0 || Convert.ToDouble(dgvAddList.Rows[i].Cells[2].Value) == 0)
                    {
                        MessageBox.Show("ข้อมูลไม่ครบ กรุณาลองใหม่อีกครั้ง");
                        return;
                    }
                }
                int StockAddID = (int)stockAddTableAdapter.InsertQuery(
                    Convert.ToInt32(cbxBy.SelectedValue),
                    dtpDate.Value,
                    Convert.ToDouble(tbxTotal.Text));

                if (StockAddID > 0)
                {
                    var log = new UserLogTableAdapter();
                    log.Insert(TypeUtil.StockAdd, AddStockID.ToString(), MainForm.User.UserID, TypeUtil.EVENT_CREATE, DateTime.Now);

                   
                    for (var i = 0; i < dgvAddList.Rows.Count; i++)
                    {
                        var stockAddListID = (int)stockAddListTableAdapter.InsertQuery(
                            StockAddID,
                            Convert.ToInt32(dgvAddList.Rows[i].Cells[0].Value),
                            Convert.ToDouble(dgvAddList.Rows[i].Cells[1].Value),
                            Convert.ToDouble(dgvAddList.Rows[i].Cells[2].Value),
                            Convert.ToDouble(dgvAddList.Rows[i].Cells[3].Value),
                            dgvAddList.Rows[i].Cells[4].Value == null ? string.Empty : dgvAddList.Rows[i].Cells[4].Value.ToString());

                        if (stockAddListID > 0)
                        {
                            log.Insert(TypeUtil.StockAddList, stockAddListID.ToString(), MainForm.User.UserID, TypeUtil.EVENT_CREATE, DateTime.Now);

                            stockTableAdapter.UpdateAddUnit(Convert.ToDouble(dgvAddList.Rows[i].Cells[1].Value), Convert.ToInt32(dgvAddList.Rows[i].Cells[0].Value));
                        }
                    }

                    DialogResult = DialogUtil.AddSuccess();
                }
                else
                {
                    DialogResult = DialogUtil.AddError();
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.No;
        }

        private Double CellBeginValue = 0D;

        private void dgvAddList_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 1 || e.ColumnIndex == 2)
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


                var Value1 = Convert.ToDouble(dgvAddList.Rows[e.RowIndex].Cells[1].Value);
                var Value2 = Convert.ToDouble(dgvAddList.Rows[e.RowIndex].Cells[2].Value);

                dgvAddList.Rows[e.RowIndex].Cells[3].Value = Value1 * Value2;
                CallculateTotalAmount();
            }
        }

        private void dgvAddList_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (e.ColumnIndex == 1 || e.ColumnIndex == 2)
            {
                CellBeginValue = Convert.ToDouble(dgvAddList.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
                dgvAddList.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = CellBeginValue;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            dgvAddList.Rows.Add();
            dgvAddList.Rows[dgvAddList.Rows.Count - 1].Cells[1].Value = 0;
            dgvAddList.Rows[dgvAddList.Rows.Count - 1].Cells[2].Value = 0;
            dgvAddList.Rows[dgvAddList.Rows.Count - 1].Cells[3].Value = 0;
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
            form.FromID = AddStockID;
            form.FromType = 4;
            form.ShowDialog();
        }

    }
}

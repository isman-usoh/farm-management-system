using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MainProject.Util;
using MainProject.Database.FarmManageDataSetTableAdapters;
using MainProject.UserInterface.Resource;

namespace MainProject.UserInterface.Order
{
    public partial class AddDeadForm : Form
    {
        public Int32 OrderOutID { get; set; }

        public AddDeadForm()
        {
            InitializeComponent();
        }

        public String[] SelectCow()
        {
            var list = new List<String>();
            foreach (DataGridViewRow row in dgvCowAdd.Rows)
            {
                list.Add(row.Cells["colCowNO"].Value.ToString());
            }
            return list.ToArray();
        }

        private void AddBornForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'farmManageDataSet.Gene' table. You can move, or remove it, as needed.
            this.geneTableAdapter.Fill(this.farmManageDataSet.Gene);
            // TODO: This line of code loads data into the 'farmManageDataSet.Corral' table. You can move, or remove it, as needed.
            this.corralTableAdapter.Fill(this.farmManageDataSet.Corral);
            // TODO: This line of code loads data into the 'farmManageDataSet.UsersView' table. You can move, or remove it, as needed.
            this.usersViewTableAdapter.Fill(this.farmManageDataSet.UsersView);

            this.sexDataGridViewTextBoxColumn.ValueMember = "Key";
            this.sexDataGridViewTextBoxColumn.DisplayMember = "Value";
            this.sexDataGridViewTextBoxColumn.DataSource = TypeUtil.CowSex().ToList();

            this.colSex.ValueMember = "Key";
            this.colSex.DisplayMember = "Value";
            this.colSex.DataSource = TypeUtil.CowSex().ToList();

            if (OrderOutID > 0)
            {
                // TODO: This line of code loads data into the 'farmManageDataSet.Cow' table. You can move, or remove it, as needed.
                this.cowTableAdapter.Fill(this.farmManageDataSet.Cow);
                // TODO: This line of code loads data into the 'farmManageDataSet.BornView' table. You can move, or remove it, as needed.
                this.deadViewTableAdapter.FillByPK(this.farmManageDataSet.DeadView, OrderOutID);

                this.cbxBy.Enabled = false;
                this.dtpDate.Enabled = false;
                this.tbxDescription.ReadOnly = true;

                this.mTitle.Text = "รายละเอียกการตาย";
                this.btnSave.Visible = false;
                this.btnClose.Text = "ปิด";

                this.tcSecond.TabPages.Remove(this.tabCowAdd);
                if (!MainForm.User.SuperUser)
                {
                    this.tcMain.TabPages.Remove(this.tabRecord);
                }
                else
                {
                    this.userLogUC.FillEvent(TypeUtil.OrderOut, OrderOutID.ToString());
                }
            }
            else
            {
                this.tcSecond.TabPages.Remove(this.tabCow);
                this.tcMain.TabPages.Remove(this.tabRecord);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (OrderOutID > 0)
            {
                this.Validate();
                this.deadViewBindingSource.EndEdit();
                this.fKCowOrderOut1BindingSource.EndEdit();
                Int32 result = this.deadViewTableAdapter.Update(this.farmManageDataSet.DeadView);

                if (result == 1)
                {
                    this.DialogResult = DialogUtil.SaveSuccess();
                }
                else
                {
                    this.DialogResult = DialogUtil.SaveError();
                }
            }
            else
            {

                OrderOutID = (int)this.deadViewTableAdapter.InsertQuery(
                    (byte)2, 
                    Convert.ToInt32(this.cbxBy.SelectedValue), 
                    this.dtpDate.Value, 
                    this.tbxDescription.Text);

                if (OrderOutID > 0)
                {
                    var log = new UserLogTableAdapter();
                    log.Insert(TypeUtil.OrderOut, OrderOutID.ToString(), MainForm.User.UserID, TypeUtil.EVENT_CREATE, DateTime.Now);

                    foreach (DataGridViewRow row in this.dgvCowAdd.Rows)
                    {
                        Int32 tCorralID = Convert.ToInt32(row.Cells["colCorral"].Value);
                        String tCowNO = row.Cells["colCowNO"].Value.ToString();


                        int result = this.cowTableAdapter.UpdateCowOrderOut(OrderOutID, new Double?(), tCowNO);
                        if (result == 1)
                        {
                            log.Insert(TypeUtil.Cow, tCowNO, MainForm.User.UserID, TypeUtil.EVENT_DEAD, DateTime.Now);
                                
                            this.corralTableAdapter.UpdateRemoveCurrent(1, tCorralID);
                        }
                    }

                    this.DialogResult = DialogUtil.AddSuccess();
                }
                else
                {
                    this.DialogResult = DialogUtil.AddError();
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var form = new AddCowOrderOutForm();
            form.AddDead = this;
            form.IsDead = true;
            if (DialogResult.Yes == form.ShowDialog())
            {
                foreach (AddCowOrderOutForm.CowPoJo cow in form.Cows)
                {
                    dgvCowAdd.Rows.Add();
                    dgvCowAdd.Rows[dgvCowAdd.Rows.Count - 1].Cells["colID"].Value = dgvCowAdd.Rows.Count;
                    dgvCowAdd.Rows[dgvCowAdd.Rows.Count - 1].Cells["colCowNO"].Value = cow.NO;
                    dgvCowAdd.Rows[dgvCowAdd.Rows.Count - 1].Cells["colCorral"].Value = cow.CorralID;
                    dgvCowAdd.Rows[dgvCowAdd.Rows.Count - 1].Cells["colGene"].Value = cow.GeneID;
                    dgvCowAdd.Rows[dgvCowAdd.Rows.Count - 1].Cells["colSex"].Value = cow.SexID;
                    dgvCowAdd.Rows[dgvCowAdd.Rows.Count - 1].Cells["colDescription"].Value = String.Empty;
                }
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in this.dgvCowAdd.SelectedRows)
            {
                this.dgvCowAdd.Rows.RemoveAt(row.Index);
            }

            foreach (DataGridViewRow row in this.dgvCowAdd.Rows)
            {
                row.Cells[0].Value = row.Index + 1;
            }
        }

        private void btnRemoveAll_Click(object sender, EventArgs e)
        {
            this.dgvCowAdd.Rows.Clear();
        }

        private void dgvCowAdd_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            this.btnRemoveAll.Enabled = this.dgvCowAdd.Rows.Count == 0 ? false : true;
        }

        private void dgvCowAdd_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            this.btnRemoveAll.Enabled = this.dgvCowAdd.Rows.Count == 0 ? false : true;
        }

        private void dgvCowAdd_SelectionChanged(object sender, EventArgs e)
        {
            this.btnRemove.Enabled = this.dgvCowAdd.SelectedRows.Count == 0 ? false : true;
        }

        private void btnResource_Click(object sender, EventArgs e)
        {
            var form = new ResourceExplorerForm();
            form.FromID = OrderOutID;
            form.FromType = 3;
            form.ShowDialog();
        }
    }
}

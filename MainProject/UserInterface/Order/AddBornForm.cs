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
    public partial class AddBornForm : Form
    {
        public Int32 OrderInID { get; set; }

        public AddBornForm()
        {
            InitializeComponent();
        }

        public Int32 CorralCount(Int32 CorralID)
        {
            var Count = 0;
            foreach (DataGridViewRow row in this.dgvCowAdd.Rows)
            {
                if (CorralID == (Int32)row.Cells["colCorral"].Value)
                {
                    Count++;
                }
            }
            return Count;
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

            if (OrderInID > 0)
            {
                // TODO: This line of code loads data into the 'farmManageDataSet.Cow' table. You can move, or remove it, as needed.
                this.cowTableAdapter.Fill(this.farmManageDataSet.Cow);
                // TODO: This line of code loads data into the 'farmManageDataSet.BornView' table. You can move, or remove it, as needed.
                this.bornViewTableAdapter.FillByPK(this.farmManageDataSet.BornView, OrderInID);

                this.cbxBy.Enabled = false;
                this.dtpDate.Enabled = false;
                this.tbxDescription.ReadOnly = true;

                this.mTitle.Text = "รายละเอียกการเกิด";
                this.btnSave.Visible = false;
                this.btnClose.Text = "ปิด";

                this.tcSecond.TabPages.Remove(this.tabCowAdd);
                if (!MainForm.User.SuperUser)
                {
                    this.tcMain.TabPages.Remove(this.tabRecord);
                }
                else
                {
                    this.userLogUC.FillEvent(TypeUtil.OrderIn, OrderInID.ToString());
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
            if (OrderInID > 0)
            {
                this.Validate();
                this.bornViewBindingSource.EndEdit();
                this.fKCowOrderIn1BindingSource.EndEdit();
                Int32 result = this.bornViewTableAdapter.Update(this.farmManageDataSet.BornView);

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
                OrderInID = (int)this.bornViewTableAdapter.InsertQuery(
                    (byte?)2,
                    Convert.ToInt32(this.cbxBy.SelectedValue), 
                    this.dtpDate.Value, 
                    this.tbxDescription.Text);

                if (OrderInID > 0)
                {
                    var log = new UserLogTableAdapter();
                    log.Insert(TypeUtil.OrderIn, OrderInID.ToString(), MainForm.User.UserID, TypeUtil.EVENT_CREATE, DateTime.Now);


                    foreach (DataGridViewRow row in this.dgvCowAdd.Rows) 
                    { 
                        Int32 tCorralID = Convert.ToInt32(row.Cells["colCorral"].Value);
                        Int32 tGeneID = Convert.ToInt32(row.Cells["colGene"].Value);
                        Byte tSexlID = Convert.ToByte(row.Cells["colSex"].Value);
                        String tDesc = row.Cells["colDescription"].Value.ToString();
                        String CowNO = String.Format("{0:000}-{1:000}", OrderInID, Convert.ToInt32(row.Cells["colID"].Value));


                        CowNO = (String)this.cowTableAdapter.InsertQuery(
                            CowNO, 
                            tCorralID, 
                            tGeneID, 
                            tSexlID, 
                            tDesc,
                            OrderInID, 
                            0.0,
                            new Int32?(), 
                            new Double?());

                        if (CowNO != null)
                        {
                            log.Insert(TypeUtil.Cow, CowNO, MainForm.User.UserID, TypeUtil.EVENT_BORN, DateTime.Now);
                            this.corralTableAdapter.UpdateAddCurrent(1, tCorralID);
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
            var form = new AddCowOrderInForm();
            form.IsBorn = true;
            form.AddBorn = this;
            if (DialogResult.Yes == form.ShowDialog())
            {
                for (Int32 i = 0; i < form.Count; i++)
                {
                    this.dgvCowAdd.Rows.Add();
                    this.dgvCowAdd.Rows[this.dgvCowAdd.Rows.Count - 1].Cells["colID"].Value = this.dgvCowAdd.Rows.Count;
                    this.dgvCowAdd.Rows[this.dgvCowAdd.Rows.Count - 1].Cells["colCorral"].Value = form.CorralID;
                    this.dgvCowAdd.Rows[this.dgvCowAdd.Rows.Count - 1].Cells["colGene"].Value = form.GeneID;
                    this.dgvCowAdd.Rows[this.dgvCowAdd.Rows.Count - 1].Cells["colSex"].Value = form.SexID;
                    this.dgvCowAdd.Rows[this.dgvCowAdd.Rows.Count - 1].Cells["colDescription"].Value = String.Empty;
                }
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            this.dgvCowAdd.EndEdit();
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
            this.dgvCowAdd.EndEdit();
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
            form.FromID = OrderInID;
            form.FromType = 2;
            form.ShowDialog();
        }
    }
}

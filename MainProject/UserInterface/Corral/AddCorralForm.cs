using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using MainProject.Util;
using MainProject.Database.FarmManageDataSetTableAdapters;

namespace MainProject.UserInterface.Corral
{
    public partial class AddCorralForm : Form
    {
        public Int32 CorralID { get; set; }

        public AddCorralForm()
        {
            InitializeComponent();
        }

        private void AddCorralForm_Load(object sender, EventArgs e)
        {
            if (CorralID > 0)
            {
                this.Text = "แก้ไขคอก";
                this.lblTitle.Text = this.Text;
                this.corralTableAdapter.FillByPK(farmManageDataSet.Corral, CorralID);
            }
            else
            {
                this.corralBindingSource.AddNew();
                
                this.btnSave.Text = "เพิ่ม";
                this.tbxCurrent.Text = "0";
            }
            this.tbxCurrent.Enabled = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
                return;

            if (CorralID > 0)
            {
                this.Validate();
                this.corralBindingSource.EndEdit();
                var ResultId = this.corralTableAdapter.Update(farmManageDataSet.Corral);
                if (ResultId == 1)
                {
                    UserLogTableAdapter logTableAdapter = new UserLogTableAdapter();
                    logTableAdapter.Insert(TypeUtil.Corral, CorralID.ToString(), MainForm.User.UserID, TypeUtil.EVENT_MODIFY, DateTime.Now);

                    DialogUtil.SaveSuccess();
                    this.DialogResult = DialogResult.Yes;
                }
                else
                {
                    DialogUtil.SaveError();
                    this.DialogResult = DialogResult.No;
                }
            }
            else
            {
                CorralID = (int)this.corralTableAdapter.InsertQuery(tbxName.Text.Trim(), Convert.ToInt32(tbxMax.Text), Convert.ToInt32(tbxCurrent.Text), tbxDescription.Text.Trim());
                if (CorralID > 0)
                {
                    UserLogTableAdapter logTableAdapter = new UserLogTableAdapter();
                    logTableAdapter.Insert(TypeUtil.Corral, CorralID.ToString(), MainForm.User.UserID, TypeUtil.EVENT_MODIFY, DateTime.Now);
                    
                    DialogUtil.AddSuccess();
                    this.DialogResult = DialogResult.Yes;
                }
                else
                {
                    DialogUtil.AddError();
                    this.DialogResult = DialogResult.No;
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
        }

        private void tbxName_Validating(object sender, CancelEventArgs e)
        {
            ValidatingUtil.Validating(tbxName, 0, e);
        }

        private void tbxMax_Validating(object sender, CancelEventArgs e)
        {
            ValidatingUtil.Validating(tbxName, Convert.ToInt32(tbxMax.Text.Trim()) < Convert.ToInt32(tbxCurrent.Text.Trim()), "จำนวนความจุต้องไม่ตำกว่าจำนวนปัจจุบัน", e);
        }

        private void tbxMax_KeyPress(object sender, KeyPressEventArgs e)
        {
            KeyPressUtil.Int(tbxMax, e);
        }

        private void tbxMax_KeyUp(object sender, KeyEventArgs e)
        {
            tbxMax.Text = tbxMax.Text.Trim().Length == 0 ? "0" : tbxMax.Text;
        }

        private void tbxName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

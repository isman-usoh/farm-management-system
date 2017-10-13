using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using MainProject.Util;
using MainProject.Database.FarmManageDataSetTableAdapters;

namespace MainProject.UserInterface.User
{
    public partial class ChangePassForm : Form
    {
        public Int32 UserID { get; set; }

        public ChangePassForm()
        {
            InitializeComponent();
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            if (!tbxPassword.Text.Trim().Equals(tbxConfirmPassword.Text.Trim()))
            {
                MessageBox.Show("รหัสผ่านไม่ตรงกัน, กรุณาลองใหม่อีกครั้ง", "รหัสผ่านไม่ตรงกัน", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                if (tbxPassword.Text.Trim().Length < 6)
                {
                    MessageBox.Show("รหัสผ่านสั้นเกินไป, กรุณาลองใหม่อีกครั้ง", "รหัสผ่านสั้นเกินไป", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            if (ValidateChildren())
            {
                usersBindingSource.EndEdit();
                if (1 == usersTableAdapter.Update(farmManageDataSet.Users))
                {
                    var log = new UserLogTableAdapter();
                    log.Insert(TypeUtil.User, UserID.ToString(), MainForm.User.UserID, TypeUtil.EVENT_CHANGE_PASSWORD, DateTime.Now);

                    DialogResult = DialogUtil.SaveSuccess();
                }
                else
                {
                    DialogResult = DialogUtil.SaveError();
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.No;
        }

        private void ChangePassForm_Load(object sender, EventArgs e)
        {
            usersTableAdapter.FillByPK(farmManageDataSet.Users, UserID);
        }

        private void tbxPassword_Validating(object sender, CancelEventArgs e)
        {
            if (tbxPassword.Text.Trim().Length < 6)
            {
                var tip = new ToolTip();
                tip.Show("จำเป็น ความยาวไม่น้อยว่า 6 ตัวอักษร", tbxPassword, 5000);
                e.Cancel = true;
            }
        }

        private void tbxConfirmPassword_Validating(object sender, CancelEventArgs e)
        {
            if (tbxConfirmPassword.Text.Trim().Length < 6)
            {
                var tip = new ToolTip();
                tip.Show("จำเป็น ความยาวไม่น้อยว่า 6 ตัวอักษร", tbxConfirmPassword, 5000);
                e.Cancel = true;
            }
        }
    }
}

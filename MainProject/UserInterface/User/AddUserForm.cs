using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using MainProject.Util;
using MainProject.Database;
using MainProject.Database.FarmManageDataSetTableAdapters;

namespace MainProject.UserInterface.User
{
    public partial class AddUserForm : Form
    {
        public AddUserForm()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            btnSave.Enabled = false;
            pnlContent.Enabled = false;
            Cursor = System.Windows.Forms.Cursors.WaitCursor;
            if (tbxUsername.Text.Length < 5)
            {
                btnSave.Enabled = true;
                pnlContent.Enabled = true;
                Cursor = System.Windows.Forms.Cursors.Default;
                MessageBox.Show("ชื่อผู้ใช้ 5 อักษรขึ้นไป กรุณาลองใหม่อีกครั้ง", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbxUsername.Focus();
                return;
            }

            int result = (int)usersTableAdapter.CheckUsername(tbxUsername.Text.Trim());
            if (result == 0)
            {
                if (!tbxPassword.Text.Trim().Equals(tbxConfirmPassword.Text.Trim()))
                {
                    btnSave.Enabled = true;
                    pnlContent.Enabled = true;
                    Cursor = System.Windows.Forms.Cursors.Default;
                    MessageBox.Show("รหัสผ่านไม่ตรงกัน, กรุณาลองใหม่อีกครั้ง", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    if (tbxPassword.Text.Trim().Length < 6)
                    {
                        btnSave.Enabled = true;
                        pnlContent.Enabled = true;
                        Cursor = System.Windows.Forms.Cursors.Default;
                        MessageBox.Show("รหัสผ่านสั้นเกินไป 6 ตัวอักษรขึ้นไป, กรุณาลองใหม่อีกครั้ง", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }

                int UserID = (int)usersTableAdapter.InsertQuery(tbxUsername.Text.Trim(),
                    tbxPassword.Text.Trim(),
                    Convert.ToByte(cbxPrename.SelectedValue),
                    tbxFirstname.Text.Trim(),
                    tbxLastname.Text.Trim(),
                    chkSuperUser.Checked,
                    chkEnable.Checked,
                    tbxEmail.Text.Trim(),
                    tbxTel.Text.Trim());
                if (UserID > 0)
                {
                    UserLogTableAdapter logTableAdapter = new UserLogTableAdapter();
                    logTableAdapter.Insert(TypeUtil.User, UserID.ToString(), MainForm.User.UserID, TypeUtil.EVENT_CREATE, DateTime.Now);

                    DialogUtil.SaveSuccess();
                    DialogResult = System.Windows.Forms.DialogResult.Yes;
                }
                else
                {
                    DialogUtil.SaveError();
                    DialogResult = System.Windows.Forms.DialogResult.No;
                }
            }
            else
            {
                btnSave.Enabled = true;
                pnlContent.Enabled = true;
                Cursor = System.Windows.Forms.Cursors.Default;
                MessageBox.Show("ไม่สามารถใช้ชื่อผู้ใช้นี้ กรุณาลองใหม่อีกครั้ง", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbxUsername.Focus();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.No;
        }

        private void AddUserForm_Load(object sender, EventArgs e)
        {
            cbxPrename.ValueMember = "Key";
            cbxPrename.DisplayMember = "Value";
            cbxPrename.DataSource = TypeUtil.Prename().ToList();
        }


        private void tbxUsername_Leave(object sender, EventArgs e)
        {
            int count = (int)usersTableAdapter.CheckUsername(tbxUsername.Text.ToLower().Trim());
            if (count != 0)
            {
                MessageBox.Show("ไม่สามารถใช้ชื่อผู้ใช้นี้ กรุณาลองใหม่อีกครั้ง", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbxUsername.Focus();
            }
        }


        private void tbxLastname_TextChanged(object sender, EventArgs e)
        {
        }

        private void cbxPrename_Validating(object sender, CancelEventArgs e)
        {
            if (cbxPrename.SelectedValue == null)
            {
                var tip = new ToolTip();
                tip.Show("จำเป็น", cbxPrename, 5000);
                e.Cancel = true;
            }
        }

        private void tbxFirstname_Validating(object sender, CancelEventArgs e)
        {
            if (tbxFirstname.Text.Length == 0)
            {
                var tip = new ToolTip();
                tip.Show("จำเป็น", tbxFirstname, 5000);
                e.Cancel = true;
            }
        }

        private void tbxLastname_Validating(object sender, CancelEventArgs e)
        {
            if (tbxLastname.Text.Length == 0)
            {
                var tip = new ToolTip();
                tip.Show("จำเป็น", tbxLastname, 5000);
                e.Cancel = true;
            }
        }
    }
}

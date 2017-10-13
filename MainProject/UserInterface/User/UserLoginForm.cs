using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using MainProject.Database.FarmManageDataSetTableAdapters;
using MainProject.Util;

namespace MainProject.UserInterface.User
{
    public partial class UserLoginForm : Form
    {
        public UserLoginForm()
        {
            InitializeComponent();
        }
        private void initalLogin()
        {
            pnlContent.Enabled = false;
            btnLogin.Enabled = false;

            var UsersTableAdapter = new UsersTableAdapter();
            var users = UsersTableAdapter.GetDataByUserLogIn(cbxUsername.Text.Trim().ToLower(), tbxPassword.Text.Trim().ToLower());

            if (users.Count == 0)
            {
                this.pnlContent.Enabled = true;
                this.btnLogin.Enabled = true;
                this.tbxPassword.Text = String.Empty;
                MessageBox.Show("ชื่อผู้ใช้หรือรหัสผ่านไม่ถูกต้อง", "ชื่อผู้ใช้หรือรหัสผ่านไม่ถูกต้อง", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                var list = Properties.Settings.Default.fUsernameList;

                var lists = list.Split('|');
                if (lists.Length > 0 && list.Trim().Length != 0)
                {
                    var result = string.Empty;
                    for (var i = 0; i < lists.Length; i++)
                    {
                        if (!cbxUsername.Text.Trim().Equals(lists[i]))
                        {
                            if (i == 0)
                            {
                                result += lists[i];
                            }
                            else
                            {
                                result += "|" + lists[i];
                            }
                        }
                    }

                    result = String.Format("{0}|{1}", cbxUsername.Text.Trim(), result);
                    Properties.Settings.Default.fUsernameList = result;
                    Properties.Settings.Default.Save();
                }
                else
                {
                    Properties.Settings.Default.fUsernameList = cbxUsername.Text;
                    Properties.Settings.Default.Save();
                }
                var log = new UserLogTableAdapter();
                log.Insert(TypeUtil.User, users[0].UserID.ToString(), users[0].UserID, TypeUtil.EVENT_USER_LOGIN, DateTime.Now);

                MainForm.User = users[0];
                DialogResult = System.Windows.Forms.DialogResult.Yes;
            }
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                initalLogin();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            AutoValidate = AutoValidate.Disable;
            DialogResult = System.Windows.Forms.DialogResult.No;
        }

        private void UserLoginForm_Load(object sender, EventArgs e)
        {
            var list = Properties.Settings.Default.fUsernameList;

            var lists = list.Trim().Split('|');
            if (lists.Length > 0 && list.Trim().Length != 0)
            {
                foreach (String username in lists)
                {
                    if (username.Trim().Length != 0)
                    {
                        cbxUsername.Items.Add(username);
                    }
                }
                cbxUsername.Items.Add("-------ล้างประวัติ------");
                cbxUsername.SelectedIndex = 0;
            }
        }

        private void cbxUsername_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxUsername.SelectedIndex == cbxUsername.Items.Count - 1)
            {
                var result = MessageBox.Show("คุณต้องการล้างข้อมูลจริงหรือไม่", "ล้างข้อมูล", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (result == System.Windows.Forms.DialogResult.OK)
                {
                    cbxUsername.Items.Clear();
                    Properties.Settings.Default.fUsernameList = string.Empty;
                    Properties.Settings.Default.Save();
                }
            }
        }

        private void tbxPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                initalLogin();
            }
        }

        private void cbxUsername_Validating(object sender, CancelEventArgs e)
        {
            if (cbxUsername.Text.Trim().Length < 5)
            {
                var tip = new ToolTip();
                tip.Show("จำเป็น 5 ตัวอักษรขึ้นไป", cbxUsername, 5000);
                e.Cancel = true;
            }
        }

        private void tbxPassword_Validating(object sender, CancelEventArgs e)
        {
            if (tbxPassword.Text.Trim().Length < 6)
            {
                var tip = new ToolTip();
                tip.Show("จำเป็น 6 ตัวอักษรขึ้นไป", tbxPassword, 5000);
                e.Cancel = true;
            }
        }
    }
}

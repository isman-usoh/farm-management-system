using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using MainProject.Util;
using MainProject.Database.FarmManageDataSetTableAdapters;

namespace MainProject.UserInterface.User
{
    public partial class UserDetailForm : Form
    {
        public Int32 UserID { get; set; }

        public UserDetailForm()
        {
            InitializeComponent();
        }
        private void UserDetailForm_Load(object sender, EventArgs e)
        {
            cbxPreneme.ValueMember = "Key";
            cbxPreneme.DisplayMember = "Value";
            cbxPreneme.DataSource = TypeUtil.Prename().ToList();



            if (!MainForm.User.SuperUser)
            {
                tcMain.TabPages.Remove(tabRecord);
            }
            else
            {
                userLogUC.FillEvent(TypeUtil.User, UserID.ToString());
            }
           

            chkSuperUser.Visible = MainForm.User.SuperUser;
            chkEnable.Visible = MainForm.User.SuperUser;

            this.usersTableAdapter.FillByPK(farmManageDataSet.Users, UserID);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            gxbDetail.Enabled = false;
            btnSave.Enabled = false;
            if (Validate())
            {
                usersBindingSource.EndEdit();
                if (1 == usersTableAdapter.Update(farmManageDataSet.Users))
                {
                    var log = new UserLogTableAdapter();
                    log.Insert(TypeUtil.User, UserID.ToString(), MainForm.User.UserID, TypeUtil.EVENT_MODIFY, DateTime.Now);

                    DialogResult = DialogUtil.SaveSuccess();
                }
                else
                {
                    DialogResult = DialogUtil.SaveError();
                }
            }
            else
            {
                gxbDetail.Enabled = true;
                btnSave.Enabled = true;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.No;
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            var form = new ChangePassForm();
            form.UserID = UserID;
            var result = form.ShowDialog();
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                usersTableAdapter.FillByPK(farmManageDataSet.Users, UserID);
            }
        }
    }
}

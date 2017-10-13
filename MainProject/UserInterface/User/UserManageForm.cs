using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace MainProject.UserInterface.User
{
    public partial class UserManageForm : Form
    {
        public UserManageForm()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            var form = new AddUserForm();
            var result = form.ShowDialog();
            if (DialogResult.Yes == result)
            {
                usersTableAdapter.Fill(farmManageDataSet.Users);
            }
        }

        private void UserManageForm_Load(object sender, EventArgs e)
        {
            usersTableAdapter.Fill(farmManageDataSet.Users);
        }

        private void dgvGrid_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }
            var form = new UserDetailForm();
            form.UserID = Convert.ToInt32(((DataRowView)usersBindingSource[e.RowIndex]).Row[0]);
            var result = form.ShowDialog();
            if (DialogResult.Yes == result)
            {
                usersTableAdapter.Fill(farmManageDataSet.Users);
            }
        }
    }
}

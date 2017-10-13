using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MainProject.Util;

namespace MainProject.UserInterface.Control
{
    public partial class UserLogUC : UserControl
    {
        public UserLogUC()
        {
            InitializeComponent();
        }

        private void UserLogUC_Load(object sender, EventArgs e)
        {
            this.colLogEvent.ValueMember = "Key";
            this.colLogEvent.DisplayMember = "Value";
            this.colLogEvent.DataSource = TypeUtil.Event().ToList();
        }

        public void FillEvent(String table, String PK) {
            this.usersViewTableAdapter.Fill(farmManageDataSet.UsersView);
            this.userLogTableAdapter.FillByEvent(this.farmManageDataSet.UserLog, table, PK);
        }
    }
}

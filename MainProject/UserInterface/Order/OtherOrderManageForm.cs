using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using MainProject.Database;

namespace MainProject.UserInterface.Order
{
    public partial class OtherOrderManageForm : Form
    {
        public OtherOrderManageForm()
        {
            InitializeComponent();
        }

        private void OtherOrderManageForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'farmManageDataSet.UsersView' table. You can move, or remove it, as needed.
            this.usersViewTableAdapter.Fill(this.farmManageDataSet.UsersView);
            // TODO: This line of code loads data into the 'farmManageDataSet.DeadView' table. You can move, or remove it, as needed.
            this.deadViewTableAdapter.Fill(this.farmManageDataSet.DeadView);
            // TODO: This line of code loads data into the 'farmManageDataSet.BornView' table. You can move, or remove it, as needed.
            this.bornViewTableAdapter.Fill(this.farmManageDataSet.BornView);
        }

        private void btnAddDead_Click(object sender, EventArgs e)
        {
            var form = new AddDeadForm();
            var result = form.ShowDialog();
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                this.deadViewTableAdapter.Fill(this.farmManageDataSet.DeadView);
            }
        }

        private void btnAddBorn_Click(object sender, EventArgs e)
        {
            var form = new AddBornForm();
            var result = form.ShowDialog();
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                this.bornViewTableAdapter.Fill(this.farmManageDataSet.BornView);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.No;
        }

        private void dgvIn_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }
            var form = new AddBornForm();
            form.OrderInID = ((this.bornViewBindingSource[e.RowIndex] as DataRowView).Row as FarmManageDataSet.BornViewRow).OrderInID;
            var result = form.ShowDialog();
            if (result == DialogResult.Yes)
            {
                this.bornViewTableAdapter.Fill(farmManageDataSet.BornView);
            }
        }

        private void dgvOut_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }
            var form = new AddDeadForm();
            form.OrderOutID = ((this.deadViewBindingSource[e.RowIndex] as DataRowView).Row as FarmManageDataSet.DeadViewRow).OrderOutID;
            var result = form.ShowDialog();
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                this.deadViewTableAdapter.Fill(farmManageDataSet.DeadView);
            }
        }

        
    }
}

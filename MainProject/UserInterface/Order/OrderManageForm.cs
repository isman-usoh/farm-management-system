using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using MainProject.Util;

namespace MainProject.UserInterface.Order
{
    public partial class OrderManageForm : Form
    {
        public OrderManageForm()
        {
            InitializeComponent();
        }

        private void OrderManageForm_Load(object sender, EventArgs e)
        {
            colOrderInType.ValueMember = "Key";
            colOrderInType.DisplayMember = "Value";
            colOrderInType.DataSource = TypeUtil.InOrderType().ToList();

            colOrderInPaymentStatus.ValueMember = "Key";
            colOrderInPaymentStatus.DisplayMember = "Value";
            colOrderInPaymentStatus.DataSource = TypeUtil.InPaymentStatus().ToList();


            colOrderOutType.ValueMember = "Key";
            colOrderOutType.DisplayMember = "Value";
            colOrderOutType.DataSource = TypeUtil.OutOrderType().ToList();

            colOrderOutPaymentStatus.ValueMember = "Key";
            colOrderOutPaymentStatus.DisplayMember = "Value";
            colOrderOutPaymentStatus.DataSource = TypeUtil.OutPaymentStatus().ToList();




            this.usersViewTableAdapter.Fill(this.farmManageDataSet.UsersView);
            this.customerViewTableAdapter.Fill(this.farmManageDataSet.CustomerView);
            this.orderOutTableAdapter.Fill(this.farmManageDataSet.OrderOut);
            this.orderInTableAdapter.Fill(this.farmManageDataSet.OrderIn);
        }

        private void btnAddOrderOut_Click(object sender, EventArgs e)
        {
            var form = new OrderOutWizardForm();
            var result = form.ShowDialog();
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                orderOutTableAdapter.Fill(farmManageDataSet.OrderOut);
            }
        }

        private void btnAddOrderIn_Click(object sender, EventArgs e)
        {
            var form = new OrderInWizardForm();
            var result = form.ShowDialog();
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                orderInTableAdapter.Fill(farmManageDataSet.OrderIn);
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
            var form = new InOrderForm();
            form.OrderInID = Convert.ToInt32(((DataRowView)orderInBindingSource[e.RowIndex]).Row["OrderInID"]);
            var result = form.ShowDialog();
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                orderInTableAdapter.Fill(farmManageDataSet.OrderIn);
            }
        }

        private void dgvOut_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }
            var form = new OutOrderForm();
            form.OrderOutID = Convert.ToInt32(((DataRowView)orderOutBindingSource[e.RowIndex]).Row["OrderOutID"]);
            var result = form.ShowDialog();
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                orderOutTableAdapter.Fill(farmManageDataSet.OrderOut);
            }
        }
    }
}

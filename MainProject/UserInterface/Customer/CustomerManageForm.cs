using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using MainProject.Util;

namespace MainProject.UserInterface.Customer
{
    public partial class CustomerManageForm : Form
    {
        public Boolean IsSelect = false;
        public String CustomerPID {get;set;}

        public CustomerManageForm()
        {
            InitializeComponent();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            var form = new AddCustomerForm();
            var result = form.ShowDialog();
            if (result == DialogResult.Yes)
            {
                DialogResult = System.Windows.Forms.DialogResult.Yes;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.No;
        }

        private void CustomerManageForm_Load(object sender, EventArgs e)
        {
            this.colCustomerPrename.DataSource = TypeUtil.Prename().ToList();
            this.colCustomerPrename.ValueMember = "Key";
            this.colCustomerPrename.DisplayMember = "Value";
            if (IsSelect)
            {
                this.btnNew.Visible = false;
            }
            this.customerTableAdapter.Fill(this.farmManageDataSet.Customer);
        }

        private void dgvGrid_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }
            if (IsSelect)
            {
                CustomerPID = ((DataRowView)customerBindingSource[e.RowIndex]).Row["CustomerPID"].ToString();
                DialogResult = System.Windows.Forms.DialogResult.Yes;
            }
            else
            {
                var form = new CustomerDetailForm();
                form.CustomerPID = ((DataRowView)customerBindingSource[e.RowIndex]).Row["CustomerPID"].ToString();
                var result = form.ShowDialog();
                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    customerTableAdapter.Fill(farmManageDataSet.Customer);
                }
            }
        }
    }
}

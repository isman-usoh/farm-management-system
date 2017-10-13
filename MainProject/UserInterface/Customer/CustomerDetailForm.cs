using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using MainProject.UserInterface.Order;
using MainProject.Util;
using MainProject.Database.FarmManageDataSetTableAdapters;

namespace MainProject.UserInterface.Customer
{
    public partial class CustomerDetailForm : Form
    {
        public String CustomerPID { get; set; }

        public CustomerDetailForm()
        {
            InitializeComponent();
        }

        private void CustomerDetailForm_Load(object sender, EventArgs e)
        {
            this.cityTableAdapter.Fill(this.farmManageDataSet.City);
            this.postCodeTableAdapter.Fill(this.farmManageDataSet.PostCode);
            this.districtTableAdapter.Fill(this.farmManageDataSet.District);
            this.provinceTableAdapter.Fill(this.farmManageDataSet.Province);

            cbxPrename.ValueMember = "Key";
            cbxPrename.DisplayMember = "Value";
            cbxPrename.DataSource = TypeUtil.Prename().ToList();

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
            colOrderOutPaymentStatus.DataSource = TypeUtil.InPaymentStatus().ToList();

            colBankType.ValueMember = "Key";
            colBankType.DisplayMember = "Value";
            colBankType.DataSource = TypeUtil.AccountType().ToList();




            if (!MainForm.User.SuperUser)
            {
                tcMain.TabPages.Remove(tabLog);
            }
            else
            {
                this.userLogUC.FillEvent(TypeUtil.Customer, CustomerPID);
            }

            this.orderOutTableAdapter.Fill(this.farmManageDataSet.OrderOut);
            this.orderInTableAdapter.Fill(this.farmManageDataSet.OrderIn);
            this.bankAccountTableAdapter.Fill(this.farmManageDataSet.BankAccount);
            this.usersViewTableAdapter.Fill(this.farmManageDataSet.UsersView);
            this.userLogTableAdapter.Fill(this.farmManageDataSet.UserLog);
            this.postCodeTableAdapter.Fill(this.farmManageDataSet.PostCode);
            this.provinceTableAdapter.Fill(this.farmManageDataSet.Province);
            this.districtTableAdapter.Fill(this.farmManageDataSet.District);
            this.cityTableAdapter.Fill(this.farmManageDataSet.City);
            this.companyTableAdapter.Fill(this.farmManageDataSet.Company);


            this.customerTableAdapter.FillByPK(this.farmManageDataSet.Customer, CustomerPID);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.No;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                tcMain.Enabled = false;
                btnSave.Enabled = false;
                customerBindingSource.EndEdit();
                if (1 == customerTableAdapter.Update(farmManageDataSet.Customer))
                {
                    var log = new UserLogTableAdapter();
                    log.Insert(TypeUtil.Customer, CustomerPID, MainForm.User.UserID, TypeUtil.EVENT_MODIFY, DateTime.Now);
                }
                DialogResult = DialogUtil.SaveSuccess();
            }
        }

        private void dgvOrderIn_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }
            var form = new InOrderForm();
            form.OrderInID = Convert.ToInt32(((DataRowView)fKorderincustomer2BindingSource[e.RowIndex]).Row[0]);
            var result = form.ShowDialog();
            if (DialogResult.Yes == result)
            {
                orderInTableAdapter.Fill(farmManageDataSet.OrderIn);
            }
        }

        private void dgvOrderOut_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }
            var form = new OutOrderForm();
            form.OrderOutID = Convert.ToInt32(((DataRowView)fKorderoutcustomer2BindingSource[e.RowIndex]).Row[0]);
            var result = form.ShowDialog();
            if (DialogResult.Yes == result)
            {
                orderOutTableAdapter.Fill(farmManageDataSet.OrderOut);
            }
        }


        private void tbx_Validating(object sender, CancelEventArgs e)
        {
            ValidatingUtil.Validating((TextBox)sender, ((TextBox)sender).Text.Trim().Length == 0, e);
        }

        private void cbxText_Validating(object sender, CancelEventArgs e)
        {
            ValidatingUtil.Validating((ComboBox)sender, ((ComboBox)sender).Text.Trim().Length == 0, e);
        }

        private void cbx_Validating(object sender, CancelEventArgs e)
        {
            ValidatingUtil.Validating((ComboBox)sender, ((ComboBox)sender).SelectedValue == null, e);
        }

        private void tbxPhoneNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            KeyPressUtil.PhoneNumber(((TextBox)sender).Text, e);
        }

        private void btnNewOrderIn_Click(object sender, EventArgs e)
        {
            var form = new OrderInWizardForm();
            form.CustomerPID = CustomerPID;
            if (DialogResult.Yes == form.ShowDialog())
            {
                tcMain.SelectedTab = tabOrder;
            }
        }

        private void btnNewOrderOut_Click(object sender, EventArgs e)
        {
            var form = new OrderOutWizardForm();
            form.CustomerPID = CustomerPID;
            if (DialogResult.Yes == form.ShowDialog())
            {
                tcMain.SelectedTab = tabOrder;
            }
        }

        private void btnClearCompany_Click(object sender, EventArgs e)
        {

        }

        private void btnAddCompany_Click(object sender, EventArgs e)
        {
            var dialog = new AddCompanyForm();
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.Yes)
            {
                this.companyTableAdapter.Fill(this.farmManageDataSet.Company);
            }
        }
    }
}

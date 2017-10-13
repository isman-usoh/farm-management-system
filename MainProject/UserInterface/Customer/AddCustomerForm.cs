using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using MainProject.Database.FarmManageDataSetTableAdapters;
using MainProject.Util;

namespace MainProject.UserInterface.Customer
{
    public partial class AddCustomerForm : Form
    {
        private CustomerTableAdapter customerTableAdapter = new CustomerTableAdapter();
        
        public AddCustomerForm()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren())
            {
                return;
            }

            String CustomerPID = (String)customerTableAdapter.InsertQuery(
                tbxPID.Text,
                Convert.ToByte(cbxPrename.SelectedValue),
                tbxfName.Text,
                tbxlName.Text,
                cbxCompany.SelectedValue == null ? new Int32?() : Convert.ToInt32(cbxCompany.SelectedValue),
                tbxAddress.Text,
                tbxStreed.Text,
                tbxPhone.Text,
                tbxMobile.Text,
                cbxCityID.SelectedValue == null ? new Int32?() : Convert.ToInt32(cbxCityID.SelectedValue),
                cbxDistrictID.SelectedValue == null ? new Int32?() : Convert.ToInt32(cbxDistrictID.SelectedValue),
                cbxProvinceID.SelectedValue == null ? new Int32?() : Convert.ToInt32(cbxProvinceID.SelectedValue),
                cbxPostCode.SelectedValue == null ? new Int32?() : Convert.ToInt32(cbxPostCode.SelectedValue));

            if (CustomerPID != null)
            {
                UserLogTableAdapter logTableAdapter = new UserLogTableAdapter();
                logTableAdapter.Insert(TypeUtil.Customer, CustomerPID, MainForm.User.UserID, TypeUtil.EVENT_CREATE, DateTime.Now);

                DialogResult = DialogUtil.AddSuccess();
            }
            else
            {
                DialogResult = DialogUtil.AddError();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.No;
        }

        private void AddCustomerForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'farmManageDataSet.PostCode' table. You can move, or remove it, as needed.
            this.postCodeTableAdapter.Fill(this.farmManageDataSet.PostCode);
            // TODO: This line of code loads data into the 'farmManageDataSet.City' table. You can move, or remove it, as needed.
            this.cityTableAdapter.Fill(this.farmManageDataSet.City);
            // TODO: This line of code loads data into the 'farmManageDataSet.District' table. You can move, or remove it, as needed.
            this.districtTableAdapter.Fill(this.farmManageDataSet.District);
            // TODO: This line of code loads data into the 'farmManageDataSet.Province' table. You can move, or remove it, as needed.
            this.provinceTableAdapter.Fill(this.farmManageDataSet.Province);
            this.companyTableAdapter.Fill(this.farmManageDataSet.Company);
            this.provinceTableAdapter.Fill(this.farmManageDataSet.Province);

            this.cbxPrename.DataSource = TypeUtil.Prename().ToList();
            this.initPanel(false);
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

        private void btnAddCompany_Click(object sender, EventArgs e)
        {
            var dialog = new AddCompanyForm();
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.Yes)
            {
                this.companyTableAdapter.Fill(this.farmManageDataSet.Company);
            }
        }

        private void btnClearCompany_Click(object sender, EventArgs e)
        {

        }

        private void btnCheckPID_Click(object sender, EventArgs e)
        {
            int? result = customerTableAdapter.CheckCustomerPID(tbxPID.Text.Trim());
            if (result != null && result.Value > 0)
            {
                MessageBox.Show("มีลูกค้านี้แล้ว กรุณาลองใหม่อีกครั้ง");
                initPanel(false);
            }
            else
            {
                initPanel(true);
            }  
        }

        private void btnClearPID_Click(object sender, EventArgs e)
        {
            initPanel(false);
        }

        private void initPanel(Boolean isAllow)
        {
            if (isAllow)
            {
                tbxPID.Enabled = false;
                btnCheckPID.Enabled = false;
                btnClearPID.Enabled = true;

                cbxPrename.Enabled = true;
                tbxfName.Enabled = true;
                tbxlName.Enabled = true;
                cbxCompany.Enabled = true;
                btnAddCompany.Enabled = true;
                btnClearCompany.Enabled = true;

                tbxAddress.Enabled = true;
                tbxStreed.Enabled = true;
                cbxCityID.Enabled = true;
                cbxDistrictID.Enabled = true;
                cbxProvinceID.Enabled = true;
                cbxPostCode.Enabled = true;

                tbxPhone.Enabled = true;
                tbxMobile.Enabled = true;

                btnSave.Enabled = true;
            }
            else
            {
                tbxPID.Enabled = true;
                btnCheckPID.Enabled = true;
                btnClearPID.Enabled = false;

                cbxPrename.Enabled = false;
                tbxfName.Enabled = false;
                tbxlName.Enabled = false;
                cbxCompany.Enabled = false;
                btnAddCompany.Enabled = false;
                btnClearCompany.Enabled = false;

                tbxAddress.Enabled = false;
                tbxStreed.Enabled = false;
                cbxCityID.Enabled = false;
                cbxDistrictID.Enabled = false;
                cbxProvinceID.Enabled = false;
                cbxPostCode.Enabled = false;

                tbxPhone.Enabled = false;
                tbxMobile.Enabled = false;

                btnSave.Enabled = false;
            }
        }
    }
}

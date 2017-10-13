using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using MainProject.Util;
using MainProject.UserInterface.Cow;
using MainProject.UserInterface.Resource;
using MainProject.Database;
using MainProject.Database.FarmManageDataSetTableAdapters;

namespace MainProject.UserInterface.Order
{
    public partial class InOrderForm : Form
    {
        public Int32 OrderInID { get; set; }
        public Int32 CustomerID { get; set; }
        public InOrderForm()
        {
            InitializeComponent();
        }

        private void InOrderForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'farmManageDataSet.UsersView' table. You can move, or remove it, as needed.
            this.usersViewTableAdapter.Fill(this.farmManageDataSet.UsersView);
            this.cbxPrename.DataSource = TypeUtil.Prename().ToList();
            this.cbxOrderType.DataSource = TypeUtil.InOrderType().ToList();
            this.cbxBankType.DataSource = TypeUtil.AccountType().ToList();
            this.cbxPaymentType.DataSource = TypeUtil.InPaymentType().ToList();
            this.cbxPaymentStatus.DataSource = TypeUtil.InPaymentStatus().ToList();
            this.cbxTransportType.DataSource = TypeUtil.InTransportType().ToList();

            this.colCowSex.ValueMember = "Key";
            this.colCowSex.DisplayMember = "Value";
            this.colCowSex.DataSource = TypeUtil.CowSex().ToList();

            // TODO: This line of code loads data into the 'farmManageDataSet.Customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter.FillByOrderInID(this.farmManageDataSet.Customer, this.OrderInID);
            // TODO: This line of code loads data into the 'farmManageDataSet.PostCode' table. You can move, or remove it, as needed.
            this.postCodeTableAdapter.Fill(this.farmManageDataSet.PostCode);
            // TODO: This line of code loads data into the 'farmManageDataSet.City' table. You can move, or remove it, as needed.
            this.cityTableAdapter.Fill(this.farmManageDataSet.City);
            // TODO: This line of code loads data into the 'farmManageDataSet.District' table. You can move, or remove it, as needed.
            this.districtTableAdapter.Fill(this.farmManageDataSet.District);
            // TODO: This line of code loads data into the 'farmManageDataSet.Province' table. You can move, or remove it, as needed.
            this.provinceTableAdapter.Fill(this.farmManageDataSet.Province);
            // TODO: This line of code loads data into the 'farmManageDataSet.Company' table. You can move, or remove it, as needed.
            this.companyTableAdapter.Fill(this.farmManageDataSet.Company);
            // TODO: This line of code loads data into the 'farmManageDataSet.UsersView' table. You can move, or remove it, as needed.
            this.usersViewTableAdapter.Fill(this.farmManageDataSet.UsersView);
            // TODO: This line of code loads data into the 'farmManageDataSet.Province' table. You can move, or remove it, as needed.
            this.provinceTableAdapter.Fill(this.farmManageDataSet.Province);
            // TODO: This line of code loads data into the 'farmManageDataSet.BankAccount' table. You can move, or remove it, as needed.
            this.bankAccountTableAdapter.Fill(this.farmManageDataSet.BankAccount);
            // TODO: This line of code loads data into the 'farmManageDataSet.Gene' table. You can move, or remove it, as needed.
            this.geneTableAdapter.Fill(farmManageDataSet.Gene);
            // TODO: This line of code loads data into the 'farmManageDataSet.Corral' table. You can move, or remove it, as needed.
            this.corralTableAdapter.Fill(farmManageDataSet.Corral);
            // TODO: This line of code loads data into the 'farmManageDataSet.Cow' table. You can move, or remove it, as needed.
            this.cowTableAdapter.Fill(farmManageDataSet.Cow);
            // TODO: This line of code loads data into the 'farmManageDataSet.OrderIn' table. You can move, or remove it, as needed.
            this.orderInTableAdapter.FillByPK(farmManageDataSet.OrderIn, OrderInID);

            
            if (!MainForm.User.SuperUser)
            {
                this.tcMain.TabPages.Remove(this.tabRecord);
            }
            else
            {
                this.userLogUC.FillEvent(TypeUtil.OrderIn, OrderInID.ToString());
            }

            var CurrentRow = ((orderInBindingSource.Current as DataRowView).Row as FarmManageDataSet.OrderInRow);
            tbxTotalAmount.Text = (CurrentRow.TransportCost + CurrentRow.Amount).ToString("C2");
            switch (CurrentRow.PaymentStatus)
            {
                case 0:
                    this.cbxPaymentStatus.Enabled = true;
                    this.btnPrintBill.Enabled = false;
                    break;

                case 1:
                    this.cbxBankNO.Enabled = false;

                    this.cbxPaymentStatus.Enabled = false;
                    this.dtpPaymentDate.Enabled = false;
                    this.cbxPaymentBy.Enabled = false;
                    this.cbxPaymentType.Enabled = false;

                    this.btnSave.Visible = false;
                    this.btnCancel.Text = "ปิด";
                    this.btnPrintBill.Enabled = true;
                    break;
            }

            switch (CurrentRow.OrderType)
            {
                case 0:
                    break;
                case 1:
                    break;
                case 2:
                    this.Text = "รายละเอียดการคลอดลูก";
                    this.lblTitle.Text = "รายละเอียดการคลอดลูก";
                    this.tabCow.Text = "รายการคลอดลูก";
                    this.btnSave.Visible = false;
                    this.btnCancel.Text = "ปิด";
                    this.btnPrintBill.Enabled = true;
                    this.tcMain.TabPages.Remove(tabCustomer);
                    this.gbxPayment.Visible = false;
                    return;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            customerBindingSource.EndEdit();
            customerTableAdapter.Update(farmManageDataSet.Customer);
            orderInBindingSource.EndEdit();
            orderInTableAdapter.Update(farmManageDataSet.OrderIn);

            var userLogTableAdapter = new UserLogTableAdapter();
            userLogTableAdapter.Insert(TypeUtil.OrderIn, OrderInID.ToString(), MainForm.User.UserID, 1, DateTime.Now);

            DialogResult = DialogUtil.SaveSuccess();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.No;
        }
        private void btnPrintBill_Click(object sender, EventArgs e)
        {
            var form = new Report.ReceverBillForm();
            form.OrderInID = OrderInID;
            form.ShowDialog();
        }

        private void tbxNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            KeyPressUtil.Double((TextBox)sender, e);
        }
        private void cbxAccountNO_KeyPress(object sender, KeyPressEventArgs e)
        {
            KeyPressUtil.NumberCode(e);
        }

        private void tbxPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            KeyPressUtil.PhoneNumber(((TextBox)sender).Text, e);
        }

        private void cbxPaymentType_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (Convert.ToInt32(cbxPaymentType.SelectedValue))
            {
                case 0:
                case 2:
                    cbxBankNO.Enabled = false;
                    break;
                case 1:
                    cbxBankNO.Enabled = true;
                    break;
            }
        }

        private void cbxPaymentStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (Convert.ToByte(cbxPaymentStatus.SelectedValue))
            {
                case 0:
                    this.dtpPaymentDate.Enabled = false;
                    this.cbxPaymentBy.Enabled = false;
                    this.cbxPaymentBy.SelectedItem = null;
                    this.cbxPaymentType.Enabled = false;
                    this.cbxPaymentType.SelectedItem = null;

                    this.cbxBankNO.Enabled = false;
                    break;
                case 1:
                    this.dtpPaymentDate.Enabled = true;
                    this.cbxPaymentBy.Enabled = true;
                    this.cbxPaymentBy.SelectedValue = MainForm.User.UserID; ;
                    this.cbxPaymentType.Enabled = true;
                    this.cbxPaymentType.SelectedValue = (Byte)0;
                    break;
            }
        }

        private void cbx_Validating(object sender, CancelEventArgs e)
        {
            ValidatingUtil.Validating((ComboBox)sender, ((ComboBox)sender).SelectedValue == null, e);
        }

        private void tbx_Validating(object sender, CancelEventArgs e)
        {
            ValidatingUtil.Validating((TextBox)sender, ((TextBox)sender).Text.Trim().Length == 0, e);
        }

        private void cbxText_Validating(object sender, CancelEventArgs e)
        {
            ValidatingUtil.Validating((ComboBox)sender, ((ComboBox)sender).Text.Trim().Length == 0, e);
        }


        private void dataCowList_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }
            var form = new CowDetailForm();
            form.CowNO = ((DataRowView)fKCowOrderInBindingSource[e.RowIndex]).Row["CowNO"].ToString();
            var result = form.ShowDialog();
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                orderInTableAdapter.FillByPK(farmManageDataSet.OrderIn, OrderInID);
            }
        }


        private void btnResource_Click(object sender, EventArgs e)
        {
            var form = new ResourceExplorerForm();
            form.FromID = OrderInID;
            form.FromType = 0;
            form.ShowDialog();
        }
    }
}

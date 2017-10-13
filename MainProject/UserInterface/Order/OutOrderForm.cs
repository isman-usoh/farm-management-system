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
    public partial class OutOrderForm : Form
    {
        public Int32 OrderOutID { get; set; }
        public Int32 CustomerID { get; set; }

        public OutOrderForm()
        {
            InitializeComponent();

            cbxPrename.DataSource = TypeUtil.Prename().ToList();
            cbxOrderType.DataSource = TypeUtil.OutOrderType().ToList();
            cbxPaymentType.DataSource = TypeUtil.OutPaymentType().ToList();
            cbxPaymentStatus.DataSource = TypeUtil.OutPaymentStatus().ToList();
            cbxTransportType.DataSource = TypeUtil.OutTransportType().ToList();


            colCowSex.ValueMember = "Key";
            colCowSex.DisplayMember = "Value";
            colCowSex.DataSource = TypeUtil.CowSex().ToList();
        }

        private void OutOrderForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'farmManageDataSet.PostCode' table. You can move, or remove it, as needed.
            this.postCodeTableAdapter.Fill(this.farmManageDataSet.PostCode);
            // TODO: This line of code loads data into the 'farmManageDataSet.City' table. You can move, or remove it, as needed.
            this.cityTableAdapter.Fill(this.farmManageDataSet.City);
            // TODO: This line of code loads data into the 'farmManageDataSet.District' table. You can move, or remove it, as needed.
            this.districtTableAdapter.Fill(this.farmManageDataSet.District);
            // TODO: This line of code loads data into the 'farmManageDataSet.Province' table. You can move, or remove it, as needed.
            this.provinceTableAdapter.Fill(this.farmManageDataSet.Province);
            // TODO: This line of code loads data into the 'farmManageDataSet.Customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter.FillByOrderOutID(this.farmManageDataSet.Customer, this.OrderOutID);
            // TODO: This line of code loads data into the 'farmManageDataSet.UsersView' table. You can move, or remove it, as needed.
            this.usersViewTableAdapter.Fill(this.farmManageDataSet.UsersView);
            // TODO: This line of code loads data into the 'farmManageDataSet.Gene' table. You can move, or remove it, as needed.
            this.geneTableAdapter.Fill(this.farmManageDataSet.Gene);
            // TODO: This line of code loads data into the 'farmManageDataSet.Corral' table. You can move, or remove it, as needed.
            this.corralTableAdapter.Fill(this.farmManageDataSet.Corral);
            // TODO: This line of code loads data into the 'farmManageDataSet.Cow' table. You can move, or remove it, as needed.
            this.cowTableAdapter.Fill(this.farmManageDataSet.Cow);
            // TODO: This line of code loads data into the 'farmManageDataSet.OrderOut' table. You can move, or remove it, as needed.
            this.orderOutTableAdapter.FillByPK(this.farmManageDataSet.OrderOut, this.OrderOutID);




            this.cbxOrderType.Enabled = false;
            this.cbxTransportType.Enabled = false;
            this.cbxOrderBy.Enabled = false;
            this.dtpDate.Enabled = false;
            this.tbxAmount.ReadOnly = true;

            this.tbxTransportNO.ReadOnly = true;
            this.tbxTransportCost.ReadOnly = true;
            this.tbxTransportIssueBy.ReadOnly = true;


            if (!MainForm.User.SuperUser)
            {
                this.tcMain.TabPages.Remove(this.tabRecord);
            }
            else
            {
                this.userLogUC.FillEvent(TypeUtil.OrderOut, OrderOutID.ToString());
            }



            var CurrentRow = (FarmManageDataSet.OrderOutRow)((orderOutBindingSource.Current as DataRowView).Row);
            this.tbxTotalAmount.Text = (CurrentRow.TransportCost + CurrentRow.Amount).ToString("C2");

            switch (CurrentRow.PaymentStatus)
            {
                case 0:
                    if (CurrentRow.OrderType != 2)
                    {
                        this.cbxPaymentStatus.Enabled = true;
                        this.btnPrintBill.Enabled = false;
                    }
                    break;
                case 1:
                    if (CurrentRow.OrderType != 2)
                    {
                        this.cbxPaymentStatus.Enabled = false;
                        this.dtpPaymentDate.Enabled = false;
                        this.cbxPaymentBy.Enabled = false;
                        this.cbxPaymentType.Enabled = false;

                        this.btnSave.Visible = false;
                        this.btnCancel.Text = "ปิด";
                        this.btnPrintBill.Enabled = true;
                    }
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
                    this.tabCowList.Text = "รายการคลอดลูก";
                    this.btnSave.Visible = false;
                    this.btnCancel.Text = "ปิด";
                    this.btnPrintBill.Enabled = true;
                    this.tcMain.TabPages.Remove(tabCustomer);
                    this.gbxPayment.Visible = false;
                    return;
            }

            Double Earnings = 0, CowOrderInAmount = 0;
            foreach (DataGridViewRow vRow in this.dataCowList.Rows)
            {
                CowOrderInAmount += (Double)vRow.Cells["colCowOrderInAmount"].Value;
                Earnings += ((Double)vRow.Cells["colCowOrderOutAmount"].Value - (Double)vRow.Cells["colCowOrderInAmount"].Value);
            }
            tbxEr.Text = Earnings.ToString("C2");
            tbxOrderInAmount.Text = CowOrderInAmount.ToString("C2");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Convert.ToByte(cbxOrderType.SelectedValue);
            Convert.ToByte(cbxPaymentStatus.SelectedValue);

            orderOutBindingSource.EndEdit();
            orderOutTableAdapter.Update(farmManageDataSet.OrderOut);

            var log = new UserLogTableAdapter();
            log.Insert(TypeUtil.OrderOut, OrderOutID.ToString(), MainForm.User.UserID, 1, DateTime.Now);

            DialogResult = DialogUtil.SaveSuccess();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.No;
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

        private void tbxTransportCost_KeyPress(object sender, KeyPressEventArgs e)
        {
            KeyPressUtil.Double(tbxTransportCost, e);
        }

        private void tbxAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            KeyPressUtil.Double(tbxAmount, e);
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
            form.CowNO = ((DataRowView)fKCowOrderOutBindingSource[e.RowIndex]).Row["CowNO"].ToString();
            var result = form.ShowDialog();
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                orderOutTableAdapter.FillByPK(farmManageDataSet.OrderOut, OrderOutID);
            }
        }

        private void tbxNumber_KeyUp(object sender, KeyEventArgs e)
        {
            if (tbxTransportCost.Text.Trim().Length == 0)
            {
                tbxTransportCost.Text = "0";
            }
            if (tbxAmount.Text.Trim().Length == 0)
            {
                tbxAmount.Text = "0";
            }
        }

        private void btnPrintBill_Click(object sender, EventArgs e)
        {
            if (cbxPaymentStatus.SelectedValue == null)
            {
                MessageBox.Show("ไม่สามารถพิมท์รายการ เนื่องจากยังไม่ได้ชำระเงิน", "ข้อผิดผลาด", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var form = new Report.ReceiptBillForm();
            form.OrderOutID = OrderOutID;
            form.ShowDialog();
        }

        private void btnResource_Click(object sender, EventArgs e)
        {
            ResourceExplorerForm form = new ResourceExplorerForm();
            form.FromID = OrderOutID;
            form.FromType = 1;
            form.ShowDialog();
        }
    }
}

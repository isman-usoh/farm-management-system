using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using MainProject.Util;
using MainProject.UserInterface.Customer;
using MainProject.Database.FarmManageDataSetTableAdapters;

namespace MainProject.UserInterface.Order
{
    public partial class OrderOutWizardForm : Form
    {
        public String CustomerPID { get; set; }

        private Int32 Index = 0;
        private Boolean IsClose = false;

        private Int32 OrderBy = 0;
        private Byte OrderType = 0;
        private Byte TransportType = 0;
        private Byte Prename = 0;
        private Int32? Company = null;
        private Int32? Province = null;
        private Int32? District = null;
        private Int32? City = null;
        private Int32? PostCode = null;

        public String[] SelectCow()
        {
            var list = new List<String>();
            foreach (DataGridViewRow row in dgvCow.Rows)
            {
                list.Add(row.Cells["colCowNO"].Value.ToString());
            }
            return list.ToArray();
        }

        public OrderOutWizardForm()
        {
            InitializeComponent();
        }

        private void initialWizard()
        {
            tcMain.TabPages.Clear();
            switch (Index)
            {
                case 0:
                    btnBack.Enabled = false;
                    btnNext.Text = "ถัดไป";
                    lblWelcome.BorderStyle = BorderStyle.FixedSingle;
                    lblCow.BorderStyle = BorderStyle.None;
                    tcMain.TabPages.Add(tabWelcome);
                    break;
                case 1:
                    btnBack.Enabled = true;
                    btnNext.Text = "ถัดไป";
                    btnNext.Enabled = dgvCow.Rows.Count == 0 ? false : true;
                    lblWelcome.BorderStyle = BorderStyle.None;
                    lblCow.BorderStyle = BorderStyle.FixedSingle;
                    lblCustomer.BorderStyle = BorderStyle.None;
                    tcMain.TabPages.Add(tabCow);
                    break;
                case 2:
                    btnBack.Enabled = true;
                    btnNext.Text = "ถัดไป";
                    lblCow.BorderStyle = BorderStyle.None;
                    lblCustomer.BorderStyle = BorderStyle.FixedSingle;
                    lblOrderIn.BorderStyle = BorderStyle.None;
                    tcMain.TabPages.Add(tabCustomer);
                    break;
                case 3:
                    btnBack.Enabled = true;
                    btnNext.Text = "ถัดไป";
                    lblCustomer.BorderStyle = BorderStyle.None;
                    lblOrderIn.BorderStyle = BorderStyle.FixedSingle;
                    lblPayment.BorderStyle = BorderStyle.None;
                    tcMain.TabPages.Add(tabOrderOut);


                    tbxAmount.Text = CalculateAmount().ToString();
                    break;
                case 4:
                    btnBack.Enabled = true;
                    btnNext.Text = "บันทึก";
                    lblOrderIn.BorderStyle = BorderStyle.None;
                    lblPayment.BorderStyle = BorderStyle.FixedSingle;
                    lblFinish.BorderStyle = BorderStyle.None;
                    tcMain.TabPages.Add(tabPayment);
                    break;
                case 5:
                    btnBack.Enabled = false;
                    btnNext.Text = "เสร็จสิ้น";
                    lblPayment.BorderStyle = BorderStyle.None;
                    lblFinish.BorderStyle = BorderStyle.FixedSingle;
                    tcMain.TabPages.Add(tabFinish);
                    break;
                case 6:
                    IsClose = true;
                    Close();
                    break;
            }
        }

        private Double CalculateAmount()
        {
            Double amount = 0;
            foreach (DataGridViewRow row in dgvCow.Rows)
            {
                amount += Convert.ToDouble(row.Cells["colCowOrderOutAmount"].Value);
            }
            return amount;
        }

        public Int32 CorralCount(Int32 CorralID)
        {
            var Count = 0;
            foreach (DataGridViewRow row in dgvCow.Rows)
            {
                if (CorralID == (Int32)row.Cells["colCowCorral"].Value)
                {
                    Count++;
                }
            }
            return Count;
        }
        private void OrderOutWizardForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'farmManageDataSet.Province' table. You can move, or remove it, as needed.
            this.provinceTableAdapter.Fill(this.farmManageDataSet.Province);
            this.cityTableAdapter.Fill(this.farmManageDataSet.City);
            this.districtTableAdapter.Fill(this.farmManageDataSet.District);
            this.postCodeTableAdapter.Fill(this.farmManageDataSet.PostCode);
            this.companyTableAdapter.Fill(this.farmManageDataSet.Company);
            this.usersViewTableAdapter.Fill(farmManageDataSet.UsersView);
            this.stockTableAdapter.Fill(farmManageDataSet.Stock);
            this.corralTableAdapter.Fill(farmManageDataSet.Corral);
            this.geneTableAdapter.Fill(farmManageDataSet.Gene);

            if (CustomerPID != null)
            {
                this.customerTableAdapter.FillByPK(farmManageDataSet.Customer, CustomerPID);
                rdoSelectCustomer.Checked = true;
                rdoSelectCustomer.Enabled = false;
                rdoNewCustomer.Enabled = false;
                btnSelectCustomer.Enabled = false;
            }


            colCowSex.ValueMember = "Key";
            colCowSex.DisplayMember = "Value";
            colCowSex.DataSource = TypeUtil.CowSex().ToList();

            cbxPrename.ValueMember = "Key";
            cbxPrename.DisplayMember = "Value";
            cbxPrename.DataSource = TypeUtil.Prename().ToList();

            cbxOrderType.ValueMember = "Key";
            cbxOrderType.DisplayMember = "Value";
            cbxOrderType.DataSource = TypeUtil.OutOrderTypeWithoutDead().ToList();

            cbxTransportType.ValueMember = "Key";
            cbxTransportType.DisplayMember = "Value";
            cbxTransportType.DataSource = TypeUtil.OutTransportType().ToList();

            cbxPaymentStatus.ValueMember = "Key";
            cbxPaymentStatus.DisplayMember = "Value";
            cbxPaymentStatus.DataSource = TypeUtil.OutPaymentStatus().ToList();

            cbxPaymentType.ValueMember = "Key";
            cbxPaymentType.DisplayMember = "Value";
            cbxPaymentType.DataSource = TypeUtil.OutPaymentType().ToList();



            dtpOrderDate.MaxDate = DateTime.Now;
            dtpPaymentDate.MaxDate = DateTime.Now;

            cbxOrderBy.SelectedValue = MainForm.User.UserID;
            cbxPaymentBy.SelectedValue = MainForm.User.UserID;
            initialWizard();
            initPanel(false);
        }

        private void OrderOutWizardForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!IsClose)
            {
                var result = MessageBox.Show("คุณต้องการยกเลิกตัวช่วยการซื้อโคใช้หรือไม่", "ยืนยัน", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    dgvCow.Rows.Clear();
                }
                else
                {
                    e.Cancel = true;
                }
            }
            else
            {
                dgvCow.Rows.Clear();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Index--;
            initialWizard();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (Index == 2)
            {
                Prename = Convert.ToByte(cbxPrename.SelectedValue);
                Company = cbxCompany.SelectedValue == null ? new Int32?() : Convert.ToInt32(cbxCompany.SelectedValue);
                Province = cbxProvince.SelectedValue == null ? new Int32?() : Convert.ToInt32(cbxProvince.SelectedValue);
                District = cbxDistrict.SelectedValue == null ? new Int32?() : Convert.ToInt32(cbxDistrict.SelectedValue);
                City = cbxCity.SelectedValue == null ? new Int32?() : Convert.ToInt32(cbxCity.SelectedValue);
                PostCode = cbxPostCode.SelectedValue == null ? new Int32?() : Convert.ToInt32(cbxPostCode.SelectedValue);
                
                if (!CustomerValidate())
                {
                    return;
                }
            }
            if (Index == 3)
            {
                OrderBy = Convert.ToInt32(cbxOrderBy.SelectedValue);
                OrderType = Convert.ToByte(cbxOrderType.SelectedValue);
                TransportType = Convert.ToByte(cbxTransportType.SelectedValue);
            }
            if (Index == 4)
            {
                SaveOrder();
            }

            Index++;
            initialWizard();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("คุณต้องการยกเลิกตัวช่วยการซื้อโคใช้หรือไม่", "ยืนยัน", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                IsClose = true;
                Close();
            }
        }


        private void SaveOrder()
        {
            int result = 0;
            if (CustomerPID == null)
            {
                CustomerPID = (String)customerTableAdapter.InsertQuery(
                    tbxCustomerPID.Text,
                    Prename,
                    tbxfName.Text,
                    tbxlName.Text,
                    Company,
                    tbxAddress.Text,
                    tbxStreed.Text,
                    tbxPhone.Text,
                    tbxMobile.Text,
                    City,
                    District,
                    Province,
                    PostCode);

                if (CustomerPID != null)
                {
                    result = 1;
                    UserLogTableAdapter logTableAdapter = new UserLogTableAdapter();
                    logTableAdapter.Insert(TypeUtil.Customer, CustomerPID, MainForm.User.UserID, 0, DateTime.Now);
                }
                else
                {
                    lblFinishHeader.Text = "ข้อผิดผลาด";
                    lblFinishDescription.Text = "พบข้อผิดผลาดในการบันทึกข้อมูลลูกค้า กรุณาลองใหม่อีกครั้ง";
                    Index = 3;
                    initialWizard();
                    return;
                }
            }

            var PaymentStatus = Convert.ToByte(cbxPaymentStatus.SelectedValue);
            var PaymentType = Convert.ToByte(cbxPaymentType.SelectedValue);

            int OrderOutID = (int)orderOutTableAdapter.InsertQuery(
                this.OrderType,
                this.CustomerPID,
                this.OrderBy,
                this.dtpOrderDate.Value,
                this.tbxNote.Text,
                this.TransportType,
                Convert.ToDouble(this.tbxTransportCost.Text),
                this.tbxTransportNO.Text,
                this.tbxTransportIssueBy.Text,
                Convert.ToDouble(this.tbxUnit.Text),
                Convert.ToDouble(this.tbxAmountPerUnit.Text),
                Convert.ToDouble(this.tbxAmount.Text),
                PaymentStatus,
                PaymentStatus == 0 ? new Byte?() : PaymentType,
                PaymentStatus == 0 ? new Int32?() : Convert.ToByte(this.cbxPaymentBy.SelectedValue),
                PaymentStatus == 0 ? new DateTime?() : this.dtpPaymentDate.Value);


            if ( OrderOutID > 0)
            {
                var log = new UserLogTableAdapter();
                log.Insert(TypeUtil.OrderOut, OrderOutID.ToString(), MainForm.User.UserID, 0, DateTime.Now);
                
                var cowTableAdapter = new CowTableAdapter();
                var OrderType = Convert.ToByte(cbxOrderType.SelectedValue);
                foreach (DataGridViewRow row in dgvCow.Rows)
                {
                    Double Amount = Convert.ToDouble(row.Cells["colCowOrderOutAmount"].Value);
                    result = cowTableAdapter.UpdateCowOrderOut(
                        OrderOutID, 
                        Amount, 
                        row.Cells["colCowNO"].Value.ToString());

                    if (result == 1)
                    {
                        log.Insert(TypeUtil.Cow, row.Cells["colCowNO"].Value.ToString(), MainForm.User.UserID, TypeUtil.EVENT_SELL, DateTime.Now);


                        corralTableAdapter.UpdateRemoveCurrent(1, Convert.ToInt32(row.Cells["colCowCorral"].Value));

                        lblFinishHeader.Text = "เสร็จสมบูรณ์";
                        lblFinishDescription.Text = "บันทึกการซื้อเสร็จสมบูรณ์";
                    }
                    else
                    {
                        lblFinishHeader.Text = "ข้อผิดผลาด";
                        lblFinishDescription.Text = "พบข้อผิดผลาดในการบันทึกข้อมูลการซื้อ";
                    }
                }
            }
            else
            {
                lblFinishHeader.Text = "ข้อผิดผลาด";
                lblFinishDescription.Text = "พบข้อผิดผลาดในการบันทึกข้อมูลการซื้อ";
                Index = 4;
                initialWizard();
                return;
            }
        }


        private void btnAddCow_Click(object sender, EventArgs e)
        {
            var form = new AddCowOrderOutForm();
            form.OrderOutWizard = this;
            var result = form.ShowDialog();
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                foreach (AddCowOrderOutForm.CowPoJo cow in form.Cows)
                {
                    dgvCow.Rows.Add();
                    dgvCow.Rows[dgvCow.Rows.Count - 1].Cells["colID"].Value = dgvCow.Rows.Count;
                    dgvCow.Rows[dgvCow.Rows.Count - 1].Cells["colCowNO"].Value = cow.NO;
                    dgvCow.Rows[dgvCow.Rows.Count - 1].Cells["colCowCorral"].Value = cow.CorralID;
                    dgvCow.Rows[dgvCow.Rows.Count - 1].Cells["colCowGene"].Value = cow.GeneID;
                    dgvCow.Rows[dgvCow.Rows.Count - 1].Cells["colCowSex"].Value = cow.SexID;
                    dgvCow.Rows[dgvCow.Rows.Count - 1].Cells["colCowProfitAmount"].Value = cow.OrderOutAmount - cow.OrderInAmount;
                    dgvCow.Rows[dgvCow.Rows.Count - 1].Cells["colCowOrderInAmount"].Value = cow.OrderInAmount;
                    dgvCow.Rows[dgvCow.Rows.Count - 1].Cells["colCowOrderOutAmount"].Value = cow.OrderOutAmount;
                }
            }
        }

        private void btnRemoveCow_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("คุณต้องการนำโคออกจากรายการใช้หรือไม่", "แจ้งเตือน", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.Yes)
            {
                var Count = 0;
                foreach (DataGridViewRow row in dgvCow.SelectedRows)
                {
                    dgvCow.Rows.Remove(row);
                    Count++;
                }
                MessageBox.Show(String.Format("นำโคออกจากรายการแล้ว {0} รายการ", Count), "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                foreach (DataGridViewRow row in dgvCow.Rows)
                {
                    row.Cells[0].Value = row.Index + 1;
                }
            }
        }

        private void btnRemoveAllCow_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("คุณต้องการนำโคทั้งหมดออกจากรายการใช้หรือไม่", "แจ้งเตือน", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.Yes)
            {
                dgvCow.Rows.Clear();
                MessageBox.Show("นำโคออกจากรายการหมดแล้ว", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }



        private void dgvCow_SelectionChanged(object sender, EventArgs e)
        {
            btnRemoveCow.Enabled = dgvCow.SelectedRows.Count > 0 ? true : false;
        }

        private void dgvCow_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            btnRemoveAllCow.Enabled = dgvCow.Rows.Count == 0 ? false : true;
            btnNext.Enabled = dgvCow.Rows.Count == 0 ? false : true;
        }

        private void dgvCow_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            btnRemoveAllCow.Enabled = dgvCow.Rows.Count == 0 ? false : true;
            btnNext.Enabled = dgvCow.Rows.Count == 0 ? false : true;
        }

        private void btnSelectCustomer_Click(object sender, EventArgs e)
        {
            var form = new CustomerManageForm();
            form.IsSelect = true;
            form.Text = "เลือกลูกค้าซื้อโค";
            form.lblTitle.Text = "เลือกลูกค้าซื้อโค";
            if (DialogResult.Yes == form.ShowDialog())
            {
                CustomerPID = form.CustomerPID;
                customerTableAdapter.FillByPK(farmManageDataSet.Customer, CustomerPID);
            }
        }

        private void rdoCustomer_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoNewCustomer.Checked)
            {
                CustomerPID = null;

                tbxfName.Text = String.Empty;
                tbxlName.Text = String.Empty;
                tbxAddress.Text = String.Empty;
                tbxStreed.Text = String.Empty;
                tbxPhone.Text = String.Empty;
                tbxMobile.Text = String.Empty;

                initPanel(false);
                tbxCustomerPID.Enabled = true;
                btnCheckPID.Enabled = true;
                btnSelectCustomer.Enabled = false;
            }
            else
            {
                initPanel(false);
                tbxCustomerPID.Enabled = false;
                btnCheckPID.Enabled = false;
                btnSelectCustomer.Enabled = true;
            }
        }

        private void tbxTransportCost_KeyUp(object sender, KeyEventArgs e)
        {
            if (tbxTransportCost.Text.Trim().Length == 0)
            {
                tbxTransportCost.Text = "0";
            }
        }

        private void tbxAmount_KeyUp(object sender, KeyEventArgs e)
        {
            if (tbxAmount.Text.Trim().Length == 0)
            {
                tbxAmount.Text = "0";
            }
        }

        private void tbxTransportCost_TextChanged(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            tb.Text = tb.Text.Trim().Length == 0 ? "0" : tb.Text;

            Double total = Convert.ToDouble(tbxAmount.Text) + Convert.ToDouble(tbxTransportCost.Text);
            tbxTotalAmount.Text = total.ToString();
        }

        private void tbxAmount_TextChanged(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            tb.Text = tb.Text.Trim().Length == 0 ? "0" : tb.Text;

            Double total = Convert.ToDouble(tbxAmount.Text);
            Double valuePerCow = total / dgvCow.Rows.Count;

            foreach (DataGridViewRow row in dgvCow.Rows)
            {
                row.Cells["colCowOrderOutAmount"].Value = valuePerCow;
                row.Cells["colCowProfitAmount"].Value = valuePerCow - Convert.ToDouble(row.Cells["colCowOrderInAmount"].Value.ToString());
            }
            tbxTotalAmount.Text = (total + Convert.ToDouble(tbxTransportCost.Text)).ToString();
        }

        private void tbxNumber_TextChanged(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            tb.Text = tb.Text.Trim().Length == 0 ? "0" : tb.Text;

            Double total = Convert.ToDouble(tbxUnit.Text) * Convert.ToDouble(tbxAmountPerUnit.Text);
            tbxAmount.Text = total.ToString();
        }

        private void tbxNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            KeyPressUtil.Double((TextBox)sender, e);
        }

        private void tbxTransportNO_KeyPress(object sender, KeyPressEventArgs e)
        {
            KeyPressUtil.Int((TextBox)sender, e);
        }

        private void cbxPaymentType_SelectedIndexChanged(object sender, EventArgs e)
        {
            Convert.ToInt32(cbxPaymentType.SelectedValue);
        }

        private void cbxPaymentStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Convert.ToInt32(cbxPaymentStatus.SelectedValue) == 0)
            {
                cbxPaymentType.Enabled = false;
                dtpPaymentDate.Enabled = false;
                cbxPaymentBy.Enabled = false;
            }
            else
            {
                cbxPaymentType.Enabled = true;
                dtpPaymentDate.Enabled = true;
                cbxPaymentBy.Enabled = true;

                cbxPaymentType_SelectedIndexChanged(sender, e);
            }
        }

        private double CellBeginValue = 0D;

        private void dgvCowAdd_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvCow.Columns["colCowOrderOutAmount"].Index == e.ColumnIndex)
            {
                try
                {
                    var value = Convert.ToDouble(dgvCow.Rows[e.RowIndex].Cells["colCowOrderOutAmount"].Value);
                    dgvCow.Rows[e.RowIndex].Cells["colCowOrderOutAmount"].Value = value;
                    dgvCow.Rows[e.RowIndex].Cells["colCowProfitAmount"].Value = value - Convert.ToDouble(dgvCow.Rows[e.RowIndex].Cells["colCowOrderInAmount"].Value);
                }
                catch
                {
                    MessageBox.Show("รับตัวเลขเท่านั้น");
                    dgvCow.Rows[e.RowIndex].Cells["colCowOrderOutAmount"].Value = CellBeginValue;
                }
            }
        }

        private void dgvCowAdd_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (dgvCow.Columns["colCowOrderOutAmount"].Index == e.ColumnIndex)
            {
                CellBeginValue = Convert.ToDouble(dgvCow.Rows[e.RowIndex].Cells["colCowOrderOutAmount"].Value);
                dgvCow.Rows[e.RowIndex].Cells["colCowOrderOutAmount"].Value = dgvCow.Rows[e.RowIndex].Cells["colCowOrderOutAmount"].Value + string.Empty;
            }
        }

        private void cbxOrderType_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbxUnit.Text = "0";
            tbxAmount.Text = "0";
            tbxAmountPerUnit.Text = "0";
            tbxNumber_TextChanged(tbxUnit, e);
            switch (Convert.ToByte(cbxOrderType.SelectedValue))
            {
                case 0:
                    tbxUnit.ReadOnly = true;
                    tbxAmountPerUnit.ReadOnly = true;
                    tbxAmount.ReadOnly = true;
                    break;
                case 1:
                    tbxUnit.ReadOnly = true;
                    tbxAmountPerUnit.ReadOnly = true;
                    tbxAmount.ReadOnly = false;
                    break;
                case 3:
                    foreach (DataGridViewRow row in dgvCow.Rows)
                    {
                        row.Cells["colCowOrderOutAmount"].Value = 0;
                        row.Cells["colCowProfitAmount"].Value = -1 * Convert.ToDouble(row.Cells["colCowOrderInAmount"].Value.ToString());
                    }
                    tbxUnit.ReadOnly = false;
                    tbxAmountPerUnit.ReadOnly = false;
                    tbxAmount.ReadOnly = true;
                    break;
            }
        }

        private Boolean CustomerValidate()
        {
            if (rdoSelectCustomer.Checked)
            {
                return true;
            }
            var result = true;
            if (tbxfName.Text.Trim().Length < 4)
            {
                var tip = new ToolTip();
                tip.Show("จำเป็น 4 ตัวขึ้นไป", tbxfName, 5000);
                result = false;
            }

            if (tbxlName.Text.Trim().Length < 4)
            {
                var tip = new ToolTip();
                tip.Show("จำเป็น 4 ตัวขึ้นไป", tbxlName, 5000);
                result = false;
            }

            if (tbxAddress.Text.Trim().Length < 4)
            {
                var tip = new ToolTip();
                tip.Show("จำเป็น 4 ตัวขึ้นไป", tbxAddress, 5000);
                result = false;
            }

            if (cbxCity.SelectedValue == null)
            {
                var tip = new ToolTip();
                tip.Show("จำเป็น", cbxCity);
                result = false;
            }

            if (cbxDistrict.SelectedValue == null)
            {
                var tip = new ToolTip();
                tip.Show("จำเป็น", cbxDistrict);
                result = false;
            }

            if (cbxProvince.SelectedValue == null)
            {
                var tip = new ToolTip();
                tip.Show("จำเป็น", cbxProvince);
                result = false;
            }

            if (cbxPostCode.SelectedValue == null)
            {
                var tip = new ToolTip();
                tip.Show("จำเป็น", cbxPostCode);
                result = false;
            }
            return result;
        }

        private void initPanel(Boolean isAllow)
        {
            if (isAllow)
            {
                tbxCustomerPID.Enabled = false;
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
                cbxCity.Enabled = true;
                cbxDistrict.Enabled = true;
                cbxProvince.Enabled = true;
                cbxPostCode.Enabled = true;

                tbxPhone.Enabled = true;
                tbxMobile.Enabled = true;
            }
            else
            {
                tbxCustomerPID.Enabled = true;
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
                cbxCity.Enabled = false;
                cbxDistrict.Enabled = false;
                cbxProvince.Enabled = false;
                cbxPostCode.Enabled = false;

                tbxPhone.Enabled = false;
                tbxMobile.Enabled = false;
            }
        }

        private void btnCheckPID_Click(object sender, EventArgs e)
        {
            int? result = customerTableAdapter.CheckCustomerPID(tbxCustomerPID.Text.Trim());
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
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using MainProject.Util;
using MainProject.UserInterface.Supplies;
using MainProject.UserInterface.Customer;
using MainProject.Database.FarmManageDataSetTableAdapters;
using System.Text;

namespace MainProject.UserInterface.Order
{
    public partial class OrderInWizardForm : Form
    {
        public String CustomerPID { get; set; }
        public Int32 OrderInID = 0;

        private Int32 Index = 0;
        private Boolean IsClose = false;



        private Byte OrderBy = 0;
        private Byte OrderType = 0;
        private Byte TransportType = 0;
        private Byte Prename = 0;

        private Int32? Company = null;
        private Int32? Province = null;
        private Int32? District = null;
        private Int32? City = null;
        private Int32? PostCode = null;

        public OrderInWizardForm()
        {
            InitializeComponent();

            colCowSex.ValueMember = "Key";
            colCowSex.DisplayMember = "Value";
            colCowSex.DataSource = TypeUtil.CowSex().ToList();

            cbxPrename.ValueMember = "Key";
            cbxPrename.DisplayMember = "Value";
            cbxPrename.DataSource = TypeUtil.Prename().ToList();

            cbxOrderType.ValueMember = "Key";
            cbxOrderType.DisplayMember = "Value";
            cbxOrderType.DataSource = TypeUtil.InOrderTypeWithoutBorn().ToList();

            cbxTransportType.ValueMember = "Key";
            cbxTransportType.DisplayMember = "Value";
            cbxTransportType.DataSource = TypeUtil.InTransportType().ToList();


            cbxPaymentStatus.ValueMember = "Key";
            cbxPaymentStatus.DisplayMember = "Value";
            cbxPaymentStatus.DataSource = TypeUtil.InPaymentStatus().ToList();

            cbxPaymentType.ValueMember = "Key";
            cbxPaymentType.DisplayMember = "Value";
            cbxPaymentType.DataSource = TypeUtil.InPaymentType().ToList();

            cbxBankType.ValueMember = "Key";
            cbxBankType.DisplayMember = "Value";
            cbxBankType.DataSource = TypeUtil.AccountType().ToList();
        }

        private void initialWizard()
        {
            tcMain.TabPages.Clear();
            switch (Index)
            {
                case 0:
                    btnBack.Enabled = false;
                    btnNext.Enabled = true;
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
                    lblVancein.BorderStyle = BorderStyle.None;
                    tcMain.TabPages.Add(tabCow);
                    break;
                case 2:
                    btnBack.Enabled = true;
                    btnNext.Text = "ถัดไป";
                    lblCow.BorderStyle = BorderStyle.None;
                    lblVancein.BorderStyle = BorderStyle.FixedSingle;
                    lblCustomer.BorderStyle = BorderStyle.None;
                    tcMain.TabPages.Add(tabVaccine);
                    break;
                case 3:
                    btnBack.Enabled = true;
                    btnNext.Text = "ถัดไป";
                    lblVancein.BorderStyle = BorderStyle.None;
                    lblCustomer.BorderStyle = BorderStyle.FixedSingle;
                    lblOrderIn.BorderStyle = BorderStyle.None;
                    tcMain.TabPages.Add(tabCustomer);
                    break;
                case 4:
                    btnBack.Enabled = true;
                    btnNext.Text = "ถัดไป";
                    lblCustomer.BorderStyle = BorderStyle.None;
                    lblOrderIn.BorderStyle = BorderStyle.FixedSingle;
                    lblPayment.BorderStyle = BorderStyle.None;
                    tcMain.TabPages.Add(tabOrderIn);
                    tbxAmount.Text = CalculateAmount().ToString();
                    break;
                case 5:
                    btnBack.Enabled = true;
                    btnNext.Text = "บันทึก";
                    lblOrderIn.BorderStyle = BorderStyle.None;
                    lblPayment.BorderStyle = BorderStyle.FixedSingle;
                    lblFinish.BorderStyle = BorderStyle.None;
                    tcMain.TabPages.Add(tabPayment);
                    break;
                case 6:
                    btnBack.Enabled = false;
                    btnNext.Text = "เสร็จสิ้น";
                    lblPayment.BorderStyle = BorderStyle.None;
                    lblFinish.BorderStyle = BorderStyle.FixedSingle;
                    tcMain.TabPages.Add(tabFinish);
                    break;
                case 7:
                    IsClose = true;
                    DialogResult = System.Windows.Forms.DialogResult.Yes;
                    break;
            }
        }

        private Double CalculateAmount()
        {
            Double amount = 0;
            foreach (DataGridViewRow row in this.dgvCow.Rows)
            {
                amount += Convert.ToDouble(row.Cells["colCowAmount"].Value);
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
        
        private void OrderInWizardForm_Load(object sender, EventArgs e)
        {
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
            this.usersViewTableAdapter.Fill(farmManageDataSet.UsersView);
            // TODO: This line of code loads data into the 'farmManageDataSet.Corral' table. You can move, or remove it, as needed.
            this.corralTableAdapter.Fill(farmManageDataSet.Corral);
            // TODO: This line of code loads data into the 'farmManageDataSet.Stock' table. You can move, or remove it, as needed.
            this.stockTableAdapter.Fill(farmManageDataSet.Stock);
            // TODO: This line of code loads data into the 'farmManageDataSet.Gene' table. You can move, or remove it, as needed.
            this.geneTableAdapter.Fill(farmManageDataSet.Gene);

            if (CustomerPID != null)
            {
                this.customerTableAdapter.FillByPK(farmManageDataSet.Customer, CustomerPID);
                this.rdoSelectCustomer.Checked = true;
                this.rdoSelectCustomer.Enabled = false;
                this.rdoNewCustomer.Enabled = false;
                this.btnSelectCustomer.Enabled = false;
            }

            this.dtpOrderDate.MaxDate = DateTime.Now;
            this.dtpPaymentDate.MaxDate = DateTime.Now;
            initialWizard();
            initPanel(false);
        }

        private void OrderInWizardForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!IsClose)
            {
                var result = MessageBox.Show("คุณต้องการยกเลิกตัวช่วยการซื้อโคใช้หรือไม่", "ยืนยัน", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    dgvCow.Rows.Clear();
                    dgvVaccine.Rows.Clear();
                }
                else
                {
                    e.Cancel = true;
                }
            }
            else
            {
                dgvCow.Rows.Clear();
                dgvVaccine.Rows.Clear();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Index--;
            initialWizard();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (Index == 3)
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
            if (Index == 4)
            {
                OrderBy = Convert.ToByte(cbxOrderBy.SelectedValue);
                OrderType = Convert.ToByte(cbxOrderType.SelectedValue);
                TransportType = Convert.ToByte(cbxTransportType.SelectedValue);
            }
            if (Index == 5)
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
            var Vaccines = new Dictionary<Int32, Double>();
            foreach (DataGridViewRow vRow in this.dgvVaccine.Rows)
            {
                var StockID = Convert.ToInt32(vRow.Cells["colVaccineStockID"].Value);
                var Unit = Convert.ToDouble(vRow.Cells["colVaccineUnit"].Value);
                if (Vaccines.ContainsKey(StockID))
                {
                    Vaccines[StockID] += Unit;
                }
                else
                {
                    Vaccines.Add(StockID, Unit);
                }
            }

            var Msg = new StringBuilder();
            foreach (KeyValuePair<Int32, Double> Vaccine in Vaccines)
            {
                Double? CurrentUnit = this.stockTableAdapter.QueryCurrentUnit(Vaccine.Key);
                if (CurrentUnit.Value < Vaccine.Value)
                {
                    Msg.Append(String.Format("{0} จำนวนปัจจุบัน:{1} จำนวนที่ต้องการ:{2}\n", stockTableAdapter.GetDataByPK(Vaccine.Key)[0].Name, CurrentUnit, Vaccine.Value));
                }
            }

            if (Msg.Length != 0)
            {
                MessageBox.Show(String.Format("พัสดุไม่พอ \n{0}\n กรุณาลองใหม่อีกครั้ง", Msg), "ข้อผิดผลาด", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            if (CustomerPID == null)
            {
                CustomerPID = (String)this.customerTableAdapter.InsertQuery(
                    this.tbxCustomerPID.Text,
                    this.Prename,
                    this.tbxfName.Text,
                    this.tbxlName.Text,
                    this.Company,
                    this.tbxAddress.Text,
                    this.tbxStreed.Text,
                    this.tbxPhone.Text,
                    this.tbxMobile.Text,
                    this.City,
                    this.District,
                    this.Province,
                    this.PostCode);

                if (CustomerPID != null)
                {
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


            int OrderInID = (int)this.orderInTableAdapter.InsertQuery(
                this.OrderBy,
                this.CustomerPID,
                this.OrderBy,
                this.dtpOrderDate.Value,
                null,
                this.TransportType,
                Convert.ToDouble(tbxTransportCost.Text),
                this.tbxTransportNO.Text,
                this.tbxTransportIssueBy.Text,
                Convert.ToDouble(this.tbxUnit.Text),
                Convert.ToDouble(this.tbxAmountPerUnit.Text),
                Convert.ToDouble(this.tbxAmount.Text),
                PaymentStatus,
                PaymentStatus == 0 ? new Byte?() : PaymentType,
                PaymentStatus == 0 ? new Int32?() : Convert.ToByte(this.cbxPaymentBy.SelectedValue),
                PaymentStatus == 0 ? new DateTime?() : dtpPaymentDate.Value,
                cbxBankNO.SelectedValue == null ? new Int32?() : Convert.ToInt32(cbxBankNO.SelectedValue));




            var stockRemoveListTableAdapter = new StockRemoveListTableAdapter();
            var stockRemoveTableAdapter = new StockRemoveTableAdapter();
            var vaccineTableAdapter = new VaccineTableAdapter();
            if (OrderInID > 0)
            {
                MessageBox.Show(OrderInID.ToString());
                var log = new UserLogTableAdapter();
                log.Insert(TypeUtil.OrderIn, OrderInID.ToString(), MainForm.User.UserID, 0, DateTime.Now);
               

                var CowTableAdapter = new CowTableAdapter();
                var CowCount = 0;
                foreach (DataGridViewRow row in dgvCow.Rows)
                {
                    String CowNO = String.Format("{0:000}-{1:000}", OrderInID, Convert.ToInt32(row.Cells["colCowID"].Value));
                    Double Amount = Convert.ToDouble(row.Cells["colCowAmount"].Value);

                    CowNO = (String)CowTableAdapter.InsertQuery(
                        CowNO,
                        Convert.ToInt32(row.Cells["colCowCorral"].Value),
                        Convert.ToInt32(row.Cells["colCowGene"].Value),
                        Convert.ToByte(row.Cells["colCowSex"].Value),
                        String.Empty,
                        OrderInID,
                        Amount,
                        new Int32?(),
                        new Double?());


                    if (CowNO != null)
                    {
                        log.Insert(TypeUtil.Cow, CowNO, MainForm.User.UserID, TypeUtil.EVENT_BUY, DateTime.Now);


                        this.corralTableAdapter.UpdateAddCurrent(1, Convert.ToInt32(row.Cells["colCowCorral"].Value));
                        foreach (DataGridViewRow vRow in this.dgvVaccine.Rows)
                        {
                            int VaccineID = (int)vaccineTableAdapter.InsertQuery((Int32)vRow.Cells["colVaccineByID"].Value, CowNO, (Int32)vRow.Cells["colVaccineStockID"].Value, (Double)vRow.Cells["colVaccineUnit"].Value, (DateTime)vRow.Cells["colVaccineDate"].Value);
                            if (VaccineID > 0)
                            {
                                log.Insert(TypeUtil.Vaccine, VaccineID.ToString(), MainForm.User.UserID, 0, DateTime.Now);
                                
                                this.stockTableAdapter.UpdateRemoveUnit((Double)vRow.Cells["colVaccineUnit"].Value, (Int32)vRow.Cells["colVaccineStockID"].Value);
                            }
                        }
                        CowCount++;
                    }
                }



                var StockRemoveID = 0;
                if (Vaccines.Count > 0)
                {
                    StockRemoveID = (int)stockRemoveTableAdapter.InsertQuery(
                        OrderBy,
                        this.dtpOrderDate.Value,
                        1, 
                        OrderInID.ToString());//1 เบิกการฉีดวัคซีน
                    log.Insert(TypeUtil.StockRemove, StockRemoveID.ToString(), MainForm.User.UserID, 0, DateTime.Now);
                }

                foreach (KeyValuePair<Int32,Double> Vaccine in Vaccines)
                {
                    stockRemoveListTableAdapter.Insert(StockRemoveID, Vaccine.Key, Vaccine.Value, null);
                }

                lblFinishHeader.Text = "เสร็จสมบูรณ์";
                lblFinishDescription.Text = "บันทึกการซื้อเสร็จสมบูรณ์";
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

        private void btnAddVaccine_Click(object sender, EventArgs e)
        {
            var form = new AddVaccineForm();
            form.Option = true;
            form.VaccineID = 0;
            var result = form.ShowDialog();
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                dgvVaccine.Rows.Add();
                dgvVaccine.Rows[dgvVaccine.Rows.Count - 1].Cells[0].Value = dgvVaccine.Rows.Count;
                dgvVaccine.Rows[dgvVaccine.Rows.Count - 1].Cells["colVaccineStockID"].Value = form.OptionStockID;
                dgvVaccine.Rows[dgvVaccine.Rows.Count - 1].Cells["colVaccineByID"].Value = form.OptionByID;
                dgvVaccine.Rows[dgvVaccine.Rows.Count - 1].Cells["colVaccineDate"].Value = form.OptionDate;
                dgvVaccine.Rows[dgvVaccine.Rows.Count - 1].Cells["colVaccineUnit"].Value = form.OptionUnit;
            }
        }

        private void btnRemoveVaccine_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvVaccine.SelectedRows)
            {
                dgvVaccine.Rows.Remove(row);
            }
        }

        private void btnRemoveAllVaccine_Click(object sender, EventArgs e)
        {
            dgvVaccine.Rows.Clear();
        }



        private void btnAddCow_Click(object sender, EventArgs e)
        {
            try{
                var form = new AddCowOrderInForm();
                form.OrderInWizard = this;
                var result = form.ShowDialog();
                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    for (var i = 0; i < form.Count; i++)
                    {
                        dgvCow.Rows.Add();
                        dgvCow.Rows[dgvCow.Rows.Count - 1].Cells["colCowID"].Value = dgvCow.Rows.Count;
                        dgvCow.Rows[dgvCow.Rows.Count - 1].Cells["colCowCorral"].Value = form.CorralID;
                        dgvCow.Rows[dgvCow.Rows.Count - 1].Cells["colCowGene"].Value = form.GeneID;
                        dgvCow.Rows[dgvCow.Rows.Count - 1].Cells["colCowSex"].Value = form.SexID;
                        dgvCow.Rows[dgvCow.Rows.Count - 1].Cells["colCowAmount"].Value = form.Amount;
                    }
                }
            }
            catch
            {
                MessageBox.Show("กรุณา เพิ่มคอกโคก่อน ทำการซื้อ", "ข้อผิดผลาด", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = System.Windows.Forms.DialogResult.No;
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

        private void dgvVaccine_SelectionChanged(object sender, EventArgs e)
        {
            btnRemoveVaccine.Enabled = dgvVaccine.SelectedRows.Count > 0 ? true : false;
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

        private void dgvVaccine_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            btnRemoveAllVaccine.Enabled = dgvVaccine.Rows.Count == 0 ? false : true;
        }

        private void dgvVaccine_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            btnRemoveAllVaccine.Enabled = dgvVaccine.Rows.Count == 0 ? false : true;
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
                row.Cells["colCowAmount"].Value = valuePerCow;
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
            var Type = Convert.ToInt32(cbxPaymentType.SelectedValue);
            switch (Type)
            {
                case 0:
                    this.bankAccountTableAdapter.FillByCustomerPID(farmManageDataSet.BankAccount, null);
                    cbxBankName.Enabled = false;
                    tbxBankBranch.Enabled = false;
                    tbxBankAccountName.Enabled = false;
                    cbxBankNO.Enabled = false;
                    cbxBankType.Enabled = false;
                    break;
                case 1:
                    if (CustomerPID != null)
                    {
                        this.bankAccountTableAdapter.FillByCustomerPID(this.farmManageDataSet.BankAccount, CustomerPID);
                    }
                    cbxBankName.Enabled = true;
                    tbxBankBranch.Enabled = true;
                    tbxBankAccountName.Enabled = true;
                    cbxBankNO.Enabled = true;
                    cbxBankType.Enabled = true;
                    break;
                case 2:
                    this.bankAccountTableAdapter.FillByCustomerPID(farmManageDataSet.BankAccount, null);
                    cbxBankName.Enabled = true;
                    tbxBankBranch.Enabled = false;
                    tbxBankAccountName.Enabled = false;
                    cbxBankNO.Enabled = false;
                    cbxBankType.Enabled = false;
                    break;
            }
        }

        private void cbxPaymentStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Convert.ToInt32(cbxPaymentStatus.SelectedValue) == 0)
            {
                cbxPaymentType.Enabled = false;
                dtpPaymentDate.Enabled = false;
                cbxPaymentBy.Enabled = false;
                cbxBankName.Enabled = false;
                cbxBankNO.Enabled = false;
                tbxBankBranch.Enabled = false;
                tbxBankAccountName.Enabled = false;
                cbxBankType.Enabled = false;
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
            if (dgvCow.Columns["colCowAmount"].Index  == e.ColumnIndex)
            {
                try
                {
                    var value = Convert.ToDouble(dgvCow.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
                    dgvCow.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = value;
                }
                catch
                {
                    MessageBox.Show("รับตัวเลขเท่านั้น");
                    dgvCow.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = CellBeginValue;
                }
            }
        }

        private void dgvCowAdd_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (dgvCow.Columns["colCowAmount"].Index == e.ColumnIndex)
            {
                CellBeginValue = Convert.ToDouble(dgvCow.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
                dgvCow.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = dgvCow.Rows[e.RowIndex].Cells[e.ColumnIndex].Value + string.Empty;
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
                        row.Cells["colCowAmount"].Value = 0;
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
                tip.Show("จำเป็น", cbxCity, 5000);
                result = false;
            }

            if (cbxDistrict.SelectedValue == null)
            {
                var tip = new ToolTip();
                tip.Show("จำเป็น", cbxDistrict, 5000);
                result = false;
            }

            if (cbxProvince.SelectedValue == null)
            {
                var tip = new ToolTip();
                tip.Show("จำเป็น", cbxProvince, 5000);
                result = false;
            }

            if (cbxPostCode.SelectedValue == null)
            {
                var tip = new ToolTip();
                tip.Show("จำเป็น", cbxPostCode, 5000);
                result = false;
            }
            return result;
        }

        private void tbxPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            KeyPressUtil.PhoneNumber(((TextBox)sender).Text, e);
        }

        private void cbxAccountNO_KeyPress(object sender, KeyPressEventArgs e)
        {
            KeyPressUtil.NumberCode(e);
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
                this.companyTableAdapter.Fill(farmManageDataSet.Company);
            }
        }

        private void btnClearCompany_Click(object sender, EventArgs e)
        {

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
    }
}

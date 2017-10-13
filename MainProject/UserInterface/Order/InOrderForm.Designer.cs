namespace MainProject.UserInterface.Order
{
    partial class InOrderForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlMain = new System.Windows.Forms.TableLayoutPanel();
            this.pnlFooter = new System.Windows.Forms.TableLayoutPanel();
            this.pnlLeftFooter = new System.Windows.Forms.FlowLayoutPanel();
            this.btnPrintBill = new System.Windows.Forms.Button();
            this.btnResource = new System.Windows.Forms.Button();
            this.pnlRightFooter = new System.Windows.Forms.FlowLayoutPanel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.tcMain = new System.Windows.Forms.TabControl();
            this.tabGeneral = new System.Windows.Forms.TabPage();
            this.pnlGeneralContent = new System.Windows.Forms.TableLayoutPanel();
            this.gbxPayment = new System.Windows.Forms.GroupBox();
            this.pnlPayment = new System.Windows.Forms.TableLayoutPanel();
            this.lblPaymentType = new System.Windows.Forms.Label();
            this.lblPaymentStatus = new System.Windows.Forms.Label();
            this.cbxPaymentType = new System.Windows.Forms.ComboBox();
            this.orderInBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.farmManageDataSet = new MainProject.Database.FarmManageDataSet();
            this.cbxPaymentStatus = new System.Windows.Forms.ComboBox();
            this.lblPaymentBy = new System.Windows.Forms.Label();
            this.lblPaymentDate = new System.Windows.Forms.Label();
            this.dtpPaymentDate = new System.Windows.Forms.DateTimePicker();
            this.cbxPaymentBy = new System.Windows.Forms.ComboBox();
            this.usersViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblAccountBank = new System.Windows.Forms.Label();
            this.cbxBankType = new System.Windows.Forms.ComboBox();
            this.bankAccountBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblAccountBranch = new System.Windows.Forms.Label();
            this.lblAccountType = new System.Windows.Forms.Label();
            this.cbxBankNO = new System.Windows.Forms.ComboBox();
            this.tbxBankAccountName = new System.Windows.Forms.TextBox();
            this.tbxBankBranch = new System.Windows.Forms.TextBox();
            this.tbxBankName = new System.Windows.Forms.TextBox();
            this.lblAccountNO = new System.Windows.Forms.Label();
            this.lblAccountName = new System.Windows.Forms.Label();
            this.gbxGeneral = new System.Windows.Forms.GroupBox();
            this.pnlGeneral = new System.Windows.Forms.TableLayoutPanel();
            this.cbxTransportType = new System.Windows.Forms.ComboBox();
            this.lblTransportCost = new System.Windows.Forms.Label();
            this.lblTransportType = new System.Windows.Forms.Label();
            this.lblTransportNO = new System.Windows.Forms.Label();
            this.lblTransportIssueBy = new System.Windows.Forms.Label();
            this.tbxTransportNO = new System.Windows.Forms.TextBox();
            this.tbxTransportIssueBy = new System.Windows.Forms.TextBox();
            this.lblAmount = new System.Windows.Forms.Label();
            this.tbxAmount = new System.Windows.Forms.TextBox();
            this.tbxTransportCost = new System.Windows.Forms.TextBox();
            this.lblNote = new System.Windows.Forms.Label();
            this.tbxNote = new System.Windows.Forms.TextBox();
            this.dtpOrderDate = new System.Windows.Forms.DateTimePicker();
            this.lblInOrderDate = new System.Windows.Forms.Label();
            this.lblOrderType = new System.Windows.Forms.Label();
            this.cbxOrderType = new System.Windows.Forms.ComboBox();
            this.lblCreateBy = new System.Windows.Forms.Label();
            this.cbxOrderBy = new System.Windows.Forms.ComboBox();
            this.tbxTotalAmount = new System.Windows.Forms.TextBox();
            this.lblTotalAmount = new System.Windows.Forms.Label();
            this.lblkilo = new System.Windows.Forms.Label();
            this.lblPerKilo = new System.Windows.Forms.Label();
            this.tbxWeight = new System.Windows.Forms.TextBox();
            this.tbxAmountPerUnit = new System.Windows.Forms.TextBox();
            this.tabCustomer = new System.Windows.Forms.TabPage();
            this.pnlCustomerContent = new System.Windows.Forms.TableLayoutPanel();
            this.gbxCustomer = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblfName = new System.Windows.Forms.Label();
            this.lbllName = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.tbxfName = new System.Windows.Forms.TextBox();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbxlName = new System.Windows.Forms.TextBox();
            this.tbxAddress = new System.Windows.Forms.TextBox();
            this.lblCompany = new System.Windows.Forms.Label();
            this.cbxProvince = new System.Windows.Forms.ComboBox();
            this.provinceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblProvince = new System.Windows.Forms.Label();
            this.lblDistrict = new System.Windows.Forms.Label();
            this.lblStreed = new System.Windows.Forms.Label();
            this.tbxStreed = new System.Windows.Forms.TextBox();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.tbxPhone = new System.Windows.Forms.TextBox();
            this.lblMobile = new System.Windows.Forms.Label();
            this.tbxMobile = new System.Windows.Forms.TextBox();
            this.lblPostCode = new System.Windows.Forms.Label();
            this.lblCountry = new System.Windows.Forms.Label();
            this.lblPrename = new System.Windows.Forms.Label();
            this.cbxPrename = new System.Windows.Forms.ComboBox();
            this.cbxCountryValue = new System.Windows.Forms.Label();
            this.cbxDistrict = new System.Windows.Forms.ComboBox();
            this.fKDistrictProvinceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbxCity = new System.Windows.Forms.ComboBox();
            this.fKCityDistrictBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbxPostCode = new System.Windows.Forms.ComboBox();
            this.fKPostCodeDistrictBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbxCompany = new System.Windows.Forms.ComboBox();
            this.companyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblCustomerPID = new System.Windows.Forms.Label();
            this.lblCustomerPIDValue = new System.Windows.Forms.Label();
            this.tabCow = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvCowList = new System.Windows.Forms.DataGridView();
            this.colCowNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCowCorral = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.corralBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colCowGene = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.geneBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colCowSex = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.colCowOrderInAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fKCowOrderInBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabRecord = new System.Windows.Forms.TabPage();
            this.pnlRecordContent = new System.Windows.Forms.TableLayoutPanel();
            this.userLogUC = new MainProject.UserInterface.Control.UserLogUC();
            this.orderInTableAdapter = new MainProject.Database.FarmManageDataSetTableAdapters.OrderInTableAdapter();
            this.geneTableAdapter = new MainProject.Database.FarmManageDataSetTableAdapters.GeneTableAdapter();
            this.corralTableAdapter = new MainProject.Database.FarmManageDataSetTableAdapters.CorralTableAdapter();
            this.cowTableAdapter = new MainProject.Database.FarmManageDataSetTableAdapters.CowTableAdapter();
            this.bankAccountTableAdapter = new MainProject.Database.FarmManageDataSetTableAdapters.BankAccountTableAdapter();
            this.companyTableAdapter = new MainProject.Database.FarmManageDataSetTableAdapters.CompanyTableAdapter();
            this.provinceTableAdapter = new MainProject.Database.FarmManageDataSetTableAdapters.ProvinceTableAdapter();
            this.districtTableAdapter = new MainProject.Database.FarmManageDataSetTableAdapters.DistrictTableAdapter();
            this.cityTableAdapter = new MainProject.Database.FarmManageDataSetTableAdapters.CityTableAdapter();
            this.postCodeTableAdapter = new MainProject.Database.FarmManageDataSetTableAdapters.PostCodeTableAdapter();
            this.customerTableAdapter = new MainProject.Database.FarmManageDataSetTableAdapters.CustomerTableAdapter();
            this.usersViewTableAdapter = new MainProject.Database.FarmManageDataSetTableAdapters.UsersViewTableAdapter();
            this.pnlMain.SuspendLayout();
            this.pnlFooter.SuspendLayout();
            this.pnlLeftFooter.SuspendLayout();
            this.pnlRightFooter.SuspendLayout();
            this.tcMain.SuspendLayout();
            this.tabGeneral.SuspendLayout();
            this.pnlGeneralContent.SuspendLayout();
            this.gbxPayment.SuspendLayout();
            this.pnlPayment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderInBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.farmManageDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankAccountBindingSource)).BeginInit();
            this.gbxGeneral.SuspendLayout();
            this.pnlGeneral.SuspendLayout();
            this.tabCustomer.SuspendLayout();
            this.pnlCustomerContent.SuspendLayout();
            this.gbxCustomer.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.provinceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKDistrictProvinceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKCityDistrictBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKPostCodeDistrictBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyBindingSource)).BeginInit();
            this.tabCow.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCowList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.corralBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.geneBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKCowOrderInBindingSource)).BeginInit();
            this.tabRecord.SuspendLayout();
            this.pnlRecordContent.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.ColumnCount = 1;
            this.pnlMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlMain.Controls.Add(this.pnlFooter, 0, 2);
            this.pnlMain.Controls.Add(this.lblTitle, 0, 0);
            this.pnlMain.Controls.Add(this.tcMain, 0, 1);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.RowCount = 3;
            this.pnlMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.pnlMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.pnlMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.pnlMain.Size = new System.Drawing.Size(694, 621);
            this.pnlMain.TabIndex = 0;
            // 
            // pnlFooter
            // 
            this.pnlFooter.ColumnCount = 2;
            this.pnlFooter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.pnlFooter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.pnlFooter.Controls.Add(this.pnlLeftFooter, 0, 0);
            this.pnlFooter.Controls.Add(this.pnlRightFooter, 1, 0);
            this.pnlFooter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFooter.Location = new System.Drawing.Point(0, 581);
            this.pnlFooter.Margin = new System.Windows.Forms.Padding(0);
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.RowCount = 1;
            this.pnlFooter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlFooter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.pnlFooter.Size = new System.Drawing.Size(694, 40);
            this.pnlFooter.TabIndex = 6;
            // 
            // pnlLeftFooter
            // 
            this.pnlLeftFooter.Controls.Add(this.btnPrintBill);
            this.pnlLeftFooter.Controls.Add(this.btnResource);
            this.pnlLeftFooter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlLeftFooter.Location = new System.Drawing.Point(3, 3);
            this.pnlLeftFooter.Name = "pnlLeftFooter";
            this.pnlLeftFooter.Padding = new System.Windows.Forms.Padding(3);
            this.pnlLeftFooter.Size = new System.Drawing.Size(341, 34);
            this.pnlLeftFooter.TabIndex = 0;
            // 
            // btnPrintBill
            // 
            this.btnPrintBill.Enabled = false;
            this.btnPrintBill.Location = new System.Drawing.Point(6, 6);
            this.btnPrintBill.Name = "btnPrintBill";
            this.btnPrintBill.Size = new System.Drawing.Size(80, 23);
            this.btnPrintBill.TabIndex = 1;
            this.btnPrintBill.Text = "พิมท์ใบเสร็จ";
            this.btnPrintBill.UseVisualStyleBackColor = true;
            this.btnPrintBill.Click += new System.EventHandler(this.btnPrintBill_Click);
            // 
            // btnResource
            // 
            this.btnResource.Location = new System.Drawing.Point(92, 6);
            this.btnResource.Name = "btnResource";
            this.btnResource.Size = new System.Drawing.Size(80, 23);
            this.btnResource.TabIndex = 4;
            this.btnResource.Text = "หลักฐาน";
            this.btnResource.UseVisualStyleBackColor = true;
            this.btnResource.Click += new System.EventHandler(this.btnResource_Click);
            // 
            // pnlRightFooter
            // 
            this.pnlRightFooter.Controls.Add(this.btnCancel);
            this.pnlRightFooter.Controls.Add(this.btnSave);
            this.pnlRightFooter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRightFooter.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.pnlRightFooter.Location = new System.Drawing.Point(350, 3);
            this.pnlRightFooter.Name = "pnlRightFooter";
            this.pnlRightFooter.Padding = new System.Windows.Forms.Padding(3);
            this.pnlRightFooter.Size = new System.Drawing.Size(341, 34);
            this.pnlRightFooter.TabIndex = 1;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(257, 6);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "ยกเลิก";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(176, 6);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "บันทึก";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.SystemColors.Window;
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lblTitle.Size = new System.Drawing.Size(694, 60);
            this.lblTitle.TabIndex = 3;
            this.lblTitle.Text = "รายละเอียดการซื้อ";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tcMain
            // 
            this.tcMain.Controls.Add(this.tabGeneral);
            this.tcMain.Controls.Add(this.tabCustomer);
            this.tcMain.Controls.Add(this.tabCow);
            this.tcMain.Controls.Add(this.tabRecord);
            this.tcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcMain.Location = new System.Drawing.Point(3, 63);
            this.tcMain.Name = "tcMain";
            this.tcMain.SelectedIndex = 0;
            this.tcMain.Size = new System.Drawing.Size(688, 515);
            this.tcMain.TabIndex = 5;
            // 
            // tabGeneral
            // 
            this.tabGeneral.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabGeneral.Controls.Add(this.pnlGeneralContent);
            this.tabGeneral.Location = new System.Drawing.Point(4, 22);
            this.tabGeneral.Name = "tabGeneral";
            this.tabGeneral.Padding = new System.Windows.Forms.Padding(3);
            this.tabGeneral.Size = new System.Drawing.Size(680, 489);
            this.tabGeneral.TabIndex = 0;
            this.tabGeneral.Text = "ข้อมูลทั้วไป";
            // 
            // pnlGeneralContent
            // 
            this.pnlGeneralContent.ColumnCount = 1;
            this.pnlGeneralContent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlGeneralContent.Controls.Add(this.gbxPayment, 0, 1);
            this.pnlGeneralContent.Controls.Add(this.gbxGeneral, 0, 0);
            this.pnlGeneralContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGeneralContent.Location = new System.Drawing.Point(3, 3);
            this.pnlGeneralContent.Name = "pnlGeneralContent";
            this.pnlGeneralContent.RowCount = 2;
            this.pnlGeneralContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 55F));
            this.pnlGeneralContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.pnlGeneralContent.Size = new System.Drawing.Size(674, 483);
            this.pnlGeneralContent.TabIndex = 0;
            // 
            // gbxPayment
            // 
            this.gbxPayment.Controls.Add(this.pnlPayment);
            this.gbxPayment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbxPayment.Location = new System.Drawing.Point(3, 268);
            this.gbxPayment.Name = "gbxPayment";
            this.gbxPayment.Size = new System.Drawing.Size(668, 212);
            this.gbxPayment.TabIndex = 4;
            this.gbxPayment.TabStop = false;
            this.gbxPayment.Text = "การชำระเงิน";
            // 
            // pnlPayment
            // 
            this.pnlPayment.ColumnCount = 7;
            this.pnlPayment.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.pnlPayment.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.pnlPayment.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.pnlPayment.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.pnlPayment.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.pnlPayment.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.pnlPayment.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.pnlPayment.Controls.Add(this.lblPaymentType, 4, 1);
            this.pnlPayment.Controls.Add(this.lblPaymentStatus, 1, 1);
            this.pnlPayment.Controls.Add(this.cbxPaymentType, 5, 1);
            this.pnlPayment.Controls.Add(this.cbxPaymentStatus, 2, 1);
            this.pnlPayment.Controls.Add(this.lblPaymentBy, 4, 3);
            this.pnlPayment.Controls.Add(this.lblPaymentDate, 1, 3);
            this.pnlPayment.Controls.Add(this.dtpPaymentDate, 2, 3);
            this.pnlPayment.Controls.Add(this.cbxPaymentBy, 5, 3);
            this.pnlPayment.Controls.Add(this.lblAccountBank, 1, 9);
            this.pnlPayment.Controls.Add(this.cbxBankType, 2, 7);
            this.pnlPayment.Controls.Add(this.lblAccountBranch, 4, 7);
            this.pnlPayment.Controls.Add(this.lblAccountType, 1, 7);
            this.pnlPayment.Controls.Add(this.cbxBankNO, 2, 5);
            this.pnlPayment.Controls.Add(this.tbxBankAccountName, 5, 5);
            this.pnlPayment.Controls.Add(this.tbxBankBranch, 5, 7);
            this.pnlPayment.Controls.Add(this.tbxBankName, 2, 9);
            this.pnlPayment.Controls.Add(this.lblAccountNO, 1, 5);
            this.pnlPayment.Controls.Add(this.lblAccountName, 4, 5);
            this.pnlPayment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPayment.Location = new System.Drawing.Point(3, 16);
            this.pnlPayment.Name = "pnlPayment";
            this.pnlPayment.RowCount = 13;
            this.pnlPayment.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.pnlPayment.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.pnlPayment.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 3F));
            this.pnlPayment.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.pnlPayment.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 3F));
            this.pnlPayment.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.pnlPayment.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 3F));
            this.pnlPayment.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.pnlPayment.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 3F));
            this.pnlPayment.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.pnlPayment.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 3F));
            this.pnlPayment.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.pnlPayment.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlPayment.Size = new System.Drawing.Size(662, 193);
            this.pnlPayment.TabIndex = 0;
            // 
            // lblPaymentType
            // 
            this.lblPaymentType.AutoSize = true;
            this.lblPaymentType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPaymentType.Location = new System.Drawing.Point(337, 10);
            this.lblPaymentType.Name = "lblPaymentType";
            this.lblPaymentType.Size = new System.Drawing.Size(91, 25);
            this.lblPaymentType.TabIndex = 1;
            this.lblPaymentType.Text = "วิธีชำระเงิน";
            this.lblPaymentType.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPaymentStatus
            // 
            this.lblPaymentStatus.AutoSize = true;
            this.lblPaymentStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPaymentStatus.Location = new System.Drawing.Point(35, 10);
            this.lblPaymentStatus.Name = "lblPaymentStatus";
            this.lblPaymentStatus.Size = new System.Drawing.Size(91, 25);
            this.lblPaymentStatus.TabIndex = 6;
            this.lblPaymentStatus.Text = "สถานะชำระเงิน";
            this.lblPaymentStatus.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbxPaymentType
            // 
            this.cbxPaymentType.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.orderInBindingSource, "PaymentType", true));
            this.cbxPaymentType.DisplayMember = "Value";
            this.cbxPaymentType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbxPaymentType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxPaymentType.Enabled = false;
            this.cbxPaymentType.FormattingEnabled = true;
            this.cbxPaymentType.Location = new System.Drawing.Point(434, 13);
            this.cbxPaymentType.Name = "cbxPaymentType";
            this.cbxPaymentType.Size = new System.Drawing.Size(189, 21);
            this.cbxPaymentType.TabIndex = 7;
            this.cbxPaymentType.ValueMember = "Key";
            this.cbxPaymentType.SelectedIndexChanged += new System.EventHandler(this.cbxPaymentType_SelectedIndexChanged);
            // 
            // orderInBindingSource
            // 
            this.orderInBindingSource.DataMember = "OrderIn";
            this.orderInBindingSource.DataSource = this.farmManageDataSet;
            // 
            // farmManageDataSet
            // 
            this.farmManageDataSet.DataSetName = "FarmManageDataSet";
            this.farmManageDataSet.Locale = new System.Globalization.CultureInfo("en");
            this.farmManageDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cbxPaymentStatus
            // 
            this.cbxPaymentStatus.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.orderInBindingSource, "PaymentStatus", true));
            this.cbxPaymentStatus.DisplayMember = "Value";
            this.cbxPaymentStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbxPaymentStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxPaymentStatus.FormattingEnabled = true;
            this.cbxPaymentStatus.Location = new System.Drawing.Point(132, 13);
            this.cbxPaymentStatus.Name = "cbxPaymentStatus";
            this.cbxPaymentStatus.Size = new System.Drawing.Size(189, 21);
            this.cbxPaymentStatus.TabIndex = 8;
            this.cbxPaymentStatus.ValueMember = "Key";
            this.cbxPaymentStatus.SelectedIndexChanged += new System.EventHandler(this.cbxPaymentStatus_SelectedIndexChanged);
            // 
            // lblPaymentBy
            // 
            this.lblPaymentBy.AutoSize = true;
            this.lblPaymentBy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPaymentBy.Location = new System.Drawing.Point(337, 38);
            this.lblPaymentBy.Name = "lblPaymentBy";
            this.lblPaymentBy.Size = new System.Drawing.Size(91, 25);
            this.lblPaymentBy.TabIndex = 15;
            this.lblPaymentBy.Text = "ผู้ชำระเงิน";
            this.lblPaymentBy.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPaymentDate
            // 
            this.lblPaymentDate.AutoSize = true;
            this.lblPaymentDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPaymentDate.Location = new System.Drawing.Point(35, 38);
            this.lblPaymentDate.Name = "lblPaymentDate";
            this.lblPaymentDate.Size = new System.Drawing.Size(91, 25);
            this.lblPaymentDate.TabIndex = 13;
            this.lblPaymentDate.Text = "วันที่ชำระเงิน";
            this.lblPaymentDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dtpPaymentDate
            // 
            this.dtpPaymentDate.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.orderInBindingSource, "PaymentDate", true));
            this.dtpPaymentDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtpPaymentDate.Enabled = false;
            this.dtpPaymentDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpPaymentDate.Location = new System.Drawing.Point(132, 41);
            this.dtpPaymentDate.Name = "dtpPaymentDate";
            this.dtpPaymentDate.Size = new System.Drawing.Size(189, 20);
            this.dtpPaymentDate.TabIndex = 14;
            // 
            // cbxPaymentBy
            // 
            this.cbxPaymentBy.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.orderInBindingSource, "PaymentBy", true));
            this.cbxPaymentBy.DataSource = this.usersViewBindingSource;
            this.cbxPaymentBy.DisplayMember = "Name";
            this.cbxPaymentBy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbxPaymentBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxPaymentBy.Enabled = false;
            this.cbxPaymentBy.FormattingEnabled = true;
            this.cbxPaymentBy.Location = new System.Drawing.Point(434, 41);
            this.cbxPaymentBy.Name = "cbxPaymentBy";
            this.cbxPaymentBy.Size = new System.Drawing.Size(189, 21);
            this.cbxPaymentBy.TabIndex = 16;
            this.cbxPaymentBy.ValueMember = "UserID";
            // 
            // usersViewBindingSource
            // 
            this.usersViewBindingSource.DataMember = "UsersView";
            this.usersViewBindingSource.DataSource = this.farmManageDataSet;
            // 
            // lblAccountBank
            // 
            this.lblAccountBank.AutoSize = true;
            this.lblAccountBank.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAccountBank.Location = new System.Drawing.Point(35, 122);
            this.lblAccountBank.Name = "lblAccountBank";
            this.lblAccountBank.Size = new System.Drawing.Size(91, 25);
            this.lblAccountBank.TabIndex = 4;
            this.lblAccountBank.Text = "ธนาคาร";
            this.lblAccountBank.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbxBankType
            // 
            this.cbxBankType.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bankAccountBindingSource, "Type", true));
            this.cbxBankType.DisplayMember = "Value";
            this.cbxBankType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbxBankType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxBankType.Enabled = false;
            this.cbxBankType.FormattingEnabled = true;
            this.cbxBankType.Location = new System.Drawing.Point(132, 97);
            this.cbxBankType.Name = "cbxBankType";
            this.cbxBankType.Size = new System.Drawing.Size(189, 21);
            this.cbxBankType.TabIndex = 11;
            this.cbxBankType.ValueMember = "Key";
            // 
            // bankAccountBindingSource
            // 
            this.bankAccountBindingSource.DataMember = "BankAccount";
            this.bankAccountBindingSource.DataSource = this.farmManageDataSet;
            // 
            // lblAccountBranch
            // 
            this.lblAccountBranch.AutoSize = true;
            this.lblAccountBranch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAccountBranch.Location = new System.Drawing.Point(337, 94);
            this.lblAccountBranch.Name = "lblAccountBranch";
            this.lblAccountBranch.Size = new System.Drawing.Size(91, 25);
            this.lblAccountBranch.TabIndex = 5;
            this.lblAccountBranch.Text = "สาขา";
            this.lblAccountBranch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblAccountType
            // 
            this.lblAccountType.AutoSize = true;
            this.lblAccountType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAccountType.Location = new System.Drawing.Point(35, 94);
            this.lblAccountType.Name = "lblAccountType";
            this.lblAccountType.Size = new System.Drawing.Size(91, 25);
            this.lblAccountType.TabIndex = 3;
            this.lblAccountType.Text = "ประเภทบัญชี";
            this.lblAccountType.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbxBankNO
            // 
            this.cbxBankNO.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.orderInBindingSource, "BankAccountID", true));
            this.cbxBankNO.DataSource = this.bankAccountBindingSource;
            this.cbxBankNO.DisplayMember = "NO";
            this.cbxBankNO.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbxBankNO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxBankNO.Enabled = false;
            this.cbxBankNO.FormattingEnabled = true;
            this.cbxBankNO.Location = new System.Drawing.Point(132, 69);
            this.cbxBankNO.Name = "cbxBankNO";
            this.cbxBankNO.Size = new System.Drawing.Size(189, 21);
            this.cbxBankNO.TabIndex = 18;
            this.cbxBankNO.ValueMember = "BankAccountID";
            // 
            // tbxBankAccountName
            // 
            this.tbxBankAccountName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bankAccountBindingSource, "Name", true));
            this.tbxBankAccountName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxBankAccountName.Location = new System.Drawing.Point(434, 69);
            this.tbxBankAccountName.Name = "tbxBankAccountName";
            this.tbxBankAccountName.ReadOnly = true;
            this.tbxBankAccountName.Size = new System.Drawing.Size(189, 20);
            this.tbxBankAccountName.TabIndex = 19;
            // 
            // tbxBankBranch
            // 
            this.tbxBankBranch.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bankAccountBindingSource, "Branch", true));
            this.tbxBankBranch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxBankBranch.Location = new System.Drawing.Point(434, 97);
            this.tbxBankBranch.Name = "tbxBankBranch";
            this.tbxBankBranch.ReadOnly = true;
            this.tbxBankBranch.Size = new System.Drawing.Size(189, 20);
            this.tbxBankBranch.TabIndex = 20;
            // 
            // tbxBankName
            // 
            this.tbxBankName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bankAccountBindingSource, "BankName", true));
            this.tbxBankName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxBankName.Location = new System.Drawing.Point(132, 125);
            this.tbxBankName.Name = "tbxBankName";
            this.tbxBankName.ReadOnly = true;
            this.tbxBankName.Size = new System.Drawing.Size(189, 20);
            this.tbxBankName.TabIndex = 21;
            // 
            // lblAccountNO
            // 
            this.lblAccountNO.AutoSize = true;
            this.lblAccountNO.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAccountNO.Location = new System.Drawing.Point(35, 66);
            this.lblAccountNO.Name = "lblAccountNO";
            this.lblAccountNO.Size = new System.Drawing.Size(91, 25);
            this.lblAccountNO.TabIndex = 2;
            this.lblAccountNO.Text = "เลขบัญชี";
            this.lblAccountNO.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblAccountName
            // 
            this.lblAccountName.AutoSize = true;
            this.lblAccountName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAccountName.Location = new System.Drawing.Point(337, 66);
            this.lblAccountName.Name = "lblAccountName";
            this.lblAccountName.Size = new System.Drawing.Size(91, 25);
            this.lblAccountName.TabIndex = 17;
            this.lblAccountName.Text = "ชื่อบัญชี";
            this.lblAccountName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // gbxGeneral
            // 
            this.gbxGeneral.Controls.Add(this.pnlGeneral);
            this.gbxGeneral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbxGeneral.Location = new System.Drawing.Point(3, 3);
            this.gbxGeneral.Name = "gbxGeneral";
            this.gbxGeneral.Size = new System.Drawing.Size(668, 259);
            this.gbxGeneral.TabIndex = 1;
            this.gbxGeneral.TabStop = false;
            this.gbxGeneral.Text = "ข้อมูลทั่วไป";
            // 
            // pnlGeneral
            // 
            this.pnlGeneral.ColumnCount = 7;
            this.pnlGeneral.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.pnlGeneral.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.pnlGeneral.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.pnlGeneral.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.pnlGeneral.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.pnlGeneral.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.pnlGeneral.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.pnlGeneral.Controls.Add(this.cbxTransportType, 2, 5);
            this.pnlGeneral.Controls.Add(this.lblTransportCost, 4, 5);
            this.pnlGeneral.Controls.Add(this.lblTransportType, 1, 5);
            this.pnlGeneral.Controls.Add(this.lblTransportNO, 1, 7);
            this.pnlGeneral.Controls.Add(this.lblTransportIssueBy, 4, 7);
            this.pnlGeneral.Controls.Add(this.tbxTransportNO, 2, 7);
            this.pnlGeneral.Controls.Add(this.tbxTransportIssueBy, 5, 7);
            this.pnlGeneral.Controls.Add(this.lblAmount, 1, 11);
            this.pnlGeneral.Controls.Add(this.tbxAmount, 2, 11);
            this.pnlGeneral.Controls.Add(this.tbxTransportCost, 5, 5);
            this.pnlGeneral.Controls.Add(this.lblNote, 4, 11);
            this.pnlGeneral.Controls.Add(this.tbxNote, 5, 11);
            this.pnlGeneral.Controls.Add(this.dtpOrderDate, 2, 3);
            this.pnlGeneral.Controls.Add(this.lblInOrderDate, 1, 3);
            this.pnlGeneral.Controls.Add(this.lblOrderType, 1, 1);
            this.pnlGeneral.Controls.Add(this.cbxOrderType, 2, 1);
            this.pnlGeneral.Controls.Add(this.lblCreateBy, 4, 3);
            this.pnlGeneral.Controls.Add(this.cbxOrderBy, 5, 3);
            this.pnlGeneral.Controls.Add(this.tbxTotalAmount, 2, 13);
            this.pnlGeneral.Controls.Add(this.lblTotalAmount, 1, 13);
            this.pnlGeneral.Controls.Add(this.lblkilo, 1, 9);
            this.pnlGeneral.Controls.Add(this.lblPerKilo, 4, 9);
            this.pnlGeneral.Controls.Add(this.tbxWeight, 2, 9);
            this.pnlGeneral.Controls.Add(this.tbxAmountPerUnit, 5, 9);
            this.pnlGeneral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGeneral.Location = new System.Drawing.Point(3, 16);
            this.pnlGeneral.Name = "pnlGeneral";
            this.pnlGeneral.RowCount = 15;
            this.pnlGeneral.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 9F));
            this.pnlGeneral.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.pnlGeneral.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 3F));
            this.pnlGeneral.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.pnlGeneral.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 3F));
            this.pnlGeneral.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.pnlGeneral.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 3F));
            this.pnlGeneral.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.pnlGeneral.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 3F));
            this.pnlGeneral.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.pnlGeneral.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 3F));
            this.pnlGeneral.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.pnlGeneral.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 3F));
            this.pnlGeneral.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.pnlGeneral.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 3F));
            this.pnlGeneral.Size = new System.Drawing.Size(662, 240);
            this.pnlGeneral.TabIndex = 15;
            // 
            // cbxTransportType
            // 
            this.cbxTransportType.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.orderInBindingSource, "TransportType", true));
            this.cbxTransportType.DisplayMember = "Value";
            this.cbxTransportType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbxTransportType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTransportType.Enabled = false;
            this.cbxTransportType.FormattingEnabled = true;
            this.cbxTransportType.Location = new System.Drawing.Point(132, 69);
            this.cbxTransportType.Name = "cbxTransportType";
            this.cbxTransportType.Size = new System.Drawing.Size(189, 21);
            this.cbxTransportType.TabIndex = 1;
            this.cbxTransportType.ValueMember = "Key";
            // 
            // lblTransportCost
            // 
            this.lblTransportCost.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTransportCost.Location = new System.Drawing.Point(337, 66);
            this.lblTransportCost.Name = "lblTransportCost";
            this.lblTransportCost.Size = new System.Drawing.Size(91, 25);
            this.lblTransportCost.TabIndex = 2;
            this.lblTransportCost.Text = "ค่าขนส่ง";
            this.lblTransportCost.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTransportType
            // 
            this.lblTransportType.AutoSize = true;
            this.lblTransportType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTransportType.Location = new System.Drawing.Point(35, 66);
            this.lblTransportType.Name = "lblTransportType";
            this.lblTransportType.Size = new System.Drawing.Size(91, 25);
            this.lblTransportType.TabIndex = 5;
            this.lblTransportType.Text = "วิธิการขนส่ง";
            this.lblTransportType.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTransportNO
            // 
            this.lblTransportNO.AutoSize = true;
            this.lblTransportNO.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTransportNO.Location = new System.Drawing.Point(35, 94);
            this.lblTransportNO.Name = "lblTransportNO";
            this.lblTransportNO.Size = new System.Drawing.Size(91, 25);
            this.lblTransportNO.TabIndex = 12;
            this.lblTransportNO.Text = "เลขทีใบย้ายเข้า";
            this.lblTransportNO.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTransportIssueBy
            // 
            this.lblTransportIssueBy.AutoSize = true;
            this.lblTransportIssueBy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTransportIssueBy.Location = new System.Drawing.Point(337, 94);
            this.lblTransportIssueBy.Name = "lblTransportIssueBy";
            this.lblTransportIssueBy.Size = new System.Drawing.Size(91, 25);
            this.lblTransportIssueBy.TabIndex = 13;
            this.lblTransportIssueBy.Text = "ออกให้โดย";
            this.lblTransportIssueBy.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbxTransportNO
            // 
            this.tbxTransportNO.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orderInBindingSource, "TransportBillNO", true));
            this.tbxTransportNO.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxTransportNO.Location = new System.Drawing.Point(132, 97);
            this.tbxTransportNO.Name = "tbxTransportNO";
            this.tbxTransportNO.ReadOnly = true;
            this.tbxTransportNO.Size = new System.Drawing.Size(189, 20);
            this.tbxTransportNO.TabIndex = 16;
            // 
            // tbxTransportIssueBy
            // 
            this.tbxTransportIssueBy.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orderInBindingSource, "TransportBillIssuedBy", true));
            this.tbxTransportIssueBy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxTransportIssueBy.Location = new System.Drawing.Point(434, 97);
            this.tbxTransportIssueBy.Name = "tbxTransportIssueBy";
            this.tbxTransportIssueBy.ReadOnly = true;
            this.tbxTransportIssueBy.Size = new System.Drawing.Size(189, 20);
            this.tbxTransportIssueBy.TabIndex = 17;
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAmount.Location = new System.Drawing.Point(35, 150);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(91, 25);
            this.lblAmount.TabIndex = 20;
            this.lblAmount.Text = "ราคา *";
            this.lblAmount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbxAmount
            // 
            this.tbxAmount.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orderInBindingSource, "Amount", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "0", "C2"));
            this.tbxAmount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxAmount.Location = new System.Drawing.Point(132, 153);
            this.tbxAmount.Name = "tbxAmount";
            this.tbxAmount.ReadOnly = true;
            this.tbxAmount.Size = new System.Drawing.Size(189, 20);
            this.tbxAmount.TabIndex = 23;
            this.tbxAmount.Text = "0";
            this.tbxAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxNumber_KeyPress);
            // 
            // tbxTransportCost
            // 
            this.tbxTransportCost.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orderInBindingSource, "TransportCost", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "0", "C2"));
            this.tbxTransportCost.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxTransportCost.Location = new System.Drawing.Point(434, 69);
            this.tbxTransportCost.Name = "tbxTransportCost";
            this.tbxTransportCost.ReadOnly = true;
            this.tbxTransportCost.Size = new System.Drawing.Size(189, 20);
            this.tbxTransportCost.TabIndex = 26;
            this.tbxTransportCost.Text = "0";
            this.tbxTransportCost.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxNumber_KeyPress);
            // 
            // lblNote
            // 
            this.lblNote.AutoSize = true;
            this.lblNote.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNote.Location = new System.Drawing.Point(337, 150);
            this.lblNote.Name = "lblNote";
            this.pnlGeneral.SetRowSpan(this.lblNote, 3);
            this.lblNote.Size = new System.Drawing.Size(91, 53);
            this.lblNote.TabIndex = 27;
            this.lblNote.Text = "หมายเหตุ";
            this.lblNote.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbxNote
            // 
            this.tbxNote.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orderInBindingSource, "Description", true));
            this.tbxNote.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxNote.Location = new System.Drawing.Point(434, 153);
            this.tbxNote.Multiline = true;
            this.tbxNote.Name = "tbxNote";
            this.tbxNote.ReadOnly = true;
            this.pnlGeneral.SetRowSpan(this.tbxNote, 3);
            this.tbxNote.Size = new System.Drawing.Size(189, 47);
            this.tbxNote.TabIndex = 28;
            // 
            // dtpOrderDate
            // 
            this.dtpOrderDate.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.orderInBindingSource, "Date", true));
            this.dtpOrderDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtpOrderDate.Enabled = false;
            this.dtpOrderDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpOrderDate.Location = new System.Drawing.Point(132, 41);
            this.dtpOrderDate.Name = "dtpOrderDate";
            this.dtpOrderDate.Size = new System.Drawing.Size(189, 20);
            this.dtpOrderDate.TabIndex = 30;
            // 
            // lblInOrderDate
            // 
            this.lblInOrderDate.AutoSize = true;
            this.lblInOrderDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblInOrderDate.Location = new System.Drawing.Point(35, 38);
            this.lblInOrderDate.Name = "lblInOrderDate";
            this.lblInOrderDate.Size = new System.Drawing.Size(91, 25);
            this.lblInOrderDate.TabIndex = 29;
            this.lblInOrderDate.Text = "วันที่ *";
            this.lblInOrderDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblOrderType
            // 
            this.lblOrderType.AutoSize = true;
            this.lblOrderType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblOrderType.Location = new System.Drawing.Point(35, 9);
            this.lblOrderType.Name = "lblOrderType";
            this.lblOrderType.Size = new System.Drawing.Size(91, 26);
            this.lblOrderType.TabIndex = 31;
            this.lblOrderType.Text = "ประเภทนำเข้า *";
            this.lblOrderType.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbxOrderType
            // 
            this.cbxOrderType.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.orderInBindingSource, "OrderType", true));
            this.cbxOrderType.DisplayMember = "Value";
            this.cbxOrderType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbxOrderType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxOrderType.Enabled = false;
            this.cbxOrderType.FormattingEnabled = true;
            this.cbxOrderType.Items.AddRange(new object[] {
            "ซื้อ"});
            this.cbxOrderType.Location = new System.Drawing.Point(132, 12);
            this.cbxOrderType.Name = "cbxOrderType";
            this.cbxOrderType.Size = new System.Drawing.Size(189, 21);
            this.cbxOrderType.TabIndex = 32;
            this.cbxOrderType.ValueMember = "Key";
            this.cbxOrderType.Validating += new System.ComponentModel.CancelEventHandler(this.cbx_Validating);
            // 
            // lblCreateBy
            // 
            this.lblCreateBy.AutoSize = true;
            this.lblCreateBy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCreateBy.Location = new System.Drawing.Point(337, 38);
            this.lblCreateBy.Name = "lblCreateBy";
            this.lblCreateBy.Size = new System.Drawing.Size(91, 25);
            this.lblCreateBy.TabIndex = 33;
            this.lblCreateBy.Text = "โดย *";
            this.lblCreateBy.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbxOrderBy
            // 
            this.cbxOrderBy.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.orderInBindingSource, "OrderBy", true));
            this.cbxOrderBy.DataSource = this.usersViewBindingSource;
            this.cbxOrderBy.DisplayMember = "Name";
            this.cbxOrderBy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbxOrderBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxOrderBy.Enabled = false;
            this.cbxOrderBy.FormattingEnabled = true;
            this.cbxOrderBy.Location = new System.Drawing.Point(434, 41);
            this.cbxOrderBy.Name = "cbxOrderBy";
            this.cbxOrderBy.Size = new System.Drawing.Size(189, 21);
            this.cbxOrderBy.TabIndex = 34;
            this.cbxOrderBy.ValueMember = "UserID";
            this.cbxOrderBy.Validating += new System.ComponentModel.CancelEventHandler(this.cbx_Validating);
            // 
            // tbxTotalAmount
            // 
            this.tbxTotalAmount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxTotalAmount.Location = new System.Drawing.Point(132, 181);
            this.tbxTotalAmount.Name = "tbxTotalAmount";
            this.tbxTotalAmount.ReadOnly = true;
            this.tbxTotalAmount.Size = new System.Drawing.Size(189, 20);
            this.tbxTotalAmount.TabIndex = 35;
            this.tbxTotalAmount.Text = "0";
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.AutoSize = true;
            this.lblTotalAmount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTotalAmount.Location = new System.Drawing.Point(35, 178);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(91, 25);
            this.lblTotalAmount.TabIndex = 36;
            this.lblTotalAmount.Text = "ราคาทั้งหมด";
            this.lblTotalAmount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblkilo
            // 
            this.lblkilo.AutoSize = true;
            this.lblkilo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblkilo.Location = new System.Drawing.Point(35, 122);
            this.lblkilo.Name = "lblkilo";
            this.lblkilo.Size = new System.Drawing.Size(91, 25);
            this.lblkilo.TabIndex = 37;
            this.lblkilo.Text = "น้ำหนัก(กิโลกรัม)";
            this.lblkilo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPerKilo
            // 
            this.lblPerKilo.AutoSize = true;
            this.lblPerKilo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPerKilo.Location = new System.Drawing.Point(337, 122);
            this.lblPerKilo.Name = "lblPerKilo";
            this.lblPerKilo.Size = new System.Drawing.Size(91, 25);
            this.lblPerKilo.TabIndex = 38;
            this.lblPerKilo.Text = "ราคาต่อกิโลกรัม";
            this.lblPerKilo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbxWeight
            // 
            this.tbxWeight.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orderInBindingSource, "Unit", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "N2"));
            this.tbxWeight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxWeight.Location = new System.Drawing.Point(132, 125);
            this.tbxWeight.Name = "tbxWeight";
            this.tbxWeight.ReadOnly = true;
            this.tbxWeight.Size = new System.Drawing.Size(189, 20);
            this.tbxWeight.TabIndex = 39;
            this.tbxWeight.Text = "0";
            // 
            // tbxAmountPerUnit
            // 
            this.tbxAmountPerUnit.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orderInBindingSource, "AmountPerUnit", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "C2"));
            this.tbxAmountPerUnit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxAmountPerUnit.Location = new System.Drawing.Point(434, 125);
            this.tbxAmountPerUnit.Name = "tbxAmountPerUnit";
            this.tbxAmountPerUnit.ReadOnly = true;
            this.tbxAmountPerUnit.Size = new System.Drawing.Size(189, 20);
            this.tbxAmountPerUnit.TabIndex = 40;
            this.tbxAmountPerUnit.Text = "0";
            // 
            // tabCustomer
            // 
            this.tabCustomer.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabCustomer.Controls.Add(this.pnlCustomerContent);
            this.tabCustomer.Location = new System.Drawing.Point(4, 22);
            this.tabCustomer.Name = "tabCustomer";
            this.tabCustomer.Padding = new System.Windows.Forms.Padding(3);
            this.tabCustomer.Size = new System.Drawing.Size(680, 489);
            this.tabCustomer.TabIndex = 1;
            this.tabCustomer.Text = "ข้อมูลผู้ขาย";
            // 
            // pnlCustomerContent
            // 
            this.pnlCustomerContent.ColumnCount = 1;
            this.pnlCustomerContent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlCustomerContent.Controls.Add(this.gbxCustomer, 0, 0);
            this.pnlCustomerContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCustomerContent.Location = new System.Drawing.Point(3, 3);
            this.pnlCustomerContent.Name = "pnlCustomerContent";
            this.pnlCustomerContent.RowCount = 1;
            this.pnlCustomerContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlCustomerContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 483F));
            this.pnlCustomerContent.Size = new System.Drawing.Size(674, 483);
            this.pnlCustomerContent.TabIndex = 0;
            // 
            // gbxCustomer
            // 
            this.gbxCustomer.Controls.Add(this.tableLayoutPanel1);
            this.gbxCustomer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbxCustomer.Location = new System.Drawing.Point(3, 3);
            this.gbxCustomer.Name = "gbxCustomer";
            this.gbxCustomer.Size = new System.Drawing.Size(668, 477);
            this.gbxCustomer.TabIndex = 1;
            this.gbxCustomer.TabStop = false;
            this.gbxCustomer.Text = "ข้อมูลผู้ขาย";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 7;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.Controls.Add(this.lblfName, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.lbllName, 4, 5);
            this.tableLayoutPanel1.Controls.Add(this.lblAddress, 1, 9);
            this.tableLayoutPanel1.Controls.Add(this.tbxfName, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.tbxlName, 5, 5);
            this.tableLayoutPanel1.Controls.Add(this.tbxAddress, 2, 9);
            this.tableLayoutPanel1.Controls.Add(this.lblCompany, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.cbxProvince, 5, 15);
            this.tableLayoutPanel1.Controls.Add(this.lblProvince, 4, 15);
            this.tableLayoutPanel1.Controls.Add(this.lblDistrict, 1, 15);
            this.tableLayoutPanel1.Controls.Add(this.lblStreed, 1, 13);
            this.tableLayoutPanel1.Controls.Add(this.tbxStreed, 2, 13);
            this.tableLayoutPanel1.Controls.Add(this.lblCity, 4, 13);
            this.tableLayoutPanel1.Controls.Add(this.lblPhone, 1, 19);
            this.tableLayoutPanel1.Controls.Add(this.tbxPhone, 2, 19);
            this.tableLayoutPanel1.Controls.Add(this.lblMobile, 4, 19);
            this.tableLayoutPanel1.Controls.Add(this.tbxMobile, 5, 19);
            this.tableLayoutPanel1.Controls.Add(this.lblPostCode, 4, 17);
            this.tableLayoutPanel1.Controls.Add(this.lblCountry, 1, 17);
            this.tableLayoutPanel1.Controls.Add(this.lblPrename, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.cbxPrename, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.cbxCountryValue, 2, 17);
            this.tableLayoutPanel1.Controls.Add(this.cbxDistrict, 2, 15);
            this.tableLayoutPanel1.Controls.Add(this.cbxCity, 5, 13);
            this.tableLayoutPanel1.Controls.Add(this.cbxPostCode, 5, 17);
            this.tableLayoutPanel1.Controls.Add(this.cbxCompany, 2, 7);
            this.tableLayoutPanel1.Controls.Add(this.lblCustomerPID, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblCustomerPIDValue, 2, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 21;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 3F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 3F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 3F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 3F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 3F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 3F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 3F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 3F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 3F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 3F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(662, 458);
            this.tableLayoutPanel1.TabIndex = 8;
            // 
            // lblfName
            // 
            this.lblfName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblfName.Location = new System.Drawing.Point(35, 66);
            this.lblfName.Name = "lblfName";
            this.lblfName.Size = new System.Drawing.Size(91, 25);
            this.lblfName.TabIndex = 0;
            this.lblfName.Text = "ชื่อ *";
            this.lblfName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbllName
            // 
            this.lbllName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbllName.Location = new System.Drawing.Point(337, 66);
            this.lbllName.Name = "lbllName";
            this.lbllName.Size = new System.Drawing.Size(91, 25);
            this.lbllName.TabIndex = 2;
            this.lbllName.Text = "นามสกุล *";
            this.lbllName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblAddress
            // 
            this.lblAddress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAddress.Location = new System.Drawing.Point(35, 122);
            this.lblAddress.Name = "lblAddress";
            this.tableLayoutPanel1.SetRowSpan(this.lblAddress, 3);
            this.lblAddress.Size = new System.Drawing.Size(91, 53);
            this.lblAddress.TabIndex = 3;
            this.lblAddress.Text = "ที่อยู่ *";
            this.lblAddress.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbxfName
            // 
            this.tbxfName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "Firstname", true));
            this.tbxfName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxfName.Location = new System.Drawing.Point(132, 69);
            this.tbxfName.MaxLength = 32;
            this.tbxfName.Name = "tbxfName";
            this.tbxfName.ReadOnly = true;
            this.tbxfName.Size = new System.Drawing.Size(189, 20);
            this.tbxfName.TabIndex = 0;
            this.tbxfName.Validating += new System.ComponentModel.CancelEventHandler(this.tbx_Validating);
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataMember = "Customer";
            this.customerBindingSource.DataSource = this.farmManageDataSet;
            // 
            // tbxlName
            // 
            this.tbxlName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "Lastname", true));
            this.tbxlName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxlName.Location = new System.Drawing.Point(434, 69);
            this.tbxlName.MaxLength = 32;
            this.tbxlName.Name = "tbxlName";
            this.tbxlName.ReadOnly = true;
            this.tbxlName.Size = new System.Drawing.Size(189, 20);
            this.tbxlName.TabIndex = 1;
            this.tbxlName.Validating += new System.ComponentModel.CancelEventHandler(this.tbx_Validating);
            // 
            // tbxAddress
            // 
            this.tbxAddress.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "Address", true));
            this.tbxAddress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxAddress.Location = new System.Drawing.Point(132, 125);
            this.tbxAddress.Multiline = true;
            this.tbxAddress.Name = "tbxAddress";
            this.tbxAddress.ReadOnly = true;
            this.tableLayoutPanel1.SetRowSpan(this.tbxAddress, 3);
            this.tbxAddress.Size = new System.Drawing.Size(189, 47);
            this.tbxAddress.TabIndex = 3;
            // 
            // lblCompany
            // 
            this.lblCompany.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCompany.Location = new System.Drawing.Point(35, 94);
            this.lblCompany.Name = "lblCompany";
            this.lblCompany.Size = new System.Drawing.Size(91, 25);
            this.lblCompany.TabIndex = 4;
            this.lblCompany.Text = "ชื่อบริษัท";
            this.lblCompany.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbxProvince
            // 
            this.cbxProvince.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.customerBindingSource, "ProvinceID", true));
            this.cbxProvince.DataSource = this.provinceBindingSource;
            this.cbxProvince.DisplayMember = "Name";
            this.cbxProvince.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbxProvince.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxProvince.Enabled = false;
            this.cbxProvince.FormattingEnabled = true;
            this.cbxProvince.Location = new System.Drawing.Point(434, 209);
            this.cbxProvince.MaxLength = 64;
            this.cbxProvince.Name = "cbxProvince";
            this.cbxProvince.Size = new System.Drawing.Size(189, 21);
            this.cbxProvince.TabIndex = 7;
            this.cbxProvince.ValueMember = "ProvinceID";
            // 
            // provinceBindingSource
            // 
            this.provinceBindingSource.DataMember = "Province";
            this.provinceBindingSource.DataSource = this.farmManageDataSet;
            // 
            // lblProvince
            // 
            this.lblProvince.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblProvince.Location = new System.Drawing.Point(337, 206);
            this.lblProvince.Name = "lblProvince";
            this.lblProvince.Size = new System.Drawing.Size(91, 25);
            this.lblProvince.TabIndex = 17;
            this.lblProvince.Text = "จังหวัด *";
            this.lblProvince.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblDistrict
            // 
            this.lblDistrict.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDistrict.Location = new System.Drawing.Point(35, 206);
            this.lblDistrict.Name = "lblDistrict";
            this.lblDistrict.Size = new System.Drawing.Size(91, 25);
            this.lblDistrict.TabIndex = 16;
            this.lblDistrict.Text = "อำเภอ *";
            this.lblDistrict.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblStreed
            // 
            this.lblStreed.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblStreed.Location = new System.Drawing.Point(35, 178);
            this.lblStreed.Name = "lblStreed";
            this.lblStreed.Size = new System.Drawing.Size(91, 25);
            this.lblStreed.TabIndex = 6;
            this.lblStreed.Text = "ถนน";
            this.lblStreed.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbxStreed
            // 
            this.tbxStreed.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "Streed", true));
            this.tbxStreed.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxStreed.Location = new System.Drawing.Point(132, 181);
            this.tbxStreed.MaxLength = 32;
            this.tbxStreed.Name = "tbxStreed";
            this.tbxStreed.ReadOnly = true;
            this.tbxStreed.Size = new System.Drawing.Size(189, 20);
            this.tbxStreed.TabIndex = 4;
            // 
            // lblCity
            // 
            this.lblCity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCity.Location = new System.Drawing.Point(337, 178);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(91, 25);
            this.lblCity.TabIndex = 7;
            this.lblCity.Text = "ตำบล *";
            this.lblCity.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPhone
            // 
            this.lblPhone.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPhone.Location = new System.Drawing.Point(35, 262);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(91, 25);
            this.lblPhone.TabIndex = 1;
            this.lblPhone.Text = "เบอร์โทรศัพท์";
            this.lblPhone.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbxPhone
            // 
            this.tbxPhone.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "Tel", true));
            this.tbxPhone.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxPhone.Location = new System.Drawing.Point(132, 265);
            this.tbxPhone.MaxLength = 16;
            this.tbxPhone.Name = "tbxPhone";
            this.tbxPhone.ReadOnly = true;
            this.tbxPhone.Size = new System.Drawing.Size(189, 20);
            this.tbxPhone.TabIndex = 8;
            this.tbxPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxPhone_KeyPress);
            // 
            // lblMobile
            // 
            this.lblMobile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMobile.Location = new System.Drawing.Point(337, 262);
            this.lblMobile.Name = "lblMobile";
            this.lblMobile.Size = new System.Drawing.Size(91, 25);
            this.lblMobile.TabIndex = 20;
            this.lblMobile.Text = "มือถือ";
            this.lblMobile.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbxMobile
            // 
            this.tbxMobile.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "Mobile", true));
            this.tbxMobile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxMobile.Location = new System.Drawing.Point(434, 265);
            this.tbxMobile.MaxLength = 18;
            this.tbxMobile.Name = "tbxMobile";
            this.tbxMobile.ReadOnly = true;
            this.tbxMobile.Size = new System.Drawing.Size(189, 20);
            this.tbxMobile.TabIndex = 9;
            this.tbxMobile.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxPhone_KeyPress);
            // 
            // lblPostCode
            // 
            this.lblPostCode.AutoSize = true;
            this.lblPostCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPostCode.Location = new System.Drawing.Point(337, 234);
            this.lblPostCode.Name = "lblPostCode";
            this.lblPostCode.Size = new System.Drawing.Size(91, 25);
            this.lblPostCode.TabIndex = 22;
            this.lblPostCode.Text = "รหัสไปรษณีย์";
            this.lblPostCode.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCountry.Location = new System.Drawing.Point(35, 234);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(91, 25);
            this.lblCountry.TabIndex = 23;
            this.lblCountry.Text = "ประเทศ *";
            this.lblCountry.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPrename
            // 
            this.lblPrename.AutoSize = true;
            this.lblPrename.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPrename.Location = new System.Drawing.Point(35, 38);
            this.lblPrename.Name = "lblPrename";
            this.lblPrename.Size = new System.Drawing.Size(91, 25);
            this.lblPrename.TabIndex = 25;
            this.lblPrename.Text = "คำนำหน้า *";
            this.lblPrename.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbxPrename
            // 
            this.cbxPrename.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.customerBindingSource, "Prename", true));
            this.cbxPrename.DisplayMember = "Value";
            this.cbxPrename.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbxPrename.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxPrename.Enabled = false;
            this.cbxPrename.FormattingEnabled = true;
            this.cbxPrename.Location = new System.Drawing.Point(132, 41);
            this.cbxPrename.Name = "cbxPrename";
            this.cbxPrename.Size = new System.Drawing.Size(189, 21);
            this.cbxPrename.TabIndex = 26;
            this.cbxPrename.ValueMember = "Key";
            this.cbxPrename.Validating += new System.ComponentModel.CancelEventHandler(this.cbx_Validating);
            // 
            // cbxCountryValue
            // 
            this.cbxCountryValue.AutoSize = true;
            this.cbxCountryValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbxCountryValue.Location = new System.Drawing.Point(132, 234);
            this.cbxCountryValue.Name = "cbxCountryValue";
            this.cbxCountryValue.Size = new System.Drawing.Size(189, 25);
            this.cbxCountryValue.TabIndex = 27;
            this.cbxCountryValue.Text = "ประเทศไทย";
            this.cbxCountryValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbxDistrict
            // 
            this.cbxDistrict.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.customerBindingSource, "DistrictID", true));
            this.cbxDistrict.DataSource = this.fKDistrictProvinceBindingSource;
            this.cbxDistrict.DisplayMember = "Name";
            this.cbxDistrict.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbxDistrict.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxDistrict.Enabled = false;
            this.cbxDistrict.FormattingEnabled = true;
            this.cbxDistrict.Location = new System.Drawing.Point(132, 209);
            this.cbxDistrict.Name = "cbxDistrict";
            this.cbxDistrict.Size = new System.Drawing.Size(189, 21);
            this.cbxDistrict.TabIndex = 28;
            this.cbxDistrict.ValueMember = "DistrictID";
            // 
            // fKDistrictProvinceBindingSource
            // 
            this.fKDistrictProvinceBindingSource.DataMember = "FK_District_Province";
            this.fKDistrictProvinceBindingSource.DataSource = this.provinceBindingSource;
            // 
            // cbxCity
            // 
            this.cbxCity.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.customerBindingSource, "CityID", true));
            this.cbxCity.DataSource = this.fKCityDistrictBindingSource;
            this.cbxCity.DisplayMember = "Name";
            this.cbxCity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbxCity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCity.Enabled = false;
            this.cbxCity.FormattingEnabled = true;
            this.cbxCity.Location = new System.Drawing.Point(434, 181);
            this.cbxCity.Name = "cbxCity";
            this.cbxCity.Size = new System.Drawing.Size(189, 21);
            this.cbxCity.TabIndex = 29;
            this.cbxCity.ValueMember = "CityID";
            // 
            // fKCityDistrictBindingSource
            // 
            this.fKCityDistrictBindingSource.DataMember = "FK_City_District";
            this.fKCityDistrictBindingSource.DataSource = this.fKDistrictProvinceBindingSource;
            // 
            // cbxPostCode
            // 
            this.cbxPostCode.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.customerBindingSource, "PostcodeID", true));
            this.cbxPostCode.DataSource = this.fKPostCodeDistrictBindingSource;
            this.cbxPostCode.DisplayMember = "PostCode";
            this.cbxPostCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbxPostCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxPostCode.Enabled = false;
            this.cbxPostCode.FormattingEnabled = true;
            this.cbxPostCode.Location = new System.Drawing.Point(434, 237);
            this.cbxPostCode.Name = "cbxPostCode";
            this.cbxPostCode.Size = new System.Drawing.Size(189, 21);
            this.cbxPostCode.TabIndex = 30;
            this.cbxPostCode.ValueMember = "PostCodeID";
            // 
            // fKPostCodeDistrictBindingSource
            // 
            this.fKPostCodeDistrictBindingSource.DataMember = "FK_PostCode_District";
            this.fKPostCodeDistrictBindingSource.DataSource = this.fKDistrictProvinceBindingSource;
            // 
            // cbxCompany
            // 
            this.cbxCompany.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.customerBindingSource, "CompanyID", true));
            this.cbxCompany.DataSource = this.companyBindingSource;
            this.cbxCompany.DisplayMember = "Name";
            this.cbxCompany.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbxCompany.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCompany.Enabled = false;
            this.cbxCompany.FormattingEnabled = true;
            this.cbxCompany.Location = new System.Drawing.Point(132, 97);
            this.cbxCompany.Name = "cbxCompany";
            this.cbxCompany.Size = new System.Drawing.Size(189, 21);
            this.cbxCompany.TabIndex = 31;
            this.cbxCompany.ValueMember = "CompanyID";
            // 
            // companyBindingSource
            // 
            this.companyBindingSource.DataMember = "Company";
            this.companyBindingSource.DataSource = this.farmManageDataSet;
            // 
            // lblCustomerPID
            // 
            this.lblCustomerPID.AutoSize = true;
            this.lblCustomerPID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCustomerPID.Location = new System.Drawing.Point(35, 10);
            this.lblCustomerPID.Name = "lblCustomerPID";
            this.lblCustomerPID.Size = new System.Drawing.Size(91, 25);
            this.lblCustomerPID.TabIndex = 32;
            this.lblCustomerPID.Text = "เลขประจำตัว";
            this.lblCustomerPID.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCustomerPIDValue
            // 
            this.lblCustomerPIDValue.AutoSize = true;
            this.lblCustomerPIDValue.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "CustomerPID", true));
            this.lblCustomerPIDValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCustomerPIDValue.Location = new System.Drawing.Point(132, 10);
            this.lblCustomerPIDValue.Name = "lblCustomerPIDValue";
            this.lblCustomerPIDValue.Size = new System.Drawing.Size(189, 25);
            this.lblCustomerPIDValue.TabIndex = 33;
            this.lblCustomerPIDValue.Text = "-";
            this.lblCustomerPIDValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tabCow
            // 
            this.tabCow.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabCow.Controls.Add(this.groupBox1);
            this.tabCow.Location = new System.Drawing.Point(4, 22);
            this.tabCow.Name = "tabCow";
            this.tabCow.Padding = new System.Windows.Forms.Padding(3);
            this.tabCow.Size = new System.Drawing.Size(680, 489);
            this.tabCow.TabIndex = 4;
            this.tabCow.Text = "รายการซื้อ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvCowList);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(674, 483);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "รายการนำเข้า";
            // 
            // dgvCowList
            // 
            this.dgvCowList.AllowUserToAddRows = false;
            this.dgvCowList.AllowUserToDeleteRows = false;
            this.dgvCowList.AutoGenerateColumns = false;
            this.dgvCowList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCowList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCowNO,
            this.colCowCorral,
            this.colCowGene,
            this.colCowSex,
            this.colCowOrderInAmount});
            this.dgvCowList.DataSource = this.fKCowOrderInBindingSource;
            this.dgvCowList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCowList.Location = new System.Drawing.Point(3, 16);
            this.dgvCowList.Name = "dgvCowList";
            this.dgvCowList.ReadOnly = true;
            this.dgvCowList.Size = new System.Drawing.Size(668, 464);
            this.dgvCowList.TabIndex = 0;
            this.dgvCowList.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataCowList_CellMouseDoubleClick);
            // 
            // colCowNO
            // 
            this.colCowNO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colCowNO.DataPropertyName = "CowNO";
            this.colCowNO.HeaderText = "NO";
            this.colCowNO.Name = "colCowNO";
            this.colCowNO.ReadOnly = true;
            // 
            // colCowCorral
            // 
            this.colCowCorral.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colCowCorral.DataPropertyName = "CorralID";
            this.colCowCorral.DataSource = this.corralBindingSource;
            this.colCowCorral.DisplayMember = "Name";
            this.colCowCorral.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.colCowCorral.HeaderText = "คอก";
            this.colCowCorral.Name = "colCowCorral";
            this.colCowCorral.ReadOnly = true;
            this.colCowCorral.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colCowCorral.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colCowCorral.ValueMember = "CorralID";
            // 
            // corralBindingSource
            // 
            this.corralBindingSource.DataMember = "Corral";
            this.corralBindingSource.DataSource = this.farmManageDataSet;
            // 
            // colCowGene
            // 
            this.colCowGene.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colCowGene.DataPropertyName = "GeneID";
            this.colCowGene.DataSource = this.geneBindingSource;
            this.colCowGene.DisplayMember = "Name";
            this.colCowGene.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.colCowGene.HeaderText = "พันธุ์";
            this.colCowGene.Name = "colCowGene";
            this.colCowGene.ReadOnly = true;
            this.colCowGene.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colCowGene.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colCowGene.ValueMember = "GeneID";
            // 
            // geneBindingSource
            // 
            this.geneBindingSource.DataMember = "Gene";
            this.geneBindingSource.DataSource = this.farmManageDataSet;
            // 
            // colCowSex
            // 
            this.colCowSex.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colCowSex.DataPropertyName = "Sex";
            this.colCowSex.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.colCowSex.HeaderText = "เพศ";
            this.colCowSex.Name = "colCowSex";
            this.colCowSex.ReadOnly = true;
            this.colCowSex.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colCowSex.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // colCowOrderInAmount
            // 
            this.colCowOrderInAmount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colCowOrderInAmount.DataPropertyName = "OnderInAmount";
            dataGridViewCellStyle2.Format = "C2";
            dataGridViewCellStyle2.NullValue = "0";
            this.colCowOrderInAmount.DefaultCellStyle = dataGridViewCellStyle2;
            this.colCowOrderInAmount.HeaderText = "ราคาซื้อ";
            this.colCowOrderInAmount.Name = "colCowOrderInAmount";
            this.colCowOrderInAmount.ReadOnly = true;
            // 
            // fKCowOrderInBindingSource
            // 
            this.fKCowOrderInBindingSource.DataMember = "FK_Cow_OrderIn";
            this.fKCowOrderInBindingSource.DataSource = this.orderInBindingSource;
            // 
            // tabRecord
            // 
            this.tabRecord.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabRecord.Controls.Add(this.pnlRecordContent);
            this.tabRecord.Location = new System.Drawing.Point(4, 22);
            this.tabRecord.Name = "tabRecord";
            this.tabRecord.Padding = new System.Windows.Forms.Padding(3);
            this.tabRecord.Size = new System.Drawing.Size(680, 489);
            this.tabRecord.TabIndex = 3;
            this.tabRecord.Text = "การบันทึก";
            // 
            // pnlRecordContent
            // 
            this.pnlRecordContent.ColumnCount = 1;
            this.pnlRecordContent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlRecordContent.Controls.Add(this.userLogUC, 0, 0);
            this.pnlRecordContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRecordContent.Location = new System.Drawing.Point(3, 3);
            this.pnlRecordContent.Name = "pnlRecordContent";
            this.pnlRecordContent.RowCount = 1;
            this.pnlRecordContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlRecordContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 483F));
            this.pnlRecordContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 483F));
            this.pnlRecordContent.Size = new System.Drawing.Size(674, 483);
            this.pnlRecordContent.TabIndex = 1;
            // 
            // userLogUC
            // 
            this.userLogUC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userLogUC.Location = new System.Drawing.Point(3, 3);
            this.userLogUC.Name = "userLogUC";
            this.userLogUC.Size = new System.Drawing.Size(668, 477);
            this.userLogUC.TabIndex = 0;
            // 
            // orderInTableAdapter
            // 
            this.orderInTableAdapter.ClearBeforeFill = true;
            // 
            // geneTableAdapter
            // 
            this.geneTableAdapter.ClearBeforeFill = true;
            // 
            // corralTableAdapter
            // 
            this.corralTableAdapter.ClearBeforeFill = true;
            // 
            // cowTableAdapter
            // 
            this.cowTableAdapter.ClearBeforeFill = true;
            // 
            // bankAccountTableAdapter
            // 
            this.bankAccountTableAdapter.ClearBeforeFill = true;
            // 
            // companyTableAdapter
            // 
            this.companyTableAdapter.ClearBeforeFill = true;
            // 
            // provinceTableAdapter
            // 
            this.provinceTableAdapter.ClearBeforeFill = true;
            // 
            // districtTableAdapter
            // 
            this.districtTableAdapter.ClearBeforeFill = true;
            // 
            // cityTableAdapter
            // 
            this.cityTableAdapter.ClearBeforeFill = true;
            // 
            // postCodeTableAdapter
            // 
            this.postCodeTableAdapter.ClearBeforeFill = true;
            // 
            // customerTableAdapter
            // 
            this.customerTableAdapter.ClearBeforeFill = true;
            // 
            // usersViewTableAdapter
            // 
            this.usersViewTableAdapter.ClearBeforeFill = true;
            // 
            // InOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 621);
            this.Controls.Add(this.pnlMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "InOrderForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "รายละเอียดการซื้อ";
            this.Load += new System.EventHandler(this.InOrderForm_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.pnlFooter.ResumeLayout(false);
            this.pnlLeftFooter.ResumeLayout(false);
            this.pnlRightFooter.ResumeLayout(false);
            this.tcMain.ResumeLayout(false);
            this.tabGeneral.ResumeLayout(false);
            this.pnlGeneralContent.ResumeLayout(false);
            this.gbxPayment.ResumeLayout(false);
            this.pnlPayment.ResumeLayout(false);
            this.pnlPayment.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderInBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.farmManageDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankAccountBindingSource)).EndInit();
            this.gbxGeneral.ResumeLayout(false);
            this.pnlGeneral.ResumeLayout(false);
            this.pnlGeneral.PerformLayout();
            this.tabCustomer.ResumeLayout(false);
            this.pnlCustomerContent.ResumeLayout(false);
            this.gbxCustomer.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.provinceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKDistrictProvinceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKCityDistrictBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKPostCodeDistrictBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyBindingSource)).EndInit();
            this.tabCow.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCowList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.corralBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.geneBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKCowOrderInBindingSource)).EndInit();
            this.tabRecord.ResumeLayout(false);
            this.pnlRecordContent.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel pnlMain;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TabControl tcMain;
        private System.Windows.Forms.TabPage tabGeneral;
        private System.Windows.Forms.TableLayoutPanel pnlGeneralContent;
        private System.Windows.Forms.TabPage tabCustomer;
        private System.Windows.Forms.Label lblPaymentType;
        private System.Windows.Forms.Label lblPaymentStatus;
        private System.Windows.Forms.ComboBox cbxPaymentType;
        private System.Windows.Forms.ComboBox cbxPaymentStatus;
        private System.Windows.Forms.GroupBox gbxGeneral;
        private System.Windows.Forms.TableLayoutPanel pnlFooter;
        private System.Windows.Forms.FlowLayoutPanel pnlLeftFooter;
        private System.Windows.Forms.FlowLayoutPanel pnlRightFooter;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblPaymentDate;
        private System.Windows.Forms.DateTimePicker dtpPaymentDate;
        private System.Windows.Forms.Label lblPaymentBy;
        private System.Windows.Forms.ComboBox cbxPaymentBy;
        private System.Windows.Forms.GroupBox gbxPayment;
        private System.Windows.Forms.TableLayoutPanel pnlPayment;
        private System.Windows.Forms.Label lblAccountNO;
        private System.Windows.Forms.Label lblAccountType;
        private System.Windows.Forms.ComboBox cbxBankType;
        private System.Windows.Forms.Label lblAccountBranch;
        private System.Windows.Forms.Label lblAccountBank;
        private System.Windows.Forms.TableLayoutPanel pnlGeneral;
        private System.Windows.Forms.ComboBox cbxTransportType;
        private System.Windows.Forms.Label lblTransportCost;
        private System.Windows.Forms.Label lblTransportType;
        private System.Windows.Forms.Label lblTransportNO;
        private System.Windows.Forms.Label lblTransportIssueBy;
        private System.Windows.Forms.TextBox tbxTransportNO;
        private System.Windows.Forms.TextBox tbxTransportIssueBy;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.TextBox tbxAmount;
        private System.Windows.Forms.TextBox tbxTransportCost;
        private System.Windows.Forms.Label lblNote;
        private System.Windows.Forms.TextBox tbxNote;
        private System.Windows.Forms.DateTimePicker dtpOrderDate;
        private System.Windows.Forms.Label lblInOrderDate;
        private System.Windows.Forms.Label lblOrderType;
        private System.Windows.Forms.ComboBox cbxOrderType;
        private System.Windows.Forms.Label lblCreateBy;
        private System.Windows.Forms.ComboBox cbxOrderBy;
        private Database.FarmManageDataSet farmManageDataSet;
        private System.Windows.Forms.BindingSource orderInBindingSource;
        private Database.FarmManageDataSetTableAdapters.OrderInTableAdapter orderInTableAdapter;
        private System.Windows.Forms.TableLayoutPanel pnlCustomerContent;
        private System.Windows.Forms.GroupBox gbxCustomer;
        private System.Windows.Forms.BindingSource geneBindingSource;
        private Database.FarmManageDataSetTableAdapters.GeneTableAdapter geneTableAdapter;
        private System.Windows.Forms.BindingSource corralBindingSource;
        private Database.FarmManageDataSetTableAdapters.CorralTableAdapter corralTableAdapter;
        private System.Windows.Forms.BindingSource fKCowOrderInBindingSource;
        private Database.FarmManageDataSetTableAdapters.CowTableAdapter cowTableAdapter;
        private System.Windows.Forms.TabPage tabCow;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvCowList;
        private System.Windows.Forms.Button btnPrintBill;
        private System.Windows.Forms.Button btnResource;
        private System.Windows.Forms.TextBox tbxTotalAmount;
        private System.Windows.Forms.Label lblTotalAmount;
        private System.Windows.Forms.Label lblAccountName;
        private System.Windows.Forms.ComboBox cbxBankNO;
        private System.Windows.Forms.Label lblkilo;
        private System.Windows.Forms.Label lblPerKilo;
        private System.Windows.Forms.TextBox tbxWeight;
        private System.Windows.Forms.TextBox tbxAmountPerUnit;
        private System.Windows.Forms.TextBox tbxBankAccountName;
        private System.Windows.Forms.TextBox tbxBankBranch;
        private System.Windows.Forms.TextBox tbxBankName;
        private System.Windows.Forms.BindingSource bankAccountBindingSource;
        private Database.FarmManageDataSetTableAdapters.BankAccountTableAdapter bankAccountTableAdapter;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblfName;
        private System.Windows.Forms.Label lbllName;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox tbxfName;
        private System.Windows.Forms.TextBox tbxlName;
        private System.Windows.Forms.TextBox tbxAddress;
        private System.Windows.Forms.Label lblCompany;
        private System.Windows.Forms.ComboBox cbxProvince;
        private System.Windows.Forms.Label lblProvince;
        private System.Windows.Forms.Label lblDistrict;
        private System.Windows.Forms.Label lblStreed;
        private System.Windows.Forms.TextBox tbxStreed;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox tbxPhone;
        private System.Windows.Forms.Label lblMobile;
        private System.Windows.Forms.TextBox tbxMobile;
        private System.Windows.Forms.Label lblPostCode;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.Label lblPrename;
        private System.Windows.Forms.ComboBox cbxPrename;
        private System.Windows.Forms.Label cbxCountryValue;
        private System.Windows.Forms.ComboBox cbxDistrict;
        private System.Windows.Forms.ComboBox cbxCity;
        private System.Windows.Forms.ComboBox cbxPostCode;
        private System.Windows.Forms.ComboBox cbxCompany;
        private System.Windows.Forms.BindingSource companyBindingSource;
        private Database.FarmManageDataSetTableAdapters.CompanyTableAdapter companyTableAdapter;
        private System.Windows.Forms.BindingSource provinceBindingSource;
        private Database.FarmManageDataSetTableAdapters.ProvinceTableAdapter provinceTableAdapter;
        private System.Windows.Forms.BindingSource fKDistrictProvinceBindingSource;
        private Database.FarmManageDataSetTableAdapters.DistrictTableAdapter districtTableAdapter;
        private System.Windows.Forms.BindingSource fKCityDistrictBindingSource;
        private Database.FarmManageDataSetTableAdapters.CityTableAdapter cityTableAdapter;
        private System.Windows.Forms.BindingSource fKPostCodeDistrictBindingSource;
        private Database.FarmManageDataSetTableAdapters.PostCodeTableAdapter postCodeTableAdapter;
        private System.Windows.Forms.Label lblCustomerPID;
        private System.Windows.Forms.Label lblCustomerPIDValue;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private Database.FarmManageDataSetTableAdapters.CustomerTableAdapter customerTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCowNO;
        private System.Windows.Forms.DataGridViewComboBoxColumn colCowCorral;
        private System.Windows.Forms.DataGridViewComboBoxColumn colCowGene;
        private System.Windows.Forms.DataGridViewComboBoxColumn colCowSex;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCowOrderInAmount;
        private System.Windows.Forms.TabPage tabRecord;
        private System.Windows.Forms.TableLayoutPanel pnlRecordContent;
        private System.Windows.Forms.BindingSource usersViewBindingSource;
        private Database.FarmManageDataSetTableAdapters.UsersViewTableAdapter usersViewTableAdapter;
        private Control.UserLogUC userLogUC;
    }
}
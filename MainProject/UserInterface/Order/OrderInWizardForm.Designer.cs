namespace MainProject.UserInterface.Order
{
    partial class OrderInWizardForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle46 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle47 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle48 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle49 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle50 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlMain = new System.Windows.Forms.TableLayoutPanel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlFooter = new System.Windows.Forms.FlowLayoutPanel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.pnlNav = new System.Windows.Forms.TableLayoutPanel();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblCow = new System.Windows.Forms.Label();
            this.lblVancein = new System.Windows.Forms.Label();
            this.lblCustomer = new System.Windows.Forms.Label();
            this.lblOrderIn = new System.Windows.Forms.Label();
            this.lblPayment = new System.Windows.Forms.Label();
            this.lblFinish = new System.Windows.Forms.Label();
            this.tcMain = new System.Windows.Forms.TabControl();
            this.tabWelcome = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblWelcomeHeader = new System.Windows.Forms.Label();
            this.lblWelcomeDescription = new System.Windows.Forms.Label();
            this.tabCow = new System.Windows.Forms.TabPage();
            this.gbxCow = new System.Windows.Forms.GroupBox();
            this.pnlCowContent = new System.Windows.Forms.TableLayoutPanel();
            this.dgvCow = new System.Windows.Forms.DataGridView();
            this.colCowID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCowSex = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.colCowGene = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.geneBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.farmManageDataSet = new MainProject.Database.FarmManageDataSet();
            this.colCowCorral = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.corralBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colCowAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlListFooter = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAddCow = new System.Windows.Forms.Button();
            this.btnRemoveCow = new System.Windows.Forms.Button();
            this.btnRemoveAllCow = new System.Windows.Forms.Button();
            this.tabVaccine = new System.Windows.Forms.TabPage();
            this.gbxVaccine = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.dgvVaccine = new System.Windows.Forms.DataGridView();
            this.colVaccineID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colVaccineStockID = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.stockBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colVaccineDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colVaccineUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colVaccineByID = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.usersViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAddVaccine = new System.Windows.Forms.Button();
            this.btnRemoveVaccine = new System.Windows.Forms.Button();
            this.btnRemoveAllVaccine = new System.Windows.Forms.Button();
            this.tabCustomer = new System.Windows.Forms.TabPage();
            this.gbxCustomer = new System.Windows.Forms.GroupBox();
            this.pnlCustomerContent = new System.Windows.Forms.TableLayoutPanel();
            this.pnlCustomerDetail = new System.Windows.Forms.TableLayoutPanel();
            this.lblfName = new System.Windows.Forms.Label();
            this.lbllName = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.tbxfName = new System.Windows.Forms.TextBox();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbxlName = new System.Windows.Forms.TextBox();
            this.tbxAddress = new System.Windows.Forms.TextBox();
            this.lblCompany = new System.Windows.Forms.Label();
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
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.rdoNewCustomer = new System.Windows.Forms.RadioButton();
            this.rdoSelectCustomer = new System.Windows.Forms.RadioButton();
            this.cbxCompany = new System.Windows.Forms.ComboBox();
            this.companyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblCountryValue = new System.Windows.Forms.Label();
            this.cbxDistrict = new System.Windows.Forms.ComboBox();
            this.cbxCity = new System.Windows.Forms.ComboBox();
            this.cbxProvince = new System.Windows.Forms.ComboBox();
            this.cbxPostCode = new System.Windows.Forms.ComboBox();
            this.tbxCustomerPID = new System.Windows.Forms.TextBox();
            this.lblCustomerPID = new System.Windows.Forms.Label();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAddCompany = new System.Windows.Forms.Button();
            this.btnClearCompany = new System.Windows.Forms.Button();
            this.flowLayoutPanel5 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnCheckPID = new System.Windows.Forms.Button();
            this.btnClearPID = new System.Windows.Forms.Button();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnSelectCustomer = new System.Windows.Forms.Button();
            this.tabOrderIn = new System.Windows.Forms.TabPage();
            this.gbxOrderIn = new System.Windows.Forms.GroupBox();
            this.pnlOrderInContent = new System.Windows.Forms.TableLayoutPanel();
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblAmountPerUnit = new System.Windows.Forms.Label();
            this.tbxUnit = new System.Windows.Forms.TextBox();
            this.tbxAmountPerUnit = new System.Windows.Forms.TextBox();
            this.tabPayment = new System.Windows.Forms.TabPage();
            this.gbxPayment = new System.Windows.Forms.GroupBox();
            this.pnlPaymentContent = new System.Windows.Forms.TableLayoutPanel();
            this.lblPaymentType = new System.Windows.Forms.Label();
            this.lblPaymentStatus = new System.Windows.Forms.Label();
            this.cbxPaymentType = new System.Windows.Forms.ComboBox();
            this.cbxPaymentStatus = new System.Windows.Forms.ComboBox();
            this.lblPaymentBy = new System.Windows.Forms.Label();
            this.lblPaymentDate = new System.Windows.Forms.Label();
            this.dtpPaymentDate = new System.Windows.Forms.DateTimePicker();
            this.cbxPaymentBy = new System.Windows.Forms.ComboBox();
            this.lblAccountType = new System.Windows.Forms.Label();
            this.cbxBankType = new System.Windows.Forms.ComboBox();
            this.lblAccountBranch = new System.Windows.Forms.Label();
            this.lblAccountBank = new System.Windows.Forms.Label();
            this.lblAccountNO = new System.Windows.Forms.Label();
            this.lblAccountName = new System.Windows.Forms.Label();
            this.cbxBankNO = new System.Windows.Forms.ComboBox();
            this.bankAccountBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbxBankAccountName = new System.Windows.Forms.TextBox();
            this.cbxBankName = new System.Windows.Forms.TextBox();
            this.tbxBankBranch = new System.Windows.Forms.TextBox();
            this.tabFinish = new System.Windows.Forms.TabPage();
            this.pnlFinishContent = new System.Windows.Forms.TableLayoutPanel();
            this.lblFinishHeader = new System.Windows.Forms.Label();
            this.lblFinishDescription = new System.Windows.Forms.Label();
            this.geneTableAdapter = new MainProject.Database.FarmManageDataSetTableAdapters.GeneTableAdapter();
            this.corralTableAdapter = new MainProject.Database.FarmManageDataSetTableAdapters.CorralTableAdapter();
            this.stockTableAdapter = new MainProject.Database.FarmManageDataSetTableAdapters.StockTableAdapter();
            this.usersViewTableAdapter = new MainProject.Database.FarmManageDataSetTableAdapters.UsersViewTableAdapter();
            this.customerTableAdapter = new MainProject.Database.FarmManageDataSetTableAdapters.CustomerTableAdapter();
            this.orderInTableAdapter = new MainProject.Database.FarmManageDataSetTableAdapters.OrderInTableAdapter();
            this.companyTableAdapter = new MainProject.Database.FarmManageDataSetTableAdapters.CompanyTableAdapter();
            this.bankAccountTableAdapter = new MainProject.Database.FarmManageDataSetTableAdapters.BankAccountTableAdapter();
            this.provinceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.provinceTableAdapter = new MainProject.Database.FarmManageDataSetTableAdapters.ProvinceTableAdapter();
            this.fKDistrictProvinceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.districtTableAdapter = new MainProject.Database.FarmManageDataSetTableAdapters.DistrictTableAdapter();
            this.fKCityDistrictBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cityTableAdapter = new MainProject.Database.FarmManageDataSetTableAdapters.CityTableAdapter();
            this.fKPostCodeDistrictBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.postCodeTableAdapter = new MainProject.Database.FarmManageDataSetTableAdapters.PostCodeTableAdapter();
            this.pnlMain.SuspendLayout();
            this.pnlFooter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.pnlNav.SuspendLayout();
            this.tcMain.SuspendLayout();
            this.tabWelcome.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tabCow.SuspendLayout();
            this.gbxCow.SuspendLayout();
            this.pnlCowContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.geneBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.farmManageDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.corralBindingSource)).BeginInit();
            this.pnlListFooter.SuspendLayout();
            this.tabVaccine.SuspendLayout();
            this.gbxVaccine.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVaccine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersViewBindingSource)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.tabCustomer.SuspendLayout();
            this.gbxCustomer.SuspendLayout();
            this.pnlCustomerContent.SuspendLayout();
            this.pnlCustomerDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            this.flowLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.companyBindingSource)).BeginInit();
            this.flowLayoutPanel4.SuspendLayout();
            this.flowLayoutPanel5.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.tabOrderIn.SuspendLayout();
            this.gbxOrderIn.SuspendLayout();
            this.pnlOrderInContent.SuspendLayout();
            this.tabPayment.SuspendLayout();
            this.gbxPayment.SuspendLayout();
            this.pnlPaymentContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bankAccountBindingSource)).BeginInit();
            this.tabFinish.SuspendLayout();
            this.pnlFinishContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.provinceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKDistrictProvinceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKCityDistrictBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKPostCodeDistrictBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.pnlMain.ColumnCount = 1;
            this.pnlMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.pnlMain.Controls.Add(this.lblTitle, 0, 0);
            this.pnlMain.Controls.Add(this.pnlFooter, 0, 2);
            this.pnlMain.Controls.Add(this.splitContainer1, 0, 1);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.RowCount = 3;
            this.pnlMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.pnlMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.pnlMain.Size = new System.Drawing.Size(794, 571);
            this.pnlMain.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.White;
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblTitle.Location = new System.Drawing.Point(4, 1);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lblTitle.Size = new System.Drawing.Size(786, 60);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "วิซาร์ดการซื้อโค";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlFooter
            // 
            this.pnlFooter.Controls.Add(this.btnCancel);
            this.pnlFooter.Controls.Add(this.btnNext);
            this.pnlFooter.Controls.Add(this.btnBack);
            this.pnlFooter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFooter.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.pnlFooter.Location = new System.Drawing.Point(4, 533);
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.Padding = new System.Windows.Forms.Padding(3);
            this.pnlFooter.Size = new System.Drawing.Size(786, 34);
            this.pnlFooter.TabIndex = 1;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(702, 6);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "ยกเลิก";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(621, 6);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 1;
            this.btnNext.Text = "ถัดไป";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(540, 6);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 2;
            this.btnBack.Text = "ย้อนกลับ";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(4, 65);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.pnlNav);
            this.splitContainer1.Panel1MinSize = 160;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tcMain);
            this.splitContainer1.Size = new System.Drawing.Size(786, 461);
            this.splitContainer1.SplitterDistance = 160;
            this.splitContainer1.TabIndex = 2;
            // 
            // pnlNav
            // 
            this.pnlNav.ColumnCount = 1;
            this.pnlNav.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlNav.Controls.Add(this.lblWelcome, 0, 0);
            this.pnlNav.Controls.Add(this.lblCow, 0, 2);
            this.pnlNav.Controls.Add(this.lblVancein, 0, 4);
            this.pnlNav.Controls.Add(this.lblCustomer, 0, 6);
            this.pnlNav.Controls.Add(this.lblOrderIn, 0, 8);
            this.pnlNav.Controls.Add(this.lblPayment, 0, 10);
            this.pnlNav.Controls.Add(this.lblFinish, 0, 12);
            this.pnlNav.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlNav.Location = new System.Drawing.Point(0, 0);
            this.pnlNav.Name = "pnlNav";
            this.pnlNav.RowCount = 18;
            this.pnlNav.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.pnlNav.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 3F));
            this.pnlNav.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.pnlNav.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 3F));
            this.pnlNav.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.pnlNav.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 3F));
            this.pnlNav.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.pnlNav.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 3F));
            this.pnlNav.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.pnlNav.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 3F));
            this.pnlNav.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.pnlNav.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 3F));
            this.pnlNav.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.pnlNav.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 3F));
            this.pnlNav.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.pnlNav.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 3F));
            this.pnlNav.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.pnlNav.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlNav.Size = new System.Drawing.Size(160, 461);
            this.pnlNav.TabIndex = 0;
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblWelcome.Location = new System.Drawing.Point(3, 0);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(154, 28);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "ยินดีต้อนรับ";
            this.lblWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCow
            // 
            this.lblCow.AutoSize = true;
            this.lblCow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblCow.Location = new System.Drawing.Point(3, 31);
            this.lblCow.Name = "lblCow";
            this.lblCow.Size = new System.Drawing.Size(154, 28);
            this.lblCow.TabIndex = 1;
            this.lblCow.Text = "รายการโค";
            this.lblCow.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblVancein
            // 
            this.lblVancein.AutoSize = true;
            this.lblVancein.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblVancein.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblVancein.Location = new System.Drawing.Point(3, 62);
            this.lblVancein.Name = "lblVancein";
            this.lblVancein.Size = new System.Drawing.Size(154, 28);
            this.lblVancein.TabIndex = 2;
            this.lblVancein.Text = "รายการฉีดวัคซีน";
            this.lblVancein.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCustomer
            // 
            this.lblCustomer.AutoSize = true;
            this.lblCustomer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblCustomer.Location = new System.Drawing.Point(3, 93);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(154, 28);
            this.lblCustomer.TabIndex = 3;
            this.lblCustomer.Text = "ข้อมูลลูกค้า";
            this.lblCustomer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblOrderIn
            // 
            this.lblOrderIn.AutoSize = true;
            this.lblOrderIn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblOrderIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblOrderIn.Location = new System.Drawing.Point(3, 124);
            this.lblOrderIn.Name = "lblOrderIn";
            this.lblOrderIn.Size = new System.Drawing.Size(154, 28);
            this.lblOrderIn.TabIndex = 4;
            this.lblOrderIn.Text = "ข้อมูลการซื้อ";
            this.lblOrderIn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPayment
            // 
            this.lblPayment.AutoSize = true;
            this.lblPayment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblPayment.Location = new System.Drawing.Point(3, 155);
            this.lblPayment.Name = "lblPayment";
            this.lblPayment.Size = new System.Drawing.Size(154, 28);
            this.lblPayment.TabIndex = 5;
            this.lblPayment.Text = "ข้อมูลชำระเงิน";
            this.lblPayment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblFinish
            // 
            this.lblFinish.AutoSize = true;
            this.lblFinish.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblFinish.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblFinish.Location = new System.Drawing.Point(3, 186);
            this.lblFinish.Name = "lblFinish";
            this.lblFinish.Size = new System.Drawing.Size(154, 28);
            this.lblFinish.TabIndex = 6;
            this.lblFinish.Text = "เสร็จสิ้น";
            this.lblFinish.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tcMain
            // 
            this.tcMain.Controls.Add(this.tabWelcome);
            this.tcMain.Controls.Add(this.tabCow);
            this.tcMain.Controls.Add(this.tabVaccine);
            this.tcMain.Controls.Add(this.tabCustomer);
            this.tcMain.Controls.Add(this.tabOrderIn);
            this.tcMain.Controls.Add(this.tabPayment);
            this.tcMain.Controls.Add(this.tabFinish);
            this.tcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcMain.ItemSize = new System.Drawing.Size(68, 18);
            this.tcMain.Location = new System.Drawing.Point(0, 0);
            this.tcMain.Name = "tcMain";
            this.tcMain.SelectedIndex = 0;
            this.tcMain.Size = new System.Drawing.Size(622, 461);
            this.tcMain.TabIndex = 4;
            // 
            // tabWelcome
            // 
            this.tabWelcome.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabWelcome.Controls.Add(this.tableLayoutPanel1);
            this.tabWelcome.Location = new System.Drawing.Point(4, 22);
            this.tabWelcome.Name = "tabWelcome";
            this.tabWelcome.Padding = new System.Windows.Forms.Padding(3);
            this.tabWelcome.Size = new System.Drawing.Size(614, 435);
            this.tabWelcome.TabIndex = 0;
            this.tabWelcome.Text = "ยินดีต้อนรับ";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.lblWelcomeHeader, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblWelcomeDescription, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(608, 429);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // lblWelcomeHeader
            // 
            this.lblWelcomeHeader.AutoSize = true;
            this.lblWelcomeHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblWelcomeHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblWelcomeHeader.Location = new System.Drawing.Point(23, 20);
            this.lblWelcomeHeader.Name = "lblWelcomeHeader";
            this.lblWelcomeHeader.Size = new System.Drawing.Size(562, 60);
            this.lblWelcomeHeader.TabIndex = 0;
            this.lblWelcomeHeader.Text = "ยินดีต้อนรับ";
            this.lblWelcomeHeader.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblWelcomeDescription
            // 
            this.lblWelcomeDescription.AutoSize = true;
            this.lblWelcomeDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblWelcomeDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblWelcomeDescription.Location = new System.Drawing.Point(23, 80);
            this.lblWelcomeDescription.Name = "lblWelcomeDescription";
            this.lblWelcomeDescription.Size = new System.Drawing.Size(562, 329);
            this.lblWelcomeDescription.TabIndex = 1;
            this.lblWelcomeDescription.Text = "ขอต้อนรับเข้าสู่ วิซาร์ดการซื้อโค";
            // 
            // tabCow
            // 
            this.tabCow.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabCow.Controls.Add(this.gbxCow);
            this.tabCow.Location = new System.Drawing.Point(4, 22);
            this.tabCow.Name = "tabCow";
            this.tabCow.Padding = new System.Windows.Forms.Padding(3);
            this.tabCow.Size = new System.Drawing.Size(614, 435);
            this.tabCow.TabIndex = 1;
            this.tabCow.Text = "รายการโค";
            // 
            // gbxCow
            // 
            this.gbxCow.Controls.Add(this.pnlCowContent);
            this.gbxCow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbxCow.Location = new System.Drawing.Point(3, 3);
            this.gbxCow.Name = "gbxCow";
            this.gbxCow.Size = new System.Drawing.Size(608, 429);
            this.gbxCow.TabIndex = 2;
            this.gbxCow.TabStop = false;
            this.gbxCow.Text = "รายการนำเข้า";
            // 
            // pnlCowContent
            // 
            this.pnlCowContent.ColumnCount = 1;
            this.pnlCowContent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlCowContent.Controls.Add(this.dgvCow, 0, 0);
            this.pnlCowContent.Controls.Add(this.pnlListFooter, 0, 1);
            this.pnlCowContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCowContent.Location = new System.Drawing.Point(3, 16);
            this.pnlCowContent.Name = "pnlCowContent";
            this.pnlCowContent.RowCount = 2;
            this.pnlCowContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlCowContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.pnlCowContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.pnlCowContent.Size = new System.Drawing.Size(602, 410);
            this.pnlCowContent.TabIndex = 2;
            // 
            // dgvCow
            // 
            this.dgvCow.AllowUserToAddRows = false;
            this.dgvCow.AllowUserToDeleteRows = false;
            this.dgvCow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCow.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCowID,
            this.colCowSex,
            this.colCowGene,
            this.colCowCorral,
            this.colCowAmount});
            this.dgvCow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCow.Location = new System.Drawing.Point(3, 3);
            this.dgvCow.Name = "dgvCow";
            this.dgvCow.Size = new System.Drawing.Size(596, 370);
            this.dgvCow.TabIndex = 2;
            this.dgvCow.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dgvCowAdd_CellBeginEdit);
            this.dgvCow.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCowAdd_CellEndEdit);
            this.dgvCow.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgvCow_RowsAdded);
            this.dgvCow.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dgvCow_RowsRemoved);
            this.dgvCow.SelectionChanged += new System.EventHandler(this.dgvCow_SelectionChanged);
            // 
            // colCowID
            // 
            this.colCowID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewCellStyle46.Format = "N0";
            dataGridViewCellStyle46.NullValue = "0";
            this.colCowID.DefaultCellStyle = dataGridViewCellStyle46;
            this.colCowID.HeaderText = "ลำดับ";
            this.colCowID.MinimumWidth = 100;
            this.colCowID.Name = "colCowID";
            this.colCowID.ReadOnly = true;
            // 
            // colCowSex
            // 
            this.colCowSex.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colCowSex.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.colCowSex.HeaderText = "เพศ";
            this.colCowSex.MinimumWidth = 50;
            this.colCowSex.Name = "colCowSex";
            this.colCowSex.ReadOnly = true;
            // 
            // colCowGene
            // 
            this.colCowGene.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colCowGene.DataSource = this.geneBindingSource;
            this.colCowGene.DisplayMember = "Name";
            this.colCowGene.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.colCowGene.HeaderText = "พันธุ์";
            this.colCowGene.MinimumWidth = 50;
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
            // farmManageDataSet
            // 
            this.farmManageDataSet.DataSetName = "FarmManageDataSet";
            this.farmManageDataSet.Locale = new System.Globalization.CultureInfo("en");
            this.farmManageDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // colCowCorral
            // 
            this.colCowCorral.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colCowCorral.DataSource = this.corralBindingSource;
            this.colCowCorral.DisplayMember = "Name";
            this.colCowCorral.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.colCowCorral.HeaderText = "คอก";
            this.colCowCorral.MinimumWidth = 50;
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
            // colCowAmount
            // 
            this.colCowAmount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle47.Format = "N2";
            dataGridViewCellStyle47.NullValue = "0";
            this.colCowAmount.DefaultCellStyle = dataGridViewCellStyle47;
            this.colCowAmount.HeaderText = "ราคา";
            this.colCowAmount.MinimumWidth = 50;
            this.colCowAmount.Name = "colCowAmount";
            this.colCowAmount.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colCowAmount.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // pnlListFooter
            // 
            this.pnlListFooter.Controls.Add(this.btnAddCow);
            this.pnlListFooter.Controls.Add(this.btnRemoveCow);
            this.pnlListFooter.Controls.Add(this.btnRemoveAllCow);
            this.pnlListFooter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlListFooter.Location = new System.Drawing.Point(3, 379);
            this.pnlListFooter.Name = "pnlListFooter";
            this.pnlListFooter.Size = new System.Drawing.Size(596, 28);
            this.pnlListFooter.TabIndex = 1;
            // 
            // btnAddCow
            // 
            this.btnAddCow.Location = new System.Drawing.Point(3, 3);
            this.btnAddCow.Name = "btnAddCow";
            this.btnAddCow.Size = new System.Drawing.Size(80, 23);
            this.btnAddCow.TabIndex = 0;
            this.btnAddCow.Text = "เพิ่ม";
            this.btnAddCow.UseVisualStyleBackColor = true;
            this.btnAddCow.Click += new System.EventHandler(this.btnAddCow_Click);
            // 
            // btnRemoveCow
            // 
            this.btnRemoveCow.Enabled = false;
            this.btnRemoveCow.Location = new System.Drawing.Point(89, 3);
            this.btnRemoveCow.Name = "btnRemoveCow";
            this.btnRemoveCow.Size = new System.Drawing.Size(80, 23);
            this.btnRemoveCow.TabIndex = 37;
            this.btnRemoveCow.Text = "ลบที่เลือก";
            this.btnRemoveCow.UseVisualStyleBackColor = true;
            this.btnRemoveCow.Click += new System.EventHandler(this.btnRemoveCow_Click);
            // 
            // btnRemoveAllCow
            // 
            this.btnRemoveAllCow.Enabled = false;
            this.btnRemoveAllCow.Location = new System.Drawing.Point(175, 3);
            this.btnRemoveAllCow.Name = "btnRemoveAllCow";
            this.btnRemoveAllCow.Size = new System.Drawing.Size(80, 23);
            this.btnRemoveAllCow.TabIndex = 38;
            this.btnRemoveAllCow.Text = "ลบทั้งหมด";
            this.btnRemoveAllCow.UseVisualStyleBackColor = true;
            this.btnRemoveAllCow.Click += new System.EventHandler(this.btnRemoveAllCow_Click);
            // 
            // tabVaccine
            // 
            this.tabVaccine.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabVaccine.Controls.Add(this.gbxVaccine);
            this.tabVaccine.Location = new System.Drawing.Point(4, 22);
            this.tabVaccine.Name = "tabVaccine";
            this.tabVaccine.Padding = new System.Windows.Forms.Padding(3);
            this.tabVaccine.Size = new System.Drawing.Size(614, 435);
            this.tabVaccine.TabIndex = 6;
            this.tabVaccine.Text = "การฉีดวัคซีน";
            // 
            // gbxVaccine
            // 
            this.gbxVaccine.Controls.Add(this.tableLayoutPanel2);
            this.gbxVaccine.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbxVaccine.Location = new System.Drawing.Point(3, 3);
            this.gbxVaccine.Name = "gbxVaccine";
            this.gbxVaccine.Size = new System.Drawing.Size(608, 429);
            this.gbxVaccine.TabIndex = 2;
            this.gbxVaccine.TabStop = false;
            this.gbxVaccine.Text = "รายการฉีดวัคซีน";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.dgvVaccine, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.flowLayoutPanel1, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(602, 410);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // dgvVaccine
            // 
            this.dgvVaccine.AllowUserToAddRows = false;
            this.dgvVaccine.AllowUserToDeleteRows = false;
            this.dgvVaccine.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVaccine.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colVaccineID,
            this.colVaccineStockID,
            this.colVaccineDate,
            this.colVaccineUnit,
            this.colVaccineByID});
            this.dgvVaccine.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvVaccine.Location = new System.Drawing.Point(3, 3);
            this.dgvVaccine.Name = "dgvVaccine";
            this.dgvVaccine.ReadOnly = true;
            this.dgvVaccine.Size = new System.Drawing.Size(596, 370);
            this.dgvVaccine.TabIndex = 2;
            this.dgvVaccine.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgvVaccine_RowsAdded);
            this.dgvVaccine.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dgvVaccine_RowsRemoved);
            this.dgvVaccine.SelectionChanged += new System.EventHandler(this.dgvVaccine_SelectionChanged);
            // 
            // colVaccineID
            // 
            this.colVaccineID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewCellStyle48.Format = "N0";
            dataGridViewCellStyle48.NullValue = "0";
            this.colVaccineID.DefaultCellStyle = dataGridViewCellStyle48;
            this.colVaccineID.HeaderText = "ลำดับ";
            this.colVaccineID.MinimumWidth = 100;
            this.colVaccineID.Name = "colVaccineID";
            this.colVaccineID.ReadOnly = true;
            // 
            // colVaccineStockID
            // 
            this.colVaccineStockID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colVaccineStockID.DataSource = this.stockBindingSource;
            this.colVaccineStockID.DisplayMember = "Name";
            this.colVaccineStockID.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.colVaccineStockID.HeaderText = "ชื่อวัคซีน";
            this.colVaccineStockID.Name = "colVaccineStockID";
            this.colVaccineStockID.ReadOnly = true;
            this.colVaccineStockID.ValueMember = "StockID";
            // 
            // stockBindingSource
            // 
            this.stockBindingSource.DataMember = "Stock";
            this.stockBindingSource.DataSource = this.farmManageDataSet;
            // 
            // colVaccineDate
            // 
            this.colVaccineDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle49.Format = "D";
            dataGridViewCellStyle49.NullValue = "0";
            this.colVaccineDate.DefaultCellStyle = dataGridViewCellStyle49;
            this.colVaccineDate.HeaderText = "วันที";
            this.colVaccineDate.MinimumWidth = 100;
            this.colVaccineDate.Name = "colVaccineDate";
            this.colVaccineDate.ReadOnly = true;
            this.colVaccineDate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colVaccineDate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colVaccineUnit
            // 
            this.colVaccineUnit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle50.Format = "N2";
            dataGridViewCellStyle50.NullValue = "0";
            this.colVaccineUnit.DefaultCellStyle = dataGridViewCellStyle50;
            this.colVaccineUnit.HeaderText = "จำนวน";
            this.colVaccineUnit.Name = "colVaccineUnit";
            this.colVaccineUnit.ReadOnly = true;
            // 
            // colVaccineByID
            // 
            this.colVaccineByID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colVaccineByID.DataSource = this.usersViewBindingSource;
            this.colVaccineByID.DisplayMember = "Name";
            this.colVaccineByID.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.colVaccineByID.HeaderText = "ฉีดโดย";
            this.colVaccineByID.Name = "colVaccineByID";
            this.colVaccineByID.ReadOnly = true;
            this.colVaccineByID.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colVaccineByID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colVaccineByID.ValueMember = "UserID";
            // 
            // usersViewBindingSource
            // 
            this.usersViewBindingSource.DataMember = "UsersView";
            this.usersViewBindingSource.DataSource = this.farmManageDataSet;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnAddVaccine);
            this.flowLayoutPanel1.Controls.Add(this.btnRemoveVaccine);
            this.flowLayoutPanel1.Controls.Add(this.btnRemoveAllVaccine);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 379);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(596, 28);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // btnAddVaccine
            // 
            this.btnAddVaccine.Location = new System.Drawing.Point(3, 3);
            this.btnAddVaccine.Name = "btnAddVaccine";
            this.btnAddVaccine.Size = new System.Drawing.Size(80, 23);
            this.btnAddVaccine.TabIndex = 0;
            this.btnAddVaccine.Text = "เพิ่ม";
            this.btnAddVaccine.UseVisualStyleBackColor = true;
            this.btnAddVaccine.Click += new System.EventHandler(this.btnAddVaccine_Click);
            // 
            // btnRemoveVaccine
            // 
            this.btnRemoveVaccine.Enabled = false;
            this.btnRemoveVaccine.Location = new System.Drawing.Point(89, 3);
            this.btnRemoveVaccine.Name = "btnRemoveVaccine";
            this.btnRemoveVaccine.Size = new System.Drawing.Size(80, 23);
            this.btnRemoveVaccine.TabIndex = 37;
            this.btnRemoveVaccine.Text = "ลบที่เลือก";
            this.btnRemoveVaccine.UseVisualStyleBackColor = true;
            this.btnRemoveVaccine.Click += new System.EventHandler(this.btnRemoveVaccine_Click);
            // 
            // btnRemoveAllVaccine
            // 
            this.btnRemoveAllVaccine.Enabled = false;
            this.btnRemoveAllVaccine.Location = new System.Drawing.Point(175, 3);
            this.btnRemoveAllVaccine.Name = "btnRemoveAllVaccine";
            this.btnRemoveAllVaccine.Size = new System.Drawing.Size(80, 23);
            this.btnRemoveAllVaccine.TabIndex = 38;
            this.btnRemoveAllVaccine.Text = "ลบทั้งหมด";
            this.btnRemoveAllVaccine.UseVisualStyleBackColor = true;
            this.btnRemoveAllVaccine.Click += new System.EventHandler(this.btnRemoveAllVaccine_Click);
            // 
            // tabCustomer
            // 
            this.tabCustomer.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabCustomer.Controls.Add(this.gbxCustomer);
            this.tabCustomer.Location = new System.Drawing.Point(4, 22);
            this.tabCustomer.Name = "tabCustomer";
            this.tabCustomer.Padding = new System.Windows.Forms.Padding(3);
            this.tabCustomer.Size = new System.Drawing.Size(614, 435);
            this.tabCustomer.TabIndex = 2;
            this.tabCustomer.Text = "ข้อมูลลูกค้า";
            // 
            // gbxCustomer
            // 
            this.gbxCustomer.Controls.Add(this.pnlCustomerContent);
            this.gbxCustomer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbxCustomer.Location = new System.Drawing.Point(3, 3);
            this.gbxCustomer.Name = "gbxCustomer";
            this.gbxCustomer.Size = new System.Drawing.Size(608, 429);
            this.gbxCustomer.TabIndex = 3;
            this.gbxCustomer.TabStop = false;
            this.gbxCustomer.Text = "ข้อมูลลูกค้า";
            // 
            // pnlCustomerContent
            // 
            this.pnlCustomerContent.ColumnCount = 1;
            this.pnlCustomerContent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlCustomerContent.Controls.Add(this.pnlCustomerDetail, 0, 0);
            this.pnlCustomerContent.Controls.Add(this.flowLayoutPanel2, 0, 1);
            this.pnlCustomerContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCustomerContent.Location = new System.Drawing.Point(3, 16);
            this.pnlCustomerContent.Name = "pnlCustomerContent";
            this.pnlCustomerContent.RowCount = 2;
            this.pnlCustomerContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlCustomerContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.pnlCustomerContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.pnlCustomerContent.Size = new System.Drawing.Size(602, 410);
            this.pnlCustomerContent.TabIndex = 2;
            // 
            // pnlCustomerDetail
            // 
            this.pnlCustomerDetail.ColumnCount = 7;
            this.pnlCustomerDetail.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.pnlCustomerDetail.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.pnlCustomerDetail.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.pnlCustomerDetail.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.pnlCustomerDetail.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.pnlCustomerDetail.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.pnlCustomerDetail.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.pnlCustomerDetail.Controls.Add(this.lblfName, 1, 7);
            this.pnlCustomerDetail.Controls.Add(this.lbllName, 4, 7);
            this.pnlCustomerDetail.Controls.Add(this.lblAddress, 1, 11);
            this.pnlCustomerDetail.Controls.Add(this.tbxfName, 2, 7);
            this.pnlCustomerDetail.Controls.Add(this.tbxlName, 5, 7);
            this.pnlCustomerDetail.Controls.Add(this.tbxAddress, 2, 11);
            this.pnlCustomerDetail.Controls.Add(this.lblCompany, 1, 9);
            this.pnlCustomerDetail.Controls.Add(this.lblProvince, 4, 17);
            this.pnlCustomerDetail.Controls.Add(this.lblDistrict, 1, 17);
            this.pnlCustomerDetail.Controls.Add(this.lblStreed, 1, 15);
            this.pnlCustomerDetail.Controls.Add(this.tbxStreed, 2, 15);
            this.pnlCustomerDetail.Controls.Add(this.lblCity, 4, 15);
            this.pnlCustomerDetail.Controls.Add(this.lblPhone, 1, 21);
            this.pnlCustomerDetail.Controls.Add(this.tbxPhone, 2, 21);
            this.pnlCustomerDetail.Controls.Add(this.lblMobile, 4, 21);
            this.pnlCustomerDetail.Controls.Add(this.tbxMobile, 5, 21);
            this.pnlCustomerDetail.Controls.Add(this.lblPostCode, 4, 19);
            this.pnlCustomerDetail.Controls.Add(this.lblCountry, 1, 19);
            this.pnlCustomerDetail.Controls.Add(this.lblPrename, 1, 5);
            this.pnlCustomerDetail.Controls.Add(this.cbxPrename, 2, 5);
            this.pnlCustomerDetail.Controls.Add(this.flowLayoutPanel3, 2, 1);
            this.pnlCustomerDetail.Controls.Add(this.cbxCompany, 2, 9);
            this.pnlCustomerDetail.Controls.Add(this.lblCountryValue, 2, 19);
            this.pnlCustomerDetail.Controls.Add(this.cbxDistrict, 2, 17);
            this.pnlCustomerDetail.Controls.Add(this.cbxCity, 5, 15);
            this.pnlCustomerDetail.Controls.Add(this.cbxProvince, 5, 17);
            this.pnlCustomerDetail.Controls.Add(this.cbxPostCode, 5, 19);
            this.pnlCustomerDetail.Controls.Add(this.tbxCustomerPID, 2, 3);
            this.pnlCustomerDetail.Controls.Add(this.lblCustomerPID, 1, 3);
            this.pnlCustomerDetail.Controls.Add(this.flowLayoutPanel4, 4, 9);
            this.pnlCustomerDetail.Controls.Add(this.flowLayoutPanel5, 4, 3);
            this.pnlCustomerDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCustomerDetail.Location = new System.Drawing.Point(3, 3);
            this.pnlCustomerDetail.Name = "pnlCustomerDetail";
            this.pnlCustomerDetail.RowCount = 23;
            this.pnlCustomerDetail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.pnlCustomerDetail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.pnlCustomerDetail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 3F));
            this.pnlCustomerDetail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.pnlCustomerDetail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 3F));
            this.pnlCustomerDetail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.pnlCustomerDetail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 3F));
            this.pnlCustomerDetail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.pnlCustomerDetail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 3F));
            this.pnlCustomerDetail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.pnlCustomerDetail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 3F));
            this.pnlCustomerDetail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.pnlCustomerDetail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 3F));
            this.pnlCustomerDetail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.pnlCustomerDetail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 3F));
            this.pnlCustomerDetail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.pnlCustomerDetail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 3F));
            this.pnlCustomerDetail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.pnlCustomerDetail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 3F));
            this.pnlCustomerDetail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.pnlCustomerDetail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 3F));
            this.pnlCustomerDetail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.pnlCustomerDetail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 3F));
            this.pnlCustomerDetail.Size = new System.Drawing.Size(596, 370);
            this.pnlCustomerDetail.TabIndex = 9;
            // 
            // lblfName
            // 
            this.lblfName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblfName.Location = new System.Drawing.Point(32, 94);
            this.lblfName.Name = "lblfName";
            this.lblfName.Size = new System.Drawing.Size(81, 25);
            this.lblfName.TabIndex = 0;
            this.lblfName.Text = "ชื่อ *";
            this.lblfName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbllName
            // 
            this.lbllName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbllName.Location = new System.Drawing.Point(304, 94);
            this.lbllName.Name = "lbllName";
            this.lbllName.Size = new System.Drawing.Size(81, 25);
            this.lbllName.TabIndex = 2;
            this.lbllName.Text = "นามสกุล *";
            this.lbllName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblAddress
            // 
            this.lblAddress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAddress.Location = new System.Drawing.Point(32, 150);
            this.lblAddress.Name = "lblAddress";
            this.pnlCustomerDetail.SetRowSpan(this.lblAddress, 3);
            this.lblAddress.Size = new System.Drawing.Size(81, 53);
            this.lblAddress.TabIndex = 3;
            this.lblAddress.Text = "ที่อยู่ *";
            this.lblAddress.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbxfName
            // 
            this.tbxfName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "Firstname", true));
            this.tbxfName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxfName.Location = new System.Drawing.Point(119, 97);
            this.tbxfName.MaxLength = 32;
            this.tbxfName.Name = "tbxfName";
            this.tbxfName.Size = new System.Drawing.Size(169, 20);
            this.tbxfName.TabIndex = 0;
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
            this.tbxlName.Location = new System.Drawing.Point(391, 97);
            this.tbxlName.MaxLength = 32;
            this.tbxlName.Name = "tbxlName";
            this.tbxlName.Size = new System.Drawing.Size(169, 20);
            this.tbxlName.TabIndex = 1;
            // 
            // tbxAddress
            // 
            this.tbxAddress.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "Address", true));
            this.tbxAddress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxAddress.Location = new System.Drawing.Point(119, 153);
            this.tbxAddress.MaxLength = 64;
            this.tbxAddress.Multiline = true;
            this.tbxAddress.Name = "tbxAddress";
            this.pnlCustomerDetail.SetRowSpan(this.tbxAddress, 3);
            this.tbxAddress.Size = new System.Drawing.Size(169, 47);
            this.tbxAddress.TabIndex = 3;
            // 
            // lblCompany
            // 
            this.lblCompany.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCompany.Location = new System.Drawing.Point(32, 122);
            this.lblCompany.Name = "lblCompany";
            this.lblCompany.Size = new System.Drawing.Size(81, 25);
            this.lblCompany.TabIndex = 4;
            this.lblCompany.Text = "ชื่อบริษัท";
            this.lblCompany.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblProvince
            // 
            this.lblProvince.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblProvince.Location = new System.Drawing.Point(304, 234);
            this.lblProvince.Name = "lblProvince";
            this.lblProvince.Size = new System.Drawing.Size(81, 25);
            this.lblProvince.TabIndex = 17;
            this.lblProvince.Text = "จังหวัด *";
            this.lblProvince.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblDistrict
            // 
            this.lblDistrict.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDistrict.Location = new System.Drawing.Point(32, 234);
            this.lblDistrict.Name = "lblDistrict";
            this.lblDistrict.Size = new System.Drawing.Size(81, 25);
            this.lblDistrict.TabIndex = 16;
            this.lblDistrict.Text = "อำเภอ *";
            this.lblDistrict.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblStreed
            // 
            this.lblStreed.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblStreed.Location = new System.Drawing.Point(32, 206);
            this.lblStreed.Name = "lblStreed";
            this.lblStreed.Size = new System.Drawing.Size(81, 25);
            this.lblStreed.TabIndex = 6;
            this.lblStreed.Text = "ถนน";
            this.lblStreed.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbxStreed
            // 
            this.tbxStreed.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "Streed", true));
            this.tbxStreed.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxStreed.Location = new System.Drawing.Point(119, 209);
            this.tbxStreed.MaxLength = 32;
            this.tbxStreed.Name = "tbxStreed";
            this.tbxStreed.Size = new System.Drawing.Size(169, 20);
            this.tbxStreed.TabIndex = 4;
            // 
            // lblCity
            // 
            this.lblCity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCity.Location = new System.Drawing.Point(304, 206);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(81, 25);
            this.lblCity.TabIndex = 7;
            this.lblCity.Text = "ตำบล *";
            this.lblCity.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPhone
            // 
            this.lblPhone.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPhone.Location = new System.Drawing.Point(32, 290);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(81, 25);
            this.lblPhone.TabIndex = 1;
            this.lblPhone.Text = "เบอร์โทรศัพท์";
            this.lblPhone.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbxPhone
            // 
            this.tbxPhone.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "Tel", true));
            this.tbxPhone.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxPhone.Location = new System.Drawing.Point(119, 293);
            this.tbxPhone.MaxLength = 16;
            this.tbxPhone.Name = "tbxPhone";
            this.tbxPhone.Size = new System.Drawing.Size(169, 20);
            this.tbxPhone.TabIndex = 8;
            this.tbxPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxPhone_KeyPress);
            // 
            // lblMobile
            // 
            this.lblMobile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMobile.Location = new System.Drawing.Point(304, 290);
            this.lblMobile.Name = "lblMobile";
            this.lblMobile.Size = new System.Drawing.Size(81, 25);
            this.lblMobile.TabIndex = 20;
            this.lblMobile.Text = "มือถือ";
            this.lblMobile.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbxMobile
            // 
            this.tbxMobile.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "Mobile", true));
            this.tbxMobile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxMobile.Location = new System.Drawing.Point(391, 293);
            this.tbxMobile.MaxLength = 18;
            this.tbxMobile.Name = "tbxMobile";
            this.tbxMobile.Size = new System.Drawing.Size(169, 20);
            this.tbxMobile.TabIndex = 9;
            this.tbxMobile.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxPhone_KeyPress);
            // 
            // lblPostCode
            // 
            this.lblPostCode.AutoSize = true;
            this.lblPostCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPostCode.Location = new System.Drawing.Point(304, 262);
            this.lblPostCode.Name = "lblPostCode";
            this.lblPostCode.Size = new System.Drawing.Size(81, 25);
            this.lblPostCode.TabIndex = 22;
            this.lblPostCode.Text = "รหัสไปรษณีย์";
            this.lblPostCode.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCountry.Location = new System.Drawing.Point(32, 262);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(81, 25);
            this.lblCountry.TabIndex = 23;
            this.lblCountry.Text = "ประเทศ *";
            this.lblCountry.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPrename
            // 
            this.lblPrename.AutoSize = true;
            this.lblPrename.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPrename.Location = new System.Drawing.Point(32, 66);
            this.lblPrename.Name = "lblPrename";
            this.lblPrename.Size = new System.Drawing.Size(81, 25);
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
            this.cbxPrename.Location = new System.Drawing.Point(119, 69);
            this.cbxPrename.Name = "cbxPrename";
            this.cbxPrename.Size = new System.Drawing.Size(169, 21);
            this.cbxPrename.TabIndex = 26;
            this.cbxPrename.ValueMember = "Key";
            // 
            // flowLayoutPanel3
            // 
            this.pnlCustomerDetail.SetColumnSpan(this.flowLayoutPanel3, 4);
            this.flowLayoutPanel3.Controls.Add(this.rdoNewCustomer);
            this.flowLayoutPanel3.Controls.Add(this.rdoSelectCustomer);
            this.flowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(119, 13);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(441, 19);
            this.flowLayoutPanel3.TabIndex = 29;
            // 
            // rdoNewCustomer
            // 
            this.rdoNewCustomer.AutoSize = true;
            this.rdoNewCustomer.Checked = true;
            this.rdoNewCustomer.Location = new System.Drawing.Point(3, 3);
            this.rdoNewCustomer.Name = "rdoNewCustomer";
            this.rdoNewCustomer.Size = new System.Drawing.Size(90, 17);
            this.rdoNewCustomer.TabIndex = 27;
            this.rdoNewCustomer.TabStop = true;
            this.rdoNewCustomer.Text = "เพิ่มลูกค้าใหม่";
            this.rdoNewCustomer.UseVisualStyleBackColor = true;
            this.rdoNewCustomer.CheckedChanged += new System.EventHandler(this.rdoCustomer_CheckedChanged);
            // 
            // rdoSelectCustomer
            // 
            this.rdoSelectCustomer.AutoSize = true;
            this.rdoSelectCustomer.Location = new System.Drawing.Point(99, 3);
            this.rdoSelectCustomer.Name = "rdoSelectCustomer";
            this.rdoSelectCustomer.Size = new System.Drawing.Size(110, 17);
            this.rdoSelectCustomer.TabIndex = 28;
            this.rdoSelectCustomer.Text = "เลือกลูกค้าจะระบบ";
            this.rdoSelectCustomer.UseVisualStyleBackColor = true;
            this.rdoSelectCustomer.CheckedChanged += new System.EventHandler(this.rdoCustomer_CheckedChanged);
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
            this.cbxCompany.Location = new System.Drawing.Point(119, 125);
            this.cbxCompany.Name = "cbxCompany";
            this.cbxCompany.Size = new System.Drawing.Size(169, 21);
            this.cbxCompany.TabIndex = 30;
            this.cbxCompany.ValueMember = "CompanyID";
            // 
            // companyBindingSource
            // 
            this.companyBindingSource.DataMember = "Company";
            this.companyBindingSource.DataSource = this.farmManageDataSet;
            // 
            // lblCountryValue
            // 
            this.lblCountryValue.AutoSize = true;
            this.lblCountryValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCountryValue.Location = new System.Drawing.Point(119, 262);
            this.lblCountryValue.Name = "lblCountryValue";
            this.lblCountryValue.Size = new System.Drawing.Size(169, 25);
            this.lblCountryValue.TabIndex = 31;
            this.lblCountryValue.Text = "ประเทศไทย";
            this.lblCountryValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.cbxDistrict.Location = new System.Drawing.Point(119, 237);
            this.cbxDistrict.Name = "cbxDistrict";
            this.cbxDistrict.Size = new System.Drawing.Size(169, 21);
            this.cbxDistrict.TabIndex = 32;
            this.cbxDistrict.ValueMember = "DistrictID";
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
            this.cbxCity.Location = new System.Drawing.Point(391, 209);
            this.cbxCity.Name = "cbxCity";
            this.cbxCity.Size = new System.Drawing.Size(169, 21);
            this.cbxCity.TabIndex = 33;
            this.cbxCity.ValueMember = "CityID";
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
            this.cbxProvince.Location = new System.Drawing.Point(391, 237);
            this.cbxProvince.Name = "cbxProvince";
            this.cbxProvince.Size = new System.Drawing.Size(169, 21);
            this.cbxProvince.TabIndex = 34;
            this.cbxProvince.ValueMember = "ProvinceID";
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
            this.cbxPostCode.Location = new System.Drawing.Point(391, 265);
            this.cbxPostCode.Name = "cbxPostCode";
            this.cbxPostCode.Size = new System.Drawing.Size(169, 21);
            this.cbxPostCode.TabIndex = 35;
            this.cbxPostCode.ValueMember = "PostCodeID";
            // 
            // tbxCustomerPID
            // 
            this.tbxCustomerPID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "CustomerPID", true));
            this.tbxCustomerPID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxCustomerPID.Location = new System.Drawing.Point(119, 41);
            this.tbxCustomerPID.Name = "tbxCustomerPID";
            this.tbxCustomerPID.Size = new System.Drawing.Size(169, 20);
            this.tbxCustomerPID.TabIndex = 38;
            // 
            // lblCustomerPID
            // 
            this.lblCustomerPID.AutoSize = true;
            this.lblCustomerPID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCustomerPID.Location = new System.Drawing.Point(32, 38);
            this.lblCustomerPID.Name = "lblCustomerPID";
            this.lblCustomerPID.Size = new System.Drawing.Size(81, 25);
            this.lblCustomerPID.TabIndex = 39;
            this.lblCustomerPID.Text = "เลขประจำตัว *";
            this.lblCustomerPID.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // flowLayoutPanel4
            // 
            this.pnlCustomerDetail.SetColumnSpan(this.flowLayoutPanel4, 2);
            this.flowLayoutPanel4.Controls.Add(this.btnAddCompany);
            this.flowLayoutPanel4.Controls.Add(this.btnClearCompany);
            this.flowLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel4.Location = new System.Drawing.Point(301, 122);
            this.flowLayoutPanel4.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.pnlCustomerDetail.SetRowSpan(this.flowLayoutPanel4, 2);
            this.flowLayoutPanel4.Size = new System.Drawing.Size(262, 28);
            this.flowLayoutPanel4.TabIndex = 40;
            // 
            // btnAddCompany
            // 
            this.btnAddCompany.Location = new System.Drawing.Point(3, 3);
            this.btnAddCompany.Name = "btnAddCompany";
            this.btnAddCompany.Size = new System.Drawing.Size(75, 23);
            this.btnAddCompany.TabIndex = 0;
            this.btnAddCompany.Text = "เพิ่ม";
            this.btnAddCompany.UseVisualStyleBackColor = true;
            this.btnAddCompany.Click += new System.EventHandler(this.btnAddCompany_Click);
            // 
            // btnClearCompany
            // 
            this.btnClearCompany.Location = new System.Drawing.Point(84, 3);
            this.btnClearCompany.Name = "btnClearCompany";
            this.btnClearCompany.Size = new System.Drawing.Size(75, 23);
            this.btnClearCompany.TabIndex = 1;
            this.btnClearCompany.Text = "ล้าง";
            this.btnClearCompany.UseVisualStyleBackColor = true;
            this.btnClearCompany.Click += new System.EventHandler(this.btnClearCompany_Click);
            // 
            // flowLayoutPanel5
            // 
            this.pnlCustomerDetail.SetColumnSpan(this.flowLayoutPanel5, 2);
            this.flowLayoutPanel5.Controls.Add(this.btnCheckPID);
            this.flowLayoutPanel5.Controls.Add(this.btnClearPID);
            this.flowLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel5.Location = new System.Drawing.Point(301, 38);
            this.flowLayoutPanel5.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel5.Name = "flowLayoutPanel5";
            this.pnlCustomerDetail.SetRowSpan(this.flowLayoutPanel5, 2);
            this.flowLayoutPanel5.Size = new System.Drawing.Size(262, 28);
            this.flowLayoutPanel5.TabIndex = 41;
            // 
            // btnCheckPID
            // 
            this.btnCheckPID.Location = new System.Drawing.Point(3, 3);
            this.btnCheckPID.Name = "btnCheckPID";
            this.btnCheckPID.Size = new System.Drawing.Size(75, 23);
            this.btnCheckPID.TabIndex = 0;
            this.btnCheckPID.Text = "ตรวจสอบ";
            this.btnCheckPID.UseVisualStyleBackColor = true;
            this.btnCheckPID.Click += new System.EventHandler(this.btnCheckPID_Click);
            // 
            // btnClearPID
            // 
            this.btnClearPID.Location = new System.Drawing.Point(84, 3);
            this.btnClearPID.Name = "btnClearPID";
            this.btnClearPID.Size = new System.Drawing.Size(75, 23);
            this.btnClearPID.TabIndex = 1;
            this.btnClearPID.Text = "ล้าง";
            this.btnClearPID.UseVisualStyleBackColor = true;
            this.btnClearPID.Click += new System.EventHandler(this.btnClearPID_Click);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.btnSelectCustomer);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 379);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(596, 28);
            this.flowLayoutPanel2.TabIndex = 1;
            // 
            // btnSelectCustomer
            // 
            this.btnSelectCustomer.Enabled = false;
            this.btnSelectCustomer.Location = new System.Drawing.Point(3, 3);
            this.btnSelectCustomer.Name = "btnSelectCustomer";
            this.btnSelectCustomer.Size = new System.Drawing.Size(90, 23);
            this.btnSelectCustomer.TabIndex = 37;
            this.btnSelectCustomer.Text = "เลือกลูกค้า";
            this.btnSelectCustomer.UseVisualStyleBackColor = true;
            this.btnSelectCustomer.Click += new System.EventHandler(this.btnSelectCustomer_Click);
            // 
            // tabOrderIn
            // 
            this.tabOrderIn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabOrderIn.Controls.Add(this.gbxOrderIn);
            this.tabOrderIn.Location = new System.Drawing.Point(4, 22);
            this.tabOrderIn.Name = "tabOrderIn";
            this.tabOrderIn.Padding = new System.Windows.Forms.Padding(3);
            this.tabOrderIn.Size = new System.Drawing.Size(614, 435);
            this.tabOrderIn.TabIndex = 3;
            this.tabOrderIn.Text = "ข้อมูลการซื้อ";
            // 
            // gbxOrderIn
            // 
            this.gbxOrderIn.Controls.Add(this.pnlOrderInContent);
            this.gbxOrderIn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbxOrderIn.Location = new System.Drawing.Point(3, 3);
            this.gbxOrderIn.Name = "gbxOrderIn";
            this.gbxOrderIn.Size = new System.Drawing.Size(608, 429);
            this.gbxOrderIn.TabIndex = 2;
            this.gbxOrderIn.TabStop = false;
            this.gbxOrderIn.Text = "ข้อมูลทั่วไป";
            // 
            // pnlOrderInContent
            // 
            this.pnlOrderInContent.ColumnCount = 7;
            this.pnlOrderInContent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.547297F));
            this.pnlOrderInContent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.21622F));
            this.pnlOrderInContent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.pnlOrderInContent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.pnlOrderInContent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.pnlOrderInContent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.pnlOrderInContent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.pnlOrderInContent.Controls.Add(this.cbxTransportType, 2, 5);
            this.pnlOrderInContent.Controls.Add(this.lblTransportCost, 4, 5);
            this.pnlOrderInContent.Controls.Add(this.lblTransportType, 1, 5);
            this.pnlOrderInContent.Controls.Add(this.lblTransportNO, 1, 7);
            this.pnlOrderInContent.Controls.Add(this.lblTransportIssueBy, 4, 7);
            this.pnlOrderInContent.Controls.Add(this.tbxTransportNO, 2, 7);
            this.pnlOrderInContent.Controls.Add(this.tbxTransportIssueBy, 5, 7);
            this.pnlOrderInContent.Controls.Add(this.lblAmount, 1, 11);
            this.pnlOrderInContent.Controls.Add(this.tbxAmount, 2, 11);
            this.pnlOrderInContent.Controls.Add(this.tbxTransportCost, 5, 5);
            this.pnlOrderInContent.Controls.Add(this.lblNote, 4, 11);
            this.pnlOrderInContent.Controls.Add(this.tbxNote, 5, 11);
            this.pnlOrderInContent.Controls.Add(this.dtpOrderDate, 2, 3);
            this.pnlOrderInContent.Controls.Add(this.lblInOrderDate, 1, 3);
            this.pnlOrderInContent.Controls.Add(this.lblOrderType, 1, 1);
            this.pnlOrderInContent.Controls.Add(this.cbxOrderType, 2, 1);
            this.pnlOrderInContent.Controls.Add(this.lblCreateBy, 4, 3);
            this.pnlOrderInContent.Controls.Add(this.cbxOrderBy, 5, 3);
            this.pnlOrderInContent.Controls.Add(this.tbxTotalAmount, 2, 13);
            this.pnlOrderInContent.Controls.Add(this.lblTotalAmount, 1, 13);
            this.pnlOrderInContent.Controls.Add(this.label1, 1, 9);
            this.pnlOrderInContent.Controls.Add(this.lblAmountPerUnit, 4, 9);
            this.pnlOrderInContent.Controls.Add(this.tbxUnit, 2, 9);
            this.pnlOrderInContent.Controls.Add(this.tbxAmountPerUnit, 5, 9);
            this.pnlOrderInContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlOrderInContent.Location = new System.Drawing.Point(3, 16);
            this.pnlOrderInContent.Name = "pnlOrderInContent";
            this.pnlOrderInContent.RowCount = 15;
            this.pnlOrderInContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 9F));
            this.pnlOrderInContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.pnlOrderInContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 3F));
            this.pnlOrderInContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.pnlOrderInContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 3F));
            this.pnlOrderInContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.pnlOrderInContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 3F));
            this.pnlOrderInContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.pnlOrderInContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 3F));
            this.pnlOrderInContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.pnlOrderInContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 3F));
            this.pnlOrderInContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.pnlOrderInContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 3F));
            this.pnlOrderInContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.pnlOrderInContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 3F));
            this.pnlOrderInContent.Size = new System.Drawing.Size(602, 410);
            this.pnlOrderInContent.TabIndex = 15;
            // 
            // cbxTransportType
            // 
            this.cbxTransportType.DisplayMember = "Value";
            this.cbxTransportType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbxTransportType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTransportType.FormattingEnabled = true;
            this.cbxTransportType.Location = new System.Drawing.Point(120, 69);
            this.cbxTransportType.Name = "cbxTransportType";
            this.cbxTransportType.Size = new System.Drawing.Size(172, 21);
            this.cbxTransportType.TabIndex = 1;
            this.cbxTransportType.ValueMember = "Key";
            // 
            // lblTransportCost
            // 
            this.lblTransportCost.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTransportCost.Location = new System.Drawing.Point(308, 66);
            this.lblTransportCost.Name = "lblTransportCost";
            this.lblTransportCost.Size = new System.Drawing.Size(83, 25);
            this.lblTransportCost.TabIndex = 2;
            this.lblTransportCost.Text = "ค่าขนส่ง";
            this.lblTransportCost.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTransportType
            // 
            this.lblTransportType.AutoSize = true;
            this.lblTransportType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTransportType.Location = new System.Drawing.Point(24, 66);
            this.lblTransportType.Name = "lblTransportType";
            this.lblTransportType.Size = new System.Drawing.Size(90, 25);
            this.lblTransportType.TabIndex = 5;
            this.lblTransportType.Text = "วิธิการขนส่ง";
            this.lblTransportType.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTransportNO
            // 
            this.lblTransportNO.AutoSize = true;
            this.lblTransportNO.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTransportNO.Location = new System.Drawing.Point(24, 94);
            this.lblTransportNO.Name = "lblTransportNO";
            this.lblTransportNO.Size = new System.Drawing.Size(90, 25);
            this.lblTransportNO.TabIndex = 12;
            this.lblTransportNO.Text = "เลขทีใบย้ายเข้า";
            this.lblTransportNO.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTransportIssueBy
            // 
            this.lblTransportIssueBy.AutoSize = true;
            this.lblTransportIssueBy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTransportIssueBy.Location = new System.Drawing.Point(308, 94);
            this.lblTransportIssueBy.Name = "lblTransportIssueBy";
            this.lblTransportIssueBy.Size = new System.Drawing.Size(83, 25);
            this.lblTransportIssueBy.TabIndex = 13;
            this.lblTransportIssueBy.Text = "ออกให้โดย";
            this.lblTransportIssueBy.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbxTransportNO
            // 
            this.tbxTransportNO.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxTransportNO.Location = new System.Drawing.Point(120, 97);
            this.tbxTransportNO.MaxLength = 15;
            this.tbxTransportNO.Name = "tbxTransportNO";
            this.tbxTransportNO.Size = new System.Drawing.Size(172, 20);
            this.tbxTransportNO.TabIndex = 16;
            this.tbxTransportNO.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxTransportNO_KeyPress);
            // 
            // tbxTransportIssueBy
            // 
            this.tbxTransportIssueBy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxTransportIssueBy.Location = new System.Drawing.Point(397, 97);
            this.tbxTransportIssueBy.MaxLength = 32;
            this.tbxTransportIssueBy.Name = "tbxTransportIssueBy";
            this.tbxTransportIssueBy.Size = new System.Drawing.Size(172, 20);
            this.tbxTransportIssueBy.TabIndex = 17;
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAmount.Location = new System.Drawing.Point(24, 150);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(90, 25);
            this.lblAmount.TabIndex = 20;
            this.lblAmount.Text = "ราคา *";
            this.lblAmount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbxAmount
            // 
            this.tbxAmount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxAmount.Location = new System.Drawing.Point(120, 153);
            this.tbxAmount.MaxLength = 16;
            this.tbxAmount.Name = "tbxAmount";
            this.tbxAmount.Size = new System.Drawing.Size(172, 20);
            this.tbxAmount.TabIndex = 23;
            this.tbxAmount.Text = "0";
            this.tbxAmount.TextChanged += new System.EventHandler(this.tbxAmount_TextChanged);
            this.tbxAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxNumber_KeyPress);
            this.tbxAmount.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbxAmount_KeyUp);
            // 
            // tbxTransportCost
            // 
            this.tbxTransportCost.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxTransportCost.Location = new System.Drawing.Point(397, 69);
            this.tbxTransportCost.Name = "tbxTransportCost";
            this.tbxTransportCost.Size = new System.Drawing.Size(172, 20);
            this.tbxTransportCost.TabIndex = 26;
            this.tbxTransportCost.Text = "0";
            this.tbxTransportCost.TextChanged += new System.EventHandler(this.tbxTransportCost_TextChanged);
            this.tbxTransportCost.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxNumber_KeyPress);
            this.tbxTransportCost.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbxTransportCost_KeyUp);
            // 
            // lblNote
            // 
            this.lblNote.AutoSize = true;
            this.lblNote.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNote.Location = new System.Drawing.Point(308, 150);
            this.lblNote.Name = "lblNote";
            this.pnlOrderInContent.SetRowSpan(this.lblNote, 3);
            this.lblNote.Size = new System.Drawing.Size(83, 53);
            this.lblNote.TabIndex = 27;
            this.lblNote.Text = "หมายเหตุ";
            this.lblNote.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbxNote
            // 
            this.tbxNote.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxNote.Location = new System.Drawing.Point(397, 153);
            this.tbxNote.MaxLength = 512;
            this.tbxNote.Multiline = true;
            this.tbxNote.Name = "tbxNote";
            this.pnlOrderInContent.SetRowSpan(this.tbxNote, 3);
            this.tbxNote.Size = new System.Drawing.Size(172, 47);
            this.tbxNote.TabIndex = 28;
            // 
            // dtpOrderDate
            // 
            this.dtpOrderDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtpOrderDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpOrderDate.Location = new System.Drawing.Point(120, 41);
            this.dtpOrderDate.Name = "dtpOrderDate";
            this.dtpOrderDate.Size = new System.Drawing.Size(172, 20);
            this.dtpOrderDate.TabIndex = 30;
            // 
            // lblInOrderDate
            // 
            this.lblInOrderDate.AutoSize = true;
            this.lblInOrderDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblInOrderDate.Location = new System.Drawing.Point(24, 38);
            this.lblInOrderDate.Name = "lblInOrderDate";
            this.lblInOrderDate.Size = new System.Drawing.Size(90, 25);
            this.lblInOrderDate.TabIndex = 29;
            this.lblInOrderDate.Text = "วันที่ *";
            this.lblInOrderDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblOrderType
            // 
            this.lblOrderType.AutoSize = true;
            this.lblOrderType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblOrderType.Location = new System.Drawing.Point(24, 9);
            this.lblOrderType.Name = "lblOrderType";
            this.lblOrderType.Size = new System.Drawing.Size(90, 26);
            this.lblOrderType.TabIndex = 31;
            this.lblOrderType.Text = "ประเภทนำเข้า *";
            this.lblOrderType.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbxOrderType
            // 
            this.cbxOrderType.DisplayMember = "Value";
            this.cbxOrderType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbxOrderType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxOrderType.FormattingEnabled = true;
            this.cbxOrderType.Items.AddRange(new object[] {
            "ซื้อ"});
            this.cbxOrderType.Location = new System.Drawing.Point(120, 12);
            this.cbxOrderType.Name = "cbxOrderType";
            this.cbxOrderType.Size = new System.Drawing.Size(172, 21);
            this.cbxOrderType.TabIndex = 32;
            this.cbxOrderType.ValueMember = "Key";
            this.cbxOrderType.SelectedIndexChanged += new System.EventHandler(this.cbxOrderType_SelectedIndexChanged);
            // 
            // lblCreateBy
            // 
            this.lblCreateBy.AutoSize = true;
            this.lblCreateBy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCreateBy.Location = new System.Drawing.Point(308, 38);
            this.lblCreateBy.Name = "lblCreateBy";
            this.lblCreateBy.Size = new System.Drawing.Size(83, 25);
            this.lblCreateBy.TabIndex = 33;
            this.lblCreateBy.Text = "โดย *";
            this.lblCreateBy.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbxOrderBy
            // 
            this.cbxOrderBy.DataSource = this.usersViewBindingSource;
            this.cbxOrderBy.DisplayMember = "Name";
            this.cbxOrderBy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbxOrderBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxOrderBy.FormattingEnabled = true;
            this.cbxOrderBy.Location = new System.Drawing.Point(397, 41);
            this.cbxOrderBy.Name = "cbxOrderBy";
            this.cbxOrderBy.Size = new System.Drawing.Size(172, 21);
            this.cbxOrderBy.TabIndex = 34;
            this.cbxOrderBy.ValueMember = "UserID";
            // 
            // tbxTotalAmount
            // 
            this.tbxTotalAmount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxTotalAmount.Location = new System.Drawing.Point(120, 181);
            this.tbxTotalAmount.MaxLength = 16;
            this.tbxTotalAmount.Name = "tbxTotalAmount";
            this.tbxTotalAmount.ReadOnly = true;
            this.tbxTotalAmount.Size = new System.Drawing.Size(172, 20);
            this.tbxTotalAmount.TabIndex = 35;
            this.tbxTotalAmount.Text = "0";
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.AutoSize = true;
            this.lblTotalAmount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTotalAmount.Location = new System.Drawing.Point(24, 178);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(90, 25);
            this.lblTotalAmount.TabIndex = 36;
            this.lblTotalAmount.Text = "ราคาทั้งหมด";
            this.lblTotalAmount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(24, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 25);
            this.label1.TabIndex = 37;
            this.label1.Text = "น้ำหนัก (กิโลกรัม)";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblAmountPerUnit
            // 
            this.lblAmountPerUnit.AutoSize = true;
            this.lblAmountPerUnit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAmountPerUnit.Location = new System.Drawing.Point(308, 122);
            this.lblAmountPerUnit.Name = "lblAmountPerUnit";
            this.lblAmountPerUnit.Size = new System.Drawing.Size(83, 25);
            this.lblAmountPerUnit.TabIndex = 38;
            this.lblAmountPerUnit.Text = "ราคาต่อกิโลกรัม";
            this.lblAmountPerUnit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbxUnit
            // 
            this.tbxUnit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxUnit.Location = new System.Drawing.Point(120, 125);
            this.tbxUnit.Name = "tbxUnit";
            this.tbxUnit.Size = new System.Drawing.Size(172, 20);
            this.tbxUnit.TabIndex = 39;
            this.tbxUnit.Text = "0";
            this.tbxUnit.TextChanged += new System.EventHandler(this.tbxNumber_TextChanged);
            this.tbxUnit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxNumber_KeyPress);
            this.tbxUnit.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbxAmount_KeyUp);
            // 
            // tbxAmountPerUnit
            // 
            this.tbxAmountPerUnit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxAmountPerUnit.Location = new System.Drawing.Point(397, 125);
            this.tbxAmountPerUnit.Name = "tbxAmountPerUnit";
            this.tbxAmountPerUnit.Size = new System.Drawing.Size(172, 20);
            this.tbxAmountPerUnit.TabIndex = 40;
            this.tbxAmountPerUnit.Text = "0";
            this.tbxAmountPerUnit.TextChanged += new System.EventHandler(this.tbxNumber_TextChanged);
            this.tbxAmountPerUnit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxNumber_KeyPress);
            this.tbxAmountPerUnit.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbxAmount_KeyUp);
            // 
            // tabPayment
            // 
            this.tabPayment.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPayment.Controls.Add(this.gbxPayment);
            this.tabPayment.Location = new System.Drawing.Point(4, 22);
            this.tabPayment.Name = "tabPayment";
            this.tabPayment.Padding = new System.Windows.Forms.Padding(3);
            this.tabPayment.Size = new System.Drawing.Size(614, 435);
            this.tabPayment.TabIndex = 4;
            this.tabPayment.Text = "ข้อมูลชำระเงิน";
            // 
            // gbxPayment
            // 
            this.gbxPayment.Controls.Add(this.pnlPaymentContent);
            this.gbxPayment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbxPayment.Location = new System.Drawing.Point(3, 3);
            this.gbxPayment.Name = "gbxPayment";
            this.gbxPayment.Size = new System.Drawing.Size(608, 429);
            this.gbxPayment.TabIndex = 5;
            this.gbxPayment.TabStop = false;
            this.gbxPayment.Text = "การชำระเงิน";
            // 
            // pnlPaymentContent
            // 
            this.pnlPaymentContent.ColumnCount = 7;
            this.pnlPaymentContent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.pnlPaymentContent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.pnlPaymentContent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.pnlPaymentContent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.pnlPaymentContent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.pnlPaymentContent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.pnlPaymentContent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.pnlPaymentContent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.pnlPaymentContent.Controls.Add(this.lblPaymentType, 4, 1);
            this.pnlPaymentContent.Controls.Add(this.lblPaymentStatus, 1, 1);
            this.pnlPaymentContent.Controls.Add(this.cbxPaymentType, 5, 1);
            this.pnlPaymentContent.Controls.Add(this.cbxPaymentStatus, 2, 1);
            this.pnlPaymentContent.Controls.Add(this.lblPaymentBy, 4, 3);
            this.pnlPaymentContent.Controls.Add(this.lblPaymentDate, 1, 3);
            this.pnlPaymentContent.Controls.Add(this.dtpPaymentDate, 2, 3);
            this.pnlPaymentContent.Controls.Add(this.cbxPaymentBy, 5, 3);
            this.pnlPaymentContent.Controls.Add(this.lblAccountType, 1, 7);
            this.pnlPaymentContent.Controls.Add(this.cbxBankType, 2, 7);
            this.pnlPaymentContent.Controls.Add(this.lblAccountBranch, 4, 7);
            this.pnlPaymentContent.Controls.Add(this.lblAccountBank, 1, 9);
            this.pnlPaymentContent.Controls.Add(this.lblAccountNO, 1, 5);
            this.pnlPaymentContent.Controls.Add(this.lblAccountName, 4, 5);
            this.pnlPaymentContent.Controls.Add(this.cbxBankNO, 2, 5);
            this.pnlPaymentContent.Controls.Add(this.tbxBankAccountName, 5, 5);
            this.pnlPaymentContent.Controls.Add(this.cbxBankName, 2, 9);
            this.pnlPaymentContent.Controls.Add(this.tbxBankBranch, 5, 7);
            this.pnlPaymentContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPaymentContent.Location = new System.Drawing.Point(3, 16);
            this.pnlPaymentContent.Name = "pnlPaymentContent";
            this.pnlPaymentContent.RowCount = 13;
            this.pnlPaymentContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.pnlPaymentContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.pnlPaymentContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 3F));
            this.pnlPaymentContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.pnlPaymentContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 3F));
            this.pnlPaymentContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.pnlPaymentContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 3F));
            this.pnlPaymentContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.pnlPaymentContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 3F));
            this.pnlPaymentContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.pnlPaymentContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 3F));
            this.pnlPaymentContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.pnlPaymentContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlPaymentContent.Size = new System.Drawing.Size(602, 410);
            this.pnlPaymentContent.TabIndex = 0;
            // 
            // lblPaymentType
            // 
            this.lblPaymentType.AutoSize = true;
            this.lblPaymentType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPaymentType.Location = new System.Drawing.Point(307, 10);
            this.lblPaymentType.Name = "lblPaymentType";
            this.lblPaymentType.Size = new System.Drawing.Size(82, 25);
            this.lblPaymentType.TabIndex = 1;
            this.lblPaymentType.Text = "วิธีชำระเงิน";
            this.lblPaymentType.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPaymentStatus
            // 
            this.lblPaymentStatus.AutoSize = true;
            this.lblPaymentStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPaymentStatus.Location = new System.Drawing.Point(32, 10);
            this.lblPaymentStatus.Name = "lblPaymentStatus";
            this.lblPaymentStatus.Size = new System.Drawing.Size(82, 25);
            this.lblPaymentStatus.TabIndex = 6;
            this.lblPaymentStatus.Text = "สถานะชำระเงิน";
            this.lblPaymentStatus.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbxPaymentType
            // 
            this.cbxPaymentType.DisplayMember = "Value";
            this.cbxPaymentType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbxPaymentType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxPaymentType.FormattingEnabled = true;
            this.cbxPaymentType.Location = new System.Drawing.Point(395, 13);
            this.cbxPaymentType.Name = "cbxPaymentType";
            this.cbxPaymentType.Size = new System.Drawing.Size(171, 21);
            this.cbxPaymentType.TabIndex = 7;
            this.cbxPaymentType.ValueMember = "Key";
            this.cbxPaymentType.SelectedIndexChanged += new System.EventHandler(this.cbxPaymentType_SelectedIndexChanged);
            // 
            // cbxPaymentStatus
            // 
            this.cbxPaymentStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbxPaymentStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxPaymentStatus.FormattingEnabled = true;
            this.cbxPaymentStatus.Location = new System.Drawing.Point(120, 13);
            this.cbxPaymentStatus.Name = "cbxPaymentStatus";
            this.cbxPaymentStatus.Size = new System.Drawing.Size(171, 21);
            this.cbxPaymentStatus.TabIndex = 8;
            this.cbxPaymentStatus.SelectedIndexChanged += new System.EventHandler(this.cbxPaymentStatus_SelectedIndexChanged);
            // 
            // lblPaymentBy
            // 
            this.lblPaymentBy.AutoSize = true;
            this.lblPaymentBy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPaymentBy.Location = new System.Drawing.Point(307, 38);
            this.lblPaymentBy.Name = "lblPaymentBy";
            this.lblPaymentBy.Size = new System.Drawing.Size(82, 25);
            this.lblPaymentBy.TabIndex = 15;
            this.lblPaymentBy.Text = "ผู้ชำระเงิน";
            this.lblPaymentBy.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPaymentDate
            // 
            this.lblPaymentDate.AutoSize = true;
            this.lblPaymentDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPaymentDate.Location = new System.Drawing.Point(32, 38);
            this.lblPaymentDate.Name = "lblPaymentDate";
            this.lblPaymentDate.Size = new System.Drawing.Size(82, 25);
            this.lblPaymentDate.TabIndex = 13;
            this.lblPaymentDate.Text = "วันที่ชำระเงิน";
            this.lblPaymentDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dtpPaymentDate
            // 
            this.dtpPaymentDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtpPaymentDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpPaymentDate.Location = new System.Drawing.Point(120, 41);
            this.dtpPaymentDate.Name = "dtpPaymentDate";
            this.dtpPaymentDate.Size = new System.Drawing.Size(171, 20);
            this.dtpPaymentDate.TabIndex = 14;
            // 
            // cbxPaymentBy
            // 
            this.cbxPaymentBy.DataSource = this.usersViewBindingSource;
            this.cbxPaymentBy.DisplayMember = "Name";
            this.cbxPaymentBy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbxPaymentBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxPaymentBy.FormattingEnabled = true;
            this.cbxPaymentBy.Location = new System.Drawing.Point(395, 41);
            this.cbxPaymentBy.Name = "cbxPaymentBy";
            this.cbxPaymentBy.Size = new System.Drawing.Size(171, 21);
            this.cbxPaymentBy.TabIndex = 16;
            this.cbxPaymentBy.ValueMember = "UserID";
            // 
            // lblAccountType
            // 
            this.lblAccountType.AutoSize = true;
            this.lblAccountType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAccountType.Location = new System.Drawing.Point(32, 94);
            this.lblAccountType.Name = "lblAccountType";
            this.lblAccountType.Size = new System.Drawing.Size(82, 25);
            this.lblAccountType.TabIndex = 3;
            this.lblAccountType.Text = "ประเภทบัญชี";
            this.lblAccountType.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbxBankType
            // 
            this.cbxBankType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbxBankType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxBankType.Enabled = false;
            this.cbxBankType.FormattingEnabled = true;
            this.cbxBankType.Location = new System.Drawing.Point(120, 97);
            this.cbxBankType.Name = "cbxBankType";
            this.cbxBankType.Size = new System.Drawing.Size(171, 21);
            this.cbxBankType.TabIndex = 11;
            // 
            // lblAccountBranch
            // 
            this.lblAccountBranch.AutoSize = true;
            this.lblAccountBranch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAccountBranch.Location = new System.Drawing.Point(307, 94);
            this.lblAccountBranch.Name = "lblAccountBranch";
            this.lblAccountBranch.Size = new System.Drawing.Size(82, 25);
            this.lblAccountBranch.TabIndex = 5;
            this.lblAccountBranch.Text = "สาขา";
            this.lblAccountBranch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblAccountBank
            // 
            this.lblAccountBank.AutoSize = true;
            this.lblAccountBank.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAccountBank.Location = new System.Drawing.Point(32, 122);
            this.lblAccountBank.Name = "lblAccountBank";
            this.lblAccountBank.Size = new System.Drawing.Size(82, 25);
            this.lblAccountBank.TabIndex = 4;
            this.lblAccountBank.Text = "ธนาคาร";
            this.lblAccountBank.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblAccountNO
            // 
            this.lblAccountNO.AutoSize = true;
            this.lblAccountNO.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAccountNO.Location = new System.Drawing.Point(32, 66);
            this.lblAccountNO.Name = "lblAccountNO";
            this.lblAccountNO.Size = new System.Drawing.Size(82, 25);
            this.lblAccountNO.TabIndex = 2;
            this.lblAccountNO.Text = "เลขบัญชี";
            this.lblAccountNO.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblAccountName
            // 
            this.lblAccountName.AutoSize = true;
            this.lblAccountName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAccountName.Location = new System.Drawing.Point(307, 66);
            this.lblAccountName.Name = "lblAccountName";
            this.lblAccountName.Size = new System.Drawing.Size(82, 25);
            this.lblAccountName.TabIndex = 17;
            this.lblAccountName.Text = "ชื่อบัญชี";
            this.lblAccountName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbxBankNO
            // 
            this.cbxBankNO.DataSource = this.bankAccountBindingSource;
            this.cbxBankNO.DisplayMember = "NO";
            this.cbxBankNO.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbxBankNO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxBankNO.FormattingEnabled = true;
            this.cbxBankNO.Location = new System.Drawing.Point(120, 69);
            this.cbxBankNO.Name = "cbxBankNO";
            this.cbxBankNO.Size = new System.Drawing.Size(171, 21);
            this.cbxBankNO.TabIndex = 18;
            this.cbxBankNO.ValueMember = "BankAccountID";
            // 
            // bankAccountBindingSource
            // 
            this.bankAccountBindingSource.DataMember = "BankAccount";
            this.bankAccountBindingSource.DataSource = this.farmManageDataSet;
            // 
            // tbxBankAccountName
            // 
            this.tbxBankAccountName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxBankAccountName.Location = new System.Drawing.Point(395, 69);
            this.tbxBankAccountName.Name = "tbxBankAccountName";
            this.tbxBankAccountName.ReadOnly = true;
            this.tbxBankAccountName.Size = new System.Drawing.Size(171, 20);
            this.tbxBankAccountName.TabIndex = 19;
            // 
            // cbxBankName
            // 
            this.cbxBankName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbxBankName.Location = new System.Drawing.Point(120, 125);
            this.cbxBankName.Name = "cbxBankName";
            this.cbxBankName.ReadOnly = true;
            this.cbxBankName.Size = new System.Drawing.Size(171, 20);
            this.cbxBankName.TabIndex = 21;
            // 
            // tbxBankBranch
            // 
            this.tbxBankBranch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxBankBranch.Location = new System.Drawing.Point(395, 97);
            this.tbxBankBranch.Name = "tbxBankBranch";
            this.tbxBankBranch.ReadOnly = true;
            this.tbxBankBranch.Size = new System.Drawing.Size(171, 20);
            this.tbxBankBranch.TabIndex = 22;
            // 
            // tabFinish
            // 
            this.tabFinish.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabFinish.Controls.Add(this.pnlFinishContent);
            this.tabFinish.Location = new System.Drawing.Point(4, 22);
            this.tabFinish.Name = "tabFinish";
            this.tabFinish.Padding = new System.Windows.Forms.Padding(3);
            this.tabFinish.Size = new System.Drawing.Size(614, 435);
            this.tabFinish.TabIndex = 5;
            this.tabFinish.Text = "เสร็จสิ้น";
            // 
            // pnlFinishContent
            // 
            this.pnlFinishContent.ColumnCount = 3;
            this.pnlFinishContent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.pnlFinishContent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlFinishContent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.pnlFinishContent.Controls.Add(this.lblFinishHeader, 1, 1);
            this.pnlFinishContent.Controls.Add(this.lblFinishDescription, 1, 2);
            this.pnlFinishContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFinishContent.Location = new System.Drawing.Point(3, 3);
            this.pnlFinishContent.Name = "pnlFinishContent";
            this.pnlFinishContent.RowCount = 4;
            this.pnlFinishContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.pnlFinishContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.pnlFinishContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlFinishContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.pnlFinishContent.Size = new System.Drawing.Size(608, 429);
            this.pnlFinishContent.TabIndex = 0;
            // 
            // lblFinishHeader
            // 
            this.lblFinishHeader.AutoSize = true;
            this.lblFinishHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblFinishHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblFinishHeader.Location = new System.Drawing.Point(23, 20);
            this.lblFinishHeader.Name = "lblFinishHeader";
            this.lblFinishHeader.Size = new System.Drawing.Size(562, 60);
            this.lblFinishHeader.TabIndex = 0;
            this.lblFinishHeader.Text = "เสร็จสมบูรณ์";
            this.lblFinishHeader.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblFinishDescription
            // 
            this.lblFinishDescription.AutoSize = true;
            this.lblFinishDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblFinishDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblFinishDescription.Location = new System.Drawing.Point(23, 80);
            this.lblFinishDescription.Name = "lblFinishDescription";
            this.lblFinishDescription.Size = new System.Drawing.Size(562, 329);
            this.lblFinishDescription.TabIndex = 1;
            this.lblFinishDescription.Text = "บันทึกการซื้อเสร็จสมบูรณ์";
            // 
            // geneTableAdapter
            // 
            this.geneTableAdapter.ClearBeforeFill = true;
            // 
            // corralTableAdapter
            // 
            this.corralTableAdapter.ClearBeforeFill = true;
            // 
            // stockTableAdapter
            // 
            this.stockTableAdapter.ClearBeforeFill = true;
            // 
            // usersViewTableAdapter
            // 
            this.usersViewTableAdapter.ClearBeforeFill = true;
            // 
            // customerTableAdapter
            // 
            this.customerTableAdapter.ClearBeforeFill = true;
            // 
            // orderInTableAdapter
            // 
            this.orderInTableAdapter.ClearBeforeFill = true;
            // 
            // companyTableAdapter
            // 
            this.companyTableAdapter.ClearBeforeFill = true;
            // 
            // bankAccountTableAdapter
            // 
            this.bankAccountTableAdapter.ClearBeforeFill = true;
            // 
            // provinceBindingSource
            // 
            this.provinceBindingSource.DataMember = "Province";
            this.provinceBindingSource.DataSource = this.farmManageDataSet;
            // 
            // provinceTableAdapter
            // 
            this.provinceTableAdapter.ClearBeforeFill = true;
            // 
            // fKDistrictProvinceBindingSource
            // 
            this.fKDistrictProvinceBindingSource.DataMember = "FK_District_Province";
            this.fKDistrictProvinceBindingSource.DataSource = this.provinceBindingSource;
            // 
            // districtTableAdapter
            // 
            this.districtTableAdapter.ClearBeforeFill = true;
            // 
            // fKCityDistrictBindingSource
            // 
            this.fKCityDistrictBindingSource.DataMember = "FK_City_District";
            this.fKCityDistrictBindingSource.DataSource = this.fKDistrictProvinceBindingSource;
            // 
            // cityTableAdapter
            // 
            this.cityTableAdapter.ClearBeforeFill = true;
            // 
            // fKPostCodeDistrictBindingSource
            // 
            this.fKPostCodeDistrictBindingSource.DataMember = "FK_PostCode_District";
            this.fKPostCodeDistrictBindingSource.DataSource = this.fKDistrictProvinceBindingSource;
            // 
            // postCodeTableAdapter
            // 
            this.postCodeTableAdapter.ClearBeforeFill = true;
            // 
            // OrderInWizardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 571);
            this.Controls.Add(this.pnlMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OrderInWizardForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "วิซาร์ดการซื้อโค";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OrderInWizardForm_FormClosing);
            this.Load += new System.EventHandler(this.OrderInWizardForm_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.pnlFooter.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.pnlNav.ResumeLayout(false);
            this.pnlNav.PerformLayout();
            this.tcMain.ResumeLayout(false);
            this.tabWelcome.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tabCow.ResumeLayout(false);
            this.gbxCow.ResumeLayout(false);
            this.pnlCowContent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.geneBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.farmManageDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.corralBindingSource)).EndInit();
            this.pnlListFooter.ResumeLayout(false);
            this.tabVaccine.ResumeLayout(false);
            this.gbxVaccine.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVaccine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersViewBindingSource)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.tabCustomer.ResumeLayout(false);
            this.gbxCustomer.ResumeLayout(false);
            this.pnlCustomerContent.ResumeLayout(false);
            this.pnlCustomerDetail.ResumeLayout(false);
            this.pnlCustomerDetail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.companyBindingSource)).EndInit();
            this.flowLayoutPanel4.ResumeLayout(false);
            this.flowLayoutPanel5.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.tabOrderIn.ResumeLayout(false);
            this.gbxOrderIn.ResumeLayout(false);
            this.pnlOrderInContent.ResumeLayout(false);
            this.pnlOrderInContent.PerformLayout();
            this.tabPayment.ResumeLayout(false);
            this.gbxPayment.ResumeLayout(false);
            this.pnlPaymentContent.ResumeLayout(false);
            this.pnlPaymentContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bankAccountBindingSource)).EndInit();
            this.tabFinish.ResumeLayout(false);
            this.pnlFinishContent.ResumeLayout(false);
            this.pnlFinishContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.provinceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKDistrictProvinceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKCityDistrictBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKPostCodeDistrictBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel pnlMain;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.FlowLayoutPanel pnlFooter;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TabControl tcMain;
        private System.Windows.Forms.TabPage tabWelcome;
        private System.Windows.Forms.TabPage tabCow;
        private System.Windows.Forms.GroupBox gbxCow;
        private System.Windows.Forms.TableLayoutPanel pnlCowContent;
        public System.Windows.Forms.DataGridView dgvCow;
        private System.Windows.Forms.FlowLayoutPanel pnlListFooter;
        private System.Windows.Forms.Button btnAddCow;
        private System.Windows.Forms.Button btnRemoveCow;
        private System.Windows.Forms.Button btnRemoveAllCow;
        private System.Windows.Forms.TabPage tabVaccine;
        private System.Windows.Forms.GroupBox gbxVaccine;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        public System.Windows.Forms.DataGridView dgvVaccine;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnAddVaccine;
        private System.Windows.Forms.Button btnRemoveVaccine;
        private System.Windows.Forms.Button btnRemoveAllVaccine;
        private System.Windows.Forms.TabPage tabCustomer;
        private System.Windows.Forms.GroupBox gbxCustomer;
        private System.Windows.Forms.TableLayoutPanel pnlCustomerContent;
        private System.Windows.Forms.TableLayoutPanel pnlCustomerDetail;
        private System.Windows.Forms.Label lblfName;
        private System.Windows.Forms.Label lbllName;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox tbxfName;
        private System.Windows.Forms.TextBox tbxlName;
        private System.Windows.Forms.TextBox tbxAddress;
        private System.Windows.Forms.Label lblCompany;
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
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.RadioButton rdoNewCustomer;
        private System.Windows.Forms.RadioButton rdoSelectCustomer;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button btnSelectCustomer;
        private System.Windows.Forms.TabPage tabOrderIn;
        private System.Windows.Forms.GroupBox gbxOrderIn;
        private System.Windows.Forms.TableLayoutPanel pnlOrderInContent;
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
        private System.Windows.Forms.TextBox tbxTotalAmount;
        private System.Windows.Forms.Label lblTotalAmount;
        private System.Windows.Forms.TabPage tabPayment;
        private System.Windows.Forms.GroupBox gbxPayment;
        private System.Windows.Forms.TableLayoutPanel pnlPaymentContent;
        private System.Windows.Forms.Label lblPaymentType;
        private System.Windows.Forms.Label lblPaymentStatus;
        private System.Windows.Forms.ComboBox cbxPaymentType;
        private System.Windows.Forms.ComboBox cbxPaymentStatus;
        private System.Windows.Forms.Label lblPaymentBy;
        private System.Windows.Forms.Label lblPaymentDate;
        private System.Windows.Forms.DateTimePicker dtpPaymentDate;
        private System.Windows.Forms.ComboBox cbxPaymentBy;
        private System.Windows.Forms.Label lblAccountNO;
        private System.Windows.Forms.Label lblAccountType;
        private System.Windows.Forms.ComboBox cbxBankType;
        private System.Windows.Forms.Label lblAccountBranch;
        private System.Windows.Forms.Label lblAccountBank;
        private System.Windows.Forms.TabPage tabFinish;
        private System.Windows.Forms.TableLayoutPanel pnlNav;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblCow;
        private System.Windows.Forms.Label lblVancein;
        private System.Windows.Forms.Label lblCustomer;
        private System.Windows.Forms.Label lblOrderIn;
        private System.Windows.Forms.Label lblPayment;
        private System.Windows.Forms.Label lblFinish;
        private System.Windows.Forms.Label lblAccountName;
        private Database.FarmManageDataSet farmManageDataSet;
        private System.Windows.Forms.BindingSource geneBindingSource;
        private Database.FarmManageDataSetTableAdapters.GeneTableAdapter geneTableAdapter;
        private System.Windows.Forms.BindingSource corralBindingSource;
        private Database.FarmManageDataSetTableAdapters.CorralTableAdapter corralTableAdapter;
        private System.Windows.Forms.BindingSource stockBindingSource;
        private Database.FarmManageDataSetTableAdapters.StockTableAdapter stockTableAdapter;
        private System.Windows.Forms.BindingSource usersViewBindingSource;
        private Database.FarmManageDataSetTableAdapters.UsersViewTableAdapter usersViewTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn colVaccineID;
        private System.Windows.Forms.DataGridViewComboBoxColumn colVaccineStockID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colVaccineDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colVaccineUnit;
        private System.Windows.Forms.DataGridViewComboBoxColumn colVaccineByID;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private Database.FarmManageDataSetTableAdapters.CustomerTableAdapter customerTableAdapter;
        private Database.FarmManageDataSetTableAdapters.OrderInTableAdapter orderInTableAdapter;
        private System.Windows.Forms.TableLayoutPanel pnlFinishContent;
        private System.Windows.Forms.Label lblFinishHeader;
        private System.Windows.Forms.Label lblFinishDescription;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblWelcomeHeader;
        private System.Windows.Forms.Label lblWelcomeDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCowID;
        private System.Windows.Forms.DataGridViewComboBoxColumn colCowSex;
        private System.Windows.Forms.DataGridViewComboBoxColumn colCowGene;
        private System.Windows.Forms.DataGridViewComboBoxColumn colCowCorral;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCowAmount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblAmountPerUnit;
        private System.Windows.Forms.TextBox tbxUnit;
        private System.Windows.Forms.TextBox tbxAmountPerUnit;
        private System.Windows.Forms.ComboBox cbxCompany;
        private System.Windows.Forms.Label lblCountryValue;
        private System.Windows.Forms.ComboBox cbxDistrict;
        private System.Windows.Forms.ComboBox cbxCity;
        private System.Windows.Forms.ComboBox cbxProvince;
        private System.Windows.Forms.ComboBox cbxPostCode;
        private System.Windows.Forms.TextBox tbxCustomerPID;
        private System.Windows.Forms.Label lblCustomerPID;
        private System.Windows.Forms.BindingSource companyBindingSource;
        private Database.FarmManageDataSetTableAdapters.CompanyTableAdapter companyTableAdapter;
        private System.Windows.Forms.ComboBox cbxBankNO;
        private System.Windows.Forms.TextBox tbxBankAccountName;
        private System.Windows.Forms.TextBox cbxBankName;
        private System.Windows.Forms.TextBox tbxBankBranch;
        private System.Windows.Forms.BindingSource bankAccountBindingSource;
        private Database.FarmManageDataSetTableAdapters.BankAccountTableAdapter bankAccountTableAdapter;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel5;
        private System.Windows.Forms.Button btnAddCompany;
        private System.Windows.Forms.Button btnClearCompany;
        private System.Windows.Forms.Button btnCheckPID;
        private System.Windows.Forms.Button btnClearPID;
        private System.Windows.Forms.BindingSource provinceBindingSource;
        private Database.FarmManageDataSetTableAdapters.ProvinceTableAdapter provinceTableAdapter;
        private System.Windows.Forms.BindingSource fKDistrictProvinceBindingSource;
        private Database.FarmManageDataSetTableAdapters.DistrictTableAdapter districtTableAdapter;
        private System.Windows.Forms.BindingSource fKCityDistrictBindingSource;
        private Database.FarmManageDataSetTableAdapters.CityTableAdapter cityTableAdapter;
        private System.Windows.Forms.BindingSource fKPostCodeDistrictBindingSource;
        private Database.FarmManageDataSetTableAdapters.PostCodeTableAdapter postCodeTableAdapter;
    }
}
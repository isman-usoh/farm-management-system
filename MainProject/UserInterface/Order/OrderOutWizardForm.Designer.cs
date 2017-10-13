namespace MainProject.UserInterface.Order
{
    partial class OrderOutWizardForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCowNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCowCorral = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.corralBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.farmManageDataSet = new MainProject.Database.FarmManageDataSet();
            this.colCowGene = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.geneBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colCowSex = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.colCowOrderInAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCowOrderOutAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCowProfitAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlListFooter = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAddCow = new System.Windows.Forms.Button();
            this.btnRemoveCow = new System.Windows.Forms.Button();
            this.btnRemoveAllCow = new System.Windows.Forms.Button();
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
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.rdoNewCustomer = new System.Windows.Forms.RadioButton();
            this.rdoSelectCustomer = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxCustomerPID = new System.Windows.Forms.TextBox();
            this.cbxCompany = new System.Windows.Forms.ComboBox();
            this.companyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbxDistrict = new System.Windows.Forms.ComboBox();
            this.districtBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbxCity = new System.Windows.Forms.ComboBox();
            this.cityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbxPostCode = new System.Windows.Forms.ComboBox();
            this.postCodeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblCountryValue = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAddCompany = new System.Windows.Forms.Button();
            this.btnClearCompany = new System.Windows.Forms.Button();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnCheckPID = new System.Windows.Forms.Button();
            this.btnClearPID = new System.Windows.Forms.Button();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnSelectCustomer = new System.Windows.Forms.Button();
            this.tabOrderOut = new System.Windows.Forms.TabPage();
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
            this.usersViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbxTotalAmount = new System.Windows.Forms.TextBox();
            this.lblTotalAmount = new System.Windows.Forms.Label();
            this.lblUnit = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
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
            this.usersViewBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tabFinish = new System.Windows.Forms.TabPage();
            this.pnlFinishContent = new System.Windows.Forms.TableLayoutPanel();
            this.lblFinishHeader = new System.Windows.Forms.Label();
            this.lblFinishDescription = new System.Windows.Forms.Label();
            this.stockBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.geneTableAdapter = new MainProject.Database.FarmManageDataSetTableAdapters.GeneTableAdapter();
            this.corralTableAdapter = new MainProject.Database.FarmManageDataSetTableAdapters.CorralTableAdapter();
            this.stockTableAdapter = new MainProject.Database.FarmManageDataSetTableAdapters.StockTableAdapter();
            this.usersViewTableAdapter = new MainProject.Database.FarmManageDataSetTableAdapters.UsersViewTableAdapter();
            this.customerTableAdapter = new MainProject.Database.FarmManageDataSetTableAdapters.CustomerTableAdapter();
            this.orderOutBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.orderOutTableAdapter = new MainProject.Database.FarmManageDataSetTableAdapters.OrderOutTableAdapter();
            this.companyTableAdapter = new MainProject.Database.FarmManageDataSetTableAdapters.CompanyTableAdapter();
            this.postCodeTableAdapter = new MainProject.Database.FarmManageDataSetTableAdapters.PostCodeTableAdapter();
            this.districtTableAdapter = new MainProject.Database.FarmManageDataSetTableAdapters.DistrictTableAdapter();
            this.cityTableAdapter = new MainProject.Database.FarmManageDataSetTableAdapters.CityTableAdapter();
            this.provinceTableAdapter = new MainProject.Database.FarmManageDataSetTableAdapters.ProvinceTableAdapter();
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
            ((System.ComponentModel.ISupportInitialize)(this.corralBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.farmManageDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.geneBindingSource)).BeginInit();
            this.pnlListFooter.SuspendLayout();
            this.tabCustomer.SuspendLayout();
            this.gbxCustomer.SuspendLayout();
            this.pnlCustomerContent.SuspendLayout();
            this.pnlCustomerDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.provinceBindingSource)).BeginInit();
            this.flowLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.companyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.districtBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cityBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.postCodeBindingSource)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel4.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.tabOrderOut.SuspendLayout();
            this.gbxOrderIn.SuspendLayout();
            this.pnlOrderInContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usersViewBindingSource)).BeginInit();
            this.tabPayment.SuspendLayout();
            this.gbxPayment.SuspendLayout();
            this.pnlPaymentContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usersViewBindingSource1)).BeginInit();
            this.tabFinish.SuspendLayout();
            this.pnlFinishContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stockBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderOutBindingSource)).BeginInit();
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
            this.lblTitle.Text = "วิซาร์ดการขายโค";
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
            this.pnlNav.Controls.Add(this.lblCustomer, 0, 4);
            this.pnlNav.Controls.Add(this.lblOrderIn, 0, 6);
            this.pnlNav.Controls.Add(this.lblPayment, 0, 8);
            this.pnlNav.Controls.Add(this.lblFinish, 0, 10);
            this.pnlNav.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlNav.Location = new System.Drawing.Point(0, 0);
            this.pnlNav.Name = "pnlNav";
            this.pnlNav.RowCount = 16;
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
            this.pnlNav.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.pnlNav.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
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
            // lblCustomer
            // 
            this.lblCustomer.AutoSize = true;
            this.lblCustomer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblCustomer.Location = new System.Drawing.Point(3, 62);
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
            this.lblOrderIn.Location = new System.Drawing.Point(3, 93);
            this.lblOrderIn.Name = "lblOrderIn";
            this.lblOrderIn.Size = new System.Drawing.Size(154, 28);
            this.lblOrderIn.TabIndex = 4;
            this.lblOrderIn.Text = "ข้อมูลการขาย";
            this.lblOrderIn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPayment
            // 
            this.lblPayment.AutoSize = true;
            this.lblPayment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblPayment.Location = new System.Drawing.Point(3, 124);
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
            this.lblFinish.Location = new System.Drawing.Point(3, 155);
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
            this.tcMain.Controls.Add(this.tabCustomer);
            this.tcMain.Controls.Add(this.tabOrderOut);
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
            this.lblWelcomeDescription.Text = "ขอต้อนรับเข้าสู่ วิซาร์ดการขายโค";
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
            this.gbxCow.Text = "รายการขาย";
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
            this.colID,
            this.colCowNO,
            this.colCowCorral,
            this.colCowGene,
            this.colCowSex,
            this.colCowOrderInAmount,
            this.colCowOrderOutAmount,
            this.colCowProfitAmount});
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
            // colID
            // 
            this.colID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colID.HeaderText = "ลำดับ";
            this.colID.Name = "colID";
            this.colID.ReadOnly = true;
            this.colID.Width = 57;
            // 
            // colCowNO
            // 
            this.colCowNO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colCowNO.HeaderText = "NO";
            this.colCowNO.Name = "colCowNO";
            this.colCowNO.ReadOnly = true;
            this.colCowNO.Width = 48;
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
            // farmManageDataSet
            // 
            this.farmManageDataSet.DataSetName = "FarmManageDataSet";
            this.farmManageDataSet.Locale = new System.Globalization.CultureInfo("en");
            this.farmManageDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // colCowSex
            // 
            this.colCowSex.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colCowSex.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.colCowSex.HeaderText = "เพศ";
            this.colCowSex.MinimumWidth = 50;
            this.colCowSex.Name = "colCowSex";
            this.colCowSex.ReadOnly = true;
            // 
            // colCowOrderInAmount
            // 
            this.colCowOrderInAmount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colCowOrderInAmount.HeaderText = "ราคาซื้อ";
            this.colCowOrderInAmount.MinimumWidth = 50;
            this.colCowOrderInAmount.Name = "colCowOrderInAmount";
            this.colCowOrderInAmount.ReadOnly = true;
            // 
            // colCowOrderOutAmount
            // 
            this.colCowOrderOutAmount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colCowOrderOutAmount.HeaderText = "ราคาขาย";
            this.colCowOrderOutAmount.MinimumWidth = 50;
            this.colCowOrderOutAmount.Name = "colCowOrderOutAmount";
            // 
            // colCowProfitAmount
            // 
            this.colCowProfitAmount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle1.Format = "N2";
            dataGridViewCellStyle1.NullValue = "0";
            this.colCowProfitAmount.DefaultCellStyle = dataGridViewCellStyle1;
            this.colCowProfitAmount.HeaderText = "กำไร";
            this.colCowProfitAmount.MinimumWidth = 50;
            this.colCowProfitAmount.Name = "colCowProfitAmount";
            this.colCowProfitAmount.ReadOnly = true;
            this.colCowProfitAmount.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colCowProfitAmount.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
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
            this.pnlCustomerDetail.Controls.Add(this.cbxProvince, 5, 17);
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
            this.pnlCustomerDetail.Controls.Add(this.label2, 1, 3);
            this.pnlCustomerDetail.Controls.Add(this.tbxCustomerPID, 2, 3);
            this.pnlCustomerDetail.Controls.Add(this.cbxCompany, 2, 9);
            this.pnlCustomerDetail.Controls.Add(this.cbxDistrict, 2, 17);
            this.pnlCustomerDetail.Controls.Add(this.cbxCity, 5, 15);
            this.pnlCustomerDetail.Controls.Add(this.cbxPostCode, 5, 19);
            this.pnlCustomerDetail.Controls.Add(this.lblCountryValue, 2, 19);
            this.pnlCustomerDetail.Controls.Add(this.flowLayoutPanel1, 4, 9);
            this.pnlCustomerDetail.Controls.Add(this.flowLayoutPanel4, 4, 3);
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
            this.cbxProvince.MaxLength = 64;
            this.cbxProvince.Name = "cbxProvince";
            this.cbxProvince.Size = new System.Drawing.Size(169, 21);
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
            // 
            // lblPostCode
            // 
            this.lblPostCode.AutoSize = true;
            this.lblPostCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPostCode.Location = new System.Drawing.Point(304, 262);
            this.lblPostCode.Name = "lblPostCode";
            this.lblPostCode.Size = new System.Drawing.Size(81, 25);
            this.lblPostCode.TabIndex = 22;
            this.lblPostCode.Text = "รหัสไปรษณีย์ *";
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(32, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 25);
            this.label2.TabIndex = 30;
            this.label2.Text = "เลขประจำตัว *";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbxCustomerPID
            // 
            this.tbxCustomerPID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "CustomerPID", true));
            this.tbxCustomerPID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxCustomerPID.Location = new System.Drawing.Point(119, 41);
            this.tbxCustomerPID.Name = "tbxCustomerPID";
            this.tbxCustomerPID.Size = new System.Drawing.Size(169, 20);
            this.tbxCustomerPID.TabIndex = 31;
            // 
            // cbxCompany
            // 
            this.cbxCompany.DataSource = this.companyBindingSource;
            this.cbxCompany.DisplayMember = "Name";
            this.cbxCompany.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbxCompany.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCompany.Enabled = false;
            this.cbxCompany.FormattingEnabled = true;
            this.cbxCompany.Location = new System.Drawing.Point(119, 125);
            this.cbxCompany.Name = "cbxCompany";
            this.cbxCompany.Size = new System.Drawing.Size(169, 21);
            this.cbxCompany.TabIndex = 32;
            this.cbxCompany.ValueMember = "CompanyID";
            // 
            // companyBindingSource
            // 
            this.companyBindingSource.DataMember = "Company";
            this.companyBindingSource.DataSource = this.farmManageDataSet;
            // 
            // cbxDistrict
            // 
            this.cbxDistrict.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.customerBindingSource, "DistrictID", true));
            this.cbxDistrict.DataSource = this.districtBindingSource;
            this.cbxDistrict.DisplayMember = "Name";
            this.cbxDistrict.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbxDistrict.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxDistrict.Enabled = false;
            this.cbxDistrict.FormattingEnabled = true;
            this.cbxDistrict.Location = new System.Drawing.Point(119, 237);
            this.cbxDistrict.Name = "cbxDistrict";
            this.cbxDistrict.Size = new System.Drawing.Size(169, 21);
            this.cbxDistrict.TabIndex = 35;
            this.cbxDistrict.ValueMember = "DistrictID";
            // 
            // districtBindingSource
            // 
            this.districtBindingSource.DataMember = "District";
            this.districtBindingSource.DataSource = this.farmManageDataSet;
            // 
            // cbxCity
            // 
            this.cbxCity.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.customerBindingSource, "CityID", true));
            this.cbxCity.DataSource = this.cityBindingSource;
            this.cbxCity.DisplayMember = "Name";
            this.cbxCity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbxCity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCity.Enabled = false;
            this.cbxCity.FormattingEnabled = true;
            this.cbxCity.Location = new System.Drawing.Point(391, 209);
            this.cbxCity.Name = "cbxCity";
            this.cbxCity.Size = new System.Drawing.Size(169, 21);
            this.cbxCity.TabIndex = 36;
            this.cbxCity.ValueMember = "CityID";
            // 
            // cityBindingSource
            // 
            this.cityBindingSource.DataMember = "City";
            this.cityBindingSource.DataSource = this.farmManageDataSet;
            // 
            // cbxPostCode
            // 
            this.cbxPostCode.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.customerBindingSource, "PostcodeID", true));
            this.cbxPostCode.DataSource = this.postCodeBindingSource;
            this.cbxPostCode.DisplayMember = "PostCode";
            this.cbxPostCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbxPostCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxPostCode.Enabled = false;
            this.cbxPostCode.FormattingEnabled = true;
            this.cbxPostCode.Location = new System.Drawing.Point(391, 265);
            this.cbxPostCode.Name = "cbxPostCode";
            this.cbxPostCode.Size = new System.Drawing.Size(169, 21);
            this.cbxPostCode.TabIndex = 37;
            this.cbxPostCode.ValueMember = "PostCodeID";
            // 
            // postCodeBindingSource
            // 
            this.postCodeBindingSource.DataMember = "PostCode";
            this.postCodeBindingSource.DataSource = this.farmManageDataSet;
            // 
            // lblCountryValue
            // 
            this.lblCountryValue.AutoSize = true;
            this.lblCountryValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCountryValue.Location = new System.Drawing.Point(119, 262);
            this.lblCountryValue.Name = "lblCountryValue";
            this.lblCountryValue.Size = new System.Drawing.Size(169, 25);
            this.lblCountryValue.TabIndex = 38;
            this.lblCountryValue.Text = "ประเทศไทย";
            this.lblCountryValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // flowLayoutPanel1
            // 
            this.pnlCustomerDetail.SetColumnSpan(this.flowLayoutPanel1, 2);
            this.flowLayoutPanel1.Controls.Add(this.btnAddCompany);
            this.flowLayoutPanel1.Controls.Add(this.btnClearCompany);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(301, 122);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.pnlCustomerDetail.SetRowSpan(this.flowLayoutPanel1, 2);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(262, 28);
            this.flowLayoutPanel1.TabIndex = 39;
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
            // flowLayoutPanel4
            // 
            this.pnlCustomerDetail.SetColumnSpan(this.flowLayoutPanel4, 2);
            this.flowLayoutPanel4.Controls.Add(this.btnCheckPID);
            this.flowLayoutPanel4.Controls.Add(this.btnClearPID);
            this.flowLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel4.Location = new System.Drawing.Point(301, 38);
            this.flowLayoutPanel4.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.pnlCustomerDetail.SetRowSpan(this.flowLayoutPanel4, 2);
            this.flowLayoutPanel4.Size = new System.Drawing.Size(262, 28);
            this.flowLayoutPanel4.TabIndex = 40;
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
            // tabOrderOut
            // 
            this.tabOrderOut.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabOrderOut.Controls.Add(this.gbxOrderIn);
            this.tabOrderOut.Location = new System.Drawing.Point(4, 22);
            this.tabOrderOut.Name = "tabOrderOut";
            this.tabOrderOut.Padding = new System.Windows.Forms.Padding(3);
            this.tabOrderOut.Size = new System.Drawing.Size(614, 435);
            this.tabOrderOut.TabIndex = 3;
            this.tabOrderOut.Text = "ข้อมูลการขาย";
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
            this.pnlOrderInContent.Controls.Add(this.lblUnit, 1, 9);
            this.pnlOrderInContent.Controls.Add(this.label1, 4, 9);
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
            this.lblOrderType.Text = "ประเภทขาย *";
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
            // usersViewBindingSource
            // 
            this.usersViewBindingSource.DataMember = "UsersView";
            this.usersViewBindingSource.DataSource = this.farmManageDataSet;
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
            // lblUnit
            // 
            this.lblUnit.AutoSize = true;
            this.lblUnit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblUnit.Location = new System.Drawing.Point(24, 122);
            this.lblUnit.Name = "lblUnit";
            this.lblUnit.Size = new System.Drawing.Size(90, 25);
            this.lblUnit.TabIndex = 37;
            this.lblUnit.Text = "น้ำหนัก (กิโลกรัม)";
            this.lblUnit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(308, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 25);
            this.label1.TabIndex = 38;
            this.label1.Text = "ราคาต่อกิโลกรัม";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            this.cbxPaymentStatus.DisplayMember = "Value";
            this.cbxPaymentStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbxPaymentStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxPaymentStatus.FormattingEnabled = true;
            this.cbxPaymentStatus.Location = new System.Drawing.Point(120, 13);
            this.cbxPaymentStatus.Name = "cbxPaymentStatus";
            this.cbxPaymentStatus.Size = new System.Drawing.Size(171, 21);
            this.cbxPaymentStatus.TabIndex = 8;
            this.cbxPaymentStatus.ValueMember = "Key";
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
            this.cbxPaymentBy.DataSource = this.usersViewBindingSource1;
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
            // usersViewBindingSource1
            // 
            this.usersViewBindingSource1.DataMember = "UsersView";
            this.usersViewBindingSource1.DataSource = this.farmManageDataSet;
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
            // stockBindingSource
            // 
            this.stockBindingSource.DataMember = "Stock";
            this.stockBindingSource.DataSource = this.farmManageDataSet;
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
            // orderOutBindingSource
            // 
            this.orderOutBindingSource.DataMember = "OrderOut";
            this.orderOutBindingSource.DataSource = this.farmManageDataSet;
            // 
            // orderOutTableAdapter
            // 
            this.orderOutTableAdapter.ClearBeforeFill = true;
            // 
            // companyTableAdapter
            // 
            this.companyTableAdapter.ClearBeforeFill = true;
            // 
            // postCodeTableAdapter
            // 
            this.postCodeTableAdapter.ClearBeforeFill = true;
            // 
            // districtTableAdapter
            // 
            this.districtTableAdapter.ClearBeforeFill = true;
            // 
            // cityTableAdapter
            // 
            this.cityTableAdapter.ClearBeforeFill = true;
            // 
            // provinceTableAdapter
            // 
            this.provinceTableAdapter.ClearBeforeFill = true;
            // 
            // OrderOutWizardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 571);
            this.Controls.Add(this.pnlMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OrderOutWizardForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "วิซาร์ดการขายโค";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OrderOutWizardForm_FormClosing);
            this.Load += new System.EventHandler(this.OrderOutWizardForm_Load);
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
            ((System.ComponentModel.ISupportInitialize)(this.corralBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.farmManageDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.geneBindingSource)).EndInit();
            this.pnlListFooter.ResumeLayout(false);
            this.tabCustomer.ResumeLayout(false);
            this.gbxCustomer.ResumeLayout(false);
            this.pnlCustomerContent.ResumeLayout(false);
            this.pnlCustomerDetail.ResumeLayout(false);
            this.pnlCustomerDetail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.provinceBindingSource)).EndInit();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.companyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.districtBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cityBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.postCodeBindingSource)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel4.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.tabOrderOut.ResumeLayout(false);
            this.gbxOrderIn.ResumeLayout(false);
            this.pnlOrderInContent.ResumeLayout(false);
            this.pnlOrderInContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usersViewBindingSource)).EndInit();
            this.tabPayment.ResumeLayout(false);
            this.gbxPayment.ResumeLayout(false);
            this.pnlPaymentContent.ResumeLayout(false);
            this.pnlPaymentContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usersViewBindingSource1)).EndInit();
            this.tabFinish.ResumeLayout(false);
            this.pnlFinishContent.ResumeLayout(false);
            this.pnlFinishContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stockBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderOutBindingSource)).EndInit();
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
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.RadioButton rdoNewCustomer;
        private System.Windows.Forms.RadioButton rdoSelectCustomer;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button btnSelectCustomer;
        private System.Windows.Forms.TabPage tabOrderOut;
        private System.Windows.Forms.GroupBox gbxOrderIn;
        private System.Windows.Forms.TableLayoutPanel pnlOrderInContent;
        private System.Windows.Forms.ComboBox cbxTransportType;
        private System.Windows.Forms.Label lblTransportCost;
        private System.Windows.Forms.Label lblTransportType;
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
        private System.Windows.Forms.TabPage tabFinish;
        private System.Windows.Forms.TableLayoutPanel pnlNav;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblCow;
        private System.Windows.Forms.Label lblCustomer;
        private System.Windows.Forms.Label lblOrderIn;
        private System.Windows.Forms.Label lblPayment;
        private System.Windows.Forms.Label lblFinish;
        private Database.FarmManageDataSet farmManageDataSet;
        private System.Windows.Forms.BindingSource geneBindingSource;
        private Database.FarmManageDataSetTableAdapters.GeneTableAdapter geneTableAdapter;
        private System.Windows.Forms.BindingSource corralBindingSource;
        private Database.FarmManageDataSetTableAdapters.CorralTableAdapter corralTableAdapter;
        private System.Windows.Forms.BindingSource stockBindingSource;
        private Database.FarmManageDataSetTableAdapters.StockTableAdapter stockTableAdapter;
        private System.Windows.Forms.BindingSource usersViewBindingSource;
        private Database.FarmManageDataSetTableAdapters.UsersViewTableAdapter usersViewTableAdapter;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private Database.FarmManageDataSetTableAdapters.CustomerTableAdapter customerTableAdapter;
        private System.Windows.Forms.TableLayoutPanel pnlFinishContent;
        private System.Windows.Forms.Label lblFinishHeader;
        private System.Windows.Forms.Label lblFinishDescription;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblWelcomeHeader;
        private System.Windows.Forms.Label lblWelcomeDescription;
        private System.Windows.Forms.BindingSource orderOutBindingSource;
        private Database.FarmManageDataSetTableAdapters.OrderOutTableAdapter orderOutTableAdapter;
        private System.Windows.Forms.Label lblTransportNO;
        private System.Windows.Forms.Label lblTransportIssueBy;
        private System.Windows.Forms.TextBox tbxTransportNO;
        private System.Windows.Forms.TextBox tbxTransportIssueBy;
        private System.Windows.Forms.BindingSource usersViewBindingSource1;
        private System.Windows.Forms.Label lblUnit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxUnit;
        private System.Windows.Forms.TextBox tbxAmountPerUnit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxCustomerPID;
        private System.Windows.Forms.ComboBox cbxCompany;
        private System.Windows.Forms.BindingSource companyBindingSource;
        private Database.FarmManageDataSetTableAdapters.CompanyTableAdapter companyTableAdapter;
        private System.Windows.Forms.ComboBox cbxDistrict;
        private System.Windows.Forms.ComboBox cbxCity;
        private System.Windows.Forms.ComboBox cbxPostCode;
        private System.Windows.Forms.BindingSource postCodeBindingSource;
        private Database.FarmManageDataSetTableAdapters.PostCodeTableAdapter postCodeTableAdapter;
        private System.Windows.Forms.BindingSource districtBindingSource;
        private Database.FarmManageDataSetTableAdapters.DistrictTableAdapter districtTableAdapter;
        private System.Windows.Forms.Label lblCountryValue;
        private System.Windows.Forms.BindingSource cityBindingSource;
        private Database.FarmManageDataSetTableAdapters.CityTableAdapter cityTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCowNO;
        private System.Windows.Forms.DataGridViewComboBoxColumn colCowCorral;
        private System.Windows.Forms.DataGridViewComboBoxColumn colCowGene;
        private System.Windows.Forms.DataGridViewComboBoxColumn colCowSex;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCowOrderInAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCowOrderOutAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCowProfitAmount;
        private System.Windows.Forms.BindingSource provinceBindingSource;
        private Database.FarmManageDataSetTableAdapters.ProvinceTableAdapter provinceTableAdapter;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private System.Windows.Forms.Button btnAddCompany;
        private System.Windows.Forms.Button btnClearCompany;
        private System.Windows.Forms.Button btnCheckPID;
        private System.Windows.Forms.Button btnClearPID;
    }
}
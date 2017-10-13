namespace MainProject.UserInterface.Customer
{
    partial class CustomerDetailForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlMain = new System.Windows.Forms.TableLayoutPanel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.tcMain = new System.Windows.Forms.TabControl();
            this.tabDetail = new System.Windows.Forms.TabPage();
            this.gbxDetail = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblfName = new System.Windows.Forms.Label();
            this.lbllName = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.tbxfName = new System.Windows.Forms.TextBox();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.farmManageDataSet = new MainProject.Database.FarmManageDataSet();
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
            this.label1 = new System.Windows.Forms.Label();
            this.cbxCity = new System.Windows.Forms.ComboBox();
            this.fKCityDistrictBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fKDistrictProvinceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbxDistrict = new System.Windows.Forms.ComboBox();
            this.cbxPostCode = new System.Windows.Forms.ComboBox();
            this.fKPostCodeDistrictBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbxCompany = new System.Windows.Forms.ComboBox();
            this.companyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblCustomerPID = new System.Windows.Forms.Label();
            this.lblCustomerPIDV = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAddCompany = new System.Windows.Forms.Button();
            this.btnClearCompany = new System.Windows.Forms.Button();
            this.tabAccount = new System.Windows.Forms.TabPage();
            this.gbxAccount = new System.Windows.Forms.GroupBox();
            this.dgvAccount = new System.Windows.Forms.DataGridView();
            this.colBankID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBankName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBankNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBankType = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.colBankBankName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBankBranch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fKBankAccountCustomer5BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabOrder = new System.Windows.Forms.TabPage();
            this.pnlOrderContent = new System.Windows.Forms.TableLayoutPanel();
            this.pnlHistory = new System.Windows.Forms.TableLayoutPanel();
            this.gbxOrderIn = new System.Windows.Forms.GroupBox();
            this.dgvOrderIn = new System.Windows.Forms.DataGridView();
            this.colOrderInID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOrderInType = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.colOrderInDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOrderInUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOrderInAamount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOrderInPaymentStatus = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.fKorderincustomer2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gbxOrderOut = new System.Windows.Forms.GroupBox();
            this.dgvOrderOut = new System.Windows.Forms.DataGridView();
            this.colOrderOutID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOrderOutType = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.colOrderOutDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOrderOutAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOrderOutPaymentStatus = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.fKorderoutcustomer2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabLog = new System.Windows.Forms.TabPage();
            this.userLogUC = new MainProject.UserInterface.Control.UserLogUC();
            this.pnlFooter = new System.Windows.Forms.TableLayoutPanel();
            this.pnlFooterRight = new System.Windows.Forms.FlowLayoutPanel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.pnlFooterLeft = new System.Windows.Forms.FlowLayoutPanel();
            this.btnNewOrderIn = new System.Windows.Forms.Button();
            this.btnNewOrderOut = new System.Windows.Forms.Button();
            this.usersViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userLogBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customerTableAdapter = new MainProject.Database.FarmManageDataSetTableAdapters.CustomerTableAdapter();
            this.companyTableAdapter = new MainProject.Database.FarmManageDataSetTableAdapters.CompanyTableAdapter();
            this.userLogTableAdapter = new MainProject.Database.FarmManageDataSetTableAdapters.UserLogTableAdapter();
            this.usersViewTableAdapter = new MainProject.Database.FarmManageDataSetTableAdapters.UsersViewTableAdapter();
            this.bankAccountTableAdapter = new MainProject.Database.FarmManageDataSetTableAdapters.BankAccountTableAdapter();
            this.orderInTableAdapter = new MainProject.Database.FarmManageDataSetTableAdapters.OrderInTableAdapter();
            this.orderOutTableAdapter = new MainProject.Database.FarmManageDataSetTableAdapters.OrderOutTableAdapter();
            this.provinceTableAdapter = new MainProject.Database.FarmManageDataSetTableAdapters.ProvinceTableAdapter();
            this.districtTableAdapter = new MainProject.Database.FarmManageDataSetTableAdapters.DistrictTableAdapter();
            this.postCodeTableAdapter = new MainProject.Database.FarmManageDataSetTableAdapters.PostCodeTableAdapter();
            this.cityTableAdapter = new MainProject.Database.FarmManageDataSetTableAdapters.CityTableAdapter();
            this.pnlMain.SuspendLayout();
            this.tcMain.SuspendLayout();
            this.tabDetail.SuspendLayout();
            this.gbxDetail.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.farmManageDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.provinceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKCityDistrictBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKDistrictProvinceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKPostCodeDistrictBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyBindingSource)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.tabAccount.SuspendLayout();
            this.gbxAccount.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKBankAccountCustomer5BindingSource)).BeginInit();
            this.tabOrder.SuspendLayout();
            this.pnlOrderContent.SuspendLayout();
            this.pnlHistory.SuspendLayout();
            this.gbxOrderIn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderIn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKorderincustomer2BindingSource)).BeginInit();
            this.gbxOrderOut.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderOut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKorderoutcustomer2BindingSource)).BeginInit();
            this.tabLog.SuspendLayout();
            this.pnlFooter.SuspendLayout();
            this.pnlFooterRight.SuspendLayout();
            this.pnlFooterLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usersViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userLogBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.pnlMain.ColumnCount = 1;
            this.pnlMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlMain.Controls.Add(this.lblTitle, 0, 0);
            this.pnlMain.Controls.Add(this.tcMain, 0, 1);
            this.pnlMain.Controls.Add(this.pnlFooter, 0, 2);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.RowCount = 3;
            this.pnlMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.pnlMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.pnlMain.Size = new System.Drawing.Size(594, 521);
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
            this.lblTitle.Size = new System.Drawing.Size(586, 60);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "รายละเอียดลูกค้า";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tcMain
            // 
            this.tcMain.Controls.Add(this.tabDetail);
            this.tcMain.Controls.Add(this.tabAccount);
            this.tcMain.Controls.Add(this.tabOrder);
            this.tcMain.Controls.Add(this.tabLog);
            this.tcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcMain.Location = new System.Drawing.Point(4, 65);
            this.tcMain.Name = "tcMain";
            this.tcMain.SelectedIndex = 0;
            this.tcMain.Size = new System.Drawing.Size(586, 411);
            this.tcMain.TabIndex = 2;
            // 
            // tabDetail
            // 
            this.tabDetail.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabDetail.Controls.Add(this.gbxDetail);
            this.tabDetail.Location = new System.Drawing.Point(4, 22);
            this.tabDetail.Name = "tabDetail";
            this.tabDetail.Padding = new System.Windows.Forms.Padding(3);
            this.tabDetail.Size = new System.Drawing.Size(578, 385);
            this.tabDetail.TabIndex = 0;
            this.tabDetail.Text = "รายละเอียด";
            // 
            // gbxDetail
            // 
            this.gbxDetail.Controls.Add(this.tableLayoutPanel1);
            this.gbxDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbxDetail.Location = new System.Drawing.Point(3, 3);
            this.gbxDetail.Name = "gbxDetail";
            this.gbxDetail.Size = new System.Drawing.Size(572, 379);
            this.gbxDetail.TabIndex = 0;
            this.gbxDetail.TabStop = false;
            this.gbxDetail.Text = "รายละเอียด";
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
            this.tableLayoutPanel1.Controls.Add(this.label1, 2, 17);
            this.tableLayoutPanel1.Controls.Add(this.cbxCity, 5, 13);
            this.tableLayoutPanel1.Controls.Add(this.cbxDistrict, 2, 15);
            this.tableLayoutPanel1.Controls.Add(this.cbxPostCode, 5, 17);
            this.tableLayoutPanel1.Controls.Add(this.cbxCompany, 2, 7);
            this.tableLayoutPanel1.Controls.Add(this.lblCustomerPID, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblCustomerPIDV, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 4, 7);
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(566, 360);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // lblfName
            // 
            this.lblfName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblfName.Location = new System.Drawing.Point(30, 66);
            this.lblfName.Name = "lblfName";
            this.lblfName.Size = new System.Drawing.Size(77, 25);
            this.lblfName.TabIndex = 0;
            this.lblfName.Text = "ชื่อ *";
            this.lblfName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbllName
            // 
            this.lbllName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbllName.Location = new System.Drawing.Point(289, 66);
            this.lbllName.Name = "lbllName";
            this.lbllName.Size = new System.Drawing.Size(77, 25);
            this.lbllName.TabIndex = 2;
            this.lbllName.Text = "นามสกุล *";
            this.lbllName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblAddress
            // 
            this.lblAddress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAddress.Location = new System.Drawing.Point(30, 122);
            this.lblAddress.Name = "lblAddress";
            this.tableLayoutPanel1.SetRowSpan(this.lblAddress, 3);
            this.lblAddress.Size = new System.Drawing.Size(77, 53);
            this.lblAddress.TabIndex = 3;
            this.lblAddress.Text = "ที่อยู่ *";
            this.lblAddress.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbxfName
            // 
            this.tbxfName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "Firstname", true));
            this.tbxfName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxfName.Location = new System.Drawing.Point(113, 69);
            this.tbxfName.Name = "tbxfName";
            this.tbxfName.Size = new System.Drawing.Size(160, 20);
            this.tbxfName.TabIndex = 0;
            this.tbxfName.Validating += new System.ComponentModel.CancelEventHandler(this.tbx_Validating);
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataMember = "Customer";
            this.customerBindingSource.DataSource = this.farmManageDataSet;
            // 
            // farmManageDataSet
            // 
            this.farmManageDataSet.DataSetName = "FarmManageDataSet";
            this.farmManageDataSet.Locale = new System.Globalization.CultureInfo("en");
            this.farmManageDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbxlName
            // 
            this.tbxlName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "Lastname", true));
            this.tbxlName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxlName.Location = new System.Drawing.Point(372, 69);
            this.tbxlName.Name = "tbxlName";
            this.tbxlName.Size = new System.Drawing.Size(160, 20);
            this.tbxlName.TabIndex = 1;
            this.tbxlName.Validating += new System.ComponentModel.CancelEventHandler(this.tbx_Validating);
            // 
            // tbxAddress
            // 
            this.tbxAddress.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "Address", true));
            this.tbxAddress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxAddress.Location = new System.Drawing.Point(113, 125);
            this.tbxAddress.Multiline = true;
            this.tbxAddress.Name = "tbxAddress";
            this.tableLayoutPanel1.SetRowSpan(this.tbxAddress, 3);
            this.tbxAddress.Size = new System.Drawing.Size(160, 47);
            this.tbxAddress.TabIndex = 3;
            this.tbxAddress.Validating += new System.ComponentModel.CancelEventHandler(this.tbx_Validating);
            // 
            // lblCompany
            // 
            this.lblCompany.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCompany.Location = new System.Drawing.Point(30, 94);
            this.lblCompany.Name = "lblCompany";
            this.lblCompany.Size = new System.Drawing.Size(77, 25);
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
            this.cbxProvince.FormattingEnabled = true;
            this.cbxProvince.Location = new System.Drawing.Point(372, 209);
            this.cbxProvince.Name = "cbxProvince";
            this.cbxProvince.Size = new System.Drawing.Size(160, 21);
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
            this.lblProvince.Location = new System.Drawing.Point(289, 206);
            this.lblProvince.Name = "lblProvince";
            this.lblProvince.Size = new System.Drawing.Size(77, 25);
            this.lblProvince.TabIndex = 17;
            this.lblProvince.Text = "จังหวัด *";
            this.lblProvince.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblDistrict
            // 
            this.lblDistrict.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDistrict.Location = new System.Drawing.Point(30, 206);
            this.lblDistrict.Name = "lblDistrict";
            this.lblDistrict.Size = new System.Drawing.Size(77, 25);
            this.lblDistrict.TabIndex = 16;
            this.lblDistrict.Text = "อำเภอ *";
            this.lblDistrict.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblStreed
            // 
            this.lblStreed.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblStreed.Location = new System.Drawing.Point(30, 178);
            this.lblStreed.Name = "lblStreed";
            this.lblStreed.Size = new System.Drawing.Size(77, 25);
            this.lblStreed.TabIndex = 6;
            this.lblStreed.Text = "ถนน";
            this.lblStreed.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbxStreed
            // 
            this.tbxStreed.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "Streed", true));
            this.tbxStreed.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxStreed.Location = new System.Drawing.Point(113, 181);
            this.tbxStreed.Name = "tbxStreed";
            this.tbxStreed.Size = new System.Drawing.Size(160, 20);
            this.tbxStreed.TabIndex = 4;
            // 
            // lblCity
            // 
            this.lblCity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCity.Location = new System.Drawing.Point(289, 178);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(77, 25);
            this.lblCity.TabIndex = 7;
            this.lblCity.Text = "ตำบล *";
            this.lblCity.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPhone
            // 
            this.lblPhone.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPhone.Location = new System.Drawing.Point(30, 262);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(77, 25);
            this.lblPhone.TabIndex = 1;
            this.lblPhone.Text = "เบอร์โทรศัพท์";
            this.lblPhone.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbxPhone
            // 
            this.tbxPhone.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "Tel", true));
            this.tbxPhone.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxPhone.Location = new System.Drawing.Point(113, 265);
            this.tbxPhone.Name = "tbxPhone";
            this.tbxPhone.Size = new System.Drawing.Size(160, 20);
            this.tbxPhone.TabIndex = 8;
            this.tbxPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxPhoneNumber_KeyPress);
            // 
            // lblMobile
            // 
            this.lblMobile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMobile.Location = new System.Drawing.Point(289, 262);
            this.lblMobile.Name = "lblMobile";
            this.lblMobile.Size = new System.Drawing.Size(77, 25);
            this.lblMobile.TabIndex = 20;
            this.lblMobile.Text = "มือถือ";
            this.lblMobile.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbxMobile
            // 
            this.tbxMobile.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "Mobile", true));
            this.tbxMobile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxMobile.Location = new System.Drawing.Point(372, 265);
            this.tbxMobile.Name = "tbxMobile";
            this.tbxMobile.Size = new System.Drawing.Size(160, 20);
            this.tbxMobile.TabIndex = 9;
            this.tbxMobile.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxPhoneNumber_KeyPress);
            // 
            // lblPostCode
            // 
            this.lblPostCode.AutoSize = true;
            this.lblPostCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPostCode.Location = new System.Drawing.Point(289, 234);
            this.lblPostCode.Name = "lblPostCode";
            this.lblPostCode.Size = new System.Drawing.Size(77, 25);
            this.lblPostCode.TabIndex = 22;
            this.lblPostCode.Text = "รหัสไปรษณีย์ *";
            this.lblPostCode.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCountry.Location = new System.Drawing.Point(30, 234);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(77, 25);
            this.lblCountry.TabIndex = 23;
            this.lblCountry.Text = "ประเทศ *";
            this.lblCountry.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPrename
            // 
            this.lblPrename.AutoSize = true;
            this.lblPrename.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPrename.Location = new System.Drawing.Point(30, 38);
            this.lblPrename.Name = "lblPrename";
            this.lblPrename.Size = new System.Drawing.Size(77, 25);
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
            this.cbxPrename.FormattingEnabled = true;
            this.cbxPrename.Location = new System.Drawing.Point(113, 41);
            this.cbxPrename.Name = "cbxPrename";
            this.cbxPrename.Size = new System.Drawing.Size(160, 21);
            this.cbxPrename.TabIndex = 26;
            this.cbxPrename.ValueMember = "Key";
            this.cbxPrename.Validating += new System.ComponentModel.CancelEventHandler(this.cbx_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(113, 234);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 25);
            this.label1.TabIndex = 27;
            this.label1.Text = "ประเทศไทย";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbxCity
            // 
            this.cbxCity.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.customerBindingSource, "CityID", true));
            this.cbxCity.DataSource = this.fKCityDistrictBindingSource;
            this.cbxCity.DisplayMember = "Name";
            this.cbxCity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbxCity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCity.FormattingEnabled = true;
            this.cbxCity.Location = new System.Drawing.Point(372, 181);
            this.cbxCity.Name = "cbxCity";
            this.cbxCity.Size = new System.Drawing.Size(160, 21);
            this.cbxCity.TabIndex = 28;
            this.cbxCity.ValueMember = "CityID";
            // 
            // fKCityDistrictBindingSource
            // 
            this.fKCityDistrictBindingSource.DataMember = "FK_City_District";
            this.fKCityDistrictBindingSource.DataSource = this.fKDistrictProvinceBindingSource;
            // 
            // fKDistrictProvinceBindingSource
            // 
            this.fKDistrictProvinceBindingSource.DataMember = "FK_District_Province";
            this.fKDistrictProvinceBindingSource.DataSource = this.provinceBindingSource;
            // 
            // cbxDistrict
            // 
            this.cbxDistrict.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.customerBindingSource, "DistrictID", true));
            this.cbxDistrict.DataSource = this.fKDistrictProvinceBindingSource;
            this.cbxDistrict.DisplayMember = "Name";
            this.cbxDistrict.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbxDistrict.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxDistrict.FormattingEnabled = true;
            this.cbxDistrict.Location = new System.Drawing.Point(113, 209);
            this.cbxDistrict.Name = "cbxDistrict";
            this.cbxDistrict.Size = new System.Drawing.Size(160, 21);
            this.cbxDistrict.TabIndex = 29;
            this.cbxDistrict.ValueMember = "DistrictID";
            // 
            // cbxPostCode
            // 
            this.cbxPostCode.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.customerBindingSource, "PostcodeID", true));
            this.cbxPostCode.DataSource = this.fKPostCodeDistrictBindingSource;
            this.cbxPostCode.DisplayMember = "PostCode";
            this.cbxPostCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbxPostCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxPostCode.FormattingEnabled = true;
            this.cbxPostCode.Location = new System.Drawing.Point(372, 237);
            this.cbxPostCode.Name = "cbxPostCode";
            this.cbxPostCode.Size = new System.Drawing.Size(160, 21);
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
            this.cbxCompany.FormattingEnabled = true;
            this.cbxCompany.Location = new System.Drawing.Point(113, 97);
            this.cbxCompany.Name = "cbxCompany";
            this.cbxCompany.Size = new System.Drawing.Size(160, 21);
            this.cbxCompany.TabIndex = 32;
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
            this.lblCustomerPID.Location = new System.Drawing.Point(30, 10);
            this.lblCustomerPID.Name = "lblCustomerPID";
            this.lblCustomerPID.Size = new System.Drawing.Size(77, 25);
            this.lblCustomerPID.TabIndex = 33;
            this.lblCustomerPID.Text = "เลขประจำตัว";
            this.lblCustomerPID.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCustomerPIDV
            // 
            this.lblCustomerPIDV.AutoSize = true;
            this.lblCustomerPIDV.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "CustomerPID", true));
            this.lblCustomerPIDV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCustomerPIDV.Location = new System.Drawing.Point(113, 10);
            this.lblCustomerPIDV.Name = "lblCustomerPIDV";
            this.lblCustomerPIDV.Size = new System.Drawing.Size(160, 25);
            this.lblCustomerPIDV.TabIndex = 34;
            this.lblCustomerPIDV.Text = "-";
            this.lblCustomerPIDV.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // flowLayoutPanel1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.flowLayoutPanel1, 2);
            this.flowLayoutPanel1.Controls.Add(this.btnAddCompany);
            this.flowLayoutPanel1.Controls.Add(this.btnClearCompany);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(286, 94);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(249, 25);
            this.flowLayoutPanel1.TabIndex = 35;
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
            // tabAccount
            // 
            this.tabAccount.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabAccount.Controls.Add(this.gbxAccount);
            this.tabAccount.Location = new System.Drawing.Point(4, 22);
            this.tabAccount.Name = "tabAccount";
            this.tabAccount.Padding = new System.Windows.Forms.Padding(3);
            this.tabAccount.Size = new System.Drawing.Size(578, 385);
            this.tabAccount.TabIndex = 2;
            this.tabAccount.Text = "ข้อมูลบัญชี";
            // 
            // gbxAccount
            // 
            this.gbxAccount.Controls.Add(this.dgvAccount);
            this.gbxAccount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbxAccount.Location = new System.Drawing.Point(3, 3);
            this.gbxAccount.Name = "gbxAccount";
            this.gbxAccount.Size = new System.Drawing.Size(572, 379);
            this.gbxAccount.TabIndex = 0;
            this.gbxAccount.TabStop = false;
            this.gbxAccount.Text = "ข้อมูลบัญชี";
            // 
            // dgvAccount
            // 
            this.dgvAccount.AllowUserToAddRows = false;
            this.dgvAccount.AllowUserToDeleteRows = false;
            this.dgvAccount.AutoGenerateColumns = false;
            this.dgvAccount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAccount.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colBankID,
            this.colBankName,
            this.colBankNO,
            this.colBankType,
            this.colBankBankName,
            this.colBankBranch});
            this.dgvAccount.DataSource = this.fKBankAccountCustomer5BindingSource;
            this.dgvAccount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAccount.Location = new System.Drawing.Point(3, 16);
            this.dgvAccount.Name = "dgvAccount";
            this.dgvAccount.ReadOnly = true;
            this.dgvAccount.Size = new System.Drawing.Size(566, 360);
            this.dgvAccount.TabIndex = 0;
            // 
            // colBankID
            // 
            this.colBankID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colBankID.DataPropertyName = "BankAccountID";
            this.colBankID.HeaderText = "#";
            this.colBankID.Name = "colBankID";
            this.colBankID.ReadOnly = true;
            this.colBankID.Width = 39;
            // 
            // colBankName
            // 
            this.colBankName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colBankName.DataPropertyName = "Name";
            this.colBankName.HeaderText = "ชื่อบัญชี";
            this.colBankName.Name = "colBankName";
            this.colBankName.ReadOnly = true;
            // 
            // colBankNO
            // 
            this.colBankNO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colBankNO.DataPropertyName = "NO";
            this.colBankNO.HeaderText = "เลขบัญชี";
            this.colBankNO.Name = "colBankNO";
            this.colBankNO.ReadOnly = true;
            // 
            // colBankType
            // 
            this.colBankType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colBankType.DataPropertyName = "Type";
            this.colBankType.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.colBankType.HeaderText = "ประเภท";
            this.colBankType.Name = "colBankType";
            this.colBankType.ReadOnly = true;
            this.colBankType.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colBankType.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // colBankBankName
            // 
            this.colBankBankName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colBankBankName.DataPropertyName = "BankName";
            this.colBankBankName.HeaderText = "ชื่อธนาคาร";
            this.colBankBankName.Name = "colBankBankName";
            this.colBankBankName.ReadOnly = true;
            // 
            // colBankBranch
            // 
            this.colBankBranch.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colBankBranch.DataPropertyName = "Branch";
            this.colBankBranch.HeaderText = "สาขา";
            this.colBankBranch.Name = "colBankBranch";
            this.colBankBranch.ReadOnly = true;
            // 
            // fKBankAccountCustomer5BindingSource
            // 
            this.fKBankAccountCustomer5BindingSource.DataMember = "FK_BankAccount_Customer5";
            this.fKBankAccountCustomer5BindingSource.DataSource = this.customerBindingSource;
            // 
            // tabOrder
            // 
            this.tabOrder.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabOrder.Controls.Add(this.pnlOrderContent);
            this.tabOrder.Location = new System.Drawing.Point(4, 22);
            this.tabOrder.Name = "tabOrder";
            this.tabOrder.Padding = new System.Windows.Forms.Padding(3);
            this.tabOrder.Size = new System.Drawing.Size(578, 385);
            this.tabOrder.TabIndex = 1;
            this.tabOrder.Text = "ประวัติการซื้อขาย";
            // 
            // pnlOrderContent
            // 
            this.pnlOrderContent.ColumnCount = 1;
            this.pnlOrderContent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.pnlOrderContent.Controls.Add(this.pnlHistory, 0, 0);
            this.pnlOrderContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlOrderContent.Location = new System.Drawing.Point(3, 3);
            this.pnlOrderContent.Name = "pnlOrderContent";
            this.pnlOrderContent.RowCount = 1;
            this.pnlOrderContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.pnlOrderContent.Size = new System.Drawing.Size(572, 379);
            this.pnlOrderContent.TabIndex = 0;
            // 
            // pnlHistory
            // 
            this.pnlHistory.ColumnCount = 1;
            this.pnlHistory.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.pnlHistory.Controls.Add(this.gbxOrderIn, 0, 0);
            this.pnlHistory.Controls.Add(this.gbxOrderOut, 0, 1);
            this.pnlHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlHistory.Location = new System.Drawing.Point(3, 3);
            this.pnlHistory.Name = "pnlHistory";
            this.pnlHistory.RowCount = 2;
            this.pnlHistory.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.pnlHistory.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.pnlHistory.Size = new System.Drawing.Size(566, 373);
            this.pnlHistory.TabIndex = 0;
            // 
            // gbxOrderIn
            // 
            this.gbxOrderIn.Controls.Add(this.dgvOrderIn);
            this.gbxOrderIn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbxOrderIn.Location = new System.Drawing.Point(3, 3);
            this.gbxOrderIn.Name = "gbxOrderIn";
            this.gbxOrderIn.Size = new System.Drawing.Size(560, 180);
            this.gbxOrderIn.TabIndex = 0;
            this.gbxOrderIn.TabStop = false;
            this.gbxOrderIn.Text = "ประวัติการนำเข้า";
            // 
            // dgvOrderIn
            // 
            this.dgvOrderIn.AllowUserToAddRows = false;
            this.dgvOrderIn.AllowUserToDeleteRows = false;
            this.dgvOrderIn.AutoGenerateColumns = false;
            this.dgvOrderIn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrderIn.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colOrderInID,
            this.colOrderInType,
            this.colOrderInDate,
            this.colOrderInUnit,
            this.colOrderInAamount,
            this.colOrderInPaymentStatus});
            this.dgvOrderIn.DataSource = this.fKorderincustomer2BindingSource;
            this.dgvOrderIn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvOrderIn.Location = new System.Drawing.Point(3, 16);
            this.dgvOrderIn.Name = "dgvOrderIn";
            this.dgvOrderIn.ReadOnly = true;
            this.dgvOrderIn.Size = new System.Drawing.Size(554, 161);
            this.dgvOrderIn.TabIndex = 0;
            this.dgvOrderIn.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvOrderIn_CellMouseDoubleClick);
            // 
            // colOrderInID
            // 
            this.colOrderInID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colOrderInID.DataPropertyName = "OrderInID";
            this.colOrderInID.HeaderText = "#";
            this.colOrderInID.Name = "colOrderInID";
            this.colOrderInID.ReadOnly = true;
            this.colOrderInID.Width = 39;
            // 
            // colOrderInType
            // 
            this.colOrderInType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colOrderInType.DataPropertyName = "OrderType";
            this.colOrderInType.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.colOrderInType.HeaderText = "ประเภท";
            this.colOrderInType.Name = "colOrderInType";
            this.colOrderInType.ReadOnly = true;
            this.colOrderInType.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colOrderInType.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // colOrderInDate
            // 
            this.colOrderInDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colOrderInDate.DataPropertyName = "Date";
            this.colOrderInDate.HeaderText = "วันที่";
            this.colOrderInDate.Name = "colOrderInDate";
            this.colOrderInDate.ReadOnly = true;
            // 
            // colOrderInUnit
            // 
            this.colOrderInUnit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colOrderInUnit.DataPropertyName = "Unit";
            this.colOrderInUnit.HeaderText = "จำนวน";
            this.colOrderInUnit.Name = "colOrderInUnit";
            this.colOrderInUnit.ReadOnly = true;
            // 
            // colOrderInAamount
            // 
            this.colOrderInAamount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colOrderInAamount.DataPropertyName = "Amount";
            dataGridViewCellStyle1.Format = "C2";
            dataGridViewCellStyle1.NullValue = "0";
            this.colOrderInAamount.DefaultCellStyle = dataGridViewCellStyle1;
            this.colOrderInAamount.HeaderText = "จำนวนเงิน";
            this.colOrderInAamount.Name = "colOrderInAamount";
            this.colOrderInAamount.ReadOnly = true;
            // 
            // colOrderInPaymentStatus
            // 
            this.colOrderInPaymentStatus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colOrderInPaymentStatus.DataPropertyName = "PaymentStatus";
            this.colOrderInPaymentStatus.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.colOrderInPaymentStatus.HeaderText = "สถานะ";
            this.colOrderInPaymentStatus.Name = "colOrderInPaymentStatus";
            this.colOrderInPaymentStatus.ReadOnly = true;
            this.colOrderInPaymentStatus.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colOrderInPaymentStatus.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // fKorderincustomer2BindingSource
            // 
            this.fKorderincustomer2BindingSource.DataMember = "FK_order_in_customer2";
            this.fKorderincustomer2BindingSource.DataSource = this.customerBindingSource;
            // 
            // gbxOrderOut
            // 
            this.gbxOrderOut.Controls.Add(this.dgvOrderOut);
            this.gbxOrderOut.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbxOrderOut.Location = new System.Drawing.Point(3, 189);
            this.gbxOrderOut.Name = "gbxOrderOut";
            this.gbxOrderOut.Size = new System.Drawing.Size(560, 181);
            this.gbxOrderOut.TabIndex = 1;
            this.gbxOrderOut.TabStop = false;
            this.gbxOrderOut.Text = "ประวัติการนำออก";
            // 
            // dgvOrderOut
            // 
            this.dgvOrderOut.AllowUserToAddRows = false;
            this.dgvOrderOut.AllowUserToDeleteRows = false;
            this.dgvOrderOut.AutoGenerateColumns = false;
            this.dgvOrderOut.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrderOut.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colOrderOutID,
            this.colOrderOutType,
            this.colOrderOutDate,
            this.unitDataGridViewTextBoxColumn1,
            this.colOrderOutAmount,
            this.colOrderOutPaymentStatus});
            this.dgvOrderOut.DataSource = this.fKorderoutcustomer2BindingSource;
            this.dgvOrderOut.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvOrderOut.Location = new System.Drawing.Point(3, 16);
            this.dgvOrderOut.Name = "dgvOrderOut";
            this.dgvOrderOut.ReadOnly = true;
            this.dgvOrderOut.Size = new System.Drawing.Size(554, 162);
            this.dgvOrderOut.TabIndex = 0;
            this.dgvOrderOut.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvOrderOut_CellMouseDoubleClick);
            // 
            // colOrderOutID
            // 
            this.colOrderOutID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colOrderOutID.DataPropertyName = "OrderOutID";
            this.colOrderOutID.HeaderText = "#";
            this.colOrderOutID.Name = "colOrderOutID";
            this.colOrderOutID.ReadOnly = true;
            this.colOrderOutID.Width = 39;
            // 
            // colOrderOutType
            // 
            this.colOrderOutType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colOrderOutType.DataPropertyName = "OrderType";
            this.colOrderOutType.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.colOrderOutType.HeaderText = "ประเภท";
            this.colOrderOutType.Name = "colOrderOutType";
            this.colOrderOutType.ReadOnly = true;
            this.colOrderOutType.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colOrderOutType.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // colOrderOutDate
            // 
            this.colOrderOutDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colOrderOutDate.DataPropertyName = "Date";
            this.colOrderOutDate.HeaderText = "วันที่";
            this.colOrderOutDate.Name = "colOrderOutDate";
            this.colOrderOutDate.ReadOnly = true;
            // 
            // unitDataGridViewTextBoxColumn1
            // 
            this.unitDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.unitDataGridViewTextBoxColumn1.DataPropertyName = "Unit";
            this.unitDataGridViewTextBoxColumn1.HeaderText = "จำนวน";
            this.unitDataGridViewTextBoxColumn1.Name = "unitDataGridViewTextBoxColumn1";
            this.unitDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // colOrderOutAmount
            // 
            this.colOrderOutAmount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colOrderOutAmount.DataPropertyName = "Amount";
            dataGridViewCellStyle2.Format = "C2";
            dataGridViewCellStyle2.NullValue = "0";
            this.colOrderOutAmount.DefaultCellStyle = dataGridViewCellStyle2;
            this.colOrderOutAmount.HeaderText = "จำนวนเงิน";
            this.colOrderOutAmount.Name = "colOrderOutAmount";
            this.colOrderOutAmount.ReadOnly = true;
            // 
            // colOrderOutPaymentStatus
            // 
            this.colOrderOutPaymentStatus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colOrderOutPaymentStatus.DataPropertyName = "PaymentStatus";
            this.colOrderOutPaymentStatus.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.colOrderOutPaymentStatus.HeaderText = "สถานะ";
            this.colOrderOutPaymentStatus.Name = "colOrderOutPaymentStatus";
            this.colOrderOutPaymentStatus.ReadOnly = true;
            this.colOrderOutPaymentStatus.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colOrderOutPaymentStatus.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // fKorderoutcustomer2BindingSource
            // 
            this.fKorderoutcustomer2BindingSource.DataMember = "FK_order_out_customer2";
            this.fKorderoutcustomer2BindingSource.DataSource = this.customerBindingSource;
            // 
            // tabLog
            // 
            this.tabLog.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabLog.Controls.Add(this.userLogUC);
            this.tabLog.Location = new System.Drawing.Point(4, 22);
            this.tabLog.Name = "tabLog";
            this.tabLog.Padding = new System.Windows.Forms.Padding(3);
            this.tabLog.Size = new System.Drawing.Size(578, 385);
            this.tabLog.TabIndex = 3;
            this.tabLog.Text = "การบันทึก";
            // 
            // userLogUC
            // 
            this.userLogUC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userLogUC.Location = new System.Drawing.Point(3, 3);
            this.userLogUC.Name = "userLogUC";
            this.userLogUC.Size = new System.Drawing.Size(572, 379);
            this.userLogUC.TabIndex = 0;
            // 
            // pnlFooter
            // 
            this.pnlFooter.ColumnCount = 2;
            this.pnlFooter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.pnlFooter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.pnlFooter.Controls.Add(this.pnlFooterRight, 1, 0);
            this.pnlFooter.Controls.Add(this.pnlFooterLeft, 0, 0);
            this.pnlFooter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFooter.Location = new System.Drawing.Point(4, 483);
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.RowCount = 1;
            this.pnlFooter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlFooter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.pnlFooter.Size = new System.Drawing.Size(586, 34);
            this.pnlFooter.TabIndex = 3;
            // 
            // pnlFooterRight
            // 
            this.pnlFooterRight.Controls.Add(this.btnCancel);
            this.pnlFooterRight.Controls.Add(this.btnSave);
            this.pnlFooterRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFooterRight.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.pnlFooterRight.Location = new System.Drawing.Point(296, 3);
            this.pnlFooterRight.Name = "pnlFooterRight";
            this.pnlFooterRight.Size = new System.Drawing.Size(287, 28);
            this.pnlFooterRight.TabIndex = 0;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(209, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "ยกเลิก";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(128, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "บันทึก";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pnlFooterLeft
            // 
            this.pnlFooterLeft.Controls.Add(this.btnNewOrderIn);
            this.pnlFooterLeft.Controls.Add(this.btnNewOrderOut);
            this.pnlFooterLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFooterLeft.Location = new System.Drawing.Point(3, 3);
            this.pnlFooterLeft.Name = "pnlFooterLeft";
            this.pnlFooterLeft.Size = new System.Drawing.Size(287, 28);
            this.pnlFooterLeft.TabIndex = 1;
            // 
            // btnNewOrderIn
            // 
            this.btnNewOrderIn.Location = new System.Drawing.Point(3, 3);
            this.btnNewOrderIn.Name = "btnNewOrderIn";
            this.btnNewOrderIn.Size = new System.Drawing.Size(100, 23);
            this.btnNewOrderIn.TabIndex = 0;
            this.btnNewOrderIn.Text = "เพิ่มการซื้อ";
            this.btnNewOrderIn.UseVisualStyleBackColor = true;
            this.btnNewOrderIn.Click += new System.EventHandler(this.btnNewOrderIn_Click);
            // 
            // btnNewOrderOut
            // 
            this.btnNewOrderOut.Location = new System.Drawing.Point(109, 3);
            this.btnNewOrderOut.Name = "btnNewOrderOut";
            this.btnNewOrderOut.Size = new System.Drawing.Size(100, 23);
            this.btnNewOrderOut.TabIndex = 1;
            this.btnNewOrderOut.Text = "เพิ่มการขาย";
            this.btnNewOrderOut.UseVisualStyleBackColor = true;
            this.btnNewOrderOut.Click += new System.EventHandler(this.btnNewOrderOut_Click);
            // 
            // usersViewBindingSource
            // 
            this.usersViewBindingSource.DataMember = "UsersView";
            this.usersViewBindingSource.DataSource = this.farmManageDataSet;
            // 
            // userLogBindingSource
            // 
            this.userLogBindingSource.DataMember = "UserLog";
            this.userLogBindingSource.DataSource = this.farmManageDataSet;
            // 
            // customerTableAdapter
            // 
            this.customerTableAdapter.ClearBeforeFill = true;
            // 
            // companyTableAdapter
            // 
            this.companyTableAdapter.ClearBeforeFill = true;
            // 
            // userLogTableAdapter
            // 
            this.userLogTableAdapter.ClearBeforeFill = true;
            // 
            // usersViewTableAdapter
            // 
            this.usersViewTableAdapter.ClearBeforeFill = true;
            // 
            // bankAccountTableAdapter
            // 
            this.bankAccountTableAdapter.ClearBeforeFill = true;
            // 
            // orderInTableAdapter
            // 
            this.orderInTableAdapter.ClearBeforeFill = true;
            // 
            // orderOutTableAdapter
            // 
            this.orderOutTableAdapter.ClearBeforeFill = true;
            // 
            // provinceTableAdapter
            // 
            this.provinceTableAdapter.ClearBeforeFill = true;
            // 
            // districtTableAdapter
            // 
            this.districtTableAdapter.ClearBeforeFill = true;
            // 
            // postCodeTableAdapter
            // 
            this.postCodeTableAdapter.ClearBeforeFill = true;
            // 
            // cityTableAdapter
            // 
            this.cityTableAdapter.ClearBeforeFill = true;
            // 
            // CustomerDetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 521);
            this.Controls.Add(this.pnlMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CustomerDetailForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "รายละเอียดลูกค้า";
            this.Load += new System.EventHandler(this.CustomerDetailForm_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.tcMain.ResumeLayout(false);
            this.tabDetail.ResumeLayout(false);
            this.gbxDetail.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.farmManageDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.provinceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKCityDistrictBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKDistrictProvinceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKPostCodeDistrictBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyBindingSource)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.tabAccount.ResumeLayout(false);
            this.gbxAccount.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKBankAccountCustomer5BindingSource)).EndInit();
            this.tabOrder.ResumeLayout(false);
            this.pnlOrderContent.ResumeLayout(false);
            this.pnlHistory.ResumeLayout(false);
            this.gbxOrderIn.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderIn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKorderincustomer2BindingSource)).EndInit();
            this.gbxOrderOut.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderOut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKorderoutcustomer2BindingSource)).EndInit();
            this.tabLog.ResumeLayout(false);
            this.pnlFooter.ResumeLayout(false);
            this.pnlFooterRight.ResumeLayout(false);
            this.pnlFooterLeft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.usersViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userLogBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel pnlMain;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TabControl tcMain;
        private System.Windows.Forms.TabPage tabDetail;
        private System.Windows.Forms.TabPage tabOrder;
        private System.Windows.Forms.TableLayoutPanel pnlOrderContent;
        private Database.FarmManageDataSet farmManageDataSet;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private Database.FarmManageDataSetTableAdapters.CustomerTableAdapter customerTableAdapter;
        private System.Windows.Forms.GroupBox gbxDetail;
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
        private System.Windows.Forms.TableLayoutPanel pnlHistory;
        private System.Windows.Forms.GroupBox gbxOrderIn;
        private System.Windows.Forms.GroupBox gbxOrderOut;
        private System.Windows.Forms.DataGridView dgvOrderIn;
        private System.Windows.Forms.DataGridView dgvOrderOut;
        private System.Windows.Forms.TableLayoutPanel pnlFooter;
        private System.Windows.Forms.FlowLayoutPanel pnlFooterRight;
        private System.Windows.Forms.FlowLayoutPanel pnlFooterLeft;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnNewOrderIn;
        private System.Windows.Forms.Button btnNewOrderOut;
        private System.Windows.Forms.TabPage tabAccount;
        private System.Windows.Forms.GroupBox gbxAccount;
        private System.Windows.Forms.DataGridView dgvAccount;
        private System.Windows.Forms.TabPage tabLog;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxCity;
        private System.Windows.Forms.ComboBox cbxDistrict;
        private System.Windows.Forms.ComboBox cbxPostCode;
        private System.Windows.Forms.ComboBox cbxCompany;
        private System.Windows.Forms.Label lblCustomerPID;
        private System.Windows.Forms.Label lblCustomerPIDV;
        private System.Windows.Forms.BindingSource companyBindingSource;
        private Database.FarmManageDataSetTableAdapters.CompanyTableAdapter companyTableAdapter;
        private System.Windows.Forms.BindingSource userLogBindingSource;
        private Database.FarmManageDataSetTableAdapters.UserLogTableAdapter userLogTableAdapter;
        private System.Windows.Forms.BindingSource usersViewBindingSource;
        private Database.FarmManageDataSetTableAdapters.UsersViewTableAdapter usersViewTableAdapter;
        private System.Windows.Forms.BindingSource fKBankAccountCustomer5BindingSource;
        private Database.FarmManageDataSetTableAdapters.BankAccountTableAdapter bankAccountTableAdapter;
        private System.Windows.Forms.BindingSource fKorderincustomer2BindingSource;
        private Database.FarmManageDataSetTableAdapters.OrderInTableAdapter orderInTableAdapter;
        private System.Windows.Forms.BindingSource fKorderoutcustomer2BindingSource;
        private Database.FarmManageDataSetTableAdapters.OrderOutTableAdapter orderOutTableAdapter;
        private Control.UserLogUC userLogUC;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnAddCompany;
        private System.Windows.Forms.Button btnClearCompany;
        private System.Windows.Forms.BindingSource provinceBindingSource;
        private Database.FarmManageDataSetTableAdapters.ProvinceTableAdapter provinceTableAdapter;
        private System.Windows.Forms.BindingSource fKDistrictProvinceBindingSource;
        private Database.FarmManageDataSetTableAdapters.DistrictTableAdapter districtTableAdapter;
        private System.Windows.Forms.BindingSource fKPostCodeDistrictBindingSource;
        private Database.FarmManageDataSetTableAdapters.PostCodeTableAdapter postCodeTableAdapter;
        private System.Windows.Forms.BindingSource fKCityDistrictBindingSource;
        private Database.FarmManageDataSetTableAdapters.CityTableAdapter cityTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOrderInID;
        private System.Windows.Forms.DataGridViewComboBoxColumn colOrderInType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOrderInDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOrderInUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOrderInAamount;
        private System.Windows.Forms.DataGridViewComboBoxColumn colOrderInPaymentStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOrderOutID;
        private System.Windows.Forms.DataGridViewComboBoxColumn colOrderOutType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOrderOutDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOrderOutAmount;
        private System.Windows.Forms.DataGridViewComboBoxColumn colOrderOutPaymentStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBankID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBankName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBankNO;
        private System.Windows.Forms.DataGridViewComboBoxColumn colBankType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBankBankName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBankBranch;
    }
}

namespace MainProject.UserInterface.Order
{
    partial class OutOrderForm
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
            this.tcMain = new System.Windows.Forms.TabControl();
            this.tabGeneral = new System.Windows.Forms.TabPage();
            this.pnlGeneralContent = new System.Windows.Forms.TableLayoutPanel();
            this.gbxPayment = new System.Windows.Forms.GroupBox();
            this.pnlPayment = new System.Windows.Forms.TableLayoutPanel();
            this.lblPaymentType = new System.Windows.Forms.Label();
            this.lblPaymentStatus = new System.Windows.Forms.Label();
            this.cbxPaymentType = new System.Windows.Forms.ComboBox();
            this.orderOutBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.farmManageDataSet = new MainProject.Database.FarmManageDataSet();
            this.cbxPaymentStatus = new System.Windows.Forms.ComboBox();
            this.lblPaymentBy = new System.Windows.Forms.Label();
            this.lblPaymentDate = new System.Windows.Forms.Label();
            this.dtpPaymentDate = new System.Windows.Forms.DateTimePicker();
            this.cbxPaymentBy = new System.Windows.Forms.ComboBox();
            this.usersViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gbxGeneral = new System.Windows.Forms.GroupBox();
            this.pnlGeneral = new System.Windows.Forms.TableLayoutPanel();
            this.tbxWeight = new System.Windows.Forms.TextBox();
            this.tbxAmountPerUnit = new System.Windows.Forms.TextBox();
            this.lblPerKilo = new System.Windows.Forms.Label();
            this.tbxTotalAmount = new System.Windows.Forms.TextBox();
            this.lblTotalAmount = new System.Windows.Forms.Label();
            this.cbxTransportType = new System.Windows.Forms.ComboBox();
            this.lblTransportCost = new System.Windows.Forms.Label();
            this.lblTransportType = new System.Windows.Forms.Label();
            this.lblTransportNO = new System.Windows.Forms.Label();
            this.lblTransportIssueBy = new System.Windows.Forms.Label();
            this.tbxTransportNO = new System.Windows.Forms.TextBox();
            this.tbxEr = new System.Windows.Forms.TextBox();
            this.tbxTransportIssueBy = new System.Windows.Forms.TextBox();
            this.lblAmount = new System.Windows.Forms.Label();
            this.tbxAmount = new System.Windows.Forms.TextBox();
            this.tbxTransportCost = new System.Windows.Forms.TextBox();
            this.lblNote = new System.Windows.Forms.Label();
            this.tbxNote = new System.Windows.Forms.TextBox();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblOrderType = new System.Windows.Forms.Label();
            this.cbxOrderType = new System.Windows.Forms.ComboBox();
            this.lblCreateBy = new System.Windows.Forms.Label();
            this.cbxOrderBy = new System.Windows.Forms.ComboBox();
            this.lblEr = new System.Windows.Forms.Label();
            this.lblOrderInAmount = new System.Windows.Forms.Label();
            this.tbxOrderInAmount = new System.Windows.Forms.TextBox();
            this.น้ำหนัก = new System.Windows.Forms.Label();
            this.tabCustomer = new System.Windows.Forms.TabPage();
            this.pnlCustomerContent = new System.Windows.Forms.TableLayoutPanel();
            this.gbxCustomer = new System.Windows.Forms.GroupBox();
            this.pnlCustomer = new System.Windows.Forms.TableLayoutPanel();
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
            this.cbxCompany = new System.Windows.Forms.ComboBox();
            this.cbxCity = new System.Windows.Forms.ComboBox();
            this.fKCityDistrictBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fKDistrictProvinceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbxPostCode = new System.Windows.Forms.ComboBox();
            this.fKPostCodeDistrictBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbxDistrict = new System.Windows.Forms.ComboBox();
            this.lblCountryValue = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCustomerPIDValue = new System.Windows.Forms.Label();
            this.tabCowList = new System.Windows.Forms.TabPage();
            this.gbxOrderOutList = new System.Windows.Forms.GroupBox();
            this.dataCowList = new System.Windows.Forms.DataGridView();
            this.colCowNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCowCorral = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.corralBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colCowGene = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.geneBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colCowSex = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.colCowOrderInID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCowOrderInAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCowOrderOutID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCowOrderOutAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fKCowOrderOutBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabRecord = new System.Windows.Forms.TabPage();
            this.userLogUC = new MainProject.UserInterface.Control.UserLogUC();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlFooter = new System.Windows.Forms.TableLayoutPanel();
            this.pnlLeftFooter = new System.Windows.Forms.FlowLayoutPanel();
            this.btnPrintBill = new System.Windows.Forms.Button();
            this.btnResource = new System.Windows.Forms.Button();
            this.pnlRightFooter = new System.Windows.Forms.FlowLayoutPanel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.orderOutTableAdapter = new MainProject.Database.FarmManageDataSetTableAdapters.OrderOutTableAdapter();
            this.cowTableAdapter = new MainProject.Database.FarmManageDataSetTableAdapters.CowTableAdapter();
            this.corralTableAdapter = new MainProject.Database.FarmManageDataSetTableAdapters.CorralTableAdapter();
            this.geneTableAdapter = new MainProject.Database.FarmManageDataSetTableAdapters.GeneTableAdapter();
            this.usersViewTableAdapter = new MainProject.Database.FarmManageDataSetTableAdapters.UsersViewTableAdapter();
            this.customerTableAdapter = new MainProject.Database.FarmManageDataSetTableAdapters.CustomerTableAdapter();
            this.provinceTableAdapter = new MainProject.Database.FarmManageDataSetTableAdapters.ProvinceTableAdapter();
            this.districtTableAdapter = new MainProject.Database.FarmManageDataSetTableAdapters.DistrictTableAdapter();
            this.cityTableAdapter = new MainProject.Database.FarmManageDataSetTableAdapters.CityTableAdapter();
            this.postCodeTableAdapter = new MainProject.Database.FarmManageDataSetTableAdapters.PostCodeTableAdapter();
            this.pnlMain.SuspendLayout();
            this.tcMain.SuspendLayout();
            this.tabGeneral.SuspendLayout();
            this.pnlGeneralContent.SuspendLayout();
            this.gbxPayment.SuspendLayout();
            this.pnlPayment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderOutBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.farmManageDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersViewBindingSource)).BeginInit();
            this.gbxGeneral.SuspendLayout();
            this.pnlGeneral.SuspendLayout();
            this.tabCustomer.SuspendLayout();
            this.pnlCustomerContent.SuspendLayout();
            this.gbxCustomer.SuspendLayout();
            this.pnlCustomer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.provinceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKCityDistrictBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKDistrictProvinceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKPostCodeDistrictBindingSource)).BeginInit();
            this.tabCowList.SuspendLayout();
            this.gbxOrderOutList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataCowList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.corralBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.geneBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKCowOrderOutBindingSource)).BeginInit();
            this.tabRecord.SuspendLayout();
            this.pnlFooter.SuspendLayout();
            this.pnlLeftFooter.SuspendLayout();
            this.pnlRightFooter.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.ColumnCount = 1;
            this.pnlMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.pnlMain.Controls.Add(this.tcMain, 0, 1);
            this.pnlMain.Controls.Add(this.lblTitle, 0, 0);
            this.pnlMain.Controls.Add(this.pnlFooter, 0, 2);
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
            // tcMain
            // 
            this.tcMain.Controls.Add(this.tabGeneral);
            this.tcMain.Controls.Add(this.tabCustomer);
            this.tcMain.Controls.Add(this.tabCowList);
            this.tcMain.Controls.Add(this.tabRecord);
            this.tcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcMain.Location = new System.Drawing.Point(3, 63);
            this.tcMain.Name = "tcMain";
            this.tcMain.SelectedIndex = 0;
            this.tcMain.Size = new System.Drawing.Size(688, 515);
            this.tcMain.TabIndex = 6;
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
            this.gbxPayment.TabIndex = 2;
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
            this.pnlPayment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPayment.Location = new System.Drawing.Point(3, 16);
            this.pnlPayment.Name = "pnlPayment";
            this.pnlPayment.RowCount = 10;
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
            this.pnlPayment.Size = new System.Drawing.Size(662, 193);
            this.pnlPayment.TabIndex = 1;
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
            this.cbxPaymentType.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.orderOutBindingSource, "PaymentType", true));
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
            // 
            // orderOutBindingSource
            // 
            this.orderOutBindingSource.DataMember = "OrderOut";
            this.orderOutBindingSource.DataSource = this.farmManageDataSet;
            // 
            // farmManageDataSet
            // 
            this.farmManageDataSet.DataSetName = "FarmManageDataSet";
            this.farmManageDataSet.Locale = new System.Globalization.CultureInfo("en");
            this.farmManageDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cbxPaymentStatus
            // 
            this.cbxPaymentStatus.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.orderOutBindingSource, "PaymentStatus", true));
            this.cbxPaymentStatus.DisplayMember = "Value";
            this.cbxPaymentStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbxPaymentStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxPaymentStatus.Enabled = false;
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
            this.lblPaymentBy.Text = "ผู้รับเงิน";
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
            this.dtpPaymentDate.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.orderOutBindingSource, "PaymentDate", true));
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
            this.cbxPaymentBy.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.orderOutBindingSource, "PaymentBy", true));
            this.cbxPaymentBy.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.orderOutBindingSource, "PaymentBy", true));
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
            this.pnlGeneral.Controls.Add(this.tbxWeight, 2, 9);
            this.pnlGeneral.Controls.Add(this.tbxAmountPerUnit, 5, 9);
            this.pnlGeneral.Controls.Add(this.lblPerKilo, 4, 9);
            this.pnlGeneral.Controls.Add(this.tbxTotalAmount, 2, 13);
            this.pnlGeneral.Controls.Add(this.lblTotalAmount, 1, 13);
            this.pnlGeneral.Controls.Add(this.cbxTransportType, 2, 5);
            this.pnlGeneral.Controls.Add(this.lblTransportCost, 4, 5);
            this.pnlGeneral.Controls.Add(this.lblTransportType, 1, 5);
            this.pnlGeneral.Controls.Add(this.lblTransportNO, 1, 7);
            this.pnlGeneral.Controls.Add(this.lblTransportIssueBy, 4, 7);
            this.pnlGeneral.Controls.Add(this.tbxTransportNO, 2, 7);
            this.pnlGeneral.Controls.Add(this.tbxEr, 5, 15);
            this.pnlGeneral.Controls.Add(this.tbxTransportIssueBy, 5, 7);
            this.pnlGeneral.Controls.Add(this.lblAmount, 1, 11);
            this.pnlGeneral.Controls.Add(this.tbxAmount, 2, 11);
            this.pnlGeneral.Controls.Add(this.tbxTransportCost, 5, 5);
            this.pnlGeneral.Controls.Add(this.lblNote, 4, 11);
            this.pnlGeneral.Controls.Add(this.tbxNote, 5, 11);
            this.pnlGeneral.Controls.Add(this.dtpDate, 2, 3);
            this.pnlGeneral.Controls.Add(this.lblDate, 1, 3);
            this.pnlGeneral.Controls.Add(this.lblOrderType, 1, 1);
            this.pnlGeneral.Controls.Add(this.cbxOrderType, 2, 1);
            this.pnlGeneral.Controls.Add(this.lblCreateBy, 4, 3);
            this.pnlGeneral.Controls.Add(this.cbxOrderBy, 5, 3);
            this.pnlGeneral.Controls.Add(this.lblEr, 4, 15);
            this.pnlGeneral.Controls.Add(this.lblOrderInAmount, 1, 15);
            this.pnlGeneral.Controls.Add(this.tbxOrderInAmount, 2, 15);
            this.pnlGeneral.Controls.Add(this.น้ำหนัก, 1, 9);
            this.pnlGeneral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGeneral.Location = new System.Drawing.Point(3, 16);
            this.pnlGeneral.Name = "pnlGeneral";
            this.pnlGeneral.RowCount = 17;
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
            this.pnlGeneral.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.pnlGeneral.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 3F));
            this.pnlGeneral.Size = new System.Drawing.Size(662, 240);
            this.pnlGeneral.TabIndex = 15;
            // 
            // tbxWeight
            // 
            this.tbxWeight.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orderOutBindingSource, "Unit", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "0", "N2"));
            this.tbxWeight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxWeight.Location = new System.Drawing.Point(132, 125);
            this.tbxWeight.Name = "tbxWeight";
            this.tbxWeight.ReadOnly = true;
            this.tbxWeight.Size = new System.Drawing.Size(189, 20);
            this.tbxWeight.TabIndex = 45;
            this.tbxWeight.Text = "0";
            // 
            // tbxAmountPerUnit
            // 
            this.tbxAmountPerUnit.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orderOutBindingSource, "AmountPerUnit", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "0", "C2"));
            this.tbxAmountPerUnit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxAmountPerUnit.Location = new System.Drawing.Point(434, 125);
            this.tbxAmountPerUnit.Name = "tbxAmountPerUnit";
            this.tbxAmountPerUnit.ReadOnly = true;
            this.tbxAmountPerUnit.Size = new System.Drawing.Size(189, 20);
            this.tbxAmountPerUnit.TabIndex = 44;
            this.tbxAmountPerUnit.Text = "0";
            // 
            // lblPerKilo
            // 
            this.lblPerKilo.AutoSize = true;
            this.lblPerKilo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPerKilo.Location = new System.Drawing.Point(337, 122);
            this.lblPerKilo.Name = "lblPerKilo";
            this.lblPerKilo.Size = new System.Drawing.Size(91, 25);
            this.lblPerKilo.TabIndex = 43;
            this.lblPerKilo.Text = "ราคาต่อกิโลกรัม";
            this.lblPerKilo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbxTotalAmount
            // 
            this.tbxTotalAmount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxTotalAmount.Location = new System.Drawing.Point(132, 181);
            this.tbxTotalAmount.Name = "tbxTotalAmount";
            this.tbxTotalAmount.ReadOnly = true;
            this.tbxTotalAmount.Size = new System.Drawing.Size(189, 20);
            this.tbxTotalAmount.TabIndex = 38;
            this.tbxTotalAmount.Text = "0";
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.AutoSize = true;
            this.lblTotalAmount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTotalAmount.Location = new System.Drawing.Point(35, 178);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(91, 25);
            this.lblTotalAmount.TabIndex = 37;
            this.lblTotalAmount.Text = "รวมราคาขาย";
            this.lblTotalAmount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbxTransportType
            // 
            this.cbxTransportType.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.orderOutBindingSource, "TransportType", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "0"));
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
            this.lblTransportNO.Text = "เลขทีใบย้ายออก";
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
            this.tbxTransportNO.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orderOutBindingSource, "TransportBillNO", true));
            this.tbxTransportNO.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxTransportNO.Location = new System.Drawing.Point(132, 97);
            this.tbxTransportNO.Name = "tbxTransportNO";
            this.tbxTransportNO.ReadOnly = true;
            this.tbxTransportNO.Size = new System.Drawing.Size(189, 20);
            this.tbxTransportNO.TabIndex = 16;
            // 
            // tbxEr
            // 
            this.tbxEr.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxEr.Location = new System.Drawing.Point(434, 209);
            this.tbxEr.Name = "tbxEr";
            this.tbxEr.ReadOnly = true;
            this.tbxEr.Size = new System.Drawing.Size(189, 20);
            this.tbxEr.TabIndex = 17;
            this.tbxEr.Text = "0";
            // 
            // tbxTransportIssueBy
            // 
            this.tbxTransportIssueBy.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orderOutBindingSource, "TransportBillIssuesBy", true));
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
            this.lblAmount.Text = "ราคาขาย *";
            this.lblAmount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbxAmount
            // 
            this.tbxAmount.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orderOutBindingSource, "Amount", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "0", "C2"));
            this.tbxAmount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxAmount.Location = new System.Drawing.Point(132, 153);
            this.tbxAmount.Name = "tbxAmount";
            this.tbxAmount.ReadOnly = true;
            this.tbxAmount.Size = new System.Drawing.Size(189, 20);
            this.tbxAmount.TabIndex = 23;
            this.tbxAmount.Text = "0";
            this.tbxAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxAmount_KeyPress);
            this.tbxAmount.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbxNumber_KeyUp);
            // 
            // tbxTransportCost
            // 
            this.tbxTransportCost.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orderOutBindingSource, "TransportCost", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "0", "C2"));
            this.tbxTransportCost.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxTransportCost.Location = new System.Drawing.Point(434, 69);
            this.tbxTransportCost.Name = "tbxTransportCost";
            this.tbxTransportCost.ReadOnly = true;
            this.tbxTransportCost.Size = new System.Drawing.Size(189, 20);
            this.tbxTransportCost.TabIndex = 26;
            this.tbxTransportCost.Text = "0";
            this.tbxTransportCost.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxTransportCost_KeyPress);
            this.tbxTransportCost.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbxNumber_KeyUp);
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
            this.tbxNote.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orderOutBindingSource, "Description", true));
            this.tbxNote.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxNote.Location = new System.Drawing.Point(434, 153);
            this.tbxNote.Multiline = true;
            this.tbxNote.Name = "tbxNote";
            this.tbxNote.ReadOnly = true;
            this.pnlGeneral.SetRowSpan(this.tbxNote, 3);
            this.tbxNote.Size = new System.Drawing.Size(189, 47);
            this.tbxNote.TabIndex = 28;
            // 
            // dtpDate
            // 
            this.dtpDate.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.orderOutBindingSource, "Date", true));
            this.dtpDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtpDate.Enabled = false;
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.Location = new System.Drawing.Point(132, 41);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(189, 20);
            this.dtpDate.TabIndex = 30;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDate.Location = new System.Drawing.Point(35, 38);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(91, 25);
            this.lblDate.TabIndex = 29;
            this.lblDate.Text = "วันที่ *";
            this.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblOrderType
            // 
            this.lblOrderType.AutoSize = true;
            this.lblOrderType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblOrderType.Location = new System.Drawing.Point(35, 9);
            this.lblOrderType.Name = "lblOrderType";
            this.lblOrderType.Size = new System.Drawing.Size(91, 26);
            this.lblOrderType.TabIndex = 31;
            this.lblOrderType.Text = "ประเภทนำออก *";
            this.lblOrderType.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbxOrderType
            // 
            this.cbxOrderType.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.orderOutBindingSource, "OrderType", true));
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
            this.cbxOrderBy.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.orderOutBindingSource, "OrderBy", true));
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
            // lblEr
            // 
            this.lblEr.AutoSize = true;
            this.lblEr.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblEr.Location = new System.Drawing.Point(337, 206);
            this.lblEr.Name = "lblEr";
            this.lblEr.Size = new System.Drawing.Size(91, 25);
            this.lblEr.TabIndex = 39;
            this.lblEr.Text = "กำไร";
            this.lblEr.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblOrderInAmount
            // 
            this.lblOrderInAmount.AutoSize = true;
            this.lblOrderInAmount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblOrderInAmount.Location = new System.Drawing.Point(35, 206);
            this.lblOrderInAmount.Name = "lblOrderInAmount";
            this.lblOrderInAmount.Size = new System.Drawing.Size(91, 25);
            this.lblOrderInAmount.TabIndex = 40;
            this.lblOrderInAmount.Text = "ราคาซื้อ";
            this.lblOrderInAmount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbxOrderInAmount
            // 
            this.tbxOrderInAmount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxOrderInAmount.Location = new System.Drawing.Point(132, 209);
            this.tbxOrderInAmount.Name = "tbxOrderInAmount";
            this.tbxOrderInAmount.ReadOnly = true;
            this.tbxOrderInAmount.Size = new System.Drawing.Size(189, 20);
            this.tbxOrderInAmount.TabIndex = 41;
            this.tbxOrderInAmount.Text = "0";
            // 
            // น้ำหนัก
            // 
            this.น้ำหนัก.AutoSize = true;
            this.น้ำหนัก.Dock = System.Windows.Forms.DockStyle.Fill;
            this.น้ำหนัก.Location = new System.Drawing.Point(35, 122);
            this.น้ำหนัก.Name = "น้ำหนัก";
            this.น้ำหนัก.Size = new System.Drawing.Size(91, 25);
            this.น้ำหนัก.TabIndex = 42;
            this.น้ำหนัก.Text = "น้ำหนัก (กิโลกรัม)";
            this.น้ำหนัก.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            this.tabCustomer.Text = "ข้อมูลผู้ซื้อ";
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
            this.pnlCustomerContent.TabIndex = 1;
            // 
            // gbxCustomer
            // 
            this.gbxCustomer.Controls.Add(this.pnlCustomer);
            this.gbxCustomer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbxCustomer.Location = new System.Drawing.Point(3, 3);
            this.gbxCustomer.Name = "gbxCustomer";
            this.gbxCustomer.Size = new System.Drawing.Size(668, 477);
            this.gbxCustomer.TabIndex = 1;
            this.gbxCustomer.TabStop = false;
            this.gbxCustomer.Text = "ข้อมูลผู้ขาย";
            // 
            // pnlCustomer
            // 
            this.pnlCustomer.ColumnCount = 7;
            this.pnlCustomer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.pnlCustomer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.pnlCustomer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.pnlCustomer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.pnlCustomer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.pnlCustomer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.pnlCustomer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.pnlCustomer.Controls.Add(this.lblfName, 1, 5);
            this.pnlCustomer.Controls.Add(this.lbllName, 4, 5);
            this.pnlCustomer.Controls.Add(this.lblAddress, 1, 9);
            this.pnlCustomer.Controls.Add(this.tbxfName, 2, 5);
            this.pnlCustomer.Controls.Add(this.tbxlName, 5, 5);
            this.pnlCustomer.Controls.Add(this.tbxAddress, 2, 9);
            this.pnlCustomer.Controls.Add(this.lblCompany, 1, 7);
            this.pnlCustomer.Controls.Add(this.cbxProvince, 5, 15);
            this.pnlCustomer.Controls.Add(this.lblProvince, 4, 15);
            this.pnlCustomer.Controls.Add(this.lblDistrict, 1, 15);
            this.pnlCustomer.Controls.Add(this.lblStreed, 1, 13);
            this.pnlCustomer.Controls.Add(this.tbxStreed, 2, 13);
            this.pnlCustomer.Controls.Add(this.lblCity, 4, 13);
            this.pnlCustomer.Controls.Add(this.lblPhone, 1, 19);
            this.pnlCustomer.Controls.Add(this.tbxPhone, 2, 19);
            this.pnlCustomer.Controls.Add(this.lblMobile, 4, 19);
            this.pnlCustomer.Controls.Add(this.tbxMobile, 5, 19);
            this.pnlCustomer.Controls.Add(this.lblPostCode, 4, 17);
            this.pnlCustomer.Controls.Add(this.lblCountry, 1, 17);
            this.pnlCustomer.Controls.Add(this.lblPrename, 1, 3);
            this.pnlCustomer.Controls.Add(this.cbxPrename, 2, 3);
            this.pnlCustomer.Controls.Add(this.cbxCompany, 2, 7);
            this.pnlCustomer.Controls.Add(this.cbxCity, 5, 13);
            this.pnlCustomer.Controls.Add(this.cbxPostCode, 5, 17);
            this.pnlCustomer.Controls.Add(this.cbxDistrict, 2, 15);
            this.pnlCustomer.Controls.Add(this.lblCountryValue, 2, 17);
            this.pnlCustomer.Controls.Add(this.label1, 1, 1);
            this.pnlCustomer.Controls.Add(this.lblCustomerPIDValue, 2, 1);
            this.pnlCustomer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCustomer.Location = new System.Drawing.Point(3, 16);
            this.pnlCustomer.Name = "pnlCustomer";
            this.pnlCustomer.RowCount = 21;
            this.pnlCustomer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.pnlCustomer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.pnlCustomer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 3F));
            this.pnlCustomer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.pnlCustomer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 3F));
            this.pnlCustomer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.pnlCustomer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 3F));
            this.pnlCustomer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.pnlCustomer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 3F));
            this.pnlCustomer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.pnlCustomer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 3F));
            this.pnlCustomer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.pnlCustomer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 3F));
            this.pnlCustomer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.pnlCustomer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 3F));
            this.pnlCustomer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.pnlCustomer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 3F));
            this.pnlCustomer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.pnlCustomer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 3F));
            this.pnlCustomer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.pnlCustomer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 3F));
            this.pnlCustomer.Size = new System.Drawing.Size(662, 458);
            this.pnlCustomer.TabIndex = 8;
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
            this.pnlCustomer.SetRowSpan(this.lblAddress, 3);
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
            this.tbxAddress.MaxLength = 64;
            this.tbxAddress.Multiline = true;
            this.tbxAddress.Name = "tbxAddress";
            this.tbxAddress.ReadOnly = true;
            this.pnlCustomer.SetRowSpan(this.tbxAddress, 3);
            this.tbxAddress.Size = new System.Drawing.Size(189, 47);
            this.tbxAddress.TabIndex = 3;
            this.tbxAddress.Validating += new System.ComponentModel.CancelEventHandler(this.tbx_Validating);
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
            this.tbxMobile.MaxLength = 16;
            this.tbxMobile.Name = "tbxMobile";
            this.tbxMobile.ReadOnly = true;
            this.tbxMobile.Size = new System.Drawing.Size(189, 20);
            this.tbxMobile.TabIndex = 9;
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
            // cbxCompany
            // 
            this.cbxCompany.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.customerBindingSource, "CompanyID", true));
            this.cbxCompany.DisplayMember = "CompanyID";
            this.cbxCompany.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbxCompany.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCompany.Enabled = false;
            this.cbxCompany.FormattingEnabled = true;
            this.cbxCompany.Location = new System.Drawing.Point(132, 97);
            this.cbxCompany.Name = "cbxCompany";
            this.cbxCompany.Size = new System.Drawing.Size(189, 21);
            this.cbxCompany.TabIndex = 27;
            this.cbxCompany.ValueMember = "CompanyID";
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
            this.cbxPostCode.TabIndex = 29;
            this.cbxPostCode.ValueMember = "PostCodeID";
            // 
            // fKPostCodeDistrictBindingSource
            // 
            this.fKPostCodeDistrictBindingSource.DataMember = "FK_PostCode_District";
            this.fKPostCodeDistrictBindingSource.DataSource = this.fKDistrictProvinceBindingSource;
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
            this.cbxDistrict.TabIndex = 30;
            this.cbxDistrict.ValueMember = "DistrictID";
            // 
            // lblCountryValue
            // 
            this.lblCountryValue.AutoSize = true;
            this.lblCountryValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCountryValue.Location = new System.Drawing.Point(132, 234);
            this.lblCountryValue.Name = "lblCountryValue";
            this.lblCountryValue.Size = new System.Drawing.Size(189, 25);
            this.lblCountryValue.TabIndex = 31;
            this.lblCountryValue.Text = "ประเทศไทย";
            this.lblCountryValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(35, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 25);
            this.label1.TabIndex = 32;
            this.label1.Text = "เลขประจำตัว";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            // tabCowList
            // 
            this.tabCowList.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabCowList.Controls.Add(this.gbxOrderOutList);
            this.tabCowList.Location = new System.Drawing.Point(4, 22);
            this.tabCowList.Name = "tabCowList";
            this.tabCowList.Padding = new System.Windows.Forms.Padding(3);
            this.tabCowList.Size = new System.Drawing.Size(680, 489);
            this.tabCowList.TabIndex = 4;
            this.tabCowList.Text = "รายการนำออก";
            // 
            // gbxOrderOutList
            // 
            this.gbxOrderOutList.Controls.Add(this.dataCowList);
            this.gbxOrderOutList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbxOrderOutList.Location = new System.Drawing.Point(3, 3);
            this.gbxOrderOutList.Name = "gbxOrderOutList";
            this.gbxOrderOutList.Size = new System.Drawing.Size(674, 483);
            this.gbxOrderOutList.TabIndex = 2;
            this.gbxOrderOutList.TabStop = false;
            this.gbxOrderOutList.Text = "รายการนำออก";
            // 
            // dataCowList
            // 
            this.dataCowList.AllowUserToAddRows = false;
            this.dataCowList.AllowUserToDeleteRows = false;
            this.dataCowList.AutoGenerateColumns = false;
            this.dataCowList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataCowList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCowNO,
            this.colCowCorral,
            this.colCowGene,
            this.colCowSex,
            this.colCowOrderInID,
            this.colCowOrderInAmount,
            this.colCowOrderOutID,
            this.colCowOrderOutAmount});
            this.dataCowList.DataSource = this.fKCowOrderOutBindingSource;
            this.dataCowList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataCowList.Location = new System.Drawing.Point(3, 16);
            this.dataCowList.Name = "dataCowList";
            this.dataCowList.ReadOnly = true;
            this.dataCowList.Size = new System.Drawing.Size(668, 464);
            this.dataCowList.TabIndex = 0;
            this.dataCowList.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataCowList_CellMouseDoubleClick);
            // 
            // colCowNO
            // 
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
            this.colCowSex.DataPropertyName = "Sex";
            this.colCowSex.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.colCowSex.HeaderText = "เพศ";
            this.colCowSex.Name = "colCowSex";
            this.colCowSex.ReadOnly = true;
            this.colCowSex.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colCowSex.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // colCowOrderInID
            // 
            this.colCowOrderInID.DataPropertyName = "OrderInID";
            this.colCowOrderInID.HeaderText = "OrderInID";
            this.colCowOrderInID.Name = "colCowOrderInID";
            this.colCowOrderInID.ReadOnly = true;
            this.colCowOrderInID.Visible = false;
            // 
            // colCowOrderInAmount
            // 
            this.colCowOrderInAmount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colCowOrderInAmount.DataPropertyName = "OnderInAmount";
            dataGridViewCellStyle1.Format = "C2";
            dataGridViewCellStyle1.NullValue = "0";
            this.colCowOrderInAmount.DefaultCellStyle = dataGridViewCellStyle1;
            this.colCowOrderInAmount.HeaderText = "ราคาซื้อ";
            this.colCowOrderInAmount.Name = "colCowOrderInAmount";
            this.colCowOrderInAmount.ReadOnly = true;
            // 
            // colCowOrderOutID
            // 
            this.colCowOrderOutID.DataPropertyName = "OrderOutID";
            this.colCowOrderOutID.HeaderText = "OrderOutID";
            this.colCowOrderOutID.Name = "colCowOrderOutID";
            this.colCowOrderOutID.ReadOnly = true;
            this.colCowOrderOutID.Visible = false;
            // 
            // colCowOrderOutAmount
            // 
            this.colCowOrderOutAmount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colCowOrderOutAmount.DataPropertyName = "OrderOutAmount";
            dataGridViewCellStyle2.Format = "C2";
            dataGridViewCellStyle2.NullValue = "0";
            this.colCowOrderOutAmount.DefaultCellStyle = dataGridViewCellStyle2;
            this.colCowOrderOutAmount.HeaderText = "ราคาขาย";
            this.colCowOrderOutAmount.Name = "colCowOrderOutAmount";
            this.colCowOrderOutAmount.ReadOnly = true;
            // 
            // fKCowOrderOutBindingSource
            // 
            this.fKCowOrderOutBindingSource.DataMember = "FK_Cow_OrderOut";
            this.fKCowOrderOutBindingSource.DataSource = this.orderOutBindingSource;
            // 
            // tabRecord
            // 
            this.tabRecord.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabRecord.Controls.Add(this.userLogUC);
            this.tabRecord.Location = new System.Drawing.Point(4, 22);
            this.tabRecord.Name = "tabRecord";
            this.tabRecord.Padding = new System.Windows.Forms.Padding(3);
            this.tabRecord.Size = new System.Drawing.Size(680, 489);
            this.tabRecord.TabIndex = 3;
            this.tabRecord.Text = "การบันทึก";
            // 
            // userLogUC
            // 
            this.userLogUC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userLogUC.Location = new System.Drawing.Point(3, 3);
            this.userLogUC.Name = "userLogUC";
            this.userLogUC.Size = new System.Drawing.Size(674, 483);
            this.userLogUC.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.White;
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblTitle.Location = new System.Drawing.Point(3, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lblTitle.Size = new System.Drawing.Size(688, 60);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "รายละเอียดการขาย";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.pnlFooter.TabIndex = 1;
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
            this.btnPrintBill.Location = new System.Drawing.Point(6, 6);
            this.btnPrintBill.Name = "btnPrintBill";
            this.btnPrintBill.Size = new System.Drawing.Size(80, 23);
            this.btnPrintBill.TabIndex = 2;
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
            // orderOutTableAdapter
            // 
            this.orderOutTableAdapter.ClearBeforeFill = true;
            // 
            // cowTableAdapter
            // 
            this.cowTableAdapter.ClearBeforeFill = true;
            // 
            // corralTableAdapter
            // 
            this.corralTableAdapter.ClearBeforeFill = true;
            // 
            // geneTableAdapter
            // 
            this.geneTableAdapter.ClearBeforeFill = true;
            // 
            // usersViewTableAdapter
            // 
            this.usersViewTableAdapter.ClearBeforeFill = true;
            // 
            // customerTableAdapter
            // 
            this.customerTableAdapter.ClearBeforeFill = true;
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
            // OutOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 621);
            this.Controls.Add(this.pnlMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OutOrderForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "รายละเอียดการขาย";
            this.Load += new System.EventHandler(this.OutOrderForm_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.tcMain.ResumeLayout(false);
            this.tabGeneral.ResumeLayout(false);
            this.pnlGeneralContent.ResumeLayout(false);
            this.gbxPayment.ResumeLayout(false);
            this.pnlPayment.ResumeLayout(false);
            this.pnlPayment.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderOutBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.farmManageDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersViewBindingSource)).EndInit();
            this.gbxGeneral.ResumeLayout(false);
            this.pnlGeneral.ResumeLayout(false);
            this.pnlGeneral.PerformLayout();
            this.tabCustomer.ResumeLayout(false);
            this.pnlCustomerContent.ResumeLayout(false);
            this.gbxCustomer.ResumeLayout(false);
            this.pnlCustomer.ResumeLayout(false);
            this.pnlCustomer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.provinceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKCityDistrictBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKDistrictProvinceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKPostCodeDistrictBindingSource)).EndInit();
            this.tabCowList.ResumeLayout(false);
            this.gbxOrderOutList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataCowList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.corralBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.geneBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKCowOrderOutBindingSource)).EndInit();
            this.tabRecord.ResumeLayout(false);
            this.pnlFooter.ResumeLayout(false);
            this.pnlLeftFooter.ResumeLayout(false);
            this.pnlRightFooter.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel pnlMain;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TableLayoutPanel pnlFooter;
        private System.Windows.Forms.FlowLayoutPanel pnlLeftFooter;
        private System.Windows.Forms.FlowLayoutPanel pnlRightFooter;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TabControl tcMain;
        private System.Windows.Forms.TabPage tabGeneral;
        private System.Windows.Forms.TableLayoutPanel pnlGeneralContent;
        private System.Windows.Forms.GroupBox gbxPayment;
        private System.Windows.Forms.GroupBox gbxGeneral;
        private System.Windows.Forms.TabPage tabCustomer;
        private System.Windows.Forms.TabPage tabRecord;
        private System.Windows.Forms.TableLayoutPanel pnlPayment;
        private System.Windows.Forms.Label lblPaymentStatus;
        private System.Windows.Forms.ComboBox cbxPaymentType;
        private System.Windows.Forms.ComboBox cbxPaymentStatus;
        private System.Windows.Forms.Label lblPaymentBy;
        private System.Windows.Forms.Label lblPaymentDate;
        private System.Windows.Forms.DateTimePicker dtpPaymentDate;
        private System.Windows.Forms.ComboBox cbxPaymentBy;
        private System.Windows.Forms.Label lblPaymentType;
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
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblOrderType;
        private System.Windows.Forms.ComboBox cbxOrderType;
        private System.Windows.Forms.Label lblCreateBy;
        private System.Windows.Forms.ComboBox cbxOrderBy;
        private System.Windows.Forms.TableLayoutPanel pnlCustomerContent;
        private System.Windows.Forms.GroupBox gbxCustomer;
        private System.Windows.Forms.TableLayoutPanel pnlCustomer;
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
        private System.Windows.Forms.TabPage tabCowList;
        private System.Windows.Forms.GroupBox gbxOrderOutList;
        private System.Windows.Forms.DataGridView dataCowList;
        private System.Windows.Forms.Button btnPrintBill;
        private System.Windows.Forms.Button btnResource;
        private System.Windows.Forms.Label lblTotalAmount;
        private System.Windows.Forms.TextBox tbxTotalAmount;
        private System.Windows.Forms.TextBox tbxEr;
        private System.Windows.Forms.Label lblEr;
        private System.Windows.Forms.Label lblOrderInAmount;
        private System.Windows.Forms.TextBox tbxOrderInAmount;
        private System.Windows.Forms.Label น้ำหนัก;
        private System.Windows.Forms.Label lblPerKilo;
        private System.Windows.Forms.TextBox tbxAmountPerUnit;
        private System.Windows.Forms.TextBox tbxWeight;
        private System.Windows.Forms.ComboBox cbxCompany;
        private System.Windows.Forms.ComboBox cbxCity;
        private System.Windows.Forms.ComboBox cbxPostCode;
        private System.Windows.Forms.ComboBox cbxDistrict;
        private System.Windows.Forms.Label lblCountryValue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCustomerPIDValue;
        private Control.UserLogUC userLogUC;
        private Database.FarmManageDataSet farmManageDataSet;
        private System.Windows.Forms.BindingSource orderOutBindingSource;
        private Database.FarmManageDataSetTableAdapters.OrderOutTableAdapter orderOutTableAdapter;
        private System.Windows.Forms.BindingSource fKCowOrderOutBindingSource;
        private Database.FarmManageDataSetTableAdapters.CowTableAdapter cowTableAdapter;
        private System.Windows.Forms.BindingSource corralBindingSource;
        private Database.FarmManageDataSetTableAdapters.CorralTableAdapter corralTableAdapter;
        private System.Windows.Forms.BindingSource geneBindingSource;
        private Database.FarmManageDataSetTableAdapters.GeneTableAdapter geneTableAdapter;
        private System.Windows.Forms.BindingSource usersViewBindingSource;
        private Database.FarmManageDataSetTableAdapters.UsersViewTableAdapter usersViewTableAdapter;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private Database.FarmManageDataSetTableAdapters.CustomerTableAdapter customerTableAdapter;
        private System.Windows.Forms.BindingSource provinceBindingSource;
        private Database.FarmManageDataSetTableAdapters.ProvinceTableAdapter provinceTableAdapter;
        private System.Windows.Forms.BindingSource fKDistrictProvinceBindingSource;
        private Database.FarmManageDataSetTableAdapters.DistrictTableAdapter districtTableAdapter;
        private System.Windows.Forms.BindingSource fKCityDistrictBindingSource;
        private Database.FarmManageDataSetTableAdapters.CityTableAdapter cityTableAdapter;
        private System.Windows.Forms.BindingSource fKPostCodeDistrictBindingSource;
        private Database.FarmManageDataSetTableAdapters.PostCodeTableAdapter postCodeTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCowNO;
        private System.Windows.Forms.DataGridViewComboBoxColumn colCowCorral;
        private System.Windows.Forms.DataGridViewComboBoxColumn colCowGene;
        private System.Windows.Forms.DataGridViewComboBoxColumn colCowSex;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCowOrderInID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCowOrderInAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCowOrderOutID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCowOrderOutAmount;
    }
}
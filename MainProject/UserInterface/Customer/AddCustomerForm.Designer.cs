namespace MainProject.UserInterface.Customer
{
    partial class AddCustomerForm
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
            this.pnlMain = new System.Windows.Forms.TableLayoutPanel();
            this.pnlContent = new System.Windows.Forms.TableLayoutPanel();
            this.lblfName = new System.Windows.Forms.Label();
            this.lbllName = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.tbxfName = new System.Windows.Forms.TextBox();
            this.tbxlName = new System.Windows.Forms.TextBox();
            this.tbxAddress = new System.Windows.Forms.TextBox();
            this.lblCompany = new System.Windows.Forms.Label();
            this.cbxProvinceID = new System.Windows.Forms.ComboBox();
            this.provinceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.farmManageDataSet = new MainProject.Database.FarmManageDataSet();
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
            this.lblPID = new System.Windows.Forms.Label();
            this.tbxPID = new System.Windows.Forms.TextBox();
            this.cbxCompany = new System.Windows.Forms.ComboBox();
            this.companyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbxCityID = new System.Windows.Forms.ComboBox();
            this.fKCityDistrictBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fKDistrictProvinceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbxPostCode = new System.Windows.Forms.ComboBox();
            this.fKPostCodeDistrictBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbxDistrictID = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAddCompany = new System.Windows.Forms.Button();
            this.btnClearCompany = new System.Windows.Forms.Button();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnCheckPID = new System.Windows.Forms.Button();
            this.btnClearPID = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlFooter = new System.Windows.Forms.FlowLayoutPanel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.companyTableAdapter = new MainProject.Database.FarmManageDataSetTableAdapters.CompanyTableAdapter();
            this.provinceTableAdapter = new MainProject.Database.FarmManageDataSetTableAdapters.ProvinceTableAdapter();
            this.districtTableAdapter = new MainProject.Database.FarmManageDataSetTableAdapters.DistrictTableAdapter();
            this.cityTableAdapter = new MainProject.Database.FarmManageDataSetTableAdapters.CityTableAdapter();
            this.postCodeTableAdapter = new MainProject.Database.FarmManageDataSetTableAdapters.PostCodeTableAdapter();
            this.pnlMain.SuspendLayout();
            this.pnlContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.provinceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.farmManageDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKCityDistrictBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKDistrictProvinceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKPostCodeDistrictBindingSource)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.pnlFooter.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.pnlMain.ColumnCount = 1;
            this.pnlMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlMain.Controls.Add(this.pnlContent, 0, 1);
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
            this.pnlMain.Size = new System.Drawing.Size(594, 421);
            this.pnlMain.TabIndex = 0;
            // 
            // pnlContent
            // 
            this.pnlContent.ColumnCount = 7;
            this.pnlContent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.pnlContent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.pnlContent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.pnlContent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.pnlContent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.pnlContent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.pnlContent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.pnlContent.Controls.Add(this.lblfName, 1, 5);
            this.pnlContent.Controls.Add(this.lbllName, 4, 5);
            this.pnlContent.Controls.Add(this.lblAddress, 1, 9);
            this.pnlContent.Controls.Add(this.tbxfName, 2, 5);
            this.pnlContent.Controls.Add(this.tbxlName, 5, 5);
            this.pnlContent.Controls.Add(this.tbxAddress, 2, 9);
            this.pnlContent.Controls.Add(this.lblCompany, 1, 7);
            this.pnlContent.Controls.Add(this.cbxProvinceID, 5, 15);
            this.pnlContent.Controls.Add(this.lblProvince, 4, 15);
            this.pnlContent.Controls.Add(this.lblDistrict, 1, 15);
            this.pnlContent.Controls.Add(this.lblStreed, 1, 13);
            this.pnlContent.Controls.Add(this.tbxStreed, 2, 13);
            this.pnlContent.Controls.Add(this.lblCity, 4, 13);
            this.pnlContent.Controls.Add(this.lblPhone, 1, 19);
            this.pnlContent.Controls.Add(this.tbxPhone, 2, 19);
            this.pnlContent.Controls.Add(this.lblMobile, 4, 19);
            this.pnlContent.Controls.Add(this.tbxMobile, 5, 19);
            this.pnlContent.Controls.Add(this.lblPostCode, 4, 17);
            this.pnlContent.Controls.Add(this.lblCountry, 1, 17);
            this.pnlContent.Controls.Add(this.lblPrename, 1, 3);
            this.pnlContent.Controls.Add(this.cbxPrename, 2, 3);
            this.pnlContent.Controls.Add(this.lblPID, 1, 1);
            this.pnlContent.Controls.Add(this.tbxPID, 2, 1);
            this.pnlContent.Controls.Add(this.cbxCompany, 2, 7);
            this.pnlContent.Controls.Add(this.cbxCityID, 5, 13);
            this.pnlContent.Controls.Add(this.cbxPostCode, 5, 17);
            this.pnlContent.Controls.Add(this.cbxDistrictID, 2, 15);
            this.pnlContent.Controls.Add(this.label1, 2, 17);
            this.pnlContent.Controls.Add(this.flowLayoutPanel1, 4, 7);
            this.pnlContent.Controls.Add(this.flowLayoutPanel2, 4, 1);
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(4, 65);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.RowCount = 21;
            this.pnlContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.pnlContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.pnlContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 3F));
            this.pnlContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.pnlContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 3F));
            this.pnlContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.pnlContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 3F));
            this.pnlContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.pnlContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 3F));
            this.pnlContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.pnlContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 3F));
            this.pnlContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.pnlContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 3F));
            this.pnlContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.pnlContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 3F));
            this.pnlContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.pnlContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 3F));
            this.pnlContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.pnlContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 3F));
            this.pnlContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.pnlContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.pnlContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.pnlContent.Size = new System.Drawing.Size(586, 311);
            this.pnlContent.TabIndex = 7;
            // 
            // lblfName
            // 
            this.lblfName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblfName.Location = new System.Drawing.Point(31, 73);
            this.lblfName.Name = "lblfName";
            this.lblfName.Size = new System.Drawing.Size(80, 25);
            this.lblfName.TabIndex = 0;
            this.lblfName.Text = "ชื่อ *";
            this.lblfName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbllName
            // 
            this.lbllName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbllName.Location = new System.Drawing.Point(299, 73);
            this.lbllName.Name = "lbllName";
            this.lbllName.Size = new System.Drawing.Size(80, 25);
            this.lbllName.TabIndex = 2;
            this.lbllName.Text = "นามสกุล *";
            this.lbllName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblAddress
            // 
            this.lblAddress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAddress.Location = new System.Drawing.Point(31, 129);
            this.lblAddress.Name = "lblAddress";
            this.pnlContent.SetRowSpan(this.lblAddress, 3);
            this.lblAddress.Size = new System.Drawing.Size(80, 53);
            this.lblAddress.TabIndex = 3;
            this.lblAddress.Text = "ที่อยู่ *";
            this.lblAddress.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbxfName
            // 
            this.tbxfName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxfName.Enabled = false;
            this.tbxfName.Location = new System.Drawing.Point(117, 76);
            this.tbxfName.Name = "tbxfName";
            this.tbxfName.Size = new System.Drawing.Size(166, 20);
            this.tbxfName.TabIndex = 0;
            this.tbxfName.Validating += new System.ComponentModel.CancelEventHandler(this.tbx_Validating);
            // 
            // tbxlName
            // 
            this.tbxlName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxlName.Enabled = false;
            this.tbxlName.Location = new System.Drawing.Point(385, 76);
            this.tbxlName.Name = "tbxlName";
            this.tbxlName.Size = new System.Drawing.Size(166, 20);
            this.tbxlName.TabIndex = 1;
            this.tbxlName.Validating += new System.ComponentModel.CancelEventHandler(this.tbx_Validating);
            // 
            // tbxAddress
            // 
            this.tbxAddress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxAddress.Enabled = false;
            this.tbxAddress.Location = new System.Drawing.Point(117, 132);
            this.tbxAddress.Multiline = true;
            this.tbxAddress.Name = "tbxAddress";
            this.pnlContent.SetRowSpan(this.tbxAddress, 3);
            this.tbxAddress.Size = new System.Drawing.Size(166, 47);
            this.tbxAddress.TabIndex = 3;
            this.tbxAddress.Validating += new System.ComponentModel.CancelEventHandler(this.tbx_Validating);
            // 
            // lblCompany
            // 
            this.lblCompany.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCompany.Location = new System.Drawing.Point(31, 101);
            this.lblCompany.Name = "lblCompany";
            this.lblCompany.Size = new System.Drawing.Size(80, 25);
            this.lblCompany.TabIndex = 4;
            this.lblCompany.Text = "ชื่อบริษัท";
            this.lblCompany.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbxProvinceID
            // 
            this.cbxProvinceID.DataSource = this.provinceBindingSource;
            this.cbxProvinceID.DisplayMember = "Name";
            this.cbxProvinceID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbxProvinceID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxProvinceID.Enabled = false;
            this.cbxProvinceID.FormattingEnabled = true;
            this.cbxProvinceID.Location = new System.Drawing.Point(385, 216);
            this.cbxProvinceID.Name = "cbxProvinceID";
            this.cbxProvinceID.Size = new System.Drawing.Size(166, 21);
            this.cbxProvinceID.TabIndex = 7;
            this.cbxProvinceID.ValueMember = "ProvinceID";
            this.cbxProvinceID.Validating += new System.ComponentModel.CancelEventHandler(this.cbxText_Validating);
            // 
            // provinceBindingSource
            // 
            this.provinceBindingSource.DataMember = "Province";
            this.provinceBindingSource.DataSource = this.farmManageDataSet;
            // 
            // farmManageDataSet
            // 
            this.farmManageDataSet.DataSetName = "FarmManageDataSet";
            this.farmManageDataSet.Locale = new System.Globalization.CultureInfo("en");
            this.farmManageDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblProvince
            // 
            this.lblProvince.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblProvince.Location = new System.Drawing.Point(299, 213);
            this.lblProvince.Name = "lblProvince";
            this.lblProvince.Size = new System.Drawing.Size(80, 25);
            this.lblProvince.TabIndex = 17;
            this.lblProvince.Text = "จังหวัด *";
            this.lblProvince.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblDistrict
            // 
            this.lblDistrict.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDistrict.Location = new System.Drawing.Point(31, 213);
            this.lblDistrict.Name = "lblDistrict";
            this.lblDistrict.Size = new System.Drawing.Size(80, 25);
            this.lblDistrict.TabIndex = 16;
            this.lblDistrict.Text = "อำเภอ *";
            this.lblDistrict.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblStreed
            // 
            this.lblStreed.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblStreed.Location = new System.Drawing.Point(31, 185);
            this.lblStreed.Name = "lblStreed";
            this.lblStreed.Size = new System.Drawing.Size(80, 25);
            this.lblStreed.TabIndex = 6;
            this.lblStreed.Text = "ถนน";
            this.lblStreed.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbxStreed
            // 
            this.tbxStreed.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxStreed.Enabled = false;
            this.tbxStreed.Location = new System.Drawing.Point(117, 188);
            this.tbxStreed.Name = "tbxStreed";
            this.tbxStreed.Size = new System.Drawing.Size(166, 20);
            this.tbxStreed.TabIndex = 4;
            // 
            // lblCity
            // 
            this.lblCity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCity.Location = new System.Drawing.Point(299, 185);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(80, 25);
            this.lblCity.TabIndex = 7;
            this.lblCity.Text = "ตำบล *";
            this.lblCity.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPhone
            // 
            this.lblPhone.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPhone.Location = new System.Drawing.Point(31, 269);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(80, 25);
            this.lblPhone.TabIndex = 1;
            this.lblPhone.Text = "เบอร์โทรศัพท์";
            this.lblPhone.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbxPhone
            // 
            this.tbxPhone.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxPhone.Enabled = false;
            this.tbxPhone.Location = new System.Drawing.Point(117, 272);
            this.tbxPhone.Name = "tbxPhone";
            this.tbxPhone.Size = new System.Drawing.Size(166, 20);
            this.tbxPhone.TabIndex = 8;
            this.tbxPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxPhoneNumber_KeyPress);
            // 
            // lblMobile
            // 
            this.lblMobile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMobile.Location = new System.Drawing.Point(299, 269);
            this.lblMobile.Name = "lblMobile";
            this.lblMobile.Size = new System.Drawing.Size(80, 25);
            this.lblMobile.TabIndex = 20;
            this.lblMobile.Text = "มือถือ";
            this.lblMobile.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbxMobile
            // 
            this.tbxMobile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxMobile.Enabled = false;
            this.tbxMobile.Location = new System.Drawing.Point(385, 272);
            this.tbxMobile.Name = "tbxMobile";
            this.tbxMobile.Size = new System.Drawing.Size(166, 20);
            this.tbxMobile.TabIndex = 9;
            this.tbxMobile.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxPhoneNumber_KeyPress);
            // 
            // lblPostCode
            // 
            this.lblPostCode.AutoSize = true;
            this.lblPostCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPostCode.Location = new System.Drawing.Point(299, 241);
            this.lblPostCode.Name = "lblPostCode";
            this.lblPostCode.Size = new System.Drawing.Size(80, 25);
            this.lblPostCode.TabIndex = 22;
            this.lblPostCode.Text = "รหัสไปรษณีย์";
            this.lblPostCode.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCountry.Location = new System.Drawing.Point(31, 241);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(80, 25);
            this.lblCountry.TabIndex = 23;
            this.lblCountry.Text = "ประเทศ *";
            this.lblCountry.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPrename
            // 
            this.lblPrename.AutoSize = true;
            this.lblPrename.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPrename.Location = new System.Drawing.Point(31, 45);
            this.lblPrename.Name = "lblPrename";
            this.lblPrename.Size = new System.Drawing.Size(80, 25);
            this.lblPrename.TabIndex = 25;
            this.lblPrename.Text = "คำนำหน้า *";
            this.lblPrename.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbxPrename
            // 
            this.cbxPrename.DisplayMember = "Value";
            this.cbxPrename.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbxPrename.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxPrename.Enabled = false;
            this.cbxPrename.FormattingEnabled = true;
            this.cbxPrename.Location = new System.Drawing.Point(117, 48);
            this.cbxPrename.Name = "cbxPrename";
            this.cbxPrename.Size = new System.Drawing.Size(166, 21);
            this.cbxPrename.TabIndex = 26;
            this.cbxPrename.ValueMember = "Key";
            this.cbxPrename.Validating += new System.ComponentModel.CancelEventHandler(this.cbx_Validating);
            // 
            // lblPID
            // 
            this.lblPID.AutoSize = true;
            this.lblPID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPID.Location = new System.Drawing.Point(31, 17);
            this.lblPID.Name = "lblPID";
            this.lblPID.Size = new System.Drawing.Size(80, 25);
            this.lblPID.TabIndex = 27;
            this.lblPID.Text = "เลขประจำตัว*";
            this.lblPID.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbxPID
            // 
            this.tbxPID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxPID.Location = new System.Drawing.Point(117, 20);
            this.tbxPID.Name = "tbxPID";
            this.tbxPID.Size = new System.Drawing.Size(166, 20);
            this.tbxPID.TabIndex = 29;
            // 
            // cbxCompany
            // 
            this.cbxCompany.DataSource = this.companyBindingSource;
            this.cbxCompany.DisplayMember = "Name";
            this.cbxCompany.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbxCompany.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCompany.Enabled = false;
            this.cbxCompany.FormattingEnabled = true;
            this.cbxCompany.Location = new System.Drawing.Point(117, 104);
            this.cbxCompany.Name = "cbxCompany";
            this.cbxCompany.Size = new System.Drawing.Size(166, 21);
            this.cbxCompany.TabIndex = 30;
            this.cbxCompany.ValueMember = "CompanyID";
            // 
            // companyBindingSource
            // 
            this.companyBindingSource.DataMember = "Company";
            this.companyBindingSource.DataSource = this.farmManageDataSet;
            // 
            // cbxCityID
            // 
            this.cbxCityID.DataSource = this.fKCityDistrictBindingSource;
            this.cbxCityID.DisplayMember = "Name";
            this.cbxCityID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbxCityID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCityID.Enabled = false;
            this.cbxCityID.FormattingEnabled = true;
            this.cbxCityID.Location = new System.Drawing.Point(385, 188);
            this.cbxCityID.Name = "cbxCityID";
            this.cbxCityID.Size = new System.Drawing.Size(166, 21);
            this.cbxCityID.TabIndex = 32;
            this.cbxCityID.ValueMember = "CityID";
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
            this.cbxPostCode.DataSource = this.fKPostCodeDistrictBindingSource;
            this.cbxPostCode.DisplayMember = "PostCode";
            this.cbxPostCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbxPostCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxPostCode.Enabled = false;
            this.cbxPostCode.FormattingEnabled = true;
            this.cbxPostCode.Location = new System.Drawing.Point(385, 244);
            this.cbxPostCode.Name = "cbxPostCode";
            this.cbxPostCode.Size = new System.Drawing.Size(166, 21);
            this.cbxPostCode.TabIndex = 33;
            this.cbxPostCode.ValueMember = "PostCodeID";
            // 
            // fKPostCodeDistrictBindingSource
            // 
            this.fKPostCodeDistrictBindingSource.DataMember = "FK_PostCode_District";
            this.fKPostCodeDistrictBindingSource.DataSource = this.fKDistrictProvinceBindingSource;
            // 
            // cbxDistrictID
            // 
            this.cbxDistrictID.DataSource = this.fKDistrictProvinceBindingSource;
            this.cbxDistrictID.DisplayMember = "Name";
            this.cbxDistrictID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbxDistrictID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxDistrictID.Enabled = false;
            this.cbxDistrictID.FormattingEnabled = true;
            this.cbxDistrictID.Location = new System.Drawing.Point(117, 216);
            this.cbxDistrictID.Name = "cbxDistrictID";
            this.cbxDistrictID.Size = new System.Drawing.Size(166, 21);
            this.cbxDistrictID.TabIndex = 34;
            this.cbxDistrictID.ValueMember = "DistrictID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(117, 241);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 25);
            this.label1.TabIndex = 35;
            this.label1.Text = "ประเทศไทย";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // flowLayoutPanel1
            // 
            this.pnlContent.SetColumnSpan(this.flowLayoutPanel1, 2);
            this.flowLayoutPanel1.Controls.Add(this.btnAddCompany);
            this.flowLayoutPanel1.Controls.Add(this.btnClearCompany);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(296, 101);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.pnlContent.SetRowSpan(this.flowLayoutPanel1, 2);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(258, 28);
            this.flowLayoutPanel1.TabIndex = 36;
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
            // flowLayoutPanel2
            // 
            this.pnlContent.SetColumnSpan(this.flowLayoutPanel2, 2);
            this.flowLayoutPanel2.Controls.Add(this.btnCheckPID);
            this.flowLayoutPanel2.Controls.Add(this.btnClearPID);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(296, 17);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.pnlContent.SetRowSpan(this.flowLayoutPanel2, 2);
            this.flowLayoutPanel2.Size = new System.Drawing.Size(258, 28);
            this.flowLayoutPanel2.TabIndex = 37;
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
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.SystemColors.Window;
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblTitle.Location = new System.Drawing.Point(1, 1);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lblTitle.Size = new System.Drawing.Size(592, 60);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "เพิ่มลูกค้าใหม่";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlFooter
            // 
            this.pnlFooter.Controls.Add(this.btnCancel);
            this.pnlFooter.Controls.Add(this.btnSave);
            this.pnlFooter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFooter.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.pnlFooter.Location = new System.Drawing.Point(4, 383);
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.Padding = new System.Windows.Forms.Padding(3);
            this.pnlFooter.Size = new System.Drawing.Size(586, 34);
            this.pnlFooter.TabIndex = 3;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(502, 6);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "ยกเลิก";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(421, 6);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "บันทึก";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
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
            // AddCustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 421);
            this.Controls.Add(this.pnlMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(300, 400);
            this.Name = "AddCustomerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "เพิ่มลูกค้าใหม่";
            this.Load += new System.EventHandler(this.AddCustomerForm_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.pnlContent.ResumeLayout(false);
            this.pnlContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.provinceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.farmManageDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKCityDistrictBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKDistrictProvinceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKPostCodeDistrictBindingSource)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.pnlFooter.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel pnlMain;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.FlowLayoutPanel pnlFooter;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TableLayoutPanel pnlContent;
        private System.Windows.Forms.Label lblfName;
        private System.Windows.Forms.Label lbllName;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblCompany;
        private System.Windows.Forms.Label lblProvince;
        private System.Windows.Forms.Label lblDistrict;
        private System.Windows.Forms.Label lblStreed;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblMobile;
        private System.Windows.Forms.Label lblPostCode;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.Label lblPrename;
        private System.Windows.Forms.TextBox tbxfName;
        private System.Windows.Forms.TextBox tbxlName;
        private System.Windows.Forms.TextBox tbxAddress;
        private System.Windows.Forms.ComboBox cbxProvinceID;
        private System.Windows.Forms.TextBox tbxStreed;
        private System.Windows.Forms.TextBox tbxPhone;
        private System.Windows.Forms.TextBox tbxMobile;
        private System.Windows.Forms.ComboBox cbxPrename;
        private System.Windows.Forms.Label lblPID;
        private System.Windows.Forms.TextBox tbxPID;
        private System.Windows.Forms.ComboBox cbxCompany;
        private Database.FarmManageDataSet farmManageDataSet;
        private System.Windows.Forms.BindingSource companyBindingSource;
        private Database.FarmManageDataSetTableAdapters.CompanyTableAdapter companyTableAdapter;
        private System.Windows.Forms.ComboBox cbxCityID;
        private System.Windows.Forms.ComboBox cbxPostCode;
        private System.Windows.Forms.ComboBox cbxDistrictID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnAddCompany;
        private System.Windows.Forms.Button btnClearCompany;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
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
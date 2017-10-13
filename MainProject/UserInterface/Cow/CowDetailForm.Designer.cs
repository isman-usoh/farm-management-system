namespace MainProject.UserInterface.Cow
{
    partial class CowDetailForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlMain = new System.Windows.Forms.TableLayoutPanel();
            this.footerFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.tcMain = new System.Windows.Forms.TabControl();
            this.tabGeneral = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.pnlGeneral = new System.Windows.Forms.TableLayoutPanel();
            this.lblNO = new System.Windows.Forms.Label();
            this.lblGene = new System.Windows.Forms.Label();
            this.lblSex = new System.Windows.Forms.Label();
            this.lblCorral = new System.Windows.Forms.Label();
            this.cbxGene = new System.Windows.Forms.ComboBox();
            this.cowBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.farmManageDataSet = new MainProject.Database.FarmManageDataSet();
            this.geneBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbxSex = new System.Windows.Forms.ComboBox();
            this.tbxCor = new System.Windows.Forms.TextBox();
            this.lblCor = new System.Windows.Forms.Label();
            this.cbxCorral = new System.Windows.Forms.ComboBox();
            this.corralBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblCowNO = new System.Windows.Forms.Label();
            this.tabTranfer = new System.Windows.Forms.TabPage();
            this.pnlInOutOrder = new System.Windows.Forms.TableLayoutPanel();
            this.gbxOutOrder = new System.Windows.Forms.GroupBox();
            this.pnlOutOrderContent = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.cbxOutTransportType = new System.Windows.Forms.ComboBox();
            this.orderOutBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblTransportCost = new System.Windows.Forms.Label();
            this.lblTransportType = new System.Windows.Forms.Label();
            this.lblTransportNO = new System.Windows.Forms.Label();
            this.lblTransportIssueBy = new System.Windows.Forms.Label();
            this.tbxOutTransportNO = new System.Windows.Forms.TextBox();
            this.tbxOutTransportIssueBy = new System.Windows.Forms.TextBox();
            this.lblAmount = new System.Windows.Forms.Label();
            this.tbxOutAmount = new System.Windows.Forms.TextBox();
            this.tbxOutTransportCost = new System.Windows.Forms.TextBox();
            this.lblNote = new System.Windows.Forms.Label();
            this.tbxOutNote = new System.Windows.Forms.TextBox();
            this.dtpOutDate = new System.Windows.Forms.DateTimePicker();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblOrderType = new System.Windows.Forms.Label();
            this.cbxOutOrderType = new System.Windows.Forms.ComboBox();
            this.lblCreateBy = new System.Windows.Forms.Label();
            this.cbxOutSaveBy = new System.Windows.Forms.ComboBox();
            this.usersViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnOutOrderDetail = new System.Windows.Forms.Button();
            this.gbxInOrder = new System.Windows.Forms.GroupBox();
            this.pnlInOrderContent = new System.Windows.Forms.TableLayoutPanel();
            this.pnlOrderIn = new System.Windows.Forms.TableLayoutPanel();
            this.cbxInTransportType = new System.Windows.Forms.ComboBox();
            this.orderInBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblInTransportCost = new System.Windows.Forms.Label();
            this.lblInTransportType = new System.Windows.Forms.Label();
            this.lblInTransportNO = new System.Windows.Forms.Label();
            this.lblInTransportIssueBy = new System.Windows.Forms.Label();
            this.tbxInTransportNO = new System.Windows.Forms.TextBox();
            this.tbxInTransportIssueBy = new System.Windows.Forms.TextBox();
            this.lblInAmount = new System.Windows.Forms.Label();
            this.tbxInAmount = new System.Windows.Forms.TextBox();
            this.tbxInTransportCost = new System.Windows.Forms.TextBox();
            this.lblInNote = new System.Windows.Forms.Label();
            this.tbxInNote = new System.Windows.Forms.TextBox();
            this.dtpInOrderDate = new System.Windows.Forms.DateTimePicker();
            this.lblInOrderDate = new System.Windows.Forms.Label();
            this.lblOrderInType = new System.Windows.Forms.Label();
            this.cbxOrderInType = new System.Windows.Forms.ComboBox();
            this.lblInOrderBy = new System.Windows.Forms.Label();
            this.cbxInOrderBy = new System.Windows.Forms.ComboBox();
            this.btnInOrderDetail = new System.Windows.Forms.Button();
            this.tabHealth = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.gbxVaccine = new System.Windows.Forms.GroupBox();
            this.pnlVaccineContent = new System.Windows.Forms.TableLayoutPanel();
            this.pnlVaccineContentOption = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAddVaccineHistory = new System.Windows.Forms.Button();
            this.dgvVaccine = new System.Windows.Forms.DataGridView();
            this.colVaccineID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colVaccineStockID = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.stockBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colVaccineUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colVaccineBy = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.colVaccineDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fKVaccineCow1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gbxMedicine = new System.Windows.Forms.GroupBox();
            this.pnlMedicineContent = new System.Windows.Forms.TableLayoutPanel();
            this.pnlMedicineContentOption = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAddMedicine = new System.Windows.Forms.Button();
            this.dgvMedicine = new System.Windows.Forms.DataGridView();
            this.colDiseaseID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDiseaseSymptom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDiseaseTreament = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diseaseHistoryByDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.colDiseaseDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fKDiseaseHistoryCow1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabRecord = new System.Windows.Forms.TabPage();
            this.userLogUC = new MainProject.UserInterface.Control.UserLogUC();
            this.cowTableAdapter = new MainProject.Database.FarmManageDataSetTableAdapters.CowTableAdapter();
            this.orderInTableAdapter = new MainProject.Database.FarmManageDataSetTableAdapters.OrderInTableAdapter();
            this.orderOutTableAdapter = new MainProject.Database.FarmManageDataSetTableAdapters.OrderOutTableAdapter();
            this.vaccineTableAdapter = new MainProject.Database.FarmManageDataSetTableAdapters.VaccineTableAdapter();
            this.diseaseHistoryTableAdapter = new MainProject.Database.FarmManageDataSetTableAdapters.DiseaseHistoryTableAdapter();
            this.geneTableAdapter = new MainProject.Database.FarmManageDataSetTableAdapters.GeneTableAdapter();
            this.corralTableAdapter = new MainProject.Database.FarmManageDataSetTableAdapters.CorralTableAdapter();
            this.usersViewTableAdapter = new MainProject.Database.FarmManageDataSetTableAdapters.UsersViewTableAdapter();
            this.stockTableAdapter = new MainProject.Database.FarmManageDataSetTableAdapters.StockTableAdapter();
            this.pnlMain.SuspendLayout();
            this.footerFlowLayoutPanel.SuspendLayout();
            this.tcMain.SuspendLayout();
            this.tabGeneral.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.pnlGeneral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cowBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.farmManageDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.geneBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.corralBindingSource)).BeginInit();
            this.tabTranfer.SuspendLayout();
            this.pnlInOutOrder.SuspendLayout();
            this.gbxOutOrder.SuspendLayout();
            this.pnlOutOrderContent.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderOutBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersViewBindingSource)).BeginInit();
            this.gbxInOrder.SuspendLayout();
            this.pnlInOrderContent.SuspendLayout();
            this.pnlOrderIn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderInBindingSource)).BeginInit();
            this.tabHealth.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.gbxVaccine.SuspendLayout();
            this.pnlVaccineContent.SuspendLayout();
            this.pnlVaccineContentOption.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVaccine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKVaccineCow1BindingSource)).BeginInit();
            this.gbxMedicine.SuspendLayout();
            this.pnlMedicineContent.SuspendLayout();
            this.pnlMedicineContentOption.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKDiseaseHistoryCow1BindingSource)).BeginInit();
            this.tabRecord.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.pnlMain.ColumnCount = 1;
            this.pnlMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.pnlMain.Controls.Add(this.footerFlowLayoutPanel, 0, 2);
            this.pnlMain.Controls.Add(this.lblTitle, 0, 0);
            this.pnlMain.Controls.Add(this.tcMain, 0, 1);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.RowCount = 3;
            this.pnlMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.pnlMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.pnlMain.Size = new System.Drawing.Size(684, 617);
            this.pnlMain.TabIndex = 0;
            // 
            // footerFlowLayoutPanel
            // 
            this.footerFlowLayoutPanel.Controls.Add(this.btnCancel);
            this.footerFlowLayoutPanel.Controls.Add(this.btnSave);
            this.footerFlowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.footerFlowLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.footerFlowLayoutPanel.Location = new System.Drawing.Point(4, 579);
            this.footerFlowLayoutPanel.Name = "footerFlowLayoutPanel";
            this.footerFlowLayoutPanel.Padding = new System.Windows.Forms.Padding(3);
            this.footerFlowLayoutPanel.Size = new System.Drawing.Size(676, 34);
            this.footerFlowLayoutPanel.TabIndex = 5;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(592, 6);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "ยกเลิก";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(511, 6);
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
            this.lblTitle.Location = new System.Drawing.Point(1, 1);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lblTitle.Size = new System.Drawing.Size(682, 60);
            this.lblTitle.TabIndex = 4;
            this.lblTitle.Text = "ข้อมูลโค";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tcMain
            // 
            this.tcMain.Controls.Add(this.tabGeneral);
            this.tcMain.Controls.Add(this.tabTranfer);
            this.tcMain.Controls.Add(this.tabHealth);
            this.tcMain.Controls.Add(this.tabRecord);
            this.tcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcMain.Location = new System.Drawing.Point(4, 65);
            this.tcMain.Name = "tcMain";
            this.tcMain.SelectedIndex = 0;
            this.tcMain.Size = new System.Drawing.Size(676, 507);
            this.tcMain.TabIndex = 6;
            // 
            // tabGeneral
            // 
            this.tabGeneral.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabGeneral.Controls.Add(this.tableLayoutPanel3);
            this.tabGeneral.Location = new System.Drawing.Point(4, 22);
            this.tabGeneral.Name = "tabGeneral";
            this.tabGeneral.Padding = new System.Windows.Forms.Padding(3);
            this.tabGeneral.Size = new System.Drawing.Size(668, 481);
            this.tabGeneral.TabIndex = 0;
            this.tabGeneral.Text = "ข้อมูลทั่วไป";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.groupBox3, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 475F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(662, 475);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.pnlGeneral);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(3, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(656, 469);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "ข้อมูลทั่วไป";
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
            this.pnlGeneral.Controls.Add(this.lblNO, 1, 1);
            this.pnlGeneral.Controls.Add(this.lblGene, 1, 3);
            this.pnlGeneral.Controls.Add(this.lblSex, 4, 3);
            this.pnlGeneral.Controls.Add(this.lblCorral, 1, 5);
            this.pnlGeneral.Controls.Add(this.cbxGene, 2, 3);
            this.pnlGeneral.Controls.Add(this.cbxSex, 5, 3);
            this.pnlGeneral.Controls.Add(this.tbxCor, 2, 7);
            this.pnlGeneral.Controls.Add(this.lblCor, 1, 7);
            this.pnlGeneral.Controls.Add(this.cbxCorral, 2, 5);
            this.pnlGeneral.Controls.Add(this.lblCowNO, 2, 1);
            this.pnlGeneral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGeneral.Location = new System.Drawing.Point(3, 16);
            this.pnlGeneral.Name = "pnlGeneral";
            this.pnlGeneral.RowCount = 13;
            this.pnlGeneral.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
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
            this.pnlGeneral.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlGeneral.Size = new System.Drawing.Size(650, 450);
            this.pnlGeneral.TabIndex = 10;
            // 
            // lblNO
            // 
            this.lblNO.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNO.Location = new System.Drawing.Point(35, 5);
            this.lblNO.Name = "lblNO";
            this.lblNO.Size = new System.Drawing.Size(90, 25);
            this.lblNO.TabIndex = 0;
            this.lblNO.Text = "หมายเลข";
            this.lblNO.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblGene
            // 
            this.lblGene.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblGene.Location = new System.Drawing.Point(35, 33);
            this.lblGene.Name = "lblGene";
            this.lblGene.Size = new System.Drawing.Size(90, 25);
            this.lblGene.TabIndex = 2;
            this.lblGene.Text = "พันธุ์";
            this.lblGene.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSex
            // 
            this.lblSex.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSex.Location = new System.Drawing.Point(333, 33);
            this.lblSex.Name = "lblSex";
            this.lblSex.Size = new System.Drawing.Size(90, 25);
            this.lblSex.TabIndex = 3;
            this.lblSex.Text = "เพศ";
            this.lblSex.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCorral
            // 
            this.lblCorral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCorral.Location = new System.Drawing.Point(35, 61);
            this.lblCorral.Name = "lblCorral";
            this.lblCorral.Size = new System.Drawing.Size(90, 25);
            this.lblCorral.TabIndex = 4;
            this.lblCorral.Text = "คอก";
            this.lblCorral.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbxGene
            // 
            this.cbxGene.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.cowBindingSource, "GeneID", true));
            this.cbxGene.DataSource = this.geneBindingSource;
            this.cbxGene.DisplayMember = "Name";
            this.cbxGene.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbxGene.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxGene.FormattingEnabled = true;
            this.cbxGene.Location = new System.Drawing.Point(131, 36);
            this.cbxGene.Name = "cbxGene";
            this.cbxGene.Size = new System.Drawing.Size(186, 21);
            this.cbxGene.TabIndex = 7;
            this.cbxGene.ValueMember = "GeneID";
            // 
            // cowBindingSource
            // 
            this.cowBindingSource.DataMember = "Cow";
            this.cowBindingSource.DataSource = this.farmManageDataSet;
            // 
            // farmManageDataSet
            // 
            this.farmManageDataSet.DataSetName = "FarmManageDataSet";
            this.farmManageDataSet.Locale = new System.Globalization.CultureInfo("en");
            this.farmManageDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // geneBindingSource
            // 
            this.geneBindingSource.DataMember = "Gene";
            this.geneBindingSource.DataSource = this.farmManageDataSet;
            // 
            // cbxSex
            // 
            this.cbxSex.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.cowBindingSource, "Sex", true));
            this.cbxSex.DisplayMember = "Value";
            this.cbxSex.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbxSex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSex.FormattingEnabled = true;
            this.cbxSex.Items.AddRange(new object[] {
            "ผู้",
            "เมีย"});
            this.cbxSex.Location = new System.Drawing.Point(429, 36);
            this.cbxSex.Name = "cbxSex";
            this.cbxSex.Size = new System.Drawing.Size(186, 21);
            this.cbxSex.TabIndex = 9;
            this.cbxSex.ValueMember = "Key";
            // 
            // tbxCor
            // 
            this.tbxCor.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cowBindingSource, "Description", true));
            this.tbxCor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxCor.Location = new System.Drawing.Point(131, 92);
            this.tbxCor.Multiline = true;
            this.tbxCor.Name = "tbxCor";
            this.pnlGeneral.SetRowSpan(this.tbxCor, 5);
            this.tbxCor.Size = new System.Drawing.Size(186, 75);
            this.tbxCor.TabIndex = 8;
            // 
            // lblCor
            // 
            this.lblCor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCor.Location = new System.Drawing.Point(35, 89);
            this.lblCor.Name = "lblCor";
            this.pnlGeneral.SetRowSpan(this.lblCor, 5);
            this.lblCor.Size = new System.Drawing.Size(90, 81);
            this.lblCor.TabIndex = 10;
            this.lblCor.Text = "ตำหนิ/ลักษณะ";
            this.lblCor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbxCorral
            // 
            this.cbxCorral.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.cowBindingSource, "CorralID", true));
            this.cbxCorral.DataSource = this.corralBindingSource;
            this.cbxCorral.DisplayMember = "Name";
            this.cbxCorral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbxCorral.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCorral.FormattingEnabled = true;
            this.cbxCorral.Location = new System.Drawing.Point(131, 64);
            this.cbxCorral.Name = "cbxCorral";
            this.cbxCorral.Size = new System.Drawing.Size(186, 21);
            this.cbxCorral.TabIndex = 11;
            this.cbxCorral.ValueMember = "CorralID";
            this.cbxCorral.SelectedIndexChanged += new System.EventHandler(this.cbxCorral_SelectedIndexChanged);
            // 
            // corralBindingSource
            // 
            this.corralBindingSource.DataMember = "Corral";
            this.corralBindingSource.DataSource = this.farmManageDataSet;
            // 
            // lblCowNO
            // 
            this.lblCowNO.AutoSize = true;
            this.lblCowNO.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cowBindingSource, "CowNO", true));
            this.lblCowNO.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCowNO.Location = new System.Drawing.Point(131, 5);
            this.lblCowNO.Name = "lblCowNO";
            this.lblCowNO.Size = new System.Drawing.Size(186, 25);
            this.lblCowNO.TabIndex = 12;
            this.lblCowNO.Text = "-";
            this.lblCowNO.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tabTranfer
            // 
            this.tabTranfer.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabTranfer.Controls.Add(this.pnlInOutOrder);
            this.tabTranfer.Location = new System.Drawing.Point(4, 22);
            this.tabTranfer.Name = "tabTranfer";
            this.tabTranfer.Padding = new System.Windows.Forms.Padding(3);
            this.tabTranfer.Size = new System.Drawing.Size(668, 481);
            this.tabTranfer.TabIndex = 3;
            this.tabTranfer.Text = "การนำเข้าและออก";
            // 
            // pnlInOutOrder
            // 
            this.pnlInOutOrder.ColumnCount = 1;
            this.pnlInOutOrder.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.pnlInOutOrder.Controls.Add(this.gbxOutOrder, 0, 1);
            this.pnlInOutOrder.Controls.Add(this.gbxInOrder, 0, 0);
            this.pnlInOutOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlInOutOrder.Location = new System.Drawing.Point(3, 3);
            this.pnlInOutOrder.Name = "pnlInOutOrder";
            this.pnlInOutOrder.RowCount = 2;
            this.pnlInOutOrder.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.pnlInOutOrder.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.pnlInOutOrder.Size = new System.Drawing.Size(662, 475);
            this.pnlInOutOrder.TabIndex = 0;
            // 
            // gbxOutOrder
            // 
            this.gbxOutOrder.Controls.Add(this.pnlOutOrderContent);
            this.gbxOutOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbxOutOrder.Location = new System.Drawing.Point(3, 240);
            this.gbxOutOrder.Name = "gbxOutOrder";
            this.gbxOutOrder.Size = new System.Drawing.Size(656, 232);
            this.gbxOutOrder.TabIndex = 3;
            this.gbxOutOrder.TabStop = false;
            this.gbxOutOrder.Text = "ข้อมูลนำออกจากฟาร์ม";
            // 
            // pnlOutOrderContent
            // 
            this.pnlOutOrderContent.ColumnCount = 1;
            this.pnlOutOrderContent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlOutOrderContent.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.pnlOutOrderContent.Controls.Add(this.btnOutOrderDetail, 0, 1);
            this.pnlOutOrderContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlOutOrderContent.Location = new System.Drawing.Point(3, 16);
            this.pnlOutOrderContent.Name = "pnlOutOrderContent";
            this.pnlOutOrderContent.RowCount = 2;
            this.pnlOutOrderContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlOutOrderContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.pnlOutOrderContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.pnlOutOrderContent.Size = new System.Drawing.Size(650, 213);
            this.pnlOutOrderContent.TabIndex = 11;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 7;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel2.Controls.Add(this.cbxOutTransportType, 2, 5);
            this.tableLayoutPanel2.Controls.Add(this.lblTransportCost, 4, 5);
            this.tableLayoutPanel2.Controls.Add(this.lblTransportType, 1, 5);
            this.tableLayoutPanel2.Controls.Add(this.lblTransportNO, 1, 7);
            this.tableLayoutPanel2.Controls.Add(this.lblTransportIssueBy, 4, 7);
            this.tableLayoutPanel2.Controls.Add(this.tbxOutTransportNO, 2, 7);
            this.tableLayoutPanel2.Controls.Add(this.tbxOutTransportIssueBy, 5, 7);
            this.tableLayoutPanel2.Controls.Add(this.lblAmount, 1, 9);
            this.tableLayoutPanel2.Controls.Add(this.tbxOutAmount, 2, 9);
            this.tableLayoutPanel2.Controls.Add(this.tbxOutTransportCost, 5, 5);
            this.tableLayoutPanel2.Controls.Add(this.lblNote, 4, 9);
            this.tableLayoutPanel2.Controls.Add(this.tbxOutNote, 5, 9);
            this.tableLayoutPanel2.Controls.Add(this.dtpOutDate, 2, 3);
            this.tableLayoutPanel2.Controls.Add(this.lblDate, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.lblOrderType, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.cbxOutOrderType, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.lblCreateBy, 4, 3);
            this.tableLayoutPanel2.Controls.Add(this.cbxOutSaveBy, 5, 3);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 13;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 9F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 3F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 3F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 3F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 3F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 3F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 3F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(644, 176);
            this.tableLayoutPanel2.TabIndex = 15;
            // 
            // cbxOutTransportType
            // 
            this.cbxOutTransportType.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.orderOutBindingSource, "TransportType", true));
            this.cbxOutTransportType.DisplayMember = "Value";
            this.cbxOutTransportType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbxOutTransportType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxOutTransportType.Enabled = false;
            this.cbxOutTransportType.FormattingEnabled = true;
            this.cbxOutTransportType.Location = new System.Drawing.Point(129, 69);
            this.cbxOutTransportType.Name = "cbxOutTransportType";
            this.cbxOutTransportType.Size = new System.Drawing.Size(184, 21);
            this.cbxOutTransportType.TabIndex = 1;
            this.cbxOutTransportType.ValueMember = "Key";
            // 
            // orderOutBindingSource
            // 
            this.orderOutBindingSource.DataMember = "OrderOut";
            this.orderOutBindingSource.DataSource = this.farmManageDataSet;
            // 
            // lblTransportCost
            // 
            this.lblTransportCost.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTransportCost.Location = new System.Drawing.Point(329, 66);
            this.lblTransportCost.Name = "lblTransportCost";
            this.lblTransportCost.Size = new System.Drawing.Size(89, 25);
            this.lblTransportCost.TabIndex = 2;
            this.lblTransportCost.Text = "ค่าขนส่ง";
            this.lblTransportCost.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTransportType
            // 
            this.lblTransportType.AutoSize = true;
            this.lblTransportType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTransportType.Location = new System.Drawing.Point(34, 66);
            this.lblTransportType.Name = "lblTransportType";
            this.lblTransportType.Size = new System.Drawing.Size(89, 25);
            this.lblTransportType.TabIndex = 5;
            this.lblTransportType.Text = "วิธิการขนส่ง";
            this.lblTransportType.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTransportNO
            // 
            this.lblTransportNO.AutoSize = true;
            this.lblTransportNO.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTransportNO.Location = new System.Drawing.Point(34, 94);
            this.lblTransportNO.Name = "lblTransportNO";
            this.lblTransportNO.Size = new System.Drawing.Size(89, 25);
            this.lblTransportNO.TabIndex = 12;
            this.lblTransportNO.Text = "เลขทีใบย้ายออก";
            this.lblTransportNO.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTransportIssueBy
            // 
            this.lblTransportIssueBy.AutoSize = true;
            this.lblTransportIssueBy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTransportIssueBy.Location = new System.Drawing.Point(329, 94);
            this.lblTransportIssueBy.Name = "lblTransportIssueBy";
            this.lblTransportIssueBy.Size = new System.Drawing.Size(89, 25);
            this.lblTransportIssueBy.TabIndex = 13;
            this.lblTransportIssueBy.Text = "ออกให้โดย";
            this.lblTransportIssueBy.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbxOutTransportNO
            // 
            this.tbxOutTransportNO.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orderOutBindingSource, "TransportBillNO", true));
            this.tbxOutTransportNO.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxOutTransportNO.Location = new System.Drawing.Point(129, 97);
            this.tbxOutTransportNO.Name = "tbxOutTransportNO";
            this.tbxOutTransportNO.ReadOnly = true;
            this.tbxOutTransportNO.Size = new System.Drawing.Size(184, 20);
            this.tbxOutTransportNO.TabIndex = 16;
            // 
            // tbxOutTransportIssueBy
            // 
            this.tbxOutTransportIssueBy.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orderOutBindingSource, "TransportBillIssuesBy", true));
            this.tbxOutTransportIssueBy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxOutTransportIssueBy.Location = new System.Drawing.Point(424, 97);
            this.tbxOutTransportIssueBy.Name = "tbxOutTransportIssueBy";
            this.tbxOutTransportIssueBy.ReadOnly = true;
            this.tbxOutTransportIssueBy.Size = new System.Drawing.Size(184, 20);
            this.tbxOutTransportIssueBy.TabIndex = 17;
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAmount.Location = new System.Drawing.Point(34, 122);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(89, 25);
            this.lblAmount.TabIndex = 20;
            this.lblAmount.Text = "ราคาต่อตัว";
            this.lblAmount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbxOutAmount
            // 
            this.tbxOutAmount.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orderOutBindingSource, "AmountPerUnit", true));
            this.tbxOutAmount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxOutAmount.Location = new System.Drawing.Point(129, 125);
            this.tbxOutAmount.Name = "tbxOutAmount";
            this.tbxOutAmount.ReadOnly = true;
            this.tbxOutAmount.Size = new System.Drawing.Size(184, 20);
            this.tbxOutAmount.TabIndex = 23;
            // 
            // tbxOutTransportCost
            // 
            this.tbxOutTransportCost.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orderOutBindingSource, "TransportCost", true));
            this.tbxOutTransportCost.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxOutTransportCost.Location = new System.Drawing.Point(424, 69);
            this.tbxOutTransportCost.Name = "tbxOutTransportCost";
            this.tbxOutTransportCost.ReadOnly = true;
            this.tbxOutTransportCost.Size = new System.Drawing.Size(184, 20);
            this.tbxOutTransportCost.TabIndex = 26;
            // 
            // lblNote
            // 
            this.lblNote.AutoSize = true;
            this.lblNote.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNote.Location = new System.Drawing.Point(329, 122);
            this.lblNote.Name = "lblNote";
            this.tableLayoutPanel2.SetRowSpan(this.lblNote, 3);
            this.lblNote.Size = new System.Drawing.Size(89, 53);
            this.lblNote.TabIndex = 27;
            this.lblNote.Text = "หมายเหตุ";
            this.lblNote.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbxOutNote
            // 
            this.tbxOutNote.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orderOutBindingSource, "Description", true));
            this.tbxOutNote.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxOutNote.Location = new System.Drawing.Point(424, 125);
            this.tbxOutNote.Multiline = true;
            this.tbxOutNote.Name = "tbxOutNote";
            this.tbxOutNote.ReadOnly = true;
            this.tableLayoutPanel2.SetRowSpan(this.tbxOutNote, 3);
            this.tbxOutNote.Size = new System.Drawing.Size(184, 47);
            this.tbxOutNote.TabIndex = 28;
            // 
            // dtpOutDate
            // 
            this.dtpOutDate.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.orderOutBindingSource, "Date", true));
            this.dtpOutDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtpOutDate.Enabled = false;
            this.dtpOutDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpOutDate.Location = new System.Drawing.Point(129, 41);
            this.dtpOutDate.Name = "dtpOutDate";
            this.dtpOutDate.Size = new System.Drawing.Size(184, 20);
            this.dtpOutDate.TabIndex = 30;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDate.Location = new System.Drawing.Point(34, 38);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(89, 25);
            this.lblDate.TabIndex = 29;
            this.lblDate.Text = "วันที่";
            this.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblOrderType
            // 
            this.lblOrderType.AutoSize = true;
            this.lblOrderType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblOrderType.Location = new System.Drawing.Point(34, 9);
            this.lblOrderType.Name = "lblOrderType";
            this.lblOrderType.Size = new System.Drawing.Size(89, 26);
            this.lblOrderType.TabIndex = 31;
            this.lblOrderType.Text = "ประเภทนำออก";
            this.lblOrderType.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbxOutOrderType
            // 
            this.cbxOutOrderType.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.orderOutBindingSource, "OrderType", true));
            this.cbxOutOrderType.DisplayMember = "Value";
            this.cbxOutOrderType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbxOutOrderType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxOutOrderType.Enabled = false;
            this.cbxOutOrderType.FormattingEnabled = true;
            this.cbxOutOrderType.Items.AddRange(new object[] {
            "ซื้อ"});
            this.cbxOutOrderType.Location = new System.Drawing.Point(129, 12);
            this.cbxOutOrderType.Name = "cbxOutOrderType";
            this.cbxOutOrderType.Size = new System.Drawing.Size(184, 21);
            this.cbxOutOrderType.TabIndex = 32;
            this.cbxOutOrderType.ValueMember = "Key";
            // 
            // lblCreateBy
            // 
            this.lblCreateBy.AutoSize = true;
            this.lblCreateBy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCreateBy.Location = new System.Drawing.Point(329, 38);
            this.lblCreateBy.Name = "lblCreateBy";
            this.lblCreateBy.Size = new System.Drawing.Size(89, 25);
            this.lblCreateBy.TabIndex = 33;
            this.lblCreateBy.Text = "โดย";
            this.lblCreateBy.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbxOutSaveBy
            // 
            this.cbxOutSaveBy.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.orderOutBindingSource, "OrderBy", true));
            this.cbxOutSaveBy.DataSource = this.usersViewBindingSource;
            this.cbxOutSaveBy.DisplayMember = "Name";
            this.cbxOutSaveBy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbxOutSaveBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxOutSaveBy.Enabled = false;
            this.cbxOutSaveBy.FormattingEnabled = true;
            this.cbxOutSaveBy.Location = new System.Drawing.Point(424, 41);
            this.cbxOutSaveBy.Name = "cbxOutSaveBy";
            this.cbxOutSaveBy.Size = new System.Drawing.Size(184, 21);
            this.cbxOutSaveBy.TabIndex = 34;
            this.cbxOutSaveBy.ValueMember = "UserID";
            // 
            // usersViewBindingSource
            // 
            this.usersViewBindingSource.DataMember = "UsersView";
            this.usersViewBindingSource.DataSource = this.farmManageDataSet;
            // 
            // btnOutOrderDetail
            // 
            this.btnOutOrderDetail.Location = new System.Drawing.Point(3, 185);
            this.btnOutOrderDetail.Name = "btnOutOrderDetail";
            this.btnOutOrderDetail.Size = new System.Drawing.Size(120, 23);
            this.btnOutOrderDetail.TabIndex = 2;
            this.btnOutOrderDetail.Text = "รายละเอียดเพิ่มเติ่ม";
            this.btnOutOrderDetail.UseVisualStyleBackColor = true;
            this.btnOutOrderDetail.Click += new System.EventHandler(this.btnOutOrderDetail_Click);
            // 
            // gbxInOrder
            // 
            this.gbxInOrder.Controls.Add(this.pnlInOrderContent);
            this.gbxInOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbxInOrder.Location = new System.Drawing.Point(3, 3);
            this.gbxInOrder.Name = "gbxInOrder";
            this.gbxInOrder.Size = new System.Drawing.Size(656, 231);
            this.gbxInOrder.TabIndex = 2;
            this.gbxInOrder.TabStop = false;
            this.gbxInOrder.Text = "ข้อมูลการนำเข้าฟาร์ม";
            // 
            // pnlInOrderContent
            // 
            this.pnlInOrderContent.ColumnCount = 1;
            this.pnlInOrderContent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlInOrderContent.Controls.Add(this.pnlOrderIn, 0, 0);
            this.pnlInOrderContent.Controls.Add(this.btnInOrderDetail, 0, 1);
            this.pnlInOrderContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlInOrderContent.Location = new System.Drawing.Point(3, 16);
            this.pnlInOrderContent.Name = "pnlInOrderContent";
            this.pnlInOrderContent.RowCount = 2;
            this.pnlInOrderContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlInOrderContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.pnlInOrderContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.pnlInOrderContent.Size = new System.Drawing.Size(650, 212);
            this.pnlInOrderContent.TabIndex = 10;
            // 
            // pnlOrderIn
            // 
            this.pnlOrderIn.ColumnCount = 7;
            this.pnlOrderIn.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.pnlOrderIn.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.pnlOrderIn.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.pnlOrderIn.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.pnlOrderIn.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.pnlOrderIn.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.pnlOrderIn.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.pnlOrderIn.Controls.Add(this.cbxInTransportType, 2, 5);
            this.pnlOrderIn.Controls.Add(this.lblInTransportCost, 4, 5);
            this.pnlOrderIn.Controls.Add(this.lblInTransportType, 1, 5);
            this.pnlOrderIn.Controls.Add(this.lblInTransportNO, 1, 7);
            this.pnlOrderIn.Controls.Add(this.lblInTransportIssueBy, 4, 7);
            this.pnlOrderIn.Controls.Add(this.tbxInTransportNO, 2, 7);
            this.pnlOrderIn.Controls.Add(this.tbxInTransportIssueBy, 5, 7);
            this.pnlOrderIn.Controls.Add(this.lblInAmount, 1, 9);
            this.pnlOrderIn.Controls.Add(this.tbxInAmount, 2, 9);
            this.pnlOrderIn.Controls.Add(this.tbxInTransportCost, 5, 5);
            this.pnlOrderIn.Controls.Add(this.lblInNote, 4, 9);
            this.pnlOrderIn.Controls.Add(this.tbxInNote, 5, 9);
            this.pnlOrderIn.Controls.Add(this.dtpInOrderDate, 2, 3);
            this.pnlOrderIn.Controls.Add(this.lblInOrderDate, 1, 3);
            this.pnlOrderIn.Controls.Add(this.lblOrderInType, 1, 1);
            this.pnlOrderIn.Controls.Add(this.cbxOrderInType, 2, 1);
            this.pnlOrderIn.Controls.Add(this.lblInOrderBy, 4, 3);
            this.pnlOrderIn.Controls.Add(this.cbxInOrderBy, 5, 3);
            this.pnlOrderIn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlOrderIn.Location = new System.Drawing.Point(3, 3);
            this.pnlOrderIn.Name = "pnlOrderIn";
            this.pnlOrderIn.RowCount = 13;
            this.pnlOrderIn.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 9F));
            this.pnlOrderIn.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.pnlOrderIn.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 3F));
            this.pnlOrderIn.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.pnlOrderIn.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 3F));
            this.pnlOrderIn.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.pnlOrderIn.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 3F));
            this.pnlOrderIn.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.pnlOrderIn.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 3F));
            this.pnlOrderIn.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.pnlOrderIn.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 3F));
            this.pnlOrderIn.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.pnlOrderIn.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 3F));
            this.pnlOrderIn.Size = new System.Drawing.Size(644, 175);
            this.pnlOrderIn.TabIndex = 15;
            // 
            // cbxInTransportType
            // 
            this.cbxInTransportType.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.orderInBindingSource, "TransportType", true));
            this.cbxInTransportType.DisplayMember = "Value";
            this.cbxInTransportType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbxInTransportType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxInTransportType.Enabled = false;
            this.cbxInTransportType.FormattingEnabled = true;
            this.cbxInTransportType.Location = new System.Drawing.Point(129, 69);
            this.cbxInTransportType.Name = "cbxInTransportType";
            this.cbxInTransportType.Size = new System.Drawing.Size(184, 21);
            this.cbxInTransportType.TabIndex = 1;
            this.cbxInTransportType.ValueMember = "Key";
            // 
            // orderInBindingSource
            // 
            this.orderInBindingSource.DataMember = "OrderIn";
            this.orderInBindingSource.DataSource = this.farmManageDataSet;
            // 
            // lblInTransportCost
            // 
            this.lblInTransportCost.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblInTransportCost.Location = new System.Drawing.Point(329, 66);
            this.lblInTransportCost.Name = "lblInTransportCost";
            this.lblInTransportCost.Size = new System.Drawing.Size(89, 25);
            this.lblInTransportCost.TabIndex = 2;
            this.lblInTransportCost.Text = "ค่าขนส่ง";
            this.lblInTransportCost.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblInTransportType
            // 
            this.lblInTransportType.AutoSize = true;
            this.lblInTransportType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblInTransportType.Location = new System.Drawing.Point(34, 66);
            this.lblInTransportType.Name = "lblInTransportType";
            this.lblInTransportType.Size = new System.Drawing.Size(89, 25);
            this.lblInTransportType.TabIndex = 5;
            this.lblInTransportType.Text = "วิธิการขนส่ง";
            this.lblInTransportType.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblInTransportNO
            // 
            this.lblInTransportNO.AutoSize = true;
            this.lblInTransportNO.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblInTransportNO.Location = new System.Drawing.Point(34, 94);
            this.lblInTransportNO.Name = "lblInTransportNO";
            this.lblInTransportNO.Size = new System.Drawing.Size(89, 25);
            this.lblInTransportNO.TabIndex = 12;
            this.lblInTransportNO.Text = "เลขทีใบย้ายเข้า";
            this.lblInTransportNO.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblInTransportIssueBy
            // 
            this.lblInTransportIssueBy.AutoSize = true;
            this.lblInTransportIssueBy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblInTransportIssueBy.Location = new System.Drawing.Point(329, 94);
            this.lblInTransportIssueBy.Name = "lblInTransportIssueBy";
            this.lblInTransportIssueBy.Size = new System.Drawing.Size(89, 25);
            this.lblInTransportIssueBy.TabIndex = 13;
            this.lblInTransportIssueBy.Text = "ออกให้โดย";
            this.lblInTransportIssueBy.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbxInTransportNO
            // 
            this.tbxInTransportNO.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orderInBindingSource, "TransportBillNO", true));
            this.tbxInTransportNO.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxInTransportNO.Location = new System.Drawing.Point(129, 97);
            this.tbxInTransportNO.Name = "tbxInTransportNO";
            this.tbxInTransportNO.ReadOnly = true;
            this.tbxInTransportNO.Size = new System.Drawing.Size(184, 20);
            this.tbxInTransportNO.TabIndex = 16;
            // 
            // tbxInTransportIssueBy
            // 
            this.tbxInTransportIssueBy.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orderInBindingSource, "TransportBillIssuedBy", true));
            this.tbxInTransportIssueBy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxInTransportIssueBy.Location = new System.Drawing.Point(424, 97);
            this.tbxInTransportIssueBy.Name = "tbxInTransportIssueBy";
            this.tbxInTransportIssueBy.ReadOnly = true;
            this.tbxInTransportIssueBy.Size = new System.Drawing.Size(184, 20);
            this.tbxInTransportIssueBy.TabIndex = 17;
            // 
            // lblInAmount
            // 
            this.lblInAmount.AutoSize = true;
            this.lblInAmount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblInAmount.Location = new System.Drawing.Point(34, 122);
            this.lblInAmount.Name = "lblInAmount";
            this.lblInAmount.Size = new System.Drawing.Size(89, 25);
            this.lblInAmount.TabIndex = 20;
            this.lblInAmount.Text = "ราคาต่อตัว";
            this.lblInAmount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbxInAmount
            // 
            this.tbxInAmount.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orderInBindingSource, "AmountPerUnit", true));
            this.tbxInAmount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxInAmount.Location = new System.Drawing.Point(129, 125);
            this.tbxInAmount.Name = "tbxInAmount";
            this.tbxInAmount.ReadOnly = true;
            this.tbxInAmount.Size = new System.Drawing.Size(184, 20);
            this.tbxInAmount.TabIndex = 23;
            // 
            // tbxInTransportCost
            // 
            this.tbxInTransportCost.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orderInBindingSource, "TransportCost", true));
            this.tbxInTransportCost.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxInTransportCost.Location = new System.Drawing.Point(424, 69);
            this.tbxInTransportCost.Name = "tbxInTransportCost";
            this.tbxInTransportCost.ReadOnly = true;
            this.tbxInTransportCost.Size = new System.Drawing.Size(184, 20);
            this.tbxInTransportCost.TabIndex = 26;
            // 
            // lblInNote
            // 
            this.lblInNote.AutoSize = true;
            this.lblInNote.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblInNote.Location = new System.Drawing.Point(329, 122);
            this.lblInNote.Name = "lblInNote";
            this.pnlOrderIn.SetRowSpan(this.lblInNote, 3);
            this.lblInNote.Size = new System.Drawing.Size(89, 53);
            this.lblInNote.TabIndex = 27;
            this.lblInNote.Text = "หมายเหตุ";
            this.lblInNote.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbxInNote
            // 
            this.tbxInNote.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orderInBindingSource, "Description", true));
            this.tbxInNote.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxInNote.Location = new System.Drawing.Point(424, 125);
            this.tbxInNote.Multiline = true;
            this.tbxInNote.Name = "tbxInNote";
            this.tbxInNote.ReadOnly = true;
            this.pnlOrderIn.SetRowSpan(this.tbxInNote, 3);
            this.tbxInNote.Size = new System.Drawing.Size(184, 47);
            this.tbxInNote.TabIndex = 28;
            // 
            // dtpInOrderDate
            // 
            this.dtpInOrderDate.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.orderInBindingSource, "Date", true));
            this.dtpInOrderDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtpInOrderDate.Enabled = false;
            this.dtpInOrderDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpInOrderDate.Location = new System.Drawing.Point(129, 41);
            this.dtpInOrderDate.Name = "dtpInOrderDate";
            this.dtpInOrderDate.Size = new System.Drawing.Size(184, 20);
            this.dtpInOrderDate.TabIndex = 30;
            // 
            // lblInOrderDate
            // 
            this.lblInOrderDate.AutoSize = true;
            this.lblInOrderDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblInOrderDate.Location = new System.Drawing.Point(34, 38);
            this.lblInOrderDate.Name = "lblInOrderDate";
            this.lblInOrderDate.Size = new System.Drawing.Size(89, 25);
            this.lblInOrderDate.TabIndex = 29;
            this.lblInOrderDate.Text = "วันที่";
            this.lblInOrderDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblOrderInType
            // 
            this.lblOrderInType.AutoSize = true;
            this.lblOrderInType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblOrderInType.Location = new System.Drawing.Point(34, 9);
            this.lblOrderInType.Name = "lblOrderInType";
            this.lblOrderInType.Size = new System.Drawing.Size(89, 26);
            this.lblOrderInType.TabIndex = 31;
            this.lblOrderInType.Text = "ประเภทนำเข้า";
            this.lblOrderInType.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbxOrderInType
            // 
            this.cbxOrderInType.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.orderInBindingSource, "OrderType", true));
            this.cbxOrderInType.DisplayMember = "Value";
            this.cbxOrderInType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbxOrderInType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxOrderInType.Enabled = false;
            this.cbxOrderInType.FormattingEnabled = true;
            this.cbxOrderInType.Items.AddRange(new object[] {
            "ซื้อ"});
            this.cbxOrderInType.Location = new System.Drawing.Point(129, 12);
            this.cbxOrderInType.Name = "cbxOrderInType";
            this.cbxOrderInType.Size = new System.Drawing.Size(184, 21);
            this.cbxOrderInType.TabIndex = 32;
            this.cbxOrderInType.ValueMember = "Key";
            // 
            // lblInOrderBy
            // 
            this.lblInOrderBy.AutoSize = true;
            this.lblInOrderBy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblInOrderBy.Location = new System.Drawing.Point(329, 38);
            this.lblInOrderBy.Name = "lblInOrderBy";
            this.lblInOrderBy.Size = new System.Drawing.Size(89, 25);
            this.lblInOrderBy.TabIndex = 33;
            this.lblInOrderBy.Text = "โดย";
            this.lblInOrderBy.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbxInOrderBy
            // 
            this.cbxInOrderBy.AllowDrop = true;
            this.cbxInOrderBy.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.orderInBindingSource, "OrderBy", true));
            this.cbxInOrderBy.DataSource = this.usersViewBindingSource;
            this.cbxInOrderBy.DisplayMember = "Name";
            this.cbxInOrderBy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbxInOrderBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxInOrderBy.Enabled = false;
            this.cbxInOrderBy.FormattingEnabled = true;
            this.cbxInOrderBy.Location = new System.Drawing.Point(424, 41);
            this.cbxInOrderBy.Name = "cbxInOrderBy";
            this.cbxInOrderBy.Size = new System.Drawing.Size(184, 21);
            this.cbxInOrderBy.TabIndex = 34;
            this.cbxInOrderBy.ValueMember = "UserID";
            // 
            // btnInOrderDetail
            // 
            this.btnInOrderDetail.Location = new System.Drawing.Point(3, 184);
            this.btnInOrderDetail.Name = "btnInOrderDetail";
            this.btnInOrderDetail.Size = new System.Drawing.Size(120, 23);
            this.btnInOrderDetail.TabIndex = 1;
            this.btnInOrderDetail.Text = "รายละเอียดเพิ่มเติ่ม";
            this.btnInOrderDetail.UseVisualStyleBackColor = true;
            this.btnInOrderDetail.Click += new System.EventHandler(this.btnInOrderDetail_Click);
            // 
            // tabHealth
            // 
            this.tabHealth.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabHealth.Controls.Add(this.tableLayoutPanel1);
            this.tabHealth.Location = new System.Drawing.Point(4, 22);
            this.tabHealth.Name = "tabHealth";
            this.tabHealth.Padding = new System.Windows.Forms.Padding(3);
            this.tabHealth.Size = new System.Drawing.Size(668, 481);
            this.tabHealth.TabIndex = 1;
            this.tabHealth.Text = "ข้อมูลสุขภาพ";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.gbxVaccine, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.gbxMedicine, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(662, 475);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // gbxVaccine
            // 
            this.gbxVaccine.Controls.Add(this.pnlVaccineContent);
            this.gbxVaccine.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbxVaccine.Location = new System.Drawing.Point(3, 3);
            this.gbxVaccine.Name = "gbxVaccine";
            this.gbxVaccine.Size = new System.Drawing.Size(656, 231);
            this.gbxVaccine.TabIndex = 0;
            this.gbxVaccine.TabStop = false;
            this.gbxVaccine.Text = "ประวัติการฉีดวัคซีน";
            // 
            // pnlVaccineContent
            // 
            this.pnlVaccineContent.ColumnCount = 1;
            this.pnlVaccineContent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlVaccineContent.Controls.Add(this.pnlVaccineContentOption, 0, 1);
            this.pnlVaccineContent.Controls.Add(this.dgvVaccine, 0, 0);
            this.pnlVaccineContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlVaccineContent.Location = new System.Drawing.Point(3, 16);
            this.pnlVaccineContent.Name = "pnlVaccineContent";
            this.pnlVaccineContent.RowCount = 2;
            this.pnlVaccineContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlVaccineContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.pnlVaccineContent.Size = new System.Drawing.Size(650, 212);
            this.pnlVaccineContent.TabIndex = 0;
            // 
            // pnlVaccineContentOption
            // 
            this.pnlVaccineContentOption.Controls.Add(this.btnAddVaccineHistory);
            this.pnlVaccineContentOption.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlVaccineContentOption.Location = new System.Drawing.Point(0, 184);
            this.pnlVaccineContentOption.Margin = new System.Windows.Forms.Padding(0);
            this.pnlVaccineContentOption.Name = "pnlVaccineContentOption";
            this.pnlVaccineContentOption.Size = new System.Drawing.Size(650, 28);
            this.pnlVaccineContentOption.TabIndex = 7;
            // 
            // btnAddVaccineHistory
            // 
            this.btnAddVaccineHistory.Location = new System.Drawing.Point(3, 3);
            this.btnAddVaccineHistory.Name = "btnAddVaccineHistory";
            this.btnAddVaccineHistory.Size = new System.Drawing.Size(120, 23);
            this.btnAddVaccineHistory.TabIndex = 0;
            this.btnAddVaccineHistory.Text = "เพิ่มการฉีดวัคซีน";
            this.btnAddVaccineHistory.UseVisualStyleBackColor = true;
            this.btnAddVaccineHistory.Click += new System.EventHandler(this.btnAddVaccineHistory_Click);
            // 
            // dgvVaccine
            // 
            this.dgvVaccine.AllowUserToAddRows = false;
            this.dgvVaccine.AllowUserToDeleteRows = false;
            this.dgvVaccine.AutoGenerateColumns = false;
            this.dgvVaccine.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVaccine.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colVaccineID,
            this.colVaccineStockID,
            this.colVaccineUnit,
            this.colVaccineBy,
            this.colVaccineDate});
            this.dgvVaccine.DataSource = this.fKVaccineCow1BindingSource;
            this.dgvVaccine.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvVaccine.Location = new System.Drawing.Point(3, 3);
            this.dgvVaccine.Name = "dgvVaccine";
            this.dgvVaccine.ReadOnly = true;
            this.dgvVaccine.Size = new System.Drawing.Size(644, 178);
            this.dgvVaccine.TabIndex = 8;
            this.dgvVaccine.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvVaccine_CellMouseDoubleClick);
            // 
            // colVaccineID
            // 
            this.colVaccineID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colVaccineID.DataPropertyName = "VaccineID";
            this.colVaccineID.HeaderText = "#";
            this.colVaccineID.MinimumWidth = 50;
            this.colVaccineID.Name = "colVaccineID";
            this.colVaccineID.ReadOnly = true;
            this.colVaccineID.Width = 50;
            // 
            // colVaccineStockID
            // 
            this.colVaccineStockID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colVaccineStockID.DataPropertyName = "StockID";
            this.colVaccineStockID.DataSource = this.stockBindingSource;
            this.colVaccineStockID.DisplayMember = "Name";
            this.colVaccineStockID.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.colVaccineStockID.HeaderText = "ยา";
            this.colVaccineStockID.Name = "colVaccineStockID";
            this.colVaccineStockID.ReadOnly = true;
            this.colVaccineStockID.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colVaccineStockID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colVaccineStockID.ValueMember = "StockID";
            // 
            // stockBindingSource
            // 
            this.stockBindingSource.DataMember = "Stock";
            this.stockBindingSource.DataSource = this.farmManageDataSet;
            // 
            // colVaccineUnit
            // 
            this.colVaccineUnit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colVaccineUnit.DataPropertyName = "Unit";
            dataGridViewCellStyle1.Format = "N2";
            dataGridViewCellStyle1.NullValue = "0";
            this.colVaccineUnit.DefaultCellStyle = dataGridViewCellStyle1;
            this.colVaccineUnit.HeaderText = "จำนวน";
            this.colVaccineUnit.Name = "colVaccineUnit";
            this.colVaccineUnit.ReadOnly = true;
            // 
            // colVaccineBy
            // 
            this.colVaccineBy.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colVaccineBy.DataPropertyName = "VaccineBy";
            this.colVaccineBy.DataSource = this.usersViewBindingSource;
            this.colVaccineBy.DisplayMember = "Name";
            this.colVaccineBy.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.colVaccineBy.HeaderText = "โดย";
            this.colVaccineBy.Name = "colVaccineBy";
            this.colVaccineBy.ReadOnly = true;
            this.colVaccineBy.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colVaccineBy.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colVaccineBy.ValueMember = "UserID";
            // 
            // colVaccineDate
            // 
            this.colVaccineDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colVaccineDate.DataPropertyName = "Date";
            dataGridViewCellStyle2.Format = "D";
            dataGridViewCellStyle2.NullValue = null;
            this.colVaccineDate.DefaultCellStyle = dataGridViewCellStyle2;
            this.colVaccineDate.HeaderText = "วันที่";
            this.colVaccineDate.Name = "colVaccineDate";
            this.colVaccineDate.ReadOnly = true;
            // 
            // fKVaccineCow1BindingSource
            // 
            this.fKVaccineCow1BindingSource.DataMember = "FK_Vaccine_Cow1";
            this.fKVaccineCow1BindingSource.DataSource = this.cowBindingSource;
            // 
            // gbxMedicine
            // 
            this.gbxMedicine.Controls.Add(this.pnlMedicineContent);
            this.gbxMedicine.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbxMedicine.Location = new System.Drawing.Point(3, 240);
            this.gbxMedicine.Name = "gbxMedicine";
            this.gbxMedicine.Size = new System.Drawing.Size(656, 232);
            this.gbxMedicine.TabIndex = 1;
            this.gbxMedicine.TabStop = false;
            this.gbxMedicine.Text = "ประวัติการเป็นโรค";
            // 
            // pnlMedicineContent
            // 
            this.pnlMedicineContent.ColumnCount = 1;
            this.pnlMedicineContent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlMedicineContent.Controls.Add(this.pnlMedicineContentOption, 0, 1);
            this.pnlMedicineContent.Controls.Add(this.dgvMedicine, 0, 0);
            this.pnlMedicineContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMedicineContent.Location = new System.Drawing.Point(3, 16);
            this.pnlMedicineContent.Name = "pnlMedicineContent";
            this.pnlMedicineContent.RowCount = 2;
            this.pnlMedicineContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlMedicineContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.pnlMedicineContent.Size = new System.Drawing.Size(650, 213);
            this.pnlMedicineContent.TabIndex = 1;
            // 
            // pnlMedicineContentOption
            // 
            this.pnlMedicineContentOption.Controls.Add(this.btnAddMedicine);
            this.pnlMedicineContentOption.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMedicineContentOption.Location = new System.Drawing.Point(0, 185);
            this.pnlMedicineContentOption.Margin = new System.Windows.Forms.Padding(0);
            this.pnlMedicineContentOption.Name = "pnlMedicineContentOption";
            this.pnlMedicineContentOption.Size = new System.Drawing.Size(650, 28);
            this.pnlMedicineContentOption.TabIndex = 7;
            // 
            // btnAddMedicine
            // 
            this.btnAddMedicine.Location = new System.Drawing.Point(3, 3);
            this.btnAddMedicine.Name = "btnAddMedicine";
            this.btnAddMedicine.Size = new System.Drawing.Size(120, 23);
            this.btnAddMedicine.TabIndex = 0;
            this.btnAddMedicine.Text = "เพิ่มการรักษาโรค";
            this.btnAddMedicine.UseVisualStyleBackColor = true;
            this.btnAddMedicine.Click += new System.EventHandler(this.btnAddMedicine_Click);
            // 
            // dgvMedicine
            // 
            this.dgvMedicine.AllowUserToAddRows = false;
            this.dgvMedicine.AllowUserToDeleteRows = false;
            this.dgvMedicine.AutoGenerateColumns = false;
            this.dgvMedicine.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMedicine.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colDiseaseID,
            this.colDiseaseSymptom,
            this.colDiseaseTreament,
            this.diseaseHistoryByDataGridViewTextBoxColumn,
            this.colDiseaseDate});
            this.dgvMedicine.DataSource = this.fKDiseaseHistoryCow1BindingSource;
            this.dgvMedicine.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMedicine.Location = new System.Drawing.Point(3, 3);
            this.dgvMedicine.Name = "dgvMedicine";
            this.dgvMedicine.ReadOnly = true;
            this.dgvMedicine.Size = new System.Drawing.Size(644, 179);
            this.dgvMedicine.TabIndex = 8;
            this.dgvMedicine.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvMedicine_CellMouseDoubleClick);
            // 
            // colDiseaseID
            // 
            this.colDiseaseID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colDiseaseID.DataPropertyName = "DiseaseHistoryID";
            this.colDiseaseID.HeaderText = "#";
            this.colDiseaseID.MinimumWidth = 50;
            this.colDiseaseID.Name = "colDiseaseID";
            this.colDiseaseID.ReadOnly = true;
            this.colDiseaseID.Width = 50;
            // 
            // colDiseaseSymptom
            // 
            this.colDiseaseSymptom.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colDiseaseSymptom.DataPropertyName = "Symptom";
            this.colDiseaseSymptom.HeaderText = "อาการ";
            this.colDiseaseSymptom.Name = "colDiseaseSymptom";
            this.colDiseaseSymptom.ReadOnly = true;
            // 
            // colDiseaseTreament
            // 
            this.colDiseaseTreament.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colDiseaseTreament.DataPropertyName = "Treament";
            this.colDiseaseTreament.HeaderText = "การรักษา";
            this.colDiseaseTreament.Name = "colDiseaseTreament";
            this.colDiseaseTreament.ReadOnly = true;
            // 
            // diseaseHistoryByDataGridViewTextBoxColumn
            // 
            this.diseaseHistoryByDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.diseaseHistoryByDataGridViewTextBoxColumn.DataPropertyName = "DiseaseHistoryBy";
            this.diseaseHistoryByDataGridViewTextBoxColumn.DataSource = this.usersViewBindingSource;
            this.diseaseHistoryByDataGridViewTextBoxColumn.DisplayMember = "Name";
            this.diseaseHistoryByDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.diseaseHistoryByDataGridViewTextBoxColumn.HeaderText = "โดย";
            this.diseaseHistoryByDataGridViewTextBoxColumn.Name = "diseaseHistoryByDataGridViewTextBoxColumn";
            this.diseaseHistoryByDataGridViewTextBoxColumn.ReadOnly = true;
            this.diseaseHistoryByDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.diseaseHistoryByDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.diseaseHistoryByDataGridViewTextBoxColumn.ValueMember = "UserID";
            // 
            // colDiseaseDate
            // 
            this.colDiseaseDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colDiseaseDate.DataPropertyName = "Date";
            dataGridViewCellStyle3.Format = "D";
            dataGridViewCellStyle3.NullValue = null;
            this.colDiseaseDate.DefaultCellStyle = dataGridViewCellStyle3;
            this.colDiseaseDate.HeaderText = "วันที่";
            this.colDiseaseDate.Name = "colDiseaseDate";
            this.colDiseaseDate.ReadOnly = true;
            // 
            // fKDiseaseHistoryCow1BindingSource
            // 
            this.fKDiseaseHistoryCow1BindingSource.DataMember = "FK_Disease_History_Cow1";
            this.fKDiseaseHistoryCow1BindingSource.DataSource = this.cowBindingSource;
            // 
            // tabRecord
            // 
            this.tabRecord.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabRecord.Controls.Add(this.userLogUC);
            this.tabRecord.Location = new System.Drawing.Point(4, 22);
            this.tabRecord.Name = "tabRecord";
            this.tabRecord.Padding = new System.Windows.Forms.Padding(3);
            this.tabRecord.Size = new System.Drawing.Size(668, 481);
            this.tabRecord.TabIndex = 4;
            this.tabRecord.Text = "การบันทึก";
            // 
            // userLogUC
            // 
            this.userLogUC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userLogUC.Location = new System.Drawing.Point(3, 3);
            this.userLogUC.Name = "userLogUC";
            this.userLogUC.Size = new System.Drawing.Size(662, 475);
            this.userLogUC.TabIndex = 0;
            // 
            // cowTableAdapter
            // 
            this.cowTableAdapter.ClearBeforeFill = true;
            // 
            // orderInTableAdapter
            // 
            this.orderInTableAdapter.ClearBeforeFill = true;
            // 
            // orderOutTableAdapter
            // 
            this.orderOutTableAdapter.ClearBeforeFill = true;
            // 
            // vaccineTableAdapter
            // 
            this.vaccineTableAdapter.ClearBeforeFill = true;
            // 
            // diseaseHistoryTableAdapter
            // 
            this.diseaseHistoryTableAdapter.ClearBeforeFill = true;
            // 
            // geneTableAdapter
            // 
            this.geneTableAdapter.ClearBeforeFill = true;
            // 
            // corralTableAdapter
            // 
            this.corralTableAdapter.ClearBeforeFill = true;
            // 
            // usersViewTableAdapter
            // 
            this.usersViewTableAdapter.ClearBeforeFill = true;
            // 
            // stockTableAdapter
            // 
            this.stockTableAdapter.ClearBeforeFill = true;
            // 
            // CowDetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.ClientSize = new System.Drawing.Size(684, 617);
            this.Controls.Add(this.pnlMain);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CowDetailForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ข้อมูลโค";
            this.Load += new System.EventHandler(this.CowDetailForm_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.footerFlowLayoutPanel.ResumeLayout(false);
            this.tcMain.ResumeLayout(false);
            this.tabGeneral.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.pnlGeneral.ResumeLayout(false);
            this.pnlGeneral.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cowBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.farmManageDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.geneBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.corralBindingSource)).EndInit();
            this.tabTranfer.ResumeLayout(false);
            this.pnlInOutOrder.ResumeLayout(false);
            this.gbxOutOrder.ResumeLayout(false);
            this.pnlOutOrderContent.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderOutBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersViewBindingSource)).EndInit();
            this.gbxInOrder.ResumeLayout(false);
            this.pnlInOrderContent.ResumeLayout(false);
            this.pnlOrderIn.ResumeLayout(false);
            this.pnlOrderIn.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderInBindingSource)).EndInit();
            this.tabHealth.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.gbxVaccine.ResumeLayout(false);
            this.pnlVaccineContent.ResumeLayout(false);
            this.pnlVaccineContentOption.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVaccine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKVaccineCow1BindingSource)).EndInit();
            this.gbxMedicine.ResumeLayout(false);
            this.pnlMedicineContent.ResumeLayout(false);
            this.pnlMedicineContentOption.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKDiseaseHistoryCow1BindingSource)).EndInit();
            this.tabRecord.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel pnlMain;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.FlowLayoutPanel footerFlowLayoutPanel;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TabControl tcMain;
        private System.Windows.Forms.TabPage tabGeneral;
        private System.Windows.Forms.TabPage tabHealth;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox gbxVaccine;
        private System.Windows.Forms.GroupBox gbxMedicine;
        private System.Windows.Forms.TableLayoutPanel pnlVaccineContent;
        private System.Windows.Forms.TableLayoutPanel pnlMedicineContent;
        private System.Windows.Forms.FlowLayoutPanel pnlVaccineContentOption;
        private System.Windows.Forms.Button btnAddVaccineHistory;
        private System.Windows.Forms.FlowLayoutPanel pnlMedicineContentOption;
        private System.Windows.Forms.Button btnAddMedicine;
        private System.Windows.Forms.DataGridView dgvVaccine;
        private System.Windows.Forms.DataGridView dgvMedicine;
        private System.Windows.Forms.TabPage tabTranfer;
        private System.Windows.Forms.TableLayoutPanel pnlInOutOrder;
        private System.Windows.Forms.GroupBox gbxOutOrder;
        private System.Windows.Forms.GroupBox gbxInOrder;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TableLayoutPanel pnlGeneral;
        private System.Windows.Forms.Label lblGene;
        private System.Windows.Forms.Label lblSex;
        private System.Windows.Forms.Label lblCorral;
        private System.Windows.Forms.ComboBox cbxGene;
        private System.Windows.Forms.TextBox tbxCor;
        private System.Windows.Forms.ComboBox cbxSex;
        private System.Windows.Forms.Label lblCor;
        private System.Windows.Forms.ComboBox cbxCorral;
        private System.Windows.Forms.TableLayoutPanel pnlInOrderContent;
        private System.Windows.Forms.TableLayoutPanel pnlOutOrderContent;
        private System.Windows.Forms.Label lblNO;
        private System.Windows.Forms.Button btnInOrderDetail;
        private System.Windows.Forms.Button btnOutOrderDetail;
        private System.Windows.Forms.TabPage tabRecord;
        private System.Windows.Forms.TableLayoutPanel pnlOrderIn;
        private System.Windows.Forms.ComboBox cbxInTransportType;
        private System.Windows.Forms.Label lblInTransportCost;
        private System.Windows.Forms.Label lblInTransportType;
        private System.Windows.Forms.Label lblInTransportNO;
        private System.Windows.Forms.Label lblInTransportIssueBy;
        private System.Windows.Forms.TextBox tbxInTransportNO;
        private System.Windows.Forms.TextBox tbxInTransportIssueBy;
        private System.Windows.Forms.Label lblInAmount;
        private System.Windows.Forms.TextBox tbxInAmount;
        private System.Windows.Forms.TextBox tbxInTransportCost;
        private System.Windows.Forms.Label lblInNote;
        private System.Windows.Forms.TextBox tbxInNote;
        private System.Windows.Forms.DateTimePicker dtpInOrderDate;
        private System.Windows.Forms.Label lblInOrderDate;
        private System.Windows.Forms.Label lblOrderInType;
        private System.Windows.Forms.ComboBox cbxOrderInType;
        private System.Windows.Forms.Label lblInOrderBy;
        private System.Windows.Forms.ComboBox cbxInOrderBy;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.ComboBox cbxOutTransportType;
        private System.Windows.Forms.Label lblTransportCost;
        private System.Windows.Forms.Label lblTransportType;
        private System.Windows.Forms.Label lblTransportNO;
        private System.Windows.Forms.Label lblTransportIssueBy;
        private System.Windows.Forms.TextBox tbxOutTransportNO;
        private System.Windows.Forms.TextBox tbxOutTransportIssueBy;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.TextBox tbxOutAmount;
        private System.Windows.Forms.TextBox tbxOutTransportCost;
        private System.Windows.Forms.Label lblNote;
        private System.Windows.Forms.TextBox tbxOutNote;
        private System.Windows.Forms.DateTimePicker dtpOutDate;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblOrderType;
        private System.Windows.Forms.ComboBox cbxOutOrderType;
        private System.Windows.Forms.Label lblCreateBy;
        private System.Windows.Forms.ComboBox cbxOutSaveBy;
        private Database.FarmManageDataSet farmManageDataSet;
        private System.Windows.Forms.BindingSource cowBindingSource;
        private Database.FarmManageDataSetTableAdapters.CowTableAdapter cowTableAdapter;
        private System.Windows.Forms.BindingSource orderInBindingSource;
        private Database.FarmManageDataSetTableAdapters.OrderInTableAdapter orderInTableAdapter;
        private System.Windows.Forms.BindingSource orderOutBindingSource;
        private Database.FarmManageDataSetTableAdapters.OrderOutTableAdapter orderOutTableAdapter;
        private System.Windows.Forms.BindingSource fKVaccineCow1BindingSource;
        private Database.FarmManageDataSetTableAdapters.VaccineTableAdapter vaccineTableAdapter;
        private System.Windows.Forms.BindingSource fKDiseaseHistoryCow1BindingSource;
        private Database.FarmManageDataSetTableAdapters.DiseaseHistoryTableAdapter diseaseHistoryTableAdapter;
        private System.Windows.Forms.BindingSource geneBindingSource;
        private Database.FarmManageDataSetTableAdapters.GeneTableAdapter geneTableAdapter;
        private System.Windows.Forms.BindingSource corralBindingSource;
        private Database.FarmManageDataSetTableAdapters.CorralTableAdapter corralTableAdapter;
        private Database.FarmManageDataSetTableAdapters.UsersViewTableAdapter usersViewTableAdapter;
        private System.Windows.Forms.BindingSource stockBindingSource;
        private Database.FarmManageDataSetTableAdapters.StockTableAdapter stockTableAdapter;
        private System.Windows.Forms.Label lblCowNO;
        private System.Windows.Forms.BindingSource usersViewBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDiseaseID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDiseaseSymptom;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDiseaseTreament;
        private System.Windows.Forms.DataGridViewComboBoxColumn diseaseHistoryByDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDiseaseDate;
        private Control.UserLogUC userLogUC;
        private System.Windows.Forms.DataGridViewTextBoxColumn colVaccineID;
        private System.Windows.Forms.DataGridViewComboBoxColumn colVaccineStockID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colVaccineUnit;
        private System.Windows.Forms.DataGridViewComboBoxColumn colVaccineBy;
        private System.Windows.Forms.DataGridViewTextBoxColumn colVaccineDate;
    }
}
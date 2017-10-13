namespace MainProject.UserInterface.Cow
{
    partial class AddDiseaseHistoryForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlMain = new System.Windows.Forms.TableLayoutPanel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlFooter = new System.Windows.Forms.FlowLayoutPanel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.tcMain = new System.Windows.Forms.TabControl();
            this.tabDetail = new System.Windows.Forms.TabPage();
            this.pnlGeneralContent = new System.Windows.Forms.TableLayoutPanel();
            this.gbxDetail = new System.Windows.Forms.GroupBox();
            this.pnlGeneralContentP = new System.Windows.Forms.TableLayoutPanel();
            this.lblTreatment = new System.Windows.Forms.Label();
            this.lblSymptom = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.tbxSymptom = new System.Windows.Forms.TextBox();
            this.diseaseHistoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.farmManageDataSet = new MainProject.Database.FarmManageDataSet();
            this.tbxTreatment = new System.Windows.Forms.TextBox();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.lblBy = new System.Windows.Forms.Label();
            this.cbxBy = new System.Windows.Forms.ComboBox();
            this.usersViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tcSecond = new System.Windows.Forms.TabControl();
            this.tabHistory = new System.Windows.Forms.TabPage();
            this.gbxList = new System.Windows.Forms.GroupBox();
            this.dgvHistoryList = new System.Windows.Forms.DataGridView();
            this.diseaseMedicineIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diseaseHistoryIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.stockBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.unitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diseaseMedicineByDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.fKdiseasemedicinediseasehistoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabNew = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pnlAddContent = new System.Windows.Forms.TableLayoutPanel();
            this.dgvAdd = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StockID = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ByID = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.pnlAddOptionContent = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnRemoveAll = new System.Windows.Forms.Button();
            this.tabRecord = new System.Windows.Forms.TabPage();
            this.userLogUC = new MainProject.UserInterface.Control.UserLogUC();
            this.usersViewBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.userLogBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usersViewBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.diseaseHistoryTableAdapter = new MainProject.Database.FarmManageDataSetTableAdapters.DiseaseHistoryTableAdapter();
            this.diseaseMedicineTableAdapter = new MainProject.Database.FarmManageDataSetTableAdapters.DiseaseMedicineTableAdapter();
            this.stockTableAdapter = new MainProject.Database.FarmManageDataSetTableAdapters.StockTableAdapter();
            this.usersViewTableAdapter = new MainProject.Database.FarmManageDataSetTableAdapters.UsersViewTableAdapter();
            this.userLogTableAdapter = new MainProject.Database.FarmManageDataSetTableAdapters.UserLogTableAdapter();
            this.pnlMain.SuspendLayout();
            this.pnlFooter.SuspendLayout();
            this.tcMain.SuspendLayout();
            this.tabDetail.SuspendLayout();
            this.pnlGeneralContent.SuspendLayout();
            this.gbxDetail.SuspendLayout();
            this.pnlGeneralContentP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.diseaseHistoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.farmManageDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersViewBindingSource)).BeginInit();
            this.tcSecond.SuspendLayout();
            this.tabHistory.SuspendLayout();
            this.gbxList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistoryList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKdiseasemedicinediseasehistoryBindingSource)).BeginInit();
            this.tabNew.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.pnlAddContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdd)).BeginInit();
            this.pnlAddOptionContent.SuspendLayout();
            this.tabRecord.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usersViewBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userLogBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersViewBindingSource1)).BeginInit();
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
            this.pnlMain.Controls.Add(this.tcMain, 0, 1);
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
            this.lblTitle.Text = "ประวัติการเป็นโรค";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlFooter
            // 
            this.pnlFooter.Controls.Add(this.btnCancel);
            this.pnlFooter.Controls.Add(this.btnSave);
            this.pnlFooter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFooter.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.pnlFooter.Location = new System.Drawing.Point(4, 483);
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.Padding = new System.Windows.Forms.Padding(3);
            this.pnlFooter.Size = new System.Drawing.Size(586, 34);
            this.pnlFooter.TabIndex = 1;
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
            // tcMain
            // 
            this.tcMain.Controls.Add(this.tabDetail);
            this.tcMain.Controls.Add(this.tabRecord);
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
            this.tabDetail.Controls.Add(this.pnlGeneralContent);
            this.tabDetail.Location = new System.Drawing.Point(4, 22);
            this.tabDetail.Name = "tabDetail";
            this.tabDetail.Padding = new System.Windows.Forms.Padding(3);
            this.tabDetail.Size = new System.Drawing.Size(578, 385);
            this.tabDetail.TabIndex = 0;
            this.tabDetail.Text = "รายละเอียด";
            // 
            // pnlGeneralContent
            // 
            this.pnlGeneralContent.ColumnCount = 1;
            this.pnlGeneralContent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlGeneralContent.Controls.Add(this.gbxDetail, 0, 0);
            this.pnlGeneralContent.Controls.Add(this.tcSecond, 0, 1);
            this.pnlGeneralContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGeneralContent.Location = new System.Drawing.Point(3, 3);
            this.pnlGeneralContent.Name = "pnlGeneralContent";
            this.pnlGeneralContent.RowCount = 2;
            this.pnlGeneralContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 124F));
            this.pnlGeneralContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlGeneralContent.Size = new System.Drawing.Size(572, 379);
            this.pnlGeneralContent.TabIndex = 0;
            // 
            // gbxDetail
            // 
            this.gbxDetail.Controls.Add(this.pnlGeneralContentP);
            this.gbxDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbxDetail.Location = new System.Drawing.Point(3, 3);
            this.gbxDetail.Name = "gbxDetail";
            this.gbxDetail.Size = new System.Drawing.Size(566, 118);
            this.gbxDetail.TabIndex = 0;
            this.gbxDetail.TabStop = false;
            this.gbxDetail.Text = "รายละเอียด";
            // 
            // pnlGeneralContentP
            // 
            this.pnlGeneralContentP.ColumnCount = 7;
            this.pnlGeneralContentP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.pnlGeneralContentP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.pnlGeneralContentP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.pnlGeneralContentP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.pnlGeneralContentP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.pnlGeneralContentP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.pnlGeneralContentP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.pnlGeneralContentP.Controls.Add(this.lblTreatment, 4, 1);
            this.pnlGeneralContentP.Controls.Add(this.lblSymptom, 1, 1);
            this.pnlGeneralContentP.Controls.Add(this.lblDate, 1, 3);
            this.pnlGeneralContentP.Controls.Add(this.tbxSymptom, 2, 1);
            this.pnlGeneralContentP.Controls.Add(this.tbxTreatment, 5, 1);
            this.pnlGeneralContentP.Controls.Add(this.dtpDate, 2, 3);
            this.pnlGeneralContentP.Controls.Add(this.lblBy, 1, 5);
            this.pnlGeneralContentP.Controls.Add(this.cbxBy, 2, 5);
            this.pnlGeneralContentP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGeneralContentP.Location = new System.Drawing.Point(3, 16);
            this.pnlGeneralContentP.Name = "pnlGeneralContentP";
            this.pnlGeneralContentP.RowCount = 7;
            this.pnlGeneralContentP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.pnlGeneralContentP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.pnlGeneralContentP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 3F));
            this.pnlGeneralContentP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.pnlGeneralContentP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 3F));
            this.pnlGeneralContentP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.pnlGeneralContentP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 3F));
            this.pnlGeneralContentP.Size = new System.Drawing.Size(560, 99);
            this.pnlGeneralContentP.TabIndex = 0;
            // 
            // lblTreatment
            // 
            this.lblTreatment.AutoSize = true;
            this.lblTreatment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTreatment.Location = new System.Drawing.Point(287, 10);
            this.lblTreatment.Name = "lblTreatment";
            this.pnlGeneralContentP.SetRowSpan(this.lblTreatment, 5);
            this.lblTreatment.Size = new System.Drawing.Size(76, 81);
            this.lblTreatment.TabIndex = 1;
            this.lblTreatment.Text = "การรักษา";
            this.lblTreatment.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSymptom
            // 
            this.lblSymptom.AutoSize = true;
            this.lblSymptom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSymptom.Location = new System.Drawing.Point(30, 10);
            this.lblSymptom.Name = "lblSymptom";
            this.lblSymptom.Size = new System.Drawing.Size(76, 25);
            this.lblSymptom.TabIndex = 0;
            this.lblSymptom.Text = "ชื่อโรค *";
            this.lblSymptom.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDate.Location = new System.Drawing.Point(30, 38);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(76, 25);
            this.lblDate.TabIndex = 2;
            this.lblDate.Text = "วันที่ *";
            this.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbxSymptom
            // 
            this.tbxSymptom.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.diseaseHistoryBindingSource, "Symptom", true));
            this.tbxSymptom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxSymptom.Location = new System.Drawing.Point(112, 13);
            this.tbxSymptom.MaxLength = 512;
            this.tbxSymptom.Name = "tbxSymptom";
            this.tbxSymptom.Size = new System.Drawing.Size(159, 20);
            this.tbxSymptom.TabIndex = 3;
            this.tbxSymptom.Validating += new System.ComponentModel.CancelEventHandler(this.tbxSymptom_Validating);
            // 
            // diseaseHistoryBindingSource
            // 
            this.diseaseHistoryBindingSource.DataMember = "DiseaseHistory";
            this.diseaseHistoryBindingSource.DataSource = this.farmManageDataSet;
            // 
            // farmManageDataSet
            // 
            this.farmManageDataSet.DataSetName = "FarmManageDataSet";
            this.farmManageDataSet.Locale = new System.Globalization.CultureInfo("en");
            this.farmManageDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbxTreatment
            // 
            this.tbxTreatment.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.diseaseHistoryBindingSource, "Treament", true));
            this.tbxTreatment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxTreatment.Location = new System.Drawing.Point(369, 13);
            this.tbxTreatment.Multiline = true;
            this.tbxTreatment.Name = "tbxTreatment";
            this.pnlGeneralContentP.SetRowSpan(this.tbxTreatment, 5);
            this.tbxTreatment.Size = new System.Drawing.Size(159, 75);
            this.tbxTreatment.TabIndex = 4;
            // 
            // dtpDate
            // 
            this.dtpDate.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.diseaseHistoryBindingSource, "Date", true));
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.Location = new System.Drawing.Point(112, 41);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(156, 20);
            this.dtpDate.TabIndex = 5;
            // 
            // lblBy
            // 
            this.lblBy.AutoSize = true;
            this.lblBy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblBy.Location = new System.Drawing.Point(30, 66);
            this.lblBy.Name = "lblBy";
            this.lblBy.Size = new System.Drawing.Size(76, 25);
            this.lblBy.TabIndex = 6;
            this.lblBy.Text = "โดย *";
            this.lblBy.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbxBy
            // 
            this.cbxBy.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.diseaseHistoryBindingSource, "DiseaseHistoryBy", true));
            this.cbxBy.DataSource = this.usersViewBindingSource;
            this.cbxBy.DisplayMember = "Name";
            this.cbxBy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbxBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxBy.FormattingEnabled = true;
            this.cbxBy.Location = new System.Drawing.Point(112, 69);
            this.cbxBy.Name = "cbxBy";
            this.cbxBy.Size = new System.Drawing.Size(159, 21);
            this.cbxBy.TabIndex = 7;
            this.cbxBy.ValueMember = "UserID";
            this.cbxBy.Validating += new System.ComponentModel.CancelEventHandler(this.cbxBy_Validating);
            // 
            // usersViewBindingSource
            // 
            this.usersViewBindingSource.DataMember = "UsersView";
            this.usersViewBindingSource.DataSource = this.farmManageDataSet;
            // 
            // tcSecond
            // 
            this.tcSecond.Controls.Add(this.tabHistory);
            this.tcSecond.Controls.Add(this.tabNew);
            this.tcSecond.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcSecond.Location = new System.Drawing.Point(3, 127);
            this.tcSecond.Name = "tcSecond";
            this.tcSecond.SelectedIndex = 0;
            this.tcSecond.Size = new System.Drawing.Size(566, 249);
            this.tcSecond.TabIndex = 1;
            // 
            // tabHistory
            // 
            this.tabHistory.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabHistory.Controls.Add(this.gbxList);
            this.tabHistory.Location = new System.Drawing.Point(4, 22);
            this.tabHistory.Name = "tabHistory";
            this.tabHistory.Padding = new System.Windows.Forms.Padding(3);
            this.tabHistory.Size = new System.Drawing.Size(558, 223);
            this.tabHistory.TabIndex = 0;
            this.tabHistory.Text = "ประวัติการใช้ยา";
            // 
            // gbxList
            // 
            this.gbxList.Controls.Add(this.dgvHistoryList);
            this.gbxList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbxList.Location = new System.Drawing.Point(3, 3);
            this.gbxList.Name = "gbxList";
            this.gbxList.Size = new System.Drawing.Size(552, 217);
            this.gbxList.TabIndex = 2;
            this.gbxList.TabStop = false;
            this.gbxList.Text = "การประวัติการใช้ยา";
            // 
            // dgvHistoryList
            // 
            this.dgvHistoryList.AllowUserToAddRows = false;
            this.dgvHistoryList.AllowUserToDeleteRows = false;
            this.dgvHistoryList.AutoGenerateColumns = false;
            this.dgvHistoryList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHistoryList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.diseaseMedicineIDDataGridViewTextBoxColumn,
            this.diseaseHistoryIDDataGridViewTextBoxColumn,
            this.stockIDDataGridViewTextBoxColumn,
            this.unitDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.diseaseMedicineByDataGridViewTextBoxColumn});
            this.dgvHistoryList.DataSource = this.fKdiseasemedicinediseasehistoryBindingSource;
            this.dgvHistoryList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvHistoryList.Location = new System.Drawing.Point(3, 16);
            this.dgvHistoryList.Name = "dgvHistoryList";
            this.dgvHistoryList.ReadOnly = true;
            this.dgvHistoryList.Size = new System.Drawing.Size(546, 198);
            this.dgvHistoryList.TabIndex = 1;
            // 
            // diseaseMedicineIDDataGridViewTextBoxColumn
            // 
            this.diseaseMedicineIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.diseaseMedicineIDDataGridViewTextBoxColumn.DataPropertyName = "DiseaseMedicineID";
            this.diseaseMedicineIDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.diseaseMedicineIDDataGridViewTextBoxColumn.MinimumWidth = 50;
            this.diseaseMedicineIDDataGridViewTextBoxColumn.Name = "diseaseMedicineIDDataGridViewTextBoxColumn";
            this.diseaseMedicineIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.diseaseMedicineIDDataGridViewTextBoxColumn.Width = 50;
            // 
            // diseaseHistoryIDDataGridViewTextBoxColumn
            // 
            this.diseaseHistoryIDDataGridViewTextBoxColumn.DataPropertyName = "DiseaseHistoryID";
            this.diseaseHistoryIDDataGridViewTextBoxColumn.HeaderText = "DiseaseHistoryID";
            this.diseaseHistoryIDDataGridViewTextBoxColumn.Name = "diseaseHistoryIDDataGridViewTextBoxColumn";
            this.diseaseHistoryIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.diseaseHistoryIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // stockIDDataGridViewTextBoxColumn
            // 
            this.stockIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.stockIDDataGridViewTextBoxColumn.DataPropertyName = "StockID";
            this.stockIDDataGridViewTextBoxColumn.DataSource = this.stockBindingSource;
            this.stockIDDataGridViewTextBoxColumn.DisplayMember = "Name";
            this.stockIDDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.stockIDDataGridViewTextBoxColumn.HeaderText = "ชื่อยา";
            this.stockIDDataGridViewTextBoxColumn.Name = "stockIDDataGridViewTextBoxColumn";
            this.stockIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.stockIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.stockIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.stockIDDataGridViewTextBoxColumn.ValueMember = "StockID";
            // 
            // stockBindingSource
            // 
            this.stockBindingSource.DataMember = "Stock";
            this.stockBindingSource.DataSource = this.farmManageDataSet;
            // 
            // unitDataGridViewTextBoxColumn
            // 
            this.unitDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.unitDataGridViewTextBoxColumn.DataPropertyName = "Unit";
            dataGridViewCellStyle1.Format = "N2";
            dataGridViewCellStyle1.NullValue = "0";
            this.unitDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.unitDataGridViewTextBoxColumn.HeaderText = "หน่วย";
            this.unitDataGridViewTextBoxColumn.Name = "unitDataGridViewTextBoxColumn";
            this.unitDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            dataGridViewCellStyle2.Format = "D";
            dataGridViewCellStyle2.NullValue = null;
            this.dateDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.dateDataGridViewTextBoxColumn.HeaderText = "วันที่";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // diseaseMedicineByDataGridViewTextBoxColumn
            // 
            this.diseaseMedicineByDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.diseaseMedicineByDataGridViewTextBoxColumn.DataPropertyName = "DiseaseMedicineBy";
            this.diseaseMedicineByDataGridViewTextBoxColumn.DataSource = this.usersViewBindingSource;
            this.diseaseMedicineByDataGridViewTextBoxColumn.DisplayMember = "Name";
            this.diseaseMedicineByDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.diseaseMedicineByDataGridViewTextBoxColumn.HeaderText = "โดย";
            this.diseaseMedicineByDataGridViewTextBoxColumn.Name = "diseaseMedicineByDataGridViewTextBoxColumn";
            this.diseaseMedicineByDataGridViewTextBoxColumn.ReadOnly = true;
            this.diseaseMedicineByDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.diseaseMedicineByDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.diseaseMedicineByDataGridViewTextBoxColumn.ValueMember = "UserID";
            // 
            // fKdiseasemedicinediseasehistoryBindingSource
            // 
            this.fKdiseasemedicinediseasehistoryBindingSource.DataMember = "FK_disease_medicine_disease_history";
            this.fKdiseasemedicinediseasehistoryBindingSource.DataSource = this.diseaseHistoryBindingSource;
            // 
            // tabNew
            // 
            this.tabNew.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabNew.Controls.Add(this.groupBox1);
            this.tabNew.Location = new System.Drawing.Point(4, 22);
            this.tabNew.Name = "tabNew";
            this.tabNew.Padding = new System.Windows.Forms.Padding(3);
            this.tabNew.Size = new System.Drawing.Size(558, 223);
            this.tabNew.TabIndex = 1;
            this.tabNew.Text = "เพิ่มการใช้ยาใหม่";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pnlAddContent);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(552, 217);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "การใช้ยาใหม่";
            // 
            // pnlAddContent
            // 
            this.pnlAddContent.ColumnCount = 1;
            this.pnlAddContent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlAddContent.Controls.Add(this.dgvAdd, 0, 0);
            this.pnlAddContent.Controls.Add(this.pnlAddOptionContent, 0, 1);
            this.pnlAddContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlAddContent.Location = new System.Drawing.Point(3, 16);
            this.pnlAddContent.Name = "pnlAddContent";
            this.pnlAddContent.RowCount = 2;
            this.pnlAddContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlAddContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.pnlAddContent.Size = new System.Drawing.Size(546, 198);
            this.pnlAddContent.TabIndex = 0;
            // 
            // dgvAdd
            // 
            this.dgvAdd.AllowUserToAddRows = false;
            this.dgvAdd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAdd.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.StockID,
            this.Date,
            this.Unit,
            this.ByID});
            this.dgvAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAdd.Location = new System.Drawing.Point(3, 3);
            this.dgvAdd.Name = "dgvAdd";
            this.dgvAdd.ReadOnly = true;
            this.dgvAdd.Size = new System.Drawing.Size(540, 164);
            this.dgvAdd.TabIndex = 0;
            this.dgvAdd.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgvAdd_RowsAdded);
            this.dgvAdd.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dgvAdd_RowsRemoved);
            this.dgvAdd.SelectionChanged += new System.EventHandler(this.dgvAdd_SelectionChanged);
            // 
            // ID
            // 
            this.ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 50;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 50;
            // 
            // StockID
            // 
            this.StockID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.StockID.DataSource = this.stockBindingSource;
            this.StockID.DisplayMember = "Name";
            this.StockID.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.StockID.HeaderText = "ยา";
            this.StockID.Name = "StockID";
            this.StockID.ReadOnly = true;
            this.StockID.ValueMember = "StockID";
            // 
            // Date
            // 
            this.Date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle3.Format = "D";
            dataGridViewCellStyle3.NullValue = null;
            this.Date.DefaultCellStyle = dataGridViewCellStyle3;
            this.Date.HeaderText = "วันที่";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            // 
            // Unit
            // 
            this.Unit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle4.Format = "N2";
            dataGridViewCellStyle4.NullValue = "0";
            this.Unit.DefaultCellStyle = dataGridViewCellStyle4;
            this.Unit.HeaderText = "จำนวน";
            this.Unit.Name = "Unit";
            this.Unit.ReadOnly = true;
            // 
            // ByID
            // 
            this.ByID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ByID.DataSource = this.usersViewBindingSource;
            this.ByID.DisplayMember = "Name";
            this.ByID.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.ByID.HeaderText = "โดย";
            this.ByID.Name = "ByID";
            this.ByID.ReadOnly = true;
            this.ByID.ValueMember = "UserID";
            // 
            // pnlAddOptionContent
            // 
            this.pnlAddOptionContent.Controls.Add(this.btnAdd);
            this.pnlAddOptionContent.Controls.Add(this.btnRemove);
            this.pnlAddOptionContent.Controls.Add(this.btnRemoveAll);
            this.pnlAddOptionContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlAddOptionContent.Location = new System.Drawing.Point(0, 170);
            this.pnlAddOptionContent.Margin = new System.Windows.Forms.Padding(0);
            this.pnlAddOptionContent.Name = "pnlAddOptionContent";
            this.pnlAddOptionContent.Size = new System.Drawing.Size(546, 28);
            this.pnlAddOptionContent.TabIndex = 1;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(3, 3);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "เพิ่ม";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Enabled = false;
            this.btnRemove.Location = new System.Drawing.Point(84, 3);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 23);
            this.btnRemove.TabIndex = 1;
            this.btnRemove.Text = "ลบที่เลือก";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnRemoveAll
            // 
            this.btnRemoveAll.Enabled = false;
            this.btnRemoveAll.Location = new System.Drawing.Point(165, 3);
            this.btnRemoveAll.Name = "btnRemoveAll";
            this.btnRemoveAll.Size = new System.Drawing.Size(75, 23);
            this.btnRemoveAll.TabIndex = 2;
            this.btnRemoveAll.Text = "ลบทั้งหมด";
            this.btnRemoveAll.UseVisualStyleBackColor = true;
            this.btnRemoveAll.Click += new System.EventHandler(this.btnRemoveAll_Click);
            // 
            // tabRecord
            // 
            this.tabRecord.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabRecord.Controls.Add(this.userLogUC);
            this.tabRecord.Location = new System.Drawing.Point(4, 22);
            this.tabRecord.Name = "tabRecord";
            this.tabRecord.Padding = new System.Windows.Forms.Padding(3);
            this.tabRecord.Size = new System.Drawing.Size(578, 385);
            this.tabRecord.TabIndex = 1;
            this.tabRecord.Text = "การบันทึก";
            // 
            // userLogUC
            // 
            this.userLogUC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userLogUC.Location = new System.Drawing.Point(3, 3);
            this.userLogUC.Name = "userLogUC";
            this.userLogUC.Size = new System.Drawing.Size(572, 379);
            this.userLogUC.TabIndex = 0;
            // 
            // usersViewBindingSource2
            // 
            this.usersViewBindingSource2.DataMember = "UsersView";
            this.usersViewBindingSource2.DataSource = this.farmManageDataSet;
            // 
            // userLogBindingSource
            // 
            this.userLogBindingSource.DataMember = "UserLog";
            this.userLogBindingSource.DataSource = this.farmManageDataSet;
            // 
            // usersViewBindingSource1
            // 
            this.usersViewBindingSource1.DataMember = "UsersView";
            this.usersViewBindingSource1.DataSource = this.farmManageDataSet;
            // 
            // diseaseHistoryTableAdapter
            // 
            this.diseaseHistoryTableAdapter.ClearBeforeFill = true;
            // 
            // diseaseMedicineTableAdapter
            // 
            this.diseaseMedicineTableAdapter.ClearBeforeFill = true;
            // 
            // stockTableAdapter
            // 
            this.stockTableAdapter.ClearBeforeFill = true;
            // 
            // usersViewTableAdapter
            // 
            this.usersViewTableAdapter.ClearBeforeFill = true;
            // 
            // userLogTableAdapter
            // 
            this.userLogTableAdapter.ClearBeforeFill = true;
            // 
            // AddDiseaseHistoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.ClientSize = new System.Drawing.Size(594, 521);
            this.Controls.Add(this.pnlMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddDiseaseHistoryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ประวัติการเป็นโรค";
            this.Load += new System.EventHandler(this.DiseaseHistoryForm_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.pnlFooter.ResumeLayout(false);
            this.tcMain.ResumeLayout(false);
            this.tabDetail.ResumeLayout(false);
            this.pnlGeneralContent.ResumeLayout(false);
            this.gbxDetail.ResumeLayout(false);
            this.pnlGeneralContentP.ResumeLayout(false);
            this.pnlGeneralContentP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.diseaseHistoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.farmManageDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersViewBindingSource)).EndInit();
            this.tcSecond.ResumeLayout(false);
            this.tabHistory.ResumeLayout(false);
            this.gbxList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistoryList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKdiseasemedicinediseasehistoryBindingSource)).EndInit();
            this.tabNew.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.pnlAddContent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdd)).EndInit();
            this.pnlAddOptionContent.ResumeLayout(false);
            this.tabRecord.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.usersViewBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userLogBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersViewBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel pnlMain;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.FlowLayoutPanel pnlFooter;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TabControl tcMain;
        private System.Windows.Forms.TabPage tabDetail;
        private System.Windows.Forms.TabPage tabRecord;
        private System.Windows.Forms.TableLayoutPanel pnlGeneralContent;
        private System.Windows.Forms.GroupBox gbxDetail;
        private System.Windows.Forms.TableLayoutPanel pnlGeneralContentP;
        private System.Windows.Forms.Label lblTreatment;
        private System.Windows.Forms.Label lblSymptom;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.TextBox tbxSymptom;
        private System.Windows.Forms.TextBox tbxTreatment;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.TabControl tcSecond;
        private System.Windows.Forms.TabPage tabHistory;
        private System.Windows.Forms.GroupBox gbxList;
        private System.Windows.Forms.DataGridView dgvHistoryList;
        private System.Windows.Forms.TabPage tabNew;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel pnlAddContent;
        private System.Windows.Forms.DataGridView dgvAdd;
        private System.Windows.Forms.FlowLayoutPanel pnlAddOptionContent;
        private System.Windows.Forms.Button btnAdd;
        private Database.FarmManageDataSet farmManageDataSet;
        private System.Windows.Forms.BindingSource diseaseHistoryBindingSource;
        private Database.FarmManageDataSetTableAdapters.DiseaseHistoryTableAdapter diseaseHistoryTableAdapter;
        private System.Windows.Forms.BindingSource fKdiseasemedicinediseasehistoryBindingSource;
        private Database.FarmManageDataSetTableAdapters.DiseaseMedicineTableAdapter diseaseMedicineTableAdapter;
        private System.Windows.Forms.BindingSource stockBindingSource;
        private Database.FarmManageDataSetTableAdapters.StockTableAdapter stockTableAdapter;
        private System.Windows.Forms.BindingSource usersViewBindingSource;
        private Database.FarmManageDataSetTableAdapters.UsersViewTableAdapter usersViewTableAdapter;
        private System.Windows.Forms.Label lblBy;
        private System.Windows.Forms.ComboBox cbxBy;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnRemoveAll;
        private System.Windows.Forms.BindingSource usersViewBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn diseaseMedicineIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diseaseHistoryIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn stockIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn diseaseMedicineByDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource userLogBindingSource;
        private Database.FarmManageDataSetTableAdapters.UserLogTableAdapter userLogTableAdapter;
        private System.Windows.Forms.BindingSource usersViewBindingSource2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewComboBoxColumn StockID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unit;
        private System.Windows.Forms.DataGridViewComboBoxColumn ByID;
        private Control.UserLogUC userLogUC;
    }
}
namespace MainProject.UserInterface.Order
{
    partial class AddDeadForm
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
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.pnlFooter = new System.Windows.Forms.FlowLayoutPanel();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnResource = new System.Windows.Forms.Button();
            this.mTitle = new System.Windows.Forms.Label();
            this.tcMain = new System.Windows.Forms.TabControl();
            this.tabDetail = new System.Windows.Forms.TabPage();
            this.pnlContent = new System.Windows.Forms.TableLayoutPanel();
            this.gbxDetail = new System.Windows.Forms.GroupBox();
            this.pnlDetailContent = new System.Windows.Forms.TableLayoutPanel();
            this.lblBy = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.cbxBy = new System.Windows.Forms.ComboBox();
            this.deadViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.farmManageDataSet = new MainProject.Database.FarmManageDataSet();
            this.usersViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.lblDescription = new System.Windows.Forms.Label();
            this.tbxDescription = new System.Windows.Forms.TextBox();
            this.tcSecond = new System.Windows.Forms.TabControl();
            this.tabCow = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pnlCowContent = new System.Windows.Forms.TableLayoutPanel();
            this.dgvCow = new System.Windows.Forms.DataGridView();
            this.corralIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.corralBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.geneIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.geneBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sexDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fKCowOrderOut1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabCowAdd = new System.Windows.Forms.TabPage();
            this.gbxCowAdd = new System.Windows.Forms.GroupBox();
            this.pnlCowAddContent = new System.Windows.Forms.TableLayoutPanel();
            this.pnlConAddOption = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnRemoveAll = new System.Windows.Forms.Button();
            this.dgvCowAdd = new System.Windows.Forms.DataGridView();
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCowID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCorral = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.colGene = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.colSex = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.colDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabRecord = new System.Windows.Forms.TabPage();
            this.userLogUC = new MainProject.UserInterface.Control.UserLogUC();
            this.usersViewBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.usersViewTableAdapter = new MainProject.Database.FarmManageDataSetTableAdapters.UsersViewTableAdapter();
            this.corralTableAdapter = new MainProject.Database.FarmManageDataSetTableAdapters.CorralTableAdapter();
            this.geneTableAdapter = new MainProject.Database.FarmManageDataSetTableAdapters.GeneTableAdapter();
            this.deadViewTableAdapter = new MainProject.Database.FarmManageDataSetTableAdapters.DeadViewTableAdapter();
            this.cowTableAdapter = new MainProject.Database.FarmManageDataSetTableAdapters.CowTableAdapter();
            this.pnlMain.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.pnlFooter.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.tcMain.SuspendLayout();
            this.tabDetail.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.gbxDetail.SuspendLayout();
            this.pnlDetailContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deadViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.farmManageDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersViewBindingSource)).BeginInit();
            this.tcSecond.SuspendLayout();
            this.tabCow.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.pnlCowContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.corralBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.geneBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKCowOrderOut1BindingSource)).BeginInit();
            this.tabCowAdd.SuspendLayout();
            this.gbxCowAdd.SuspendLayout();
            this.pnlCowAddContent.SuspendLayout();
            this.pnlConAddOption.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCowAdd)).BeginInit();
            this.tabRecord.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usersViewBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.pnlMain.ColumnCount = 1;
            this.pnlMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.pnlMain.Controls.Add(this.tableLayoutPanel2, 0, 2);
            this.pnlMain.Controls.Add(this.mTitle, 0, 0);
            this.pnlMain.Controls.Add(this.tcMain, 0, 1);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.RowCount = 3;
            this.pnlMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.pnlMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.pnlMain.Size = new System.Drawing.Size(644, 571);
            this.pnlMain.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.pnlFooter, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.flowLayoutPanel1, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(1, 530);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(642, 40);
            this.tableLayoutPanel2.TabIndex = 4;
            // 
            // pnlFooter
            // 
            this.pnlFooter.Controls.Add(this.btnClose);
            this.pnlFooter.Controls.Add(this.btnSave);
            this.pnlFooter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFooter.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.pnlFooter.Location = new System.Drawing.Point(324, 3);
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.Padding = new System.Windows.Forms.Padding(3);
            this.pnlFooter.Size = new System.Drawing.Size(315, 34);
            this.pnlFooter.TabIndex = 2;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(231, 6);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "ยกเลิก";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(150, 6);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "บันทึก";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnResource);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(3);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(315, 34);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // btnResource
            // 
            this.btnResource.Location = new System.Drawing.Point(6, 6);
            this.btnResource.Name = "btnResource";
            this.btnResource.Size = new System.Drawing.Size(75, 23);
            this.btnResource.TabIndex = 0;
            this.btnResource.Text = "หลักฐาน";
            this.btnResource.UseVisualStyleBackColor = true;
            this.btnResource.Click += new System.EventHandler(this.btnResource_Click);
            // 
            // mTitle
            // 
            this.mTitle.AutoSize = true;
            this.mTitle.BackColor = System.Drawing.Color.White;
            this.mTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.mTitle.Location = new System.Drawing.Point(4, 1);
            this.mTitle.Name = "mTitle";
            this.mTitle.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.mTitle.Size = new System.Drawing.Size(636, 60);
            this.mTitle.TabIndex = 0;
            this.mTitle.Text = "เพิ่มการตาย";
            this.mTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tcMain
            // 
            this.tcMain.Controls.Add(this.tabDetail);
            this.tcMain.Controls.Add(this.tabRecord);
            this.tcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcMain.Location = new System.Drawing.Point(4, 65);
            this.tcMain.Name = "tcMain";
            this.tcMain.SelectedIndex = 0;
            this.tcMain.Size = new System.Drawing.Size(636, 461);
            this.tcMain.TabIndex = 2;
            // 
            // tabDetail
            // 
            this.tabDetail.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabDetail.Controls.Add(this.pnlContent);
            this.tabDetail.Location = new System.Drawing.Point(4, 22);
            this.tabDetail.Name = "tabDetail";
            this.tabDetail.Padding = new System.Windows.Forms.Padding(3);
            this.tabDetail.Size = new System.Drawing.Size(628, 435);
            this.tabDetail.TabIndex = 0;
            this.tabDetail.Text = "รายละเอียด";
            // 
            // pnlContent
            // 
            this.pnlContent.ColumnCount = 1;
            this.pnlContent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlContent.Controls.Add(this.gbxDetail, 0, 0);
            this.pnlContent.Controls.Add(this.tcSecond, 0, 1);
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(3, 3);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.RowCount = 2;
            this.pnlContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 110F));
            this.pnlContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlContent.Size = new System.Drawing.Size(622, 429);
            this.pnlContent.TabIndex = 3;
            // 
            // gbxDetail
            // 
            this.gbxDetail.Controls.Add(this.pnlDetailContent);
            this.gbxDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbxDetail.Location = new System.Drawing.Point(3, 3);
            this.gbxDetail.Name = "gbxDetail";
            this.gbxDetail.Size = new System.Drawing.Size(616, 104);
            this.gbxDetail.TabIndex = 0;
            this.gbxDetail.TabStop = false;
            this.gbxDetail.Text = "รายละเอียดการตาย";
            // 
            // pnlDetailContent
            // 
            this.pnlDetailContent.ColumnCount = 7;
            this.pnlDetailContent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.pnlDetailContent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.pnlDetailContent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.pnlDetailContent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.pnlDetailContent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.pnlDetailContent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.pnlDetailContent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.pnlDetailContent.Controls.Add(this.lblBy, 1, 1);
            this.pnlDetailContent.Controls.Add(this.lblDate, 1, 3);
            this.pnlDetailContent.Controls.Add(this.cbxBy, 2, 1);
            this.pnlDetailContent.Controls.Add(this.dtpDate, 2, 3);
            this.pnlDetailContent.Controls.Add(this.lblDescription, 4, 1);
            this.pnlDetailContent.Controls.Add(this.tbxDescription, 5, 1);
            this.pnlDetailContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDetailContent.Location = new System.Drawing.Point(3, 16);
            this.pnlDetailContent.Name = "pnlDetailContent";
            this.pnlDetailContent.RowCount = 7;
            this.pnlDetailContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.pnlDetailContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.pnlDetailContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 3F));
            this.pnlDetailContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.pnlDetailContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 3F));
            this.pnlDetailContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.pnlDetailContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlDetailContent.Size = new System.Drawing.Size(610, 85);
            this.pnlDetailContent.TabIndex = 0;
            // 
            // lblBy
            // 
            this.lblBy.AutoSize = true;
            this.lblBy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblBy.Location = new System.Drawing.Point(33, 10);
            this.lblBy.Name = "lblBy";
            this.lblBy.Size = new System.Drawing.Size(84, 25);
            this.lblBy.TabIndex = 0;
            this.lblBy.Text = "แจ้งโดย";
            this.lblBy.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDate.Location = new System.Drawing.Point(33, 38);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(84, 25);
            this.lblDate.TabIndex = 1;
            this.lblDate.Text = "วันทีตาย";
            this.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbxBy
            // 
            this.cbxBy.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.deadViewBindingSource, "OrderBy", true));
            this.cbxBy.DataSource = this.usersViewBindingSource;
            this.cbxBy.DisplayMember = "Name";
            this.cbxBy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbxBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxBy.FormattingEnabled = true;
            this.cbxBy.Location = new System.Drawing.Point(123, 13);
            this.cbxBy.Name = "cbxBy";
            this.cbxBy.Size = new System.Drawing.Size(174, 21);
            this.cbxBy.TabIndex = 2;
            this.cbxBy.ValueMember = "UserID";
            // 
            // deadViewBindingSource
            // 
            this.deadViewBindingSource.DataMember = "DeadView";
            this.deadViewBindingSource.DataSource = this.farmManageDataSet;
            // 
            // farmManageDataSet
            // 
            this.farmManageDataSet.DataSetName = "FarmManageDataSet";
            this.farmManageDataSet.Locale = new System.Globalization.CultureInfo("en");
            this.farmManageDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usersViewBindingSource
            // 
            this.usersViewBindingSource.DataMember = "UsersView";
            this.usersViewBindingSource.DataSource = this.farmManageDataSet;
            // 
            // dtpDate
            // 
            this.dtpDate.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.deadViewBindingSource, "Date", true));
            this.dtpDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.Location = new System.Drawing.Point(123, 41);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(174, 20);
            this.dtpDate.TabIndex = 3;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDescription.Location = new System.Drawing.Point(313, 10);
            this.lblDescription.Name = "lblDescription";
            this.pnlDetailContent.SetRowSpan(this.lblDescription, 3);
            this.lblDescription.Size = new System.Drawing.Size(84, 53);
            this.lblDescription.TabIndex = 4;
            this.lblDescription.Text = "รายละเอียด";
            this.lblDescription.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbxDescription
            // 
            this.tbxDescription.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.deadViewBindingSource, "Description", true));
            this.tbxDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxDescription.Location = new System.Drawing.Point(403, 13);
            this.tbxDescription.Multiline = true;
            this.tbxDescription.Name = "tbxDescription";
            this.pnlDetailContent.SetRowSpan(this.tbxDescription, 3);
            this.tbxDescription.Size = new System.Drawing.Size(174, 47);
            this.tbxDescription.TabIndex = 5;
            // 
            // tcSecond
            // 
            this.tcSecond.Controls.Add(this.tabCow);
            this.tcSecond.Controls.Add(this.tabCowAdd);
            this.tcSecond.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcSecond.Location = new System.Drawing.Point(3, 113);
            this.tcSecond.Name = "tcSecond";
            this.tcSecond.SelectedIndex = 0;
            this.tcSecond.Size = new System.Drawing.Size(616, 313);
            this.tcSecond.TabIndex = 1;
            // 
            // tabCow
            // 
            this.tabCow.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabCow.Controls.Add(this.groupBox2);
            this.tabCow.Location = new System.Drawing.Point(4, 22);
            this.tabCow.Name = "tabCow";
            this.tabCow.Padding = new System.Windows.Forms.Padding(3);
            this.tabCow.Size = new System.Drawing.Size(608, 287);
            this.tabCow.TabIndex = 0;
            this.tabCow.Text = "รายการโค";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pnlCowContent);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(602, 281);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "รายการโค";
            // 
            // pnlCowContent
            // 
            this.pnlCowContent.ColumnCount = 1;
            this.pnlCowContent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlCowContent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.pnlCowContent.Controls.Add(this.dgvCow, 0, 0);
            this.pnlCowContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCowContent.Location = new System.Drawing.Point(3, 16);
            this.pnlCowContent.Name = "pnlCowContent";
            this.pnlCowContent.RowCount = 1;
            this.pnlCowContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlCowContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 262F));
            this.pnlCowContent.Size = new System.Drawing.Size(596, 262);
            this.pnlCowContent.TabIndex = 0;
            // 
            // dgvCow
            // 
            this.dgvCow.AllowUserToAddRows = false;
            this.dgvCow.AllowUserToDeleteRows = false;
            this.dgvCow.AutoGenerateColumns = false;
            this.dgvCow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCow.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.corralIDDataGridViewTextBoxColumn,
            this.geneIDDataGridViewTextBoxColumn,
            this.sexDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn});
            this.dgvCow.DataSource = this.fKCowOrderOut1BindingSource;
            this.dgvCow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCow.Location = new System.Drawing.Point(3, 3);
            this.dgvCow.Name = "dgvCow";
            this.dgvCow.ReadOnly = true;
            this.dgvCow.Size = new System.Drawing.Size(590, 256);
            this.dgvCow.TabIndex = 0;
            // 
            // corralIDDataGridViewTextBoxColumn
            // 
            this.corralIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.corralIDDataGridViewTextBoxColumn.DataPropertyName = "CorralID";
            this.corralIDDataGridViewTextBoxColumn.DataSource = this.corralBindingSource;
            this.corralIDDataGridViewTextBoxColumn.DisplayMember = "Name";
            this.corralIDDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.corralIDDataGridViewTextBoxColumn.HeaderText = "คอก";
            this.corralIDDataGridViewTextBoxColumn.Name = "corralIDDataGridViewTextBoxColumn";
            this.corralIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.corralIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.corralIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.corralIDDataGridViewTextBoxColumn.ValueMember = "CorralID";
            // 
            // corralBindingSource
            // 
            this.corralBindingSource.DataMember = "Corral";
            this.corralBindingSource.DataSource = this.farmManageDataSet;
            // 
            // geneIDDataGridViewTextBoxColumn
            // 
            this.geneIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.geneIDDataGridViewTextBoxColumn.DataPropertyName = "GeneID";
            this.geneIDDataGridViewTextBoxColumn.DataSource = this.geneBindingSource;
            this.geneIDDataGridViewTextBoxColumn.DisplayMember = "Name";
            this.geneIDDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.geneIDDataGridViewTextBoxColumn.HeaderText = "พันธุ์";
            this.geneIDDataGridViewTextBoxColumn.Name = "geneIDDataGridViewTextBoxColumn";
            this.geneIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.geneIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.geneIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.geneIDDataGridViewTextBoxColumn.ValueMember = "GeneID";
            // 
            // geneBindingSource
            // 
            this.geneBindingSource.DataMember = "Gene";
            this.geneBindingSource.DataSource = this.farmManageDataSet;
            // 
            // sexDataGridViewTextBoxColumn
            // 
            this.sexDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.sexDataGridViewTextBoxColumn.DataPropertyName = "Sex";
            this.sexDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.sexDataGridViewTextBoxColumn.HeaderText = "เพศ";
            this.sexDataGridViewTextBoxColumn.Name = "sexDataGridViewTextBoxColumn";
            this.sexDataGridViewTextBoxColumn.ReadOnly = true;
            this.sexDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.sexDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "รายละเอียด";
            this.descriptionDataGridViewTextBoxColumn.MinimumWidth = 150;
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            this.descriptionDataGridViewTextBoxColumn.Width = 150;
            // 
            // fKCowOrderOut1BindingSource
            // 
            this.fKCowOrderOut1BindingSource.DataMember = "FK_Cow_OrderOut1";
            this.fKCowOrderOut1BindingSource.DataSource = this.deadViewBindingSource;
            // 
            // tabCowAdd
            // 
            this.tabCowAdd.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabCowAdd.Controls.Add(this.gbxCowAdd);
            this.tabCowAdd.Location = new System.Drawing.Point(4, 22);
            this.tabCowAdd.Name = "tabCowAdd";
            this.tabCowAdd.Padding = new System.Windows.Forms.Padding(3);
            this.tabCowAdd.Size = new System.Drawing.Size(608, 287);
            this.tabCowAdd.TabIndex = 1;
            this.tabCowAdd.Text = "เพิ่มรายการโค";
            // 
            // gbxCowAdd
            // 
            this.gbxCowAdd.Controls.Add(this.pnlCowAddContent);
            this.gbxCowAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbxCowAdd.Location = new System.Drawing.Point(3, 3);
            this.gbxCowAdd.Name = "gbxCowAdd";
            this.gbxCowAdd.Size = new System.Drawing.Size(602, 281);
            this.gbxCowAdd.TabIndex = 0;
            this.gbxCowAdd.TabStop = false;
            this.gbxCowAdd.Text = "เพิ่มรายการโค";
            // 
            // pnlCowAddContent
            // 
            this.pnlCowAddContent.ColumnCount = 1;
            this.pnlCowAddContent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlCowAddContent.Controls.Add(this.pnlConAddOption, 0, 1);
            this.pnlCowAddContent.Controls.Add(this.dgvCowAdd, 0, 0);
            this.pnlCowAddContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCowAddContent.Location = new System.Drawing.Point(3, 16);
            this.pnlCowAddContent.Name = "pnlCowAddContent";
            this.pnlCowAddContent.RowCount = 2;
            this.pnlCowAddContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlCowAddContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.pnlCowAddContent.Size = new System.Drawing.Size(596, 262);
            this.pnlCowAddContent.TabIndex = 1;
            // 
            // pnlConAddOption
            // 
            this.pnlConAddOption.Controls.Add(this.btnAdd);
            this.pnlConAddOption.Controls.Add(this.btnRemove);
            this.pnlConAddOption.Controls.Add(this.btnRemoveAll);
            this.pnlConAddOption.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlConAddOption.Location = new System.Drawing.Point(0, 234);
            this.pnlConAddOption.Margin = new System.Windows.Forms.Padding(0);
            this.pnlConAddOption.Name = "pnlConAddOption";
            this.pnlConAddOption.Size = new System.Drawing.Size(596, 28);
            this.pnlConAddOption.TabIndex = 0;
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
            // dgvCowAdd
            // 
            this.dgvCowAdd.AllowUserToAddRows = false;
            this.dgvCowAdd.AllowUserToDeleteRows = false;
            this.dgvCowAdd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCowAdd.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colID,
            this.colCowID,
            this.colNO,
            this.colCorral,
            this.colGene,
            this.colSex,
            this.colDescription});
            this.dgvCowAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCowAdd.Location = new System.Drawing.Point(3, 3);
            this.dgvCowAdd.Name = "dgvCowAdd";
            this.dgvCowAdd.Size = new System.Drawing.Size(590, 228);
            this.dgvCowAdd.TabIndex = 1;
            this.dgvCowAdd.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgvCowAdd_RowsAdded);
            this.dgvCowAdd.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dgvCowAdd_RowsRemoved);
            this.dgvCowAdd.SelectionChanged += new System.EventHandler(this.dgvCowAdd_SelectionChanged);
            // 
            // colID
            // 
            this.colID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colID.HeaderText = "ลำดับ";
            this.colID.MinimumWidth = 50;
            this.colID.Name = "colID";
            this.colID.ReadOnly = true;
            this.colID.Width = 57;
            // 
            // colCowID
            // 
            this.colCowID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colCowID.HeaderText = "ID";
            this.colCowID.MinimumWidth = 50;
            this.colCowID.Name = "colCowID";
            this.colCowID.ReadOnly = true;
            this.colCowID.Visible = false;
            // 
            // colNO
            // 
            this.colNO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colNO.HeaderText = "NO";
            this.colNO.Name = "colNO";
            this.colNO.ReadOnly = true;
            // 
            // colCorral
            // 
            this.colCorral.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colCorral.DataSource = this.corralBindingSource;
            this.colCorral.DisplayMember = "Name";
            this.colCorral.HeaderText = "คอก";
            this.colCorral.Name = "colCorral";
            this.colCorral.ReadOnly = true;
            this.colCorral.ValueMember = "CorralID";
            // 
            // colGene
            // 
            this.colGene.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colGene.DataSource = this.geneBindingSource;
            this.colGene.DisplayMember = "Name";
            this.colGene.HeaderText = "พันธุ์";
            this.colGene.Name = "colGene";
            this.colGene.ReadOnly = true;
            this.colGene.ValueMember = "GeneID";
            // 
            // colSex
            // 
            this.colSex.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colSex.HeaderText = "เพศ";
            this.colSex.Name = "colSex";
            this.colSex.ReadOnly = true;
            // 
            // colDescription
            // 
            this.colDescription.HeaderText = "รายละเอียด";
            this.colDescription.MaxInputLength = 512;
            this.colDescription.MinimumWidth = 100;
            this.colDescription.Name = "colDescription";
            // 
            // tabRecord
            // 
            this.tabRecord.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabRecord.Controls.Add(this.userLogUC);
            this.tabRecord.Location = new System.Drawing.Point(4, 22);
            this.tabRecord.Name = "tabRecord";
            this.tabRecord.Padding = new System.Windows.Forms.Padding(3);
            this.tabRecord.Size = new System.Drawing.Size(628, 435);
            this.tabRecord.TabIndex = 1;
            this.tabRecord.Text = "การบันทึก";
            // 
            // userLogUC
            // 
            this.userLogUC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userLogUC.Location = new System.Drawing.Point(3, 3);
            this.userLogUC.Name = "userLogUC";
            this.userLogUC.Size = new System.Drawing.Size(622, 429);
            this.userLogUC.TabIndex = 0;
            // 
            // usersViewBindingSource1
            // 
            this.usersViewBindingSource1.DataMember = "UsersView";
            this.usersViewBindingSource1.DataSource = this.farmManageDataSet;
            // 
            // usersViewTableAdapter
            // 
            this.usersViewTableAdapter.ClearBeforeFill = true;
            // 
            // corralTableAdapter
            // 
            this.corralTableAdapter.ClearBeforeFill = true;
            // 
            // geneTableAdapter
            // 
            this.geneTableAdapter.ClearBeforeFill = true;
            // 
            // deadViewTableAdapter
            // 
            this.deadViewTableAdapter.ClearBeforeFill = true;
            // 
            // cowTableAdapter
            // 
            this.cowTableAdapter.ClearBeforeFill = true;
            // 
            // AddDeadForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 571);
            this.Controls.Add(this.pnlMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddDeadForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "เพิ่มการตาย";
            this.Load += new System.EventHandler(this.AddBornForm_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.pnlFooter.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.tcMain.ResumeLayout(false);
            this.tabDetail.ResumeLayout(false);
            this.pnlContent.ResumeLayout(false);
            this.gbxDetail.ResumeLayout(false);
            this.pnlDetailContent.ResumeLayout(false);
            this.pnlDetailContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deadViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.farmManageDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersViewBindingSource)).EndInit();
            this.tcSecond.ResumeLayout(false);
            this.tabCow.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.pnlCowContent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.corralBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.geneBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKCowOrderOut1BindingSource)).EndInit();
            this.tabCowAdd.ResumeLayout(false);
            this.gbxCowAdd.ResumeLayout(false);
            this.pnlCowAddContent.ResumeLayout(false);
            this.pnlConAddOption.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCowAdd)).EndInit();
            this.tabRecord.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.usersViewBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel pnlMain;
        private System.Windows.Forms.Label mTitle;
        private System.Windows.Forms.TabControl tcMain;
        private System.Windows.Forms.TabPage tabDetail;
        private System.Windows.Forms.TableLayoutPanel pnlContent;
        private System.Windows.Forms.GroupBox gbxDetail;
        private System.Windows.Forms.TableLayoutPanel pnlDetailContent;
        private System.Windows.Forms.TabControl tcSecond;
        private System.Windows.Forms.TabPage tabCow;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TableLayoutPanel pnlCowContent;
        private System.Windows.Forms.DataGridView dgvCow;
        private System.Windows.Forms.TabPage tabCowAdd;
        private System.Windows.Forms.GroupBox gbxCowAdd;
        private System.Windows.Forms.TableLayoutPanel pnlCowAddContent;
        private System.Windows.Forms.FlowLayoutPanel pnlConAddOption;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnRemoveAll;
        private System.Windows.Forms.DataGridView dgvCowAdd;
        private System.Windows.Forms.TabPage tabRecord;
        private System.Windows.Forms.Label lblBy;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.ComboBox cbxBy;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox tbxDescription;
        private Database.FarmManageDataSet farmManageDataSet;
        private System.Windows.Forms.BindingSource usersViewBindingSource;
        private Database.FarmManageDataSetTableAdapters.UsersViewTableAdapter usersViewTableAdapter;
        private System.Windows.Forms.BindingSource usersViewBindingSource1;
        private System.Windows.Forms.BindingSource corralBindingSource;
        private Database.FarmManageDataSetTableAdapters.CorralTableAdapter corralTableAdapter;
        private System.Windows.Forms.BindingSource geneBindingSource;
        private Database.FarmManageDataSetTableAdapters.GeneTableAdapter geneTableAdapter;
        private System.Windows.Forms.BindingSource deadViewBindingSource;
        private Database.FarmManageDataSetTableAdapters.DeadViewTableAdapter deadViewTableAdapter;
        private System.Windows.Forms.BindingSource fKCowOrderOut1BindingSource;
        private Database.FarmManageDataSetTableAdapters.CowTableAdapter cowTableAdapter;
        private System.Windows.Forms.DataGridViewComboBoxColumn corralIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn geneIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn sexDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCowID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNO;
        private System.Windows.Forms.DataGridViewComboBoxColumn colCorral;
        private System.Windows.Forms.DataGridViewComboBoxColumn colGene;
        private System.Windows.Forms.DataGridViewComboBoxColumn colSex;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDescription;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.FlowLayoutPanel pnlFooter;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnResource;
        private Control.UserLogUC userLogUC;
    }
}
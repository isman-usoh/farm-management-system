namespace MainProject.UserInterface.Recipes
{
    partial class AddRecipesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddRecipesForm));
            this.pnlMain = new System.Windows.Forms.TableLayoutPanel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlFooter = new System.Windows.Forms.FlowLayoutPanel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.tclMain = new System.Windows.Forms.TabControl();
            this.tabDetail = new System.Windows.Forms.TabPage();
            this.pnlContent = new System.Windows.Forms.TableLayoutPanel();
            this.gbxGeneral = new System.Windows.Forms.GroupBox();
            this.pnlGeneralContent = new System.Windows.Forms.TableLayoutPanel();
            this.lblName = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.recipesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.farmManageDataSet = new MainProject.Database.FarmManageDataSet();
            this.tbxDescription = new System.Windows.Forms.TextBox();
            this.tcSecond = new System.Windows.Forms.TabControl();
            this.tabList = new System.Windows.Forms.TabPage();
            this.gbxList = new System.Windows.Forms.GroupBox();
            this.pnlListContent = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnListRemove = new System.Windows.Forms.Button();
            this.dgvList = new System.Windows.Forms.DataGridView();
            this.recipesListIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.stockBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.unitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fKrecipeslistrecipesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabAdd = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.dgvAdd = new System.Windows.Forms.DataGridView();
            this.colAddStock = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.colAddUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnRemoveAll = new System.Windows.Forms.Button();
            this.tabHistory = new System.Windows.Forms.TabPage();
            this.pnlHistory = new System.Windows.Forms.TableLayoutPanel();
            this.pnlContentOption = new System.Windows.Forms.FlowLayoutPanel();
            this.button4 = new System.Windows.Forms.Button();
            this.dgvHistory = new System.Windows.Forms.DataGridView();
            this.recipesHistoryIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.recipesHistoryByDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.usersViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fKrecipeshistoryrecipesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabRecord = new System.Windows.Forms.TabPage();
            this.userLogBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.recipesTableAdapter = new MainProject.Database.FarmManageDataSetTableAdapters.RecipesTableAdapter();
            this.recipesListTableAdapter = new MainProject.Database.FarmManageDataSetTableAdapters.RecipesListTableAdapter();
            this.recipesHistoryTableAdapter = new MainProject.Database.FarmManageDataSetTableAdapters.RecipesHistoryTableAdapter();
            this.usersViewTableAdapter = new MainProject.Database.FarmManageDataSetTableAdapters.UsersViewTableAdapter();
            this.stockTableAdapter = new MainProject.Database.FarmManageDataSetTableAdapters.StockTableAdapter();
            this.userLogTableAdapter = new MainProject.Database.FarmManageDataSetTableAdapters.UserLogTableAdapter();
            this.pnlMain.SuspendLayout();
            this.pnlFooter.SuspendLayout();
            this.tclMain.SuspendLayout();
            this.tabDetail.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.gbxGeneral.SuspendLayout();
            this.pnlGeneralContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.recipesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.farmManageDataSet)).BeginInit();
            this.tcSecond.SuspendLayout();
            this.tabList.SuspendLayout();
            this.gbxList.SuspendLayout();
            this.pnlListContent.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKrecipeslistrecipesBindingSource)).BeginInit();
            this.tabAdd.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdd)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.tabHistory.SuspendLayout();
            this.pnlHistory.SuspendLayout();
            this.pnlContentOption.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKrecipeshistoryrecipesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userLogBindingSource)).BeginInit();
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
            this.pnlMain.Controls.Add(this.tclMain, 0, 1);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.RowCount = 3;
            this.pnlMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.pnlMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.pnlMain.Size = new System.Drawing.Size(594, 521);
            this.pnlMain.TabIndex = 1;
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
            this.lblTitle.Text = "รายละเอียดสูตรอาหาร";
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
            // tclMain
            // 
            this.tclMain.Controls.Add(this.tabDetail);
            this.tclMain.Controls.Add(this.tabHistory);
            this.tclMain.Controls.Add(this.tabRecord);
            this.tclMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tclMain.Location = new System.Drawing.Point(4, 65);
            this.tclMain.Name = "tclMain";
            this.tclMain.SelectedIndex = 0;
            this.tclMain.Size = new System.Drawing.Size(586, 411);
            this.tclMain.TabIndex = 2;
            // 
            // tabDetail
            // 
            this.tabDetail.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabDetail.Controls.Add(this.pnlContent);
            this.tabDetail.Location = new System.Drawing.Point(4, 22);
            this.tabDetail.Name = "tabDetail";
            this.tabDetail.Padding = new System.Windows.Forms.Padding(3);
            this.tabDetail.Size = new System.Drawing.Size(578, 385);
            this.tabDetail.TabIndex = 0;
            this.tabDetail.Text = "รายละเอียด";
            // 
            // pnlContent
            // 
            this.pnlContent.ColumnCount = 1;
            this.pnlContent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlContent.Controls.Add(this.gbxGeneral, 0, 0);
            this.pnlContent.Controls.Add(this.tcSecond, 0, 1);
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(3, 3);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.RowCount = 2;
            this.pnlContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 93F));
            this.pnlContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlContent.Size = new System.Drawing.Size(572, 379);
            this.pnlContent.TabIndex = 3;
            // 
            // gbxGeneral
            // 
            this.gbxGeneral.Controls.Add(this.pnlGeneralContent);
            this.gbxGeneral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbxGeneral.Location = new System.Drawing.Point(3, 3);
            this.gbxGeneral.Name = "gbxGeneral";
            this.gbxGeneral.Size = new System.Drawing.Size(566, 87);
            this.gbxGeneral.TabIndex = 1;
            this.gbxGeneral.TabStop = false;
            this.gbxGeneral.Text = "ข้อมูลทั้วไป";
            // 
            // pnlGeneralContent
            // 
            this.pnlGeneralContent.ColumnCount = 7;
            this.pnlGeneralContent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.pnlGeneralContent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.pnlGeneralContent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.pnlGeneralContent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.pnlGeneralContent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.pnlGeneralContent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.pnlGeneralContent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.pnlGeneralContent.Controls.Add(this.lblName, 1, 1);
            this.pnlGeneralContent.Controls.Add(this.lblDescription, 4, 1);
            this.pnlGeneralContent.Controls.Add(this.tbxName, 2, 1);
            this.pnlGeneralContent.Controls.Add(this.tbxDescription, 5, 1);
            this.pnlGeneralContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGeneralContent.Location = new System.Drawing.Point(3, 16);
            this.pnlGeneralContent.Name = "pnlGeneralContent";
            this.pnlGeneralContent.RowCount = 6;
            this.pnlGeneralContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.pnlGeneralContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.pnlGeneralContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 3F));
            this.pnlGeneralContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.pnlGeneralContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 3F));
            this.pnlGeneralContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.pnlGeneralContent.Size = new System.Drawing.Size(560, 68);
            this.pnlGeneralContent.TabIndex = 0;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblName.Location = new System.Drawing.Point(30, 10);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(76, 25);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "ชื่อสูตร *";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDescription.Location = new System.Drawing.Point(287, 10);
            this.lblDescription.Name = "lblDescription";
            this.pnlGeneralContent.SetRowSpan(this.lblDescription, 3);
            this.lblDescription.Size = new System.Drawing.Size(76, 53);
            this.lblDescription.TabIndex = 1;
            this.lblDescription.Text = "รายละเอียด";
            this.lblDescription.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbxName
            // 
            this.tbxName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.recipesBindingSource, "Name", true));
            this.tbxName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxName.Location = new System.Drawing.Point(112, 13);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(159, 20);
            this.tbxName.TabIndex = 2;
            this.tbxName.Validating += new System.ComponentModel.CancelEventHandler(this.tbxName_Validating);
            // 
            // recipesBindingSource
            // 
            this.recipesBindingSource.DataMember = "Recipes";
            this.recipesBindingSource.DataSource = this.farmManageDataSet;
            // 
            // farmManageDataSet
            // 
            this.farmManageDataSet.DataSetName = "FarmManageDataSet";
            this.farmManageDataSet.Locale = new System.Globalization.CultureInfo("en");
            this.farmManageDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbxDescription
            // 
            this.tbxDescription.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.recipesBindingSource, "Description", true));
            this.tbxDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxDescription.Location = new System.Drawing.Point(369, 13);
            this.tbxDescription.Multiline = true;
            this.tbxDescription.Name = "tbxDescription";
            this.pnlGeneralContent.SetRowSpan(this.tbxDescription, 3);
            this.tbxDescription.Size = new System.Drawing.Size(159, 47);
            this.tbxDescription.TabIndex = 3;
            // 
            // tcSecond
            // 
            this.tcSecond.Controls.Add(this.tabList);
            this.tcSecond.Controls.Add(this.tabAdd);
            this.tcSecond.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcSecond.Location = new System.Drawing.Point(3, 96);
            this.tcSecond.Name = "tcSecond";
            this.tcSecond.SelectedIndex = 0;
            this.tcSecond.Size = new System.Drawing.Size(566, 280);
            this.tcSecond.TabIndex = 2;
            // 
            // tabList
            // 
            this.tabList.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabList.Controls.Add(this.gbxList);
            this.tabList.Location = new System.Drawing.Point(4, 22);
            this.tabList.Name = "tabList";
            this.tabList.Padding = new System.Windows.Forms.Padding(3);
            this.tabList.Size = new System.Drawing.Size(558, 254);
            this.tabList.TabIndex = 0;
            this.tabList.Text = "รายการพัสดุ";
            // 
            // gbxList
            // 
            this.gbxList.Controls.Add(this.pnlListContent);
            this.gbxList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbxList.Location = new System.Drawing.Point(3, 3);
            this.gbxList.Name = "gbxList";
            this.gbxList.Size = new System.Drawing.Size(552, 248);
            this.gbxList.TabIndex = 1;
            this.gbxList.TabStop = false;
            this.gbxList.Text = "รายการพัสดุ";
            // 
            // pnlListContent
            // 
            this.pnlListContent.ColumnCount = 1;
            this.pnlListContent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlListContent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.pnlListContent.Controls.Add(this.flowLayoutPanel2, 0, 1);
            this.pnlListContent.Controls.Add(this.dgvList, 0, 0);
            this.pnlListContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlListContent.Location = new System.Drawing.Point(3, 16);
            this.pnlListContent.Name = "pnlListContent";
            this.pnlListContent.RowCount = 2;
            this.pnlListContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlListContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.pnlListContent.Size = new System.Drawing.Size(546, 229);
            this.pnlListContent.TabIndex = 0;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.btnListRemove);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 201);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(546, 28);
            this.flowLayoutPanel2.TabIndex = 3;
            // 
            // btnListRemove
            // 
            this.btnListRemove.Enabled = false;
            this.btnListRemove.Location = new System.Drawing.Point(3, 3);
            this.btnListRemove.Name = "btnListRemove";
            this.btnListRemove.Size = new System.Drawing.Size(75, 23);
            this.btnListRemove.TabIndex = 1;
            this.btnListRemove.Text = "ลบที่เลือก";
            this.btnListRemove.UseVisualStyleBackColor = true;
            this.btnListRemove.Click += new System.EventHandler(this.btnListRemove_Click);
            // 
            // dgvList
            // 
            this.dgvList.AllowUserToAddRows = false;
            this.dgvList.AllowUserToDeleteRows = false;
            this.dgvList.AutoGenerateColumns = false;
            this.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.recipesListIDDataGridViewTextBoxColumn,
            this.stockIDDataGridViewTextBoxColumn,
            this.unitDataGridViewTextBoxColumn});
            this.dgvList.DataSource = this.fKrecipeslistrecipesBindingSource;
            this.dgvList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvList.Location = new System.Drawing.Point(3, 3);
            this.dgvList.Name = "dgvList";
            this.dgvList.Size = new System.Drawing.Size(540, 195);
            this.dgvList.TabIndex = 1;
            this.dgvList.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvList_DataError);
            this.dgvList.SelectionChanged += new System.EventHandler(this.dgvList_SelectionChanged);
            // 
            // recipesListIDDataGridViewTextBoxColumn
            // 
            this.recipesListIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.recipesListIDDataGridViewTextBoxColumn.DataPropertyName = "RecipesListID";
            this.recipesListIDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.recipesListIDDataGridViewTextBoxColumn.Name = "recipesListIDDataGridViewTextBoxColumn";
            this.recipesListIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.recipesListIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // stockIDDataGridViewTextBoxColumn
            // 
            this.stockIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.stockIDDataGridViewTextBoxColumn.DataPropertyName = "StockID";
            this.stockIDDataGridViewTextBoxColumn.DataSource = this.stockBindingSource;
            dataGridViewCellStyle1.NullValue = "0";
            this.stockIDDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.stockIDDataGridViewTextBoxColumn.DisplayMember = "Name";
            this.stockIDDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.stockIDDataGridViewTextBoxColumn.HeaderText = "ชื่อพัสดุ";
            this.stockIDDataGridViewTextBoxColumn.Name = "stockIDDataGridViewTextBoxColumn";
            this.stockIDDataGridViewTextBoxColumn.ReadOnly = true;
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
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = "0";
            this.unitDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.unitDataGridViewTextBoxColumn.HeaderText = "จำนวน";
            this.unitDataGridViewTextBoxColumn.Name = "unitDataGridViewTextBoxColumn";
            // 
            // fKrecipeslistrecipesBindingSource
            // 
            this.fKrecipeslistrecipesBindingSource.DataMember = "FK_recipes_list_recipes";
            this.fKrecipeslistrecipesBindingSource.DataSource = this.recipesBindingSource;
            // 
            // tabAdd
            // 
            this.tabAdd.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabAdd.Controls.Add(this.groupBox1);
            this.tabAdd.Location = new System.Drawing.Point(4, 22);
            this.tabAdd.Name = "tabAdd";
            this.tabAdd.Padding = new System.Windows.Forms.Padding(3);
            this.tabAdd.Size = new System.Drawing.Size(558, 254);
            this.tabAdd.TabIndex = 1;
            this.tabAdd.Text = "เพิ่มรายการพัสดุใหม่";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(552, 248);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "เพิ่มรายการพัสดุใหม่";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Controls.Add(this.dgvAdd, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.flowLayoutPanel1, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(546, 229);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // dgvAdd
            // 
            this.dgvAdd.AllowUserToAddRows = false;
            this.dgvAdd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAdd.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colAddStock,
            this.colAddUnit});
            this.dgvAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAdd.Location = new System.Drawing.Point(3, 3);
            this.dgvAdd.Name = "dgvAdd";
            this.dgvAdd.Size = new System.Drawing.Size(540, 195);
            this.dgvAdd.TabIndex = 1;
            this.dgvAdd.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dgvAdd_CellBeginEdit);
            this.dgvAdd.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAdd_CellEndEdit);
            this.dgvAdd.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgvAdd_RowsAdded);
            this.dgvAdd.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dgvAdd_RowsRemoved);
            this.dgvAdd.SelectionChanged += new System.EventHandler(this.dgvAdd_SelectionChanged);
            // 
            // colAddStock
            // 
            this.colAddStock.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colAddStock.DataSource = this.stockBindingSource;
            this.colAddStock.DisplayMember = "Name";
            this.colAddStock.HeaderText = "ชื่อพัสดุ";
            this.colAddStock.Name = "colAddStock";
            this.colAddStock.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colAddStock.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colAddStock.ValueMember = "StockID";
            // 
            // colAddUnit
            // 
            this.colAddUnit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle3.Format = "N2";
            dataGridViewCellStyle3.NullValue = "0";
            this.colAddUnit.DefaultCellStyle = dataGridViewCellStyle3;
            this.colAddUnit.HeaderText = "จำนวน";
            this.colAddUnit.MaxInputLength = 6;
            this.colAddUnit.Name = "colAddUnit";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnAdd);
            this.flowLayoutPanel1.Controls.Add(this.btnRemove);
            this.flowLayoutPanel1.Controls.Add(this.btnRemoveAll);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 201);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(546, 28);
            this.flowLayoutPanel1.TabIndex = 2;
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
            // tabHistory
            // 
            this.tabHistory.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabHistory.Controls.Add(this.pnlHistory);
            this.tabHistory.Location = new System.Drawing.Point(4, 22);
            this.tabHistory.Name = "tabHistory";
            this.tabHistory.Padding = new System.Windows.Forms.Padding(3);
            this.tabHistory.Size = new System.Drawing.Size(578, 385);
            this.tabHistory.TabIndex = 1;
            this.tabHistory.Text = "ประวัติการใช้สูตร";
            // 
            // pnlHistory
            // 
            this.pnlHistory.ColumnCount = 1;
            this.pnlHistory.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlHistory.Controls.Add(this.pnlContentOption, 0, 1);
            this.pnlHistory.Controls.Add(this.dgvHistory, 0, 0);
            this.pnlHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlHistory.Location = new System.Drawing.Point(3, 3);
            this.pnlHistory.Name = "pnlHistory";
            this.pnlHistory.RowCount = 2;
            this.pnlHistory.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlHistory.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.pnlHistory.Size = new System.Drawing.Size(572, 379);
            this.pnlHistory.TabIndex = 0;
            // 
            // pnlContentOption
            // 
            this.pnlContentOption.Controls.Add(this.button4);
            this.pnlContentOption.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContentOption.Location = new System.Drawing.Point(3, 348);
            this.pnlContentOption.Name = "pnlContentOption";
            this.pnlContentOption.Size = new System.Drawing.Size(566, 28);
            this.pnlContentOption.TabIndex = 2;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(3, 3);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(100, 23);
            this.button4.TabIndex = 4;
            this.button4.Text = "หักพัสดุจากคลัง";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // dgvHistory
            // 
            this.dgvHistory.AllowUserToAddRows = false;
            this.dgvHistory.AllowUserToDeleteRows = false;
            this.dgvHistory.AutoGenerateColumns = false;
            this.dgvHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHistory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.recipesHistoryIDDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.recipesHistoryByDataGridViewTextBoxColumn});
            this.dgvHistory.DataSource = this.fKrecipeshistoryrecipesBindingSource;
            this.dgvHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvHistory.Location = new System.Drawing.Point(3, 3);
            this.dgvHistory.Name = "dgvHistory";
            this.dgvHistory.ReadOnly = true;
            this.dgvHistory.Size = new System.Drawing.Size(566, 339);
            this.dgvHistory.TabIndex = 1;
            this.dgvHistory.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvHistory_CellMouseDoubleClick);
            // 
            // recipesHistoryIDDataGridViewTextBoxColumn
            // 
            this.recipesHistoryIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.recipesHistoryIDDataGridViewTextBoxColumn.DataPropertyName = "RecipesHistoryID";
            this.recipesHistoryIDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.recipesHistoryIDDataGridViewTextBoxColumn.MinimumWidth = 50;
            this.recipesHistoryIDDataGridViewTextBoxColumn.Name = "recipesHistoryIDDataGridViewTextBoxColumn";
            this.recipesHistoryIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.recipesHistoryIDDataGridViewTextBoxColumn.Width = 50;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            dataGridViewCellStyle4.Format = "D";
            dataGridViewCellStyle4.NullValue = null;
            this.dateDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.dateDataGridViewTextBoxColumn.HeaderText = "วันที่";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // recipesHistoryByDataGridViewTextBoxColumn
            // 
            this.recipesHistoryByDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.recipesHistoryByDataGridViewTextBoxColumn.DataPropertyName = "RecipesHistoryBy";
            this.recipesHistoryByDataGridViewTextBoxColumn.DataSource = this.usersViewBindingSource;
            this.recipesHistoryByDataGridViewTextBoxColumn.DisplayMember = "Name";
            this.recipesHistoryByDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.recipesHistoryByDataGridViewTextBoxColumn.HeaderText = "โดย";
            this.recipesHistoryByDataGridViewTextBoxColumn.Name = "recipesHistoryByDataGridViewTextBoxColumn";
            this.recipesHistoryByDataGridViewTextBoxColumn.ReadOnly = true;
            this.recipesHistoryByDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.recipesHistoryByDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.recipesHistoryByDataGridViewTextBoxColumn.ValueMember = "UserID";
            // 
            // usersViewBindingSource
            // 
            this.usersViewBindingSource.DataMember = "UsersView";
            this.usersViewBindingSource.DataSource = this.farmManageDataSet;
            // 
            // fKrecipeshistoryrecipesBindingSource
            // 
            this.fKrecipeshistoryrecipesBindingSource.DataMember = "FK_recipes_history_recipes";
            this.fKrecipeshistoryrecipesBindingSource.DataSource = this.recipesBindingSource;
            // 
            // tabRecord
            // 
            this.tabRecord.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabRecord.Location = new System.Drawing.Point(4, 22);
            this.tabRecord.Name = "tabRecord";
            this.tabRecord.Padding = new System.Windows.Forms.Padding(3);
            this.tabRecord.Size = new System.Drawing.Size(578, 385);
            this.tabRecord.TabIndex = 2;
            this.tabRecord.Text = "การบันทึก";
            // 
            // userLogBindingSource
            // 
            this.userLogBindingSource.DataMember = "UserLog";
            this.userLogBindingSource.DataSource = this.farmManageDataSet;
            // 
            // recipesTableAdapter
            // 
            this.recipesTableAdapter.ClearBeforeFill = true;
            // 
            // recipesListTableAdapter
            // 
            this.recipesListTableAdapter.ClearBeforeFill = true;
            // 
            // recipesHistoryTableAdapter
            // 
            this.recipesHistoryTableAdapter.ClearBeforeFill = true;
            // 
            // usersViewTableAdapter
            // 
            this.usersViewTableAdapter.ClearBeforeFill = true;
            // 
            // stockTableAdapter
            // 
            this.stockTableAdapter.ClearBeforeFill = true;
            // 
            // userLogTableAdapter
            // 
            this.userLogTableAdapter.ClearBeforeFill = true;
            // 
            // AddRecipesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.ClientSize = new System.Drawing.Size(594, 521);
            this.Controls.Add(this.pnlMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddRecipesForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "รายละเอียดสูตรอาหาร";
            this.Load += new System.EventHandler(this.RecipesDetailForm_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.pnlFooter.ResumeLayout(false);
            this.tclMain.ResumeLayout(false);
            this.tabDetail.ResumeLayout(false);
            this.pnlContent.ResumeLayout(false);
            this.gbxGeneral.ResumeLayout(false);
            this.pnlGeneralContent.ResumeLayout(false);
            this.pnlGeneralContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.recipesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.farmManageDataSet)).EndInit();
            this.tcSecond.ResumeLayout(false);
            this.tabList.ResumeLayout(false);
            this.gbxList.ResumeLayout(false);
            this.pnlListContent.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKrecipeslistrecipesBindingSource)).EndInit();
            this.tabAdd.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdd)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.tabHistory.ResumeLayout(false);
            this.pnlHistory.ResumeLayout(false);
            this.pnlContentOption.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKrecipeshistoryrecipesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userLogBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel pnlMain;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.FlowLayoutPanel pnlFooter;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TabControl tclMain;
        private System.Windows.Forms.TabPage tabDetail;
        private System.Windows.Forms.TabPage tabHistory;
        private System.Windows.Forms.TableLayoutPanel pnlContent;
        private System.Windows.Forms.GroupBox gbxGeneral;
        private System.Windows.Forms.TableLayoutPanel pnlGeneralContent;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.TextBox tbxDescription;
        private System.Windows.Forms.TableLayoutPanel pnlHistory;
        private System.Windows.Forms.DataGridView dgvHistory;
        private System.Windows.Forms.FlowLayoutPanel pnlContentOption;
        private System.Windows.Forms.Button button4;
        private Database.FarmManageDataSet farmManageDataSet;
        private System.Windows.Forms.BindingSource recipesBindingSource;
        private Database.FarmManageDataSetTableAdapters.RecipesTableAdapter recipesTableAdapter;
        private System.Windows.Forms.TabPage tabRecord;
        private System.Windows.Forms.BindingSource fKrecipeslistrecipesBindingSource;
        private Database.FarmManageDataSetTableAdapters.RecipesListTableAdapter recipesListTableAdapter;
        private System.Windows.Forms.BindingSource fKrecipeshistoryrecipesBindingSource;
        private Database.FarmManageDataSetTableAdapters.RecipesHistoryTableAdapter recipesHistoryTableAdapter;
        private System.Windows.Forms.BindingSource usersViewBindingSource;
        private Database.FarmManageDataSetTableAdapters.UsersViewTableAdapter usersViewTableAdapter;
        private System.Windows.Forms.BindingSource stockBindingSource;
        private Database.FarmManageDataSetTableAdapters.StockTableAdapter stockTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn recipesHistoryIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn recipesHistoryByDataGridViewTextBoxColumn;
        private System.Windows.Forms.TabControl tcSecond;
        private System.Windows.Forms.TabPage tabList;
        private System.Windows.Forms.GroupBox gbxList;
        private System.Windows.Forms.TableLayoutPanel pnlListContent;
        private System.Windows.Forms.DataGridView dgvList;
        private System.Windows.Forms.TabPage tabAdd;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.DataGridView dgvAdd;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnRemoveAll;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button btnListRemove;
        private System.Windows.Forms.DataGridViewComboBoxColumn colAddStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAddUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn recipesListIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn stockIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource userLogBindingSource;
        private Database.FarmManageDataSetTableAdapters.UserLogTableAdapter userLogTableAdapter;

    }
}
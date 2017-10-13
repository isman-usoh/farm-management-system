namespace MainProject.UserInterface.Supplies
{
    partial class StockDetailForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StockDetailForm));
            this.pnlMain = new System.Windows.Forms.TableLayoutPanel();
            this.pnlFooter = new System.Windows.Forms.FlowLayoutPanel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.tcMain = new System.Windows.Forms.TabControl();
            this.tabDetail = new System.Windows.Forms.TabPage();
            this.gbxDetail = new System.Windows.Forms.GroupBox();
            this.pnlDetailContent = new System.Windows.Forms.TableLayoutPanel();
            this.lblDisease = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblUnit = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.cbxStockType = new System.Windows.Forms.ComboBox();
            this.stockBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.farmManageDataSet = new MainProject.Database.FarmManageDataSet();
            this.tbxUnit = new System.Windows.Forms.TextBox();
            this.tbxDescription = new System.Windows.Forms.TextBox();
            this.tbxSuppliesName = new System.Windows.Forms.TextBox();
            this.tabAddHistory = new System.Windows.Forms.TabPage();
            this.gbxAddHistory = new System.Windows.Forms.GroupBox();
            this.pnlHistoryContent = new System.Windows.Forms.TableLayoutPanel();
            this.pnlHistoryOption = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAddStock = new System.Windows.Forms.Button();
            this.dgvAddHistory = new System.Windows.Forms.DataGridView();
            this.colAddID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAddUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAddAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAddDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAddBy = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.usersViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stockAddListViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pnlAddHistoryFilter = new System.Windows.Forms.FlowLayoutPanel();
            this.lblMonth = new System.Windows.Forms.Label();
            this.cbxAddMonth = new System.Windows.Forms.ComboBox();
            this.lblYear = new System.Windows.Forms.Label();
            this.cbxAddYear = new System.Windows.Forms.ComboBox();
            this.tabRemoveHistory = new System.Windows.Forms.TabPage();
            this.gbxRemoveHistory = new System.Windows.Forms.GroupBox();
            this.pnlRemoveHistoryContent = new System.Windows.Forms.TableLayoutPanel();
            this.pnlRemoveHistoryFilter = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxRemoveMonth = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxRemoveYear = new System.Windows.Forms.ComboBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnRemoveStock = new System.Windows.Forms.Button();
            this.dgvRemoveHistory = new System.Windows.Forms.DataGridView();
            this.coRemoveID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRemoveUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRemoveDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRemoveBy = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.colRemoveFromType = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.stockRemoveListViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stockTableAdapter = new MainProject.Database.FarmManageDataSetTableAdapters.StockTableAdapter();
            this.usersViewTableAdapter = new MainProject.Database.FarmManageDataSetTableAdapters.UsersViewTableAdapter();
            this.stockAddListViewTableAdapter = new MainProject.Database.FarmManageDataSetTableAdapters.StockAddListViewTableAdapter();
            this.stockRemoveListViewTableAdapter = new MainProject.Database.FarmManageDataSetTableAdapters.StockRemoveListViewTableAdapter();
            this.pnlMain.SuspendLayout();
            this.pnlFooter.SuspendLayout();
            this.tcMain.SuspendLayout();
            this.tabDetail.SuspendLayout();
            this.gbxDetail.SuspendLayout();
            this.pnlDetailContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stockBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.farmManageDataSet)).BeginInit();
            this.tabAddHistory.SuspendLayout();
            this.gbxAddHistory.SuspendLayout();
            this.pnlHistoryContent.SuspendLayout();
            this.pnlHistoryOption.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAddHistory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockAddListViewBindingSource)).BeginInit();
            this.pnlAddHistoryFilter.SuspendLayout();
            this.tabRemoveHistory.SuspendLayout();
            this.gbxRemoveHistory.SuspendLayout();
            this.pnlRemoveHistoryContent.SuspendLayout();
            this.pnlRemoveHistoryFilter.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRemoveHistory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockRemoveListViewBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
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
            this.pnlMain.Size = new System.Drawing.Size(594, 521);
            this.pnlMain.TabIndex = 0;
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
            this.lblTitle.Text = "รายละเอียดพัสดุ";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tcMain
            // 
            this.tcMain.Controls.Add(this.tabDetail);
            this.tcMain.Controls.Add(this.tabAddHistory);
            this.tcMain.Controls.Add(this.tabRemoveHistory);
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
            this.gbxDetail.Controls.Add(this.pnlDetailContent);
            this.gbxDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbxDetail.Location = new System.Drawing.Point(3, 3);
            this.gbxDetail.Name = "gbxDetail";
            this.gbxDetail.Size = new System.Drawing.Size(572, 379);
            this.gbxDetail.TabIndex = 0;
            this.gbxDetail.TabStop = false;
            this.gbxDetail.Text = "รายละเอียด";
            // 
            // pnlDetailContent
            // 
            this.pnlDetailContent.ColumnCount = 4;
            this.pnlDetailContent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.pnlDetailContent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.pnlDetailContent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55F));
            this.pnlDetailContent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.pnlDetailContent.Controls.Add(this.lblDisease, 1, 1);
            this.pnlDetailContent.Controls.Add(this.lblDate, 1, 3);
            this.pnlDetailContent.Controls.Add(this.lblUnit, 1, 5);
            this.pnlDetailContent.Controls.Add(this.lblDescription, 1, 7);
            this.pnlDetailContent.Controls.Add(this.cbxStockType, 2, 3);
            this.pnlDetailContent.Controls.Add(this.tbxUnit, 2, 5);
            this.pnlDetailContent.Controls.Add(this.tbxDescription, 2, 7);
            this.pnlDetailContent.Controls.Add(this.tbxSuppliesName, 2, 1);
            this.pnlDetailContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDetailContent.Location = new System.Drawing.Point(3, 16);
            this.pnlDetailContent.Name = "pnlDetailContent";
            this.pnlDetailContent.RowCount = 13;
            this.pnlDetailContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.pnlDetailContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.pnlDetailContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 3F));
            this.pnlDetailContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.pnlDetailContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 3F));
            this.pnlDetailContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.pnlDetailContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 3F));
            this.pnlDetailContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.pnlDetailContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 3F));
            this.pnlDetailContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.pnlDetailContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 3F));
            this.pnlDetailContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.pnlDetailContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlDetailContent.Size = new System.Drawing.Size(566, 360);
            this.pnlDetailContent.TabIndex = 1;
            // 
            // lblDisease
            // 
            this.lblDisease.AutoSize = true;
            this.lblDisease.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDisease.Location = new System.Drawing.Point(59, 10);
            this.lblDisease.Name = "lblDisease";
            this.lblDisease.Size = new System.Drawing.Size(135, 25);
            this.lblDisease.TabIndex = 0;
            this.lblDisease.Text = "ชื่อพัสดุ *";
            this.lblDisease.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDate.Location = new System.Drawing.Point(59, 38);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(135, 25);
            this.lblDate.TabIndex = 1;
            this.lblDate.Text = "ประเภท *";
            this.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblUnit
            // 
            this.lblUnit.AutoSize = true;
            this.lblUnit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblUnit.Location = new System.Drawing.Point(59, 66);
            this.lblUnit.Name = "lblUnit";
            this.lblUnit.Size = new System.Drawing.Size(135, 25);
            this.lblUnit.TabIndex = 2;
            this.lblUnit.Text = "คงเหลือ *";
            this.lblUnit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDescription.Location = new System.Drawing.Point(59, 94);
            this.lblDescription.Name = "lblDescription";
            this.pnlDetailContent.SetRowSpan(this.lblDescription, 5);
            this.lblDescription.Size = new System.Drawing.Size(135, 81);
            this.lblDescription.TabIndex = 3;
            this.lblDescription.Text = "รายละเอียด";
            this.lblDescription.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbxStockType
            // 
            this.cbxStockType.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.stockBindingSource, "Type", true));
            this.cbxStockType.DisplayMember = "Value";
            this.cbxStockType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbxStockType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxStockType.FormattingEnabled = true;
            this.cbxStockType.Location = new System.Drawing.Point(200, 41);
            this.cbxStockType.Name = "cbxStockType";
            this.cbxStockType.Size = new System.Drawing.Size(305, 21);
            this.cbxStockType.TabIndex = 5;
            this.cbxStockType.ValueMember = "Key";
            // 
            // stockBindingSource
            // 
            this.stockBindingSource.DataMember = "Stock";
            this.stockBindingSource.DataSource = this.farmManageDataSet;
            // 
            // farmManageDataSet
            // 
            this.farmManageDataSet.DataSetName = "FarmManageDataSet";
            this.farmManageDataSet.Locale = new System.Globalization.CultureInfo("en");
            this.farmManageDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbxUnit
            // 
            this.tbxUnit.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.stockBindingSource, "Unit", true));
            this.tbxUnit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxUnit.Location = new System.Drawing.Point(200, 69);
            this.tbxUnit.Name = "tbxUnit";
            this.tbxUnit.ReadOnly = true;
            this.tbxUnit.Size = new System.Drawing.Size(305, 20);
            this.tbxUnit.TabIndex = 4;
            this.tbxUnit.Text = "0";
            this.tbxUnit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxUnit_KeyPress);
            this.tbxUnit.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbxUnit_KeyUp);
            // 
            // tbxDescription
            // 
            this.tbxDescription.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.stockBindingSource, "Description", true));
            this.tbxDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxDescription.Location = new System.Drawing.Point(200, 97);
            this.tbxDescription.MaxLength = 512;
            this.tbxDescription.Multiline = true;
            this.tbxDescription.Name = "tbxDescription";
            this.pnlDetailContent.SetRowSpan(this.tbxDescription, 5);
            this.tbxDescription.Size = new System.Drawing.Size(305, 75);
            this.tbxDescription.TabIndex = 7;
            // 
            // tbxSuppliesName
            // 
            this.tbxSuppliesName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.stockBindingSource, "Name", true));
            this.tbxSuppliesName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxSuppliesName.Location = new System.Drawing.Point(200, 13);
            this.tbxSuppliesName.MaxLength = 32;
            this.tbxSuppliesName.Name = "tbxSuppliesName";
            this.tbxSuppliesName.Size = new System.Drawing.Size(305, 20);
            this.tbxSuppliesName.TabIndex = 8;
            // 
            // tabAddHistory
            // 
            this.tabAddHistory.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabAddHistory.Controls.Add(this.gbxAddHistory);
            this.tabAddHistory.Location = new System.Drawing.Point(4, 22);
            this.tabAddHistory.Name = "tabAddHistory";
            this.tabAddHistory.Padding = new System.Windows.Forms.Padding(3);
            this.tabAddHistory.Size = new System.Drawing.Size(578, 385);
            this.tabAddHistory.TabIndex = 2;
            this.tabAddHistory.Text = "ประวัติการเพิ่ม";
            // 
            // gbxAddHistory
            // 
            this.gbxAddHistory.Controls.Add(this.pnlHistoryContent);
            this.gbxAddHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbxAddHistory.Location = new System.Drawing.Point(3, 3);
            this.gbxAddHistory.Name = "gbxAddHistory";
            this.gbxAddHistory.Size = new System.Drawing.Size(572, 379);
            this.gbxAddHistory.TabIndex = 0;
            this.gbxAddHistory.TabStop = false;
            this.gbxAddHistory.Text = "ประวัติการเพิ่ม";
            // 
            // pnlHistoryContent
            // 
            this.pnlHistoryContent.ColumnCount = 1;
            this.pnlHistoryContent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlHistoryContent.Controls.Add(this.pnlHistoryOption, 0, 2);
            this.pnlHistoryContent.Controls.Add(this.dgvAddHistory, 0, 1);
            this.pnlHistoryContent.Controls.Add(this.pnlAddHistoryFilter, 0, 0);
            this.pnlHistoryContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlHistoryContent.Location = new System.Drawing.Point(3, 16);
            this.pnlHistoryContent.Name = "pnlHistoryContent";
            this.pnlHistoryContent.RowCount = 3;
            this.pnlHistoryContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.pnlHistoryContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlHistoryContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.pnlHistoryContent.Size = new System.Drawing.Size(566, 360);
            this.pnlHistoryContent.TabIndex = 0;
            // 
            // pnlHistoryOption
            // 
            this.pnlHistoryOption.Controls.Add(this.btnAddStock);
            this.pnlHistoryOption.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlHistoryOption.Location = new System.Drawing.Point(3, 329);
            this.pnlHistoryOption.Name = "pnlHistoryOption";
            this.pnlHistoryOption.Size = new System.Drawing.Size(560, 28);
            this.pnlHistoryOption.TabIndex = 0;
            // 
            // btnAddStock
            // 
            this.btnAddStock.Location = new System.Drawing.Point(3, 3);
            this.btnAddStock.Name = "btnAddStock";
            this.btnAddStock.Size = new System.Drawing.Size(120, 23);
            this.btnAddStock.TabIndex = 0;
            this.btnAddStock.Text = "เพิ่มพัสดุเข้าคลัง";
            this.btnAddStock.UseVisualStyleBackColor = true;
            this.btnAddStock.Click += new System.EventHandler(this.btnAddStock_Click);
            // 
            // dgvAddHistory
            // 
            this.dgvAddHistory.AllowUserToAddRows = false;
            this.dgvAddHistory.AllowUserToDeleteRows = false;
            this.dgvAddHistory.AutoGenerateColumns = false;
            this.dgvAddHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAddHistory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colAddID,
            this.colAddUnit,
            this.colAddAmount,
            this.colAddDate,
            this.colAddBy});
            this.dgvAddHistory.DataSource = this.stockAddListViewBindingSource;
            this.dgvAddHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAddHistory.Location = new System.Drawing.Point(3, 37);
            this.dgvAddHistory.Name = "dgvAddHistory";
            this.dgvAddHistory.ReadOnly = true;
            this.dgvAddHistory.Size = new System.Drawing.Size(560, 286);
            this.dgvAddHistory.TabIndex = 1;
            this.dgvAddHistory.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvAddHistory_CellMouseDoubleClick);
            // 
            // colAddID
            // 
            this.colAddID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colAddID.DataPropertyName = "StockAddListID";
            this.colAddID.HeaderText = "ID";
            this.colAddID.MinimumWidth = 50;
            this.colAddID.Name = "colAddID";
            this.colAddID.ReadOnly = true;
            this.colAddID.Width = 50;
            // 
            // colAddUnit
            // 
            this.colAddUnit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colAddUnit.DataPropertyName = "Unit";
            dataGridViewCellStyle1.Format = "N2";
            dataGridViewCellStyle1.NullValue = "0";
            this.colAddUnit.DefaultCellStyle = dataGridViewCellStyle1;
            this.colAddUnit.HeaderText = "จำนวน";
            this.colAddUnit.Name = "colAddUnit";
            this.colAddUnit.ReadOnly = true;
            // 
            // colAddAmount
            // 
            this.colAddAmount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colAddAmount.DataPropertyName = "TotalAmount";
            dataGridViewCellStyle2.Format = "C2";
            dataGridViewCellStyle2.NullValue = "0";
            this.colAddAmount.DefaultCellStyle = dataGridViewCellStyle2;
            this.colAddAmount.HeaderText = "จำนวนเงิน";
            this.colAddAmount.Name = "colAddAmount";
            this.colAddAmount.ReadOnly = true;
            // 
            // colAddDate
            // 
            this.colAddDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colAddDate.DataPropertyName = "Date";
            dataGridViewCellStyle3.Format = "D";
            dataGridViewCellStyle3.NullValue = null;
            this.colAddDate.DefaultCellStyle = dataGridViewCellStyle3;
            this.colAddDate.HeaderText = "วันที";
            this.colAddDate.Name = "colAddDate";
            this.colAddDate.ReadOnly = true;
            // 
            // colAddBy
            // 
            this.colAddBy.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colAddBy.DataPropertyName = "StockAddBy";
            this.colAddBy.DataSource = this.usersViewBindingSource;
            this.colAddBy.DisplayMember = "Name";
            this.colAddBy.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.colAddBy.HeaderText = "เพิ่มโดย";
            this.colAddBy.Name = "colAddBy";
            this.colAddBy.ReadOnly = true;
            this.colAddBy.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colAddBy.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colAddBy.ValueMember = "UserID";
            // 
            // usersViewBindingSource
            // 
            this.usersViewBindingSource.DataMember = "UsersView";
            this.usersViewBindingSource.DataSource = this.farmManageDataSet;
            // 
            // stockAddListViewBindingSource
            // 
            this.stockAddListViewBindingSource.DataMember = "StockAddListView";
            this.stockAddListViewBindingSource.DataSource = this.farmManageDataSet;
            // 
            // pnlAddHistoryFilter
            // 
            this.pnlAddHistoryFilter.Controls.Add(this.lblMonth);
            this.pnlAddHistoryFilter.Controls.Add(this.cbxAddMonth);
            this.pnlAddHistoryFilter.Controls.Add(this.lblYear);
            this.pnlAddHistoryFilter.Controls.Add(this.cbxAddYear);
            this.pnlAddHistoryFilter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlAddHistoryFilter.Location = new System.Drawing.Point(3, 3);
            this.pnlAddHistoryFilter.Name = "pnlAddHistoryFilter";
            this.pnlAddHistoryFilter.Size = new System.Drawing.Size(560, 28);
            this.pnlAddHistoryFilter.TabIndex = 2;
            // 
            // lblMonth
            // 
            this.lblMonth.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblMonth.Location = new System.Drawing.Point(3, 0);
            this.lblMonth.Name = "lblMonth";
            this.lblMonth.Size = new System.Drawing.Size(120, 23);
            this.lblMonth.TabIndex = 0;
            this.lblMonth.Text = "เดือน";
            this.lblMonth.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbxAddMonth
            // 
            this.cbxAddMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxAddMonth.FormattingEnabled = true;
            this.cbxAddMonth.Location = new System.Drawing.Point(129, 3);
            this.cbxAddMonth.Name = "cbxAddMonth";
            this.cbxAddMonth.Size = new System.Drawing.Size(120, 21);
            this.cbxAddMonth.TabIndex = 2;
            this.cbxAddMonth.SelectedIndexChanged += new System.EventHandler(this.cbxAddMonth_SelectedIndexChanged);
            // 
            // lblYear
            // 
            this.lblYear.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblYear.Location = new System.Drawing.Point(255, 0);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(80, 23);
            this.lblYear.TabIndex = 1;
            this.lblYear.Text = "ปี";
            this.lblYear.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbxAddYear
            // 
            this.cbxAddYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxAddYear.FormattingEnabled = true;
            this.cbxAddYear.Location = new System.Drawing.Point(341, 3);
            this.cbxAddYear.Name = "cbxAddYear";
            this.cbxAddYear.Size = new System.Drawing.Size(120, 21);
            this.cbxAddYear.TabIndex = 3;
            this.cbxAddYear.SelectedIndexChanged += new System.EventHandler(this.cbxAddYear_SelectedIndexChanged);
            // 
            // tabRemoveHistory
            // 
            this.tabRemoveHistory.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabRemoveHistory.Controls.Add(this.gbxRemoveHistory);
            this.tabRemoveHistory.Location = new System.Drawing.Point(4, 22);
            this.tabRemoveHistory.Name = "tabRemoveHistory";
            this.tabRemoveHistory.Padding = new System.Windows.Forms.Padding(3);
            this.tabRemoveHistory.Size = new System.Drawing.Size(578, 385);
            this.tabRemoveHistory.TabIndex = 3;
            this.tabRemoveHistory.Text = "ประวัติการเบิก";
            // 
            // gbxRemoveHistory
            // 
            this.gbxRemoveHistory.Controls.Add(this.pnlRemoveHistoryContent);
            this.gbxRemoveHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbxRemoveHistory.Location = new System.Drawing.Point(3, 3);
            this.gbxRemoveHistory.Name = "gbxRemoveHistory";
            this.gbxRemoveHistory.Size = new System.Drawing.Size(572, 379);
            this.gbxRemoveHistory.TabIndex = 1;
            this.gbxRemoveHistory.TabStop = false;
            this.gbxRemoveHistory.Text = "ประวัติการเพิ่ม";
            // 
            // pnlRemoveHistoryContent
            // 
            this.pnlRemoveHistoryContent.ColumnCount = 1;
            this.pnlRemoveHistoryContent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlRemoveHistoryContent.Controls.Add(this.pnlRemoveHistoryFilter, 0, 0);
            this.pnlRemoveHistoryContent.Controls.Add(this.flowLayoutPanel1, 0, 2);
            this.pnlRemoveHistoryContent.Controls.Add(this.dgvRemoveHistory, 0, 1);
            this.pnlRemoveHistoryContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRemoveHistoryContent.Location = new System.Drawing.Point(3, 16);
            this.pnlRemoveHistoryContent.Name = "pnlRemoveHistoryContent";
            this.pnlRemoveHistoryContent.RowCount = 3;
            this.pnlRemoveHistoryContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.pnlRemoveHistoryContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlRemoveHistoryContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.pnlRemoveHistoryContent.Size = new System.Drawing.Size(566, 360);
            this.pnlRemoveHistoryContent.TabIndex = 0;
            // 
            // pnlRemoveHistoryFilter
            // 
            this.pnlRemoveHistoryFilter.Controls.Add(this.label1);
            this.pnlRemoveHistoryFilter.Controls.Add(this.cbxRemoveMonth);
            this.pnlRemoveHistoryFilter.Controls.Add(this.label2);
            this.pnlRemoveHistoryFilter.Controls.Add(this.cbxRemoveYear);
            this.pnlRemoveHistoryFilter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRemoveHistoryFilter.Location = new System.Drawing.Point(3, 3);
            this.pnlRemoveHistoryFilter.Name = "pnlRemoveHistoryFilter";
            this.pnlRemoveHistoryFilter.Size = new System.Drawing.Size(560, 28);
            this.pnlRemoveHistoryFilter.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "เดือน";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbxRemoveMonth
            // 
            this.cbxRemoveMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxRemoveMonth.FormattingEnabled = true;
            this.cbxRemoveMonth.Location = new System.Drawing.Point(129, 3);
            this.cbxRemoveMonth.Name = "cbxRemoveMonth";
            this.cbxRemoveMonth.Size = new System.Drawing.Size(120, 21);
            this.cbxRemoveMonth.TabIndex = 2;
            this.cbxRemoveMonth.SelectedIndexChanged += new System.EventHandler(this.cbxRemoveMonth_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Location = new System.Drawing.Point(255, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "ปี";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbxRemoveYear
            // 
            this.cbxRemoveYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxRemoveYear.FormattingEnabled = true;
            this.cbxRemoveYear.Location = new System.Drawing.Point(341, 3);
            this.cbxRemoveYear.Name = "cbxRemoveYear";
            this.cbxRemoveYear.Size = new System.Drawing.Size(120, 21);
            this.cbxRemoveYear.TabIndex = 3;
            this.cbxRemoveYear.SelectedIndexChanged += new System.EventHandler(this.cbxRemoveYear_SelectedIndexChanged);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnRemoveStock);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 329);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(560, 28);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // btnRemoveStock
            // 
            this.btnRemoveStock.Location = new System.Drawing.Point(3, 3);
            this.btnRemoveStock.Name = "btnRemoveStock";
            this.btnRemoveStock.Size = new System.Drawing.Size(120, 23);
            this.btnRemoveStock.TabIndex = 0;
            this.btnRemoveStock.Text = "เบิกพัสดุ";
            this.btnRemoveStock.UseVisualStyleBackColor = true;
            this.btnRemoveStock.Click += new System.EventHandler(this.btnRemoveStock_Click);
            // 
            // dgvRemoveHistory
            // 
            this.dgvRemoveHistory.AllowUserToAddRows = false;
            this.dgvRemoveHistory.AllowUserToDeleteRows = false;
            this.dgvRemoveHistory.AutoGenerateColumns = false;
            this.dgvRemoveHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRemoveHistory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.coRemoveID,
            this.colRemoveUnit,
            this.colRemoveDate,
            this.colRemoveBy,
            this.colRemoveFromType});
            this.dgvRemoveHistory.DataSource = this.stockRemoveListViewBindingSource;
            this.dgvRemoveHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRemoveHistory.Location = new System.Drawing.Point(3, 37);
            this.dgvRemoveHistory.Name = "dgvRemoveHistory";
            this.dgvRemoveHistory.ReadOnly = true;
            this.dgvRemoveHistory.Size = new System.Drawing.Size(560, 286);
            this.dgvRemoveHistory.TabIndex = 1;
            this.dgvRemoveHistory.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvRemoveHistory_CellMouseDoubleClick);
            // 
            // coRemoveID
            // 
            this.coRemoveID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.coRemoveID.DataPropertyName = "StockRemoveListID";
            this.coRemoveID.HeaderText = "ID";
            this.coRemoveID.MinimumWidth = 50;
            this.coRemoveID.Name = "coRemoveID";
            this.coRemoveID.ReadOnly = true;
            this.coRemoveID.Width = 50;
            // 
            // colRemoveUnit
            // 
            this.colRemoveUnit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colRemoveUnit.DataPropertyName = "Unit";
            dataGridViewCellStyle4.Format = "N2";
            dataGridViewCellStyle4.NullValue = "0";
            this.colRemoveUnit.DefaultCellStyle = dataGridViewCellStyle4;
            this.colRemoveUnit.HeaderText = "จำนวน";
            this.colRemoveUnit.Name = "colRemoveUnit";
            this.colRemoveUnit.ReadOnly = true;
            // 
            // colRemoveDate
            // 
            this.colRemoveDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colRemoveDate.DataPropertyName = "Date";
            dataGridViewCellStyle5.Format = "D";
            dataGridViewCellStyle5.NullValue = null;
            this.colRemoveDate.DefaultCellStyle = dataGridViewCellStyle5;
            this.colRemoveDate.HeaderText = "วันที";
            this.colRemoveDate.Name = "colRemoveDate";
            this.colRemoveDate.ReadOnly = true;
            // 
            // colRemoveBy
            // 
            this.colRemoveBy.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colRemoveBy.DataPropertyName = "StockRemoveBy";
            this.colRemoveBy.DataSource = this.usersViewBindingSource;
            this.colRemoveBy.DisplayMember = "Name";
            this.colRemoveBy.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.colRemoveBy.HeaderText = "เบิกโดย";
            this.colRemoveBy.Name = "colRemoveBy";
            this.colRemoveBy.ReadOnly = true;
            this.colRemoveBy.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colRemoveBy.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colRemoveBy.ValueMember = "UserID";
            // 
            // colRemoveFromType
            // 
            this.colRemoveFromType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colRemoveFromType.DataPropertyName = "RemoveFromType";
            this.colRemoveFromType.HeaderText = "วิธิการเบิก";
            this.colRemoveFromType.Name = "colRemoveFromType";
            this.colRemoveFromType.ReadOnly = true;
            this.colRemoveFromType.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colRemoveFromType.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // stockRemoveListViewBindingSource
            // 
            this.stockRemoveListViewBindingSource.DataMember = "StockRemoveListView";
            this.stockRemoveListViewBindingSource.DataSource = this.farmManageDataSet;
            // 
            // stockTableAdapter
            // 
            this.stockTableAdapter.ClearBeforeFill = true;
            // 
            // usersViewTableAdapter
            // 
            this.usersViewTableAdapter.ClearBeforeFill = true;
            // 
            // stockAddListViewTableAdapter
            // 
            this.stockAddListViewTableAdapter.ClearBeforeFill = true;
            // 
            // stockRemoveListViewTableAdapter
            // 
            this.stockRemoveListViewTableAdapter.ClearBeforeFill = true;
            // 
            // StockDetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 521);
            this.Controls.Add(this.pnlMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StockDetailForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "รายละเอียดพัสดุ";
            this.Load += new System.EventHandler(this.SuppliesDetailForm_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.pnlFooter.ResumeLayout(false);
            this.tcMain.ResumeLayout(false);
            this.tabDetail.ResumeLayout(false);
            this.gbxDetail.ResumeLayout(false);
            this.pnlDetailContent.ResumeLayout(false);
            this.pnlDetailContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stockBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.farmManageDataSet)).EndInit();
            this.tabAddHistory.ResumeLayout(false);
            this.gbxAddHistory.ResumeLayout(false);
            this.pnlHistoryContent.ResumeLayout(false);
            this.pnlHistoryOption.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAddHistory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockAddListViewBindingSource)).EndInit();
            this.pnlAddHistoryFilter.ResumeLayout(false);
            this.tabRemoveHistory.ResumeLayout(false);
            this.gbxRemoveHistory.ResumeLayout(false);
            this.pnlRemoveHistoryContent.ResumeLayout(false);
            this.pnlRemoveHistoryFilter.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRemoveHistory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockRemoveListViewBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel pnlMain;
        private System.Windows.Forms.FlowLayoutPanel pnlFooter;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TabControl tcMain;
        private System.Windows.Forms.TabPage tabDetail;
        private System.Windows.Forms.TabPage tabAddHistory;
        private System.Windows.Forms.GroupBox gbxDetail;
        private System.Windows.Forms.TableLayoutPanel pnlDetailContent;
        private System.Windows.Forms.Label lblDisease;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblUnit;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.ComboBox cbxStockType;
        private System.Windows.Forms.TextBox tbxUnit;
        private System.Windows.Forms.TextBox tbxDescription;
        private System.Windows.Forms.TextBox tbxSuppliesName;
        private System.Windows.Forms.Button btnSave;
        private Database.FarmManageDataSet farmManageDataSet;
        private System.Windows.Forms.BindingSource stockBindingSource;
        private Database.FarmManageDataSetTableAdapters.StockTableAdapter stockTableAdapter;
        private System.Windows.Forms.BindingSource usersViewBindingSource;
        private Database.FarmManageDataSetTableAdapters.UsersViewTableAdapter usersViewTableAdapter;
        private System.Windows.Forms.TabPage tabRemoveHistory;
        private System.Windows.Forms.GroupBox gbxRemoveHistory;
        private System.Windows.Forms.TableLayoutPanel pnlRemoveHistoryContent;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnRemoveStock;
        private System.Windows.Forms.DataGridView dgvRemoveHistory;
        private System.Windows.Forms.GroupBox gbxAddHistory;
        private System.Windows.Forms.TableLayoutPanel pnlHistoryContent;
        private System.Windows.Forms.FlowLayoutPanel pnlHistoryOption;
        private System.Windows.Forms.Button btnAddStock;
        private System.Windows.Forms.DataGridView dgvAddHistory;
        private System.Windows.Forms.FlowLayoutPanel pnlAddHistoryFilter;
        private System.Windows.Forms.Label lblMonth;
        private System.Windows.Forms.ComboBox cbxAddMonth;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.ComboBox cbxAddYear;
        private System.Windows.Forms.FlowLayoutPanel pnlRemoveHistoryFilter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxRemoveMonth;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxRemoveYear;
        private System.Windows.Forms.BindingSource stockAddListViewBindingSource;
        private Database.FarmManageDataSetTableAdapters.StockAddListViewTableAdapter stockAddListViewTableAdapter;
        private System.Windows.Forms.BindingSource stockRemoveListViewBindingSource;
        private Database.FarmManageDataSetTableAdapters.StockRemoveListViewTableAdapter stockRemoveListViewTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAddID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAddUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAddAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAddDate;
        private System.Windows.Forms.DataGridViewComboBoxColumn colAddBy;
        private System.Windows.Forms.DataGridViewTextBoxColumn coRemoveID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRemoveUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRemoveDate;
        private System.Windows.Forms.DataGridViewComboBoxColumn colRemoveBy;
        private System.Windows.Forms.DataGridViewComboBoxColumn colRemoveFromType;
    }
}
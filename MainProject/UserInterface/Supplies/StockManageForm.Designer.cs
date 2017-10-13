namespace MainProject.UserInterface.Supplies
{
    partial class StockManageForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StockManageForm));
            this.pnlMain = new System.Windows.Forms.TableLayoutPanel();
            this.tcMain = new System.Windows.Forms.TabControl();
            this.tabDetail = new System.Windows.Forms.TabPage();
            this.gbxDetail = new System.Windows.Forms.GroupBox();
            this.pnlContent = new System.Windows.Forms.TableLayoutPanel();
            this.pnlContentOption = new System.Windows.Forms.FlowLayoutPanel();
            this.btnNewStock = new System.Windows.Forms.Button();
            this.dgvList = new System.Windows.Forms.DataGridView();
            this.pnlFilter = new System.Windows.Forms.FlowLayoutPanel();
            this.lblType = new System.Windows.Forms.Label();
            this.cbxType = new System.Windows.Forms.ComboBox();
            this.tabAddHistory = new System.Windows.Forms.TabPage();
            this.gbxAddHistory = new System.Windows.Forms.GroupBox();
            this.pnlAddHistoryContent = new System.Windows.Forms.TableLayoutPanel();
            this.pnlRemoveHistoryFilter = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxAddMonth = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxAddYear = new System.Windows.Forms.ComboBox();
            this.dgvAddHistory = new System.Windows.Forms.DataGridView();
            this.pnlAddHistoryOption = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAddStock = new System.Windows.Forms.Button();
            this.tabRemoveHostory = new System.Windows.Forms.TabPage();
            this.gbxRemoveHistory = new System.Windows.Forms.GroupBox();
            this.pnlRemoveHistoryContent = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.cbxRemoveMonth = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbxRemoveYear = new System.Windows.Forms.ComboBox();
            this.dgvRemoveHistory = new System.Windows.Forms.DataGridView();
            this.addRemoveID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRemoveBy = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.colRemoveDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlRemoveContentOption = new System.Windows.Forms.FlowLayoutPanel();
            this.btnRemoveStock = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlFooter = new System.Windows.Forms.TableLayoutPanel();
            this.pnlRightFooter = new System.Windows.Forms.FlowLayoutPanel();
            this.btnClose = new System.Windows.Forms.Button();
            this.pnlFooterLeft = new System.Windows.Forms.FlowLayoutPanel();
            this.colStockID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colType = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.colUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.farmManageDataSet = new MainProject.Database.FarmManageDataSet();
            this.colAddID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAddDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAddTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAddBy = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.usersViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stockAddBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colRemoveFromType = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.stockRemoveBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stockTableAdapter = new MainProject.Database.FarmManageDataSetTableAdapters.StockTableAdapter();
            this.stockAddTableAdapter = new MainProject.Database.FarmManageDataSetTableAdapters.StockAddTableAdapter();
            this.usersViewTableAdapter = new MainProject.Database.FarmManageDataSetTableAdapters.UsersViewTableAdapter();
            this.stockRemoveTableAdapter = new MainProject.Database.FarmManageDataSetTableAdapters.StockRemoveTableAdapter();
            this.pnlMain.SuspendLayout();
            this.tcMain.SuspendLayout();
            this.tabDetail.SuspendLayout();
            this.gbxDetail.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.pnlContentOption.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            this.pnlFilter.SuspendLayout();
            this.tabAddHistory.SuspendLayout();
            this.gbxAddHistory.SuspendLayout();
            this.pnlAddHistoryContent.SuspendLayout();
            this.pnlRemoveHistoryFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAddHistory)).BeginInit();
            this.pnlAddHistoryOption.SuspendLayout();
            this.tabRemoveHostory.SuspendLayout();
            this.gbxRemoveHistory.SuspendLayout();
            this.pnlRemoveHistoryContent.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRemoveHistory)).BeginInit();
            this.pnlRemoveContentOption.SuspendLayout();
            this.pnlFooter.SuspendLayout();
            this.pnlRightFooter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stockBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.farmManageDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockAddBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockRemoveBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
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
            this.pnlMain.Size = new System.Drawing.Size(594, 521);
            this.pnlMain.TabIndex = 0;
            // 
            // tcMain
            // 
            this.tcMain.Controls.Add(this.tabDetail);
            this.tcMain.Controls.Add(this.tabAddHistory);
            this.tcMain.Controls.Add(this.tabRemoveHostory);
            this.tcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcMain.Location = new System.Drawing.Point(4, 65);
            this.tcMain.Name = "tcMain";
            this.tcMain.SelectedIndex = 0;
            this.tcMain.Size = new System.Drawing.Size(586, 411);
            this.tcMain.TabIndex = 4;
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
            this.tabDetail.Text = "ข้อมูลพัสดุ";
            // 
            // gbxDetail
            // 
            this.gbxDetail.Controls.Add(this.pnlContent);
            this.gbxDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbxDetail.Location = new System.Drawing.Point(3, 3);
            this.gbxDetail.Name = "gbxDetail";
            this.gbxDetail.Size = new System.Drawing.Size(572, 379);
            this.gbxDetail.TabIndex = 0;
            this.gbxDetail.TabStop = false;
            this.gbxDetail.Text = "ข้อมูลพัสดุ";
            // 
            // pnlContent
            // 
            this.pnlContent.ColumnCount = 1;
            this.pnlContent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlContent.Controls.Add(this.pnlContentOption, 0, 2);
            this.pnlContent.Controls.Add(this.dgvList, 0, 1);
            this.pnlContent.Controls.Add(this.pnlFilter, 0, 0);
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(3, 16);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.RowCount = 3;
            this.pnlContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.pnlContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.pnlContent.Size = new System.Drawing.Size(566, 360);
            this.pnlContent.TabIndex = 4;
            // 
            // pnlContentOption
            // 
            this.pnlContentOption.Controls.Add(this.btnNewStock);
            this.pnlContentOption.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContentOption.Location = new System.Drawing.Point(0, 332);
            this.pnlContentOption.Margin = new System.Windows.Forms.Padding(0);
            this.pnlContentOption.Name = "pnlContentOption";
            this.pnlContentOption.Size = new System.Drawing.Size(566, 28);
            this.pnlContentOption.TabIndex = 5;
            // 
            // btnNewStock
            // 
            this.btnNewStock.Location = new System.Drawing.Point(3, 3);
            this.btnNewStock.Name = "btnNewStock";
            this.btnNewStock.Size = new System.Drawing.Size(100, 23);
            this.btnNewStock.TabIndex = 1;
            this.btnNewStock.Text = "เพิ่มรายการ";
            this.btnNewStock.UseVisualStyleBackColor = true;
            this.btnNewStock.Click += new System.EventHandler(this.newStock_Click);
            // 
            // dgvList
            // 
            this.dgvList.AllowUserToAddRows = false;
            this.dgvList.AllowUserToDeleteRows = false;
            this.dgvList.AutoGenerateColumns = false;
            this.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colStockID,
            this.colName,
            this.colType,
            this.colUnit});
            this.dgvList.DataSource = this.stockBindingSource;
            this.dgvList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvList.Location = new System.Drawing.Point(3, 43);
            this.dgvList.Name = "dgvList";
            this.dgvList.ReadOnly = true;
            this.dgvList.Size = new System.Drawing.Size(560, 286);
            this.dgvList.TabIndex = 1;
            this.dgvList.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvList_CellMouseDoubleClick);
            // 
            // pnlFilter
            // 
            this.pnlFilter.Controls.Add(this.lblType);
            this.pnlFilter.Controls.Add(this.cbxType);
            this.pnlFilter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFilter.Location = new System.Drawing.Point(3, 3);
            this.pnlFilter.Name = "pnlFilter";
            this.pnlFilter.Size = new System.Drawing.Size(560, 34);
            this.pnlFilter.TabIndex = 2;
            // 
            // lblType
            // 
            this.lblType.Location = new System.Drawing.Point(3, 0);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(120, 34);
            this.lblType.TabIndex = 0;
            this.lblType.Text = "ประเภท : ";
            this.lblType.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbxType
            // 
            this.cbxType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxType.FormattingEnabled = true;
            this.cbxType.Location = new System.Drawing.Point(132, 6);
            this.cbxType.Margin = new System.Windows.Forms.Padding(6);
            this.cbxType.Name = "cbxType";
            this.cbxType.Size = new System.Drawing.Size(150, 21);
            this.cbxType.TabIndex = 1;
            this.cbxType.SelectedIndexChanged += new System.EventHandler(this.cbxType_SelectedIndexChanged);
            // 
            // tabAddHistory
            // 
            this.tabAddHistory.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabAddHistory.Controls.Add(this.gbxAddHistory);
            this.tabAddHistory.Location = new System.Drawing.Point(4, 22);
            this.tabAddHistory.Name = "tabAddHistory";
            this.tabAddHistory.Padding = new System.Windows.Forms.Padding(3);
            this.tabAddHistory.Size = new System.Drawing.Size(578, 385);
            this.tabAddHistory.TabIndex = 1;
            this.tabAddHistory.Text = "ประวัติการเพิ่มพัสดุ";
            // 
            // gbxAddHistory
            // 
            this.gbxAddHistory.Controls.Add(this.pnlAddHistoryContent);
            this.gbxAddHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbxAddHistory.Location = new System.Drawing.Point(3, 3);
            this.gbxAddHistory.Name = "gbxAddHistory";
            this.gbxAddHistory.Size = new System.Drawing.Size(572, 379);
            this.gbxAddHistory.TabIndex = 2;
            this.gbxAddHistory.TabStop = false;
            this.gbxAddHistory.Text = "ประวัติการเพิ่มพัสดุ";
            // 
            // pnlAddHistoryContent
            // 
            this.pnlAddHistoryContent.ColumnCount = 1;
            this.pnlAddHistoryContent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlAddHistoryContent.Controls.Add(this.pnlRemoveHistoryFilter, 0, 0);
            this.pnlAddHistoryContent.Controls.Add(this.dgvAddHistory, 0, 1);
            this.pnlAddHistoryContent.Controls.Add(this.pnlAddHistoryOption, 0, 2);
            this.pnlAddHistoryContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlAddHistoryContent.Location = new System.Drawing.Point(3, 16);
            this.pnlAddHistoryContent.Name = "pnlAddHistoryContent";
            this.pnlAddHistoryContent.RowCount = 3;
            this.pnlAddHistoryContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.pnlAddHistoryContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlAddHistoryContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.pnlAddHistoryContent.Size = new System.Drawing.Size(566, 360);
            this.pnlAddHistoryContent.TabIndex = 0;
            // 
            // pnlRemoveHistoryFilter
            // 
            this.pnlRemoveHistoryFilter.Controls.Add(this.label1);
            this.pnlRemoveHistoryFilter.Controls.Add(this.cbxAddMonth);
            this.pnlRemoveHistoryFilter.Controls.Add(this.label2);
            this.pnlRemoveHistoryFilter.Controls.Add(this.cbxAddYear);
            this.pnlRemoveHistoryFilter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRemoveHistoryFilter.Location = new System.Drawing.Point(3, 3);
            this.pnlRemoveHistoryFilter.Name = "pnlRemoveHistoryFilter";
            this.pnlRemoveHistoryFilter.Size = new System.Drawing.Size(560, 28);
            this.pnlRemoveHistoryFilter.TabIndex = 4;
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
            // dgvAddHistory
            // 
            this.dgvAddHistory.AllowUserToAddRows = false;
            this.dgvAddHistory.AllowUserToDeleteRows = false;
            this.dgvAddHistory.AutoGenerateColumns = false;
            this.dgvAddHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAddHistory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colAddID,
            this.colAddDate,
            this.colAddTotal,
            this.colAddBy});
            this.dgvAddHistory.DataSource = this.stockAddBindingSource;
            this.dgvAddHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAddHistory.Location = new System.Drawing.Point(3, 37);
            this.dgvAddHistory.Name = "dgvAddHistory";
            this.dgvAddHistory.ReadOnly = true;
            this.dgvAddHistory.Size = new System.Drawing.Size(560, 292);
            this.dgvAddHistory.TabIndex = 2;
            this.dgvAddHistory.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvAddHistory_CellMouseDoubleClick);
            // 
            // pnlAddHistoryOption
            // 
            this.pnlAddHistoryOption.Controls.Add(this.btnAddStock);
            this.pnlAddHistoryOption.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlAddHistoryOption.Location = new System.Drawing.Point(0, 332);
            this.pnlAddHistoryOption.Margin = new System.Windows.Forms.Padding(0);
            this.pnlAddHistoryOption.Name = "pnlAddHistoryOption";
            this.pnlAddHistoryOption.Size = new System.Drawing.Size(566, 28);
            this.pnlAddHistoryOption.TabIndex = 3;
            // 
            // btnAddStock
            // 
            this.btnAddStock.Location = new System.Drawing.Point(3, 3);
            this.btnAddStock.Name = "btnAddStock";
            this.btnAddStock.Size = new System.Drawing.Size(100, 23);
            this.btnAddStock.TabIndex = 0;
            this.btnAddStock.Text = "เพิ่มพัสดุ";
            this.btnAddStock.UseVisualStyleBackColor = true;
            this.btnAddStock.Click += new System.EventHandler(this.addStock_Click);
            // 
            // tabRemoveHostory
            // 
            this.tabRemoveHostory.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabRemoveHostory.Controls.Add(this.gbxRemoveHistory);
            this.tabRemoveHostory.Location = new System.Drawing.Point(4, 22);
            this.tabRemoveHostory.Name = "tabRemoveHostory";
            this.tabRemoveHostory.Padding = new System.Windows.Forms.Padding(3);
            this.tabRemoveHostory.Size = new System.Drawing.Size(578, 385);
            this.tabRemoveHostory.TabIndex = 2;
            this.tabRemoveHostory.Text = "ประวัติการเบิกพัสดุ";
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
            this.gbxRemoveHistory.Text = "ประวัตการเบิก";
            // 
            // pnlRemoveHistoryContent
            // 
            this.pnlRemoveHistoryContent.ColumnCount = 1;
            this.pnlRemoveHistoryContent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlRemoveHistoryContent.Controls.Add(this.flowLayoutPanel1, 0, 0);
            this.pnlRemoveHistoryContent.Controls.Add(this.dgvRemoveHistory, 0, 1);
            this.pnlRemoveHistoryContent.Controls.Add(this.pnlRemoveContentOption, 0, 2);
            this.pnlRemoveHistoryContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRemoveHistoryContent.Location = new System.Drawing.Point(3, 16);
            this.pnlRemoveHistoryContent.Name = "pnlRemoveHistoryContent";
            this.pnlRemoveHistoryContent.RowCount = 3;
            this.pnlRemoveHistoryContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.pnlRemoveHistoryContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlRemoveHistoryContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.pnlRemoveHistoryContent.Size = new System.Drawing.Size(566, 360);
            this.pnlRemoveHistoryContent.TabIndex = 5;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.label3);
            this.flowLayoutPanel1.Controls.Add(this.cbxRemoveMonth);
            this.flowLayoutPanel1.Controls.Add(this.label4);
            this.flowLayoutPanel1.Controls.Add(this.cbxRemoveYear);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(560, 28);
            this.flowLayoutPanel1.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 23);
            this.label3.TabIndex = 0;
            this.label3.Text = "เดือน";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Location = new System.Drawing.Point(255, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 23);
            this.label4.TabIndex = 1;
            this.label4.Text = "ปี";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            // dgvRemoveHistory
            // 
            this.dgvRemoveHistory.AllowUserToAddRows = false;
            this.dgvRemoveHistory.AllowUserToDeleteRows = false;
            this.dgvRemoveHistory.AutoGenerateColumns = false;
            this.dgvRemoveHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRemoveHistory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.addRemoveID,
            this.colRemoveBy,
            this.colRemoveDate,
            this.colRemoveFromType});
            this.dgvRemoveHistory.DataSource = this.stockRemoveBindingSource;
            this.dgvRemoveHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRemoveHistory.Location = new System.Drawing.Point(3, 37);
            this.dgvRemoveHistory.Name = "dgvRemoveHistory";
            this.dgvRemoveHistory.ReadOnly = true;
            this.dgvRemoveHistory.Size = new System.Drawing.Size(560, 292);
            this.dgvRemoveHistory.TabIndex = 2;
            this.dgvRemoveHistory.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvRemoveHistory_CellMouseDoubleClick);
            // 
            // addRemoveID
            // 
            this.addRemoveID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.addRemoveID.DataPropertyName = "StockRemoveID";
            this.addRemoveID.HeaderText = "ID";
            this.addRemoveID.MinimumWidth = 50;
            this.addRemoveID.Name = "addRemoveID";
            this.addRemoveID.ReadOnly = true;
            this.addRemoveID.Width = 50;
            // 
            // colRemoveBy
            // 
            this.colRemoveBy.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colRemoveBy.DataPropertyName = "StockRemoveBy";
            this.colRemoveBy.DataSource = this.usersViewBindingSource;
            this.colRemoveBy.DisplayMember = "Name";
            this.colRemoveBy.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.colRemoveBy.HeaderText = "โดย";
            this.colRemoveBy.MinimumWidth = 50;
            this.colRemoveBy.Name = "colRemoveBy";
            this.colRemoveBy.ReadOnly = true;
            this.colRemoveBy.ValueMember = "UserID";
            // 
            // colRemoveDate
            // 
            this.colRemoveDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colRemoveDate.DataPropertyName = "Date";
            dataGridViewCellStyle3.Format = "D";
            dataGridViewCellStyle3.NullValue = null;
            this.colRemoveDate.DefaultCellStyle = dataGridViewCellStyle3;
            this.colRemoveDate.HeaderText = "วันที่";
            this.colRemoveDate.MinimumWidth = 50;
            this.colRemoveDate.Name = "colRemoveDate";
            this.colRemoveDate.ReadOnly = true;
            // 
            // pnlRemoveContentOption
            // 
            this.pnlRemoveContentOption.Controls.Add(this.btnRemoveStock);
            this.pnlRemoveContentOption.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRemoveContentOption.Location = new System.Drawing.Point(0, 332);
            this.pnlRemoveContentOption.Margin = new System.Windows.Forms.Padding(0);
            this.pnlRemoveContentOption.Name = "pnlRemoveContentOption";
            this.pnlRemoveContentOption.Size = new System.Drawing.Size(566, 28);
            this.pnlRemoveContentOption.TabIndex = 3;
            // 
            // btnRemoveStock
            // 
            this.btnRemoveStock.Location = new System.Drawing.Point(3, 3);
            this.btnRemoveStock.Name = "btnRemoveStock";
            this.btnRemoveStock.Size = new System.Drawing.Size(100, 23);
            this.btnRemoveStock.TabIndex = 3;
            this.btnRemoveStock.Text = "เบิกพัสดุ";
            this.btnRemoveStock.UseVisualStyleBackColor = true;
            this.btnRemoveStock.Click += new System.EventHandler(this.removeStock_Click);
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
            this.lblTitle.Text = "การบริหารจัดการพัสดุ";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlFooter
            // 
            this.pnlFooter.ColumnCount = 2;
            this.pnlFooter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.pnlFooter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.pnlFooter.Controls.Add(this.pnlRightFooter, 1, 0);
            this.pnlFooter.Controls.Add(this.pnlFooterLeft, 0, 0);
            this.pnlFooter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFooter.Location = new System.Drawing.Point(1, 480);
            this.pnlFooter.Margin = new System.Windows.Forms.Padding(0);
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.RowCount = 1;
            this.pnlFooter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlFooter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.pnlFooter.Size = new System.Drawing.Size(592, 40);
            this.pnlFooter.TabIndex = 1;
            // 
            // pnlRightFooter
            // 
            this.pnlRightFooter.Controls.Add(this.btnClose);
            this.pnlRightFooter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRightFooter.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.pnlRightFooter.Location = new System.Drawing.Point(299, 3);
            this.pnlRightFooter.Name = "pnlRightFooter";
            this.pnlRightFooter.Padding = new System.Windows.Forms.Padding(3);
            this.pnlRightFooter.Size = new System.Drawing.Size(290, 34);
            this.pnlRightFooter.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(206, 6);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "ปิด";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pnlFooterLeft
            // 
            this.pnlFooterLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFooterLeft.Location = new System.Drawing.Point(3, 3);
            this.pnlFooterLeft.Name = "pnlFooterLeft";
            this.pnlFooterLeft.Padding = new System.Windows.Forms.Padding(3);
            this.pnlFooterLeft.Size = new System.Drawing.Size(290, 34);
            this.pnlFooterLeft.TabIndex = 1;
            // 
            // colStockID
            // 
            this.colStockID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colStockID.DataPropertyName = "StockID";
            this.colStockID.HeaderText = "ID";
            this.colStockID.Name = "colStockID";
            this.colStockID.ReadOnly = true;
            this.colStockID.Width = 43;
            // 
            // colName
            // 
            this.colName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colName.DataPropertyName = "Name";
            this.colName.HeaderText = "พัสดุ";
            this.colName.Name = "colName";
            this.colName.ReadOnly = true;
            // 
            // colType
            // 
            this.colType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colType.DataPropertyName = "Type";
            this.colType.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.colType.HeaderText = "ประเภท";
            this.colType.Name = "colType";
            this.colType.ReadOnly = true;
            this.colType.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colType.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // colUnit
            // 
            this.colUnit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colUnit.DataPropertyName = "Unit";
            this.colUnit.HeaderText = "จำนวนคงเหลือ";
            this.colUnit.Name = "colUnit";
            this.colUnit.ReadOnly = true;
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
            // colAddID
            // 
            this.colAddID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colAddID.DataPropertyName = "StockAddID";
            this.colAddID.HeaderText = "ID";
            this.colAddID.MinimumWidth = 50;
            this.colAddID.Name = "colAddID";
            this.colAddID.ReadOnly = true;
            this.colAddID.Width = 50;
            // 
            // colAddDate
            // 
            this.colAddDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colAddDate.DataPropertyName = "Date";
            dataGridViewCellStyle1.Format = "D";
            dataGridViewCellStyle1.NullValue = null;
            this.colAddDate.DefaultCellStyle = dataGridViewCellStyle1;
            this.colAddDate.HeaderText = "วันที";
            this.colAddDate.MinimumWidth = 100;
            this.colAddDate.Name = "colAddDate";
            this.colAddDate.ReadOnly = true;
            // 
            // colAddTotal
            // 
            this.colAddTotal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colAddTotal.DataPropertyName = "TotalAmount";
            dataGridViewCellStyle2.Format = "C2";
            dataGridViewCellStyle2.NullValue = "0";
            this.colAddTotal.DefaultCellStyle = dataGridViewCellStyle2;
            this.colAddTotal.HeaderText = "ราคารวม";
            this.colAddTotal.MinimumWidth = 100;
            this.colAddTotal.Name = "colAddTotal";
            this.colAddTotal.ReadOnly = true;
            // 
            // colAddBy
            // 
            this.colAddBy.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colAddBy.DataPropertyName = "StockAddBy";
            this.colAddBy.DataSource = this.usersViewBindingSource;
            this.colAddBy.DisplayMember = "Name";
            this.colAddBy.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.colAddBy.HeaderText = "โดย";
            this.colAddBy.MinimumWidth = 100;
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
            // stockAddBindingSource
            // 
            this.stockAddBindingSource.DataMember = "StockAdd";
            this.stockAddBindingSource.DataSource = this.farmManageDataSet;
            // 
            // colRemoveFromType
            // 
            this.colRemoveFromType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colRemoveFromType.DataPropertyName = "RemoveFromType";
            this.colRemoveFromType.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.colRemoveFromType.HeaderText = "วิธีเบิก";
            this.colRemoveFromType.MinimumWidth = 50;
            this.colRemoveFromType.Name = "colRemoveFromType";
            this.colRemoveFromType.ReadOnly = true;
            this.colRemoveFromType.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colRemoveFromType.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // stockRemoveBindingSource
            // 
            this.stockRemoveBindingSource.DataMember = "StockRemove";
            this.stockRemoveBindingSource.DataSource = this.farmManageDataSet;
            // 
            // stockTableAdapter
            // 
            this.stockTableAdapter.ClearBeforeFill = true;
            // 
            // stockAddTableAdapter
            // 
            this.stockAddTableAdapter.ClearBeforeFill = true;
            // 
            // usersViewTableAdapter
            // 
            this.usersViewTableAdapter.ClearBeforeFill = true;
            // 
            // stockRemoveTableAdapter
            // 
            this.stockRemoveTableAdapter.ClearBeforeFill = true;
            // 
            // StockManageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 521);
            this.Controls.Add(this.pnlMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StockManageForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "การบริหารจัดการพัสดุ";
            this.Load += new System.EventHandler(this.SuppliesManageForm_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.tcMain.ResumeLayout(false);
            this.tabDetail.ResumeLayout(false);
            this.gbxDetail.ResumeLayout(false);
            this.pnlContent.ResumeLayout(false);
            this.pnlContentOption.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
            this.pnlFilter.ResumeLayout(false);
            this.tabAddHistory.ResumeLayout(false);
            this.gbxAddHistory.ResumeLayout(false);
            this.pnlAddHistoryContent.ResumeLayout(false);
            this.pnlRemoveHistoryFilter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAddHistory)).EndInit();
            this.pnlAddHistoryOption.ResumeLayout(false);
            this.tabRemoveHostory.ResumeLayout(false);
            this.gbxRemoveHistory.ResumeLayout(false);
            this.pnlRemoveHistoryContent.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRemoveHistory)).EndInit();
            this.pnlRemoveContentOption.ResumeLayout(false);
            this.pnlFooter.ResumeLayout(false);
            this.pnlRightFooter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.stockBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.farmManageDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockAddBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockRemoveBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel pnlMain;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TableLayoutPanel pnlFooter;
        private System.Windows.Forms.FlowLayoutPanel pnlRightFooter;
        private System.Windows.Forms.Button btnClose;
        private Database.FarmManageDataSet farmManageDataSet;
        private System.Windows.Forms.BindingSource stockBindingSource;
        private Database.FarmManageDataSetTableAdapters.StockTableAdapter stockTableAdapter;
        private System.Windows.Forms.FlowLayoutPanel pnlFooterLeft;
        private System.Windows.Forms.TabControl tcMain;
        private System.Windows.Forms.TabPage tabDetail;
        private System.Windows.Forms.TabPage tabAddHistory;
        private System.Windows.Forms.TabPage tabRemoveHostory;
        private System.Windows.Forms.BindingSource stockAddBindingSource;
        private Database.FarmManageDataSetTableAdapters.StockAddTableAdapter stockAddTableAdapter;
        private System.Windows.Forms.BindingSource usersViewBindingSource;
        private Database.FarmManageDataSetTableAdapters.UsersViewTableAdapter usersViewTableAdapter;
        private System.Windows.Forms.GroupBox gbxDetail;
        private System.Windows.Forms.TableLayoutPanel pnlContent;
        private System.Windows.Forms.FlowLayoutPanel pnlContentOption;
        private System.Windows.Forms.Button btnNewStock;
        private System.Windows.Forms.DataGridView dgvList;
        private System.Windows.Forms.FlowLayoutPanel pnlFilter;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.ComboBox cbxType;
        private System.Windows.Forms.GroupBox gbxAddHistory;
        private System.Windows.Forms.TableLayoutPanel pnlAddHistoryContent;
        private System.Windows.Forms.DataGridView dgvAddHistory;
        private System.Windows.Forms.FlowLayoutPanel pnlAddHistoryOption;
        private System.Windows.Forms.Button btnAddStock;
        private System.Windows.Forms.GroupBox gbxRemoveHistory;
        private System.Windows.Forms.TableLayoutPanel pnlRemoveHistoryContent;
        private System.Windows.Forms.DataGridView dgvRemoveHistory;
        private System.Windows.Forms.FlowLayoutPanel pnlRemoveContentOption;
        private System.Windows.Forms.Button btnRemoveStock;
        private System.Windows.Forms.BindingSource stockRemoveBindingSource;
        private Database.FarmManageDataSetTableAdapters.StockRemoveTableAdapter stockRemoveTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStockID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewComboBoxColumn colType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAddID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAddDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAddTotal;
        private System.Windows.Forms.DataGridViewComboBoxColumn colAddBy;
        private System.Windows.Forms.DataGridViewTextBoxColumn addRemoveID;
        private System.Windows.Forms.DataGridViewComboBoxColumn colRemoveBy;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRemoveDate;
        private System.Windows.Forms.DataGridViewComboBoxColumn colRemoveFromType;
        private System.Windows.Forms.FlowLayoutPanel pnlRemoveHistoryFilter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxAddMonth;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxAddYear;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbxRemoveMonth;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbxRemoveYear;
    }
}
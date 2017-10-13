namespace MainProject.UserInterface.Supplies
{
    partial class RemoveStockDetailForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlMain = new System.Windows.Forms.TableLayoutPanel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.tcMain = new System.Windows.Forms.TabControl();
            this.tabDetail = new System.Windows.Forms.TabPage();
            this.pblContentDetail = new System.Windows.Forms.TableLayoutPanel();
            this.gbxDetail = new System.Windows.Forms.GroupBox();
            this.pnlDetailContent = new System.Windows.Forms.TableLayoutPanel();
            this.lblUser = new System.Windows.Forms.Label();
            this.cbxBy = new System.Windows.Forms.ComboBox();
            this.stockRemoveBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.farmManageDataSet = new MainProject.Database.FarmManageDataSet();
            this.usersViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblDate = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.tcSecond = new System.Windows.Forms.TabControl();
            this.tabStockList = new System.Windows.Forms.TabPage();
            this.gbxList = new System.Windows.Forms.GroupBox();
            this.dgvList = new System.Windows.Forms.DataGridView();
            this.colStockRemoveListID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStockID = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.stockBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fKStockRemoveListStockRemoveBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabStockAdd = new System.Windows.Forms.TabPage();
            this.gbxStockAdd = new System.Windows.Forms.GroupBox();
            this.pnlStockAddContent = new System.Windows.Forms.TableLayoutPanel();
            this.dgvAddList = new System.Windows.Forms.DataGridView();
            this.colAddStock = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlStockAddFooter = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnRemoveAll = new System.Windows.Forms.Button();
            this.tabRecord = new System.Windows.Forms.TabPage();
            this.userLogUC = new MainProject.UserInterface.Control.UserLogUC();
            this.pnlFooter = new System.Windows.Forms.TableLayoutPanel();
            this.pnlRight = new System.Windows.Forms.FlowLayoutPanel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.pnlLeft = new System.Windows.Forms.FlowLayoutPanel();
            this.btnResource = new System.Windows.Forms.Button();
            this.stockTableAdapter = new MainProject.Database.FarmManageDataSetTableAdapters.StockTableAdapter();
            this.stockRemoveTableAdapter = new MainProject.Database.FarmManageDataSetTableAdapters.StockRemoveTableAdapter();
            this.stockRemoveListTableAdapter = new MainProject.Database.FarmManageDataSetTableAdapters.StockRemoveListTableAdapter();
            this.usersViewTableAdapter = new MainProject.Database.FarmManageDataSetTableAdapters.UsersViewTableAdapter();
            this.pnlMain.SuspendLayout();
            this.tcMain.SuspendLayout();
            this.tabDetail.SuspendLayout();
            this.pblContentDetail.SuspendLayout();
            this.gbxDetail.SuspendLayout();
            this.pnlDetailContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stockRemoveBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.farmManageDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersViewBindingSource)).BeginInit();
            this.tcSecond.SuspendLayout();
            this.tabStockList.SuspendLayout();
            this.gbxList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKStockRemoveListStockRemoveBindingSource)).BeginInit();
            this.tabStockAdd.SuspendLayout();
            this.gbxStockAdd.SuspendLayout();
            this.pnlStockAddContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAddList)).BeginInit();
            this.pnlStockAddFooter.SuspendLayout();
            this.tabRecord.SuspendLayout();
            this.pnlFooter.SuspendLayout();
            this.pnlRight.SuspendLayout();
            this.pnlLeft.SuspendLayout();
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
            this.pnlMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.pnlMain.Size = new System.Drawing.Size(594, 471);
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
            this.lblTitle.Size = new System.Drawing.Size(586, 60);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "รายละเอียดการเบิกพัสดุ";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tcMain
            // 
            this.tcMain.Controls.Add(this.tabDetail);
            this.tcMain.Controls.Add(this.tabRecord);
            this.tcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcMain.Location = new System.Drawing.Point(4, 65);
            this.tcMain.Name = "tcMain";
            this.tcMain.SelectedIndex = 0;
            this.tcMain.Size = new System.Drawing.Size(586, 361);
            this.tcMain.TabIndex = 2;
            // 
            // tabDetail
            // 
            this.tabDetail.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabDetail.Controls.Add(this.pblContentDetail);
            this.tabDetail.Location = new System.Drawing.Point(4, 22);
            this.tabDetail.Name = "tabDetail";
            this.tabDetail.Padding = new System.Windows.Forms.Padding(3);
            this.tabDetail.Size = new System.Drawing.Size(578, 335);
            this.tabDetail.TabIndex = 0;
            this.tabDetail.Text = "รายละเอียด";
            // 
            // pblContentDetail
            // 
            this.pblContentDetail.ColumnCount = 1;
            this.pblContentDetail.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pblContentDetail.Controls.Add(this.gbxDetail, 0, 0);
            this.pblContentDetail.Controls.Add(this.tcSecond, 0, 1);
            this.pblContentDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pblContentDetail.Location = new System.Drawing.Point(3, 3);
            this.pblContentDetail.Name = "pblContentDetail";
            this.pblContentDetail.RowCount = 2;
            this.pblContentDetail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.pblContentDetail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pblContentDetail.Size = new System.Drawing.Size(572, 329);
            this.pblContentDetail.TabIndex = 1;
            // 
            // gbxDetail
            // 
            this.gbxDetail.Controls.Add(this.pnlDetailContent);
            this.gbxDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbxDetail.Location = new System.Drawing.Point(3, 3);
            this.gbxDetail.Name = "gbxDetail";
            this.gbxDetail.Size = new System.Drawing.Size(566, 74);
            this.gbxDetail.TabIndex = 1;
            this.gbxDetail.TabStop = false;
            this.gbxDetail.Text = "รายละเอียด";
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
            this.pnlDetailContent.Controls.Add(this.lblUser, 1, 1);
            this.pnlDetailContent.Controls.Add(this.cbxBy, 2, 1);
            this.pnlDetailContent.Controls.Add(this.lblDate, 4, 1);
            this.pnlDetailContent.Controls.Add(this.dtpDate, 5, 1);
            this.pnlDetailContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDetailContent.Location = new System.Drawing.Point(3, 16);
            this.pnlDetailContent.Name = "pnlDetailContent";
            this.pnlDetailContent.RowCount = 6;
            this.pnlDetailContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.pnlDetailContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.pnlDetailContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 3F));
            this.pnlDetailContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.pnlDetailContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 3F));
            this.pnlDetailContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlDetailContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.pnlDetailContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.pnlDetailContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.pnlDetailContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.pnlDetailContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.pnlDetailContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.pnlDetailContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.pnlDetailContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.pnlDetailContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.pnlDetailContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.pnlDetailContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.pnlDetailContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.pnlDetailContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.pnlDetailContent.Size = new System.Drawing.Size(560, 55);
            this.pnlDetailContent.TabIndex = 3;
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblUser.Location = new System.Drawing.Point(30, 10);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(76, 25);
            this.lblUser.TabIndex = 0;
            this.lblUser.Text = "ชื่อผู้ชื่อ";
            this.lblUser.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbxBy
            // 
            this.cbxBy.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.stockRemoveBindingSource, "StockRemoveBy", true));
            this.cbxBy.DataSource = this.usersViewBindingSource;
            this.cbxBy.DisplayMember = "Name";
            this.cbxBy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbxBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxBy.FormattingEnabled = true;
            this.cbxBy.Location = new System.Drawing.Point(112, 13);
            this.cbxBy.Name = "cbxBy";
            this.cbxBy.Size = new System.Drawing.Size(159, 21);
            this.cbxBy.TabIndex = 8;
            this.cbxBy.ValueMember = "UserID";
            // 
            // stockRemoveBindingSource
            // 
            this.stockRemoveBindingSource.DataMember = "StockRemove";
            this.stockRemoveBindingSource.DataSource = this.farmManageDataSet;
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
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDate.Location = new System.Drawing.Point(287, 10);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(76, 25);
            this.lblDate.TabIndex = 14;
            this.lblDate.Text = "วันที่";
            this.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dtpDate
            // 
            this.dtpDate.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.stockRemoveBindingSource, "Date", true));
            this.dtpDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.Location = new System.Drawing.Point(369, 13);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(159, 20);
            this.dtpDate.TabIndex = 9;
            // 
            // tcSecond
            // 
            this.tcSecond.Controls.Add(this.tabStockList);
            this.tcSecond.Controls.Add(this.tabStockAdd);
            this.tcSecond.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcSecond.Location = new System.Drawing.Point(3, 83);
            this.tcSecond.Name = "tcSecond";
            this.tcSecond.SelectedIndex = 0;
            this.tcSecond.Size = new System.Drawing.Size(566, 243);
            this.tcSecond.TabIndex = 2;
            // 
            // tabStockList
            // 
            this.tabStockList.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabStockList.Controls.Add(this.gbxList);
            this.tabStockList.Location = new System.Drawing.Point(4, 22);
            this.tabStockList.Name = "tabStockList";
            this.tabStockList.Padding = new System.Windows.Forms.Padding(3);
            this.tabStockList.Size = new System.Drawing.Size(558, 217);
            this.tabStockList.TabIndex = 0;
            this.tabStockList.Text = "รายการพัสดุ";
            // 
            // gbxList
            // 
            this.gbxList.Controls.Add(this.dgvList);
            this.gbxList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbxList.Location = new System.Drawing.Point(3, 3);
            this.gbxList.Name = "gbxList";
            this.gbxList.Size = new System.Drawing.Size(552, 211);
            this.gbxList.TabIndex = 3;
            this.gbxList.TabStop = false;
            this.gbxList.Text = "รายการพัสดุ";
            // 
            // dgvList
            // 
            this.dgvList.AllowUserToAddRows = false;
            this.dgvList.AllowUserToDeleteRows = false;
            this.dgvList.AutoGenerateColumns = false;
            this.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colStockRemoveListID,
            this.colStockID,
            this.colUnit,
            this.colDescription});
            this.dgvList.DataSource = this.fKStockRemoveListStockRemoveBindingSource;
            this.dgvList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvList.Location = new System.Drawing.Point(3, 16);
            this.dgvList.Name = "dgvList";
            this.dgvList.ReadOnly = true;
            this.dgvList.Size = new System.Drawing.Size(546, 192);
            this.dgvList.TabIndex = 0;
            // 
            // colStockRemoveListID
            // 
            this.colStockRemoveListID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colStockRemoveListID.DataPropertyName = "StockRemoveListID";
            this.colStockRemoveListID.HeaderText = "ID";
            this.colStockRemoveListID.MinimumWidth = 50;
            this.colStockRemoveListID.Name = "colStockRemoveListID";
            this.colStockRemoveListID.ReadOnly = true;
            this.colStockRemoveListID.Width = 50;
            // 
            // colStockID
            // 
            this.colStockID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colStockID.DataPropertyName = "StockID";
            this.colStockID.DataSource = this.stockBindingSource;
            this.colStockID.DisplayMember = "Name";
            this.colStockID.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.colStockID.HeaderText = "พัสดุ";
            this.colStockID.MinimumWidth = 150;
            this.colStockID.Name = "colStockID";
            this.colStockID.ReadOnly = true;
            this.colStockID.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colStockID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colStockID.ValueMember = "StockID";
            // 
            // stockBindingSource
            // 
            this.stockBindingSource.DataMember = "Stock";
            this.stockBindingSource.DataSource = this.farmManageDataSet;
            // 
            // colUnit
            // 
            this.colUnit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colUnit.DataPropertyName = "Unit";
            dataGridViewCellStyle3.Format = "N2";
            dataGridViewCellStyle3.NullValue = "0";
            this.colUnit.DefaultCellStyle = dataGridViewCellStyle3;
            this.colUnit.HeaderText = "จำนวน";
            this.colUnit.MinimumWidth = 50;
            this.colUnit.Name = "colUnit";
            this.colUnit.ReadOnly = true;
            // 
            // colDescription
            // 
            this.colDescription.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colDescription.DataPropertyName = "Description";
            this.colDescription.HeaderText = "รายละเอียด";
            this.colDescription.MaxInputLength = 512;
            this.colDescription.MinimumWidth = 50;
            this.colDescription.Name = "colDescription";
            this.colDescription.ReadOnly = true;
            // 
            // fKStockRemoveListStockRemoveBindingSource
            // 
            this.fKStockRemoveListStockRemoveBindingSource.DataMember = "FK_StockRemoveList_StockRemove";
            this.fKStockRemoveListStockRemoveBindingSource.DataSource = this.stockRemoveBindingSource;
            // 
            // tabStockAdd
            // 
            this.tabStockAdd.Controls.Add(this.gbxStockAdd);
            this.tabStockAdd.Location = new System.Drawing.Point(4, 22);
            this.tabStockAdd.Name = "tabStockAdd";
            this.tabStockAdd.Padding = new System.Windows.Forms.Padding(3);
            this.tabStockAdd.Size = new System.Drawing.Size(558, 217);
            this.tabStockAdd.TabIndex = 1;
            this.tabStockAdd.Text = "เพิ่มรายการพัสดุ";
            this.tabStockAdd.UseVisualStyleBackColor = true;
            // 
            // gbxStockAdd
            // 
            this.gbxStockAdd.Controls.Add(this.pnlStockAddContent);
            this.gbxStockAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbxStockAdd.Location = new System.Drawing.Point(3, 3);
            this.gbxStockAdd.Name = "gbxStockAdd";
            this.gbxStockAdd.Size = new System.Drawing.Size(552, 211);
            this.gbxStockAdd.TabIndex = 1;
            this.gbxStockAdd.TabStop = false;
            this.gbxStockAdd.Text = "เพิ่มรายการพัสดุ";
            // 
            // pnlStockAddContent
            // 
            this.pnlStockAddContent.ColumnCount = 1;
            this.pnlStockAddContent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlStockAddContent.Controls.Add(this.dgvAddList, 0, 0);
            this.pnlStockAddContent.Controls.Add(this.pnlStockAddFooter, 0, 1);
            this.pnlStockAddContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlStockAddContent.Location = new System.Drawing.Point(3, 16);
            this.pnlStockAddContent.Name = "pnlStockAddContent";
            this.pnlStockAddContent.RowCount = 2;
            this.pnlStockAddContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlStockAddContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.pnlStockAddContent.Size = new System.Drawing.Size(546, 192);
            this.pnlStockAddContent.TabIndex = 0;
            // 
            // dgvAddList
            // 
            this.dgvAddList.AllowUserToAddRows = false;
            this.dgvAddList.AllowUserToDeleteRows = false;
            this.dgvAddList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAddList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colAddStock,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.dgvAddList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAddList.Location = new System.Drawing.Point(3, 3);
            this.dgvAddList.Name = "dgvAddList";
            this.dgvAddList.Size = new System.Drawing.Size(540, 158);
            this.dgvAddList.TabIndex = 2;
            this.dgvAddList.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dgvAddList_CellBeginEdit);
            this.dgvAddList.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAddList_CellEndEdit);
            this.dgvAddList.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgvAddList_RowsAdded);
            this.dgvAddList.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dgvAddList_RowsRemoved);
            this.dgvAddList.SelectionChanged += new System.EventHandler(this.dgvAddList_SelectionChanged);
            // 
            // colAddStock
            // 
            this.colAddStock.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colAddStock.DataSource = this.stockBindingSource;
            this.colAddStock.DisplayMember = "Name";
            this.colAddStock.HeaderText = "ชื่อพัสดุ";
            this.colAddStock.Name = "colAddStock";
            this.colAddStock.ValueMember = "StockID";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle4.Format = "N2";
            dataGridViewCellStyle4.NullValue = "0";
            this.dataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewTextBoxColumn1.HeaderText = "จำนวน";
            this.dataGridViewTextBoxColumn1.MaxInputLength = 12;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.HeaderText = "รายละเอียด";
            this.dataGridViewTextBoxColumn2.MaxInputLength = 512;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // pnlStockAddFooter
            // 
            this.pnlStockAddFooter.Controls.Add(this.btnAdd);
            this.pnlStockAddFooter.Controls.Add(this.btnRemove);
            this.pnlStockAddFooter.Controls.Add(this.btnRemoveAll);
            this.pnlStockAddFooter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlStockAddFooter.Location = new System.Drawing.Point(0, 164);
            this.pnlStockAddFooter.Margin = new System.Windows.Forms.Padding(0);
            this.pnlStockAddFooter.Name = "pnlStockAddFooter";
            this.pnlStockAddFooter.Size = new System.Drawing.Size(546, 28);
            this.pnlStockAddFooter.TabIndex = 1;
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
            this.tabRecord.Size = new System.Drawing.Size(578, 335);
            this.tabRecord.TabIndex = 1;
            this.tabRecord.Text = "การบันทึก";
            // 
            // userLogUC
            // 
            this.userLogUC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userLogUC.Location = new System.Drawing.Point(3, 3);
            this.userLogUC.Name = "userLogUC";
            this.userLogUC.Size = new System.Drawing.Size(572, 329);
            this.userLogUC.TabIndex = 0;
            // 
            // pnlFooter
            // 
            this.pnlFooter.ColumnCount = 2;
            this.pnlFooter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.pnlFooter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.pnlFooter.Controls.Add(this.pnlRight, 1, 0);
            this.pnlFooter.Controls.Add(this.pnlLeft, 0, 0);
            this.pnlFooter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFooter.Location = new System.Drawing.Point(1, 430);
            this.pnlFooter.Margin = new System.Windows.Forms.Padding(0);
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.RowCount = 1;
            this.pnlFooter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlFooter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.pnlFooter.Size = new System.Drawing.Size(592, 40);
            this.pnlFooter.TabIndex = 3;
            // 
            // pnlRight
            // 
            this.pnlRight.Controls.Add(this.btnCancel);
            this.pnlRight.Controls.Add(this.btnSave);
            this.pnlRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRight.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.pnlRight.Location = new System.Drawing.Point(299, 3);
            this.pnlRight.Name = "pnlRight";
            this.pnlRight.Padding = new System.Windows.Forms.Padding(3);
            this.pnlRight.Size = new System.Drawing.Size(290, 34);
            this.pnlRight.TabIndex = 2;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(206, 6);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "ยกเลิก";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(125, 6);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "บันทึก";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pnlLeft
            // 
            this.pnlLeft.Controls.Add(this.btnResource);
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlLeft.Location = new System.Drawing.Point(3, 3);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Padding = new System.Windows.Forms.Padding(3);
            this.pnlLeft.Size = new System.Drawing.Size(290, 34);
            this.pnlLeft.TabIndex = 3;
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
            // stockTableAdapter
            // 
            this.stockTableAdapter.ClearBeforeFill = true;
            // 
            // stockRemoveTableAdapter
            // 
            this.stockRemoveTableAdapter.ClearBeforeFill = true;
            // 
            // stockRemoveListTableAdapter
            // 
            this.stockRemoveListTableAdapter.ClearBeforeFill = true;
            // 
            // usersViewTableAdapter
            // 
            this.usersViewTableAdapter.ClearBeforeFill = true;
            // 
            // RemoveStockDetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 471);
            this.Controls.Add(this.pnlMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RemoveStockDetailForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "รายละเอียดการเบิกพัสดุ";
            this.Load += new System.EventHandler(this.AddStockDetailForm_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.tcMain.ResumeLayout(false);
            this.tabDetail.ResumeLayout(false);
            this.pblContentDetail.ResumeLayout(false);
            this.gbxDetail.ResumeLayout(false);
            this.pnlDetailContent.ResumeLayout(false);
            this.pnlDetailContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stockRemoveBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.farmManageDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersViewBindingSource)).EndInit();
            this.tcSecond.ResumeLayout(false);
            this.tabStockList.ResumeLayout(false);
            this.gbxList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKStockRemoveListStockRemoveBindingSource)).EndInit();
            this.tabStockAdd.ResumeLayout(false);
            this.gbxStockAdd.ResumeLayout(false);
            this.pnlStockAddContent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAddList)).EndInit();
            this.pnlStockAddFooter.ResumeLayout(false);
            this.tabRecord.ResumeLayout(false);
            this.pnlFooter.ResumeLayout(false);
            this.pnlRight.ResumeLayout(false);
            this.pnlLeft.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel pnlMain;
        private System.Windows.Forms.Label lblTitle;
        private Database.FarmManageDataSetTableAdapters.StockTableAdapter stockTableAdapter;
        private System.Windows.Forms.TabControl tcMain;
        private System.Windows.Forms.TabPage tabDetail;
        private System.Windows.Forms.TabPage tabRecord;
        private System.Windows.Forms.TableLayoutPanel pblContentDetail;
        private System.Windows.Forms.GroupBox gbxDetail;
        private System.Windows.Forms.TableLayoutPanel pnlDetailContent;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.ComboBox cbxBy;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private Database.FarmManageDataSet farmManageDataSet;
        private System.Windows.Forms.BindingSource stockRemoveBindingSource;
        private Database.FarmManageDataSetTableAdapters.StockRemoveTableAdapter stockRemoveTableAdapter;
        private System.Windows.Forms.BindingSource fKStockRemoveListStockRemoveBindingSource;
        private Database.FarmManageDataSetTableAdapters.StockRemoveListTableAdapter stockRemoveListTableAdapter;
        private System.Windows.Forms.BindingSource stockBindingSource;
        private System.Windows.Forms.TabControl tcSecond;
        private System.Windows.Forms.TabPage tabStockList;
        private System.Windows.Forms.GroupBox gbxList;
        private System.Windows.Forms.DataGridView dgvList;
        private System.Windows.Forms.TabPage tabStockAdd;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStockRemoveListID;
        private System.Windows.Forms.DataGridViewComboBoxColumn colStockID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDescription;
        private System.Windows.Forms.GroupBox gbxStockAdd;
        private System.Windows.Forms.TableLayoutPanel pnlStockAddContent;
        private System.Windows.Forms.DataGridView dgvAddList;
        private System.Windows.Forms.DataGridViewComboBoxColumn colAddStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.FlowLayoutPanel pnlStockAddFooter;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnRemoveAll;
        private System.Windows.Forms.TableLayoutPanel pnlFooter;
        private System.Windows.Forms.FlowLayoutPanel pnlRight;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.FlowLayoutPanel pnlLeft;
        private System.Windows.Forms.Button btnResource;
        private Control.UserLogUC userLogUC;
        private System.Windows.Forms.BindingSource usersViewBindingSource;
        private Database.FarmManageDataSetTableAdapters.UsersViewTableAdapter usersViewTableAdapter;
    }
}
namespace MainProject.UserInterface.Recipes
{
    partial class RecipesCalculateDetailForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RecipesCalculateDetailForm));
            this.pnlMain = new System.Windows.Forms.TableLayoutPanel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlFooter = new System.Windows.Forms.FlowLayoutPanel();
            this.btnClose = new System.Windows.Forms.Button();
            this.tclMain = new System.Windows.Forms.TabControl();
            this.tabDetail = new System.Windows.Forms.TabPage();
            this.gbxDetail = new System.Windows.Forms.GroupBox();
            this.pnlDetailContent = new System.Windows.Forms.TableLayoutPanel();
            this.lblRecipse = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.cbxRecipse = new System.Windows.Forms.ComboBox();
            this.recipesHistoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.farmManageDataSet = new MainProject.Database.FarmManageDataSet();
            this.recipesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.cbxBy = new System.Windows.Forms.ComboBox();
            this.usersViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblBy = new System.Windows.Forms.Label();
            this.lblUnit = new System.Windows.Forms.Label();
            this.tbxUnit = new System.Windows.Forms.TextBox();
            this.dgvList = new System.Windows.Forms.DataGridView();
            this.recipesListHistoryIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.stockBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.unitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fKrecipeslisthistoryrecipeshistoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabRecord = new System.Windows.Forms.TabPage();
            this.userLogUC = new MainProject.UserInterface.Control.UserLogUC();
            this.usersViewBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.recipesTableAdapter = new MainProject.Database.FarmManageDataSetTableAdapters.RecipesTableAdapter();
            this.recipesHistoryTableAdapter = new MainProject.Database.FarmManageDataSetTableAdapters.RecipesHistoryTableAdapter();
            this.usersViewTableAdapter = new MainProject.Database.FarmManageDataSetTableAdapters.UsersViewTableAdapter();
            this.recipesListHistoryTableAdapter = new MainProject.Database.FarmManageDataSetTableAdapters.RecipesListHistoryTableAdapter();
            this.stockTableAdapter = new MainProject.Database.FarmManageDataSetTableAdapters.StockTableAdapter();
            this.pnlMain.SuspendLayout();
            this.pnlFooter.SuspendLayout();
            this.tclMain.SuspendLayout();
            this.tabDetail.SuspendLayout();
            this.gbxDetail.SuspendLayout();
            this.pnlDetailContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.recipesHistoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.farmManageDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.recipesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKrecipeslisthistoryrecipeshistoryBindingSource)).BeginInit();
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
            this.pnlMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.pnlMain.Size = new System.Drawing.Size(594, 521);
            this.pnlMain.TabIndex = 2;
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
            this.lblTitle.Text = "รายละเอียดคำนวณสูตรอาหาร";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlFooter
            // 
            this.pnlFooter.Controls.Add(this.btnClose);
            this.pnlFooter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFooter.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.pnlFooter.Location = new System.Drawing.Point(4, 483);
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.Padding = new System.Windows.Forms.Padding(3);
            this.pnlFooter.Size = new System.Drawing.Size(586, 34);
            this.pnlFooter.TabIndex = 1;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(502, 6);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "ปิด";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // tclMain
            // 
            this.tclMain.Controls.Add(this.tabDetail);
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
            this.pnlDetailContent.ColumnCount = 7;
            this.pnlDetailContent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.pnlDetailContent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.pnlDetailContent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.pnlDetailContent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.pnlDetailContent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.pnlDetailContent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.pnlDetailContent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.pnlDetailContent.Controls.Add(this.lblRecipse, 1, 1);
            this.pnlDetailContent.Controls.Add(this.lblDate, 1, 3);
            this.pnlDetailContent.Controls.Add(this.cbxRecipse, 2, 1);
            this.pnlDetailContent.Controls.Add(this.dtpDate, 2, 3);
            this.pnlDetailContent.Controls.Add(this.cbxBy, 5, 1);
            this.pnlDetailContent.Controls.Add(this.lblBy, 4, 1);
            this.pnlDetailContent.Controls.Add(this.lblUnit, 4, 3);
            this.pnlDetailContent.Controls.Add(this.tbxUnit, 5, 3);
            this.pnlDetailContent.Controls.Add(this.dgvList, 0, 5);
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
            this.pnlDetailContent.Size = new System.Drawing.Size(566, 360);
            this.pnlDetailContent.TabIndex = 4;
            // 
            // lblRecipse
            // 
            this.lblRecipse.AutoSize = true;
            this.lblRecipse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblRecipse.Location = new System.Drawing.Point(30, 10);
            this.lblRecipse.Name = "lblRecipse";
            this.lblRecipse.Size = new System.Drawing.Size(77, 25);
            this.lblRecipse.TabIndex = 0;
            this.lblRecipse.Text = "สูตร";
            this.lblRecipse.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDate.Location = new System.Drawing.Point(30, 38);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(77, 25);
            this.lblDate.TabIndex = 1;
            this.lblDate.Text = "วันที่";
            this.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbxRecipse
            // 
            this.cbxRecipse.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.recipesHistoryBindingSource, "RecipesID", true));
            this.cbxRecipse.DataSource = this.recipesBindingSource;
            this.cbxRecipse.DisplayMember = "Name";
            this.cbxRecipse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbxRecipse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxRecipse.Enabled = false;
            this.cbxRecipse.FormattingEnabled = true;
            this.cbxRecipse.Location = new System.Drawing.Point(113, 13);
            this.cbxRecipse.Name = "cbxRecipse";
            this.cbxRecipse.Size = new System.Drawing.Size(160, 21);
            this.cbxRecipse.TabIndex = 5;
            this.cbxRecipse.ValueMember = "RecipesID";
            // 
            // recipesHistoryBindingSource
            // 
            this.recipesHistoryBindingSource.DataMember = "RecipesHistory";
            this.recipesHistoryBindingSource.DataSource = this.farmManageDataSet;
            // 
            // farmManageDataSet
            // 
            this.farmManageDataSet.DataSetName = "FarmManageDataSet";
            this.farmManageDataSet.Locale = new System.Globalization.CultureInfo("en");
            this.farmManageDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // recipesBindingSource
            // 
            this.recipesBindingSource.DataMember = "Recipes";
            this.recipesBindingSource.DataSource = this.farmManageDataSet;
            // 
            // dtpDate
            // 
            this.dtpDate.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.recipesHistoryBindingSource, "Date", true));
            this.dtpDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtpDate.Enabled = false;
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.Location = new System.Drawing.Point(113, 41);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(160, 20);
            this.dtpDate.TabIndex = 6;
            // 
            // cbxBy
            // 
            this.cbxBy.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.recipesHistoryBindingSource, "RecipesHistoryBy", true));
            this.cbxBy.DataSource = this.usersViewBindingSource;
            this.cbxBy.DisplayMember = "Name";
            this.cbxBy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbxBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxBy.Enabled = false;
            this.cbxBy.FormattingEnabled = true;
            this.cbxBy.Location = new System.Drawing.Point(372, 13);
            this.cbxBy.Name = "cbxBy";
            this.cbxBy.Size = new System.Drawing.Size(160, 21);
            this.cbxBy.TabIndex = 7;
            this.cbxBy.ValueMember = "UserID";
            // 
            // usersViewBindingSource
            // 
            this.usersViewBindingSource.DataMember = "UsersView";
            this.usersViewBindingSource.DataSource = this.farmManageDataSet;
            // 
            // lblBy
            // 
            this.lblBy.AutoSize = true;
            this.lblBy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblBy.Location = new System.Drawing.Point(289, 10);
            this.lblBy.Name = "lblBy";
            this.lblBy.Size = new System.Drawing.Size(77, 25);
            this.lblBy.TabIndex = 8;
            this.lblBy.Text = "โดย";
            this.lblBy.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblUnit
            // 
            this.lblUnit.AutoSize = true;
            this.lblUnit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblUnit.Location = new System.Drawing.Point(289, 38);
            this.lblUnit.Name = "lblUnit";
            this.lblUnit.Size = new System.Drawing.Size(77, 25);
            this.lblUnit.TabIndex = 9;
            this.lblUnit.Text = "ร้อยละ";
            this.lblUnit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbxUnit
            // 
            this.tbxUnit.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.recipesHistoryBindingSource, "Unit", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "0", "N2"));
            this.tbxUnit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxUnit.Location = new System.Drawing.Point(372, 41);
            this.tbxUnit.Name = "tbxUnit";
            this.tbxUnit.ReadOnly = true;
            this.tbxUnit.Size = new System.Drawing.Size(160, 20);
            this.tbxUnit.TabIndex = 10;
            // 
            // dgvList
            // 
            this.dgvList.AllowUserToAddRows = false;
            this.dgvList.AllowUserToDeleteRows = false;
            this.dgvList.AutoGenerateColumns = false;
            this.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.recipesListHistoryIDDataGridViewTextBoxColumn,
            this.stockIDDataGridViewTextBoxColumn,
            this.unitDataGridViewTextBoxColumn});
            this.pnlDetailContent.SetColumnSpan(this.dgvList, 7);
            this.dgvList.DataSource = this.fKrecipeslisthistoryrecipeshistoryBindingSource;
            this.dgvList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvList.Location = new System.Drawing.Point(3, 69);
            this.dgvList.Name = "dgvList";
            this.dgvList.ReadOnly = true;
            this.dgvList.Size = new System.Drawing.Size(560, 288);
            this.dgvList.TabIndex = 11;
            // 
            // recipesListHistoryIDDataGridViewTextBoxColumn
            // 
            this.recipesListHistoryIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.recipesListHistoryIDDataGridViewTextBoxColumn.DataPropertyName = "RecipesListHistoryID";
            this.recipesListHistoryIDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.recipesListHistoryIDDataGridViewTextBoxColumn.MinimumWidth = 50;
            this.recipesListHistoryIDDataGridViewTextBoxColumn.Name = "recipesListHistoryIDDataGridViewTextBoxColumn";
            this.recipesListHistoryIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.recipesListHistoryIDDataGridViewTextBoxColumn.Width = 50;
            // 
            // stockIDDataGridViewTextBoxColumn
            // 
            this.stockIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.stockIDDataGridViewTextBoxColumn.DataPropertyName = "StockID";
            this.stockIDDataGridViewTextBoxColumn.DataSource = this.stockBindingSource;
            this.stockIDDataGridViewTextBoxColumn.DisplayMember = "Name";
            this.stockIDDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.stockIDDataGridViewTextBoxColumn.HeaderText = "ชื่อพัสดุ";
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
            this.unitDataGridViewTextBoxColumn.HeaderText = "จำนวน";
            this.unitDataGridViewTextBoxColumn.Name = "unitDataGridViewTextBoxColumn";
            this.unitDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fKrecipeslisthistoryrecipeshistoryBindingSource
            // 
            this.fKrecipeslisthistoryrecipeshistoryBindingSource.DataMember = "FK_recipes_list_history_recipes_history";
            this.fKrecipeslisthistoryrecipeshistoryBindingSource.DataSource = this.recipesHistoryBindingSource;
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
            // usersViewBindingSource1
            // 
            this.usersViewBindingSource1.DataMember = "UsersView";
            this.usersViewBindingSource1.DataSource = this.farmManageDataSet;
            // 
            // recipesTableAdapter
            // 
            this.recipesTableAdapter.ClearBeforeFill = true;
            // 
            // recipesHistoryTableAdapter
            // 
            this.recipesHistoryTableAdapter.ClearBeforeFill = true;
            // 
            // usersViewTableAdapter
            // 
            this.usersViewTableAdapter.ClearBeforeFill = true;
            // 
            // recipesListHistoryTableAdapter
            // 
            this.recipesListHistoryTableAdapter.ClearBeforeFill = true;
            // 
            // stockTableAdapter
            // 
            this.stockTableAdapter.ClearBeforeFill = true;
            // 
            // RecipesCalculateDetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 521);
            this.Controls.Add(this.pnlMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RecipesCalculateDetailForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "รายละเอียดคำนวณสูตรอาหาร";
            this.Load += new System.EventHandler(this.RecipesCalculateDetailForm_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.pnlFooter.ResumeLayout(false);
            this.tclMain.ResumeLayout(false);
            this.tabDetail.ResumeLayout(false);
            this.gbxDetail.ResumeLayout(false);
            this.pnlDetailContent.ResumeLayout(false);
            this.pnlDetailContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.recipesHistoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.farmManageDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.recipesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKrecipeslisthistoryrecipeshistoryBindingSource)).EndInit();
            this.tabRecord.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.usersViewBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel pnlMain;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.FlowLayoutPanel pnlFooter;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TabControl tclMain;
        private System.Windows.Forms.TabPage tabDetail;
        private System.Windows.Forms.TabPage tabRecord;
        private System.Windows.Forms.GroupBox gbxDetail;
        private System.Windows.Forms.TableLayoutPanel pnlDetailContent;
        private System.Windows.Forms.Label lblRecipse;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.ComboBox cbxRecipse;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.ComboBox cbxBy;
        private System.Windows.Forms.Label lblBy;
        private Database.FarmManageDataSet farmManageDataSet;
        private System.Windows.Forms.BindingSource recipesBindingSource;
        private Database.FarmManageDataSetTableAdapters.RecipesTableAdapter recipesTableAdapter;
        private System.Windows.Forms.BindingSource recipesHistoryBindingSource;
        private Database.FarmManageDataSetTableAdapters.RecipesHistoryTableAdapter recipesHistoryTableAdapter;
        private System.Windows.Forms.BindingSource usersViewBindingSource;
        private Database.FarmManageDataSetTableAdapters.UsersViewTableAdapter usersViewTableAdapter;
        private System.Windows.Forms.Label lblUnit;
        private System.Windows.Forms.TextBox tbxUnit;
        private System.Windows.Forms.DataGridView dgvList;
        private System.Windows.Forms.BindingSource fKrecipeslisthistoryrecipeshistoryBindingSource;
        private Database.FarmManageDataSetTableAdapters.RecipesListHistoryTableAdapter recipesListHistoryTableAdapter;
        private System.Windows.Forms.BindingSource stockBindingSource;
        private Database.FarmManageDataSetTableAdapters.StockTableAdapter stockTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn recipesListHistoryIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn stockIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource usersViewBindingSource1;
        private Control.UserLogUC userLogUC;
    }
}
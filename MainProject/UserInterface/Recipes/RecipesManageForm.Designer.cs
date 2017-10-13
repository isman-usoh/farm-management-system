namespace MainProject.UserInterface.Recipes
{
    partial class RecipesManageForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RecipesManageForm));
            this.pnlMain = new System.Windows.Forms.TableLayoutPanel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlContent = new System.Windows.Forms.TableLayoutPanel();
            this.pnlContentOption = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSubStock = new System.Windows.Forms.Button();
            this.tcMain = new System.Windows.Forms.TabControl();
            this.tabList = new System.Windows.Forms.TabPage();
            this.gbxRecipse = new System.Windows.Forms.GroupBox();
            this.dgvRecipse = new System.Windows.Forms.DataGridView();
            this.recipesIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.recipesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.farmManageDataSet = new MainProject.Database.FarmManageDataSet();
            this.tabHistory = new System.Windows.Forms.TabPage();
            this.cbxHistory = new System.Windows.Forms.GroupBox();
            this.dgvRecipseHistory = new System.Windows.Forms.DataGridView();
            this.stockBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usersViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.recipesHistoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pnlFooter = new System.Windows.Forms.FlowLayoutPanel();
            this.btnClose = new System.Windows.Forms.Button();
            this.recipesTableAdapter = new MainProject.Database.FarmManageDataSetTableAdapters.RecipesTableAdapter();
            this.recipesHistoryTableAdapter = new MainProject.Database.FarmManageDataSetTableAdapters.RecipesHistoryTableAdapter();
            this.usersViewTableAdapter = new MainProject.Database.FarmManageDataSetTableAdapters.UsersViewTableAdapter();
            this.stockTableAdapter = new MainProject.Database.FarmManageDataSetTableAdapters.StockTableAdapter();
            this.recipesHistoryIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.recipesIDDataGridViewComboBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.recipesHistoryByDataGridViewComboBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.pnlMain.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.pnlContentOption.SuspendLayout();
            this.tcMain.SuspendLayout();
            this.tabList.SuspendLayout();
            this.gbxRecipse.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecipse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.recipesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.farmManageDataSet)).BeginInit();
            this.tabHistory.SuspendLayout();
            this.cbxHistory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecipseHistory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.recipesHistoryBindingSource)).BeginInit();
            this.pnlFooter.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.pnlMain.ColumnCount = 1;
            this.pnlMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.pnlMain.Controls.Add(this.lblTitle, 0, 0);
            this.pnlMain.Controls.Add(this.pnlContent, 0, 1);
            this.pnlMain.Controls.Add(this.pnlFooter, 0, 2);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.RowCount = 3;
            this.pnlMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.pnlMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.pnlMain.Size = new System.Drawing.Size(584, 511);
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
            this.lblTitle.Size = new System.Drawing.Size(576, 60);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "จัดการสูตรอาหาร";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlContent
            // 
            this.pnlContent.ColumnCount = 1;
            this.pnlContent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlContent.Controls.Add(this.pnlContentOption, 0, 1);
            this.pnlContent.Controls.Add(this.tcMain, 0, 0);
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(4, 65);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.RowCount = 2;
            this.pnlContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.pnlContent.Size = new System.Drawing.Size(576, 401);
            this.pnlContent.TabIndex = 1;
            // 
            // pnlContentOption
            // 
            this.pnlContentOption.Controls.Add(this.btnAdd);
            this.pnlContentOption.Controls.Add(this.btnSubStock);
            this.pnlContentOption.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContentOption.Location = new System.Drawing.Point(3, 370);
            this.pnlContentOption.Name = "pnlContentOption";
            this.pnlContentOption.Size = new System.Drawing.Size(570, 28);
            this.pnlContentOption.TabIndex = 1;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(3, 3);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(120, 23);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "เพิ่มสูตรอาหาร";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSubStock
            // 
            this.btnSubStock.Location = new System.Drawing.Point(129, 3);
            this.btnSubStock.Name = "btnSubStock";
            this.btnSubStock.Size = new System.Drawing.Size(100, 23);
            this.btnSubStock.TabIndex = 4;
            this.btnSubStock.Text = "หักพัสดุจากสูตร";
            this.btnSubStock.UseVisualStyleBackColor = true;
            this.btnSubStock.Click += new System.EventHandler(this.btnSubStock_Click);
            // 
            // tcMain
            // 
            this.tcMain.Controls.Add(this.tabList);
            this.tcMain.Controls.Add(this.tabHistory);
            this.tcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcMain.Location = new System.Drawing.Point(3, 3);
            this.tcMain.Name = "tcMain";
            this.tcMain.SelectedIndex = 0;
            this.tcMain.Size = new System.Drawing.Size(570, 361);
            this.tcMain.TabIndex = 2;
            // 
            // tabList
            // 
            this.tabList.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabList.Controls.Add(this.gbxRecipse);
            this.tabList.Location = new System.Drawing.Point(4, 22);
            this.tabList.Name = "tabList";
            this.tabList.Padding = new System.Windows.Forms.Padding(3);
            this.tabList.Size = new System.Drawing.Size(562, 335);
            this.tabList.TabIndex = 0;
            this.tabList.Text = "สูตรอาหาร";
            // 
            // gbxRecipse
            // 
            this.gbxRecipse.Controls.Add(this.dgvRecipse);
            this.gbxRecipse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbxRecipse.Location = new System.Drawing.Point(3, 3);
            this.gbxRecipse.Name = "gbxRecipse";
            this.gbxRecipse.Size = new System.Drawing.Size(556, 329);
            this.gbxRecipse.TabIndex = 0;
            this.gbxRecipse.TabStop = false;
            this.gbxRecipse.Text = "สูตรอาหาร";
            // 
            // dgvRecipse
            // 
            this.dgvRecipse.AllowUserToAddRows = false;
            this.dgvRecipse.AllowUserToDeleteRows = false;
            this.dgvRecipse.AutoGenerateColumns = false;
            this.dgvRecipse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRecipse.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.recipesIDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn});
            this.dgvRecipse.DataSource = this.recipesBindingSource;
            this.dgvRecipse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRecipse.Location = new System.Drawing.Point(3, 16);
            this.dgvRecipse.Name = "dgvRecipse";
            this.dgvRecipse.ReadOnly = true;
            this.dgvRecipse.Size = new System.Drawing.Size(550, 310);
            this.dgvRecipse.TabIndex = 2;
            this.dgvRecipse.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvRecipse_CellMouseDoubleClick);
            // 
            // recipesIDDataGridViewTextBoxColumn
            // 
            this.recipesIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.recipesIDDataGridViewTextBoxColumn.DataPropertyName = "RecipesID";
            this.recipesIDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.recipesIDDataGridViewTextBoxColumn.MinimumWidth = 50;
            this.recipesIDDataGridViewTextBoxColumn.Name = "recipesIDDataGridViewTextBoxColumn";
            this.recipesIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.recipesIDDataGridViewTextBoxColumn.Width = 50;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "ชื่อสูตร";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "รายละเอียด";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.ReadOnly = true;
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
            // tabHistory
            // 
            this.tabHistory.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabHistory.Controls.Add(this.cbxHistory);
            this.tabHistory.Location = new System.Drawing.Point(4, 22);
            this.tabHistory.Name = "tabHistory";
            this.tabHistory.Padding = new System.Windows.Forms.Padding(3);
            this.tabHistory.Size = new System.Drawing.Size(562, 335);
            this.tabHistory.TabIndex = 1;
            this.tabHistory.Text = "ประวัติการใช้สูตร";
            // 
            // cbxHistory
            // 
            this.cbxHistory.Controls.Add(this.dgvRecipseHistory);
            this.cbxHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbxHistory.Location = new System.Drawing.Point(3, 3);
            this.cbxHistory.Name = "cbxHistory";
            this.cbxHistory.Size = new System.Drawing.Size(556, 329);
            this.cbxHistory.TabIndex = 0;
            this.cbxHistory.TabStop = false;
            this.cbxHistory.Text = "ประวัติการใช้สูตร";
            // 
            // dgvRecipseHistory
            // 
            this.dgvRecipseHistory.AllowUserToAddRows = false;
            this.dgvRecipseHistory.AllowUserToDeleteRows = false;
            this.dgvRecipseHistory.AutoGenerateColumns = false;
            this.dgvRecipseHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRecipseHistory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.recipesHistoryIDDataGridViewTextBoxColumn,
            this.recipesIDDataGridViewComboBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.recipesHistoryByDataGridViewComboBoxColumn});
            this.dgvRecipseHistory.DataSource = this.recipesHistoryBindingSource;
            this.dgvRecipseHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRecipseHistory.Location = new System.Drawing.Point(3, 16);
            this.dgvRecipseHistory.Name = "dgvRecipseHistory";
            this.dgvRecipseHistory.ReadOnly = true;
            this.dgvRecipseHistory.Size = new System.Drawing.Size(550, 310);
            this.dgvRecipseHistory.TabIndex = 2;
            this.dgvRecipseHistory.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvRecipseHistory_CellMouseDoubleClick);
            // 
            // stockBindingSource
            // 
            this.stockBindingSource.DataMember = "Stock";
            this.stockBindingSource.DataSource = this.farmManageDataSet;
            // 
            // usersViewBindingSource
            // 
            this.usersViewBindingSource.DataMember = "UsersView";
            this.usersViewBindingSource.DataSource = this.farmManageDataSet;
            // 
            // recipesHistoryBindingSource
            // 
            this.recipesHistoryBindingSource.DataMember = "RecipesHistory";
            this.recipesHistoryBindingSource.DataSource = this.farmManageDataSet;
            // 
            // pnlFooter
            // 
            this.pnlFooter.Controls.Add(this.btnClose);
            this.pnlFooter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFooter.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.pnlFooter.Location = new System.Drawing.Point(4, 473);
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.Padding = new System.Windows.Forms.Padding(3);
            this.pnlFooter.Size = new System.Drawing.Size(576, 34);
            this.pnlFooter.TabIndex = 2;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(492, 6);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "ปิด";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
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
            // stockTableAdapter
            // 
            this.stockTableAdapter.ClearBeforeFill = true;
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
            // recipesIDDataGridViewComboBoxColumn
            // 
            this.recipesIDDataGridViewComboBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.recipesIDDataGridViewComboBoxColumn.DataPropertyName = "RecipesID";
            this.recipesIDDataGridViewComboBoxColumn.DataSource = this.recipesBindingSource;
            this.recipesIDDataGridViewComboBoxColumn.DisplayMember = "Name";
            this.recipesIDDataGridViewComboBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.recipesIDDataGridViewComboBoxColumn.HeaderText = "ชื่อสูตร";
            this.recipesIDDataGridViewComboBoxColumn.MinimumWidth = 100;
            this.recipesIDDataGridViewComboBoxColumn.Name = "recipesIDDataGridViewComboBoxColumn";
            this.recipesIDDataGridViewComboBoxColumn.ReadOnly = true;
            this.recipesIDDataGridViewComboBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.recipesIDDataGridViewComboBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.recipesIDDataGridViewComboBoxColumn.ValueMember = "RecipesID";
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            dataGridViewCellStyle1.Format = "D";
            dataGridViewCellStyle1.NullValue = null;
            this.dateDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.dateDataGridViewTextBoxColumn.HeaderText = "วันที";
            this.dateDataGridViewTextBoxColumn.MinimumWidth = 100;
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // recipesHistoryByDataGridViewComboBoxColumn
            // 
            this.recipesHistoryByDataGridViewComboBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.recipesHistoryByDataGridViewComboBoxColumn.DataPropertyName = "RecipesHistoryBy";
            this.recipesHistoryByDataGridViewComboBoxColumn.DataSource = this.usersViewBindingSource;
            this.recipesHistoryByDataGridViewComboBoxColumn.DisplayMember = "Name";
            this.recipesHistoryByDataGridViewComboBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.recipesHistoryByDataGridViewComboBoxColumn.HeaderText = "โดย";
            this.recipesHistoryByDataGridViewComboBoxColumn.MinimumWidth = 100;
            this.recipesHistoryByDataGridViewComboBoxColumn.Name = "recipesHistoryByDataGridViewComboBoxColumn";
            this.recipesHistoryByDataGridViewComboBoxColumn.ReadOnly = true;
            this.recipesHistoryByDataGridViewComboBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.recipesHistoryByDataGridViewComboBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.recipesHistoryByDataGridViewComboBoxColumn.ValueMember = "UserID";
            // 
            // RecipesManageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 511);
            this.Controls.Add(this.pnlMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RecipesManageForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "จัดการสูตรอาหาร";
            this.Load += new System.EventHandler(this.RecipesManageForm_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.pnlContent.ResumeLayout(false);
            this.pnlContentOption.ResumeLayout(false);
            this.tcMain.ResumeLayout(false);
            this.tabList.ResumeLayout(false);
            this.gbxRecipse.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecipse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.recipesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.farmManageDataSet)).EndInit();
            this.tabHistory.ResumeLayout(false);
            this.cbxHistory.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecipseHistory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.recipesHistoryBindingSource)).EndInit();
            this.pnlFooter.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel pnlMain;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.FlowLayoutPanel pnlFooter;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TableLayoutPanel pnlContent;
        private System.Windows.Forms.FlowLayoutPanel pnlContentOption;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSubStock;
        private System.Windows.Forms.TabControl tcMain;
        private System.Windows.Forms.TabPage tabList;
        private System.Windows.Forms.TabPage tabHistory;
        private Database.FarmManageDataSet farmManageDataSet;
        private System.Windows.Forms.BindingSource recipesBindingSource;
        private Database.FarmManageDataSetTableAdapters.RecipesTableAdapter recipesTableAdapter;
        private System.Windows.Forms.BindingSource recipesHistoryBindingSource;
        private Database.FarmManageDataSetTableAdapters.RecipesHistoryTableAdapter recipesHistoryTableAdapter;
        private System.Windows.Forms.BindingSource usersViewBindingSource;
        private Database.FarmManageDataSetTableAdapters.UsersViewTableAdapter usersViewTableAdapter;
        private System.Windows.Forms.BindingSource stockBindingSource;
        private Database.FarmManageDataSetTableAdapters.StockTableAdapter stockTableAdapter;
        private System.Windows.Forms.GroupBox cbxHistory;
        private System.Windows.Forms.DataGridView dgvRecipseHistory;
        private System.Windows.Forms.GroupBox gbxRecipse;
        private System.Windows.Forms.DataGridView dgvRecipse;
        private System.Windows.Forms.DataGridViewTextBoxColumn recipesIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn recipesHistoryIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn recipesIDDataGridViewComboBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn recipesHistoryByDataGridViewComboBoxColumn;
    }
}
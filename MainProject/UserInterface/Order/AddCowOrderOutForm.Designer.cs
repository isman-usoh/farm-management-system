namespace MainProject.UserInterface.Order
{
    partial class AddCowOrderOutForm
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
            this.pnlDetailContent = new System.Windows.Forms.TableLayoutPanel();
            this.lblCorral = new System.Windows.Forms.Label();
            this.lblGene = new System.Windows.Forms.Label();
            this.cbxGene = new System.Windows.Forms.ComboBox();
            this.cbxCorral = new System.Windows.Forms.ComboBox();
            this.lblSex = new System.Windows.Forms.Label();
            this.cbxCowSex = new System.Windows.Forms.ComboBox();
            this.dgvList = new System.Windows.Forms.DataGridView();
            this.colCowID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCowNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCowCorral = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.corralBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.farmManageDataSet = new MainProject.Database.FarmManageDataSet();
            this.colCowGene = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.geneBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colCowSex = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.colCowOrderInAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCowOrderOutAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblSearch = new System.Windows.Forms.Label();
            this.tbxSearch = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlFooter = new System.Windows.Forms.FlowLayoutPanel();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.geneTableAdapter = new MainProject.Database.FarmManageDataSetTableAdapters.GeneTableAdapter();
            this.corralTableAdapter = new MainProject.Database.FarmManageDataSetTableAdapters.CorralTableAdapter();
            this.cowTableAdapter1 = new MainProject.Database.FarmManageDataSetTableAdapters.CowTableAdapter();
            this.pnlMain.SuspendLayout();
            this.pnlDetailContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.corralBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.farmManageDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.geneBindingSource)).BeginInit();
            this.pnlFooter.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.pnlMain.ColumnCount = 1;
            this.pnlMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlMain.Controls.Add(this.pnlDetailContent, 0, 1);
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
            this.pnlDetailContent.Controls.Add(this.lblCorral, 4, 1);
            this.pnlDetailContent.Controls.Add(this.lblGene, 1, 3);
            this.pnlDetailContent.Controls.Add(this.cbxGene, 2, 3);
            this.pnlDetailContent.Controls.Add(this.cbxCorral, 4, 1);
            this.pnlDetailContent.Controls.Add(this.lblSex, 4, 3);
            this.pnlDetailContent.Controls.Add(this.cbxCowSex, 5, 3);
            this.pnlDetailContent.Controls.Add(this.dgvList, 0, 5);
            this.pnlDetailContent.Controls.Add(this.lblSearch, 1, 1);
            this.pnlDetailContent.Controls.Add(this.tbxSearch, 2, 1);
            this.pnlDetailContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDetailContent.Location = new System.Drawing.Point(4, 65);
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
            this.pnlDetailContent.Size = new System.Drawing.Size(586, 411);
            this.pnlDetailContent.TabIndex = 4;
            // 
            // lblCorral
            // 
            this.lblCorral.AutoSize = true;
            this.lblCorral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCorral.Location = new System.Drawing.Point(299, 10);
            this.lblCorral.Name = "lblCorral";
            this.lblCorral.Size = new System.Drawing.Size(80, 25);
            this.lblCorral.TabIndex = 0;
            this.lblCorral.Text = "คอก";
            this.lblCorral.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblGene
            // 
            this.lblGene.AutoSize = true;
            this.lblGene.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblGene.Location = new System.Drawing.Point(31, 38);
            this.lblGene.Name = "lblGene";
            this.lblGene.Size = new System.Drawing.Size(80, 25);
            this.lblGene.TabIndex = 1;
            this.lblGene.Text = "พันธุ์";
            this.lblGene.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbxGene
            // 
            this.cbxGene.DisplayMember = "Value";
            this.cbxGene.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbxGene.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxGene.FormattingEnabled = true;
            this.cbxGene.Location = new System.Drawing.Point(117, 41);
            this.cbxGene.Name = "cbxGene";
            this.cbxGene.Size = new System.Drawing.Size(166, 21);
            this.cbxGene.TabIndex = 5;
            this.cbxGene.ValueMember = "Key";
            // 
            // cbxCorral
            // 
            this.cbxCorral.DisplayMember = "Value";
            this.cbxCorral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbxCorral.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCorral.FormattingEnabled = true;
            this.cbxCorral.Location = new System.Drawing.Point(385, 13);
            this.cbxCorral.Name = "cbxCorral";
            this.cbxCorral.Size = new System.Drawing.Size(166, 21);
            this.cbxCorral.TabIndex = 8;
            this.cbxCorral.ValueMember = "Key";
            // 
            // lblSex
            // 
            this.lblSex.AutoSize = true;
            this.lblSex.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSex.Location = new System.Drawing.Point(299, 38);
            this.lblSex.Name = "lblSex";
            this.lblSex.Size = new System.Drawing.Size(80, 25);
            this.lblSex.TabIndex = 18;
            this.lblSex.Text = "เพศ";
            this.lblSex.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbxCowSex
            // 
            this.cbxCowSex.DisplayMember = "Value";
            this.cbxCowSex.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbxCowSex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCowSex.FormattingEnabled = true;
            this.cbxCowSex.Location = new System.Drawing.Point(385, 41);
            this.cbxCowSex.Name = "cbxCowSex";
            this.cbxCowSex.Size = new System.Drawing.Size(166, 21);
            this.cbxCowSex.TabIndex = 19;
            this.cbxCowSex.ValueMember = "Key";
            // 
            // dgvList
            // 
            this.dgvList.AllowUserToAddRows = false;
            this.dgvList.AllowUserToDeleteRows = false;
            this.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCowID,
            this.colCowNO,
            this.colCowCorral,
            this.colCowGene,
            this.colCowSex,
            this.colCowOrderInAmount,
            this.colCowOrderOutAmount});
            this.pnlDetailContent.SetColumnSpan(this.dgvList, 7);
            this.dgvList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvList.Location = new System.Drawing.Point(3, 69);
            this.dgvList.Name = "dgvList";
            this.dgvList.Size = new System.Drawing.Size(580, 339);
            this.dgvList.TabIndex = 20;
            this.dgvList.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dgvList_CellBeginEdit);
            this.dgvList.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvList_CellEndEdit);
            this.dgvList.SelectionChanged += new System.EventHandler(this.dgvList_SelectionChanged);
            // 
            // colCowID
            // 
            this.colCowID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colCowID.HeaderText = "ID";
            this.colCowID.Name = "colCowID";
            this.colCowID.Visible = false;
            // 
            // colCowNO
            // 
            this.colCowNO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle1.NullValue = "0000-0000";
            this.colCowNO.DefaultCellStyle = dataGridViewCellStyle1;
            this.colCowNO.HeaderText = "NO";
            this.colCowNO.Name = "colCowNO";
            this.colCowNO.ReadOnly = true;
            // 
            // colCowCorral
            // 
            this.colCowCorral.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colCowCorral.DataSource = this.corralBindingSource;
            this.colCowCorral.DisplayMember = "Name";
            this.colCowCorral.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.colCowCorral.HeaderText = "คอก";
            this.colCowCorral.Name = "colCowCorral";
            this.colCowCorral.ReadOnly = true;
            this.colCowCorral.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colCowCorral.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colCowCorral.ValueMember = "CorralID";
            // 
            // corralBindingSource
            // 
            this.corralBindingSource.DataMember = "Corral";
            this.corralBindingSource.DataSource = this.farmManageDataSet;
            // 
            // farmManageDataSet
            // 
            this.farmManageDataSet.DataSetName = "FarmManageDataSet";
            this.farmManageDataSet.Locale = new System.Globalization.CultureInfo("en");
            this.farmManageDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // colCowGene
            // 
            this.colCowGene.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colCowGene.DataSource = this.geneBindingSource;
            this.colCowGene.DisplayMember = "Name";
            this.colCowGene.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.colCowGene.HeaderText = "พันธุ์";
            this.colCowGene.Name = "colCowGene";
            this.colCowGene.ReadOnly = true;
            this.colCowGene.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colCowGene.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colCowGene.ValueMember = "GeneID";
            // 
            // geneBindingSource
            // 
            this.geneBindingSource.DataMember = "Gene";
            this.geneBindingSource.DataSource = this.farmManageDataSet;
            // 
            // colCowSex
            // 
            this.colCowSex.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colCowSex.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.colCowSex.HeaderText = "เพศ";
            this.colCowSex.Name = "colCowSex";
            this.colCowSex.ReadOnly = true;
            this.colCowSex.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colCowSex.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // colCowOrderInAmount
            // 
            this.colCowOrderInAmount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle2.Format = "C2";
            dataGridViewCellStyle2.NullValue = "0";
            this.colCowOrderInAmount.DefaultCellStyle = dataGridViewCellStyle2;
            this.colCowOrderInAmount.HeaderText = "ราคาซื้อ";
            this.colCowOrderInAmount.MaxInputLength = 16;
            this.colCowOrderInAmount.Name = "colCowOrderInAmount";
            this.colCowOrderInAmount.ReadOnly = true;
            // 
            // colCowOrderOutAmount
            // 
            this.colCowOrderOutAmount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle3.Format = "C2";
            dataGridViewCellStyle3.NullValue = "0";
            this.colCowOrderOutAmount.DefaultCellStyle = dataGridViewCellStyle3;
            this.colCowOrderOutAmount.HeaderText = "ราคาขาย*";
            this.colCowOrderOutAmount.MaxInputLength = 16;
            this.colCowOrderOutAmount.MinimumWidth = 100;
            this.colCowOrderOutAmount.Name = "colCowOrderOutAmount";
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSearch.Location = new System.Drawing.Point(31, 10);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(80, 25);
            this.lblSearch.TabIndex = 21;
            this.lblSearch.Text = "ค้นหา";
            this.lblSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbxSearch
            // 
            this.tbxSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxSearch.Location = new System.Drawing.Point(117, 13);
            this.tbxSearch.Name = "tbxSearch";
            this.tbxSearch.Size = new System.Drawing.Size(166, 20);
            this.tbxSearch.TabIndex = 23;
            this.tbxSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxSearch_KeyPress);
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
            this.lblTitle.Text = "เพิ่มรายการขาย";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlFooter
            // 
            this.pnlFooter.Controls.Add(this.btnClose);
            this.pnlFooter.Controls.Add(this.btnSave);
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
            this.btnClose.Text = "ยกเลิก";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.Location = new System.Drawing.Point(421, 6);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "เพิ่ม";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // geneTableAdapter
            // 
            this.geneTableAdapter.ClearBeforeFill = true;
            // 
            // corralTableAdapter
            // 
            this.corralTableAdapter.ClearBeforeFill = true;
            // 
            // cowTableAdapter1
            // 
            this.cowTableAdapter1.ClearBeforeFill = true;
            // 
            // AddCowOrderOutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 521);
            this.Controls.Add(this.pnlMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddCowOrderOutForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "เพิ่มรายการขาย";
            this.Load += new System.EventHandler(this.AddCowOrderInForm_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.pnlDetailContent.ResumeLayout(false);
            this.pnlDetailContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.corralBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.farmManageDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.geneBindingSource)).EndInit();
            this.pnlFooter.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel pnlMain;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.FlowLayoutPanel pnlFooter;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TableLayoutPanel pnlDetailContent;
        private System.Windows.Forms.Label lblCorral;
        private System.Windows.Forms.Label lblGene;
        private System.Windows.Forms.ComboBox cbxGene;
        private System.Windows.Forms.ComboBox cbxCorral;
        private Database.FarmManageDataSet farmManageDataSet;
        private System.Windows.Forms.BindingSource geneBindingSource;
        private Database.FarmManageDataSetTableAdapters.GeneTableAdapter geneTableAdapter;
        private System.Windows.Forms.BindingSource corralBindingSource;
        private Database.FarmManageDataSetTableAdapters.CorralTableAdapter corralTableAdapter;
        private System.Windows.Forms.Label lblSex;
        private System.Windows.Forms.ComboBox cbxCowSex;
        private System.Windows.Forms.DataGridView dgvList;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox tbxSearch;
        private Database.FarmManageDataSetTableAdapters.CowTableAdapter cowTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCowID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCowNO;
        private System.Windows.Forms.DataGridViewComboBoxColumn colCowCorral;
        private System.Windows.Forms.DataGridViewComboBoxColumn colCowGene;
        private System.Windows.Forms.DataGridViewComboBoxColumn colCowSex;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCowOrderInAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCowOrderOutAmount;
    }
}
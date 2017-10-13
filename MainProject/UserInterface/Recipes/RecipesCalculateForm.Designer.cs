namespace MainProject.UserInterface.Recipes
{
    partial class RecipesCalculateForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RecipesCalculateForm));
            this.pnlFooter = new System.Windows.Forms.FlowLayoutPanel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlMain = new System.Windows.Forms.TableLayoutPanel();
            this.pnlContent = new System.Windows.Forms.TableLayoutPanel();
            this.gbxDetail = new System.Windows.Forms.GroupBox();
            this.pnlDetailContent = new System.Windows.Forms.TableLayoutPanel();
            this.lblRecipse = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblUnit = new System.Windows.Forms.Label();
            this.cbxRecipse = new System.Windows.Forms.ComboBox();
            this.recipesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.farmManageDataSet = new MainProject.Database.FarmManageDataSet();
            this.tbxPercen = new System.Windows.Forms.TextBox();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.lblBy = new System.Windows.Forms.Label();
            this.cbxBy = new System.Windows.Forms.ComboBox();
            this.usersViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gbxDescription = new System.Windows.Forms.GroupBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.usersViewTableAdapter = new MainProject.Database.FarmManageDataSetTableAdapters.UsersViewTableAdapter();
            this.stockTableAdapter = new MainProject.Database.FarmManageDataSetTableAdapters.StockTableAdapter();
            this.stockRemoveTableAdapter = new MainProject.Database.FarmManageDataSetTableAdapters.StockRemoveTableAdapter();
            this.recipesListHistoryTableAdapter = new MainProject.Database.FarmManageDataSetTableAdapters.RecipesListHistoryTableAdapter();
            this.recipesHistoryTableAdapter = new MainProject.Database.FarmManageDataSetTableAdapters.RecipesHistoryTableAdapter();
            this.recipesTableAdapter = new MainProject.Database.FarmManageDataSetTableAdapters.RecipesTableAdapter();
            this.pnlFooter.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.gbxDetail.SuspendLayout();
            this.pnlDetailContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.recipesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.farmManageDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersViewBindingSource)).BeginInit();
            this.gbxDescription.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlFooter
            // 
            this.pnlFooter.Controls.Add(this.btnCancel);
            this.pnlFooter.Controls.Add(this.btnCalculate);
            this.pnlFooter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFooter.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.pnlFooter.Location = new System.Drawing.Point(4, 333);
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.Padding = new System.Windows.Forms.Padding(3);
            this.pnlFooter.Size = new System.Drawing.Size(436, 34);
            this.pnlFooter.TabIndex = 1;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(352, 6);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "ยกเลิก";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(271, 6);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 1;
            this.btnCalculate.Text = "คำนวณ";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
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
            this.lblTitle.Size = new System.Drawing.Size(436, 60);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "คำนวณสูตรอาหาร";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlMain
            // 
            this.pnlMain.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.pnlMain.ColumnCount = 1;
            this.pnlMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.pnlMain.Controls.Add(this.lblTitle, 0, 0);
            this.pnlMain.Controls.Add(this.pnlFooter, 0, 2);
            this.pnlMain.Controls.Add(this.pnlContent, 0, 1);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.RowCount = 3;
            this.pnlMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.pnlMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.pnlMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.pnlMain.Size = new System.Drawing.Size(444, 371);
            this.pnlMain.TabIndex = 1;
            // 
            // pnlContent
            // 
            this.pnlContent.ColumnCount = 1;
            this.pnlContent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlContent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.pnlContent.Controls.Add(this.gbxDetail, 0, 0);
            this.pnlContent.Controls.Add(this.gbxDescription, 0, 1);
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(4, 65);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.RowCount = 2;
            this.pnlContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 57.37052F));
            this.pnlContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 42.62948F));
            this.pnlContent.Size = new System.Drawing.Size(436, 261);
            this.pnlContent.TabIndex = 2;
            // 
            // gbxDetail
            // 
            this.gbxDetail.Controls.Add(this.pnlDetailContent);
            this.gbxDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbxDetail.Location = new System.Drawing.Point(3, 3);
            this.gbxDetail.Name = "gbxDetail";
            this.gbxDetail.Size = new System.Drawing.Size(430, 143);
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
            this.pnlDetailContent.Controls.Add(this.lblRecipse, 1, 1);
            this.pnlDetailContent.Controls.Add(this.lblDate, 1, 5);
            this.pnlDetailContent.Controls.Add(this.lblUnit, 1, 7);
            this.pnlDetailContent.Controls.Add(this.cbxRecipse, 2, 1);
            this.pnlDetailContent.Controls.Add(this.tbxPercen, 2, 7);
            this.pnlDetailContent.Controls.Add(this.dtpDate, 2, 5);
            this.pnlDetailContent.Controls.Add(this.lblBy, 1, 3);
            this.pnlDetailContent.Controls.Add(this.cbxBy, 2, 3);
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
            this.pnlDetailContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 3F));
            this.pnlDetailContent.Size = new System.Drawing.Size(424, 124);
            this.pnlDetailContent.TabIndex = 3;
            // 
            // lblRecipse
            // 
            this.lblRecipse.AutoSize = true;
            this.lblRecipse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblRecipse.Location = new System.Drawing.Point(45, 10);
            this.lblRecipse.Name = "lblRecipse";
            this.lblRecipse.Size = new System.Drawing.Size(100, 25);
            this.lblRecipse.TabIndex = 0;
            this.lblRecipse.Text = "สูตร";
            this.lblRecipse.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDate.Location = new System.Drawing.Point(45, 66);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(100, 25);
            this.lblDate.TabIndex = 1;
            this.lblDate.Text = "วันที่";
            this.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblUnit
            // 
            this.lblUnit.AutoSize = true;
            this.lblUnit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblUnit.Location = new System.Drawing.Point(45, 94);
            this.lblUnit.Name = "lblUnit";
            this.lblUnit.Size = new System.Drawing.Size(100, 25);
            this.lblUnit.TabIndex = 2;
            this.lblUnit.Text = "อัตราคำนวน";
            this.lblUnit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbxRecipse
            // 
            this.cbxRecipse.DataSource = this.recipesBindingSource;
            this.cbxRecipse.DisplayMember = "Name";
            this.cbxRecipse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbxRecipse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxRecipse.FormattingEnabled = true;
            this.cbxRecipse.Location = new System.Drawing.Point(151, 13);
            this.cbxRecipse.Name = "cbxRecipse";
            this.cbxRecipse.Size = new System.Drawing.Size(227, 21);
            this.cbxRecipse.TabIndex = 5;
            this.cbxRecipse.ValueMember = "RecipesID";
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
            // tbxPercen
            // 
            this.tbxPercen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxPercen.Location = new System.Drawing.Point(151, 97);
            this.tbxPercen.Name = "tbxPercen";
            this.tbxPercen.ReadOnly = true;
            this.tbxPercen.Size = new System.Drawing.Size(227, 20);
            this.tbxPercen.TabIndex = 4;
            this.tbxPercen.Text = "100";
            this.tbxPercen.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxPercen_KeyPress);
            // 
            // dtpDate
            // 
            this.dtpDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.Location = new System.Drawing.Point(151, 69);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(227, 20);
            this.dtpDate.TabIndex = 6;
            // 
            // lblBy
            // 
            this.lblBy.AutoSize = true;
            this.lblBy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblBy.Location = new System.Drawing.Point(45, 38);
            this.lblBy.Name = "lblBy";
            this.lblBy.Size = new System.Drawing.Size(100, 25);
            this.lblBy.TabIndex = 7;
            this.lblBy.Text = "โดย";
            this.lblBy.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbxBy
            // 
            this.cbxBy.DataSource = this.usersViewBindingSource;
            this.cbxBy.DisplayMember = "Name";
            this.cbxBy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbxBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxBy.FormattingEnabled = true;
            this.cbxBy.Location = new System.Drawing.Point(151, 41);
            this.cbxBy.Name = "cbxBy";
            this.cbxBy.Size = new System.Drawing.Size(227, 21);
            this.cbxBy.TabIndex = 8;
            this.cbxBy.ValueMember = "UserID";
            // 
            // usersViewBindingSource
            // 
            this.usersViewBindingSource.DataMember = "UsersView";
            this.usersViewBindingSource.DataSource = this.farmManageDataSet;
            // 
            // gbxDescription
            // 
            this.gbxDescription.Controls.Add(this.lblDescription);
            this.gbxDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbxDescription.Location = new System.Drawing.Point(3, 152);
            this.gbxDescription.Name = "gbxDescription";
            this.gbxDescription.Size = new System.Drawing.Size(430, 106);
            this.gbxDescription.TabIndex = 1;
            this.gbxDescription.TabStop = false;
            this.gbxDescription.Text = "คำอธิบาย";
            // 
            // lblDescription
            // 
            this.lblDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDescription.Location = new System.Drawing.Point(3, 16);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(424, 87);
            this.lblDescription.TabIndex = 0;
            this.lblDescription.Text = "ในการคำนวนสูตรอาหารจะคิดเป็นร้อยละ ตามจำนวนของสูตรนั้นๆ";
            // 
            // usersViewTableAdapter
            // 
            this.usersViewTableAdapter.ClearBeforeFill = true;
            // 
            // stockTableAdapter
            // 
            this.stockTableAdapter.ClearBeforeFill = true;
            // 
            // stockRemoveTableAdapter
            // 
            this.stockRemoveTableAdapter.ClearBeforeFill = true;
            // 
            // recipesListHistoryTableAdapter
            // 
            this.recipesListHistoryTableAdapter.ClearBeforeFill = true;
            // 
            // recipesHistoryTableAdapter
            // 
            this.recipesHistoryTableAdapter.ClearBeforeFill = true;
            // 
            // recipesTableAdapter
            // 
            this.recipesTableAdapter.ClearBeforeFill = true;
            // 
            // RecipesCalculateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 371);
            this.Controls.Add(this.pnlMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RecipesCalculateForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "คำนวณสูตรอาหาร";
            this.Load += new System.EventHandler(this.RecipesCalculateForm_Load);
            this.pnlFooter.ResumeLayout(false);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.pnlContent.ResumeLayout(false);
            this.gbxDetail.ResumeLayout(false);
            this.pnlDetailContent.ResumeLayout(false);
            this.pnlDetailContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.recipesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.farmManageDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersViewBindingSource)).EndInit();
            this.gbxDescription.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel pnlFooter;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TableLayoutPanel pnlMain;
        private System.Windows.Forms.TableLayoutPanel pnlContent;
        private System.Windows.Forms.GroupBox gbxDetail;
        private System.Windows.Forms.TableLayoutPanel pnlDetailContent;
        private System.Windows.Forms.Label lblRecipse;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblUnit;
        private System.Windows.Forms.ComboBox cbxRecipse;
        private System.Windows.Forms.TextBox tbxPercen;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.GroupBox gbxDescription;
        private System.Windows.Forms.Label lblDescription;
        private Database.FarmManageDataSet farmManageDataSet;
        private System.Windows.Forms.Label lblBy;
        private System.Windows.Forms.ComboBox cbxBy;
        private System.Windows.Forms.BindingSource usersViewBindingSource;
        private Database.FarmManageDataSetTableAdapters.UsersViewTableAdapter usersViewTableAdapter;
        private Database.FarmManageDataSetTableAdapters.StockTableAdapter stockTableAdapter;
        private Database.FarmManageDataSetTableAdapters.StockRemoveTableAdapter stockRemoveTableAdapter;
        private Database.FarmManageDataSetTableAdapters.RecipesListHistoryTableAdapter recipesListHistoryTableAdapter;
        private Database.FarmManageDataSetTableAdapters.RecipesHistoryTableAdapter recipesHistoryTableAdapter;
        private System.Windows.Forms.BindingSource recipesBindingSource;
        private Database.FarmManageDataSetTableAdapters.RecipesTableAdapter recipesTableAdapter;

    }
}
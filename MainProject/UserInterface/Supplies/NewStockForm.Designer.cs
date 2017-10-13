namespace MainProject.UserInterface.Supplies
{
    partial class NewStockForm
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
            this.pnlDetailContent = new System.Windows.Forms.TableLayoutPanel();
            this.lblDisease = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblUnit = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.cbxSuppliesType = new System.Windows.Forms.ComboBox();
            this.stockBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.farmManageDataSet = new MainProject.Database.FarmManageDataSet();
            this.tbxUnit = new System.Windows.Forms.TextBox();
            this.tbxDescription = new System.Windows.Forms.TextBox();
            this.tbxSuppliesName = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlFooter = new System.Windows.Forms.FlowLayoutPanel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.stockTableAdapter = new MainProject.Database.FarmManageDataSetTableAdapters.StockTableAdapter();
            this.pnlMain.SuspendLayout();
            this.pnlDetailContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stockBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.farmManageDataSet)).BeginInit();
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
            this.pnlMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.pnlMain.Size = new System.Drawing.Size(444, 371);
            this.pnlMain.TabIndex = 1;
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
            this.pnlDetailContent.Controls.Add(this.cbxSuppliesType, 2, 3);
            this.pnlDetailContent.Controls.Add(this.tbxUnit, 2, 5);
            this.pnlDetailContent.Controls.Add(this.tbxDescription, 2, 7);
            this.pnlDetailContent.Controls.Add(this.tbxSuppliesName, 2, 1);
            this.pnlDetailContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDetailContent.Location = new System.Drawing.Point(4, 65);
            this.pnlDetailContent.Name = "pnlDetailContent";
            this.pnlDetailContent.RowCount = 13;
            this.pnlDetailContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
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
            this.pnlDetailContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.pnlDetailContent.Size = new System.Drawing.Size(436, 261);
            this.pnlDetailContent.TabIndex = 2;
            // 
            // lblDisease
            // 
            this.lblDisease.AutoSize = true;
            this.lblDisease.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDisease.Location = new System.Drawing.Point(46, 48);
            this.lblDisease.Name = "lblDisease";
            this.lblDisease.Size = new System.Drawing.Size(103, 25);
            this.lblDisease.TabIndex = 0;
            this.lblDisease.Text = "ชื่อพัสดุ *";
            this.lblDisease.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDate.Location = new System.Drawing.Point(46, 76);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(103, 25);
            this.lblDate.TabIndex = 1;
            this.lblDate.Text = "ประเภท *";
            this.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblUnit
            // 
            this.lblUnit.AutoSize = true;
            this.lblUnit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblUnit.Location = new System.Drawing.Point(46, 104);
            this.lblUnit.Name = "lblUnit";
            this.lblUnit.Size = new System.Drawing.Size(103, 25);
            this.lblUnit.TabIndex = 2;
            this.lblUnit.Text = "หน่วย *";
            this.lblUnit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDescription.Location = new System.Drawing.Point(46, 132);
            this.lblDescription.Name = "lblDescription";
            this.pnlDetailContent.SetRowSpan(this.lblDescription, 5);
            this.lblDescription.Size = new System.Drawing.Size(103, 81);
            this.lblDescription.TabIndex = 3;
            this.lblDescription.Text = "รายละเอียด";
            this.lblDescription.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbxSuppliesType
            // 
            this.cbxSuppliesType.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.stockBindingSource, "Type", true));
            this.cbxSuppliesType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbxSuppliesType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSuppliesType.FormattingEnabled = true;
            this.cbxSuppliesType.Location = new System.Drawing.Point(155, 79);
            this.cbxSuppliesType.Name = "cbxSuppliesType";
            this.cbxSuppliesType.Size = new System.Drawing.Size(233, 21);
            this.cbxSuppliesType.TabIndex = 5;
            this.cbxSuppliesType.Validating += new System.ComponentModel.CancelEventHandler(this.cbxSuppliesType_Validating);
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
            this.tbxUnit.Location = new System.Drawing.Point(155, 107);
            this.tbxUnit.Name = "tbxUnit";
            this.tbxUnit.ReadOnly = true;
            this.tbxUnit.Size = new System.Drawing.Size(233, 20);
            this.tbxUnit.TabIndex = 4;
            this.tbxUnit.Text = "0";
            // 
            // tbxDescription
            // 
            this.tbxDescription.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.stockBindingSource, "Description", true));
            this.tbxDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxDescription.Location = new System.Drawing.Point(155, 135);
            this.tbxDescription.MaxLength = 512;
            this.tbxDescription.Multiline = true;
            this.tbxDescription.Name = "tbxDescription";
            this.pnlDetailContent.SetRowSpan(this.tbxDescription, 5);
            this.tbxDescription.Size = new System.Drawing.Size(233, 75);
            this.tbxDescription.TabIndex = 7;
            // 
            // tbxSuppliesName
            // 
            this.tbxSuppliesName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.stockBindingSource, "Name", true));
            this.tbxSuppliesName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxSuppliesName.Location = new System.Drawing.Point(155, 51);
            this.tbxSuppliesName.MaxLength = 32;
            this.tbxSuppliesName.Name = "tbxSuppliesName";
            this.tbxSuppliesName.Size = new System.Drawing.Size(233, 20);
            this.tbxSuppliesName.TabIndex = 8;
            this.tbxSuppliesName.Validating += new System.ComponentModel.CancelEventHandler(this.tbxSuppliesName_Validating);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.White;
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblTitle.Location = new System.Drawing.Point(4, 1);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(436, 60);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "เพิ่มรายการพัสดุใหม่";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlFooter
            // 
            this.pnlFooter.Controls.Add(this.btnCancel);
            this.pnlFooter.Controls.Add(this.btnSave);
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
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(271, 6);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "บันทึก";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // stockTableAdapter
            // 
            this.stockTableAdapter.ClearBeforeFill = true;
            // 
            // NewStockForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.ClientSize = new System.Drawing.Size(444, 371);
            this.Controls.Add(this.pnlMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NewStockForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "เพิ่มรายการพัสดุใหม่";
            this.Load += new System.EventHandler(this.NewStockForm_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.pnlDetailContent.ResumeLayout(false);
            this.pnlDetailContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stockBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.farmManageDataSet)).EndInit();
            this.pnlFooter.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel pnlMain;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.FlowLayoutPanel pnlFooter;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TableLayoutPanel pnlDetailContent;
        private System.Windows.Forms.Label lblDisease;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblUnit;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.ComboBox cbxSuppliesType;
        private System.Windows.Forms.TextBox tbxUnit;
        private System.Windows.Forms.TextBox tbxDescription;
        private System.Windows.Forms.TextBox tbxSuppliesName;
        private Database.FarmManageDataSet farmManageDataSet;
        private System.Windows.Forms.BindingSource stockBindingSource;
        private Database.FarmManageDataSetTableAdapters.StockTableAdapter stockTableAdapter;
    }
}
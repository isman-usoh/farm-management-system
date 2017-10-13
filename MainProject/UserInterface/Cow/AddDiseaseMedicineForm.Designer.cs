namespace MainProject.UserInterface.Cow
{
    partial class AddDiseaseMedicineForm
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlFooter = new System.Windows.Forms.FlowLayoutPanel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.tcMain = new System.Windows.Forms.TabControl();
            this.tabDetail = new System.Windows.Forms.TabPage();
            this.pnlDetailContent = new System.Windows.Forms.TableLayoutPanel();
            this.lblDisease = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblUnit = new System.Windows.Forms.Label();
            this.cbxStock = new System.Windows.Forms.ComboBox();
            this.diseaseMedicineBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.farmManageDataSet = new MainProject.Database.FarmManageDataSet();
            this.stockBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbxUnit = new System.Windows.Forms.TextBox();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.lblBy = new System.Windows.Forms.Label();
            this.cbxBy = new System.Windows.Forms.ComboBox();
            this.usersViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabRecord = new System.Windows.Forms.TabPage();
            this.userLogUC = new MainProject.UserInterface.Control.UserLogUC();
            this.usersViewBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.usersViewBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.diseaseMedicineTableAdapter = new MainProject.Database.FarmManageDataSetTableAdapters.DiseaseMedicineTableAdapter();
            this.usersViewTableAdapter = new MainProject.Database.FarmManageDataSetTableAdapters.UsersViewTableAdapter();
            this.stockTableAdapter = new MainProject.Database.FarmManageDataSetTableAdapters.StockTableAdapter();
            this.pnlMain.SuspendLayout();
            this.pnlFooter.SuspendLayout();
            this.tcMain.SuspendLayout();
            this.tabDetail.SuspendLayout();
            this.pnlDetailContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.diseaseMedicineBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.farmManageDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersViewBindingSource)).BeginInit();
            this.tabRecord.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usersViewBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersViewBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.pnlMain.ColumnCount = 1;
            this.pnlMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlMain.Controls.Add(this.lblTitle, 0, 0);
            this.pnlMain.Controls.Add(this.pnlFooter, 0, 2);
            this.pnlMain.Controls.Add(this.tcMain, 0, 1);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.RowCount = 3;
            this.pnlMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.pnlMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.pnlMain.Size = new System.Drawing.Size(434, 361);
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
            this.lblTitle.Size = new System.Drawing.Size(426, 60);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "การใช้ยารักษาโรค";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlFooter
            // 
            this.pnlFooter.Controls.Add(this.btnCancel);
            this.pnlFooter.Controls.Add(this.btnSave);
            this.pnlFooter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFooter.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.pnlFooter.Location = new System.Drawing.Point(4, 323);
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.Padding = new System.Windows.Forms.Padding(3);
            this.pnlFooter.Size = new System.Drawing.Size(426, 34);
            this.pnlFooter.TabIndex = 1;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(342, 6);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "ยกเลิก";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(261, 6);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "บันทึก";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // tcMain
            // 
            this.tcMain.Controls.Add(this.tabDetail);
            this.tcMain.Controls.Add(this.tabRecord);
            this.tcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcMain.Location = new System.Drawing.Point(4, 65);
            this.tcMain.Name = "tcMain";
            this.tcMain.SelectedIndex = 0;
            this.tcMain.Size = new System.Drawing.Size(426, 251);
            this.tcMain.TabIndex = 2;
            // 
            // tabDetail
            // 
            this.tabDetail.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabDetail.Controls.Add(this.pnlDetailContent);
            this.tabDetail.Location = new System.Drawing.Point(4, 22);
            this.tabDetail.Name = "tabDetail";
            this.tabDetail.Padding = new System.Windows.Forms.Padding(3);
            this.tabDetail.Size = new System.Drawing.Size(418, 225);
            this.tabDetail.TabIndex = 0;
            this.tabDetail.Text = "รายละเอียด";
            // 
            // pnlDetailContent
            // 
            this.pnlDetailContent.ColumnCount = 4;
            this.pnlDetailContent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.pnlDetailContent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.pnlDetailContent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55F));
            this.pnlDetailContent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.pnlDetailContent.Controls.Add(this.lblDisease, 1, 1);
            this.pnlDetailContent.Controls.Add(this.lblDate, 1, 5);
            this.pnlDetailContent.Controls.Add(this.lblUnit, 1, 7);
            this.pnlDetailContent.Controls.Add(this.cbxStock, 2, 1);
            this.pnlDetailContent.Controls.Add(this.tbxUnit, 2, 7);
            this.pnlDetailContent.Controls.Add(this.dtpDate, 2, 5);
            this.pnlDetailContent.Controls.Add(this.lblBy, 1, 3);
            this.pnlDetailContent.Controls.Add(this.cbxBy, 2, 3);
            this.pnlDetailContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDetailContent.Location = new System.Drawing.Point(3, 3);
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
            this.pnlDetailContent.Size = new System.Drawing.Size(412, 219);
            this.pnlDetailContent.TabIndex = 0;
            // 
            // lblDisease
            // 
            this.lblDisease.AutoSize = true;
            this.lblDisease.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDisease.Location = new System.Drawing.Point(44, 10);
            this.lblDisease.Name = "lblDisease";
            this.lblDisease.Size = new System.Drawing.Size(97, 25);
            this.lblDisease.TabIndex = 0;
            this.lblDisease.Text = "ยา *";
            this.lblDisease.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDate.Location = new System.Drawing.Point(44, 66);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(97, 25);
            this.lblDate.TabIndex = 1;
            this.lblDate.Text = "วันที่ *";
            this.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblUnit
            // 
            this.lblUnit.AutoSize = true;
            this.lblUnit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblUnit.Location = new System.Drawing.Point(44, 94);
            this.lblUnit.Name = "lblUnit";
            this.lblUnit.Size = new System.Drawing.Size(97, 25);
            this.lblUnit.TabIndex = 2;
            this.lblUnit.Text = "หน่วย *";
            this.lblUnit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbxStock
            // 
            this.cbxStock.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.diseaseMedicineBindingSource, "StockID", true));
            this.cbxStock.DataSource = this.stockBindingSource;
            this.cbxStock.DisplayMember = "Name";
            this.cbxStock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbxStock.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxStock.FormattingEnabled = true;
            this.cbxStock.Location = new System.Drawing.Point(147, 13);
            this.cbxStock.Name = "cbxStock";
            this.cbxStock.Size = new System.Drawing.Size(220, 21);
            this.cbxStock.TabIndex = 5;
            this.cbxStock.ValueMember = "StockID";
            this.cbxStock.Validating += new System.ComponentModel.CancelEventHandler(this.cbxStock_Validating);
            // 
            // diseaseMedicineBindingSource
            // 
            this.diseaseMedicineBindingSource.DataMember = "DiseaseMedicine";
            this.diseaseMedicineBindingSource.DataSource = this.farmManageDataSet;
            // 
            // farmManageDataSet
            // 
            this.farmManageDataSet.DataSetName = "FarmManageDataSet";
            this.farmManageDataSet.Locale = new System.Globalization.CultureInfo("en");
            this.farmManageDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // stockBindingSource
            // 
            this.stockBindingSource.DataMember = "Stock";
            this.stockBindingSource.DataSource = this.farmManageDataSet;
            // 
            // tbxUnit
            // 
            this.tbxUnit.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.diseaseMedicineBindingSource, "Unit", true));
            this.tbxUnit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxUnit.Location = new System.Drawing.Point(147, 97);
            this.tbxUnit.Name = "tbxUnit";
            this.tbxUnit.Size = new System.Drawing.Size(220, 20);
            this.tbxUnit.TabIndex = 4;
            this.tbxUnit.Text = "0";
            this.tbxUnit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxUnit_KeyPress);
            this.tbxUnit.Validating += new System.ComponentModel.CancelEventHandler(this.tbxUnit_Validating);
            // 
            // dtpDate
            // 
            this.dtpDate.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.diseaseMedicineBindingSource, "Date", true));
            this.dtpDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.Location = new System.Drawing.Point(147, 69);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(220, 20);
            this.dtpDate.TabIndex = 6;
            // 
            // lblBy
            // 
            this.lblBy.AutoSize = true;
            this.lblBy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblBy.Location = new System.Drawing.Point(44, 38);
            this.lblBy.Name = "lblBy";
            this.lblBy.Size = new System.Drawing.Size(97, 25);
            this.lblBy.TabIndex = 8;
            this.lblBy.Text = "โดย *";
            this.lblBy.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbxBy
            // 
            this.cbxBy.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.diseaseMedicineBindingSource, "DiseaseMedicineBy", true));
            this.cbxBy.DataSource = this.usersViewBindingSource;
            this.cbxBy.DisplayMember = "Name";
            this.cbxBy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbxBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxBy.FormattingEnabled = true;
            this.cbxBy.Location = new System.Drawing.Point(147, 41);
            this.cbxBy.Name = "cbxBy";
            this.cbxBy.Size = new System.Drawing.Size(220, 21);
            this.cbxBy.TabIndex = 9;
            this.cbxBy.ValueMember = "UserID";
            this.cbxBy.Validating += new System.ComponentModel.CancelEventHandler(this.cbxStock_Validating);
            // 
            // usersViewBindingSource
            // 
            this.usersViewBindingSource.DataMember = "UsersView";
            this.usersViewBindingSource.DataSource = this.farmManageDataSet;
            // 
            // tabRecord
            // 
            this.tabRecord.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabRecord.Controls.Add(this.userLogUC);
            this.tabRecord.Location = new System.Drawing.Point(4, 22);
            this.tabRecord.Name = "tabRecord";
            this.tabRecord.Padding = new System.Windows.Forms.Padding(3);
            this.tabRecord.Size = new System.Drawing.Size(418, 225);
            this.tabRecord.TabIndex = 1;
            this.tabRecord.Text = "การบันทึก";
            // 
            // userLogUC
            // 
            this.userLogUC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userLogUC.Location = new System.Drawing.Point(3, 3);
            this.userLogUC.Name = "userLogUC";
            this.userLogUC.Size = new System.Drawing.Size(412, 219);
            this.userLogUC.TabIndex = 0;
            // 
            // usersViewBindingSource2
            // 
            this.usersViewBindingSource2.DataMember = "UsersView";
            this.usersViewBindingSource2.DataSource = this.farmManageDataSet;
            // 
            // usersViewBindingSource1
            // 
            this.usersViewBindingSource1.DataMember = "UsersView";
            this.usersViewBindingSource1.DataSource = this.farmManageDataSet;
            // 
            // diseaseMedicineTableAdapter
            // 
            this.diseaseMedicineTableAdapter.ClearBeforeFill = true;
            // 
            // usersViewTableAdapter
            // 
            this.usersViewTableAdapter.ClearBeforeFill = true;
            // 
            // stockTableAdapter
            // 
            this.stockTableAdapter.ClearBeforeFill = true;
            // 
            // AddDiseaseMedicineForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 361);
            this.Controls.Add(this.pnlMain);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddDiseaseMedicineForm";
            this.Text = "การใช้ยารักษาโรค";
            this.Load += new System.EventHandler(this.DiseaseMedicineForm_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.pnlFooter.ResumeLayout(false);
            this.tcMain.ResumeLayout(false);
            this.tabDetail.ResumeLayout(false);
            this.pnlDetailContent.ResumeLayout(false);
            this.pnlDetailContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.diseaseMedicineBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.farmManageDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersViewBindingSource)).EndInit();
            this.tabRecord.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.usersViewBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersViewBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel pnlMain;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.FlowLayoutPanel pnlFooter;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TabControl tcMain;
        private System.Windows.Forms.TabPage tabDetail;
        private System.Windows.Forms.TabPage tabRecord;
        private System.Windows.Forms.TableLayoutPanel pnlDetailContent;
        private System.Windows.Forms.Label lblDisease;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblUnit;
        private System.Windows.Forms.ComboBox cbxStock;
        private System.Windows.Forms.TextBox tbxUnit;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label lblBy;
        private System.Windows.Forms.ComboBox cbxBy;
        private Database.FarmManageDataSet farmManageDataSet;
        private System.Windows.Forms.BindingSource diseaseMedicineBindingSource;
        private Database.FarmManageDataSetTableAdapters.DiseaseMedicineTableAdapter diseaseMedicineTableAdapter;
        private System.Windows.Forms.BindingSource usersViewBindingSource;
        private Database.FarmManageDataSetTableAdapters.UsersViewTableAdapter usersViewTableAdapter;
        private System.Windows.Forms.BindingSource stockBindingSource;
        private Database.FarmManageDataSetTableAdapters.StockTableAdapter stockTableAdapter;
        private System.Windows.Forms.BindingSource usersViewBindingSource1;
        private System.Windows.Forms.BindingSource usersViewBindingSource2;
        private Control.UserLogUC userLogUC;
    }
}
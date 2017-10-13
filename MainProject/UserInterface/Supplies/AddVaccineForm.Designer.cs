namespace MainProject.UserInterface.Supplies
{
    partial class AddVaccineForm
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
            this.gbxDetail = new System.Windows.Forms.GroupBox();
            this.pnlDetailContent = new System.Windows.Forms.TableLayoutPanel();
            this.lblStock = new System.Windows.Forms.Label();
            this.lblBy = new System.Windows.Forms.Label();
            this.lblUnit = new System.Windows.Forms.Label();
            this.cbxBy = new System.Windows.Forms.ComboBox();
            this.vaccineBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.farmManageDataSet = new MainProject.Database.FarmManageDataSet();
            this.usersViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbxUnit = new System.Windows.Forms.TextBox();
            this.cbxStock = new System.Windows.Forms.ComboBox();
            this.stockBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblCow = new System.Windows.Forms.Label();
            this.cbxCow = new System.Windows.Forms.ComboBox();
            this.cowBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabRecord = new System.Windows.Forms.TabPage();
            this.usersViewBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.vaccineTableAdapter = new MainProject.Database.FarmManageDataSetTableAdapters.VaccineTableAdapter();
            this.usersViewTableAdapter = new MainProject.Database.FarmManageDataSetTableAdapters.UsersViewTableAdapter();
            this.stockTableAdapter = new MainProject.Database.FarmManageDataSetTableAdapters.StockTableAdapter();
            this.cowTableAdapter = new MainProject.Database.FarmManageDataSetTableAdapters.CowTableAdapter();
            this.userLogUC = new MainProject.UserInterface.Control.UserLogUC();
            this.pnlMain.SuspendLayout();
            this.pnlFooter.SuspendLayout();
            this.tcMain.SuspendLayout();
            this.tabDetail.SuspendLayout();
            this.gbxDetail.SuspendLayout();
            this.pnlDetailContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vaccineBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.farmManageDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cowBindingSource)).BeginInit();
            this.tabRecord.SuspendLayout();
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
            this.pnlMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.pnlMain.Size = new System.Drawing.Size(444, 371);
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
            this.lblTitle.Size = new System.Drawing.Size(436, 60);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "รายละเอียดการฉีดวัคซีน";
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
            // tcMain
            // 
            this.tcMain.Controls.Add(this.tabDetail);
            this.tcMain.Controls.Add(this.tabRecord);
            this.tcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcMain.Location = new System.Drawing.Point(4, 65);
            this.tcMain.Name = "tcMain";
            this.tcMain.SelectedIndex = 0;
            this.tcMain.Size = new System.Drawing.Size(436, 261);
            this.tcMain.TabIndex = 2;
            // 
            // tabDetail
            // 
            this.tabDetail.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabDetail.Controls.Add(this.gbxDetail);
            this.tabDetail.Location = new System.Drawing.Point(4, 22);
            this.tabDetail.Name = "tabDetail";
            this.tabDetail.Padding = new System.Windows.Forms.Padding(3);
            this.tabDetail.Size = new System.Drawing.Size(428, 235);
            this.tabDetail.TabIndex = 0;
            this.tabDetail.Text = "รายละเอียด";
            // 
            // gbxDetail
            // 
            this.gbxDetail.Controls.Add(this.pnlDetailContent);
            this.gbxDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbxDetail.Location = new System.Drawing.Point(3, 3);
            this.gbxDetail.Name = "gbxDetail";
            this.gbxDetail.Size = new System.Drawing.Size(422, 229);
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
            this.pnlDetailContent.Controls.Add(this.lblStock, 1, 3);
            this.pnlDetailContent.Controls.Add(this.lblBy, 1, 5);
            this.pnlDetailContent.Controls.Add(this.lblUnit, 1, 9);
            this.pnlDetailContent.Controls.Add(this.cbxBy, 2, 5);
            this.pnlDetailContent.Controls.Add(this.tbxUnit, 2, 9);
            this.pnlDetailContent.Controls.Add(this.cbxStock, 2, 3);
            this.pnlDetailContent.Controls.Add(this.dtpDate, 2, 7);
            this.pnlDetailContent.Controls.Add(this.lblDate, 1, 7);
            this.pnlDetailContent.Controls.Add(this.lblCow, 1, 1);
            this.pnlDetailContent.Controls.Add(this.cbxCow, 2, 1);
            this.pnlDetailContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDetailContent.Location = new System.Drawing.Point(3, 16);
            this.pnlDetailContent.Name = "pnlDetailContent";
            this.pnlDetailContent.RowCount = 19;
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
            this.pnlDetailContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.pnlDetailContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 3F));
            this.pnlDetailContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.pnlDetailContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 3F));
            this.pnlDetailContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.pnlDetailContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 3F));
            this.pnlDetailContent.Size = new System.Drawing.Size(416, 210);
            this.pnlDetailContent.TabIndex = 3;
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblStock.Location = new System.Drawing.Point(44, 38);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(98, 25);
            this.lblStock.TabIndex = 0;
            this.lblStock.Text = "ชื่อยา *";
            this.lblStock.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblBy
            // 
            this.lblBy.AutoSize = true;
            this.lblBy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblBy.Location = new System.Drawing.Point(44, 66);
            this.lblBy.Name = "lblBy";
            this.lblBy.Size = new System.Drawing.Size(98, 25);
            this.lblBy.TabIndex = 1;
            this.lblBy.Text = "โดย *";
            this.lblBy.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblUnit
            // 
            this.lblUnit.AutoSize = true;
            this.lblUnit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblUnit.Location = new System.Drawing.Point(44, 122);
            this.lblUnit.Name = "lblUnit";
            this.lblUnit.Size = new System.Drawing.Size(98, 25);
            this.lblUnit.TabIndex = 2;
            this.lblUnit.Text = "จำนวน *";
            this.lblUnit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbxBy
            // 
            this.cbxBy.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.vaccineBindingSource, "VaccineBy", true));
            this.cbxBy.DataSource = this.usersViewBindingSource;
            this.cbxBy.DisplayMember = "Name";
            this.cbxBy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbxBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxBy.FormattingEnabled = true;
            this.cbxBy.Location = new System.Drawing.Point(148, 69);
            this.cbxBy.Name = "cbxBy";
            this.cbxBy.Size = new System.Drawing.Size(222, 21);
            this.cbxBy.TabIndex = 5;
            this.cbxBy.ValueMember = "UserID";
            // 
            // vaccineBindingSource
            // 
            this.vaccineBindingSource.DataMember = "Vaccine";
            this.vaccineBindingSource.DataSource = this.farmManageDataSet;
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
            // tbxUnit
            // 
            this.tbxUnit.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vaccineBindingSource, "Unit", true));
            this.tbxUnit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxUnit.Location = new System.Drawing.Point(148, 125);
            this.tbxUnit.Name = "tbxUnit";
            this.tbxUnit.Size = new System.Drawing.Size(222, 20);
            this.tbxUnit.TabIndex = 4;
            this.tbxUnit.Text = "0";
            this.tbxUnit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxUnit_KeyPress);
            this.tbxUnit.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbxUnit_KeyUp);
            this.tbxUnit.Validating += new System.ComponentModel.CancelEventHandler(this.tbxUnit_Validating);
            // 
            // cbxStock
            // 
            this.cbxStock.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.vaccineBindingSource, "StockID", true));
            this.cbxStock.DataSource = this.stockBindingSource;
            this.cbxStock.DisplayMember = "Name";
            this.cbxStock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbxStock.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxStock.FormattingEnabled = true;
            this.cbxStock.Location = new System.Drawing.Point(148, 41);
            this.cbxStock.Name = "cbxStock";
            this.cbxStock.Size = new System.Drawing.Size(222, 21);
            this.cbxStock.TabIndex = 8;
            this.cbxStock.ValueMember = "StockID";
            // 
            // stockBindingSource
            // 
            this.stockBindingSource.DataMember = "Stock";
            this.stockBindingSource.DataSource = this.farmManageDataSet;
            // 
            // dtpDate
            // 
            this.dtpDate.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.vaccineBindingSource, "Date", true));
            this.dtpDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.Location = new System.Drawing.Point(148, 97);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(222, 20);
            this.dtpDate.TabIndex = 9;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDate.Location = new System.Drawing.Point(44, 94);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(98, 25);
            this.lblDate.TabIndex = 14;
            this.lblDate.Text = "วันที่ *";
            this.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCow
            // 
            this.lblCow.AutoSize = true;
            this.lblCow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCow.Location = new System.Drawing.Point(44, 10);
            this.lblCow.Name = "lblCow";
            this.lblCow.Size = new System.Drawing.Size(98, 25);
            this.lblCow.TabIndex = 15;
            this.lblCow.Text = "โค *";
            this.lblCow.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbxCow
            // 
            this.cbxCow.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.vaccineBindingSource, "CowNO", true));
            this.cbxCow.DataSource = this.cowBindingSource;
            this.cbxCow.DisplayMember = "CowNO";
            this.cbxCow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbxCow.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCow.FormattingEnabled = true;
            this.cbxCow.Location = new System.Drawing.Point(148, 13);
            this.cbxCow.Name = "cbxCow";
            this.cbxCow.Size = new System.Drawing.Size(222, 21);
            this.cbxCow.TabIndex = 16;
            this.cbxCow.ValueMember = "CowNO";
            // 
            // cowBindingSource
            // 
            this.cowBindingSource.DataMember = "Cow";
            this.cowBindingSource.DataSource = this.farmManageDataSet;
            // 
            // tabRecord
            // 
            this.tabRecord.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabRecord.Controls.Add(this.userLogUC);
            this.tabRecord.Location = new System.Drawing.Point(4, 22);
            this.tabRecord.Name = "tabRecord";
            this.tabRecord.Padding = new System.Windows.Forms.Padding(3);
            this.tabRecord.Size = new System.Drawing.Size(428, 235);
            this.tabRecord.TabIndex = 1;
            this.tabRecord.Text = "การบันทึก";
            // 
            // usersViewBindingSource1
            // 
            this.usersViewBindingSource1.DataMember = "UsersView";
            this.usersViewBindingSource1.DataSource = this.farmManageDataSet;
            // 
            // vaccineTableAdapter
            // 
            this.vaccineTableAdapter.ClearBeforeFill = true;
            // 
            // usersViewTableAdapter
            // 
            this.usersViewTableAdapter.ClearBeforeFill = true;
            // 
            // stockTableAdapter
            // 
            this.stockTableAdapter.ClearBeforeFill = true;
            // 
            // cowTableAdapter
            // 
            this.cowTableAdapter.ClearBeforeFill = true;
            // 
            // userLogUC
            // 
            this.userLogUC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userLogUC.Location = new System.Drawing.Point(3, 3);
            this.userLogUC.Name = "userLogUC";
            this.userLogUC.Size = new System.Drawing.Size(422, 229);
            this.userLogUC.TabIndex = 0;
            // 
            // AddVaccineForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.ClientSize = new System.Drawing.Size(444, 371);
            this.Controls.Add(this.pnlMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddVaccineForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "รายละเอียดการฉีดวัคซีน";
            this.Load += new System.EventHandler(this.AddVaccineForm_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.pnlFooter.ResumeLayout(false);
            this.tcMain.ResumeLayout(false);
            this.tabDetail.ResumeLayout(false);
            this.gbxDetail.ResumeLayout(false);
            this.pnlDetailContent.ResumeLayout(false);
            this.pnlDetailContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vaccineBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.farmManageDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cowBindingSource)).EndInit();
            this.tabRecord.ResumeLayout(false);
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
        private System.Windows.Forms.GroupBox gbxDetail;
        private System.Windows.Forms.TableLayoutPanel pnlDetailContent;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.Label lblBy;
        private System.Windows.Forms.Label lblUnit;
        private System.Windows.Forms.ComboBox cbxBy;
        private System.Windows.Forms.TextBox tbxUnit;
        private System.Windows.Forms.ComboBox cbxStock;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.TabPage tabRecord;
        private System.Windows.Forms.Label lblCow;
        private Database.FarmManageDataSet farmManageDataSet;
        private System.Windows.Forms.BindingSource vaccineBindingSource;
        private Database.FarmManageDataSetTableAdapters.VaccineTableAdapter vaccineTableAdapter;
        private System.Windows.Forms.BindingSource usersViewBindingSource;
        private Database.FarmManageDataSetTableAdapters.UsersViewTableAdapter usersViewTableAdapter;
        private System.Windows.Forms.BindingSource stockBindingSource;
        private Database.FarmManageDataSetTableAdapters.StockTableAdapter stockTableAdapter;
        private System.Windows.Forms.ComboBox cbxCow;
        private System.Windows.Forms.BindingSource cowBindingSource;
        private Database.FarmManageDataSetTableAdapters.CowTableAdapter cowTableAdapter;
        private System.Windows.Forms.BindingSource usersViewBindingSource1;
        private Control.UserLogUC userLogUC;
    }
}
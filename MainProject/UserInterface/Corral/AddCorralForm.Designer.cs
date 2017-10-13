namespace MainProject.UserInterface.Corral
{
    partial class AddCorralForm
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
            this.footerPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlContent = new System.Windows.Forms.TableLayoutPanel();
            this.lblName = new System.Windows.Forms.Label();
            this.lblMax = new System.Windows.Forms.Label();
            this.lblCurrent = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.corralBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.farmManageDataSet = new MainProject.Database.FarmManageDataSet();
            this.tbxMax = new System.Windows.Forms.TextBox();
            this.tbxDescription = new System.Windows.Forms.TextBox();
            this.tbxCurrent = new System.Windows.Forms.TextBox();
            this.corralTableAdapter = new MainProject.Database.FarmManageDataSetTableAdapters.CorralTableAdapter();
            this.pnlMain.SuspendLayout();
            this.footerPanel.SuspendLayout();
            this.pnlContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.corralBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.farmManageDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.pnlMain.ColumnCount = 1;
            this.pnlMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.pnlMain.Controls.Add(this.footerPanel, 0, 2);
            this.pnlMain.Controls.Add(this.lblTitle, 0, 0);
            this.pnlMain.Controls.Add(this.pnlContent, 0, 1);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.RowCount = 3;
            this.pnlMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.pnlMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.pnlMain.Size = new System.Drawing.Size(394, 321);
            this.pnlMain.TabIndex = 0;
            // 
            // footerPanel
            // 
            this.footerPanel.Controls.Add(this.btnCancel);
            this.footerPanel.Controls.Add(this.btnSave);
            this.footerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.footerPanel.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.footerPanel.Location = new System.Drawing.Point(4, 283);
            this.footerPanel.Name = "footerPanel";
            this.footerPanel.Padding = new System.Windows.Forms.Padding(3);
            this.footerPanel.Size = new System.Drawing.Size(386, 34);
            this.footerPanel.TabIndex = 0;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(302, 6);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "ยกเลิก";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(221, 6);
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
            this.lblTitle.Size = new System.Drawing.Size(386, 60);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "เพิ่มคอกใหม่";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlContent
            // 
            this.pnlContent.ColumnCount = 4;
            this.pnlContent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.pnlContent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.pnlContent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55F));
            this.pnlContent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.pnlContent.Controls.Add(this.lblName, 1, 1);
            this.pnlContent.Controls.Add(this.lblMax, 1, 3);
            this.pnlContent.Controls.Add(this.lblCurrent, 1, 5);
            this.pnlContent.Controls.Add(this.lblDescription, 1, 7);
            this.pnlContent.Controls.Add(this.tbxName, 2, 1);
            this.pnlContent.Controls.Add(this.tbxMax, 2, 3);
            this.pnlContent.Controls.Add(this.tbxDescription, 2, 7);
            this.pnlContent.Controls.Add(this.tbxCurrent, 2, 5);
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(4, 65);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.RowCount = 13;
            this.pnlContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.pnlContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.pnlContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 3F));
            this.pnlContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.pnlContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 3F));
            this.pnlContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.pnlContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 3F));
            this.pnlContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.pnlContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 3F));
            this.pnlContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.pnlContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 3F));
            this.pnlContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.pnlContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.pnlContent.Size = new System.Drawing.Size(386, 211);
            this.pnlContent.TabIndex = 2;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblName.Location = new System.Drawing.Point(41, 23);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(90, 25);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "ชื่อคอก*";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblMax
            // 
            this.lblMax.AutoSize = true;
            this.lblMax.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMax.Location = new System.Drawing.Point(41, 51);
            this.lblMax.Name = "lblMax";
            this.lblMax.Size = new System.Drawing.Size(90, 25);
            this.lblMax.TabIndex = 1;
            this.lblMax.Text = "ความจุ*";
            this.lblMax.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCurrent
            // 
            this.lblCurrent.AutoSize = true;
            this.lblCurrent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCurrent.Location = new System.Drawing.Point(41, 79);
            this.lblCurrent.Name = "lblCurrent";
            this.lblCurrent.Size = new System.Drawing.Size(90, 25);
            this.lblCurrent.TabIndex = 2;
            this.lblCurrent.Text = "จำนวนปัจจุบัน";
            this.lblCurrent.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDescription.Location = new System.Drawing.Point(41, 107);
            this.lblDescription.Name = "lblDescription";
            this.pnlContent.SetRowSpan(this.lblDescription, 5);
            this.lblDescription.Size = new System.Drawing.Size(90, 81);
            this.lblDescription.TabIndex = 3;
            this.lblDescription.Text = "คำธิบาย";
            this.lblDescription.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbxName
            // 
            this.tbxName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.corralBindingSource, "Name", true));
            this.tbxName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxName.Location = new System.Drawing.Point(137, 26);
            this.tbxName.MaxLength = 32;
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(206, 20);
            this.tbxName.TabIndex = 4;
            this.tbxName.TextChanged += new System.EventHandler(this.tbxName_TextChanged);
            this.tbxName.Validating += new System.ComponentModel.CancelEventHandler(this.tbxName_Validating);
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
            // tbxMax
            // 
            this.tbxMax.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.corralBindingSource, "MaxNum", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "N0"));
            this.tbxMax.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxMax.Location = new System.Drawing.Point(137, 54);
            this.tbxMax.Name = "tbxMax";
            this.tbxMax.Size = new System.Drawing.Size(206, 20);
            this.tbxMax.TabIndex = 5;
            this.tbxMax.Text = "0";
            this.tbxMax.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxMax_KeyPress);
            this.tbxMax.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbxMax_KeyUp);
            this.tbxMax.Validating += new System.ComponentModel.CancelEventHandler(this.tbxMax_Validating);
            // 
            // tbxDescription
            // 
            this.tbxDescription.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.corralBindingSource, "Discription", true));
            this.tbxDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxDescription.Location = new System.Drawing.Point(137, 110);
            this.tbxDescription.MaxLength = 512;
            this.tbxDescription.Multiline = true;
            this.tbxDescription.Name = "tbxDescription";
            this.pnlContent.SetRowSpan(this.tbxDescription, 5);
            this.tbxDescription.Size = new System.Drawing.Size(206, 75);
            this.tbxDescription.TabIndex = 6;
            // 
            // tbxCurrent
            // 
            this.tbxCurrent.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.corralBindingSource, "CurrentNum", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "N0"));
            this.tbxCurrent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxCurrent.Enabled = false;
            this.tbxCurrent.Location = new System.Drawing.Point(137, 82);
            this.tbxCurrent.Name = "tbxCurrent";
            this.tbxCurrent.ReadOnly = true;
            this.tbxCurrent.Size = new System.Drawing.Size(206, 20);
            this.tbxCurrent.TabIndex = 7;
            this.tbxCurrent.Text = "0";
            // 
            // corralTableAdapter
            // 
            this.corralTableAdapter.ClearBeforeFill = true;
            // 
            // AddCorralForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.ClientSize = new System.Drawing.Size(394, 321);
            this.Controls.Add(this.pnlMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddCorralForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "เพิ่มคอกใหม่";
            this.Load += new System.EventHandler(this.AddCorralForm_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.footerPanel.ResumeLayout(false);
            this.pnlContent.ResumeLayout(false);
            this.pnlContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.corralBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.farmManageDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel pnlMain;
        private System.Windows.Forms.FlowLayoutPanel footerPanel;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TableLayoutPanel pnlContent;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblMax;
        private System.Windows.Forms.Label lblCurrent;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.TextBox tbxDescription;
        private Database.FarmManageDataSet farmManageDataSet;
        private System.Windows.Forms.BindingSource corralBindingSource;
        private Database.FarmManageDataSetTableAdapters.CorralTableAdapter corralTableAdapter;
        private System.Windows.Forms.TextBox tbxMax;
        private System.Windows.Forms.TextBox tbxCurrent;
    }
}
namespace MainProject.UserInterface.Order
{
    partial class AddCowOrderInForm
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
            this.lblCorral = new System.Windows.Forms.Label();
            this.lblGene = new System.Windows.Forms.Label();
            this.cbxGene = new System.Windows.Forms.ComboBox();
            this.geneBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.farmManageDataSet = new MainProject.Database.FarmManageDataSet();
            this.cbxCorral = new System.Windows.Forms.ComboBox();
            this.corralBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblDate = new System.Windows.Forms.Label();
            this.tbxCount = new System.Windows.Forms.TextBox();
            this.lblAmount = new System.Windows.Forms.Label();
            this.tbxAmount = new System.Windows.Forms.TextBox();
            this.lblSex = new System.Windows.Forms.Label();
            this.cbxSex = new System.Windows.Forms.ComboBox();
            this.lblCorralFree = new System.Windows.Forms.Label();
            this.lblCorralFreeValue = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlFooter = new System.Windows.Forms.FlowLayoutPanel();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.geneTableAdapter = new MainProject.Database.FarmManageDataSetTableAdapters.GeneTableAdapter();
            this.corralTableAdapter = new MainProject.Database.FarmManageDataSetTableAdapters.CorralTableAdapter();
            this.pnlMain.SuspendLayout();
            this.pnlDetailContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.geneBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.farmManageDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.corralBindingSource)).BeginInit();
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
            this.pnlMain.Size = new System.Drawing.Size(394, 321);
            this.pnlMain.TabIndex = 0;
            // 
            // pnlDetailContent
            // 
            this.pnlDetailContent.ColumnCount = 4;
            this.pnlDetailContent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.pnlDetailContent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.pnlDetailContent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55F));
            this.pnlDetailContent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.pnlDetailContent.Controls.Add(this.lblCorral, 1, 1);
            this.pnlDetailContent.Controls.Add(this.lblGene, 1, 5);
            this.pnlDetailContent.Controls.Add(this.cbxGene, 2, 5);
            this.pnlDetailContent.Controls.Add(this.cbxCorral, 2, 1);
            this.pnlDetailContent.Controls.Add(this.lblDate, 1, 9);
            this.pnlDetailContent.Controls.Add(this.tbxCount, 2, 9);
            this.pnlDetailContent.Controls.Add(this.lblAmount, 1, 11);
            this.pnlDetailContent.Controls.Add(this.tbxAmount, 2, 11);
            this.pnlDetailContent.Controls.Add(this.lblSex, 1, 7);
            this.pnlDetailContent.Controls.Add(this.cbxSex, 2, 7);
            this.pnlDetailContent.Controls.Add(this.lblCorralFree, 1, 3);
            this.pnlDetailContent.Controls.Add(this.lblCorralFreeValue, 2, 3);
            this.pnlDetailContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDetailContent.Location = new System.Drawing.Point(4, 65);
            this.pnlDetailContent.Name = "pnlDetailContent";
            this.pnlDetailContent.RowCount = 14;
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
            this.pnlDetailContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 3F));
            this.pnlDetailContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.pnlDetailContent.Size = new System.Drawing.Size(386, 211);
            this.pnlDetailContent.TabIndex = 4;
            // 
            // lblCorral
            // 
            this.lblCorral.AutoSize = true;
            this.lblCorral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCorral.Location = new System.Drawing.Point(41, 21);
            this.lblCorral.Name = "lblCorral";
            this.lblCorral.Size = new System.Drawing.Size(90, 25);
            this.lblCorral.TabIndex = 0;
            this.lblCorral.Text = "คอก *";
            this.lblCorral.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblGene
            // 
            this.lblGene.AutoSize = true;
            this.lblGene.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblGene.Location = new System.Drawing.Point(41, 77);
            this.lblGene.Name = "lblGene";
            this.lblGene.Size = new System.Drawing.Size(90, 25);
            this.lblGene.TabIndex = 1;
            this.lblGene.Text = "พันธุ์ *";
            this.lblGene.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbxGene
            // 
            this.cbxGene.DataSource = this.geneBindingSource;
            this.cbxGene.DisplayMember = "Name";
            this.cbxGene.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbxGene.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxGene.FormattingEnabled = true;
            this.cbxGene.Location = new System.Drawing.Point(137, 80);
            this.cbxGene.Name = "cbxGene";
            this.cbxGene.Size = new System.Drawing.Size(206, 21);
            this.cbxGene.TabIndex = 5;
            this.cbxGene.ValueMember = "GeneID";
            // 
            // geneBindingSource
            // 
            this.geneBindingSource.DataMember = "Gene";
            this.geneBindingSource.DataSource = this.farmManageDataSet;
            // 
            // farmManageDataSet
            // 
            this.farmManageDataSet.DataSetName = "FarmManageDataSet";
            this.farmManageDataSet.Locale = new System.Globalization.CultureInfo("en");
            this.farmManageDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cbxCorral
            // 
            this.cbxCorral.DataSource = this.corralBindingSource;
            this.cbxCorral.DisplayMember = "Name";
            this.cbxCorral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbxCorral.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCorral.FormattingEnabled = true;
            this.cbxCorral.Location = new System.Drawing.Point(137, 24);
            this.cbxCorral.Name = "cbxCorral";
            this.cbxCorral.Size = new System.Drawing.Size(206, 21);
            this.cbxCorral.TabIndex = 8;
            this.cbxCorral.ValueMember = "CorralID";
            this.cbxCorral.SelectedIndexChanged += new System.EventHandler(this.cbxCorral_SelectedIndexChanged);
            // 
            // corralBindingSource
            // 
            this.corralBindingSource.DataMember = "Corral";
            this.corralBindingSource.DataSource = this.farmManageDataSet;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDate.Location = new System.Drawing.Point(41, 133);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(90, 25);
            this.lblDate.TabIndex = 14;
            this.lblDate.Text = "จำนวนตัว *";
            this.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbxCount
            // 
            this.tbxCount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxCount.Location = new System.Drawing.Point(137, 136);
            this.tbxCount.Name = "tbxCount";
            this.tbxCount.Size = new System.Drawing.Size(206, 20);
            this.tbxCount.TabIndex = 15;
            this.tbxCount.Text = "1";
            this.tbxCount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxCount_KeyPress);
            this.tbxCount.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbxCount_KeyUp);
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAmount.Location = new System.Drawing.Point(41, 161);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(90, 25);
            this.lblAmount.TabIndex = 16;
            this.lblAmount.Text = "ราคาต่อตัว *";
            this.lblAmount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbxAmount
            // 
            this.tbxAmount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxAmount.Location = new System.Drawing.Point(137, 164);
            this.tbxAmount.Name = "tbxAmount";
            this.tbxAmount.Size = new System.Drawing.Size(206, 20);
            this.tbxAmount.TabIndex = 17;
            this.tbxAmount.Text = "0";
            this.tbxAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxAmount_KeyPress);
            // 
            // lblSex
            // 
            this.lblSex.AutoSize = true;
            this.lblSex.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSex.Location = new System.Drawing.Point(41, 105);
            this.lblSex.Name = "lblSex";
            this.lblSex.Size = new System.Drawing.Size(90, 25);
            this.lblSex.TabIndex = 18;
            this.lblSex.Text = "เพศ *";
            this.lblSex.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbxSex
            // 
            this.cbxSex.DisplayMember = "Value";
            this.cbxSex.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbxSex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSex.FormattingEnabled = true;
            this.cbxSex.Location = new System.Drawing.Point(137, 108);
            this.cbxSex.Name = "cbxSex";
            this.cbxSex.Size = new System.Drawing.Size(206, 21);
            this.cbxSex.TabIndex = 19;
            this.cbxSex.ValueMember = "Key";
            // 
            // lblCorralFree
            // 
            this.lblCorralFree.AutoSize = true;
            this.lblCorralFree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCorralFree.Location = new System.Drawing.Point(41, 49);
            this.lblCorralFree.Name = "lblCorralFree";
            this.lblCorralFree.Size = new System.Drawing.Size(90, 25);
            this.lblCorralFree.TabIndex = 20;
            this.lblCorralFree.Text = "ความจุคอก(ตัว)";
            this.lblCorralFree.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCorralFreeValue
            // 
            this.lblCorralFreeValue.AutoSize = true;
            this.lblCorralFreeValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCorralFreeValue.Location = new System.Drawing.Point(137, 49);
            this.lblCorralFreeValue.Name = "lblCorralFreeValue";
            this.lblCorralFreeValue.Size = new System.Drawing.Size(206, 25);
            this.lblCorralFreeValue.TabIndex = 21;
            this.lblCorralFreeValue.Text = "0";
            this.lblCorralFreeValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "เพิ่มรายการซื้อ";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlFooter
            // 
            this.pnlFooter.Controls.Add(this.btnClose);
            this.pnlFooter.Controls.Add(this.btnSave);
            this.pnlFooter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFooter.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.pnlFooter.Location = new System.Drawing.Point(4, 283);
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.Padding = new System.Windows.Forms.Padding(3);
            this.pnlFooter.Size = new System.Drawing.Size(386, 34);
            this.pnlFooter.TabIndex = 1;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(302, 6);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "ยกเลิก";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
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
            // geneTableAdapter
            // 
            this.geneTableAdapter.ClearBeforeFill = true;
            // 
            // corralTableAdapter
            // 
            this.corralTableAdapter.ClearBeforeFill = true;
            // 
            // AddCowOrderInForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 321);
            this.Controls.Add(this.pnlMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddCowOrderInForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "เพิ่มรายการซื้อ";
            this.Load += new System.EventHandler(this.AddCowOrderInForm_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.pnlDetailContent.ResumeLayout(false);
            this.pnlDetailContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.geneBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.farmManageDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.corralBindingSource)).EndInit();
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
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.TextBox tbxCount;
        private Database.FarmManageDataSet farmManageDataSet;
        private System.Windows.Forms.BindingSource geneBindingSource;
        private Database.FarmManageDataSetTableAdapters.GeneTableAdapter geneTableAdapter;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.TextBox tbxAmount;
        private System.Windows.Forms.Label lblSex;
        private System.Windows.Forms.ComboBox cbxSex;
        private System.Windows.Forms.Label lblCorralFree;
        private System.Windows.Forms.Label lblCorralFreeValue;
        private System.Windows.Forms.BindingSource corralBindingSource;
        private Database.FarmManageDataSetTableAdapters.CorralTableAdapter corralTableAdapter;
    }
}
namespace MainProject.UserInterface.Static
{
    partial class CowPriceStaticForm
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
            this.btnClose = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tcMain = new System.Windows.Forms.TabControl();
            this.tabData = new System.Windows.Forms.TabPage();
            this.pnlDataContent = new System.Windows.Forms.TableLayoutPanel();
            this.gbxData1 = new System.Windows.Forms.GroupBox();
            this.pnlData1Content = new System.Windows.Forms.TableLayoutPanel();
            this.lblYear1 = new System.Windows.Forms.Label();
            this.cbxYear1 = new System.Windows.Forms.ComboBox();
            this.chbEnable1 = new System.Windows.Forms.CheckBox();
            this.btnPreview1 = new System.Windows.Forms.Button();
            this.lblType1 = new System.Windows.Forms.Label();
            this.lblGene1 = new System.Windows.Forms.Label();
            this.cbxType1 = new System.Windows.Forms.ComboBox();
            this.cbxGene1 = new System.Windows.Forms.ComboBox();
            this.cbxData2 = new System.Windows.Forms.GroupBox();
            this.pnlData2Content = new System.Windows.Forms.TableLayoutPanel();
            this.lblYear2 = new System.Windows.Forms.Label();
            this.cbxYear2 = new System.Windows.Forms.ComboBox();
            this.chbEnable2 = new System.Windows.Forms.CheckBox();
            this.btnPreview2 = new System.Windows.Forms.Button();
            this.lblType2 = new System.Windows.Forms.Label();
            this.lblGene2 = new System.Windows.Forms.Label();
            this.cbxType2 = new System.Windows.Forms.ComboBox();
            this.cbxGene2 = new System.Windows.Forms.ComboBox();
            this.cbxData3 = new System.Windows.Forms.GroupBox();
            this.pnlData3Content = new System.Windows.Forms.TableLayoutPanel();
            this.lblYear3 = new System.Windows.Forms.Label();
            this.cbxYear3 = new System.Windows.Forms.ComboBox();
            this.chbEnable3 = new System.Windows.Forms.CheckBox();
            this.btnPreview3 = new System.Windows.Forms.Button();
            this.lblType3 = new System.Windows.Forms.Label();
            this.lblGene3 = new System.Windows.Forms.Label();
            this.cbxType3 = new System.Windows.Forms.ComboBox();
            this.cbxGene3 = new System.Windows.Forms.ComboBox();
            this.cbxData4 = new System.Windows.Forms.GroupBox();
            this.pnlData4Content = new System.Windows.Forms.TableLayoutPanel();
            this.lblYear4 = new System.Windows.Forms.Label();
            this.cbxYear4 = new System.Windows.Forms.ComboBox();
            this.chbEnable4 = new System.Windows.Forms.CheckBox();
            this.btnPreview4 = new System.Windows.Forms.Button();
            this.lblGene4 = new System.Windows.Forms.Label();
            this.lblType4 = new System.Windows.Forms.Label();
            this.cbxType4 = new System.Windows.Forms.ComboBox();
            this.cbxGene4 = new System.Windows.Forms.ComboBox();
            this.geneBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.farmManageDataSet = new MainProject.Database.FarmManageDataSet();
            this.geneTableAdapter = new MainProject.Database.FarmManageDataSetTableAdapters.GeneTableAdapter();
            this.pnlMain.SuspendLayout();
            this.pnlFooter.SuspendLayout();
            this.tcMain.SuspendLayout();
            this.tabData.SuspendLayout();
            this.pnlDataContent.SuspendLayout();
            this.gbxData1.SuspendLayout();
            this.pnlData1Content.SuspendLayout();
            this.cbxData2.SuspendLayout();
            this.pnlData2Content.SuspendLayout();
            this.cbxData3.SuspendLayout();
            this.pnlData3Content.SuspendLayout();
            this.cbxData4.SuspendLayout();
            this.pnlData4Content.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.geneBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.farmManageDataSet)).BeginInit();
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
            this.pnlMain.Size = new System.Drawing.Size(794, 621);
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
            this.lblTitle.Size = new System.Drawing.Size(786, 60);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "วิเคราะห์ราคาโค";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlFooter
            // 
            this.pnlFooter.Controls.Add(this.btnClose);
            this.pnlFooter.Controls.Add(this.button1);
            this.pnlFooter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFooter.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.pnlFooter.Location = new System.Drawing.Point(4, 583);
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.Padding = new System.Windows.Forms.Padding(3);
            this.pnlFooter.Size = new System.Drawing.Size(786, 34);
            this.pnlFooter.TabIndex = 1;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(702, 6);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "ปิด";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(581, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "ข้อมูลตัวอย่าง";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tcMain
            // 
            this.tcMain.Controls.Add(this.tabData);
            this.tcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcMain.Location = new System.Drawing.Point(4, 65);
            this.tcMain.Name = "tcMain";
            this.tcMain.SelectedIndex = 0;
            this.tcMain.Size = new System.Drawing.Size(786, 511);
            this.tcMain.TabIndex = 2;
            // 
            // tabData
            // 
            this.tabData.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabData.Controls.Add(this.pnlDataContent);
            this.tabData.Location = new System.Drawing.Point(4, 22);
            this.tabData.Name = "tabData";
            this.tabData.Padding = new System.Windows.Forms.Padding(3);
            this.tabData.Size = new System.Drawing.Size(778, 485);
            this.tabData.TabIndex = 0;
            this.tabData.Text = "ข้อมูล";
            // 
            // pnlDataContent
            // 
            this.pnlDataContent.ColumnCount = 1;
            this.pnlDataContent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlDataContent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.pnlDataContent.Controls.Add(this.gbxData1, 0, 0);
            this.pnlDataContent.Controls.Add(this.cbxData2, 0, 1);
            this.pnlDataContent.Controls.Add(this.cbxData3, 0, 2);
            this.pnlDataContent.Controls.Add(this.cbxData4, 0, 3);
            this.pnlDataContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDataContent.Location = new System.Drawing.Point(3, 3);
            this.pnlDataContent.Name = "pnlDataContent";
            this.pnlDataContent.RowCount = 4;
            this.pnlDataContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.pnlDataContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.pnlDataContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.pnlDataContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.pnlDataContent.Size = new System.Drawing.Size(772, 479);
            this.pnlDataContent.TabIndex = 0;
            // 
            // gbxData1
            // 
            this.gbxData1.Controls.Add(this.pnlData1Content);
            this.gbxData1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbxData1.Location = new System.Drawing.Point(3, 3);
            this.gbxData1.Name = "gbxData1";
            this.gbxData1.Size = new System.Drawing.Size(766, 113);
            this.gbxData1.TabIndex = 0;
            this.gbxData1.TabStop = false;
            this.gbxData1.Text = "ข้อมูล 1";
            // 
            // pnlData1Content
            // 
            this.pnlData1Content.ColumnCount = 7;
            this.pnlData1Content.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.pnlData1Content.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.pnlData1Content.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.pnlData1Content.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.pnlData1Content.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.pnlData1Content.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.pnlData1Content.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.pnlData1Content.Controls.Add(this.lblYear1, 4, 3);
            this.pnlData1Content.Controls.Add(this.cbxYear1, 5, 3);
            this.pnlData1Content.Controls.Add(this.chbEnable1, 2, 1);
            this.pnlData1Content.Controls.Add(this.btnPreview1, 5, 5);
            this.pnlData1Content.Controls.Add(this.lblType1, 1, 3);
            this.pnlData1Content.Controls.Add(this.lblGene1, 1, 5);
            this.pnlData1Content.Controls.Add(this.cbxType1, 2, 3);
            this.pnlData1Content.Controls.Add(this.cbxGene1, 2, 5);
            this.pnlData1Content.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlData1Content.Location = new System.Drawing.Point(3, 16);
            this.pnlData1Content.Name = "pnlData1Content";
            this.pnlData1Content.RowCount = 7;
            this.pnlData1Content.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.pnlData1Content.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.pnlData1Content.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 3F));
            this.pnlData1Content.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.pnlData1Content.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 3F));
            this.pnlData1Content.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.pnlData1Content.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlData1Content.Size = new System.Drawing.Size(760, 94);
            this.pnlData1Content.TabIndex = 0;
            // 
            // lblYear1
            // 
            this.lblYear1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblYear1.Location = new System.Drawing.Point(387, 33);
            this.lblYear1.Name = "lblYear1";
            this.lblYear1.Size = new System.Drawing.Size(106, 25);
            this.lblYear1.TabIndex = 1;
            this.lblYear1.Text = "ปี";
            this.lblYear1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbxYear1
            // 
            this.cbxYear1.DisplayMember = "Value";
            this.cbxYear1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbxYear1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxYear1.FormattingEnabled = true;
            this.cbxYear1.Location = new System.Drawing.Point(499, 36);
            this.cbxYear1.Name = "cbxYear1";
            this.cbxYear1.Size = new System.Drawing.Size(219, 21);
            this.cbxYear1.TabIndex = 9;
            this.cbxYear1.ValueMember = "Key";
            this.cbxYear1.SelectedIndexChanged += new System.EventHandler(this.cbxYear_SelectedIndexChanged);
            // 
            // chbEnable1
            // 
            this.chbEnable1.AutoSize = true;
            this.chbEnable1.Checked = true;
            this.chbEnable1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbEnable1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.chbEnable1.Location = new System.Drawing.Point(152, 10);
            this.chbEnable1.Name = "chbEnable1";
            this.chbEnable1.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.chbEnable1.Size = new System.Drawing.Size(219, 17);
            this.chbEnable1.TabIndex = 10;
            this.chbEnable1.Text = "เปิดใช้งาน";
            this.chbEnable1.UseVisualStyleBackColor = true;
            this.chbEnable1.CheckedChanged += new System.EventHandler(this.chbEnable_CheckedChanged);
            // 
            // btnPreview1
            // 
            this.btnPreview1.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPreview1.Location = new System.Drawing.Point(499, 64);
            this.btnPreview1.Name = "btnPreview1";
            this.pnlData1Content.SetRowSpan(this.btnPreview1, 2);
            this.btnPreview1.Size = new System.Drawing.Size(219, 23);
            this.btnPreview1.TabIndex = 11;
            this.btnPreview1.Text = "แสดงกราฟ";
            this.btnPreview1.UseVisualStyleBackColor = true;
            this.btnPreview1.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // lblType1
            // 
            this.lblType1.AutoSize = true;
            this.lblType1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblType1.Location = new System.Drawing.Point(40, 33);
            this.lblType1.Name = "lblType1";
            this.lblType1.Size = new System.Drawing.Size(106, 25);
            this.lblType1.TabIndex = 12;
            this.lblType1.Text = "ประเภท";
            this.lblType1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblGene1
            // 
            this.lblGene1.AutoSize = true;
            this.lblGene1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblGene1.Location = new System.Drawing.Point(40, 61);
            this.lblGene1.Name = "lblGene1";
            this.lblGene1.Size = new System.Drawing.Size(106, 25);
            this.lblGene1.TabIndex = 4;
            this.lblGene1.Text = "พันธุ์";
            this.lblGene1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbxType1
            // 
            this.cbxType1.DisplayMember = "Value";
            this.cbxType1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbxType1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxType1.FormattingEnabled = true;
            this.cbxType1.Location = new System.Drawing.Point(152, 36);
            this.cbxType1.Name = "cbxType1";
            this.cbxType1.Size = new System.Drawing.Size(219, 21);
            this.cbxType1.TabIndex = 13;
            this.cbxType1.ValueMember = "Key";
            this.cbxType1.SelectedIndexChanged += new System.EventHandler(this.cbxType_SelectedIndexChanged);
            // 
            // cbxGene1
            // 
            this.cbxGene1.DisplayMember = "Value";
            this.cbxGene1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbxGene1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxGene1.FormattingEnabled = true;
            this.cbxGene1.Location = new System.Drawing.Point(152, 64);
            this.cbxGene1.Name = "cbxGene1";
            this.cbxGene1.Size = new System.Drawing.Size(219, 21);
            this.cbxGene1.TabIndex = 8;
            this.cbxGene1.ValueMember = "Key";
            // 
            // cbxData2
            // 
            this.cbxData2.Controls.Add(this.pnlData2Content);
            this.cbxData2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbxData2.Location = new System.Drawing.Point(3, 122);
            this.cbxData2.Name = "cbxData2";
            this.cbxData2.Size = new System.Drawing.Size(766, 113);
            this.cbxData2.TabIndex = 1;
            this.cbxData2.TabStop = false;
            this.cbxData2.Text = "ข้อมูล 2";
            // 
            // pnlData2Content
            // 
            this.pnlData2Content.ColumnCount = 7;
            this.pnlData2Content.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.pnlData2Content.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.pnlData2Content.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.pnlData2Content.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.pnlData2Content.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.pnlData2Content.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.pnlData2Content.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.pnlData2Content.Controls.Add(this.lblYear2, 4, 3);
            this.pnlData2Content.Controls.Add(this.cbxYear2, 5, 3);
            this.pnlData2Content.Controls.Add(this.chbEnable2, 2, 1);
            this.pnlData2Content.Controls.Add(this.btnPreview2, 5, 5);
            this.pnlData2Content.Controls.Add(this.lblType2, 1, 3);
            this.pnlData2Content.Controls.Add(this.lblGene2, 1, 5);
            this.pnlData2Content.Controls.Add(this.cbxType2, 2, 3);
            this.pnlData2Content.Controls.Add(this.cbxGene2, 2, 5);
            this.pnlData2Content.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlData2Content.Location = new System.Drawing.Point(3, 16);
            this.pnlData2Content.Name = "pnlData2Content";
            this.pnlData2Content.RowCount = 7;
            this.pnlData2Content.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.pnlData2Content.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.pnlData2Content.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 3F));
            this.pnlData2Content.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.pnlData2Content.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 3F));
            this.pnlData2Content.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.pnlData2Content.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlData2Content.Size = new System.Drawing.Size(760, 94);
            this.pnlData2Content.TabIndex = 1;
            // 
            // lblYear2
            // 
            this.lblYear2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblYear2.Location = new System.Drawing.Point(387, 33);
            this.lblYear2.Name = "lblYear2";
            this.lblYear2.Size = new System.Drawing.Size(106, 25);
            this.lblYear2.TabIndex = 1;
            this.lblYear2.Text = "ปี";
            this.lblYear2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbxYear2
            // 
            this.cbxYear2.DisplayMember = "Value";
            this.cbxYear2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbxYear2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxYear2.Enabled = false;
            this.cbxYear2.FormattingEnabled = true;
            this.cbxYear2.Location = new System.Drawing.Point(499, 36);
            this.cbxYear2.Name = "cbxYear2";
            this.cbxYear2.Size = new System.Drawing.Size(219, 21);
            this.cbxYear2.TabIndex = 9;
            this.cbxYear2.ValueMember = "Key";
            this.cbxYear2.SelectedIndexChanged += new System.EventHandler(this.cbxYear_SelectedIndexChanged);
            // 
            // chbEnable2
            // 
            this.chbEnable2.AutoSize = true;
            this.chbEnable2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.chbEnable2.Location = new System.Drawing.Point(152, 10);
            this.chbEnable2.Name = "chbEnable2";
            this.chbEnable2.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.chbEnable2.Size = new System.Drawing.Size(219, 17);
            this.chbEnable2.TabIndex = 10;
            this.chbEnable2.Text = "เปิดใช้งาน";
            this.chbEnable2.UseVisualStyleBackColor = true;
            this.chbEnable2.CheckedChanged += new System.EventHandler(this.chbEnable_CheckedChanged);
            // 
            // btnPreview2
            // 
            this.btnPreview2.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPreview2.Enabled = false;
            this.btnPreview2.Location = new System.Drawing.Point(499, 64);
            this.btnPreview2.Name = "btnPreview2";
            this.pnlData2Content.SetRowSpan(this.btnPreview2, 2);
            this.btnPreview2.Size = new System.Drawing.Size(219, 23);
            this.btnPreview2.TabIndex = 11;
            this.btnPreview2.Text = "แสดงกราฟ";
            this.btnPreview2.UseVisualStyleBackColor = true;
            this.btnPreview2.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // lblType2
            // 
            this.lblType2.AutoSize = true;
            this.lblType2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblType2.Location = new System.Drawing.Point(40, 33);
            this.lblType2.Name = "lblType2";
            this.lblType2.Size = new System.Drawing.Size(106, 25);
            this.lblType2.TabIndex = 13;
            this.lblType2.Text = "ประเภท";
            this.lblType2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblGene2
            // 
            this.lblGene2.AutoSize = true;
            this.lblGene2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblGene2.Location = new System.Drawing.Point(40, 61);
            this.lblGene2.Name = "lblGene2";
            this.lblGene2.Size = new System.Drawing.Size(106, 25);
            this.lblGene2.TabIndex = 4;
            this.lblGene2.Text = "พันธุ์";
            this.lblGene2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbxType2
            // 
            this.cbxType2.DisplayMember = "Value";
            this.cbxType2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbxType2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxType2.Enabled = false;
            this.cbxType2.FormattingEnabled = true;
            this.cbxType2.Location = new System.Drawing.Point(152, 36);
            this.cbxType2.Name = "cbxType2";
            this.cbxType2.Size = new System.Drawing.Size(219, 21);
            this.cbxType2.TabIndex = 14;
            this.cbxType2.ValueMember = "Key";
            this.cbxType2.SelectedIndexChanged += new System.EventHandler(this.cbxType_SelectedIndexChanged);
            // 
            // cbxGene2
            // 
            this.cbxGene2.DisplayMember = "Value";
            this.cbxGene2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbxGene2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxGene2.Enabled = false;
            this.cbxGene2.FormattingEnabled = true;
            this.cbxGene2.Location = new System.Drawing.Point(152, 64);
            this.cbxGene2.Name = "cbxGene2";
            this.cbxGene2.Size = new System.Drawing.Size(219, 21);
            this.cbxGene2.TabIndex = 8;
            this.cbxGene2.ValueMember = "Key";
            // 
            // cbxData3
            // 
            this.cbxData3.Controls.Add(this.pnlData3Content);
            this.cbxData3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbxData3.Location = new System.Drawing.Point(3, 241);
            this.cbxData3.Name = "cbxData3";
            this.cbxData3.Size = new System.Drawing.Size(766, 113);
            this.cbxData3.TabIndex = 2;
            this.cbxData3.TabStop = false;
            this.cbxData3.Text = "ข้อมูล 3";
            // 
            // pnlData3Content
            // 
            this.pnlData3Content.ColumnCount = 7;
            this.pnlData3Content.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.pnlData3Content.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.pnlData3Content.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.pnlData3Content.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.pnlData3Content.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.pnlData3Content.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.pnlData3Content.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.pnlData3Content.Controls.Add(this.lblYear3, 4, 3);
            this.pnlData3Content.Controls.Add(this.cbxYear3, 5, 3);
            this.pnlData3Content.Controls.Add(this.chbEnable3, 2, 1);
            this.pnlData3Content.Controls.Add(this.btnPreview3, 5, 5);
            this.pnlData3Content.Controls.Add(this.lblType3, 1, 3);
            this.pnlData3Content.Controls.Add(this.lblGene3, 1, 5);
            this.pnlData3Content.Controls.Add(this.cbxType3, 2, 3);
            this.pnlData3Content.Controls.Add(this.cbxGene3, 2, 5);
            this.pnlData3Content.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlData3Content.Location = new System.Drawing.Point(3, 16);
            this.pnlData3Content.Name = "pnlData3Content";
            this.pnlData3Content.RowCount = 7;
            this.pnlData3Content.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.pnlData3Content.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.pnlData3Content.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 3F));
            this.pnlData3Content.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.pnlData3Content.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 3F));
            this.pnlData3Content.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.pnlData3Content.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlData3Content.Size = new System.Drawing.Size(760, 94);
            this.pnlData3Content.TabIndex = 2;
            // 
            // lblYear3
            // 
            this.lblYear3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblYear3.Location = new System.Drawing.Point(387, 33);
            this.lblYear3.Name = "lblYear3";
            this.lblYear3.Size = new System.Drawing.Size(106, 25);
            this.lblYear3.TabIndex = 1;
            this.lblYear3.Text = "ปี";
            this.lblYear3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbxYear3
            // 
            this.cbxYear3.DisplayMember = "Value";
            this.cbxYear3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbxYear3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxYear3.Enabled = false;
            this.cbxYear3.FormattingEnabled = true;
            this.cbxYear3.Location = new System.Drawing.Point(499, 36);
            this.cbxYear3.Name = "cbxYear3";
            this.cbxYear3.Size = new System.Drawing.Size(219, 21);
            this.cbxYear3.TabIndex = 9;
            this.cbxYear3.ValueMember = "Key";
            this.cbxYear3.SelectedIndexChanged += new System.EventHandler(this.cbxYear_SelectedIndexChanged);
            // 
            // chbEnable3
            // 
            this.chbEnable3.AutoSize = true;
            this.chbEnable3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.chbEnable3.Location = new System.Drawing.Point(152, 10);
            this.chbEnable3.Name = "chbEnable3";
            this.chbEnable3.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.chbEnable3.Size = new System.Drawing.Size(219, 17);
            this.chbEnable3.TabIndex = 10;
            this.chbEnable3.Text = "เปิดใช้งาน";
            this.chbEnable3.UseVisualStyleBackColor = true;
            this.chbEnable3.CheckedChanged += new System.EventHandler(this.chbEnable_CheckedChanged);
            // 
            // btnPreview3
            // 
            this.btnPreview3.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPreview3.Enabled = false;
            this.btnPreview3.Location = new System.Drawing.Point(499, 64);
            this.btnPreview3.Name = "btnPreview3";
            this.pnlData3Content.SetRowSpan(this.btnPreview3, 2);
            this.btnPreview3.Size = new System.Drawing.Size(219, 23);
            this.btnPreview3.TabIndex = 11;
            this.btnPreview3.Text = "แสดงกราฟ";
            this.btnPreview3.UseVisualStyleBackColor = true;
            this.btnPreview3.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // lblType3
            // 
            this.lblType3.AutoSize = true;
            this.lblType3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblType3.Location = new System.Drawing.Point(40, 33);
            this.lblType3.Name = "lblType3";
            this.lblType3.Size = new System.Drawing.Size(106, 25);
            this.lblType3.TabIndex = 13;
            this.lblType3.Text = "ประเภท";
            this.lblType3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblGene3
            // 
            this.lblGene3.AutoSize = true;
            this.lblGene3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblGene3.Location = new System.Drawing.Point(40, 61);
            this.lblGene3.Name = "lblGene3";
            this.lblGene3.Size = new System.Drawing.Size(106, 25);
            this.lblGene3.TabIndex = 4;
            this.lblGene3.Text = "พันธุ์";
            this.lblGene3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbxType3
            // 
            this.cbxType3.DisplayMember = "Value";
            this.cbxType3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbxType3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxType3.Enabled = false;
            this.cbxType3.FormattingEnabled = true;
            this.cbxType3.Location = new System.Drawing.Point(152, 36);
            this.cbxType3.Name = "cbxType3";
            this.cbxType3.Size = new System.Drawing.Size(219, 21);
            this.cbxType3.TabIndex = 15;
            this.cbxType3.ValueMember = "Key";
            this.cbxType3.SelectedIndexChanged += new System.EventHandler(this.cbxType_SelectedIndexChanged);
            // 
            // cbxGene3
            // 
            this.cbxGene3.DisplayMember = "Value";
            this.cbxGene3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbxGene3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxGene3.Enabled = false;
            this.cbxGene3.FormattingEnabled = true;
            this.cbxGene3.Location = new System.Drawing.Point(152, 64);
            this.cbxGene3.Name = "cbxGene3";
            this.cbxGene3.Size = new System.Drawing.Size(219, 21);
            this.cbxGene3.TabIndex = 8;
            this.cbxGene3.ValueMember = "Key";
            // 
            // cbxData4
            // 
            this.cbxData4.Controls.Add(this.pnlData4Content);
            this.cbxData4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbxData4.Location = new System.Drawing.Point(3, 360);
            this.cbxData4.Name = "cbxData4";
            this.cbxData4.Size = new System.Drawing.Size(766, 116);
            this.cbxData4.TabIndex = 3;
            this.cbxData4.TabStop = false;
            this.cbxData4.Text = "ข้อมูล 4";
            // 
            // pnlData4Content
            // 
            this.pnlData4Content.ColumnCount = 7;
            this.pnlData4Content.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.pnlData4Content.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.pnlData4Content.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.pnlData4Content.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.pnlData4Content.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.pnlData4Content.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.pnlData4Content.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.pnlData4Content.Controls.Add(this.lblYear4, 4, 3);
            this.pnlData4Content.Controls.Add(this.cbxYear4, 5, 3);
            this.pnlData4Content.Controls.Add(this.chbEnable4, 2, 1);
            this.pnlData4Content.Controls.Add(this.btnPreview4, 5, 5);
            this.pnlData4Content.Controls.Add(this.lblGene4, 1, 5);
            this.pnlData4Content.Controls.Add(this.lblType4, 1, 3);
            this.pnlData4Content.Controls.Add(this.cbxType4, 2, 3);
            this.pnlData4Content.Controls.Add(this.cbxGene4, 2, 5);
            this.pnlData4Content.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlData4Content.Location = new System.Drawing.Point(3, 16);
            this.pnlData4Content.Name = "pnlData4Content";
            this.pnlData4Content.RowCount = 7;
            this.pnlData4Content.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.pnlData4Content.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.pnlData4Content.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 3F));
            this.pnlData4Content.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.pnlData4Content.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 3F));
            this.pnlData4Content.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.pnlData4Content.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlData4Content.Size = new System.Drawing.Size(760, 97);
            this.pnlData4Content.TabIndex = 2;
            // 
            // lblYear4
            // 
            this.lblYear4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblYear4.Location = new System.Drawing.Point(387, 33);
            this.lblYear4.Name = "lblYear4";
            this.lblYear4.Size = new System.Drawing.Size(106, 25);
            this.lblYear4.TabIndex = 1;
            this.lblYear4.Text = "ปี";
            this.lblYear4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbxYear4
            // 
            this.cbxYear4.DisplayMember = "Value";
            this.cbxYear4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbxYear4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxYear4.Enabled = false;
            this.cbxYear4.FormattingEnabled = true;
            this.cbxYear4.Location = new System.Drawing.Point(499, 36);
            this.cbxYear4.Name = "cbxYear4";
            this.cbxYear4.Size = new System.Drawing.Size(219, 21);
            this.cbxYear4.TabIndex = 9;
            this.cbxYear4.ValueMember = "Key";
            this.cbxYear4.SelectedIndexChanged += new System.EventHandler(this.cbxYear_SelectedIndexChanged);
            // 
            // chbEnable4
            // 
            this.chbEnable4.AutoSize = true;
            this.chbEnable4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.chbEnable4.Location = new System.Drawing.Point(152, 10);
            this.chbEnable4.Name = "chbEnable4";
            this.chbEnable4.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.chbEnable4.Size = new System.Drawing.Size(219, 17);
            this.chbEnable4.TabIndex = 10;
            this.chbEnable4.Text = "เปิดใช้งาน";
            this.chbEnable4.UseVisualStyleBackColor = true;
            this.chbEnable4.CheckedChanged += new System.EventHandler(this.chbEnable_CheckedChanged);
            // 
            // btnPreview4
            // 
            this.btnPreview4.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPreview4.Enabled = false;
            this.btnPreview4.Location = new System.Drawing.Point(499, 64);
            this.btnPreview4.Name = "btnPreview4";
            this.pnlData4Content.SetRowSpan(this.btnPreview4, 2);
            this.btnPreview4.Size = new System.Drawing.Size(219, 23);
            this.btnPreview4.TabIndex = 11;
            this.btnPreview4.Text = "แสดงกราฟ";
            this.btnPreview4.UseVisualStyleBackColor = true;
            this.btnPreview4.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // lblGene4
            // 
            this.lblGene4.AutoSize = true;
            this.lblGene4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblGene4.Location = new System.Drawing.Point(40, 61);
            this.lblGene4.Name = "lblGene4";
            this.lblGene4.Size = new System.Drawing.Size(106, 25);
            this.lblGene4.TabIndex = 4;
            this.lblGene4.Text = "พันธุ์";
            this.lblGene4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblType4
            // 
            this.lblType4.AutoSize = true;
            this.lblType4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblType4.Location = new System.Drawing.Point(40, 33);
            this.lblType4.Name = "lblType4";
            this.lblType4.Size = new System.Drawing.Size(106, 25);
            this.lblType4.TabIndex = 13;
            this.lblType4.Text = "ประเภท";
            this.lblType4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbxType4
            // 
            this.cbxType4.DisplayMember = "Value";
            this.cbxType4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbxType4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxType4.Enabled = false;
            this.cbxType4.FormattingEnabled = true;
            this.cbxType4.Location = new System.Drawing.Point(152, 36);
            this.cbxType4.Name = "cbxType4";
            this.cbxType4.Size = new System.Drawing.Size(219, 21);
            this.cbxType4.TabIndex = 15;
            this.cbxType4.ValueMember = "Key";
            this.cbxType4.SelectedIndexChanged += new System.EventHandler(this.cbxType_SelectedIndexChanged);
            // 
            // cbxGene4
            // 
            this.cbxGene4.DisplayMember = "Value";
            this.cbxGene4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbxGene4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxGene4.Enabled = false;
            this.cbxGene4.FormattingEnabled = true;
            this.cbxGene4.Location = new System.Drawing.Point(152, 64);
            this.cbxGene4.Name = "cbxGene4";
            this.cbxGene4.Size = new System.Drawing.Size(219, 21);
            this.cbxGene4.TabIndex = 8;
            this.cbxGene4.ValueMember = "Key";
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
            // geneTableAdapter
            // 
            this.geneTableAdapter.ClearBeforeFill = true;
            // 
            // CowPriceStaticForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 621);
            this.Controls.Add(this.pnlMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MinimizeBox = false;
            this.Name = "CowPriceStaticForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "วิเคราะห์ราคาโค";
            this.Load += new System.EventHandler(this.StaticCow_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.pnlFooter.ResumeLayout(false);
            this.tcMain.ResumeLayout(false);
            this.tabData.ResumeLayout(false);
            this.pnlDataContent.ResumeLayout(false);
            this.gbxData1.ResumeLayout(false);
            this.pnlData1Content.ResumeLayout(false);
            this.pnlData1Content.PerformLayout();
            this.cbxData2.ResumeLayout(false);
            this.pnlData2Content.ResumeLayout(false);
            this.pnlData2Content.PerformLayout();
            this.cbxData3.ResumeLayout(false);
            this.pnlData3Content.ResumeLayout(false);
            this.pnlData3Content.PerformLayout();
            this.cbxData4.ResumeLayout(false);
            this.pnlData4Content.ResumeLayout(false);
            this.pnlData4Content.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.geneBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.farmManageDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel pnlMain;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.FlowLayoutPanel pnlFooter;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TabControl tcMain;
        private System.Windows.Forms.TabPage tabData;
        private System.Windows.Forms.TableLayoutPanel pnlDataContent;
        private System.Windows.Forms.GroupBox gbxData1;
        private System.Windows.Forms.GroupBox cbxData2;
        private System.Windows.Forms.GroupBox cbxData3;
        private System.Windows.Forms.GroupBox cbxData4;
        private System.Windows.Forms.TableLayoutPanel pnlData1Content;
        private System.Windows.Forms.Label lblYear1;
        private System.Windows.Forms.Label lblGene1;
        private System.Windows.Forms.ComboBox cbxGene1;
        private System.Windows.Forms.ComboBox cbxYear1;
        private System.Windows.Forms.CheckBox chbEnable1;
        private System.Windows.Forms.Button btnPreview1;
        private System.Windows.Forms.TableLayoutPanel pnlData2Content;
        private System.Windows.Forms.Label lblYear2;
        private System.Windows.Forms.Label lblGene2;
        private System.Windows.Forms.ComboBox cbxGene2;
        private System.Windows.Forms.ComboBox cbxYear2;
        private System.Windows.Forms.Button btnPreview2;
        private System.Windows.Forms.CheckBox chbEnable2;
        private System.Windows.Forms.TableLayoutPanel pnlData3Content;
        private System.Windows.Forms.Label lblYear3;
        private System.Windows.Forms.Label lblGene3;
        private System.Windows.Forms.ComboBox cbxGene3;
        private System.Windows.Forms.ComboBox cbxYear3;
        private System.Windows.Forms.Button btnPreview3;
        private System.Windows.Forms.CheckBox chbEnable3;
        private System.Windows.Forms.TableLayoutPanel pnlData4Content;
        private System.Windows.Forms.Label lblYear4;
        private System.Windows.Forms.Label lblGene4;
        private System.Windows.Forms.ComboBox cbxGene4;
        private System.Windows.Forms.ComboBox cbxYear4;
        private System.Windows.Forms.Button btnPreview4;
        private System.Windows.Forms.CheckBox chbEnable4;
        private Database.FarmManageDataSet farmManageDataSet;
        private System.Windows.Forms.BindingSource geneBindingSource;
        private Database.FarmManageDataSetTableAdapters.GeneTableAdapter geneTableAdapter;
        private System.Windows.Forms.Label lblType1;
        private System.Windows.Forms.ComboBox cbxType1;
        private System.Windows.Forms.Label lblType2;
        private System.Windows.Forms.ComboBox cbxType2;
        private System.Windows.Forms.Label lblType3;
        private System.Windows.Forms.ComboBox cbxType3;
        private System.Windows.Forms.Label lblType4;
        private System.Windows.Forms.ComboBox cbxType4;
        private System.Windows.Forms.Button button1;
    }
}
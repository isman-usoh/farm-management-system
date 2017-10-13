namespace MainProject.UserInterface
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.pnlMain = new System.Windows.Forms.TableLayoutPanel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.contentSplitContainer = new System.Windows.Forms.SplitContainer();
            this.leftPanel = new System.Windows.Forms.TableLayoutPanel();
            this.btnOrderManage = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTotalCow = new System.Windows.Forms.Label();
            this.lblCowCurrentValue = new System.Windows.Forms.Label();
            this.cowStaticBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.farmManageDataSet = new MainProject.Database.FarmManageDataSet();
            this.lblCurrentCow = new System.Windows.Forms.Label();
            this.lbl = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblUse1 = new System.Windows.Forms.Label();
            this.orderOutStaticBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblTime = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.orderInStaticBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnBuy = new System.Windows.Forms.Button();
            this.btnSell = new System.Windows.Forms.Button();
            this.btnCustomer = new System.Windows.Forms.Button();
            this.btnStock = new System.Windows.Forms.Button();
            this.btnReport = new System.Windows.Forms.Button();
            this.rightPanel = new System.Windows.Forms.TableLayoutPanel();
            this.searchPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.lblSearch = new System.Windows.Forms.Label();
            this.tbxSearch = new System.Windows.Forms.TextBox();
            this.btnSearchGo = new System.Windows.Forms.Button();
            this.chxAllShow = new System.Windows.Forms.CheckBox();
            this.filterPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.lblCorral = new System.Windows.Forms.Label();
            this.cbxCorral = new System.Windows.Forms.ComboBox();
            this.lblGene = new System.Windows.Forms.Label();
            this.cbxGene = new System.Windows.Forms.ComboBox();
            this.dgvGrid = new System.Windows.Forms.DataGridView();
            this.corralBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.geneBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cowBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pnlHeader = new System.Windows.Forms.TableLayoutPanel();
            this.menuUser = new System.Windows.Forms.MenuStrip();
            this.tsmiCurrentUser = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCurrentUserDetail = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCurrentUserPassword = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiCurrentLogOut = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.tsmiFile = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiBackupItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiLogOutItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiExitItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiUser = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiUserDetailItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiUserPasswordItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiManage = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCorralItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiGeneItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tmsiSuppliesItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCustomerItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiUserItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiRecipesItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tmsiOrderItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiOtherOrderMgn = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiStaticItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiStatic = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCowPrice = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSetting = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiFarmDetailItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiFormat = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSettingItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiHelpItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAboutItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changePasswordMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.corralManageItem = new System.Windows.Forms.ToolStripMenuItem();
            this.medicineItem = new System.Windows.Forms.ToolStripMenuItem();
            this.geneManageItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recipesManageItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formDetailItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userManageItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abountItem = new System.Windows.Forms.ToolStripMenuItem();
            this.corralTableAdapter = new MainProject.Database.FarmManageDataSetTableAdapters.CorralTableAdapter();
            this.geneTableAdapter = new MainProject.Database.FarmManageDataSetTableAdapters.GeneTableAdapter();
            this.cowTableAdapter = new MainProject.Database.FarmManageDataSetTableAdapters.CowTableAdapter();
            this.toolStripMenuItem8 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem9 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem10 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem11 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem12 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem13 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem14 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.cowStaticTableAdapter = new MainProject.Database.FarmManageDataSetTableAdapters.CowStaticTableAdapter();
            this.orderOutStaticTableAdapter = new MainProject.Database.FarmManageDataSetTableAdapters.OrderOutStaticTableAdapter();
            this.orderInStaticTableAdapter = new MainProject.Database.FarmManageDataSetTableAdapters.OrderInStaticTableAdapter();
            this.colCowNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCowSex = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.colCowCorral = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.colCowGene = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contentSplitContainer)).BeginInit();
            this.contentSplitContainer.Panel1.SuspendLayout();
            this.contentSplitContainer.Panel2.SuspendLayout();
            this.contentSplitContainer.SuspendLayout();
            this.leftPanel.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cowStaticBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.farmManageDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderOutStaticBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderInStaticBindingSource)).BeginInit();
            this.rightPanel.SuspendLayout();
            this.searchPanel.SuspendLayout();
            this.filterPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.corralBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.geneBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cowBindingSource)).BeginInit();
            this.pnlHeader.SuspendLayout();
            this.menuUser.SuspendLayout();
            this.mainMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.pnlMain.ColumnCount = 1;
            this.pnlMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.pnlMain.Controls.Add(this.lblTitle, 0, 1);
            this.pnlMain.Controls.Add(this.contentSplitContainer, 0, 2);
            this.pnlMain.Controls.Add(this.pnlHeader, 0, 0);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.RowCount = 3;
            this.pnlMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.pnlMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.pnlMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.pnlMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.pnlMain.Size = new System.Drawing.Size(784, 561);
            this.pnlMain.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.SystemColors.Window;
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblTitle.Location = new System.Drawing.Point(1, 27);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lblTitle.Size = new System.Drawing.Size(784, 60);
            this.lblTitle.TabIndex = 5;
            this.lblTitle.Text = "ระบบจัดการบริหารฟาร์มโค";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // contentSplitContainer
            // 
            this.contentSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contentSplitContainer.Location = new System.Drawing.Point(4, 91);
            this.contentSplitContainer.Name = "contentSplitContainer";
            // 
            // contentSplitContainer.Panel1
            // 
            this.contentSplitContainer.Panel1.Controls.Add(this.leftPanel);
            this.contentSplitContainer.Panel1MinSize = 180;
            // 
            // contentSplitContainer.Panel2
            // 
            this.contentSplitContainer.Panel2.Controls.Add(this.rightPanel);
            this.contentSplitContainer.Size = new System.Drawing.Size(778, 466);
            this.contentSplitContainer.SplitterDistance = 180;
            this.contentSplitContainer.TabIndex = 2;
            // 
            // leftPanel
            // 
            this.leftPanel.ColumnCount = 1;
            this.leftPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.leftPanel.Controls.Add(this.btnOrderManage, 0, 4);
            this.leftPanel.Controls.Add(this.tableLayoutPanel3, 0, 15);
            this.leftPanel.Controls.Add(this.btnBuy, 0, 0);
            this.leftPanel.Controls.Add(this.btnSell, 0, 2);
            this.leftPanel.Controls.Add(this.btnCustomer, 0, 6);
            this.leftPanel.Controls.Add(this.btnStock, 0, 8);
            this.leftPanel.Controls.Add(this.btnReport, 0, 10);
            this.leftPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.leftPanel.Location = new System.Drawing.Point(0, 0);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.RowCount = 16;
            this.leftPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.leftPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 3F));
            this.leftPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.leftPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 3F));
            this.leftPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.leftPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 3F));
            this.leftPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.leftPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 3F));
            this.leftPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.leftPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 3F));
            this.leftPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.leftPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 3F));
            this.leftPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.leftPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 3F));
            this.leftPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.leftPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.leftPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.leftPanel.Size = new System.Drawing.Size(180, 466);
            this.leftPanel.TabIndex = 0;
            // 
            // btnOrderManage
            // 
            this.btnOrderManage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnOrderManage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnOrderManage.Location = new System.Drawing.Point(3, 69);
            this.btnOrderManage.Name = "btnOrderManage";
            this.btnOrderManage.Size = new System.Drawing.Size(174, 24);
            this.btnOrderManage.TabIndex = 13;
            this.btnOrderManage.Text = "สรุปการซื้อขาย";
            this.btnOrderManage.UseVisualStyleBackColor = true;
            this.btnOrderManage.Click += new System.EventHandler(this.btnOrderManage_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 69.71831F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.28169F));
            this.tableLayoutPanel3.Controls.Add(this.label1, 0, 6);
            this.tableLayoutPanel3.Controls.Add(this.lblTotalCow, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.lblCowCurrentValue, 1, 3);
            this.tableLayoutPanel3.Controls.Add(this.lblCurrentCow, 0, 4);
            this.tableLayoutPanel3.Controls.Add(this.lbl, 1, 4);
            this.tableLayoutPanel3.Controls.Add(this.label7, 0, 5);
            this.tableLayoutPanel3.Controls.Add(this.lblUse1, 1, 6);
            this.tableLayoutPanel3.Controls.Add(this.lblTime, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.lblDate, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.label2, 1, 5);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 261);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 7;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(180, 205);
            this.tableLayoutPanel3.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 185);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "รายการขายค้างรับ";
            // 
            // lblTotalCow
            // 
            this.lblTotalCow.AutoSize = true;
            this.lblTotalCow.Location = new System.Drawing.Point(3, 125);
            this.lblTotalCow.Name = "lblTotalCow";
            this.lblTotalCow.Size = new System.Drawing.Size(85, 13);
            this.lblTotalCow.TabIndex = 0;
            this.lblTotalCow.Text = "จำนวนโคทั้งหมด";
            // 
            // lblCowCurrentValue
            // 
            this.lblCowCurrentValue.AutoSize = true;
            this.lblCowCurrentValue.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cowStaticBindingSource, "Total", true));
            this.lblCowCurrentValue.Location = new System.Drawing.Point(128, 125);
            this.lblCowCurrentValue.Name = "lblCowCurrentValue";
            this.lblCowCurrentValue.Size = new System.Drawing.Size(13, 13);
            this.lblCowCurrentValue.TabIndex = 1;
            this.lblCowCurrentValue.Text = "0";
            // 
            // cowStaticBindingSource
            // 
            this.cowStaticBindingSource.DataMember = "CowStatic";
            this.cowStaticBindingSource.DataSource = this.farmManageDataSet;
            // 
            // farmManageDataSet
            // 
            this.farmManageDataSet.DataSetName = "FarmManageDataSet";
            this.farmManageDataSet.Locale = new System.Globalization.CultureInfo("en");
            this.farmManageDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblCurrentCow
            // 
            this.lblCurrentCow.AutoSize = true;
            this.lblCurrentCow.Location = new System.Drawing.Point(3, 145);
            this.lblCurrentCow.Name = "lblCurrentCow";
            this.lblCurrentCow.Size = new System.Drawing.Size(86, 13);
            this.lblCurrentCow.TabIndex = 2;
            this.lblCurrentCow.Text = "จำนวนโคปัจจุบัน";
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cowStaticBindingSource, "CurrentCow", true));
            this.lbl.Location = new System.Drawing.Point(128, 145);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(13, 13);
            this.lbl.TabIndex = 3;
            this.lbl.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 165);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "รายการซื้อค้างจ่าย";
            // 
            // lblUse1
            // 
            this.lblUse1.AutoSize = true;
            this.lblUse1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orderOutStaticBindingSource, "PaymentStatus0", true));
            this.lblUse1.Location = new System.Drawing.Point(128, 185);
            this.lblUse1.Name = "lblUse1";
            this.lblUse1.Size = new System.Drawing.Size(13, 13);
            this.lblUse1.TabIndex = 6;
            this.lblUse1.Text = "0";
            // 
            // orderOutStaticBindingSource
            // 
            this.orderOutStaticBindingSource.DataMember = "OrderOutStatic";
            this.orderOutStaticBindingSource.DataSource = this.farmManageDataSet;
            // 
            // lblTime
            // 
            this.tableLayoutPanel3.SetColumnSpan(this.lblTime, 2);
            this.lblTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblTime.Location = new System.Drawing.Point(3, 35);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(174, 50);
            this.lblTime.TabIndex = 10;
            this.lblTime.Text = "22:22:22";
            this.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDate
            // 
            this.tableLayoutPanel3.SetColumnSpan(this.lblDate, 2);
            this.lblDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblDate.Location = new System.Drawing.Point(3, 85);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(174, 40);
            this.lblDate.TabIndex = 11;
            this.lblDate.Text = "12/12/2012";
            this.lblDate.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orderInStaticBindingSource, "PaymentStatus0", true));
            this.label2.Location = new System.Drawing.Point(128, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "0";
            // 
            // orderInStaticBindingSource
            // 
            this.orderInStaticBindingSource.DataMember = "OrderInStatic";
            this.orderInStaticBindingSource.DataSource = this.farmManageDataSet;
            // 
            // btnBuy
            // 
            this.btnBuy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnBuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnBuy.Location = new System.Drawing.Point(3, 3);
            this.btnBuy.Name = "btnBuy";
            this.btnBuy.Size = new System.Drawing.Size(174, 24);
            this.btnBuy.TabIndex = 0;
            this.btnBuy.Text = "การซื้อโค";
            this.btnBuy.UseVisualStyleBackColor = true;
            this.btnBuy.Click += new System.EventHandler(this.btnBuy_Click);
            // 
            // btnSell
            // 
            this.btnSell.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSell.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnSell.Location = new System.Drawing.Point(3, 36);
            this.btnSell.Name = "btnSell";
            this.btnSell.Size = new System.Drawing.Size(174, 24);
            this.btnSell.TabIndex = 1;
            this.btnSell.Text = "การขายโค";
            this.btnSell.UseVisualStyleBackColor = true;
            this.btnSell.Click += new System.EventHandler(this.btnSell_Click);
            // 
            // btnCustomer
            // 
            this.btnCustomer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnCustomer.Location = new System.Drawing.Point(3, 102);
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.Size = new System.Drawing.Size(174, 24);
            this.btnCustomer.TabIndex = 2;
            this.btnCustomer.Text = "จัดการลูกค้า";
            this.btnCustomer.UseVisualStyleBackColor = true;
            this.btnCustomer.Click += new System.EventHandler(this.btnCustomer_Click);
            // 
            // btnStock
            // 
            this.btnStock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnStock.Location = new System.Drawing.Point(3, 135);
            this.btnStock.Name = "btnStock";
            this.btnStock.Size = new System.Drawing.Size(174, 24);
            this.btnStock.TabIndex = 3;
            this.btnStock.Text = "จัดการพัสดุ";
            this.btnStock.UseVisualStyleBackColor = true;
            this.btnStock.Click += new System.EventHandler(this.btnStock_Click);
            // 
            // btnReport
            // 
            this.btnReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnReport.Location = new System.Drawing.Point(3, 168);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(174, 24);
            this.btnReport.TabIndex = 4;
            this.btnReport.Text = "แบบฟอร์ม";
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // rightPanel
            // 
            this.rightPanel.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.rightPanel.ColumnCount = 1;
            this.rightPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.rightPanel.Controls.Add(this.searchPanel, 0, 0);
            this.rightPanel.Controls.Add(this.filterPanel, 0, 2);
            this.rightPanel.Controls.Add(this.dgvGrid, 0, 3);
            this.rightPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rightPanel.Location = new System.Drawing.Point(0, 0);
            this.rightPanel.Name = "rightPanel";
            this.rightPanel.RowCount = 4;
            this.rightPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.rightPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 3F));
            this.rightPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.rightPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.rightPanel.Size = new System.Drawing.Size(594, 466);
            this.rightPanel.TabIndex = 0;
            // 
            // searchPanel
            // 
            this.searchPanel.Controls.Add(this.lblSearch);
            this.searchPanel.Controls.Add(this.tbxSearch);
            this.searchPanel.Controls.Add(this.btnSearchGo);
            this.searchPanel.Controls.Add(this.chxAllShow);
            this.searchPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchPanel.Location = new System.Drawing.Point(4, 4);
            this.searchPanel.Name = "searchPanel";
            this.searchPanel.Size = new System.Drawing.Size(588, 29);
            this.searchPanel.TabIndex = 1;
            // 
            // lblSearch
            // 
            this.lblSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.lblSearch.Location = new System.Drawing.Point(3, 0);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lblSearch.Size = new System.Drawing.Size(100, 30);
            this.lblSearch.TabIndex = 0;
            this.lblSearch.Text = "ค้นหา :";
            this.lblSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbxSearch
            // 
            this.tbxSearch.Location = new System.Drawing.Point(109, 3);
            this.tbxSearch.Name = "tbxSearch";
            this.tbxSearch.Size = new System.Drawing.Size(150, 20);
            this.tbxSearch.TabIndex = 1;
            this.tbxSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxSearch_KeyPress);
            // 
            // btnSearchGo
            // 
            this.btnSearchGo.Location = new System.Drawing.Point(265, 3);
            this.btnSearchGo.Name = "btnSearchGo";
            this.btnSearchGo.Size = new System.Drawing.Size(75, 23);
            this.btnSearchGo.TabIndex = 2;
            this.btnSearchGo.Text = "Go";
            this.btnSearchGo.UseVisualStyleBackColor = true;
            this.btnSearchGo.Click += new System.EventHandler(this.btnSearchGo_Click);
            // 
            // chxAllShow
            // 
            this.chxAllShow.Location = new System.Drawing.Point(373, 3);
            this.chxAllShow.Margin = new System.Windows.Forms.Padding(30, 3, 3, 3);
            this.chxAllShow.Name = "chxAllShow";
            this.chxAllShow.Size = new System.Drawing.Size(104, 24);
            this.chxAllShow.TabIndex = 3;
            this.chxAllShow.Text = "แสดงทั้งหมด";
            this.chxAllShow.UseVisualStyleBackColor = true;
            this.chxAllShow.CheckedChanged += new System.EventHandler(this.cbxFilter_SelectedIndexChanged);
            // 
            // filterPanel
            // 
            this.filterPanel.Controls.Add(this.lblCorral);
            this.filterPanel.Controls.Add(this.cbxCorral);
            this.filterPanel.Controls.Add(this.lblGene);
            this.filterPanel.Controls.Add(this.cbxGene);
            this.filterPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.filterPanel.Location = new System.Drawing.Point(4, 44);
            this.filterPanel.Name = "filterPanel";
            this.filterPanel.Size = new System.Drawing.Size(588, 29);
            this.filterPanel.TabIndex = 2;
            // 
            // lblCorral
            // 
            this.lblCorral.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.lblCorral.Location = new System.Drawing.Point(3, 0);
            this.lblCorral.Name = "lblCorral";
            this.lblCorral.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lblCorral.Size = new System.Drawing.Size(100, 27);
            this.lblCorral.TabIndex = 3;
            this.lblCorral.Text = "คอก :";
            this.lblCorral.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbxCorral
            // 
            this.cbxCorral.DisplayMember = "CorralID";
            this.cbxCorral.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCorral.FormattingEnabled = true;
            this.cbxCorral.Location = new System.Drawing.Point(109, 3);
            this.cbxCorral.Name = "cbxCorral";
            this.cbxCorral.Size = new System.Drawing.Size(150, 21);
            this.cbxCorral.TabIndex = 0;
            this.cbxCorral.ValueMember = "CorralID";
            this.cbxCorral.SelectedIndexChanged += new System.EventHandler(this.cbxFilter_SelectedIndexChanged);
            // 
            // lblGene
            // 
            this.lblGene.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.lblGene.Location = new System.Drawing.Point(265, 0);
            this.lblGene.Name = "lblGene";
            this.lblGene.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lblGene.Size = new System.Drawing.Size(100, 27);
            this.lblGene.TabIndex = 2;
            this.lblGene.Text = "พันธุ์ :";
            this.lblGene.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbxGene
            // 
            this.cbxGene.DisplayMember = "GeneID";
            this.cbxGene.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxGene.FormattingEnabled = true;
            this.cbxGene.Location = new System.Drawing.Point(371, 3);
            this.cbxGene.Name = "cbxGene";
            this.cbxGene.Size = new System.Drawing.Size(150, 21);
            this.cbxGene.TabIndex = 1;
            this.cbxGene.ValueMember = "GeneID";
            this.cbxGene.SelectedIndexChanged += new System.EventHandler(this.cbxFilter_SelectedIndexChanged);
            // 
            // dgvGrid
            // 
            this.dgvGrid.AllowUserToAddRows = false;
            this.dgvGrid.AllowUserToDeleteRows = false;
            this.dgvGrid.AutoGenerateColumns = false;
            this.dgvGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCowNO,
            this.colCowSex,
            this.colCowCorral,
            this.colCowGene});
            this.dgvGrid.DataSource = this.cowBindingSource;
            this.dgvGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvGrid.Location = new System.Drawing.Point(4, 80);
            this.dgvGrid.Name = "dgvGrid";
            this.dgvGrid.ReadOnly = true;
            this.dgvGrid.Size = new System.Drawing.Size(588, 382);
            this.dgvGrid.TabIndex = 3;
            this.dgvGrid.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvGrid_CellMouseDoubleClick);
            // 
            // corralBindingSource
            // 
            this.corralBindingSource.DataMember = "Corral";
            this.corralBindingSource.DataSource = this.farmManageDataSet;
            // 
            // geneBindingSource
            // 
            this.geneBindingSource.DataMember = "Gene";
            this.geneBindingSource.DataSource = this.farmManageDataSet;
            // 
            // cowBindingSource
            // 
            this.cowBindingSource.DataMember = "Cow";
            this.cowBindingSource.DataSource = this.farmManageDataSet;
            // 
            // pnlHeader
            // 
            this.pnlHeader.ColumnCount = 2;
            this.pnlHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.pnlHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.pnlHeader.Controls.Add(this.menuUser, 0, 0);
            this.pnlHeader.Controls.Add(this.mainMenuStrip, 0, 0);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlHeader.Location = new System.Drawing.Point(1, 1);
            this.pnlHeader.Margin = new System.Windows.Forms.Padding(0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.RowCount = 1;
            this.pnlHeader.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.pnlHeader.Size = new System.Drawing.Size(784, 25);
            this.pnlHeader.TabIndex = 4;
            // 
            // menuUser
            // 
            this.menuUser.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiCurrentUser});
            this.menuUser.Location = new System.Drawing.Point(392, 0);
            this.menuUser.Name = "menuUser";
            this.menuUser.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuUser.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuUser.Size = new System.Drawing.Size(392, 24);
            this.menuUser.TabIndex = 2;
            this.menuUser.Text = "menuStrip1";
            // 
            // tsmiCurrentUser
            // 
            this.tsmiCurrentUser.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiCurrentUserDetail,
            this.tsmiCurrentUserPassword,
            this.toolStripSeparator5,
            this.tsmiCurrentLogOut});
            this.tsmiCurrentUser.Name = "tsmiCurrentUser";
            this.tsmiCurrentUser.Size = new System.Drawing.Size(38, 20);
            this.tsmiCurrentUser.Text = "ผู้ใช้";
            // 
            // tsmiCurrentUserDetail
            // 
            this.tsmiCurrentUserDetail.Name = "tsmiCurrentUserDetail";
            this.tsmiCurrentUserDetail.Size = new System.Drawing.Size(140, 22);
            this.tsmiCurrentUserDetail.Text = "ข้อมูลผู้ใช้";
            this.tsmiCurrentUserDetail.Click += new System.EventHandler(this.tsmiUserDetailItem_Click);
            // 
            // tsmiCurrentUserPassword
            // 
            this.tsmiCurrentUserPassword.Name = "tsmiCurrentUserPassword";
            this.tsmiCurrentUserPassword.Size = new System.Drawing.Size(140, 22);
            this.tsmiCurrentUserPassword.Text = "เปลี่ยนรหัสผ่าน";
            this.tsmiCurrentUserPassword.Click += new System.EventHandler(this.tsmiUserPasswordItem_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(137, 6);
            // 
            // tsmiCurrentLogOut
            // 
            this.tsmiCurrentLogOut.Name = "tsmiCurrentLogOut";
            this.tsmiCurrentLogOut.Size = new System.Drawing.Size(140, 22);
            this.tsmiCurrentLogOut.Text = "ออกจากระบบ";
            this.tsmiCurrentLogOut.Click += new System.EventHandler(this.tsmiLogOutItem_Click);
            // 
            // mainMenuStrip
            // 
            this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiFile,
            this.tsmiUser,
            this.tsmiManage,
            this.tsmiStaticItem,
            this.tsmiSetting,
            this.tsmiHelp});
            this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.mainMenuStrip.Name = "mainMenuStrip";
            this.mainMenuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.mainMenuStrip.Size = new System.Drawing.Size(392, 24);
            this.mainMenuStrip.TabIndex = 1;
            this.mainMenuStrip.Text = "mainMenuStrip";
            // 
            // tsmiFile
            // 
            this.tsmiFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiBackupItem,
            this.tsmiLogOutItem,
            this.toolStripSeparator2,
            this.tsmiExitItem});
            this.tsmiFile.Name = "tsmiFile";
            this.tsmiFile.Size = new System.Drawing.Size(38, 20);
            this.tsmiFile.Text = "ไฟล์";
            // 
            // tsmiBackupItem
            // 
            this.tsmiBackupItem.Name = "tsmiBackupItem";
            this.tsmiBackupItem.Size = new System.Drawing.Size(168, 22);
            this.tsmiBackupItem.Text = "สำรองข้อมูลและคือค่า";
            this.tsmiBackupItem.Click += new System.EventHandler(this.tsmiBackupItem_Click);
            // 
            // tsmiLogOutItem
            // 
            this.tsmiLogOutItem.Name = "tsmiLogOutItem";
            this.tsmiLogOutItem.Size = new System.Drawing.Size(168, 22);
            this.tsmiLogOutItem.Text = "ออกจากระบบ";
            this.tsmiLogOutItem.Click += new System.EventHandler(this.tsmiLogOutItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(165, 6);
            // 
            // tsmiExitItem
            // 
            this.tsmiExitItem.Name = "tsmiExitItem";
            this.tsmiExitItem.Size = new System.Drawing.Size(168, 22);
            this.tsmiExitItem.Text = "ปิดโปรแกรม";
            this.tsmiExitItem.Click += new System.EventHandler(this.tsmiExitItem_Click);
            // 
            // tsmiUser
            // 
            this.tsmiUser.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiUserDetailItem,
            this.tsmiUserPasswordItem});
            this.tsmiUser.Name = "tsmiUser";
            this.tsmiUser.Size = new System.Drawing.Size(38, 20);
            this.tsmiUser.Text = "ผู้ใช้";
            this.tsmiUser.Visible = false;
            // 
            // tsmiUserDetailItem
            // 
            this.tsmiUserDetailItem.Name = "tsmiUserDetailItem";
            this.tsmiUserDetailItem.Size = new System.Drawing.Size(140, 22);
            this.tsmiUserDetailItem.Text = "ข้อมูลผู้ใช้";
            this.tsmiUserDetailItem.Click += new System.EventHandler(this.tsmiUserDetailItem_Click);
            // 
            // tsmiUserPasswordItem
            // 
            this.tsmiUserPasswordItem.Name = "tsmiUserPasswordItem";
            this.tsmiUserPasswordItem.Size = new System.Drawing.Size(140, 22);
            this.tsmiUserPasswordItem.Text = "เปลี่ยนรหัสผ่าน";
            this.tsmiUserPasswordItem.Click += new System.EventHandler(this.tsmiUserPasswordItem_Click);
            // 
            // tsmiManage
            // 
            this.tsmiManage.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiCorralItem,
            this.tsmiGeneItem,
            this.tmsiSuppliesItem,
            this.tsmiCustomerItem,
            this.tsmiUserItem,
            this.tsmiRecipesItem,
            this.tmsiOrderItem,
            this.tsmiOtherOrderMgn});
            this.tsmiManage.Name = "tsmiManage";
            this.tsmiManage.Size = new System.Drawing.Size(66, 20);
            this.tsmiManage.Text = "การจัดการ";
            // 
            // tsmiCorralItem
            // 
            this.tsmiCorralItem.Name = "tsmiCorralItem";
            this.tsmiCorralItem.Size = new System.Drawing.Size(160, 22);
            this.tsmiCorralItem.Text = "จัดการคอก";
            this.tsmiCorralItem.Click += new System.EventHandler(this.tsmiCorralItem_Click);
            // 
            // tsmiGeneItem
            // 
            this.tsmiGeneItem.Name = "tsmiGeneItem";
            this.tsmiGeneItem.Size = new System.Drawing.Size(160, 22);
            this.tsmiGeneItem.Text = "จัดการพันธุ์โค";
            this.tsmiGeneItem.Click += new System.EventHandler(this.tsmiGeneItem_Click);
            // 
            // tmsiSuppliesItem
            // 
            this.tmsiSuppliesItem.Name = "tmsiSuppliesItem";
            this.tmsiSuppliesItem.Size = new System.Drawing.Size(160, 22);
            this.tmsiSuppliesItem.Text = "จัดการพัสดุ";
            this.tmsiSuppliesItem.Click += new System.EventHandler(this.tmsiSuppliesItem_Click);
            // 
            // tsmiCustomerItem
            // 
            this.tsmiCustomerItem.Name = "tsmiCustomerItem";
            this.tsmiCustomerItem.Size = new System.Drawing.Size(160, 22);
            this.tsmiCustomerItem.Text = "จัดการลูกค้า";
            this.tsmiCustomerItem.Click += new System.EventHandler(this.tsmiCustomerItem_Click);
            // 
            // tsmiUserItem
            // 
            this.tsmiUserItem.Name = "tsmiUserItem";
            this.tsmiUserItem.Size = new System.Drawing.Size(160, 22);
            this.tsmiUserItem.Text = "จัดการผู้ใช้";
            this.tsmiUserItem.Click += new System.EventHandler(this.tsmiUserItem_Click);
            // 
            // tsmiRecipesItem
            // 
            this.tsmiRecipesItem.Name = "tsmiRecipesItem";
            this.tsmiRecipesItem.Size = new System.Drawing.Size(160, 22);
            this.tsmiRecipesItem.Text = "จัดการสูตรอาหารโค";
            this.tsmiRecipesItem.Click += new System.EventHandler(this.tsmiRecipesItem_Click);
            // 
            // tmsiOrderItem
            // 
            this.tmsiOrderItem.Name = "tmsiOrderItem";
            this.tmsiOrderItem.Size = new System.Drawing.Size(160, 22);
            this.tmsiOrderItem.Text = "สรุปรายการซื้อขาย";
            this.tmsiOrderItem.Click += new System.EventHandler(this.tmsiOrderItem_Click);
            // 
            // tsmiOtherOrderMgn
            // 
            this.tsmiOtherOrderMgn.Name = "tsmiOtherOrderMgn";
            this.tsmiOtherOrderMgn.Size = new System.Drawing.Size(160, 22);
            this.tsmiOtherOrderMgn.Text = "สรุปรายการเกิดตาย";
            this.tsmiOtherOrderMgn.Click += new System.EventHandler(this.tsmiOtherOrderMgn_Click);
            // 
            // tsmiStaticItem
            // 
            this.tsmiStaticItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiStatic,
            this.tsmiCowPrice});
            this.tsmiStaticItem.Name = "tsmiStaticItem";
            this.tsmiStaticItem.Size = new System.Drawing.Size(39, 20);
            this.tsmiStaticItem.Text = "สถิติ";
            // 
            // tsmiStatic
            // 
            this.tsmiStatic.Name = "tsmiStatic";
            this.tsmiStatic.Size = new System.Drawing.Size(176, 22);
            this.tsmiStatic.Text = "สถิติ";
            this.tsmiStatic.Click += new System.EventHandler(this.tsmiStatic_Click);
            // 
            // tsmiCowPrice
            // 
            this.tsmiCowPrice.Name = "tsmiCowPrice";
            this.tsmiCowPrice.Size = new System.Drawing.Size(176, 22);
            this.tsmiCowPrice.Text = "ประเมินแนวโน้มราคาโค";
            this.tsmiCowPrice.Click += new System.EventHandler(this.tsmiCowPrice_Click);
            // 
            // tsmiSetting
            // 
            this.tsmiSetting.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiFarmDetailItem,
            this.toolStripSeparator3,
            this.tsmiFormat,
            this.tsmiSettingItem});
            this.tsmiSetting.Name = "tsmiSetting";
            this.tsmiSetting.Size = new System.Drawing.Size(60, 20);
            this.tsmiSetting.Text = "การตั้งค่า";
            // 
            // tsmiFarmDetailItem
            // 
            this.tsmiFarmDetailItem.Name = "tsmiFarmDetailItem";
            this.tsmiFarmDetailItem.Size = new System.Drawing.Size(161, 22);
            this.tsmiFarmDetailItem.Text = "ข้อมูลฟาร์ม";
            this.tsmiFarmDetailItem.Click += new System.EventHandler(this.tsmiFarmDetailItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(158, 6);
            // 
            // tsmiFormat
            // 
            this.tsmiFormat.Name = "tsmiFormat";
            this.tsmiFormat.Size = new System.Drawing.Size(161, 22);
            this.tsmiFormat.Text = "ตั้งค่ารูปแบบวันเวลา";
            this.tsmiFormat.Click += new System.EventHandler(this.tsmiFormat_Click);
            // 
            // tsmiSettingItem
            // 
            this.tsmiSettingItem.Name = "tsmiSettingItem";
            this.tsmiSettingItem.Size = new System.Drawing.Size(161, 22);
            this.tsmiSettingItem.Text = "การตั้งค่า";
            this.tsmiSettingItem.Click += new System.EventHandler(this.tsmiSettingItem_Click);
            // 
            // tsmiHelp
            // 
            this.tsmiHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiHelpItem,
            this.tsmiAboutItem});
            this.tsmiHelp.Name = "tsmiHelp";
            this.tsmiHelp.Size = new System.Drawing.Size(59, 20);
            this.tsmiHelp.Text = "ช่วยเหลือ";
            // 
            // tsmiHelpItem
            // 
            this.tsmiHelpItem.Name = "tsmiHelpItem";
            this.tsmiHelpItem.Size = new System.Drawing.Size(149, 22);
            this.tsmiHelpItem.Text = "ช่วยเหลือ";
            this.tsmiHelpItem.Click += new System.EventHandler(this.tsmiHelpItem_Click);
            // 
            // tsmiAboutItem
            // 
            this.tsmiAboutItem.Name = "tsmiAboutItem";
            this.tsmiAboutItem.Size = new System.Drawing.Size(149, 22);
            this.tsmiAboutItem.Text = "เกี่ยวกับโปรแกรม";
            this.tsmiAboutItem.Click += new System.EventHandler(this.tsmiAboutItem_Click);
            // 
            // fileMenuItem
            // 
            this.fileMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logoutItem,
            this.toolStripSeparator1,
            this.exitItem});
            this.fileMenuItem.Name = "fileMenuItem";
            this.fileMenuItem.Size = new System.Drawing.Size(38, 20);
            this.fileMenuItem.Text = "ไฟล์";
            // 
            // logoutItem
            // 
            this.logoutItem.Name = "logoutItem";
            this.logoutItem.Size = new System.Drawing.Size(134, 22);
            this.logoutItem.Text = "ออกจากระบบ";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(131, 6);
            // 
            // exitItem
            // 
            this.exitItem.Name = "exitItem";
            this.exitItem.Size = new System.Drawing.Size(134, 22);
            this.exitItem.Text = "ปิดโปรแกรม";
            // 
            // userMenuItem
            // 
            this.userMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userItem,
            this.changePasswordMenuItem});
            this.userMenuItem.Name = "userMenuItem";
            this.userMenuItem.Size = new System.Drawing.Size(38, 20);
            this.userMenuItem.Text = "ผู้ใช้";
            // 
            // userItem
            // 
            this.userItem.Name = "userItem";
            this.userItem.Size = new System.Drawing.Size(140, 22);
            this.userItem.Text = "ข้อมูลผู้ใช้";
            // 
            // changePasswordMenuItem
            // 
            this.changePasswordMenuItem.Name = "changePasswordMenuItem";
            this.changePasswordMenuItem.Size = new System.Drawing.Size(140, 22);
            this.changePasswordMenuItem.Text = "เปลี่ยนรหัสผ่าน";
            // 
            // manageMenuItem
            // 
            this.manageMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.corralManageItem,
            this.medicineItem,
            this.geneManageItem,
            this.recipesManageItem,
            this.formDetailItem,
            this.userManageItem});
            this.manageMenuItem.Name = "manageMenuItem";
            this.manageMenuItem.Size = new System.Drawing.Size(66, 20);
            this.manageMenuItem.Text = "การจัดการ";
            // 
            // corralManageItem
            // 
            this.corralManageItem.Name = "corralManageItem";
            this.corralManageItem.Size = new System.Drawing.Size(150, 22);
            this.corralManageItem.Text = "จัดการคอก";
            // 
            // medicineItem
            // 
            this.medicineItem.Name = "medicineItem";
            this.medicineItem.Size = new System.Drawing.Size(150, 22);
            this.medicineItem.Text = "จัดการพัสดุ";
            // 
            // geneManageItem
            // 
            this.geneManageItem.Name = "geneManageItem";
            this.geneManageItem.Size = new System.Drawing.Size(150, 22);
            this.geneManageItem.Text = "จัดกาพันธ์สัตร";
            // 
            // recipesManageItem
            // 
            this.recipesManageItem.Name = "recipesManageItem";
            this.recipesManageItem.Size = new System.Drawing.Size(150, 22);
            this.recipesManageItem.Text = "จัดการสูตรอาหาร";
            // 
            // formDetailItem
            // 
            this.formDetailItem.Name = "formDetailItem";
            this.formDetailItem.Size = new System.Drawing.Size(150, 22);
            this.formDetailItem.Text = "ข้อมูลฟาร์ม";
            // 
            // userManageItem
            // 
            this.userManageItem.Name = "userManageItem";
            this.userManageItem.Size = new System.Drawing.Size(150, 22);
            this.userManageItem.Text = "จัดการผู้ใช้";
            // 
            // optionMenuItem
            // 
            this.optionMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionItem});
            this.optionMenuItem.Name = "optionMenuItem";
            this.optionMenuItem.Size = new System.Drawing.Size(53, 20);
            this.optionMenuItem.Text = "ตัวเลือก";
            // 
            // optionItem
            // 
            this.optionItem.Name = "optionItem";
            this.optionItem.Size = new System.Drawing.Size(108, 22);
            this.optionItem.Text = "ตัวเลือก";
            // 
            // helpMenuItem
            // 
            this.helpMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpItem,
            this.abountItem});
            this.helpMenuItem.Name = "helpMenuItem";
            this.helpMenuItem.Size = new System.Drawing.Size(59, 20);
            this.helpMenuItem.Text = "ช่วยเหลือ";
            // 
            // helpItem
            // 
            this.helpItem.Name = "helpItem";
            this.helpItem.Size = new System.Drawing.Size(114, 22);
            this.helpItem.Text = "ช่วยเหลือ";
            // 
            // abountItem
            // 
            this.abountItem.Name = "abountItem";
            this.abountItem.Size = new System.Drawing.Size(114, 22);
            this.abountItem.Text = "เกียวกับ";
            // 
            // corralTableAdapter
            // 
            this.corralTableAdapter.ClearBeforeFill = true;
            // 
            // geneTableAdapter
            // 
            this.geneTableAdapter.ClearBeforeFill = true;
            // 
            // cowTableAdapter
            // 
            this.cowTableAdapter.ClearBeforeFill = true;
            // 
            // toolStripMenuItem8
            // 
            this.toolStripMenuItem8.Name = "toolStripMenuItem8";
            this.toolStripMenuItem8.Size = new System.Drawing.Size(160, 22);
            this.toolStripMenuItem8.Text = "จัดการคอก";
            // 
            // toolStripMenuItem9
            // 
            this.toolStripMenuItem9.Name = "toolStripMenuItem9";
            this.toolStripMenuItem9.Size = new System.Drawing.Size(160, 22);
            this.toolStripMenuItem9.Text = "จัดการพันธุ์โค";
            // 
            // toolStripMenuItem10
            // 
            this.toolStripMenuItem10.Name = "toolStripMenuItem10";
            this.toolStripMenuItem10.Size = new System.Drawing.Size(160, 22);
            this.toolStripMenuItem10.Text = "จัดการพัสดุ";
            // 
            // toolStripMenuItem11
            // 
            this.toolStripMenuItem11.Name = "toolStripMenuItem11";
            this.toolStripMenuItem11.Size = new System.Drawing.Size(160, 22);
            this.toolStripMenuItem11.Text = "จัดการลูกค้า";
            // 
            // toolStripMenuItem12
            // 
            this.toolStripMenuItem12.Name = "toolStripMenuItem12";
            this.toolStripMenuItem12.Size = new System.Drawing.Size(160, 22);
            this.toolStripMenuItem12.Text = "จัดการการซื้อขาย";
            // 
            // toolStripMenuItem13
            // 
            this.toolStripMenuItem13.Name = "toolStripMenuItem13";
            this.toolStripMenuItem13.Size = new System.Drawing.Size(160, 22);
            this.toolStripMenuItem13.Text = "จัดการผู้ใช้";
            // 
            // toolStripMenuItem14
            // 
            this.toolStripMenuItem14.Name = "toolStripMenuItem14";
            this.toolStripMenuItem14.Size = new System.Drawing.Size(160, 22);
            this.toolStripMenuItem14.Text = "จัดการสูตรอาหารโค";
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(140, 22);
            this.toolStripMenuItem5.Text = "ข้อมูลผู้ใช้";
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(140, 22);
            this.toolStripMenuItem6.Text = "เปลี่ยนรหัสผ่าน";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(134, 22);
            this.toolStripMenuItem2.Text = "ออกจากระบบ";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(131, 6);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(134, 22);
            this.toolStripMenuItem3.Text = "ปิดโปรแกรม";
            // 
            // cowStaticTableAdapter
            // 
            this.cowStaticTableAdapter.ClearBeforeFill = true;
            // 
            // orderOutStaticTableAdapter
            // 
            this.orderOutStaticTableAdapter.ClearBeforeFill = true;
            // 
            // orderInStaticTableAdapter
            // 
            this.orderInStaticTableAdapter.ClearBeforeFill = true;
            // 
            // colCowNO
            // 
            this.colCowNO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colCowNO.DataPropertyName = "CowNO";
            this.colCowNO.HeaderText = "NO";
            this.colCowNO.Name = "colCowNO";
            this.colCowNO.ReadOnly = true;
            // 
            // colCowSex
            // 
            this.colCowSex.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colCowSex.DataPropertyName = "Sex";
            this.colCowSex.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.colCowSex.HeaderText = "เพศ";
            this.colCowSex.Name = "colCowSex";
            this.colCowSex.ReadOnly = true;
            this.colCowSex.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colCowSex.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // colCowCorral
            // 
            this.colCowCorral.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colCowCorral.DataPropertyName = "CorralID";
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
            // colCowGene
            // 
            this.colCowGene.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colCowGene.DataPropertyName = "GeneID";
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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.pnlMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ระบบจัดการบริหารฟาร์มโค";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.contentSplitContainer.Panel1.ResumeLayout(false);
            this.contentSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.contentSplitContainer)).EndInit();
            this.contentSplitContainer.ResumeLayout(false);
            this.leftPanel.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cowStaticBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.farmManageDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderOutStaticBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderInStaticBindingSource)).EndInit();
            this.rightPanel.ResumeLayout(false);
            this.searchPanel.ResumeLayout(false);
            this.searchPanel.PerformLayout();
            this.filterPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.corralBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.geneBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cowBindingSource)).EndInit();
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.menuUser.ResumeLayout(false);
            this.menuUser.PerformLayout();
            this.mainMenuStrip.ResumeLayout(false);
            this.mainMenuStrip.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel pnlMain;
        private System.Windows.Forms.ToolStripMenuItem fileMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpItem;
        private System.Windows.Forms.ToolStripMenuItem abountItem;
        private System.Windows.Forms.SplitContainer contentSplitContainer;
        private System.Windows.Forms.TableLayoutPanel leftPanel;
        private System.Windows.Forms.Button btnBuy;
        private System.Windows.Forms.Button btnSell;
        private System.Windows.Forms.Button btnCustomer;
        private System.Windows.Forms.Button btnStock;
        private System.Windows.Forms.ToolStripMenuItem optionMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionItem;
        private System.Windows.Forms.ToolStripMenuItem exitItem;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.TableLayoutPanel rightPanel;
        private System.Windows.Forms.FlowLayoutPanel searchPanel;
        private System.Windows.Forms.FlowLayoutPanel filterPanel;
        private System.Windows.Forms.DataGridView dgvGrid;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox tbxSearch;
        private System.Windows.Forms.Label lblCorral;
        private System.Windows.Forms.ComboBox cbxCorral;
        private System.Windows.Forms.Label lblGene;
        private System.Windows.Forms.ComboBox cbxGene;
        private System.Windows.Forms.ToolStripMenuItem manageMenuItem;
        private System.Windows.Forms.ToolStripMenuItem corralManageItem;
        private System.Windows.Forms.ToolStripMenuItem medicineItem;
        private System.Windows.Forms.ToolStripMenuItem geneManageItem;
        private System.Windows.Forms.ToolStripMenuItem recipesManageItem;
        private System.Windows.Forms.ToolStripMenuItem formDetailItem;
        private System.Windows.Forms.ToolStripMenuItem userManageItem;
        private System.Windows.Forms.ToolStripMenuItem userMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userItem;
        private System.Windows.Forms.ToolStripMenuItem changePasswordMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem logoutItem;
        private System.Windows.Forms.Button btnSearchGo;
        private Database.FarmManageDataSet farmManageDataSet;
        private System.Windows.Forms.BindingSource corralBindingSource;
        private Database.FarmManageDataSetTableAdapters.CorralTableAdapter corralTableAdapter;
        private System.Windows.Forms.BindingSource geneBindingSource;
        private Database.FarmManageDataSetTableAdapters.GeneTableAdapter geneTableAdapter;
        private System.Windows.Forms.BindingSource cowBindingSource;
        private Database.FarmManageDataSetTableAdapters.CowTableAdapter cowTableAdapter;
        private System.Windows.Forms.CheckBox chxAllShow;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TableLayoutPanel pnlHeader;
        private System.Windows.Forms.MenuStrip menuUser;
        private System.Windows.Forms.ToolStripMenuItem tsmiCurrentUser;
        private System.Windows.Forms.ToolStripMenuItem tsmiCurrentUserDetail;
        private System.Windows.Forms.ToolStripMenuItem tsmiCurrentUserPassword;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem tsmiCurrentLogOut;
        private System.Windows.Forms.MenuStrip mainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem tsmiFile;
        private System.Windows.Forms.ToolStripMenuItem tsmiLogOutItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem tsmiExitItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiUser;
        private System.Windows.Forms.ToolStripMenuItem tsmiUserDetailItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiUserPasswordItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiManage;
        private System.Windows.Forms.ToolStripMenuItem tsmiCorralItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiGeneItem;
        private System.Windows.Forms.ToolStripMenuItem tmsiSuppliesItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiCustomerItem;
        private System.Windows.Forms.ToolStripMenuItem tmsiOrderItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiUserItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiRecipesItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiSetting;
        private System.Windows.Forms.ToolStripMenuItem tsmiFarmDetailItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem tsmiSettingItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiHelp;
        private System.Windows.Forms.ToolStripMenuItem tsmiHelpItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiAboutItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem8;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem9;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem10;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem11;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem12;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem13;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem14;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label lblTotalCow;
        private System.Windows.Forms.Label lblCowCurrentValue;
        private System.Windows.Forms.Label lblCurrentCow;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblUse1;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Button btnOrderManage;
        private System.Windows.Forms.ToolStripMenuItem tsmiFormat;
        private System.Windows.Forms.ToolStripMenuItem tsmiStaticItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiStatic;
        private System.Windows.Forms.ToolStripMenuItem tsmiCowPrice;
        private System.Windows.Forms.BindingSource cowStaticBindingSource;
        private Database.FarmManageDataSetTableAdapters.CowStaticTableAdapter cowStaticTableAdapter;
        private System.Windows.Forms.BindingSource orderOutStaticBindingSource;
        private Database.FarmManageDataSetTableAdapters.OrderOutStaticTableAdapter orderOutStaticTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource orderInStaticBindingSource;
        private Database.FarmManageDataSetTableAdapters.OrderInStaticTableAdapter orderInStaticTableAdapter;
        private System.Windows.Forms.ToolStripMenuItem tsmiOtherOrderMgn;
        private System.Windows.Forms.ToolStripMenuItem tsmiBackupItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCowNO;
        private System.Windows.Forms.DataGridViewComboBoxColumn colCowSex;
        private System.Windows.Forms.DataGridViewComboBoxColumn colCowCorral;
        private System.Windows.Forms.DataGridViewComboBoxColumn colCowGene;
    }
}
namespace MainProject.UserInterface.Order
{
    partial class OrderManageForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderManageForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlMain = new System.Windows.Forms.TableLayoutPanel();
            this.footerFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.tcMain = new System.Windows.Forms.TabControl();
            this.tabOrderIn = new System.Windows.Forms.TabPage();
            this.gbxOrderIn = new System.Windows.Forms.GroupBox();
            this.pnlOrderInContent = new System.Windows.Forms.TableLayoutPanel();
            this.cFooterFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAddOrderIn = new System.Windows.Forms.Button();
            this.dgvIn = new System.Windows.Forms.DataGridView();
            this.customerViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.farmManageDataSet = new MainProject.Database.FarmManageDataSet();
            this.orderInBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabOrderOut = new System.Windows.Forms.TabPage();
            this.gbxOrderOut = new System.Windows.Forms.GroupBox();
            this.pnlOrderOutContent = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAddOrderOut = new System.Windows.Forms.Button();
            this.dgvOut = new System.Windows.Forms.DataGridView();
            this.orderOutBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usersViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.orderInTableAdapter = new MainProject.Database.FarmManageDataSetTableAdapters.OrderInTableAdapter();
            this.orderOutTableAdapter = new MainProject.Database.FarmManageDataSetTableAdapters.OrderOutTableAdapter();
            this.customerViewTableAdapter = new MainProject.Database.FarmManageDataSetTableAdapters.CustomerViewTableAdapter();
            this.usersViewTableAdapter = new MainProject.Database.FarmManageDataSetTableAdapters.UsersViewTableAdapter();
            this.colOrderOutID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOrderOutType = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.colOrderOutDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOrderOutAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOrderOutPaymentStatus = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.colOrderInID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOrderInType = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.colOrderInDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOrderInAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOrderInPaymentStatus = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.pnlMain.SuspendLayout();
            this.footerFlowLayoutPanel.SuspendLayout();
            this.tcMain.SuspendLayout();
            this.tabOrderIn.SuspendLayout();
            this.gbxOrderIn.SuspendLayout();
            this.pnlOrderInContent.SuspendLayout();
            this.cFooterFlowLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.farmManageDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderInBindingSource)).BeginInit();
            this.tabOrderOut.SuspendLayout();
            this.gbxOrderOut.SuspendLayout();
            this.pnlOrderOutContent.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderOutBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersViewBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            resources.ApplyResources(this.pnlMain, "pnlMain");
            this.pnlMain.Controls.Add(this.footerFlowLayoutPanel, 0, 2);
            this.pnlMain.Controls.Add(this.lblTitle, 0, 0);
            this.pnlMain.Controls.Add(this.tcMain, 0, 1);
            this.pnlMain.Name = "pnlMain";
            // 
            // footerFlowLayoutPanel
            // 
            this.footerFlowLayoutPanel.Controls.Add(this.btnClose);
            resources.ApplyResources(this.footerFlowLayoutPanel, "footerFlowLayoutPanel");
            this.footerFlowLayoutPanel.Name = "footerFlowLayoutPanel";
            // 
            // btnClose
            // 
            resources.ApplyResources(this.btnClose, "btnClose");
            this.btnClose.Name = "btnClose";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblTitle
            // 
            resources.ApplyResources(this.lblTitle, "lblTitle");
            this.lblTitle.BackColor = System.Drawing.SystemColors.Window;
            this.lblTitle.Name = "lblTitle";
            // 
            // tcMain
            // 
            this.tcMain.Controls.Add(this.tabOrderIn);
            this.tcMain.Controls.Add(this.tabOrderOut);
            resources.ApplyResources(this.tcMain, "tcMain");
            this.tcMain.Name = "tcMain";
            this.tcMain.SelectedIndex = 0;
            // 
            // tabOrderIn
            // 
            this.tabOrderIn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabOrderIn.Controls.Add(this.gbxOrderIn);
            resources.ApplyResources(this.tabOrderIn, "tabOrderIn");
            this.tabOrderIn.Name = "tabOrderIn";
            // 
            // gbxOrderIn
            // 
            this.gbxOrderIn.Controls.Add(this.pnlOrderInContent);
            resources.ApplyResources(this.gbxOrderIn, "gbxOrderIn");
            this.gbxOrderIn.Name = "gbxOrderIn";
            this.gbxOrderIn.TabStop = false;
            // 
            // pnlOrderInContent
            // 
            resources.ApplyResources(this.pnlOrderInContent, "pnlOrderInContent");
            this.pnlOrderInContent.Controls.Add(this.cFooterFlowLayoutPanel, 0, 1);
            this.pnlOrderInContent.Controls.Add(this.dgvIn, 0, 0);
            this.pnlOrderInContent.Name = "pnlOrderInContent";
            // 
            // cFooterFlowLayoutPanel
            // 
            this.cFooterFlowLayoutPanel.Controls.Add(this.btnAddOrderIn);
            resources.ApplyResources(this.cFooterFlowLayoutPanel, "cFooterFlowLayoutPanel");
            this.cFooterFlowLayoutPanel.Name = "cFooterFlowLayoutPanel";
            // 
            // btnAddOrderIn
            // 
            resources.ApplyResources(this.btnAddOrderIn, "btnAddOrderIn");
            this.btnAddOrderIn.Name = "btnAddOrderIn";
            this.btnAddOrderIn.UseVisualStyleBackColor = true;
            this.btnAddOrderIn.Click += new System.EventHandler(this.btnAddOrderIn_Click);
            // 
            // dgvIn
            // 
            this.dgvIn.AllowUserToAddRows = false;
            this.dgvIn.AllowUserToDeleteRows = false;
            this.dgvIn.AutoGenerateColumns = false;
            this.dgvIn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIn.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colOrderInID,
            this.colOrderInType,
            this.colOrderInDate,
            this.colOrderInAmount,
            this.colOrderInPaymentStatus});
            this.dgvIn.DataSource = this.orderInBindingSource;
            resources.ApplyResources(this.dgvIn, "dgvIn");
            this.dgvIn.Name = "dgvIn";
            this.dgvIn.ReadOnly = true;
            this.dgvIn.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvIn_CellMouseDoubleClick);
            // 
            // customerViewBindingSource
            // 
            this.customerViewBindingSource.DataMember = "CustomerView";
            this.customerViewBindingSource.DataSource = this.farmManageDataSet;
            // 
            // farmManageDataSet
            // 
            this.farmManageDataSet.DataSetName = "FarmManageDataSet";
            this.farmManageDataSet.Locale = new System.Globalization.CultureInfo("en");
            this.farmManageDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // orderInBindingSource
            // 
            this.orderInBindingSource.DataMember = "OrderIn";
            this.orderInBindingSource.DataSource = this.farmManageDataSet;
            // 
            // tabOrderOut
            // 
            this.tabOrderOut.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabOrderOut.Controls.Add(this.gbxOrderOut);
            resources.ApplyResources(this.tabOrderOut, "tabOrderOut");
            this.tabOrderOut.Name = "tabOrderOut";
            // 
            // gbxOrderOut
            // 
            this.gbxOrderOut.Controls.Add(this.pnlOrderOutContent);
            resources.ApplyResources(this.gbxOrderOut, "gbxOrderOut");
            this.gbxOrderOut.Name = "gbxOrderOut";
            this.gbxOrderOut.TabStop = false;
            // 
            // pnlOrderOutContent
            // 
            resources.ApplyResources(this.pnlOrderOutContent, "pnlOrderOutContent");
            this.pnlOrderOutContent.Controls.Add(this.flowLayoutPanel1, 0, 1);
            this.pnlOrderOutContent.Controls.Add(this.dgvOut, 0, 0);
            this.pnlOrderOutContent.Name = "pnlOrderOutContent";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnAddOrderOut);
            resources.ApplyResources(this.flowLayoutPanel1, "flowLayoutPanel1");
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            // 
            // btnAddOrderOut
            // 
            resources.ApplyResources(this.btnAddOrderOut, "btnAddOrderOut");
            this.btnAddOrderOut.Name = "btnAddOrderOut";
            this.btnAddOrderOut.UseVisualStyleBackColor = true;
            this.btnAddOrderOut.Click += new System.EventHandler(this.btnAddOrderOut_Click);
            // 
            // dgvOut
            // 
            this.dgvOut.AllowUserToAddRows = false;
            this.dgvOut.AllowUserToDeleteRows = false;
            this.dgvOut.AutoGenerateColumns = false;
            this.dgvOut.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOut.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colOrderOutID,
            this.colOrderOutType,
            this.colOrderOutDate,
            this.colOrderOutAmount,
            this.colOrderOutPaymentStatus});
            this.dgvOut.DataSource = this.orderOutBindingSource;
            resources.ApplyResources(this.dgvOut, "dgvOut");
            this.dgvOut.Name = "dgvOut";
            this.dgvOut.ReadOnly = true;
            this.dgvOut.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvOut_CellMouseDoubleClick);
            // 
            // orderOutBindingSource
            // 
            this.orderOutBindingSource.DataMember = "OrderOut";
            this.orderOutBindingSource.DataSource = this.farmManageDataSet;
            // 
            // usersViewBindingSource
            // 
            this.usersViewBindingSource.DataMember = "UsersView";
            this.usersViewBindingSource.DataSource = this.farmManageDataSet;
            // 
            // orderInTableAdapter
            // 
            this.orderInTableAdapter.ClearBeforeFill = true;
            // 
            // orderOutTableAdapter
            // 
            this.orderOutTableAdapter.ClearBeforeFill = true;
            // 
            // customerViewTableAdapter
            // 
            this.customerViewTableAdapter.ClearBeforeFill = true;
            // 
            // usersViewTableAdapter
            // 
            this.usersViewTableAdapter.ClearBeforeFill = true;
            // 
            // colOrderOutID
            // 
            this.colOrderOutID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colOrderOutID.DataPropertyName = "OrderOutID";
            resources.ApplyResources(this.colOrderOutID, "colOrderOutID");
            this.colOrderOutID.Name = "colOrderOutID";
            this.colOrderOutID.ReadOnly = true;
            // 
            // colOrderOutType
            // 
            this.colOrderOutType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colOrderOutType.DataPropertyName = "OrderType";
            this.colOrderOutType.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            resources.ApplyResources(this.colOrderOutType, "colOrderOutType");
            this.colOrderOutType.Name = "colOrderOutType";
            this.colOrderOutType.ReadOnly = true;
            this.colOrderOutType.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colOrderOutType.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // colOrderOutDate
            // 
            this.colOrderOutDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colOrderOutDate.DataPropertyName = "Date";
            dataGridViewCellStyle3.Format = "D";
            dataGridViewCellStyle3.NullValue = null;
            this.colOrderOutDate.DefaultCellStyle = dataGridViewCellStyle3;
            resources.ApplyResources(this.colOrderOutDate, "colOrderOutDate");
            this.colOrderOutDate.Name = "colOrderOutDate";
            this.colOrderOutDate.ReadOnly = true;
            // 
            // colOrderOutAmount
            // 
            this.colOrderOutAmount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colOrderOutAmount.DataPropertyName = "Amount";
            dataGridViewCellStyle4.Format = "C2";
            dataGridViewCellStyle4.NullValue = "0";
            this.colOrderOutAmount.DefaultCellStyle = dataGridViewCellStyle4;
            resources.ApplyResources(this.colOrderOutAmount, "colOrderOutAmount");
            this.colOrderOutAmount.Name = "colOrderOutAmount";
            this.colOrderOutAmount.ReadOnly = true;
            // 
            // colOrderOutPaymentStatus
            // 
            this.colOrderOutPaymentStatus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colOrderOutPaymentStatus.DataPropertyName = "PaymentStatus";
            this.colOrderOutPaymentStatus.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            resources.ApplyResources(this.colOrderOutPaymentStatus, "colOrderOutPaymentStatus");
            this.colOrderOutPaymentStatus.Name = "colOrderOutPaymentStatus";
            this.colOrderOutPaymentStatus.ReadOnly = true;
            this.colOrderOutPaymentStatus.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colOrderOutPaymentStatus.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // colOrderInID
            // 
            this.colOrderInID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colOrderInID.DataPropertyName = "OrderInID";
            resources.ApplyResources(this.colOrderInID, "colOrderInID");
            this.colOrderInID.Name = "colOrderInID";
            this.colOrderInID.ReadOnly = true;
            // 
            // colOrderInType
            // 
            this.colOrderInType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colOrderInType.DataPropertyName = "OrderType";
            this.colOrderInType.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            resources.ApplyResources(this.colOrderInType, "colOrderInType");
            this.colOrderInType.Name = "colOrderInType";
            this.colOrderInType.ReadOnly = true;
            this.colOrderInType.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colOrderInType.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // colOrderInDate
            // 
            this.colOrderInDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colOrderInDate.DataPropertyName = "Date";
            dataGridViewCellStyle1.Format = "D";
            dataGridViewCellStyle1.NullValue = null;
            this.colOrderInDate.DefaultCellStyle = dataGridViewCellStyle1;
            resources.ApplyResources(this.colOrderInDate, "colOrderInDate");
            this.colOrderInDate.Name = "colOrderInDate";
            this.colOrderInDate.ReadOnly = true;
            // 
            // colOrderInAmount
            // 
            this.colOrderInAmount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colOrderInAmount.DataPropertyName = "Amount";
            dataGridViewCellStyle2.Format = "C2";
            dataGridViewCellStyle2.NullValue = "0";
            this.colOrderInAmount.DefaultCellStyle = dataGridViewCellStyle2;
            resources.ApplyResources(this.colOrderInAmount, "colOrderInAmount");
            this.colOrderInAmount.Name = "colOrderInAmount";
            this.colOrderInAmount.ReadOnly = true;
            // 
            // colOrderInPaymentStatus
            // 
            this.colOrderInPaymentStatus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colOrderInPaymentStatus.DataPropertyName = "PaymentStatus";
            this.colOrderInPaymentStatus.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            resources.ApplyResources(this.colOrderInPaymentStatus, "colOrderInPaymentStatus");
            this.colOrderInPaymentStatus.Name = "colOrderInPaymentStatus";
            this.colOrderInPaymentStatus.ReadOnly = true;
            this.colOrderInPaymentStatus.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colOrderInPaymentStatus.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // OrderManageForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlMain);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OrderManageForm";
            this.Load += new System.EventHandler(this.OrderManageForm_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.footerFlowLayoutPanel.ResumeLayout(false);
            this.tcMain.ResumeLayout(false);
            this.tabOrderIn.ResumeLayout(false);
            this.gbxOrderIn.ResumeLayout(false);
            this.pnlOrderInContent.ResumeLayout(false);
            this.cFooterFlowLayoutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvIn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.farmManageDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderInBindingSource)).EndInit();
            this.tabOrderOut.ResumeLayout(false);
            this.gbxOrderOut.ResumeLayout(false);
            this.pnlOrderOutContent.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderOutBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersViewBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel pnlMain;
        private System.Windows.Forms.FlowLayoutPanel footerFlowLayoutPanel;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TabControl tcMain;
        private System.Windows.Forms.TabPage tabOrderIn;
        private System.Windows.Forms.TabPage tabOrderOut;
        private Database.FarmManageDataSet farmManageDataSet;
        private System.Windows.Forms.BindingSource orderInBindingSource;
        private Database.FarmManageDataSetTableAdapters.OrderInTableAdapter orderInTableAdapter;
        private System.Windows.Forms.BindingSource orderOutBindingSource;
        private Database.FarmManageDataSetTableAdapters.OrderOutTableAdapter orderOutTableAdapter;
        private System.Windows.Forms.BindingSource customerViewBindingSource;
        private Database.FarmManageDataSetTableAdapters.CustomerViewTableAdapter customerViewTableAdapter;
        private System.Windows.Forms.BindingSource usersViewBindingSource;
        private Database.FarmManageDataSetTableAdapters.UsersViewTableAdapter usersViewTableAdapter;
        private System.Windows.Forms.GroupBox gbxOrderIn;
        private System.Windows.Forms.TableLayoutPanel pnlOrderInContent;
        private System.Windows.Forms.FlowLayoutPanel cFooterFlowLayoutPanel;
        private System.Windows.Forms.Button btnAddOrderIn;
        private System.Windows.Forms.DataGridView dgvIn;
        private System.Windows.Forms.GroupBox gbxOrderOut;
        private System.Windows.Forms.TableLayoutPanel pnlOrderOutContent;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnAddOrderOut;
        private System.Windows.Forms.DataGridView dgvOut;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOrderOutID;
        private System.Windows.Forms.DataGridViewComboBoxColumn colOrderOutType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOrderOutDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOrderOutAmount;
        private System.Windows.Forms.DataGridViewComboBoxColumn colOrderOutPaymentStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOrderInID;
        private System.Windows.Forms.DataGridViewComboBoxColumn colOrderInType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOrderInDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOrderInAmount;
        private System.Windows.Forms.DataGridViewComboBoxColumn colOrderInPaymentStatus;

    }
}
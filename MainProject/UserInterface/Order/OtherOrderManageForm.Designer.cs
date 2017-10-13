namespace MainProject.UserInterface.Order
{
    partial class OtherOrderManageForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OtherOrderManageForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlMain = new System.Windows.Forms.TableLayoutPanel();
            this.footerFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.tcMain = new System.Windows.Forms.TabControl();
            this.tabBorn = new System.Windows.Forms.TabPage();
            this.gbxBorn = new System.Windows.Forms.GroupBox();
            this.pnlOrderInContent = new System.Windows.Forms.TableLayoutPanel();
            this.cFooterFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAddBorn = new System.Windows.Forms.Button();
            this.dgvBorn = new System.Windows.Forms.DataGridView();
            this.usersViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.farmManageDataSet = new MainProject.Database.FarmManageDataSet();
            this.bornViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabDead = new System.Windows.Forms.TabPage();
            this.gbxDead = new System.Windows.Forms.GroupBox();
            this.pnlOrderOutContent = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAddDead = new System.Windows.Forms.Button();
            this.dgvDead = new System.Windows.Forms.DataGridView();
            this.deadViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bornViewTableAdapter = new MainProject.Database.FarmManageDataSetTableAdapters.BornViewTableAdapter();
            this.deadViewTableAdapter = new MainProject.Database.FarmManageDataSetTableAdapters.DeadViewTableAdapter();
            this.usersViewTableAdapter = new MainProject.Database.FarmManageDataSetTableAdapters.UsersViewTableAdapter();
            this.colBornID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBornBy = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.colBornDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBornDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBornCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDeadID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deadBy = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.colDeadDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDeadDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDeadCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlMain.SuspendLayout();
            this.footerFlowLayoutPanel.SuspendLayout();
            this.tcMain.SuspendLayout();
            this.tabBorn.SuspendLayout();
            this.gbxBorn.SuspendLayout();
            this.pnlOrderInContent.SuspendLayout();
            this.cFooterFlowLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBorn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.farmManageDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bornViewBindingSource)).BeginInit();
            this.tabDead.SuspendLayout();
            this.gbxDead.SuspendLayout();
            this.pnlOrderOutContent.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDead)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deadViewBindingSource)).BeginInit();
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
            this.tcMain.Controls.Add(this.tabBorn);
            this.tcMain.Controls.Add(this.tabDead);
            resources.ApplyResources(this.tcMain, "tcMain");
            this.tcMain.Name = "tcMain";
            this.tcMain.SelectedIndex = 0;
            // 
            // tabBorn
            // 
            this.tabBorn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabBorn.Controls.Add(this.gbxBorn);
            resources.ApplyResources(this.tabBorn, "tabBorn");
            this.tabBorn.Name = "tabBorn";
            // 
            // gbxBorn
            // 
            this.gbxBorn.Controls.Add(this.pnlOrderInContent);
            resources.ApplyResources(this.gbxBorn, "gbxBorn");
            this.gbxBorn.Name = "gbxBorn";
            this.gbxBorn.TabStop = false;
            // 
            // pnlOrderInContent
            // 
            resources.ApplyResources(this.pnlOrderInContent, "pnlOrderInContent");
            this.pnlOrderInContent.Controls.Add(this.cFooterFlowLayoutPanel, 0, 1);
            this.pnlOrderInContent.Controls.Add(this.dgvBorn, 0, 0);
            this.pnlOrderInContent.Name = "pnlOrderInContent";
            // 
            // cFooterFlowLayoutPanel
            // 
            this.cFooterFlowLayoutPanel.Controls.Add(this.btnAddBorn);
            resources.ApplyResources(this.cFooterFlowLayoutPanel, "cFooterFlowLayoutPanel");
            this.cFooterFlowLayoutPanel.Name = "cFooterFlowLayoutPanel";
            // 
            // btnAddBorn
            // 
            resources.ApplyResources(this.btnAddBorn, "btnAddBorn");
            this.btnAddBorn.Name = "btnAddBorn";
            this.btnAddBorn.UseVisualStyleBackColor = true;
            this.btnAddBorn.Click += new System.EventHandler(this.btnAddBorn_Click);
            // 
            // dgvBorn
            // 
            this.dgvBorn.AllowUserToAddRows = false;
            this.dgvBorn.AllowUserToDeleteRows = false;
            this.dgvBorn.AutoGenerateColumns = false;
            this.dgvBorn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBorn.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colBornID,
            this.colBornBy,
            this.colBornDate,
            this.colBornDescription,
            this.colBornCount});
            this.dgvBorn.DataSource = this.bornViewBindingSource;
            resources.ApplyResources(this.dgvBorn, "dgvBorn");
            this.dgvBorn.Name = "dgvBorn";
            this.dgvBorn.ReadOnly = true;
            this.dgvBorn.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvIn_CellMouseDoubleClick);
            // 
            // usersViewBindingSource
            // 
            this.usersViewBindingSource.DataMember = "UsersView";
            this.usersViewBindingSource.DataSource = this.farmManageDataSet;
            // 
            // farmManageDataSet
            // 
            this.farmManageDataSet.DataSetName = "FarmManageDataSet";
            this.farmManageDataSet.Locale = new System.Globalization.CultureInfo("en");
            this.farmManageDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bornViewBindingSource
            // 
            this.bornViewBindingSource.DataMember = "BornView";
            this.bornViewBindingSource.DataSource = this.farmManageDataSet;
            // 
            // tabDead
            // 
            this.tabDead.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabDead.Controls.Add(this.gbxDead);
            resources.ApplyResources(this.tabDead, "tabDead");
            this.tabDead.Name = "tabDead";
            // 
            // gbxDead
            // 
            this.gbxDead.Controls.Add(this.pnlOrderOutContent);
            resources.ApplyResources(this.gbxDead, "gbxDead");
            this.gbxDead.Name = "gbxDead";
            this.gbxDead.TabStop = false;
            // 
            // pnlOrderOutContent
            // 
            resources.ApplyResources(this.pnlOrderOutContent, "pnlOrderOutContent");
            this.pnlOrderOutContent.Controls.Add(this.flowLayoutPanel1, 0, 1);
            this.pnlOrderOutContent.Controls.Add(this.dgvDead, 0, 0);
            this.pnlOrderOutContent.Name = "pnlOrderOutContent";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnAddDead);
            resources.ApplyResources(this.flowLayoutPanel1, "flowLayoutPanel1");
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            // 
            // btnAddDead
            // 
            resources.ApplyResources(this.btnAddDead, "btnAddDead");
            this.btnAddDead.Name = "btnAddDead";
            this.btnAddDead.UseVisualStyleBackColor = true;
            this.btnAddDead.Click += new System.EventHandler(this.btnAddDead_Click);
            // 
            // dgvDead
            // 
            this.dgvDead.AllowUserToAddRows = false;
            this.dgvDead.AllowUserToDeleteRows = false;
            this.dgvDead.AutoGenerateColumns = false;
            this.dgvDead.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDead.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colDeadID,
            this.deadBy,
            this.colDeadDate,
            this.colDeadDescription,
            this.colDeadCount});
            this.dgvDead.DataSource = this.deadViewBindingSource;
            resources.ApplyResources(this.dgvDead, "dgvDead");
            this.dgvDead.Name = "dgvDead";
            this.dgvDead.ReadOnly = true;
            this.dgvDead.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvOut_CellMouseDoubleClick);
            // 
            // deadViewBindingSource
            // 
            this.deadViewBindingSource.DataMember = "DeadView";
            this.deadViewBindingSource.DataSource = this.farmManageDataSet;
            // 
            // bornViewTableAdapter
            // 
            this.bornViewTableAdapter.ClearBeforeFill = true;
            // 
            // deadViewTableAdapter
            // 
            this.deadViewTableAdapter.ClearBeforeFill = true;
            // 
            // usersViewTableAdapter
            // 
            this.usersViewTableAdapter.ClearBeforeFill = true;
            // 
            // colBornID
            // 
            this.colBornID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colBornID.DataPropertyName = "OrderInID";
            resources.ApplyResources(this.colBornID, "colBornID");
            this.colBornID.Name = "colBornID";
            this.colBornID.ReadOnly = true;
            // 
            // colBornBy
            // 
            this.colBornBy.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colBornBy.DataPropertyName = "OrderBy";
            this.colBornBy.DataSource = this.usersViewBindingSource;
            this.colBornBy.DisplayMember = "Name";
            this.colBornBy.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            resources.ApplyResources(this.colBornBy, "colBornBy");
            this.colBornBy.Name = "colBornBy";
            this.colBornBy.ReadOnly = true;
            this.colBornBy.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colBornBy.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colBornBy.ValueMember = "UserID";
            // 
            // colBornDate
            // 
            this.colBornDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colBornDate.DataPropertyName = "Date";
            dataGridViewCellStyle1.Format = "D";
            dataGridViewCellStyle1.NullValue = null;
            this.colBornDate.DefaultCellStyle = dataGridViewCellStyle1;
            resources.ApplyResources(this.colBornDate, "colBornDate");
            this.colBornDate.Name = "colBornDate";
            this.colBornDate.ReadOnly = true;
            // 
            // colBornDescription
            // 
            this.colBornDescription.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colBornDescription.DataPropertyName = "Description";
            resources.ApplyResources(this.colBornDescription, "colBornDescription");
            this.colBornDescription.Name = "colBornDescription";
            this.colBornDescription.ReadOnly = true;
            // 
            // colBornCount
            // 
            this.colBornCount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colBornCount.DataPropertyName = "Count";
            dataGridViewCellStyle2.Format = "N0";
            dataGridViewCellStyle2.NullValue = "0";
            this.colBornCount.DefaultCellStyle = dataGridViewCellStyle2;
            resources.ApplyResources(this.colBornCount, "colBornCount");
            this.colBornCount.Name = "colBornCount";
            this.colBornCount.ReadOnly = true;
            // 
            // colDeadID
            // 
            this.colDeadID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colDeadID.DataPropertyName = "OrderOutID";
            resources.ApplyResources(this.colDeadID, "colDeadID");
            this.colDeadID.Name = "colDeadID";
            this.colDeadID.ReadOnly = true;
            // 
            // deadBy
            // 
            this.deadBy.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.deadBy.DataPropertyName = "OrderBy";
            this.deadBy.DataSource = this.usersViewBindingSource;
            this.deadBy.DisplayMember = "Name";
            this.deadBy.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            resources.ApplyResources(this.deadBy, "deadBy");
            this.deadBy.Name = "deadBy";
            this.deadBy.ReadOnly = true;
            this.deadBy.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.deadBy.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.deadBy.ValueMember = "UserID";
            // 
            // colDeadDate
            // 
            this.colDeadDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colDeadDate.DataPropertyName = "Date";
            dataGridViewCellStyle3.Format = "D";
            dataGridViewCellStyle3.NullValue = null;
            this.colDeadDate.DefaultCellStyle = dataGridViewCellStyle3;
            resources.ApplyResources(this.colDeadDate, "colDeadDate");
            this.colDeadDate.Name = "colDeadDate";
            this.colDeadDate.ReadOnly = true;
            // 
            // colDeadDescription
            // 
            this.colDeadDescription.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colDeadDescription.DataPropertyName = "Description";
            resources.ApplyResources(this.colDeadDescription, "colDeadDescription");
            this.colDeadDescription.Name = "colDeadDescription";
            this.colDeadDescription.ReadOnly = true;
            // 
            // colDeadCount
            // 
            this.colDeadCount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colDeadCount.DataPropertyName = "Count";
            dataGridViewCellStyle4.Format = "N0";
            dataGridViewCellStyle4.NullValue = "0";
            this.colDeadCount.DefaultCellStyle = dataGridViewCellStyle4;
            resources.ApplyResources(this.colDeadCount, "colDeadCount");
            this.colDeadCount.Name = "colDeadCount";
            this.colDeadCount.ReadOnly = true;
            // 
            // OtherOrderManageForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlMain);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OtherOrderManageForm";
            this.Load += new System.EventHandler(this.OtherOrderManageForm_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.footerFlowLayoutPanel.ResumeLayout(false);
            this.tcMain.ResumeLayout(false);
            this.tabBorn.ResumeLayout(false);
            this.gbxBorn.ResumeLayout(false);
            this.pnlOrderInContent.ResumeLayout(false);
            this.cFooterFlowLayoutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBorn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.farmManageDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bornViewBindingSource)).EndInit();
            this.tabDead.ResumeLayout(false);
            this.gbxDead.ResumeLayout(false);
            this.pnlOrderOutContent.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDead)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deadViewBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel pnlMain;
        private System.Windows.Forms.FlowLayoutPanel footerFlowLayoutPanel;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TabControl tcMain;
        private System.Windows.Forms.TabPage tabBorn;
        private System.Windows.Forms.TabPage tabDead;
        private System.Windows.Forms.GroupBox gbxBorn;
        private System.Windows.Forms.TableLayoutPanel pnlOrderInContent;
        private System.Windows.Forms.FlowLayoutPanel cFooterFlowLayoutPanel;
        private System.Windows.Forms.Button btnAddBorn;
        private System.Windows.Forms.DataGridView dgvBorn;
        private System.Windows.Forms.GroupBox gbxDead;
        private System.Windows.Forms.TableLayoutPanel pnlOrderOutContent;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnAddDead;
        private System.Windows.Forms.DataGridView dgvDead;
        private Database.FarmManageDataSet farmManageDataSet;
        private System.Windows.Forms.BindingSource bornViewBindingSource;
        private Database.FarmManageDataSetTableAdapters.BornViewTableAdapter bornViewTableAdapter;
        private System.Windows.Forms.BindingSource deadViewBindingSource;
        private Database.FarmManageDataSetTableAdapters.DeadViewTableAdapter deadViewTableAdapter;
        private System.Windows.Forms.BindingSource usersViewBindingSource;
        private Database.FarmManageDataSetTableAdapters.UsersViewTableAdapter usersViewTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBornID;
        private System.Windows.Forms.DataGridViewComboBoxColumn colBornBy;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBornDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBornDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBornCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDeadID;
        private System.Windows.Forms.DataGridViewComboBoxColumn deadBy;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDeadDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDeadDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDeadCount;

    }
}
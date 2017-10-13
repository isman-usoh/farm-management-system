namespace MainProject.UserInterface.User
{
    partial class UserManageForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserManageForm));
            this.pnlMain = new System.Windows.Forms.TableLayoutPanel();
            this.footerFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlContent = new System.Windows.Forms.TableLayoutPanel();
            this.pnlContentOption = new System.Windows.Forms.FlowLayoutPanel();
            this.btnNew = new System.Windows.Forms.Button();
            this.dgvGrid = new System.Windows.Forms.DataGridView();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.farmManageDataSet = new MainProject.Database.FarmManageDataSet();
            this.usersTableAdapter = new MainProject.Database.FarmManageDataSetTableAdapters.UsersTableAdapter();
            this.colUserID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUsername = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUserFirstname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUserLastname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUserSuperUser = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colUserEnable = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.pnlMain.SuspendLayout();
            this.footerFlowLayoutPanel.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.pnlContentOption.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.farmManageDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.pnlMain.ColumnCount = 1;
            this.pnlMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlMain.Controls.Add(this.footerFlowLayoutPanel, 0, 2);
            this.pnlMain.Controls.Add(this.lblTitle, 0, 0);
            this.pnlMain.Controls.Add(this.pnlContent, 0, 1);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.RowCount = 3;
            this.pnlMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.pnlMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.pnlMain.Size = new System.Drawing.Size(594, 521);
            this.pnlMain.TabIndex = 4;
            // 
            // footerFlowLayoutPanel
            // 
            this.footerFlowLayoutPanel.Controls.Add(this.btnClose);
            this.footerFlowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.footerFlowLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.footerFlowLayoutPanel.Location = new System.Drawing.Point(4, 483);
            this.footerFlowLayoutPanel.Name = "footerFlowLayoutPanel";
            this.footerFlowLayoutPanel.Padding = new System.Windows.Forms.Padding(3);
            this.footerFlowLayoutPanel.Size = new System.Drawing.Size(586, 34);
            this.footerFlowLayoutPanel.TabIndex = 5;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(502, 6);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "ปิด";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.SystemColors.Window;
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblTitle.Location = new System.Drawing.Point(1, 1);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lblTitle.Size = new System.Drawing.Size(592, 60);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "จัดการผู้ใช้งาน";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlContent
            // 
            this.pnlContent.ColumnCount = 1;
            this.pnlContent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlContent.Controls.Add(this.pnlContentOption, 0, 1);
            this.pnlContent.Controls.Add(this.dgvGrid, 0, 0);
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(4, 65);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.RowCount = 2;
            this.pnlContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.pnlContent.Size = new System.Drawing.Size(586, 411);
            this.pnlContent.TabIndex = 6;
            // 
            // pnlContentOption
            // 
            this.pnlContentOption.Controls.Add(this.btnNew);
            this.pnlContentOption.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContentOption.Location = new System.Drawing.Point(3, 380);
            this.pnlContentOption.Name = "pnlContentOption";
            this.pnlContentOption.Size = new System.Drawing.Size(580, 28);
            this.pnlContentOption.TabIndex = 0;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(3, 3);
            this.btnNew.Name = "btnNew";
            this.btnNew.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnNew.Size = new System.Drawing.Size(80, 23);
            this.btnNew.TabIndex = 0;
            this.btnNew.Text = "เพิ่มผู้ใช้ใหม่";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // dgvGrid
            // 
            this.dgvGrid.AllowUserToAddRows = false;
            this.dgvGrid.AllowUserToDeleteRows = false;
            this.dgvGrid.AutoGenerateColumns = false;
            this.dgvGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colUserID,
            this.colUsername,
            this.colUserFirstname,
            this.colUserLastname,
            this.colUserSuperUser,
            this.colUserEnable});
            this.dgvGrid.DataSource = this.usersBindingSource;
            this.dgvGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvGrid.Location = new System.Drawing.Point(3, 3);
            this.dgvGrid.Name = "dgvGrid";
            this.dgvGrid.ReadOnly = true;
            this.dgvGrid.Size = new System.Drawing.Size(580, 371);
            this.dgvGrid.TabIndex = 1;
            this.dgvGrid.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvGrid_CellMouseDoubleClick);
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "users";
            this.usersBindingSource.DataSource = this.farmManageDataSet;
            // 
            // farmManageDataSet
            // 
            this.farmManageDataSet.DataSetName = "FarmManageDataSet";
            this.farmManageDataSet.Locale = new System.Globalization.CultureInfo("en");
            this.farmManageDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // colUserID
            // 
            this.colUserID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colUserID.DataPropertyName = "UserID";
            this.colUserID.HeaderText = "#";
            this.colUserID.MinimumWidth = 50;
            this.colUserID.Name = "colUserID";
            this.colUserID.ReadOnly = true;
            this.colUserID.Width = 50;
            // 
            // colUsername
            // 
            this.colUsername.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colUsername.DataPropertyName = "Username";
            this.colUsername.HeaderText = "ชื่อผู้ใช้";
            this.colUsername.Name = "colUsername";
            this.colUsername.ReadOnly = true;
            // 
            // colUserFirstname
            // 
            this.colUserFirstname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colUserFirstname.DataPropertyName = "Firstname";
            this.colUserFirstname.HeaderText = "ชื่อ";
            this.colUserFirstname.Name = "colUserFirstname";
            this.colUserFirstname.ReadOnly = true;
            // 
            // colUserLastname
            // 
            this.colUserLastname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colUserLastname.DataPropertyName = "Lastname";
            this.colUserLastname.HeaderText = "นามสกุล";
            this.colUserLastname.Name = "colUserLastname";
            this.colUserLastname.ReadOnly = true;
            // 
            // colUserSuperUser
            // 
            this.colUserSuperUser.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colUserSuperUser.DataPropertyName = "SuperUser";
            this.colUserSuperUser.HeaderText = "ผู้ดูแล";
            this.colUserSuperUser.Name = "colUserSuperUser";
            this.colUserSuperUser.ReadOnly = true;
            // 
            // colUserEnable
            // 
            this.colUserEnable.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colUserEnable.DataPropertyName = "Enable";
            this.colUserEnable.HeaderText = "เปิดใช้งาน";
            this.colUserEnable.Name = "colUserEnable";
            this.colUserEnable.ReadOnly = true;
            // 
            // UserManageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 521);
            this.Controls.Add(this.pnlMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UserManageForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "จัดการผู้ใช้งาน";
            this.Load += new System.EventHandler(this.UserManageForm_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.footerFlowLayoutPanel.ResumeLayout(false);
            this.pnlContent.ResumeLayout(false);
            this.pnlContentOption.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.farmManageDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel pnlMain;
        private System.Windows.Forms.FlowLayoutPanel footerFlowLayoutPanel;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TableLayoutPanel pnlContent;
        private System.Windows.Forms.FlowLayoutPanel pnlContentOption;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.DataGridView dgvGrid;
        private Database.FarmManageDataSetTableAdapters.UsersTableAdapter usersTableAdapter;
        private Database.FarmManageDataSet farmManageDataSet;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUserID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUsername;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUserFirstname;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUserLastname;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colUserSuperUser;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colUserEnable;

    }
}
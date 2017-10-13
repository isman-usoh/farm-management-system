namespace MainProject.UserInterface.Setting
{
    partial class DatabaseSettingForm
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
            this.pnlMain = new System.Windows.Forms.TableLayoutPanel();
            this.pnlFooter = new System.Windows.Forms.FlowLayoutPanel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.gbxDatabaseSetting = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pnlContent = new System.Windows.Forms.TableLayoutPanel();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.lblServerName = new System.Windows.Forms.Label();
            this.cbxServerName = new System.Windows.Forms.ComboBox();
            this.gbxLogon = new System.Windows.Forms.GroupBox();
            this.pnlLogonContent = new System.Windows.Forms.TableLayoutPanel();
            this.rdoWinAuth = new System.Windows.Forms.RadioButton();
            this.rdoSQLAuth = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxUsername = new System.Windows.Forms.TextBox();
            this.tbxPassword = new System.Windows.Forms.TextBox();
            this.gbxContentDatabase = new System.Windows.Forms.GroupBox();
            this.pnlConnectContent = new System.Windows.Forms.TableLayoutPanel();
            this.tbxFilePath = new System.Windows.Forms.TextBox();
            this.btnBrowser = new System.Windows.Forms.Button();
            this.btnTest = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pnlMain.SuspendLayout();
            this.pnlFooter.SuspendLayout();
            this.gbxDatabaseSetting.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.gbxLogon.SuspendLayout();
            this.pnlLogonContent.SuspendLayout();
            this.gbxContentDatabase.SuspendLayout();
            this.pnlConnectContent.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.pnlMain.ColumnCount = 1;
            this.pnlMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.pnlMain.Controls.Add(this.pnlFooter, 0, 2);
            this.pnlMain.Controls.Add(this.lblTitle, 0, 0);
            this.pnlMain.Controls.Add(this.gbxDatabaseSetting, 0, 1);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.RowCount = 3;
            this.pnlMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.pnlMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.pnlMain.Size = new System.Drawing.Size(394, 440);
            this.pnlMain.TabIndex = 0;
            // 
            // pnlFooter
            // 
            this.pnlFooter.Controls.Add(this.btnCancel);
            this.pnlFooter.Controls.Add(this.btnSave);
            this.pnlFooter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFooter.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.pnlFooter.Location = new System.Drawing.Point(4, 402);
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.Padding = new System.Windows.Forms.Padding(3);
            this.pnlFooter.Size = new System.Drawing.Size(386, 34);
            this.pnlFooter.TabIndex = 0;
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
            this.lblTitle.Text = "การตั้งค่าฐานข้อมูล";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // gbxDatabaseSetting
            // 
            this.gbxDatabaseSetting.Controls.Add(this.tableLayoutPanel1);
            this.gbxDatabaseSetting.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbxDatabaseSetting.Location = new System.Drawing.Point(4, 65);
            this.gbxDatabaseSetting.Name = "gbxDatabaseSetting";
            this.gbxDatabaseSetting.Size = new System.Drawing.Size(386, 330);
            this.gbxDatabaseSetting.TabIndex = 2;
            this.gbxDatabaseSetting.TabStop = false;
            this.gbxDatabaseSetting.Text = "ตั้งค่าฐานข้อมูล";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.pnlContent, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.gbxLogon, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.gbxContentDatabase, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 160F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(380, 311);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // pnlContent
            // 
            this.pnlContent.ColumnCount = 2;
            this.pnlContent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.pnlContent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.pnlContent.Controls.Add(this.btnRefresh, 1, 1);
            this.pnlContent.Controls.Add(this.lblServerName, 0, 0);
            this.pnlContent.Controls.Add(this.cbxServerName, 0, 1);
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(3, 3);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.RowCount = 2;
            this.pnlContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.pnlContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.pnlContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.pnlContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.pnlContent.Size = new System.Drawing.Size(374, 43);
            this.pnlContent.TabIndex = 0;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRefresh.Location = new System.Drawing.Point(283, 18);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(88, 21);
            this.btnRefresh.TabIndex = 1;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // lblServerName
            // 
            this.lblServerName.AutoSize = true;
            this.lblServerName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblServerName.Location = new System.Drawing.Point(3, 0);
            this.lblServerName.Name = "lblServerName";
            this.lblServerName.Size = new System.Drawing.Size(274, 15);
            this.lblServerName.TabIndex = 2;
            this.lblServerName.Text = "Server Name";
            this.lblServerName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbxServerName
            // 
            this.cbxServerName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbxServerName.FormattingEnabled = true;
            this.cbxServerName.Location = new System.Drawing.Point(3, 18);
            this.cbxServerName.Name = "cbxServerName";
            this.cbxServerName.Size = new System.Drawing.Size(274, 21);
            this.cbxServerName.TabIndex = 3;
            this.cbxServerName.DropDown += new System.EventHandler(this.cbxServerName_DropDown);
            this.cbxServerName.SelectedIndexChanged += new System.EventHandler(this.cbxServerName_SelectedIndexChanged);
            this.cbxServerName.TextChanged += new System.EventHandler(this.cbxServerName_TextChanged);
            // 
            // gbxLogon
            // 
            this.gbxLogon.Controls.Add(this.pnlLogonContent);
            this.gbxLogon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbxLogon.Location = new System.Drawing.Point(3, 52);
            this.gbxLogon.Name = "gbxLogon";
            this.gbxLogon.Size = new System.Drawing.Size(374, 154);
            this.gbxLogon.TabIndex = 1;
            this.gbxLogon.TabStop = false;
            this.gbxLogon.Text = "Log on to the server";
            // 
            // pnlLogonContent
            // 
            this.pnlLogonContent.ColumnCount = 5;
            this.pnlLogonContent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.pnlLogonContent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.pnlLogonContent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.pnlLogonContent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.pnlLogonContent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 14F));
            this.pnlLogonContent.Controls.Add(this.rdoWinAuth, 1, 1);
            this.pnlLogonContent.Controls.Add(this.rdoSQLAuth, 1, 3);
            this.pnlLogonContent.Controls.Add(this.label1, 2, 5);
            this.pnlLogonContent.Controls.Add(this.label2, 2, 7);
            this.pnlLogonContent.Controls.Add(this.tbxUsername, 3, 5);
            this.pnlLogonContent.Controls.Add(this.tbxPassword, 3, 7);
            this.pnlLogonContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlLogonContent.Location = new System.Drawing.Point(3, 16);
            this.pnlLogonContent.Name = "pnlLogonContent";
            this.pnlLogonContent.RowCount = 10;
            this.pnlLogonContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.pnlLogonContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.pnlLogonContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 3F));
            this.pnlLogonContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.pnlLogonContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 3F));
            this.pnlLogonContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.pnlLogonContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 3F));
            this.pnlLogonContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.pnlLogonContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 3F));
            this.pnlLogonContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlLogonContent.Size = new System.Drawing.Size(368, 135);
            this.pnlLogonContent.TabIndex = 0;
            // 
            // rdoWinAuth
            // 
            this.rdoWinAuth.AutoSize = true;
            this.rdoWinAuth.Checked = true;
            this.pnlLogonContent.SetColumnSpan(this.rdoWinAuth, 3);
            this.rdoWinAuth.Location = new System.Drawing.Point(13, 13);
            this.rdoWinAuth.Name = "rdoWinAuth";
            this.rdoWinAuth.Size = new System.Drawing.Size(162, 17);
            this.rdoWinAuth.TabIndex = 0;
            this.rdoWinAuth.TabStop = true;
            this.rdoWinAuth.Text = "Use Windows Authentication";
            this.rdoWinAuth.UseVisualStyleBackColor = true;
            this.rdoWinAuth.CheckedChanged += new System.EventHandler(this.rdoWinAuth_CheckedChanged);
            // 
            // rdoSQLAuth
            // 
            this.rdoSQLAuth.AutoSize = true;
            this.pnlLogonContent.SetColumnSpan(this.rdoSQLAuth, 3);
            this.rdoSQLAuth.Location = new System.Drawing.Point(13, 41);
            this.rdoSQLAuth.Name = "rdoSQLAuth";
            this.rdoSQLAuth.Size = new System.Drawing.Size(173, 17);
            this.rdoSQLAuth.TabIndex = 1;
            this.rdoSQLAuth.TabStop = true;
            this.rdoSQLAuth.Text = "Use SQL Server Authentication";
            this.rdoSQLAuth.UseVisualStyleBackColor = true;
            this.rdoSQLAuth.CheckedChanged += new System.EventHandler(this.rdoWinAuth_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(33, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Username :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(33, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbxUsername
            // 
            this.tbxUsername.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxUsername.Location = new System.Drawing.Point(114, 69);
            this.tbxUsername.Name = "tbxUsername";
            this.tbxUsername.Size = new System.Drawing.Size(237, 20);
            this.tbxUsername.TabIndex = 4;
            // 
            // tbxPassword
            // 
            this.tbxPassword.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxPassword.Location = new System.Drawing.Point(114, 97);
            this.tbxPassword.Name = "tbxPassword";
            this.tbxPassword.Size = new System.Drawing.Size(237, 20);
            this.tbxPassword.TabIndex = 5;
            this.tbxPassword.UseSystemPasswordChar = true;
            // 
            // gbxContentDatabase
            // 
            this.gbxContentDatabase.Controls.Add(this.pnlConnectContent);
            this.gbxContentDatabase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbxContentDatabase.Location = new System.Drawing.Point(3, 212);
            this.gbxContentDatabase.Name = "gbxContentDatabase";
            this.gbxContentDatabase.Size = new System.Drawing.Size(374, 96);
            this.gbxContentDatabase.TabIndex = 2;
            this.gbxContentDatabase.TabStop = false;
            this.gbxContentDatabase.Text = "Connect to databse";
            // 
            // pnlConnectContent
            // 
            this.pnlConnectContent.ColumnCount = 6;
            this.pnlConnectContent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.pnlConnectContent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.pnlConnectContent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.pnlConnectContent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.pnlConnectContent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.pnlConnectContent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.pnlConnectContent.Controls.Add(this.tbxFilePath, 2, 1);
            this.pnlConnectContent.Controls.Add(this.btnBrowser, 4, 1);
            this.pnlConnectContent.Controls.Add(this.btnTest, 1, 3);
            this.pnlConnectContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlConnectContent.Location = new System.Drawing.Point(3, 16);
            this.pnlConnectContent.Name = "pnlConnectContent";
            this.pnlConnectContent.RowCount = 5;
            this.pnlConnectContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.pnlConnectContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.pnlConnectContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 3F));
            this.pnlConnectContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.pnlConnectContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlConnectContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.pnlConnectContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.pnlConnectContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.pnlConnectContent.Size = new System.Drawing.Size(368, 77);
            this.pnlConnectContent.TabIndex = 1;
            // 
            // tbxFilePath
            // 
            this.pnlConnectContent.SetColumnSpan(this.tbxFilePath, 2);
            this.tbxFilePath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxFilePath.Location = new System.Drawing.Point(33, 13);
            this.tbxFilePath.Name = "tbxFilePath";
            this.tbxFilePath.Size = new System.Drawing.Size(240, 20);
            this.tbxFilePath.TabIndex = 2;
            // 
            // btnBrowser
            // 
            this.btnBrowser.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBrowser.Location = new System.Drawing.Point(279, 13);
            this.btnBrowser.Name = "btnBrowser";
            this.btnBrowser.Size = new System.Drawing.Size(76, 20);
            this.btnBrowser.TabIndex = 4;
            this.btnBrowser.Text = "Browse..";
            this.btnBrowser.UseVisualStyleBackColor = true;
            this.btnBrowser.Click += new System.EventHandler(this.btnBrowser_Click);
            // 
            // btnTest
            // 
            this.pnlConnectContent.SetColumnSpan(this.btnTest, 4);
            this.btnTest.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTest.Location = new System.Drawing.Point(13, 42);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(342, 23);
            this.btnTest.TabIndex = 5;
            this.btnTest.Text = "Test Conntecting";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // DatabaseSettingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 440);
            this.Controls.Add(this.pnlMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DatabaseSettingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "การตั้งค่าฐานข้อมูล";
            this.Load += new System.EventHandler(this.DatabaseSettingForm_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.pnlFooter.ResumeLayout(false);
            this.gbxDatabaseSetting.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.pnlContent.ResumeLayout(false);
            this.pnlContent.PerformLayout();
            this.gbxLogon.ResumeLayout(false);
            this.pnlLogonContent.ResumeLayout(false);
            this.pnlLogonContent.PerformLayout();
            this.gbxContentDatabase.ResumeLayout(false);
            this.pnlConnectContent.ResumeLayout(false);
            this.pnlConnectContent.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel pnlMain;
        private System.Windows.Forms.FlowLayoutPanel pnlFooter;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox gbxDatabaseSetting;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel pnlContent;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label lblServerName;
        private System.Windows.Forms.ComboBox cbxServerName;
        private System.Windows.Forms.GroupBox gbxLogon;
        private System.Windows.Forms.TableLayoutPanel pnlLogonContent;
        private System.Windows.Forms.RadioButton rdoWinAuth;
        private System.Windows.Forms.RadioButton rdoSQLAuth;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxUsername;
        private System.Windows.Forms.TextBox tbxPassword;
        private System.Windows.Forms.GroupBox gbxContentDatabase;
        private System.Windows.Forms.TableLayoutPanel pnlConnectContent;
        private System.Windows.Forms.TextBox tbxFilePath;
        private System.Windows.Forms.Button btnBrowser;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}
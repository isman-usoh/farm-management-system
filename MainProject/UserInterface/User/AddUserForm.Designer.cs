namespace MainProject.UserInterface.User
{
    partial class AddUserForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddUserForm));
            this.pnlMain = new System.Windows.Forms.TableLayoutPanel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.footerPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.pnlContent = new System.Windows.Forms.TableLayoutPanel();
            this.tbxUsername = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblConfirmPassword = new System.Windows.Forms.Label();
            this.tbxPassword = new System.Windows.Forms.TextBox();
            this.tbxConfirmPassword = new System.Windows.Forms.TextBox();
            this.chkSuperUser = new System.Windows.Forms.CheckBox();
            this.tbxLastname = new System.Windows.Forms.TextBox();
            this.tbxFirstname = new System.Windows.Forms.TextBox();
            this.lblLastname = new System.Windows.Forms.Label();
            this.lblPrename = new System.Windows.Forms.Label();
            this.lblFisrtname = new System.Windows.Forms.Label();
            this.cbxPrename = new System.Windows.Forms.ComboBox();
            this.lblTel = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.tbxTel = new System.Windows.Forms.TextBox();
            this.tbxEmail = new System.Windows.Forms.TextBox();
            this.chkEnable = new System.Windows.Forms.CheckBox();
            this.farmManageDataSet = new MainProject.Database.FarmManageDataSet();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usersTableAdapter = new MainProject.Database.FarmManageDataSetTableAdapters.UsersTableAdapter();
            this.pnlMain.SuspendLayout();
            this.footerPanel.SuspendLayout();
            this.pnlContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.farmManageDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.pnlMain.ColumnCount = 1;
            this.pnlMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.pnlMain.Controls.Add(this.lblTitle, 0, 0);
            this.pnlMain.Controls.Add(this.footerPanel, 0, 2);
            this.pnlMain.Controls.Add(this.pnlContent, 0, 1);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.RowCount = 3;
            this.pnlMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.pnlMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.pnlMain.Size = new System.Drawing.Size(444, 421);
            this.pnlMain.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.White;
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblTitle.Location = new System.Drawing.Point(1, 1);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lblTitle.Size = new System.Drawing.Size(442, 60);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "เพิ่มผู้ใช้ใหม่";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // footerPanel
            // 
            this.footerPanel.Controls.Add(this.btnCancel);
            this.footerPanel.Controls.Add(this.btnSave);
            this.footerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.footerPanel.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.footerPanel.Location = new System.Drawing.Point(4, 383);
            this.footerPanel.Name = "footerPanel";
            this.footerPanel.Padding = new System.Windows.Forms.Padding(3);
            this.footerPanel.Size = new System.Drawing.Size(436, 34);
            this.footerPanel.TabIndex = 1;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(352, 6);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "ยกเลิก";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(271, 6);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "บันทึก";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pnlContent
            // 
            this.pnlContent.ColumnCount = 4;
            this.pnlContent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.pnlContent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.pnlContent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55F));
            this.pnlContent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.pnlContent.Controls.Add(this.tbxUsername, 2, 1);
            this.pnlContent.Controls.Add(this.lblUsername, 1, 1);
            this.pnlContent.Controls.Add(this.lblPassword, 1, 3);
            this.pnlContent.Controls.Add(this.lblConfirmPassword, 1, 5);
            this.pnlContent.Controls.Add(this.tbxPassword, 2, 3);
            this.pnlContent.Controls.Add(this.tbxConfirmPassword, 2, 5);
            this.pnlContent.Controls.Add(this.chkSuperUser, 2, 17);
            this.pnlContent.Controls.Add(this.tbxLastname, 2, 11);
            this.pnlContent.Controls.Add(this.tbxFirstname, 2, 9);
            this.pnlContent.Controls.Add(this.lblLastname, 1, 11);
            this.pnlContent.Controls.Add(this.lblPrename, 1, 7);
            this.pnlContent.Controls.Add(this.lblFisrtname, 1, 9);
            this.pnlContent.Controls.Add(this.cbxPrename, 2, 7);
            this.pnlContent.Controls.Add(this.lblTel, 1, 13);
            this.pnlContent.Controls.Add(this.lblEmail, 1, 15);
            this.pnlContent.Controls.Add(this.tbxTel, 2, 13);
            this.pnlContent.Controls.Add(this.tbxEmail, 2, 15);
            this.pnlContent.Controls.Add(this.chkEnable, 2, 19);
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(4, 65);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.RowCount = 21;
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
            this.pnlContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 3F));
            this.pnlContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.pnlContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 3F));
            this.pnlContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.pnlContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 3F));
            this.pnlContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.pnlContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 3F));
            this.pnlContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.pnlContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.pnlContent.Size = new System.Drawing.Size(436, 311);
            this.pnlContent.TabIndex = 0;
            // 
            // tbxUsername
            // 
            this.tbxUsername.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxUsername.Location = new System.Drawing.Point(155, 20);
            this.tbxUsername.MaxLength = 16;
            this.tbxUsername.Name = "tbxUsername";
            this.tbxUsername.Size = new System.Drawing.Size(233, 20);
            this.tbxUsername.TabIndex = 0;
            this.tbxUsername.Leave += new System.EventHandler(this.tbxUsername_Leave);
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblUsername.Location = new System.Drawing.Point(46, 17);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(103, 25);
            this.lblUsername.TabIndex = 1;
            this.lblUsername.Text = "ชื่อผู้ใช้*";
            this.lblUsername.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPassword.Location = new System.Drawing.Point(46, 45);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(103, 25);
            this.lblPassword.TabIndex = 2;
            this.lblPassword.Text = "รหัสผ่าน*";
            this.lblPassword.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblConfirmPassword
            // 
            this.lblConfirmPassword.AutoSize = true;
            this.lblConfirmPassword.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblConfirmPassword.Location = new System.Drawing.Point(46, 73);
            this.lblConfirmPassword.Name = "lblConfirmPassword";
            this.lblConfirmPassword.Size = new System.Drawing.Size(103, 25);
            this.lblConfirmPassword.TabIndex = 3;
            this.lblConfirmPassword.Text = "ยืนยันรหัสผ่าน*";
            this.lblConfirmPassword.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbxPassword
            // 
            this.tbxPassword.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxPassword.Location = new System.Drawing.Point(155, 48);
            this.tbxPassword.MaxLength = 16;
            this.tbxPassword.Name = "tbxPassword";
            this.tbxPassword.PasswordChar = '*';
            this.tbxPassword.Size = new System.Drawing.Size(233, 20);
            this.tbxPassword.TabIndex = 1;
            this.tbxPassword.UseSystemPasswordChar = true;
            // 
            // tbxConfirmPassword
            // 
            this.tbxConfirmPassword.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxConfirmPassword.Location = new System.Drawing.Point(155, 76);
            this.tbxConfirmPassword.MaxLength = 16;
            this.tbxConfirmPassword.Name = "tbxConfirmPassword";
            this.tbxConfirmPassword.PasswordChar = '*';
            this.tbxConfirmPassword.Size = new System.Drawing.Size(233, 20);
            this.tbxConfirmPassword.TabIndex = 2;
            this.tbxConfirmPassword.UseSystemPasswordChar = true;
            // 
            // chkSuperUser
            // 
            this.chkSuperUser.AutoSize = true;
            this.chkSuperUser.Location = new System.Drawing.Point(155, 244);
            this.chkSuperUser.Name = "chkSuperUser";
            this.chkSuperUser.Size = new System.Drawing.Size(79, 17);
            this.chkSuperUser.TabIndex = 8;
            this.chkSuperUser.Text = "ผู้ดูแลระบบ";
            this.chkSuperUser.UseVisualStyleBackColor = true;
            // 
            // tbxLastname
            // 
            this.tbxLastname.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxLastname.Location = new System.Drawing.Point(155, 160);
            this.tbxLastname.MaxLength = 32;
            this.tbxLastname.Name = "tbxLastname";
            this.tbxLastname.Size = new System.Drawing.Size(233, 20);
            this.tbxLastname.TabIndex = 5;
            this.tbxLastname.TextChanged += new System.EventHandler(this.tbxLastname_TextChanged);
            this.tbxLastname.Validating += new System.ComponentModel.CancelEventHandler(this.tbxLastname_Validating);
            // 
            // tbxFirstname
            // 
            this.tbxFirstname.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxFirstname.Location = new System.Drawing.Point(155, 132);
            this.tbxFirstname.MaxLength = 32;
            this.tbxFirstname.Name = "tbxFirstname";
            this.tbxFirstname.Size = new System.Drawing.Size(233, 20);
            this.tbxFirstname.TabIndex = 4;
            this.tbxFirstname.Validating += new System.ComponentModel.CancelEventHandler(this.tbxFirstname_Validating);
            // 
            // lblLastname
            // 
            this.lblLastname.AutoSize = true;
            this.lblLastname.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblLastname.Location = new System.Drawing.Point(46, 157);
            this.lblLastname.Name = "lblLastname";
            this.lblLastname.Size = new System.Drawing.Size(103, 25);
            this.lblLastname.TabIndex = 6;
            this.lblLastname.Text = "นามสกุล*";
            this.lblLastname.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPrename
            // 
            this.lblPrename.AutoSize = true;
            this.lblPrename.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPrename.Location = new System.Drawing.Point(46, 101);
            this.lblPrename.Name = "lblPrename";
            this.lblPrename.Size = new System.Drawing.Size(103, 25);
            this.lblPrename.TabIndex = 7;
            this.lblPrename.Text = "คำนำหน้า*";
            this.lblPrename.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblFisrtname
            // 
            this.lblFisrtname.AutoSize = true;
            this.lblFisrtname.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblFisrtname.Location = new System.Drawing.Point(46, 129);
            this.lblFisrtname.Name = "lblFisrtname";
            this.lblFisrtname.Size = new System.Drawing.Size(103, 25);
            this.lblFisrtname.TabIndex = 5;
            this.lblFisrtname.Text = "ชื่อ*";
            this.lblFisrtname.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbxPrename
            // 
            this.cbxPrename.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbxPrename.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxPrename.FormattingEnabled = true;
            this.cbxPrename.Items.AddRange(new object[] {
            "ชาย",
            "หญิง"});
            this.cbxPrename.Location = new System.Drawing.Point(155, 104);
            this.cbxPrename.Name = "cbxPrename";
            this.cbxPrename.Size = new System.Drawing.Size(233, 21);
            this.cbxPrename.TabIndex = 3;
            this.cbxPrename.Validating += new System.ComponentModel.CancelEventHandler(this.cbxPrename_Validating);
            // 
            // lblTel
            // 
            this.lblTel.AutoSize = true;
            this.lblTel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTel.Location = new System.Drawing.Point(46, 185);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(103, 25);
            this.lblTel.TabIndex = 14;
            this.lblTel.Text = "เบอร์โทร";
            this.lblTel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblEmail.Location = new System.Drawing.Point(46, 213);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(103, 25);
            this.lblEmail.TabIndex = 15;
            this.lblEmail.Text = "อีเมล์";
            this.lblEmail.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbxTel
            // 
            this.tbxTel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxTel.Location = new System.Drawing.Point(155, 188);
            this.tbxTel.MaxLength = 16;
            this.tbxTel.Name = "tbxTel";
            this.tbxTel.Size = new System.Drawing.Size(233, 20);
            this.tbxTel.TabIndex = 6;
            // 
            // tbxEmail
            // 
            this.tbxEmail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxEmail.Location = new System.Drawing.Point(155, 216);
            this.tbxEmail.MaxLength = 64;
            this.tbxEmail.Name = "tbxEmail";
            this.tbxEmail.Size = new System.Drawing.Size(233, 20);
            this.tbxEmail.TabIndex = 7;
            // 
            // chkEnable
            // 
            this.chkEnable.AutoSize = true;
            this.chkEnable.Location = new System.Drawing.Point(155, 272);
            this.chkEnable.Name = "chkEnable";
            this.chkEnable.Size = new System.Drawing.Size(76, 17);
            this.chkEnable.TabIndex = 9;
            this.chkEnable.Text = "เปิดใช้งาน";
            this.chkEnable.UseVisualStyleBackColor = true;
            // 
            // farmManageDataSet
            // 
            this.farmManageDataSet.DataSetName = "FarmManageDataSet";
            this.farmManageDataSet.Locale = new System.Globalization.CultureInfo("en");
            this.farmManageDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "Users";
            this.usersBindingSource.DataSource = this.farmManageDataSet;
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // AddUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 421);
            this.Controls.Add(this.pnlMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddUserForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "เพิ่มผู้ใช้ใหม่";
            this.Load += new System.EventHandler(this.AddUserForm_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.footerPanel.ResumeLayout(false);
            this.pnlContent.ResumeLayout(false);
            this.pnlContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.farmManageDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel pnlMain;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.FlowLayoutPanel footerPanel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TableLayoutPanel pnlContent;
        private System.Windows.Forms.TextBox tbxUsername;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblConfirmPassword;
        private System.Windows.Forms.Label lblFisrtname;
        private System.Windows.Forms.Label lblLastname;
        private System.Windows.Forms.Label lblPrename;
        private System.Windows.Forms.TextBox tbxPassword;
        private System.Windows.Forms.TextBox tbxConfirmPassword;
        private System.Windows.Forms.TextBox tbxFirstname;
        private System.Windows.Forms.TextBox tbxLastname;
        private System.Windows.Forms.ComboBox cbxPrename;
        private System.Windows.Forms.CheckBox chkSuperUser;
        private System.Windows.Forms.Label lblTel;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox tbxTel;
        private System.Windows.Forms.TextBox tbxEmail;
        private System.Windows.Forms.CheckBox chkEnable;
        private Database.FarmManageDataSet farmManageDataSet;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private Database.FarmManageDataSetTableAdapters.UsersTableAdapter usersTableAdapter;
    }
}
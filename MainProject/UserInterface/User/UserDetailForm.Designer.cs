namespace MainProject.UserInterface.User
{
    partial class UserDetailForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserDetailForm));
            this.pnlMain = new System.Windows.Forms.TableLayoutPanel();
            this.footerPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.farmManageDataSet = new MainProject.Database.FarmManageDataSet();
            this.usersTableAdapter = new MainProject.Database.FarmManageDataSetTableAdapters.UsersTableAdapter();
            this.tabRecord = new System.Windows.Forms.TabPage();
            this.userLogUC = new MainProject.UserInterface.Control.UserLogUC();
            this.tabDetail = new System.Windows.Forms.TabPage();
            this.gxbDetail = new System.Windows.Forms.GroupBox();
            this.pnlContent = new System.Windows.Forms.TableLayoutPanel();
            this.tbxEmail = new System.Windows.Forms.TextBox();
            this.tbxTel = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.chkEnable = new System.Windows.Forms.CheckBox();
            this.chkSuperUser = new System.Windows.Forms.CheckBox();
            this.lblPrefix = new System.Windows.Forms.Label();
            this.cbxPreneme = new System.Windows.Forms.ComboBox();
            this.tbxFirstname = new System.Windows.Forms.TextBox();
            this.lblFisrtname = new System.Windows.Forms.Label();
            this.lblLastname = new System.Windows.Forms.Label();
            this.tbxLastname = new System.Windows.Forms.TextBox();
            this.btnChangePassword = new System.Windows.Forms.Button();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.tbxUsername = new System.Windows.Forms.TextBox();
            this.tcMain = new System.Windows.Forms.TabControl();
            this.pnlMain.SuspendLayout();
            this.footerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.farmManageDataSet)).BeginInit();
            this.tabRecord.SuspendLayout();
            this.tabDetail.SuspendLayout();
            this.gxbDetail.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.tcMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.pnlMain.ColumnCount = 1;
            this.pnlMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.pnlMain.Controls.Add(this.footerPanel, 0, 2);
            this.pnlMain.Controls.Add(this.label1, 0, 0);
            this.pnlMain.Controls.Add(this.tcMain, 0, 1);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.RowCount = 3;
            this.pnlMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.pnlMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.pnlMain.Size = new System.Drawing.Size(494, 421);
            this.pnlMain.TabIndex = 0;
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
            this.footerPanel.Size = new System.Drawing.Size(486, 34);
            this.footerPanel.TabIndex = 1;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(402, 6);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "ยกเลิก";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(321, 6);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "บันทึก";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label1.Location = new System.Drawing.Point(4, 1);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.label1.Size = new System.Drawing.Size(486, 60);
            this.label1.TabIndex = 0;
            this.label1.Text = "รายละเอียดผู้ใช้งาน";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "Users";
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
            // tabRecord
            // 
            this.tabRecord.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabRecord.Controls.Add(this.userLogUC);
            this.tabRecord.Location = new System.Drawing.Point(4, 22);
            this.tabRecord.Name = "tabRecord";
            this.tabRecord.Padding = new System.Windows.Forms.Padding(3);
            this.tabRecord.Size = new System.Drawing.Size(478, 285);
            this.tabRecord.TabIndex = 1;
            this.tabRecord.Text = "การบันทึก";
            // 
            // userLogUC
            // 
            this.userLogUC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userLogUC.Location = new System.Drawing.Point(3, 3);
            this.userLogUC.Name = "userLogUC";
            this.userLogUC.Size = new System.Drawing.Size(472, 279);
            this.userLogUC.TabIndex = 0;
            // 
            // tabDetail
            // 
            this.tabDetail.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabDetail.Controls.Add(this.gxbDetail);
            this.tabDetail.Location = new System.Drawing.Point(4, 22);
            this.tabDetail.Name = "tabDetail";
            this.tabDetail.Padding = new System.Windows.Forms.Padding(3);
            this.tabDetail.Size = new System.Drawing.Size(478, 285);
            this.tabDetail.TabIndex = 0;
            this.tabDetail.Text = "รายละเอียด";
            // 
            // gxbDetail
            // 
            this.gxbDetail.Controls.Add(this.pnlContent);
            this.gxbDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gxbDetail.Location = new System.Drawing.Point(3, 3);
            this.gxbDetail.Name = "gxbDetail";
            this.gxbDetail.Size = new System.Drawing.Size(472, 279);
            this.gxbDetail.TabIndex = 0;
            this.gxbDetail.TabStop = false;
            this.gxbDetail.Text = "รายละเอียด";
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
            this.pnlContent.Controls.Add(this.btnChangePassword, 2, 3);
            this.pnlContent.Controls.Add(this.tbxLastname, 2, 9);
            this.pnlContent.Controls.Add(this.lblLastname, 1, 9);
            this.pnlContent.Controls.Add(this.lblFisrtname, 1, 7);
            this.pnlContent.Controls.Add(this.tbxFirstname, 2, 7);
            this.pnlContent.Controls.Add(this.cbxPreneme, 2, 5);
            this.pnlContent.Controls.Add(this.lblPrefix, 1, 5);
            this.pnlContent.Controls.Add(this.chkSuperUser, 2, 15);
            this.pnlContent.Controls.Add(this.chkEnable, 2, 17);
            this.pnlContent.Controls.Add(this.label2, 1, 11);
            this.pnlContent.Controls.Add(this.label3, 1, 13);
            this.pnlContent.Controls.Add(this.tbxTel, 2, 11);
            this.pnlContent.Controls.Add(this.tbxEmail, 2, 13);
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(3, 16);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.RowCount = 19;
            this.pnlContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
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
            this.pnlContent.Size = new System.Drawing.Size(466, 260);
            this.pnlContent.TabIndex = 4;
            // 
            // tbxEmail
            // 
            this.tbxEmail.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource, "Email", true));
            this.tbxEmail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxEmail.Location = new System.Drawing.Point(165, 181);
            this.tbxEmail.MaxLength = 64;
            this.tbxEmail.Name = "tbxEmail";
            this.tbxEmail.Size = new System.Drawing.Size(250, 20);
            this.tbxEmail.TabIndex = 6;
            // 
            // tbxTel
            // 
            this.tbxTel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource, "Tel", true));
            this.tbxTel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxTel.Location = new System.Drawing.Point(165, 153);
            this.tbxTel.MaxLength = 16;
            this.tbxTel.Name = "tbxTel";
            this.tbxTel.Size = new System.Drawing.Size(250, 20);
            this.tbxTel.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(49, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 25);
            this.label3.TabIndex = 16;
            this.label3.Text = "อีเมล์";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(49, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 25);
            this.label2.TabIndex = 15;
            this.label2.Text = "เบอร์โทร";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // chkEnable
            // 
            this.chkEnable.AutoSize = true;
            this.chkEnable.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.usersBindingSource, "Enable", true));
            this.chkEnable.Location = new System.Drawing.Point(165, 237);
            this.chkEnable.Name = "chkEnable";
            this.chkEnable.Size = new System.Drawing.Size(76, 17);
            this.chkEnable.TabIndex = 8;
            this.chkEnable.Text = "เปิดใช้งาน";
            this.chkEnable.UseVisualStyleBackColor = true;
            // 
            // chkSuperUser
            // 
            this.chkSuperUser.AutoSize = true;
            this.chkSuperUser.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.usersBindingSource, "SuperUser", true));
            this.chkSuperUser.Location = new System.Drawing.Point(165, 209);
            this.chkSuperUser.Name = "chkSuperUser";
            this.chkSuperUser.Size = new System.Drawing.Size(79, 17);
            this.chkSuperUser.TabIndex = 7;
            this.chkSuperUser.Text = "ผู้ดูแลระบบ";
            this.chkSuperUser.UseVisualStyleBackColor = true;
            // 
            // lblPrefix
            // 
            this.lblPrefix.AutoSize = true;
            this.lblPrefix.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPrefix.Location = new System.Drawing.Point(49, 66);
            this.lblPrefix.Name = "lblPrefix";
            this.lblPrefix.Size = new System.Drawing.Size(110, 25);
            this.lblPrefix.TabIndex = 7;
            this.lblPrefix.Text = "คำนำหน้า";
            this.lblPrefix.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbxPreneme
            // 
            this.cbxPreneme.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.usersBindingSource, "Prename", true));
            this.cbxPreneme.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbxPreneme.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxPreneme.FormattingEnabled = true;
            this.cbxPreneme.Items.AddRange(new object[] {
            "นางสาว",
            "นาง",
            "นาย"});
            this.cbxPreneme.Location = new System.Drawing.Point(165, 69);
            this.cbxPreneme.Name = "cbxPreneme";
            this.cbxPreneme.Size = new System.Drawing.Size(250, 21);
            this.cbxPreneme.TabIndex = 2;
            // 
            // tbxFirstname
            // 
            this.tbxFirstname.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource, "Firstname", true));
            this.tbxFirstname.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxFirstname.Location = new System.Drawing.Point(165, 97);
            this.tbxFirstname.MaxLength = 32;
            this.tbxFirstname.Name = "tbxFirstname";
            this.tbxFirstname.Size = new System.Drawing.Size(250, 20);
            this.tbxFirstname.TabIndex = 3;
            // 
            // lblFisrtname
            // 
            this.lblFisrtname.AutoSize = true;
            this.lblFisrtname.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblFisrtname.Location = new System.Drawing.Point(49, 94);
            this.lblFisrtname.Name = "lblFisrtname";
            this.lblFisrtname.Size = new System.Drawing.Size(110, 25);
            this.lblFisrtname.TabIndex = 5;
            this.lblFisrtname.Text = "ชื่อ";
            this.lblFisrtname.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblLastname
            // 
            this.lblLastname.AutoSize = true;
            this.lblLastname.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblLastname.Location = new System.Drawing.Point(49, 122);
            this.lblLastname.Name = "lblLastname";
            this.lblLastname.Size = new System.Drawing.Size(110, 25);
            this.lblLastname.TabIndex = 6;
            this.lblLastname.Text = "นามสกุล";
            this.lblLastname.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbxLastname
            // 
            this.tbxLastname.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource, "Lastname", true));
            this.tbxLastname.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxLastname.Location = new System.Drawing.Point(165, 125);
            this.tbxLastname.MaxLength = 32;
            this.tbxLastname.Name = "tbxLastname";
            this.tbxLastname.Size = new System.Drawing.Size(250, 20);
            this.tbxLastname.TabIndex = 4;
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnChangePassword.Location = new System.Drawing.Point(164, 40);
            this.btnChangePassword.Margin = new System.Windows.Forms.Padding(2);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Size = new System.Drawing.Size(252, 21);
            this.btnChangePassword.TabIndex = 1;
            this.btnChangePassword.Text = "เปลี่ยนรหัสผ่าน";
            this.btnChangePassword.UseVisualStyleBackColor = true;
            this.btnChangePassword.Click += new System.EventHandler(this.btnChangePassword_Click);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPassword.Location = new System.Drawing.Point(49, 38);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(110, 25);
            this.lblPassword.TabIndex = 2;
            this.lblPassword.Text = "รหัสผ่าน";
            this.lblPassword.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblUsername.Location = new System.Drawing.Point(49, 10);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(110, 25);
            this.lblUsername.TabIndex = 1;
            this.lblUsername.Text = "ชื่อผู้ใช้";
            this.lblUsername.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbxUsername
            // 
            this.tbxUsername.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource, "Username", true));
            this.tbxUsername.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxUsername.Location = new System.Drawing.Point(165, 13);
            this.tbxUsername.Name = "tbxUsername";
            this.tbxUsername.ReadOnly = true;
            this.tbxUsername.Size = new System.Drawing.Size(250, 20);
            this.tbxUsername.TabIndex = 0;
            // 
            // tcMain
            // 
            this.tcMain.Controls.Add(this.tabDetail);
            this.tcMain.Controls.Add(this.tabRecord);
            this.tcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcMain.Location = new System.Drawing.Point(4, 65);
            this.tcMain.Name = "tcMain";
            this.tcMain.SelectedIndex = 0;
            this.tcMain.Size = new System.Drawing.Size(486, 311);
            this.tcMain.TabIndex = 0;
            // 
            // UserDetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 421);
            this.Controls.Add(this.pnlMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UserDetailForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "รายละเอียดผู้ใช้งาน";
            this.Load += new System.EventHandler(this.UserDetailForm_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.footerPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.farmManageDataSet)).EndInit();
            this.tabRecord.ResumeLayout(false);
            this.tabDetail.ResumeLayout(false);
            this.gxbDetail.ResumeLayout(false);
            this.pnlContent.ResumeLayout(false);
            this.pnlContent.PerformLayout();
            this.tcMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel pnlMain;
        private System.Windows.Forms.Label label1;
        private Database.FarmManageDataSet farmManageDataSet;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private Database.FarmManageDataSetTableAdapters.UsersTableAdapter usersTableAdapter;
        private System.Windows.Forms.FlowLayoutPanel footerPanel;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TabControl tcMain;
        private System.Windows.Forms.TabPage tabDetail;
        private System.Windows.Forms.GroupBox gxbDetail;
        private System.Windows.Forms.TableLayoutPanel pnlContent;
        private System.Windows.Forms.TextBox tbxUsername;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Button btnChangePassword;
        private System.Windows.Forms.TextBox tbxLastname;
        private System.Windows.Forms.Label lblLastname;
        private System.Windows.Forms.Label lblFisrtname;
        private System.Windows.Forms.TextBox tbxFirstname;
        private System.Windows.Forms.ComboBox cbxPreneme;
        private System.Windows.Forms.Label lblPrefix;
        private System.Windows.Forms.CheckBox chkSuperUser;
        private System.Windows.Forms.CheckBox chkEnable;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxTel;
        private System.Windows.Forms.TextBox tbxEmail;
        private System.Windows.Forms.TabPage tabRecord;
        private Control.UserLogUC userLogUC;
    }
}
namespace MainProject.UserInterface.Setting
{
    partial class SettingForm
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlFooter = new System.Windows.Forms.FlowLayoutPanel();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.tcMain = new System.Windows.Forms.TabControl();
            this.tabGeneral = new System.Windows.Forms.TabPage();
            this.pnlSettingContent = new System.Windows.Forms.TableLayoutPanel();
            this.gbxDateFormat = new System.Windows.Forms.GroupBox();
            this.pnlDateContent = new System.Windows.Forms.TableLayoutPanel();
            this.lblFormat = new System.Windows.Forms.Label();
            this.cbxFormat = new System.Windows.Forms.ComboBox();
            this.gbxResource = new System.Windows.Forms.GroupBox();
            this.pnlResource = new System.Windows.Forms.TableLayoutPanel();
            this.btnChangePath = new System.Windows.Forms.Button();
            this.lblPath = new System.Windows.Forms.Label();
            this.tbxPath = new System.Windows.Forms.TextBox();
            this.pnlMain.SuspendLayout();
            this.pnlFooter.SuspendLayout();
            this.tcMain.SuspendLayout();
            this.tabGeneral.SuspendLayout();
            this.pnlSettingContent.SuspendLayout();
            this.gbxDateFormat.SuspendLayout();
            this.pnlDateContent.SuspendLayout();
            this.gbxResource.SuspendLayout();
            this.pnlResource.SuspendLayout();
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
            this.pnlMain.Size = new System.Drawing.Size(444, 371);
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
            this.lblTitle.Size = new System.Drawing.Size(436, 60);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "การตั้งค่า";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlFooter
            // 
            this.pnlFooter.Controls.Add(this.btnClose);
            this.pnlFooter.Controls.Add(this.btnSave);
            this.pnlFooter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFooter.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.pnlFooter.Location = new System.Drawing.Point(4, 333);
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.Padding = new System.Windows.Forms.Padding(3);
            this.pnlFooter.Size = new System.Drawing.Size(436, 34);
            this.pnlFooter.TabIndex = 1;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(352, 6);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "ยกเลืก";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(271, 6);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "บันทึก";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // tcMain
            // 
            this.tcMain.Controls.Add(this.tabGeneral);
            this.tcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcMain.Location = new System.Drawing.Point(4, 65);
            this.tcMain.Name = "tcMain";
            this.tcMain.SelectedIndex = 0;
            this.tcMain.Size = new System.Drawing.Size(436, 261);
            this.tcMain.TabIndex = 2;
            // 
            // tabGeneral
            // 
            this.tabGeneral.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabGeneral.Controls.Add(this.pnlSettingContent);
            this.tabGeneral.Location = new System.Drawing.Point(4, 22);
            this.tabGeneral.Name = "tabGeneral";
            this.tabGeneral.Padding = new System.Windows.Forms.Padding(3);
            this.tabGeneral.Size = new System.Drawing.Size(428, 235);
            this.tabGeneral.TabIndex = 1;
            this.tabGeneral.Text = "ทั่วไป";
            // 
            // pnlSettingContent
            // 
            this.pnlSettingContent.ColumnCount = 1;
            this.pnlSettingContent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlSettingContent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.pnlSettingContent.Controls.Add(this.gbxDateFormat, 0, 0);
            this.pnlSettingContent.Controls.Add(this.gbxResource, 0, 1);
            this.pnlSettingContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSettingContent.Location = new System.Drawing.Point(3, 3);
            this.pnlSettingContent.Name = "pnlSettingContent";
            this.pnlSettingContent.RowCount = 2;
            this.pnlSettingContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.pnlSettingContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.pnlSettingContent.Size = new System.Drawing.Size(422, 229);
            this.pnlSettingContent.TabIndex = 0;
            // 
            // gbxDateFormat
            // 
            this.gbxDateFormat.Controls.Add(this.pnlDateContent);
            this.gbxDateFormat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbxDateFormat.Location = new System.Drawing.Point(3, 3);
            this.gbxDateFormat.Name = "gbxDateFormat";
            this.gbxDateFormat.Size = new System.Drawing.Size(416, 108);
            this.gbxDateFormat.TabIndex = 0;
            this.gbxDateFormat.TabStop = false;
            this.gbxDateFormat.Text = "รูปแบบวันเวลา";
            // 
            // pnlDateContent
            // 
            this.pnlDateContent.ColumnCount = 3;
            this.pnlDateContent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.pnlDateContent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.pnlDateContent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.pnlDateContent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.pnlDateContent.Controls.Add(this.lblFormat, 1, 1);
            this.pnlDateContent.Controls.Add(this.cbxFormat, 1, 2);
            this.pnlDateContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDateContent.Location = new System.Drawing.Point(3, 16);
            this.pnlDateContent.Name = "pnlDateContent";
            this.pnlDateContent.RowCount = 4;
            this.pnlDateContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.pnlDateContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.pnlDateContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.pnlDateContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlDateContent.Size = new System.Drawing.Size(410, 89);
            this.pnlDateContent.TabIndex = 0;
            // 
            // lblFormat
            // 
            this.lblFormat.AutoSize = true;
            this.lblFormat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblFormat.Location = new System.Drawing.Point(44, 10);
            this.lblFormat.Name = "lblFormat";
            this.lblFormat.Size = new System.Drawing.Size(322, 20);
            this.lblFormat.TabIndex = 0;
            this.lblFormat.Text = "รูปแบบ";
            this.lblFormat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbxFormat
            // 
            this.cbxFormat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbxFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxFormat.FormattingEnabled = true;
            this.cbxFormat.Location = new System.Drawing.Point(44, 33);
            this.cbxFormat.Name = "cbxFormat";
            this.cbxFormat.Size = new System.Drawing.Size(322, 21);
            this.cbxFormat.TabIndex = 1;
            // 
            // gbxResource
            // 
            this.gbxResource.Controls.Add(this.pnlResource);
            this.gbxResource.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbxResource.Location = new System.Drawing.Point(3, 117);
            this.gbxResource.Name = "gbxResource";
            this.gbxResource.Size = new System.Drawing.Size(416, 109);
            this.gbxResource.TabIndex = 1;
            this.gbxResource.TabStop = false;
            this.gbxResource.Text = "หลักฐาน";
            // 
            // pnlResource
            // 
            this.pnlResource.ColumnCount = 4;
            this.pnlResource.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.pnlResource.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.pnlResource.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.pnlResource.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.pnlResource.Controls.Add(this.btnChangePath, 2, 2);
            this.pnlResource.Controls.Add(this.lblPath, 1, 1);
            this.pnlResource.Controls.Add(this.tbxPath, 1, 2);
            this.pnlResource.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlResource.Location = new System.Drawing.Point(3, 16);
            this.pnlResource.Name = "pnlResource";
            this.pnlResource.RowCount = 5;
            this.pnlResource.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.pnlResource.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.pnlResource.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.pnlResource.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.pnlResource.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlResource.Size = new System.Drawing.Size(410, 90);
            this.pnlResource.TabIndex = 1;
            // 
            // btnChangePath
            // 
            this.btnChangePath.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnChangePath.Location = new System.Drawing.Point(290, 33);
            this.btnChangePath.Name = "btnChangePath";
            this.pnlResource.SetRowSpan(this.btnChangePath, 2);
            this.btnChangePath.Size = new System.Drawing.Size(76, 23);
            this.btnChangePath.TabIndex = 1;
            this.btnChangePath.Text = "เปลี่ยน";
            this.btnChangePath.UseVisualStyleBackColor = true;
            // 
            // lblPath
            // 
            this.lblPath.AutoSize = true;
            this.lblPath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPath.Location = new System.Drawing.Point(44, 10);
            this.lblPath.Name = "lblPath";
            this.lblPath.Size = new System.Drawing.Size(240, 20);
            this.lblPath.TabIndex = 0;
            this.lblPath.Text = "ที่ตั้งหลักฐาน";
            this.lblPath.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbxPath
            // 
            this.tbxPath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxPath.Location = new System.Drawing.Point(44, 33);
            this.tbxPath.Name = "tbxPath";
            this.tbxPath.ReadOnly = true;
            this.tbxPath.Size = new System.Drawing.Size(240, 20);
            this.tbxPath.TabIndex = 2;
            // 
            // SettingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 371);
            this.Controls.Add(this.pnlMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "การตั้งค่า";
            this.Load += new System.EventHandler(this.SettingForm_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.pnlFooter.ResumeLayout(false);
            this.tcMain.ResumeLayout(false);
            this.tabGeneral.ResumeLayout(false);
            this.pnlSettingContent.ResumeLayout(false);
            this.gbxDateFormat.ResumeLayout(false);
            this.pnlDateContent.ResumeLayout(false);
            this.pnlDateContent.PerformLayout();
            this.gbxResource.ResumeLayout(false);
            this.pnlResource.ResumeLayout(false);
            this.pnlResource.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel pnlMain;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.FlowLayoutPanel pnlFooter;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TabControl tcMain;
        private System.Windows.Forms.TabPage tabGeneral;
        private System.Windows.Forms.TableLayoutPanel pnlSettingContent;
        private System.Windows.Forms.GroupBox gbxDateFormat;
        private System.Windows.Forms.GroupBox gbxResource;
        private System.Windows.Forms.TableLayoutPanel pnlDateContent;
        private System.Windows.Forms.Label lblFormat;
        private System.Windows.Forms.TableLayoutPanel pnlResource;
        private System.Windows.Forms.Label lblPath;
        private System.Windows.Forms.ComboBox cbxFormat;
        private System.Windows.Forms.Button btnChangePath;
        private System.Windows.Forms.TextBox tbxPath;
    }
}
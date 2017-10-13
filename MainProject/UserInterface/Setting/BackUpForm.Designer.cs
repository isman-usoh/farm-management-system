namespace MainProject.UserInterface.Setting
{
    partial class BackUpForm
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
            this.pnlSettingContent = new System.Windows.Forms.TableLayoutPanel();
            this.gbxDateFormat = new System.Windows.Forms.GroupBox();
            this.pnlDateContent = new System.Windows.Forms.TableLayoutPanel();
            this.btnbackUpNow = new System.Windows.Forms.Button();
            this.lblBackUpLast = new System.Windows.Forms.Label();
            this.gbxBackUpList = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRestone = new System.Windows.Forms.DataGridViewButtonColumn();
            this.colDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlFooter = new System.Windows.Forms.FlowLayoutPanel();
            this.btnClose = new System.Windows.Forms.Button();
            this.pnlMain.SuspendLayout();
            this.pnlSettingContent.SuspendLayout();
            this.gbxDateFormat.SuspendLayout();
            this.pnlDateContent.SuspendLayout();
            this.gbxBackUpList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.pnlFooter.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.pnlMain.ColumnCount = 1;
            this.pnlMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlMain.Controls.Add(this.pnlSettingContent, 0, 1);
            this.pnlMain.Controls.Add(this.lblTitle, 0, 0);
            this.pnlMain.Controls.Add(this.pnlFooter, 0, 2);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.RowCount = 3;
            this.pnlMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.pnlMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.pnlMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.pnlMain.Size = new System.Drawing.Size(494, 421);
            this.pnlMain.TabIndex = 1;
            // 
            // pnlSettingContent
            // 
            this.pnlSettingContent.ColumnCount = 1;
            this.pnlSettingContent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlSettingContent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.pnlSettingContent.Controls.Add(this.gbxDateFormat, 0, 0);
            this.pnlSettingContent.Controls.Add(this.gbxBackUpList, 0, 1);
            this.pnlSettingContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSettingContent.Location = new System.Drawing.Point(4, 65);
            this.pnlSettingContent.Name = "pnlSettingContent";
            this.pnlSettingContent.RowCount = 2;
            this.pnlSettingContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 27.65273F));
            this.pnlSettingContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 72.34727F));
            this.pnlSettingContent.Size = new System.Drawing.Size(486, 311);
            this.pnlSettingContent.TabIndex = 2;
            // 
            // gbxDateFormat
            // 
            this.gbxDateFormat.Controls.Add(this.pnlDateContent);
            this.gbxDateFormat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbxDateFormat.Location = new System.Drawing.Point(3, 3);
            this.gbxDateFormat.Name = "gbxDateFormat";
            this.gbxDateFormat.Size = new System.Drawing.Size(480, 79);
            this.gbxDateFormat.TabIndex = 0;
            this.gbxDateFormat.TabStop = false;
            this.gbxDateFormat.Text = "รูปแบบวันเวลา";
            // 
            // pnlDateContent
            // 
            this.pnlDateContent.ColumnCount = 5;
            this.pnlDateContent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.pnlDateContent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlDateContent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.pnlDateContent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 118F));
            this.pnlDateContent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.pnlDateContent.Controls.Add(this.btnbackUpNow, 3, 1);
            this.pnlDateContent.Controls.Add(this.lblBackUpLast, 1, 1);
            this.pnlDateContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDateContent.Location = new System.Drawing.Point(3, 16);
            this.pnlDateContent.Name = "pnlDateContent";
            this.pnlDateContent.RowCount = 3;
            this.pnlDateContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.pnlDateContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.pnlDateContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.pnlDateContent.Size = new System.Drawing.Size(474, 60);
            this.pnlDateContent.TabIndex = 0;
            // 
            // btnbackUpNow
            // 
            this.btnbackUpNow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnbackUpNow.Location = new System.Drawing.Point(349, 18);
            this.btnbackUpNow.Name = "btnbackUpNow";
            this.btnbackUpNow.Size = new System.Drawing.Size(112, 24);
            this.btnbackUpNow.TabIndex = 0;
            this.btnbackUpNow.Text = "สำรองข้อมูลเดียวนี้";
            this.btnbackUpNow.UseVisualStyleBackColor = true;
            this.btnbackUpNow.Click += new System.EventHandler(this.btnbackUpNow_Click);
            // 
            // lblBackUpLast
            // 
            this.lblBackUpLast.AutoSize = true;
            this.lblBackUpLast.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblBackUpLast.Location = new System.Drawing.Point(13, 15);
            this.lblBackUpLast.Name = "lblBackUpLast";
            this.lblBackUpLast.Size = new System.Drawing.Size(322, 30);
            this.lblBackUpLast.TabIndex = 1;
            this.lblBackUpLast.Text = "สำรองข้อมูลล่าสุดเมือ :";
            this.lblBackUpLast.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // gbxBackUpList
            // 
            this.gbxBackUpList.Controls.Add(this.dataGridView1);
            this.gbxBackUpList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbxBackUpList.Location = new System.Drawing.Point(3, 88);
            this.gbxBackUpList.Name = "gbxBackUpList";
            this.gbxBackUpList.Size = new System.Drawing.Size(480, 220);
            this.gbxBackUpList.TabIndex = 1;
            this.gbxBackUpList.TabStop = false;
            this.gbxBackUpList.Text = "รายการสำรอง";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colName,
            this.colRestone,
            this.colDelete});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 16);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(10);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(474, 201);
            this.dataGridView1.TabIndex = 0;
            // 
            // colName
            // 
            this.colName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colName.HeaderText = "รายการ";
            this.colName.Name = "colName";
            this.colName.ReadOnly = true;
            // 
            // colRestone
            // 
            this.colRestone.HeaderText = "กู้คืน";
            this.colRestone.Name = "colRestone";
            this.colRestone.ReadOnly = true;
            // 
            // colDelete
            // 
            this.colDelete.HeaderText = "ลบ";
            this.colDelete.Name = "colDelete";
            this.colDelete.ReadOnly = true;
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
            this.lblTitle.Size = new System.Drawing.Size(486, 60);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "สำรองและกู้คืน";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlFooter
            // 
            this.pnlFooter.Controls.Add(this.btnClose);
            this.pnlFooter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFooter.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.pnlFooter.Location = new System.Drawing.Point(4, 383);
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.Padding = new System.Windows.Forms.Padding(3);
            this.pnlFooter.Size = new System.Drawing.Size(486, 34);
            this.pnlFooter.TabIndex = 1;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(402, 6);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "ปิด";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // BackUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 421);
            this.Controls.Add(this.pnlMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BackUpForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "สำรองและกู้คืน";
            this.Load += new System.EventHandler(this.BackUpForm_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.pnlSettingContent.ResumeLayout(false);
            this.gbxDateFormat.ResumeLayout(false);
            this.pnlDateContent.ResumeLayout(false);
            this.pnlDateContent.PerformLayout();
            this.gbxBackUpList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.pnlFooter.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel pnlMain;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.FlowLayoutPanel pnlFooter;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TableLayoutPanel pnlSettingContent;
        private System.Windows.Forms.GroupBox gbxDateFormat;
        private System.Windows.Forms.TableLayoutPanel pnlDateContent;
        private System.Windows.Forms.GroupBox gbxBackUpList;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnbackUpNow;
        private System.Windows.Forms.Label lblBackUpLast;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewButtonColumn colRestone;
        private System.Windows.Forms.DataGridViewButtonColumn colDelete;
    }
}
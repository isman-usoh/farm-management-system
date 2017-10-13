namespace MainProject.UserInterface.Control
{
    partial class UserLogUC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.gbxCreate = new System.Windows.Forms.GroupBox();
            this.dgvLog = new System.Windows.Forms.DataGridView();
            this.usersViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.farmManageDataSet = new MainProject.Database.FarmManageDataSet();
            this.userLogBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userLogTableAdapter = new MainProject.Database.FarmManageDataSetTableAdapters.UserLogTableAdapter();
            this.usersViewTableAdapter = new MainProject.Database.FarmManageDataSetTableAdapters.UsersViewTableAdapter();
            this.colLogID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLogBy = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.colLogEvent = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.colLogDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbxCreate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.farmManageDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userLogBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxCreate
            // 
            this.gbxCreate.Controls.Add(this.dgvLog);
            this.gbxCreate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbxCreate.Location = new System.Drawing.Point(0, 0);
            this.gbxCreate.Name = "gbxCreate";
            this.gbxCreate.Size = new System.Drawing.Size(662, 266);
            this.gbxCreate.TabIndex = 4;
            this.gbxCreate.TabStop = false;
            this.gbxCreate.Text = "การบันทึก";
            // 
            // dgvLog
            // 
            this.dgvLog.AllowUserToAddRows = false;
            this.dgvLog.AllowUserToDeleteRows = false;
            this.dgvLog.AutoGenerateColumns = false;
            this.dgvLog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLog.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colLogID,
            this.colLogBy,
            this.colLogEvent,
            this.colLogDate});
            this.dgvLog.DataSource = this.userLogBindingSource;
            this.dgvLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLog.Location = new System.Drawing.Point(3, 16);
            this.dgvLog.Name = "dgvLog";
            this.dgvLog.ReadOnly = true;
            this.dgvLog.Size = new System.Drawing.Size(656, 247);
            this.dgvLog.TabIndex = 0;
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
            // userLogBindingSource
            // 
            this.userLogBindingSource.DataMember = "UserLog";
            this.userLogBindingSource.DataSource = this.farmManageDataSet;
            // 
            // userLogTableAdapter
            // 
            this.userLogTableAdapter.ClearBeforeFill = true;
            // 
            // usersViewTableAdapter
            // 
            this.usersViewTableAdapter.ClearBeforeFill = true;
            // 
            // colLogID
            // 
            this.colLogID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colLogID.DataPropertyName = "ID";
            this.colLogID.HeaderText = "#";
            this.colLogID.Name = "colLogID";
            this.colLogID.ReadOnly = true;
            this.colLogID.Width = 39;
            // 
            // colLogBy
            // 
            this.colLogBy.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colLogBy.DataPropertyName = "UserID";
            this.colLogBy.DataSource = this.usersViewBindingSource;
            this.colLogBy.DisplayMember = "Name";
            this.colLogBy.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.colLogBy.HeaderText = "โดย";
            this.colLogBy.Name = "colLogBy";
            this.colLogBy.ReadOnly = true;
            this.colLogBy.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colLogBy.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colLogBy.ValueMember = "UserID";
            // 
            // colLogEvent
            // 
            this.colLogEvent.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colLogEvent.DataPropertyName = "Event";
            this.colLogEvent.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.colLogEvent.HeaderText = "เหตุการณ์";
            this.colLogEvent.Name = "colLogEvent";
            this.colLogEvent.ReadOnly = true;
            this.colLogEvent.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colLogEvent.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // colLogDate
            // 
            this.colLogDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colLogDate.DataPropertyName = "Date";
            this.colLogDate.HeaderText = "วันที่";
            this.colLogDate.Name = "colLogDate";
            this.colLogDate.ReadOnly = true;
            // 
            // UserLogUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbxCreate);
            this.Name = "UserLogUC";
            this.Size = new System.Drawing.Size(662, 266);
            this.Load += new System.EventHandler(this.UserLogUC_Load);
            this.gbxCreate.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.farmManageDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userLogBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxCreate;
        private System.Windows.Forms.DataGridView dgvLog;
        private System.Windows.Forms.BindingSource usersViewBindingSource;
        private Database.FarmManageDataSetTableAdapters.UsersViewTableAdapter usersViewTableAdapter;
        private System.Windows.Forms.BindingSource userLogBindingSource;
        private Database.FarmManageDataSetTableAdapters.UserLogTableAdapter userLogTableAdapter;
        private Database.FarmManageDataSet farmManageDataSet;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLogID;
        private System.Windows.Forms.DataGridViewComboBoxColumn colLogBy;
        private System.Windows.Forms.DataGridViewComboBoxColumn colLogEvent;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLogDate;
    }
}

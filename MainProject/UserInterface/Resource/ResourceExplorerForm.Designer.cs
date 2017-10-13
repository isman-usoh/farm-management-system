namespace MainProject.UserInterface.Resource
{
    partial class ResourceExplorerForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlMain = new System.Windows.Forms.TableLayoutPanel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlFooter = new System.Windows.Forms.FlowLayoutPanel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.tcMain = new System.Windows.Forms.TabControl();
            this.tabListResource = new System.Windows.Forms.TabPage();
            this.gbxListResource = new System.Windows.Forms.GroupBox();
            this.dgvList = new System.Windows.Forms.DataGridView();
            this.resourceIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewComboBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createByDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.usersViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.farmManageDataSet = new MainProject.Database.FarmManageDataSet();
            this.createDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOpen = new System.Windows.Forms.DataGridViewButtonColumn();
            this.resourceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabAddResource = new System.Windows.Forms.TabPage();
            this.gbxAddResource = new System.Windows.Forms.GroupBox();
            this.pnlAddResourceContent = new System.Windows.Forms.TableLayoutPanel();
            this.pnlAddResourceOption = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnRemoveAll = new System.Windows.Forms.Button();
            this.dgvAdd = new System.Windows.Forms.DataGridView();
            this.colAddID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAddName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAddType = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.colAddDescriptiom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resourceTableAdapter = new MainProject.Database.FarmManageDataSetTableAdapters.ResourceTableAdapter();
            this.usersViewTableAdapter = new MainProject.Database.FarmManageDataSetTableAdapters.UsersViewTableAdapter();
            this.pnlMain.SuspendLayout();
            this.pnlFooter.SuspendLayout();
            this.tcMain.SuspendLayout();
            this.tabListResource.SuspendLayout();
            this.gbxListResource.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.farmManageDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resourceBindingSource)).BeginInit();
            this.tabAddResource.SuspendLayout();
            this.gbxAddResource.SuspendLayout();
            this.pnlAddResourceContent.SuspendLayout();
            this.pnlAddResourceOption.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdd)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.ColumnCount = 1;
            this.pnlMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
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
            this.pnlMain.Size = new System.Drawing.Size(644, 421);
            this.pnlMain.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.White;
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblTitle.Location = new System.Drawing.Point(3, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lblTitle.Size = new System.Drawing.Size(638, 60);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "การจัดการหลักฐาน";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlFooter
            // 
            this.pnlFooter.Controls.Add(this.btnCancel);
            this.pnlFooter.Controls.Add(this.btnSave);
            this.pnlFooter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFooter.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.pnlFooter.Location = new System.Drawing.Point(3, 384);
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.Padding = new System.Windows.Forms.Padding(3);
            this.pnlFooter.Size = new System.Drawing.Size(638, 34);
            this.pnlFooter.TabIndex = 2;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(554, 6);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "ยกเลิก";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(473, 6);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "บันทึก";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // tcMain
            // 
            this.tcMain.Controls.Add(this.tabListResource);
            this.tcMain.Controls.Add(this.tabAddResource);
            this.tcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcMain.Location = new System.Drawing.Point(3, 63);
            this.tcMain.Name = "tcMain";
            this.tcMain.SelectedIndex = 0;
            this.tcMain.Size = new System.Drawing.Size(638, 315);
            this.tcMain.TabIndex = 3;
            // 
            // tabListResource
            // 
            this.tabListResource.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabListResource.Controls.Add(this.gbxListResource);
            this.tabListResource.Location = new System.Drawing.Point(4, 22);
            this.tabListResource.Name = "tabListResource";
            this.tabListResource.Padding = new System.Windows.Forms.Padding(3);
            this.tabListResource.Size = new System.Drawing.Size(630, 289);
            this.tabListResource.TabIndex = 0;
            this.tabListResource.Text = "รายการหลักฐาน";
            // 
            // gbxListResource
            // 
            this.gbxListResource.Controls.Add(this.dgvList);
            this.gbxListResource.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbxListResource.Location = new System.Drawing.Point(3, 3);
            this.gbxListResource.Name = "gbxListResource";
            this.gbxListResource.Size = new System.Drawing.Size(624, 283);
            this.gbxListResource.TabIndex = 0;
            this.gbxListResource.TabStop = false;
            this.gbxListResource.Text = "รายการหลักฐาน";
            // 
            // dgvList
            // 
            this.dgvList.AllowUserToAddRows = false;
            this.dgvList.AllowUserToDeleteRows = false;
            this.dgvList.AutoGenerateColumns = false;
            this.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.resourceIDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.typeDataGridViewComboBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.createByDataGridViewTextBoxColumn,
            this.createDateDataGridViewTextBoxColumn,
            this.colOpen});
            this.dgvList.DataSource = this.resourceBindingSource;
            this.dgvList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvList.Location = new System.Drawing.Point(3, 16);
            this.dgvList.Name = "dgvList";
            this.dgvList.ReadOnly = true;
            this.dgvList.Size = new System.Drawing.Size(618, 264);
            this.dgvList.TabIndex = 0;
            this.dgvList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvList_CellContentClick);
            // 
            // resourceIDDataGridViewTextBoxColumn
            // 
            this.resourceIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.resourceIDDataGridViewTextBoxColumn.DataPropertyName = "ResourceID";
            this.resourceIDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.resourceIDDataGridViewTextBoxColumn.MinimumWidth = 50;
            this.resourceIDDataGridViewTextBoxColumn.Name = "resourceIDDataGridViewTextBoxColumn";
            this.resourceIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.resourceIDDataGridViewTextBoxColumn.Width = 50;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "ชื่อไฟล์";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // typeDataGridViewComboBoxColumn
            // 
            this.typeDataGridViewComboBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.typeDataGridViewComboBoxColumn.DataPropertyName = "Type";
            this.typeDataGridViewComboBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.typeDataGridViewComboBoxColumn.HeaderText = "ประเภท";
            this.typeDataGridViewComboBoxColumn.Name = "typeDataGridViewComboBoxColumn";
            this.typeDataGridViewComboBoxColumn.ReadOnly = true;
            this.typeDataGridViewComboBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.typeDataGridViewComboBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "คำอธิบาย";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // createByDataGridViewTextBoxColumn
            // 
            this.createByDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.createByDataGridViewTextBoxColumn.DataPropertyName = "CreateBy";
            this.createByDataGridViewTextBoxColumn.DataSource = this.usersViewBindingSource;
            this.createByDataGridViewTextBoxColumn.DisplayMember = "Name";
            this.createByDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.createByDataGridViewTextBoxColumn.HeaderText = "เพิ่มโดย";
            this.createByDataGridViewTextBoxColumn.Name = "createByDataGridViewTextBoxColumn";
            this.createByDataGridViewTextBoxColumn.ReadOnly = true;
            this.createByDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.createByDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.createByDataGridViewTextBoxColumn.ValueMember = "UserID";
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
            // createDateDataGridViewTextBoxColumn
            // 
            this.createDateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.createDateDataGridViewTextBoxColumn.DataPropertyName = "CreateDate";
            dataGridViewCellStyle1.Format = "D";
            dataGridViewCellStyle1.NullValue = null;
            this.createDateDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.createDateDataGridViewTextBoxColumn.HeaderText = "วันที่เพิ่ม";
            this.createDateDataGridViewTextBoxColumn.Name = "createDateDataGridViewTextBoxColumn";
            this.createDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // colOpen
            // 
            this.colOpen.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colOpen.HeaderText = "";
            this.colOpen.Name = "colOpen";
            this.colOpen.ReadOnly = true;
            this.colOpen.Text = "เปิด";
            this.colOpen.UseColumnTextForButtonValue = true;
            // 
            // resourceBindingSource
            // 
            this.resourceBindingSource.DataMember = "Resource";
            this.resourceBindingSource.DataSource = this.farmManageDataSet;
            // 
            // tabAddResource
            // 
            this.tabAddResource.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabAddResource.Controls.Add(this.gbxAddResource);
            this.tabAddResource.Location = new System.Drawing.Point(4, 22);
            this.tabAddResource.Name = "tabAddResource";
            this.tabAddResource.Padding = new System.Windows.Forms.Padding(3);
            this.tabAddResource.Size = new System.Drawing.Size(630, 289);
            this.tabAddResource.TabIndex = 1;
            this.tabAddResource.Text = "เพิ่มรายการหลักฐาน";
            // 
            // gbxAddResource
            // 
            this.gbxAddResource.Controls.Add(this.pnlAddResourceContent);
            this.gbxAddResource.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbxAddResource.Location = new System.Drawing.Point(3, 3);
            this.gbxAddResource.Name = "gbxAddResource";
            this.gbxAddResource.Size = new System.Drawing.Size(624, 283);
            this.gbxAddResource.TabIndex = 0;
            this.gbxAddResource.TabStop = false;
            this.gbxAddResource.Text = "เพิ่มรายการหลักฐาน";
            // 
            // pnlAddResourceContent
            // 
            this.pnlAddResourceContent.ColumnCount = 1;
            this.pnlAddResourceContent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlAddResourceContent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.pnlAddResourceContent.Controls.Add(this.pnlAddResourceOption, 0, 1);
            this.pnlAddResourceContent.Controls.Add(this.dgvAdd, 0, 0);
            this.pnlAddResourceContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlAddResourceContent.Location = new System.Drawing.Point(3, 16);
            this.pnlAddResourceContent.Name = "pnlAddResourceContent";
            this.pnlAddResourceContent.RowCount = 2;
            this.pnlAddResourceContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlAddResourceContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.pnlAddResourceContent.Size = new System.Drawing.Size(618, 264);
            this.pnlAddResourceContent.TabIndex = 0;
            // 
            // pnlAddResourceOption
            // 
            this.pnlAddResourceOption.Controls.Add(this.btnAdd);
            this.pnlAddResourceOption.Controls.Add(this.btnRemove);
            this.pnlAddResourceOption.Controls.Add(this.btnRemoveAll);
            this.pnlAddResourceOption.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlAddResourceOption.Location = new System.Drawing.Point(0, 236);
            this.pnlAddResourceOption.Margin = new System.Windows.Forms.Padding(0);
            this.pnlAddResourceOption.Name = "pnlAddResourceOption";
            this.pnlAddResourceOption.Size = new System.Drawing.Size(618, 28);
            this.pnlAddResourceOption.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(3, 3);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "เพิ่ม";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Enabled = false;
            this.btnRemove.Location = new System.Drawing.Point(84, 3);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 23);
            this.btnRemove.TabIndex = 1;
            this.btnRemove.Text = "ลบที่เลือก";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnRemoveAll
            // 
            this.btnRemoveAll.Enabled = false;
            this.btnRemoveAll.Location = new System.Drawing.Point(165, 3);
            this.btnRemoveAll.Name = "btnRemoveAll";
            this.btnRemoveAll.Size = new System.Drawing.Size(75, 23);
            this.btnRemoveAll.TabIndex = 2;
            this.btnRemoveAll.Text = "ลบทั้งหมด";
            this.btnRemoveAll.UseVisualStyleBackColor = true;
            this.btnRemoveAll.Click += new System.EventHandler(this.btnRemoveAll_Click);
            // 
            // dgvAdd
            // 
            this.dgvAdd.AllowUserToAddRows = false;
            this.dgvAdd.AllowUserToDeleteRows = false;
            this.dgvAdd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAdd.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colAddID,
            this.colAddName,
            this.colAddType,
            this.colAddDescriptiom});
            this.dgvAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAdd.Location = new System.Drawing.Point(3, 3);
            this.dgvAdd.Name = "dgvAdd";
            this.dgvAdd.ReadOnly = true;
            this.dgvAdd.Size = new System.Drawing.Size(612, 230);
            this.dgvAdd.TabIndex = 1;
            this.dgvAdd.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgvAdd_RowsAdded);
            this.dgvAdd.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dgvAdd_RowsRemoved);
            this.dgvAdd.SelectionChanged += new System.EventHandler(this.dgvAdd_SelectionChanged);
            // 
            // colAddID
            // 
            this.colAddID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colAddID.HeaderText = "ลำดับ";
            this.colAddID.MinimumWidth = 50;
            this.colAddID.Name = "colAddID";
            this.colAddID.ReadOnly = true;
            this.colAddID.Width = 57;
            // 
            // colAddName
            // 
            this.colAddName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colAddName.HeaderText = "ชื่อไฟล์";
            this.colAddName.MinimumWidth = 100;
            this.colAddName.Name = "colAddName";
            this.colAddName.ReadOnly = true;
            // 
            // colAddType
            // 
            this.colAddType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colAddType.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.colAddType.HeaderText = "ประเภท";
            this.colAddType.MinimumWidth = 100;
            this.colAddType.Name = "colAddType";
            this.colAddType.ReadOnly = true;
            this.colAddType.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colAddType.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // colAddDescriptiom
            // 
            this.colAddDescriptiom.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colAddDescriptiom.HeaderText = "คำอธิบาย";
            this.colAddDescriptiom.Name = "colAddDescriptiom";
            this.colAddDescriptiom.ReadOnly = true;
            // 
            // resourceTableAdapter
            // 
            this.resourceTableAdapter.ClearBeforeFill = true;
            // 
            // usersViewTableAdapter
            // 
            this.usersViewTableAdapter.ClearBeforeFill = true;
            // 
            // ResourceExplorerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 421);
            this.Controls.Add(this.pnlMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ResourceExplorerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "การจัดการหลักฐาน";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ResourceExplorerForm_FormClosing);
            this.Load += new System.EventHandler(this.ResourceExplorerForm_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.pnlFooter.ResumeLayout(false);
            this.tcMain.ResumeLayout(false);
            this.tabListResource.ResumeLayout(false);
            this.gbxListResource.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.farmManageDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resourceBindingSource)).EndInit();
            this.tabAddResource.ResumeLayout(false);
            this.gbxAddResource.ResumeLayout(false);
            this.pnlAddResourceContent.ResumeLayout(false);
            this.pnlAddResourceOption.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdd)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel pnlMain;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.FlowLayoutPanel pnlFooter;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TabControl tcMain;
        private System.Windows.Forms.TabPage tabListResource;
        private System.Windows.Forms.TabPage tabAddResource;
        private System.Windows.Forms.GroupBox gbxListResource;
        private System.Windows.Forms.DataGridView dgvList;
        private System.Windows.Forms.GroupBox gbxAddResource;
        private System.Windows.Forms.TableLayoutPanel pnlAddResourceContent;
        private System.Windows.Forms.FlowLayoutPanel pnlAddResourceOption;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnRemoveAll;
        private System.Windows.Forms.DataGridView dgvAdd;
        private Database.FarmManageDataSet farmManageDataSet;
        private System.Windows.Forms.BindingSource resourceBindingSource;
        private Database.FarmManageDataSetTableAdapters.ResourceTableAdapter resourceTableAdapter;
        private System.Windows.Forms.BindingSource usersViewBindingSource;
        private Database.FarmManageDataSetTableAdapters.UsersViewTableAdapter usersViewTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAddID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAddName;
        private System.Windows.Forms.DataGridViewComboBoxColumn colAddType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAddDescriptiom;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridViewTextBoxColumn resourceIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn typeDataGridViewComboBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn createByDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn createDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn colOpen;
    }
}
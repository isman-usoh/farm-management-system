using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using MainProject.Util;
using System.IO;
using MainProject.Properties;
using System.Diagnostics;

namespace MainProject.UserInterface.Resource
{
    public partial class ResourceExplorerForm : Form
    {
        public Int32 FromID { get; set; }
        public Byte FromType { get; set; }

        public List<AddResourceForm.ResourceObj> ResourcesList = new List<AddResourceForm.ResourceObj>();

        public ResourceExplorerForm()
        {
            InitializeComponent();
        }

        private void ResourceExplorerForm_Load(object sender, EventArgs e)
        {
            colAddType.ValueMember = "Key";
            colAddType.DisplayMember = "Value";
            colAddType.DataSource = TypeUtil.ResourceType().ToList();

            typeDataGridViewComboBoxColumn.ValueMember = "Key";
            typeDataGridViewComboBoxColumn.DisplayMember = "Value";
            typeDataGridViewComboBoxColumn.DataSource = TypeUtil.ResourceType().ToList();

            usersViewTableAdapter.Fill(farmManageDataSet.UsersView);



            if (FromID == 0)
            {
                tcMain.TabPages.Remove(tabListResource);
                btnCancel.Text = "ปิด";
                btnSave.Visible = false;
            }
            else
            {
                resourceTableAdapter.FillByResource(farmManageDataSet.Resource, FromType, FromID);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var form = new AddResourceForm();
            form.FromType = FromType;
            if (form.ShowDialog() == System.Windows.Forms.DialogResult.Yes)
            {
                dgvAdd.Rows.Add();
                dgvAdd.Rows[dgvAdd.Rows.Count - 1].Cells[0].Value = dgvAdd.Rows.Count;
                dgvAdd.Rows[dgvAdd.Rows.Count - 1].Cells[1].Value = form.Resource.Name;
                dgvAdd.Rows[dgvAdd.Rows.Count - 1].Cells[2].Value = form.Resource.Type;
                dgvAdd.Rows[dgvAdd.Rows.Count - 1].Cells[3].Value = form.Resource.Desciption;
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvAdd.SelectedRows)
            {
                dgvAdd.Rows.Remove(row);
            }
        }

        private void btnRemoveAll_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvAdd.Rows)
            {
                dgvAdd.Rows.Remove(row);
            }
        }

        private void dgvAdd_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            btnRemoveAll.Enabled = dgvAdd.Rows.Count == 0 ? false : true;
        }

        private void dgvAdd_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            btnRemoveAll.Enabled = dgvAdd.Rows.Count == 0 ? false : true;
        }

        private void dgvAdd_SelectionChanged(object sender, EventArgs e)
        {
            btnRemove.Enabled = dgvAdd.SelectedRows.Count == 0 ? false : true;
        }

        private void ResourceExplorerForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            ResourcesList.Clear();
            foreach (DataGridViewRow row in dgvAdd.Rows)
            {
                var obj = new AddResourceForm.ResourceObj();
                obj.Name = row.Cells[1].Value.ToString();
                obj.Type = row.Cells[2].Value.ToString();
                obj.Desciption = row.Cells[3].Value == null ? String.Empty : row.Cells[3].Value.ToString();

                ResourcesList.Add(obj);
            }
            DialogResult = System.Windows.Forms.DialogResult.Yes;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ResourcesList.Clear();
            foreach (DataGridViewRow row in dgvAdd.Rows)
            {
                var obj = new AddResourceForm.ResourceObj();
                obj.Name = row.Cells[1].Value.ToString();
                obj.Type = row.Cells[2].Value.ToString();
                obj.Desciption = row.Cells[3].Value == null ? String.Empty : row.Cells[3].Value.ToString();

                ResourcesList.Add(obj);
            }
            DialogResult = System.Windows.Forms.DialogResult.Yes;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Save();
            DialogResult = System.Windows.Forms.DialogResult.Yes;
        }


        private void Save()
        {
            foreach (DataGridViewRow row in dgvAdd.Rows)
            {
                if (File.Exists(row.Cells[1].Value.ToString()))
                {
                    var arr = row.Cells[1].Value.ToString().Split('\\');
                    var Filename = arr[arr.Length - 1];

                    var temp = String.Format("{0}.{1}", Guid.NewGuid().ToString(), row.Cells[2].Value.ToString());

                    File.Copy(row.Cells[1].Value.ToString(), System.IO.Path.Combine(System.IO.Path.GetTempPath(), temp));
                    File.Move(System.IO.Path.Combine(System.IO.Path.GetTempPath(), temp), System.IO.Path.Combine(Settings.Default.infoPath, temp));

                    resourceTableAdapter.Insert(
                        Filename,
                        row.Cells[2].Value.ToString(),
                        temp,
                        FromType,
                        FromID,
                        MainForm.User.UserID,
                        DateTime.Now,
                        row.Cells[3].Value == null ? String.Empty : row.Cells[3].Value.ToString());
                }
            }

            if (dgvAdd.Rows.Count != 0)
            {
                MessageBox.Show("เพิ่มหลักฐานเสร็จสมบูรณ์", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("ไม่ได้เพิ่มหลักฐาน", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dgvList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }
            if (e.ColumnIndex == 6)
            {
                var path = ((DataRowView)resourceBindingSource[e.RowIndex]).Row["Path"].ToString();
                path = System.IO.Path.Combine(Settings.Default.infoPath, path);
                Process.Start(path);
            }
        }
    }
}

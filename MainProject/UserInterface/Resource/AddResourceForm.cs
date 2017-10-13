using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MainProject.Util;

namespace MainProject.UserInterface.Resource
{
    public partial class AddResourceForm : Form
    {
        public Int32 ResourceID { get; set; }
        public Byte FromType { get; set; }
        public ResourceObj Resource { get; set; }

        public class ResourceObj
        {
            public String Name { get; set; }
            public String Type { get; set; }
            public String Desciption { get; set; }
        }


        public AddResourceForm()
        {
            InitializeComponent();
        }

        private void AddResourceForm_Load(object sender, EventArgs e)
        {
            cbxFrom.ValueMember = "Key";
            cbxFrom.DisplayMember = "Value";
            cbxFrom.DataSource = TypeUtil.ResourceFromType().ToList();

            cbxType.ValueMember = "Key";
            cbxType.DisplayMember = "Value";
            cbxType.DataSource = TypeUtil.ResourceType().ToList();

            if (ResourceID == 0)
            {
                cbxFrom.SelectedValue = FromType;
                cbxCreateBy.Visible = false;
                lblCreateBy.Visible = false;
                tbxCreateDate.Visible = false;
                lblCreateDate.Visible = false;
            }
            else
            {
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var temp = new ResourceObj();
            temp.Desciption = tbxDescription.Text;
            temp.Type = cbxType.SelectedValue.ToString();
            temp.Name = tbxName.Text;



            Resource = temp;
            DialogResult = System.Windows.Forms.DialogResult.Yes;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.No;
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            var dialog = new OpenFileDialog() { Filter = "All File |*.doc;*.docx;*.jpeg;*.png;*.jpg;*.pdf|JPEG Files (*.jpeg)|*.jpeg|PNG Files (*.png)|*.png|JPG Files (*.jpg)|*.jpg|PDF Files (*.pdf)|*.pdf|Word Documents (*.doc;*.docx)|*.doc;*.docx",
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
                Title = "กรุณาเลือกไฟล์ประกอบหลักฐาน" };
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                var files = dialog.FileName.Split('.');
                var fileEx = files[files.Length - 1];

                tbxName.Text = dialog.FileName;
                cbxType.SelectedValue = fileEx;
            }
        }
    }
}

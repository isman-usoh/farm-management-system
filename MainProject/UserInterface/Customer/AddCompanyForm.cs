using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using MainProject.Util;
using MainProject.Database.FarmManageDataSetTableAdapters;

namespace MainProject.UserInterface.Customer
{
    public partial class AddCompanyForm : Form
    {
        public Int32 CompanyID { get; set; }

        public AddCompanyForm()
        {
            InitializeComponent();
        }

        private void AddGeneForm_Load(object sender, EventArgs e)
        {
            this.btnSave.Text = "เพิ่ม";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
                return;

            CompanyTableAdapter companyTableAdapter = new CompanyTableAdapter();
            CompanyID = (int)companyTableAdapter.InsertQuery(this.tbxName.Text.Trim());
            if (CompanyID > 0)
            {
                UserLogTableAdapter logTableAdapter = new UserLogTableAdapter();
                logTableAdapter.Insert(TypeUtil.Gene, CompanyID.ToString(), MainForm.User.UserID, TypeUtil.EVENT_CREATE, DateTime.Now);

                this.DialogResult = DialogUtil.AddSuccess();
            }
            else
            {
                this.DialogResult = DialogUtil.AddError();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
        }

        private void tbxName_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            ValidatingUtil.Validating(tbxName, 0, e);
        }
    }
}

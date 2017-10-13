using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using MainProject.Util;
using MainProject.Database.FarmManageDataSetTableAdapters;

namespace MainProject.UserInterface.Gene
{
    public partial class AddGeneForm : Form
    {
        public Int32 GeneID { get; set; }

        public AddGeneForm()
        {
            InitializeComponent();
        }

        private void AddGeneForm_Load(object sender, EventArgs e)
        {
            if (GeneID != 0)
            {
                this.Text = "แก้ไขพันธุ์โค";
                this.lblTitle.Text = this.Text;
                this.geneTableAdapter.FillByPK(farmManageDataSet.Gene, GeneID);
            }
            else
            {
                this.btnSave.Text = "เพิ่ม";
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
                return;


            if (GeneID != 0)
            {
                this.geneBindingSource.EndEdit();
                if (1 == this.geneTableAdapter.Update(this.farmManageDataSet.Gene))
                {
                    UserLogTableAdapter logTableAdapter = new UserLogTableAdapter();
                    logTableAdapter.Insert(TypeUtil.Gene, GeneID.ToString(), MainForm.User.UserID, TypeUtil.EVENT_MODIFY, DateTime.Now);

                    this.DialogResult = DialogUtil.SaveSuccess();
                }
                else
                {
                    this.DialogResult = DialogUtil.SaveError();
                }
            }
            else
            {
                GeneID = (int)this.geneTableAdapter.InsertQuery(this.tbxName.Text.Trim(), this.tbxNatural.Text.Trim());
                if (GeneID > 0)
                {
                    UserLogTableAdapter logTableAdapter = new UserLogTableAdapter();
                    logTableAdapter.Insert(TypeUtil.Gene, GeneID.ToString(), MainForm.User.UserID, TypeUtil.EVENT_CREATE, DateTime.Now);

                    this.DialogResult = DialogUtil.AddSuccess();
                }
                else
                {
                    this.DialogResult = DialogUtil.AddError();
                }
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

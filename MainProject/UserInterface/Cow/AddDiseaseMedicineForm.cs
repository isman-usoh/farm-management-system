using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using MainProject.Util;

namespace MainProject.UserInterface.Cow
{
    public partial class AddDiseaseMedicineForm : Form
    {
        public Int32 DiseaseMedicineID { get; set; }
        public Int32 OptionStockID { get; set; }
        public Int32 OptionByID { get; set; }
        public Double OptionUnit { get; set; }
        public DateTime OptionDate { get; set; }

        public AddDiseaseMedicineForm()
        {
            InitializeComponent();
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren())
            {
                return;
            }

            if (DiseaseMedicineID == 0)
            {
                OptionStockID = Convert.ToInt32(cbxStock.SelectedValue);
                OptionByID = Convert.ToInt32(cbxBy.SelectedValue);
                OptionUnit = Convert.ToDouble(tbxUnit.Text);
                OptionDate = dtpDate.Value;
            }
            else
            {
                diseaseMedicineTableAdapter.Update(farmManageDataSet.DiseaseMedicine);
            }
            DialogResult = System.Windows.Forms.DialogResult.Yes;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.No;
        }

        private void DiseaseMedicineForm_Load(object sender, EventArgs e)
        {
            this.stockTableAdapter.Fill(farmManageDataSet.Stock);
            this.usersViewTableAdapter.Fill(farmManageDataSet.UsersView);

            if (DiseaseMedicineID == 0)
            {
                tcMain.TabPages.Remove(tabRecord);
            }
            else
            {
                if (!MainForm.User.SuperUser)
                {
                    this.tcMain.TabPages.Remove(tabRecord);
                }
                else
                {
                    this.userLogUC.FillEvent(TypeUtil.DiseaseMedicine, DiseaseMedicineID.ToString());
                }
                this.diseaseMedicineTableAdapter.FillByPK(farmManageDataSet.DiseaseMedicine, DiseaseMedicineID);
                this.userLogUC.FillEvent(TypeUtil.DiseaseMedicine, DiseaseMedicineID.ToString());
            }
        }

        private void tbxUnit_KeyPress(object sender, KeyPressEventArgs e)
        {
            KeyPressUtil.Double(tbxUnit, e);
        }

        private void cbxStock_Validating(object sender, CancelEventArgs e)
        {
            ValidatingUtil.Validating(cbxStock, cbxStock.SelectedValue == null, e);
        }

        private void tbxUnit_Validating(object sender, CancelEventArgs e)
        {
            if (tbxUnit.Text == null)
            {
                e.Cancel = true;
            }
            else
            {
                ValidatingUtil.Validating(tbxUnit, Convert.ToDouble(tbxUnit.Text) == 0, e);
            }
        }
    }
}

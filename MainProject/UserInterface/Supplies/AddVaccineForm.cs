using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using MainProject.Util;
using System.Text;
using MainProject.Database.FarmManageDataSetTableAdapters;

namespace MainProject.UserInterface.Supplies
{
    public partial class AddVaccineForm : Form
    {
        public Int32 VaccineID { get; set; }
        public String CowNO { get; set; }



        public Boolean Option { get; set; }
        public Int32 OptionStockID { get; set; }
        public Int32 OptionByID { get; set; }
        public Double OptionUnit { get; set; }
        public DateTime OptionDate { get; set; }

        public AddVaccineForm()
        {
            InitializeComponent();
        }

        private void AddVaccineForm_Load(object sender, EventArgs e)
        {
            this.cowTableAdapter.Fill(farmManageDataSet.Cow);
            this.stockTableAdapter.FillByType(farmManageDataSet.Stock, 2);
            this.usersViewTableAdapter.Fill(farmManageDataSet.UsersView);


            if (CowNO != null)
            {
                this.cbxCow.SelectedValue = CowNO;
                this.cbxCow.Enabled = false;
            }

            if (Option)
            {
                this.cbxCow.Visible = false;
                this.lblCow.Visible = false;
                this.tcMain.TabPages.Remove(tabRecord);
            }

            

            if (VaccineID > 0)
            {
                this.vaccineTableAdapter.FillByPK(farmManageDataSet.Vaccine, VaccineID);
                this.cbxBy.Enabled = false;
                this.cbxCow.Enabled = false;
                this.cbxStock.Enabled = false;
                this.tbxUnit.ReadOnly = true;
                this.dtpDate.Enabled = false;
                this.btnSave.Visible = false;
                this.btnCancel.Text = "ปิด";

                if (MainForm.User.SuperUser)
                {
                    this.userLogUC.FillEvent(TypeUtil.Vaccine, VaccineID.ToString());
                }
                else
                {
                    this.tcMain.TabPages.Remove(tabRecord);
                }
            }
            else
            {
                this.Text = "การฉีดวัคซีน";
                this.lblTitle.Text = this.Text;
                this.tcMain.TabPages.Remove(this.tabRecord);

                this.dtpDate.MaxDate = DateTime.Now;
                this.cbxBy.SelectedValue = MainForm.User.UserID;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren())
                return;

            if (Option)
            {
                OptionByID = Convert.ToInt32(cbxBy.SelectedValue);
                OptionStockID = Convert.ToInt32(cbxStock.SelectedValue);
                OptionUnit = Convert.ToDouble(tbxUnit.Text);
                OptionDate = this.dtpDate.Value;
                this.DialogResult = System.Windows.Forms.DialogResult.Yes;
            }
            else
            {
                var Msg = new StringBuilder();
                var CurrentUnit = this.stockTableAdapter.QueryCurrentUnit(Convert.ToInt32(cbxStock.SelectedValue));
                if (CurrentUnit < Convert.ToDouble(tbxUnit.Text))
                {
                    Msg.Append(String.Format("{0} จำนวนปัจจุบัน:{1} จำนวนที่ต้องการ:{2}\n", stockTableAdapter.GetDataByPK(Convert.ToInt32(cbxStock.SelectedValue))[0].Name, CurrentUnit, Convert.ToDouble(tbxUnit.Text)));
                }

                if (Msg.Length != 0)
                {
                    MessageBox.Show(String.Format("พัสดุไม่พอ \n{0}\n กรุณาลองใหม่อีกครั้ง", Msg), "ข้อผิดผลาด", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    int VaccineID = (int)this.vaccineTableAdapter.InsertQuery(
                        Convert.ToInt32(cbxBy.SelectedValue),
                        cbxCow.SelectedValue.ToString(),
                        Convert.ToInt32(cbxStock.SelectedValue),
                        Convert.ToDouble(tbxUnit.Text),
                        dtpDate.Value);
                    

                    if (VaccineID > 0)
                    {
                        var log = new UserLogTableAdapter();
                        log.Insert(TypeUtil.Vaccine, VaccineID.ToString(), MainForm.User.UserID, TypeUtil.EVENT_CREATE, DateTime.Now);

                        this.stockTableAdapter.UpdateRemoveUnit(Convert.ToDouble(tbxUnit.Text), Convert.ToInt32(cbxStock.SelectedValue));
                        this.DialogResult = DialogUtil.AddSuccess();
                    }
                    else
                    {
                        this.DialogResult = DialogUtil.AddError();
                    }
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.No;
        }

        private void tbxUnit_KeyPress(object sender, KeyPressEventArgs e)
        {
            KeyPressUtil.Double(tbxUnit, e);
        }

        private void tbxUnit_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            ValidatingUtil.Validating(tbxUnit, Convert.ToDouble(tbxUnit.Text) == 0, "ต้องมากกว่า 0", e);
        }

        private void tbxUnit_KeyUp(object sender, KeyEventArgs e)
        {
            this.tbxUnit.Text = this.tbxUnit.Text.Trim().Length == 0 ? "0" : tbxUnit.Text;
        }
    }
}

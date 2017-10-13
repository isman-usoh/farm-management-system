using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using MainProject.Util;
using MainProject.Database.FarmManageDataSetTableAdapters;

namespace MainProject.UserInterface.Supplies
{
    public partial class NewStockForm : Form
    {
        public Int32 StockID { get; set; }

        public NewStockForm()
        {
            InitializeComponent();
        }

        private void NewStockForm_Load(object sender, EventArgs e)
        {
            cbxSuppliesType.ValueMember = "Key";
            cbxSuppliesType.DisplayMember = "Value";
            cbxSuppliesType.DataSource = TypeUtil.StockType().ToList();

            if (StockID != 0)
            {
                this.lblTitle.Text = "แก้ไขรายการพัสดุ";
                this.Text = this.lblTitle.Text;
                this.stockTableAdapter.FillByPK(farmManageDataSet.Stock, StockID);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                return;
            }

            if (StockID != 0)
            {
                this.Validate();
                this.stockBindingSource.EndEdit();
                if (1 == stockTableAdapter.Update(farmManageDataSet.Stock))
                {
                    var log = new UserLogTableAdapter();
                    log.Insert(TypeUtil.Stock, StockID.ToString(), MainForm.User.UserID, TypeUtil.EVENT_CREATE, DateTime.Now);


                    DialogResult = DialogUtil.SaveSuccess();
                }
                else
                {
                    DialogResult = DialogUtil.SaveError();
                }
            }
            else
            {
                StockID = (int)stockTableAdapter.InsertQuery(tbxSuppliesName.Text, Convert.ToDouble(tbxUnit.Text), Convert.ToByte(cbxSuppliesType.SelectedValue), tbxDescription.Text);

                if (StockID > 0)
                {
                    var log = new UserLogTableAdapter();
                    log.Insert(TypeUtil.Stock, StockID.ToString(), MainForm.User.UserID, 0, DateTime.Now);

                    DialogResult = DialogUtil.AddSuccess();
                }
                else
                {
                    DialogResult = DialogUtil.AddError();
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.No;
        }

        private void tbxSuppliesName_Validating(object sender, CancelEventArgs e)
        {
            ValidatingUtil.Validating(tbxSuppliesName, tbxSuppliesName.Text.Length == 0, e);
        }

        private void cbxSuppliesType_Validating(object sender, CancelEventArgs e)
        {
            ValidatingUtil.Validating(cbxSuppliesType, cbxSuppliesType.SelectedValue == null, e);
        }
    }
}

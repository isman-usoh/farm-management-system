using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using MainProject.Util;

namespace MainProject.UserInterface.Order
{
    public partial class AddCowOrderInForm : Form
    {
        public OrderInWizardForm OrderInWizard { get; set; }
        public AddBornForm AddBorn { get; set; }
        public Boolean IsBorn { get; set; }


        public Int32 CorralID { get; set; }
        public Int32 GeneID { get; set; }
        public Byte SexID { get; set; }
        public Int32 Count { get; set; }
        public Double Amount { get; set; }


        public AddCowOrderInForm()
        {
            InitializeComponent();
        }

        private void initialCorralFree()
        {
            var free = corralTableAdapter.CheckFree(Convert.ToInt32(cbxCorral.SelectedValue));
            if (this.IsBorn)
            {
                lblCorralFreeValue.Text = (free.Value - AddBorn.CorralCount(Convert.ToInt32(cbxCorral.SelectedValue))).ToString();
            }
            else
            {
                lblCorralFreeValue.Text = (free.Value - OrderInWizard.CorralCount(Convert.ToInt32(cbxCorral.SelectedValue))).ToString();
            }

            free = Convert.ToInt32(lblCorralFreeValue.Text);
            if (free == 0)
            {
                this.tbxCount.Text = "0";
                this.tbxCount.ReadOnly = true;
            }
            else
            {
                this.tbxCount.Text = "1";
                this.tbxCount.ReadOnly = false;
            }
        }

        private void AddCowOrderInForm_Load(object sender, EventArgs e)
        {
            if (this.IsBorn)
            {
                this.Text = "เพิ่มรายการโคเกิด";
                this.lblTitle.Text = this.Text;
                this.tbxAmount.Visible = false;
                this.lblAmount.Visible = false;
            }

            this.corralTableAdapter.Fill(farmManageDataSet.Corral);
            this.geneTableAdapter.Fill(farmManageDataSet.Gene);
            this.cbxSex.DataSource = TypeUtil.CowSex().ToList();


            this.initialCorralFree();
        }

        private void tbxCount_KeyPress(object sender, KeyPressEventArgs e)
        {
            KeyPressUtil.Int(tbxCount, e);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (0 == Convert.ToInt32(tbxCount.Text))
            {
                MessageBox.Show("ไม่สามารถเพิ่มได้ กรุณาเพิ่มจำนวนมากกว่าหนึ่ง", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            CorralID = Convert.ToInt32(cbxCorral.SelectedValue);
            GeneID = Convert.ToInt32(cbxGene.SelectedValue);
            SexID = Convert.ToByte(cbxSex.SelectedValue);
            Amount = Convert.ToDouble(tbxAmount.Text);
            Count = Convert.ToInt32(tbxCount.Text);
            DialogResult = System.Windows.Forms.DialogResult.Yes;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.No;
        }

        private void tbxAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            KeyPressUtil.Double(tbxAmount, e);
        }

        private void tbxCount_KeyUp(object sender, KeyEventArgs e)
        {
            if (tbxCount.Text.Trim().Length == 0)
            {
                tbxCount.Text = "0";
            }
            if (Convert.ToInt32(tbxCount.Text) > Convert.ToInt32(lblCorralFreeValue.Text))
            {
                MessageBox.Show("คุณป้อนเกินความจุของคอก กรุณาป้อนใหม่อีกครั้ง", "ข้อผิดผลาด", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbxCount.Text = lblCorralFreeValue.Text;
            }
        }

        private void cbxCorral_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.initialCorralFree();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using MainProject.Database;
using MainProject.UserInterface.User;
using MainProject.UserInterface.Cow;
using MainProject.UserInterface.Order;
using MainProject.Util;
using MainProject.UserInterface.Setting;
using MainProject.Properties;
using System.IO;
using MainProject.UserInterface.FormsDialog;

namespace MainProject.UserInterface
{
    public partial class MainForm : Form
    {
        public static MainProject.Database.FarmManageDataSet.UsersRow User { get; set; }
        
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            var start = new StartForm();
            if (start.ShowDialog() == System.Windows.Forms.DialogResult.No)
            {
                this.Close();
            }


            // TODO: This line of code loads data into the 'farmManageDataSet.OrderInStatic' table. You can move, or remove it, as needed.
            this.orderInStaticTableAdapter.Fill(this.farmManageDataSet.OrderInStatic);
            // TODO: This line of code loads data into the 'farmManageDataSet.OrderOutStatic' table. You can move, or remove it, as needed.
            this.orderOutStaticTableAdapter.Fill(this.farmManageDataSet.OrderOutStatic);
            // TODO: This line of code loads data into the 'farmManageDataSet.CowStatic' table. You can move, or remove it, as needed.
            this.cowStaticTableAdapter.Fill(this.farmManageDataSet.CowStatic);




            colCowSex.ValueMember = "Key";
            colCowSex.DisplayMember = "Value";
            colCowSex.DataSource = TypeUtil.CowSex().ToList();


            var corralList = new SortedDictionary<Int32, String>();
            corralList.Add(-1, "ทั้งหมด");
            foreach (FarmManageDataSet.CorralRow row in corralTableAdapter.GetData())
            {
                corralList.Add(row.CorralID, row.Name);
            }
            cbxCorral.ValueMember = "Key";
            cbxCorral.DisplayMember = "Value";
            cbxCorral.DataSource = corralList.ToList();


            var geneList = new SortedDictionary<Int32, String>();
            geneList.Add(-1, "ทั้งหมด");
            foreach (FarmManageDataSet.GeneRow row in geneTableAdapter.GetData())
            {
                geneList.Add(row.GeneID, row.Name);
            }
            cbxGene.ValueMember = "Key";
            cbxGene.DisplayMember = "Value";
            cbxGene.DataSource = geneList.ToList();



            corralTableAdapter.Fill(farmManageDataSet.Corral);
            geneTableAdapter.Fill(farmManageDataSet.Gene);
            initSearch();

            var timer = new Timer();
            timer.Tick += new EventHandler(timer_Tick);
            timer.Start();

            

            var login = new UserLoginForm();
            if (login.ShowDialog() == System.Windows.Forms.DialogResult.Yes)
            {
                tsmiCurrentUser.Text = String.Format("ลงชื่อเข้าใช้โดย {0} {1}", User.Firstname, User.Lastname);
                tsmiManage.Visible = User.SuperUser;
                tsmiBackupItem.Visible = false;
                Show();
            }
            else
            {
                Close();
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToLongTimeString();
            lblDate.Text = DateTime.Now.ToLongDateString();
        }

        private void tsmiLogOutItem_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("คุณต้องการออกจากระบบใช้หรือไม่", "ออกจากระบบ", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                Hide();
                User = null;
                var login = new UserLoginForm();
                if (login.ShowDialog() == System.Windows.Forms.DialogResult.Yes)
                {
                    tsmiManage.Visible = User.SuperUser;
                    Show();
                }
                else
                {
                    Close();
                }
            }
        }

        private void tsmiExitItem_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("คุณต้องการปิดโปรแกรมใช้หรือไม่", "ปิดโปรแกรม", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                Close();
            }
        }

        private void tsmiUserDetailItem_Click(object sender, EventArgs e)
        {
            var user = new UserDetailForm();
            user.UserID = User.UserID;
            user.ShowDialog();
        }

        private void tsmiUserPasswordItem_Click(object sender, EventArgs e)
        {
            var form = new ChangePassForm();
            form.UserID = User.UserID;
            form.ShowDialog();
        }

        private void tsmiCorralItem_Click(object sender, EventArgs e)
        {
            var form = new Corral.CorralManageForm();
            form.ShowDialog();
			
			corralTableAdapter.Fill(farmManageDataSet.Corral);
            var corralList = new SortedDictionary<Int32, String>();
            corralList.Add(-1, "ทั้งหมด");
            foreach (FarmManageDataSet.CorralRow row in corralTableAdapter.GetData())
            {
                corralList.Add(row.CorralID, row.Name);
            }
            cbxCorral.DataSource = corralList.ToList();
        }

        private void tsmiGeneItem_Click(object sender, EventArgs e)
        {
            var form = new Gene.GeneManageForm();
            form.ShowDialog();

			geneTableAdapter.Fill(farmManageDataSet.Gene);
            var geneList = new SortedDictionary<Int32, String>();
            geneList.Add(-1, "ทั้งหมด");
            foreach (FarmManageDataSet.GeneRow row in geneTableAdapter.GetData())
            {
                geneList.Add(row.GeneID, row.Name);
            }
            cbxGene.DataSource = geneList.ToList();
        }

        private void tmsiSuppliesItem_Click(object sender, EventArgs e)
        {
            var form = new Supplies.StockManageForm();
            form.ShowDialog();
        }

        private void tsmiCustomerItem_Click(object sender, EventArgs e)
        {
            var form = new Customer.CustomerManageForm();
            form.ShowDialog();
        }

        private void tmsiOrderItem_Click(object sender, EventArgs e)
        {
            var form = new Order.OrderManageForm();
            form.ShowDialog();
        }

        private void tsmiUserItem_Click(object sender, EventArgs e)
        {
            var form = new UserManageForm();
            form.ShowDialog();
        }

        private void tsmiRecipesItem_Click(object sender, EventArgs e)
        {
            var form = new Recipes.RecipesManageForm();
            form.ShowDialog();
        }

        private void tsmiFarmDetailItem_Click(object sender, EventArgs e)
        {
            var form = new Setting.InformationSettingForm();
            form.ShowDialog();
        }

        private void tsmiSettingItem_Click(object sender, EventArgs e)
        {
            var form = new Setting.DatabaseSettingForm();
            form.ShowDialog();
        }

        private void tsmiHelpItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ยังไม่มีข้อมูลช่วยเหลือ", "ข้อผิดผลาด", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void tsmiAboutItem_Click(object sender, EventArgs e)
        {
            var about = new AboutForm();
            about.ShowDialog();
        }

        private void cbxFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            initSearch();
        }


        private void initSearch()
        {
            if (chxAllShow.Checked)
            {
                cowTableAdapter.FillBySearchAll(farmManageDataSet.Cow, Convert.ToInt32(cbxCorral.SelectedValue), Convert.ToInt32(cbxGene.SelectedValue), -1, tbxSearch.Text);
            }
            else
            {
                cowTableAdapter.FillBySearchCurrent(farmManageDataSet.Cow, Convert.ToInt32(cbxCorral.SelectedValue), Convert.ToInt32(cbxGene.SelectedValue), -1, tbxSearch.Text);
            }
        }

        private void btnSearchGo_Click(object sender, EventArgs e)
        {
            initSearch();
        }

        private void tbxSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (Char)13)
            {
                initSearch();
            }
        }

        private void dgvGrid_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }
            var form = new CowDetailForm();
            form.CowNO = ((DataRowView)cowBindingSource[e.RowIndex]).Row["CowNO"].ToString();
            var result = form.ShowDialog();
            if (DialogResult.Yes == result)
            {
                initSearch();
            }
        }

        private void btnBuy_Click(object sender, EventArgs e)
        {
            var form = new OrderInWizardForm();
            var result = form.ShowDialog();
            this.initSearch();

            this.orderInStaticTableAdapter.Fill(this.farmManageDataSet.OrderInStatic);
            this.orderOutStaticTableAdapter.Fill(this.farmManageDataSet.OrderOutStatic);
            this.cowStaticTableAdapter.Fill(this.farmManageDataSet.CowStatic);
        }

        private void btnSell_Click(object sender, EventArgs e)
        {
            var form = new OrderOutWizardForm();
            var result = form.ShowDialog();
            this.initSearch();

            this.orderInStaticTableAdapter.Fill(this.farmManageDataSet.OrderInStatic);
            this.orderOutStaticTableAdapter.Fill(this.farmManageDataSet.OrderOutStatic);
            this.cowStaticTableAdapter.Fill(this.farmManageDataSet.CowStatic);
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            var form = new Customer.CustomerManageForm();
            form.ShowDialog();
        }

        private void btnStock_Click(object sender, EventArgs e)
        {
            var form = new Supplies.StockManageForm();
            form.ShowDialog();
        }

        private void tsmiFormat_Click(object sender, EventArgs e)
        {
            var form = new SettingForm();
            form.ShowDialog();
        }

        private void tsmiStatic_Click(object sender, EventArgs e)
        {
            var form = new Static.StaticForm();
            form.ShowDialog();
        }

        private void tsmiCowPrice_Click(object sender, EventArgs e)
        {
            var form = new Static.CowPriceStaticForm();
            form.ShowDialog();
        }

        private void btnOrderManage_Click(object sender, EventArgs e)
        {
            var form = new OrderManageForm();
            form.ShowDialog();
        }

        private void tsmiOtherOrderMgn_Click(object sender, EventArgs e)
        {
            var form = new OtherOrderManageForm();
            form.ShowDialog();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            SelectFormForm form = new SelectFormForm();
            form.ShowDialog();
        }

        private void tsmiBackupItem_Click(object sender, EventArgs e)
        {
            BackUpForm form = new BackUpForm();
            form.ShowDialog();
        }
    }
}

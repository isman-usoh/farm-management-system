using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace MainProject.UserInterface.Static
{
    public partial class StaticForm : Form
    {
        public StaticForm()
        {
            InitializeComponent();
        }

        private void StaticForm_Load(object sender, EventArgs e)
        {
            orderInStaticTableAdapter.Fill(farmManageDataSet1.OrderInStatic);
            orderOutStaticTableAdapter.Fill(farmManageDataSet.OrderOutStatic);
            customerStaticTableAdapter.Fill(farmManageDataSet.CustomerStatic);
            geneStaticTableAdapter.Fill(farmManageDataSet.GeneStatic);
            cowStaticTableAdapter.Fill(farmManageDataSet.CowStatic);
            userStaticTableAdapter.Fill(farmManageDataSet.UserStatic);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.No;
        }

        private void tableLayoutPanel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

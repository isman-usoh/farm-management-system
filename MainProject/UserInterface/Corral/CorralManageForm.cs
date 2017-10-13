using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace MainProject.UserInterface.Corral
{
    public partial class CorralManageForm : Form
    {
        public CorralManageForm()
        {
            InitializeComponent();
        }

        private void CorralManageForm_Load(object sender, EventArgs e)
        {
            corralTableAdapter.Fill(farmManageDataSet.Corral);
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            var form = new AddCorralForm();
            var result = form.ShowDialog();
            if (result == DialogResult.Yes)
            {
                corralTableAdapter.Fill(farmManageDataSet.Corral);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.No;
        }

        private void dgvList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }
            var form = new AddCorralForm();
            form.CorralID = Convert.ToInt32(((DataRowView)corralBindingSource[e.RowIndex]).Row[0]);
            var result = form.ShowDialog();
            if (DialogResult.Yes == result)
            {
                corralTableAdapter.Fill(farmManageDataSet.Corral);
            }
        }

        private void dgvList_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }
            var form = new AddCorralForm();
            form.CorralID = Convert.ToInt32(((DataRowView)corralBindingSource[e.RowIndex]).Row[0]);
            var result = form.ShowDialog();
            if (DialogResult.Yes == result)
            {
                corralTableAdapter.Fill(farmManageDataSet.Corral);
            }
        }
    }
}

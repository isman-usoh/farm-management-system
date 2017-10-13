using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace MainProject.UserInterface.Gene
{
    public partial class GeneManageForm : Form
    {
        public GeneManageForm()
        {
            InitializeComponent();
        }

        private void GeneManageForm_Load(object sender, EventArgs e)
        {
            this.geneTableAdapter.Fill(this.farmManageDataSet.Gene);
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            AddGeneForm form = new AddGeneForm();
            form.GeneID = 0;
            if (DialogResult.Yes == form.ShowDialog())
                this.geneTableAdapter.Fill(this.farmManageDataSet.Gene);
        }

        private void dgvGrid_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }
            AddGeneForm form = new AddGeneForm();
            form.GeneID =  Convert.ToInt32(((DataRowView)geneBindingSource[e.RowIndex]).Row[0]);
            if (DialogResult.Yes == form.ShowDialog())
                this.geneTableAdapter.Fill(this.farmManageDataSet.Gene);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.No;
        }
    }
}

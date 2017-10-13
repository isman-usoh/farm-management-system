using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace MainProject.UserInterface.Recipes
{
    public partial class RecipesManageForm : Form
    {
        public RecipesManageForm()
        {
            InitializeComponent();
        }

        private void RecipesManageForm_Load(object sender, EventArgs e)
        {
            stockTableAdapter.Fill(farmManageDataSet.Stock);
            usersViewTableAdapter.Fill(farmManageDataSet.UsersView);
            recipesHistoryTableAdapter.Fill(farmManageDataSet.RecipesHistory);
            recipesTableAdapter.Fill(farmManageDataSet.Recipes);
        }

        private void dgvRecipseHistory_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var form = new RecipesCalculateDetailForm();
            form.RecipesHistoryID = Convert.ToInt32(((DataRowView)recipesHistoryBindingSource[e.RowIndex]).Row[0]);
            var result = form.ShowDialog();
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                recipesHistoryTableAdapter.Fill(farmManageDataSet.RecipesHistory);
            }
        }

        private void dgvRecipse_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }
            var form = new AddRecipesForm();
            form.RecipesID = Convert.ToInt32(((DataRowView)recipesBindingSource[e.RowIndex]).Row[0]);
            var result = form.ShowDialog();
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                recipesTableAdapter.Fill(farmManageDataSet.Recipes);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.No;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddRecipesForm form = new AddRecipesForm();
            form.RecipesID = 0;
            var result = form.ShowDialog();
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                recipesTableAdapter.Fill(farmManageDataSet.Recipes);
            }
        }

        private void btnSubStock_Click(object sender, EventArgs e)
        {
            var form = new RecipesCalculateForm();
            var result = form.ShowDialog();
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                recipesHistoryTableAdapter.Fill(farmManageDataSet.RecipesHistory);
            }
        }
    }
}

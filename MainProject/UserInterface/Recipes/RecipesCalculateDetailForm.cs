using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using MainProject.Util;

namespace MainProject.UserInterface.Recipes
{
    public partial class RecipesCalculateDetailForm : Form
    {
        public Int32 RecipesHistoryID { get; set; }

        public RecipesCalculateDetailForm()
        {
            InitializeComponent();
        }

        private void RecipesCalculateDetailForm_Load(object sender, EventArgs e)
        {
            this.stockTableAdapter.Fill(farmManageDataSet.Stock);
            this.recipesTableAdapter.Fill(farmManageDataSet.Recipes);
            this.usersViewTableAdapter.Fill(farmManageDataSet.UsersView);
            this.recipesListHistoryTableAdapter.Fill(farmManageDataSet.RecipesListHistory);
            this.recipesHistoryTableAdapter.FillByPK(farmManageDataSet.RecipesHistory, RecipesHistoryID);

            

            if (RecipesHistoryID == 0)
            {
                this.dtpDate.MaxDate = DateTime.Now;
                this.cbxBy.SelectedValue = MainForm.User.UserID;
                this.tclMain.TabPages.Remove(tabRecord);
            }
            else
            {
                if (MainForm.User.SuperUser)
                {
                    userLogUC.FillEvent(TypeUtil.RecipesHistory, RecipesHistoryID.ToString());
                }
                else
                {
                    tclMain.TabPages.Remove(tabRecord);
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.No;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MainProject.Report;

namespace MainProject.UserInterface.FormsDialog
{
    public partial class SelectFormForm : System.Windows.Forms.Form
    {
        public SelectFormForm()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.No;
        }

        private void btnForm1_Click(object sender, EventArgs e)
        {
            VaccineBillForm form = new VaccineBillForm();
            this.DialogResult = form.ShowDialog();
        }

        private void btnForm2_Click(object sender, EventArgs e)
        {
            RemoveBillForm form = new RemoveBillForm();
            this.DialogResult = form.ShowDialog();
        }
    }
}

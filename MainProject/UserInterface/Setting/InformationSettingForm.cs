using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using MainProject.Properties;

namespace MainProject.UserInterface.Setting
{
    public partial class InformationSettingForm : Form
    {
        public InformationSettingForm()
        {
            InitializeComponent();
        }

        private void InformationSettingForm_Load(object sender, EventArgs e)
        {
            tbxFarmName.Text = Settings.Default.infoFarmName;
            tbxCompany.Text = Settings.Default.infoCompany;
            tbxFName.Text = Settings.Default.infoFName;
            tbxLName.Text = Settings.Default.infoLName;
            tbxAddress.Text = Settings.Default.infoAddres;
            tbxCity.Text = Settings.Default.infoCity;
            tbxDistrict.Text = Settings.Default.infoDistrict;
            tbxProvince.Text = Settings.Default.infoProvince;
            tbxCountry.Text = Settings.Default.infoCountry;
            tbxTel.Text = Settings.Default.infoTel;
            tbxMobile.Text = Settings.Default.infoMobile;
            tbxFax.Text = Settings.Default.infoFax;
            tbxEmail.Text = Settings.Default.infoEmail;
            tbxWesite.Text = Settings.Default.infoWebsite;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.No;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Settings.Default.infoFarmName = tbxFarmName.Text;
            Settings.Default.infoCompany = tbxCompany.Text;
            Settings.Default.infoFName = tbxFName.Text;
            Settings.Default.infoLName = tbxLName.Text;
            Settings.Default.infoAddres = tbxAddress.Text;
            Settings.Default.infoCity = tbxCity.Text;
            Settings.Default.infoDistrict = tbxDistrict.Text;
            Settings.Default.infoProvince = tbxProvince.Text;
            Settings.Default.infoCountry = tbxCountry.Text;
            Settings.Default.infoTel = tbxTel.Text;
            Settings.Default.infoMobile = tbxMobile.Text;
            Settings.Default.infoFax = tbxFax.Text;
            Settings.Default.infoEmail = tbxEmail.Text;
            Settings.Default.infoWebsite = tbxWesite.Text;
            Settings.Default.Save();
            DialogResult = DialogResult.Yes;
        }
    }
}

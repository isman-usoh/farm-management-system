using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Globalization;
using MainProject.Properties;

namespace MainProject.UserInterface.Setting
{
    public partial class SettingForm : Form
    {
        public SettingForm()
        {
            InitializeComponent();
        }

        private void SettingForm_Load(object sender, EventArgs e)
        {
            var format = new SortedDictionary<String, String>();
            format.Add("th-TH", "ไทย");
            format.Add("en-US", "English");

            this.cbxFormat.ValueMember = "Key";
            this.cbxFormat.DisplayMember = "Value";
            this.cbxFormat.DataSource = format.ToList();
            this.cbxFormat.SelectedValue = Settings.Default.infoFormat;
            tbxPath.Text = Settings.Default.infoPath;

            if (!MainForm.User.SuperUser)
            {
                btnChangePath.Enabled = false;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Settings.Default.infoFormat = cbxFormat.SelectedValue.ToString();
            Settings.Default.Save();
            var cInfo = CultureInfo.GetCultureInfo(Settings.Default.infoFormat);
            System.Threading.Thread.CurrentThread.CurrentCulture = cInfo;
            System.Threading.Thread.CurrentThread.CurrentUICulture = cInfo;
            Application.CurrentCulture = cInfo;
            DialogResult = System.Windows.Forms.DialogResult.Yes;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.No;
        }
    }
}

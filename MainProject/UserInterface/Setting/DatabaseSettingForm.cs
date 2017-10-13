using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using MainProject.Util;
using System.Data.Common;
using MainProject.Database;
using System.IO;
using MainProject.Properties;
using System.Security.Permissions;

namespace MainProject.UserInterface.Setting
{
    public partial class DatabaseSettingForm : Form
    {
        private Boolean isChackInstance = true;
        public Boolean isLoad = true;
        private Boolean isFirstLoadInstance = true;

        private String StringFormat = @"{0}{1}{2}{3}Integrated Security={4}; Connect Timeout=30; User Instance=True;";

        public DatabaseSettingForm()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.No;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            pnlMain.Enabled = false;
            btnTest.Enabled = false;
            try
            {
                var provider = "System.Data.SqlClient";
                var factory = DbProviderFactories.GetFactory(provider);
                using (var conn = factory.CreateConnection())
                {
                    conn.ConnectionString = getConnectionString();
                    conn.Open();
                    conn.Close();

                    Settings.Default.dbInstance = cbxServerName.Text;
                    Settings.Default.dbWinAuth = rdoWinAuth.Checked;
                    rdoSQLAuth.Checked = !rdoWinAuth.Checked;

                    Settings.Default.dbUsername = tbxUsername.Text;
                    Settings.Default.dbPassword = tbxPassword.Text;

                    Settings.Default.dbName = tbxFilePath.Text;
                    Settings.Default["FarmManageDatabaseConnectionString"] = getConnectionString();
                    Settings.Default.Save();
                    DialogResult = System.Windows.Forms.DialogResult.Yes;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ไม่สามารถบันทึกการเปลี่ยนแปลงการเชื่อมต่อฐานข้อมูล"+Environment.NewLine+ex.Data, ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbxFilePath.Enabled = false;
                DialogResult = System.Windows.Forms.DialogResult.No;
            }
            finally
            {
                pnlMain.Enabled = true;
                btnTest.Enabled = true;
            }
            Cursor.Current = Cursors.Default;
        }

        private void initaialComponent()
        {
            if (cbxServerName.Text.Trim().Length != 0)
            {
                pnlLogonContent.Enabled = true;
                pnlConnectContent.Enabled = true;

                tbxUsername.Enabled = rdoSQLAuth.Checked;
                tbxPassword.Enabled = rdoSQLAuth.Checked;
            }
            else
            {
                pnlConnectContent.Enabled = false;
                pnlLogonContent.Enabled = false;
            }
        }

        private void loadServerInstance()
        {
            if (isChackInstance)
            {
                btnTest.Enabled = false;
                pnlMain.Enabled = false;
                this.Cursor = Cursors.AppStarting;
                var instance = SQLServerHelper.EnumerateServers();
                if (instance != null)
                {
                    cbxServerName.Items.Clear();
                    cbxServerName.Items.AddRange(instance.ToArray());
                    isChackInstance = false;
                }
                btnTest.Enabled = true;
                pnlMain.Enabled = true;
                Cursor = Cursors.Default;
            }
        }

        private void btnBrowser_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyComputer);
            openFileDialog1.Filter = "SQL Database File (*.mdf)|*.mdf";
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                tbxFilePath.Text = openFileDialog1.FileName;
            }
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            if (!File.Exists(tbxFilePath.Text))
            {
                MessageBox.Show("ไม่พบไฟล์ที่ระบุ, กรุณาลองใหม่อีกครั้ง", "ไม่พบไฟล์", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            this.Cursor = Cursors.WaitCursor;
            btnTest.Enabled = false;
            pnlMain.Enabled = false;
            try
            {
                var provider = "System.Data.SqlClient";
                var factory = DbProviderFactories.GetFactory(provider);
                using (var conn = factory.CreateConnection())
                {
                    conn.ConnectionString = getConnectionString();
                    conn.Open();
                    conn.Close();
                    MessageBox.Show("Test connection succeeded.", "Farm Manage System", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tbxFilePath.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Data.Count + string.Empty, "ข้อผิดผลาด", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbxFilePath.Enabled = false;
            }
            finally
            {
                pnlMain.Enabled = true;
                btnTest.Enabled = true;
            }

            this.Cursor = Cursors.Default;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            isChackInstance = true;
            loadServerInstance();
        }

        private void cbxServerName_SelectedIndexChanged(object sender, EventArgs e)
        {
            initaialComponent();
        }

        private void cbxServerName_DropDown(object sender, EventArgs e)
        {
            if (isFirstLoadInstance)
            {
                loadServerInstance();
                isFirstLoadInstance = false;
            }
        }

        private void DatabaseSettingForm_Load(object sender, EventArgs e)
        {
            if (isLoad)
            {
                cbxServerName.Text = Settings.Default.dbInstance;
                rdoWinAuth.Checked = Settings.Default.dbWinAuth;
                rdoSQLAuth.Checked = !rdoWinAuth.Checked;

                tbxUsername.Text = Settings.Default.dbUsername;
                tbxPassword.Text = Settings.Default.dbPassword;
                tbxFilePath.Text = Settings.Default.dbName;
            }
            initaialComponent();
        }

        private void cbxServerName_TextChanged(object sender, EventArgs e)
        {
            initaialComponent();
        }

        private void rdoWinAuth_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoWinAuth.Checked)
            {
                tbxUsername.Enabled = false;
                tbxPassword.Enabled = false;
                tbxUsername.Text = String.Empty;
                tbxPassword.Text = String.Empty;
            }
            else
            {
                tbxUsername.Enabled = true;
                tbxPassword.Enabled = true;
                tbxUsername.Text = Settings.Default.dbUsername;
                tbxPassword.Text = Settings.Default.dbPassword;
            }
        }


        private String getConnectionString()
        {
            var dbConnectionString = string.Empty;
            var Username = tbxUsername.Text;
            var Password = tbxUsername.Text;
            var Security = "TRUE";

            if (rdoSQLAuth.Checked)
            {
                Username = "UID=" + Username + ";";
                Password = "Password=" + Password + ";";
                Security = "FALSE";
            }
            if (rdoWinAuth.Checked)
            {
                Username = string.Empty;
                Password = string.Empty;
                Security = "TRUE";
            }

            var ConntectString = "AttachDbFilename=" + tbxFilePath.Text + ";";

            dbConnectionString = String.Format(StringFormat, "Data Source=" + cbxServerName.Text + ";", ConntectString, Username, Password, Security);
            return dbConnectionString;
        }
    }
}

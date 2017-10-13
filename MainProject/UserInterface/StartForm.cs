using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Reflection;
using System.Data.Common;
using MainProject.UserInterface.Setting;
using System.Threading;
using MainProject.Properties;
using System.IO;
using MainProject.Util;

namespace MainProject.UserInterface
{
    public partial class StartForm : Form
    {
        Boolean IsDir = false;
        Boolean IsDatabase = false;

        public StartForm()
        {
            InitializeComponent();

            lblName.Text = AssemblyProduct;
            lblVersion.Text = AssemblyVersion;
        }

        public string AssemblyProduct
        {
            get
            {
                var attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyProductAttribute), false);
                if (attributes.Length == 0)
                {
                    return string.Empty;
                }
                return ((AssemblyProductAttribute)attributes[0]).Product;
            }
        }

        public string AssemblyVersion
        {
            get
            {
                return Assembly.GetExecutingAssembly().GetName().Version.ToString();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.No;
        }
        
        private System.Windows.Forms.Timer timer;

        private void StartForm_Load(object sender, EventArgs e)
        {
            timer = new System.Windows.Forms.Timer();
            timer.Tick += new EventHandler(timer_Tick);
            timer.Start();

            lblDebug.Visible = new ModeDetector().IsDebug;
        }

        int sleep = 0;
        private void timer_Tick(object sender, EventArgs e)
        {
            if (IsDir && pgbLoad.Value < 50)
            {
                pgbLoad.Value += 1;
            }
            else if (IsDatabase && pgbLoad.Value < 99)
            {
                pgbLoad.Value += 1;
            }
            else
            {
                if (pgbLoad.Value < 100)
                {
                    pgbLoad.Value += 1;
                }

                if (pgbLoad.Value == 100 && IsDir && IsDatabase)
                {
                    sleep++;
                    if (sleep == 10)
                    {
                        timer.Stop();
                        DialogResult = System.Windows.Forms.DialogResult.Yes;
                    }
                }
            }


            if (pgbLoad.Value == 10 )
            {
                lblLabel.Text = "กำลังตรวจสอบไฟล์ระบบ";
                initialDir();
                pgbLoad.Value = 49;
                IsDir = true;
            }
            else if(pgbLoad.Value == 50)
            {
                lblLabel.Text = "กำลังตรวจสอบการเชื่อมต่อฐานข้อมูล";
                initialDatabase();
                pgbLoad.Value = 99;
                IsDatabase = true;
            }
        }



        private void initialDatabase()
        {
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                var provider = "System.Data.SqlClient";
                var factory = DbProviderFactories.GetFactory(provider);
                using (var conn = factory.CreateConnection())
                {
                    conn.ConnectionString = ConnectString();
                    conn.Open();
                    conn.Close();
                }
            }
            catch
            {
                timer.Stop();
                DialogResult result = MessageBox.Show("ไม่สามารถเชื่อมต่อฐานข้อมูลได้  กด 'Yes' เพิอตั้งค่า กด 'No' เพือปิดโปรแกรท", "ข้อผิดผลาด", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    DatabaseSettingForm form = new DatabaseSettingForm();
                    form.isLoad = false;
                    result = form.ShowDialog();
                    if (DialogResult.No == result)
                    {
                        Application.Exit();
                    }
                    else
                    {
                        pgbLoad.Value = 39;
                        timer.Start();
                    }
                }
                else
                {
                    Application.Exit();
                }
            }
            finally
            {
                Cursor.Current = Cursors.WaitCursor;
            }
            
        }

        public static String CowFileDir = Path.Combine(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "CowManagement"));

        public static String DatabaseDir = Path.Combine(CowFileDir, "Database");

        public static String FileDir = Path.Combine(CowFileDir, "File");

        public static String BackupDir = Path.Combine(CowFileDir, "Backup");

        private static void initialDir()
        {
            if (new ModeDetector().IsDebug && Directory.Exists(CowFileDir))
            {
               // Directory.Delete(CowFileDir, true);
            }



            if (!Directory.Exists(CowFileDir))
            {
                Directory.CreateDirectory(CowFileDir);
            }
            if (Settings.Default.infoPath.Trim().Length == 0)
            {
                Settings.Default.infoPath = Path.Combine(CowFileDir, "File");
                Settings.Default.Save();
            }

            String backupDir = Path.Combine(CowFileDir, "Backup");
             if (!Directory.Exists(backupDir))
                 Directory.CreateDirectory(backupDir);








            String databaseDir = Path.Combine(CowFileDir, "Database");
            if (!Directory.Exists(databaseDir))
                Directory.CreateDirectory(databaseDir);
            if (!Directory.Exists(Settings.Default.infoPath))
                Directory.CreateDirectory(Settings.Default.infoPath);

          
            String dbFile = Path.Combine(databaseDir, "FarmManageDatabase.mdf");
            String dbLogfile = Path.Combine(databaseDir, "FarmManageDatabase_log.ldf");


            if (!File.Exists(dbFile) || Settings.Default.sysFirstLoad)
            {
                String sourceDir = Path.Combine(Environment.CurrentDirectory, "Database");

                if (File.Exists(Path.Combine(databaseDir, "FarmManageDatabase_log.ldf")))
                    File.Delete(Path.Combine(databaseDir, "FarmManageDatabase_log.ldf"));

                if (File.Exists(Path.Combine(databaseDir, "FarmManageDatabase.mdf")))
                    File.Delete(Path.Combine(databaseDir, "FarmManageDatabase.mdf"));

                File.Copy(Path.Combine(sourceDir, "FarmManageDatabase.mdf"), dbFile);
                File.Copy(Path.Combine(sourceDir, "FarmManageDatabase_log.ldf"), dbLogfile);


                Settings.Default.sysFirstLoad = false;
                Settings.Default.dbInstance = ".\\SQLEXPRESS";
                Settings.Default.dbWinAuth = true;
                Settings.Default.dbUsername = String.Empty;
                Settings.Default.dbPassword = String.Empty;
                Settings.Default.dbName = dbFile;
                Settings.Default.Save();


                Settings.Default["FarmManageDatabaseConnectionString"] = ConnectString();
                Settings.Default.Save();
            }
        }

        public static String ConnectString()
        {
            var dbConnectionString = string.Empty;
            var Username = Settings.Default.dbUsername;
            var Password = Settings.Default.dbPassword;
            var Security = "TRUE";

            if (!Settings.Default.dbWinAuth)
            {
                Username = "UID=" + Username + ";";
                Password = "Password=" + Password + ";";
                Security = "FALSE";
            }
            if (Settings.Default.dbWinAuth)
            {
                Username = string.Empty;
                Password = string.Empty;
                Security = "TRUE";
            }

            var ConntectString = "AttachDbFilename=" + Settings.Default.dbName + ";";
            String StringFormat = @"{0}{1}{2}{3}Integrated Security={4}; Connect Timeout=30; User Instance=True;";

            dbConnectionString = String.Format(StringFormat, "Data Source=" + Settings.Default.dbInstance + ";", ConntectString, Username, Password, Security);
            return dbConnectionString;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace MainProject.UserInterface.Setting
{
    public partial class BackUpForm : Form
    {
        public BackUpForm()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BackUpForm_Load(object sender, EventArgs e)
        {

        }

        private void btnbackUpNow_Click(object sender, EventArgs e)
        {
            String BackUpDir = StartForm.BackupDir;
            if (!Directory.Exists(BackUpDir))
            {
                Directory.CreateDirectory(BackUpDir);
            }
            String Folder = Path.Combine(BackUpDir, DateTime.Now.ToString("dd-MM-yyyy HH-mm-ss"));
            if (!Directory.Exists(Folder))
            {
                Directory.CreateDirectory(Folder);
            }


            String path = Properties.Settings.Default.dbName;
            FileInfo info = new FileInfo(path);
            String[] files = Directory.GetFiles(info.DirectoryName);
            foreach (String filename in files)
            {
                MessageBox.Show(filename + " \n" + Folder + " \n" + Path.GetFileName(filename) + "\n" + Path.Combine(Folder, Path.GetFileName(filename)));
                File.Copy(filename, Path.Combine(Folder, Path.GetFileName(filename)), true);
            }
        }
    }
}

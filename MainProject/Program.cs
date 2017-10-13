using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using MainProject.UserInterface;
using System.Globalization;
using MainProject.Properties;
using System.IO;
using System.Security.Principal;
using System.Reflection;
using System.Diagnostics;
using System.ComponentModel;
using System.Drawing;
using System.Data.Common;
using System.Threading;
using MainProject.UserInterface.Setting;

namespace MainProject
{
    internal static class Program
    {
        public static CultureInfo cInfo = System.Globalization.CultureInfo.GetCultureInfo(Properties.Settings.Default.infoFormat);
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Thread.CurrentThread.CurrentCulture = cInfo;
            Thread.CurrentThread.CurrentUICulture = cInfo;
            Application.CurrentCulture = cInfo;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }

    }
}

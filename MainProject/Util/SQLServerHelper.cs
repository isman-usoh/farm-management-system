using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Sql;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.Win32;

namespace MainProject.Util
{
    public static class SQLServerHelper
    {
        public static List<String> EnumerateServers()
        {
            var result = new List<String>();
            RegistryView registryView = Environment.Is64BitOperatingSystem ? RegistryView.Registry64 : RegistryView.Registry32;
            using (RegistryKey hklm = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, registryView))
            {
                RegistryKey instanceKey = hklm.OpenSubKey(@"SOFTWARE\Microsoft\Microsoft SQL Server\Instance Names\SQL", false);
                if (instanceKey != null)
                {
                    foreach (var instanceName in instanceKey.GetValueNames())
                    {
                        result.Add(Environment.MachineName + @"\" + instanceName);
                    }
                }
            }

            var instances = SqlDataSourceEnumerator.Instance.GetDataSources();
            if (instances != null)
            {
                foreach (DataRow instance in instances.Rows)
                {
                    var serverName = instance["ServerName"].ToString();
                    var instanceName = instance["InstanceName"].ToString();
                    if (!serverName.Equals(Environment.MachineName))
                    {
                        result.Add(String.IsNullOrEmpty(instanceName) ? serverName : String.Format(@"{0}\{1}", serverName, instanceName));
                    }
                }
            }
            return result;
        }

        public static List<String> EnumerateDatabases(String connectionString)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                try
                {
                    MessageBox.Show(connectionString);
                    connection.Open();
                    var databases = connection.GetSchema("Databases");
                    if ((databases == null) || (databases.Rows.Count < 1))
                        return null;

                    var result = new List<String>();
                    foreach (DataRow database in databases.Rows)
                    {
                        result.Add(database.Field<String>("database_name"));
                    }
                    return result;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                    MessageBox.Show(e.ToString(), e.Message, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return null;
                }
                finally
                {
                    //connection.Close();
                }
            }
        }
    }
}

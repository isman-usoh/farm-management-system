using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using MainProject.ReportDataSetTableAdapters;
using MainProject.Util;
using MainProject.Properties;

namespace MainProject.Report
{
    public partial class VaccineBillForm : Form
    {
        public VaccineBillForm()
        {
            InitializeComponent();
        }

        private void ReceiptBill_Load(object sender, EventArgs e)
        {
            this.stockReportTableAdapter.Fill(this.reportDataSet.StockReport);
            var ReportParameters = new List<ReportParameter>();
            ReportParameters.Add(new ReportParameter("FarmName", Settings.Default.infoCompany.Length == 0 ? Settings.Default.infoFarmName : Settings.Default.infoCompany));

            var FarmAddtrss = new StringBuilder();
            FarmAddtrss.Append(Settings.Default.infoAddres.Trim().Length != 0 ? Settings.Default.infoAddres.Trim() + " " : string.Empty);
            FarmAddtrss.Append(Settings.Default.infoCity.Trim().Length != 0 ? "ตำบล " + Settings.Default.infoCity.Trim() + " " : string.Empty);
            FarmAddtrss.Append(Settings.Default.infoDistrict.Trim().Length != 0 ? "อำเภอ " + Settings.Default.infoDistrict.Trim() + " " : string.Empty);
            FarmAddtrss.Append(Settings.Default.infoProvince.Trim().Length != 0 ? "จังหวัด " + Settings.Default.infoProvince.Trim() + " " : string.Empty);
            FarmAddtrss.Append(Settings.Default.infoCountry.Trim().Length != 0 ? Settings.Default.infoCountry.Trim() + " " : string.Empty);
            FarmAddtrss.Append(Settings.Default.infoPostcode.Trim().Length != 0 ? Settings.Default.infoPostcode.Trim() : string.Empty);
            ReportParameters.Add(new ReportParameter("FarmAddress", FarmAddtrss.ToString()));

            var FarmContact = new StringBuilder();
            FarmContact.Append(Settings.Default.infoTel.Trim().Length != 0 ? String.Format("เบอร์โทร {0} ", Settings.Default.infoTel.Trim()) : string.Empty);
            FarmContact.Append(Settings.Default.infoMobile.Trim().Length != 0 ? "มือถือ " + Settings.Default.infoMobile.Trim() + " " : string.Empty);
            FarmContact.Append(Settings.Default.infoFax.Trim().Length != 0 ? "แฟกซ์ " + Settings.Default.infoFax.Trim() + " " : string.Empty);
            ReportParameters.Add(new ReportParameter("FarmContact", FarmContact.ToString()));

            var FarmInfo = new StringBuilder();
            FarmInfo.Append(Settings.Default.infoWebsite.Trim().Length != 0 ? "เว็บไชต์ " + Settings.Default.infoWebsite.Trim() + " " : string.Empty);
            FarmInfo.Append(Settings.Default.infoEmail.Trim().Length != 0 ? "อีเมล์ " + Settings.Default.infoEmail.Trim() : string.Empty);
            ReportParameters.Add(new ReportParameter("FarmInfo", FarmInfo.ToString()));





            reportViewer.LocalReport.SetParameters(ReportParameters);
            reportViewer.Name = string.Empty;
            reportViewer.RefreshReport();
            this.reportViewer.RefreshReport();
        }

        private void VaccineBillForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            reportViewer.LocalReport.ReleaseSandboxAppDomain();
        }
    }
}

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
    public partial class ReceiptBillForm : Form
    {
        public Int32 OrderOutID = 1;

        public ReceiptBillForm()
        {
            InitializeComponent();
        }

        private void ReceiptBill_Load(object sender, EventArgs e)
        {
            CowOrderOutReportAdapter.FillByOrderOutID(reportDataSet.CowOrderOutReport, OrderOutID);

            var orderOutReportTableAdapter = new OrderOutReportTableAdapter();
            var orderOutData = orderOutReportTableAdapter.GetDataByPK(OrderOutID);

            if (orderOutData.Count != 0)
            {
                var row = orderOutData[0];

                var ReportParameters = new List<ReportParameter>();
                ReportParameters.Add(new ReportParameter("OrderID", row.OrderOutID.ToString()));
                ReportParameters.Add(new ReportParameter("OrderType", TypeUtil.OutOrderType()[row.OrderType]));
                ReportParameters.Add(new ReportParameter("OrderDate", row.OrderDate.ToShortDateString()));
                ReportParameters.Add(new ReportParameter("OrderByName", String.Format("{0} {1}", TypeUtil.Prename()[row.OrderPrename], row.OrderName)));
                ReportParameters.Add(new ReportParameter("PaymentByName", String.Format("{0} {1}", TypeUtil.Prename()[row.PaymentPrename], row.PaymentName)));
                ReportParameters.Add(new ReportParameter("TransportCost", row.TransportCost.ToString()));
                ReportParameters.Add(new ReportParameter("TransportType", TypeUtil.OutTransportType()[row.TransportType]));
                ReportParameters.Add(new ReportParameter("TransportBillNO", row.TransportBillNO));
                ReportParameters.Add(new ReportParameter("TransportBillIssuesBy", row.TransportBillIssuesBy));

                ReportParameters.Add(new ReportParameter("CustomerID", row.CustomerID.ToString()));
                ReportParameters.Add(new ReportParameter("CustomerName", String.Format("{0} {1}", TypeUtil.Prename()[row.CustomerPrename], row.CustomerName)));
                ReportParameters.Add(new ReportParameter("PaymentByName", String.Format("{0} {1}", TypeUtil.Prename()[row.PaymentPrename], row.PaymentName)));

                var CustomerAddress = new StringBuilder();
                CustomerAddress.Append(row.Address.Trim().Length != 0 ? row.Address.Trim() : string.Empty);
                CustomerAddress.Append(row.Streed.Trim().Length != 0 ? " ถนน " + row.Streed.Trim() : string.Empty);
                CustomerAddress.Append(row.City.Trim().Length != 0 ? " ตำบล " + row.City.Trim() : string.Empty);
                CustomerAddress.Append(row.District.Trim().Length != 0 ? " อำเภอ " + row.District.Trim() : string.Empty);
                CustomerAddress.Append(row.Province.Trim().Length != 0 ? " จังหวัด " + row.Province.Trim() : string.Empty);
                CustomerAddress.Append(row.Postcode.Trim().Length != 0 ? " " + row.Postcode.Trim() : string.Empty);
                ReportParameters.Add(new ReportParameter("CustomerAddress", CustomerAddress.ToString()));
                var CustomerContact = new StringBuilder();
                CustomerContact.Append(row.Tel.Trim().Length  != 0 ? "เบอร์โทร " + row.Tel + " " : string.Empty);
                CustomerContact.Append(row.Mobile.Trim().Length != 0 ? "มือถือ " + row.Mobile : string.Empty);
                ReportParameters.Add(new ReportParameter("CustomerContact", CustomerContact.ToString()));

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
            }
        }

        private void ReceiptBillForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            reportViewer.LocalReport.ReleaseSandboxAppDomain();
        }
    }
}

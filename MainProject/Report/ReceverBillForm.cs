using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MainProject.Properties;
using Microsoft.Reporting.WinForms;
using MainProject.Util;
using MainProject.ReportDataSetTableAdapters;

namespace MainProject.Report
{
    public partial class ReceverBillForm : Form
    {
        public Int32 OrderInID { get; set; }
        public ReceverBillForm()
        {
            InitializeComponent();
        }

        private void ReceverBillForm_Load(object sender, EventArgs e)
        {
            cowOrderInReportTableAdapter.Fill(reportDataSet.CowOrderInReport);

            var orderInReportTableAdapter = new OrderInReportTableAdapter();
            var orderInData = orderInReportTableAdapter.GetDataByPK(OrderInID);

            if (orderInData.Count != 0)
            {
                var row = orderInData[0];

                var ReportParameters = new List<ReportParameter>();
                ReportParameters.Add(new ReportParameter("OrderID", row.OrderInID.ToString()));
                ReportParameters.Add(new ReportParameter("OrderType", TypeUtil.InOrderType()[row.OrderType]));
                ReportParameters.Add(new ReportParameter("OrderDate", row.OrderDate.ToLocalTime().ToShortDateString()));
                ReportParameters.Add(new ReportParameter("OrderByName", String.Format("{0} {1}", TypeUtil.Prename()[row.OrderPrename], row.OrderName)));
                ReportParameters.Add(new ReportParameter("PaymentByName", String.Format("{0} {1}", TypeUtil.Prename()[row.PaymentPrename], row.PaymentName)));
                ReportParameters.Add(new ReportParameter("TransportCost", row.TransportCost.ToString()));
                ReportParameters.Add(new ReportParameter("TransportType", TypeUtil.OutTransportType()[row.TransportType]));
                ReportParameters.Add(new ReportParameter("TransportBillNO", row.TransportBillNO));
                ReportParameters.Add(new ReportParameter("TransportBillIssuesBy", row.TransportBillIssuedBy));

                ReportParameters.Add(new ReportParameter("CustomerID", row.CustomerID.ToString()));
                ReportParameters.Add(new ReportParameter("CustomerName", String.Format("{0} {1}", TypeUtil.Prename()[row.CustomerPrename], row.CustomerName)));
                ReportParameters.Add(new ReportParameter("PaymentByName", String.Format("{0} {1}", TypeUtil.Prename()[row.PaymentPrename], row.PaymentName)));
                ReportParameters.Add(new ReportParameter("FarmTax", "เลขประจำตัวผู้เสียภาษี :" + Settings.Default.infoTax));


                var CustomerAddress = new StringBuilder();
                CustomerAddress.Append(row.Address.Trim().Length != 0 ? row.Address.Trim() : string.Empty);
                CustomerAddress.Append(row.Streed.Trim().Length != 0 ? " ถนน " + row.Streed.Trim() : string.Empty);
                CustomerAddress.Append(row.City.Trim().Length != 0 ? " ตำบล " + row.City.Trim() : string.Empty);
                CustomerAddress.Append(row.District.Trim().Length != 0 ? " อำเภอ " + row.District.Trim() : string.Empty);
                CustomerAddress.Append(row.Province.Trim().Length != 0 ? " จังหวัด " + row.Province.Trim() : string.Empty);
                CustomerAddress.Append(row.Postcode.Trim().Length != 0 ? " " + row.Postcode.Trim() : string.Empty);
                ReportParameters.Add(new ReportParameter("CustomerAddress", CustomerAddress.ToString()));


                var CustomerContact = new StringBuilder();
                CustomerContact.Append(row.Tel.Trim().Length != 0 ? String.Format("เบอร์โทร {0} ", row.Tel) : string.Empty);
                CustomerContact.Append(row.Mobile.Trim().Length != 0 ? "มือถือ " + row.Mobile : string.Empty);
                ReportParameters.Add(new ReportParameter("CustomerContact", CustomerContact.ToString()));


                ReportParameters.Add(new ReportParameter("FarmName", Settings.Default.infoCompany.Length == 0 ? Settings.Default.infoFarmName : Settings.Default.infoCompany));

                var FarmAddtrss = new StringBuilder();
                FarmAddtrss.Append(Settings.Default.infoAddres.Trim().Length != 0 ? Settings.Default.infoAddres.Trim() + " " : string.Empty);
                FarmAddtrss.Append(Settings.Default.infoCity.Trim().Length != 0 ? String.Format("ตำบล {0} ", Settings.Default.infoCity.Trim()) : string.Empty);
                FarmAddtrss.Append(Settings.Default.infoDistrict.Trim().Length != 0 ? String.Format("อำเภอ {0} ", Settings.Default.infoDistrict.Trim()) : string.Empty);
                FarmAddtrss.Append(Settings.Default.infoProvince.Trim().Length != 0 ? String.Format("จังหวัด {0} ", Settings.Default.infoProvince.Trim()) : string.Empty);
                FarmAddtrss.Append(Settings.Default.infoCountry.Trim().Length != 0 ? Settings.Default.infoCountry.Trim() + " " : string.Empty);
                FarmAddtrss.Append(Settings.Default.infoPostcode.Trim().Length != 0 ? Settings.Default.infoPostcode.Trim() : string.Empty);
                ReportParameters.Add(new ReportParameter("FarmAddress", FarmAddtrss.ToString()));

                var FarmContact = new StringBuilder();
                FarmContact.Append(Settings.Default.infoTel.Trim().Length != 0 ? String.Format("เบอร์โทร {0} ", Settings.Default.infoTel.Trim()) : string.Empty);
                FarmContact.Append(Settings.Default.infoMobile.Trim().Length != 0 ? String.Format("มือถือ {0} ", Settings.Default.infoMobile.Trim()) : string.Empty);
                FarmContact.Append(Settings.Default.infoFax.Trim().Length != 0 ? String.Format("แฟกซ์ {0} ", Settings.Default.infoFax.Trim()) : string.Empty);
                ReportParameters.Add(new ReportParameter("FarmContact", FarmContact.ToString()));

                var FarmInfo = new StringBuilder();
                FarmInfo.Append(Settings.Default.infoWebsite.Trim().Length != 0 ? String.Format("เว็บไชต์ {0} ", Settings.Default.infoWebsite.Trim()) : string.Empty);
                FarmInfo.Append(Settings.Default.infoEmail.Trim().Length != 0 ? "อีเมล์ " + Settings.Default.infoEmail.Trim() : string.Empty);
                ReportParameters.Add(new ReportParameter("FarmInfo", FarmInfo.ToString()));


                ReportParameters.Add(new ReportParameter("FarmTax", "เลขประจำตัวผู้เสียภาษี :" + Settings.Default.infoTax));
                ReportParameters.Add(new ReportParameter("PaymentStatus", row.PaymentStatus == 1 ? String.Format("{0} โดย {1}", TypeUtil.InPaymentStatus()[row.PaymentStatus], TypeUtil.InPaymentType()[row.PaymentType]) : TypeUtil.InPaymentStatus()[row.PaymentStatus]));
                if (row.PaymentType == 1)
                {
                    ReportParameters.Add(new ReportParameter("PaymentDetail", String.Format("ชื่อบัญชี: {0} เลขบัญชี: {1} ประเภท: {2} สาขา: {3} ธนาคาร: {4}", row.BankAccountName, row.BankAccountNO, (row.BankAccountType == 99 ? "-" : TypeUtil.AccountType()[row.BankAccountType]), row.BankAccountBranch, row.BackName)));
                }
                reportViewer.LocalReport.SetParameters(ReportParameters);
                reportViewer.RefreshReport();
            }
        }

        private void ReceverBillForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            reportViewer.LocalReport.ReleaseSandboxAppDomain();
        }
    }
}

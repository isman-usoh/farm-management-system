namespace MainProject.Report
{
    partial class VaccineBillForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.reportDataSet = new MainProject.ReportDataSet();
            this.stockReportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stockReportTableAdapter = new MainProject.ReportDataSetTableAdapters.StockReportTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.reportDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockReportBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer
            // 
            this.reportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "StockDataSet";
            reportDataSource2.Value = this.stockReportBindingSource;
            this.reportViewer.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer.LocalReport.ReportEmbeddedResource = "MainProject.Report.VaccineBill.rdlc";
            this.reportViewer.Location = new System.Drawing.Point(0, 0);
            this.reportViewer.Name = "reportViewer";
            this.reportViewer.Size = new System.Drawing.Size(484, 561);
            this.reportViewer.TabIndex = 0;
            // 
            // reportDataSet
            // 
            this.reportDataSet.DataSetName = "ReportDataSet";
            this.reportDataSet.Locale = new System.Globalization.CultureInfo("en");
            this.reportDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // stockReportBindingSource
            // 
            this.stockReportBindingSource.DataMember = "StockReport";
            this.stockReportBindingSource.DataSource = this.reportDataSet;
            // 
            // stockReportTableAdapter
            // 
            this.stockReportTableAdapter.ClearBeforeFill = true;
            // 
            // VaccineBillForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 561);
            this.Controls.Add(this.reportViewer);
            this.Name = "VaccineBillForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ใบฉีดยา/วัคซีน";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.VaccineBillForm_FormClosing);
            this.Load += new System.EventHandler(this.ReceiptBill_Load);
            ((System.ComponentModel.ISupportInitialize)(this.reportDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockReportBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer;
        private ReportDataSet reportDataSet;
        private System.Windows.Forms.BindingSource stockReportBindingSource;
        private ReportDataSetTableAdapters.StockReportTableAdapter stockReportTableAdapter;


    }
}
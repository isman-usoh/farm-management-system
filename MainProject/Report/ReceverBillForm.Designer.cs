namespace MainProject.Report
{
    partial class ReceverBillForm
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.cowOrderInReportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportDataSet = new MainProject.ReportDataSet();
            this.reportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.cowOrderInReportTableAdapter = new MainProject.ReportDataSetTableAdapters.CowOrderInReportTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.cowOrderInReportBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // cowOrderInReportBindingSource
            // 
            this.cowOrderInReportBindingSource.DataMember = "CowOrderInReport";
            this.cowOrderInReportBindingSource.DataSource = this.reportDataSet;
            // 
            // reportDataSet
            // 
            this.reportDataSet.DataSetName = "ReportDataSet";
            this.reportDataSet.Locale = new System.Globalization.CultureInfo("en");
            this.reportDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer
            // 
            this.reportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "CowDataSet";
            reportDataSource1.Value = this.cowOrderInReportBindingSource;
            this.reportViewer.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer.LocalReport.ReportEmbeddedResource = "MainProject.Report.ReceverBill.rdlc";
            this.reportViewer.Location = new System.Drawing.Point(0, 0);
            this.reportViewer.Name = "reportViewer";
            this.reportViewer.Size = new System.Drawing.Size(484, 561);
            this.reportViewer.TabIndex = 0;
            // 
            // cowOrderInReportTableAdapter
            // 
            this.cowOrderInReportTableAdapter.ClearBeforeFill = true;
            // 
            // ReceverBillForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 561);
            this.Controls.Add(this.reportViewer);
            this.Name = "ReceverBillForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "รายการรับของ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ReceverBillForm_FormClosing);
            this.Load += new System.EventHandler(this.ReceverBillForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cowOrderInReportBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer;
        private ReportDataSet reportDataSet;
        private System.Windows.Forms.BindingSource cowOrderInReportBindingSource;
        private ReportDataSetTableAdapters.CowOrderInReportTableAdapter cowOrderInReportTableAdapter;
    }
}
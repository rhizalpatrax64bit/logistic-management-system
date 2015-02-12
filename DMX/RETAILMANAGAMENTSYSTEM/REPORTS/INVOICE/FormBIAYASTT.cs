using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using System.Windows.Forms;

namespace LOGISTICMANAGAMENTSYSTEM.REPORTS.INVOICE
{
    public partial class FormBIAYASTT : Form
    {
        ReportDocument m_cryRpt = new ReportDocument();
        DataTable my_dt;
        public FormBIAYASTT(DataTable dt)
        {
            InitializeComponent();
            
            my_dt = new DataTable();
            my_dt = dt;
            loadReport();
        }
        public void loadReport()
        {

            crystalReportViewerBIAYASTT.LocalReport.DataSources.Clear();
            crystalReportViewerBIAYASTT.LocalReport.ReportEmbeddedResource = "LOGISTICMANAGAMENTSYSTEM.REPORTS.INVOICE.reportBIAYA.rdlc";
            Microsoft.Reporting.WinForms.ReportDataSource dataset = new Microsoft.Reporting.WinForms.ReportDataSource("dsBIAYA_V_BIAYASTT", my_dt); // set the datasource
            crystalReportViewerBIAYASTT.LocalReport.DataSources.Add(dataset);
            dataset.Value = my_dt;
            crystalReportViewerBIAYASTT.LocalReport.Refresh();
            crystalReportViewerBIAYASTT.RefreshReport(); // refresh report        

        }

        private void crystalReportViewerBIAYASTT_Leave(object sender, System.EventArgs e)
        {
            crystalReportViewerBIAYASTT.Dispose();
        }

        private void FormBIAYASTT_FormClosed(object sender, FormClosedEventArgs e)
        {
            crystalReportViewerBIAYASTT.Dispose();
            
        }

        private void FormBIAYASTT_Load(object sender, System.EventArgs e)
        {

            this.crystalReportViewerBIAYASTT.RefreshReport();
        }

        
    }
}

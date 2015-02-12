using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using System.Windows.Forms;

namespace LOGISTICMANAGAMENTSYSTEM.MASTER.REPORT
{
    public partial class FormViewerCUSTOMER : Form
    {
        ReportDocument m_cryRpt;
        DataTable my_dt;

        public FormViewerCUSTOMER(DataTable dt)
        {
            InitializeComponent();
        
            my_dt = new DataTable();
            my_dt = dt;
            loadReport();

        }
        public void loadReport()
        {


            reportViewerCUSTOMER.LocalReport.DataSources.Clear();
            reportViewerCUSTOMER.LocalReport.ReportEmbeddedResource = "LOGISTICMANAGAMENTSYSTEM.MASTER.REPORT.masterCUSTOMER.rdlc";
            Microsoft.Reporting.WinForms.ReportDataSource dataset = new Microsoft.Reporting.WinForms.ReportDataSource("dsCUSTOMER_v_customer", my_dt); // set the datasource
            reportViewerCUSTOMER.LocalReport.DataSources.Add(dataset);
            dataset.Value = my_dt;
            reportViewerCUSTOMER.LocalReport.Refresh();
            reportViewerCUSTOMER.RefreshReport(); // refresh report

        }

        private void crystalReportViewer_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }

        private void FormViewerCUSTOMER_Load(object sender, EventArgs e)
        {

            this.reportViewerCUSTOMER.RefreshReport();
        }
    }
}

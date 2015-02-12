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
    public partial class FormViewerMARKETING : Form
    {
        ReportDocument m_cryRpt;
        DataTable my_dt;

        public FormViewerMARKETING(DataTable dt)
        {
            InitializeComponent();
           
            my_dt = new DataTable();
            my_dt = dt;
            loadReport();

        }
        public void loadReport()
        {
            
            reportViewerMARKETING.LocalReport.DataSources.Clear();
            reportViewerMARKETING.LocalReport.ReportEmbeddedResource = "LOGISTICMANAGAMENTSYSTEM.MASTER.REPORT.masterMarketing.rdlc";
            Microsoft.Reporting.WinForms.ReportDataSource dataset = new Microsoft.Reporting.WinForms.ReportDataSource("dsMARKETING__v_marketing", my_dt); // set the datasource
            reportViewerMARKETING.LocalReport.DataSources.Add(dataset);
            dataset.Value = my_dt;
            reportViewerMARKETING.LocalReport.Refresh();
            reportViewerMARKETING.RefreshReport(); // refresh report
           



        }

        private void FormViewerMARKETING_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }

        private void FormViewerMARKETING_Load(object sender, EventArgs e)
        {

            this.reportViewerMARKETING.RefreshReport();
            this.reportViewerMARKETING.RefreshReport();
            this.reportViewerMARKETING.RefreshReport();
            this.reportViewerMARKETING.RefreshReport();
            this.reportViewerMARKETING.RefreshReport();
            this.reportViewerMARKETING.RefreshReport();
            this.reportViewerMARKETING.RefreshReport();
        }
    }
}


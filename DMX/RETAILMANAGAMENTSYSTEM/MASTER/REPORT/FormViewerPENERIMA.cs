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
    public partial class FormViewerPENERIMA : Form
    {
        ReportDocument m_cryRpt;
        DataTable my_dt;
        public FormViewerPENERIMA(DataTable dt)
        {
            InitializeComponent();
            
            my_dt = new DataTable();
            my_dt = dt;
            loadReport();
          
        }
        public void loadReport()
        {
            reportViewerPENERIMA.LocalReport.DataSources.Clear();
            reportViewerPENERIMA.LocalReport.ReportEmbeddedResource = "LOGISTICMANAGAMENTSYSTEM.MASTER.REPORT.masterPenerima.rdlc";
            Microsoft.Reporting.WinForms.ReportDataSource dataset = new Microsoft.Reporting.WinForms.ReportDataSource("dsPENERIMA_v_penerima", my_dt); // set the datasource
            reportViewerPENERIMA.LocalReport.DataSources.Add(dataset);
            dataset.Value = my_dt;
            reportViewerPENERIMA.LocalReport.Refresh();
            reportViewerPENERIMA.RefreshReport(); // refresh report           


        }

        private void FormViewerPENERIMA_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }

        private void FormViewerPENERIMA_Load(object sender, EventArgs e)
        {

            this.reportViewerPENERIMA.RefreshReport();
        }
    }
}

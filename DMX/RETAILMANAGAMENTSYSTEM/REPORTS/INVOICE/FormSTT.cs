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
    public partial class FormSTT : Form
    {
        
        DataTable my_dt;
        public FormSTT(DataTable dt)
        {
            InitializeComponent();
          
            my_dt = new DataTable();
            my_dt = dt;
            loadReport();
        }
        public void loadReport()
        {
            reportViewerPENERIMAANCARGO.LocalReport.DataSources.Clear();
            reportViewerPENERIMAANCARGO.LocalReport.ReportEmbeddedResource = "LOGISTICMANAGAMENTSYSTEM.REPORTS.INVOICE.reportPENERIMAANCARGO.rdlc";
            Microsoft.Reporting.WinForms.ReportDataSource dataset = new Microsoft.Reporting.WinForms.ReportDataSource("dsPENERIMAANCARGO_V_STT", my_dt); // set the datasource
            reportViewerPENERIMAANCARGO.LocalReport.DataSources.Add(dataset);
            dataset.Value = my_dt;
            reportViewerPENERIMAANCARGO.LocalReport.Refresh();          


        }

        private void FormSTT_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }

        private void FormSTT_Load(object sender, System.EventArgs e)
        {

            this.reportViewerPENERIMAANCARGO.RefreshReport();
        }
    }
}

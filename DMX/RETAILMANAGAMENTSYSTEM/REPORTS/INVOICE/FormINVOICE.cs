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
    public partial class FormINVOICE : Form
    {
        ReportDocument m_cryRpt;
        DataTable my_dt;
        public FormINVOICE(DataTable dt)
        {
            InitializeComponent();
            my_dt = new DataTable();
            my_dt = dt;
            loadReport();
        }
        public void loadReport()
        {

            reportViewerINVOICE.LocalReport.DataSources.Clear();
            reportViewerINVOICE.LocalReport.ReportEmbeddedResource = "LOGISTICMANAGAMENTSYSTEM.REPORTS.INVOICE.cetakINVOICE.rdlc";
            Microsoft.Reporting.WinForms.ReportDataSource dataset = new Microsoft.Reporting.WinForms.ReportDataSource("dsINVOICING_V_INVOICECETAK", my_dt); // set the datasource
            reportViewerINVOICE.LocalReport.DataSources.Add(dataset);
            dataset.Value = my_dt;
            reportViewerINVOICE.LocalReport.Refresh();
            reportViewerINVOICE.RefreshReport(); // refresh report        
           
        }

         private void FormINVOICE_KeyUp(object sender, KeyEventArgs e)
         {
             if (e.KeyCode == Keys.Escape)
             {
                 Close();
             }
         }

         private void FormINVOICE_Load(object sender, System.EventArgs e)
         {

             this.reportViewerINVOICE.RefreshReport();
         }
    }
}

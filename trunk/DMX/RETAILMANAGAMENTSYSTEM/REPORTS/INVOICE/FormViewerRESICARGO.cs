using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LOGISTICMANAGAMENTSYSTEM.REPORTS.INVOICE
{
    public partial class FormViewerRESICARGO : Form
    {
        DataTable my_dt;
        public FormViewerRESICARGO(DataTable dt)
        {
            InitializeComponent();
            my_dt = new DataTable();
            my_dt = dt;
            loadReport();
        }
        public void loadReport()
        {           
            reportViewerRESICARGO.LocalReport.DataSources.Clear();
            reportViewerRESICARGO.LocalReport.ReportEmbeddedResource = "LOGISTICMANAGAMENTSYSTEM.REPORTS.INVOICE.cetakRESICARGO.rdlc";
            Microsoft.Reporting.WinForms.ReportDataSource dataset = new Microsoft.Reporting.WinForms.ReportDataSource("dsRESICARGO_V_RESICARGO", my_dt); // set the datasource
            reportViewerRESICARGO.LocalReport.DataSources.Add(dataset);
            dataset.Value = my_dt;
            reportViewerRESICARGO.LocalReport.Refresh();
            reportViewerRESICARGO.RefreshReport(); // refresh report        
            
        }

        private void FormViewerRESICARGO_Load(object sender, EventArgs e)
        {

            this.reportViewerRESICARGO.RefreshReport();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LOGISTICMANAGAMENTSYSTEM.REPORTS.EXPRESS
{
    public partial class FormViewerCARGO : Form
    {
        DataTable my_dt;
        public FormViewerCARGO(DataTable dt)
        {
            InitializeComponent();
            my_dt = new DataTable();
            my_dt = dt;
            loadReport();
        }

        public void loadReport()
        {

            reportViewerCARGO.LocalReport.DataSources.Clear();
            reportViewerCARGO.LocalReport.ReportEmbeddedResource = "LOGISTICMANAGAMENTSYSTEM.REPORTS.EXPRESS.reportCOURIER.rdlc";
            Microsoft.Reporting.WinForms.ReportDataSource dataset = new Microsoft.Reporting.WinForms.ReportDataSource("dsCOURIER_v_courier", my_dt); // set the datasource
            reportViewerCARGO.LocalReport.DataSources.Add(dataset);
            dataset.Value = my_dt;
            reportViewerCARGO.LocalReport.Refresh();
            reportViewerCARGO.RefreshReport(); // refresh report        

        }


        private void FormViewerCARGO_Load(object sender, EventArgs e)
        {

            this.reportViewerCARGO.RefreshReport();
        }
    }
}

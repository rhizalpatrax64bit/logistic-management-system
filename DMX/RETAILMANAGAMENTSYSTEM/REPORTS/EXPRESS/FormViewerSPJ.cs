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
    public partial class FormViewerSPJ : Form
    {
        DataTable my_dt;
        public FormViewerSPJ(DataTable dt)
        {
            InitializeComponent();
            my_dt = new DataTable();
            my_dt = dt;
            loadReport();
        }
        public void loadReport()
        {

            reportViewerSPJ.LocalReport.DataSources.Clear();
            reportViewerSPJ.LocalReport.ReportEmbeddedResource = "LOGISTICMANAGAMENTSYSTEM.REPORTS.EXPRESS.reportSPJ.rdlc";
            Microsoft.Reporting.WinForms.ReportDataSource dataset = new Microsoft.Reporting.WinForms.ReportDataSource("reportSPJ_v_spj", my_dt); // set the datasource
            reportViewerSPJ.LocalReport.DataSources.Add(dataset);
            dataset.Value = my_dt;
            reportViewerSPJ.LocalReport.Refresh();
            reportViewerSPJ.RefreshReport(); // refresh report        

        }
        private void FormViewerSPJ_Load(object sender, EventArgs e)
        {

            this.reportViewerSPJ.RefreshReport();
        }
    }
}

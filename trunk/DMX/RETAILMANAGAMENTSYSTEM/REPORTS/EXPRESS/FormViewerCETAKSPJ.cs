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
    public partial class FormViewerCETAKSPJ : Form
    {
        DataTable my_dt;
        public FormViewerCETAKSPJ(DataTable dt)
        {
            InitializeComponent();
            my_dt = new DataTable();
            my_dt = dt;
            loadReport();
        }
        public void loadReport()
        {

            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.ReportEmbeddedResource = "LOGISTICMANAGAMENTSYSTEM.REPORTS.EXPRESS.cetakSPJ.rdlc";
            Microsoft.Reporting.WinForms.ReportDataSource dataset = new Microsoft.Reporting.WinForms.ReportDataSource("dsSPJ_v_cetak_spj", my_dt); // set the datasource
            reportViewer1.LocalReport.DataSources.Add(dataset);
            dataset.Value = my_dt;
            reportViewer1.LocalReport.Refresh();
            reportViewer1.RefreshReport(); // refresh report        

        }
        private void FormViewerCETAKSPJ_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }
    }
}

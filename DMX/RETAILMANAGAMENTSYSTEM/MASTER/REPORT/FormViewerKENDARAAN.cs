using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LOGISTICMANAGAMENTSYSTEM.MASTER.REPORT
{
    public partial class FormViewerKENDARAAN : Form
    {
        
        DataTable my_dt;
        public FormViewerKENDARAAN(DataTable dt)
        {
            InitializeComponent();
            my_dt = new DataTable();
            my_dt = dt;
            loadReport();
        }
        public void loadReport()
        {


            reportViewerKENDARAAN.LocalReport.DataSources.Clear();
            reportViewerKENDARAAN.LocalReport.ReportEmbeddedResource = "LOGISTICMANAGAMENTSYSTEM.MASTER.REPORT.masterKENDARAAN.rdlc";
            Microsoft.Reporting.WinForms.ReportDataSource dataset = new Microsoft.Reporting.WinForms.ReportDataSource("dsKENDARAAN_v_kendaraan", my_dt); // set the datasource
            reportViewerKENDARAAN.LocalReport.DataSources.Add(dataset);
            dataset.Value = my_dt;
            reportViewerKENDARAAN.LocalReport.Refresh();
            reportViewerKENDARAAN.RefreshReport(); // refresh report

        }


        private void FormViewerKENDARAAN_Load(object sender, EventArgs e)
        {

            this.reportViewerKENDARAAN.RefreshReport();
        }
    }
}

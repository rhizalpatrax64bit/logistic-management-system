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
    public partial class FormViewerDriver : Form
    {
        DataTable my_dt;
        public FormViewerDriver(DataTable dt)
        {
            InitializeComponent();
            my_dt = new DataTable();
            my_dt = dt;
            loadReport();
        }
        public void loadReport()
        {
            reportViewerDRIVER.LocalReport.DataSources.Clear();
            reportViewerDRIVER.LocalReport.ReportEmbeddedResource = "LOGISTICMANAGAMENTSYSTEM.MASTER.REPORT.masterDriver.rdlc";
            Microsoft.Reporting.WinForms.ReportDataSource dataset = new Microsoft.Reporting.WinForms.ReportDataSource("dsDRIVER_v_driver", my_dt); // set the datasource
            reportViewerDRIVER.LocalReport.DataSources.Add(dataset);
            dataset.Value = my_dt;
            reportViewerDRIVER.LocalReport.Refresh();
            reportViewerDRIVER.RefreshReport(); // refresh report           


        }
        private void FormViewerDriver_Load(object sender, EventArgs e)
        {

            this.reportViewerDRIVER.RefreshReport();
        }
    }
}

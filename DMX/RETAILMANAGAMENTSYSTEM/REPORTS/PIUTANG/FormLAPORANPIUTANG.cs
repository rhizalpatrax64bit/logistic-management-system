using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using System.Windows.Forms;


namespace LOGISTICMANAGAMENTSYSTEM.REPORTS.PIUTANG
{
    public partial class FormLAPORANPIUTANG : Form
    {
        ReportDocument m_cryRpt;
        DataTable my_dt;
        public FormLAPORANPIUTANG(DataTable dt)
        {
            InitializeComponent();
            my_dt = new DataTable();
            my_dt = dt;
            loadReport();
        }
        public void loadReport()
        {            
           /* file ini disimpan di bin/debug
            m_cryRpt.Load(Application.StartupPath + @".\REPORT\PIUTANG.rpt");
            // cara pemanggilan menggunakan data table yang sudah di proses dan di masukan ke object dt
            m_cryRpt.Database.Tables[0].SetDataSource((DataTable)my_dt);
            // data yang di panggil di ke data source otomatis tergambar ke dataset yang di buat dan berextensi xsd
            crystalReportViewerPIUTANG.ReportSource = m_cryRpt;
            crystalReportViewerPIUTANG.Refresh();
            */
            reportViewerPIUTANG.LocalReport.DataSources.Clear();
            reportViewerPIUTANG.LocalReport.ReportEmbeddedResource = "LOGISTICMANAGAMENTSYSTEM.REPORTS.PIUTANG.reportPIUTANG.rdlc";
            Microsoft.Reporting.WinForms.ReportDataSource dataset = new Microsoft.Reporting.WinForms.ReportDataSource("DSPIUTANG_PIUTANG", my_dt); // set the datasource
            reportViewerPIUTANG.LocalReport.DataSources.Add(dataset);
            dataset.Value = my_dt;
            reportViewerPIUTANG.LocalReport.Refresh();
            reportViewerPIUTANG.RefreshReport(); // refresh report      

        }

        private void FormLAPORANPIUTANG_Load(object sender, System.EventArgs e)
        {

            this.reportViewerPIUTANG.RefreshReport();
        }
    }
}

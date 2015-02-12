using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
//using CrystalDecisions.CrystalReports.Engine;
//susing CrystalDecisions.Shared;
using System.Windows.Forms;
using System.Drawing.Printing;
using Microsoft.Reporting.WinForms;


namespace LOGISTICMANAGAMENTSYSTEM.REPORTS.EXPRESS
{
    public partial class FormRESIEXPRESS : Form
    {
        
        DataTable my_dt;

        public FormRESIEXPRESS(DataTable dt)
        {
            InitializeComponent();
       
            my_dt = new DataTable();
            my_dt = dt;
            loadReport();
        }
        public void loadReport()
        {
            /*
            // file ini disimpan di bin/debug
            m_cryRpt.Load(Application.StartupPath + @".\REPORT\RESI.rpt");
            // cara pemanggilan menggunakan data table yang sudah di proses dan di masukan ke object dt
            m_cryRpt.Database.Tables[0].SetDataSource((DataTable)my_dt);
            // data yang di panggil di ke data source otomatis tergambar ke dataset yang di buat dan berextensi xsd
            crystalReportViewerRESI.ReportSource = m_cryRpt;
            crystalReportViewerRESI.Refresh();
             */
            reportViewerCETAKRESI.LocalReport.DataSources.Clear();
            reportViewerCETAKRESI.LocalReport.ReportEmbeddedResource = "LOGISTICMANAGAMENTSYSTEM.REPORTS.EXPRESS.cetakRESI.rdlc";
            Microsoft.Reporting.WinForms.ReportDataSource dataset = new Microsoft.Reporting.WinForms.ReportDataSource("dsRESI_V_TRANSAKSIEXPRESS", my_dt); // set the datasource
            reportViewerCETAKRESI.LocalReport.DataSources.Add(dataset);
            dataset.Value = my_dt;
            System.Drawing.Printing.PageSettings pg = new PageSettings();
            // Set margins
            // Set paper size
            pg.Margins.Top = 100;
            pg.Margins.Bottom = 100;
            pg.Margins.Left = 100;
            pg.Margins.Right = 100;
            pg.Landscape = false;
            System.Drawing.Printing.PaperSize size = new PaperSize();
            size.RawKind = (int)PaperKind.A4;
            pg.PaperSize = size;

           // reportViewerCETAKRESI.SetPageSettings(pg); ??
            reportViewerCETAKRESI.LocalReport.Refresh();
            reportViewerCETAKRESI.RefreshReport(); // refresh report        



        }

        private void FormRESIEXPRESS_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }

        private void FormRESIEXPRESS_Load(object sender, System.EventArgs e)
        {

            this.reportViewerCETAKRESI.RefreshReport();
            this.reportViewerCETAKRESI.RefreshReport();
        }
    }
}

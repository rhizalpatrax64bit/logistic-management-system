using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
//using CrystalDecisions.CrystalReports.Engine;
//using CrystalDecisions.Shared;
using System.Windows.Forms;
using System.Drawing.Printing;
using Microsoft.Reporting.WinForms;



namespace LOGISTICMANAGAMENTSYSTEM.MASTER.REPORT
{
    public partial class FormViewerAGENT : Form
    {
      
         DataTable my_dt;

         //public FormViewerAGENT(ReportDocument rpt, DataTable dt)
        public FormViewerAGENT(DataTable dt)
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
            m_cryRpt.Load(Application.StartupPath + @".\REPORT\agent.rpt");
            // cara pemanggilan menggunakan data table yang sudah di proses dan di masukan ke object dt
            m_cryRpt.Database.Tables[0].SetDataSource((DataTable)my_dt);
            // data yang di panggil di ke data source otomatis tergambar ke dataset yang di buat dan berextensi xsd
            crystalReportAGENT.ReportSource = m_cryRpt;
            crystalReportAGENT.Refresh();*/
             //List<Student> list = StudentRepository.GetStudents();  
           // m_cryRpt.Database.Tables[0].SetDataSource((DataTable)my_dt);

            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.ReportEmbeddedResource = "LOGISTICMANAGAMENTSYSTEM.MASTER.REPORT.masterAgent.rdlc";
            Microsoft.Reporting.WinForms.ReportDataSource dataset = new Microsoft.Reporting.WinForms.ReportDataSource("dsAGENT_v_agent", my_dt); // set the datasource
            reportViewer1.LocalReport.DataSources.Add(dataset);
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
            reportViewer1.LocalReport.Refresh();
            reportViewer1.RefreshReport(); // refresh report
         
           
           
        }
        private void crystalReportAGENT_Load(object sender, EventArgs e)
        {

        }

        private void FormViewerAGENT_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }

        private void FormViewerAGENT_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }
    }
}

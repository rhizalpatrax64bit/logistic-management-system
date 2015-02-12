using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using System.Windows.Forms;

namespace LOGISTICMANAGAMENTSYSTEM.MASTER.REPORT
{
    public partial class FormViewerSALES : Form
    {
         ReportDocument m_cryRpt;
         DataTable my_dt;

         public FormViewerSALES(ReportDocument rpt, DataTable dt)
        {
            InitializeComponent();
            m_cryRpt = rpt;
            my_dt = new DataTable();
            my_dt = dt;
            loadReport();
          
        }
        public void loadReport()
        {


            // file ini disimpan di bin/debug
            m_cryRpt.Load(@".\REPORT\sales.rpt");
            // cara pemanggilan menggunakan data table yang sudah di proses dan di masukan ke object dt
            m_cryRpt.Database.Tables[0].SetDataSource((DataTable)my_dt);
            // data yang di panggil di ke data source otomatis tergambar ke dataset yang di buat dan berextensi xsd
            crystalReportSALES.ReportSource = m_cryRpt;
            crystalReportSALES.Refresh();
         
           
           
        }

        private void FormViewerSALES_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }
    }
}

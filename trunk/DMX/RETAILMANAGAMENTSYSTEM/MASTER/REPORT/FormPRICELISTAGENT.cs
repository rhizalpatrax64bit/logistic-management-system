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
    public partial class FormPRICELISTAGENT : Form
    {
        ReportDocument m_cryRpt;
        DataTable my_dtB;
        int type;

        public FormPRICELISTAGENT(DataTable dtB, int _type)
        {
            InitializeComponent();
            
            my_dtB = new DataTable();
            type = _type;
            my_dtB = dtB;

            loadReport();
        }
        public void loadReport()
        {
            reportViewerPRICELISTAGENT.LocalReport.DataSources.Clear();
            reportViewerPRICELISTAGENT.LocalReport.ReportEmbeddedResource = "LOGISTICMANAGAMENTSYSTEM.MASTER.REPORT.pricelistAgent.rdlc";
            Microsoft.Reporting.WinForms.ReportDataSource dataset = new Microsoft.Reporting.WinForms.ReportDataSource("dsPRICELISTAGENT_PRICELIST", my_dtB); // set the datasource
            reportViewerPRICELISTAGENT.LocalReport.DataSources.Add(dataset);
            dataset.Value = my_dtB;
            reportViewerPRICELISTAGENT.LocalReport.Refresh();
            reportViewerPRICELISTAGENT.RefreshReport(); // refresh report     

           



        }

        private void FormPRICELISTAGENT_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }

        private void FormPRICELISTAGENT_Load(object sender, EventArgs e)
        {

            this.reportViewerPRICELISTAGENT.RefreshReport();
        }

        private void reportViewerPRICELISTAGENT_Load(object sender, EventArgs e)
        {

        }
    }
}

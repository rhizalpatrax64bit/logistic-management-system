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
    public partial class FormViewerPRICELIST : Form
    {
        
        DataTable my_dtB;
        int type;
        public FormViewerPRICELIST(DataTable dtB, int _type)
        {
            InitializeComponent();
            
            my_dtB = new DataTable();
            type = _type;
            my_dtB = dtB;
           
            loadReport();

        }
        public void loadReport()
        {

            reportViewerPRICELIST.LocalReport.DataSources.Clear();
            reportViewerPRICELIST.LocalReport.ReportEmbeddedResource = "LOGISTICMANAGAMENTSYSTEM.MASTER.REPORT.quotationPricelist.rdlc";
            Microsoft.Reporting.WinForms.ReportDataSource dataset = new Microsoft.Reporting.WinForms.ReportDataSource("PRICELIST_PRICELIST", my_dtB); // set the datasource
            reportViewerPRICELIST.LocalReport.DataSources.Add(dataset);
            dataset.Value = my_dtB;
            reportViewerPRICELIST.LocalReport.Refresh();
            reportViewerPRICELIST.RefreshReport(); // refresh report           



        }

        private void FormViewerPRICELIST_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }

        private void FormViewerPRICELIST_Load(object sender, EventArgs e)
        {

            this.reportViewerPRICELIST.RefreshReport();
        }
    }
}

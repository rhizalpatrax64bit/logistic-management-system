using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LOGISTICMANAGAMENTSYSTEM.PURCHASE.SUBPURCHASE
{
    public partial class FormADDRETUR : Form
    {
        public FormADDRETUR()
        {
            InitializeComponent();
        }

        private void btnTAMBAH_Click(object sender, EventArgs e)
        {
            PURCHASE.SUBPURCHASE.FormADDITEMRETUR frm = new FormADDITEMRETUR();
            frm.ShowDialog();
        }

        private void btnKELUAR_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

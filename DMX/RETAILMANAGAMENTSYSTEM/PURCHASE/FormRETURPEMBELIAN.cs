using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LOGISTICMANAGAMENTSYSTEM.PURCHASE
{
    public partial class FormRETURPEMBELIAN : Form
    {
        public FormRETURPEMBELIAN()
        {
            InitializeComponent();
            SETTING_MANUAL();
        }
        void SETTING_MANUAL()
        {
            this.Size = new Size(1365, 608);
            this.dgvRETUR.Size = new Size(1360, 500);
            this.panelBUTTON.Location = new Point(2, 560);
            this.gbVIEW.Location = new Point(986, 4);
        }

        private void btnKELUAR_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnTAMBAH_Click(object sender, EventArgs e)
        {
            PURCHASE.SUBPURCHASE.FormADDRETUR frm = new LOGISTICMANAGAMENTSYSTEM.PURCHASE.SUBPURCHASE.FormADDRETUR();
            frm.ShowDialog();
        }
    }
}

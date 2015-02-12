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
    public partial class FormPEMBELIAN : Form
    {
        public FormPEMBELIAN()
        {
            InitializeComponent();
            SETTING_MANUAL();
        }

        void SETTING_MANUAL()
        {
            this.Size = new Size(1365, 608);
            this.dgvPEMBELIAN.Size = new Size(1360, 490);
            this.panelBUTTON.Location = new Point(2, 550);
            this.gbVIEW.Location = new Point(986, 4);
        }

        private void btnKELUAR_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnTAMBAH_Click(object sender, EventArgs e)
        {
            PURCHASE.SUBPURCHASE.FormADDPEMBELIAN frm = new LOGISTICMANAGAMENTSYSTEM.PURCHASE.SUBPURCHASE.FormADDPEMBELIAN();
            frm.ShowDialog();
        }
    }
}

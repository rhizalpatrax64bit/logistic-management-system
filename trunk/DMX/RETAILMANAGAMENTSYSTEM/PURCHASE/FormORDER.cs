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
    public partial class FormORDER : Form
    {
        public FormORDER()
        {
            InitializeComponent();
            SETTING_MANUAL();
        }
        void SETTING_MANUAL()
        {
            this.Size = new Size(1365, 608);
            this.gbORDER.Size = new Size(1360, 145);
            this.dgvORDER.Size = new Size(1360, 346);
            this.panelTOTAL.Location = new Point(1060, 497);
            this.panelBUTTON.Location = new Point(2, 549);
        }

        private void btnKELUAR_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnTAMBAH_Click(object sender, EventArgs e)
        {
            PURCHASE.SUBPURCHASE.FormADDORDER frm = new LOGISTICMANAGAMENTSYSTEM.PURCHASE.SUBPURCHASE.FormADDORDER();
            frm.ShowDialog();
        }
    }
}

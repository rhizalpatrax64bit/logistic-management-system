using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LOGISTICMANAGAMENTSYSTEM.MASTER
{
    public partial class FormMEMBER : Form
    {
        public FormMEMBER()
        {
            InitializeComponent();
            SETTING_MANUAL();
        }

        void SETTING_MANUAL()
        {
            this.Size = new Size(1365, 608);
            this.dgvMEMBER.Size = new Size(1360, 520);
            this.panelBUTTON.Location = new Point(2, 560);
            //this.panelCARI.Location = new Point(790, 4);
        }

        private void btnTAMBAH_Click(object sender, EventArgs e)
        {
            MASTER.SUBMASTER.FormMEMBER frm = new LOGISTICMANAGAMENTSYSTEM.MASTER.SUBMASTER.FormMEMBER();
            frm.ShowDialog();
        }

        private void btnKELUAR_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

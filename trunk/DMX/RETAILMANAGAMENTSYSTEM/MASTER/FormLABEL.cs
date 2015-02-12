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
    public partial class FormLABEL : Form
    {
        public FormLABEL()
        {
            InitializeComponent();
            SETTING_MANUAL();
        }

        void SETTING_MANUAL()
        {
            this.Size = new Size(1365, 608);
            this.dgvBARANG.Size = new Size(1360, 428);
            this.panelLABEL.Location = new Point(2, 550);
            //this.panelCARI.Location = new Point(790, 4);
        }

        private void btnKELUAR_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLABELRAK_Click(object sender, EventArgs e)
        {
            MASTER.SUBMASTER.FormLABEL frm = new LOGISTICMANAGAMENTSYSTEM.MASTER.SUBMASTER.FormLABEL();
            frm.ShowDialog();
        }
    }
}

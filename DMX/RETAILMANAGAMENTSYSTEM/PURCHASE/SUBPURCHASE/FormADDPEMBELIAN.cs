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
    public partial class FormADDPEMBELIAN : Form
    {
        public FormADDPEMBELIAN()
        {
            InitializeComponent();
        }

        private void btnTAMBAH_Click(object sender, EventArgs e)
        {
            PURCHASE.SUBPURCHASE.FormADDITEMPEMBELIAN frm = new FormADDITEMPEMBELIAN();
            frm.ShowDialog();
        }

        private void btnKELUAR_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtKODESUPLIER_KeyUp(object sender, KeyEventArgs e)
        {
          
        }
        public void GET_DATA_SUPPLIER(RMS.COMMON.MASTER.RMS_SUPPLIER obj)
        {
            txtKODESUPLIER.Text = obj.KODE;
            txtNAMASUPLIER.Text = obj.NAMA;
            /*
            if (obj.TEMPO != 0)
            {
                txtTEMPO.Text = obj.TEMPO.ToString();
                txtJATUHTEMPO.Text = DateTime.Now.AddDays(obj.TEMPO).ToString("dd-MM-yyyy");
            }
             */ 
        }


    }
}

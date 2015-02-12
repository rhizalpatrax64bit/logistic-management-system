using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LOGISTICMANAGAMENTSYSTEM.VIEW
{
    public partial class FormTAMBAHPENERIMA : Form
    {
        protected RMS.BUSSINES.MASTER.RMS_PENERIMA b = new RMS.BUSSINES.MASTER.RMS_PENERIMA();
        protected RMS.COMMON.MASTER.RMS_PENERIMA c = new RMS.COMMON.MASTER.RMS_PENERIMA();


        DELIVERYORDER.FormDATAENTRY frm;
        EXPRESS.FormENTRYSO frmSO;
        int Type;
        public FormTAMBAHPENERIMA(DELIVERYORDER.FormDATAENTRY _frm,EXPRESS.FormENTRYSO _frmSO, int _Type)
        {
            InitializeComponent();
            this.Type = _Type;
            if (Type == 1)
            {
                this.frm = _frm;
                c.TYPE = 2;
            }
            else                
            {
                c.TYPE = 1;
                this.frmSO = _frmSO; }
        }

        private void btnSIMPAN_Click(object sender, EventArgs e)
        {

          

            if (string.IsNullOrEmpty(txtNAMACUSTOMER.Text))
            {
                MessageBox.Show("ISI NAMA PENERIMA", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtNAMACUSTOMER.Focus();
                return;
            }
            
            if (string.IsNullOrEmpty(txtALAMAT.Text))
            {
                MessageBox.Show("ISI ALAMAT", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtNAMACUSTOMER.Focus();
                return;
            }

            if (string.IsNullOrEmpty(txtTELP.Text))
            {
                MessageBox.Show("ISI NO TELP", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtTELP.Focus();
                return;
            }

            if (string.IsNullOrEmpty(txtHP.Text))
            {
                MessageBox.Show("ISI NO HP", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtHP.Focus();
                return;
            }
            
            c.KODEPENERIMA = "";            
            c.NAMAPENERIMA = txtNAMACUSTOMER.Text;
            c.ALAMAT = txtALAMAT.Text;
            c.FAX = txtFAX.Text;
            c.TELEPON = txtFAX.Text;
            c.HP = txtHP.Text;
            c.EMAIL = txtEMAIL.Text;

            if (Type == 1)
            {
                b.INSERT(c);
                this.frm.GET_DATA_PENERIMA(c);
            }
            else
            {
                b.INSERT(c);
                this.frmSO.GET_DATA_PENERIMA(c);
            }
          
            CLEAR();
        }

        void CLEAR()
        {
            
            txtNAMACUSTOMER.Text = "";
            txtALAMAT.Text = "";
            txtFAX.Text = "";
            txtEMAIL.Text = "";
            txtTELP.Text = "";
            txtHP.Text = "";

        }

        private void btnBATAL_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

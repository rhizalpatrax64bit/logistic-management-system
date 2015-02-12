using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LOGISTICMANAGAMENTSYSTEM.MASTER.SUBMASTER
{
    public partial class FormBARANGPROMO : Form
    {

        protected RMS.BUSSINES.MASTER.RMS_BARANGPROMO b = new RMS.BUSSINES.MASTER.RMS_BARANGPROMO();
        protected RMS.COMMON.MASTER.RMS_BARANGPROMO c = new RMS.COMMON.MASTER.RMS_BARANGPROMO();

        MASTER.FormBARANGPROMO frm;
        public FormBARANGPROMO(MASTER.FormBARANGPROMO _frm)
        {
            InitializeComponent();
            this.frm = _frm;
        }

        private void btnBATAL_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSIMPAN_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtKODE.Text))
            {
                MessageBox.Show("ISI KODE", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtKODE.Focus();
                return;
            }

            if (string.IsNullOrEmpty(txtNAMA.Text))
            {
                MessageBox.Show("ISI NAMA", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtNAMA.Focus();
                return;
            }

            if (string.IsNullOrEmpty(txtHARGAPOKOK.Text))
            {
                MessageBox.Show("ISI HARGA POKOK", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtHARGAPOKOK.Focus();
                return;
            }

            if (string.IsNullOrEmpty(txtHARGAJUAL.Text))
            {
                MessageBox.Show("ISI HARGA JUAL", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtHARGAJUAL.Focus();
                return;
            }

            if (string.IsNullOrEmpty(txtQTY.Text))
            {
                MessageBox.Show("ISI QTY", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtQTY.Focus();
                return;
            }

            c.BARCODE = txtBARCODE.Text;
            c.KODE = txtKODE.Text;
            c.NAMA = txtNAMA.Text;
            c.HARGAJUAL = decimal.Parse(txtHARGAJUAL.Text);
            c.HARGAPOKOK = decimal.Parse(txtHARGAPOKOK.Text);
            c.QTY = Convert.ToInt32(txtQTY.Text);

            b.INSERT(c);
            this.frm.LOAD_DATA();
            CLEAR();
        }

        void CLEAR()
        {
            txtBARCODE.Text = "";
            txtHARGAJUAL.Text = ""; 
            txtHARGAPOKOK.Text = "";
            txtKODE.Text = "";
            txtNAMA.Text = "";
            txtPROFIT.Text = "";
            txtQTY.Text = "";
            txtBARCODE.Focus();
        }

       
    }
}

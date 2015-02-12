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
    public partial class FormSALES : Form
    {
        protected RMS.BUSSINES.MASTER.RMS_SALES b = new RMS.BUSSINES.MASTER.RMS_SALES();
        protected RMS.COMMON.MASTER.RMS_SALES c = new RMS.COMMON.MASTER.RMS_SALES();
        MASTER.FormSALES frm;
        int Type;
        public FormSALES(MASTER.FormSALES _frm, int Type, RMS.COMMON.MASTER.RMS_SALES obj)
        {
            InitializeComponent();
            this.frm = _frm;
            this.Type = Type;

            if (Type == 1)
            {
               LOAD_DATA(obj);
            }
        }
        void LOAD_DATA(RMS.COMMON.MASTER.RMS_SALES obj)
        {
            txtKODE.Enabled = false;
            DataTable dt = b.CARI_BYKODE(obj);
            if (dt.Rows.Count > 0)
            {

                txtKODE.Text = dt.Rows[0]["KODESALES"].ToString();
                txtNAMA.Text = dt.Rows[0]["NAMASALES"].ToString();
                txtALAMAT.Text = dt.Rows[0]["ALAMAT"].ToString();
                txtTLP.Text = dt.Rows[0]["TELEPON"].ToString();
                txtEMAIL.Text = dt.Rows[0]["EMAIL"].ToString();
                
            }
        }

        private void btnBATAL_Click(object sender, EventArgs e)
        {
            this.Close();
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

            c.KODE = txtKODE.Text;
            if (Type == 0)
            {
                DataTable dt = b.CARI_BYKODE(c);
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("KODE : " + c.KODE + " SUDAH TERDAFTAR", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }
            }

            c.NAMA = txtNAMA.Text;
            c.ALAMAT = txtALAMAT.Text;
            c.TELP= txtTLP.Text;
            c.EMAIL = txtEMAIL.Text;
            
            
            if (Type == 0)
            {
                b.INSERT(c);
                this.frm.LOAD_DATA();
            }
            else
            {
                b.UPDATE(c);
                this.frm.LOAD_DATA();
                Close();
            }
            CLEAR();
              
        }
        void CLEAR()
        {
            txtKODE.Focus();
            txtKODE.Text = "";
            txtNAMA.Text = "";
            txtALAMAT.Text = "";
            txtEMAIL.Text = "";
            txtTLP.Text = "";

        }
    }
}

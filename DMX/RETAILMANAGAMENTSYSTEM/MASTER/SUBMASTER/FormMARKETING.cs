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
    public partial class FormMARKETING : Form
    {
        protected RMS.BUSSINES.MASTER.RMS_MARKETING b = new RMS.BUSSINES.MASTER.RMS_MARKETING();
        protected RMS.COMMON.MASTER.RMS_MARKETING c = new RMS.COMMON.MASTER.RMS_MARKETING();
        MASTER.FormMARKETING frm;
        int Type;
        public FormMARKETING(MASTER.FormMARKETING _frm, int Type, RMS.COMMON.MASTER.RMS_MARKETING obj)
        {
            InitializeComponent();
            this.frm = _frm;
            this.Type = Type;
            txtKODE.Text = GETKODE();
            if (Type == 1)
            {
                LOAD_DATA(obj);
            }
        }
        public string GETKODE()
        {
            string newkode;
            int last_insert;
            int new_insert;
            DataTable dt = b.GETKODE();
            if (string.IsNullOrEmpty(dt.Rows[0]["LAST_ID"].ToString()))
            {
                last_insert = 0;
            }
            else
            {
                last_insert = int.Parse(dt.Rows[0]["LAST_ID"].ToString());
            }
            new_insert = last_insert+1;
            if (new_insert < 10)
            {
                newkode = "M0" + new_insert;
            }
            else
            {
                newkode = "M" + new_insert;
            }
            
            return newkode;
        }	
        void LOAD_DATA(RMS.COMMON.MASTER.RMS_MARKETING obj)
        {
            txtKODE.Enabled = false;
            DataTable dt = b.CARI_BYKODE(obj);
            if (dt.Rows.Count > 0)
            {

                txtKODE.Text = dt.Rows[0]["KODE"].ToString();
                txtNAMA.Text = dt.Rows[0]["NAMA"].ToString();
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
            if (string.IsNullOrEmpty(txtALAMAT.Text))
            {
                MessageBox.Show("ISI ALAMAT", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtALAMAT.Focus();
                return;
            }

            if (string.IsNullOrEmpty(txtTLP.Text))
            {
                MessageBox.Show("ISI NAMA TELEPON", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtTLP.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txtEMAIL.Text))
            {
                MessageBox.Show("ISI NAMA EMAIL", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtEMAIL.Focus();
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

        private void txtEMAIL_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                txtTLP.Focus();
            }
            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }

        private void txtTLP_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                txtALAMAT.Focus();
            }
            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }

        private void txtALAMAT_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                txtNAMA.Focus();
            }
            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }

        private void txtNAMA_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
               txtKODE.Focus();
            }
            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }

        private void txtKODE_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }

        private void FormMARKETING_Load(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

    }
}

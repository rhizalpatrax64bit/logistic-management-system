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
    public partial class FormGUDANG : Form
    {
        protected RMS.BUSSINES.MASTER.RMS_GUDANG b = new RMS.BUSSINES.MASTER.RMS_GUDANG();
        protected RMS.COMMON.MASTER.RMS_GUDANG c = new RMS.COMMON.MASTER.RMS_GUDANG();

        MASTER.FormGUDANG frm;
        int Type;
        public FormGUDANG(MASTER.FormGUDANG _frm, int Type, RMS.COMMON.MASTER.RMS_GUDANG obj)
        {
            InitializeComponent();
            this.Type = Type;
            this.frm = _frm;

            if (Type == 1)
            {
                LOAD_DATA(obj);
            }

        }

        void LOAD_DATA(RMS.COMMON.MASTER.RMS_GUDANG obj)
        {
            txtKODE.Enabled = false;
            DataTable dt = b.SEARCH_BYKODE(obj);
            if (dt.Rows.Count > 0)
            {
                txtKODE.Text = dt.Rows[0]["KODEGUDANG"].ToString();
                txtNAMA.Text = dt.Rows[0]["NAMAGUDANG"].ToString();
                txtKETERANGAN.Text = dt.Rows[0]["KETERANGAN"].ToString();
            }
        }

        private void btnBATAL_Click(object sender, EventArgs e)
        {

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
            c.NAMA = txtNAMA.Text;
            c.KETERANGAN = txtKETERANGAN.Text;

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
            txtKODE.Text = "";
            txtNAMA.Text = "";
            txtKETERANGAN.Text = "";
            txtKODE.Focus();
        }
    }
}

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
    public partial class FormBANK : Form
    {
        protected RMS.BUSSINES.MASTER.RMS_BANK b = new RMS.BUSSINES.MASTER.RMS_BANK();
        protected RMS.COMMON.MASTER.RMS_BANK c = new RMS.COMMON.MASTER.RMS_BANK();

        MASTER.FormBANK frm;
        int Type;
        public FormBANK(MASTER.FormBANK _frm, int Type, RMS.COMMON.MASTER.RMS_BANK obj)
        {
            InitializeComponent();
            this.frm = _frm;
            this.Type = Type;

            if (Type == 1)
            {
                LOAD_DATA(obj);
            }
        }

        void LOAD_DATA(RMS.COMMON.MASTER.RMS_BANK obj)
        {
            txtKODE.Enabled = false;
            DataTable dt = b.CARI_BYKODE(obj);
            if (dt.Rows.Count > 0)
            {
                txtKODE.Text = dt.Rows[0]["KODEBANK"].ToString();
                txtNAMA.Text = dt.Rows[0]["NAMABANK"].ToString();
            }
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
        }

        private void btnBATAL_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

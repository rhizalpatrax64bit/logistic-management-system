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
    public partial class FormSATUAN : Form
    {

        protected RMS.BUSSINES.MASTER.RMS_SATUAN b = new RMS.BUSSINES.MASTER.RMS_SATUAN();
        protected RMS.COMMON.MASTER.RMS_SATUAN c = new RMS.COMMON.MASTER.RMS_SATUAN();

        MASTER.FormSATUAN frm;
        int Type;
        public FormSATUAN(MASTER.FormSATUAN _frm,int Type,RMS.COMMON.MASTER.RMS_SATUAN obj)
        {
            InitializeComponent();
            this.Type = Type;
            this.frm = _frm;

            if (Type == 1)
            {
                LOAD_DATA(obj);
            }
        }

        void LOAD_DATA(RMS.COMMON.MASTER.RMS_SATUAN obj)
        {
            txtKODE.Enabled = false;
            DataTable dt = b.CARI_BYKODE(obj);
            if (dt.Rows.Count > 0)
            {
                txtKODE.Text = dt.Rows[0]["KODESATUAN"].ToString();
                txtNAMA.Text = dt.Rows[0]["NAMASATUAN"].ToString();
                txtISI.Text= dt.Rows[0]["ISI"].ToString();
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
            if (string.IsNullOrEmpty(txtISI.Text))
            {
                MessageBox.Show("ISI KOSONG", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtISI.Focus();
                return;
            }

            c.KODE = txtKODE.Text;
            if (Type == 0)
            {
                DataTable dt = b.CARI_BYKODE(c);
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("KODE : " + txtKODE.Text + " SUDAH TERDAFTAR", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }
            }
            c.NAMA = txtNAMA.Text;
            c.ISI = Convert.ToInt32(txtISI.Text);
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
            txtISI.Text = "";
        }
    }
}

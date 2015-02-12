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
    public partial class FormAREA : Form
    {
        protected RMS.BUSSINES.MASTER.RMS_KOTA b = new RMS.BUSSINES.MASTER.RMS_KOTA();
        protected RMS.COMMON.MASTER.RMS_KOTA c = new RMS.COMMON.MASTER.RMS_KOTA();
        MASTER.FormKOTA frm;
        int Type;
        public FormAREA(MASTER.FormKOTA _frm, int Type, RMS.COMMON.MASTER.RMS_KOTA obj)
        {
            InitializeComponent();
            this.frm = _frm;
            this.Type = Type;

            if (Type == 1)
            {
                LOAD_DATA(obj);
            }
        }
        void LOAD_DATA(RMS.COMMON.MASTER.RMS_KOTA obj)
        {
            txtKODE.Enabled = false;
           
            DataTable dt = b.CARI_BYIDAREA(obj);
            if (dt.Rows.Count > 0)
            {
                c.IDAREA = int.Parse(dt.Rows[0]["IDAREA"].ToString());
                txtKODE.Text = dt.Rows[0]["KODEAREA"].ToString();
                txtNAMA.Text = dt.Rows[0]["NAMAAREA"].ToString();
                               
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

            c.KODEAREA = txtKODE.Text;
            if (Type == 0)
            {
                DataTable dt = b.CARI_BYKODE(c);
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("KODE : " + c.KODEKOTA + " SUDAH TERDAFTAR", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }
            }

            c.KODEAREA = txtKODE.Text;
            c.NAMAAREA = txtNAMA.Text;
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
        }

        private void btnBATAL_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}

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
    public partial class FormDEPARTMENT : Form
    {
        MASTER.FormDEPARTMENT frm;
        int Type;
        public FormDEPARTMENT(MASTER.FormDEPARTMENT _frm, int Type, RMS.COMMON.MASTER.RMS_DEPARTMENT obj)
        {
            this.frm = _frm;
            this.Type = Type;
            InitializeComponent();
            if (Type == 1)
            {
                LOAD_DATA(obj);
            }
        }
        void LOAD_DATA(RMS.COMMON.MASTER.RMS_DEPARTMENT obj)
        {
            txtKODE.Enabled = false;
            DataTable dt = b.CARI_BYKODE(obj);
            if (dt.Rows.Count > 0)
            {
                txtKODE.Text = dt.Rows[0]["KODEDEPARTMENT"].ToString();
                txtNAMA.Text = dt.Rows[0]["NAMADEPARTMENT"].ToString();
                txtMIN.Text = dt.Rows[0]["MINMARGIN"].ToString();
                txtMAX.Text = dt.Rows[0]["MAXMARGIN"].ToString();
            }
        }

        protected RMS.BUSSINES.MASTER.RMS_DEPARTMENT b = new RMS.BUSSINES.MASTER.RMS_DEPARTMENT();
        protected RMS.COMMON.MASTER.RMS_DEPARTMENT c = new RMS.COMMON.MASTER.RMS_DEPARTMENT();
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

            if (string.IsNullOrEmpty(txtMIN.Text))
            {
                MessageBox.Show("ISI MIN MARGIN", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtMIN.Focus();
                return;
            }

            if (string.IsNullOrEmpty(txtMAX.Text))
            {
                MessageBox.Show("ISI MAX MARGIN", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtMAX.Focus();
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
            c.MINMARGIN = Convert.ToInt32(txtMIN.Text);
            c.MAXMARGIN = Convert.ToInt32(txtMAX.Text);
            c.KETERANGAN = txtKET.Text;

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
            txtMAX.Text = "";
            txtMIN.Text = "";
            txtNAMA.Text = "";
            txtKET.Text = "";
            txtKODE.Focus();
        }
    }
}

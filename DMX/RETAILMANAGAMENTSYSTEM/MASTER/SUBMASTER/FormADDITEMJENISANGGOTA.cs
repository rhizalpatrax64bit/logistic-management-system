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
    public partial class FormADDITEMJENISANGGOTA : Form
    {
        protected RMS.BUSSINES.MASTER.RMS_JENISANGGOTA b = new RMS.BUSSINES.MASTER.RMS_JENISANGGOTA();
        protected RMS.COMMON.MASTER.RMS_JENISANGGOTA c = new RMS.COMMON.MASTER.RMS_JENISANGGOTA();


        MASTER.SUBMASTER.FormMEMBER frm;
        int Type;
        public FormADDITEMJENISANGGOTA(MASTER.SUBMASTER.FormMEMBER _frm,int Type)
        {
            InitializeComponent();
            this.frm = _frm;
            this.Type = Type;
            LOAD_DATA();
        }

        void LOAD_DATA()
        {
            dgvJENIS.DataSource = null;
            dgvJENIS.Rows.Clear();
            DataTable dt = b.SELECT();
            dgvJENIS.DataSource = dt;
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
                MessageBox.Show("ISI JENIS KEANGGOTAAN", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Stop);
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
            b.INSERT(c);
            this.frm.LOAD_DATA_JENISANGGOTA();
            txtKODE.Text = "";
            txtNAMA.Text = "";
            txtKODE.Focus();
            LOAD_DATA();
        }

        private void btnHAPUS_Click(object sender, EventArgs e)
        {
            if (dgvJENIS.SelectedCells.Count > 0)
            {
                string kode = dgvJENIS.SelectedCells[0].OwningRow.Cells["KODE"].Value.ToString();
                string nama = dgvJENIS.SelectedCells[0].OwningRow.Cells["JENISKEANGGOTAAN"].Value.ToString();
                c.KODE = kode;
                DialogResult dr = MessageBox.Show("APAKAH YAKIN AKAN DELETE DATA : " + nama + " ?", "WARNING", MessageBoxButtons.OKCancel, MessageBoxIcon.Stop);
                if (dr == DialogResult.OK)
                {
                    b.DELETE(c);
                    LOAD_DATA();
                }
            }
        }
    }
}

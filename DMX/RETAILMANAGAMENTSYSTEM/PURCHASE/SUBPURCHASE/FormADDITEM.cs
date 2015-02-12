using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LOGISTICMANAGAMENTSYSTEM.PURCHASE.SUBPURCHASE
{
    public partial class FormADDITEM : Form
    {
        protected RMS.COMMON.MASTER.RMS_BARANG c = new RMS.COMMON.MASTER.RMS_BARANG();
        protected RMS.BUSSINES.MASTER.RMS_BARANG b = new RMS.BUSSINES.MASTER.RMS_BARANG();
        protected RMS.BUSSINES.MASTER.RMS_DEPARTMENT bd = new RMS.BUSSINES.MASTER.RMS_DEPARTMENT();
        protected RMS.COMMON.MASTER.RMS_DEPARTMENT cd = new RMS.COMMON.MASTER.RMS_DEPARTMENT();

        PURCHASE.SUBPURCHASE.FormADDITEMPEMBELIAN frm;
        public FormADDITEM(PURCHASE.SUBPURCHASE.FormADDITEMPEMBELIAN _frm)
        {
            InitializeComponent();
            this.frm = _frm;
        }
        private void btnBATAL_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void txtKODEDEPT_KeyUp(object sender, KeyEventArgs e)
        {
            if (!string.IsNullOrEmpty(txtKODEDEPT.Text)) return;
            if (e.KeyCode == Keys.Enter)
            {
                VIEW.FormVIEWDEPARTMENT frm = new LOGISTICMANAGAMENTSYSTEM.VIEW.FormVIEWDEPARTMENT(this);
                frm.ShowDialog();
            }
        }
        public void GETA_KODE_BARANG(RMS.COMMON.MASTER.RMS_DEPARTMENT obj)
        {
            txtKODEDEPT.Text = obj.KODE;
            txtNAMADEPT.Text = obj.NAMA;
            txtKODEBARANG.Text = GENERATE_NUMBER();
        }
        public void GETA_KODE_SATUAN(RMS.COMMON.MASTER.RMS_SATUAN obj)
        {
            txtUNIT.Text = obj.NAMA;
            txtISIUNIT.Text = obj.ISI.ToString();
        }
        string GENERATE_NUMBER()
        {
            string kode = string.Empty;
            kode = txtKODEDEPT.Text +DateTime.Now.ToString("ddMMyyHHmmss");
            return kode;
        }
        private void txtUNIT_KeyUp(object sender, KeyEventArgs e)
        {
            if (!string.IsNullOrEmpty(txtUNIT.Text)) return;
            if (e.KeyCode == Keys.Enter)
            {
                VIEW.FormVIEWSATUAN frm = new LOGISTICMANAGAMENTSYSTEM.VIEW.FormVIEWSATUAN(this);
                frm.ShowDialog();
            }
        }

        private void btnSIMPAN_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtKODEDEPT.Text))
            {
                MessageBox.Show("ISI DEPARTMENT", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtKODEDEPT.Focus();
                return;
            }

            if (string.IsNullOrEmpty(txtKODEBARANG.Text))
            {
                MessageBox.Show("ISI KODE BARANG", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtKODEBARANG.Focus();
                return;
            }

            if (string.IsNullOrEmpty(txtNAMABARANG.Text))
            {
                MessageBox.Show("ISI NAMA BARANG", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtNAMABARANG.Focus();
                return;
            }

            if (string.IsNullOrEmpty(txtUNIT.Text))
            {
                MessageBox.Show("ISI UNIT/SATUAN", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtUNIT.Focus();
                return;
            }

            c.KODEBARANG = txtKODEBARANG.Text;
            c.BARCODE = txtBARCODE.Text;

            //CEK KODE BARANG DAN BARCODE
            DataTable kd = b.CARI_BYKODE(c);
            if (kd.Rows.Count > 0)
            {
                MessageBox.Show("KODE BARANG : " + txtKODEBARANG.Text + " SUDAH TERDAFTAR.", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            DataTable bc = b.CARI_BYBARCODE(c);
            if (bc.Rows.Count > 0)
            {
                MessageBox.Show("KODE BARCODE : " + txtBARCODE.Text + " SUDAH TERDAFTAR.", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            c.NAMABARANG = txtNAMABARANG.Text;
            c.KODESATUAN = txtISIUNIT.Text;
            c.NAMASATUAN = txtUNIT.Text;
            c.KODEDEPT = txtKODEDEPT.Text;
            c.NAMADEPT = txtNAMADEPT.Text;

            c.STOK = 0;
            c.TOTALPCS = 0;
            c.HARGABELI1 = 0;
            c.HARGABELI2 = 0;
            c.BRUTO = 0;
            c.DISKONRP1 = 0;
            c.DISKONRP2 = 0;
            c.DISKONPSN1 = 0;
            c.DISKONPSN2 = 0;
            c.DISKONPSN3 = 0;
            c.DISKONPSN4 = 0;
            c.DISKONPSN5 = 0;
            c.PPN = 0;
            c.NETTO = 0;
            c.HARGAPOKOKBELI1 = 0;
            c.HARGAPOKOKBELI2 = 0;
            c.MARGIN1 = 0;
            c.HARGAJUAL1 = 0;
            c.HARGAJUAL2 = 0;
            c.MARGINSPESIAL = 0;
            c.HARGASPESIAL = 0;
            c.QTY1 = 0;
            c.QTY2 = 0;
            c.QTY3 = 0;
            c.QTY4 = 0;
            c.QTY5 = 0;
            c.MRG1 = 0;
            c.MRG2 = 0;
            c.MRG3 = 0;
            c.MRG4 = 0;
            c.MRG5 = 0;
            c.HRG1 = 0;
            c.HRG2 = 0;
            c.HRG3 = 0;
            c.HRG4 = 0;
            c.HRG5 = 0;
            c.RESET = false;
            c.GUDANG = "";
            c.TGLBELI = DateTime.Now;
            c.TGLEXPIRED = DateTime.MinValue;
            c.TGLUPDATE = DateTime.MinValue;

            // get value maxmargin & minmargin
            cd.KODE = c.KODEDEPT;
            DataTable dt = bd.CARI_BYKODE(cd);
            if (dt.Rows.Count > 0)
            {
                c.BATASMARGIN1 = float.Parse(dt.Rows[0]["MINMARGIN"].ToString());
                c.BATASMARGIN2 = float.Parse(dt.Rows[0]["MAXMARGIN"].ToString());
            }
            else
            {
                MessageBox.Show("DEPARTMENT BELUM TERDAFTAR PADA SISTEM", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtKODEDEPT.Focus();
                return;
            }

            // INSERT DATA TO DATABASE
            b.INSERT(c);
            this.frm.GET_DATA(c);
            Close();
        }
        
    }
}

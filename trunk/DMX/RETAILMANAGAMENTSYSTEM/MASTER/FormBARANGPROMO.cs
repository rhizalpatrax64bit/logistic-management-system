using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LOGISTICMANAGAMENTSYSTEM.MASTER
{
    public partial class FormBARANGPROMO : Form
    {
        protected RMS.BUSSINES.MASTER.RMS_BARANGPROMO b = new RMS.BUSSINES.MASTER.RMS_BARANGPROMO();
        protected RMS.COMMON.MASTER.RMS_BARANGPROMO c = new RMS.COMMON.MASTER.RMS_BARANGPROMO();

        public FormBARANGPROMO()
        {
            InitializeComponent();
            SETTING_MANUAL();
            LOAD_DATA();
        }
        void SETTING_MANUAL()
        {
            this.Size = new Size(1365, 608);
            this.dgvPROMO.Size = new Size(1360, 520);
            this.panelBUTTON.Location = new Point(2, 560);
            this.panelCARI.Location = new Point(819, 4);
        }

        public void LOAD_DATA()
        {
            dgvPROMO.DataSource = null;
            dgvPROMO.Rows.Clear();

            DataTable dt = b.SELECT();
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    string barcode = dt.Rows[i]["BARCODE"].ToString();
                    string kode = dt.Rows[i]["KODEPROMO"].ToString();
                    string nama = dt.Rows[i]["NAMAPROMO"].ToString();
                    decimal beli = decimal.Parse(dt.Rows[i]["HARGAPOKOK"].ToString());
                    string hargapokok = string.Format("{0:0,0}", beli);
                    decimal jual = decimal.Parse(dt.Rows[i]["HARGAJUAL"].ToString());
                    string profit = dt.Rows[i]["MARGINPROFIT"].ToString();
                    string hargajual = string.Format("{0:0,0}", jual);
                    string qty = dt.Rows[i]["QTY"].ToString();
                    dgvPROMO.Rows.Add(kode, nama, barcode, hargapokok, profit, hargajual, qty);
                }
            }
        }

        private void btnKELUAR_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnTAMBAH_Click(object sender, EventArgs e)
        {
            MASTER.SUBMASTER.FormBARANGPROMO frm = new LOGISTICMANAGAMENTSYSTEM.MASTER.SUBMASTER.FormBARANGPROMO(this);
            frm.ShowDialog();
        }

        private void btnHAPUS_Click(object sender, EventArgs e)
        {
            if (dgvPROMO.SelectedCells.Count > 0)
            {
                string kode = dgvPROMO.SelectedCells[0].OwningRow.Cells["KODE"].Value.ToString();
                string nama = dgvPROMO.SelectedCells[0].OwningRow.Cells["NAMA"].Value.ToString();
                c.KODE = kode;
                DialogResult dr = MessageBox.Show("APAKAH YAKIN AKAN DELETE DATA : " + nama + " ?", "WARNING", MessageBoxButtons.OKCancel, MessageBoxIcon.Stop);
                if (dr == DialogResult.OK)
                {
                    b.DELETE(c);
                    LOAD_DATA();
                }
            }
        }

        private void FormBARANGPROMO_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F3)
            {
                rdbKODE.Checked = true;
                txtCARI.Text = "";
                txtCARI.Focus();
            }

            if (e.KeyCode == Keys.F4)
            {
                rdbNAMA.Checked = true;
                txtCARI.Text = "";
                txtCARI.Focus();
            }
        }

        private void txtCARI_TextChanged(object sender, EventArgs e)
        {
            if (rdbKODE.Checked == true)
            {
                dgvPROMO.DataSource = null;
                dgvPROMO.Rows.Clear();

                c.KODE = txtCARI.Text;
                DataTable dt = b.SEARCH_BYKODE(c);
                if (dt.Rows.Count > 0)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        string barcode = dt.Rows[i]["BARCODE"].ToString();
                        string kode = dt.Rows[i]["KODEPROMO"].ToString();
                        string nama = dt.Rows[i]["NAMAPROMO"].ToString();
                        decimal beli = decimal.Parse(dt.Rows[i]["HARGAPOKOK"].ToString());
                        string hargapokok = string.Format("{0:0,0}", beli);
                        decimal jual = decimal.Parse(dt.Rows[i]["HARGAJUAL"].ToString());
                        string profit = dt.Rows[i]["MARGINPROFIT"].ToString();
                        string hargajual = string.Format("{0:0,0}", jual);
                        string qty = dt.Rows[i]["QTY"].ToString();
                        dgvPROMO.Rows.Add(kode, nama, barcode, hargapokok, profit, hargajual, qty);
                    }
                }
            }

            if (rdbNAMA.Checked == true)
            {
                dgvPROMO.DataSource = null;
                dgvPROMO.Rows.Clear();

                c.NAMA = txtCARI.Text;
                DataTable dt = b.SEARCH_BYNAMA(c);
                if (dt.Rows.Count > 0)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        string barcode = dt.Rows[i]["BARCODE"].ToString();
                        string kode = dt.Rows[i]["KODEPROMO"].ToString();
                        string nama = dt.Rows[i]["NAMAPROMO"].ToString();
                        decimal beli = decimal.Parse(dt.Rows[i]["HARGAPOKOK"].ToString());
                        string hargapokok = string.Format("{0:0,0}", beli);
                        decimal jual = decimal.Parse(dt.Rows[i]["HARGAJUAL"].ToString());
                        string profit = dt.Rows[i]["MARGINPROFIT"].ToString();
                        string hargajual = string.Format("{0:0,0}", jual);
                        string qty = dt.Rows[i]["QTY"].ToString();
                        dgvPROMO.Rows.Add(kode, nama, barcode, hargapokok, profit, hargajual, qty);
                    }
                }

            }
        }

    }
}

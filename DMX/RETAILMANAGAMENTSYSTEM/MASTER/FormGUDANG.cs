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
    public partial class FormGUDANG : Form
    {
        protected RMS.BUSSINES.MASTER.RMS_GUDANG b = new RMS.BUSSINES.MASTER.RMS_GUDANG();
        protected RMS.COMMON.MASTER.RMS_GUDANG c = new RMS.COMMON.MASTER.RMS_GUDANG();
        public FormGUDANG()
        {
            InitializeComponent();
            SETTING_MANUAL();
            LOAD_DATA();
        }
        void SETTING_MANUAL()
        {
            this.Size = new Size(1365, 608);
            this.dgvGUDANG.Size = new Size(1358, 520);
            this.panelBUTTON.Location = new Point(2, 560);
            this.labelINFO.Location = new Point(1094, 4);
        }
        public void LOAD_DATA()
        {
            dgvGUDANG.DataSource = null;
            dgvGUDANG.Rows.Clear();

            DataTable dt = b.SELECT();
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    string kode = dt.Rows[i]["KODEGUDANG"].ToString();
                    string nama = dt.Rows[i]["NAMAGUDANG"].ToString();
                    string keterangan = dt.Rows[i]["KETERANGAN"].ToString();
                    dgvGUDANG.Rows.Add(kode, nama, keterangan);
                }
            }
            
        }
        private void btnKELUAR_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void btnTAMBAH_Click(object sender, EventArgs e)
        {
            MASTER.SUBMASTER.FormGUDANG frm = new LOGISTICMANAGAMENTSYSTEM.MASTER.SUBMASTER.FormGUDANG(this,0,null);
            frm.ShowDialog();
        }
        private void btnEDIT_Click(object sender, EventArgs e)
        {
            if (dgvGUDANG.SelectedCells.Count > 0)
            {
                string kode = dgvGUDANG.SelectedCells[0].OwningRow.Cells["KODE"].Value.ToString();
                c.KODE = kode;
                MASTER.SUBMASTER.FormGUDANG frm = new LOGISTICMANAGAMENTSYSTEM.MASTER.SUBMASTER.FormGUDANG(this, 1, c);
                frm.ShowDialog();
            }
        }
        private void FormGUDANG_KeyUp(object sender, KeyEventArgs e)
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
                dgvGUDANG.DataSource = null;
                dgvGUDANG.Rows.Clear();

                c.KODE = txtCARI.Text;
                DataTable dt = b.SEARCH_BYKODE(c);
                if (dt.Rows.Count > 0)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        string kode = dt.Rows[i]["KODEGUDANG"].ToString();
                        string nama = dt.Rows[i]["NAMAGUDANG"].ToString();
                        string keterangan = dt.Rows[i]["KETERANGAN"].ToString();
                        dgvGUDANG.Rows.Add(kode, nama, keterangan);
                    }
                }
            }

            if (rdbNAMA.Checked == true)
            {
                dgvGUDANG.DataSource = null;
                dgvGUDANG.Rows.Clear();

                c.NAMA = txtCARI.Text;
                DataTable dt = b.SEARCH_BYNAMA(c);
                if (dt.Rows.Count > 0)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        string kode = dt.Rows[i]["KODEGUDANG"].ToString();
                        string nama = dt.Rows[i]["NAMAGUDANG"].ToString();
                        string keterangan = dt.Rows[i]["KETERANGAN"].ToString();
                        dgvGUDANG.Rows.Add(kode, nama, keterangan);
                    }
                }
            }
        }
        private void btnHAPUS_Click(object sender, EventArgs e)
        {
            if (dgvGUDANG.SelectedCells.Count > 0)
            {
                string kode = dgvGUDANG.SelectedCells[0].OwningRow.Cells["KODE"].Value.ToString();
                string nama = dgvGUDANG.SelectedCells[0].OwningRow.Cells["NAMA"].Value.ToString();
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

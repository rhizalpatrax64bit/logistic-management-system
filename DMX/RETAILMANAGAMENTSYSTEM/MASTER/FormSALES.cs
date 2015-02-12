using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using System.Windows.Forms;

namespace LOGISTICMANAGAMENTSYSTEM.MASTER
{
    public partial class FormSALES : Form
    {
        protected RMS.BUSSINES.MASTER.RMS_SALES b = new RMS.BUSSINES.MASTER.RMS_SALES();
        protected RMS.COMMON.MASTER.RMS_SALES c = new RMS.COMMON.MASTER.RMS_SALES();
        DataTable dataPrint;
        public FormSALES()
        {
            InitializeComponent();
            SETTING_MANUAL();
            LOAD_DATA();
        }
        void SETTING_MANUAL()
        {
            this.Size = new Size(1365, 608);
            this.dgvSALES.Size = new Size(1360, 520);
            this.panelBUTTON.Location = new Point(2, 560);
            // this.panelCARI.Location = new Point(790, 4);

        }
        public void LOAD_DATA()
        {
            dgvSALES.DataSource = null;
            dgvSALES.Rows.Clear();

            DataTable dt = b.SELECT();
            dataPrint = new DataTable();
            dataPrint = dt;
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    string kode = dt.Rows[i]["KODESALES"].ToString();
                    string nama = dt.Rows[i]["NAMASALES"].ToString();
                    string alamat = dt.Rows[i]["ALAMAT"].ToString();
                    string telp = dt.Rows[i]["TELEPON"].ToString();
                    string email = dt.Rows[i]["EMAIL"].ToString();
                 
                    dgvSALES.Rows.Add(kode, nama, alamat, telp, email);
                }
            }

        }

        private void FormSALES_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                txtCARI.Focus();
            }

            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }

           
        }

        private void txtCARI_TextChanged(object sender, EventArgs e)
        {
           
                dgvSALES.DataSource = null;
                dgvSALES.Rows.Clear();

                c.NAMA = txtCARI.Text;
                c.KODE = txtCARI.Text;
                DataTable dt = b.SEARCH_BYNAMA(c);
                dataPrint = new DataTable();
                dataPrint = dt;
                if (dt.Rows.Count > 0)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        string kode = dt.Rows[i]["KODESALES"].ToString();
                        string nama = dt.Rows[i]["NAMASALES"].ToString();
                        string alamat = dt.Rows[i]["ALAMAT"].ToString();
                        string telp = dt.Rows[i]["TELEPON"].ToString();
                        string email = dt.Rows[i]["EMAIL"].ToString();

                        dgvSALES.Rows.Add(kode, nama, alamat, telp, email);
                    }
                }
            
        }

        private void btnTAMBAH_Click(object sender, EventArgs e)
        {
            MASTER.SUBMASTER.FormSALES frm = new LOGISTICMANAGAMENTSYSTEM.MASTER.SUBMASTER.FormSALES(this, 0, null);
            frm.ShowDialog();
        }

        private void btnEDIT_Click(object sender, EventArgs e)
        {
            if (dgvSALES.SelectedCells.Count > 0)
            {
                string kode = dgvSALES.SelectedCells[0].OwningRow.Cells["KODESALES"].Value.ToString();
                c.KODE = kode;
                MASTER.SUBMASTER.FormSALES frm = new LOGISTICMANAGAMENTSYSTEM.MASTER.SUBMASTER.FormSALES(this, 1, c);
                frm.ShowDialog();
            }
        }

        private void btnKELUAR_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnHAPUS_Click(object sender, EventArgs e)
        {
            if (dgvSALES.SelectedCells.Count > 0)
            {
                string kode = dgvSALES.SelectedCells[0].OwningRow.Cells["KODESALES"].Value.ToString();
                string nama = dgvSALES.SelectedCells[0].OwningRow.Cells["NAMASALES"].Value.ToString();
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

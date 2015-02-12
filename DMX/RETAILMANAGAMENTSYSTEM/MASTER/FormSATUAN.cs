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
    public partial class FormSATUAN : Form
    {
        protected RMS.BUSSINES.MASTER.RMS_SATUAN b = new RMS.BUSSINES.MASTER.RMS_SATUAN();
        protected RMS.COMMON.MASTER.RMS_SATUAN c = new RMS.COMMON.MASTER.RMS_SATUAN();

        public FormSATUAN()
        {
            InitializeComponent();
            SETTING_MANUAL();
            LOAD_DATA();
        }

        void SETTING_MANUAL()
        {
            this.Size = new Size(1365, 608);
            this.dgvSATUAN.Size = new Size(1358, 520);
            this.panelBUTTON.Location = new Point(2, 560);
            this.labelINFO.Location = new Point(1094, 4);
        }

        public void LOAD_DATA()
        {
            dgvSATUAN.DataSource = null;
            dgvSATUAN.Rows.Clear();
            DataTable dt = b.SELECT();
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    string KODE = dt.Rows[i]["KODESATUAN"].ToString();
                    string NAMA = dt.Rows[i]["NAMASATUAN"].ToString();
                   dgvSATUAN.Rows.Add(KODE, NAMA);
                }
            }
        }

        private void btnTAMBAH_Click(object sender, EventArgs e)
        {
            MASTER.SUBMASTER.FormSATUAN frm = new LOGISTICMANAGAMENTSYSTEM.MASTER.SUBMASTER.FormSATUAN(this,0,null);
            frm.ShowDialog();
        }

        private void btnKELUAR_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnEDIT_Click(object sender, EventArgs e)
        {
            if (dgvSATUAN.SelectedCells.Count > 0)
            {
                string kode = dgvSATUAN.SelectedCells[0].OwningRow.Cells["KODE"].Value.ToString();
                c.KODE = kode;
                MASTER.SUBMASTER.FormSATUAN frm = new LOGISTICMANAGAMENTSYSTEM.MASTER.SUBMASTER.FormSATUAN(this, 1, c);
                frm.ShowDialog();
            }
        }

        private void btnHAPUS_Click(object sender, EventArgs e)
        {
            if (dgvSATUAN.SelectedCells.Count > 0)
            {
                string kode = dgvSATUAN.SelectedCells[0].OwningRow.Cells["KODE"].Value.ToString();
                string nama = dgvSATUAN.SelectedCells[0].OwningRow.Cells["NAMA"].Value.ToString();
                c.KODE = kode;
                DialogResult dr = MessageBox.Show("APAKAH YAKIN AKAN DELETE DATA : " + nama + " ?", "WARNING", MessageBoxButtons.OKCancel, MessageBoxIcon.Stop);
                if (dr == DialogResult.OK)
                {
                    b.DELETE(c);
                    LOAD_DATA();
                }
            }
        }

        private void FormSATUAN_KeyUp(object sender, KeyEventArgs e)
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
                dgvSATUAN.DataSource = null;
                dgvSATUAN.Rows.Clear();

                c.KODE = txtCARI.Text;
                DataTable dt = b.SEARCH_BYKODE(c);
                if (dt.Rows.Count > 0)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        string KODE = dt.Rows[i]["KODESATUAN"].ToString();
                        string NAMA = dt.Rows[i]["NAMASATUAN"].ToString();
                        string ISI = dt.Rows[i]["ISI"].ToString();
                        dgvSATUAN.Rows.Add(KODE, NAMA, ISI);
                    }
                }
            }

            if (rdbNAMA.Checked == true)
            {
                dgvSATUAN.DataSource = null;
                dgvSATUAN.Rows.Clear();

                c.NAMA = txtCARI.Text;
                DataTable dt = b.SEARCH_BYNAMA(c);
                if (dt.Rows.Count > 0)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        string KODE = dt.Rows[i]["KODESATUAN"].ToString();
                        string NAMA = dt.Rows[i]["NAMASATUAN"].ToString();
                        string ISI = dt.Rows[i]["ISI"].ToString();
                        dgvSATUAN.Rows.Add(KODE, NAMA, ISI);
                    }
                }

            }
        }
    }
}

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
    public partial class FormBANK : Form
    {
        protected RMS.BUSSINES.MASTER.RMS_BANK b = new RMS.BUSSINES.MASTER.RMS_BANK();
        protected RMS.COMMON.MASTER.RMS_BANK c = new RMS.COMMON.MASTER.RMS_BANK();

        public FormBANK()
        {
            InitializeComponent();
            SETTING_MANUAL();
            LOAD_DATA();
        }
        void SETTING_MANUAL()
        {
            this.Size = new Size(1365, 608);
            this.dgvBANK.Size = new Size(1360, 520);
            this.panelBUTTON.Location = new Point(2, 560);
            this.panelCARI.Location = new Point(790, 4);
        }
        public void LOAD_DATA()
        {
            dgvBANK.DataSource = null;
            dgvBANK.Rows.Clear();

            DataTable dt = b.SELECT();

            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    string KODE = dt.Rows[i]["KODEBANK"].ToString();
                    string NAMA = dt.Rows[i]["NAMABANK"].ToString();
                    dgvBANK.Rows.Add(KODE, NAMA);
                }
            }
        }
        private void btnKELUAR_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void btnTAMBAH_Click(object sender, EventArgs e)
        {
            MASTER.SUBMASTER.FormBANK frm = new LOGISTICMANAGAMENTSYSTEM.MASTER.SUBMASTER.FormBANK(this,0,null);
            frm.ShowDialog();
        }

        private void btnEDIT_Click(object sender, EventArgs e)
        {
            if (dgvBANK.SelectedCells.Count > 0)
            {
                string kode = dgvBANK.SelectedCells[0].OwningRow.Cells["KODEBANK"].Value.ToString();
                c.KODE = kode;
                MASTER.SUBMASTER.FormBANK frm = new LOGISTICMANAGAMENTSYSTEM.MASTER.SUBMASTER.FormBANK(this, 1, c);
                frm.ShowDialog();
            }
        }

        private void btnHAPUS_Click(object sender, EventArgs e)
        {
            if (dgvBANK.SelectedCells.Count > 0)
            {
                string kode = dgvBANK.SelectedCells[0].OwningRow.Cells["KODEBANK"].Value.ToString();
                string nama = dgvBANK.SelectedCells[0].OwningRow.Cells["NAMABANK"].Value.ToString();
                c.KODE = kode;
                DialogResult dr = MessageBox.Show("APAKAH YAKIN AKAN DELETE DATA : " + nama + " ?", "WARNING", MessageBoxButtons.OKCancel, MessageBoxIcon.Stop);
                if (dr == DialogResult.OK)
                {
                    b.DELETE(c);
                    LOAD_DATA();
                }
            }
        }

        private void FormBANK_KeyUp(object sender, KeyEventArgs e)
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
                dgvBANK.DataSource = null;
                dgvBANK.Rows.Clear();

                c.KODE = txtCARI.Text;
                DataTable dt = b.SEARCH_BYKODE(c);
                if (dt.Rows.Count > 0)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        string KODE = dt.Rows[i]["KODEBANK"].ToString();
                        string NAMA = dt.Rows[i]["NAMABANK"].ToString();
                        dgvBANK.Rows.Add(KODE, NAMA);
                    }
                }
            }

            if (rdbNAMA.Checked == true)
            {
                dgvBANK.DataSource = null;
                dgvBANK.Rows.Clear();

                c.NAMA = txtCARI.Text;
                DataTable dt = b.SEARCH_BYNAMA(c);
                if (dt.Rows.Count > 0)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        string KODE = dt.Rows[i]["KODEBANK"].ToString();
                        string NAMA = dt.Rows[i]["NAMABANK"].ToString();
                        dgvBANK.Rows.Add(KODE, NAMA);
                    }
                }

            }
        }
    }
}

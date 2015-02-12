using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LOGISTICMANAGAMENTSYSTEM.VIEW
{
    public partial class FormVIEWDEPARTMENT : Form
    {
        protected RMS.BUSSINES.MASTER.RMS_DEPARTMENT b = new RMS.BUSSINES.MASTER.RMS_DEPARTMENT();
        protected RMS.COMMON.MASTER.RMS_DEPARTMENT c = new RMS.COMMON.MASTER.RMS_DEPARTMENT();

        PURCHASE.SUBPURCHASE.FormADDITEM frm;
        public FormVIEWDEPARTMENT(PURCHASE.SUBPURCHASE.FormADDITEM _frm)
        {
            InitializeComponent();
            this.frm = _frm;
            LOAD_DATA();
        }
        public void LOAD_DATA()
        {
            dgvDEPT.DataSource = null;
            dgvDEPT.Rows.Clear();

            DataTable dt = b.SELECT();
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    string KODE = dt.Rows[i]["KODEDEPARTMENT"].ToString();
                    string NAMA = dt.Rows[i]["NAMADEPARTMENT"].ToString();
                    dgvDEPT.Rows.Add(KODE, NAMA);
                }
            }
        }
        private void FormVIEWDEPARTMENT_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
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
                dgvDEPT.DataSource = null;
                dgvDEPT.Rows.Clear();

                c.KODE = txtCARI.Text;
                DataTable dt = b.SEARCH_BYKODE(c);
                if (dt.Rows.Count > 0)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        string KODE = dt.Rows[i]["KODEDEPARTMENT"].ToString();
                        string NAMA = dt.Rows[i]["NAMADEPARTMENT"].ToString();
                        dgvDEPT.Rows.Add(KODE, NAMA);
                    }
                }
            }

            if (rdbNAMA.Checked == true)
            {
                dgvDEPT.DataSource = null;
                dgvDEPT.Rows.Clear();

                c.NAMA = txtCARI.Text;
                DataTable dt = b.SEARCH_BYNAMA(c);
                if (dt.Rows.Count > 0)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        string KODE = dt.Rows[i]["KODEDEPARTMENT"].ToString();
                        string NAMA = dt.Rows[i]["NAMADEPARTMENT"].ToString();
                        dgvDEPT.Rows.Add(KODE, NAMA);
                    }
                }
            }
        }
        private void dgvDEPT_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDEPT.SelectedCells.Count > 0)
            {
                c.KODE = dgvDEPT.SelectedCells[0].OwningRow.Cells["KODE"].Value.ToString();
                c.NAMA = dgvDEPT.SelectedCells[0].OwningRow.Cells["NAMA"].Value.ToString();
                this.frm.GETA_KODE_BARANG(c);
                Close();
            }
        }
    }
}

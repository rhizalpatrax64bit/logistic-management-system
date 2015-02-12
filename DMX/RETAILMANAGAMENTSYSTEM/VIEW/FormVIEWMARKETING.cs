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
    public partial class FormVIEWMARKETING : Form
    {
        protected RMS.BUSSINES.MASTER.RMS_MARKETING b = new RMS.BUSSINES.MASTER.RMS_MARKETING();
        protected RMS.COMMON.MASTER.RMS_MARKETING c = new RMS.COMMON.MASTER.RMS_MARKETING();
        MASTER.SUBMASTER.FormCUSTOMER frm;
        
        int type;
        public FormVIEWMARKETING(MASTER.SUBMASTER.FormCUSTOMER _frm,int _type)
        {
            InitializeComponent();
            if (_type == 1)
            {
                this.frm = _frm;
            }
            LOAD_DATA();
        }
        public void LOAD_DATA()
        {
            dgvMARKETING.DataSource = null;
            dgvMARKETING.Rows.Clear();

            DataTable dt = b.SELECT();
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    // string id = dt.Rows[i]["ID"].ToString();
                    string kode = dt.Rows[i]["KODE"].ToString();
                    string nama = dt.Rows[i]["NAMA"].ToString();
                    string alamat = dt.Rows[i]["ALAMAT"].ToString();
                    string telp = dt.Rows[i]["TELEPON"].ToString();
                    string email = dt.Rows[i]["EMAIL"].ToString();
                    string idmarketing = dt.Rows[i]["ID"].ToString();

                    dgvMARKETING.Rows.Add(idmarketing, kode, nama, alamat, telp, email);
                }
            }
        }

        private void FormVIEWMARKETING_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
            if (e.KeyCode == Keys.F1)
            {
                                
                txtCARI.Focus();
            }

        }

        private void txtCARI_TextChanged(object sender, EventArgs e)
        {
           
                dgvMARKETING.DataSource = null;
                dgvMARKETING.Rows.Clear();

                c.NAMA = txtCARI.Text;
                c.KODE = txtCARI.Text;
                DataTable dt = b.SEARCH_BYNAMA(c);
                if (dt.Rows.Count > 0)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {

                        string kode = dt.Rows[i]["KODE"].ToString();
                        string nama = dt.Rows[i]["NAMA"].ToString();
                        string alamat = dt.Rows[i]["ALAMAT"].ToString();
                        string telp = dt.Rows[i]["TELEPON"].ToString();
                        string email = dt.Rows[i]["EMAIL"].ToString();
                        string idmarketing = dt.Rows[i]["ID"].ToString();

                        dgvMARKETING.Rows.Add(idmarketing, kode, nama, alamat, telp, email);
                    }
                
            }
        }

        private void dgvMARKETING_Click(object sender, EventArgs e)
        {
            if (dgvMARKETING.SelectedCells.Count > 0)
            {
                c.ID = int.Parse(dgvMARKETING.SelectedCells[0].OwningRow.Cells["IDMARKETING"].Value.ToString());
                c.KODE = dgvMARKETING.SelectedCells[0].OwningRow.Cells["KODE"].Value.ToString();
                c.NAMA = dgvMARKETING.SelectedCells[0].OwningRow.Cells["NAMA"].Value.ToString();
                this.frm.GET_DATA_MARKETING(c);
                
                
                Close();
            }
        }

        private void dgvMARKETING_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (dgvMARKETING.SelectedCells.Count > 0)
                {
                    c.ID = int.Parse(dgvMARKETING.SelectedCells[0].OwningRow.Cells["IDMARKETING"].Value.ToString());
                    c.KODE = dgvMARKETING.SelectedCells[0].OwningRow.Cells["KODE"].Value.ToString();
                    c.NAMA = dgvMARKETING.SelectedCells[0].OwningRow.Cells["NAMA"].Value.ToString();
                    this.frm.GET_DATA_MARKETING(c);


                    Close();
                }
            }
        }

        private void txtCARI_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
            if (e.KeyCode == Keys.F1)
            {
                txtCARI.Focus();
            }

        }
    }
}

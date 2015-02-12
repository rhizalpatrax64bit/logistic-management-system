using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LOGISTICMANAGAMENTSYSTEM.FINANCE
{
    public partial class FormVIEWAGENT : Form
    {
        protected RMS.BUSSINES.MASTER.RMS_SUPPLIER b = new RMS.BUSSINES.MASTER.RMS_SUPPLIER();
        protected RMS.COMMON.MASTER.RMS_SUPPLIER c = new RMS.COMMON.MASTER.RMS_SUPPLIER();
        FINANCE.FormTAGIHAN frm;
        
        int type;
        public FormVIEWAGENT(FINANCE.FormTAGIHAN _frm, RMS.COMMON.MASTER.RMS_SUPPLIER obj, int _type)
        {
            InitializeComponent();
            type = _type;
            if (type == 1)
            {
                this.frm = _frm;
                c = obj;
            }
            LOAD_DATA();
            this.txtCARI.Focus();
           
        }
        public void LOAD_DATA()
        {
            dgvAGENT.DataSource = null;
            dgvAGENT.Rows.Clear();
            c.NAMA = txtCARI.Text;
            c.KODE = txtCARI.Text;
            c.HANDLING = txtCARI.Text;
            DataTable dt = b.SEARCH_BYNAMA(c);
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    string id = dt.Rows[i]["IDAGENT"].ToString();
                    string kode = dt.Rows[i]["KODEAGENT"].ToString();
                    string nama = dt.Rows[i]["NAMAAGENT"].ToString();
                    string handling = dt.Rows[i]["HANDLING"].ToString();
                    string alamat = dt.Rows[i]["ALAMAT"].ToString();
                    string cp = dt.Rows[i]["CP"].ToString();
                    string telepon = dt.Rows[i]["TELEPON"].ToString();                    
                    dgvAGENT.Rows.Add(id,kode,nama,handling,alamat,telepon);
                }
            }
        }

        private void FormVIEWAGENT_KeyUp(object sender, KeyEventArgs e)
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
            LOAD_DATA();
        }

        private void dgvAGENT_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvAGENT.SelectedCells.Count > 0)
            {
                if (type == 1)
                {
                    c.IDAGENT = int.Parse(dgvAGENT.SelectedCells[0].OwningRow.Cells["IDAGENT"].Value.ToString());
                    c.KODE = dgvAGENT.SelectedCells[0].OwningRow.Cells["KODE"].Value.ToString();
                    c.NAMA = dgvAGENT.SelectedCells[0].OwningRow.Cells["NAMA"].Value.ToString();
                  this.frm.GET_DATA_AGENT(c);
                }


                Close();
            }
        }

        private void dgvAGENT_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (dgvAGENT.SelectedCells.Count > 0)
                {
                    if (type == 1)
                    {
                        c.IDAGENT = int.Parse(dgvAGENT.SelectedCells[0].OwningRow.Cells["IDAGENT"].Value.ToString());
                        c.KODE = dgvAGENT.SelectedCells[0].OwningRow.Cells["KODE"].Value.ToString();
                        c.NAMA = dgvAGENT.SelectedCells[0].OwningRow.Cells["NAMA"].Value.ToString();
                        this.frm.GET_DATA_AGENT(c);
                    }


                    Close();
                }
            }
        }
    }
}

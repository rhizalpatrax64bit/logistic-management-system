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
    public partial class FormVIEWSUPPLIER : Form
    {
        protected RMS.BUSSINES.MASTER.RMS_SUPPLIER b = new RMS.BUSSINES.MASTER.RMS_SUPPLIER();
        protected RMS.COMMON.MASTER.RMS_SUPPLIER c = new RMS.COMMON.MASTER.RMS_SUPPLIER();
        DELIVERYORDER.FormDATAENTRY frm;
        public FormVIEWSUPPLIER(DELIVERYORDER.FormDATAENTRY _frm)
        {
            InitializeComponent();
            this.frm = _frm;
            LOAD_DATA();
        }
        public void LOAD_DATA()
        {
            dgvSUPPLIER.DataSource = null;
            dgvSUPPLIER.Rows.Clear();
            c.HANDLING = "SMU";
            DataTable dt = b.SELECTUDARA(c);
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    string af, trucking, warehouse, groundhandling;
                    string hd = dt.Rows[i]["HANDLING"].ToString();
                    string kode = dt.Rows[i]["KODEAGENT"].ToString();
                    string nama = dt.Rows[i]["NAMAAGENT"].ToString();
                    string alamat = dt.Rows[i]["ALAMAT"].ToString();
                    string cp = dt.Rows[i]["CP"].ToString();
                    string telp = dt.Rows[i]["TELEPON"].ToString();
                    if ((dt.Rows[i]["AF"].ToString() == "YES")) { af = "A/F"; } else { af = ""; }
                    if ((dt.Rows[i]["TRUCKING"].ToString() == "YES")) { trucking = "TRUCKING"; } else { trucking = ""; }
                    if ((dt.Rows[i]["WAREHOUSING"].ToString() == "YES")) { warehouse = "WAREHOUSING"; } else { warehouse = ""; }
                    if ((dt.Rows[i]["GROUNDHANDLING"].ToString() == "YES")) { groundhandling = "GROUNDHANDLING"; } else { groundhandling = ""; }
                    string handling = af + "-" + trucking + "-" + warehouse + "-" + groundhandling;
                    dgvSUPPLIER.Rows.Add(hd, kode, nama, alamat, cp, telp, handling);
                }
            }
        }
        private void FormVIEWSUPPLIER_KeyUp(object sender, KeyEventArgs e)
        {
            
        }
        private void txtCARI_TextChanged(object sender, EventArgs e)
        {
            LOAD_FILTER();
        }
        void LOAD_FILTER()
        {
            dgvSUPPLIER.DataSource = null;
            dgvSUPPLIER.Rows.Clear();
            c.HANDLING = "SMU";
            c.NAMA = txtCARI.Text;
            c.KODE = txtCARI.Text;
            DataTable dt = b.SELECTUDARALIKE(c);
         
            if (dt.Rows.Count > 0)
            {
                int no_urut = 1;
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    string af, trucking, warehouse, groundhandling;
                    string hd = dt.Rows[i]["HANDLING"].ToString();
                    string kode = dt.Rows[i]["KODEAGENT"].ToString();
                    string nama = dt.Rows[i]["NAMAAGENT"].ToString();
                    string alamat = dt.Rows[i]["ALAMAT"].ToString();
                    string cp = dt.Rows[i]["CP"].ToString();
                    string telp = dt.Rows[i]["TELEPON"].ToString();
                    if ((dt.Rows[i]["AF"].ToString() == "YES")) { af = "A/F"; } else { af = ""; }
                    if ((dt.Rows[i]["TRUCKING"].ToString() == "YES")) { trucking = "TRUCKING"; } else { trucking = ""; }
                    if ((dt.Rows[i]["WAREHOUSING"].ToString() == "YES")) { warehouse = "WAREHOUSING"; } else { warehouse = ""; }
                    if ((dt.Rows[i]["GROUNDHANDLING"].ToString() == "YES")) { groundhandling = "GROUNDHANDLING"; } else { groundhandling = ""; }
                    string handling = af + "-" + trucking + "-" + warehouse + "-" + groundhandling;
                    dgvSUPPLIER.Rows.Add(hd, kode, nama, alamat, cp, telp, handling);
                   
                }

            }
        }

        private void dgvSUPPLIER_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvSUPPLIER.SelectedCells.Count > 0)
            {
                c.KODE = dgvSUPPLIER.SelectedCells[0].OwningRow.Cells["KODEAGENT"].Value.ToString();
                c.NAMA = dgvSUPPLIER.SelectedCells[0].OwningRow.Cells["NAMASAGENT"].Value.ToString();

                this.frm.GET_DATA_AGENTSMU(c);
                Close();
            }
        }

        private void FormVIEWSUPPLIER_KeyUp_1(object sender, KeyEventArgs e)
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

        private void dgvSUPPLIER_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (dgvSUPPLIER.SelectedCells.Count > 0)
                {
                    c.KODE = dgvSUPPLIER.SelectedCells[0].OwningRow.Cells["KODEAGENT"].Value.ToString();
                    c.NAMA = dgvSUPPLIER.SelectedCells[0].OwningRow.Cells["NAMASAGENT"].Value.ToString();

                    this.frm.GET_DATA_AGENTSMU(c);
                    Close();
                }
            }
        }

       

    }
}

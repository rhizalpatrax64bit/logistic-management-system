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
    public partial class FormVIEWKOTATERUSAN : Form
    {
        protected RMS.BUSSINES.MASTER.RMS_KOTATERUSAN b = new RMS.BUSSINES.MASTER.RMS_KOTATERUSAN();
        protected RMS.COMMON.MASTER.RMS_KOTATERUSAN c = new RMS.COMMON.MASTER.RMS_KOTATERUSAN();
        protected RMS.COMMON.MASTER.RMS_PRICELIST cc = new RMS.COMMON.MASTER.RMS_PRICELIST();
        DELIVERYORDER.FormDATAENTRY frm;
        MASTER.SUBMASTER.FormPRICELIST frmPRICELIST;

        int type;
        string KODETUJUAN;
        public FormVIEWKOTATERUSAN(DELIVERYORDER.FormDATAENTRY _frm,int _type, string KODE)
        {
            InitializeComponent();
            type = _type;
            if (type == 1)
            {
                c.KODEAREA = KODE;
                this.frm = _frm;
            }
            
                     
            LOAD_DATA();
        }
        public void LOAD_DATA()
        {
            dgvTERUSAN.DataSource = null;
            dgvTERUSAN.Rows.Clear();

            DataTable dt = b.SEARCH_BYNAMA(c);
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    string id = dt.Rows[i]["IDKOTA"].ToString();
                    string kode = dt.Rows[i]["KODEKOTA"].ToString();
                    string namaterusan = dt.Rows[i]["NAMATERUSAN"].ToString();
                    dgvTERUSAN.Rows.Add(id, kode, namaterusan);
                }
            }
        }
       
                    

      

        private void txtCARI_TextChanged(object sender, EventArgs e)
        {
                dgvKOTATERUSAN.DataSource = null;
                dgvKOTATERUSAN.Rows.Clear();

                c.NAMAKOTA = txtCARI.Text;
               
                DataTable dt = b.SEARCH_BYNAMA(c);
                if (dt.Rows.Count > 0)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                      // string id = dt.Rows[i]["IDKOTA"].ToString();
                        string kode = dt.Rows[i]["KODEAREA"].ToString();
                        string kota = dt.Rows[i]["NAMAAREA"].ToString();
                        string namaterusan = dt.Rows[i]["NAMAKOTA"].ToString();
                        dgvKOTATERUSAN.Rows.Add(kode, kota, namaterusan);
                    }
                }
            
        }

        private void FormVIEWKOTATERUSAN_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }

        }

        private void txtSEARCH_KeyUp(object sender, KeyEventArgs e)
        {
           // c.KODEAREA = txtSEARCH.Text;
            c.NAMAKOTA = txtSEARCH.Text;

            dgvTERUSAN.DataSource = null;
            dgvTERUSAN.Rows.Clear();

            DataTable dt = b.SEARCH_BYNAMA(c);
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    string id = dt.Rows[i]["ID"].ToString();
                    string kode = dt.Rows[i]["KODEKOTA"].ToString();                    
                    string namaterusan = dt.Rows[i]["NAMATERUSAN"].ToString();
                    dgvTERUSAN.Rows.Add(id,kode,namaterusan);
                }
            }
        }

        private void dgvTERUSAN_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvTERUSAN.SelectedCells.Count > 0)
            {
                if (type == 1)
                {
                    c.IDTERUSAN = int.Parse(dgvTERUSAN.SelectedCells[0].OwningRow.Cells["ID"].Value.ToString());
                    c.KODEAREA = dgvTERUSAN.SelectedCells[0].OwningRow.Cells["AREA"].Value.ToString();
                    c.NAMAKOTA = dgvTERUSAN.SelectedCells[0].OwningRow.Cells["NAMA"].Value.ToString();
                    // this.frm(c);
                }
                this.frm.GET_DATA_TERUSAN(c);

                Close();
            }
        }

        private void dgvTERUSAN_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                c.IDTERUSAN = int.Parse(dgvTERUSAN.SelectedCells[0].OwningRow.Cells["ID"].Value.ToString());
                c.KODEAREA = dgvTERUSAN.SelectedCells[0].OwningRow.Cells["AREA"].Value.ToString();
                c.NAMAKOTA = dgvTERUSAN.SelectedCells[0].OwningRow.Cells["NAMA"].Value.ToString();

                this.frm.GET_DATA_TERUSAN(c);

                Close();
            }
        }

        private void FormVIEWKOTATERUSAN_KeyUp_1(object sender, KeyEventArgs e)
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

    }
}

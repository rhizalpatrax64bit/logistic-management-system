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
    public partial class FormVIEWCUSTOMER : Form
    {
        protected RMS.BUSSINES.MASTER.RMS_CUSTOMER b = new RMS.BUSSINES.MASTER.RMS_CUSTOMER();
        protected RMS.COMMON.MASTER.RMS_CUSTOMER c = new RMS.COMMON.MASTER.RMS_CUSTOMER();
        DELIVERYORDER.FormDATAENTRY frm;
        DELIVERYORDER.FormDAFTARINVOICE frmINVOICE;
        int type;

        public FormVIEWCUSTOMER(DELIVERYORDER.FormDATAENTRY _frm, DELIVERYORDER.FormDAFTARINVOICE _frmSTT, int _type)
        {
            InitializeComponent();
            this.type = _type;
            if(type==1)
            {
                 this.frm = _frm;
            }
            else 
            {
                this.frmINVOICE = _frmSTT;
            }
            LOAD_DATA();
            txtCARI.Focus();
        }

        private void myToolTip()
        {
            ToolTip myToolTip = new ToolTip();
            myToolTip.SetToolTip(txtCARI, "Cari Berdasarkan Salah Satu data : Kode, Marketing, Customer");

        }
        public void LOAD_DATA()
        {
            dgvCUSTOMER.DataSource = null;
            dgvCUSTOMER.Rows.Clear();
            c.TYPE = 2;
            DataTable dt = b.SELECT(c);
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                   // string id = dt.Rows[i]["ID"].ToString();
                    string kode = dt.Rows[i]["KODECUSTOMER"].ToString();
                    string nama = dt.Rows[i]["NAMACUSTOMER"].ToString();
                    string alamat = dt.Rows[i]["ALAMAT"].ToString();
                    string telepon = dt.Rows[i]["TELEPON"].ToString();
                    string hp = dt.Rows[i]["HP"].ToString();
                    string kodemarketing = dt.Rows[i]["KODEMARKETING"].ToString();
                    string namamarketing = dt.Rows[i]["MARKETING"].ToString();
                    dgvCUSTOMER.Rows.Add(kode,nama, alamat,telepon,hp,kodemarketing,namamarketing);
                }
            }
        }
        private void FormVIEWCUSTOMER_KeyUp(object sender, KeyEventArgs e)
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
        
      
        private void dgvCUSTOMER_Click(object sender, EventArgs e)
        {
            if (dgvCUSTOMER.SelectedCells.Count > 0)
            {
                
                c.KODE = dgvCUSTOMER.SelectedCells[0].OwningRow.Cells["KODE"].Value.ToString();
                c.NAMACUSTOMER = dgvCUSTOMER.SelectedCells[0].OwningRow.Cells["NAMA"].Value.ToString();
                c.ALAMAT = dgvCUSTOMER.SelectedCells[0].OwningRow.Cells["ALAMAT"].Value.ToString();
                c.TELEPON = dgvCUSTOMER.SelectedCells[0].OwningRow.Cells["TELEPON"].Value.ToString();
                c.HP = dgvCUSTOMER.SelectedCells[0].OwningRow.Cells["HP"].Value.ToString();
                c.KODEMARKETING = dgvCUSTOMER.SelectedCells[0].OwningRow.Cells["KODEMARKETING"].Value.ToString();
                c.MARKETING = dgvCUSTOMER.SelectedCells[0].OwningRow.Cells["NAMAMARKETING"].Value.ToString();

                if (type == 1)
                {
                    this.frm.GET_DATA_CUSTOMER(c);
                }
                else
                {
                    this.frmINVOICE.GET_DATA_CUSTOMER(c);
                }
                Close();
            }
        }

     
       

        private void txtCARI_KeyUp(object sender, KeyEventArgs e)
        {
            c.NAMACUSTOMER = txtCARI.Text;
            c.KODE = txtCARI.Text;
            c.MARKETING = txtCARI.Text;
            dgvCUSTOMER.DataSource = null;
            dgvCUSTOMER.Rows.Clear();
            c.TYPE = 2;
            DataTable dt = b.SEARCHLIKE(c);
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {

                    string kode = dt.Rows[i]["KODECUSTOMER"].ToString();
                    string nama = dt.Rows[i]["NAMACUSTOMER"].ToString();
                    string alamat = dt.Rows[i]["ALAMAT"].ToString();
                    string telepon = dt.Rows[i]["TELEPON"].ToString();
                    string hp = dt.Rows[i]["HP"].ToString();
                    string kodemarketing = dt.Rows[i]["KODEMARKETING"].ToString();
                    string namamarketing = dt.Rows[i]["MARKETING"].ToString();
                    dgvCUSTOMER.Rows.Add(kode, nama, alamat, telepon, hp, kodemarketing, namamarketing);
                }
            }
        }

        private void dgvCUSTOMER_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                c.KODE = dgvCUSTOMER.SelectedCells[0].OwningRow.Cells["KODE"].Value.ToString();
                c.NAMACUSTOMER = dgvCUSTOMER.SelectedCells[0].OwningRow.Cells["NAMA"].Value.ToString();
                c.KODEMARKETING = dgvCUSTOMER.SelectedCells[0].OwningRow.Cells["KODEMARKETING"].Value.ToString();
                c.MARKETING = dgvCUSTOMER.SelectedCells[0].OwningRow.Cells["NAMAMARKETING"].Value.ToString();

                this.frm.GET_DATA_CUSTOMER(c);
                Close();
            }
        }
    }
}

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
    public partial class FormCUSTOMEREXPRESS : Form
    {
        protected RMS.BUSSINES.MASTER.RMS_CUSTOMER b = new RMS.BUSSINES.MASTER.RMS_CUSTOMER();
        protected RMS.COMMON.MASTER.RMS_CUSTOMER c = new RMS.COMMON.MASTER.RMS_CUSTOMER();
        EXPRESS.FormENTRYSO frm;
       
        int type;
        public FormCUSTOMEREXPRESS(EXPRESS.FormENTRYSO _frm, int _type)
        {
            InitializeComponent();
             this.type = _type;
            if(type==1)
            {
                 this.frm = _frm;
            }
            else 
            {
                //this.frmINVOICE = _frmSTT;
            }
            LOAD_DATA();
            txtCARI.Focus();
        }
        public void LOAD_DATA()
        {
            dgvCUSTOMER.DataSource = null;
            dgvCUSTOMER.Rows.Clear();

            DataTable dt = b.SELECT(c);
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    string id = dt.Rows[i]["IDCUSTOMER"].ToString();
                    string kode = dt.Rows[i]["KODECUSTOMER"].ToString();
                    string nama = dt.Rows[i]["NAMACUSTOMER"].ToString();
                    string alamat = dt.Rows[i]["ALAMAT"].ToString();
                    string telepon = dt.Rows[i]["TELEPON"].ToString();
                    string hp = dt.Rows[i]["HP"].ToString();
                 
                    dgvCUSTOMER.Rows.Add(id,kode, nama, alamat, telepon,hp);
                }
            }
        }

        private void dgvCUSTOMER_Click(object sender, EventArgs e)
        {
            if (dgvCUSTOMER.SelectedCells.Count > 0)
            {
                c.ID = Convert.ToInt32(dgvCUSTOMER.SelectedCells[0].OwningRow.Cells["ID"].Value.ToString());
                c.KODE = dgvCUSTOMER.SelectedCells[0].OwningRow.Cells["KODE"].Value.ToString();
                c.NAMACUSTOMER = dgvCUSTOMER.SelectedCells[0].OwningRow.Cells["NAMA"].Value.ToString();
                c.ALAMAT = dgvCUSTOMER.SelectedCells[0].OwningRow.Cells["ALAMAT"].Value.ToString();
                c.TELEPON = dgvCUSTOMER.SelectedCells[0].OwningRow.Cells["TELEPON"].Value.ToString();
                c.HP = dgvCUSTOMER.SelectedCells[0].OwningRow.Cells["HP"].Value.ToString();
            

                if (type == 1)
                {
                  this.frm.GET_DATA_CUSTOMER(c);
                }
                else
                {
                   // this.frmINVOICE.GET_DATA_CUSTOMER(c);
                }
                Close();
            }
        }

        private void txtCARI_KeyUp(object sender, KeyEventArgs e)
        {
            c.NAMACUSTOMER = txtCARI.Text;
            c.KODE = txtCARI.Text;
           // c.MARKETING = txtCARI.Text;
            dgvCUSTOMER.DataSource = null;
            dgvCUSTOMER.Rows.Clear();

            DataTable dt = b.SEARCHLIKE(c);
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    string id = dt.Rows[i]["IDCUSTOMER"].ToString();
                    string kode = dt.Rows[i]["KODECUSTOMER"].ToString();
                    string nama = dt.Rows[i]["NAMACUSTOMER"].ToString();
                    string alamat = dt.Rows[i]["ALAMAT"].ToString();
                    string telepon = dt.Rows[i]["TELEPON"].ToString();
                    string hp = dt.Rows[i]["HP"].ToString();

                    dgvCUSTOMER.Rows.Add(id, kode, nama, alamat, telepon, hp);
                }
            }
        }

        private void txtCARI_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                c.KODE = dgvCUSTOMER.SelectedCells[0].OwningRow.Cells["KODE"].Value.ToString();
                c.NAMACUSTOMER = dgvCUSTOMER.SelectedCells[0].OwningRow.Cells["NAMA"].Value.ToString();
              
                this.frm.GET_DATA_CUSTOMER(c);
                Close();
            }
        }
    }
}

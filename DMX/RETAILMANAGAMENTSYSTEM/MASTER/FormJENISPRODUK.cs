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
    public partial class FormJENISPRODUK : Form
    {

        protected RMS.BUSSINES.MASTER.RMS_JENISPRODUK b = new RMS.BUSSINES.MASTER.RMS_JENISPRODUK();
        protected RMS.COMMON.MASTER.RMS_JENISPRODUK c = new RMS.COMMON.MASTER.RMS_JENISPRODUK();
        MASTER.FormJENISPRODUK frm;
        int Type = 0;
        public FormJENISPRODUK()
        {
            InitializeComponent();
          
            txtKODE.Text = GETKODE();
            txtKODE.ReadOnly = true;
            LOAD_DATA();
            
        }
        public string GETKODE()
        {
            string newkode;
            int last_insert;
            int new_insert;
            DataTable dt = b.GETKODE();
            if (string.IsNullOrEmpty(dt.Rows[0]["LAST_ID"].ToString()))
            {
                last_insert = 0;
            }
            else
            {
                last_insert = int.Parse(dt.Rows[0]["LAST_ID"].ToString());
            }
            new_insert = last_insert + 1;
            if (new_insert < 10)
            {
                newkode = "P0" + new_insert;
            }
            else
            {
                newkode = "P" + new_insert;
            }

            return newkode;
        }
        void LOAD_DATA()
        {
            dgvJENISPRODUK.DataSource = null;
            dgvJENISPRODUK.Rows.Clear();
            DataTable dt = b.SELECT();
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    string id = dt.Rows[i]["ID"].ToString();
                    string kode = dt.Rows[i]["KODE"].ToString();
                    string produk = dt.Rows[i]["PRODUK"].ToString();
                    string keterangan = dt.Rows[i]["PRODUK"].ToString();
                   // string isaktif = dt.Rows[i]["isaktif"].ToString();
                    dgvJENISPRODUK.Rows.Add(id, kode, produk, keterangan);
                   

                }
            }
        }

        private void btnSIMPAN_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPRODUK.Text))
            {
                MessageBox.Show("ISI NAMA PRODUK", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtPRODUK.Focus();
                return;
            }
            c.KODE = txtKODE.Text;
            c.PRODUK = txtPRODUK.Text;
            c.KETERANGAN = txtKETERANGAN.Text;

            c.ISAKTIVE = true;
           

            if (Type == 0)
            {
                b.INSERT(c);
                this.LOAD_DATA();
                Type = 0;
            }
            else
            {
               
                b.UPDATE(c);
                this.LOAD_DATA();
                Type = 1;
            }
            CLEAR();
        }
        void CLEAR()
        {
            txtPRODUK.Text = "";
            txtKETERANGAN.Text = "";
           
          
        }

        private void btnTAMBAH_Click(object sender, EventArgs e)
        {
            Type = 0;
        }

        private void btnEDIT_Click(object sender, EventArgs e)
        {

            if (dgvJENISPRODUK.SelectedCells.Count > 0)
            {

                string id = dgvJENISPRODUK.SelectedCells[0].OwningRow.Cells["ID"].Value.ToString();
                string kode = dgvJENISPRODUK.SelectedCells[0].OwningRow.Cells["KODE"].Value.ToString();
                string produk = dgvJENISPRODUK.SelectedCells[0].OwningRow.Cells["PRODUK"].Value.ToString();
                string keterangan = dgvJENISPRODUK.SelectedCells[0].OwningRow.Cells["KETERANGAN"].Value.ToString();
           

                c.ID = int.Parse(id);
                c.KODE = kode; txtKODE.Text = c.KODE;
                c.PRODUK = produk; txtPRODUK.Text = c.PRODUK;
                c.KETERANGAN = keterangan; txtKETERANGAN.Text = c.KETERANGAN;
                
              

                 Type = 1;

            }
           
        }

        private void btnHAPUS_Click(object sender, EventArgs e)
        {
            if (dgvJENISPRODUK.SelectedCells.Count > 0)
            {
                int id = Convert.ToInt32(dgvJENISPRODUK.SelectedCells[0].OwningRow.Cells["ID"].Value.ToString());
                string produk = dgvJENISPRODUK.SelectedCells[0].OwningRow.Cells["PRODUK"].Value.ToString();
                c.ID = id;
                DialogResult dr = MessageBox.Show("APAKAH YAKIN AKAN DELETE DATA : " + produk + " ?", "WARNING", MessageBoxButtons.OKCancel, MessageBoxIcon.Stop);
                if (dr == DialogResult.OK)
                {
                    b.DELETE(c);
                    LOAD_DATA();
                }
            }
        }

        private void btnBATAL_Click(object sender, EventArgs e)
        {
            CLEAR();
            LOAD_DATA();
        }

        private void btnKELUAR_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LOGISTICMANAGAMENTSYSTEM.MASTER.SUBMASTER
{
     
    public partial class FormTERUSAN : Form
    {
        protected RMS.BUSSINES.MASTER.RMS_KOTA b = new RMS.BUSSINES.MASTER.RMS_KOTA();
        protected RMS.COMMON.MASTER.RMS_KOTA c = new RMS.COMMON.MASTER.RMS_KOTA();
        MASTER.FormKOTA frm;
        int Type;
        public FormTERUSAN(MASTER.FormKOTA _frm, int Type, RMS.COMMON.MASTER.RMS_KOTA obj)
        {
            InitializeComponent();
            this.frm = _frm;
            this.Type = Type;

            if (Type == 0)
            {
                LOAD_DATAKOTA(obj);
            }
            else
            {
                LOAD_DATAKOTA(obj);
                //LOAD_DATAKOTA(obj);
            }
        }
        void LOAD_DATAAREA(RMS.COMMON.MASTER.RMS_KOTA obj)
        {

            DataTable dt = b.SEARCH_BYKODEAREA(obj);
            if (dt.Rows.Count > 0)
            {
                c.IDAREA = int.Parse(dt.Rows[0]["IDAREA"].ToString());
                txtKODE.Text = dt.Rows[0]["KODEAREA"].ToString();
                txtNAMA.Text = dt.Rows[0]["NAMAAREA"].ToString();

            }

        }
        void LOAD_DATAKOTA(RMS.COMMON.MASTER.RMS_KOTA obj)
        {

            DataTable dt = b.CARI_BYIDKOTA(obj);
            if (dt.Rows.Count > 0)
            {
                c.IDKOTA = int.Parse(dt.Rows[0]["IDKOTA"].ToString());
                txtKODE.Text = dt.Rows[0]["KODEKOTA"].ToString();
                txtNAMA.Text = dt.Rows[0]["NAMAKOTA"].ToString();

            }

        }

        private void btnBATAL_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
        void CLEAR()
        {
           
            txtNAMAKOTA.Text = "";
        }

        private void btnSIMPAN_Click(object sender, EventArgs e)
        {
          

            if (string.IsNullOrEmpty(txtNAMAKOTA.Text))
            {
                MessageBox.Show("ISI NAMA TERUSAN", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtNAMA.Focus();
                return;
            }

          
            c.NAMATERUSAN = txtNAMAKOTA.Text;
            if (Type == 0)
            {
                b.INSERTTERUSAN(c);
                this.frm.LOAD_DATATERUSAN();
                txtNAMAKOTA.Focus();
            }
            else
            {
                b.UPDATEKOTA(c);
                this.frm.LOAD_DATATERUSAN();
                Close();
            }

            CLEAR();
        }

        private void btnBATAL_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}


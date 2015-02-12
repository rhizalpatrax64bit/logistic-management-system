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
    public partial class FormTAMBAHCUSTOMER : Form
    {
        protected RMS.BUSSINES.MASTER.RMS_CUSTOMER b = new RMS.BUSSINES.MASTER.RMS_CUSTOMER();
        protected RMS.COMMON.MASTER.RMS_CUSTOMER c = new RMS.COMMON.MASTER.RMS_CUSTOMER();


        DELIVERYORDER.FormDATAENTRY frm;
        EXPRESS.FormENTRYSO frmSO;
        int Type;
        public FormTAMBAHCUSTOMER(DELIVERYORDER.FormDATAENTRY _frm, EXPRESS.FormENTRYSO _frmSO, int _Type)
        {
            InitializeComponent();
            this.Type = _Type;
            txtKODE.Text = GETKODE();
            txtKODE.ReadOnly = true;    
            if (Type == 1)
            {
                this.frm = _frm;
            }
            else
            { this.frmSO = _frmSO; }
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
                newkode = "C0" + new_insert;
            }
            else
            {
                newkode = "C" + new_insert;
            }

            return newkode;
        }

        private void btnSIMPAN_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtKODE.Text))
            {
                MessageBox.Show("ISI KODE", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtKODE.Focus();
                return;
            }

            if (string.IsNullOrEmpty(txtNAMACUSTOMER.Text))
            {
                MessageBox.Show("ISI NAMA CUSTOMER", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtNAMACUSTOMER.Focus();
                return;
            }
            


            c.KODE = txtKODE.Text;
            if (Type == 0)
            {
                DataTable dt = b.CARI_BYKODE(c);
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("KODE : " + c.KODE + " SUDAH TERDAFTAR", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }
            }

            c.NAMACUSTOMER = txtNAMACUSTOMER.Text;

            c.ALAMAT = txtALAMAT.Text;
            c.TELEPON = txtTELP.Text;
            c.HP = txtHP.Text;
            c.EMAIL = txtEMAIL.Text;
            //c.IDMARKETING = int.Parse(txtIDMARKETING.Text);                        
            b.INSERT(c);
            this.frmSO.GET_DATA_CUSTOMER(c);
           
            CLEAR();
            
          
        }
        void CLEAR()
        {
            txtKODE.Text = "";
            txtKODE.Focus();
            txtNAMACUSTOMER.Text = "";
            txtALAMAT.Text = "";
            txtTELP.Text = "";
            txtHP.Text = "";
            txtEMAIL.Text = "";

        }

        private void btnBATAL_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

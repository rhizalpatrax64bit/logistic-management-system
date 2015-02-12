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
    public partial class FormSUPPLIER : Form
    {
        protected RMS.BUSSINES.MASTER.RMS_SUPPLIER b = new RMS.BUSSINES.MASTER.RMS_SUPPLIER();
        protected RMS.COMMON.MASTER.RMS_SUPPLIER c = new RMS.COMMON.MASTER.RMS_SUPPLIER();
        MASTER.FormSUPPLIER frm;
        int Type;
        public FormSUPPLIER(MASTER.FormSUPPLIER _frm, int Type, RMS.COMMON.MASTER.RMS_SUPPLIER obj)
        {
            InitializeComponent();
            this.frm = _frm;
            this.Type = Type;
            cboHANDLING.Text = "DELIVERY";
            txtKODE.Text = GETKODE();
            if (Type == 1)
            {
                LOAD_DATA(obj);
            }
        }
        public string GETKODE()
        {
            string newkode;
            int last_insert;
            int new_insert;
            DataTable dt = b.GETKODE();
            if(string.IsNullOrEmpty(dt.Rows[0]["LAST_ID"].ToString()))
            {
                last_insert = 0;
            }
            else
            {
                last_insert = int.Parse(dt.Rows[0]["LAST_ID"].ToString());
            }
            new_insert = last_insert+1;
            newkode = "A" + new_insert;
            return newkode;
        }
        void LOAD_DATA(RMS.COMMON.MASTER.RMS_SUPPLIER obj)
        {
            txtKODE.Enabled = false;
            DataTable dt = b.CARI_BYKODE_UPDATE(obj);
            if (dt.Rows.Count > 0)
            {
                
                txtKODE.Text = dt.Rows[0]["KODEAGENT"].ToString();
                if (dt.Rows[0]["HANDLING_ID"].ToString() == "1")
                {
                    cboHANDLING.Text = "SHIPPING";
                }
                else if (dt.Rows[0]["HANDLING_ID"].ToString() == "2")
                {
                    cboHANDLING.Text = "DELIVERY";
                }
                else if (dt.Rows[0]["HANDLING_ID"].ToString() == "3")
                {
                    cboHANDLING.Text = "WAREHOUSE";
                }
                else if (dt.Rows[0]["HANDLING_ID"].ToString() == "4")
                {
                    cboHANDLING.Text = "REGULATED AGENT";
                }
                else if (dt.Rows[0]["HANDLING_ID"].ToString() == "5")
                {
                    cboHANDLING.Text = "SMU";
                }
                else if (dt.Rows[0]["HANDLING_ID"].ToString() == "6")
                {
                    cboHANDLING.Text = "GRDH";
                }
                else
                {
                    cboHANDLING.Text = "TRUCKING";
                }

                txtNAMA.Text = dt.Rows[0]["NAMAAGENT"].ToString();
                txtALAMAT.Text = dt.Rows[0]["ALAMAT"].ToString();
                txtCP.Text = dt.Rows[0]["CP"].ToString();
                txtTELP.Text = dt.Rows[0]["TELEPON"].ToString();
                txtNPWP.Text = dt.Rows[0]["NPWP"].ToString();
                txtBANK.Text = dt.Rows[0]["BANK"].ToString();
                txtACCOUNT.Text = dt.Rows[0]["ACCOUNTNUMBER"].ToString();
                txtAN.Text = dt.Rows[0]["ATASNAMA"].ToString();
                string test = dt.Rows[0]["IS_AF"].ToString();
                if (dt.Rows[0]["IS_AF"].ToString() == "True")
                {
                    chkAF.Checked = true;
                }
                if (dt.Rows[0]["IS_TRUCK"].ToString() == "True")
                {
                    chkTrucking.Checked = true;
                }
                if (dt.Rows[0]["IS_WH"].ToString() == "True")
                {
                    chkWH.Checked = true;
                }
                if (dt.Rows[0]["IS_GRDH"].ToString() == "True")
                {
                    chkGRDH.Checked = true;
                }
                if (dt.Rows[0]["IS_SHIPPING"].ToString() == "True")
                {
                     chkSHIPPING .Checked = true;
                }
                if (dt.Rows[0]["IS_REGULATEDAGENT"].ToString() == "True")
                {
                    chkRA.Checked = true;

                }
                if (dt.Rows[0]["IS_DELIVERY"].ToString() == "True")
                {
                    chkDELIVERY.Checked = true;

                }
              
            }
        }
        private void btnBATAL_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void btnSIMPAN_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtKODE.Text))
            {
                MessageBox.Show("ISI KODE", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtKODE.Focus();
                return;
            }

            if (string.IsNullOrEmpty(txtNAMA.Text))
            {
                MessageBox.Show("ISI NAMA", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtNAMA.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txtALAMAT.Text))
            {
                MessageBox.Show("ISI ALAMAT", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtALAMAT.Focus();
                return;
            }
            
            if (string.IsNullOrEmpty(txtCP.Text))
            {
                MessageBox.Show("ISI CONTACT PERSON", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtCP.Focus();
                return;
            }

            if (string.IsNullOrEmpty(txtTELP.Text))
            {
                MessageBox.Show("ISI CONTACT TELEPON", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtTELP.Focus();
                return;
            }
            if (cboHANDLING.Text == "SHIPPING")
            {
                c.HANDLING_ID = 1;
            }
            else if (cboHANDLING.Text == "DELIVERY")
            {
                c.HANDLING_ID = 2;
            }
            else if (cboHANDLING.Text == "WAREHOUSE")
            {
                c.HANDLING_ID = 3;
            }
            else if (cboHANDLING.Text == "REGULATED AGENT")
            {
                c.HANDLING_ID = 4;
            }
            else if (cboHANDLING.Text == "SMU")
            {
                c.HANDLING_ID = 5;
            }
            else if (cboHANDLING.Text == "GRDH")
            {
                c.HANDLING_ID = 6;
            }
            else
            {
                c.HANDLING_ID = 7;
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

            c.NAMA = txtNAMA.Text;
            c.ALAMAT = txtALAMAT.Text;
            c.CP = txtCP.Text;
            c.TELEPON = txtTELP.Text;
            c.NPWP = txtNPWP.Text;
            c.BANK = txtBANK.Text;
            c.ACCOUNT = txtACCOUNT.Text;
            c.ATASNAMA = txtAN.Text;
           
            if (chkAF.Checked == true) {
                c.IS_AF = true;
            } else {
                c.IS_AF = false;
            }
            if (chkTrucking.Checked == true){
                c.IS_TRUCK = true;
            }else{
                c.IS_TRUCK = false;
            }
            if (chkWH.Checked == true){
                c.IS_WH = true;
            }
            else {
                c.IS_WH = false;
            }
            if (chkGRDH.Checked == true){
                c.IS_GRDH = true;
            }
            else {
                c.IS_GRDH = false;
            }
            if (chkSHIPPING.Checked == true)
            {
                c.IS_SHIPPING = true;
            }
            else
            {
                c.IS_SHIPPING = false;
            }
            if (chkRA.Checked == true)
            {
                c.IS_RA = true;
            }
            else
            {
                c.IS_RA = false;
            }
            if (chkDELIVERY.Checked == true)
            {
                c.IS_DELIVERY = true;
            }
            else
            {
                c.IS_DELIVERY = false;
            }  
            if (Type == 0)
            {
                b.INSERT(c);
                this.frm.LOAD_DATA();
                txtKODE.Text = GETKODE();
            }
            else
            {
                b.UPDATE(c);
                this.frm.LOAD_DATA();
                Close();
            }
            CLEAR();
              
        }
        void CLEAR()
        {
            txtKODE.Focus();
            txtKODE.Text = GETKODE();
            txtNAMA.Text = "";
            txtALAMAT.Text = "";
            txtCP.Text = "";
            txtTELP.Text = "";
            txtNPWP.Text = "";
            txtBANK.Text = "";
            txtAN.Text = "";
            txtACCOUNT.Text = "";
            chkAF.Checked = false;
            chkTrucking.Checked = false;
            chkWH.Checked = false;
            chkGRDH.Checked = false;
        }
        private void txtBANK_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
            if (e.KeyCode == Keys.Up)
            {
                txtNPWP.Focus();
            }
        }
        public void GET_DATA(RMS.COMMON.MASTER.RMS_BANK obj)
        {
            txtBANK.Text = obj.NAMA;
        }

        private void FormSUPPLIER_Load(object sender, EventArgs e)
        {

        }

        private void txtAN_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                txtACCOUNT.Focus();
            }
            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }

        private void txtACCOUNT_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                txtBANK.Focus();
            }
            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }

        private void txtNPWP_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                txtTELP.Focus();
            }
            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }

        private void txtTELP_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                txtCP.Focus();
            }
            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }

        private void txtCP_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                txtALAMAT.Focus();
            }
            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }

        private void txtALAMAT_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                chkAF.Focus();
            }
            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }

        private void FormSUPPLIER_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }

        }

        private void txtKODE_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }

        private void txtNAMA_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }

        private void cboHANDLING_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

       

       
        
    }
}

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
    public partial class FormTAGIHAN : Form
    {
        protected RMS.BUSSINES.MASTER.RMS_SUPPLIER bsup = new RMS.BUSSINES.MASTER.RMS_SUPPLIER();
        protected RMS.COMMON.MASTER.RMS_SUPPLIER csup = new RMS.COMMON.MASTER.RMS_SUPPLIER();
        protected RMS.BUSSINES.DELIVERYORDER.RMS_TAGIHAN b = new RMS.BUSSINES.DELIVERYORDER.RMS_TAGIHAN();
        protected RMS.COMMON.DELIVERYORDER.RMS_TAGIHAN c = new RMS.COMMON.DELIVERYORDER.RMS_TAGIHAN();


        FINANCE.FormDAFTARPEMBAYARANHUTANG frm;
        int Type;
        public FormTAGIHAN(FINANCE.FormDAFTARPEMBAYARANHUTANG _frm, int _Type, RMS.COMMON.DELIVERYORDER.RMS_TAGIHAN obj)
        {
            InitializeComponent();
            this.frm = _frm;
            this.Type = _Type;
            //txtKODE.Text = GETKODE();
            //txtKODE.ReadOnly = true;
            if (Type == 1)
            {
                
                LOAD_DATA(obj);
            }
        }
        void LOAD_DATA(RMS.COMMON.DELIVERYORDER.RMS_TAGIHAN obj)
        {
            txtKODE.Enabled = false;
            txtNAMA.Enabled = false;
            DataTable dt = b.SELECTTAGIHAN(obj);
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    c.ID = obj.ID;
                    c.IDAGENT = int.Parse(dt.Rows[i]["IDAGENT"].ToString());
                    txtKODE.Text = dt.Rows[i]["KODEAGENT"].ToString();
                    txtNAMA.Text = dt.Rows[i]["NAMAAGENT"].ToString();
                    string tgldatanginv = dt.Rows[i]["TGLDATANGINV"].ToString();
                    string tglinv = dt.Rows[i]["TGLINV"].ToString();
                    dtTGLDATANGINVOICE.Value = DateTime.Parse(tgldatanginv);
                    dtTGLINVOICE.Value = DateTime.Parse(tglinv);
                    txtNOINVOICE.Text = dt.Rows[i]["NOINV"].ToString();
                    txtJMLTAGIHAN.Text = dt.Rows[i]["JUMLAHTAGIHAN"].ToString();
                    txtKETERANGAN.Text = dt.Rows[i]["KETERANGAN"].ToString();
                   

                }
            }
        }

        private void btnSIMPAN_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtKODE.Text))
            {
                MessageBox.Show("ISI KODE AGENT", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtKODE.Focus();
                return;
            }

            if (string.IsNullOrEmpty(txtNOINVOICE.Text))
            {
                MessageBox.Show("ISI NO INVOICE", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtNOINVOICE.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txtJMLTAGIHAN.Text))
            {
                MessageBox.Show("ISI JUMLAH TAGIHAN", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtJMLTAGIHAN.Focus();
                return;
            }


            c.NOINV = txtNOINVOICE.Text;
            if (Type == 0)
            {
                DataTable dt = b.CARI_BYKODE(c);
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("NO INVOICE : " + c.NOINV + " SUDAH TERDAFTAR", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }
            }

            //c.IDAGENT
            
            c.TGLDATANGINV = dtTGLDATANGINVOICE.Value.ToString("yyyy-MM-dd");
            c.TGLINV = dtTGLINVOICE.Value.ToString("yyyy-MM-dd");
            c.NOINV = txtNOINVOICE.Text;
            c.JUMLAHTAGIHAN = float.Parse(txtJMLTAGIHAN.Text);
            c.KETERANGAN = txtKETERANGAN.Text;


            if (Type == 0)
            {
                b.INSERT(c);
                this.frm.LOAD_DATA();
                Close();
            }
            else
            {
                b.UPDATETAGIHAN(c);
                this.frm.LOAD_DATA();
                this.Close();
            }
           // CLEAR();
        }

        private void txtJMLTAGIHAN_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtJMLTAGIHAN.Text))
            {
                MessageBox.Show("MOHON ISI DENGAN ANGKA", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtJMLTAGIHAN.Focus();
                txtJMLTAGIHAN.Text = "0";
                return;
            }
            System.Text.RegularExpressions.Regex nonNumericRegex = new System.Text.RegularExpressions.Regex(@"\D");
            if (nonNumericRegex.IsMatch(txtJMLTAGIHAN.Text))
            {
                MessageBox.Show("MOHON ISI DENGAN ANGKA", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtJMLTAGIHAN.Focus();
                txtJMLTAGIHAN.Text = "0";
                return;
            }
        }
        public void GET_DATA_AGENT(RMS.COMMON.MASTER.RMS_SUPPLIER obj)
        {
            c.IDAGENT = obj.IDAGENT;
            txtKODE.Text = obj.KODE;
            txtNAMA.Text = obj.NAMA;                   



        }
        private void btnAGENT_Click(object sender, EventArgs e)
        {
          
            FINANCE.FormVIEWAGENT frm = new LOGISTICMANAGAMENTSYSTEM.FINANCE.FormVIEWAGENT(this, csup, 1);
            frm.ShowDialog();
        }

        private void btnBATAL_Click(object sender, EventArgs e)
        {
            Close();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}

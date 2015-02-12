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
    public partial class FormPEMBAYARANTAGIHAN : Form
    {
        protected RMS.BUSSINES.DELIVERYORDER.RMS_TAGIHAN b = new RMS.BUSSINES.DELIVERYORDER.RMS_TAGIHAN();
        protected RMS.COMMON.DELIVERYORDER.RMS_TAGIHAN c = new RMS.COMMON.DELIVERYORDER.RMS_TAGIHAN();
             

        protected RMS.BUSSINES.DELIVERYORDER.RMS_PEMBAYARAN bPMB = new RMS.BUSSINES.DELIVERYORDER.RMS_PEMBAYARAN();
        protected RMS.COMMON.DELIVERYORDER.RMS_PEMBAYARAN cPMB = new RMS.COMMON.DELIVERYORDER.RMS_PEMBAYARAN();
        FINANCE.FormDAFTARPEMBAYARANHUTANG frm;
        
        int type;
        public FormPEMBAYARANTAGIHAN(FINANCE.FormDAFTARPEMBAYARANHUTANG _frm, int Type, RMS.COMMON.DELIVERYORDER.RMS_TAGIHAN obj)
        {
            InitializeComponent();
            this.type = Type;
            type = 0;
            c.ID = obj.ID;
            cPMB.IDTAGIHAN = obj.ID;
            //cDETAIL.KODEIVOICE = obj.KODEINVOICE;

            cboMETODEBAYAR.Text = "CASH";
            cboJENISBAYAR.Text = "PELUNASAN";
            pnlNOTRANSFER.Visible = false;
            if (type == 0)
            {
                LOAD_DATA(obj);
                LOAD_HISTORYBAYAR(c);

            }

        }
        void LOAD_HISTORYBAYAR(RMS.COMMON.DELIVERYORDER.RMS_TAGIHAN obj)
        {
            dgvHISTORY.DataSource = null;
            dgvHISTORY.Rows.Clear();
            DataTable dt = bPMB.SEARCH_HISTORYTAGIHAN(obj);
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    // txtKODE.Text = dt.Rows[0]["KODEAGENT"].ToString();

                    string IDPEMB = dt.Rows[i]["IDPEMBAYARAN"].ToString();
                    string IDTAGIHAN = dt.Rows[i]["IDTAGIHAN"].ToString();
                    string NOTRANSAKSI = dt.Rows[i]["NOTRANSAKSI"].ToString();
                    string NOTRANSFER = dt.Rows[i]["NOTRANSFER"].ToString();
                    string TGLBAYAR = DateTime.Parse(dt.Rows[i]["TGLBAYAR"].ToString()).ToString("dd-MM-yyyy");
                    string METODEBAYAR = dt.Rows[i]["METODEBAYAR"].ToString();
                    string BAYAR = dt.Rows[i]["TOTALBAYAR"].ToString();

                    dgvHISTORY.Rows.Add(IDPEMB, IDTAGIHAN, NOTRANSAKSI, NOTRANSFER, TGLBAYAR, METODEBAYAR, BAYAR);

                }

            }
       
       
        }
        void LOAD_DATA(RMS.COMMON.DELIVERYORDER.RMS_TAGIHAN obj)
        {

            DataTable dt = b.SELECTTAGIHAN(obj);
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                   
                    txtAGENT.Text = dt.Rows[0]["NAMAAGENT"].ToString();
                    txtHANDLING.Text = dt.Rows[0]["HANDLING"].ToString();
                    txtTAGIHAN.Text = dt.Rows[0]["JUMLAHTAGIHAN"].ToString();
                    txtTGLDATANGINVOICE.Text = DateTime.Parse(dt.Rows[0]["TGLDATANGINV"].ToString()).ToString("dd-MM-yyyy");
                    txtTGLINVOICE.Text = DateTime.Parse(dt.Rows[0]["TGLINV"].ToString()).ToString("dd-MM-yyyy");
                    txtINVOICE.Text = dt.Rows[0]["NOINV"].ToString();
                    txtTOTALTAGIHAN.Text = dt.Rows[0]["JUMLAHTAGIHAN"].ToString();
                    txtTOTALPEMBAYARAN.Text = dt.Rows[0]["TOTALBAYAR"].ToString();
                    txtSISA.Text = dt.Rows[0]["SISA"].ToString();
                    lblSTATUSTAGIHAN.Text = dt.Rows[0]["STATUS"].ToString();
                }

            }
        }

        private void btnSIMPAN_Click(object sender, EventArgs e)
        {
            if (txtPEMBAYARAN.Text == "0")
            {
                MessageBox.Show("ISI PEMBAYARAN, TIDAK BOLEH 0", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtNOTRANSFER.Focus();
                return;
            }
            if (type == 0)
            {
                if (int.Parse(txtPEMBAYARAN.Text) > int.Parse(txtSISA.Text))
                {
                    MessageBox.Show("ISI PEMBAYARAN, MELEBIHI SISA YANG HARUS DIBAYAR", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    txtNOTRANSFER.Focus();
                    return;
                }
            }


            if (cboMETODEBAYAR.Text == "CASH")
            {
                cPMB.IDMETODEBAYAR = 1;
            }
            else
            {
                cPMB.IDMETODEBAYAR = 2;
            }

            if (cboJENISBAYAR.Text == "UANG MUKA")
            {
                cPMB.IDJENISBAYAR = 1;
            }
            else if (cboJENISBAYAR.Text == "SISA INVOICE")
            {
                cPMB.IDJENISBAYAR = 2;
            }
            else
            {
                cPMB.IDJENISBAYAR = 3;
            }
            if ((cPMB.IDMETODEBAYAR == 2) && string.IsNullOrEmpty(txtNOTRANSFER.Text))
            {
                MessageBox.Show("ISI BUKTI TRANSFER", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtNOTRANSFER.Focus();
                return;
            }
            else
            {
                cPMB.NOTRANSFER = txtNOTRANSFER.Text;
            }

            cPMB.NOTRANSAKSI = txtINVOICE.Text;
            cPMB.TOTALBAYAR = float.Parse(txtPEMBAYARAN.Text);
            cPMB.TGLBAYAR = dtTGLBAYAR.Value.ToString("yyyy-MM-dd");
            //cPMB
            if (type == 0)
            {

                bPMB.INSERTTAGIHAN(cPMB);
                LOAD_DATA(c);
                LOAD_HISTORYBAYAR(c);

            }
            else
            {

                bPMB.UPDATETAGIHAN(cPMB);
                LOAD_DATA(c);
                LOAD_HISTORYBAYAR(c);
                type = 0;
            }
            CLEAR();

            
        }
        void CLEAR()
        {
            txtPEMBAYARAN.Text = "0";
        }

        private void btnEDIT_Click(object sender, EventArgs e)
        {
            if (dgvHISTORY.SelectedCells.Count > 0)
            {

                int IDPEMB = int.Parse(dgvHISTORY.SelectedCells[0].OwningRow.Cells["IDPEMB"].Value.ToString());
                cPMB.IDPEMBAYARAN = IDPEMB;
                DataTable dt = bPMB.SEARCHPEMBTAGIHAN_BYID(cPMB);
                if (dt.Rows.Count > 0)
                {
                    string TGLBAYAR = string.Empty;
                    TGLBAYAR = dt.Rows[0]["TGLBAYAR"].ToString();
                    dtTGLBAYAR.Value = DateTime.Parse(TGLBAYAR);
                    cboMETODEBAYAR.Text = dt.Rows[0]["METODEBAYAR"].ToString();
                    cboJENISBAYAR.Text = dt.Rows[0]["KODEJENISBAYAR"].ToString();
                    txtPEMBAYARAN.Text = dt.Rows[0]["TOTALBAYAR"].ToString();
                    if (cboMETODEBAYAR.Text == "TRANSFER")
                    {
                        pnlNOTRANSFER.Visible = true;
                        txtNOTRANSFER.Text = dt.Rows[0]["NOTRANSFER"].ToString();
                    }
                    type = 1;
                }

            }
        }

        private void cboMETODEBAYAR_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboMETODEBAYAR.Text == "TRANSFER")
            {
                pnlNOTRANSFER.Visible = true;

            }
            else
            {
                pnlNOTRANSFER.Visible = false;
            }
        }

        private void btnHAPUS_Click(object sender, EventArgs e)
        {

        }

        private void btnBATAL_Click(object sender, EventArgs e)
        {
            Close();
        }
       
    }
}

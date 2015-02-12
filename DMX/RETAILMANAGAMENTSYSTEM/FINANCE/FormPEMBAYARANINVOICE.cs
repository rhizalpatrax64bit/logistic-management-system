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
    public partial class FormPEMBAYARANINVOICE : Form
    {
        protected RMS.BUSSINES.DELIVERYORDER.RMS_INVOICE b = new RMS.BUSSINES.DELIVERYORDER.RMS_INVOICE();
        protected RMS.COMMON.DELIVERYORDER.RMS_INVOICE c = new RMS.COMMON.DELIVERYORDER.RMS_INVOICE();

        protected RMS.BUSSINES.DELIVERYORDER.RMS_DETAILINVOICE bDETAIL = new RMS.BUSSINES.DELIVERYORDER.RMS_DETAILINVOICE();
        protected RMS.COMMON.DELIVERYORDER.RMS_DETAILINVOICE cDETAIL = new RMS.COMMON.DELIVERYORDER.RMS_DETAILINVOICE();

        protected RMS.BUSSINES.DELIVERYORDER.RMS_PEMBAYARAN bPMB = new RMS.BUSSINES.DELIVERYORDER.RMS_PEMBAYARAN();
        protected RMS.COMMON.DELIVERYORDER.RMS_PEMBAYARAN cPMB = new RMS.COMMON.DELIVERYORDER.RMS_PEMBAYARAN();
        FINANCE.FormDAFTARPEMBAYRANPIUTANG frm;
        int Type;
        int type;
        public FormPEMBAYARANINVOICE(FINANCE.FormDAFTARPEMBAYRANPIUTANG _frm, int Type, RMS.COMMON.DELIVERYORDER.RMS_INVOICE obj)
        {
            InitializeComponent();
            this.Type = Type;
            type = 0;
            cPMB.IDINVOICE = obj.ID;
            cDETAIL.KODEIVOICE = obj.KODEINVOICE;

            cboMETODEBAYAR.Text = "CASH";
            cboJENISBAYAR.Text = "PELUNASAN";
            pnlNOTRANSFER.Visible = false;
            
           // txtTERBILANG.Visible = false;
            if (type == 0)
            {
                LOAD_DATA(cDETAIL);
                LOAD_HISTORYBAYAR(cPMB);

            }
        }
        void LOAD_HISTORYBAYAR(RMS.COMMON.DELIVERYORDER.RMS_PEMBAYARAN obj)
        {
            dgvHISTORY.DataSource = null;
            dgvHISTORY.Rows.Clear();
            DataTable dt = bPMB.SEARCH_HISTORYINV(obj);
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    // txtKODE.Text = dt.Rows[0]["KODEAGENT"].ToString();

                    string IDPEMB = dt.Rows[i]["IDPEMBAYARAN"].ToString();
                    string IDSTT = dt.Rows[i]["ID"].ToString();
                    string NOTRANSAKSI = dt.Rows[i]["NOTRANSAKSI"].ToString();
                    string NOTRANSFER = dt.Rows[i]["NOTRANSFER"].ToString();
                    string TGLBAYAR = DateTime.Parse(dt.Rows[i]["TGLBAYAR"].ToString()).ToString("dd-MM-yyyy");
                    string METODEBAYAR = dt.Rows[i]["METODEBAYAR"].ToString();
                    string BAYAR = dt.Rows[i]["TOTALBAYAR"].ToString();

                    dgvHISTORY.Rows.Add(IDPEMB, IDSTT, NOTRANSAKSI, NOTRANSFER, TGLBAYAR, METODEBAYAR, BAYAR);

                }

            }
        }
        void LOAD_DATA(RMS.COMMON.DELIVERYORDER.RMS_DETAILINVOICE obj)
        {
           

            DataTable dt = bDETAIL.SELECTKODEINVOICE(obj);
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    // txtKODE.Text = dt.Rows[0]["KODEAGENT"].ToString();
                    txtINVOICE.Text = dt.Rows[0]["KODEINVOICE"].ToString();                   
                    txtCUSTOMER.Text = dt.Rows[0]["NAMACUSTOMER"].ToString();
                    
                    txtPACKING.Text = dt.Rows[0]["PACKING"].ToString();
                    txtPPN.Text = dt.Rows[0]["PPN"].ToString();
                    txtINSURANCE.Text = dt.Rows[0]["INSURANCE"].ToString();
                    txtTOTALCHARGE.Text = dt.Rows[0]["CHARGE"].ToString();
                    txtTOTALPEMBAYARAN.Text = dt.Rows[0]["TOTALBAYAR"].ToString();
                    txtSISA.Text = dt.Rows[0]["SISAKEKURANGAN"].ToString();

                    if (dt.Rows[0]["SISAKEKURANGAN"].ToString() == "0")
                    {
                        lblSTATUS.Text = "LUNAS";
                    }
                    else
                    {
                        lblSTATUS.Text = "BELUM LUNAS";
                    }
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

            
            
                cPMB.NOTRANSAKSI = txtINVOICE.Text;
            
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
            cPMB.TGLBAYAR = DateTime.Now.ToString("yyyy-MM-dd");
            c.ID = cPMB.IDINVOICE;
            if (type == 0)
            {
                
                bPMB.INSERTPMBINV(cPMB);                
                LOAD_DATA(cDETAIL);
                LOAD_HISTORYBAYAR(cPMB);
              
            }
            else
            {                
                
                bPMB.UPDATE(cPMB);
                LOAD_DATA(cDETAIL);
                LOAD_HISTORYBAYAR(cPMB);
                type = 0;
            }
            CLEAR();
 
        }
        void CLEAR()
        {
            txtPEMBAYARAN.Text = "0";
        }

        private void btnBATAL_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEDIT_Click(object sender, EventArgs e)
        {
            if (dgvHISTORY.SelectedCells.Count > 0)
            {

                int IDPEMB = int.Parse(dgvHISTORY.SelectedCells[0].OwningRow.Cells["IDPEMB"].Value.ToString());
                cPMB.IDPEMBAYARAN = IDPEMB;
                DataTable dt = bPMB.SEARCHPEMBINV_BYID(cPMB);
                if (dt.Rows.Count > 0)
                {
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

        private void btnHAPUS_Click(object sender, EventArgs e)
        {
            if (dgvHISTORY.SelectedCells.Count > 0)
            {
                int IDPEMB = int.Parse(dgvHISTORY.SelectedCells[0].OwningRow.Cells["IDPEMB"].Value.ToString());
                string NOTRANSAKSI = dgvHISTORY.SelectedCells[0].OwningRow.Cells["NOTRANSAKSI"].Value.ToString();
                string TOTALBAYAR = dgvHISTORY.SelectedCells[0].OwningRow.Cells["BAYAR"].Value.ToString();
                cPMB.IDPEMBAYARAN = IDPEMB;
                DialogResult dr = MessageBox.Show("APAKAH YAKIN AKAN DELETE DATA : " + NOTRANSAKSI + " ?", "WARNING", MessageBoxButtons.OKCancel, MessageBoxIcon.Stop);
                if (dr == DialogResult.OK)
                {
                    bPMB.DELETE(cPMB);
                    LOAD_DATA(cDETAIL);
                    LOAD_HISTORYBAYAR(cPMB);
                    type = 0;
                }
            }
        }

        private void txtPEMBAYARAN_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPEMBAYARAN.Text))
            {
                MessageBox.Show("MOHON ISI DENGAN ANGKA", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtPEMBAYARAN.Focus();
                txtPEMBAYARAN.Text = "0";
                return;
            }
            System.Text.RegularExpressions.Regex nonNumericRegex = new System.Text.RegularExpressions.Regex(@"\D");
            if (nonNumericRegex.IsMatch(txtPEMBAYARAN.Text))
            {
                MessageBox.Show("MOHON ISI DENGAN ANGKA", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtPEMBAYARAN.Focus();
                txtPEMBAYARAN.Text = "0";

                return;
            }
        }
    }
}

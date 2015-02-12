using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LOGISTICMANAGAMENTSYSTEM.DELIVERYORDER
{
    public partial class FormDATAENTRY : Form
    {
        protected RMS.BUSSINES.DELIVERYORDER.RMS_DETAILINVOICE b = new RMS.BUSSINES.DELIVERYORDER.RMS_DETAILINVOICE();
        protected RMS.COMMON.DELIVERYORDER.RMS_DETAILINVOICE c = new RMS.COMMON.DELIVERYORDER.RMS_DETAILINVOICE();
        protected RMS.BUSSINES.MASTER.RMS_PRICELIST bPricelist = new RMS.BUSSINES.MASTER.RMS_PRICELIST();
        protected RMS.COMMON.MASTER.RMS_PRICELIST cPricelist = new RMS.COMMON.MASTER.RMS_PRICELIST();

        protected RMS.BUSSINES.MASTER.RMS_PRICELISTAGENT bPricelistAgent = new RMS.BUSSINES.MASTER.RMS_PRICELISTAGENT();
        protected RMS.COMMON.MASTER.RMS_PRICELISTAGENT cPricelistAgent = new RMS.COMMON.MASTER.RMS_PRICELISTAGENT();

        protected RMS.COMMON.MASTER.RMS_USER cUser = new RMS.COMMON.MASTER.RMS_USER();
        protected RMS.BUSSINES.MASTER.RMS_USER bUser = new RMS.BUSSINES.MASTER.RMS_USER();
        DELIVERYORDER.FormDAFTARSTT frm;
        protected RMS.COMMON.MASTER.RMS_TENTANGPERUSAHAAN cPersusahaan = new RMS.COMMON.MASTER.RMS_TENTANGPERUSAHAAN();
        protected RMS.BUSSINES.MASTER.RMS_TENTANGPERUSAHAAN bPersusahaan = new RMS.BUSSINES.MASTER.RMS_TENTANGPERUSAHAAN();
        string kodePerusahaan, namaPerusahaan, alamatPerusahaan, telpPerusahaan, faxPerusahaan;
        DataTable dataPrint;
        int Type;
        int costSMU = 0;
        public FormDATAENTRY(DELIVERYORDER.FormDAFTARSTT _frm,int Type,
                                    RMS.COMMON.DELIVERYORDER.RMS_DETAILINVOICE obj, RMS.COMMON.MASTER.RMS_USER user)
        {
            InitializeComponent();
            INIT_PERUSAHAAN();
            SET_PRINT();
            cUser = user;
            this.frm = _frm;
            this.Type = Type;
            setDIM();

            if (cUser.isbiayastt)
            {
                panelBIAYA.Visible = true;
            }
            else
            {
                panelBIAYA.Visible = false;
            }

            if (Type == 0)
            {
                cboINSURANCE.Text = "0";
                txtNOCONNOTE.Text = GETKODE();
                cboTERMOFPAYMENT.Text = "PREPAID";
            }
            else
            {
                c.ID = obj.ID;
                LOAD_DATA(obj);
               
            }

        }
        void INIT_PERUSAHAAN()
        {
            DataTable dt = bPersusahaan.SELECT();
            kodePerusahaan = dt.Rows[0][0].ToString();
            namaPerusahaan = dt.Rows[0][1].ToString();
            alamatPerusahaan = dt.Rows[0][6].ToString();
            telpPerusahaan = dt.Rows[0][7].ToString();
            faxPerusahaan = dt.Rows[0][8].ToString();

        }
        void SET_PRINT()
        {
            dataPrint = new DataTable();

            dataPrint.Columns.Add("NORESI", typeof(string));
            dataPrint.Columns.Add("ASAL", typeof(string));
            dataPrint.Columns.Add("TUJUAN", typeof(string));
            dataPrint.Columns.Add("BERAT", typeof(string));
            dataPrint.Columns.Add("JUMLAH", typeof(string));
            dataPrint.Columns.Add("PENGIRIM", typeof(string));
            dataPrint.Columns.Add("ALAMATPENGIRIM", typeof(string));
            dataPrint.Columns.Add("PHONEPENGIRIM", typeof(string));
            dataPrint.Columns.Add("PENERIMA", typeof(string));
            dataPrint.Columns.Add("ALAMATPENERIMA", typeof(string));
            dataPrint.Columns.Add("PHONEPENERIMA", typeof(string));
            dataPrint.Columns.Add("LAYANAN", typeof(string));
            dataPrint.Columns.Add("HARGA", typeof(string));
            dataPrint.Columns.Add("JENISKIRIMAN", typeof(string));
            dataPrint.Columns.Add("ASURANSI", typeof(string));
            dataPrint.Columns.Add("PPN", typeof(string));
            dataPrint.Columns.Add("JUMLAHTOTAL", typeof(string));
            dataPrint.Columns.Add("KETERANGANISI", typeof(string));
            dataPrint.Columns.Add("INSTRUKSIKHUSUS", typeof(string));
            dataPrint.Columns.Add("DIM_P", typeof(string));
            dataPrint.Columns.Add("DIM_L", typeof(string));
            dataPrint.Columns.Add("DIM_T ", typeof(string));
            dataPrint.Columns.Add("HPPENGIRIM ", typeof(string));
            dataPrint.Columns.Add("PACKING ", typeof(string));
            dataPrint.Columns.Add("BARCODE ", typeof(string));
            dataPrint.Columns.Add("NAMAPERUSAHAAN", typeof(string));
            dataPrint.Columns.Add("ALAMATPERUSAHAAN", typeof(string));
            dataPrint.Columns.Add("TELPPERUSAHAAN", typeof(string));
            dataPrint.Columns.Add("FAXPERUSAHAAN", typeof(string));
            dataPrint.Columns.Add("TGLMANIFEST", typeof(string));
            dataPrint.Columns.Add("ETD", typeof(string));



        }
        public string GETKODE()
        {
            string newkode;

            DataTable dt = b.GETKODE();
            if (string.IsNullOrEmpty(dt.Rows[0][0].ToString()))
            {
                newkode = "kosong";
            }
            else
            {
                newkode = dt.Rows[0][0].ToString();
            }


            return newkode;
        }
        void LOAD_DATA(RMS.COMMON.DELIVERYORDER.RMS_DETAILINVOICE obj)
        {
           
            DataTable dt = b.CARI_BYID(obj);
            if (dt.Rows.Count > 0)
            {
                string TGLSTT, TGLMANIFEST,CSMU;
                CSMU = dt.Rows[0]["CSMU"].ToString();
                TGLSTT = dt.Rows[0]["TGLCONNOTE"].ToString();
                TGLMANIFEST = dt.Rows[0]["TGLMANIFEST"].ToString();

                dtTGLCONNOTE.Value =  DateTime.Parse(TGLSTT);
                dtTGLMANIFEST.Value =  DateTime.Parse(TGLMANIFEST);
                txtTOTALCHARGEKIRIM.Text = dt.Rows[0]["CHARGE_KIRIM"].ToString();
                if (txtTOTALOTHERCHARGE.Text == "0")
                {
                   txtGRANDTOTAL.Text = txtTOTALCHARGEKIRIM.Text;
                   txtTERBILANG.Text = Terbilang(int.Parse(txtGRANDTOTAL.Text));
                   txtTOTALCHARGE.Text = txtGRANDTOTAL.Text;
                }
                txtNOCONNOTE.Text = dt.Rows[0]["NOCONNOTE"].ToString();
                txtKODECUSTOMER.Text = dt.Rows[0]["KODECUSTOMER"].ToString();
                txtNAMACUSTOMER.Text = dt.Rows[0]["NAMACUSTOMER"].ToString();
                txtALAMATCUSTOMER.Text = dt.Rows[0]["ALAMATCUSTOMER"].ToString();
                txtFAXCUSTOMER.Text = dt.Rows[0]["TELEPONCUSTOMER"].ToString();
                txtPHONECUSTOMER.Text = dt.Rows[0]["HPCUSTOMER"].ToString();


                txtKODEORIGIN.Text = dt.Rows[0]["KODEASAL"].ToString();
                txtNAMAORIGIN.Text = dt.Rows[0]["KOTAASAL"].ToString();
                txtKODEDESTINATION.Text = dt.Rows[0]["KODEDEST"].ToString();
                txtNAMADESTINATION.Text = dt.Rows[0]["NAMAKOTA"].ToString();
              
                txtNAMATERUSAN.Text = dt.Rows[0]["NAMATERUSAN"].ToString();
                txtLAYANAN.Text = dt.Rows[0]["SERVICE"].ToString();
                
                if (dt.Rows[0]["SERVICE"].ToString() == "D TO D")
                {
                    c.IDSERVICE = 1;
                }
                else if (dt.Rows[0]["SERVICE"].ToString() == "D TO P")
                {
                    c.IDSERVICE = 2;
                }
                else if (dt.Rows[0]["SERVICE"].ToString() == "P TO P")
                {
                    c.IDSERVICE = 3;
                }
                else
                {
                    c.IDSERVICE = 4;
                }

                if (dt.Rows[0]["IDSTATUSSTT"].ToString() == "1")
                {
                    cboTERMOFPAYMENT.Text = "PREPAID";
                }
                else { cboTERMOFPAYMENT.Text = "COLLECT"; }
                txtHANDLING.Text = dt.Rows[0]["HANDLING"].ToString();

                if (dt.Rows[0]["HANDLING"].ToString() == "UDARA")
                {
                    c.IDHANDLING = 1;
                }
                else if (dt.Rows[0]["HANDLING"].ToString() == "DARAT")
                {
                    c.IDHANDLING = 2;
                }
                else
                {
                    c.IDHANDLING = 3;
                }
                
                if (txtHANDLING.Text == "UDARA")
                {
                    panelAF.Visible = true;
                }
                c.ISINVOICE = int.Parse(dt.Rows[0]["ISINVOICE"].ToString());
                txtPENERIMA.Text = dt.Rows[0]["CONSIGNEE"].ToString();
                txtFAXPENERIMA.Text = dt.Rows[0]["FAX"].ToString();
                txtPHONEPENERIMA.Text = dt.Rows[0]["PHONE"].ToString();
                txtALAMAT.Text = dt.Rows[0]["ALAMAT"].ToString();
                txtRATEKIRIM.Text = dt.Rows[0]["RATE_KIRIM"].ToString();
                txtPCS.Text = dt.Rows[0]["PCS"].ToString();
                
                txtWEIGHT.Text = dt.Rows[0]["WEIGHT"].ToString();               
                txtWEIGHTDIM.Text = dt.Rows[0]["WEIGHTDIM"].ToString();
                
                txtPDIM.Text = dt.Rows[0]["DIM_P"].ToString();
                txtLDIM.Text =  dt.Rows[0]["DIM_L"].ToString();
                txtTDIM.Text = dt.Rows[0]["DIM_T"].ToString();
                if (txtPDIM.Text != "0")
                {
                    chkISDIM.Checked = true;
                }
                txtPPNPercent.Text = dt.Rows[0]["PPNPERCENT"].ToString();
                if(txtPPNPercent.Text != "0")
                {
                    chkPPN.Checked = true;
                }
                txtCHARGEPPN.Text = dt.Rows[0]["PPN"].ToString();
                cboINSURANCE.Text = dt.Rows[0]["INCURANCEPERCENT"].ToString();               
                txtCHARGEINSURANCE.Text = dt.Rows[0]["INSURANCE"].ToString();
                txtNOMINALBARANG.Text = dt.Rows[0]["NBARANGINSURANCE"].ToString();
                if (txtNOMINALBARANG.Text != "0")
                {
                    chkPACKING.Checked = true;
                }
                txtCHARGEPACKING.Text = dt.Rows[0]["PACKING"].ToString();
                //txtTOTALCHARGEKIRIM.Text = 
                // cari kode dan nama agent
                txtKODESMU.Text = dt.Rows[0]["KAGNTAF"].ToString();
                txtNAMASMU.Text = dt.Rows[0]["AGNTAF"].ToString();
                txtNOSMU.Text = dt.Rows[0]["NOSMU"].ToString();
                txtCOSTSMU.Text = CSMU;
                txtNOSMU.Text = dt.Rows[0]["NOSMU"].ToString(); // NO SMU BELUM KE INSERT
                if (string.IsNullOrEmpty(dt.Rows[0]["CSMU"].ToString()))
                {
                    txtCOSTSMU.Text = "0";
                }
                else
                { txtCOSTSMU.Text = CSMU; }

                // SHIPPING
                txtKODESHIPPING.Text = dt.Rows[0]["KAGNTSHIPPING"].ToString();
                txtNAMASHIPPING.Text = dt.Rows[0]["AGNTSHIPPING"].ToString();
                txtCOSTSHIPPING.Text = dt.Rows[0]["COST_SHIPPING"].ToString();
                if(string.IsNullOrEmpty(dt.Rows[0]["COST_SHIPPING"].ToString()))
                {
                    txtCOSTSHIPPING.Text =  "0";
                }
                // DELIVERY
                txtKODEDELIVER.Text = dt.Rows[0]["KAGNTDELIVERY"].ToString();
                txtNAMADELIVER.Text = dt.Rows[0]["AGNTDELIVERY"].ToString();
                txtCOSTTRUCKING.Text = dt.Rows[0]["CTRUCKING"].ToString();
                if(string.IsNullOrEmpty(dt.Rows[0]["CTRUCKING"].ToString()))
                {
                    txtCOSTTRUCKING.Text = "0";
                }
                txtCOSTDELIVERY.Text = dt.Rows[0]["CDELIVERY"].ToString();
                if (string.IsNullOrEmpty(dt.Rows[0]["CDELIVERY"].ToString()))
                {
                    txtCOSTDELIVERY.Text = "0";
                }
                //WAREHOUSING
                txtKODEWAREHOUSE.Text = dt.Rows[0]["KAGNTWH"].ToString();
                txtNAMAWAREHOUSE.Text = dt.Rows[0]["AGNTWH"].ToString(); 
                txtCOSTWAREHOUSE.Text = dt.Rows[0]["CWH"].ToString();
                if(string.IsNullOrEmpty(dt.Rows[0]["CWH"].ToString()))
                {
                    txtCOSTWAREHOUSE.Text = "0";
                }
                //RA
                txtKODERA.Text = dt.Rows[0]["KAGNTRA"].ToString();
                txtNAMARA.Text = dt.Rows[0]["AGNTRA"].ToString(); 
                txtCOSTRA.Text = dt.Rows[0]["COST_RA"].ToString();
                if(string.IsNullOrEmpty(dt.Rows[0]["COST_RA"].ToString()))
                {
                    txtCOSTRA.Text = "0";
                }
                // TRUCKING
                txtKODETRUCKING.Text = dt.Rows[0]["KAGNTTRUCKING"].ToString();
                txtNAMATRUCKING.Text = dt.Rows[0]["AGNTTRUCKING"].ToString();
                txtCOSTTRUCKING.Text = dt.Rows[0]["CTRUCKING"].ToString();

                if(string.IsNullOrEmpty(dt.Rows[0]["CTRUCKING"].ToString()))
                {
                   txtCOSTTRUCKING.Text = "0";
                }

                // GRDH
                txtKODEGRDH.Text = dt.Rows[0]["KAGNTGRDH"].ToString();
                txtNAMAGRDH.Text = dt.Rows[0]["AGNTGRDH"].ToString();
                txtCOSTGRDH.Text = dt.Rows[0]["CGRDH"].ToString();
                
                if(string.IsNullOrEmpty(dt.Rows[0]["CGRDH"].ToString()))
                {
                    txtCOSTTRUCKING.Text = "0";
                }


                // MARKETING
                txtNAMAMARKETING.Text = dt.Rows[0]["MARKETING"].ToString();
                txtFEEMARKETING.Text = dt.Rows[0]["KODEMARKETING"].ToString();
                txtCOSTFEEMARKETING.Text = dt.Rows[0]["FEEMKT"].ToString();
                if (string.IsNullOrEmpty(txtCOSTFEEMARKETING.Text))
                {
                    txtCOSTFEEMARKETING.Text = "0";
                }

                // REFUND
                txtCOSTREFUNDCUST.Text = dt.Rows[0]["REFUND"].ToString();
               
                if(string.IsNullOrEmpty(dt.Rows[0]["REFUND"].ToString()))
                {
                    txtCOSTREFUNDCUST.Text = "0";
                }
            }
                 
        }
        public void setDIM()
        {
            txtPDIM.ReadOnly = true;
            txtLDIM.ReadOnly = true;
            txtTDIM.ReadOnly = true;

            txtWEIGHTDIM.BackColor = Color.Red;
            txtPDIM.BackColor = Color.Red;
            txtLDIM.BackColor = Color.Red;
            txtTDIM.BackColor = Color.Red;
        }
             
        public void LOADINVOICE(RMS.COMMON.DELIVERYORDER.RMS_INVOICE obj)
        {
           // this.tglINV.Text = obj.TGLINVOICE;
           // this.txtKODEINV.Text = obj.KODEINVOICE;
           // this.txtNAMACUST.Text = obj.NAMACUSTOMER;
        }
      
        private void btnTAMBAH_Click(object sender, EventArgs e)
        {
            #region CEK BY RICEK
           
            if (string.IsNullOrEmpty(txtKODECUSTOMER.Text))
            {
                MessageBox.Show("ISI KODECUSTOMER", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtKODECUSTOMER.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txtNOCONNOTE.Text))
            {
                MessageBox.Show("ISI NOCONNOTE", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtNOCONNOTE.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txtPENERIMA.Text))
            {
                MessageBox.Show("ISI PENERIMA", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtNOCONNOTE.Focus();
                return;
            }
            #endregion
            c.NOCONNOTE = txtNOCONNOTE.Text;
            if (Type == 0)
            {
                DataTable dt = b.CARI_BYKODE(c);
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("KODE : " + c.NOCONNOTE + " SUDAH TERDAFTAR", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }
            }
            
            c._KODECUSTOMER = txtKODECUSTOMER.Text;
            c.NOCONNOTE = txtNOCONNOTE.Text;
            c.TGLCONNOTE = dtTGLCONNOTE.Value.ToString("yyyy-MM-dd");
            c.TGLMANIFEST = dtTGLMANIFEST.Value.ToString("yyyy-MM-dd");
            c.NOACCOUNT = "";
            c.NOREFERENSI = "";
            c.CONSIGNEE = txtPENERIMA.Text;
            c.PHONE = txtPHONEPENERIMA.Text;
            c.FAX = txtFAXPENERIMA.Text;
            c.ALAMAT = txtALAMAT.Text;
            c.MARKETING = txtNAMAMARKETING.Text;
            c.NAMAKOTAORIGIN = txtNAMAORIGIN.Text;
            c.NAMAKOTADEST = txtNAMADESTINATION.Text;
            c._KOTATERUSAN = txtNAMATERUSAN.Text;
            c.PCS = Int32.Parse(txtPCS.Text);
            c.WEIGHT = float.Parse(txtWEIGHT.Text);
            c.WEIGHTDIM = float.Parse(txtWEIGHTDIM.Text);
            c.DIM_P = Int32.Parse(txtPDIM.Text);
            c.DIM_L = Int32.Parse(txtLDIM.Text);
            c.DIM_T = Int32.Parse(txtTDIM.Text);
            c.RATE_KIRIM = float.Parse(txtRATEKIRIM.Text);
            c.CHARGE_KIRIM = float.Parse(txtTOTALCHARGEKIRIM.Text);
            c.CHARGE_DIM = float.Parse(txtCHARGEDIM.Text);
            c.PPN = float.Parse(txtCHARGEPPN.Text);
            c.INSURANCE = float.Parse(txtCHARGEINSURANCE.Text);
            c.PACKING = float.Parse(txtCHARGEPACKING.Text);
            c.CHARGE_TERUSAN = float.Parse(txtCHARGETERUSAN.Text);
            c._KAGENT_SHIPPING = txtKODESHIPPING.Text;
            c._KAGENT_DELIVERY = txtKODEDELIVER.Text;
            c._KAGENT_WAREHOUSE = txtKODEWAREHOUSE.Text;
           // c._KOTATERUSAN = "0";
            c._KAGENT_RA = txtKODERA.Text;
            c._KAGENT_TRUCKING = txtKODETRUCKING.Text;
            c._KAGENT_SMU = txtKODESMU.Text;
            c.NOSMU = txtNOSMU.Text;
            c._KAGENT_GRDH = txtKODEGRDH.Text;
            c.COST_SHIPPING = float.Parse(txtCOSTSHIPPING.Text);
            c.COST_DELIVERY = float.Parse(txtCOSTDELIVERY.Text);
            c.COST_TRUCKING = float.Parse(txtCOSTTRUCKING.Text);
            c.COST_WAREHOUSE = float.Parse(txtCOSTWAREHOUSE.Text);
            c.COST_RA = float.Parse(txtCOSTRA.Text);
            c.COST_SMU = float.Parse(txtCOSTSMU.Text);
            c.COST_GRDH = float.Parse(txtCOSTGRDH.Text);
            c.COST_FEEMARKETING = float.Parse(txtCOSTFEEMARKETING.Text);
            c.COST_REFUNDCUST = float.Parse(txtCOSTREFUNDCUST.Text);
            c.IDSTATUSBAYAR = 1;
            c.TOTAL_CHARGE = float.Parse(txtGRANDTOTAL.Text);
            c.TOTAL_COST = float.Parse(txtTOTALCOST.Text);
            c.TOTAL_PROFIT = float.Parse(txtTOTALPROFIT.Text);
            c.KETERANGANISI = txtKETERANGANISI.Text;
            c.INSTRUKSIKHUSUS = txtINSTRUKSIKHUSUS.Text;
            c.NBARANGINSURANCE = float.Parse(txtNOMINALBARANG.Text);
            c.PPNPERCENT = float.Parse(txtPPNPercent.Text);
            c.INCURANCEPERCENT = float.Parse(cboINSURANCE.Text);
            if (Type == 0)
            {
                b.INSERT(c);
                this.frm.LOAD_DATA();

            }
            else
            {
                b.UPDATE(c);
            }
            Close();
            
            //this.Hide();
            //this.MinimumSize();
            // disini isi data table printer
            string compareWEIGHT;
            if (txtWEIGHTDIM.Text == "0")
            {
                compareWEIGHT = txtWEIGHT.Text;
            }
            else
            {
                compareWEIGHT = txtWEIGHTDIM.Text;
            }

            dataPrint.Rows.Add(c.NOCONNOTE, txtNAMAORIGIN.Text, txtNAMADESTINATION.Text, compareWEIGHT, txtPCS.Text,
                c.NAMACUSTOMER, txtALAMATCUSTOMER.Text, txtPHONECUSTOMER.Text, txtPENERIMA.Text, txtALAMAT.Text,
                txtPHONEPENERIMA.Text, txtLAYANAN.Text+"|"+txtHANDLING.Text, txtRATEKIRIM.Text, "",
                txtCHARGEINSURANCE.Text, txtCHARGEPPN.Text, txtGRANDTOTAL.Text, txtKETERANGANISI.Text, txtINSTRUKSIKHUSUS.Text, txtPDIM.Text, txtLDIM.Text, txtTDIM.Text, "", txtCHARGEPACKING.Text, 038000356216, namaPerusahaan, alamatPerusahaan, telpPerusahaan, faxPerusahaan, c.TGLCONNOTE, c.TGLMANIFEST);

            TopMost = false;
            CrystalDecisions.CrystalReports.Engine.ReportDocument cryRpt = new CrystalDecisions.CrystalReports.Engine.ReportDocument();
            REPORTS.INVOICE.FormViewerRESICARGO frm = new REPORTS.INVOICE.FormViewerRESICARGO(dataPrint);
            frm.WindowState = FormWindowState.Normal;
            frm.BringToFront();
            frm.ShowDialog();
        }

       
        private void txtKODEORIGIN_KeyUp(object sender, KeyEventArgs e)
        {
           
        }
        private void txtKODEDESTINATION_KeyUp(object sender, KeyEventArgs e)
        {
            
        }
        public void GET_DATA_KOTA(RMS.COMMON.MASTER.RMS_KOTA obj, string _namaField)
        {
            if (_namaField == "ORIGIN")
            {
                txtKODEORIGIN.Text = obj.KODEKOTA;
                txtNAMAORIGIN.Text = obj.NAMAKOTA;
                cPricelist.IDASAL = obj.IDKOTA;
               
            }
            else
            {

                txtKODEDESTINATION.Text = obj.KODEKOTA;
                txtNAMADESTINATION.Text = obj.NAMAKOTA;
                cPricelist.IDTUJUAN = obj.IDKOTA;
            }

           
        }
        public void GET_DATA_PRICELIST(RMS.COMMON.MASTER.RMS_PRICELIST obj)
        {
            txtKODEORIGIN.Text = obj.KODEAREAASAL;
            txtNAMAORIGIN.Text = obj.NAMAASAL;
            txtKODEDESTINATION.Text = obj.KODEAREATUJUAN;
            txtNAMADESTINATION.Text = obj.NAMATUJUAN;
            txtRATEKIRIM.Text = obj.CHARGE.ToString();
            lblREFUND.Text = obj.RC.ToString();
            c.IDTERUSAN = obj.IDTERUSAN;
           //txtKODETERUSAN.Text = obj.KODEAREA;
            txtNAMATERUSAN.Text = obj.NAMATERUSAN;
            c.IDHANDLING = obj.IDHANDLING;
            c.IDSERVICE = obj.IDSERVICE;

            if (c.IDHANDLING == 1)
            {
                txtHANDLING.Text = "UDARA";
                panelAF.Visible = true;
            }
            else if (c.IDHANDLING == 2)
            {
                txtHANDLING.Text = "DARAT";
                panelAF.Visible = false;
            }
            else
            {
                txtHANDLING.Text = "LAUT";
                panelAF.Visible = false;
            }
            // untuk layanan
            if (c.IDSERVICE == 1)
            {
                txtLAYANAN.Text = "D TO D";

            }
            else if (c.IDSERVICE == 2)
            {
                txtLAYANAN.Text = "D TO P";
            }
            else if (c.IDSERVICE == 3)
            {

                txtLAYANAN.Text = "P TO P";
            }
            else
            {
                txtLAYANAN.Text = "P TO D";
            }


        }
        public void GET_DATA_TERUSAN(RMS.COMMON.MASTER.RMS_KOTATERUSAN obj)
        {
            //txtKODETERUSAN.Text = obj.KODEAREA;
            //txtNAMATERUSAN.Text = obj.NAMAKOTA;
        }
        public void GET_DATA_AGENTSMU(RMS.COMMON.MASTER.RMS_SUPPLIER obj)
        {
            txtKODESMU.Text = obj.KODE;
            txtNAMASMU.Text = obj.NAMA;
        }
        public void GET_DATA_AGENT(RMS.COMMON.MASTER.RMS_SUPPLIER obj, string _namaField)
        {
            if (_namaField == "SHIPPING")
            {
                txtKODESHIPPING.Text = obj.KODE;
                txtNAMASHIPPING.Text = obj.NAMA;
                hitungBIAYASHIPPING(int.Parse(obj.CHARGE));
               
            }
            else if(_namaField == "DELIVERY")
            {
                  txtKODEDELIVER.Text = obj.KODE;
                  txtNAMADELIVER.Text = obj.NAMA;
                  hitungBIAYADELIVERY (int.Parse(obj.CHARGE));
            }
            else if (_namaField == "WAREHOUSE")
            {
                txtKODEWAREHOUSE.Text = obj.KODE;
                txtNAMAWAREHOUSE.Text = obj.NAMA;
                hitungBIAYAWAREHOUSE(int.Parse(obj.CHARGE));
            }
            else if (_namaField == "RA")
            {
                txtKODERA.Text = obj.KODE;
                txtNAMARA.Text = obj.NAMA;
                costSMU = int.Parse(obj.CHARGE);
                hitungBIAYARA(int.Parse(obj.CHARGE));
            }
            else if (_namaField == "TRUCKING")
            {
                txtKODETRUCKING.Text = obj.KODE;
                txtNAMATRUCKING.Text = obj.NAMA;
                hitungBIAYATRUCKING(int.Parse(obj.CHARGE));
            }
            else if (_namaField == "SMU")
            {
                txtKODESMU.Text = obj.KODE;
                txtNAMASMU.Text = obj.NAMA;
               // c.COST_SMU = float.Parse(obj.CHARGE);
                costSMU = int.Parse(obj.CHARGE);
                hitungBIAYAUDARA(int.Parse(obj.CHARGE));
            }
            else
            {
                txtKODEGRDH.Text = obj.KODE;
                txtNAMAGRDH.Text = obj.NAMA;
                hitungBIAYAGRDH(int.Parse(obj.CHARGE));
            }


            
        }

               
        public void GET_DATA_CUSTOMER(RMS.COMMON.MASTER.RMS_CUSTOMER obj)
        {            
                txtKODECUSTOMER.Text = obj.KODE;
                txtNAMACUSTOMER.Text = obj.NAMACUSTOMER;
                txtALAMATCUSTOMER.Text = obj.ALAMAT;
                txtFAXCUSTOMER.Text = obj.TELEPON;
                txtPHONECUSTOMER.Text = obj.HP;
                txtFEEMARKETING.Text = obj.KODEMARKETING;
                txtNAMAMARKETING.Text = obj.MARKETING;                          
        }
        public void GET_DATA_PENERIMA(RMS.COMMON.MASTER.RMS_PENERIMA obj)
        {
           
            txtPENERIMA.Text = obj.NAMAPENERIMA;
            txtALAMAT.Text = obj.ALAMAT;
            txtPHONEPENERIMA.Text = obj.HP;
            txtFAXPENERIMA.Text = obj.FAX;
            
        }
       

        private void txtKODESHIPPING_KeyUp(object sender, KeyEventArgs e)
        {
           
        }

        private void txtKODEDELIVER_KeyUp(object sender, KeyEventArgs e)
        {
           
        }

        private void txtKODEWAREHOUSE_KeyUp(object sender, KeyEventArgs e)
        {
          
        }

        private void txtKODERA_KeyUp(object sender, KeyEventArgs e)
        {
           
        }

        private void txtKODETRUCKING_KeyUp(object sender, KeyEventArgs e)
        {
           
        }
        private void txtKODESMU_KeyUp(object sender, KeyEventArgs e)
        {
           
        }
        private void txtKODEGRDH_KeyUp(object sender, KeyEventArgs e)
        {
            
        }

        private void txtKODECUSTOMER_KeyUp(object sender, KeyEventArgs e)
        {
            VIEW.FormVIEWCUSTOMER frm = new LOGISTICMANAGAMENTSYSTEM.VIEW.FormVIEWCUSTOMER(this, null, 1);
            frm.ShowDialog();
        }

        private void FormDATAENTRY_Load(object sender, EventArgs e)
        {
            txtNOCONNOTE.Focus();
        }

        

        private void cboTERMOFPAYMENT_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboTERMOFPAYMENT.Text == "PREPAID")
            {
                c.IDSTATUSSTT = 1;
            }
            else { c.IDSTATUSSTT = 2; }


        }

        

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btnEDIT_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void chkISDIM_CheckedChanged(object sender, EventArgs e)
        {
            if (chkISDIM.Checked == true)
            {
                txtWEIGHT.ReadOnly = true;
                txtWEIGHT.BackColor = Color.Red;
                txtPDIM.ReadOnly = false;
                txtLDIM.ReadOnly = false;
                txtTDIM.ReadOnly = false;
                txtWEIGHTDIM.BackColor = Color.White;
                txtPDIM.BackColor = Color.White;
                txtLDIM.BackColor = Color.White;
                txtTDIM.BackColor = Color.White;
                txtWEIGHT.Text = "0";
            }
            else
            {
                txtWEIGHT.ReadOnly = false;
                txtWEIGHT.BackColor = Color.White;
                txtPDIM.ReadOnly = true;
                txtLDIM.ReadOnly = true;
                txtTDIM.ReadOnly = true;
                txtWEIGHTDIM.BackColor = Color.Red;
                txtPDIM.BackColor = Color.Red;
                txtLDIM.BackColor = Color.Red;
                txtTDIM.BackColor = Color.Red;

                txtPDIM.Text = "0";
                txtLDIM.Text = "0";
                txtTDIM.Text = "0";

                txtWEIGHTDIM.Text = "0";

            }
        }

        private void hitungWEIGHTDIM()
        {

            decimal WEIGHTDECIMAL;
            int pembagi;
            

            if (!isNumeric(txtPDIM.Text, System.Globalization.NumberStyles.Float) || (String.IsNullOrEmpty(txtPDIM.Text)))
            {
                MessageBox.Show("ISI FIELD DENGAN BENAR", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtPDIM.Text = "0";
                return;
            }
            if (!isNumeric(txtLDIM.Text, System.Globalization.NumberStyles.Float) || (String.IsNullOrEmpty(txtLDIM.Text)))
            {
                MessageBox.Show("ISI FIELD DENGAN BENAR", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtLDIM.Text = "0";
                return;
            }
            if (!isNumeric(txtTDIM.Text, System.Globalization.NumberStyles.Float) || (String.IsNullOrEmpty(txtTDIM.Text)))
            {
                MessageBox.Show("ISI FIELD DENGAN BENAR", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtTDIM.Text = "0";
                return;
            }

            decimal nominalP = decimal.Parse(txtPDIM.Text);
            decimal nominalL = decimal.Parse(txtLDIM.Text);
            decimal nominalT = decimal.Parse(txtTDIM.Text);

            if(txtHANDLING.Text== "Air Freight")
            {
                pembagi = 6000;
            }
            else
            {
                pembagi = 4000;
            }

            WEIGHTDECIMAL = Math.Round((nominalP * nominalL * nominalT)) / pembagi;

            txtWEIGHTDIM.Text = WEIGHTDECIMAL.ToString();
        }

    
        public bool isNumeric(string val, System.Globalization.NumberStyles NumberStyle)
        {
            Double result;
            return Double.TryParse(val, NumberStyle,
                System.Globalization.CultureInfo.CurrentCulture, out result);
        }

        private void txtPDIM_TextChanged(object sender, EventArgs e)
        {
            //checkNUMBER(txtPDIM.Text);
            if (string.IsNullOrEmpty(txtPDIM.Text))
            {
                MessageBox.Show("MOHON ISI DENGAN ANGKA", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtPDIM.Focus();
                txtPDIM.Text = "0";
                return;
            }
            System.Text.RegularExpressions.Regex nonNumericRegex = new System.Text.RegularExpressions.Regex(@"\D");
            if (nonNumericRegex.IsMatch(txtPDIM.Text))
            {
                MessageBox.Show("MOHON ISI DENGAN ANGKA", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtPDIM.Focus();
                txtPDIM.Text = "0";
                return;
            }
            hitungWEIGHTDIM();
            hitungTotal();
            hitungGrandTotal();
        }

        private void txtLDIM_TextChanged(object sender, EventArgs e)
        {
            //checkNUMBER(txtLDIM.Text);
            if (string.IsNullOrEmpty(txtLDIM.Text))
            {
                MessageBox.Show("MOHON ISI DENGAN ANGKA", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtLDIM.Focus();
                txtLDIM.Text = "0";
                return;
            }
            System.Text.RegularExpressions.Regex nonNumericRegex = new System.Text.RegularExpressions.Regex(@"\D");
            if (nonNumericRegex.IsMatch(txtLDIM.Text))
            {
                MessageBox.Show("MOHON ISI DENGAN ANGKA", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtLDIM.Focus();
                txtLDIM.Text = "0";
                return;
            }
            hitungWEIGHTDIM();
            hitungTotal();
            hitungGrandTotal();
        }

        private void txtTDIM_TextChanged(object sender, EventArgs e)
        {
            //checkNUMBER(txtTDIM.Text);
            if (string.IsNullOrEmpty(txtTDIM.Text))
            {
                MessageBox.Show("MOHON ISI DENGAN ANGKA", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtTDIM.Focus();
                txtTDIM.Text = "0";
                return;
            }
            System.Text.RegularExpressions.Regex nonNumericRegex = new System.Text.RegularExpressions.Regex(@"\D");
            if (nonNumericRegex.IsMatch(txtTDIM.Text))
            {
                MessageBox.Show("MOHON ISI DENGAN ANGKA", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtTDIM.Focus();
                txtTDIM.Text = "0";
                return;
            }
            hitungWEIGHTDIM();
            hitungTotal();
            hitungGrandTotal();
        }

        private void btnHitung_Click(object sender, EventArgs e)
        {
            // ini yang dipanggil form pricelist customer
            if (string.IsNullOrEmpty(txtKODECUSTOMER.Text))
            {
                MessageBox.Show("ISI NAMACUSTOMER", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtKODECUSTOMER.Focus();
                return;
            }
            c.NAMACUSTOMER = txtNAMACUSTOMER.Text;
            VIEW.FormVIEWPRICELISTCUSTOMER frm = new LOGISTICMANAGAMENTSYSTEM.VIEW.FormVIEWPRICELISTCUSTOMER(this,c);
            frm.ShowDialog();
        }
        public void hitungSemua()
        {
            if (string.IsNullOrEmpty(txtKODECUSTOMER.Text))
            {
                MessageBox.Show("SILAHKAN PILIH CUSTOMER", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            if (string.IsNullOrEmpty(txtKODEORIGIN.Text))
            {
                MessageBox.Show("SILAHKAN PILIH KOTA ASAL / ORIGIN", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            if (string.IsNullOrEmpty(txtKODEDESTINATION.Text))
            {
                MessageBox.Show("SILAHKAN PILIH KOTA TUJUAN / DESTINATION", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            cPricelist.IDHANDLING = c.IDHANDLING;
            cPricelist.IDSERVICE = c.IDSERVICE;
            //cPricelist.IDASAL = 1; // default bandung
            cPricelist.NAMACUSTOMER = txtNAMACUSTOMER.Text;
            cPricelist.NAMATERUSAN = txtNAMATERUSAN.Text;
            cPricelist.ISAKTIF = true;
            DataTable dt = bPricelist.SELECTSCANRATE(cPricelist);

            if (dt.Rows.Count > 0)
            {
                string CHARGE;
                string REFUND;

                CHARGE = dt.Rows[0]["CHARGE"].ToString();
                REFUND = dt.Rows[0]["REFUND"].ToString();
                lblREFUND.Text = REFUND.ToString();

                txtRATEKIRIM.Text = CHARGE;

                //txtCOSTREFUNDCUST.Text = REFUND;
                if (!string.IsNullOrEmpty(REFUND))
                {
                    hitungBIAYAREFUND(int.Parse(REFUND));
                }
                else
                {
                    hitungBIAYAREFUND(0);
                }

            }
            else
            {
                txtRATEKIRIM.Text = "0";
                txtCOSTREFUNDCUST.Text = "0";
            }
            hitungTotal();
            // hitungGrandTotal();
        }
        private void chkPPN_CheckedChanged(object sender, EventArgs e)
        {
            if (chkPPN.Checked == true)
            {
                txtPPNPercent.ReadOnly = true;
                txtPPNPercent.Text = "10";
                hitungPPN();
            }
            else
            {
                txtPPNPercent.Text = "0";
                txtCHARGEPPN.Text = "0";
            }
        }
        public void hitungPPN()
        {
            if (string.IsNullOrEmpty(txtRATEKIRIM.Text)) return;
            if (string.IsNullOrEmpty(txtWEIGHT.Text)) return;

            if (txtTOTALCHARGEKIRIM.Text == "0" || txtTOTALCHARGEKIRIM.Text == "")
            {
                chkPPN.Checked = false;
                MessageBox.Show("TOTAL CHARGE KIRM MOHON DIHITUNG KEMBALI", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

                decimal totalcharge = decimal.Parse(txtTOTALCHARGEKIRIM.Text);
                decimal ppn = (decimal.Parse(txtPPNPercent.Text) / 100) * totalcharge;
                txtCHARGEPPN.Text = ppn.ToString("#.##");
           

        }

        public void hitungTotal()
        {
            if (string.IsNullOrEmpty(txtRATEKIRIM.Text)) return;
            if (string.IsNullOrEmpty(txtWEIGHT.Text)) return;
            if (string.IsNullOrEmpty(txtCHARGETERUSAN.Text)) return;
            decimal weight;
            decimal ratekirim = decimal.Parse(txtRATEKIRIM.Text);
            if (txtWEIGHT.Text != "0")
            {
                weight = Math.Round(decimal.Parse(txtWEIGHT.Text));
            }
            else
            {
                weight = Math.Round(decimal.Parse(txtWEIGHTDIM.Text));
            }

            txtTOTALCHARGEKIRIM.Text = (ratekirim * weight).ToString("#.##");
            if (string.IsNullOrEmpty((ratekirim * weight).ToString("#.##")))
            {
                txtTOTALCHARGEKIRIM.Text = "0";
            }
            

        }
        public void hitungCOST()
        {
                      
            decimal totalCHARGE,totalCOST,totalPROFIT,totalPROFITPERCENT;
            decimal freight, shipping, delivery, warehouse, ra, trucking, grdh, feemkrt, refund;
            
            if (string.IsNullOrEmpty(txtCOSTSMU.Text))
            {
                txtCOSTSMU.Text = "0";
            }
            if (string.IsNullOrEmpty(txtCOSTSHIPPING.Text))
            {
                txtCOSTSHIPPING.Text = "0";
            }
            if (string.IsNullOrEmpty(txtCOSTDELIVERY.Text))
            {
                txtCOSTDELIVERY.Text = "0";
            }
            if (string.IsNullOrEmpty(txtCOSTWAREHOUSE.Text))
            {
                txtCOSTWAREHOUSE.Text = "0";
            }
            if (string.IsNullOrEmpty(txtCOSTRA.Text))
            {
                txtCOSTRA.Text = "0";
            }
            if (string.IsNullOrEmpty(txtCOSTDELIVERY.Text))
            {
                txtCOSTDELIVERY.Text = "0";
            }
            if (string.IsNullOrEmpty(txtCOSTTRUCKING.Text))
            {
                txtCOSTTRUCKING.Text = "0";
            }
            if (string.IsNullOrEmpty(txtCOSTGRDH.Text))
            {
                txtCOSTGRDH.Text = "0";
            }
            if (string.IsNullOrEmpty(txtCOSTFEEMARKETING.Text))
            {
                txtCOSTFEEMARKETING.Text = "0";
            }
            if (string.IsNullOrEmpty(txtCOSTREFUNDCUST.Text))
            {
                txtCOSTREFUNDCUST.Text = "0";
            }
            if (string.IsNullOrEmpty(txtTOTALCHARGE.Text))
            {
                txtTOTALCHARGE.Text = "0";
            }
            totalCHARGE = decimal.Parse(txtTOTALCHARGE.Text);
            freight = decimal.Parse(txtCOSTSMU.Text);
            shipping = decimal.Parse(txtCOSTSHIPPING.Text);
            delivery = decimal.Parse(txtCOSTDELIVERY.Text);
            warehouse = decimal.Parse(txtCOSTWAREHOUSE.Text);
            ra = decimal.Parse(txtCOSTRA.Text);
            trucking = decimal.Parse(txtCOSTTRUCKING.Text);
            grdh = decimal.Parse(txtCOSTGRDH.Text);
            feemkrt = decimal.Parse(txtCOSTFEEMARKETING.Text); 
            refund = decimal.Parse(txtCOSTREFUNDCUST.Text);

            totalCOST = (freight + shipping + delivery + warehouse + ra + trucking + grdh + feemkrt + refund);
            totalPROFIT = totalCHARGE - totalCOST;
            if (totalCHARGE != 0)
            {
                totalPROFITPERCENT = Math.Round((totalPROFIT / totalCHARGE * 100));

                txtTOTALCOST.Text = totalCOST.ToString("#.##");
                txtTOTALPROFIT.Text = totalPROFIT.ToString("#.##");
                txtPROFITPERCENT.Text = totalPROFITPERCENT.ToString("#.##");
            }

            
        }
        public void checkNUMBER(string _text)
        {
            string text = _text;
            decimal d;
            if (decimal.TryParse(text, out d))
            {
                //valid 
            }
            else
            {
                //invalid
                MessageBox.Show("Please enter a valid number");
                return;
            }
        }
        public void hitungGrandTotal()
        {
            decimal grandtotal;
            decimal totalcharge;
            decimal totalothercharge;
            decimal ppn, packing, insurance;
            ppn = decimal.Parse(txtCHARGEPPN.Text.ToString());
            packing = decimal.Parse(txtCHARGEPACKING.Text.ToString());
            if (string.IsNullOrEmpty(txtCHARGEINSURANCE.Text.ToString()))
            {
                insurance = 0;
            }
            else
            {
                insurance = decimal.Parse(txtCHARGEINSURANCE.Text.ToString());
            }
            if(string.IsNullOrEmpty(txtTOTALCHARGEKIRIM.Text))
            {
                txtTOTALCHARGEKIRIM.Text ="0";
            }
            totalcharge = decimal.Parse(txtTOTALCHARGEKIRIM.Text.ToString());
            totalothercharge = (ppn + packing + insurance);            
            grandtotal = totalothercharge + totalcharge;

            txtTOTALOTHERCHARGE.Text = (totalothercharge.ToString("#.##"));
            txtGRANDTOTAL.Text = (grandtotal.ToString("#.##"));
            txtTOTALCHARGE.Text = (grandtotal.ToString("#.##"));

            if (string.IsNullOrEmpty(totalothercharge.ToString("#.##")))
            { txtTOTALOTHERCHARGE.Text = "0"; }
            if (string.IsNullOrEmpty(grandtotal.ToString("#.##")))
            { txtGRANDTOTAL.Text = "0"; }

            Decimal GTOTAL;
            GTOTAL = decimal.Parse(txtGRANDTOTAL.Text);

            txtTERBILANG.Text = Terbilang(Decimal.ToInt32(Math.Round(GTOTAL))) + " RUPIAH";
           
        }

        private void txtWEIGHT_KeyUp(object sender, KeyEventArgs e)
        {
            if (string.IsNullOrEmpty(txtWEIGHT.Text))
            {
                MessageBox.Show("MOHON ISI DENGAN ANGKA", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtWEIGHT.Focus();
                return;
            }
            System.Text.RegularExpressions.Regex nonNumericRegex = new System.Text.RegularExpressions.Regex(@"\D");
            if (nonNumericRegex.IsMatch(txtWEIGHT.Text))
            {
                MessageBox.Show("MOHON ISI DENGAN ANGKA", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtPCS.Focus();
                return;
            }
            hitungBIAYAUDARA(costSMU);
            hitungTotal();
            hitungGrandTotal();
        }

        private void txtWEIGHTDIM_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                txtWEIGHT.Focus();
            }
            else if (e.KeyCode == Keys.F1)
            {
                txtNOCONNOTE.Focus();
            }
            else if (e.KeyCode == Keys.F2)
            {
                bntPENERIMA.Focus();
            }
            else if (e.KeyCode == Keys.F3)
            {
                txtPCS.Focus();
            }
            else if (e.KeyCode == Keys.F4)
            {
                chkPPN.Focus();
            }
            else if (e.KeyCode == Keys.F5)
            {
                btnALAUT.Focus();
            }
            else if (e.KeyCode == Keys.Space)
            {
                btnTAMBAH.Focus();
            }
            else if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
            hitungBIAYAUDARA(int.Parse(txtWEIGHT.Text));
            hitungTotal();
            hitungGrandTotal();
        }

        private void txtNOMINALBARANG_KeyUp(object sender, KeyEventArgs e)
        {
            if (string.IsNullOrEmpty(txtNOMINALBARANG.Text))
            {
                MessageBox.Show("MOHON ISI DENGAN ANGKA", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtNOMINALBARANG.Focus();
                return;
            }
            System.Text.RegularExpressions.Regex nonNumericRegex = new System.Text.RegularExpressions.Regex(@"\D");
            if (nonNumericRegex.IsMatch(txtNOMINALBARANG.Text))
            {
                MessageBox.Show("MOHON ISI DENGAN ANGKA", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtNOMINALBARANG.Focus();
                return;
            }
        }

        private void chkPACKING_CheckedChanged(object sender, EventArgs e)
        {

            if (chkPACKING.Checked == true)
            {
                txtCHARGEPACKING.ReadOnly = false;
                txtCHARGEPACKING.Text = "0";
            }
            else
            {
                txtCHARGEPACKING.ReadOnly = true;
                txtCHARGEPACKING.Text = "0";

            }
        }

        private void txtCHARGETERUSAN_TextChanged(object sender, EventArgs e)
        {
            hitungGrandTotal();
        }

        private void txtCHARGEPPN_TextChanged(object sender, EventArgs e)
        {
            checkNUMBER(txtCHARGEPPN.Text);
            hitungGrandTotal();
        }

        private void txtNOMINALBARANG_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNOMINALBARANG.Text))
            {
                MessageBox.Show("MOHON ISI DENGAN ANGKA", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtNOMINALBARANG.Focus();
                txtNOMINALBARANG.Text = "0";
                return;
            }
            System.Text.RegularExpressions.Regex nonNumericRegex = new System.Text.RegularExpressions.Regex(@"\D");
            if (nonNumericRegex.IsMatch(txtNOMINALBARANG.Text))
            {
                MessageBox.Show("MOHON ISI DENGAN ANGKA", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtNOMINALBARANG.Focus();
                txtNOMINALBARANG.Text = "0";

                return;
            }
            checkNUMBER(txtNOMINALBARANG.Text);
            decimal insurance;
            decimal insuranceAMOUNT;
            insurance = (decimal.Parse(cboINSURANCE.SelectedItem.ToString()) / 100);
            insuranceAMOUNT = insurance * decimal.Parse(txtNOMINALBARANG.Text);
            txtCHARGEINSURANCE.Text = insuranceAMOUNT.ToString("#.##");

            hitungGrandTotal();
        }

        private void txtCHARGEPACKING_TextChanged(object sender, EventArgs e)
        {
            checkNUMBER(txtCHARGEPACKING.Text);
            hitungGrandTotal();
        }

        private void txtPCS_TextChanged(object sender, EventArgs e)
        {
            //checkNUMBER(txtPCS.Text);
            if (string.IsNullOrEmpty(txtPCS.Text))
            {
                MessageBox.Show("MOHON ISI DENGAN ANGKA", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtPCS.Focus();
                txtPCS.Text = "0";
                return;
            }
            System.Text.RegularExpressions.Regex nonNumericRegex = new System.Text.RegularExpressions.Regex(@"\D");
            if (nonNumericRegex.IsMatch(txtPCS.Text))
            {
                MessageBox.Show("MOHON ISI DENGAN ANGKA", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtPCS.Focus();
                txtPCS.Text = "0";
                return;
            }
        }

        private void txtRATEKIRIM_TextChanged(object sender, EventArgs e)
        {
            //checkNUMBER(txtRATEKIRIM.Text);
            if (string.IsNullOrEmpty(txtRATEKIRIM.Text))
            {
                MessageBox.Show("MOHON ISI DENGAN ANGKA", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtRATEKIRIM.Focus();
                txtRATEKIRIM.Text = "0";
                return;
            }
            System.Text.RegularExpressions.Regex nonNumericRegex = new System.Text.RegularExpressions.Regex(@"\D");
            if (nonNumericRegex.IsMatch(txtRATEKIRIM.Text))
            {
                MessageBox.Show("MOHON ISI DENGAN ANGKA", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtRATEKIRIM.Focus();
                txtRATEKIRIM.Text = "0";
                return;
            }
        }

        private void txtWEIGHT_TextChanged(object sender, EventArgs e)
        {
            //checkNUMBER(txtWEIGHT.Text);
            if (string.IsNullOrEmpty(txtWEIGHT.Text))
            {
                MessageBox.Show("MOHON ISI DENGAN ANGKA", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtWEIGHT.Focus();
                txtWEIGHT.Text = "0";
                return;
            }
            System.Text.RegularExpressions.Regex nonNumericRegex = new System.Text.RegularExpressions.Regex(@"\D");
            if (nonNumericRegex.IsMatch(txtWEIGHT.Text))
            {
                MessageBox.Show("MOHON ISI DENGAN ANGKA", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtWEIGHT.Focus();
                txtWEIGHT.Text = "0";
                return;
            }
           
        }

        private void txtWEIGHTDIM_TextChanged(object sender, EventArgs e)
        {
            checkNUMBER(txtWEIGHTDIM.Text);
           
        }

        private void txtPPNPercent_TextChanged(object sender, EventArgs e)
        {
            checkNUMBER(txtPPNPercent.Text);
        }

        public string Terbilang(int x)
        {
            string terbilang = "";
            string[] bil = new string[] { "", "SATU", "DUA", "TIGA", "EMPAT", "LIMA", "ENAM", "TUJUH", "DELAPAN", "SEMBILAN", "SEPULUH", "SEBELAS" };

            if (x < 12)
            {
                terbilang = " " + bil[x];
            }
            else if (x < 20)
            {
                terbilang = Terbilang(x - 10) + " BELAS";
            }
            else if (x < 100)
            {
                terbilang = Terbilang(x / 10) + " PULUH" + Terbilang(x % 10);
            }
            else if (x < 200)
            {
                terbilang = " SERATUS" + Terbilang(x - 100);
            }
            else if (x < 1000)
            {
                terbilang = Terbilang(x / 100) + " RATUS" + Terbilang(x % 100);
            }
            else if (x < 2000)
            {
                terbilang = " SERIBU" + Terbilang(x - 1000);
            }
            else if (x < 1000000)
            {
                terbilang = Terbilang(x / 1000) + " RIBU" + Terbilang(x % 1000);
            }
            else if (x < 1000000000)
            {
                terbilang = Terbilang(x / 1000000) + " JUTA" + Terbilang(x % 1000000);

            }
            return terbilang;
        }

      

        
        private void btnCUSTOMER(object sender, EventArgs e)
        {
            VIEW.FormVIEWCUSTOMER frm = new LOGISTICMANAGAMENTSYSTEM.VIEW.FormVIEWCUSTOMER(this, null, 1);
            frm.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
              VIEW.FormVIEWKOTA frm = new LOGISTICMANAGAMENTSYSTEM.VIEW.FormVIEWKOTA(this, "DESTINATION", 1);
              frm.ShowDialog();
          
        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void btnASAL_Click(object sender, EventArgs e)
        {

                VIEW.FormVIEWKOTA frm = new LOGISTICMANAGAMENTSYSTEM.VIEW.FormVIEWKOTA(this, "ORIGIN", 1);
                frm.ShowDialog();
            
        }

        private void btnTERUSAN_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtKODEDESTINATION.Text))
            {
                MessageBox.Show("MOHON PILIH TERLEBIH DAHULU TUJUAN", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtKODEDESTINATION.Focus();
                return;
            }
            else
            {

                VIEW.FormVIEWKOTATERUSAN frm = new LOGISTICMANAGAMENTSYSTEM.VIEW.FormVIEWKOTATERUSAN(this, 1,txtKODEDESTINATION.Text);
                frm.ShowDialog(); 
            }
            
        }

        private void btnALAUT_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtKODEORIGIN.Text))
            {
                MessageBox.Show("MOHON PILIH KOTA ASAL", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtKODEORIGIN.Focus();
                return;
            }

            if (string.IsNullOrEmpty(txtKODEDESTINATION.Text))
            {
                MessageBox.Show("MOHON PILIH KOTA TUJUAN", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtKODEDESTINATION.Focus();
                return;
            }
            cPricelistAgent.KODEAREAASAL = txtKODEORIGIN.Text;
            cPricelistAgent.KODEAREATUJUAN = txtKODEDESTINATION.Text;
            cPricelistAgent.KODELAYANAN = txtLAYANAN.Text;
                VIEW.FormVIEWAGENT frm = new LOGISTICMANAGAMENTSYSTEM.VIEW.FormVIEWAGENT(this, null, "SHIPPING", 1,cPricelistAgent);
                frm.ShowDialog();
            
        }

        private void bntADELIVER_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtKODEORIGIN.Text))
            {
                MessageBox.Show("MOHON PILIH KOTA ASAL", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtKODEORIGIN.Focus();
                return;
            }

            if (string.IsNullOrEmpty(txtKODEDESTINATION.Text))
            {
                MessageBox.Show("MOHON PILIH KOTA TUJUAN", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtKODEDESTINATION.Focus();
                return;
            }
            cPricelistAgent.KODEAREAASAL = txtKODEORIGIN.Text;
            cPricelistAgent.KODEAREATUJUAN = txtKODEDESTINATION.Text;
            cPricelistAgent.KODELAYANAN = txtLAYANAN.Text;
            VIEW.FormVIEWAGENT frm = new LOGISTICMANAGAMENTSYSTEM.VIEW.FormVIEWAGENT(this, null, "DELIVERY", 1, cPricelistAgent);
                frm.ShowDialog();
           
        }

        private void bntAGUDANG_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtKODEORIGIN.Text))
            {
                MessageBox.Show("MOHON PILIH KOTA ASAL", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtKODEORIGIN.Focus();
                return;
            }

            if (string.IsNullOrEmpty(txtKODEDESTINATION.Text))
            {
                MessageBox.Show("MOHON PILIH KOTA TUJUAN", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtKODEDESTINATION.Focus();
                return;
            }
            cPricelistAgent.KODEAREAASAL = txtKODEORIGIN.Text;
            cPricelistAgent.KODEAREATUJUAN = txtKODEDESTINATION.Text;
            cPricelistAgent.KODELAYANAN = txtLAYANAN.Text;
            VIEW.FormVIEWAGENT frm = new LOGISTICMANAGAMENTSYSTEM.VIEW.FormVIEWAGENT(this, null, "WAREHOUSE", 1, cPricelistAgent);
                frm.ShowDialog();
            
        }

        private void bntARA_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtKODEORIGIN.Text))
            {
                MessageBox.Show("MOHON PILIH KOTA ASAL", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtKODEORIGIN.Focus();
                return;
            }

            if (string.IsNullOrEmpty(txtKODEDESTINATION.Text))
            {
                MessageBox.Show("MOHON PILIH KOTA TUJUAN", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtKODEDESTINATION.Focus();
                return;
            }
            cPricelistAgent.KODEAREAASAL = txtKODEORIGIN.Text;
            cPricelistAgent.KODEAREATUJUAN = txtKODEDESTINATION.Text;
            cPricelistAgent.KODELAYANAN = txtLAYANAN.Text;
            VIEW.FormVIEWAGENT frm = new LOGISTICMANAGAMENTSYSTEM.VIEW.FormVIEWAGENT(this, null, "RA", 1, cPricelistAgent);
                frm.ShowDialog();
           
        }

        private void bntADARAT_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtKODEORIGIN.Text))
            {
                MessageBox.Show("MOHON PILIH KOTA ASAL", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtKODEORIGIN.Focus();
                return;
            }

            if (string.IsNullOrEmpty(txtKODEDESTINATION.Text))
            {
                MessageBox.Show("MOHON PILIH KOTA TUJUAN", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtKODEDESTINATION.Focus();
                return;
            }
            cPricelistAgent.KODEAREAASAL = txtKODEORIGIN.Text;
            cPricelistAgent.KODEAREATUJUAN = txtKODEDESTINATION.Text;
            cPricelistAgent.KODELAYANAN = txtLAYANAN.Text;
            VIEW.FormVIEWAGENT frm = new LOGISTICMANAGAMENTSYSTEM.VIEW.FormVIEWAGENT(this, null, "TRUCKING", 1, cPricelistAgent);
            frm.ShowDialog();
            
        }

        private void bntAGRDH_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtKODEORIGIN.Text))
            {
                MessageBox.Show("MOHON PILIH KOTA ASAL", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtKODEORIGIN.Focus();
                return;
            }

            if (string.IsNullOrEmpty(txtKODEDESTINATION.Text))
            {
                MessageBox.Show("MOHON PILIH KOTA TUJUAN", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtKODEDESTINATION.Focus();
                return;
            }
            cPricelistAgent.KODEAREAASAL = txtKODEORIGIN.Text;
            cPricelistAgent.KODEAREATUJUAN = txtKODEDESTINATION.Text;
            cPricelistAgent.KODELAYANAN = txtLAYANAN.Text;
            VIEW.FormVIEWAGENT frm = new LOGISTICMANAGAMENTSYSTEM.VIEW.FormVIEWAGENT(this, null, "GRDH", 1, cPricelistAgent);
                frm.ShowDialog();
            
        }

        private void bntPENERIMA_Click(object sender, EventArgs e)
        {
          
           
            VIEW.FormVIEWPENERIMA frm = new LOGISTICMANAGAMENTSYSTEM.VIEW.FormVIEWPENERIMA(this,null, 1);
            frm.ShowDialog();
        }

       

        private void bntAUDARA_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtKODEORIGIN.Text))
            {
                MessageBox.Show("MOHON PILIH KOTA ASAL", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtKODEORIGIN.Focus();
                return;
            }

            if (string.IsNullOrEmpty(txtKODEDESTINATION.Text))
            {
                MessageBox.Show("MOHON PILIH KOTA TUJUAN", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtKODEDESTINATION.Focus();
                return;
            }
           // cPricelistAgent.KODEAREAASAL = txtKODEORIGIN.Text;
            //cPricelistAgent.KODEAREATUJUAN = txtKODEDESTINATION.Text;
            //cPricelistAgent.KODELAYANAN = cboSERVICE.Text;
            VIEW.FormVIEWSUPPLIER frm = new LOGISTICMANAGAMENTSYSTEM.VIEW.FormVIEWSUPPLIER(this);
                frm.ShowDialog();
            
        }
        void hitungBIAYAREFUND(int biaya)
        {
            int berat;
            int tbiaya;
            if (string.IsNullOrEmpty(txtRATEKIRIM.Text))
            {
                MessageBox.Show("ISI BERAT TIDAK BOLEH KOSONG", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtRATEKIRIM.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txtWEIGHT.Text))
            {
                MessageBox.Show("ISI BERAT TIDAK BOLEH KOSONG", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtWEIGHT.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txtWEIGHT.Text))
            {
                MessageBox.Show("ISI BERAT TIDAK BOLEH KOSONG", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtWEIGHT.Focus();
                return;
            }
            if (txtWEIGHTDIM.Text == "0")
            {
                berat = int.Parse(txtWEIGHT.Text);
            }
            else
            {
                berat = int.Parse(txtWEIGHTDIM.Text);
            }
            tbiaya = (berat * biaya);
            txtCOSTREFUNDCUST.Text = tbiaya.ToString();

        }
        void hitungBIAYAMARKETING(int biaya)
        {
            int berat;
            int tbiaya;
            if (string.IsNullOrEmpty(txtWEIGHT.Text))
            {
                MessageBox.Show("ISI BERAT TIDAK BOLEH KOSONG", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtWEIGHT.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txtWEIGHT.Text))
            {
                MessageBox.Show("ISI BERAT TIDAK BOLEH KOSONG", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtWEIGHT.Focus();
                return;
            }
            if (txtWEIGHTDIM.Text == "0")
            {
                berat = int.Parse(txtWEIGHT.Text);
            }
            else
            {
                berat = int.Parse(txtWEIGHTDIM.Text);
            }
            tbiaya = (berat * biaya);
            txtCOSTFEEMARKETING.Text = tbiaya.ToString();

        }
        void hitungBIAYAUDARA(int biaya)
        {
            decimal berat;
            decimal tbiaya;
            if (string.IsNullOrEmpty(txtWEIGHT.Text))
            {
                MessageBox.Show("ISI BERAT TIDAK BOLEH KOSONG", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtWEIGHT.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txtWEIGHT.Text))
            {
                MessageBox.Show("ISI BERAT TIDAK BOLEH KOSONG", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtWEIGHT.Focus();
                return;
            }
            if (txtWEIGHTDIM.Text == "0")
            {
                berat = decimal.Parse(txtWEIGHT.Text);
            }
            else
            {
                berat = Math.Round(decimal.Parse(txtWEIGHTDIM.Text));
            }
            tbiaya = (berat * biaya);
            if (biaya != 0)
            {
                txtCOSTSMU.Text = tbiaya.ToString();
            }
           
        }
        void hitungBIAYATRUCKING(int biaya)
        {
            decimal berat;
            decimal tbiaya;
            if (string.IsNullOrEmpty(txtWEIGHT.Text))
            {
                MessageBox.Show("ISI BERAT TIDAK BOLEH KOSONG", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtWEIGHT.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txtWEIGHT.Text))
            {
                MessageBox.Show("ISI BERAT TIDAK BOLEH KOSONG", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtWEIGHT.Focus();
                return;
            }
            if (txtWEIGHTDIM.Text == "0")
            {
                berat = decimal.Parse(txtWEIGHT.Text);
            }
            else
            {
                berat = Math.Round(decimal.Parse(txtWEIGHTDIM.Text));
            }
            tbiaya = (berat * biaya);
            txtCOSTTRUCKING.Text = tbiaya.ToString();
        }
        void hitungBIAYADELIVERY(int biaya)
        {
            decimal berat;
            decimal tbiaya;
            if (string.IsNullOrEmpty(txtWEIGHT.Text))
            {
                MessageBox.Show("ISI BERAT TIDAK BOLEH KOSONG", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtWEIGHT.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txtWEIGHT.Text))
            {
                MessageBox.Show("ISI BERAT TIDAK BOLEH KOSONG", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtWEIGHT.Focus();
                return;
            }
            if (txtWEIGHTDIM.Text == "0")
            {
                berat = decimal.Parse(txtWEIGHT.Text);
            }
            else
            {
                berat = Math.Round(decimal.Parse(txtWEIGHTDIM.Text));
            }
            tbiaya = (berat * biaya);
            txtCOSTDELIVERY.Text = tbiaya.ToString();
        }
        void hitungBIAYASHIPPING(int biaya)
        {
            decimal berat;
            decimal tbiaya;
            if (string.IsNullOrEmpty(txtWEIGHT.Text))
            {
                MessageBox.Show("ISI BERAT TIDAK BOLEH KOSONG", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtWEIGHT.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txtWEIGHT.Text))
            {
                MessageBox.Show("ISI BERAT TIDAK BOLEH KOSONG", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtWEIGHT.Focus();
                return;
            }
            if (txtWEIGHTDIM.Text == "0")
            {
                berat = decimal.Parse(txtWEIGHT.Text);
            }
            else
            {
                berat = Math.Round(decimal.Parse(txtWEIGHTDIM.Text));
            }
            tbiaya = (berat * biaya);
            txtCOSTSHIPPING.Text = tbiaya.ToString();
        }
        void hitungBIAYAGRDH(int biaya)
        {
            decimal berat;
            decimal tbiaya;
            if (string.IsNullOrEmpty(txtWEIGHT.Text))
            {
                MessageBox.Show("ISI BERAT TIDAK BOLEH KOSONG", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtWEIGHT.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txtWEIGHT.Text))
            {
                MessageBox.Show("ISI BERAT TIDAK BOLEH KOSONG", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtWEIGHT.Focus();
                return;
            }
            if (txtWEIGHTDIM.Text == "0")
            {
                berat = decimal.Parse(txtWEIGHT.Text);
            }
            else
            {
                berat = Math.Round(decimal.Parse(txtWEIGHTDIM.Text));
            }
            tbiaya = (berat * biaya);
            txtCOSTGRDH.Text = tbiaya.ToString();
        }
        void hitungBIAYARA(int biaya)
        {
            decimal berat;
            decimal tbiaya;
            if (string.IsNullOrEmpty(txtWEIGHT.Text))
            {
                MessageBox.Show("ISI BERAT TIDAK BOLEH KOSONG", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtWEIGHT.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txtWEIGHT.Text))
            {
                MessageBox.Show("ISI BERAT TIDAK BOLEH KOSONG", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtWEIGHT.Focus();
                return;
            }
            if (txtWEIGHTDIM.Text == "0")
            {
                berat = decimal.Parse(txtWEIGHT.Text);
            }
            else
            {
                berat = Math.Round(decimal.Parse(txtWEIGHTDIM.Text));
            }
            tbiaya = (berat * biaya);
            txtCOSTRA.Text = tbiaya.ToString();
        }
        void hitungBIAYAWAREHOUSE(int biaya)
        {
            decimal berat;
            decimal tbiaya;
            if (string.IsNullOrEmpty(txtWEIGHT.Text))
            {
                MessageBox.Show("ISI BERAT TIDAK BOLEH KOSONG", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtWEIGHT.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txtWEIGHT.Text))
            {
                MessageBox.Show("ISI BERAT TIDAK BOLEH KOSONG", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtWEIGHT.Focus();
                return;
            }
            if (txtWEIGHTDIM.Text == "0")
            {
                berat = decimal.Parse(txtWEIGHT.Text);
            }
            else
            {
                berat = Math.Round(decimal.Parse(txtWEIGHTDIM.Text));
            }
            tbiaya = (berat * biaya);
            txtCOSTWAREHOUSE.Text = tbiaya.ToString();
        }

        private void txtCOSTSMU_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                txtNOCONNOTE.Focus();
            }
            else if (e.KeyCode == Keys.F2)
            {
                bntPENERIMA.Focus();
            }
            else if (e.KeyCode == Keys.F3)
            {
                txtPCS.Focus();
            }
            else if (e.KeyCode == Keys.F4)
            {
                chkPPN.Focus();
            }
            else if (e.KeyCode == Keys.F5)
            {
                btnALAUT.Focus();
            }
            else if (e.KeyCode == Keys.Space)
            {
                btnTAMBAH.Focus();
            }
            else if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
            if (string.IsNullOrEmpty(txtCOSTSMU.Text))
            {
                MessageBox.Show("MOHON ISI DENGAN ANGKA", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtCOSTSMU.Focus();
                return;
            }
            System.Text.RegularExpressions.Regex nonNumericRegex = new System.Text.RegularExpressions.Regex(@"\D");
            if (nonNumericRegex.IsMatch(txtCOSTSMU.Text))
            {
                MessageBox.Show("MOHON ISI DENGAN ANGKA", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtCOSTSMU.Focus();
                return;
            }
        }

        private void txtCOSTSHIPPING_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                txtCOSTSMU.Focus();
            }
            if (e.KeyCode == Keys.F1)
            {
                txtNOCONNOTE.Focus();
            }
            else if (e.KeyCode == Keys.F2)
            {
                bntPENERIMA.Focus();
            }
            else if (e.KeyCode == Keys.F3)
            {
                txtPCS.Focus();
            }
            else if (e.KeyCode == Keys.F4)
            {
                chkPPN.Focus();
            }
            else if (e.KeyCode == Keys.F5)
            {
                btnALAUT.Focus();
            }
            else if (e.KeyCode == Keys.Space)
            {
                btnTAMBAH.Focus();
            }
            else if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
            if (string.IsNullOrEmpty(txtCOSTSHIPPING.Text))
            {
                MessageBox.Show("MOHON ISI DENGAN ANGKA", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtCOSTSHIPPING.Focus();
                return;
            }
            System.Text.RegularExpressions.Regex nonNumericRegex = new System.Text.RegularExpressions.Regex(@"\D");
            if (nonNumericRegex.IsMatch(txtCOSTSHIPPING.Text))
            {
                MessageBox.Show("MOHON ISI DENGAN ANGKA", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtCOSTSHIPPING.Focus();
                return;
            }
        }

        private void txtCOSTDELIVERY_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                txtCOSTSHIPPING.Focus();
            }
            else if (e.KeyCode == Keys.F1)
            {
                txtNOCONNOTE.Focus();
            }
            else if (e.KeyCode == Keys.F2)
            {
                bntPENERIMA.Focus();
            }
            else if (e.KeyCode == Keys.F3)
            {
                txtPCS.Focus();
            }
            else if (e.KeyCode == Keys.F4)
            {
                chkPPN.Focus();
            }
            else if (e.KeyCode == Keys.F5)
            {
                btnALAUT.Focus();
            }
            else if (e.KeyCode == Keys.Space)
            {
                btnTAMBAH.Focus();
            }
            else if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
            if (string.IsNullOrEmpty(txtCOSTDELIVERY.Text))
            {
                MessageBox.Show("MOHON ISI DENGAN ANGKA", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtCOSTDELIVERY.Focus();
                return;
            }
            System.Text.RegularExpressions.Regex nonNumericRegex = new System.Text.RegularExpressions.Regex(@"\D");
            if (nonNumericRegex.IsMatch(txtCOSTDELIVERY.Text))
            {
                MessageBox.Show("MOHON ISI DENGAN ANGKA", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtCOSTDELIVERY.Focus();
                return;
            }
        }

        private void txtCOSTWAREHOUSE_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                txtCOSTDELIVERY.Focus();
            }
            else if (e.KeyCode == Keys.F1)
            {
                txtNOCONNOTE.Focus();
            }
            else if (e.KeyCode == Keys.F2)
            {
                bntPENERIMA.Focus();
            }
            else if (e.KeyCode == Keys.F3)
            {
                txtPCS.Focus();
            }
            else if (e.KeyCode == Keys.F4)
            {
                chkPPN.Focus();
            }
            else if (e.KeyCode == Keys.F5)
            {
                btnALAUT.Focus();
            }
            else if (e.KeyCode == Keys.Space)
            {
                btnTAMBAH.Focus();
            }
            else if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
            if (string.IsNullOrEmpty(txtCOSTWAREHOUSE.Text))
            {
                MessageBox.Show("MOHON ISI DENGAN ANGKA", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtCOSTWAREHOUSE.Focus();
                return;
            }
            System.Text.RegularExpressions.Regex nonNumericRegex = new System.Text.RegularExpressions.Regex(@"\D");
            if (nonNumericRegex.IsMatch(txtCOSTWAREHOUSE.Text))
            {
                MessageBox.Show("MOHON ISI DENGAN ANGKA", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtCOSTWAREHOUSE.Focus();
                return;
            }
        }

        private void txtCOSTRA_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                txtCOSTWAREHOUSE.Focus();
            }
            else if (e.KeyCode == Keys.F1)
            {
                txtNOCONNOTE.Focus();
            }
            else if (e.KeyCode == Keys.F2)
            {
                bntPENERIMA.Focus();
            }
            else if (e.KeyCode == Keys.F3)
            {
                txtPCS.Focus();
            }
            else if (e.KeyCode == Keys.F4)
            {
                chkPPN.Focus();
            }
            else if (e.KeyCode == Keys.F5)
            {
                btnALAUT.Focus();
            }
            else if (e.KeyCode == Keys.Space)
            {
                btnTAMBAH.Focus();
            }
            else if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
            if (string.IsNullOrEmpty(txtCOSTRA.Text))
            {
                MessageBox.Show("MOHON ISI DENGAN ANGKA", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtCOSTRA.Focus();
                return;
            }
            System.Text.RegularExpressions.Regex nonNumericRegex = new System.Text.RegularExpressions.Regex(@"\D");
            if (nonNumericRegex.IsMatch(txtCOSTRA.Text))
            {
                MessageBox.Show("MOHON ISI DENGAN ANGKA", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtCOSTRA.Focus();
                return;
            }
        }

        private void txtCOSTTRUCKING_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                txtCOSTRA.Focus();
            }
            else if (e.KeyCode == Keys.F1)
            {
                txtNOCONNOTE.Focus();
            }
            else if (e.KeyCode == Keys.F2)
            {
                bntPENERIMA.Focus();
            }
            else if (e.KeyCode == Keys.F3)
            {
                txtPCS.Focus();
            }
            else if (e.KeyCode == Keys.F4)
            {
                chkPPN.Focus();
            }
            else if (e.KeyCode == Keys.F5)
            {
                btnALAUT.Focus();
            }
            else if (e.KeyCode == Keys.Space)
            {
                btnTAMBAH.Focus();
            }
            else if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
            if (string.IsNullOrEmpty(txtCOSTTRUCKING.Text))
            {
                MessageBox.Show("MOHON ISI DENGAN ANGKA", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtCOSTTRUCKING.Focus();
                return;
            }
            System.Text.RegularExpressions.Regex nonNumericRegex = new System.Text.RegularExpressions.Regex(@"\D");
            if (nonNumericRegex.IsMatch(txtCOSTTRUCKING.Text))
            {
                MessageBox.Show("MOHON ISI DENGAN ANGKA", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtCOSTTRUCKING.Focus();
                return;
            }
        }

        private void txtCOSTGRDH_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                txtCOSTTRUCKING.Focus();
            }
            else if (e.KeyCode == Keys.F1)
            {
                txtNOCONNOTE.Focus();
            }
            else if (e.KeyCode == Keys.F2)
            {
                bntPENERIMA.Focus();
            }
            else if (e.KeyCode == Keys.F3)
            {
                txtPCS.Focus();
            }
            else if (e.KeyCode == Keys.F4)
            {
                chkPPN.Focus();
            }
            else if (e.KeyCode == Keys.F5)
            {
                btnALAUT.Focus();
            }
            else if (e.KeyCode == Keys.Space)
            {
                btnTAMBAH.Focus();
            }
            else if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
            if (string.IsNullOrEmpty(txtCOSTGRDH.Text))
            {
                MessageBox.Show("MOHON ISI DENGAN ANGKA", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtCOSTGRDH.Focus();
                return;
            }
            System.Text.RegularExpressions.Regex nonNumericRegex = new System.Text.RegularExpressions.Regex(@"\D");
            if (nonNumericRegex.IsMatch(txtCOSTGRDH.Text))
            {
                MessageBox.Show("MOHON ISI DENGAN ANGKA", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtCOSTGRDH.Focus();
                return;
            }
        }

        private void txtCOSTFEEMARKETING_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                txtCOSTGRDH.Focus();
            }
            else if (e.KeyCode == Keys.F1)
            {
                txtNOCONNOTE.Focus();
            }
            else if (e.KeyCode == Keys.F2)
            {
                bntPENERIMA.Focus();
            }
            else if (e.KeyCode == Keys.F3)
            {
                txtPCS.Focus();
            }
            else if (e.KeyCode == Keys.F4)
            {
                chkPPN.Focus();
            }
            else if (e.KeyCode == Keys.F5)
            {
                btnALAUT.Focus();
            }
            else if (e.KeyCode == Keys.Space)
            {
                btnTAMBAH.Focus();
            }
            else if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
            if (string.IsNullOrEmpty(txtCOSTFEEMARKETING.Text))
            {
                MessageBox.Show("MOHON ISI DENGAN ANGKA", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtCOSTFEEMARKETING.Focus();
                return;
            }
            System.Text.RegularExpressions.Regex nonNumericRegex = new System.Text.RegularExpressions.Regex(@"\D");
            if (nonNumericRegex.IsMatch(txtCOSTFEEMARKETING.Text))
            {
                MessageBox.Show("MOHON ISI DENGAN ANGKA", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtCOSTFEEMARKETING.Focus();
                return;
            }
        }

        private void txtCOSTREFUNDCUST_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                txtCOSTFEEMARKETING.Focus();
            }
            else if (e.KeyCode == Keys.F1)
            {
                txtNOCONNOTE.Focus();
            }
            else if (e.KeyCode == Keys.F2)
            {
                bntPENERIMA.Focus();
            }
            else if (e.KeyCode == Keys.F3)
            {
                txtPCS.Focus();
            }
            else if (e.KeyCode == Keys.F4)
            {
                chkPPN.Focus();
            }
            else if (e.KeyCode == Keys.F5)
            {
                btnALAUT.Focus();
            }
            else if (e.KeyCode == Keys.Space)
            {
                btnTAMBAH.Focus();
            }
            else if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
            if (string.IsNullOrEmpty(txtCOSTREFUNDCUST.Text))
            {
                MessageBox.Show("MOHON ISI DENGAN ANGKA", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtCOSTREFUNDCUST.Focus();
                return;
            }
            System.Text.RegularExpressions.Regex nonNumericRegex = new System.Text.RegularExpressions.Regex(@"\D");
            if (nonNumericRegex.IsMatch(txtCOSTREFUNDCUST.Text))
            {
                MessageBox.Show("MOHON ISI DENGAN ANGKA", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtCOSTREFUNDCUST.Focus();
                return;
            }
        }

        private void txtCOSTSMU_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCOSTSMU.Text))
            {
                MessageBox.Show("MOHON ISI DENGAN ANGKA", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtCOSTSMU.Focus();
                txtCOSTSMU.Text = "0";
                return;
            }
            System.Text.RegularExpressions.Regex nonNumericRegex = new System.Text.RegularExpressions.Regex(@"\D");
            if (nonNumericRegex.IsMatch(txtCOSTSMU.Text))
            {
                MessageBox.Show("MOHON ISI DENGAN ANGKA", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtCOSTSMU.Focus();
                txtCOSTSMU.Text = "0";

                return;
            }
            hitungBIAYAUDARA(costSMU);
            hitungCOST();
        }

        private void txtCOSTSHIPPING_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCOSTSHIPPING.Text))
            {
                MessageBox.Show("MOHON ISI DENGAN ANGKA", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtCOSTSHIPPING.Focus();
                txtCOSTSHIPPING.Text = "0";
                return;
            }
            System.Text.RegularExpressions.Regex nonNumericRegex = new System.Text.RegularExpressions.Regex(@"\D");
            if (nonNumericRegex.IsMatch(txtCOSTSHIPPING.Text))
            {
                MessageBox.Show("MOHON ISI DENGAN ANGKA", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtCOSTSHIPPING.Focus();
                txtCOSTSHIPPING.Text = "0";

                return;
            }
            hitungBIAYAUDARA(costSMU);
            hitungCOST();
        }

        private void txtCOSTDELIVERY_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCOSTDELIVERY.Text))
            {
                MessageBox.Show("MOHON ISI DENGAN ANGKA", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtCOSTDELIVERY.Focus();
                txtCOSTDELIVERY.Text = "0";
                return;
            }
            System.Text.RegularExpressions.Regex nonNumericRegex = new System.Text.RegularExpressions.Regex(@"\D");
            if (nonNumericRegex.IsMatch(txtCOSTDELIVERY.Text))
            {
                MessageBox.Show("MOHON ISI DENGAN ANGKA", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtCOSTDELIVERY.Focus();
                txtCOSTDELIVERY.Text = "0";

                return;
            }
            hitungBIAYAUDARA(costSMU);
            hitungCOST();
        }

        private void txtCOSTWAREHOUSE_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCOSTWAREHOUSE.Text))
            {
                MessageBox.Show("MOHON ISI DENGAN ANGKA", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtCOSTWAREHOUSE.Focus();
                txtCOSTWAREHOUSE.Text = "0";
                return;
            }
            System.Text.RegularExpressions.Regex nonNumericRegex = new System.Text.RegularExpressions.Regex(@"\D");
            if (nonNumericRegex.IsMatch(txtCOSTWAREHOUSE.Text))
            {
                MessageBox.Show("MOHON ISI DENGAN ANGKA", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtCOSTWAREHOUSE.Focus();
                txtCOSTWAREHOUSE.Text = "0";

                return;
            }
            hitungBIAYAUDARA(costSMU);
            hitungCOST();
        }

        private void txtCOSTRA_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCOSTRA.Text))
            {
                MessageBox.Show("MOHON ISI DENGAN ANGKA", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtCOSTRA.Focus();
                txtCOSTRA.Text = "0";
                return;
            }
            System.Text.RegularExpressions.Regex nonNumericRegex = new System.Text.RegularExpressions.Regex(@"\D");
            if (nonNumericRegex.IsMatch(txtCOSTRA.Text))
            {
                MessageBox.Show("MOHON ISI DENGAN ANGKA", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtCOSTRA.Focus();
                txtCOSTRA.Text = "0";

                return;
            }
            hitungBIAYAUDARA(costSMU);
            hitungCOST();
        }

        private void txtCOSTTRUCKING_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCOSTTRUCKING.Text))
            {
                MessageBox.Show("MOHON ISI DENGAN ANGKA", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtCOSTTRUCKING.Focus();
                txtCOSTTRUCKING.Text = "0";
                return;
            }
            System.Text.RegularExpressions.Regex nonNumericRegex = new System.Text.RegularExpressions.Regex(@"\D");
            if (nonNumericRegex.IsMatch(txtCOSTTRUCKING.Text))
            {
                MessageBox.Show("MOHON ISI DENGAN ANGKA", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtCOSTTRUCKING.Focus();
                txtCOSTTRUCKING.Text = "0";

                return;
            }
            hitungBIAYAUDARA(costSMU);
            hitungCOST();

        }

        private void txtCOSTGRDH_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCOSTGRDH.Text))
            {
                MessageBox.Show("MOHON ISI DENGAN ANGKA", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtCOSTGRDH.Focus();
                txtCOSTGRDH.Text = "0";
                return;
            }
            System.Text.RegularExpressions.Regex nonNumericRegex = new System.Text.RegularExpressions.Regex(@"\D");
            if (nonNumericRegex.IsMatch(txtCOSTGRDH.Text))
            {
                MessageBox.Show("MOHON ISI DENGAN ANGKA", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtCOSTGRDH.Focus();
                txtCOSTGRDH.Text = "0";

                return;
            }
            hitungCOST();

        }

        private void txtCOSTFEEMARKETING_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCOSTFEEMARKETING.Text))
            {
                MessageBox.Show("MOHON ISI DENGAN ANGKA", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtCOSTFEEMARKETING.Focus();
                txtCOSTFEEMARKETING.Text = "0";
                return;
            }
            System.Text.RegularExpressions.Regex nonNumericRegex = new System.Text.RegularExpressions.Regex(@"\D");
            if (nonNumericRegex.IsMatch(txtCOSTFEEMARKETING.Text))
            {
                MessageBox.Show("MOHON ISI DENGAN ANGKA", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtCOSTFEEMARKETING.Focus();
                txtCOSTFEEMARKETING.Text = "0";

                return;
            }
            hitungCOST();

        }

        private void txtCOSTREFUNDCUST_TextChanged(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtCOSTREFUNDCUST.Text))
            {
                MessageBox.Show("MOHON ISI DENGAN ANGKA", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtCOSTREFUNDCUST.Focus();
                txtCOSTREFUNDCUST.Text = "0";
                return;
            }
            System.Text.RegularExpressions.Regex nonNumericRegex = new System.Text.RegularExpressions.Regex(@"\D");
            if (nonNumericRegex.IsMatch(txtCOSTREFUNDCUST.Text))
            {
                MessageBox.Show("MOHON ISI DENGAN ANGKA", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtCOSTREFUNDCUST.Focus();
                txtCOSTREFUNDCUST.Text = "0";

                return;
            }
            hitungCOST();

        }

        private void btnTAMBAHPENERIMA_Click(object sender, EventArgs e)
        {
            VIEW.FormTAMBAHPENERIMA frm = new LOGISTICMANAGAMENTSYSTEM.VIEW.FormTAMBAHPENERIMA(this,null, 1);
            frm.ShowDialog();
        }

        private void txtPCS_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                txtNOCONNOTE.Focus();
            }
            else if (e.KeyCode == Keys.F2)
            {
                bntPENERIMA.Focus();
            }
            else if (e.KeyCode == Keys.F3)
            {
                txtPCS.Focus();
            }
            else if (e.KeyCode == Keys.F4)
            {
                chkPPN.Focus();
            }
            else if (e.KeyCode == Keys.F5)
            {
                btnALAUT.Focus();
            }
            else if (e.KeyCode == Keys.Space)
            {
                btnTAMBAH.Focus();
            }
            else if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
            if (string.IsNullOrEmpty(txtPCS.Text))
            {
                MessageBox.Show("MOHON ISI DENGAN ANGKA", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtPCS.Focus();
                return;
            }
            System.Text.RegularExpressions.Regex nonNumericRegex = new System.Text.RegularExpressions.Regex(@"\D");
            if (nonNumericRegex.IsMatch(txtPCS.Text))
            {
                MessageBox.Show("MOHON ISI DENGAN ANGKA", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtPCS.Focus();
                return;
            }
        }

        private void txtCHARGEPPN_KeyUp(object sender, KeyEventArgs e)
        {
            if (string.IsNullOrEmpty(txtCHARGEPPN.Text))
            {
                MessageBox.Show("MOHON ISI DENGAN ANGKA", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtCHARGEPPN.Focus();
                return;
            }
            System.Text.RegularExpressions.Regex nonNumericRegex = new System.Text.RegularExpressions.Regex(@"\D");
            if (nonNumericRegex.IsMatch(txtCHARGEPPN.Text))
            {
                MessageBox.Show("MOHON ISI DENGAN ANGKA", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtCHARGEPPN.Focus();
                return;
            }
        }

        private void btnTAMBAHPENERIMA_Leave(object sender, EventArgs e)
        {
            btnHitung.Focus();
        }

        private void txtWEIGHTDIM_Leave(object sender, EventArgs e)
        {
            chkPPN.Focus();
        }

        private void txtCHARGEPACKING_Leave(object sender, EventArgs e)
        {
            if (panelBIAYA.Visible)
            {
                txtCOSTSMU.Focus();
            }
            else
            {
                btnTAMBAH.Focus();
            }
        }

        private void txtCOSTREFUNDCUST_Leave(object sender, EventArgs e)
        {
            btnTAMBAH.Focus();
        }

        private void txtRATEKIRIM_Leave(object sender, EventArgs e)
        {
            chkISDIM.Focus();
            
        }

        private void chkISDIM_Leave(object sender, EventArgs e)
        {
            txtPDIM.Focus();
        }

        private void label36_Click(object sender, EventArgs e)
        {

        }

        private void FormDATAENTRY_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                txtNOCONNOTE.Focus();
            }
            else if (e.KeyCode == Keys.F2)
            {
                bntPENERIMA.Focus();
            }
            else if (e.KeyCode == Keys.F3)
            {
                txtPCS.Focus();
            }
            else if (e.KeyCode == Keys.F4)
            {
                chkPPN.Focus();
            }
            else if (e.KeyCode == Keys.F5)
            {
                btnALAUT.Focus();
            }
            else if (e.KeyCode == Keys.Space)
            {
                btnTAMBAH.Focus();
            }
            else if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }

        private void btnHitung_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                txtNOCONNOTE.Focus();
            }
            else if (e.KeyCode == Keys.F2)
            {
                bntPENERIMA.Focus();
            }
            else if (e.KeyCode == Keys.F3)
            {
                txtPCS.Focus();
            }
            else if (e.KeyCode == Keys.F4)
            {
                chkPPN.Focus();
            }
            else if (e.KeyCode == Keys.F5)
            {
                btnALAUT.Focus();
            }
            else if (e.KeyCode == Keys.Space)
            {
                btnTAMBAH.Focus();
            }
            else if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }

        private void txtNOCONNOTE_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                txtNOCONNOTE.Focus();
            }
            else if (e.KeyCode == Keys.F2)
            {
                bntPENERIMA.Focus();
            }
            else if (e.KeyCode == Keys.F3)
            {
                txtPCS.Focus();
            }
            else if (e.KeyCode == Keys.F4)
            {
                chkPPN.Focus();
            }
            else if (e.KeyCode == Keys.F5)
            {
                btnALAUT.Focus();
            }
            else if (e.KeyCode == Keys.Space)
            {
                btnTAMBAH.Focus();
            }
            else if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }

        private void btnCUST_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                txtNOCONNOTE.Focus();
            }
            else if (e.KeyCode == Keys.F2)
            {
                bntPENERIMA.Focus();
            }
            else if (e.KeyCode == Keys.F3)
            {
                txtPCS.Focus();
            }
            else if (e.KeyCode == Keys.F4)
            {
                chkPPN.Focus();
            }
            else if (e.KeyCode == Keys.F5)
            {
                btnALAUT.Focus();
            }
            else if (e.KeyCode == Keys.Space)
            {
                btnTAMBAH.Focus();
            }
            else if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }

        private void btnASAL_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                txtNOCONNOTE.Focus();
            }
            else if (e.KeyCode == Keys.F2)
            {
                bntPENERIMA.Focus();
            }
            else if (e.KeyCode == Keys.F3)
            {
                txtPCS.Focus();
            }
            else if (e.KeyCode == Keys.F4)
            {
                chkPPN.Focus();
            }
            else if (e.KeyCode == Keys.F5)
            {
                btnALAUT.Focus();
            }
            else if (e.KeyCode == Keys.Space)
            {
                btnTAMBAH.Focus();
            }
            else if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }

        private void bntTUJUAN_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                txtNOCONNOTE.Focus();
            }
            else if (e.KeyCode == Keys.F2)
            {
                bntPENERIMA.Focus();
            }
            else if (e.KeyCode == Keys.F3)
            {
                txtPCS.Focus();
            }
            else if (e.KeyCode == Keys.F4)
            {
                chkPPN.Focus();
            }
            else if (e.KeyCode == Keys.F5)
            {
                btnALAUT.Focus();
            }
            else if (e.KeyCode == Keys.Space)
            {
                btnTAMBAH.Focus();
            }
            else if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }

        private void btnTERUSAN_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                txtNOCONNOTE.Focus();
            }
            else if (e.KeyCode == Keys.F2)
            {
                bntPENERIMA.Focus();
            }
            else if (e.KeyCode == Keys.F3)
            {
                txtPCS.Focus();
            }
            else if (e.KeyCode == Keys.F4)
            {
                chkPPN.Focus();
            }
            else if (e.KeyCode == Keys.F5)
            {
                btnALAUT.Focus();
            }
            else if (e.KeyCode == Keys.Space)
            {
                btnTAMBAH.Focus();
            }
            else if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }

        private void cboSERVICE_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                txtNOCONNOTE.Focus();
            }
            else if (e.KeyCode == Keys.F2)
            {
                bntPENERIMA.Focus();
            }
            else if (e.KeyCode == Keys.F3)
            {
                txtPCS.Focus();
            }
            else if (e.KeyCode == Keys.F4)
            {
                chkPPN.Focus();
            }
            else if (e.KeyCode == Keys.F5)
            {
                btnALAUT.Focus();
            }
            else if (e.KeyCode == Keys.Space)
            {
                btnTAMBAH.Focus();
            }
            else if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }

        private void cboHANDLING_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                txtNOCONNOTE.Focus();
            }
            else if (e.KeyCode == Keys.F2)
            {
                bntPENERIMA.Focus();
            }
            else if (e.KeyCode == Keys.F3)
            {
                txtPCS.Focus();
            }
            else if (e.KeyCode == Keys.F4)
            {
                chkPPN.Focus();
            }
            else if (e.KeyCode == Keys.F5)
            {
                btnALAUT.Focus();
            }
            else if (e.KeyCode == Keys.Space)
            {
                btnTAMBAH.Focus();
            }
            else if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }

        private void bntAUDARA_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                txtNOCONNOTE.Focus();
            }
            else if (e.KeyCode == Keys.F2)
            {
                bntPENERIMA.Focus();
            }
            else if (e.KeyCode == Keys.F3)
            {
                txtPCS.Focus();
            }
            else if (e.KeyCode == Keys.F4)
            {
                chkPPN.Focus();
            }
            else if (e.KeyCode == Keys.F5)
            {
                btnALAUT.Focus();
            }
            else if (e.KeyCode == Keys.Space)
            {
                btnTAMBAH.Focus();
            }
            else if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }

        private void chkPPN_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                txtNOCONNOTE.Focus();
            }
            else if (e.KeyCode == Keys.F2)
            {
                bntPENERIMA.Focus();
            }
            else if (e.KeyCode == Keys.F3)
            {
                txtPCS.Focus();
            }
            else if (e.KeyCode == Keys.F4)
            {
                chkPPN.Focus();
            }
            else if (e.KeyCode == Keys.F5)
            {
                btnALAUT.Focus();
            }
            else if (e.KeyCode == Keys.Space)
            {
                btnTAMBAH.Focus();
            }
            else if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }

        private void btnALAUT_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                txtNOCONNOTE.Focus();
            }
            else if (e.KeyCode == Keys.F2)
            {
                bntPENERIMA.Focus();
            }
            else if (e.KeyCode == Keys.F3)
            {
                txtPCS.Focus();
            }
            else if (e.KeyCode == Keys.F4)
            {
                chkPPN.Focus();
            }
            else if (e.KeyCode == Keys.F5)
            {
                btnALAUT.Focus();
            }
            else if (e.KeyCode == Keys.Space)
            {
                btnTAMBAH.Focus();
            }
            else if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }

        private void bntADELIVER_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                txtNOCONNOTE.Focus();
            }
            else if (e.KeyCode == Keys.F2)
            {
                bntPENERIMA.Focus();
            }
            else if (e.KeyCode == Keys.F3)
            {
                txtPCS.Focus();
            }
            else if (e.KeyCode == Keys.F4)
            {
                chkPPN.Focus();
            }
            else if (e.KeyCode == Keys.F5)
            {
                btnALAUT.Focus();
            }
            else if (e.KeyCode == Keys.Space)
            {
                btnTAMBAH.Focus();
            }
            else if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }

        private void bntAGUDANG_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                txtNOCONNOTE.Focus();
            }
            else if (e.KeyCode == Keys.F2)
            {
                bntPENERIMA.Focus();
            }
            else if (e.KeyCode == Keys.F3)
            {
                txtPCS.Focus();
            }
            else if (e.KeyCode == Keys.F4)
            {
                chkPPN.Focus();
            }
            else if (e.KeyCode == Keys.F5)
            {
                btnALAUT.Focus();
            }
            else if (e.KeyCode == Keys.Space)
            {
                btnTAMBAH.Focus();
            }
            else if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }

        private void bntARA_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                txtNOCONNOTE.Focus();
            }
            else if (e.KeyCode == Keys.F2)
            {
                bntPENERIMA.Focus();
            }
            else if (e.KeyCode == Keys.F3)
            {
                txtPCS.Focus();
            }
            else if (e.KeyCode == Keys.F4)
            {
                chkPPN.Focus();
            }
            else if (e.KeyCode == Keys.F5)
            {
                btnALAUT.Focus();
            }
            else if (e.KeyCode == Keys.Space)
            {
                btnTAMBAH.Focus();
            }
            else if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }

        private void bntADARAT_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                txtNOCONNOTE.Focus();
            }
            else if (e.KeyCode == Keys.F2)
            {
                bntPENERIMA.Focus();
            }
            else if (e.KeyCode == Keys.F3)
            {
                txtPCS.Focus();
            }
            else if (e.KeyCode == Keys.F4)
            {
                chkPPN.Focus();
            }
            else if (e.KeyCode == Keys.F5)
            {
                btnALAUT.Focus();
            }
            else if (e.KeyCode == Keys.Space)
            {
                btnTAMBAH.Focus();
            }
            else if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }

        private void bntAGRDH_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                txtNOCONNOTE.Focus();
            }
            else if (e.KeyCode == Keys.F2)
            {
                bntPENERIMA.Focus();
            }
            else if (e.KeyCode == Keys.F3)
            {
                txtPCS.Focus();
            }
            else if (e.KeyCode == Keys.F4)
            {
                chkPPN.Focus();
            }
            else if (e.KeyCode == Keys.F5)
            {
                btnALAUT.Focus();
            }
            else if (e.KeyCode == Keys.Space)
            {
                btnTAMBAH.Focus();
            }
            else if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }

        private void bntPENERIMA_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                txtNOCONNOTE.Focus();
            }
            else if (e.KeyCode == Keys.F2)
            {
                bntPENERIMA.Focus();
            }
            else if (e.KeyCode == Keys.F3)
            {
                txtPCS.Focus();
            }
            else if (e.KeyCode == Keys.F4)
            {
                chkPPN.Focus();
            }
            else if (e.KeyCode == Keys.F5)
            {
                btnALAUT.Focus();
            }
            else if (e.KeyCode == Keys.Space)
            {
                btnTAMBAH.Focus();
            }
            else if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }

        private void bntPENERIMA_Click_1(object sender, EventArgs e)
        {
            VIEW.FormVIEWPENERIMA frm = new LOGISTICMANAGAMENTSYSTEM.VIEW.FormVIEWPENERIMA(this, null, 1);
            frm.ShowDialog();
        }

        private void btnTAMBAHPENERIMA_Click_1(object sender, EventArgs e)
        {
            VIEW.FormTAMBAHPENERIMA frm = new LOGISTICMANAGAMENTSYSTEM.VIEW.FormTAMBAHPENERIMA(this, null, 1);
            frm.ShowDialog();
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void label41_Click(object sender, EventArgs e)
        {

        }

        private void label47_Click(object sender, EventArgs e)
        {

        }

        private void txtNAMAGRDH_TextChanged(object sender, EventArgs e)
        {

        }

       
      

      

      
        

      
       

     

     

      

    
  

       

      
      

       
    }
}

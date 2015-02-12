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
    public partial class FormDAFTARBIAYASTT : Form
    {
        protected RMS.BUSSINES.DELIVERYORDER.RMS_DETAILINVOICE b = new RMS.BUSSINES.DELIVERYORDER.RMS_DETAILINVOICE();
        protected RMS.COMMON.DELIVERYORDER.RMS_DETAILINVOICE c = new RMS.COMMON.DELIVERYORDER.RMS_DETAILINVOICE();
        protected RMS.COMMON.GENERAL.RMS_COMBO combo = new RMS.COMMON.GENERAL.RMS_COMBO();
        protected RMS.BUSSINES.GENERAL.RMS_COMBO comboQuery = new RMS.BUSSINES.GENERAL.RMS_COMBO();
        protected RMS.COMMON.MASTER.RMS_USER cUser = new RMS.COMMON.MASTER.RMS_USER();
        protected RMS.BUSSINES.MASTER.RMS_USER bUser = new RMS.BUSSINES.MASTER.RMS_USER();
        protected RMS.BUSSINES.MASTER.RMS_TENTANGPERUSAHAAN bPersusahaan = new RMS.BUSSINES.MASTER.RMS_TENTANGPERUSAHAAN();
        protected RMS.COMMON.MASTER.RMS_TENTANGPERUSAHAAN cPersusahaan = new RMS.COMMON.MASTER.RMS_TENTANGPERUSAHAAN();
        string kodePerusahaan, namaPerusahaan, alamatPerusahaan, telpPerusahaan, faxPerusahaan;


        DataTable dataPrint;
        public FormDAFTARBIAYASTT()
        {
            InitializeComponent();
           
            SETTING_MANUAL();
            INIT_PERUSAHAAN();
            LOAD_DATA();
            myToolTip();
        }
        void SETTING_MANUAL()
        {
            this.Size = new Size(1365, 608);

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
            dataPrint.Columns.Add("STARTDATE", typeof(string));
            dataPrint.Columns.Add("ENDDATE", typeof(string));
            dataPrint.Columns.Add("DATE", typeof(string));
            dataPrint.Columns.Add("CUSTOMER", typeof(string));
            dataPrint.Columns.Add("STT", typeof(string));
            dataPrint.Columns.Add("DEST", typeof(string));
            dataPrint.Columns.Add("ARMADA", typeof(string));
            dataPrint.Columns.Add("SERVICE", typeof(string));
            dataPrint.Columns.Add("BERAT", typeof(string));
            dataPrint.Columns.Add("TOTAL", typeof(string));
            dataPrint.Columns.Add("FEEMKRT", typeof(string));
            dataPrint.Columns.Add("RC", typeof(string));
            dataPrint.Columns.Add("COSTSMU", typeof(string));
            dataPrint.Columns.Add("COSTGRDH", typeof(string));
            dataPrint.Columns.Add("COSTWH", typeof(string));
            dataPrint.Columns.Add("COSTDARAT", typeof(string));
            dataPrint.Columns.Add("COSTLAUT", typeof(string));
            dataPrint.Columns.Add("COSTDELIVERY", typeof(string));
            dataPrint.Columns.Add("COSTRA", typeof(string));
            dataPrint.Columns.Add("TOTALCOST", typeof(string));
            dataPrint.Columns.Add("PROFIT", typeof(string));
            dataPrint.Columns.Add("PROFITPERCENT", typeof(string));
            dataPrint.Columns.Add("OPT1 ", typeof(string));
            dataPrint.Columns.Add("OPT2", typeof(string));
            dataPrint.Columns.Add("OPT3", typeof(string));
            dataPrint.Columns.Add("NAMAPERUSAHAAN", typeof(string));
            dataPrint.Columns.Add("ALAMATPERUSAHAAN", typeof(string));
            dataPrint.Columns.Add("TELPPERUSAHAAN", typeof(string));
            dataPrint.Columns.Add("FAXPERUSAHAAN", typeof(string));
            dataPrint.Columns.Add("NO", typeof(string));


        }
        private void myToolTip()
        {
            ToolTip myToolTip = new ToolTip();
            myToolTip.SetToolTip(txtCARI, "Cari Berdasarkan Salah Satu data : Marketing, Customer, Status bayar, DEST");

        }
        public void LOAD_DATA()
        {


            c.STATUSSTT = cboTERMOFPAYMENT.Text;
            c.STARTDATE = dtStart.Value.ToString("yyyy-MM-dd");
            c.ENDDATE = dtEnd.Value.ToString("yyyy-MM-dd");

            dgvSTT.DataSource = null;
            dgvSTT.Rows.Clear();
            DataTable dt;
            SET_PRINT();
            if (string.IsNullOrEmpty(c.NAMACUSTOMER))
            {
                dt = b.SELECT(c);
            }
            else
            {
                dt = b.SELECTLIKE(c);
            }
            string BERAT;
            int TRECORD = 1;
            int TBERAT = 0;
            int TOTALCHARGE = 0;
            int TCHARGE = 0;
            int TOTHER = 0;
            int TCOLLY = 0;
            int TFEE = 0;
            int TRC = 0;

            // Biaya
            int TUDARA = 0;
            int TDARAT = 0;
            int TLAUT = 0;
            int TDELIVERY = 0;
            int TWAREHOUSE = 0;
            int TGRDH = 0;
            int TRA = 0;
            // grantotal & profit
            
            int grandtotal = 0;
            int TPROFIT = 0;
            int TPROFITPERCENT = 0;
            decimal opt1 = 0;
            if (dt.Rows.Count > 0)
            {
                int no_urut = 1;
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                   

                    string ID = dt.Rows[i]["ID"].ToString();
                    string DATE = DateTime.Parse(dt.Rows[i]["DATE"].ToString()).ToString("dd-MM-yyyy");
                    string TPAYMENT = dt.Rows[i]["TPAYMENT"].ToString();
                    string STT = dt.Rows[i]["NOCONNOTE"].ToString();
                    string CUSTOMER = dt.Rows[i]["CUSTOMER"].ToString();
                    string PENERIMA = dt.Rows[i]["CONSIGNEE"].ToString();
                    string MARKETING = dt.Rows[i]["MARKETING"].ToString();
                    string FEEMKRT = int.Parse(dt.Rows[i]["FEEMKT"].ToString()).ToString("N0");
                    string RC = int.Parse(dt.Rows[i]["REFUND"].ToString()).ToString("N0");
                    string DEST = string.Empty;
                    if (string.IsNullOrEmpty(dt.Rows[i]["NAMATERUSAN"].ToString()))
                    {
                        DEST = dt.Rows[i]["DEST"].ToString();
                    }
                    else
                    {
                        string terusan = dt.Rows[i]["NAMATERUSAN"].ToString();
                        DEST = dt.Rows[i]["DEST"].ToString();
                        DEST = DEST + "/" + terusan;
                    }

                    string ARMADA = dt.Rows[i]["HANDLING"].ToString();
                    string SERVICE = dt.Rows[i]["SERVICE"].ToString();
                    string COLLY = dt.Rows[i]["COLLIE"].ToString();
                    if (dt.Rows[i]["WEIGHT"].ToString() == "0")
                    {
                        BERAT = dt.Rows[i]["WEIGHTDIM"].ToString();
                    }
                    else
                    {
                        BERAT = dt.Rows[i]["WEIGHT"].ToString();
                    }

                    string RATE = int.Parse(dt.Rows[i]["RATE_KIRIM"].ToString()).ToString("N0");
                    string CHARGE = int.Parse(dt.Rows[i]["CHARGE_KIRIM"].ToString()).ToString("N0");
                    string OTHER = int.Parse(dt.Rows[i]["OTHERCHARGE"].ToString()).ToString("N0");
                    string TOTAL = int.Parse(dt.Rows[i]["TOTAL_CHARGE"].ToString()).ToString("N0");
                    string STATUS = dt.Rows[i]["STATUS"].ToString();
                    string AGNTUDARA = dt.Rows[i]["AGNTAF"].ToString();
                    string AGNTDARAT = dt.Rows[i]["AGNTTRUCKING"].ToString();
                    string AGNTLAUT = dt.Rows[i]["AGNTSHIPPING"].ToString();
                    string AGNTDELIVERY = dt.Rows[i]["AGNTDELIVERY"].ToString();
                    string AGNTWAREHOUSE = dt.Rows[i]["AGNTWH"].ToString();
                    string AGNTGRDH = dt.Rows[i]["AGNTGRDH"].ToString();
                    string AGNTRA = dt.Rows[i]["AGNTRA"].ToString();
                    string COSTUDARA = int.Parse(dt.Rows[i]["COST_SMU"].ToString()).ToString("N0");
                    string COSTDARAT = int.Parse(dt.Rows[i]["CTRUCKING"].ToString()).ToString("N0");
                    string COSTLAUT = int.Parse(dt.Rows[i]["COST_SHIPPING"].ToString()).ToString("N0");
                    string COSTDELIVERY = int.Parse(dt.Rows[i]["CDELIVERY"].ToString()).ToString("N0");
                  
                    string COSTWAREHOUSE = int.Parse(dt.Rows[i]["CWH"].ToString()).ToString("N0");
                    string COSTGRDH = int.Parse(dt.Rows[i]["CGRDH"].ToString()).ToString("N0");
                    string COSTRA = int.Parse(dt.Rows[i]["COST_RA"].ToString()).ToString("N0");
                    string TOTALCOST = int.Parse(dt.Rows[i]["TOTAL_COST"].ToString()).ToString("N0");
                    string PROFIT = int.Parse(dt.Rows[i]["TOTAL_PROFIT"].ToString()).ToString("N0");
                    decimal totalPROFITPERCENT = Math.Round((decimal.Parse(PROFIT) / decimal.Parse(TOTAL) * 100));
                    string PROFITPERCENT = totalPROFITPERCENT.ToString();
                    


                    TCHARGE += int.Parse(dt.Rows[i]["CHARGE_KIRIM"].ToString());
                    TOTHER += int.Parse(dt.Rows[i]["OTHERCHARGE"].ToString());
                    TCOLLY += int.Parse(dt.Rows[i]["COLLIE"].ToString());
                    TBERAT += int.Parse(BERAT);
                    TFEE += int.Parse(dt.Rows[i]["FEEMKT"].ToString());
                    TRC += int.Parse(dt.Rows[i]["REFUND"].ToString());
                    
                    TUDARA += int.Parse(dt.Rows[i]["COST_SMU"].ToString());
                    TDARAT += int.Parse(dt.Rows[i]["CTRUCKING"].ToString());
                    TLAUT += int.Parse(dt.Rows[i]["COST_SHIPPING"].ToString());
                    TDELIVERY += int.Parse(dt.Rows[i]["CDELIVERY"].ToString());
                    TWAREHOUSE += int.Parse(dt.Rows[i]["CWH"].ToString());
                    TGRDH += int.Parse(dt.Rows[i]["CGRDH"].ToString());
                    TRA += int.Parse(dt.Rows[i]["COST_RA"].ToString());
                    TPROFIT += int.Parse(dt.Rows[i]["TOTAL_PROFIT"].ToString());
                    TOTALCHARGE += int.Parse(dt.Rows[i]["TOTAL_CHARGE"].ToString());
                    dgvSTT.Rows.Add(ID,DATE,CUSTOMER,STT,DEST,ARMADA,SERVICE,BERAT,TOTAL,FEEMKRT,RC,COSTUDARA,COSTGRDH,COSTWAREHOUSE,COSTDARAT,COSTLAUT,COSTDELIVERY,COSTRA,TOTALCOST,PROFIT,PROFITPERCENT);
                    if (TPROFIT != 0)
                    {
                        opt1 = Math.Round((decimal.Parse(TPROFIT.ToString()) / decimal.Parse(TOTALCHARGE.ToString()) * 100));
                    }
                    grandtotal += int.Parse(dt.Rows[i]["TOTAL_COST"].ToString());
                    dataPrint.Rows.Add(c.STARTDATE, c.ENDDATE, DATE, CUSTOMER, STT, DEST, ARMADA, SERVICE, BERAT, TOTAL, FEEMKRT, RC, COSTUDARA, COSTGRDH, COSTWAREHOUSE, COSTDARAT, COSTLAUT, COSTDELIVERY, COSTRA, TOTALCOST, PROFIT, PROFITPERCENT, opt1.ToString(), "", "", namaPerusahaan, alamatPerusahaan, telpPerusahaan, faxPerusahaan,no_urut);
                    no_urut++;


                }
                
                txtTBERAT.Text = TBERAT.ToString();
                txtCOLLY.Text = TCOLLY.ToString();
                txtFEE.Text = TFEE.ToString("N0");
                txtRC.Text = TRC.ToString("N0");

                txtUDARA.Text = TUDARA.ToString("N0");
                txtDARAT.Text = TDARAT.ToString("N0");
                txtLAUT.Text = TLAUT.ToString("N0");
                txtDELIVERY.Text = TDELIVERY.ToString("N0");
                txtWAREHOUSE.Text = TWAREHOUSE.ToString("N0");
                txtGRDH.Text = TGRDH.ToString("N0");
                txtRA.Text = TRA.ToString("N0");
                txtTOTALCHARGE.Text = TOTALCHARGE.ToString("N0");
                txtGRANDTOTALCOST.Text = grandtotal.ToString("N0");
                txtTOTALPROFIT.Text = TPROFIT.ToString("N0");
                decimal TOTALPROFITPERCENT = Math.Round((decimal.Parse(txtTOTALPROFIT.Text.ToString()) / decimal.Parse(txtTOTALCHARGE.Text.ToString()) * 100));
                txtTOTALPROFITPERCENT.Text = TOTALPROFITPERCENT.ToString()+ " %";
            }

        }
        public void setCOMBO()
        {

            DataTable dtSTATUSSTT = new DataTable();
            dtSTATUSSTT = comboQuery.SELECTSTATUSSTT();

            cboTERMOFPAYMENT.DataSource = dtSTATUSSTT;
            cboTERMOFPAYMENT.ValueMember = dtSTATUSSTT.Columns[0].ColumnName;
            cboTERMOFPAYMENT.DisplayMember = dtSTATUSSTT.Columns[1].ColumnName;



        }

        private void txtCARI_TextChanged(object sender, EventArgs e)
        {
            c.MARKETING = txtCARI.Text;
            c.NAMACUSTOMER = txtCARI.Text;
            c.NAMAKOTADEST = txtCARI.Text;
            c.STATUSPEMBAYARAN = txtCARI.Text;
            c.MARKETING = txtCARI.Text;
            c.SERVICE = txtCARI.Text;
            c.ARMADA = txtCARI.Text;

            LOAD_DATA();
        }

        private void cboTERMOFPAYMENT_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboTERMOFPAYMENT.Text == "PREPAID")
            {
                c.IDSTATUSSTT = 1;
                c.STATUSSTT = "PREPAID";
            }
            else
            {
                c.IDSTATUSSTT = 2;
                c.STATUSSTT = "COLLECT";
            }
            
          
        }

        private void btnCARI_Click(object sender, EventArgs e)
        {
            txtTBERAT.Text = "0";
            txtTOTALCHARGE.Text = "0";
            LOAD_DATA();
        }

        private void FormDAFTARBIAYASTT_Load(object sender, EventArgs e)
        {
            this.cboTERMOFPAYMENT.Text = "SEMUA";
        }
        void CETAK()
        {
            CrystalDecisions.CrystalReports.Engine.ReportDocument cryRpt = new CrystalDecisions.CrystalReports.Engine.ReportDocument();
            REPORTS.INVOICE.FormBIAYASTT frm = new REPORTS.INVOICE.FormBIAYASTT(dataPrint);
            frm.ShowDialog();
        }

        private void btnKELUAR_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCetak_Click(object sender, EventArgs e)
        {
            CETAK();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }
    }
}

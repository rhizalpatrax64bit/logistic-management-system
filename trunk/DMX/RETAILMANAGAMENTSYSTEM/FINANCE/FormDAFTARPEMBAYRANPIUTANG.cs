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
    public partial class FormDAFTARPEMBAYRANPIUTANG : Form
    {
        protected RMS.BUSSINES.DELIVERYORDER.RMS_DETAILINVOICE b = new RMS.BUSSINES.DELIVERYORDER.RMS_DETAILINVOICE();
        protected RMS.COMMON.DELIVERYORDER.RMS_DETAILINVOICE c = new RMS.COMMON.DELIVERYORDER.RMS_DETAILINVOICE();

        protected RMS.BUSSINES.DELIVERYORDER.RMS_INVOICE bINV = new RMS.BUSSINES.DELIVERYORDER.RMS_INVOICE();
        protected RMS.COMMON.DELIVERYORDER.RMS_INVOICE cINV = new RMS.COMMON.DELIVERYORDER.RMS_INVOICE();

        protected RMS.BUSSINES.DELIVERYORDER.RMS_PEMBAYARAN bPMB = new RMS.BUSSINES.DELIVERYORDER.RMS_PEMBAYARAN();
        protected RMS.COMMON.DELIVERYORDER.RMS_PEMBAYARAN cpMB = new RMS.COMMON.DELIVERYORDER.RMS_PEMBAYARAN();
        public FormDAFTARPEMBAYRANPIUTANG()
        {
            InitializeComponent();
            SETTING_MANUAL();
            c.STATUSSTT = "PAID";
            cboSTATUS.Text = "BELUM LUNAS";
            c.STATUS = "BELUM LUNAS";
            LOAD_DATA();
        }
        void SETTING_MANUAL()
        {
            this.Size = new Size(1365, 608);

        }
        public void LOAD_DATAINVOICE()
        {
            c.STARTDATE = dtBEGIN.Value.ToString("yyyy-MM-dd");
            c.ENDDATE = dtEND.Value.ToString("yyyy-MM-dd");

            //dgvSTTPAID.DataSource = null;
            //dgvSTTPAID.Rows.Clear();
            dgvPREPAID.DataSource = null;
            dgvPREPAID.Rows.Clear();
            dgvCOLLECT.DataSource = null;
            dgvCOLLECT.Rows.Clear();


            DataTable dt = b.SELECTPEMB(c);
            string WEIGHT;
            string tipe;
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {

                    string ID = dt.Rows[i]["ID"].ToString();
                    string DATE = DateTime.Parse(dt.Rows[i]["DATE"].ToString()).ToString("dd-MM-yyyy");
                    string NOCONNOTE = dt.Rows[i]["NOCONNOTE"].ToString();
                    string CUSTOMER = dt.Rows[i]["CUSTOMER"].ToString();
                    string CONNOTENO = dt.Rows[i]["NOCONNOTE"].ToString();
                    string TPAYMENT = dt.Rows[i]["TPAYMENT"].ToString();
                    string DEST = dt.Rows[i]["DEST"].ToString();
                    string CONSIGNEE = dt.Rows[i]["CONSIGNEE"].ToString();
                    string COLLIE = dt.Rows[i]["COLLIE"].ToString();
                    if (dt.Rows[i]["WEIGHT"].ToString() != "0")
                    {
                        WEIGHT = dt.Rows[i]["WEIGHT"].ToString();
                        tipe = "PKG";
                    }
                    else
                    {
                        WEIGHT = dt.Rows[i]["WEIGHTDIM"].ToString();
                        tipe = "DIM";
                    }

                    string CHARGE = dt.Rows[i]["CHARGE_KIRIM"].ToString();
                    string PACKING = dt.Rows[i]["PACKING"].ToString();
                    string PPN = dt.Rows[i]["PPN"].ToString();
                    string INSURANCE = dt.Rows[i]["INSURANCE"].ToString();
                    string SERVICE = dt.Rows[i]["SERVICE"].ToString();
                    string TCHARGE = dt.Rows[i]["TOTAL_CHARGE"].ToString();
                    string TBAYAR = dt.Rows[i]["TOTALBAYAR"].ToString();
                    string SISA = dt.Rows[i]["SISAKEKURANGAN"].ToString();
                    string STATUS = dt.Rows[i]["STATUS"].ToString();
                    bool ISINVOICE = Convert.ToBoolean(dt.Rows[i]["ISINVOICE"]);

                    if (TPAYMENT == "PREPAID" && ISINVOICE == false)
                    {
                        dgvPREPAID.Rows.Add(ID, DATE, CUSTOMER, CONNOTENO, TPAYMENT, DEST, CONSIGNEE, COLLIE, WEIGHT, tipe, CHARGE, PACKING, PPN, INSURANCE, SERVICE, TCHARGE, TBAYAR, SISA, STATUS);
                    }
                    else 
                    {
                        dgvCOLLECT.Rows.Add(ID, DATE, CUSTOMER, CONNOTENO, TPAYMENT, DEST, CONSIGNEE, COLLIE, WEIGHT, tipe, CHARGE, PACKING, PPN, INSURANCE, SERVICE, TCHARGE, TBAYAR, SISA, STATUS);
                    }

                }
            }
        }
        public void LOAD_DATA()
        {
            
            c.STARTDATE = dtBEGIN.Value.ToString("yyyy-MM-dd");
            c.ENDDATE = dtEND.Value.ToString("yyyy-MM-dd");
            
            dgvSTTPAID.DataSource = null;
            dgvSTTPAID.Rows.Clear();          

            DataTable dt = b.SELECTPMBINV(c);
            string WEIGHT;
            string tipe;
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                   
                    string ID = dt.Rows[i]["ID"].ToString();
                    string TGLINVOICE = DateTime.Parse(dt.Rows[i]["TGLINVOICE"].ToString()).ToString("dd-MM-yyyy");
                    string KODEINVOICE = dt.Rows[i]["KODEINVOICE"].ToString();
                    string NAMACUSTOMER = dt.Rows[i]["NAMACUSTOMER"].ToString();
                    string PPN = dt.Rows[i]["PPN"].ToString();
                    string INSURANCE = dt.Rows[i]["INSURANCE"].ToString();
                    string PACKING = dt.Rows[i]["PACKING"].ToString();
                    string CHARGE = dt.Rows[i]["CHARGE"].ToString();
                    string TOTALBAYAR = dt.Rows[i]["TOTALBAYAR"].ToString();
                    string SISAKEKURANGAN = dt.Rows[i]["SISAKEKURANGAN"].ToString();
                    string STATUS;
                    

                    if (dt.Rows[i]["SISAKEKURANGAN"].ToString() != "0")
                    {
                        STATUS = "BELUM LUNAS";
                    }
                    else
                    {
                        STATUS = "LUNAS";
                    }
                    if (cboSTATUS.Text == "BELUM LUNAS")
                    {
                        if (STATUS == "BELUM LUNAS")
                        {
                            dgvSTTPAID.Rows.Add(ID, TGLINVOICE, KODEINVOICE, NAMACUSTOMER, PPN, INSURANCE, PACKING, CHARGE, TOTALBAYAR, SISAKEKURANGAN, STATUS);
                        }
                    }
                    else if (cboSTATUS.Text == "LUNAS")
                    {
                        if (STATUS == "LUNAS")
                        {
                            dgvSTTPAID.Rows.Add(ID, TGLINVOICE, KODEINVOICE, NAMACUSTOMER, PPN, INSURANCE, PACKING, CHARGE, TOTALBAYAR, SISAKEKURANGAN, STATUS);
                        }
                    }
                    else
                    {
                        dgvSTTPAID.Rows.Add(ID, TGLINVOICE, KODEINVOICE, NAMACUSTOMER, PPN, INSURANCE, PACKING, CHARGE, TOTALBAYAR, SISAKEKURANGAN, STATUS);
                    }
                }
            }
        }
        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void tabCASH_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabCASH.SelectedTab == tabCASH.TabPages["PAID"])//your specific tabname
            {
                c.STATUSSTT = "PAID";
                c.STATUS = cboSTATUS.Text;
                LOAD_DATA();
            }
            else if (tabCASH.SelectedTab == tabCASH.TabPages["PREPAID"])
            {
                c.STATUSSTT = "PREPAID";
                c.STATUS = cboSTATUS.Text;
                LOAD_DATA();
            }
            else
            {
                c.STATUSSTT = "COLLECT";
                c.STATUS = cboSTATUS.Text;
                LOAD_DATA();

            }

        }
       
        private void FormDAFTARPEMBAYRANPIUTANG_Load(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            c.STATUS = cboSTATUS.Text;
            LOAD_DATAINVOICE();
            LOAD_DATA();
        }

        private void btnTAMBAH_Click(object sender, EventArgs e)
        {
           
            if (tabCASH.SelectedTab == tabCASH.TabPages["PAID"])//your specific tabname
            {
                if (dgvSTTPAID.SelectedCells.Count > 0)
                {
                    int ID = int.Parse(dgvSTTPAID.SelectedCells[0].OwningRow.Cells["ID"].Value.ToString());
                    cINV.ID = ID;
                    cINV.KODEINVOICE = dgvSTTPAID.SelectedCells[0].OwningRow.Cells["INVOICE"].Value.ToString();
                    FINANCE.FormPEMBAYARANINVOICE frm = new LOGISTICMANAGAMENTSYSTEM.FINANCE.FormPEMBAYARANINVOICE(this, 1, cINV);
                    frm.ShowDialog();
                }
            }
            else if (tabCASH.SelectedTab == tabCASH.TabPages["PREPAID"])
            {
                if (dgvPREPAID.SelectedCells.Count > 0)
                {
                    int ID = int.Parse(dgvPREPAID.SelectedCells[0].OwningRow.Cells["IDSTTCASH"].Value.ToString());
                    c.ID = ID;
                    FINANCE.FormPEMBAYARAN frm = new LOGISTICMANAGAMENTSYSTEM.FINANCE.FormPEMBAYARAN(this, 1, c);
                    frm.ShowDialog();
                };
            }
            else
            {
               int ID = int.Parse(dgvCOLLECT.SelectedCells[0].OwningRow.Cells["IDSTTCOLL"].Value.ToString());
               c.ID = ID;
               FINANCE.FormPEMBAYARAN frm = new LOGISTICMANAGAMENTSYSTEM.FINANCE.FormPEMBAYARAN(this, 1, c);
               frm.ShowDialog();

            }
        }

        private void btnCetak_Click(object sender, EventArgs e)
        {

        }

        private void btnKELUAR_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

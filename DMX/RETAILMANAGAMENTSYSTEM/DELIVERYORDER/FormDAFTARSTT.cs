using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//using GemBox.Spreadsheet;
//using GemBox.Spreadsheet.WinFormsUtilities;

namespace LOGISTICMANAGAMENTSYSTEM.DELIVERYORDER
{
    public partial class FormDAFTARSTT : Form
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
        public FormDAFTARSTT(RMS.COMMON.MASTER.RMS_USER obj)
        {
            InitializeComponent();            
            //this.setCOMBO();
        
            cUser = obj;
            SETTING_MANUAL();
            INIT_PERUSAHAAN();
            LOAD_DATA();
            LOAD_DATAUSER();
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
            dataPrint.Columns.Add("NO", typeof(string));
            dataPrint.Columns.Add("STARTDATE", typeof(string));
            dataPrint.Columns.Add("ENDDATE", typeof(string));
            dataPrint.Columns.Add("DATE", typeof(string));
            dataPrint.Columns.Add("TPAYMENT", typeof(string));
            dataPrint.Columns.Add("STT", typeof(string));
            dataPrint.Columns.Add("CUSTOMER", typeof(string));
            dataPrint.Columns.Add("PENERIMA", typeof(string));
            dataPrint.Columns.Add("MARKETING", typeof(string));
            dataPrint.Columns.Add("FEEMKRT", typeof(string));
            dataPrint.Columns.Add("RC", typeof(string));
            dataPrint.Columns.Add("DEST", typeof(string));
            dataPrint.Columns.Add("SERVICE", typeof(string));
            dataPrint.Columns.Add("ARMADA", typeof(string));
            dataPrint.Columns.Add("COLLY", typeof(string));
            dataPrint.Columns.Add("BERAT", typeof(string));
            dataPrint.Columns.Add("RATE", typeof(string));
            dataPrint.Columns.Add("CHARGE", typeof(string));
            dataPrint.Columns.Add("OTHER", typeof(string));
            dataPrint.Columns.Add("TOTAL", typeof(string));
            dataPrint.Columns.Add("STATUS", typeof(string));
            dataPrint.Columns.Add("OPT1 ", typeof(string));
            dataPrint.Columns.Add("OPT2", typeof(string));
            dataPrint.Columns.Add("OPT3", typeof(string));
            dataPrint.Columns.Add("NAMAPERUSAHAAN", typeof(string));
            dataPrint.Columns.Add("ALAMATPERUSAHAAN", typeof(string));
            dataPrint.Columns.Add("TELPPERUSAHAAN", typeof(string));
            dataPrint.Columns.Add("FAXPERUSAHAAN", typeof(string));


        }
        private void myToolTip()
        {
            ToolTip myToolTip = new ToolTip();
            myToolTip.SetToolTip(txtCARI, "Cari Berdasarkan Salah Satu data : Marketing, Customer, Status bayar, DEST");
            
        }

        private void btnTAMBAH_Click(object sender, EventArgs e)
        {
            TAMBAH();
        }
        public void LOAD_DATAUSER()
        {                   
            DataTable dt;           
            dt = bUser.CARI_BYNAMA(cUser);           

            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    cUser.id = int.Parse(dt.Rows[i]["id"].ToString());
                    cUser.nama = dt.Rows[i]["nama"].ToString();
                    cUser.level = dt.Rows[i]["level"].ToString();
                    cUser.username = dt.Rows[i]["username"].ToString();
                    cUser.password = dt.Rows[i]["password"].ToString();
                    cUser.hp = dt.Rows[i]["hp"].ToString();
                    cUser.alamat = dt.Rows[i]["alamat"].ToString();
                    cUser.isaktif = bool.Parse(dt.Rows[i]["isaktif"].ToString());
                    cUser.isbiayastt = bool.Parse(dt.Rows[i]["isbiayastt"].ToString());
                    cUser.ispiutang = bool.Parse(dt.Rows[i]["ispiutang"].ToString());
                    cUser.ismasterdata = bool.Parse(dt.Rows[i]["ismasterdata"].ToString());
                    cUser.isagent = bool.Parse(dt.Rows[i]["isagent"].ToString());
                    cUser.ispricelist = bool.Parse(dt.Rows[i]["ispricelist"].ToString());
                    cUser.isuser = bool.Parse(dt.Rows[i]["isuser"].ToString());
                    cUser.islaporan = bool.Parse(dt.Rows[i]["islaporan"].ToString());
                    
                }
            }

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
            if(string.IsNullOrEmpty(c.NAMACUSTOMER))
            {
                dt= b.SELECT(c);
            }
            else
            {
               dt = b.SELECTLIKE(c);
            }
            string BERAT;
            int TBERAT = 0;
            int TOTALCHARGE = 0;
            int TCHARGE = 0;
            int TOTHER = 0;
            int TCOLLY = 0;
            int TFEE = 0;
            int  TRC = 0;
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
                    int ISINVOICE = int.Parse(dt.Rows[i]["ISINVOICE"].ToString());
                    string DEST = string.Empty;

                    if (ISINVOICE != 0)
                    {                       
                        //dgvSTT.DefaultCellStyle.ForeColor = Color.Red;
                        dgvSTT.DefaultCellStyle.BackColor = Color.Aquamarine;
                    }
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
                    TCHARGE += int.Parse(dt.Rows[i]["CHARGE_KIRIM"].ToString());
                    TOTHER += int.Parse(dt.Rows[i]["OTHERCHARGE"].ToString());
                    TCOLLY += int.Parse(dt.Rows[i]["COLLIE"].ToString());
                    TBERAT += int.Parse(BERAT);
                    TFEE += int.Parse(dt.Rows[i]["FEEMKT"].ToString());
                    TRC += int.Parse(dt.Rows[i]["REFUND"].ToString());
                    TOTALCHARGE += int.Parse(dt.Rows[i]["TOTAL_CHARGE"].ToString());
                    dgvSTT.Rows.Add(ID, DATE, STT, CUSTOMER,PENERIMA, MARKETING, FEEMKRT, RC, DEST, SERVICE,ARMADA, COLLY, BERAT, RATE, CHARGE, OTHER,TOTAL,STATUS);
                    txtTBERAT.Text = TBERAT.ToString();
                    txtCHARGE.Text = TCHARGE.ToString("N0");
                    txtOTHER.Text = TOTHER.ToString("N0");
                    txtCOLLY.Text = TCOLLY.ToString();
                    txtFEE.Text = TFEE.ToString("N0");
                    txtRC.Text = TRC.ToString("N0");
                    txtTOTALCHARGE.Text = TOTALCHARGE.ToString("N0");
                    dataPrint.Rows.Add(no_urut, c.STARTDATE, c.ENDDATE, DATE, TPAYMENT, STT, CUSTOMER, PENERIMA, MARKETING, FEEMKRT, RC, DEST, SERVICE, ARMADA, COLLY, BERAT, RATE, CHARGE, OTHER, TOTAL, STATUS, "", "", "", namaPerusahaan, alamatPerusahaan, telpPerusahaan, faxPerusahaan);
                    no_urut++;

                    
                }
                
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
           
          //DataRow selectedDataRow = ((DataRowView)cboTERMOFPAYMENT.SelectedItem).Row;
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

        private void button1_Click(object sender, EventArgs e)
        {
            txtTBERAT.Text = "0";
            txtTOTALCHARGE.Text = "0";
            LOAD_DATA();
        }

        private void btnEDIT_Click(object sender, EventArgs e)
        {
            EDIT();
        }

        private void FormDAFTARSTT_Load(object sender, EventArgs e)
        {
            this.cboTERMOFPAYMENT.Text = "SEMUA";
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnCetak_Click(object sender, EventArgs e)
        {
            CETAK();
        }

        void TAMBAH()
        {
            DELIVERYORDER.FormDATAENTRY frm = new DELIVERYORDER.FormDATAENTRY(this, 0, c, cUser);
            frm.ShowDialog();
        }
        void EDIT()
        {
            if (dgvSTT.SelectedCells.Count > 0)
            {
                int ID = int.Parse(dgvSTT.SelectedCells[0].OwningRow.Cells["ID"].Value.ToString());
                c.ID = ID;
                DELIVERYORDER.FormDATAENTRY frm = new LOGISTICMANAGAMENTSYSTEM.DELIVERYORDER.FormDATAENTRY(this, 1, c, cUser);
                frm.ShowDialog();
            }
        }
        void CETAK()
        {
            CrystalDecisions.CrystalReports.Engine.ReportDocument cryRpt = new CrystalDecisions.CrystalReports.Engine.ReportDocument();
            REPORTS.INVOICE.FormSTT frm = new REPORTS.INVOICE.FormSTT(dataPrint);
            frm.ShowDialog();
        }

        private void FormDAFTARSTT_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                txtCARI.Focus();
            }
            else if (e.KeyCode == Keys.F2)
            {
                TAMBAH();
            }
            else if (e.KeyCode == Keys.F3)
            {
                EDIT();
            }
            else if (e.KeyCode == Keys.F4)
            {
                
            }
            else if (e.KeyCode == Keys.F5)
            {
                CETAK();
            }
            else if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }

        private void txtCARI_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                txtCARI.Focus();
            }
            else if (e.KeyCode == Keys.F2)
            {
                TAMBAH();
            }
            else if (e.KeyCode == Keys.F3)
            {
                EDIT();
            }
            else if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }

        private void btnKELUAR_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnHAPUS_Click(object sender, EventArgs e)
        {

        }

     
       
    }
}

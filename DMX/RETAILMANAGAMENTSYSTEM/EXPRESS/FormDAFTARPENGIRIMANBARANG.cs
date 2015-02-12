using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LOGISTICMANAGAMENTSYSTEM.EXPRESS
{
    public partial class FormDAFTARPENGIRIMANBARANG : Form
    {
        protected RMS.BUSSINES.EXPRESS.RMS_SPJ b = new RMS.BUSSINES.EXPRESS.RMS_SPJ();
        protected RMS.COMMON.EXPRESS.RMS_SPJ c = new RMS.COMMON.EXPRESS.RMS_SPJ();
        protected RMS.COMMON.GENERAL.RMS_COMBO combo = new RMS.COMMON.GENERAL.RMS_COMBO();
        protected RMS.BUSSINES.GENERAL.RMS_COMBO comboQuery = new RMS.BUSSINES.GENERAL.RMS_COMBO();
        protected RMS.COMMON.MASTER.RMS_USER cUser = new RMS.COMMON.MASTER.RMS_USER();
        protected RMS.BUSSINES.MASTER.RMS_USER bUser = new RMS.BUSSINES.MASTER.RMS_USER();
        protected RMS.COMMON.MASTER.RMS_TENTANGPERUSAHAAN cPersusahaan = new RMS.COMMON.MASTER.RMS_TENTANGPERUSAHAAN();
        protected RMS.BUSSINES.MASTER.RMS_TENTANGPERUSAHAAN bPersusahaan = new RMS.BUSSINES.MASTER.RMS_TENTANGPERUSAHAAN();
        string kodePerusahaan, namaPerusahaan, alamatPerusahaan, telpPerusahaan, faxPerusahaan;

        DataTable dataPrint;

        public FormDAFTARPENGIRIMANBARANG()
        {
            InitializeComponent();
            //cUser = obj;
            SETTING_MANUAL();
            INIT_PERUSAHAAN();
           // loadCOMBO();
            myToolTip();
            //LOAD_DATA();
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
            dataPrint.Columns.Add("TGLPENGIRIMAN", typeof(string));
            dataPrint.Columns.Add("NOSPJ", typeof(string));
            dataPrint.Columns.Add("NOPOL", typeof(string));
            dataPrint.Columns.Add("JENISKENDARAAN", typeof(string));
            dataPrint.Columns.Add("NAMADRIVER", typeof(string));
            dataPrint.Columns.Add("NAMAHELPER", typeof(string));
            dataPrint.Columns.Add("JUMLAHRESI", typeof(string));
            dataPrint.Columns.Add("NAMAPERUSAHAAN", typeof(string));
            dataPrint.Columns.Add("ALAMATPERUSAHAAN", typeof(string));
            dataPrint.Columns.Add("TELPPERUSAHAAN", typeof(string));
            dataPrint.Columns.Add("FAXPERUSAHAAN", typeof(string));


        }
        public void LOAD_DATA()
        {


            //c.STATUSORDER = cboSTATUS.Text.ToString(); sudah di inisialisasi di cbo text changed index
            c.STARTDATE = dtStart.Value.ToString("yyyy-MM-dd");
            c.ENDDATE = dtEnd.Value.ToString("yyyy-MM-dd");

            dgvPENGIRIMAN.DataSource = null;
            dgvPENGIRIMAN.Rows.Clear();
            DataTable dt;
            SET_PRINT();
            if (string.IsNullOrEmpty(txtCARI.Text))
            {
                dt = b.SELECT(c);
            }
            else
            {
                c.NOPOLISI = txtCARI.Text;
                c.NOSPJ = txtCARI.Text;
                dt = b.SELECTFILTERSPJ(c);
            }

            int TBERAT = 0;
            int TOTALCHARGE = 0;
            int TCHARGE = 0;
            int TOTHER = 0;
            if (dt.Rows.Count > 0)
            {
                 int no_urut = 1;
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                   

                    string ID = dt.Rows[i]["ID"].ToString();
                    string TGLPENGIRIMAN = DateTime.Parse(dt.Rows[i]["TGLPENGIRIMAN"].ToString()).ToString("dd-MM-yyyy");
                    string NOSPJ = dt.Rows[i]["NOSPJ"].ToString();
                    string NOPOL = dt.Rows[i]["NOPOL"].ToString();
                    string JENISKENDARAAN = dt.Rows[i]["JENISKENDARAAN"].ToString();
                    string NAMADRIVER = dt.Rows[i]["NAMADRIVER"].ToString();
                    string NAMAHELPER = dt.Rows[i]["NAMAHELPER"].ToString();

                    dgvPENGIRIMAN.Rows.Add(ID, TGLPENGIRIMAN, NOSPJ, NOPOL, JENISKENDARAAN, NAMADRIVER, NAMAHELPER);
                    dataPrint.Rows.Add(NOPOL, c.STARTDATE, c.ENDDATE, TGLPENGIRIMAN, NOSPJ, NOPOL, JENISKENDARAAN, NAMADRIVER, NAMAHELPER,"jmlrsi", namaPerusahaan, alamatPerusahaan, telpPerusahaan, faxPerusahaan);
                    //TBERAT += int.Parse(BERAT);
                    //TCHARGE += int.Parse(dt.Rows[i]["CHARGE_KIRIM"].ToString());
                    //TOTHER += int.Parse(dt.Rows[i]["TOTHER"].ToString());
                    //TOTALCHARGE += int.Parse(dt.Rows[i]["TOTAL"].ToString());
                    /*                  
                    TCOLLY += int.Parse(dt.Rows[i]["COLLIE"].ToString());
                    TBERAT += int.Parse(BERAT);
                    TFEE += int.Parse(dt.Rows[i]["FEEMKT"].ToString());
                    TRC += int.Parse(dt.Rows[i]["REFUND"].ToString());                
                    txtCOLLY.Text = TCOLLY.ToString();
                    txtFEE.Text = TFEE.ToString("N0");
                    txtRC.Text = TRC.ToString("N0");
                    dataPrint.Rows.Add(no_urut, c.STARTDATE, c.ENDDATE, DATE, TPAYMENT, STT, CUSTOMER, PENERIMA, MARKETING, FEEMKRT, RC, DEST, SERVICE, ARMADA, COLLY, BERAT, RATE, CHARGE, OTHER, TOTAL, STATUS, "", "", "");
                    no_urut++;
                    
                    txtTBERAT.Text = TBERAT.ToString();
                    txtCHARGE.Text = TCHARGE.ToString("N0");
                    txtOTHER.Text = TOTHER.ToString("N0");
                    txtTOTALCHARGE.Text = TOTALCHARGE.ToString("N0");
                     */ 
                     no_urut = no_urut + 1;
                }

            }

        }
        void SETTING_MANUAL()
        {
            this.Size = new Size(1365, 608);

        }
        private void myToolTip()
        {
            ToolTip myToolTip = new ToolTip();
            myToolTip.SetToolTip(txtCARI, "Cari Berdasarkan Salah Satu data : Marketing, Customer, Status bayar, DEST");

        }
        public void loadCOMBO()
        {
            /*
            this.setCOMBO();

            DataRow drSTATUS = ((DataRowView)cboSTATUS.SelectedItem).Row;


            c.STATUS = int.Parse(drSTATUS["ID"].ToString());
            c.STATUSORDER = drSTATUS["STATUS"].ToString();
             */ 


        }
        public void setCOMBO()
        {
            /*
            DataTable dtSTATUSORDER = new DataTable();
            dtSTATUSORDER = comboQuery.SELECTSTATUSORDER();

            cboSTATUS.DataSource = dtSTATUSORDER;
            cboSTATUS.ValueMember = dtSTATUSORDER.Columns[0].ColumnName;
            cboSTATUS.DisplayMember = dtSTATUSORDER.Columns[1].ColumnName;
             */ 



        }
        private void btnTAMBAH_Click(object sender, EventArgs e)
        {

            TAMBAH();
        }
        void TAMBAH()
        {
            EXPRESS.FormENTRYPENGIRIMANBARANG frm = new EXPRESS.FormENTRYPENGIRIMANBARANG(this, 0, c, cUser);
            frm.ShowDialog();
        }
        void BONGKARMUAT()
        {

            if (dgvPENGIRIMAN.SelectedCells.Count > 0)
            {
                int ID = int.Parse(dgvPENGIRIMAN.SelectedCells[0].OwningRow.Cells["ID"].Value.ToString());
                c.ID = ID;
                EXPRESS.FormENTRYPENGIRIMANBARANG frm = new LOGISTICMANAGAMENTSYSTEM.EXPRESS.FormENTRYPENGIRIMANBARANG(this, 1, c, cUser);
                frm.ShowDialog();
            }

        }

        void CETAK()
        {

            REPORTS.EXPRESS.FormViewerSPJ frm = new REPORTS.EXPRESS.FormViewerSPJ(dataPrint);
            frm.ShowDialog();
        }
        private void btnBONGKARMUAT_Click(object sender, EventArgs e)
        {
            //BONGKARMUAT();
            TAMBAH();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //txtTBERAT.Text = "0";
            //txtTOTALCHARGE.Text = "0";
            LOAD_DATA();
        }

        private void btnBATALMUAT_Click(object sender, EventArgs e)
        {
            BONGKARMUAT();

        }

        private void btnCetak_Click(object sender, EventArgs e)
        {
            CETAK();
        }

        private void btnKELUAR_Click(object sender, EventArgs e)
        {
            Close();
        }

        

       
      
    }
}

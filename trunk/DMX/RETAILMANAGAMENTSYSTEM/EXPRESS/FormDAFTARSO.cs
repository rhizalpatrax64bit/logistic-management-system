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
    public partial class FormDAFTARSO : Form
    {
        protected RMS.BUSSINES.EXPRESS.RMS_TRANSAKSI b = new RMS.BUSSINES.EXPRESS.RMS_TRANSAKSI();
        protected RMS.COMMON.EXPRESS.RMS_TRANSAKSI c = new RMS.COMMON.EXPRESS.RMS_TRANSAKSI();
        protected RMS.COMMON.GENERAL.RMS_COMBO combo = new RMS.COMMON.GENERAL.RMS_COMBO();
        protected RMS.BUSSINES.GENERAL.RMS_COMBO comboQuery = new RMS.BUSSINES.GENERAL.RMS_COMBO();
        protected RMS.COMMON.MASTER.RMS_USER cUser = new RMS.COMMON.MASTER.RMS_USER();
        protected RMS.BUSSINES.MASTER.RMS_USER bUser = new RMS.BUSSINES.MASTER.RMS_USER();
        protected RMS.COMMON.MASTER.RMS_TENTANGPERUSAHAAN cPersusahaan = new RMS.COMMON.MASTER.RMS_TENTANGPERUSAHAAN();
        protected RMS.BUSSINES.MASTER.RMS_TENTANGPERUSAHAAN bPersusahaan = new RMS.BUSSINES.MASTER.RMS_TENTANGPERUSAHAAN();
        string kodePerusahaan, namaPerusahaan, alamatPerusahaan, telpPerusahaan, faxPerusahaan;
        
        DataTable dataPrint;
        
        public FormDAFTARSO(RMS.COMMON.MASTER.RMS_USER obj)
        {
            InitializeComponent();
            cUser = obj;
            SETTING_MANUAL();
            loadCOMBO();
            INIT_PERUSAHAAN();
            
            myToolTip();
            LOAD_DATA();
            //LOAD_DATAUSER();
            
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
            dataPrint.Columns.Add("TGLTERIMA", typeof(string));
            dataPrint.Columns.Add("CUSTOMER", typeof(string));
            dataPrint.Columns.Add("ASAL", typeof(string));
            dataPrint.Columns.Add("TUJUAN", typeof(string));
            dataPrint.Columns.Add("PENERIMA", typeof(string));
            dataPrint.Columns.Add("SERVICE", typeof(string));
            dataPrint.Columns.Add("JENISKIRIMAN", typeof(string));
            dataPrint.Columns.Add("JUMLAH", typeof(string));
            dataPrint.Columns.Add("BERAT", typeof(string));
            dataPrint.Columns.Add("CHARGE", typeof(string));
            dataPrint.Columns.Add("OTHERCHARGE", typeof(string));
            dataPrint.Columns.Add("DISKON", typeof(string));
            dataPrint.Columns.Add("TOTAL", typeof(string));
            dataPrint.Columns.Add("STATUS", typeof(string));
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

            dgvSO.DataSource = null;
            dgvSO.Rows.Clear();
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
                    string TGLTERIMA = DateTime.Parse(dt.Rows[i]["TGLTERIMA"].ToString()).ToString("dd-MM-yyyy");
                    string CUSTOMER = dt.Rows[i]["NAMACUSTOMER"].ToString();
                    string ASAL = dt.Rows[i]["KOTAASAL"].ToString();
                    string TUJUAN = dt.Rows[i]["KOTATUJUAN"].ToString();
                    string PENERIMA = dt.Rows[i]["NAMAPENERIMA"].ToString();
                    string SERVICE = dt.Rows[i]["PRODUK"].ToString();
                    string JENISKIRIMAN = dt.Rows[i]["JENISKIRIMAN"].ToString();
                    string JUMLAH = dt.Rows[i]["JUMLAH"].ToString();                                 
                    string BERAT = dt.Rows[i]["BERAT"].ToString();                                                      
                    string CHARGE = int.Parse(dt.Rows[i]["CHARGE_KIRIM"].ToString()).ToString("N0");
                    string OTHER = int.Parse(dt.Rows[i]["TOTHER"].ToString()).ToString("N0");
                    string DISKON = int.Parse(dt.Rows[i]["DISKON"].ToString()).ToString("N0");
                    string TOTAL = int.Parse(dt.Rows[i]["TOTAL"].ToString()).ToString("N0");
                    string STATUSORDER = dt.Rows[i]["STATUS"].ToString();
                    dgvSO.Rows.Add(ID, TGLTERIMA, CUSTOMER, ASAL, TUJUAN, PENERIMA, SERVICE, JENISKIRIMAN, JUMLAH, BERAT, CHARGE, OTHER, DISKON,TOTAL, STATUSORDER);
                    dataPrint.Rows.Add(no_urut, c.STARTDATE, c.ENDDATE, TGLTERIMA, CUSTOMER, ASAL, TUJUAN, PENERIMA, SERVICE, JENISKIRIMAN, JUMLAH, BERAT, CHARGE, OTHER, DISKON, TOTAL, STATUSORDER, namaPerusahaan, alamatPerusahaan, telpPerusahaan, faxPerusahaan);
                    TBERAT += int.Parse(BERAT);
                    TCHARGE += int.Parse(dt.Rows[i]["CHARGE_KIRIM"].ToString());
                    TOTHER += int.Parse(dt.Rows[i]["TOTHER"].ToString());
                    TOTALCHARGE += int.Parse(dt.Rows[i]["TOTAL"].ToString());
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
                    */
                    txtTBERAT.Text = TBERAT.ToString();
                    txtCHARGE.Text = TCHARGE.ToString("N0");
                    txtOTHER.Text = TOTHER.ToString("N0");
                    txtTOTALCHARGE.Text = TOTALCHARGE.ToString("N0");
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
            this.setCOMBO();

            DataRow drSTATUS = ((DataRowView)cboSTATUS.SelectedItem).Row;


            c.STATUS = int.Parse(drSTATUS["ID"].ToString());
            c.STATUSORDER = drSTATUS["STATUS"].ToString();
            

        }
        public void setCOMBO()
        {

            DataTable dtSTATUSORDER = new DataTable();
            dtSTATUSORDER = comboQuery.SELECTSTATUSORDER();

            cboSTATUS.DataSource = dtSTATUSORDER;
            cboSTATUS.ValueMember = dtSTATUSORDER.Columns[0].ColumnName;
            cboSTATUS.DisplayMember = dtSTATUSORDER.Columns[2].ColumnName;



        }
        private void btnTAMBAH_Click(object sender, EventArgs e)
        {
            TAMBAH();
        }
        private void btnEDIT_Click(object sender, EventArgs e)
        {
            EDIT();
        }
        void TAMBAH()
        {
            EXPRESS.FormENTRYSO frm = new EXPRESS.FormENTRYSO(this, 0, c, cUser);            
            frm.ShowDialog();
           
        }
        void EDIT()
        {
            if (dgvSO.SelectedCells.Count > 0)
            {
                int ID = int.Parse(dgvSO.SelectedCells[0].OwningRow.Cells["ID"].Value.ToString());
                c.ID = ID;
                EXPRESS.FormENTRYSO frm = new LOGISTICMANAGAMENTSYSTEM.EXPRESS.FormENTRYSO(this, 1, c, cUser);
                frm.ShowDialog();
            }
        }

        private void cboSTATUS_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!cboSTATUS.Focused)
            {
                return;
            }
            else
            {
                DataRow selectedDataRow = ((DataRowView)cboSTATUS.SelectedItem).Row;
                c.STATUS = Convert.ToInt32(cboSTATUS.SelectedValue);
                c.STATUSORDER = cboSTATUS.Text;
            }
        }
        void CETAK()
        {

            REPORTS.EXPRESS.FormViewerCARGO frm = new REPORTS.EXPRESS.FormViewerCARGO(dataPrint);
            frm.ShowDialog();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            txtTBERAT.Text = "0";
            txtTOTALCHARGE.Text = "0";
            LOAD_DATA();
        }
      
        private void btnCetak_Click(object sender, EventArgs e)
        {
            CETAK();
        }

        private void FormDAFTARSO_KeyUp(object sender, KeyEventArgs e)
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
                //DELETE();
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

        private void btnHAPUS_Click(object sender, EventArgs e)
        {

        }

       
    }
}

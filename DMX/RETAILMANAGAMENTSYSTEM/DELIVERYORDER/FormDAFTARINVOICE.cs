using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using System.Collections.ObjectModel;

namespace LOGISTICMANAGAMENTSYSTEM.DELIVERYORDER
{
    public partial class FormDAFTARINVOICE : Form
    {
        protected RMS.BUSSINES.DELIVERYORDER.RMS_INVOICE b = new RMS.BUSSINES.DELIVERYORDER.RMS_INVOICE();
        protected RMS.COMMON.DELIVERYORDER.RMS_INVOICE c = new RMS.COMMON.DELIVERYORDER.RMS_INVOICE();
        protected RMS.BUSSINES.DELIVERYORDER.RMS_DETAILINVOICE bb = new RMS.BUSSINES.DELIVERYORDER.RMS_DETAILINVOICE();
        protected RMS.COMMON.DELIVERYORDER.RMS_DETAILINVOICE cc = new RMS.COMMON.DELIVERYORDER.RMS_DETAILINVOICE();

        protected RMS.BUSSINES.MASTER.RMS_TENTANGPERUSAHAAN bPersusahaan = new RMS.BUSSINES.MASTER.RMS_TENTANGPERUSAHAAN();
        protected RMS.COMMON.MASTER.RMS_TENTANGPERUSAHAAN cPersusahaan = new RMS.COMMON.MASTER.RMS_TENTANGPERUSAHAAN();
        string startDATE, endDATE = "";
        string startDATEINV, endDATEINV = ""; // dibikin dua karena dt crystal report hanya baca format dd-mm-yy
        int IDINVOICE = 0;
        DataTable dtPRINT;
        string kodePerusahaan, namaPerusahaan, alamatPerusahaan, telpPerusahaan, faxPerusahaan, cabang1, cabang2, norek1, norek2, atasnama1, atasnama2;
       
        public FormDAFTARINVOICE()
        {
            InitializeComponent();
            lblMESSAGE.Text = "SILAHKAN LAKUKAN PENCARIAN PERIODE DAN NAMA CUSTOMER YANG AKAN DIBUATKAN INVOICE";
            SETTING_MANUAL();
            progressBar1.Hide();
            INIT_PERUSAHAAN();
            
        }
        void INIT_PERUSAHAAN()
        {
            DataTable dt = bPersusahaan.SELECT();
            kodePerusahaan = dt.Rows[0][0].ToString();
            namaPerusahaan = dt.Rows[0][1].ToString();
            alamatPerusahaan = dt.Rows[0][6].ToString();
            telpPerusahaan = dt.Rows[0][7].ToString();
            faxPerusahaan = dt.Rows[0][8].ToString();
            cabang1 = dt.Rows[0][9].ToString();
            cabang2  = dt.Rows[0][10].ToString();
            norek1 = dt.Rows[0][11].ToString();
            norek2 = dt.Rows[0][12].ToString();
            atasnama1 = dt.Rows[0][13].ToString();
            atasnama2 = dt.Rows[0][14].ToString();
        }

        void SETTING_MANUAL()
        {
            this.Size = new Size(1365, 608);

        }
        public void GET_DATA_CUSTOMER(RMS.COMMON.MASTER.RMS_CUSTOMER obj)
        {
            // STRING DATE TIDAK BOLEH KOSONG
            int _nourut;
            startDATE = dtINVOICEDATE.Value.ToString("yyyy-MM-dd");
            endDATE = dtEND.Value.ToString("yyyy-MM-dd");
            txtKODECUSTOMER.Text = obj.KODE;
            txtNAMACUSTOMER.Text = obj.NAMACUSTOMER;
            DataTable dt = b.SELECTNOINVOICE(startDATE,endDATE,txtKODECUSTOMER.Text.Trim());
            _nourut = int.Parse(dt.Rows[0][0].ToString());
            txtKODEINVOICE.Text = getNewInvoice(_nourut, txtKODECUSTOMER.Text);
            lblMESSAGE.Text = txtKODEINVOICE.Text; 
            lblMESSAGE.BackColor = Color.Blue;
            lblDETAILMSG.Text = "SILAHKAN TEKAN CARI UNTUK MENAMBAHKAN PACKING LIST PENGIRIMAN BARANG";
            lblDETAILMSG.BackColor = Color.Red;
        }
        public string getNewInvoice(int _urut,string kodecustomer)
        {
               
                string noinvoice;
                String now =  dtINVOICEDATE.Value.ToString("MM/yy");
                noinvoice  = kodecustomer + "/"+kodePerusahaan+"/"+_urut+"/" + now;
                return noinvoice; 
        }
       
        public void LOAD_DETAIL()
        {
            LOAD_STTINV();
            LOAD_PRINT();
            LOAD_INVCETAK();
           
        }
        public void LOAD_INVCETAK()
        {
            dgvCETAK.DataSource = null;
            dgvCETAK.Rows.Clear();

            DataTable dt;

            cc.STATUSSTT = "PAID";
            cc.NAMACUSTOMER = txtNAMACUSTOMER.Text;
            dt = bb.SELECTINVOICECETAK(cc);

            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    string INVOICE = dt.Rows[i]["KODEINVOICE"].ToString();
                    string TGLCONNOTE = DateTime.Parse(dt.Rows[i]["DATE"].ToString()).ToString("dd-MM-yyyy");
                    string NOCONNOTE = dt.Rows[i]["NOCONNOTE"].ToString();
                    string SERVICE = dt.Rows[i]["SERVICE"].ToString();
                    string ARMADA = dt.Rows[i]["HANDLING"].ToString();
                    string NAMACUSTOMER = dt.Rows[i]["CUSTOMER"].ToString();
                    string TYPEOFPAYMENT = dt.Rows[i]["TPAYMENT"].ToString();
                    string DESC = dt.Rows[i]["DEST"].ToString();
                    string CONSIGNEE = dt.Rows[i]["CONSIGNEE"].ToString();
                    string PCS = dt.Rows[i]["COLLIE"].ToString();
                    string WEIGHT = dt.Rows[i]["WEIGHT"].ToString();
                    string CHARGEKIRIM = dt.Rows[i]["CHARGE_KIRIM"].ToString();
                    string OTHERCHARGE = dt.Rows[i]["OTHERCHARGE"].ToString();

                    string TOTAL_CHARGE = dt.Rows[i]["TOTAL_CHARGE"].ToString();
                    dgvCETAK.Rows.Add(INVOICE,TGLCONNOTE, NOCONNOTE, SERVICE, ARMADA, NAMACUSTOMER, TYPEOFPAYMENT, DESC, CONSIGNEE, PCS, WEIGHT, CHARGEKIRIM, OTHERCHARGE, TOTAL_CHARGE);
                }
            }
        }
        public void LOAD_STTINV()
        {
            dgvSTTINV.DataSource = null;
            dgvSTTINV.Rows.Clear();         
          
            DataTable dt;                        
            cc.STATUSSTT = "INV";
            cc.NAMACUSTOMER = txtNAMACUSTOMER.Text;
            dt = bb.SELECTGENERATEINVOICE(cc);
            progressBar1.Show();
            progressBar1.Minimum = 0;
            progressBar1.Maximum = dt.Rows.Count;
            progressBar1.Value = 0;
            progressBar1.Step = 3;
            
           
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    bool isInvoice = true;
                   
                    string TGLCONNOTE = DateTime.Parse(dt.Rows[i]["DATE"].ToString()).ToString("dd-MM-yyyy");
                    string NOCONNOTE = dt.Rows[i]["NOCONNOTE"].ToString();
                    string SERVICE = dt.Rows[i]["SERVICE"].ToString();
                    string ARMADA = dt.Rows[i]["HANDLING"].ToString();
                    string NAMACUSTOMER = dt.Rows[i]["CUSTOMER"].ToString();
                    string TYPEOFPAYMENT = dt.Rows[i]["TPAYMENT"].ToString();
                    string DESC = dt.Rows[i]["DEST"].ToString();
                    string CONSIGNEE = dt.Rows[i]["CONSIGNEE"].ToString();
                    string PCS = dt.Rows[i]["COLLIE"].ToString();
                    string WEIGHT = dt.Rows[i]["WEIGHT"].ToString();
                    string CHARGEKIRIM = dt.Rows[i]["CHARGE_KIRIM"].ToString();
                    string OTHERCHARGE = dt.Rows[i]["OTHERCHARGE"].ToString();
                
                    string TOTAL_CHARGE = dt.Rows[i]["TOTAL_CHARGE"].ToString();
                    dgvSTTINV.Rows.Add(isInvoice, TGLCONNOTE, NOCONNOTE,SERVICE,ARMADA, NAMACUSTOMER, TYPEOFPAYMENT, DESC, CONSIGNEE, PCS, WEIGHT, CHARGEKIRIM, OTHERCHARGE, TOTAL_CHARGE);
                    
                    //progressBar1.Value = i;
                    progressBar1.PerformStep();
                }
                progressBar1.Hide();
                lblDETAILMSG.Text = "SILAHKAN TEKAN TOMBOL CETAK INVOICE UNTUK MENAMBAHKAN";
                lblDETAILMSG.BackColor = Color.Red;
            }
        }
        // PAID
        public void LOAD_PRINT()
        {
            string limitpiutang = string.Empty;
            string KETERANGAN = string.Empty;
           
            cc.STATUSSTT = "PAID";
            DataTable dt =

            dt = bb.SELECTINVOICE(cc);
            dtPRINT = new DataTable();
           // dtPRINT = null;
            dtPRINT.Columns.Add("NOINVOICE", typeof(string));
            dtPRINT.Columns.Add("NAMACUSTOMER", typeof(string));
            dtPRINT.Columns.Add("STARDATE", typeof(string));
            dtPRINT.Columns.Add("ENDDATE", typeof(string));
            dtPRINT.Columns.Add("NOURUT", typeof(string));
            dtPRINT.Columns.Add("DATESTT", typeof(string));
            dtPRINT.Columns.Add("CONNOTENO", typeof(string));
            dtPRINT.Columns.Add("DEST", typeof(string));
            dtPRINT.Columns.Add("CONSIGNEE", typeof(string));
            dtPRINT.Columns.Add("COLLIE", typeof(string));
            dtPRINT.Columns.Add("TYPE", typeof(string));
            dtPRINT.Columns.Add("WEIGHT", typeof(string));
            dtPRINT.Columns.Add("RATE", typeof(string));
            dtPRINT.Columns.Add("PPN", typeof(string));
            dtPRINT.Columns.Add("ASURANSI", typeof(float));
            dtPRINT.Columns.Add("PACKING", typeof(float));
            dtPRINT.Columns.Add("SERVICE", typeof(string));
            dtPRINT.Columns.Add("CHARGE", typeof(float));
            dtPRINT.Columns.Add("ARMADA", typeof(string));
            dtPRINT.Columns.Add("TERBILANG", typeof(string));
            dtPRINT.Columns.Add("KODE", typeof(string));
            dtPRINT.Columns.Add("ALAMAT", typeof(string));
            dtPRINT.Columns.Add("TELP", typeof(string));            
            dtPRINT.Columns.Add("FAX", typeof(string));
             dtPRINT.Columns.Add("CABANGBANK1", typeof(string));
            dtPRINT.Columns.Add("CABANGBANK2", typeof(string));
            dtPRINT.Columns.Add("NOREK1", typeof(string));
            dtPRINT.Columns.Add("NOREK2", typeof(string));
            dtPRINT.Columns.Add("ATASNAMA1", typeof(string));
            dtPRINT.Columns.Add("ATASNAMA2", typeof(string));
            dtPRINT.Columns.Add("NAMA", typeof(string));

            //dtPRINT = dt;
            if (dt.Rows.Count > 0)
            {
                int no_urut = 1;
                string typekirim;
                string WEIGHT;
                int _TOTAL_CHARGE =0;
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    
                    string NOINVOICE = (dt.Rows[i]["KODEINVOICE"]).ToString();
                    string NAMACUSTOMER = (dt.Rows[i]["CUSTOMER"]).ToString();
                    string TGLCONNOTE = DateTime.Parse(dt.Rows[i]["DATE"].ToString()).ToString("dd-MM-yyyy");
                    string NOCONNOTE = dt.Rows[i]["NOCONNOTE"].ToString();
                    string TYPEOFPAYMENT = dt.Rows[i]["TPAYMENT"].ToString();
                    string KODEDEST = dt.Rows[i]["DEST"].ToString();
                    string DESC = dt.Rows[i]["DEST"].ToString();
                    string TERUSAN = dt.Rows[i]["NAMATERUSAN"].ToString();
                    string CONSIGNEE = dt.Rows[i]["CONSIGNEE"].ToString();
                    string PCS = dt.Rows[i]["COLLIE"].ToString();
                    string RATE = dt.Rows[i]["RATE_KIRIM"].ToString();
                    string PPN = dt.Rows[i]["PPN"].ToString();
                    string INSURANCE = dt.Rows[i]["INSURANCE"].ToString();
                    string ARMADA = dt.Rows[i]["HANDLING"].ToString();
                     KETERANGAN = dt.Rows[i]["KETERANGAN"].ToString();
                  //  string PACKING = dt.Rows[i]["PACKING"].ToString();
                    string CHARGE = dt.Rows[i]["TOTAL_CHARGE"].ToString();
                    if (int.Parse(dt.Rows[i]["WEIGHT"].ToString()) != 0)
                    {
                        WEIGHT = dt.Rows[i]["WEIGHT"].ToString();
                        typekirim = "PKG";
                        
                    }
                    else
                    {
                        typekirim = "DIM";
                        WEIGHT = dt.Rows[i]["WEIGHTDIM"].ToString();
                    }
                    string CHARGEKIRIM = dt.Rows[i]["CHARGE_KIRIM"].ToString();
                    string PACKING = dt.Rows[i]["PACKING"].ToString();
                    string SERVICE = dt.Rows[i]["SERVICE"].ToString();
                    string TOTAL_CHARGE = dt.Rows[i]["TOTAL_CHARGE"].ToString();
                    _TOTAL_CHARGE += int.Parse(TOTAL_CHARGE);
                    string TERBILANG = Terbilang(_TOTAL_CHARGE);
                    dtPRINT.Rows.Add(NOINVOICE, NAMACUSTOMER, KETERANGAN, TERUSAN, (no_urut++).ToString(), TGLCONNOTE, NOCONNOTE, KODEDEST, CONSIGNEE, PCS, typekirim, WEIGHT, RATE, PPN, INSURANCE, PACKING, SERVICE, TOTAL_CHARGE, ARMADA, TERBILANG,kodePerusahaan,alamatPerusahaan,telpPerusahaan,faxPerusahaan,cabang1,cabang2,norek1,norek2,atasnama1,atasnama2,namaPerusahaan);
                  
                }
            }
        }
       
        private void txtKODECUSTOMER_TextChanged(object sender, EventArgs e)
        {
            //getNewInvoice();
        }

        private void btnNewInvoice_Click(object sender, EventArgs e)
        {
   
           
        }
       
        private void Reset_Click(object sender, EventArgs e)
        {
            CLEAR();

        }

        private void btnTAMBAH_Click(object sender, EventArgs e)
        {
           
           
        }
        void CLEAR()
        {
            txtKODEINVOICE.Text = "";
            txtKODECUSTOMER.Text = "";
            txtNAMACUSTOMER.Text = "";
            lblMESSAGE.Text = "";
            lblDETAILMSG.Text = "";
            txtKET.Text = "";
        }             

        private void dgvSTTINV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewCheckBoxCell ch1 = new DataGridViewCheckBoxCell();
            ch1 = (DataGridViewCheckBoxCell)dgvSTTINV.Rows[dgvSTTINV.CurrentRow.Index].Cells[0];

            if (ch1.Value == null)
                ch1.Value = false;
            switch (ch1.Value.ToString())
            {
                case "True":
                    ch1.Value = false;
                    break;
                case "False":
                    ch1.Value = true;
                    break;
            }
            MessageBox.Show("ANDA YAKIN UNTUK TIDAK GENERATE INVOICE NO STT INI", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Stop);
           
        }

        private void txtKODECUSTOMER_KeyUp(object sender, KeyEventArgs e)
        {            
            
            if (e.KeyCode == Keys.Enter)
            {
                if (!string.IsNullOrEmpty(txtKODECUSTOMER.Text)) return;
                if (string.IsNullOrEmpty(dtINVOICEDATE.Value.ToString("yyyy-MM-dd").ToString()))
                {
                    MessageBox.Show("SILAHKAN PILIH TANGGAL", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }
                else
                {
                    VIEW.FormVIEWCUSTOMER frm = new LOGISTICMANAGAMENTSYSTEM.VIEW.FormVIEWCUSTOMER(null, this, 2);
                    frm.ShowDialog();
                }
            }
            if (e.KeyCode == Keys.Back)
            {
                CLEAR();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            startDATE = dtINVOICEDATE.Value.ToString("dd-MM-yyyy");
            endDATE = dtEND.Value.ToString("dd-MM-yyyy");
            LOAD_DETAIL();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCetak_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtKODEINVOICE.Text))
            {
                MessageBox.Show("KODE INVOICE KOSONG", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtKODEINVOICE.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txtKODECUSTOMER.Text))
            {
                MessageBox.Show("KODE CUSTOMER KOSONG", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtKODECUSTOMER.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txtNAMACUSTOMER.Text))
            {
                MessageBox.Show("NAMA CUSTOMER KOSONG", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtNAMACUSTOMER.Focus();
                return;
            }

            if (dgvSTTINV.SelectedCells.Count > 0)
            {
                if (string.IsNullOrEmpty(txtKET.Text))
                {
                    MessageBox.Show("MOHON ISI KETERANGAN", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    txtKET.Focus();
                    return;
                }

                c.TGLINVOICE = dtINVOICEDATE.Value.ToString("yyyy-MM-dd");
                c.KODEINVOICE = txtKODEINVOICE.Text;
                c.KODECUSTOMER = txtKODECUSTOMER.Text;
                c.KETERANGAN = txtKET.Text;

                DataTable dt = b.SEARCH_NOINVOICE(txtKODEINVOICE.Text);
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("NO INVOICE TELAH DIBUAT, SILAHKAN CETAK INVOICE", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Stop);

                    return;
                }
                b.INSERT(c);
                DataTable dtUPDATE = b.SEARCH_NOINVOICE(txtKODEINVOICE.Text);
                if (dtUPDATE.Rows.Count > 0)
                {
                    for (int i = 0; i < dtUPDATE.Rows.Count; i++)
                    {
                        IDINVOICE = int.Parse(dtUPDATE.Rows[i]["ID"].ToString());
                    }
                }
                for (int count = 0; count < dgvSTTINV.Rows.Count; count++)
                {
                    string check = dgvSTTINV.Rows[count].Cells[0].Value.ToString();
                    if (check == "True")
                    {
                        string noconnote = dgvSTTINV.Rows[count].Cells[2].Value.ToString();
                        bb.UPDATESETINVOICE(IDINVOICE, noconnote);
                    }
                }
                cc.KODEIVOICE = txtKODEINVOICE.Text;
                LOAD_DETAIL();


                CrystalDecisions.CrystalReports.Engine.ReportDocument cryRpt = new CrystalDecisions.CrystalReports.Engine.ReportDocument();

                REPORTS.INVOICE.FormINVOICE frm = new REPORTS.INVOICE.FormINVOICE(dtPRINT);

                frm.ShowDialog();
                // print
                lblMESSAGE.Text = "SILAHKAN LAKUKAN PENCARIAN PERIODE DAN NAMA CUSTOMER YANG AKAN DIBUATKAN INVOICE";
                CLEAR();
            }
            else
            {
                MessageBox.Show("TIDAK ADA STT YANG AKANG DI CETAK INVOICE", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                btnCARI.Focus();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            startDATE = dtINVOICEDATE.Value.ToString("yyyy-MM-dd");
            endDATE = dtEND.Value.ToString("yyyy-MM-dd");
            startDATEINV = dtINVOICEDATE.Value.ToString("dd-MM-yyyy");
            endDATEINV = dtEND.Value.ToString("dd-MM-yyyy");
            cc.STARTDATE = startDATE;
            cc.ENDDATE = endDATE;
            cc._KODECUSTOMER = txtKODECUSTOMER.Text;
            LOAD_INVCETAK();
            LOAD_DETAIL();
         
        }

        private void btnCARI_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtKODECUSTOMER.Text)) return;
            if (string.IsNullOrEmpty(dtINVOICEDATE.Value.ToString("yyyy-MM-dd").ToString()))
            {
                MessageBox.Show("SILAHKAN PILIH TANGGAL", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            else
            {
                VIEW.FormVIEWCUSTOMER frm = new LOGISTICMANAGAMENTSYSTEM.VIEW.FormVIEWCUSTOMER(null, this, 2);
                frm.ShowDialog();
            }
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

        private void btnKELUAR_Click(object sender, EventArgs e)
        {
            Close();
        }

     

        private void FormDAFTARINVOICE_Load(object sender, EventArgs e)
        {
           
        }
       
     
    }
}

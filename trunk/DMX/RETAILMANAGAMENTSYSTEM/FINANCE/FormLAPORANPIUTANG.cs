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
    public partial class FormLAPORANPIUTANG : Form
    {
        protected RMS.BUSSINES.LAPORAN.RMS_LAPORANPIUTANG b = new RMS.BUSSINES.LAPORAN.RMS_LAPORANPIUTANG();
        protected RMS.COMMON.LAPORAN.RMS_LAPORANPIUTANG c = new RMS.COMMON.LAPORAN.RMS_LAPORANPIUTANG();
        DataTable dtPIUTANG = new DataTable();
        string TGLMULAI,TGLAHIR = string.Empty;
        protected RMS.BUSSINES.MASTER.RMS_TENTANGPERUSAHAAN bPersusahaan = new RMS.BUSSINES.MASTER.RMS_TENTANGPERUSAHAAN();
        protected RMS.COMMON.MASTER.RMS_TENTANGPERUSAHAAN cPersusahaan = new RMS.COMMON.MASTER.RMS_TENTANGPERUSAHAAN();
        string kodePerusahaan, namaPerusahaan, alamatPerusahaan, telpPerusahaan, faxPerusahaan;
        public FormLAPORANPIUTANG()
        {
            InitializeComponent();
            INIT_PERUSAHAAN();
            cboSTATUS.Text = "SEMUA";
            TGLMULAI = dtBEGIN.Value.ToString("yyyy-MM-dd");
            TGLAHIR = dtEND.Value.ToString("yyyy-MM-dd");
            dtPIUTANG.Columns.Add("NO", typeof(string));
            dtPIUTANG.Columns.Add("TGLINV", typeof(string));
            dtPIUTANG.Columns.Add("NOINV", typeof(string));
            dtPIUTANG.Columns.Add("TGLKONTRABON", typeof(string));
            dtPIUTANG.Columns.Add("KONTRABON", typeof(string));
            dtPIUTANG.Columns.Add("CUSTOMER", typeof(string));
            dtPIUTANG.Columns.Add("MARKETING", typeof(string));
            dtPIUTANG.Columns.Add("JUMLAHINV", typeof(string));
            dtPIUTANG.Columns.Add("TOTALINV", typeof(string));
            dtPIUTANG.Columns.Add("JATUHTEMPO", typeof(string));
            dtPIUTANG.Columns.Add("TGLBAYAR", typeof(string));
            dtPIUTANG.Columns.Add("JUMLAHBAYAR", typeof(string));
            dtPIUTANG.Columns.Add("TOTALBAYAR", typeof(string));
            dtPIUTANG.Columns.Add("METODEBAYAR", typeof(string));
            dtPIUTANG.Columns.Add("SISAPIUTANG", typeof(string));
            dtPIUTANG.Columns.Add("TGLMULAI", typeof(string));
            dtPIUTANG.Columns.Add("TGLAHIR", typeof(string));
            dtPIUTANG.Columns.Add("STATUS", typeof(string));
            dtPIUTANG.Columns.Add("NAMAPERUSAHAAN", typeof(string));
            dtPIUTANG.Columns.Add("ALAMATPERUSAHAAN", typeof(string));
            dtPIUTANG.Columns.Add("TELPPERUSAHAAN", typeof(string));
            dtPIUTANG.Columns.Add("FAXPERUSAHAAN", typeof(string));
            
            LOAD_PIUTANG();
            
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
        void LOAD_PIUTANG()
        {
            c.STARTDATE = TGLMULAI;
            c.ENDDATE = TGLAHIR;
            string limitpiutang = string.Empty;
            string KETERANGAN = string.Empty;
            dtPIUTANG.Clear();
                     
            DataTable dt =
            dt = b.SELECT(c);

            if (dt.Rows.Count > 0)
            {
                string NOSTT = "";
                string TGLKONTRABON = "";
                string KONTRABON = "";
                string INVOICESTT = "";
                string CUSTOMER = "";
                string MARKETING = "";
                string JUMLAHINV = "";
                string TGLINVOICE = "";
                string TOTALINV = "";
                string JATUHTEMPO = "";
                string TGLBAYAR = "";
                string JUMLAHBAYAR = "";
                string TOTALBAYAR = "";
                string METODEBAYAR = "";
                string SISAPIUTANG = "";

                int no_urut = 0;

                for (int i = 0; i < dt.Rows.Count; i++)
                {

                    // ini jika pembayaran lebih dari satu
                    TGLKONTRABON = "";

                    KONTRABON = "";
                    TGLINVOICE = DateTime.Parse(dt.Rows[i]["TGLINVOICESTT"].ToString()).ToString("dd.MM.yy");
                    INVOICESTT = dt.Rows[i]["INVOICESTT"].ToString();
                    CUSTOMER = dt.Rows[i]["CUSTOMER"].ToString();
                    MARKETING = dt.Rows[i]["MARKETING"].ToString();
                    JUMLAHINV = dt.Rows[i]["TOTALCHARGE"].ToString();
                    JATUHTEMPO = "";
                    if (dt.Rows[i]["JUMLAHBAYAR"].ToString() != "0")
                    {
                        TGLBAYAR = DateTime.Parse(dt.Rows[i]["TGLBAYAR"].ToString()).ToString("dd.MM.yy"); ;
                    }
                    else
                    {
                        TGLBAYAR = "";
                    }
                    JUMLAHBAYAR = dt.Rows[i]["JUMLAHBAYAR"].ToString();
                    TOTALBAYAR = "";
                    METODEBAYAR = dt.Rows[i]["METODEBAYAR"].ToString();
                    SISAPIUTANG = "";
                    dtPIUTANG.Rows.Add(no_urut, TGLINVOICE, INVOICESTT, TGLKONTRABON, KONTRABON, CUSTOMER, MARKETING, JUMLAHINV, TOTALINV, JATUHTEMPO, TGLBAYAR, JUMLAHBAYAR, TOTALBAYAR, METODEBAYAR, SISAPIUTANG, TGLMULAI, TGLAHIR, "", namaPerusahaan, alamatPerusahaan, telpPerusahaan, faxPerusahaan);



                }
                lblMESSAGE.Text = "Data Tersedia, Silahkan tekan cetak";
            }
            else
            {
                lblMESSAGE.Text = "Maaf tidak ada data";
            }
        }
        void CETAK()
        {
            CrystalDecisions.CrystalReports.Engine.ReportDocument cryRpt = new CrystalDecisions.CrystalReports.Engine.ReportDocument();
            REPORTS.PIUTANG.FormLAPORANPIUTANG frm = new REPORTS.PIUTANG.FormLAPORANPIUTANG(dtPIUTANG);
            frm.ShowDialog();
        }
        private void btnCARI_Click(object sender, EventArgs e)
        {
            TGLMULAI = dtBEGIN.Value.ToString("yyyy-MM-dd");
            TGLAHIR = dtEND.Value.ToString("yyyy-MM-dd");
            LOAD_PIUTANG();
            
            
        }

        private void btnCetak_Click(object sender, EventArgs e)
        {
            CETAK();
        }
        
    }
}

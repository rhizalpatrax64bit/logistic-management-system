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
    public partial class FormDAFTARPEMBAYARANHUTANG : Form
    {
        protected RMS.BUSSINES.DELIVERYORDER.RMS_TAGIHAN b = new RMS.BUSSINES.DELIVERYORDER.RMS_TAGIHAN();
        protected RMS.COMMON.DELIVERYORDER.RMS_TAGIHAN c = new RMS.COMMON.DELIVERYORDER.RMS_TAGIHAN();

        protected RMS.BUSSINES.DELIVERYORDER.RMS_PEMBAYARAN bPMB = new RMS.BUSSINES.DELIVERYORDER.RMS_PEMBAYARAN();
        protected RMS.COMMON.DELIVERYORDER.RMS_PEMBAYARAN cpMB = new RMS.COMMON.DELIVERYORDER.RMS_PEMBAYARAN();
        DataTable dataPrint;
        public FormDAFTARPEMBAYARANHUTANG()
        {
            InitializeComponent();
            cboSTATUS.Text = "BELUM LUNAS";
            SETTING_MANUAL();
            c.STATUS = "BELUM LUNAS";
            LOAD_DATA();
        }
        void SETTING_MANUAL()
        {
            this.Size = new Size(1365, 608);

        }
        void SET_PRINT()
        {
            dataPrint = new DataTable();
            dataPrint.Columns.Add("NO", typeof(string));
            dataPrint.Columns.Add("AGENT", typeof(string));
            dataPrint.Columns.Add("TGLDATANGINV", typeof(string));
            dataPrint.Columns.Add("TGLINV", typeof(string));
            dataPrint.Columns.Add("NOINV", typeof(string));
            dataPrint.Columns.Add("JUMLAHTAGIHAN", typeof(string));
            dataPrint.Columns.Add("JUMLAHBAYAR", typeof(string));
            dataPrint.Columns.Add("SISA", typeof(string));
            dataPrint.Columns.Add("TGLBAYAR", typeof(string));
            dataPrint.Columns.Add("KETERANGAN", typeof(string));
            dataPrint.Columns.Add("OPT1 ", typeof(string));
            dataPrint.Columns.Add("OPT2", typeof(string));
            dataPrint.Columns.Add("OPT3", typeof(string));
            dataPrint.Columns.Add("PERIODE", typeof(string));


        }
        public void LOAD_DATA()
        {
            string periode = string.Empty;
            c.STARTDATE = dtBEGIN.Value.ToString("yyyy-MM-dd");
            c.ENDDATE = dtEND.Value.ToString("yyyy-MM-dd");
            periode = c.STARTDATE +' '+ "s/d"+' '+ c.ENDDATE;
            dgvTAGIHAN.DataSource = null;
            dgvTAGIHAN.Rows.Clear();

            DataTable dt = b.SELECT();
            SET_PRINT();
            if (dt.Rows.Count > 0)
            {
                int no_urut = 1;
                for (int i = 0; i < dt.Rows.Count; i++)
                {

                    string ID = dt.Rows[i]["ID"].ToString();
                    string NAMAAGENT = dt.Rows[i]["NAMAAGENT"].ToString();
                    string HANDLING = dt.Rows[i]["HANDLING"].ToString();
                    string TGLDATANGINV = DateTime.Parse(dt.Rows[i]["TGLDATANGINV"].ToString()).ToString("dd-MM-yyyy");
                    string TGLINV = DateTime.Parse(dt.Rows[i]["TGLINV"].ToString()).ToString("dd-MM-yyyy");
                    string NOINV = dt.Rows[i]["NOINV"].ToString();
                    string JUMLAHTAGIHAN = dt.Rows[i]["JUMLAHTAGIHAN"].ToString();
                    string TGLBAYAR = string.Empty;
                    if(string.IsNullOrEmpty(dt.Rows[i]["TGLBAYAR"].ToString()))
                    {
                        TGLBAYAR = "000-00-00";
                    }
                    else { TGLBAYAR = DateTime.Parse(dt.Rows[i]["TGLBAYAR"].ToString()).ToString("dd-MM-yyyy"); }
                    
                    string TOTALBAYAR = dt.Rows[i]["TOTALBAYAR"].ToString();
                    string SISA = dt.Rows[i]["SISA"].ToString();
                    string KETERANGAN = dt.Rows[i]["KETERANGAN"].ToString();
                    
                    string STATUS;
                    string STATUSREPORT;
                    string PERIODE;
                   
                    if (dt.Rows[i]["SISA"].ToString() != "0")
                    {
                        STATUS = "BELUM LUNAS";
                        STATUSREPORT = "BELUM LUNAS";
                        PERIODE = periode;
                    }
                    else
                    {
                        STATUS = "LUNAS";
                        STATUSREPORT = "LUNAS";
                        PERIODE = periode;
                       
                    }
                    if (cboSTATUS.Text == "BELUM LUNAS")
                    {
                        if (STATUS == "BELUM LUNAS")
                        {
                            dgvTAGIHAN.Rows.Add(ID, NAMAAGENT, HANDLING,TGLDATANGINV, TGLINV, NOINV, JUMLAHTAGIHAN, TOTALBAYAR, SISA, "", STATUS, KETERANGAN);
                            dataPrint.Rows.Add(no_urut, NAMAAGENT, TGLDATANGINV, TGLINV, NOINV, JUMLAHTAGIHAN, TOTALBAYAR, SISA, TGLBAYAR, KETERANGAN, PERIODE, HANDLING, STATUSREPORT,PERIODE);

                        }
                    }
                    else if (cboSTATUS.Text == "LUNAS")
                    {
                        if (STATUS == "LUNAS")
                        {
                            dgvTAGIHAN.Rows.Add(ID, NAMAAGENT, HANDLING, TGLDATANGINV, TGLINV, NOINV, JUMLAHTAGIHAN, TOTALBAYAR, SISA, TGLBAYAR, STATUS, KETERANGAN);
                            dataPrint.Rows.Add(no_urut, NAMAAGENT, TGLDATANGINV, TGLINV, NOINV, JUMLAHTAGIHAN, TOTALBAYAR, SISA, TGLBAYAR, KETERANGAN, PERIODE, HANDLING, STATUSREPORT, PERIODE);
                        }
                    }
                    else
                    {
                        STATUSREPORT = "SEMUA TAGIHAN";
                        
                        PERIODE = periode;
                        dgvTAGIHAN.Rows.Add(ID, NAMAAGENT, HANDLING, TGLDATANGINV, TGLINV, NOINV, JUMLAHTAGIHAN, TOTALBAYAR, SISA, TGLBAYAR, STATUS, KETERANGAN);
                        HANDLING = "SEMUA AGENT";
                        dataPrint.Rows.Add(no_urut, NAMAAGENT, TGLDATANGINV, TGLINV, NOINV, JUMLAHTAGIHAN, TOTALBAYAR, SISA, TGLBAYAR, KETERANGAN, PERIODE, HANDLING, STATUSREPORT, PERIODE);
                    }
                    no_urut++;
                }
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            c.STATUS = cboSTATUS.Text;
            
            LOAD_DATA();
        }

        private void FormDAFTARPEMBAYARANHUTANG_Load(object sender, EventArgs e)
        {

        }

        private void btnTAGIHAN_Click(object sender, EventArgs e)
        {
            FINANCE.FormTAGIHAN frm = new LOGISTICMANAGAMENTSYSTEM.FINANCE.FormTAGIHAN(this, 0, null);
             frm.ShowDialog();
        }

        private void btnEDIT_Click(object sender, EventArgs e)
        {
            if (dgvTAGIHAN.SelectedCells.Count > 0)
            {
                int kode = int.Parse(dgvTAGIHAN.SelectedCells[0].OwningRow.Cells["ID"].Value.ToString());
                c.ID = kode;
                FINANCE.FormTAGIHAN frm = new LOGISTICMANAGAMENTSYSTEM.FINANCE.FormTAGIHAN(this, 1, c);
                frm.ShowDialog();
            }
        }
        void CETAK()
        {
            CrystalDecisions.CrystalReports.Engine.ReportDocument cryRpt = new CrystalDecisions.CrystalReports.Engine.ReportDocument();
            REPORTS.TAGIHAN.FormTAGIHAN frm = new REPORTS.TAGIHAN.FormTAGIHAN(cryRpt, dataPrint);
            frm.ShowDialog();
        }

        private void btnCetak_Click(object sender, EventArgs e)
        {
            CETAK();
        }

        private void btnPEMBAYARAN_Click(object sender, EventArgs e)
        {
            if(dgvTAGIHAN.SelectedCells.Count > 0)
            {
                int ID = int.Parse(dgvTAGIHAN.SelectedCells[0].OwningRow.Cells["ID"].Value.ToString());
                c.ID = ID;
                FINANCE.FormPEMBAYARANTAGIHAN frm = new LOGISTICMANAGAMENTSYSTEM.FINANCE.FormPEMBAYARANTAGIHAN(this, 0, c);
                frm.ShowDialog();
            }
        }

        private void btnKELUAR_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

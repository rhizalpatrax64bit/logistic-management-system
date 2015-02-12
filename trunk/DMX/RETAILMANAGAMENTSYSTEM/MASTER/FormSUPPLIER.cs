using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using System.Windows.Forms;

namespace LOGISTICMANAGAMENTSYSTEM.MASTER
{
    public partial class FormSUPPLIER : Form
    {
        protected RMS.BUSSINES.MASTER.RMS_SUPPLIER b = new RMS.BUSSINES.MASTER.RMS_SUPPLIER();
        protected RMS.COMMON.MASTER.RMS_SUPPLIER c = new RMS.COMMON.MASTER.RMS_SUPPLIER();

        protected RMS.BUSSINES.MASTER.RMS_TENTANGPERUSAHAAN bPersusahaan = new RMS.BUSSINES.MASTER.RMS_TENTANGPERUSAHAAN();
        protected RMS.COMMON.MASTER.RMS_TENTANGPERUSAHAAN cPersusahaan = new RMS.COMMON.MASTER.RMS_TENTANGPERUSAHAAN();
        string kodePerusahaan, namaPerusahaan, alamatPerusahaan, telpPerusahaan, faxPerusahaan;
        DataTable dataPrint;
        public FormSUPPLIER()
        {
            InitializeComponent();
            
            SETTING_MANUAL();
            INIT_PERUSAHAAN();
            LOAD_DATA();
           
           
        }
        void INIT_PERUSAHAAN()
        {
            DataTable dt = bPersusahaan.SELECT();
            if (dt.Rows.Count > 0)
            {
                kodePerusahaan = dt.Rows[0][0].ToString();
                namaPerusahaan = dt.Rows[0][1].ToString();
                alamatPerusahaan = dt.Rows[0][6].ToString();
                telpPerusahaan = dt.Rows[0][7].ToString();
                faxPerusahaan = dt.Rows[0][8].ToString();
            }
                        
        }
        void SETTING_MANUAL()
        {
            this.Size = new Size(1365, 608);
            this.dgvSUPPLIER.Size = new Size(1300, 400);
            this.panelBUTTON.Location = new Point(4, 560);           
          
        }
        void SET_PRINT()
        {

            dataPrint = new DataTable();
            dataPrint.Columns.Add("NO", typeof(string));
            dataPrint.Columns.Add("HANDLING", typeof(string));
            dataPrint.Columns.Add("KODEAGENT", typeof(string));
            dataPrint.Columns.Add("NAMAAGENT", typeof(string));
            dataPrint.Columns.Add("ALAMAT", typeof(string));
            dataPrint.Columns.Add("CP", typeof(string));
            dataPrint.Columns.Add("TELEPON", typeof(string));
            dataPrint.Columns.Add("NAMAPERUSAHAAN", typeof(string));
            dataPrint.Columns.Add("ALAMATPERUSAHAAN", typeof(string));
            dataPrint.Columns.Add("TELPPERUSAHAAN", typeof(string));
            dataPrint.Columns.Add("FAXPERUSAHAAN", typeof(string));


        }
        public void LOAD_DATA()
        {
            dgvSUPPLIER.DataSource = null;
            dgvSUPPLIER.Rows.Clear();
            

            DataTable dt = b.SELECT();
            SET_PRINT();            
            if (dt.Rows.Count > 0)
            {
                int no_urut = 1;
                for (int i = 0; i < dt.Rows.Count; i++)
                { 
                    string af,trucking,warehouse,groundhandling,ra,shipping,delivery;
                    string hd = dt.Rows[i]["HANDLING"].ToString();
                    string kode = dt.Rows[i]["KODEAGENT"].ToString();
                    string nama = dt.Rows[i]["NAMAAGENT"].ToString();
                    string alamat = dt.Rows[i]["ALAMAT"].ToString();
                    string cp = dt.Rows[i]["CP"].ToString();
                    string telp = dt.Rows[i]["TELEPON"].ToString();
                    if ((dt.Rows[i]["AF"].ToString() == "YES")) { af = "A/F"; } else { af = ""; }
                    if ((dt.Rows[i]["TRUCKING"].ToString() == "YES")) { trucking = "TRUCKING"; } else { trucking = ""; }
                    if ((dt.Rows[i]["WAREHOUSING"].ToString() == "YES")) { warehouse = "WAREHOUSING"; } else { warehouse = ""; }
                    if ((dt.Rows[i]["GROUNDHANDLING"].ToString() == "YES")) { groundhandling = "GROUNDHANDLING"; } else { groundhandling = ""; }
                    if ((dt.Rows[i]["SHIPPING"].ToString() == "YES")) { shipping = "SHIPPING"; } else { shipping = ""; }
                    if ((dt.Rows[i]["DELIVERY"].ToString() == "YES")) { delivery = "DELIVERY"; } else { delivery = ""; }
                    if ((dt.Rows[i]["RA"].ToString() == "YES")) { ra = "REGULATED AGENT"; } else { ra = ""; }
                    string handling = shipping+"-"+af+"-"+delivery+"-"+trucking+"-"+warehouse+"-"+groundhandling+"-"+ra;
                    dgvSUPPLIER.Rows.Add(hd,kode, nama, alamat, cp, telp, handling);
                    dataPrint.Rows.Add(no_urut,hd,kode,nama,alamat,cp,telp,namaPerusahaan,alamatPerusahaan,telpPerusahaan,faxPerusahaan);
                    no_urut++;
                }
            }

        }
        private void btnKELUAR_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void FormSUPPLIER_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                txtCARI.Focus();
            }
            else if (e.KeyCode == Keys.F2)
            {
                MASTER.SUBMASTER.FormSUPPLIER frm = new LOGISTICMANAGAMENTSYSTEM.MASTER.SUBMASTER.FormSUPPLIER(this, 0, null);
                frm.ShowDialog();
            }
            else if (e.KeyCode == Keys.F3)
            {
                if (dgvSUPPLIER.SelectedCells.Count > 0)
                {
                    string kode = dgvSUPPLIER.SelectedCells[0].OwningRow.Cells["KODEAGENT"].Value.ToString();
                    c.KODE = kode;
                    MASTER.SUBMASTER.FormSUPPLIER frm = new LOGISTICMANAGAMENTSYSTEM.MASTER.SUBMASTER.FormSUPPLIER(this, 1, c);
                    frm.ShowDialog();
                }
            }
            else if (e.KeyCode == Keys.F4)
            {
                if (dgvSUPPLIER.SelectedCells.Count > 0)
                {
                    string kode = dgvSUPPLIER.SelectedCells[0].OwningRow.Cells["KODEAGENT"].Value.ToString();
                    string nama = dgvSUPPLIER.SelectedCells[0].OwningRow.Cells["NAMASAGENT"].Value.ToString();
                    c.KODE = kode;
                    DialogResult dr = MessageBox.Show("APAKAH YAKIN AKAN DELETE DATA : " + nama + " ?", "WARNING", MessageBoxButtons.OKCancel, MessageBoxIcon.Stop);
                    if (dr == DialogResult.OK)
                    {
                        b.DELETE(c);
                        LOAD_DATA();
                    }
                }
            }
            else if (e.KeyCode == Keys.F5)
            {
                CrystalDecisions.CrystalReports.Engine.ReportDocument cryRpt = new CrystalDecisions.CrystalReports.Engine.ReportDocument();

                REPORT.FormViewerAGENT frm = new REPORT.FormViewerAGENT(dataPrint);

                frm.ShowDialog();
            }
            else if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }
        private void btnTAMBAH_Click(object sender, EventArgs e)
        {
            MASTER.SUBMASTER.FormSUPPLIER frm = new LOGISTICMANAGAMENTSYSTEM.MASTER.SUBMASTER.FormSUPPLIER(this, 0, null);
            frm.ShowDialog();
        }
        private void btnEDIT_Click(object sender, EventArgs e)
        {
            if (dgvSUPPLIER.SelectedCells.Count > 0)
            {
                string kode = dgvSUPPLIER.SelectedCells[0].OwningRow.Cells["KODEAGENT"].Value.ToString();
                c.KODE = kode;
                MASTER.SUBMASTER.FormSUPPLIER frm = new LOGISTICMANAGAMENTSYSTEM.MASTER.SUBMASTER.FormSUPPLIER(this, 1, c);
                frm.ShowDialog();
            }
        }
        private void btnHAPUS_Click(object sender, EventArgs e)
        {
            if (dgvSUPPLIER.SelectedCells.Count > 0)
            {
                string kode = dgvSUPPLIER.SelectedCells[0].OwningRow.Cells["KODEAGENT"].Value.ToString();
                string nama = dgvSUPPLIER.SelectedCells[0].OwningRow.Cells["NAMASAGENT"].Value.ToString();
                c.KODE = kode;
                DialogResult dr = MessageBox.Show("APAKAH YAKIN AKAN DELETE DATA : " + nama + " ?", "WARNING", MessageBoxButtons.OKCancel, MessageBoxIcon.Stop);
                if (dr == DialogResult.OK)
                {
                    b.DELETE(c);
                    LOAD_DATA();
                }
            }
        }

        private void txtCARI_TextChanged(object sender, EventArgs e)
        {
            LOAD_FILTER();
              
        }
        void LOAD_FILTER()
        {
            dgvSUPPLIER.DataSource = null;
            dgvSUPPLIER.Rows.Clear();
            c.HANDLING = txtCARI.Text;
            c.NAMA = txtCARI.Text;
            c.KODE = txtCARI.Text;
            DataTable dt = b.SEARCH_BYNAMA(c);
            SET_PRINT();
            if (dt.Rows.Count > 0)
            {
                int no_urut = 1;
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    string af, trucking, warehouse, groundhandling;
                    string hd = dt.Rows[i]["HANDLING"].ToString();
                    string kode = dt.Rows[i]["KODEAGENT"].ToString();
                    string nama = dt.Rows[i]["NAMAAGENT"].ToString();
                    string alamat = dt.Rows[i]["ALAMAT"].ToString();
                    string cp = dt.Rows[i]["CP"].ToString();
                    string telp = dt.Rows[i]["TELEPON"].ToString();
                    if ((dt.Rows[i]["AF"].ToString() == "YES")) { af = "A/F"; } else { af = ""; }
                    if ((dt.Rows[i]["TRUCKING"].ToString() == "YES")) { trucking = "TRUCKING"; } else { trucking = ""; }
                    if ((dt.Rows[i]["WAREHOUSING"].ToString() == "YES")) { warehouse = "WAREHOUSING"; } else { warehouse = ""; }
                    if ((dt.Rows[i]["GROUNDHANDLING"].ToString() == "YES")) { groundhandling = "GROUNDHANDLING"; } else { groundhandling = ""; }
                    string handling = af + "-" + trucking + "-" + warehouse + "-" + groundhandling;
                    dgvSUPPLIER.Rows.Add(hd, kode, nama, alamat, cp, telp, handling);
                    dataPrint.Rows.Add(no_urut,hd,kode,nama,alamat,cp,telp,"","","");
                    no_urut++;
                }

            }
        }

        private void btnCetak_Click(object sender, EventArgs e)
        {
           
           // CrystalDecisions.CrystalReports.Engine.ReportDocument cryRpt = new CrystalDecisions.CrystalReports.Engine.ReportDocument();
            
           // REPORT.FormViewerAGENT frm = new REPORT.FormViewerAGENT(cryRpt, dataPrint);
            REPORT.FormViewerAGENT frm = new REPORT.FormViewerAGENT(dataPrint);

            frm.ShowDialog();

        }

        private void cboHANDLING_TextChanged(object sender, EventArgs e)
        {
            LOAD_FILTER();
        }

        
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LOGISTICMANAGAMENTSYSTEM.MASTER
{
    public partial class FormCUSTOMER : Form
    {
        protected RMS.BUSSINES.MASTER.RMS_CUSTOMER b = new RMS.BUSSINES.MASTER.RMS_CUSTOMER();
        protected RMS.COMMON.MASTER.RMS_CUSTOMER c = new RMS.COMMON.MASTER.RMS_CUSTOMER();

        protected RMS.BUSSINES.MASTER.RMS_TENTANGPERUSAHAAN bPersusahaan = new RMS.BUSSINES.MASTER.RMS_TENTANGPERUSAHAAN();
        protected RMS.COMMON.MASTER.RMS_TENTANGPERUSAHAAN cPersusahaan = new RMS.COMMON.MASTER.RMS_TENTANGPERUSAHAAN();

        string kodePerusahaan, namaPerusahaan, alamatPerusahaan, telpPerusahaan, faxPerusahaan;
        DataTable dataPrint;
        public FormCUSTOMER()
        {
            InitializeComponent();
            SETTING_MANUAL();
            INIT_PERUSAHAAN();
            cboTYPE.Text = "RETAIL";
            LOAD_DATA();
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
            dataPrint.Columns.Add("KODE", typeof(string));
            dataPrint.Columns.Add("NAMA", typeof(string));
            dataPrint.Columns.Add("ALAMAT", typeof(string));
            dataPrint.Columns.Add("TELP", typeof(string));
            dataPrint.Columns.Add("HP", typeof(string));
            dataPrint.Columns.Add("MARKETING", typeof(string));
            dataPrint.Columns.Add("NAMAPERUSAHAAN", typeof(string));
            dataPrint.Columns.Add("ALAMATPERUSAHAAN", typeof(string));
            dataPrint.Columns.Add("TELPPERUSAHAAN", typeof(string));
            dataPrint.Columns.Add("FAXPERUSAHAAN", typeof(string));
            

        }
        public void LOAD_DATA()
        {
            dgvCUSTOMER.DataSource = null;
            dgvCUSTOMER.Rows.Clear();

            string limitpiutang = string.Empty;
           
            DataTable dt = b.SELECT(c);
            SET_PRINT();
            if (dt.Rows.Count > 0)
            {
                int no_urut = 1;
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    string kode = dt.Rows[i]["KODECUSTOMER"].ToString();
                    string namaC = dt.Rows[i]["NAMACUSTOMER"].ToString();
                    string alamat = dt.Rows[i]["ALAMAT"].ToString();
                    string telp = dt.Rows[i]["TELEPON"].ToString();
                    string hp = dt.Rows[i]["HP"].ToString();
                    string email = dt.Rows[i]["HP"].ToString();
                    string idmarketing = dt.Rows[i]["IDMARKETING"].ToString();
                    string kodemarketing = dt.Rows[i]["KODEMARKETING"].ToString();
                    string namamarketing = dt.Rows[i]["MARKETING"].ToString();
                    dgvCUSTOMER.Rows.Add(kode, namaC, alamat,telp,hp,email,idmarketing,kodemarketing,namamarketing);
                    dataPrint.Rows.Add(no_urut, kode, namaC, alamat, telp, hp, namamarketing,namaPerusahaan,alamatPerusahaan,telpPerusahaan,faxPerusahaan);
                    no_urut++;
                }
            }

        }

        void SETTING_MANUAL()
        {
            this.Size = new Size(1365, 608);
          
        }

        private void btnKELUAR_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnTAMBAH_Click(object sender, EventArgs e)
        {
            MASTER.SUBMASTER.FormCUSTOMER frm = new LOGISTICMANAGAMENTSYSTEM.MASTER.SUBMASTER.FormCUSTOMER(this,0,null);
            frm.ShowDialog();
        }

        private void btnEDIT_Click(object sender, EventArgs e)
        {
            if (dgvCUSTOMER.SelectedCells.Count > 0)
            {
                string kode = dgvCUSTOMER.SelectedCells[0].OwningRow.Cells["KODE"].Value.ToString();
                c.KODE = kode;
                MASTER.SUBMASTER.FormCUSTOMER frm = new LOGISTICMANAGAMENTSYSTEM.MASTER.SUBMASTER.FormCUSTOMER(this, 1, c);
                frm.ShowDialog();
            }
        }

        private void btnHAPUS_Click(object sender, EventArgs e)
        {
            if (dgvCUSTOMER.SelectedCells.Count > 0)
            {
                string kode = dgvCUSTOMER.SelectedCells[0].OwningRow.Cells["KODE"].Value.ToString();
                string nama = dgvCUSTOMER.SelectedCells[0].OwningRow.Cells["NAMACUSTOMER"].Value.ToString();
                c.KODE = kode;
                DialogResult dr = MessageBox.Show("APAKAH YAKIN AKAN DELETE DATA : " + nama + " ?", "WARNING", MessageBoxButtons.OKCancel, MessageBoxIcon.Stop);
                if (dr == DialogResult.OK)
                {
                    b.DELETE(c);
                    LOAD_DATA();
                }
            }
        }

        private void FormCUSTOMER_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                txtCARI.Focus();
            }
            else if (e.KeyCode == Keys.F2)
            {
               ADD();
            }
            else if (e.KeyCode == Keys.F3)
            {
               EDIT();
            }
            else if (e.KeyCode == Keys.F4)
            {
               DELETE();
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

        private void txtCARI_TextChanged(object sender, EventArgs e)
        {
            string limitpiutang = string.Empty;

            
                dgvCUSTOMER.DataSource = null;
                dgvCUSTOMER.Rows.Clear();

                c.NAMACUSTOMER = txtCARI.Text;
                c.KODE = txtCARI.Text;
                c.MARKETING = txtCARI.Text;
                DataTable dt = b.SEARCHLIKE(c);
                SET_PRINT();
                if (dt.Rows.Count > 0)
                {
                    int no_urut = 1;
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        string kode = dt.Rows[i]["KODECUSTOMER"].ToString();
                        string namaC = dt.Rows[i]["NAMACUSTOMER"].ToString();
                        string alamat = dt.Rows[i]["ALAMAT"].ToString();
                        string telp = dt.Rows[i]["TELEPON"].ToString();
                        string hp = dt.Rows[i]["HP"].ToString();
                        string email = dt.Rows[i]["HP"].ToString();
                        string idmarketing = dt.Rows[i]["IDMARKETING"].ToString();
                        string kodemarketing = dt.Rows[i]["KODEMARKETING"].ToString();
                        string namamarketing = dt.Rows[i]["MARKETING"].ToString();
                        dgvCUSTOMER.Rows.Add(kode, namaC, alamat, telp, hp, email, idmarketing, kodemarketing, namamarketing);
                        dataPrint.Rows.Add(no_urut, kode, namaC, alamat, telp, hp, namamarketing);
                        no_urut++;
                    }
                

            }
        }
        private void btnCetak_Click(object sender, EventArgs e)
        {
            CrystalDecisions.CrystalReports.Engine.ReportDocument cryRpt = new CrystalDecisions.CrystalReports.Engine.ReportDocument();
            REPORT.FormViewerCUSTOMER frm = new REPORT.FormViewerCUSTOMER(dataPrint);
            frm.ShowDialog();
        }
        void ADD()
        {
            MASTER.SUBMASTER.FormCUSTOMER frm = new LOGISTICMANAGAMENTSYSTEM.MASTER.SUBMASTER.FormCUSTOMER(this, 0, null);
            frm.ShowDialog();
        }
        void EDIT()
        {
            if (dgvCUSTOMER.SelectedCells.Count > 0)
            {
                string kode = dgvCUSTOMER.SelectedCells[0].OwningRow.Cells["KODE"].Value.ToString();
                c.KODE = kode;
                MASTER.SUBMASTER.FormCUSTOMER frm = new LOGISTICMANAGAMENTSYSTEM.MASTER.SUBMASTER.FormCUSTOMER(this, 1, c);
                frm.ShowDialog();
            }
        }
        void DELETE()
        {
            if (dgvCUSTOMER.SelectedCells.Count > 0)
            {
                string kode = dgvCUSTOMER.SelectedCells[0].OwningRow.Cells["KODE"].Value.ToString();
                string nama = dgvCUSTOMER.SelectedCells[0].OwningRow.Cells["NAMACUSTOMER"].Value.ToString();
                c.KODE = kode;
                DialogResult dr = MessageBox.Show("APAKAH YAKIN AKAN DELETE DATA : " + nama + " ?", "WARNING", MessageBoxButtons.OKCancel, MessageBoxIcon.Stop);
                if (dr == DialogResult.OK)
                {
                    b.DELETE(c);
                    LOAD_DATA();
                }
            }
        }
        void CETAK()
        {
            CrystalDecisions.CrystalReports.Engine.ReportDocument cryRpt = new CrystalDecisions.CrystalReports.Engine.ReportDocument();
            REPORT.FormViewerCUSTOMER frm = new REPORT.FormViewerCUSTOMER(dataPrint);
            frm.ShowDialog();
        }

        private void txtCARI_KeyUp(object sender, KeyEventArgs e)
        {

   
        }

        private void dgvCUSTOMER_KeyUp(object sender, KeyEventArgs e)
        {
     
        }

        private void cboTYPE_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboTYPE.Text == "RETAIL")
            {
                c.TYPE = 1;
            }
            else
            {
                c.TYPE = 2;
            }
            LOAD_DATA();
        }
    }
}

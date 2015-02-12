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
    public partial class FormPENERIMA : Form
    {
        protected RMS.BUSSINES.MASTER.RMS_PENERIMA b = new RMS.BUSSINES.MASTER.RMS_PENERIMA();
        protected RMS.COMMON.MASTER.RMS_PENERIMA c = new RMS.COMMON.MASTER.RMS_PENERIMA();

        protected RMS.BUSSINES.MASTER.RMS_TENTANGPERUSAHAAN bPersusahaan = new RMS.BUSSINES.MASTER.RMS_TENTANGPERUSAHAAN();
        protected RMS.COMMON.MASTER.RMS_TENTANGPERUSAHAAN cPersusahaan = new RMS.COMMON.MASTER.RMS_TENTANGPERUSAHAAN();
        string kodePerusahaan, namaPerusahaan, alamatPerusahaan, telpPerusahaan, faxPerusahaan;
        DataTable dataPrint;
      
        public FormPENERIMA()
        {
            InitializeComponent();
            cboTYPE.Text = "RETAIL";
            SETTING_MANUAL();
            INIT_PERUSAHAAN();
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
            dataPrint.Columns.Add("FAX", typeof(string));
            dataPrint.Columns.Add("EMAIL", typeof(string));
            dataPrint.Columns.Add("NAMAPERUSAHAAN", typeof(string));
            dataPrint.Columns.Add("ALAMATPERUSAHAAN", typeof(string));
            dataPrint.Columns.Add("TELPPERUSAHAAN", typeof(string));
            dataPrint.Columns.Add("FAXPERUSAHAAN", typeof(string));
            dataPrint.Columns.Add("HP", typeof(string));


        }
        public void LOAD_DATA()
        {
            dgvPENERIMA.DataSource = null;
            dgvPENERIMA.Rows.Clear();

            string limitpiutang = string.Empty;

            DataTable dt = b.SELECT(c);

            SET_PRINT();
            if (dt.Rows.Count > 0)
            {
                int no_urut = 1;
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    
                    string kode = dt.Rows[i]["KODEPENERIMA"].ToString();
                    string id = dt.Rows[i]["IDPENERIMA"].ToString();
                    string namaC = dt.Rows[i]["NAMAPENERIMA"].ToString();
                    string alamat = dt.Rows[i]["ALAMAT"].ToString();
                    string telp = dt.Rows[i]["TELEPON"].ToString();
                    string fax = dt.Rows[i]["FAX"].ToString();
                    string hp = dt.Rows[i]["HP"].ToString();
                    string email = dt.Rows[i]["EMAIL"].ToString();
                    
                    
                    dgvPENERIMA.Rows.Add(id, namaC, alamat, telp,fax, hp, email);
                    dataPrint.Rows.Add(no_urut, kode, namaC, alamat, telp, fax, email, namaPerusahaan, alamatPerusahaan, telpPerusahaan, faxPerusahaan, hp);
                    no_urut++;
                }
            }

        }
        void SETTING_MANUAL()
        {
            this.Size = new Size(1365, 608);
           // this.dgvPENERIMA.Size = new Size(1360, 520);

            // this.panelBUTTON.Location = new Point(2, 560);
            //  this.panelCARI.Location = new Point(814, 4);
        }

        private void txtCARI_KeyUp(object sender, KeyEventArgs e)
        {      
            string limitpiutang = string.Empty;
            
            dgvPENERIMA.DataSource = null;
            dgvPENERIMA.Rows.Clear();

            c.NAMAPENERIMA = txtCARI.Text;
            
            DataTable dt = b.SEARCHLIKE(c);
            SET_PRINT();
            if (dt.Rows.Count > 0)
            {
                int no_urut = 1;
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    string kode = dt.Rows[i]["KODEPENERIMA"].ToString();
                    string id = dt.Rows[i]["IDPENERIMA"].ToString();
                    string namaC = dt.Rows[i]["NAMAPENERIMA"].ToString();
                    string alamat = dt.Rows[i]["ALAMAT"].ToString();
                    string telp = dt.Rows[i]["TELEPON"].ToString();
                    string fax = dt.Rows[i]["FAX"].ToString();
                    string hp = dt.Rows[i]["HP"].ToString();
                    string email = dt.Rows[i]["EMAIL"].ToString();

                    
                    dgvPENERIMA.Rows.Add(id, namaC, alamat, telp, fax, hp, email);
                    dataPrint.Rows.Add(no_urut, kode, namaC, alamat, telp, fax, email, namaPerusahaan, alamatPerusahaan, telpPerusahaan, faxPerusahaan, hp);
                    no_urut++;
                }


            }
        }

        private void btnHAPUS_Click(object sender, EventArgs e)
        {
            if (dgvPENERIMA.SelectedCells.Count > 0)
            {
                string id = dgvPENERIMA.SelectedCells[0].OwningRow.Cells["ID"].Value.ToString();
                string nama = dgvPENERIMA.SelectedCells[0].OwningRow.Cells["NAMAPENERIMA"].Value.ToString();
                c.ID = int.Parse(id);
                DialogResult dr = MessageBox.Show("APAKAH YAKIN AKAN DELETE DATA : " + nama + " ?", "WARNING", MessageBoxButtons.OKCancel, MessageBoxIcon.Stop);
                if (dr == DialogResult.OK)
                {
                    b.DELETE(c);
                    LOAD_DATA();
                }
            }
        }

        private void btnTAMBAH_Click(object sender, EventArgs e)
        {
            MASTER.SUBMASTER.FormPENERIMA frm = new LOGISTICMANAGAMENTSYSTEM.MASTER.SUBMASTER.FormPENERIMA(this, 0, null);
            frm.ShowDialog();
        }

        private void btnEDIT_Click(object sender, EventArgs e)
        {
            if (dgvPENERIMA.SelectedCells.Count > 0)
            {
                string ID = dgvPENERIMA.SelectedCells[0].OwningRow.Cells["ID"].Value.ToString();
                c.ID = int.Parse(ID);
                MASTER.SUBMASTER.FormPENERIMA frm = new LOGISTICMANAGAMENTSYSTEM.MASTER.SUBMASTER.FormPENERIMA(this, 1, c);
                frm.ShowDialog();
            }
        }

        private void FormPENERIMA_KeyUp(object sender, KeyEventArgs e)
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
                DELETE();
            }
            else if (e.KeyCode == Keys.F5)
            {
                CETAK();
            }
            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }
        void TAMBAH()
        {
            MASTER.SUBMASTER.FormPENERIMA frm = new LOGISTICMANAGAMENTSYSTEM.MASTER.SUBMASTER.FormPENERIMA(this, 0, null);
            frm.ShowDialog();
        }
        void EDIT()
        {
            if (dgvPENERIMA.SelectedCells.Count > 0)
            {
                string ID = dgvPENERIMA.SelectedCells[0].OwningRow.Cells["ID"].Value.ToString();
                c.ID = int.Parse(ID);
                MASTER.SUBMASTER.FormPENERIMA frm = new LOGISTICMANAGAMENTSYSTEM.MASTER.SUBMASTER.FormPENERIMA(this, 1, c);
                frm.ShowDialog();
            }
        }
        void DELETE()
        {
            if (dgvPENERIMA.SelectedCells.Count > 0)
            {
                string id = dgvPENERIMA.SelectedCells[0].OwningRow.Cells["ID"].Value.ToString();
                string nama = dgvPENERIMA.SelectedCells[0].OwningRow.Cells["NAMAPENERIMA"].Value.ToString();
                c.ID = int.Parse(id);
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
            REPORT.FormViewerPENERIMA frm = new REPORT.FormViewerPENERIMA(dataPrint);
            frm.ShowDialog();
        }

        private void btnCetak_Click(object sender, EventArgs e)
        {
            CETAK();  
        }

        private void btnKELUAR_Click(object sender, EventArgs e)
        {
            Close();
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

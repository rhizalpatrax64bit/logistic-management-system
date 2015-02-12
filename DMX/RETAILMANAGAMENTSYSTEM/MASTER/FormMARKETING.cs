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
    public partial class FormMARKETING : Form
    {
        protected RMS.BUSSINES.MASTER.RMS_MARKETING b = new RMS.BUSSINES.MASTER.RMS_MARKETING();
        protected RMS.COMMON.MASTER.RMS_MARKETING c = new RMS.COMMON.MASTER.RMS_MARKETING();
        protected RMS.BUSSINES.MASTER.RMS_TENTANGPERUSAHAAN bPersusahaan = new RMS.BUSSINES.MASTER.RMS_TENTANGPERUSAHAAN();
        protected RMS.COMMON.MASTER.RMS_TENTANGPERUSAHAAN cPersusahaan = new RMS.COMMON.MASTER.RMS_TENTANGPERUSAHAAN();

        string kodePerusahaan, namaPerusahaan, alamatPerusahaan, telpPerusahaan, faxPerusahaan;

        DataTable dataPrint;
        public FormMARKETING()
        {
            InitializeComponent();
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

        void SETTING_MANUAL()
        {
            this.Size = new Size(1365, 608);
            this.dgvMARKETING.Size = new Size(1360, 520);
            this.panelBUTTON.Location = new Point(2, 560);
           // this.panelCARI.Location = new Point(790, 4);
        }
        void SET_PRINT()
        {
            dataPrint = new DataTable();
            dataPrint.Columns.Add("NO", typeof(string));
            dataPrint.Columns.Add("KODE", typeof(string));
            dataPrint.Columns.Add("NAMA", typeof(string));
            dataPrint.Columns.Add("ALAMAT", typeof(string));
            dataPrint.Columns.Add("TELP", typeof(string));
            dataPrint.Columns.Add("EMAIL", typeof(string));
            dataPrint.Columns.Add("NAMAPERUSAHAAN", typeof(string));
            dataPrint.Columns.Add("ALAMATPERUSAHAAN", typeof(string));
            dataPrint.Columns.Add("TELPPERUSAHAAN", typeof(string));
            dataPrint.Columns.Add("FAXPERUSAHAAN", typeof(string));


        }
        public void LOAD_DATA()
        {
            dgvMARKETING.DataSource = null;
            dgvMARKETING.Rows.Clear();

            DataTable dt = b.SELECT();
            SET_PRINT();
            if (dt.Rows.Count > 0)
            {
                int no_urut = 1;
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    string kode = dt.Rows[i]["KODE"].ToString();
                    string nama = dt.Rows[i]["NAMA"].ToString();
                    string alamat = dt.Rows[i]["ALAMAT"].ToString();
                    string telp = dt.Rows[i]["TELEPON"].ToString();
                    string email = dt.Rows[i]["EMAIL"].ToString();
                    dgvMARKETING.Rows.Add(kode, nama, alamat, telp, email);
                    dataPrint.Rows.Add(no_urut, kode, nama, alamat, telp, email, namaPerusahaan, alamatPerusahaan, telpPerusahaan,faxPerusahaan);
                    no_urut++;
                }
            }
        }

        private void FormMARKETING_KeyUp(object sender, KeyEventArgs e)
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
              CrystalDecisions.CrystalReports.Engine.ReportDocument cryRpt = new CrystalDecisions.CrystalReports.Engine.ReportDocument();
              REPORT.FormViewerMARKETING frm = new REPORT.FormViewerMARKETING(dataPrint);
              frm.ShowDialog();
        
            }
            else if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
            
        }

        private void txtCARI_TextChanged(object sender, EventArgs e)
        {
                     
                dgvMARKETING.DataSource = null;
                dgvMARKETING.Rows.Clear();

                c.NAMA = txtCARI.Text;
                c.KODE = txtCARI.Text;
                DataTable dt = b.SEARCH_BYNAMA(c);
                SET_PRINT();
                if (dt.Rows.Count > 0)
                {
                    int no_urut = 1;
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        string KODE = dt.Rows[i]["KODE"].ToString();
                        string NAMA = dt.Rows[i]["NAMA"].ToString();
                        string ALAMAT = dt.Rows[i]["ALAMAT"].ToString();
                        string TELP = dt.Rows[i]["TELEPON"].ToString();
                        string EMAIL = dt.Rows[i]["EMAIL"].ToString();
                        dgvMARKETING.Rows.Add(KODE, NAMA, ALAMAT, TELP, EMAIL);
                        dataPrint.Rows.Add(no_urut, KODE, NAMA, ALAMAT, TELP, EMAIL, "", "", "");
                        no_urut++;
                    }
                

            }
        }

        private void btnCetak_Click(object sender, EventArgs e)
        {
            //CrystalDecisions.CrystalReports.Engine.ReportDocument cryRpt = new CrystalDecisions.CrystalReports.Engine.ReportDocument();
            REPORT.FormViewerMARKETING frm = new REPORT.FormViewerMARKETING(dataPrint);
            frm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int index = dgvMARKETING.Rows.Count;
            dgvMARKETING.Rows.Insert(index, 1);
            var addedRow = dgvMARKETING.Rows[index];
        
        }

        private void btnHAPUS_Click(object sender, EventArgs e)
        {
            if (dgvMARKETING.SelectedCells.Count > 0)
            {
                string kode = dgvMARKETING.SelectedCells[0].OwningRow.Cells["KODEMARKETING"].Value.ToString();
                string nama = dgvMARKETING.SelectedCells[0].OwningRow.Cells["KODEMARKETING"].Value.ToString();
                c.KODE = kode;
                DialogResult dr = MessageBox.Show("APAKAH YAKIN AKAN DELETE DATA : " + nama + " ?", "WARNING", MessageBoxButtons.OKCancel, MessageBoxIcon.Stop);
                if (dr == DialogResult.OK)
                {
                    b.DELETE(c);
                    LOAD_DATA();
                }
            }
        }

        private void dgvMARKETING_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvMARKETING.SelectedCells.Count > 0)
            {
                dgvMARKETING.ReadOnly = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in this.dgvMARKETING.SelectedRows)
            {
                dgvMARKETING.Rows.RemoveAt(item.Index);
            }
        }

        private void btnTAMBAH_Click(object sender, EventArgs e)
        {
            MASTER.SUBMASTER.FormMARKETING frm = new LOGISTICMANAGAMENTSYSTEM.MASTER.SUBMASTER.FormMARKETING(this, 0, null);
            frm.ShowDialog();
        }

        private void btnEDIT_Click(object sender, EventArgs e)
        {
            if (dgvMARKETING.SelectedCells.Count > 0)
            {
                string kode = dgvMARKETING.SelectedCells[0].OwningRow.Cells["KODEMARKETING"].Value.ToString();
                c.KODE = kode;
                MASTER.SUBMASTER.FormMARKETING frm = new LOGISTICMANAGAMENTSYSTEM.MASTER.SUBMASTER.FormMARKETING(this, 1, c);
                frm.ShowDialog();
            }
        }

        private void btnKELUAR_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtCARI_KeyUp(object sender, KeyEventArgs e)
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
                CrystalDecisions.CrystalReports.Engine.ReportDocument cryRpt = new CrystalDecisions.CrystalReports.Engine.ReportDocument();
                REPORT.FormViewerMARKETING frm = new REPORT.FormViewerMARKETING(dataPrint);
                frm.ShowDialog();
        
            }
            else if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
            

        }

        private void dgvMARKETING_KeyUp(object sender, KeyEventArgs e)
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
                CrystalDecisions.CrystalReports.Engine.ReportDocument cryRpt = new CrystalDecisions.CrystalReports.Engine.ReportDocument();
                REPORT.FormViewerMARKETING frm = new REPORT.FormViewerMARKETING(dataPrint);
                frm.ShowDialog();

            }
            else if (e.KeyCode == Keys.Escape)
            {
                    Close();
            }
            

        }
        void ADD()
        {
            MASTER.SUBMASTER.FormMARKETING frm = new LOGISTICMANAGAMENTSYSTEM.MASTER.SUBMASTER.FormMARKETING(this, 0, null);
            frm.ShowDialog();
        }
        void EDIT()
        {
            if (dgvMARKETING.SelectedCells.Count > 0)
            {
                string kode = dgvMARKETING.SelectedCells[0].OwningRow.Cells["KODEMARKETING"].Value.ToString();
                c.KODE = kode;
                MASTER.SUBMASTER.FormMARKETING frm = new LOGISTICMANAGAMENTSYSTEM.MASTER.SUBMASTER.FormMARKETING(this, 1, c);
                frm.ShowDialog();
            }
        }
        void DELETE()
        {
            if (dgvMARKETING.SelectedCells.Count > 0)
            {
                string kode = dgvMARKETING.SelectedCells[0].OwningRow.Cells["KODEMARKETING"].Value.ToString();
                string nama = dgvMARKETING.SelectedCells[0].OwningRow.Cells["KODEMARKETING"].Value.ToString();
                c.KODE = kode;
                DialogResult dr = MessageBox.Show("APAKAH YAKIN AKAN DELETE DATA : " + nama + " ?", "WARNING", MessageBoxButtons.OKCancel, MessageBoxIcon.Stop);
                if (dr == DialogResult.OK)
                {
                    b.DELETE(c);
                    LOAD_DATA();
                }
            }
        }
    }
}

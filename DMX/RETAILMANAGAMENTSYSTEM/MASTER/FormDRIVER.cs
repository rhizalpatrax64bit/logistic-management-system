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
    public partial class FormDRIVER : Form
    {
        protected RMS.BUSSINES.MASTER.RMS_DRIVER b = new RMS.BUSSINES.MASTER.RMS_DRIVER();
        protected RMS.COMMON.MASTER.RMS_DRIVER c = new RMS.COMMON.MASTER.RMS_DRIVER();
        protected RMS.BUSSINES.MASTER.RMS_TENTANGPERUSAHAAN bPersusahaan = new RMS.BUSSINES.MASTER.RMS_TENTANGPERUSAHAAN();
        protected RMS.COMMON.MASTER.RMS_TENTANGPERUSAHAAN cPersusahaan = new RMS.COMMON.MASTER.RMS_TENTANGPERUSAHAAN();

        string kodePerusahaan, namaPerusahaan, alamatPerusahaan, telpPerusahaan, faxPerusahaan;
        DataTable dataPrint;

        public FormDRIVER()
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
            this.dgvDRIVER.Size = new Size(1360, 520);
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
            dataPrint.Columns.Add("HP", typeof(string));
            dataPrint.Columns.Add("EMAIL", typeof(string));
            dataPrint.Columns.Add("STATUS", typeof(string));
            dataPrint.Columns.Add("NAMAPERUSAHAAN", typeof(string));
            dataPrint.Columns.Add("ALAMATPERUSAHAAN", typeof(string));
            dataPrint.Columns.Add("TELPPERUSAHAAN", typeof(string));
            dataPrint.Columns.Add("FAXPERUSAHAAN", typeof(string));


        }
        public void LOAD_DATA()
        {
            dgvDRIVER.DataSource = null;
            dgvDRIVER.Rows.Clear();

            string limitpiutang = string.Empty;

            DataTable dt = b.SELECT();
            SET_PRINT();
            if (dt.Rows.Count > 0)
            {
                int no_urut = 1;
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    string id = dt.Rows[i]["ID"].ToString();
                    string kode = dt.Rows[i]["KODE"].ToString();
                    string nama = dt.Rows[i]["NAMA"].ToString();
                    string alamat = dt.Rows[i]["ALAMAT"].ToString();
                    string telp = dt.Rows[i]["TELEPON"].ToString();
                    string hp = dt.Rows[i]["HP"].ToString();
                    string email = dt.Rows[i]["EMAIL"].ToString();
                    string status = dt.Rows[i]["NAMASTATUS"].ToString();

                    dgvDRIVER.Rows.Add(id,status,kode,nama, alamat, telp, hp, email);
                    dataPrint.Rows.Add(no_urut, kode, nama, alamat, telp, hp, email, status, namaPerusahaan, alamatPerusahaan, telpPerusahaan, faxPerusahaan);
                    no_urut++;
                }
            }

        }
        private void btnTAMBAH_Click(object sender, EventArgs e)
        {
            TAMBAH();
        }

        private void btnEDIT_Click(object sender, EventArgs e)
        {
            EDIT();
        }

        private void txtCARI_TextChanged(object sender, EventArgs e)
        {
            dgvDRIVER.DataSource = null;
            dgvDRIVER.Rows.Clear();

            string limitpiutang = string.Empty;
            c.NAMA = txtCARI.Text;
            c.TELEPON = txtCARI.Text;
           
            DataTable dt = b.SEARCHLIKE(c);

            if (dt.Rows.Count > 0)
            {
                int no_urut = 1;
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    string id = dt.Rows[i]["ID"].ToString();
                    string kode = dt.Rows[i]["KODE"].ToString();
                    string nama = dt.Rows[i]["NAMA"].ToString();
                    string alamat = dt.Rows[i]["ALAMAT"].ToString();
                    string telp = dt.Rows[i]["TELEPON"].ToString();
                    string hp = dt.Rows[i]["HP"].ToString();
                    string email = dt.Rows[i]["EMAIL"].ToString();
                    string status = dt.Rows[i]["NAMASTATUS"].ToString();

                    dgvDRIVER.Rows.Add(id, status, kode, nama, alamat, telp, hp, email);
                    dataPrint.Rows.Add(no_urut, kode, nama, alamat, telp, hp, email, status, namaPerusahaan, alamatPerusahaan, telpPerusahaan, faxPerusahaan);
                    no_urut++;
                }
            }
        }

        private void btnHAPUS_Click(object sender, EventArgs e)
        {
            DELETE();
        }

        private void btnCetak_Click(object sender, EventArgs e)
        {
            CETAK();
        }

        private void FormDRIVER_KeyUp(object sender, KeyEventArgs e)
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
            MASTER.SUBMASTER.FormDRIVERHELPER frm = new LOGISTICMANAGAMENTSYSTEM.MASTER.SUBMASTER.FormDRIVERHELPER(this, 0, null);
            frm.ShowDialog();
        }
        void EDIT()
        {
            if (dgvDRIVER.SelectedCells.Count > 0)
            {
                string kode = dgvDRIVER.SelectedCells[0].OwningRow.Cells["KODE"].Value.ToString();
                c.KODE = kode;
                MASTER.SUBMASTER.FormDRIVERHELPER frm = new LOGISTICMANAGAMENTSYSTEM.MASTER.SUBMASTER.FormDRIVERHELPER(this, 1, c);
                frm.ShowDialog();
            }
        }
        void DELETE()
        {
            if (dgvDRIVER.SelectedCells.Count > 0)
            {
                string kode = dgvDRIVER.SelectedCells[0].OwningRow.Cells["KODE"].Value.ToString();
                string nama = dgvDRIVER.SelectedCells[0].OwningRow.Cells["NAMA"].Value.ToString();
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

            REPORT.FormViewerDriver frm = new REPORT.FormViewerDriver(dataPrint);
            frm.ShowDialog();
        }

    }
}

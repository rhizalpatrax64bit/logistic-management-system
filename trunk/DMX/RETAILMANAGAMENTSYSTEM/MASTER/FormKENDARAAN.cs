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
    public partial class FormKENDARAAN : Form
    {
        protected RMS.BUSSINES.MASTER.RMS_KENDARAAN b = new RMS.BUSSINES.MASTER.RMS_KENDARAAN();
        protected RMS.COMMON.MASTER.RMS_KENDARAAN c = new RMS.COMMON.MASTER.RMS_KENDARAAN();

        protected RMS.BUSSINES.MASTER.RMS_TENTANGPERUSAHAAN bPersusahaan = new RMS.BUSSINES.MASTER.RMS_TENTANGPERUSAHAAN();
        protected RMS.COMMON.MASTER.RMS_TENTANGPERUSAHAAN cPersusahaan = new RMS.COMMON.MASTER.RMS_TENTANGPERUSAHAAN();
        string kodePerusahaan, namaPerusahaan, alamatPerusahaan, telpPerusahaan, faxPerusahaan;
        DataTable dataPrint;
        MASTER.FormDRIVER frm;
        int Type;

        public FormKENDARAAN()
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
            this.dgvKENDARAAN.Size = new Size(1360, 520);
            this.panelBUTTON.Location = new Point(2, 560);
            // this.panelCARI.Location = new Point(790, 4);
        }
        void SET_PRINT()
        {
            dataPrint = new DataTable();
            dataPrint.Columns.Add("NO", typeof(string));
            dataPrint.Columns.Add("NOPOL", typeof(string));
            dataPrint.Columns.Add("JENIS", typeof(string));
            dataPrint.Columns.Add("BERATMUATAN", typeof(string));
            dataPrint.Columns.Add("VOLUME", typeof(string));
            dataPrint.Columns.Add("DRIVER", typeof(string));
            dataPrint.Columns.Add("HELPER", typeof(string));
            dataPrint.Columns.Add("STATUS", typeof(string));
            dataPrint.Columns.Add("NAMAPERUSAHAAN", typeof(string));
            dataPrint.Columns.Add("ALAMATPERUSAHAAN", typeof(string));
            dataPrint.Columns.Add("TELPPERUSAHAAN", typeof(string));
            dataPrint.Columns.Add("FAXPERUSAHAAN", typeof(string));

          

        }
        public void LOAD_DATA()
        {
            dgvKENDARAAN.DataSource = null;
            dgvKENDARAAN.Rows.Clear();

            string limitpiutang = string.Empty;

            DataTable dt = b.SELECT();
            SET_PRINT();
            if (dt.Rows.Count > 0)
            {
                int no_urut = 1;
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    string id = dt.Rows[i]["ID"].ToString();
                    string nopol = dt.Rows[i]["NOPOL"].ToString();
                    string jeniskendaraan = dt.Rows[i]["JENISKENDARAAN"].ToString();
                    string maxmuatan = dt.Rows[i]["MAXMUATAN"].ToString();
                    string maxvolume = dt.Rows[i]["MAXVOLUME"].ToString();
                    string driver = dt.Rows[i]["NAMADRIVER"].ToString();
                    string helper = dt.Rows[i]["NAMAHELPER"].ToString();
                    string namastatus = dt.Rows[i]["NAMASTATUS"].ToString();

                    dgvKENDARAAN.Rows.Add(id, nopol, jeniskendaraan, maxmuatan, maxvolume, driver, helper, namastatus);
                    dataPrint.Rows.Add(no_urut,nopol, jeniskendaraan, maxmuatan, maxvolume, driver, helper, namastatus, namaPerusahaan, alamatPerusahaan, telpPerusahaan, faxPerusahaan);
                    no_urut++;
                }
            }

        }

       

        private void btnTAMBAH_Click(object sender, EventArgs e)
        {
            TAMBAH();
        }
        void TAMBAH()
        {
            MASTER.SUBMASTER.FormKENDARAAN frm = new LOGISTICMANAGAMENTSYSTEM.MASTER.SUBMASTER.FormKENDARAAN(this, 0, null);
            frm.ShowDialog();
        }
        private void btnEDIT_Click(object sender, EventArgs e)
        {
            EDIT();
        }
        void EDIT()
        {
            if (dgvKENDARAAN.SelectedCells.Count > 0)
            {
                int id = Convert.ToInt32(dgvKENDARAAN.SelectedCells[0].OwningRow.Cells["ID"].Value.ToString());
                string nopol = dgvKENDARAAN.SelectedCells[0].OwningRow.Cells["NOPOL"].Value.ToString();
                c.ID = id;
                c.NOPOL = nopol;

                MASTER.SUBMASTER.FormKENDARAAN frm = new LOGISTICMANAGAMENTSYSTEM.MASTER.SUBMASTER.FormKENDARAAN(this, 1, c);
                frm.ShowDialog();
            }
        }
        private void btnCetak_Click(object sender, EventArgs e)
        {
            CETAK();
            
        }
        void CETAK()
        {
            REPORT.FormViewerKENDARAAN frm = new REPORT.FormViewerKENDARAAN(dataPrint);
            frm.ShowDialog();
        }
        private void FormKENDARAAN_KeyUp(object sender, KeyEventArgs e)
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

        private void btnHAPUS_Click(object sender, EventArgs e)
        {
            DELETE();
        }
        void DELETE()
        {
            if (dgvKENDARAAN.SelectedCells.Count > 0)
            {
                int id = Convert.ToInt32(dgvKENDARAAN.SelectedCells[0].OwningRow.Cells["ID"].Value.ToString());
                string nopol = dgvKENDARAAN.SelectedCells[0].OwningRow.Cells["NOPOL"].Value.ToString();
                c.ID = id;
                c.NOPOL = nopol;
                DialogResult dr = MessageBox.Show("APAKAH YAKIN AKAN DELETE DATA : " + nopol + " ?", "WARNING", MessageBoxButtons.OKCancel, MessageBoxIcon.Stop);
                if (dr == DialogResult.OK)
                {
                    b.DELETE(c);
                    LOAD_DATA();
                }
            }
        }

        private void txtCARI_KeyUp(object sender, KeyEventArgs e)
        {
            dgvKENDARAAN.DataSource = null;
            dgvKENDARAAN.Rows.Clear();

            string limitpiutang = string.Empty;
            c.NOPOL = txtCARI.Text;
            c.NAMADRIVER = txtCARI.Text;
            c.NAMAHELPER = txtCARI.Text;


            DataTable dt = b.SEARCHLIKE(c);

            if (dt.Rows.Count > 0)
            {
                int no_urut = 1;
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    string id = dt.Rows[i]["ID"].ToString();
                    string nopol = dt.Rows[i]["NOPOL"].ToString();
                    string jeniskendaraan = dt.Rows[i]["JENISKENDARAAN"].ToString();
                    string maxmuatan = dt.Rows[i]["MAXMUATAN"].ToString();
                    string maxvolume = dt.Rows[i]["MAXVOLUME"].ToString();
                    string driver = dt.Rows[i]["NAMADRIVER"].ToString();
                    string helper = dt.Rows[i]["NAMAHELPER"].ToString();
                    string namastatus = dt.Rows[i]["NAMASTATUS"].ToString();

                    dgvKENDARAAN.Rows.Add(id, nopol, jeniskendaraan, maxmuatan, maxvolume, driver, helper, namastatus);
                    dataPrint.Rows.Add(no_urut, nopol, jeniskendaraan, maxmuatan, maxvolume, driver, helper, namastatus, namaPerusahaan, alamatPerusahaan, telpPerusahaan, faxPerusahaan);
                    no_urut++;
                }
            }
        }
       
    }
}

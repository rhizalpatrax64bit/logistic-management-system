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
    public partial class FormKOTA : Form
    {
        protected RMS.BUSSINES.MASTER.RMS_KOTA b = new RMS.BUSSINES.MASTER.RMS_KOTA();
        protected RMS.COMMON.MASTER.RMS_KOTA c = new RMS.COMMON.MASTER.RMS_KOTA();
        DataTable dataPrint;

        public FormKOTA()
        {
            InitializeComponent();
            LOAD_DATA();
        }
        public void LOAD_DATA()
        {
            dgvAREA.DataSource = null;
            dgvAREA.Rows.Clear();

            DataTable dt = b.SELECT();
            dataPrint = new DataTable();
            dataPrint = dt;
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    string idarea = dt.Rows[i]["IDAREA"].ToString();
                    string kodearea = dt.Rows[i]["KODEAREA"].ToString();
                    string namaarea = dt.Rows[i]["NAMAAREA"].ToString();                    
                    dgvAREA.Rows.Add(idarea,kodearea,namaarea);
                }
            }

        }
        public void LOAD_DATAKOTA()
        {
            dgvKOTA.DataSource = null;
            dgvKOTA.Rows.Clear();

            DataTable dt = b.CARI_BYKODE(c);
            dataPrint = new DataTable();
            dataPrint = dt;
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    string idkota = dt.Rows[i]["IDKOTA"].ToString();
                    string namaareakota = dt.Rows[i]["NAMAAREA"].ToString();
                    string kodekota = dt.Rows[i]["KODEKOTA"].ToString();
                    string namakota = dt.Rows[i]["NAMAKOTA"].ToString();
                    dgvKOTA.Rows.Add(idkota, namaareakota, kodekota,namakota);
                }
            }

        }
        public void LOAD_DATATERUSAN()
        {
            dgvTERUSAN.DataSource = null;
            dgvTERUSAN.Rows.Clear();

            DataTable dt = b.GET_TERUSANBYID(c);
            dataPrint = new DataTable();
            dataPrint = dt;
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    string id = dt.Rows[i]["ID"].ToString();
                    string idkota = dt.Rows[i]["IDKOTA"].ToString();
                    string kodekota = dt.Rows[i]["KODEKOTA"].ToString();
                    string namaterusan = dt.Rows[i]["NAMATERUSAN"].ToString();

                    dgvTERUSAN.Rows.Add(id,idkota, kodekota, namaterusan);
                }
            }

        }
        private void dgvAREA_Click(object sender, EventArgs e)
        {
            if (dgvAREA.SelectedCells.Count > 0)
            {
                string kode = dgvAREA.SelectedCells[0].OwningRow.Cells["KODEAREA"].Value.ToString();
                c.KODEAREA = kode;
                LOAD_DATAKOTA();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MASTER.SUBMASTER.FormAREA frm = new LOGISTICMANAGAMENTSYSTEM.MASTER.SUBMASTER.FormAREA(this, 0, null);
            frm.ShowDialog();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dgvAREA.SelectedCells.Count > 0)
            {
               
                string idarea = dgvAREA.SelectedCells[0].OwningRow.Cells["IDAREA"].Value.ToString();
                c.IDAREA = int.Parse(idarea);
                MASTER.SUBMASTER.FormAREA frm = new LOGISTICMANAGAMENTSYSTEM.MASTER.SUBMASTER.FormAREA(this, 1, c);
                frm.ShowDialog();
                 
            }
        }

        private void txtCARI_TextChanged(object sender, EventArgs e)
        {
            dgvAREA.DataSource = null;
            dgvAREA.Rows.Clear();
            dgvKOTA.DataSource = null;
            dgvKOTA.Rows.Clear();

            if (rdbKODE.Checked == true)
            {
                c.KODEAREA = txtCARI.Text;
                DataTable dt = b.SEARCH_BYKODEAREA(c);
                DataTable dtKOTA = b.SEARCH_BYKODE(c);
                dataPrint = new DataTable();
                dataPrint = dt;
                if (dt.Rows.Count > 0)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        string idarea = dt.Rows[i]["IDAREA"].ToString();
                        string kodearea = dt.Rows[i]["KODEAREA"].ToString();
                        string namaarea = dt.Rows[i]["NAMAAREA"].ToString();
                        dgvAREA.Rows.Add(idarea, kodearea, namaarea);
                    }
                }
                if (dtKOTA.Rows.Count > 0)
                {
                    for (int i = 0; i < dtKOTA.Rows.Count; i++)
                    {
                        string idkota = dtKOTA.Rows[i]["IDKOTA"].ToString();
                        string namaareakota = dtKOTA.Rows[i]["NAMAAREA"].ToString();
                        string kodekota = dtKOTA.Rows[i]["KODEKOTA"].ToString();
                        string namakota = dtKOTA.Rows[i]["NAMAKOTA"].ToString();
                        dgvKOTA.Rows.Add(idkota, namaareakota, kodekota, namakota);
                    }
                }
            }

            if (rdbNAMA.Checked == true)
            {
                c.NAMAAREA = txtCARI.Text;
                DataTable dt = b.SEARCH_BYNAMAAREA(c);
                DataTable dtKOTA = b.SEARCH_BYNAMAAREAKOTA(c);
                dataPrint = new DataTable();
                dataPrint = dt;
                if (dt.Rows.Count > 0)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        string idarea = dt.Rows[i]["IDAREA"].ToString();
                        string kodearea = dt.Rows[i]["KODEAREA"].ToString();
                        string namaarea = dt.Rows[i]["NAMAAREA"].ToString();
                        dgvAREA.Rows.Add(idarea, kodearea, namaarea);
                    }
                }
                if (dtKOTA.Rows.Count > 0)
                {
                    for (int i = 0; i < dtKOTA.Rows.Count; i++)
                    {
                        string idkota = dtKOTA.Rows[i]["IDKOTA"].ToString();
                        string namaareakota = dtKOTA.Rows[i]["NAMAAREA"].ToString();
                        string kodekota = dtKOTA.Rows[i]["KODEKOTA"].ToString();
                        string namakota = dtKOTA.Rows[i]["NAMAKOTA"].ToString();
                        dgvKOTA.Rows.Add(idkota, namaareakota, kodekota, namakota);
                    }
                }
            }
        }

        private void FormKOTA_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F3)
            {
                rdbKODE.Checked = true;
                txtCARI.Text = "";
                txtCARI.Focus();
            }

            if (e.KeyCode == Keys.F4)
            {
                rdbNAMA.Checked = true;
                txtCARI.Text = "";
                txtCARI.Focus();
            }
            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }

        private void btnTAMBAH_Click(object sender, EventArgs e)
        {
            if (dgvAREA.SelectedCells.Count > 0)
            {
                string kodearea = dgvAREA.SelectedCells[0].OwningRow.Cells["KODEAREA"].Value.ToString();
                c.KODEAREA = kodearea;
                MASTER.SUBMASTER.FormKOTA frm = new LOGISTICMANAGAMENTSYSTEM.MASTER.SUBMASTER.FormKOTA(this, 0, c);
                frm.ShowDialog();

            }
        }

        private void btnEDIT_Click(object sender, EventArgs e)
        {
            if (dgvKOTA.SelectedCells.Count > 0)
            {

                string idkota = dgvKOTA.SelectedCells[0].OwningRow.Cells["IDKOTA"].Value.ToString();
                c.IDKOTA = int.Parse(idkota);
                MASTER.SUBMASTER.FormKOTA frm = new LOGISTICMANAGAMENTSYSTEM.MASTER.SUBMASTER.FormKOTA(this, 1, c);
                frm.ShowDialog();

            }
        }

        private void dgvKOTA_Click(object sender, EventArgs e)
        {

            if (dgvKOTA.SelectedCells.Count > 0)
            {
                int id = int.Parse(dgvKOTA.SelectedCells[0].OwningRow.Cells["IDKOTA"].Value.ToString());
                c.IDKOTA = id;
                LOAD_DATATERUSAN();
                lblTERUSAN.Text = dgvKOTA.SelectedCells[0].OwningRow.Cells["NAMAKOTA"].Value.ToString();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(lblTERUSAN.Text))
            {

                MessageBox.Show("SILAHKAN PILIH KOTA", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                dgvKOTA.Focus();
                return;

            }
            else
            {
               
                MASTER.SUBMASTER.FormTERUSAN frm = new LOGISTICMANAGAMENTSYSTEM.MASTER.SUBMASTER.FormTERUSAN(this, 0, c);
                frm.ShowDialog();
            }
        }

        private void btnHAPUS_Click(object sender, EventArgs e)
        {
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dgvTERUSAN.SelectedCells.Count > 0)
            {

                int id = int.Parse(dgvTERUSAN.SelectedCells[0].OwningRow.Cells["ID"].Value.ToString());
                string nama = dgvTERUSAN.SelectedCells[0].OwningRow.Cells["TERUSAN"].Value.ToString();

                c.IDTERUSAN = id;
                DialogResult dr = MessageBox.Show("APAKAH YAKIN AKAN DELETE DATA : " + nama + " ?", "WARNING", MessageBoxButtons.OKCancel, MessageBoxIcon.Stop);
                if (dr == DialogResult.OK)
                {
                    b.DELETETERUSAN(c);
                    LOAD_DATATERUSAN();
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

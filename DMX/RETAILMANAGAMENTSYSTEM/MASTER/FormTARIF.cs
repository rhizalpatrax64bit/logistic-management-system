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
    public partial class FormTARIF : Form
    {
        protected RMS.BUSSINES.MASTER.RMS_TARIF b = new RMS.BUSSINES.MASTER.RMS_TARIF();
        protected RMS.COMMON.MASTER.RMS_TARIF c = new RMS.COMMON.MASTER.RMS_TARIF();
        protected RMS.COMMON.GENERAL.RMS_COMBO combo = new RMS.COMMON.GENERAL.RMS_COMBO();
        protected RMS.BUSSINES.GENERAL.RMS_COMBO comboQuery = new RMS.BUSSINES.GENERAL.RMS_COMBO();

        
        int Type = 0;
        public FormTARIF()
        {
            InitializeComponent();
            loadCOMBO();
            LOAD_DATA();
            txtKODE.Text = GETKODE();
            txtKODE.ReadOnly = true;
        }
        void LOAD_DATA()
        {
            dgvTARIF.DataSource = null;
            dgvTARIF.Rows.Clear();
            DataTable dt = b.SELECT();
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    string id = dt.Rows[i]["IDTARIF"].ToString();
                    string kode = dt.Rows[i]["KODETARIF"].ToString();
                    string asal = dt.Rows[i]["KOTAASAL"].ToString();
                    string tujuan = dt.Rows[i]["KOTATUJUAN"].ToString();
                    string layanan = dt.Rows[i]["PRODUK"].ToString();
                    string jeniskiriman = dt.Rows[i]["JENISKIRIMAN"].ToString();
                    string tarif = dt.Rows[i]["TARIF"].ToString();
                    string tarifberikut = dt.Rows[i]["TARIFBERIKUT"].ToString();
                    string etd = dt.Rows[i]["ETD"].ToString();
                   
                    // string isaktif = dt.Rows[i]["isaktif"].ToString();


                    dgvTARIF.Rows.Add(id, kode, asal,tujuan,layanan,jeniskiriman,tarif,tarifberikut,etd);


                }
            }
        }

        public void GET_DATA_KOTA(RMS.COMMON.MASTER.RMS_KOTA obj, string _namaField)
        {
            if (_namaField == "ORIGIN")
            {
                txtKODEASAL.Text = obj.KODEKOTA;
                txtASAL.Text = obj.NAMAKOTA;
                c.IDKOTAASAL = obj.IDKOTA;

            }
            else
            {
                txtKODETUJUAN.Text = obj.KODEKOTA;
                txtTUJUAN.Text = obj.NAMAKOTA;
                c.IDKOTATUJUAN = obj.IDKOTA;
            }


        }
        public void loadCOMBO()
        {
            this.setCOMBO();

            DataRow drLAYANAN = ((DataRowView)cboLAYANAN.SelectedItem).Row;
            DataRow drJENISKIRIMAN = ((DataRowView)cboJENISKIRIMAN.SelectedItem).Row;

            c.IDJENISKIRIMAN = int.Parse(drJENISKIRIMAN["ID"].ToString());
            c.IDPRODUK = int.Parse(drLAYANAN["ID"].ToString());

        }
        public void setCOMBO()
        {
            DataTable dtJENISKIRIMAN = new DataTable();
            DataTable dtLAYANAN = new DataTable();


            dtJENISKIRIMAN = comboQuery.SELECTJENISKIRIMAN();
            dtLAYANAN = comboQuery.SELECTPRODUKEXPRESS();


            cboLAYANAN.DataSource = dtLAYANAN;
            cboLAYANAN.ValueMember = dtLAYANAN.Columns[0].ColumnName;
            cboLAYANAN.DisplayMember = dtLAYANAN.Columns[2].ColumnName;

            cboJENISKIRIMAN.DataSource = dtJENISKIRIMAN;
            cboJENISKIRIMAN.ValueMember = dtJENISKIRIMAN.Columns[0].ColumnName;
            cboJENISKIRIMAN.DisplayMember = dtJENISKIRIMAN.Columns[2].ColumnName;

        }
        public string GETKODE()
        {
            string newkode;
            int last_insert;
            int new_insert;
            DataTable dt = b.GETKODE();
            if (string.IsNullOrEmpty(dt.Rows[0]["LAST_ID"].ToString()))
            {
                last_insert = 0;
            }
            else
            {
                last_insert = int.Parse(dt.Rows[0]["LAST_ID"].ToString());
            }
            new_insert = last_insert + 1;
            if (new_insert < 10)
            {
                newkode = "TRF0" + new_insert;
            }
            else
            {
                newkode = "TRF" + new_insert;
            }

            return newkode;
        }
        private void btnASAL_Click(object sender, EventArgs e)
        {
            VIEW.FormVIEWKOTAEXPRESS frm = new LOGISTICMANAGAMENTSYSTEM.VIEW.FormVIEWKOTAEXPRESS(this, "ORIGIN", 1);
            frm.ShowDialog();
        }

        private void btnTUJUAN_Click(object sender, EventArgs e)
        {
            VIEW.FormVIEWKOTAEXPRESS frm = new LOGISTICMANAGAMENTSYSTEM.VIEW.FormVIEWKOTAEXPRESS(this, "DESTINATION", 1);
            frm.ShowDialog();
        }

        private void txtWEIGHT_KeyUp(object sender, KeyEventArgs e)
        {
            if (string.IsNullOrEmpty(txtTARIF.Text))
            {
                MessageBox.Show("MOHON ISI DENGAN ANGKA", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtTARIF.Focus();
                return;
            }
            System.Text.RegularExpressions.Regex nonNumericRegex = new System.Text.RegularExpressions.Regex(@"\D");
            if (nonNumericRegex.IsMatch(txtTARIF.Text))
            {
                MessageBox.Show("MOHON ISI DENGAN ANGKA", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtTARIF.Focus();
                return;
            }
        }

       
        private void txtTARIFBERIKUT_KeyUp(object sender, KeyEventArgs e)
        {
            if (string.IsNullOrEmpty(txtTARIF.Text))
            {
                MessageBox.Show("MOHON ISI DENGAN ANGKA", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtTARIF.Focus();
                return;
            }
            System.Text.RegularExpressions.Regex nonNumericRegex = new System.Text.RegularExpressions.Regex(@"\D");
            if (nonNumericRegex.IsMatch(txtTARIF.Text))
            {
                MessageBox.Show("MOHON ISI DENGAN ANGKA", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtTARIF.Focus();
                return;
            }
        }
        private void btnTAMBAH_Click(object sender, EventArgs e)
        {
            Type = 0;
        }

        private void btnEDIT_Click(object sender, EventArgs e)
        {
            if (dgvTARIF.SelectedCells.Count > 0)
            {

                int id = int.Parse(dgvTARIF.SelectedCells[0].OwningRow.Cells["ID"].Value.ToString());
                c.ID = id;
                DataTable dt = b.CARI_BYID(c);
                if (dt.Rows.Count > 0)
                {
                    c.ID = Convert.ToInt32(dt.Rows[0]["IDTARIF"].ToString());
                    c.KODE = dt.Rows[0]["KODETARIF"].ToString();
                    c.IDKOTAASAL = Convert.ToInt32(dt.Rows[0]["IDKOTAASAL"].ToString());
                    c.IDKOTATUJUAN = Convert.ToInt32(dt.Rows[0]["IDKOTATUJUAN"].ToString());
                    c.IDJENISKIRIMAN = Convert.ToInt32(dt.Rows[0]["IDJENISKIRIMAN"].ToString());
                    c.IDPRODUK = Convert.ToInt32(dt.Rows[0]["IDPRODUK"].ToString());
                    c.KODEKOTAASAL = dt.Rows[0]["KODEKOTAASAL"].ToString(); txtKODEASAL.Text = c.KODEKOTAASAL;
                    c.KODEKOTA = dt.Rows[0]["KODEKOTA"].ToString(); txtKODETUJUAN.Text = c.KODEKOTA;
                    c.KOTAASAL = dt.Rows[0]["KOTAASAL"].ToString(); txtASAL.Text = c.KOTAASAL;
                    c.KOTATUJUAN = dt.Rows[0]["KOTATUJUAN"].ToString(); txtTUJUAN.Text = c.KOTATUJUAN;
                    c.PRODUK = dt.Rows[0]["PRODUK"].ToString(); cboLAYANAN.Text = c.PRODUK;
                    c.JENISKIRIMAN = dt.Rows[0]["JENISKIRIMAN"].ToString(); cboJENISKIRIMAN.Text = c.JENISKIRIMAN;
                    c.TARIF = float.Parse(dt.Rows[0]["TARIF"].ToString()); txtTARIF.Text = Convert.ToString(c.TARIF);
                    c.TARIFBERIKUT = float.Parse(dt.Rows[0]["TARIFBERIKUT"].ToString()); txtTARIFBERIKUT.Text = Convert.ToString(c.TARIFBERIKUT);
                    c.ETD = dt.Rows[0]["ETD"].ToString(); txtETD.Text = c.ETD;
                    c.KETERANGAN = dt.Rows[0]["KETERANGAN"].ToString(); txtKETERANGAN.Text = c.KETERANGAN;
                   
                    Type = 1;
                }

            }
        }

        private void btnHAPUS_Click(object sender, EventArgs e)
        {
            
            if (dgvTARIF.SelectedCells.Count > 0)
            {
                int id = Convert.ToInt32(dgvTARIF.SelectedCells[0].OwningRow.Cells["ID"].Value.ToString());
                string kode = dgvTARIF.SelectedCells[0].OwningRow.Cells["KODE"].Value.ToString();
                c.ID = id;
                DialogResult dr = MessageBox.Show("APAKAH YAKIN AKAN DELETE DATA TARIF  : " + kode + " ?", "WARNING", MessageBoxButtons.OKCancel, MessageBoxIcon.Stop);
                if (dr == DialogResult.OK)
                {
                    b.DELETE(c);
                    LOAD_DATA();
                }
            }
             
        }

        private void btnSIMPAN_Click(object sender, EventArgs e)
        {
            
            if (string.IsNullOrEmpty(txtKODEASAL.Text))
            {
                MessageBox.Show("ISI KOTA ASAL", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtKODEASAL.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txtKODETUJUAN.Text))
            {
                MessageBox.Show("ISI KOTA TUJUAN", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtKODETUJUAN.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txtTARIF.Text))
            {
                MessageBox.Show("ISI TARIF / KG", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtTARIF.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txtTARIFBERIKUT.Text))
            {
                MessageBox.Show("ISI TARIF BERIKUT/ KG", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtTARIFBERIKUT.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txtETD.Text))
            {
                MessageBox.Show("ISI Estimate Days (ETD)", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtETD.Focus();
                return;
            }
            c.KODE = txtKODE.Text;
            c.KETERANGAN = txtKETERANGAN.Text;
            c.ETD = txtETD.Text;
            c.TARIF = float.Parse(txtTARIF.Text);
            c.TARIFBERIKUT = float.Parse(txtTARIFBERIKUT.Text);
            c.ISACTIVE = true;


            if (Type == 0)
            {
                b.INSERT(c);
                this.LOAD_DATA();
                Type = 0;
            }
            else
            {

                b.UPDATE(c);
                this.LOAD_DATA();
                Type = 1;
            }
            CLEAR();
            
        }
        void CLEAR()
        {
            txtKODEASAL.Text = "";
            txtKODETUJUAN.Text = "";
            txtASAL.Text = "";
            txtTUJUAN.Text = "";
            txtTARIF.Text = "0";
            txtTARIFBERIKUT.Text = "0";
            txtETD.Text = "";
            txtKETERANGAN.Text = "";


        }
        private void btnBATAL_Click(object sender, EventArgs e)
        {
            CLEAR();
            LOAD_DATA();
        }

        private void btnKELUAR_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cboLAYANAN_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!cboLAYANAN.Focused)
            {
                return;
            }
            else
            {
                DataRow selectedDataRow = ((DataRowView)cboLAYANAN.SelectedItem).Row;
                c.IDPRODUK = Convert.ToInt32(cboLAYANAN.SelectedValue);

            }
        }

        private void cboJENISKIRIMAN_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!cboJENISKIRIMAN.Focused)
            {
                return;
            }
            else
            {
                DataRow selectedDataRow = ((DataRowView)cboJENISKIRIMAN.SelectedItem).Row;
                c.IDJENISKIRIMAN = Convert.ToInt32(cboJENISKIRIMAN.SelectedValue);

            }
        }

        private void txtCARI_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtCARI_KeyUp(object sender, KeyEventArgs e)
        {
            dgvTARIF.DataSource = null;
            dgvTARIF.Rows.Clear();

            c.KOTATUJUAN = txtCARI.Text;
            c.PRODUK = txtCARI.Text;
            c.JENISKIRIMAN = txtCARI.Text;

            DataTable dt = b.SEARCHLIKE(c);
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    string id = dt.Rows[i]["IDTARIF"].ToString();
                    string kode = dt.Rows[i]["KODETARIF"].ToString();
                    string asal = dt.Rows[i]["KOTAASAL"].ToString();
                    string tujuan = dt.Rows[i]["KOTATUJUAN"].ToString();
                    string layanan = dt.Rows[i]["PRODUK"].ToString();
                    string jeniskiriman = dt.Rows[i]["JENISKIRIMAN"].ToString();
                    string tarif = dt.Rows[i]["TARIF"].ToString();
                    string tarifberikut = dt.Rows[i]["TARIFBERIKUT"].ToString();
                    string etd = dt.Rows[i]["ETD"].ToString();

                    // string isaktif = dt.Rows[i]["isaktif"].ToString();


                    dgvTARIF.Rows.Add(id, kode, asal, tujuan, layanan, jeniskiriman, tarif, tarifberikut, etd);


                }
            }

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LOGISTICMANAGAMENTSYSTEM.EXPRESS
{
    public partial class FormENTRYPENGIRIMANBARANG : Form
    {
        protected RMS.BUSSINES.EXPRESS.RMS_SPJ b = new RMS.BUSSINES.EXPRESS.RMS_SPJ();
        protected RMS.COMMON.EXPRESS.RMS_SPJ c = new RMS.COMMON.EXPRESS.RMS_SPJ();

        protected RMS.BUSSINES.MASTER.RMS_KOTA bKOTA = new RMS.BUSSINES.MASTER.RMS_KOTA();
        protected RMS.COMMON.MASTER.RMS_KOTA cKOTA = new RMS.COMMON.MASTER.RMS_KOTA();

        protected RMS.BUSSINES.MASTER.RMS_TARIF bTARIF = new RMS.BUSSINES.MASTER.RMS_TARIF();
        protected RMS.COMMON.MASTER.RMS_TARIF cTARIF = new RMS.COMMON.MASTER.RMS_TARIF();
        protected RMS.COMMON.MASTER.RMS_TENTANGPERUSAHAAN cPersusahaan = new RMS.COMMON.MASTER.RMS_TENTANGPERUSAHAAN();
        protected RMS.BUSSINES.MASTER.RMS_TENTANGPERUSAHAAN bPersusahaan = new RMS.BUSSINES.MASTER.RMS_TENTANGPERUSAHAAN();
        string kodePerusahaan, namaPerusahaan, alamatPerusahaan, telpPerusahaan, faxPerusahaan;

        DataTable dataPrint;
        EXPRESS.FormDAFTARPENGIRIMANBARANG frm;
        int Type = 0;
        DataTable dtDETAIL;
        public FormENTRYPENGIRIMANBARANG(EXPRESS.FormDAFTARPENGIRIMANBARANG _frm, int _Type,
                                    RMS.COMMON.EXPRESS.RMS_SPJ obj, RMS.COMMON.MASTER.RMS_USER user)
        {
            InitializeComponent();
            frm = _frm;
            Type = _Type;
            if (Type == 0)
            {
               
                txtSPJ.Text = GETKODE();
            }
            else
            {
               // update coy 
                c.ID = obj.ID;
                INIT_PERUSAHAAN();
                LOAD_DATA(obj);
                LOAD_DETAIL();                               

            }
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
            dataPrint.Columns.Add("NOSPJ", typeof(string));
            dataPrint.Columns.Add("TGLKIRIM", typeof(string));
            dataPrint.Columns.Add("NOPOL", typeof(string));
            dataPrint.Columns.Add("DRIVER", typeof(string));
            dataPrint.Columns.Add("HELPER", typeof(string));
            dataPrint.Columns.Add("JENISKENDARAAN", typeof(string));
            dataPrint.Columns.Add("BERATMUATAN", typeof(string));
            dataPrint.Columns.Add("VOLUME", typeof(string));
            dataPrint.Columns.Add("STATUSKENDARAAN", typeof(string));
            dataPrint.Columns.Add("STATUSRESI", typeof(string));
            dataPrint.Columns.Add("NORESI", typeof(string));
            dataPrint.Columns.Add("PENERIMA", typeof(string));
            dataPrint.Columns.Add("ALAMAT", typeof(string));
            dataPrint.Columns.Add("NAMALAYANAN", typeof(string));
            dataPrint.Columns.Add("JENISKIRIMAN", typeof(string));
            dataPrint.Columns.Add("BERAT", typeof(string));
            dataPrint.Columns.Add("JUMLAH", typeof(string));
            dataPrint.Columns.Add("TARIF", typeof(string));
            dataPrint.Columns.Add("ETD", typeof(string));
            dataPrint.Columns.Add("NAMAPERUSAHAAN", typeof(string));
            dataPrint.Columns.Add("ALAMATPERUSAHAAN", typeof(string));
            dataPrint.Columns.Add("TELPPERUSAHAAN", typeof(string));
            dataPrint.Columns.Add("FAXPERUSAHAAN", typeof(string));


        }
        void LOAD_DATA(RMS.COMMON.EXPRESS.RMS_SPJ obj)
        {

            DataTable dt = b.CARI_BYID(obj);
            
            if (dt.Rows.Count > 0)
            {
                string TGLPENGIRIMAN;
                c.IDKENDARAAN = Convert.ToInt32(dt.Rows[0]["IDKENDARAAN"].ToString());
                txtSPJ.Text = dt.Rows[0]["NOSPJ"].ToString();
                TGLPENGIRIMAN = dt.Rows[0]["TGLPENGIRIMAN"].ToString();
                dtTGLKIRIM.Value = DateTime.Parse(TGLPENGIRIMAN);
                txtNOPOL.Text = dt.Rows[0]["NOPOL"].ToString();
                txtJENISKENDARAAN.Text = dt.Rows[0]["JENISKENDARAAN"].ToString();
                txtMAXMUATAN.Text = dt.Rows[0]["MAXMUATAN"].ToString();
                txtMAXVOLUME.Text = dt.Rows[0]["MAXVOLUME"].ToString();
                if (!string.IsNullOrEmpty(dt.Rows[0]["IDDRIVER"].ToString()))
                { c.IDDRIVER = Convert.ToInt32(dt.Rows[0]["IDDRIVER"].ToString()); }
                if (!string.IsNullOrEmpty(dt.Rows[0]["IDCODRIVER"].ToString()))
                {
                  c.IDCODRIVER = Convert.ToInt32(dt.Rows[0]["IDCODRIVER"].ToString());
                }
                txtKODEDRIVER.Text = dt.Rows[0]["KODEDRIVER"].ToString();
                txtKODEHELPER.Text = dt.Rows[0]["KODEHELPER"].ToString();
                txtNAMADRIVER.Text = dt.Rows[0]["NAMADRIVER"].ToString();
                txtNAMAHELPER.Text = dt.Rows[0]["NAMAHELPER"].ToString();
                
            }
        }
        public void LOAD_DETAILEDIT()
        {
            dgvRESI.DataSource = null;
            dgvRESI.Rows.Clear();

            c.NOSPJ = txtSPJ.Text;
           
            int TWEIGHT = 0;
            int TPCS = 0;
            if (dtDETAIL.Rows.Count > 0)
            {
                for (int i = 0; i < dtDETAIL.Rows.Count; i++)
                {
                    // INI DARI TABLE spj_detail, jangan sampai salah penamaan row nya
                    string ALAMATDETAIL;
                    string ID = dtDETAIL.Rows[i]["IDSPJDETAIL"].ToString();
                    string STATUS = dtDETAIL.Rows[i]["STATUS"].ToString();
                    string NORESI = dtDETAIL.Rows[i]["NORESI"].ToString();
                    string PENERIMA = dtDETAIL.Rows[i]["NAMAPENERIMA"].ToString();
                    string ALAMAT = dtDETAIL.Rows[i]["ALAMATPENERIMA"].ToString();
                    string TELEPON = dtDETAIL.Rows[i]["TELEPONPENERIMA"].ToString();
                    string FAX = dtDETAIL.Rows[i]["FAXPENERIMA"].ToString();
                    string HP = dtDETAIL.Rows[i]["HPPENERIMA"].ToString();
                    string EMAIL = dtDETAIL.Rows[i]["EMAILPENERIMA"].ToString();
                    ALAMATDETAIL = "Alamat :" + ALAMAT + ", Telp :" + TELEPON + ", Fax :" + FAX + ", Hp :" + HP + ", Email :" + EMAIL;
                    string NAMALAYANAN = dtDETAIL.Rows[i]["NAMALAYANAN"].ToString();
                    string JENISKIRIMAN = dtDETAIL.Rows[i]["JENISKIRIMAN"].ToString();
                    string BERAT = dtDETAIL.Rows[i]["BERAT"].ToString();
                    string JUMLAH = dtDETAIL.Rows[i]["JUMLAH"].ToString();
                    string TOTAL = dtDETAIL.Rows[i]["TOTAL"].ToString();
                    string ETD = dtDETAIL.Rows[i]["ETD"].ToString();
                    dgvRESI.Rows.Add(ID, STATUS,NORESI,PENERIMA,ALAMATDETAIL, NAMALAYANAN, JENISKIRIMAN, BERAT, JUMLAH, TOTAL, ETD);
                    TWEIGHT += int.Parse(BERAT);
                    TPCS += int.Parse(JUMLAH);
                    txtTBERAT.Text = TWEIGHT.ToString("N0");
                    txtTJUMLAH.Text = TPCS.ToString("N0");

                }

            }
        }
        public void LOAD_DETAIL()
        {
            dgvRESI.DataSource = null;
            dgvRESI.Rows.Clear();
            
            c.NOSPJ = txtSPJ.Text;
            if (Type == 1)
            {
                dtDETAIL = b.SELECTRESI(c);

                // ini jika sudah ditambahkan dari form tambah resi gmanuk
            }
            SET_PRINT();
            //dtDETAIL.Rows.Add(dr);
            int TWEIGHT = 0;
            int TPCS = 0;
            int no_urut = 1;
            if (dtDETAIL.Rows.Count > 0)
            {
                for (int i = 0; i < dtDETAIL.Rows.Count; i++)
                {
                    string ALAMATDETAIL;
                    string ID = dtDETAIL.Rows[i]["IDSPJDETAIL"].ToString();
                    string STATUS = dtDETAIL.Rows[i]["STATUS"].ToString();
                    string NORESI = dtDETAIL.Rows[i]["NORESI"].ToString();
                    string PENERIMA = dtDETAIL.Rows[i]["NAMAPENERIMA"].ToString();
                    string ALAMAT = dtDETAIL.Rows[i]["ALAMATPENERIMA"].ToString();
                    string TELEPON = dtDETAIL.Rows[i]["TELEPONPENERIMA"].ToString();
                    string FAX = dtDETAIL.Rows[i]["FAXPENERIMA"].ToString();
                    string HP = dtDETAIL.Rows[i]["HPPENERIMA"].ToString();
                    string EMAIL = dtDETAIL.Rows[i]["EMAILPENERIMA"].ToString();
                    ALAMATDETAIL = "Alamat :" + ALAMAT + ", Telp :" + TELEPON + ", Fax :" + FAX + ", Hp :" + HP + ", Email :" + EMAIL;
                    string NAMALAYANAN = dtDETAIL.Rows[i]["NAMALAYANAN"].ToString();
                    string JENISKIRIMAN = dtDETAIL.Rows[i]["JENISKIRIMAN"].ToString();
                    string BERAT = dtDETAIL.Rows[i]["BERAT"].ToString();
                    string JUMLAH = dtDETAIL.Rows[i]["JUMLAH"].ToString();
                    string TOTAL = dtDETAIL.Rows[i]["TOTAL"].ToString();
                    string ETD = dtDETAIL.Rows[i]["ETD"].ToString();
                    dgvRESI.Rows.Add(ID,STATUS,NORESI,PENERIMA,ALAMATDETAIL, NAMALAYANAN, JENISKIRIMAN, BERAT, JUMLAH, TOTAL, ETD);
                    string tglKirim = dtTGLKIRIM.Value.ToString("yyyy-MM-dd");
                    dataPrint.Rows.Add(no_urut, txtSPJ.Text, tglKirim, txtNOPOL.Text, txtNAMADRIVER.Text, txtNAMAHELPER.Text, txtJENISKENDARAAN.Text,
                        txtMAXMUATAN.Text, txtMAXVOLUME.Text, txtSTATUS.Text,STATUS,
                        NORESI, PENERIMA, ALAMATDETAIL, NAMALAYANAN, JENISKIRIMAN, BERAT, JUMLAH, TOTAL, ETD, namaPerusahaan, alamatPerusahaan, telpPerusahaan, faxPerusahaan);
                    TWEIGHT += int.Parse(BERAT);
                    TPCS += int.Parse(JUMLAH);
                    txtTBERAT.Text = TWEIGHT.ToString("N0");
                    txtTJUMLAH.Text = TPCS.ToString("N0");
                    no_urut=no_urut+1;
                }

            }

        }
        public void GET_DATA_DRIVER(RMS.COMMON.MASTER.RMS_DRIVER obj, string _namaField)
        {
            if (_namaField == "DRIVER")
            {
                c.IDDRIVER = obj.ID;
                txtKODEDRIVER.Text = obj.KODE;
                txtNAMADRIVER.Text = obj.NAMA;


            }
            else
            {
                c.IDCODRIVER = obj.ID;
                txtKODEHELPER.Text = obj.KODE;
                txtNAMAHELPER.Text = obj.NAMA;                
            }


        }
        public void GET_DATA_KENDARAAN(RMS.COMMON.MASTER.RMS_KENDARAAN obj)
        {
            //c.ID = obj.ID;
            c.IDKENDARAAN = obj.ID;
            c.IDDRIVER = obj.IDDRIVER;
            c.IDCODRIVER = obj.IDHELPER;
            txtNOPOL.Text = obj.NOPOL;
            txtJENISKENDARAAN.Text = obj.JENISKENDARAAN;
            txtMAXMUATAN.Text = obj.MAXMUATAN.ToString();
            txtMAXVOLUME.Text = obj.MAXVOLUME.ToString();
            txtSTATUS.Text = obj.STATUSKENDARAAN.ToString();

            txtKODEDRIVER.Text = obj.KODEDRIVER;
            txtKODEHELPER.Text = obj.KODEHELPER;
            txtNAMADRIVER.Text = obj.NAMADRIVER;
            txtNAMAHELPER.Text = obj.NAMAHELPER;
          
        }
        public void GET_DETAIL(DataTable dt, int pass)
        {
            // 1 itu dari insert
            // 2 jika ada edit, dan ditambahkan dari datarow form pilih resi
            if (pass == 1)
            {
                dtDETAIL = dt;
                LOAD_DETAIL();
            }
            else
            {
                LOAD_DETAILEDIT();
            }

        }
        public string GETKODE()
        {
            string newkode;

            DataTable dt = b.GETKODE();
            if (string.IsNullOrEmpty(dt.Rows[0][0].ToString()))
            {
                newkode = "kosong";
            }
            else
            {
                newkode = dt.Rows[0][0].ToString();
            }


            return newkode;
        }
        private void txtNOPOL_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                VIEW.FormVIEWKENDARAAN frm = new LOGISTICMANAGAMENTSYSTEM.VIEW.FormVIEWKENDARAAN(this, 1);
                frm.ShowDialog();

            }
        }

        private void txtKODEDRIVER_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                VIEW.FormDRIVERHELPER frm = new LOGISTICMANAGAMENTSYSTEM.VIEW.FormDRIVERHELPER(null, this, "DRIVER", 2);
                frm.ShowDialog();
            }
        }

        private void txtKODEHELPER_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                VIEW.FormDRIVERHELPER frm = new LOGISTICMANAGAMENTSYSTEM.VIEW.FormDRIVERHELPER(null, this, "HELPER", 2);
                frm.ShowDialog();
            }
        }

        private void btnCARI_Click(object sender, EventArgs e)
        {
            VIEW.FormVIEWPENERIMAANBARANG frm;
            if (Type == 0)
            {
                frm = new LOGISTICMANAGAMENTSYSTEM.VIEW.FormVIEWPENERIMAANBARANG(this, dtDETAIL, 1);
            }
            else
            {
                 frm = new LOGISTICMANAGAMENTSYSTEM.VIEW.FormVIEWPENERIMAANBARANG(this, dtDETAIL,2);
            }
            frm.ShowDialog();
        }

        private void btnTAMBAH_Click(object sender, EventArgs e)
        {
            #region CEK BY RICEK

            if (string.IsNullOrEmpty(txtSPJ.Text))
            {
                MessageBox.Show("ISI NO SPJ", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtSPJ.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txtNOPOL.Text))
            {
                MessageBox.Show("ISI NO POLISI", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtNOPOL.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txtNOPOL.Text))
            {
                MessageBox.Show("ISI NO POLISI", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtNOPOL.Focus();
                return;
            }
            
            if (string.IsNullOrEmpty(txtKODEDRIVER.Text))
            {
                MessageBox.Show("APAKAH ANDA YAKIN, TANPA MENGGUNAKAN DRIVER", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtKODEDRIVER.Focus();
                c.IDDRIVER = 0;
            }
            if (string.IsNullOrEmpty(txtKODEHELPER.Text))
            {
                MessageBox.Show("APAKAH ANDA YAKIN, TANPA MENGGUNAKAN HELPER", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtKODEDRIVER.Focus();
                c.IDCODRIVER = 0;
                //return;
            }
            #endregion
            c.NOSPJ = txtSPJ.Text;
            c.TGLPENGIRIMAN = dtTGLKIRIM.Value.ToString("yyyy-MM-dd");
            if (Type == 0)
            {
             
                // looping untuk insert detail spj
                if (dgvRESI.RowCount > 0)
                {
                    DialogResult dr = MessageBox.Show("APAKAH YAKIN AKAN MEMBUAT SPJ  : " + c.NOSPJ + " ?", "WARNING", MessageBoxButtons.OKCancel, MessageBoxIcon.Stop);
                    if (dr == DialogResult.OK)
                    {
                        b.INSERT(c); // insert SPJ
                    }

                    // insert detail resi bwt spi kehed
                    foreach (DataGridViewRow row in dgvRESI.Rows)
                    {
                        c.NORESI = row.Cells["NORESI"].Value.ToString();
                        b.INSERTRESI(c);
                        //merubah status resi // menjadi 10 STATUS DELIVERY
                        c.STATUS = 10;
                        b.UPDATESTATUSPENGIRIMAN(c);

                    }
                }
                else
                {
                    MessageBox.Show("SILAHKAN MASUKAN PACKING LIST", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    dgvRESI.Focus();
                    return;
                }
                this.frm.LOAD_DATA();

            }
            else
            {
                b.UPDATE(c);
                // update detail kmha mang
                // check dlu di database reference resi di grid, jika ga ada libas insert, jika ada abaikan
                // check datagrid jika id detail null libas insert
                foreach (DataGridViewRow row in dgvRESI.Rows)
                {
                    // gv.Rows[i][column1].Tostring();
                    //int test = int.Parse(row.Cells["IDSPJDETAIL"].Value.ToString());
                    if (string.IsNullOrEmpty(row.Cells["IDDETAIL"].Value.ToString()))
                    {
                        c.NORESI = row.Cells["NORESI"].Value.ToString();
                        b.INSERTRESI(c);
                        //merubah status resi // menjadi 10 STATUS DELIVERY
                        c.STATUS = 10;
                        b.UPDATESTATUSPENGIRIMAN(c);
                        
                    }
                }
                
                this.frm.LOAD_DATA();
            }
            Close();
        }

        private void btnBATALMUAT_Click(object sender, EventArgs e)
        {
            if (dgvRESI.SelectedCells.Count > 0)
            {
                

                if (Type != 0)
                {
                    // CHECK ID DETAIL NULL HANYA REMOVE DATATABLE
                    if(!string.IsNullOrEmpty(dgvRESI.SelectedCells[0].OwningRow.Cells["IDDETAIL"].Value.ToString()))
                    {
                         c.IDDETAIL = int.Parse(dgvRESI.SelectedCells[0].OwningRow.Cells["IDDETAIL"].Value.ToString());
                         c.STATUS = 1;
                         c.NORESI = dgvRESI.SelectedCells[0].OwningRow.Cells["NORESI"].Value.ToString();
                        DialogResult dr = MessageBox.Show("APAKAH YAKIN AKAN DELETE DATA : " + c.NORESI + " ?", "WARNING", MessageBoxButtons.OKCancel, MessageBoxIcon.Stop);
                        if (dr == DialogResult.OK)
                        {
                            b.DELETE(c);
                            b.UPDATESTATUSPENGIRIMAN(c);
                            // ini juga harus merubah status resi MENJADI 1 BALIKIN LAGI KE MANIFEST
                            LOAD_DETAIL();
                        }
                    }
                    else
                    {
                        int selectedIndex = dgvRESI.CurrentCell.RowIndex;
                        // remove dt table
                        dgvRESI.Rows.RemoveAt(selectedIndex);
                      //  LOAD_DETAILEDIT();
                    }
                    
                    
                }
                else
                {
                    int selectedIndex = dgvRESI.CurrentCell.RowIndex;
                    // remove dt table
                    dgvRESI.Rows.RemoveAt(selectedIndex);
                }

            }
            
        }

        private void dgvRESI_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           // VIEW.FormVIEWMISSROUTE frm = new LOGISTICMANAGAMENTSYSTEM.VIEW.FormVIEWMISSROUTE();
            //frm.ShowDialog();
        }

        private void dgvRESI_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvRESI.SelectedCells.Count > 0)
            {
                c.NORESI = dgvRESI.SelectedCells[0].OwningRow.Cells["NORESI"].Value.ToString();

                VIEW.FormVIEWMISSROUTE frm = new LOGISTICMANAGAMENTSYSTEM.VIEW.FormVIEWMISSROUTE(this,c, 1);
                frm.ShowDialog();
            }
        }
        void CETAK()
        {
            TopMost = false;
            REPORTS.EXPRESS.FormViewerCETAKSPJ frm = new REPORTS.EXPRESS.FormViewerCETAKSPJ(dataPrint);
            frm.WindowState = FormWindowState.Normal;
            frm.BringToFront();
            frm.ShowDialog();
           
        }
        private void btnCetak_Click(object sender, EventArgs e)
        {
            CETAK();
        }

        private void btnEDIT_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

      
    }
}

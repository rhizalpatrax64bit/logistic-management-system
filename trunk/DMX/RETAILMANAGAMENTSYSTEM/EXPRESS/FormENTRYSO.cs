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
    public partial class FormENTRYSO : Form
    {
       // BarcodeLib.Barcode b = new BarcodeLib.Barcode();
        protected RMS.BUSSINES.EXPRESS.RMS_TRANSAKSI b = new RMS.BUSSINES.EXPRESS.RMS_TRANSAKSI();
        protected RMS.COMMON.EXPRESS.RMS_TRANSAKSI c = new RMS.COMMON.EXPRESS.RMS_TRANSAKSI();

        protected RMS.BUSSINES.MASTER.RMS_KOTA bKOTA = new RMS.BUSSINES.MASTER.RMS_KOTA();
        protected RMS.COMMON.MASTER.RMS_KOTA cKOTA = new RMS.COMMON.MASTER.RMS_KOTA();

        protected RMS.BUSSINES.MASTER.RMS_TARIF bTARIF = new RMS.BUSSINES.MASTER.RMS_TARIF();
        protected RMS.COMMON.MASTER.RMS_TARIF cTARIF = new RMS.COMMON.MASTER.RMS_TARIF();
        protected RMS.COMMON.MASTER.RMS_TENTANGPERUSAHAAN cPersusahaan = new RMS.COMMON.MASTER.RMS_TENTANGPERUSAHAAN();
        protected RMS.BUSSINES.MASTER.RMS_TENTANGPERUSAHAAN bPersusahaan = new RMS.BUSSINES.MASTER.RMS_TENTANGPERUSAHAAN();
        string kodePerusahaan, namaPerusahaan, alamatPerusahaan, telpPerusahaan, faxPerusahaan;
           

        
        EXPRESS.FormDAFTARSO frm;
        int Type = 0;
        int checkIDTARIF;
        DataTable dataPrint;
        public FormENTRYSO(EXPRESS.FormDAFTARSO _frm, int _Type,
                                    RMS.COMMON.EXPRESS.RMS_TRANSAKSI obj, RMS.COMMON.MASTER.RMS_USER user)
        {
            InitializeComponent();
            INIT_PERUSAHAAN();
            frm = _frm;
            Type = _Type;
            if (Type == 0)
            {
                cboINSURANCE.Text = "0";
                setDIM();
                ptbASAL.Visible = false;
                ptbTUJUAN.Visible = false;
                txtNORESI.Text = GETKODE();
            }
            else
            {
                c.ID = obj.ID;               
                LOAD_DATA(obj);

            }
            SET_PRINT();
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

            dataPrint.Columns.Add("NORESI", typeof(string));
            dataPrint.Columns.Add("ASAL", typeof(string));
            dataPrint.Columns.Add("TUJUAN", typeof(string));
            dataPrint.Columns.Add("BERAT", typeof(string));
            dataPrint.Columns.Add("JUMLAH", typeof(string));
            dataPrint.Columns.Add("PENGIRIM", typeof(string));
            dataPrint.Columns.Add("ALAMATPENGIRIM", typeof(string));
            dataPrint.Columns.Add("PHONEPENGIRIM", typeof(string));
            dataPrint.Columns.Add("PENERIMA", typeof(string));
            dataPrint.Columns.Add("ALAMATPENERIMA", typeof(string));
            dataPrint.Columns.Add("PHONEPENERIMA", typeof(string));
            dataPrint.Columns.Add("LAYANAN", typeof(string));
            dataPrint.Columns.Add("HARGA", typeof(string));
            dataPrint.Columns.Add("JENISKIRIMAN", typeof(string));
            dataPrint.Columns.Add("ASURANSI", typeof(string));
            dataPrint.Columns.Add("PPN", typeof(string));
            dataPrint.Columns.Add("JUMLAHTOTAL", typeof(string));
            dataPrint.Columns.Add("KETERANGANISI", typeof(string));
            dataPrint.Columns.Add("INSTRUKSIKHUSUS", typeof(string));
            dataPrint.Columns.Add("DIM_P", typeof(string));
            dataPrint.Columns.Add("DIM_L", typeof(string));
            dataPrint.Columns.Add("DIM_T ", typeof(string));
            dataPrint.Columns.Add("HPPENGIRIM ", typeof(string));
            dataPrint.Columns.Add("PACKING ", typeof(string));
            dataPrint.Columns.Add("BARCODE ", typeof(byte[]));
            dataPrint.Columns.Add("NAMAPERUSAHAAN", typeof(string));
            dataPrint.Columns.Add("ALAMATPERUSAHAAN", typeof(string));
            dataPrint.Columns.Add("TELPPERUSAHAAN", typeof(string));
            dataPrint.Columns.Add("FAXPERUSAHAAN", typeof(string));
            dataPrint.Columns.Add("TGLMANIFEST", typeof(string));
            dataPrint.Columns.Add("ETD", typeof(string));



        }

        private void FormENTRYSO_Load(object sender, EventArgs e)
        {
           
            GetAutoSourceKOTA();
            txtSFROM.AutoCompleteCustomSource = GetAutoSourceKOTA();
            txtSFROM.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtSFROM.AutoCompleteSource = AutoCompleteSource.CustomSource;

            txtSTO.AutoCompleteCustomSource = GetAutoSourceKOTA();
            txtSTO.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtSTO.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        private void btnHitung_Click(object sender, EventArgs e)
        {
           
            LOAD_TARIF();
        }            
        private void txtKODECUSTOMER_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                VIEW.FormCUSTOMEREXPRESS frm = new LOGISTICMANAGAMENTSYSTEM.VIEW.FormCUSTOMEREXPRESS(this, 1);
                frm.ShowDialog();
               
            }
        }       
        private void btnTAMBAHPENERIMA_Click(object sender, EventArgs e)
        {
            VIEW.FormTAMBAHPENERIMA frm = new LOGISTICMANAGAMENTSYSTEM.VIEW.FormTAMBAHPENERIMA(null, this, 2);
            frm.ShowDialog();
        }
        private void btnSEARCHPENERIMA_Click(object sender, EventArgs e)
        {
            VIEW.FormVIEWPENERIMA frm = new LOGISTICMANAGAMENTSYSTEM.VIEW.FormVIEWPENERIMA(null,this, 2);
            frm.ShowDialog();
        }
        private void txtSFROM_Leave(object sender, EventArgs e)
        {
            string kode = txtSFROM.Text;
            cKOTA.KODEKOTA = kode;
            cKOTA.NAMAKOTA = kode;
            DataTable dt = bKOTA.GETKOTA(cKOTA);
            if (dt.Rows.Count > 0)
            {                
                    ptbASAL.Visible = true;                    
                                
            }
            else
            {
                DialogResult dr = MessageBox.Show("KODE KOTA YANG ANDA MASUKAN SALAH : ", "WARNING", MessageBoxButtons.OKCancel, MessageBoxIcon.Stop);
                if (dr == DialogResult.OK)
                {
                    ptbASAL.Visible = false;
                    txtSFROM.Focus();

                }

            }    
        }
        private void txtSTO_Leave(object sender, EventArgs e)
        {
            string kode = txtSFROM.Text;
            cKOTA.KODEKOTA = kode;
            cKOTA.NAMAKOTA = kode;
            DataTable dt = bKOTA.GETKOTA(cKOTA);
            if (dt.Rows.Count > 0)
            {
                ptbTUJUAN.Visible = true;

            }
            else
            {
                DialogResult dr = MessageBox.Show("KODE KOTA YANG ANDA MASUKAN SALAH : ", "WARNING", MessageBoxButtons.OKCancel, MessageBoxIcon.Stop);
                if (dr == DialogResult.OK)
                {
                    ptbTUJUAN.Visible = false;
                    txtSTO.Focus();

                }


            } 
        }
        private void txtSWIGHT_Leave(object sender, EventArgs e)
        {

            if (!isNumeric(txtWEIGHT.Text, System.Globalization.NumberStyles.Float) || (String.IsNullOrEmpty(txtWEIGHT.Text)))
            {
                MessageBox.Show("ISI FIELD DENGAN BENAR", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtWEIGHT.Text = "0";
                return;
            }
            txtWEIGHT.Text = txtSWIGHT.Text;
            if (c.IDTARIF != 0)
            {
                hitungTotal();
                clearPEMBAYARAN();
                hitungGrandTotal();
                
            }
        }
        private void dgvTARIF_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                PILIHLAYANAN();
            }

        }
        void PILIHLAYANAN()
        {
            
                if (txtWEIGHT.Text == "0")
                {
                    MessageBox.Show("Silahkan isikan berat kiriman", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    txtWEIGHT.Text = "0";
                    return;

                }
                else
                {
                    c.IDTARIF = Convert.ToInt32(dgvTARIF.SelectedCells[0].OwningRow.Cells["ID"].Value.ToString());
                    txtRATEKIRIM.Text = dgvTARIF.SelectedCells[0].OwningRow.Cells["TARIFF"].Value.ToString();
                    lblFROM.Text = txtSFROM.Text;
                    lblTO.Text = txtSTO.Text;
                    lblLAYANAN.Text = dgvTARIF.SelectedCells[0].OwningRow.Cells["NAMALAYANAN"].Value.ToString();
                    lblJENISKIRIMAN.Text = dgvTARIF.SelectedCells[0].OwningRow.Cells["JENISKIRIMAN"].Value.ToString();
                    hitungTotal();
                    hitungGrandTotal();
                }
            
         
        }
        private void txtWEIGHT_KeyUp(object sender, KeyEventArgs e)
        {
            if (string.IsNullOrEmpty(txtWEIGHT.Text))
            {
                MessageBox.Show("MOHON ISI DENGAN ANGKA", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtWEIGHT.Text = "0";
                txtWEIGHT.Focus();
                return;
            }
            System.Text.RegularExpressions.Regex nonNumericRegex = new System.Text.RegularExpressions.Regex(@"\D");
            if (nonNumericRegex.IsMatch(txtTDIM.Text))
            {
                MessageBox.Show("MOHON ISI DENGAN ANGKA", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtWEIGHT.Text = "0";
                txtWEIGHT.Focus();
                return;
            }
            hitungTotal();
            hitungGrandTotal();
            
        }       
        private void chkISDIM_CheckedChanged(object sender, EventArgs e)
        {
            if (chkISDIM.Checked == true)
            {
                txtWEIGHT.ReadOnly = true;
                txtWEIGHT.BackColor = Color.Red;
                txtPDIM.ReadOnly = false;
                txtLDIM.ReadOnly = false;
                txtTDIM.ReadOnly = false;
                txtWEIGHT.BackColor = Color.White;
                txtPDIM.BackColor = Color.White;
                txtLDIM.BackColor = Color.White;
                txtTDIM.BackColor = Color.White;
                txtWEIGHT.Text = "0";
            }
            else
            {
                txtWEIGHT.ReadOnly = false;
                txtWEIGHT.BackColor = Color.White;
                txtPDIM.ReadOnly = true;
                txtLDIM.ReadOnly = true;
                txtTDIM.ReadOnly = true;
                txtWEIGHT.BackColor = Color.Red;
                txtPDIM.BackColor = Color.Red;
                txtLDIM.BackColor = Color.Red;
                txtTDIM.BackColor = Color.Red;

                txtPDIM.Text = "0";
                txtLDIM.Text = "0";
                txtTDIM.Text = "0";
                txtWEIGHT.Text = "0";

            }
        }             
        private void txtPDIM_KeyUp(object sender, KeyEventArgs e)
        {          
            hitungWEIGHTDIM();
            hitungTotal();
            hitungGrandTotal();
        }
        private void txtLDIM_KeyUp(object sender, KeyEventArgs e)
        {
            hitungWEIGHTDIM();
            hitungTotal();
            hitungGrandTotal();
        }
        private void txtTDIM_KeyUp(object sender, KeyEventArgs e)
        {
            hitungWEIGHTDIM();
            hitungTotal();
            hitungGrandTotal();
        }
        private void chkPPN_CheckedChanged(object sender, EventArgs e)
        {
            if (chkPPN.Checked == true)
            {
                txtPPNPercent.ReadOnly = true;
                txtPPNPercent.Text = "10";
                hitungPPN();
            }
            else
            {
                txtPPNPercent.Text = "0";
                txtCHARGEPPN.Text = "0";
            }
            clearPEMBAYARAN();
            hitungGrandTotal();
            

        }
        #region Fungsi2
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
        // validasi pengisian dengan angka
        public bool isNumeric(string val, System.Globalization.NumberStyles NumberStyle)
        {
            Double result;
            return Double.TryParse(val, NumberStyle,
                System.Globalization.CultureInfo.CurrentCulture, out result);
        }
        private AutoCompleteStringCollection GetAutoSourceKOTA()
        {
            DataTable dt = bKOTA.SELECTKOTA();
            AutoCompleteStringCollection autoSourceCollection = new AutoCompleteStringCollection();

            if (dt.Rows.Count > 0)
            {

                for (int i = 0; i < dt.Rows.Count; i++)
                {

                    autoSourceCollection.Add(dt.Rows[i]["NAMAKOTA"].ToString());

                }
            }


            return autoSourceCollection;
        }
        void LOAD_TARIF()
        {
            float sberat = float.Parse(txtSWIGHT.Text);
            float tberat = 0;
            dgvTARIF.DataSource = null;
            dgvTARIF.Rows.Clear();
            DataTable dt;
            cTARIF.KOTAASAL = txtSFROM.Text;
            cTARIF.KOTATUJUAN = txtSTO.Text;

            if (string.IsNullOrEmpty(cTARIF.KOTAASAL))
            {
                MessageBox.Show("MOHON ISI KOTA ASAL DENGAN BENAR", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtSFROM.Text = "";
                txtSFROM.Focus();
                return;
            }
            if (string.IsNullOrEmpty(cTARIF.KOTATUJUAN))
            {
                MessageBox.Show("MOHON ISI KOTA TUJUAN DENGAN BENAR", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtSTO.Text = "";
                txtSTO.Focus();
                return;
            }

            dt = bTARIF.SEARCH_BYNAMA(cTARIF);

            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    string id = dt.Rows[i]["IDTARIF"].ToString();
                    string namalayanan = dt.Rows[i]["PRODUK"].ToString();
                    string jeniskiriman = dt.Rows[i]["JENISKIRIMAN"].ToString();
                    string tarif = dt.Rows[i]["TARIF"].ToString();
                    string tarifberikut = dt.Rows[i]["TARIFBERIKUT"].ToString();
                    string etd = dt.Rows[i]["ETD"].ToString();                    

                    tberat = (sberat * Convert.ToInt32(dt.Rows[i]["TARIF"].ToString()));
                    dgvTARIF.Rows.Add(id, tberat, namalayanan, jeniskiriman, tarif, tarifberikut, etd);

                    if (checkIDTARIF == Convert.ToInt32(id))
                    {
                        dgvTARIF.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                    }

                }
            }
        }
        public void GET_DATA_CUSTOMER(RMS.COMMON.MASTER.RMS_CUSTOMER obj)
        {
            c.IDCUSTOMER = obj.ID;
            txtKODECUSTOMER.Text = obj.KODE;
            txtNAMACUSTOMER.Text = obj.NAMACUSTOMER;
            txtALAMATPENGIRIM.Text = obj.ALAMAT;
            txtPHONEPENGIRIM.Text = obj.TELEPON;
            txtHPPENGIRIM.Text = obj.HP;
        }
        public void GET_DATA_PENERIMA(RMS.COMMON.MASTER.RMS_PENERIMA obj)
        {
            c.IDPENERIMA = obj.ID;
            txtPENERIMA.Text = obj.NAMAPENERIMA;
            txtALAMAT.Text = obj.ALAMAT;
            txtPHONEPENERIMA.Text = obj.HP;
            txtFAXPENERIMA.Text = obj.FAX;
        }
        public string Terbilang(int x)
        {
            string terbilang = "";
            string[] bil = new string[] { "", "SATU", "DUA", "TIGA", "EMPAT", "LIMA", "ENAM", "TUJUH", "DELAPAN", "SEMBILAN", "SEPULUH", "SEBELAS" };

            if (x < 12)
            {
                terbilang = " " + bil[x];
            }
            else if (x < 20)
            {
                terbilang = Terbilang(x - 10) + " BELAS";
            }
            else if (x < 100)
            {
                terbilang = Terbilang(x / 10) + " PULUH" + Terbilang(x % 10);
            }
            else if (x < 200)
            {
                terbilang = " SERATUS" + Terbilang(x - 100);
            }
            else if (x < 1000)
            {
                terbilang = Terbilang(x / 100) + " RATUS" + Terbilang(x % 100);
            }
            else if (x < 2000)
            {
                terbilang = " SERIBU" + Terbilang(x - 1000);
            }
            else if (x < 1000000)
            {
                terbilang = Terbilang(x / 1000) + " RIBU" + Terbilang(x % 1000);
            }
            else if (x < 1000000000)
            {
                terbilang = Terbilang(x / 1000000) + " JUTA" + Terbilang(x % 1000000);

            }
            return terbilang;
        }

        public void setDIM()
        {
            txtPDIM.ReadOnly = true;
            txtLDIM.ReadOnly = true;
            txtTDIM.ReadOnly = true;

            txtWEIGHT.BackColor = Color.Red;
            txtPDIM.BackColor = Color.Red;
            txtLDIM.BackColor = Color.Red;
            txtTDIM.BackColor = Color.Red;
        }
        public void hitungTotal()
        {
            if (string.IsNullOrEmpty(txtRATEKIRIM.Text)) return;
            if (string.IsNullOrEmpty(txtWEIGHT.Text)) return;

            decimal weight = 0;
            decimal ratekirim = decimal.Parse(txtRATEKIRIM.Text);
            if (txtWEIGHT.Text != "0")
            {
                weight = Math.Round(decimal.Parse(txtWEIGHT.Text));
            }

            txtTOTALCHARGEKIRIM.Text = (ratekirim * weight).ToString("#.##");
            if (string.IsNullOrEmpty((ratekirim * weight).ToString("#.##")))
            {
                txtTOTALCHARGEKIRIM.Text = "0";
            }


        }
        public void hitungUang()
        {
            decimal grandtotal, bayar, kembali;
            grandtotal = decimal.Parse(txtGRANDTOTAL.Text.ToString());
            bayar = decimal.Parse(txtBAYAR.Text.ToString());
            kembali = bayar - grandtotal;
            if (bayar <= 0)
            {
                txtKEMBALI.Text = "0";
            }
            else
            {
                txtKEMBALI.Text = kembali.ToString("#.##");
            }
            if (kembali == 0)
            {
                txtKEMBALI.Text = "0";
            }

        }
        public void hitungGrandTotal()
        {
            decimal grandtotal;
            decimal totalcharge;
            decimal totalothercharge;
            decimal ppn, packing, insurance, diskon;
            ppn = decimal.Parse(txtCHARGEPPN.Text.ToString());
            packing = decimal.Parse(txtCHARGEPACKING.Text.ToString());
            if (string.IsNullOrEmpty(txtCHARGEINSURANCE.Text.ToString()))
            {
                insurance = 0;
            }
            else
            {
                insurance = decimal.Parse(txtCHARGEINSURANCE.Text.ToString());
            }
            if (string.IsNullOrEmpty(txtTOTALCHARGEKIRIM.Text))
            {
                txtTOTALCHARGEKIRIM.Text = "0";
            }
            totalcharge = decimal.Parse(txtTOTALCHARGEKIRIM.Text.ToString());
            diskon = decimal.Parse(txtDISKON.Text.ToString());
            totalothercharge = (ppn + packing + insurance);
            grandtotal = totalothercharge + totalcharge - diskon;

            txtTOTALOTHERCHARGE.Text = (totalothercharge.ToString("#.##"));
            txtGRANDTOTAL.Text = (grandtotal.ToString("#.##"));


            if (string.IsNullOrEmpty(totalothercharge.ToString("#.##")))
            { txtTOTALOTHERCHARGE.Text = "0"; }
            if (string.IsNullOrEmpty(grandtotal.ToString("#.##")))
            { txtGRANDTOTAL.Text = "0"; }

            Decimal GTOTAL;
            GTOTAL = decimal.Parse(txtGRANDTOTAL.Text);

            txtTERBILANG.Text = Terbilang(Decimal.ToInt32(Math.Round(GTOTAL))) + " RUPIAH";
           

        }
        private void clearPEMBAYARAN()
        {            
            hitungDISKON();
            txtBAYAR.Text = "0";
            txtKEMBALI.Text = "0";

        }
        private void hitungWEIGHTDIM()
        {

            decimal WEIGHTDECIMAL;
            int pembagi;


            if (!isNumeric(txtPDIM.Text, System.Globalization.NumberStyles.Float) || (String.IsNullOrEmpty(txtPDIM.Text)))
            {
                MessageBox.Show("ISI FIELD DENGAN BENAR", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtPDIM.Text = "0";
                return;
            }
            if (!isNumeric(txtLDIM.Text, System.Globalization.NumberStyles.Float) || (String.IsNullOrEmpty(txtLDIM.Text)))
            {
                MessageBox.Show("ISI FIELD DENGAN BENAR", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtLDIM.Text = "0";
                return;
            }
            if (!isNumeric(txtTDIM.Text, System.Globalization.NumberStyles.Float) || (String.IsNullOrEmpty(txtTDIM.Text)))
            {
                MessageBox.Show("ISI FIELD DENGAN BENAR", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtTDIM.Text = "0";
                return;
            }

            decimal nominalP = decimal.Parse(txtPDIM.Text);
            decimal nominalL = decimal.Parse(txtLDIM.Text);
            decimal nominalT = decimal.Parse(txtTDIM.Text);

            pembagi = 6000;


            WEIGHTDECIMAL = Math.Round((nominalP * nominalL * nominalT)) / pembagi;
            txtWEIGHT.Text = WEIGHTDECIMAL.ToString();
            txtSWIGHT.Text = txtWEIGHT.Text;
        }
        public void hitungPPN()
        {
            if (string.IsNullOrEmpty(txtRATEKIRIM.Text)) return;
            if (string.IsNullOrEmpty(txtWEIGHT.Text)) return;

            if (txtTOTALCHARGEKIRIM.Text == "0" || txtTOTALCHARGEKIRIM.Text == "")
            {
                chkPPN.Checked = false;
                MessageBox.Show("TOTAL CHARGE KIRM MOHON DIHITUNG KEMBALI", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            decimal totalcharge = decimal.Parse(txtTOTALCHARGEKIRIM.Text);
            decimal ppn = (decimal.Parse(txtPPNPercent.Text) / 100) * totalcharge;
            txtCHARGEPPN.Text = ppn.ToString("#.##");

        }
        public void hitungDISKON()
        {
            if (string.IsNullOrEmpty(txtTOTALCHARGEKIRIM.Text)) return;

            if (txtTOTALCHARGEKIRIM.Text == "0" || txtTOTALCHARGEKIRIM.Text == "")
            {
                chkPPN.Checked = false;
                MessageBox.Show("TOTAL CHARGE KIRM MOHON DIHITUNG KEMBALI", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            decimal totalcharge = decimal.Parse(txtTOTALCHARGEKIRIM.Text);
            decimal diskon = (decimal.Parse(txtDISKONPERCENT.Text) / 100) * totalcharge;
            if (diskon == 0)
            {
                txtDISKON.Text = "0";
            }
            else
            {
                txtDISKON.Text = diskon.ToString("#.##");
            }

        }
        #endregion       
        private void chkPACKING_CheckedChanged(object sender, EventArgs e)
        {
            if (chkPACKING.Checked == true)
            {
                txtCHARGEPACKING.ReadOnly = false;
                txtCHARGEPACKING.Text = "0";
            }
            else
            {
                txtCHARGEPACKING.ReadOnly = true;
                txtCHARGEPACKING.Text = "0";

            }
        }
        private void txtCHARGEPACKING_TextChanged(object sender, EventArgs e)
        {
            if (!isNumeric(txtCHARGEPACKING.Text, System.Globalization.NumberStyles.Float) || (String.IsNullOrEmpty(txtCHARGEPACKING.Text)))
            {
                MessageBox.Show("ISI FIELD DENGAN BENAR", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtCHARGEPACKING.Text = "0";
                return;
            }
            clearPEMBAYARAN();
            hitungGrandTotal();
           
        }
        private void txtNOMINALBARANG_TextChanged(object sender, EventArgs e)
        {
            
            if (!isNumeric(txtNOMINALBARANG.Text, System.Globalization.NumberStyles.Float) || (String.IsNullOrEmpty(txtNOMINALBARANG.Text)))
            {
                MessageBox.Show("MOHON ISI DENGAN ANGKA", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtNOMINALBARANG.Text = "0";
                return;
            }

            decimal insurance;
            decimal insuranceAMOUNT;
            insurance = (decimal.Parse(cboINSURANCE.SelectedItem.ToString()) / 100);
            insuranceAMOUNT = insurance * decimal.Parse(txtNOMINALBARANG.Text);
            if (insuranceAMOUNT > 0)
            {
                txtCHARGEINSURANCE.Text = insuranceAMOUNT.ToString("#.##");
            }
            else
            {
                txtCHARGEINSURANCE.Text = "0";
            }
            clearPEMBAYARAN();
            hitungGrandTotal();
            
        }       
        private void button1_Click(object sender, EventArgs e)
        {
            VIEW.FormTAMBAHCUSTOMER frm = new LOGISTICMANAGAMENTSYSTEM.VIEW.FormTAMBAHCUSTOMER(null, this, 2);
            frm.ShowDialog();
        }
        private void txtSWIGHT_TextChanged(object sender, EventArgs e)
        {
            if (!isNumeric(txtSWIGHT.Text, System.Globalization.NumberStyles.Float) || (String.IsNullOrEmpty(txtSWIGHT.Text)))
            {
                MessageBox.Show("ISI FIELD DENGAN BENAR", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtSWIGHT.Text = "0";
                return;
            }
            

        }       
        private void txtDISKONPERCENT_TextChanged(object sender, EventArgs e)
        {
            if (!isNumeric(txtDISKONPERCENT.Text, System.Globalization.NumberStyles.Integer) || (String.IsNullOrEmpty(txtDISKONPERCENT.Text)))
            {
                MessageBox.Show("ISI FIELD DENGAN BENAR", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtDISKONPERCENT.Text = "0";
                return;
            }
            decimal disc = 0;
            disc = Convert.ToDecimal(txtDISKONPERCENT.Text.ToString());
            if (disc >= 100)
            {
                MessageBox.Show("Maaf nominal diskon melebihi jumlah total charge", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtDISKONPERCENT.Text = "0";
                return;
            }
            {
                hitungDISKON();
                hitungGrandTotal();
            }
            txtBAYAR.Text = "0";
            txtKEMBALI.Text = "0";
        }
        private void txtBAYAR_TextChanged(object sender, EventArgs e)
        {
            if (!isNumeric(txtBAYAR.Text, System.Globalization.NumberStyles.Float) || (String.IsNullOrEmpty(txtBAYAR.Text)))
            {
                MessageBox.Show("ISI FIELD DENGAN BENAR", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtBAYAR.Text = "0";
                return;
            }
            hitungUang();
        }
        private void btnTAMBAH_Click(object sender, EventArgs e)
        {
            #region CEK BY RICEK

            if (string.IsNullOrEmpty(txtSFROM.Text))
            {
                MessageBox.Show("ISI KOTA ASAL", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtSFROM.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txtSTO.Text))
            {
                MessageBox.Show("ISI KOTA TUJUAN", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtSTO.Focus();
                return;
            }

            if (string.IsNullOrEmpty(txtSWIGHT.Text))
            {
                MessageBox.Show("ISI BERAT / KG", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtSWIGHT.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txtNAMACUSTOMER.Text))
            {
                MessageBox.Show("ISI NAMA CUSTOMER", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtNAMACUSTOMER.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txtPENERIMA.Text))
            {
                MessageBox.Show("ISI NAMA PENERIMA", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtPENERIMA.Focus();
                return;
            }
            
            if (string.IsNullOrEmpty(txtKETERANGANISI.Text))
            {
                MessageBox.Show("ISI KETERANGAN ISI BARANG", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtPENERIMA.Focus();
                return;
            }
            if (txtSWIGHT.Text == "0")
            {
                MessageBox.Show("Mohon Lengkapi Transaksi", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtGRANDTOTAL.Focus();
                return;
            }
            if (txtBAYAR.Text == "0")
            {
                MessageBox.Show("Mohon Lakukan Pembayaran", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtBAYAR.Focus();
                return;
            }
            decimal checkGrandtotal, checkBayar = 0;
            checkGrandtotal = Convert.ToDecimal(txtGRANDTOTAL.Text);
            checkBayar = Convert.ToDecimal(txtBAYAR.Text);
            if (checkBayar < checkGrandtotal)
            {
                MessageBox.Show("Mohon Lakukan Pelunasan Pembayaran", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtBAYAR.Focus();
                return;
            }
            #endregion
            c.NORESI = txtNORESI.Text;
            c.TGLTERIMA = dtTGLMANIFEST.Value.ToString("yyyy-MM-dd");
            c.TGLESTIMASI = dtETD.Value.ToString("yyyy-MM-dd");
            c.JUMLAH = Convert.ToInt32(txtPCS.Text);
            c.BERAT = float.Parse(txtWEIGHT.Text);
            c.DIM_P = float.Parse(txtPDIM.Text);
            c.DIM_L = float.Parse(txtLDIM.Text);
            c.DIM_T = float.Parse(txtTDIM.Text);
            c.RATE_KIRIM = float.Parse(txtRATEKIRIM.Text);
            c.CHARGE_KIRIM = float.Parse(txtTOTALCHARGEKIRIM.Text);
            c.PPNPERCENT = float.Parse(txtPPNPercent.Text);
            c.PPN = float.Parse(txtCHARGEPPN.Text);
            c.CHARGE_PACKING = float.Parse(txtCHARGEPACKING.Text);
            c.OTHER_CHARGE = 0;
            c.DISCPERCENT = float.Parse(txtDISKONPERCENT.Text);
            c.DISC = float.Parse(txtDISKON.Text);
            c.INCURANCEPERCENT = float.Parse(cboINSURANCE.Text);
            c.INCURANCE = float.Parse(txtCHARGEINSURANCE.Text);
            c.NBARANGINSURANCE = float.Parse(txtNOMINALBARANG.Text);
            // TGLPENGIRIMAN,TGLPENGAMBILAN informasi ini di bongkar muat
            c.TOTAL = float.Parse(txtGRANDTOTAL.Text);
            c.BAYAR = float.Parse(txtBAYAR.Text);
            c.SISA = float.Parse(txtKEMBALI.Text);
            c.VOID = 0; // Belum disediakan untuk void
            c.STATUS = 1; // SAAT pengisian awal default MANIFESTED
            c.KETERANGANISI = txtKETERANGANISI.Text;
            c.INSTRUKSIKHUSUS = txtINSTRUKSIKHUSUS.Text;


            if (Type == 0)
            {
             //  b.INSERT(c);
               
                this.frm.LOAD_DATA();
                

            }
            else
            {
                b.UPDATE(c);
                this.frm.LOAD_DATA();
            }
            Close();
            //this.Hide();
            //this.MinimumSize();
            // disini isi data table printer

           // BarcodeLib.Barcode b = new BarcodeLib.Barcode(BarcodeLib.TYPE.UPCA,
          //"038000356216", Color.Black, Color.White, 300, 150);
            dataPrint.Rows.Add(c.NORESI, txtSFROM.Text, txtSTO.Text, txtWEIGHT.Text, txtPCS.Text,
                txtNAMACUSTOMER.Text, txtALAMATPENGIRIM.Text, txtPHONEPENGIRIM.Text, txtPENERIMA.Text, txtALAMAT.Text,
                txtPHONEPENERIMA.Text, lblLAYANAN.Text, txtRATEKIRIM.Text, lblJENISKIRIMAN.Text,
                txtCHARGEINSURANCE.Text, txtCHARGEPPN.Text, txtGRANDTOTAL.Text, txtKETERANGANISI.Text, txtINSTRUKSIKHUSUS.Text, txtPDIM.Text, txtLDIM.Text, txtTDIM.Text, txtHPPENGIRIM.Text, txtCHARGEPACKING.Text, 038000356216, namaPerusahaan, alamatPerusahaan, telpPerusahaan, faxPerusahaan, c.TGLTERIMA,c.TGLESTIMASI);
                
            TopMost = false;
            CrystalDecisions.CrystalReports.Engine.ReportDocument cryRpt = new CrystalDecisions.CrystalReports.Engine.ReportDocument();
            REPORTS.EXPRESS.FormRESIEXPRESS frm = new REPORTS.EXPRESS.FormRESIEXPRESS(dataPrint);
            frm.WindowState = FormWindowState.Normal;
            frm.BringToFront();
            frm.ShowDialog();
            

           
        }

        void LOAD_DATA(RMS.COMMON.EXPRESS.RMS_TRANSAKSI obj)
        {

            DataTable dt = b.CARI_BYID(obj);
            if (dt.Rows.Count > 0)
            {
                string TGLTERIMA, TGLETD;

                txtNORESI.Text = dt.Rows[0]["NORESI"].ToString();
                checkIDTARIF = Convert.ToInt32(dt.Rows[0]["IDTARIF"].ToString());
                c.IDTARIF = Convert.ToInt32(dt.Rows[0]["IDTARIF"].ToString());
                txtSFROM.Text = dt.Rows[0]["KOTAASAL"].ToString();
                txtSTO.Text = dt.Rows[0]["KOTATUJUAN"].ToString(); 
                TGLTERIMA = dt.Rows[0]["TGLTERIMA"].ToString();
                TGLETD = dt.Rows[0]["TGLESTIMASI"].ToString();
                dtTGLMANIFEST.Value = DateTime.Parse(TGLTERIMA);
                dtETD.Value = DateTime.Parse(TGLETD);

                txtRATEKIRIM.Text = dt.Rows[0]["RATE_KIRIM"].ToString();
                txtSWIGHT.Text = dt.Rows[0]["BERAT"].ToString();               
                txtPCS.Text = dt.Rows[0]["JUMLAH"].ToString();

                txtPDIM.Text = dt.Rows[0]["DIM_P"].ToString();
                txtLDIM.Text = dt.Rows[0]["DIM_L"].ToString();
                txtTDIM.Text = dt.Rows[0]["DIM_T"].ToString();
                if (txtPDIM.Text != "0")
                {
                    chkISDIM.Checked = true;
                }
                txtWEIGHT.Text = dt.Rows[0]["BERAT"].ToString();
                LOAD_TARIF(); // untuk mengetahui tarif yang digunakan sebelumnya
                c.IDCUSTOMER = Convert.ToInt32(dt.Rows[0]["IDCUSTOMER"].ToString());
                txtKODECUSTOMER.Text = dt.Rows[0]["KODECUSTOMER"].ToString();
                txtNAMACUSTOMER.Text = dt.Rows[0]["NAMACUSTOMER"].ToString();
                // tambah disini mang
                txtALAMATPENGIRIM.Text = dt.Rows[0]["ALAMAT"].ToString();
                txtPHONEPENGIRIM.Text = dt.Rows[0]["TELEPON"].ToString();
                txtHPPENGIRIM.Text = dt.Rows[0]["HP"].ToString();
                
                c.IDPENERIMA = Convert.ToInt32(dt.Rows[0]["IDPENERIMA"].ToString());
                txtPENERIMA.Text = dt.Rows[0]["NAMAPENERIMA"].ToString();
                txtPHONEPENERIMA.Text = dt.Rows[0]["TELEPONPENERIMA"].ToString();
                txtFAXPENERIMA.Text = dt.Rows[0]["FAXPENERIMA"].ToString();
                txtALAMAT.Text = dt.Rows[0]["ALAMATPENERIMA"].ToString();
                
                // informasi other charge
                txtTOTALCHARGEKIRIM.Text = dt.Rows[0]["CHARGE_KIRIM"].ToString();
                txtDISKONPERCENT.Text = dt.Rows[0]["DISCPERCENT"].ToString();
                txtDISKON.Text = dt.Rows[0]["DISC"].ToString();
                txtBAYAR.Text = dt.Rows[0]["BAYAR"].ToString();
                
                // hitunga on change grandTOTAL
                txtPPNPercent.Text = dt.Rows[0]["PPNPERCENT"].ToString();
                if (txtPPNPercent.Text != "0")
                {
                    chkPPN.Checked = true;
                }
                txtCHARGEPPN.Text = dt.Rows[0]["PPN"].ToString();
                cboINSURANCE.Text = dt.Rows[0]["INCURANCEPERCENT"].ToString();
                txtCHARGEINSURANCE.Text = dt.Rows[0]["INSURANCE"].ToString();
                txtNOMINALBARANG.Text = dt.Rows[0]["NBARANGINSURANCE"].ToString();
                if (txtNOMINALBARANG.Text != "0")
                {
                    chkPACKING.Checked = true;
                }
                txtCHARGEPACKING.Text = dt.Rows[0]["CHARGE_PACKING"].ToString();

                // additional info pamantes
                lblFROM.Text = dt.Rows[0]["KOTAASAL"].ToString();
                lblTO.Text = dt.Rows[0]["KOTATUJUAN"].ToString();
                lblLAYANAN.Text = dt.Rows[0]["PRODUK"].ToString();
                lblJENISKIRIMAN.Text = dt.Rows[0]["JENISKIRIMAN"].ToString();

                // additional 
                txtKETERANGANISI.Text = dt.Rows[0]["KETERANGANISI"].ToString();
                txtINSTRUKSIKHUSUS.Text = dt.Rows[0]["INSTRUKSIKHUSUS"].ToString();
            }
        }

        private void btnBARCODE_Click(object sender, EventArgs e)
        {
            
           BarcodeLib.Barcode barcode = new BarcodeLib.Barcode();

           Image image = barcode.Encode(BarcodeLib.TYPE.CODE128, "0380003562162", Color.Black, Color.White, 300, 150);

           showBarcode.BackgroundImage = barcode.Encode(BarcodeLib.TYPE.CODE128, "0380003562162", Color.Black, Color.White, 300, 50);
           byte[] test = barcode.Encoded_Image_Stream;
        

           //string test = barcode.EncodedValue;
           dataPrint.Rows.Add(c.NORESI, txtSFROM.Text, txtSTO.Text, txtWEIGHT.Text, txtPCS.Text,
               c.NAMACUSTOMER, txtALAMATPENGIRIM.Text, txtPHONEPENGIRIM.Text, txtPENERIMA.Text, txtALAMAT.Text,
               txtPHONEPENERIMA.Text, lblLAYANAN.Text, txtRATEKIRIM.Text, lblJENISKIRIMAN.Text,
               txtCHARGEINSURANCE.Text, txtCHARGEPPN.Text, txtGRANDTOTAL.Text, txtKETERANGANISI.Text, txtINSTRUKSIKHUSUS.Text, txtPDIM.Text, txtLDIM.Text, txtTDIM.Text, txtHPPENGIRIM.Text, txtCHARGEPACKING.Text, test, barcode.EncodedValue, alamatPerusahaan, telpPerusahaan, faxPerusahaan, c.TGLTERIMA, c.TGLESTIMASI);
            TopMost = false;
            CrystalDecisions.CrystalReports.Engine.ReportDocument cryRpt = new CrystalDecisions.CrystalReports.Engine.ReportDocument();
            REPORTS.EXPRESS.FormRESIEXPRESS frm = new REPORTS.EXPRESS.FormRESIEXPRESS(dataPrint);
            frm.WindowState = FormWindowState.Normal;
            frm.BringToFront();
            frm.ShowDialog();
           
            
           
        }

        private void dgvTARIF_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            PILIHLAYANAN();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btnEDIT_Click(object sender, EventArgs e)
        {
            Close();
        }
                
               
        
    }
}

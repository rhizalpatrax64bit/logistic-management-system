using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;


namespace LOGISTICMANAGAMENTSYSTEM.MASTER
{
    public partial class FormPRICELIST : Form
    {
        protected RMS.BUSSINES.MASTER.RMS_CUSTOMER bCUST = new RMS.BUSSINES.MASTER.RMS_CUSTOMER();
        protected RMS.COMMON.MASTER.RMS_CUSTOMER cCUST = new RMS.COMMON.MASTER.RMS_CUSTOMER();

        protected RMS.BUSSINES.MASTER.RMS_KOTA bKOTA = new RMS.BUSSINES.MASTER.RMS_KOTA();
        protected RMS.COMMON.MASTER.RMS_KOTA cKOTA = new RMS.COMMON.MASTER.RMS_KOTA();

        protected RMS.BUSSINES.MASTER.RMS_PRICELIST b = new RMS.BUSSINES.MASTER.RMS_PRICELIST();
        protected RMS.COMMON.MASTER.RMS_PRICELIST c = new RMS.COMMON.MASTER.RMS_PRICELIST();
        protected RMS.COMMON.GENERAL.RMS_COMBO combo = new RMS.COMMON.GENERAL.RMS_COMBO();
        protected RMS.BUSSINES.GENERAL.RMS_COMBO comboQuery = new RMS.BUSSINES.GENERAL.RMS_COMBO();

        protected RMS.BUSSINES.MASTER.RMS_TENTANGPERUSAHAAN bPersusahaan = new RMS.BUSSINES.MASTER.RMS_TENTANGPERUSAHAAN();
        protected RMS.COMMON.MASTER.RMS_TENTANGPERUSAHAAN cPersusahaan = new RMS.COMMON.MASTER.RMS_TENTANGPERUSAHAAN();

        string kodePerusahaan, namaPerusahaan, alamatPerusahaan, telpPerusahaan, faxPerusahaan;

        DataTable dtPRINTB, dtPRINTT,dtAUTOTERUSAN;
        int type = 0;
        public FormPRICELIST()
        {
            InitializeComponent();
            INIT_PERUSAHAAN();
            loadCOMBO();
            SETTING_MANUAL();
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
            this.dgvPRICELIST.Size = new Size(1281, 250);
            this.panelBUTTON.Location = new Point(2, 560);
          //  this.panelCARI.Location = new Point(790, 4);
        }
        public void loadCOMBO()
        {
            this.setCOMBO();
         
            DataRow drSERVICE = ((DataRowView)cboLAYANAN.SelectedItem).Row;
            DataRow drHANDLING = ((DataRowView)cboHANDLING.SelectedItem).Row;
                   
            c.IDSERVICE = int.Parse(drSERVICE["IDLAYANAN"].ToString());
            c.IDHANDLING = int.Parse(drHANDLING["IDJNSKIRIM"].ToString());

        }
        public void setCOMBO()
        {       
            DataTable dtLAYANAN = new DataTable();
            DataTable dtMODAKIRIM = new DataTable();
         
            dtLAYANAN = comboQuery.SELECTLAYANAN();
            dtMODAKIRIM = comboQuery.SELECTMODAKIRIM();
                

            cboLAYANAN.DataSource = dtLAYANAN;
            cboLAYANAN.ValueMember = dtLAYANAN.Columns[0].ColumnName;
            cboLAYANAN.DisplayMember = dtLAYANAN.Columns[1].ColumnName;

            cboHANDLING.DataSource = dtMODAKIRIM;
            cboHANDLING.ValueMember = dtMODAKIRIM.Columns[0].ColumnName;
            cboHANDLING.DisplayMember = dtMODAKIRIM.Columns[2].ColumnName;

        }
        public void LOAD_DATA()
        {
            
            dgvPRICELIST.DataSource = null;
            dgvPRICELIST.Rows.Clear();
            DataTable dt;
            if (type == 0)
            {
                  dt = b.CARI_BYKODE(c);
            }
            else
            {
                dt = b.CARI_BYKODE(c);
            }
            type = 0;
            dtPRINTB = new DataTable();
            dtPRINTT = new DataTable();
            // dtPRINT = null;
            dtPRINTB.Columns.Add("NAMA", typeof(string));
            dtPRINTB.Columns.Add("SERVICE", typeof(string));
            dtPRINTB.Columns.Add("HANDLING", typeof(string));
            dtPRINTB.Columns.Add("JENISCOST", typeof(string));
            dtPRINTB.Columns.Add("BASAL", typeof(string));
            dtPRINTB.Columns.Add("BTUJUAN", typeof(string));
            dtPRINTB.Columns.Add("BKODE", typeof(string));
            dtPRINTB.Columns.Add("BHARGA", typeof(string));
            dtPRINTB.Columns.Add("BWAKTU", typeof(string));
        

            dtPRINTB.Columns.Add("TASAL", typeof(string));
            dtPRINTB.Columns.Add("TTUJUAN", typeof(string)); // durasi waktu / keterangan
            dtPRINTB.Columns.Add("TKODE", typeof(string));
            dtPRINTB.Columns.Add("THARGA", typeof(string));
            dtPRINTB.Columns.Add("TWAKTU", typeof(string));
            dtPRINTB.Columns.Add("TRC", typeof(string));
            dtPRINTB.Columns.Add("BRC", typeof(string));
            dtPRINTB.Columns.Add("NAMAPERUSAHAAN", typeof(string));
            dtPRINTB.Columns.Add("ALAMATPERUSAHAAN", typeof(string));
            dtPRINTB.Columns.Add("TELPPERUSAHAAN", typeof(string));
            dtPRINTB.Columns.Add("FAXPERUSAHAAN", typeof(string));
            dtPRINTB.Columns.Add("NO", typeof(string));
           
            
            bool isTrue = true;
            string kodearea = string.Empty;
            string JENISCOST;
            string BASAL = "";
            string BTUJUAN ="";
            string BKODE="";
            string BHARGA="";
            string BWAKTU="";
           
           
            if (dt.Rows.Count > 0)
            {
                int no_urut = 1;
                for (int i = 0; i < dt.Rows.Count; i++)
                {

                    string NAMA = dt.Rows[i]["CUSTOMER"].ToString();
                    kodearea = dt.Rows[i]["KODEAREA"].ToString();
                    string IDPRICELIST = dt.Rows[i]["IDPRICELIST"].ToString();
                    string SERVICE = dt.Rows[i]["KODELAYANAN"].ToString();
                    string HANDLING = dt.Rows[i]["HANDLING"].ToString();
                    string ASAL = dt.Rows[i]["ASAL"].ToString();
                    string TUJUAN = dt.Rows[i]["TUJUAN"].ToString();
                    string TERUSAN = dt.Rows[i]["NAMATERUSAN"].ToString();
                    string CHARGE = dt.Rows[i]["CHARGE"].ToString();
                    string REFUND = dt.Rows[i]["REFUND"].ToString();
                    string DURASI = dt.Rows[i]["DURASIWAKTU"].ToString();
                    string IDASAL = dt.Rows[i]["IDASAL"].ToString();
                    string IDTUJUAN = dt.Rows[i]["IDTUJUAN"].ToString();
                    bool ISAKTIF = bool.Parse(dt.Rows[i]["ISAKTIF"].ToString());

                    string kodecust = dt.Rows[i]["KODECUSTOMER"].ToString();
                    string customer = dt.Rows[i]["CUSTOMER"].ToString();
                    string kasal = dt.Rows[i]["KODEASAL"].ToString();
                    string ktujuan = dt.Rows[i]["KODETUJUAN"].ToString();
                    dgvPRICELIST.Rows.Add(IDPRICELIST, SERVICE, HANDLING, ASAL, TUJUAN, TERUSAN, CHARGE, REFUND, DURASI, ISAKTIF);
                    if (ISAKTIF)
                    {
                        //dgvPRICELIST.DefaultCellStyle.ForeColor = Color.Red;

                        /// dtPRINTB.Rows.Add();
                        JENISCOST = "";
                        BASAL = ASAL;
                        if (string.IsNullOrEmpty(TERUSAN))
                        {
                            BTUJUAN = TUJUAN;
                        }
                        else { BTUJUAN = TERUSAN; }
                        BKODE = ktujuan;
                        BHARGA = CHARGE;
                        BWAKTU = DURASI;
                        //dtPRINTB.Rows.Add(NAMA, SERVICE, HANDLING, JENISCOST, BASAL, BTUJUAN, BKODE, BHARGA, BWAKTU, TASAL, TTUJUAN, TKODE, THARGA, TWAKTU, "","");

                        dtPRINTB.Rows.Add(NAMA, SERVICE, HANDLING, JENISCOST, BASAL, BTUJUAN, BKODE, BHARGA, BWAKTU,"","","","","","","", namaPerusahaan, alamatPerusahaan, telpPerusahaan, faxPerusahaan,no_urut);
                        no_urut++;

                    }
                    else
                    {
                        dgvPRICELIST.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                    }
                }
             }
        }

        private void btnCetak_Click(object sender, EventArgs e)
        {

        }
             

       

       
        private void button1_Click(object sender, EventArgs e)
        {
            dgvPRICELIST.DataSource = null;
            dgvPRICELIST.Rows.Clear();

            DataTable dt = b.SELECT(c);
            
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                   
                    string IDPRICELIST = dt.Rows[i]["IDPRICELIST"].ToString();
                    string SERVICE = dt.Rows[i]["SERVICE"].ToString();
                    string HANDLING = dt.Rows[i]["HANDLING"].ToString();
                    string ASAL = dt.Rows[i]["ASAL"].ToString();
                    string TUJUAN = dt.Rows[i]["TUJUAN"].ToString();                  
                    string CHARGE = dt.Rows[i]["CHARGE"].ToString();
                    string REFUND = dt.Rows[i]["REFUND"].ToString();
                    string DURASIWAKTU = dt.Rows[i]["DURASIWAKTU"].ToString();
                    dgvPRICELIST.Rows.Add(IDPRICELIST,SERVICE, HANDLING, ASAL, TUJUAN, CHARGE, REFUND,DURASIWAKTU);
                    dgvPRICELIST.Rows[i].ReadOnly = true;
                }
            }
        }
       
        private void btnTAMBAH_Click(object sender, EventArgs e)
        {
           
            if (string.IsNullOrEmpty(txtCUSTOMER.Text))
            {
                MessageBox.Show("PILIH CUSTOMER", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtCUSTOMER.Focus();
                return;
            }
            else
            {
                txtKODEASAL.Focus();
            }
            
        }

        private void btnHAPUS_Click(object sender, EventArgs e)
        {
                       
            if (dgvPRICELIST.SelectedCells.Count > 0)
            {
                string idpricelist = dgvPRICELIST.SelectedCells[0].OwningRow.Cells["IDPRICELIST"].Value.ToString();
                string tujuan = dgvPRICELIST.SelectedCells[0].OwningRow.Cells["KTUJUAN"].Value.ToString();
                c.IDPRICELIST = int.Parse(idpricelist);
                DialogResult dr = MessageBox.Show("APAKAH YAKIN AKAN DELETE DATA : " + tujuan + " ?", "WARNING", MessageBoxButtons.OKCancel, MessageBoxIcon.Stop);
                if (dr == DialogResult.OK)
                {
                    b.DELETE(c);
                    LOAD_DATA();
                }
            }
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtCARI_KeyUp(object sender, KeyEventArgs e)
        {
            pnlCUSTOMER.Visible = true;
            pnlCUSTOMER.BringToFront();
            panel1.BringToFront();
            dgvCUSTOMER.BringToFront();
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

        private void FormPRICELIST_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                txtCARI.Focus();
            }

            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
            
                        
        }

        private void txtCARI_TextChanged(object sender, EventArgs e)
        {           
                dgvCUSTOMER.DataSource = null;
                dgvCUSTOMER.Rows.Clear();
                cCUST.NAMACUSTOMER = txtCARI.Text;
                cCUST.KODE = txtCARI.Text;
                cCUST.TYPE = 2;
                DataTable dt = bCUST.SEARCH_BYNAMA(cCUST);
                
                if (dt.Rows.Count > 0)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        string id = dt.Rows[i]["IDCUSTOMER"].ToString();
                        string kode = dt.Rows[i]["KODECUSTOMER"].ToString();
                        string namaC = dt.Rows[i]["NAMACUSTOMER"].ToString();
                        string alamat = dt.Rows[i]["ALAMAT"].ToString();
                        string hp = dt.Rows[i]["HP"].ToString();
                        dgvCUSTOMER.Rows.Add(id,kode, namaC, alamat,hp);
                    }
                

            }
        }

        private void dgvCUSTOMER_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvCUSTOMER.SelectedCells.Count > 0)
            {
                string kode = dgvCUSTOMER.SelectedCells[0].OwningRow.Cells["KODE"].Value.ToString();
                string nama = dgvCUSTOMER.SelectedCells[0].OwningRow.Cells["NAMA"].Value.ToString();
                txtCUSTOMER.Text = nama;
                c.KODECUSTOMER = kode;
                c.IDCUSTOMER = int.Parse(dgvCUSTOMER.SelectedCells[0].OwningRow.Cells["IDCUSTOMER"].Value.ToString());
                enableTAMBAH();
                pnlCUSTOMER.Visible = false;
                LOAD_DATA();
                txtKODEASAL.Focus();
            }
        }
        private void enableTAMBAH()
        {
            cboHANDLING.Visible = true;
            cboLAYANAN.Visible = true;
            txtKODEASAL.Visible = true;
            txtKODETUJUAN.Visible = true;
            txtKODETERUSAN.Visible = true;
            txtCHARGE.Visible = true;
            txtREFUND.Visible = true;
            txtTAMBAH.Visible = true;
            txtDURASI.Visible = true;
        }
        private void disableTAMBAH()
        {
            cboHANDLING.Visible = false;
            cboLAYANAN.Visible = false;
            txtKODEASAL.Visible = false;
            txtKODETUJUAN.Visible = false;
            txtKODETUJUAN.Visible = false;
            txtCHARGE.Visible = false;
            txtREFUND.Visible = false;
            txtTAMBAH.Visible = false;
            txtDURASI.Visible = false;
        }
      

        private void FormPRICELIST_Load(object sender, EventArgs e)
        {
           disableTAMBAH();
           GetAutoSourceCollectionFromTable();
           GetAutoSourceKOTA();
           txtKODETERUSAN.AutoCompleteCustomSource = GetAutoSourceCollectionFromTable();
           txtKODETERUSAN.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
           txtKODETERUSAN.AutoCompleteSource = AutoCompleteSource.CustomSource;

           txtKODEASAL.AutoCompleteCustomSource = GetAutoSourceKOTA();
           txtKODEASAL.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
           txtKODEASAL.AutoCompleteSource = AutoCompleteSource.CustomSource;

           txtKODETUJUAN.AutoCompleteCustomSource = GetAutoSourceKOTA();
           txtKODETUJUAN.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
           txtKODETUJUAN.AutoCompleteSource = AutoCompleteSource.CustomSource;
               
        }

        private void gbORDER_Enter(object sender, EventArgs e)
        {

        }

        private void txtKODEASAL_Leave(object sender, EventArgs e)
        {
            string kode = txtKODEASAL.Text;            
            cKOTA.KODEKOTA = kode;
            cKOTA.NAMAKOTA = kode;
            if (!string.IsNullOrEmpty(txtKODEASAL.Text))
            {
                DataTable dt = bKOTA.GETKOTA(cKOTA);
                if (dt.Rows.Count > 0)
                {
                    if (dt.Rows.Count > 0)
                    {
                        string idKOTA = dt.Rows[0]["IDKOTA"].ToString();
                        c.IDASAL = int.Parse(idKOTA);
                        txtKODEASAL.Text = dt.Rows[0]["NAMAKOTA"].ToString();
                        txtKODEASAL.BackColor = Color.LimeGreen;
                        cKOTA.KODEKOTA = "";
                        cKOTA.NAMAKOTA = "";

                    }
                }
                else
                {
                    DialogResult dr = MessageBox.Show("KODE KOTA YANG ANDA MASUKAN SALAH : ", "WARNING", MessageBoxButtons.OKCancel, MessageBoxIcon.Stop);
                    if (dr == DialogResult.OK)
                    {
                        txtKODEASAL.BackColor = Color.White;
                        //txtKODEASAL.Focus();
                    }


                }
            }
            else
            {
                txtKODEASAL.BackColor = Color.White;
            }
           
        }

        private void txtKODETUJUAN_Leave(object sender, EventArgs e)
        {
            string kode = txtKODETUJUAN.Text;
            cKOTA.KODEKOTA = kode;
            cKOTA.NAMAKOTA = kode;
            if (!string.IsNullOrEmpty(txtKODETUJUAN.Text))
            {
                DataTable dt = bKOTA.GETKOTA(cKOTA);
                if (dt.Rows.Count > 0)
                {
                    string idKOTA = dt.Rows[0]["IDKOTA"].ToString();
                    c.IDTUJUAN = int.Parse(idKOTA);
                    txtKODETUJUAN.Text = dt.Rows[0]["NAMAKOTA"].ToString();
                    txtKODETUJUAN.BackColor = Color.LimeGreen;
                    cKOTA.KODEKOTA = "";
                    cKOTA.NAMAKOTA = "";
                }
                else
                {
                    DialogResult dr = MessageBox.Show("KODE KOTA YANG ANDA MASUKAN SALAH : ", "WARNING", MessageBoxButtons.OKCancel, MessageBoxIcon.Stop);
                    if (dr == DialogResult.OK)
                    {

                        txtKODETUJUAN.BackColor = Color.White;
                        //txtKODETUJUAN.Focus();
                    }

                }
            }
            else
            {
                txtKODETUJUAN.BackColor = Color.White;
            }
              
        }

        private void txtTAMBAH_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtKODEASAL.Text))
            {
                MessageBox.Show("ISI KODE ASAL", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtKODEASAL.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txtKODETUJUAN.Text))
            {
                MessageBox.Show("ISI KODE TUJUAN", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtKODEASAL.Focus();
                return;
            }
                       

            c.RC = float.Parse(txtREFUND.Text);
            c.CHARGE = float.Parse(txtCHARGE.Text);
            c.DURASIWAKTU = txtDURASI.Text;
            if(string.IsNullOrEmpty(txtKODETERUSAN.Text))
            {
                c.IDTERUSAN = 0;
            }
            if (chkAKTIF.Checked == true)
            {
                c.ISAKTIF = true;
            }
            else
            {
                c.ISAKTIF = false;
            }
            if (type == 0)
            {
                DataTable dt = b.SELECTVALIDATE(c);
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("PRICELIST : " + c.NAMACUSTOMER +", SUDAH TERDAFTAR", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }
            }
            if (type == 0)
            {
                b.INSERT(c);
                this.LOAD_DATA();
            }
            else
            {
                b.UPDATE(c);
                this.LOAD_DATA();
            }
            
            CLEAR();
            txtKODEASAL.Focus();
        }
        private void CLEAR()
        {
            txtKODEASAL.Text = String.Empty;
            txtKODEASAL.BackColor = Color.White;
            txtKODETUJUAN.Text = String.Empty;
            txtKODETUJUAN.BackColor = Color.White;
            txtKODETERUSAN.Text = String.Empty;
            txtKODETERUSAN.BackColor = Color.White;
            txtDURASI.Text = String.Empty;
            txtCHARGE.Text = "0";
            txtREFUND.Text = "0";
            chkAKTIF.Checked = false;
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
                c.IDSERVICE = Convert.ToInt32(cboLAYANAN.SelectedValue);
               
            }
        }

        private void cboHANDLING_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!cboHANDLING.Focused)
            {
                return;
            }
            else
            {
                DataRow selectedDataRow = ((DataRowView)cboHANDLING.SelectedItem).Row;
                c.IDHANDLING = Convert.ToInt32(cboHANDLING.SelectedValue);

            }
        }

        private void btnEDIT_Click(object sender, EventArgs e)
        {
            
            if (dgvPRICELIST.SelectedCells.Count > 0)
            {

                int idpricelist = int.Parse(dgvPRICELIST.SelectedCells[0].OwningRow.Cells["IDPRICELIST"].Value.ToString());
                c.IDPRICELIST = idpricelist;
                DataTable dt = b.CARI_BYIDPRICELIST(c);            
                if (dt.Rows.Count > 0)
                {
                    cboHANDLING.Text = dt.Rows[0]["HANDLING"].ToString();
                    cboLAYANAN.Text = dt.Rows[0]["SERVICE"].ToString();
                    txtKODEASAL.Text = dt.Rows[0]["ASAL"].ToString();
                    txtKODEASAL.BackColor = Color.LimeGreen;
                    txtKODETUJUAN.Text = dt.Rows[0]["TUJUAN"].ToString();
                    txtKODETUJUAN.BackColor = Color.LimeGreen;
                    txtKODETERUSAN.Text = dt.Rows[0]["NAMATERUSAN"].ToString();
                    if (!string.IsNullOrEmpty(txtKODETERUSAN.Text))
                    {
                        txtKODETERUSAN.BackColor = Color.LimeGreen;
                    }
                    else
                    {
                        txtKODETERUSAN.BackColor = Color.White;
                    }

                    txtCHARGE.Text = dt.Rows[0]["CHARGE"].ToString();
                    txtREFUND.Text = dt.Rows[0]["REFUND"].ToString();
                    txtDURASI.Text = dt.Rows[0]["DURASIWAKTU"].ToString();
                    chkAKTIF.Checked = bool.Parse(dt.Rows[0]["ISAKTIF"].ToString());
                    c.IDASAL = int.Parse(dt.Rows[0]["IDASAL"].ToString());
                    c.IDTUJUAN = int.Parse(dt.Rows[0]["IDTUJUAN"].ToString());
                    if (!string.IsNullOrEmpty(dt.Rows[0]["IDTERUSAN"].ToString()))
                    {
                        c.IDTERUSAN = int.Parse(dt.Rows[0]["IDTERUSAN"].ToString());
                    }
                    else
                    {
                        c.IDTERUSAN = 0;
                    }
                    type = 1;
                }
                
            }
             
        }
        // load fungsi pannggil data untuk autocomplete 
        private AutoCompleteStringCollection GetAutoSourceCollectionFromTable()
        {
            DataTable dt = bKOTA.GETTERUSAN_AUTO();
            AutoCompleteStringCollection autoSourceCollection = new AutoCompleteStringCollection();
            
            if (dt.Rows.Count > 0)
            {
             
                for (int i = 0; i < dt.Rows.Count; i++)
                {

                   autoSourceCollection.Add(dt.Rows[i]["NAMATERUSAN"].ToString());
                    
                }
            }
            

            return autoSourceCollection;
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
        private void txtKODETERUSAN_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtKODETUJUAN.Text))
            {
                MessageBox.Show("Mohon Isi Kota Tujuan", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtKODETUJUAN.Focus();
                return;
            }

            if (!string.IsNullOrEmpty(txtKODETERUSAN.Text))
            {
                string namaterusan = txtKODETERUSAN.Text;
                cKOTA.NAMATERUSAN = namaterusan;
                DataTable dt = bKOTA.GETTERUSAN_BYNAMA(cKOTA);

                if (dt.Rows.Count > 0)
                {
                    string idKOTA = dt.Rows[0]["ID"].ToString();
                    c.IDTERUSAN = int.Parse(idKOTA);
                    txtKODETERUSAN.Text = dt.Rows[0]["NAMATERUSAN"].ToString();
                    txtKODETERUSAN.BackColor = Color.LimeGreen;
                }
                else
                {
                    c.IDTERUSAN = 0;
                    txtKODETERUSAN.BackColor = Color.White;



                }
            }
            else
            {
                txtKODETERUSAN.BackColor = Color.White;
            }
        }

        private void dgvCUSTOMER_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode  == Keys.Enter)
            {
                if (dgvCUSTOMER.SelectedCells.Count > 0)
                {
                    string kode = dgvCUSTOMER.SelectedCells[0].OwningRow.Cells["KODE"].Value.ToString();
                    string nama = dgvCUSTOMER.SelectedCells[0].OwningRow.Cells["NAMA"].Value.ToString();
                    txtCUSTOMER.Text = nama;
                    c.KODECUSTOMER = kode;
                    c.IDCUSTOMER = int.Parse(dgvCUSTOMER.SelectedCells[0].OwningRow.Cells["IDCUSTOMER"].Value.ToString());
                    enableTAMBAH();
                    pnlCUSTOMER.Visible = false;
                    LOAD_DATA();
                    txtKODEASAL.Focus();
                }
            }
        }

        private void btnCetak_Click_1(object sender, EventArgs e)
        {

          //  CrystalDecisions.CrystalReports.Engine.ReportDocument cryRpt = new CrystalDecisions.CrystalReports.Engine.ReportDocument();

            MASTER.REPORT.FormViewerPRICELIST frm = new MASTER.REPORT.FormViewerPRICELIST(dtPRINTB,0);

            frm.ShowDialog();
        }

        private void txtCHARGE_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCHARGE.Text))
            {
                MessageBox.Show("MOHON ISI DENGAN ANGKA", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtCHARGE.Focus();
                txtCHARGE.Text = "0";
                return;
            }
            System.Text.RegularExpressions.Regex nonNumericRegex = new System.Text.RegularExpressions.Regex(@"\D");
            if (nonNumericRegex.IsMatch(txtCHARGE.Text))
            {
                MessageBox.Show("MOHON ISI DENGAN ANGKA", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtCHARGE.Focus();
                txtCHARGE.Text = "0";

                return;
            }
        }

        private void txtREFUND_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtREFUND.Text))
            {
                MessageBox.Show("MOHON ISI DENGAN ANGKA", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtREFUND.Focus();
                txtREFUND.Text = "0";
                return;
            }
            System.Text.RegularExpressions.Regex nonNumericRegex = new System.Text.RegularExpressions.Regex(@"\D");
            if (nonNumericRegex.IsMatch(txtREFUND.Text))
            {
                MessageBox.Show("MOHON ISI DENGAN ANGKA", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtREFUND.Focus();
                txtREFUND.Text = "0";

                return;
            }
        }

        void ADD()
        {
            if (string.IsNullOrEmpty(txtCUSTOMER.Text))
            {
                MessageBox.Show("PILIH CUSTOMER", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtCUSTOMER.Focus();
                return;
            }
            else
            {
                txtKODEASAL.Focus();
            }
        }
        void EDIT()
        {
            if (dgvPRICELIST.SelectedCells.Count > 0)
            {

                int idpricelist = int.Parse(dgvPRICELIST.SelectedCells[0].OwningRow.Cells["IDPRICELIST"].Value.ToString());
                c.IDPRICELIST = idpricelist;
                DataTable dt = b.CARI_BYIDPRICELIST(c);
                if (dt.Rows.Count > 0)
                {
                    cboHANDLING.Text = dt.Rows[0]["HANDLING"].ToString();
                    cboLAYANAN.Text = dt.Rows[0]["SERVICE"].ToString();
                    txtKODEASAL.Text = dt.Rows[0]["ASAL"].ToString();
                    txtKODETUJUAN.Text = dt.Rows[0]["TUJUAN"].ToString();
                    txtKODETERUSAN.Text = dt.Rows[0]["NAMATERUSAN"].ToString();
                    txtCHARGE.Text = dt.Rows[0]["CHARGE"].ToString();
                    txtREFUND.Text = dt.Rows[0]["REFUND"].ToString();
                    txtDURASI.Text = dt.Rows[0]["DURASIWAKTU"].ToString();
                    chkAKTIF.Checked = bool.Parse(dt.Rows[0]["ISAKTIF"].ToString());
                    c.IDASAL = int.Parse(dt.Rows[0]["IDASAL"].ToString());
                    c.IDTUJUAN = int.Parse(dt.Rows[0]["IDTUJUAN"].ToString());
                    type = 1;
                }

            }
        }
        void DELETE()
        {
            if (dgvPRICELIST.SelectedCells.Count > 0)
            {
                string idpricelist = dgvPRICELIST.SelectedCells[0].OwningRow.Cells["IDPRICELIST"].Value.ToString();
                string tujuan = dgvPRICELIST.SelectedCells[0].OwningRow.Cells["KTUJUAN"].Value.ToString();
                c.IDPRICELIST = int.Parse(idpricelist);
                DialogResult dr = MessageBox.Show("APAKAH YAKIN AKAN DELETE DATA : " + tujuan + " ?", "WARNING", MessageBoxButtons.OKCancel, MessageBoxIcon.Stop);
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

            MASTER.REPORT.FormViewerPRICELIST frm = new MASTER.REPORT.FormViewerPRICELIST(dtPRINTB, 0);

            frm.ShowDialog();
        }

        private void dgvPRICELIST_KeyUp(object sender, KeyEventArgs e)
        {
          
        }

        private void btnKELUAR_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtKODETERUSAN_KeyUp(object sender, KeyEventArgs e)
        {
            // GetAutoSourceCollectionFromTable()
            //GetAutoSourceCollectionFromTable();
        }
       
    }
}















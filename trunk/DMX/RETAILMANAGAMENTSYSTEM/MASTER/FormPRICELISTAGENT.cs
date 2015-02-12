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
    public partial class FormPRICELISTAGENT : Form
    {
        protected RMS.BUSSINES.MASTER.RMS_SUPPLIER bCUST = new RMS.BUSSINES.MASTER.RMS_SUPPLIER();
        protected RMS.COMMON.MASTER.RMS_SUPPLIER cCUST = new RMS.COMMON.MASTER.RMS_SUPPLIER();

        protected RMS.BUSSINES.MASTER.RMS_KOTA bKOTA = new RMS.BUSSINES.MASTER.RMS_KOTA();
        protected RMS.COMMON.MASTER.RMS_KOTA cKOTA = new RMS.COMMON.MASTER.RMS_KOTA();

        protected RMS.BUSSINES.MASTER.RMS_PRICELISTAGENT b = new RMS.BUSSINES.MASTER.RMS_PRICELISTAGENT();
        protected RMS.COMMON.MASTER.RMS_PRICELISTAGENT c = new RMS.COMMON.MASTER.RMS_PRICELISTAGENT();
        protected RMS.COMMON.GENERAL.RMS_COMBO combo = new RMS.COMMON.GENERAL.RMS_COMBO();
        protected RMS.BUSSINES.GENERAL.RMS_COMBO comboQuery = new RMS.BUSSINES.GENERAL.RMS_COMBO();

        protected RMS.BUSSINES.MASTER.RMS_TENTANGPERUSAHAAN bPersusahaan = new RMS.BUSSINES.MASTER.RMS_TENTANGPERUSAHAAN();
        protected RMS.COMMON.MASTER.RMS_TENTANGPERUSAHAAN cPersusahaan = new RMS.COMMON.MASTER.RMS_TENTANGPERUSAHAAN();

        string kodePerusahaan, namaPerusahaan, alamatPerusahaan, telpPerusahaan, faxPerusahaan;

        DataTable dtPRINT;
        int type = 0;
        public FormPRICELISTAGENT()
        {
            InitializeComponent();
            loadCOMBO();
            INIT_PERUSAHAAN();
            SETTING_MANUAL();
            LOAD_DATA();
            cboJNSCOST.Text = "DELIVERY";
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
            this.dgvPRICELIST.Size = new Size(1281, 240);
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
            dtPRINT = new DataTable();
            // dtPRINT = null;
            dtPRINT.Columns.Add("NAMA", typeof(string));
            dtPRINT.Columns.Add("SERVICE", typeof(string));
            dtPRINT.Columns.Add("HANDLING", typeof(string));
            dtPRINT.Columns.Add("JENISCOST", typeof(string));
            dtPRINT.Columns.Add("BASAL", typeof(string));
            dtPRINT.Columns.Add("BTUJUAN", typeof(string));
            dtPRINT.Columns.Add("BKODE", typeof(string));
            dtPRINT.Columns.Add("BHARGA", typeof(string));
            dtPRINT.Columns.Add("BWAKTU", typeof(string));
            dtPRINT.Columns.Add("NAMAPERUSAHAAN", typeof(string));
            dtPRINT.Columns.Add("ALAMATPERUSAHAAN", typeof(string));
            dtPRINT.Columns.Add("TELPPERUSAHAAN", typeof(string));
            dtPRINT.Columns.Add("FAXPERUSAHAAN", typeof(string));
            dtPRINT.Columns.Add("NO", typeof(string));
        

            bool isTrue = true;
            string JENISCOST;
            string BASAL = "";
            string BTUJUAN = "";
            string BKODE = "";
            string BHARGA = "";
            string BWAKTU = "";
            if (dt.Rows.Count > 0)
            {
                int no_urut = 1;
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    string NAMA = dt.Rows[i]["NAMAAGENT"].ToString();
                    string IDPRICELIST = dt.Rows[i]["IDPRICELIST"].ToString();
                    string SERVICE = dt.Rows[i]["KODELAYANAN"].ToString();
                    string HANDLING = dt.Rows[i]["NAMAJNSKIRIM"].ToString();
                    string JNSCOST = dt.Rows[i]["JNSCOST"].ToString();
                    string ASAL = dt.Rows[i]["NAMAKOTA"].ToString();
                    string TUJUAN = dt.Rows[i]["NAMAKOTATUJUAN"].ToString();
                    string TERUSAN = dt.Rows[i]["NAMATERUSAN"].ToString();
                    string CHARGE = dt.Rows[i]["CHARGE"].ToString();
                    //string REFUND = dt.Rows[i]["REFUND"].ToString();
                    string DURASI = dt.Rows[i]["DURASIWAKTU"].ToString();
                    string IDASAL = dt.Rows[i]["IDKOTA"].ToString();
                    string IDTUJUAN = dt.Rows[i]["IDKOTATUJUAN"].ToString();
                    bool ISAKTIF = bool.Parse(dt.Rows[i]["ISAKTIF"].ToString());

                    string kodecust = dt.Rows[i]["KODEAGENT"].ToString();
                    string customer = dt.Rows[i]["NAMAAGENT"].ToString();
                    string kasal = dt.Rows[i]["KODEKOTA"].ToString();
                    string ktujuan = dt.Rows[i]["KODEKOTATUJUAN"].ToString();

                    dgvPRICELIST.Rows.Add(IDPRICELIST, SERVICE, HANDLING, JNSCOST, ASAL, TUJUAN, TERUSAN, CHARGE, DURASI, ISAKTIF);
                    if (ISAKTIF)
                    {                                               
                            /// dtPRINTB.Rows.Add();
                            JENISCOST = JNSCOST;
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

                            dtPRINT.Rows.Add(NAMA, SERVICE, HANDLING, JENISCOST, BASAL, BTUJUAN, BKODE, BHARGA, BWAKTU, namaPerusahaan, alamatPerusahaan, telpPerusahaan, faxPerusahaan,no_urut);
                            no_urut++;
                       
                    }
                    else
                    {
                        dgvPRICELIST.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                    }
                    
                }
            }
        }

        private void txtCARI_TextChanged(object sender, EventArgs e)
        {
                dgvCUSTOMER.DataSource = null;
                dgvCUSTOMER.Rows.Clear();

                cCUST.NAMA = txtCARI.Text;
                cCUST.KODE = txtCARI.Text;
                cCUST.HANDLING = txtCARI.Text;
                DataTable dt = bCUST.SEARCH_BYNAMA(cCUST);
               
                if (dt.Rows.Count > 0)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        string id = dt.Rows[i]["IDAGENT"].ToString();
                        string kode = dt.Rows[i]["KODEAGENT"].ToString();
                        string namaC = dt.Rows[i]["NAMAAGENT"].ToString();
                        string alamat = dt.Rows[i]["ALAMAT"].ToString();
                        string telp = dt.Rows[i]["TELEPON"].ToString();
                        dgvCUSTOMER.Rows.Add(id, kode, namaC, alamat, telp);
                    }
                

            }
        }

        private void txtCARI_KeyUp(object sender, KeyEventArgs e)
        {
            pnlCUSTOMER.Visible = true;
            pnlCUSTOMER.BringToFront();
            panel1.BringToFront();
            dgvCUSTOMER.BringToFront();
        }

        private void dgvCUSTOMER_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvCUSTOMER.SelectedCells.Count > 0)
            {
                string kode = dgvCUSTOMER.SelectedCells[0].OwningRow.Cells["KODE"].Value.ToString();
                string nama = dgvCUSTOMER.SelectedCells[0].OwningRow.Cells["NAMA"].Value.ToString();
                txtCUSTOMER.Text = nama;
                c.KODEAGENT = kode;
                c.IDAGENT = int.Parse(dgvCUSTOMER.SelectedCells[0].OwningRow.Cells["IDAGENT"].Value.ToString());
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
            cboJNSCOST.Visible = true;
            txtKODEASAL.Visible = true;
            txtKODETUJUAN.Visible = true;
            txtKODETERUSAN.Visible = true;
            txtCHARGE.Visible = true;
           
            txtTAMBAH.Visible = true;
            txtDURASI.Visible = true;
        }
        private void disableTAMBAH()
        {
            cboHANDLING.Visible = false;
            cboLAYANAN.Visible = false;
            cboJNSCOST.Visible = false;
            txtKODEASAL.Visible = false;
            txtKODETUJUAN.Visible = false;
            txtKODETUJUAN.Visible = false;
            txtCHARGE.Visible = false;
            
            txtTAMBAH.Visible = false;
            txtDURASI.Visible = false;
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
                    }

                }
            }
            else
            {
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

            c.JNSCOST = cboJNSCOST.Text;
            //c.RC = float.Parse(txtMINIMAL.Text);
            c.CHARGE = float.Parse(txtCHARGE.Text);
            c.DURASIWAKTU = txtDURASI.Text;
            if (string.IsNullOrEmpty(txtKODETERUSAN.Text))
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
                    MessageBox.Show("PRICELIST AGENT : " + c.NAMACUSTOMER + ", SUDAH TERDAFTAR", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    CLEAR();
                    return;
                }
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
           
            chkAKTIF.Checked = false;
        }
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

        private void btnCetak_Click(object sender, EventArgs e)
        {
            

            MASTER.REPORT.FormPRICELISTAGENT frm = new MASTER.REPORT.FormPRICELISTAGENT(dtPRINT, 1);

            frm.ShowDialog();
        }

        private void dgvCUSTOMER_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                if (dgvCUSTOMER.SelectedCells.Count > 0)
                {
                    string kode = dgvCUSTOMER.SelectedCells[0].OwningRow.Cells["KODE"].Value.ToString();
                    string nama = dgvCUSTOMER.SelectedCells[0].OwningRow.Cells["NAMA"].Value.ToString();
                    txtCUSTOMER.Text = nama;
                    c.KODEAGENT = kode;
                    c.IDAGENT = int.Parse(dgvCUSTOMER.SelectedCells[0].OwningRow.Cells["IDAGENT"].Value.ToString());
                    enableTAMBAH();
                    pnlCUSTOMER.Visible = false;
                    LOAD_DATA();
                    txtKODEASAL.Focus();
                }
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
                    cboHANDLING.Text = dt.Rows[0]["NAMAJNSKIRIM"].ToString();
                    cboLAYANAN.Text = dt.Rows[0]["KODELAYANAN"].ToString();
                    cboJNSCOST.Text = dt.Rows[0]["JNSCOST"].ToString();
                    txtKODEASAL.Text = dt.Rows[0]["KODEKOTA"].ToString();
                    txtKODEASAL.BackColor = Color.LimeGreen;
                    txtKODETUJUAN.Text = dt.Rows[0]["KODEKOTATUJUAN"].ToString();
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
                   
                    txtDURASI.Text = dt.Rows[0]["DURASIWAKTU"].ToString();
                    chkAKTIF.Checked = bool.Parse(dt.Rows[0]["ISAKTIF"].ToString());
                    c.IDASAL = int.Parse(dt.Rows[0]["IDKOTA"].ToString());
                    c.IDTUJUAN = int.Parse(dt.Rows[0]["IDKOTATUJUAN"].ToString());
                    c.NAMATERUSAN = dt.Rows[0]["NAMATERUSAN"].ToString();
                    /*
                    if (!string.IsNullOrEmpty(dt.Rows[0]["IDKOTATERUSAN"].ToString()))
                    {
                        c.IDTERUSAN = int.Parse(dt.Rows[0]["IDKOTATERUSAN"].ToString());
                    }
                    else
                    {
                        c.IDTERUSAN = 0;
                    }
                     */
                    type = 1;
                }

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

        private void FormPRICELISTAGENT_Load(object sender, EventArgs e)
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

        private void FormPRICELISTAGENT_KeyUp(object sender, KeyEventArgs e)
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

        private void txtKODETERUSAN_TextChanged(object sender, EventArgs e)
        {

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

        private void btnKELUAR_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

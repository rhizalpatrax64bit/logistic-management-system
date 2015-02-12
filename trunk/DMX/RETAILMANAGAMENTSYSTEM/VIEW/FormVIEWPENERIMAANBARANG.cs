using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LOGISTICMANAGAMENTSYSTEM.VIEW
{
    public partial class FormVIEWPENERIMAANBARANG : Form
    {
        protected RMS.BUSSINES.EXPRESS.RMS_TRANSAKSI b = new RMS.BUSSINES.EXPRESS.RMS_TRANSAKSI();
        protected RMS.COMMON.EXPRESS.RMS_TRANSAKSI c = new RMS.COMMON.EXPRESS.RMS_TRANSAKSI();
        protected RMS.COMMON.GENERAL.RMS_COMBO combo = new RMS.COMMON.GENERAL.RMS_COMBO();
        protected RMS.BUSSINES.GENERAL.RMS_COMBO comboQuery = new RMS.BUSSINES.GENERAL.RMS_COMBO();
        EXPRESS.FormENTRYPENGIRIMANBARANG frm;

        int type;
        DataTable table;
        DataTable dt;
        public FormVIEWPENERIMAANBARANG(EXPRESS.FormENTRYPENGIRIMANBARANG _frm,DataTable dataDetail, int _type)
        {
            InitializeComponent();
            loadCOMBO();
            type = _type;
            frm = _frm;
            LOAD_DATA();
            if (_type != 1)
            {
                // ini dikirim dari form sebelumnya
                table = dataDetail;
            }
        }
        public void LOAD_DATA()
        {
            //c.STATUSORDER = cboSTATUS.Text.ToString(); sudah di inisialisasi di cbo text changed index
            c.STARTDATE = dtStart.Value.ToString("yyyy-MM-dd");
            c.ENDDATE = dtEnd.Value.ToString("yyyy-MM-dd");

            dgvRESIPENGIRIMAN.DataSource = null;
            dgvRESIPENGIRIMAN.Rows.Clear();
            DataTable dt;
            //SET_PRINT();
            //dgvRESIPENGIRIMAN.AllowUserToAddRows = false;
            //dgvRESIPENGIRIMAN.AllowUserToDeleteRows = false;
            //dgvRESIPENGIRIMAN.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            if (string.IsNullOrEmpty(c.NAMACUSTOMER))
            {
                dt = b.SELECT(c);
            }
            else
            {
                dt = b.SELECTLIKE(c);
            }
           
            if (dt.Rows.Count > 0)
            {

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    string ALAMATDETAIL;
                    bool isCheck = true;
                    string ID = dt.Rows[i]["ID"].ToString();
                    string STATUSORDER = dt.Rows[i]["STATUS"].ToString();
                    string NORESI = dt.Rows[i]["NORESI"].ToString();
                    string TGLTERIMA = dt.Rows[i]["TGLTERIMA"].ToString();
                    string ETD = dt.Rows[i]["TGLESTIMASI"].ToString();
                    string CUSTOMER = dt.Rows[i]["NAMACUSTOMER"].ToString();
                    string ASAL = dt.Rows[i]["KOTAASAL"].ToString();
                    string TUJUAN = dt.Rows[i]["KOTATUJUAN"].ToString();
                    string PENERIMA = dt.Rows[i]["NAMAPENERIMA"].ToString();
                    string ALAMAT = dt.Rows[i]["ALAMATPENERIMA"].ToString();
                    string TELEPON = dt.Rows[i]["TELEPONPENERIMA"].ToString();
                    string FAX = dt.Rows[i]["FAXPENERIMA"].ToString();
                    string HP = dt.Rows[i]["HPPENERIMA"].ToString();
                    string EMAIL = dt.Rows[i]["EMAILPENERIMA"].ToString();
                    ALAMATDETAIL = "Alamat :" + ALAMAT + ", Telp :" + TELEPON + ", Fax :" + FAX + ", Hp :" + HP + ", Email :" + EMAIL;
                    string SERVICE = dt.Rows[i]["PRODUK"].ToString();
                    string JENISKIRIMAN = dt.Rows[i]["JENISKIRIMAN"].ToString();
                    string JUMLAH = dt.Rows[i]["JUMLAH"].ToString();
                    string BERAT = dt.Rows[i]["BERAT"].ToString();
                    string CHARGE = int.Parse(dt.Rows[i]["CHARGE_KIRIM"].ToString()).ToString("N0");
                    string OTHER = int.Parse(dt.Rows[i]["TOTHER"].ToString()).ToString("N0");
                    string DISKON = int.Parse(dt.Rows[i]["DISKON"].ToString()).ToString("N0");
                    string TOTAL = int.Parse(dt.Rows[i]["TOTAL"].ToString()).ToString("N0");

                    dgvRESIPENGIRIMAN.Rows.Add(isCheck, ID, STATUSORDER, NORESI, TGLTERIMA, ETD, CUSTOMER, ASAL, TUJUAN, PENERIMA, ALAMATDETAIL,TELEPON,FAX,HP,EMAIL,SERVICE, JENISKIRIMAN, JUMLAH, BERAT, CHARGE, OTHER, DISKON, TOTAL);
                    
                   
                }

            }

        }
        void SETTING_MANUAL()
        {
            this.Size = new Size(1365, 608);

        }
       
        public void loadCOMBO()
        {
            this.setCOMBO();

            DataRow drSTATUS = ((DataRowView)cboSTATUS.SelectedItem).Row;


            c.STATUS = int.Parse(drSTATUS["ID"].ToString());
            c.STATUSORDER = drSTATUS["STATUS"].ToString();


        }
        public void setCOMBO()
        {

            DataTable dtSTATUSORDER = new DataTable();
            dtSTATUSORDER = comboQuery.SELECTSTATUSORDER();

            cboSTATUS.DataSource = dtSTATUSORDER;
            cboSTATUS.ValueMember = dtSTATUSORDER.Columns[0].ColumnName;
            cboSTATUS.DisplayMember = dtSTATUSORDER.Columns[2].ColumnName;



        }
        
        private void btnCARI_Click(object sender, EventArgs e)
        {
            LOAD_DATA();
        }

        
        public DataTable GetTableSO()
        {
            table = new DataTable();
            table.Columns.Add("IDSPJDETAIL", typeof(string));
            table.Columns.Add("STATUS", typeof(string));
            table.Columns.Add("NORESI", typeof(string));
            table.Columns.Add("NAMAPENERIMA", typeof(string));
            table.Columns.Add("ALAMATPENERIMA", typeof(string));
            table.Columns.Add("TELEPONPENERIMA", typeof(string));
            table.Columns.Add("FAXPENERIMA", typeof(string));
            table.Columns.Add("HPPENERIMA", typeof(string));
            table.Columns.Add("EMAILPENERIMA", typeof(string));
            table.Columns.Add("NAMALAYANAN", typeof(string));
            table.Columns.Add("JENISKIRIMAN", typeof(string));
            table.Columns.Add("BERAT", typeof(string));
            table.Columns.Add("JUMLAH", typeof(string));
            table.Columns.Add("TOTAL", typeof(string));
            table.Columns.Add("ETD", typeof(string));

            return table;


        }

        private void btnTAMBAH_Click(object sender, EventArgs e)
        {
            // 1 insert
            if (type == 1)
            {
                dt = GetTableSO();
            }
            else
            {
                dt = table;
            }
                foreach (DataGridViewRow row in dgvRESIPENGIRIMAN.Rows)
                {
                    // gv.Rows[i][column1].Tostring();
                    int test = int.Parse(row.Cells["ID"].Value.ToString());
                    if (Convert.ToBoolean(row.Cells[0].Value))
                    {
                        DataRow rows = dt.NewRow();
                        string d = row.Cells["PENERIMA"].Value.ToString();
                        rows["IDSPJDETAIL"] = DBNull.Value;
                        rows["STATUS"] = row.Cells["STATUS"].Value.ToString();
                        rows["NORESI"] = row.Cells["NORESI"].Value.ToString();
                        rows["NAMAPENERIMA"] = row.Cells["PENERIMA"].Value.ToString();
                        rows["ALAMATPENERIMA"] = row.Cells["ALAMAT"].Value.ToString();
                        rows["NAMALAYANAN"] = row.Cells["SERVICE"].Value.ToString();
                        rows["JENISKIRIMAN"] = row.Cells["JENISKIRIMAN"].Value.ToString();
                        rows["BERAT"] = row.Cells["BERAT"].Value.ToString();
                        rows["JUMLAH"] = row.Cells["JUMLAH"].Value.ToString();
                        rows["TOTAL"] = row.Cells["TOTAL"].Value.ToString();
                        rows["ETD"] = DateTime.Parse(row.Cells["ETD"].Value.ToString());
                        dt.Rows.Add(rows);
                        dt.AcceptChanges();
                    }
                }


                frm.GET_DETAIL(dt, type);
            this.Close();
        }

        private void dgvRESIPENGIRIMAN_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewCheckBoxCell ch1 = new DataGridViewCheckBoxCell();
            ch1 = (DataGridViewCheckBoxCell)dgvRESIPENGIRIMAN.Rows[dgvRESIPENGIRIMAN.CurrentRow.Index].Cells[0];

            if (ch1.Value == null)
                ch1.Value = false;
            switch (ch1.Value.ToString())
            {
                case "True":
                    ch1.Value = false;
                    break;
                case "False":
                    ch1.Value = true;
                    break;
            }
            MessageBox.Show("ANDA YAKIN UNTUK TIDAK MEMASUKAN NO RESI INI ??", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }
    }
}

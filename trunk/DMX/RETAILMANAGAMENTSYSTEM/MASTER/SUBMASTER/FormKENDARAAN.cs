using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LOGISTICMANAGAMENTSYSTEM.MASTER.SUBMASTER
{
    public partial class FormKENDARAAN : Form
    {
        protected RMS.BUSSINES.MASTER.RMS_KENDARAAN b = new RMS.BUSSINES.MASTER.RMS_KENDARAAN();
        protected RMS.COMMON.MASTER.RMS_KENDARAAN c = new RMS.COMMON.MASTER.RMS_KENDARAAN();
        protected RMS.COMMON.GENERAL.RMS_COMBO combo = new RMS.COMMON.GENERAL.RMS_COMBO();
        protected RMS.BUSSINES.GENERAL.RMS_COMBO comboQuery = new RMS.BUSSINES.GENERAL.RMS_COMBO();

        MASTER.FormKENDARAAN frm;
        int Type;
        public FormKENDARAAN(MASTER.FormKENDARAAN _frm, int _Type, RMS.COMMON.MASTER.RMS_KENDARAAN obj)
        {
            InitializeComponent();
            this.frm = _frm;
            Type = _Type;
            loadCOMBO();
            if (Type == 1)
            {
                LOAD_DATA(obj);
                
            }
          
        }
        void LOAD_DATA(RMS.COMMON.MASTER.RMS_KENDARAAN obj)
        {
            c.ID = obj.ID;
            txtNOPOL.Enabled = false;

            DataTable dt = b.SEARCH_BYKODE(obj);
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    string test = dt.Rows[i]["JENISKENDARAAN"].ToString();
                    cboJENISKENDARAAN.Text = dt.Rows[i]["JENISKENDARAAN"].ToString();
                    txtNOPOL.Text = dt.Rows[i]["NOPOL"].ToString();
                    txtMAXMUATAN.Text = dt.Rows[i]["MAXMUATAN"].ToString();
                    txtMAXVOLUME.Text = dt.Rows[i]["MAXVOLUME"].ToString();
                    if(!string.IsNullOrEmpty(dt.Rows[i]["IDDRIVER"].ToString()))
                    {
                        c.IDDRIVER = Convert.ToInt32(dt.Rows[i]["IDDRIVER"].ToString());
                    }
                    if (!string.IsNullOrEmpty(dt.Rows[i]["IDHELPER"].ToString()))
                    {
                        c.IDHELPER = Convert.ToInt32(dt.Rows[i]["IDHELPER"].ToString());
                    }
                    txtKODEDRIVER.Text = dt.Rows[i]["KODEDRIVER"].ToString();
                    txtKODEHELPER.Text = dt.Rows[i]["KODEHELPER"].ToString();
                    txtNAMADRIVER.Text = dt.Rows[i]["NAMADRIVER"].ToString();
                    txtNAMAHELPER.Text = dt.Rows[i]["NAMAHELPER"].ToString();
                    if (Convert.ToBoolean(dt.Rows[0]["STATUS"].ToString()) == true)
                    {
                        chkTERSEDIA.Checked = true;
                    }
                    else
                    {
                        chkTIDAKTERSEDIA.Checked = true;
                    }


                }
            }
             
        }
        public void loadCOMBO()
        {
            this.setCOMBO();

            DataRow drJENISKENDARAAN = ((DataRowView)cboJENISKENDARAAN.SelectedItem).Row;
            c.IDJENISKENDARAAN = int.Parse(drJENISKENDARAAN["ID"].ToString());
            

        }
        public void setCOMBO()
        {
            DataTable dtJENISKENDARAAN = new DataTable();

            dtJENISKENDARAAN = comboQuery.SELECTJENISKENDARAAN();
            cboJENISKENDARAAN.DataSource = dtJENISKENDARAAN;
            cboJENISKENDARAAN.ValueMember = dtJENISKENDARAAN.Columns[0].ColumnName;
            cboJENISKENDARAAN.DisplayMember = dtJENISKENDARAAN.Columns[1].ColumnName;
                     

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
                c.IDHELPER = obj.ID;
                txtKODEHELPER.Text = obj.KODE;
                txtNAMAHELPER.Text = obj.NAMA;
                
               // cPricelist.IDTUJUAN = obj.IDKOTA;
            }


        }
        private void txtKODEDRIVER_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                
                VIEW.FormDRIVERHELPER frm = new LOGISTICMANAGAMENTSYSTEM.VIEW.FormDRIVERHELPER(this,null, "DRIVER", 1);
                frm.ShowDialog();
            }
        }

        private void txtKODEHELPER_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                VIEW.FormDRIVERHELPER frm = new LOGISTICMANAGAMENTSYSTEM.VIEW.FormDRIVERHELPER(this,null, "HELPER", 1);
                frm.ShowDialog();
            }
        }

        private void btnSIMPAN_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNOPOL.Text))
            {
                MessageBox.Show("ISI NOPOL", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtNOPOL.Focus();
                return;
            }

           
            c.NOPOL = txtNOPOL.Text;
            if (Type == 0)
            {
                DataTable dt = b.CARI_BYKODE(c);
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("KODE : " + c.NOPOL + " SUDAH TERDAFTAR", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }
            }

            c.MAXMUATAN = float.Parse(txtMAXMUATAN.Text);
            c.MAXVOLUME = float.Parse(txtMAXVOLUME.Text);
            if (string.IsNullOrEmpty(txtKODEDRIVER.Text))
            {
                c.IDDRIVER = 0;
                // ini nanti event insert dirubah menjadi null insert
            }
            if (string.IsNullOrEmpty(txtKODEHELPER.Text))
            {
                c.IDHELPER = 0;
            }
            if (chkTERSEDIA.Checked == true)
            {
                c.STATUS = true;

            }
            else
            {
                c.STATUS = false;
            }

            if (Type == 0)
            {
                b.INSERT(c);
                this.frm.LOAD_DATA();
            }
            else
            {
                b.UPDATE(c);
                this.frm.LOAD_DATA();
                this.Close();
            }
            CLEAR();
        }

        void CLEAR()
        {
            txtNOPOL.Focus();
            txtNOPOL.Text = "";
            txtKODEDRIVER.Text = "";
            txtKODEHELPER.Text = "";
            txtNAMADRIVER.Text = "";
            txtNAMAHELPER.Text = "";
            txtMAXMUATAN.Text ="";
            txtMAXVOLUME.Text = "";
        
        }

        private void cboJENISKENDARAAN_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!cboJENISKENDARAAN.Focused)
            {
                return;
            }
            else
            {
                DataRow selectedDataRow = ((DataRowView)cboJENISKENDARAAN.SelectedItem).Row;
                c.IDJENISKENDARAAN = Convert.ToInt32(cboJENISKENDARAAN.SelectedValue);

            }
        }

        private void chkTERSEDIA_CheckedChanged(object sender, EventArgs e)
        {
            if (chkTERSEDIA.Checked == true)
            {
                chkTIDAKTERSEDIA.Checked = false;
            }
        }

        private void chkTIDAKTERSEDIA_CheckedChanged(object sender, EventArgs e)
        {
            if (chkTIDAKTERSEDIA.Checked == true)
            {
                chkTERSEDIA.Checked = false;
            }
        }

        private void btnBATAL_Click(object sender, EventArgs e)
        {
            Close();
        }

       

        
     

       
    }
}

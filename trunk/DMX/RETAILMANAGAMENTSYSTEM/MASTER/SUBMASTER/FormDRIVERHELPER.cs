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
    public partial class FormDRIVERHELPER : Form
    {
        protected RMS.BUSSINES.MASTER.RMS_DRIVER b = new RMS.BUSSINES.MASTER.RMS_DRIVER();
        protected RMS.COMMON.MASTER.RMS_DRIVER c = new RMS.COMMON.MASTER.RMS_DRIVER();

        MASTER.FormDRIVER frm;
        int Type;

        public FormDRIVERHELPER(MASTER.FormDRIVER _frm, int _Type, RMS.COMMON.MASTER.RMS_DRIVER obj)
        {
            InitializeComponent();
            this.frm = _frm;
            this.Type = _Type;
            txtKODE.Text = GETKODE();
            txtKODE.ReadOnly = true;
            if (Type == 1)
            {
                LOAD_DATA(obj);
            }
        }

        public string GETKODE()
        {
            string newkode;
            int last_insert;
            int new_insert;
            DataTable dt = b.GETKODE();
            if (dt.Rows.Count > 0)
            {
                last_insert = int.Parse(dt.Rows[0]["LAST_ID"].ToString());
                
            }
            else
            {
                last_insert = 0;
            }
            new_insert = last_insert + 1;
            if (new_insert < 10)
            {
                newkode = "CRW0" + new_insert;
            }
            else
            {
                newkode = "CRW" + new_insert;
            }

            return newkode;
        }
        void LOAD_DATA(RMS.COMMON.MASTER.RMS_DRIVER obj)
        {
            txtKODE.Enabled = false;

           DataTable dt = b.SEARCH_BYKODE(obj);
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    txtKODE.Text = dt.Rows[i]["KODE"].ToString();
                    txtNAMA.Text = dt.Rows[i]["NAMA"].ToString();
                    txtALAMAT.Text = dt.Rows[i]["ALAMAT"].ToString();
                    txtTELP.Text = dt.Rows[i]["TELEPON"].ToString();
                    txtHP.Text = dt.Rows[i]["HP"].ToString();
                    txtEMAIL.Text = dt.Rows[i]["EMAIL"].ToString();

                    if (Convert.ToBoolean(dt.Rows[0]["STATUS"].ToString()) == false)
                    {
                        chkDRIVER.Checked = true;
                    }
                    else
                    {
                        chkHELPER.Checked = true;
                    }
                    

                }
            }
        }

        private void btnBATAL_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSIMPAN_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtKODE.Text))
            {
                MessageBox.Show("ISI KODE", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtKODE.Focus();
                return;
            }

            if (string.IsNullOrEmpty(txtNAMA.Text))
            {
                MessageBox.Show("ISI NAMA ", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtNAMA.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txtALAMAT.Text))
            {
                MessageBox.Show("ISI ALAMAT ", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtALAMAT.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txtHP.Text))
            {
                MessageBox.Show("ISI HP ", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtHP.Focus();
                return;
            }
           

           
            c.KODE = txtKODE.Text;
            if (Type == 0)
            {
                DataTable dt = b.CARI_BYKODE(c);
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("KODE : " + c.KODE + " SUDAH TERDAFTAR", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }
            }

            c.NAMA = txtNAMA.Text;
           
            c.ALAMAT = txtALAMAT.Text;
            c.TELEPON = txtTELP.Text;
            c.HP = txtHP.Text;
            c.EMAIL = txtEMAIL.Text;
            //c.IDMARKETING = int.Parse(txtIDMARKETING.Text);

            if (chkDRIVER.Checked == true)
            {
                c.STATUS = false;

            }
            else
            {
                c.STATUS = true;
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
            txtKODE.Text = "";
            txtNAMA.Focus();
            txtNAMA.Text = "";           
            txtALAMAT.Text = "";
            txtTELP.Text = "";           
            txtHP.Text = "";
            txtEMAIL.Text = "";
            txtKODE.Text = GETKODE(); 
        
        }

        private void chkDRIVER_CheckedChanged(object sender, EventArgs e)
        {
            if (chkDRIVER.Checked == true)
            {
                chkHELPER.Checked = false;
            }
        }

        private void chkHELPER_CheckedChanged(object sender, EventArgs e)
        {
            if (chkHELPER.Checked == true)
            {
                chkDRIVER.Checked = false;
            }
        }

       

    }
}

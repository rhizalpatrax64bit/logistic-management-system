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
    public partial class FormCUSTOMER : Form
    {
        protected RMS.BUSSINES.MASTER.RMS_CUSTOMER b = new RMS.BUSSINES.MASTER.RMS_CUSTOMER();
        protected RMS.COMMON.MASTER.RMS_CUSTOMER c = new RMS.COMMON.MASTER.RMS_CUSTOMER();


        MASTER.FormCUSTOMER frm;
        int Type;
        public FormCUSTOMER(MASTER.FormCUSTOMER _frm, int _Type, RMS.COMMON.MASTER.RMS_CUSTOMER obj)
        {
            InitializeComponent();
            this.frm = _frm;
            this.Type = _Type;
            txtKODE.Text = GETKODE();
            txtKODE.ReadOnly = true;
            cboTYPE.Text = "RETAIL";
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
                newkode = "C0" + new_insert;
            }
            else
            {
                newkode = "C" + new_insert;
            }

            return newkode;
        }
        void LOAD_DATA(RMS.COMMON.MASTER.RMS_CUSTOMER obj)
        {
            txtKODE.Enabled = false;

            DataTable dt = b.SEARCH_BYKODE(obj);
            int TypeCustomer;
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    txtKODE.Text = dt.Rows[i]["KODECUSTOMER"].ToString();
                    txtNAMACUSTOMER.Text = dt.Rows[i]["NAMACUSTOMER"].ToString();
                    txtALAMAT.Text = dt.Rows[i]["ALAMAT"].ToString();
                    txtTELP.Text = dt.Rows[i]["TELEPON"].ToString();
                    txtHP.Text = dt.Rows[i]["HP"].ToString();
                    txtEMAIL.Text = dt.Rows[i]["EMAIL"].ToString();
                    txtKODEMARKETING.Text = dt.Rows[i]["KODEMARKETING"].ToString();
                    txtNAMAMARKETING.Text = dt.Rows[i]["MARKETING"].ToString();                   
                    TypeCustomer = Convert.ToInt32(dt.Rows[i]["TYPE"].ToString());

                    if (TypeCustomer == 1)
                    {
                        cboTYPE.Text = "RETAIL";
                    }
                    else
                    {
                        cboTYPE.Text = "CORPORATE";
                        txtIDMARKETING.Text = dt.Rows[i]["IDMARKETING"].ToString();
                           
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

            if (string.IsNullOrEmpty(txtNAMACUSTOMER.Text))
            {
                MessageBox.Show("ISI NAMA CUSTOMER", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtNAMACUSTOMER.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txtALAMAT.Text))
            {
                MessageBox.Show("ISI NAMA ALAMAT", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtALAMAT.Focus();
                return;
            }

            if (string.IsNullOrEmpty(txtHP.Text))
            {
                MessageBox.Show("ISI NAMA HP", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtHP.Focus();
                return;
            }

            if (string.IsNullOrEmpty(txtTELP.Text))
            {
                MessageBox.Show("ISI NAMA TELEPON", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtTELP.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txtEMAIL.Text))
            {
                MessageBox.Show("ISI NAMA EMAIL", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtEMAIL.Focus();
                return;
            }
            if (c.TYPE == 2)
            {
                if (string.IsNullOrEmpty(txtKODEMARKETING.Text))
                {
                    MessageBox.Show("ISI KODE MARKETING", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    txtNAMAMARKETING.Focus();
                    return;
                }
                else
                {
                    c.IDMARKETING = int.Parse(txtIDMARKETING.Text);
                }
                
            }
            else
            {
                c.IDMARKETING = 0;
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

            c.NAMACUSTOMER = txtNAMACUSTOMER.Text;
           
            c.ALAMAT = txtALAMAT.Text;
            c.TELEPON = txtTELP.Text;
            c.HP = txtHP.Text;
            c.EMAIL = txtEMAIL.Text;
            
                       

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
            GETKODE();
            txtNAMACUSTOMER.Text = "";           
            txtALAMAT.Text = "";
            txtTELP.Text = "";           
            txtHP.Text = "";
            txtKODE.Text = "";
            txtNAMAMARKETING.Text = "";
            txtIDMARKETING.Text = "";
            c.IDMARKETING = 0;
           
        }
        public void GET_DATA_MARKETING(RMS.COMMON.MASTER.RMS_MARKETING obj)
        {
            txtIDMARKETING.Text = obj.ID.ToString();
            txtKODEMARKETING.Text = obj.KODE;
            txtNAMAMARKETING.Text = obj.NAMA;
            
        }
        private void txtBANK_KeyUp(object sender, KeyEventArgs e)
        {
            
        }
        public void GET_DATA_BANK(RMS.COMMON.MASTER.RMS_BANK obj)
        {
           
        }

        private void txtKODEMARKETING_KeyUp(object sender, KeyEventArgs e)
        {
            if (!string.IsNullOrEmpty(txtKODEMARKETING.Text)) return;
            if (e.KeyCode == Keys.Enter)
            {
                VIEW.FormVIEWMARKETING frm = new LOGISTICMANAGAMENTSYSTEM.VIEW.FormVIEWMARKETING(this, 1);
                frm.ShowDialog();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
                      
                VIEW.FormVIEWMARKETING frm = new LOGISTICMANAGAMENTSYSTEM.VIEW.FormVIEWMARKETING(this, 1);
                frm.ShowDialog();
           
        }

        private void txtEMAIL_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                txtHP.Focus();
            }
            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }

        private void txtHP_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                txtTELP.Focus();
            }
            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }

        private void txtTELP_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                txtALAMAT.Focus();
            }
            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }

        private void txtALAMAT_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                txtNAMACUSTOMER.Focus();
            }
            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }

        private void txtNAMACUSTOMER_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                txtKODE.Focus();
            }
            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }

        private void txtKODE_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }

        private void button1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }

        private void cboTYPE_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboTYPE.Text == "RETAIL")
            {
                c.TYPE = 1;
            }
            else
            {
                c.TYPE = 2;
            }
        }
    }
}

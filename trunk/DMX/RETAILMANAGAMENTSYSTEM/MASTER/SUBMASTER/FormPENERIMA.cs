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
    public partial class FormPENERIMA : Form
    {
        protected RMS.BUSSINES.MASTER.RMS_PENERIMA b = new RMS.BUSSINES.MASTER.RMS_PENERIMA();
        protected RMS.COMMON.MASTER.RMS_PENERIMA c = new RMS.COMMON.MASTER.RMS_PENERIMA();


        MASTER.FormPENERIMA frm;
        int Type;
        public FormPENERIMA(MASTER.FormPENERIMA _frm, int _Type, RMS.COMMON.MASTER.RMS_PENERIMA obj)
        {
            InitializeComponent();
            this.frm = _frm;
            this.Type = _Type;
            cboTYPE.Text = "RETAIL";
            if (Type == 1)
            {
                LOAD_DATA(obj);
            }
        }

        void LOAD_DATA(RMS.COMMON.MASTER.RMS_PENERIMA obj)
        {

            c.ID = obj.ID;
            DataTable dt = b.SEARCH_BYKODE(obj);
            int TypeCustomer;
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {

                    txtNAMAPENERIMA.Text = dt.Rows[i]["NAMAPENERIMA"].ToString();
                    txtALAMAT.Text = dt.Rows[i]["ALAMAT"].ToString();
                    txtTELP.Text = dt.Rows[i]["TELEPON"].ToString();
                    txtFAX.Text = dt.Rows[i]["FAX"].ToString();
                    txtHP.Text = dt.Rows[i]["HP"].ToString();
                    txtEMAIL.Text = dt.Rows[i]["EMAIL"].ToString();
                    TypeCustomer = Convert.ToInt32(dt.Rows[i]["TYPE"].ToString());

                    if (TypeCustomer == 1)
                    {
                        cboTYPE.Text = "RETAIL";
                    }
                    else
                    {
                        cboTYPE.Text = "CORPORATE";                      

                    }

                }
            }
        }

        private void btnSIMPAN_Click(object sender, EventArgs e)
        {


            if (string.IsNullOrEmpty(txtNAMAPENERIMA.Text))
            {
                MessageBox.Show("ISI NAMA PENERIMA", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtNAMAPENERIMA.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txtTELP.Text))
            {
                MessageBox.Show("ISI NO TELP", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtTELP.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txtHP.Text))
            {
                MessageBox.Show("ISI NO HP", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtHP.Focus();
                return;
            }

            
            c.KODEPENERIMA = "";
            c.NAMAPENERIMA = txtNAMAPENERIMA.Text;
            c.ALAMAT = txtALAMAT.Text;
            c.TELEPON = txtTELP.Text;
            c.FAX = txtFAX.Text;
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
          
            txtNAMAPENERIMA.Text = "";
            txtALAMAT.Text = "";
            txtTELP.Text = "";
            txtFAX.Text = "";
            txtHP.Text = "";
            txtEMAIL.Text = "";

        }

        private void btnBATAL_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtEMAIL_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                txtHP.Focus();
            }
        }

        private void txtHP_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                txtFAX.Focus();
            }
        }

        private void txtFAX_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                txtTELP.Focus();
            }
        }

        private void txtTELP_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                txtALAMAT.Focus();
            }
        }

        private void txtALAMAT_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                txtNAMAPENERIMA.Focus();
            }
        }

        private void FormPENERIMA_KeyUp(object sender, KeyEventArgs e)
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

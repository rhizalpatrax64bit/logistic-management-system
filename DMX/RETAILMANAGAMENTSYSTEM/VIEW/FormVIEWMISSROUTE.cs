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
    public partial class FormVIEWMISSROUTE : Form
    {

        protected RMS.BUSSINES.EXPRESS.RMS_SPJ b = new RMS.BUSSINES.EXPRESS.RMS_SPJ();
        protected RMS.COMMON.EXPRESS.RMS_SPJ c = new RMS.COMMON.EXPRESS.RMS_SPJ();

        // CATATAN 
        // ID PADA STATUS ORDER SUDAH FIX YA
        
        EXPRESS.FormENTRYPENGIRIMANBARANG frm;
        int Type;
        public FormVIEWMISSROUTE(EXPRESS.FormENTRYPENGIRIMANBARANG _frm, RMS.COMMON.EXPRESS.RMS_SPJ spj, int _Type)
        {
            InitializeComponent();
            this.Type = _Type;
            //txtNORESI.Text = GETKODE();
            c = spj;
            txtNORESI.ReadOnly = true;
            txtNORESI.Text = c.NORESI;
            this.frm = _frm;
            LOAD_DATA(c);
            
        }
        void LOAD_DATA(RMS.COMMON.EXPRESS.RMS_SPJ obj)
        {

            DataTable dt = b.CARI_BYNORESI(obj);

            if (dt.Rows.Count > 0)
            {
                int status = Convert.ToInt32(dt.Rows[0]["status"].ToString());

                
                if (status == 2)
                {
                    rbONTRANSIT.Checked = true;
                    rbONTRANSIT.BackColor = Color.Orange;
                    c.STATUS = 2;
                }
                else if (status == 3)
                {
                    rbANTARULANG.Checked = true;
                    rbANTARULANG.BackColor = Color.Orange;
                    c.STATUS = 3;
                }
                
                else if (status == 4)
                {
                    rbBADADRESS.Checked = true;
                    rbBADADRESS.BackColor = Color.Orange;
                    c.STATUS = 4;
                }
                else if (status == 5)                {

                    rbRECEIVEONDESC.Checked = true;
                    rbRECEIVEONDESC.BackColor = Color.Orange;
                    c.STATUS = 5;
                }
                else if (status == 6)
                {
                    rbMISSROUTE.Checked = true;
                    rbMISSROUTE.BackColor = Color.Orange;
                    c.STATUS = 6;
                }
                else if (status == 7)
                {
                    rbCRISCROSS.Checked = true;
                    rbCRISCROSS.BackColor = Color.Orange;
                    c.STATUS = 7;
                }
                else if (status == 8)
                {
                    rbREDELIVERY.Checked = true;
                    rbREDELIVERY.BackColor = Color.Orange;
                    c.STATUS = 8;
                }
                else if (status == 9)
                {
                    rbCLOSED.Checked = true;
                    rbCLOSED.BackColor = Color.Orange;
                    c.STATUS = 9;
                }
                else if (status == 10)
                {
                    rbDELIVERY.Checked = true;
                    rbDELIVERY.BackColor = Color.Orange;
                    c.STATUS = 10;
                }
                else
                {
                    rbDELIVERYSUCCESS.Checked = true;
                    rbDELIVERYSUCCESS.BackColor = Color.Orange;
                    c.STATUS = 11;
                }

            }
        }

        private void btnTAMBAH_Click(object sender, EventArgs e)
        {
            if (rbONTRANSIT.Checked == true)
            {
                rbONTRANSIT.BackColor = Color.Navy;
                rbONTRANSIT.ForeColor = Color.White;
                c.STATUS = 2;
            }
            else if (rbANTARULANG.Checked == true)
            {
                rbANTARULANG.BackColor = Color.Navy;
                rbANTARULANG.ForeColor = Color.White;
                c.STATUS = 3;
            }
            else if (rbBADADRESS.Checked == true)
            {

                rbBADADRESS.BackColor = Color.Navy;
                rbBADADRESS.ForeColor = Color.White;
                c.STATUS = 4;
            }

            else if (rbRECEIVEONDESC.Checked == true)
            {
                rbRECEIVEONDESC.BackColor = Color.Navy;
                rbRECEIVEONDESC.ForeColor = Color.White;
                c.STATUS = 5;
            }
            else if (rbMISSROUTE.Checked == true)
            {
                
                rbMISSROUTE.BackColor = Color.Navy;
                rbMISSROUTE.ForeColor = Color.White;
                c.STATUS = 6;
            }
            else if (rbCRISCROSS.Checked == true)
            {
                rbCRISCROSS.Checked = true;
                rbCRISCROSS.BackColor = Color.Navy;
                rbCRISCROSS.ForeColor = Color.White;
                c.STATUS = 7;
            }
            else if (rbREDELIVERY.Checked == true)
            {
                rbREDELIVERY.Checked = true;
                rbREDELIVERY.BackColor = Color.Navy;
                rbREDELIVERY.ForeColor = Color.White;
                c.STATUS = 8;
            }
            else if (rbCLOSED.Checked == true)
            {
                rbCLOSED.Checked = true;
                rbCLOSED.BackColor = Color.Navy;
                rbCLOSED.ForeColor = Color.White;
                c.STATUS = 9;
            }
            else if (rbDELIVERY.Checked ==true)
            {
                
                rbDELIVERY.BackColor = Color.Navy;
                rbDELIVERY.ForeColor = Color.White;
                c.STATUS = 10;
            }
            else
            {

                rbDELIVERYSUCCESS.BackColor = Color.Navy;
                rbDELIVERYSUCCESS.ForeColor = Color.White;
                c.STATUS = 11;
            }
            DialogResult dr = MessageBox.Show("APAKAH YAKIN AKAN MERUBAH STATUS RESI : " + c.NORESI + " ?", "WARNING", MessageBoxButtons.OKCancel, MessageBoxIcon.Stop);
            if (dr == DialogResult.OK)
            {
                b.UPDATESTATUSPENGIRIMAN(c);
                frm.LOAD_DETAIL();
                this.Close();
            }
           
        }
       

      

        
    }
}

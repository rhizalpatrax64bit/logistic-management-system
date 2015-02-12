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
    public partial class FormPRICELIST : Form
    {
        protected RMS.BUSSINES.MASTER.RMS_PRICELIST b = new RMS.BUSSINES.MASTER.RMS_PRICELIST();
        protected RMS.COMMON.MASTER.RMS_PRICELIST c = new RMS.COMMON.MASTER.RMS_PRICELIST();
        protected RMS.COMMON.GENERAL.RMS_COMBO combo = new RMS.COMMON.GENERAL.RMS_COMBO();
        protected RMS.BUSSINES.GENERAL.RMS_COMBO comboQuery = new RMS.BUSSINES.GENERAL.RMS_COMBO();
      
        MASTER.FormPRICELIST frm;
        int Type;
        public FormPRICELIST(MASTER.FormPRICELIST _frm, int Type, RMS.COMMON.MASTER.RMS_PRICELIST obj)
        {
            InitializeComponent();
            this.frm = _frm;
            this.Type = Type;

            if (Type == 1)
            {
                //  LOAD_DATA(obj);
            }
            loadCOMBO();
        }

        public void loadCOMBO()
        {
            this.setCOMBO();
           
            DataRow drSERVICE = ((DataRowView)cboSERVICE.SelectedItem).Row;
            DataRow drHANDLING = ((DataRowView)cboHANDLING.SelectedItem).Row;         

            c.IDSERVICE = int.Parse(drSERVICE["IDLAYANAN"].ToString());
            c.IDHANDLING = int.Parse(drHANDLING["IDJNSKIRIM"].ToString());
           

        }
        public void setCOMBO()
        {
            DataTable dtLAYANAN = new DataTable();
            DataTable dtMODAKIRIM = new DataTable();
                     
            dtMODAKIRIM = comboQuery.SELECTMODAKIRIM();
            dtLAYANAN = comboQuery.SELECTLAYANAN();

            cboSERVICE.DataSource = dtLAYANAN;
            cboSERVICE.ValueMember = dtLAYANAN.Columns[0].ColumnName;
            cboSERVICE.DisplayMember = dtLAYANAN.Columns[1].ColumnName;

            cboHANDLING.DataSource = dtMODAKIRIM;
            cboHANDLING.ValueMember = dtMODAKIRIM.Columns[0].ColumnName;
            cboHANDLING.DisplayMember = dtMODAKIRIM.Columns[2].ColumnName;
                 

        }
        private void btnBATAL_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtKODEORIGIN_KeyUp(object sender, KeyEventArgs e)
        {
           
            if (e.KeyCode == Keys.Enter)
            {
               // VIEW.FormVIEWKOTA frm = new LOGISTICMANAGAMENTSYSTEM.VIEW.FormVIEWKOTA(null, this, "ORIGIN", 2);
                frm.ShowDialog();
            }
        }

        private void txtKODEDESTINATION_KeyUp(object sender, KeyEventArgs e)
        {
          
            if (e.KeyCode == Keys.Enter)
            {
                //VIEW.FormVIEWKOTA frm = new LOGISTICMANAGAMENTSYSTEM.VIEW.FormVIEWKOTA(null, this, "DESTINATION", 2);
                frm.ShowDialog();
            }
        }

        private void txtKODETERUSAN_KeyUp(object sender, KeyEventArgs e)
        {
          
            if (e.KeyCode == Keys.Enter)
            {
              //  VIEW.FormVIEWKOTATERUSAN frm = new LOGISTICMANAGAMENTSYSTEM.VIEW.FormVIEWKOTATERUSAN(this, 1);
                frm.ShowDialog();
            }
        }
        public void GET_DATA_KOTATERUSAN(RMS.COMMON.MASTER.RMS_PRICELIST obj)
        {
          
            txtKODETERUSAN.Text = obj.KODEATERUSAN;
            txtNAMATERUSAN.Text = obj.NAMATERUSAN;
            
            c.IDTERUSAN = obj.IDTERUSAN;


        }
        public void GET_DATA_KOTA(RMS.COMMON.MASTER.RMS_PRICELIST obj, string _namaField)
        {
            if (_namaField == "ORIGIN")
            {
                //txtKODEORIGIN.Text = obj.;
                txtKODEORIGIN.Text = obj.KODEAREAASAL;
                txtNAMAORIGIN.Text = obj.NAMAASAL;
                c.IDASAL = obj.IDASAL;
               

            }
            else
            {
                txtKODEDESTINATION.Text = obj.KODEAREATUJUAN;
                txtNAMADESTINATION.Text = obj.NAMATUJUAN;
                c.IDTUJUAN = obj.IDTUJUAN;
            }


        }
        public void GET_DATA_AGENT(RMS.COMMON.MASTER.RMS_PRICELIST obj)
        {
            txtKODEAGENT.Text = obj.KODEAGENT;
            txtNAMAAGENT.Text = obj.NAMAAGENT;
            c.IDAGENT = obj.IDAGENT;

        }

        private void cboSERVICE_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!cboSERVICE.Focused)
            {
                return;
            }
            else
            {
                DataRow selectedDataRow = ((DataRowView)cboSERVICE.SelectedItem).Row;
                c.IDSERVICE = Convert.ToInt32(cboSERVICE.SelectedValue);

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

        private void txtKODEAGENT_KeyUp(object sender, KeyEventArgs e)
        {
           
        }

        private void btnSIMPAN_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtKODEORIGIN.Text))
            {
                MessageBox.Show("ISI KODE ASAL", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtKODEORIGIN.Focus();
                return;
            }
            c.DURASIWAKTU = txtDURASI.Text;
            c.KETERANGAN = txtKETERANGAN.Text;
            c.RC = float.Parse(txtREFUND.Text);
            c.CHARGE = float.Parse(txtCHARGE.Text);
            
            if (Type == 0)
            {
                b.INSERT(c);
                this.frm.LOAD_DATA();
            }
            else
            {
                b.UPDATE(c);
                this.frm.LOAD_DATA();
                Close();
            }
            CLEAR();
        }
        void CLEAR()
        {
            txtKODEORIGIN.Focus();
            txtKODEORIGIN.Text = "";
            txtNAMAORIGIN.Text = "";
            txtKODEDESTINATION.Text = "";
            txtNAMADESTINATION.Text = "";
            txtKODETERUSAN.Text = "";
            txtNAMATERUSAN.Text = "";
            txtDURASI.Text = "";
            txtKETERANGAN.Text = "";
        }
    }
}

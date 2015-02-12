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
    public partial class FormVIEWAGENT : Form
    {
        protected RMS.BUSSINES.MASTER.RMS_SUPPLIER b = new RMS.BUSSINES.MASTER.RMS_SUPPLIER();
        protected RMS.COMMON.MASTER.RMS_SUPPLIER c = new RMS.COMMON.MASTER.RMS_SUPPLIER();
        protected RMS.BUSSINES.MASTER.RMS_PRICELISTAGENT bb = new RMS.BUSSINES.MASTER.RMS_PRICELISTAGENT();
        protected RMS.COMMON.MASTER.RMS_PRICELISTAGENT cc = new RMS.COMMON.MASTER.RMS_PRICELISTAGENT();
        DELIVERYORDER.FormDATAENTRY frm;
        MASTER.SUBMASTER.FormPRICELIST frmPRICELIST;
        string field;
        int type;
        public FormVIEWAGENT(DELIVERYORDER.FormDATAENTRY _frm, MASTER.SUBMASTER.FormPRICELIST _frmPRICELIST, string _field, int _type,RMS.COMMON.MASTER.RMS_PRICELISTAGENT obj)
        {
            InitializeComponent();
            type = _type;
            if (type == 1)
            {
                this.frm = _frm;
                cc = obj;
            }
            else
            {
                this.frmPRICELIST = _frmPRICELIST;
            }
            field = _field;
            if (field == "SMU")
            {
                cc.JNSCOST = "FREIGHT";
            }
            else if (field == "SHIPPING")
            {
                cc.JNSCOST = "SHIPPING";
            }
            else if (field == "DELIVERY")
            {
                cc.JNSCOST = "DELIVERY";
            }
            else if (field == "WAREHOUSE")
            {
                cc.JNSCOST = "WAREHOUSING";
            }
            else if (field == "RA")
            {
                cc.JNSCOST = "RA";
            }
            else if (field == "TRUCKING")
            {
                cc.JNSCOST = "TRUCKING";
            }
            else
            {
                cc.JNSCOST = "GRDH";
            }
            cc.ISAKTIF = true;
            LOAD_DATA();
            this.txtCARI.Focus();
        }
        public void LOAD_DATA()
        {
            dgvAGENT.DataSource = null;
            dgvAGENT.Rows.Clear();
            cc.NAMAAGENT = txtCARI.Text;
            DataTable dt = bb.VSELECT(cc);
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    string id = dt.Rows[i]["IDAGENT"].ToString();
                    string KODELAYANAN = dt.Rows[i]["KODELAYANAN"].ToString();
                    string NAMAJNSKIRIM = dt.Rows[i]["NAMAJNSKIRIM"].ToString();
                    string JNSCOST = dt.Rows[i]["JNSCOST"].ToString();
                    string KODEKOTA = dt.Rows[i]["KODEKOTA"].ToString();
                    string KODEKOTATUJUAN = dt.Rows[i]["KODEKOTATUJUAN"].ToString();
                    string KODEAGENT = dt.Rows[i]["KODEAGENT"].ToString();
                    string NAMAAGENT = dt.Rows[i]["NAMAAGENT"].ToString();
                    string CHARGE = dt.Rows[i]["CHARGE"].ToString();
                    dgvAGENT.Rows.Add(id, KODEAGENT, NAMAAGENT, KODELAYANAN, NAMAJNSKIRIM, JNSCOST, KODEKOTA, KODEKOTATUJUAN, CHARGE);
                }
            }
        }

        private void FormVIEWAGENT_KeyUp(object sender, KeyEventArgs e)
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
                       
                dgvAGENT.DataSource = null;
                dgvAGENT.Rows.Clear();

                cc.NAMAAGENT = txtCARI.Text;
                DataTable dt = bb.VSELECTLIKE(cc);
                if (dt.Rows.Count > 0)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        string id = dt.Rows[i]["IDAGENT"].ToString();
                        string KODELAYANAN = dt.Rows[i]["KODELAYANAN"].ToString();
                        string NAMAJNSKIRIM = dt.Rows[i]["NAMAJNSKIRIM"].ToString();
                        string JNSCOST = dt.Rows[i]["JNSCOST"].ToString();
                        string KODEKOTA = dt.Rows[i]["KODEKOTA"].ToString();
                        string KODEKOTATUJUAN = dt.Rows[i]["KODEKOTATUJUAN"].ToString();
                        string KODEAGENT = dt.Rows[i]["KODEAGENT"].ToString();
                        string NAMAAGENT = dt.Rows[i]["NAMAAGENT"].ToString();
                        string CHARGE = dt.Rows[i]["CHARGE"].ToString();
                        dgvAGENT.Rows.Add(id, KODEAGENT, NAMAAGENT, KODELAYANAN, NAMAJNSKIRIM, JNSCOST, KODEKOTA, KODEKOTATUJUAN, CHARGE);
                    }
                }
        }

        private void dgvAGENT_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvAGENT.SelectedCells.Count > 0)
            {
                if (type == 1)
                {
                    c.KODE = dgvAGENT.SelectedCells[0].OwningRow.Cells["KODE"].Value.ToString();
                    c.NAMA = dgvAGENT.SelectedCells[0].OwningRow.Cells["NAMA"].Value.ToString();
                    c.CHARGE = dgvAGENT.SelectedCells[0].OwningRow.Cells["BIAYA"].Value.ToString();
                    this.frm.GET_DATA_AGENT(c, field);
                }
                
                
                Close();
            }
        }

        private void dgvAGENT_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvAGENT_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                c.KODE = dgvAGENT.SelectedCells[0].OwningRow.Cells["KODE"].Value.ToString();
                c.NAMA = dgvAGENT.SelectedCells[0].OwningRow.Cells["NAMA"].Value.ToString();
                c.CHARGE = dgvAGENT.SelectedCells[0].OwningRow.Cells["BIAYA"].Value.ToString();
                
                this.frm.GET_DATA_AGENT(c, field);
                Close();
            }
        }
    }
}

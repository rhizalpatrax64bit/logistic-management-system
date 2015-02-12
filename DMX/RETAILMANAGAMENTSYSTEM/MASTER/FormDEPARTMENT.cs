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
    public partial class FormDEPARTMENT : Form
    {
        protected RMS.BUSSINES.MASTER.RMS_DEPARTMENT b = new RMS.BUSSINES.MASTER.RMS_DEPARTMENT();
        protected RMS.COMMON.MASTER.RMS_DEPARTMENT c = new RMS.COMMON.MASTER.RMS_DEPARTMENT();

        public FormDEPARTMENT()
        {
            InitializeComponent();
            SETTING_MANUAL();
            LOAD_DATA();
        }
        void SETTING_MANUAL()
        {
            this.Size = new Size(1365, 608);
            this.dgvDEPARTMENT.Size = new Size(1360, 520);
            this.panelBUTTON.Location = new Point(2, 560);
            this.panelCARI.Location = new Point(814, 4);
        }
        private void btnTAMBAH_Click(object sender, EventArgs e)
        {
            MASTER.SUBMASTER.FormDEPARTMENT frm = new LOGISTICMANAGAMENTSYSTEM.MASTER.SUBMASTER.FormDEPARTMENT(this, 0, null);
            frm.ShowDialog();
        }
        private void btnKELUAR_Click(object sender, EventArgs e)
        {
            Close();
        }
        public void LOAD_DATA()
        {
            dgvDEPARTMENT.DataSource = null;
            dgvDEPARTMENT.Rows.Clear();
            DataTable dt = b.SELECT();
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    string KODE = dt.Rows[i]["KODEDEPARTMENT"].ToString();
                    string NAMA = dt.Rows[i]["NAMADEPARTMENT"].ToString();
                    string MIN = dt.Rows[i]["MINMARGIN"].ToString();
                    string MAX = dt.Rows[i]["MAXMARGIN"].ToString();
                    dgvDEPARTMENT.Rows.Add(KODE, NAMA, MIN, MAX);
                }
            }
        }

        private void btnEDIT_Click(object sender, EventArgs e)
        {
            if (dgvDEPARTMENT.SelectedCells.Count > 0)
            {
                string kode = dgvDEPARTMENT.SelectedCells[0].OwningRow.Cells["KODE"].Value.ToString();
                c.KODE = kode;
                MASTER.SUBMASTER.FormDEPARTMENT frm = new LOGISTICMANAGAMENTSYSTEM.MASTER.SUBMASTER.FormDEPARTMENT(this, 1, c);
                frm.ShowDialog();
            }
        }

        private void btnHAPUS_Click(object sender, EventArgs e)
        {
            if (dgvDEPARTMENT.SelectedCells.Count > 0)
            {
                string kode = dgvDEPARTMENT.SelectedCells[0].OwningRow.Cells["KODE"].Value.ToString();
                string nama = dgvDEPARTMENT.SelectedCells[0].OwningRow.Cells["NAMA"].Value.ToString();
                c.KODE = kode;
                DialogResult dr = MessageBox.Show("APAKAH YAKIN AKAN DELETE DATA : " + nama + " ?", "WARNING", MessageBoxButtons.OKCancel, MessageBoxIcon.Stop);
                if (dr == DialogResult.OK)
                {
                    b.DELETE(c);
                    LOAD_DATA();
                }
            }
        }

        private void txtCARI_TextChanged(object sender, EventArgs e)
        {
            if (rdbKODE.Checked == true)
            {
                dgvDEPARTMENT.DataSource = null;
                dgvDEPARTMENT.Rows.Clear();

                c.KODE = txtCARI.Text;
                DataTable dt = b.SEARCH_BYKODE(c);
                if (dt.Rows.Count > 0)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        string KODE = dt.Rows[i]["KODEDEPARTMENT"].ToString();
                        string NAMA = dt.Rows[i]["NAMADEPARTMENT"].ToString();
                        string MIN = dt.Rows[i]["MINMARGIN"].ToString();
                        string MAX = dt.Rows[i]["MAXMARGIN"].ToString();
                        dgvDEPARTMENT.Rows.Add(KODE, NAMA, MIN, MAX);
                    }
                }
            }

            if (rdbNAMA.Checked == true) 
            {
                dgvDEPARTMENT.DataSource = null;
                dgvDEPARTMENT.Rows.Clear();

                c.NAMA = txtCARI.Text;
                DataTable dt = b.SEARCH_BYNAMA(c);
                if (dt.Rows.Count > 0)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        string KODE = dt.Rows[i]["KODEDEPARTMENT"].ToString();
                        string NAMA = dt.Rows[i]["NAMADEPARTMENT"].ToString();
                        string MIN = dt.Rows[i]["MINMARGIN"].ToString();
                        string MAX = dt.Rows[i]["MAXMARGIN"].ToString();
                        dgvDEPARTMENT.Rows.Add(KODE, NAMA, MIN, MAX);
                    }
                }

            }
        }

        private void FormDEPARTMENT_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F3)
            {
                rdbKODE.Checked = true;
                txtCARI.Text = "";
                txtCARI.Focus();
            }

            if (e.KeyCode == Keys.F4)
            {
                rdbNAMA.Checked = true;
                txtCARI.Text = "";
                txtCARI.Focus();
            }
        }
    }
}

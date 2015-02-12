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
    public partial class FormUSER : Form
    {
        protected RMS.BUSSINES.MASTER.RMS_USER b = new RMS.BUSSINES.MASTER.RMS_USER();
        protected RMS.COMMON.MASTER.RMS_USER c = new RMS.COMMON.MASTER.RMS_USER();
        int id;
        int type = 0;
        public FormUSER()
        {
            InitializeComponent();
            cboLEVEL.Text = "OPERATOR";
            if (type == 0)
            {
                LOAD_DATA();
            }
            
        }

        public void LOAD_DATA()
        {
            dgvUSER.DataSource = null;
            dgvUSER.Rows.Clear();
              DataTable dt;
              dt = b.SELECT();
            /*
            if (type == 0)
            {
              dt = b.SELECT();
            }
            else
            {
                dt = b.CARI_BYKODE(c);
            }
            */
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    string id = dt.Rows[i]["id"].ToString();
                    string nama = dt.Rows[i]["nama"].ToString();
                    string level = dt.Rows[i]["level"].ToString();
                    string username = dt.Rows[i]["username"].ToString();
                    string password = dt.Rows[i]["password"].ToString();
                    string hp = dt.Rows[i]["hp"].ToString();
                    string alamat = dt.Rows[i]["alamat"].ToString();
                    string isaktif = dt.Rows[i]["isaktif"].ToString();
                    string isbiayastt = dt.Rows[i]["isbiayastt"].ToString();
                    string ispiutang = dt.Rows[i]["ispiutang"].ToString();
                    string ismasterdata = dt.Rows[i]["ismasterdata"].ToString();
                    string isagent = dt.Rows[i]["isagent"].ToString();
                    string ispricelist = dt.Rows[i]["ispricelist"].ToString();
                    string isuser = dt.Rows[i]["isuser"].ToString();
                    string islaporan = dt.Rows[i]["islaporan"].ToString();
                    string iscourier = dt.Rows[i]["iscourier"].ToString();
                    dgvUSER.Rows.Add(id, nama, level, username, password, hp, alamat, isaktif, isbiayastt, ispiutang, ismasterdata, isagent, ispricelist, isuser, islaporan, iscourier);
                }
            }

        }

        private void btnEDIT_Click(object sender, EventArgs e)
        {
            if (dgvUSER.SelectedCells.Count > 0)
            {

                string id = dgvUSER.SelectedCells[0].OwningRow.Cells["IDUSER"].Value.ToString();
                string nama = dgvUSER.SelectedCells[0].OwningRow.Cells["NAMA"].Value.ToString();
                string level = dgvUSER.SelectedCells[0].OwningRow.Cells["LEVEL"].Value.ToString();
                string username = dgvUSER.SelectedCells[0].OwningRow.Cells["USERNAME"].Value.ToString();
                string password = dgvUSER.SelectedCells[0].OwningRow.Cells["PASSWORD"].Value.ToString();
                string hp = dgvUSER.SelectedCells[0].OwningRow.Cells["HP"].Value.ToString();
                string alamat = dgvUSER.SelectedCells[0].OwningRow.Cells["ALAMAT"].Value.ToString();
                bool isaktif = bool.Parse(dgvUSER.SelectedCells[0].OwningRow.Cells["ISAKTIF"].Value.ToString());
                bool isbiayastt = bool.Parse(dgvUSER.SelectedCells[0].OwningRow.Cells["ISBIAYASTT"].Value.ToString());
                bool ispiutang = bool.Parse(dgvUSER.SelectedCells[0].OwningRow.Cells["ISPIUTANG"].Value.ToString());
                bool ismasterdata = bool.Parse(dgvUSER.SelectedCells[0].OwningRow.Cells["ISMASTERDATA"].Value.ToString());
                bool isagent = bool.Parse(dgvUSER.SelectedCells[0].OwningRow.Cells["ISAGENT"].Value.ToString());
                bool ispricelist = bool.Parse(dgvUSER.SelectedCells[0].OwningRow.Cells["ISPRICELIST"].Value.ToString());
                bool isuser = bool.Parse(dgvUSER.SelectedCells[0].OwningRow.Cells["ISUSER"].Value.ToString());
                bool islaporan = bool.Parse(dgvUSER.SelectedCells[0].OwningRow.Cells["ISLAPORAN"].Value.ToString());
                bool iscourier = bool.Parse(dgvUSER.SelectedCells[0].OwningRow.Cells["ISCOURIER"].Value.ToString());

                c.id = int.Parse(id);
                c.nama = nama; txtNAMA.Text = c.nama;
                c.level = level; cboLEVEL.Text = c.level;
                c.username = username; txtUSERNAME.Text = c.username;
                c.password = password; txtPASSWORD.Text = b.DecodePassword(c);
                c.hp = hp; txtHP.Text = c.hp;
                c.alamat = alamat; txtALAMAT.Text = c.alamat;
                c.isaktif = isaktif; if (c.isaktif) { chkISAKTIF.Checked = true; } else{chkISAKTIF.Checked = false;}
                c.isbiayastt = isbiayastt; if (c.isbiayastt) { chkISTRANSAKSIBIAYASTT.Checked = true; } else { chkISTRANSAKSIBIAYASTT.Checked = false; }
                c.ispiutang = ispiutang; if (c.ispiutang) { chkISPIUTANG.Checked = true; } else { chkISPIUTANG.Checked = false; }
                c.ismasterdata = ismasterdata; if (c.ismasterdata) { chkISMASTERDATA.Checked = true; } else { chkISMASTERDATA.Checked = false; }
                c.isagent = isagent; if (c.isagent) { chkISAGENT.Checked = true; } else { chkISAGENT.Checked = false; }
                c.ispricelist = ispricelist; if (c.ispricelist) { chkISPRICELIST.Checked = true; } else { chkISPRICELIST.Checked = false; }
                c.isuser = isuser; if (c.isuser) { chkISSETTINGUSER.Checked = true; } else { chkISSETTINGUSER.Checked = false; }
                c.islaporan = islaporan; if (c.islaporan) { chkLAPORAN.Checked = true; } else { chkLAPORAN.Checked = false; }
                c.iscourier = iscourier; if (c.iscourier) { chkISCOURIER.Checked = true; } else { chkISCOURIER.Checked = false; }
               
                type = 1;

            }
        }

        private void btnSIMPAN_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNAMA.Text))
            {
                MessageBox.Show("ISI NAMA", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtNAMA.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txtHP.Text))
            {
                MessageBox.Show("ISI HP", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtHP.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txtUSERNAME.Text))
            {
                MessageBox.Show("ISI USERNAME", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtHP.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txtPASSWORD.Text))
            {
                MessageBox.Show("ISI PASSWORD", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtPASSWORD.Focus();
                return;
            }

            c.nama = txtNAMA.Text;
            c.level = cboLEVEL.Text;
            c.username = txtUSERNAME.Text;
            c.password = txtPASSWORD.Text;
            c.hp = txtHP.Text;
            c.alamat = txtALAMAT.Text;
            c.isLogin = false;
            if(chkISAKTIF.Checked == true) { c.isaktif = true;}else {c.isaktif = false;}
            if (chkISTRANSAKSIBIAYASTT.Checked == true) { c.isbiayastt = true; } else { c.isbiayastt = false; }
            if (chkISPIUTANG.Checked == true) { c.ispiutang = true; } else { c.ispiutang = false; }
            if (chkISMASTERDATA.Checked == true) { c.ismasterdata = true; } else { c.ismasterdata = false; }
            if (chkISAGENT.Checked == true) { c.isagent = true; } else { c.isagent = false; }
            if (chkISPRICELIST.Checked == true) { c.ispricelist = true; } else { c.ispricelist = false; }
            if (chkISSETTINGUSER.Checked == true) { c.isuser = true; } else { c.isuser = false; }
            if (chkLAPORAN.Checked == true) { c.islaporan = true; } else { c.islaporan = false; }
            if (chkISCOURIER.Checked == true) { c.iscourier = true; } else { c.iscourier = false; }

            if (type == 0)
            {
                c.password = b.EncodePassword(c);
                b.INSERT(c);
                this.LOAD_DATA();
                type = 0;
            }
            else
            {
                c.password = b.EncodePassword(c);
                b.UPDATE(c);
                this.LOAD_DATA();
                type = 0;
            }
            CLEAR();
        }
        void CLEAR()
        {
            txtNAMA.Text = "";
            cboLEVEL.Text = "";
            txtHP.Text = "";
            txtALAMAT.Text = "";
            txtUSERNAME.Text = "";
            txtPASSWORD.Text = "";
            chkISAGENT.Checked = false;
            chkISAKTIF.Checked = false;
            chkISMASTERDATA.Checked = false;
            chkISPIUTANG.Checked = false;
            chkISPRICELIST.Checked = false;
            chkISSETTINGUSER.Checked = false;
            chkISTRANSAKSIBIAYASTT.Checked = false;
            chkLAPORAN.Checked = false;
            chkISCOURIER.Checked = false;
        }

        private void btnTAMBAH_Click(object sender, EventArgs e)
        {
            CLEAR();
            LOAD_DATA();
        }
        public static string EncodePassword(string password)
        {
            string result = "";

            password = password.Trim();

            for (int i = 0; i < password.Length; i++)
            {
                int x = (int)password[i];

                result += char.ConvertFromUtf32((x + 5) * 2);
            }
            return result;
        }

        private void btnHAPUS_Click(object sender, EventArgs e)
        {
            if (dgvUSER.SelectedCells.Count > 0)
            {
                string id = dgvUSER.SelectedCells[0].OwningRow.Cells["IDUSER"].Value.ToString();
                string nama = dgvUSER.SelectedCells[0].OwningRow.Cells["USERNAME"].Value.ToString();
                c.id = int.Parse(id);
                DialogResult dr = MessageBox.Show("APAKAH YAKIN AKAN DELETE DATA : " + nama + " ?", "WARNING", MessageBoxButtons.OKCancel, MessageBoxIcon.Stop);
                if (dr == DialogResult.OK)
                {
                    b.DELETE(c);
                    LOAD_DATA();
                }
            }
        }

        private void btnKELUAR_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

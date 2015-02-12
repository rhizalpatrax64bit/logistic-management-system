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
    public partial class FormMEMBER : Form
    {
        protected RMS.BUSSINES.MASTER.RMS_JENISANGGOTA bj = new RMS.BUSSINES.MASTER.RMS_JENISANGGOTA();
        protected RMS.COMMON.MASTER.RMS_JENISANGGOTA cj = new RMS.COMMON.MASTER.RMS_JENISANGGOTA();

        public FormMEMBER()
        {
            InitializeComponent();
            LOAD_DATA_JENISANGGOTA();
        }

        public void LOAD_DATA_JENISANGGOTA()
        {
            cmbKEANGGOTAAN.Items.Clear();
            DataTable dt = bj.SELECT();
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    string nama = dt.Rows[i]["JENISANGGOTA"].ToString();
                    cmbKEANGGOTAAN.Items.Add(nama);
                }
            }
        }

        private void chkAKTF_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAKTF.Checked == true)
            {
                chkAKTF.Text = "AKTIF";
            }
            else
            {
                chkAKTF.Text = "NON AKTIF";
            }
        }

        private void btnBATAL_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtBANK_KeyUp(object sender, KeyEventArgs e)
        {
            if (!string.IsNullOrEmpty(txtBANK.Text)) return;
            if (e.KeyCode == Keys.Enter)
            {
                VIEW.FormVIEWBANK frm = new LOGISTICMANAGAMENTSYSTEM.VIEW.FormVIEWBANK(null, null, this, 3);
                frm.ShowDialog();
            }
        }

        public void GET_DATA_BANK(RMS.COMMON.MASTER.RMS_BANK obj)
        {
            txtBANK.Text = obj.NAMA;
        }

        private void btnADD_Click(object sender, EventArgs e)
        {
            MASTER.SUBMASTER.FormADDITEMJENISANGGOTA frm = new FormADDITEMJENISANGGOTA(this,0);
            frm.ShowDialog();
        }

        
    }
}

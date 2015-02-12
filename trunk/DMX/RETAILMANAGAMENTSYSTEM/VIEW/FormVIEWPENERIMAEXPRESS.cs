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
    public partial class FormVIEWPENERIMAEXPRESS : Form
    {
        protected RMS.BUSSINES.MASTER.RMS_PENERIMA b = new RMS.BUSSINES.MASTER.RMS_PENERIMA();
        protected RMS.COMMON.MASTER.RMS_PENERIMA c = new RMS.COMMON.MASTER.RMS_PENERIMA();
        EXPRESS.FormENTRYSO frm;
        int type;
        public FormVIEWPENERIMAEXPRESS(EXPRESS.FormENTRYSO _frm, int _type)
        {
            InitializeComponent();
            this.type = _type;
            if (type == 1)
            {
                this.frm = _frm;
            }

            LOAD_DATA();
            txtCARI.Focus();
            myToolTip();
        }
        private void myToolTip()
        {
            ToolTip myToolTip = new ToolTip();
            myToolTip.SetToolTip(txtCARI, "Cari Berdasarkan Salah Satu data : Kode, Marketing, Customer");

        }
        public void LOAD_DATA()
        {
            dgvPENERIMA.DataSource = null;
            dgvPENERIMA.Rows.Clear();

            DataTable dt = b.SELECT(c);
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    string id = dt.Rows[i]["IDPENERIMA"].ToString();
                    string nama = dt.Rows[i]["NAMAPENERIMA"].ToString();
                    string alamat = dt.Rows[i]["ALAMAT"].ToString();
                    string tlp = dt.Rows[i]["TELEPON"].ToString();
                    string fax = dt.Rows[i]["FAX"].ToString();
                    string hp = dt.Rows[i]["HP"].ToString();
                    dgvPENERIMA.Rows.Add(id,nama, alamat, tlp, fax, hp);
                }
            }
        }

        private void FormVIEWPENERIMAEXPRESS_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
            if (e.KeyCode == Keys.F1)
            {
                txtCARI.Focus();
            }
        }

        private void dgvPENERIMA_Click(object sender, EventArgs e)
        {
            if (dgvPENERIMA.SelectedCells.Count > 0)
            {
                c.ID = Convert.ToInt32(dgvPENERIMA.SelectedCells[0].OwningRow.Cells["ID"].Value.ToString());
                c.NAMAPENERIMA = dgvPENERIMA.SelectedCells[0].OwningRow.Cells["NAMA"].Value.ToString();
                c.HP = dgvPENERIMA.SelectedCells[0].OwningRow.Cells["HP"].Value.ToString();
                c.ALAMAT = dgvPENERIMA.SelectedCells[0].OwningRow.Cells["ALAMAT"].Value.ToString();
                c.TELEPON = dgvPENERIMA.SelectedCells[0].OwningRow.Cells["TELEPON"].Value.ToString();
                c.FAX = dgvPENERIMA.SelectedCells[0].OwningRow.Cells["FAX"].Value.ToString();


                if (type == 1)
                {
                    this.frm.GET_DATA_PENERIMA(c);
                }

                Close();
            }
        }

        private void txtCARI_KeyUp(object sender, KeyEventArgs e)
        {
            c.NAMAPENERIMA = txtCARI.Text;
            c.KODEPENERIMA = txtCARI.Text;

            dgvPENERIMA.DataSource = null;
            dgvPENERIMA.Rows.Clear();

            DataTable dt = b.SEARCHLIKE(c);
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    string id = dt.Rows[i]["IDPENERIMA"].ToString();
                    string nama = dt.Rows[i]["NAMAPENERIMA"].ToString();
                    string alamat = dt.Rows[i]["ALAMAT"].ToString();
                    string tlp = dt.Rows[i]["TELEPON"].ToString();
                    string fax = dt.Rows[i]["FAX"].ToString();
                    string hp = dt.Rows[i]["HP"].ToString();
                    dgvPENERIMA.Rows.Add(id,nama, alamat, tlp, fax, hp);
                }
            }
        }

        private void txtCARI_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                c.ID = Convert.ToInt32(dgvPENERIMA.SelectedCells[0].OwningRow.Cells["ID"].Value.ToString());
                c.NAMAPENERIMA = dgvPENERIMA.SelectedCells[0].OwningRow.Cells["NAMA"].Value.ToString();
                c.HP = dgvPENERIMA.SelectedCells[0].OwningRow.Cells["HP"].Value.ToString();
                c.ALAMAT = dgvPENERIMA.SelectedCells[0].OwningRow.Cells["ALAMAT"].Value.ToString();
                c.TELEPON = dgvPENERIMA.SelectedCells[0].OwningRow.Cells["TELEPON"].Value.ToString();
                c.FAX = dgvPENERIMA.SelectedCells[0].OwningRow.Cells["FAX"].Value.ToString();

                if (type == 1)
                {
                    this.frm.GET_DATA_PENERIMA(c);
                }

                Close();
            }
        }
    }
}

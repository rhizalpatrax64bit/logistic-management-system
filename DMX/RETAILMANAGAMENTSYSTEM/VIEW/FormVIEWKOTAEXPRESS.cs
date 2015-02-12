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
    public partial class FormVIEWKOTAEXPRESS : Form
    {
        protected RMS.BUSSINES.MASTER.RMS_KOTA b = new RMS.BUSSINES.MASTER.RMS_KOTA();
        protected RMS.COMMON.MASTER.RMS_KOTA c = new RMS.COMMON.MASTER.RMS_KOTA();
        protected RMS.COMMON.MASTER.RMS_TARIF cc = new RMS.COMMON.MASTER.RMS_TARIF();
        MASTER.FormTARIF frm;

        string _namaField;
        int type;
        public FormVIEWKOTAEXPRESS(MASTER.FormTARIF _frm, string namaField, int _type)
        {
            InitializeComponent();
            this.frm = _frm;
            type = _type;
            if (type == 1)
            {
                this.frm = _frm;
            }

            _namaField = namaField; ;
            LOAD_DATA();
        }
        public void LOAD_DATA()
        {
            dgvKOTA.DataSource = null;
            dgvKOTA.Rows.Clear();

            DataTable dt = b.SELECTKOTA();
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    string id = dt.Rows[i]["IDKOTA"].ToString();
                    string kodekota = dt.Rows[i]["KODEKOTA"].ToString();
                    string namakota = dt.Rows[i]["NAMAKOTA"].ToString();
                    dgvKOTA.Rows.Add(id, kodekota, namakota);
                }
            }
        }

        private void dgvKOTA_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (type == 1)
            {
                if (dgvKOTA.SelectedCells.Count > 0)
                {
                    c.IDKOTA = int.Parse(dgvKOTA.SelectedCells[0].OwningRow.Cells["IDKOTA"].Value.ToString());
                    c.KODEKOTA = dgvKOTA.SelectedCells[0].OwningRow.Cells["KODE"].Value.ToString();
                    c.NAMAKOTA = dgvKOTA.SelectedCells[0].OwningRow.Cells["NAMA"].Value.ToString();

                    this.frm.GET_DATA_KOTA(c, _namaField);
                    Close();
                }
            }
            
        }

        private void txtCARI_TextChanged(object sender, EventArgs e)
        {
            dgvKOTA.DataSource = null;
            dgvKOTA.Rows.Clear();

            c.KODEKOTA = txtCARI.Text;
            c.NAMAKOTA = txtCARI.Text;
            DataTable dt = b.GETKOTA(c);
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    string id = dt.Rows[i]["IDKOTA"].ToString();
                    string kodekota = dt.Rows[i]["KODEKOTA"].ToString();
                    string namakota = dt.Rows[i]["NAMAKOTA"].ToString();

                    dgvKOTA.Rows.Add(id, kodekota, namakota);
                }
            }
        }
    }
}

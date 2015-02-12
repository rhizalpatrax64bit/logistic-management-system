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
    public partial class FormDRIVERHELPER : Form
    {
        protected RMS.BUSSINES.MASTER.RMS_DRIVER b = new RMS.BUSSINES.MASTER.RMS_DRIVER();
        protected RMS.COMMON.MASTER.RMS_DRIVER c = new RMS.COMMON.MASTER.RMS_DRIVER();
        protected RMS.COMMON.MASTER.RMS_KENDARAAN cc = new RMS.COMMON.MASTER.RMS_KENDARAAN();
        MASTER.SUBMASTER.FormKENDARAAN frm;
        EXPRESS.FormENTRYPENGIRIMANBARANG frmPENGIRIMANBARANG;

        string _namaField;
        int type;

        public FormDRIVERHELPER(MASTER.SUBMASTER.FormKENDARAAN _frm, EXPRESS.FormENTRYPENGIRIMANBARANG frm, string namaField, int _type)
        {
            InitializeComponent();
        
            type = _type;
            if (type == 1)
            {
                this.frm = _frm;
            }else { this.frmPENGIRIMANBARANG = frm;}

            _namaField = namaField; ;
            if (_namaField == "DRIVER")
            {
                c.STATUS = false; // driver 0
            }
            else
            {
                c.STATUS = true; // helper 1
            }
            LOAD_DATA();
            
        }
        public void LOAD_DATA()
        {
            dgvDRIVER.DataSource = null;
            dgvDRIVER.Rows.Clear();
            c.NAMA = txtCARI.Text;
            c.TELEPON = txtCARI.Text;
            DataTable dt = b.SEARCHLIKEVIEW(c);
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    string id = dt.Rows[i]["ID"].ToString();
                    string kode = dt.Rows[i]["KODE"].ToString();
                    string nama = dt.Rows[i]["NAMA"].ToString();
                    string hp = dt.Rows[i]["HP"].ToString();
                    dgvDRIVER.Rows.Add(id, kode, nama, hp);
                }
            }
        }

        private void txtCARI_TextChanged(object sender, EventArgs e)
        {
            dgvDRIVER.DataSource = null;
            dgvDRIVER.Rows.Clear();
            c.NAMA = txtCARI.Text;
            c.HP = txtCARI.Text;
            DataTable dt = b.SEARCHLIKEVIEW(c);
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    string id = dt.Rows[i]["ID"].ToString();
                    string kode = dt.Rows[i]["KODE"].ToString();
                    string nama = dt.Rows[i]["NAMA"].ToString();
                    string hp = dt.Rows[i]["HP"].ToString();
                    dgvDRIVER.Rows.Add(id, kode,nama, hp);
                }
            }
        }

       

        private void dgvDRIVER_Click(object sender, EventArgs e)
        {
            if (type == 1)
            {
                if (dgvDRIVER.SelectedCells.Count > 0)
                {
                    c.ID = int.Parse(dgvDRIVER.SelectedCells[0].OwningRow.Cells["ID"].Value.ToString());
                    c.KODE = dgvDRIVER.SelectedCells[0].OwningRow.Cells["KODE"].Value.ToString();
                    c.NAMA = dgvDRIVER.SelectedCells[0].OwningRow.Cells["NAMA"].Value.ToString();

                    this.frm.GET_DATA_DRIVER(c, _namaField);
                    Close();
                }

            }
            else
            {
                if (dgvDRIVER.SelectedCells.Count > 0)
                {
                    c.ID = int.Parse(dgvDRIVER.SelectedCells[0].OwningRow.Cells["ID"].Value.ToString());
                    c.KODE = dgvDRIVER.SelectedCells[0].OwningRow.Cells["KODE"].Value.ToString();
                    c.NAMA = dgvDRIVER.SelectedCells[0].OwningRow.Cells["NAMA"].Value.ToString();

                    this.frmPENGIRIMANBARANG.GET_DATA_DRIVER(c, _namaField);
                    Close();
                }
            }
        }

       
    }
}

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
    public partial class FormVIEWSATUAN : Form
    {
        protected RMS.BUSSINES.MASTER.RMS_SATUAN b = new RMS.BUSSINES.MASTER.RMS_SATUAN();
        protected RMS.COMMON.MASTER.RMS_SATUAN c = new RMS.COMMON.MASTER.RMS_SATUAN();

        PURCHASE.SUBPURCHASE.FormADDITEM frm;
        //PURCHASE.SUBPURCHASE.FormADDITEMPEMBELIAN frm;
        public FormVIEWSATUAN(PURCHASE.SUBPURCHASE.FormADDITEM _frm)
        {
            InitializeComponent();
            this.frm = _frm;
            LOAD_DATA();
        }

        void LOAD_DATA()
        {
            DataTable dt = b.SELECT();
            if (dt.Rows.Count > 0)
            {
                for(int i=0;i<dt.Rows.Count;i++)
                {
                    string nama = dt.Rows[i]["NAMASATUAN"].ToString();
                    string isi = dt.Rows[i]["ISI"].ToString();
                    dgvSATUAN.Rows.Add(nama,isi);
                }
            }
        }

        private void dgvSATUAN_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvSATUAN.SelectedCells.Count > 0)
            {
                c.NAMA = dgvSATUAN.SelectedCells[0].OwningRow.Cells["NAMASATUAN"].Value.ToString();
                c.ISI = Convert.ToInt32(dgvSATUAN.SelectedCells[0].OwningRow.Cells["ISI"].Value.ToString());
                this.frm.GETA_KODE_SATUAN(c);
                Close();
            }
        }
    }
}

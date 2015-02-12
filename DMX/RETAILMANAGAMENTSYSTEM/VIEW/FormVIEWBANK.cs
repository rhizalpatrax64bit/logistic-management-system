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
    public partial class FormVIEWBANK : Form
    {
        protected RMS.BUSSINES.MASTER.RMS_BANK b = new RMS.BUSSINES.MASTER.RMS_BANK();
        protected RMS.COMMON.MASTER.RMS_BANK c = new RMS.COMMON.MASTER.RMS_BANK();

        // 1.Supplier, 2.Customer
        MASTER.SUBMASTER.FormSUPPLIER frm;
        MASTER.SUBMASTER.FormCUSTOMER frmC;
        MASTER.SUBMASTER.FormMEMBER frmM;
        int Type;
        public FormVIEWBANK(MASTER.SUBMASTER.FormSUPPLIER _frm,
                            MASTER.SUBMASTER.FormCUSTOMER _frmC,
                            MASTER.SUBMASTER.FormMEMBER _frmM,
                            int _Type)
        {
            InitializeComponent();
            this.frm = _frm;
            this.frmC = _frmC;
            this.frmM = _frmM;
            this.Type = _Type;
            LOAD_DATA();
        }

        void LOAD_DATA()
        {
            dgvBANK.DataSource = null;
            dgvBANK.Rows.Clear();
            DataTable dt = b.SELECT();
            dgvBANK.DataSource = dt;
        }

        private void FormVIEWBANK_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }

        private void dgvBANK_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            GET_DATA(Type);
        }

        void GET_DATA(int Value)
        {
            if (dgvBANK.SelectedCells.Count > 0)
            {
                string nama = dgvBANK.SelectedCells[0].OwningRow.Cells["NAMABANK"].Value.ToString();
                c.NAMA = nama;
                switch (Value)
                {
                    case 1: this.frm.GET_DATA(c); break;
                    case 2: this.frmC.GET_DATA_BANK(c); break;
                    case 3: this.frmM.GET_DATA_BANK(c); break;
                };

                Close();
            }
        }
    }
}

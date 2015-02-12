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
    public partial class FormVIEWKENDARAAN : Form
    {
        protected RMS.BUSSINES.MASTER.RMS_KENDARAAN b = new RMS.BUSSINES.MASTER.RMS_KENDARAAN();
        protected RMS.COMMON.MASTER.RMS_KENDARAAN c = new RMS.COMMON.MASTER.RMS_KENDARAAN();
        EXPRESS.FormENTRYPENGIRIMANBARANG frm;

        int type;
        public FormVIEWKENDARAAN(EXPRESS.FormENTRYPENGIRIMANBARANG _frm, int _type)
        {
            InitializeComponent();
            this.type = _type;
            if (type == 1)
            {
                this.frm = _frm;
            }
            else
            {
                //this.frmINVOICE = _frmSTT;
            }
            LOAD_DATA();
            txtCARI.Focus();
        }
        public void LOAD_DATA()
        {
            dgvKENDARAAN.DataSource = null;
            dgvKENDARAAN.Rows.Clear();

            DataTable dt = b.SELECT();
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    string id = dt.Rows[i]["ID"].ToString();
                    string nopol = dt.Rows[i]["NOPOL"].ToString();
                    string jeniskendaraan = dt.Rows[i]["JENISKENDARAAN"].ToString();
                    string maxmuatan = dt.Rows[i]["MAXMUATAN"].ToString();
                    string maxvolume = dt.Rows[i]["MAXVOLUME"].ToString();
                    string iddriver = dt.Rows[i]["IDDRIVER"].ToString();
                    string idhelper = dt.Rows[i]["IDHELPER"].ToString();
                    string kodedriver = dt.Rows[i]["KODEDRIVER"].ToString();
                    string kodehelper = dt.Rows[i]["KODEHELPER"].ToString();
                    string namadriver = dt.Rows[i]["NAMADRIVER"].ToString();
                    string namahelper = dt.Rows[i]["NAMAHELPER"].ToString();
                    string _statusKendaraan = dt.Rows[i]["STATUS"].ToString();
                    if (Convert.ToBoolean(dt.Rows[i]["STATUS"].ToString()) == false)
                    {
                        _statusKendaraan = "Tidak Tersedia";
                    }
                    else
                    {
                        _statusKendaraan = "Tersedia";
                    }

                    dgvKENDARAAN.Rows.Add(id, nopol,jeniskendaraan, maxmuatan, maxvolume,iddriver,idhelper,kodedriver,kodehelper,namadriver,namahelper,_statusKendaraan);
                }
            }
        }

        private void dgvKENDARAAN_Click(object sender, EventArgs e)
        {
            if (dgvKENDARAAN.SelectedCells.Count > 0)
            {
                c.ID = Convert.ToInt32(dgvKENDARAAN.SelectedCells[0].OwningRow.Cells["ID"].Value.ToString());
                c.NOPOL = dgvKENDARAAN.SelectedCells[0].OwningRow.Cells["NOPOL"].Value.ToString();
                c.JENISKENDARAAN = dgvKENDARAAN.SelectedCells[0].OwningRow.Cells["JENISKENDARAAN"].Value.ToString();
                c.MAXMUATAN = float.Parse(dgvKENDARAAN.SelectedCells[0].OwningRow.Cells["MAXMUATAN"].Value.ToString());
                c.MAXVOLUME = float.Parse(dgvKENDARAAN.SelectedCells[0].OwningRow.Cells["MAXVOLUME"].Value.ToString());
                c.STATUSKENDARAAN = dgvKENDARAAN.SelectedCells[0].OwningRow.Cells["STATUS"].Value.ToString();

                c.IDDRIVER = Convert.ToInt32(dgvKENDARAAN.SelectedCells[0].OwningRow.Cells["IDDRIVER"].Value.ToString());
                c.IDHELPER = Convert.ToInt32(dgvKENDARAAN.SelectedCells[0].OwningRow.Cells["IDHELPER"].Value.ToString());
                c.KODEDRIVER = dgvKENDARAAN.SelectedCells[0].OwningRow.Cells["KODEDRIVER"].Value.ToString();
                c.KODEHELPER = dgvKENDARAAN.SelectedCells[0].OwningRow.Cells["KODEHELPER"].Value.ToString();
                c.NAMADRIVER = dgvKENDARAAN.SelectedCells[0].OwningRow.Cells["NAMADRIVER"].Value.ToString();
                c.NAMAHELPER = dgvKENDARAAN.SelectedCells[0].OwningRow.Cells["NAMAHELPER"].Value.ToString();


                if (type == 1)
                {
                    this.frm.GET_DATA_KENDARAAN(c);
                }
                else
                {
                    // this.frmINVOICE.GET_DATA_CUSTOMER(c);
                }
                Close();
            }
        }
    }
}

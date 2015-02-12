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
    public partial class FormVIEWBARANG : Form
    {
        protected RMS.BUSSINES.MASTER.RMS_BARANG b = new RMS.BUSSINES.MASTER.RMS_BARANG();
        protected RMS.COMMON.MASTER.RMS_BARANG c = new RMS.COMMON.MASTER.RMS_BARANG();

        PURCHASE.SUBPURCHASE.FormADDITEMPEMBELIAN frm;
        public FormVIEWBARANG(PURCHASE.SUBPURCHASE.FormADDITEMPEMBELIAN _frm)
        {
            InitializeComponent();
            LOAD_DATA_BARANG();
            this.frm = _frm;
        }
        private void FormVIEWBARANG_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }

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
        public void LOAD_DATA_BARANG()
        {
            string HARGAJUAL1 = string.Empty;
            string HARGAJUAL2 = string.Empty;

            DataTable dt = b.SELECT();
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    string kode = dt.Rows[i]["KODEBARANG"].ToString();
                    string nama = dt.Rows[i]["NAMABARANG"].ToString();
                    string barcode = dt.Rows[i]["BARCODE"].ToString();

                    if (dt.Rows[i]["HARGAJUAL1"].ToString() == "0")
                    {
                        HARGAJUAL1 = "0";
                    }
                    else
                    {
                        decimal hg1 = decimal.Parse(dt.Rows[i]["HARGAJUAL1"].ToString());
                        HARGAJUAL1 = string.Format("{0:0,0}", hg1);
                    }
                    if (dt.Rows[i]["HARGAJUAL2"].ToString() == "0")
                    {
                        HARGAJUAL2 = "0";
                    }
                    else
                    {
                        decimal hg2 = decimal.Parse(dt.Rows[i]["HARGAJUAL2"].ToString());
                        HARGAJUAL2 = string.Format("{0:0,0}", hg2);
                    }

                    dgvBARANG.Rows.Add(kode, nama, barcode, HARGAJUAL1, HARGAJUAL2);
                }
            }

        }
        private void txtCARI_TextChanged(object sender, EventArgs e)
        {
            string HARGAJUAL1 = string.Empty;
            string HARGAJUAL2 = string.Empty;

            if (rdbKODE.Checked == true)
            {
                dgvBARANG.DataSource = null;
                dgvBARANG.Rows.Clear();

                c.KODEBARANG = txtCARI.Text;
                DataTable dt = b.SEARCH_BYKODE(c);
                if (dt.Rows.Count > 0)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        string kode = dt.Rows[i]["KODEBARANG"].ToString();
                        string nama = dt.Rows[i]["NAMABARANG"].ToString();
                        string barcode = dt.Rows[i]["BARCODE"].ToString();

                        if (dt.Rows[i]["HARGAJUAL1"].ToString() == "0")
                        {
                            HARGAJUAL1 = "0";
                        }
                        else
                        {
                            decimal hg1 = decimal.Parse(dt.Rows[i]["HARGAJUAL1"].ToString());
                            HARGAJUAL1 = string.Format("{0:0,0}", hg1);
                        }
                        if (dt.Rows[i]["HARGAJUAL2"].ToString() == "0")
                        {
                            HARGAJUAL2 = "0";
                        }
                        else
                        {
                            decimal hg2 = decimal.Parse(dt.Rows[i]["HARGAJUAL2"].ToString());
                            HARGAJUAL2 = string.Format("{0:0,0}", hg2);
                        }

                        dgvBARANG.Rows.Add(kode, nama, barcode, HARGAJUAL1, HARGAJUAL2);
                    }
                }
            }

            if (rdbNAMA.Checked == true)
            {
                dgvBARANG.DataSource = null;
                dgvBARANG.Rows.Clear();

                c.NAMABARANG = txtCARI.Text;
                DataTable dt = b.SEARCH_BYNAMA(c);
                if (dt.Rows.Count > 0)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        string kode = dt.Rows[i]["KODEBARANG"].ToString();
                        string nama = dt.Rows[i]["NAMABARANG"].ToString();
                        string barcode = dt.Rows[i]["BARCODE"].ToString();

                        if (dt.Rows[i]["HARGAJUAL1"].ToString() == "0")
                        {
                            HARGAJUAL1 = "0";
                        }
                        else
                        {
                            decimal hg1 = decimal.Parse(dt.Rows[i]["HARGAJUAL1"].ToString());
                            HARGAJUAL1 = string.Format("{0:0,0}", hg1);
                        }
                        if (dt.Rows[i]["HARGAJUAL2"].ToString() == "0")
                        {
                            HARGAJUAL2 = "0";
                        }
                        else
                        {
                            decimal hg2 = decimal.Parse(dt.Rows[i]["HARGAJUAL2"].ToString());
                            HARGAJUAL2 = string.Format("{0:0,0}", hg2);
                        }

                        dgvBARANG.Rows.Add(kode, nama, barcode, HARGAJUAL1, HARGAJUAL2);
                    }
                }

            }
        }
        private void dgvBARANG_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvBARANG.SelectedCells.Count > 0)
            {
                string kode = dgvBARANG.SelectedCells[0].OwningRow.Cells["KODE"].Value.ToString();
                c.KODEBARANG = kode;
                this.frm.GET_DATA_DB(c);
                Close();
            }
        }
    }
}

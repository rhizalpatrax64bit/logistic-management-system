using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LOGISTICMANAGAMENTSYSTEM.PURCHASE.SUBPURCHASE
{
    public partial class FormADDITEMPEMBELIAN : Form
    {
        protected RMS.COMMON.MASTER.RMS_BARANG c = new RMS.COMMON.MASTER.RMS_BARANG();
        protected RMS.BUSSINES.MASTER.RMS_BARANG b = new RMS.BUSSINES.MASTER.RMS_BARANG();
        protected RMS.BUSSINES.MASTER.RMS_DEPARTMENT bd = new RMS.BUSSINES.MASTER.RMS_DEPARTMENT();
        protected RMS.COMMON.MASTER.RMS_DEPARTMENT cd = new RMS.COMMON.MASTER.RMS_DEPARTMENT();
        public FormADDITEMPEMBELIAN()
        {
            InitializeComponent();
        }
        private void btnTAMBAH_Click(object sender, EventArgs e)
        {
            PURCHASE.SUBPURCHASE.FormADDITEM frm = new FormADDITEM(this);
            frm.ShowDialog();
        }
        private void btnBATAL_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void chkEXPIRED_CheckedChanged(object sender, EventArgs e)
        {
            if (chkEXPIRED.Checked == true)
            {
                dtpEXPIRED.Enabled = true;
            }
            else
            {
                dtpEXPIRED.Enabled = false;
            }
        }
        public void GET_DATA(RMS.COMMON.MASTER.RMS_BARANG obj)
        {
            txtBARANG.Text = obj.NAMABARANG;
            txtKODE.Text = obj.KODEBARANG;
            txtBARCODE.Text = obj.BARCODE;
            txtKODESATUAN.Text = obj.KODESATUAN;
            txtNAMASATUAN.Text = obj.NAMASATUAN;
            txtKODEDEPT.Text = obj.KODEDEPT;
            txtNAMADEPT.Text = obj.NAMADEPT;
            txtQTYBELI1.Text = "0";
            txtQTYBELI2.Text = "0";
            txtQTYBONUS.Text = "0";
            txtTOTALPCS.Text = "0";
            txtTOTALPCSBNS.Text = "0";
            txtHARGABELI1.Text = "0";
            txtHARGABELI2.Text = "0";
            txtBRUTO.Text = "0";
            txtDSKNRP1.Text = "0";
            txtDSKNRP1A.Text = "0";
            txtDSKNRP2.Text = "0";
            txtDSKNRP2A.Text = "0";
            txtDSKNPSN1.Text = "0";
            txtDSKNPSN1A.Text = "0";
            txtDSKNPSN2.Text = "0";
            txtDSKNPSN2A.Text = "0";
            txtDSKNPSN3.Text = "0";
            txtDSKNPSN3A.Text = "0";
            txtDSKNPSN4.Text = "0";
            txtDSKNPSN4A.Text = "0";
            txtDSKNPSN5.Text = "0";
            txtDSKNPSN5A.Text = "0";
            txtPPN.Text = "0";
            txtPPNA.Text = "0";
            txtNETTO.Text = "0";
            txtHRGPKKBELI1.Text = "0";
            txtHRGPKKBELI2.Text = "0";
            txtMGNPROFIT1.Text = "0";
            txtMGNPROFIT1A.Text = "0";
            txtBTSMGN1.Text = obj.BATASMARGIN1.ToString();
            txtBTSMGN2.Text = obj.BATASMARGIN2.ToString();
            txtHARGAJUAL1.Text = "0";
            txtHARGAJUAL2.Text = "0";
            txtMGNSPESIAL.Text = "0";
            txtHARGASPESIAL.Text = "0";
            txtQTY1.Text = "0"; txtMGN1.Text = "0"; txtHARGA1.Text = "0";
            txtQTY2.Text = "0"; txtMGN2.Text = "0"; txtHARGA2.Text = "0";
            txtQTY3.Text = "0"; txtMGN3.Text = "0"; txtHARGA3.Text = "0";
            txtQTY4.Text = "0"; txtMGN4.Text = "0"; txtHARGA4.Text = "0";
            txtQTY5.Text = "0"; txtMGN5.Text = "0"; txtHARGA5.Text = "0";
            labelINFO1.Text = obj.NAMASATUAN;
            labelINFO3.Text = obj.NAMASATUAN;
            labelINFO4.Text = obj.NAMASATUAN;
            labelINFO6.Text = obj.NAMASATUAN;
        }
        public void GET_DATA_DB(RMS.COMMON.MASTER.RMS_BARANG obj)
        {
            DataTable dt = b.CARI_BYKODE(obj);
            if (dt.Rows.Count > 0)
            {
                txtBARANG.Text = dt.Rows[0]["NAMABARANG"].ToString();
                txtKODE.Text = dt.Rows[0]["KODEBARANG"].ToString();
                txtBARCODE.Text = dt.Rows[0]["BARCODE"].ToString();
                txtKODESATUAN.Text = dt.Rows[0]["ISISATUAN"].ToString();
                txtNAMASATUAN.Text = dt.Rows[0]["NAMASATUAN"].ToString();
                txtKODEDEPT.Text = dt.Rows[0]["KODEDEPARTMENT"].ToString();
                txtNAMADEPT.Text = dt.Rows[0]["NAMADEPARTMENT"].ToString();
                txtQTYBELI1.Text = "0";
                txtQTYBELI2.Text = "0";
                txtQTYBONUS.Text = "0";
                txtTOTALPCS.Text = "0";
                txtTOTALPCSBNS.Text = "0";
                txtHARGABELI1.Text = "0";
                txtHARGABELI2.Text = "0";
                txtBRUTO.Text = "0";
                txtDSKNRP1.Text = "0";
                txtDSKNRP1A.Text = "0";
                txtDSKNRP2.Text = "0";
                txtDSKNRP2A.Text = "0";
                txtDSKNPSN1.Text = "0";
                txtDSKNPSN1A.Text = "0";
                txtDSKNPSN2.Text = "0";
                txtDSKNPSN2A.Text = "0";
                txtDSKNPSN3.Text = "0";
                txtDSKNPSN3A.Text = "0";
                txtDSKNPSN4.Text = "0";
                txtDSKNPSN4A.Text = "0";
                txtDSKNPSN5.Text = "0";
                txtDSKNPSN5A.Text = "0";
                txtPPN.Text = "0";
                txtPPNA.Text = "0";
                txtNETTO.Text = "0";
                txtHRGPKKBELI1.Text = "0";
                txtHRGPKKBELI2.Text = "0";
                txtMGNPROFIT1.Text = "0";
                txtMGNPROFIT1A.Text = "0";
                // get value maxmargin & minmargin
                cd.KODE = txtKODEDEPT.Text;
                DataTable dp = bd.CARI_BYKODE(cd);
                if (dp.Rows.Count > 0)
                {
                    txtBTSMGN1.Text = dp.Rows[0]["MINMARGIN"].ToString();
                    txtBTSMGN2.Text = dp.Rows[0]["MAXMARGIN"].ToString();
                }
                else
                {
                    txtBTSMGN1.Text = "0";
                    txtBTSMGN2.Text = "0";
                }

                txtHARGAJUAL1.Text = "0";
                txtHARGAJUAL2.Text = "0";
                txtMGNSPESIAL.Text = "0";
                txtHARGASPESIAL.Text = "0";
                txtQTY1.Text = "0"; txtMGN1.Text = "0"; txtHARGA1.Text = "0";
                txtQTY2.Text = "0"; txtMGN2.Text = "0"; txtHARGA2.Text = "0";
                txtQTY3.Text = "0"; txtMGN3.Text = "0"; txtHARGA3.Text = "0";
                txtQTY4.Text = "0"; txtMGN4.Text = "0"; txtHARGA4.Text = "0";
                txtQTY5.Text = "0"; txtMGN5.Text = "0"; txtHARGA5.Text = "0";
                labelINFO1.Text = txtNAMASATUAN.Text;
                labelINFO3.Text = txtNAMASATUAN.Text;
                labelINFO4.Text = txtNAMASATUAN.Text;
                labelINFO6.Text = txtNAMASATUAN.Text;
            }
        }
        private void txtBARANG_KeyUp(object sender, KeyEventArgs e)
        {
            if (!string.IsNullOrEmpty(txtBARANG.Text)) return;
            if (e.KeyCode == Keys.Enter)
            {
                VIEW.FormVIEWBARANG frm = new LOGISTICMANAGAMENTSYSTEM.VIEW.FormVIEWBARANG(this);
                frm.ShowDialog();
            }
        }

        #region EVENT TEXT BOXT
        private void txtQTYBELI1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        private void txtQTYBELI2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        private void txtQTYBONUS_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        private void txtPPN_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        private void txtQTY1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        private void txtQTY2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        private void txtQTY3_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        private void txtQTY4_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        private void txtQTY5_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        private void txtDSKNRP1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',')
            {
                e.Handled = true;
            }
            // only allow one decimal point
            if (e.KeyChar == ','
            && (sender as TextBox).Text.IndexOf(',') > -1)
            {
                e.Handled = true;
            }
        }
        private void txtDSKNRP2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',')
            {
                e.Handled = true;
            }
            // only allow one decimal point
            if (e.KeyChar == ','
            && (sender as TextBox).Text.IndexOf(',') > -1)
            {
                e.Handled = true;
            }
        }
        private void txtDSKNPSN1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',')
            {
                e.Handled = true;
            }
            // only allow one decimal point
            if (e.KeyChar == ','
            && (sender as TextBox).Text.IndexOf(',') > -1)
            {
                e.Handled = true;
            }
        }
        private void txtDSKNPSN2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',')
            {
                e.Handled = true;
            }
            // only allow one decimal point
            if (e.KeyChar == ','
            && (sender as TextBox).Text.IndexOf(',') > -1)
            {
                e.Handled = true;
            }
        }
        private void txtDSKNPSN3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',')
            {
                e.Handled = true;
            }
            // only allow one decimal point
            if (e.KeyChar == ','
            && (sender as TextBox).Text.IndexOf(',') > -1)
            {
                e.Handled = true;
            }
        }
        private void txtDSKNPSN4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',')
            {
                e.Handled = true;
            }
            // only allow one decimal point
            if (e.KeyChar == ','
            && (sender as TextBox).Text.IndexOf(',') > -1)
            {
                e.Handled = true;
            }
        }
        private void txtDSKNPSN5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',')
            {
                e.Handled = true;
            }
            // only allow one decimal point
            if (e.KeyChar == ','
            && (sender as TextBox).Text.IndexOf(',') > -1)
            {
                e.Handled = true;
            }
        }
        private void txtMGNSPESIAL_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',')
            {
                e.Handled = true;
            }
            // only allow one decimal point
            if (e.KeyChar == ','
            && (sender as TextBox).Text.IndexOf(',') > -1)
            {
                e.Handled = true;
            }
        }
        private void txtHARGABELI1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',')
            {
                e.Handled = true;
            }
            // only allow one decimal point
            if (e.KeyChar == ','
            && (sender as TextBox).Text.IndexOf(',') > -1)
            {
                e.Handled = true;
            }
        }
        private void txtHARGABELI2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',')
            {
                e.Handled = true;
            }
            // only allow one decimal point
            if (e.KeyChar == ','
            && (sender as TextBox).Text.IndexOf(',') > -1)
            {
                e.Handled = true;
            }
        }
        private void txtBRUTO_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',')
            {
                e.Handled = true;
            }
            // only allow one decimal point
            if (e.KeyChar == ','
            && (sender as TextBox).Text.IndexOf(',') > -1)
            {
                e.Handled = true;
            }
        }
        private void txtNETTO_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',')
            {
                e.Handled = true;
            }
            // only allow one decimal point
            if (e.KeyChar == ','
            && (sender as TextBox).Text.IndexOf(',') > -1)
            {
                e.Handled = true;
            }
        }
        private void txtHRGPKKBELI1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',')
            {
                e.Handled = true;
            }
            // only allow one decimal point
            if (e.KeyChar == ','
            && (sender as TextBox).Text.IndexOf(',') > -1)
            {
                e.Handled = true;
            }
        }
        private void txtHRGPKKBELI2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',')
            {
                e.Handled = true;
            }
            // only allow one decimal point
            if (e.KeyChar == ','
            && (sender as TextBox).Text.IndexOf(',') > -1)
            {
                e.Handled = true;
            }
        }
        private void txtMGNPROFIT1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',')
            {
                e.Handled = true;
            }
            // only allow one decimal point
            if (e.KeyChar == ','
            && (sender as TextBox).Text.IndexOf(',') > -1)
            {
                e.Handled = true;
            }
        }
        private void txtMGN1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',')
            {
                e.Handled = true;
            }
            // only allow one decimal point
            if (e.KeyChar == ','
            && (sender as TextBox).Text.IndexOf(',') > -1)
            {
                e.Handled = true;
            }
        }
        private void txtMGN2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',')
            {
                e.Handled = true;
            }
            // only allow one decimal point
            if (e.KeyChar == ','
            && (sender as TextBox).Text.IndexOf(',') > -1)
            {
                e.Handled = true;
            }
        }
        private void txtMGN3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',')
            {
                e.Handled = true;
            }
            // only allow one decimal point
            if (e.KeyChar == ','
            && (sender as TextBox).Text.IndexOf(',') > -1)
            {
                e.Handled = true;
            }
        }
        private void txtMGN4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',')
            {
                e.Handled = true;
            }
            // only allow one decimal point
            if (e.KeyChar == ','
            && (sender as TextBox).Text.IndexOf(',') > -1)
            {
                e.Handled = true;
            }
        }
        private void txtMGN5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',')
            {
                e.Handled = true;
            }
            // only allow one decimal point
            if (e.KeyChar == ','
            && (sender as TextBox).Text.IndexOf(',') > -1)
            {
                e.Handled = true;
            }
        }
        private void txtHARGA1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',')
            {
                e.Handled = true;
            }
            // only allow one decimal point
            if (e.KeyChar == ','
            && (sender as TextBox).Text.IndexOf(',') > -1)
            {
                e.Handled = true;
            }
        }
        private void txtHARGA2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',')
            {
                e.Handled = true;
            }
            // only allow one decimal point
            if (e.KeyChar == ','
            && (sender as TextBox).Text.IndexOf(',') > -1)
            {
                e.Handled = true;
            }
        }
        private void txtHARGA3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',')
            {
                e.Handled = true;
            }
            // only allow one decimal point
            if (e.KeyChar == ','
            && (sender as TextBox).Text.IndexOf(',') > -1)
            {
                e.Handled = true;
            }
        }
        private void txtHARGA4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',')
            {
                e.Handled = true;
            }
            // only allow one decimal point
            if (e.KeyChar == ','
            && (sender as TextBox).Text.IndexOf(',') > -1)
            {
                e.Handled = true;
            }
        }
        private void txtHARGA5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',')
            {
                e.Handled = true;
            }
            // only allow one decimal point
            if (e.KeyChar == ','
            && (sender as TextBox).Text.IndexOf(',') > -1)
            {
                e.Handled = true;
            }
        }
        #endregion

        private void txtQTYBELI1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (string.IsNullOrEmpty(txtQTYBELI1.Text)) return;
                if (string.IsNullOrEmpty(txtKODESATUAN.Text))
                {
                    MessageBox.Show("ISI SATUAN TERLEBIH DAHULU", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    txtKODESATUAN.Focus();
                    return;
                }

                try
                {
                    int kode = Convert.ToInt32(txtKODESATUAN.Text);
                    int Qty = Convert.ToInt32(txtQTYBELI1.Text);

                    if (txtQTYBELI2.Text != "0" || txtQTYBELI2.Text != "")
                    {
                        int qtypcs = Convert.ToInt32(txtQTYBELI2.Text);
                        txtTOTALPCS.Text = ((kode * Qty) + qtypcs).ToString();
                    }
                    else
                    {
                        txtTOTALPCS.Text = (kode * Qty).ToString();
                    }

                    if (txtQTYBONUS.Text != "0" || txtQTYBONUS.Text != "")
                    {
                        int qtybns = Convert.ToInt32(txtQTYBONUS.Text);
                        txtTOTALPCSBNS.Text = (qtybns + Convert.ToInt32(txtTOTALPCS.Text)).ToString();
                    }

                    txtQTYBELI2.Focus();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void txtQTYBELI2_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (string.IsNullOrEmpty(txtQTYBELI2.Text)) return;
                if (string.IsNullOrEmpty(txtKODESATUAN.Text))
                {
                    MessageBox.Show("ISI SATUAN TERLEBIH DAHULU", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    txtKODESATUAN.Focus();
                    return;
                }

                try
                {
                    int TOTAL = Convert.ToInt32(txtKODESATUAN.Text) * Convert.ToInt32(txtQTYBELI1.Text);
                    int QTY2 = Convert.ToInt32(txtQTYBELI2.Text);
                    int VALUE = TOTAL + QTY2;
                    txtTOTALPCS.Text = VALUE.ToString();
                    txtQTYBONUS.Focus();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }
        private void txtMGNPROFIT1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (string.IsNullOrEmpty(txtBTSMGN1.Text)) return;
                if (string.IsNullOrEmpty(txtMGNPROFIT1.Text))
                {
                    txtHARGAJUAL1.Text = txtHARGABELI1.Text;
                    txtMGNPROFIT1.Text = "0";
                    return;
                }
                if (txtQTYBELI1.Text == "0" || txtQTYBELI1.Text == "") return;

                float btsmrgn1 = float.Parse(txtBTSMGN1.Text);
                float btsmrgn2 = float.Parse(txtBTSMGN2.Text);
                float mrgnprft = float.Parse(txtMGNPROFIT1.Text);
                decimal hargabeli = decimal.Parse(txtHARGABELI1.Text);
                decimal hargajual = decimal.Parse(txtHARGAJUAL1.Text);
                int QTY = Convert.ToInt32(txtQTYBELI1.Text);

                if ((mrgnprft >= btsmrgn1) && (mrgnprft <= btsmrgn2))
                {
                    if (txtMGNPROFIT1.Text != "0" || txtMGNPROFIT1.Text != "")
                    {
                        decimal mrgn = ((decimal.Parse(txtMGNPROFIT1.Text) / 100) * hargabeli);
                        txtHARGAJUAL1.Text = (hargabeli + mrgn).ToString();
                    }
                    else
                    {
                        txtHARGAJUAL1.Text = hargabeli.ToString();
                    }
                }

                if (mrgnprft < btsmrgn1)
                {
                    MessageBox.Show("MARGIN PROFIT LEBIH KECIL DARI BATAS MARGIN YANG TELAH DITENTUKAN", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }

                if (mrgnprft > btsmrgn2)
                {
                    MessageBox.Show("MARGIN PROFIT LEBIH BESAR DARI BATAS MARGIN YANG TELAH DITENTUKAN", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }
            }
        }
        private void txtMGNPROFIT1A_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (string.IsNullOrEmpty(txtBTSMGN1.Text)) return;
                if (string.IsNullOrEmpty(txtMGNPROFIT1A.Text))
                {
                    txtHARGAJUAL2.Text = txtHARGABELI2.Text;
                    txtMGNPROFIT1.Text = "0";
                    return;
                }
                if (txtQTYBELI1.Text == "0" || txtQTYBELI1.Text == "") return;

                float btsmrgn1 = float.Parse(txtBTSMGN1.Text);
                float btsmrgn2 = float.Parse(txtBTSMGN2.Text);
                float mrgnprft = float.Parse(txtMGNPROFIT1A.Text);
                decimal hargabeli = decimal.Parse(txtHARGABELI2.Text);
                decimal hargajual = decimal.Parse(txtHARGAJUAL2.Text);
                int QTY = Convert.ToInt32(txtQTYBELI1.Text);

                if ((mrgnprft >= btsmrgn1) && (mrgnprft <= btsmrgn2))
                {
                    if (txtMGNPROFIT1A.Text != "0" || txtMGNPROFIT1A.Text != "")
                    {
                        decimal mrgn = ((decimal.Parse(txtMGNPROFIT1A.Text) / 100) * hargabeli);
                        txtHARGAJUAL2.Text = (hargabeli + mrgn).ToString();
                    }
                    else
                    {
                        txtHARGAJUAL2.Text = hargabeli.ToString();
                    }
                }

                if (mrgnprft < btsmrgn1)
                {
                    MessageBox.Show("MARGIN PROFIT LEBIH KECIL DARI BATAS MARGIN YANG TELAH DITENTUKAN", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }

                if (mrgnprft > btsmrgn2)
                {
                    MessageBox.Show("MARGIN PROFIT LEBIH BESAR DARI BATAS MARGIN YANG TELAH DITENTUKAN", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }
            }
        }
        private void txtMGNSPESIAL_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (string.IsNullOrEmpty(txtBTSMGN1.Text)) return;
                if (string.IsNullOrEmpty(txtHARGAJUAL2.Text)) return;

                float btsmrgn1 = float.Parse(txtBTSMGN1.Text);
                float btsmrgn2 = float.Parse(txtBTSMGN2.Text);
                float mrgnprft = float.Parse(txtMGNSPESIAL.Text);

                if ((mrgnprft >= btsmrgn1) && (mrgnprft <= btsmrgn2))
                {
                    decimal hargajual = decimal.Parse(txtHARGAJUAL2.Text);
                    decimal mrgn = (decimal.Parse(txtMGNSPESIAL.Text) / 100) * hargajual;
                    txtHARGASPESIAL.Text = (hargajual + mrgn).ToString("#.##");
                }

                if (mrgnprft < btsmrgn1)
                {
                    MessageBox.Show("MARGIN PROFIT LEBIH KECIL DARI BATAS MARGIN YANG TELAH DITENTUKAN", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }

                if (mrgnprft > btsmrgn2)
                {
                    MessageBox.Show("MARGIN PROFIT LEBIH BESAR DARI BATAS MARGIN YANG TELAH DITENTUKAN", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }
            }
        }
        private void txtQTYBONUS_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (string.IsNullOrEmpty(txtKODESATUAN.Text))
                {
                    MessageBox.Show("ISI SATUAN TERLEBIH DAHULU", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    txtKODESATUAN.Focus();
                    return;
                }

                try
                {
                    if (txtTOTALPCS.Text != "0" || txtTOTALPCS.Text == "")
                    {
                        int TOTAL = Convert.ToInt32(txtKODESATUAN.Text) * Convert.ToInt32(txtQTYBELI1.Text);
                        int QTY2 = Convert.ToInt32(txtQTYBONUS.Text);
                        int VALUE = TOTAL + QTY2;
                        txtTOTALPCSBNS.Text = VALUE.ToString();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }
        private void txtHARGABELI1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (string.IsNullOrEmpty(txtKODESATUAN.Text))
                {
                    MessageBox.Show("ISI SATUAN TERLEBIH DAHULU", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    txtKODESATUAN.Focus();
                    return;
                }

                try
                {
                    string harga = txtHARGABELI1.Text;

                    // HARGA SATUAN TERBESAR
                    txtHARGABELI1.Text = harga;
                    txtHRGPKKBELI1.Text = harga;
                    txtHARGAJUAL1.Text = harga;

                    // HARGA SATUAN TERKECIL (PCS)
                    decimal value = decimal.Parse(harga);
                    int Qty = Convert.ToInt32(txtKODESATUAN.Text);
                    decimal hrg1 = value / Qty;
                    txtHARGAJUAL2.Text = hrg1.ToString("#.##");
                    txtHARGABELI2.Text = hrg1.ToString("#.##");
                    txtHRGPKKBELI2.Text = hrg1.ToString("#.##");

                    if (txtQTYBELI1.Text != "0" || txtQTYBELI1.Text != "")
                    {
                        int QtyBeli = Convert.ToInt32(txtQTYBELI1.Text);
                        decimal hrg2 = QtyBeli * decimal.Parse(harga);
                        txtBRUTO.Text = hrg2.ToString();
                        txtNETTO.Text = hrg2.ToString();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void txtDSKNRP1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                KALKULASI_DISKON();
                txtDSKNRP2.Focus();
            }
        }
        private void txtDSKNRP2_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                KALKULASI_DISKON();
                txtDSKNPSN1.Focus();
            }
        }
        private void txtDSKNPSN1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                KALKULASI_DISKON();
                txtDSKNPSN2.Focus();
            }
        }
        private void txtDSKNPSN2_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                KALKULASI_DISKON();
                txtDSKNPSN3.Focus();
            }
        }
        private void txtDSKNPSN3_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                KALKULASI_DISKON();
                txtDSKNPSN4.Focus();
            }
        }
        private void txtDSKNPSN4_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                KALKULASI_DISKON();
                txtDSKNPSN5.Focus();
            }
        }
        private void txtDSKNPSN5_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                KALKULASI_DISKON();
                txtPPN.Focus();
            }
        }
        public void KALKULASI_DISKON()
        {
            if (txtQTYBELI1.Text == "0" || txtQTYBELI1.Text == "") return;
            if (txtHARGABELI1.Text == "0" || txtHARGABELI1.Text == "") return;
            if (txtKODESATUAN.Text == "0" || txtKODESATUAN.Text == "") return;

            decimal total = 0;
            decimal totalbruto = 0;

            decimal hargabeli = decimal.Parse(txtHARGABELI1.Text);
            decimal brutto = decimal.Parse(txtBRUTO.Text);
            int QTY = Convert.ToInt32(txtQTYBELI1.Text);
            int ISI = Convert.ToInt32(txtKODESATUAN.Text);

            #region DISKON RP 1
            if (txtDSKNRP1.Text != "0" || txtDSKNRP1.Text != "")
            {
                if (string.IsNullOrEmpty(txtDSKNRP1.Text))
                {
                    txtDSKNRP1.Text = "0";
                }

                decimal dskn = decimal.Parse(txtDSKNRP1.Text);
                decimal val = dskn * QTY;
                txtDSKNRP1A.Text = val.ToString();

                // NETTO
                if (total == 0)
                {
                    total = hargabeli - dskn;
                    totalbruto = brutto - dskn;
                    txtNETTO.Text = totalbruto.ToString();
                    txtHRGPKKBELI1.Text = total.ToString();
                    txtHRGPKKBELI2.Text = (total / ISI).ToString("#.##");
                    txtHARGAJUAL1.Text = total.ToString();
                    txtHARGAJUAL2.Text = (total / ISI).ToString("#.##");
                }
                else
                {
                    total = total - dskn;
                    totalbruto = totalbruto - dskn;
                    txtNETTO.Text = totalbruto.ToString();
                    txtHRGPKKBELI1.Text = total.ToString();
                    txtHRGPKKBELI2.Text = (total / ISI).ToString("#.##");
                    txtHARGAJUAL1.Text = total.ToString();
                    txtHARGAJUAL2.Text = (total / ISI).ToString("#.##");
                }
            }
            else
            {
                txtDSKNRP1A.Text = "0";
            }
            #endregion
            #region DISKON RP 2
            if (txtDSKNRP2.Text != "0" || txtDSKNRP2.Text !="")
            {
                if (string.IsNullOrEmpty(txtDSKNRP2.Text))
                {
                    txtDSKNRP2.Text = "0";
                }

                decimal dskn = decimal.Parse(txtDSKNRP2.Text);
                decimal val = dskn * QTY;
                txtDSKNRP2A.Text = val.ToString();
                // NETTO
                if (total == 0)
                {
                    total = hargabeli - dskn;
                    totalbruto = brutto - dskn;
                    txtNETTO.Text = totalbruto.ToString();
                    txtHRGPKKBELI1.Text = total.ToString();
                    txtHRGPKKBELI2.Text = (total / ISI).ToString("#.##");
                    txtHARGAJUAL1.Text = total.ToString();
                    txtHARGAJUAL2.Text = (total / ISI).ToString("#.##");
                }
                else
                {
                    total = total - dskn;
                    totalbruto = totalbruto - dskn;
                    txtNETTO.Text = totalbruto.ToString();
                    txtHRGPKKBELI1.Text = total.ToString();
                    txtHRGPKKBELI2.Text = (total / ISI).ToString("#.##");
                    txtHARGAJUAL1.Text = total.ToString();
                    txtHARGAJUAL2.Text = (total / ISI).ToString("#.##");
                }
            }
            else
            {
                txtDSKNRP2A.Text = "0";
            }
            #endregion
            #region DISKON PS 1
            if (txtDSKNPSN1.Text != "0")
            {
                if (string.IsNullOrEmpty(txtDSKNPSN1.Text))
                {
                    txtDSKNPSN1.Text = "0";
                }

                decimal dskn = ((decimal.Parse(txtDSKNPSN1.Text) / 100) * hargabeli);
                decimal val = dskn * QTY;
                txtDSKNPSN1A.Text = val.ToString();

                if (total == 0)
                {
                    total = hargabeli - dskn;
                    totalbruto = brutto - val;
                    txtNETTO.Text = totalbruto.ToString();
                    txtHRGPKKBELI1.Text = total.ToString();
                    txtHRGPKKBELI2.Text = (total / ISI).ToString("#.##");
                    txtHARGAJUAL1.Text = total.ToString();
                    txtHARGAJUAL2.Text = (total / ISI).ToString("#.##");

                }
                else
                {
                    total = total - dskn;
                    totalbruto = totalbruto - val;
                    txtNETTO.Text = totalbruto.ToString();
                    txtHRGPKKBELI1.Text = total.ToString();
                    txtHRGPKKBELI2.Text = (total / ISI).ToString("#.##");
                    txtHARGAJUAL1.Text = total.ToString();
                    txtHARGAJUAL2.Text = (total / ISI).ToString("#.##");
                }
            }
            else
            {
                txtDSKNPSN1A.Text = "0";
            }
            #endregion
            #region DISKON PS 2
            if (txtDSKNPSN2.Text != "0")
            {
                if (string.IsNullOrEmpty(txtDSKNPSN2.Text))
                {
                    txtDSKNPSN2.Text = "0";
                }

                decimal dskn = ((decimal.Parse(txtDSKNPSN2.Text) / 100) * hargabeli);
                decimal val = dskn * QTY;
                txtDSKNPSN2A.Text = val.ToString();

                if (total == 0)
                {
                    total = hargabeli - dskn;
                    totalbruto = brutto - val;
                    txtNETTO.Text = totalbruto.ToString();
                    txtHRGPKKBELI1.Text = total.ToString();
                    txtHRGPKKBELI2.Text = (total / ISI).ToString("#.##");
                    txtHARGAJUAL1.Text = total.ToString();
                    txtHARGAJUAL2.Text = (total / ISI).ToString("#.##");
                }
                else
                {
                    total = total - dskn;
                    totalbruto = totalbruto - val;
                    txtNETTO.Text = totalbruto.ToString();
                    txtHRGPKKBELI1.Text = total.ToString();
                    txtHRGPKKBELI2.Text = (total / ISI).ToString("#.##");
                    txtHARGAJUAL1.Text = total.ToString();
                    txtHARGAJUAL2.Text = (total / ISI).ToString("#.##");
                }
            }
            else
            {
                txtDSKNPSN2A.Text = "0";
            }
            #endregion
            #region DISKON PS 3
            if (txtDSKNPSN3.Text != "0")
            {
                if (string.IsNullOrEmpty(txtDSKNPSN3.Text))
                {
                    txtDSKNPSN3.Text = "0";
                }

                decimal dskn = ((decimal.Parse(txtDSKNPSN3.Text) / 100) * hargabeli);
                decimal val = dskn * QTY;
                txtDSKNPSN3A.Text = val.ToString();

                if (total == 0)
                {
                    total = hargabeli - dskn;
                    totalbruto = brutto - val;
                    txtNETTO.Text = totalbruto.ToString();
                    txtHRGPKKBELI1.Text = total.ToString();
                    txtHRGPKKBELI2.Text = (total / ISI).ToString("#.##");
                    txtHARGAJUAL1.Text = total.ToString();
                    txtHARGAJUAL2.Text = (total / ISI).ToString("#.##");
                }
                else
                {
                    total = total - dskn;
                    totalbruto = totalbruto - val;
                    txtNETTO.Text = totalbruto.ToString();
                    txtHRGPKKBELI1.Text = total.ToString();
                    txtHRGPKKBELI2.Text = (total / ISI).ToString("#.##");
                    txtHARGAJUAL1.Text = total.ToString();
                    txtHARGAJUAL2.Text = (total / ISI).ToString("#.##");
                }
            }
            else
            {
                txtDSKNPSN3A.Text = "0";
            }
            #endregion
            #region DISKON PS 4
            if (txtDSKNPSN4.Text != "0")
            {
                if (string.IsNullOrEmpty(txtDSKNPSN4.Text))
                {
                    txtDSKNPSN4.Text = "0";
                }

                decimal dskn = ((decimal.Parse(txtDSKNPSN4.Text) / 100) * hargabeli);
                decimal val = dskn * QTY;
                txtDSKNPSN4A.Text = val.ToString();

                if (total == 0)
                {
                    total = hargabeli - dskn;
                    totalbruto = brutto - val;
                    txtNETTO.Text = totalbruto.ToString();
                    txtHRGPKKBELI1.Text = total.ToString();
                    txtHRGPKKBELI2.Text = (total / ISI).ToString("#.##");
                    txtHARGAJUAL1.Text = total.ToString();
                    txtHARGAJUAL2.Text = (total / ISI).ToString("#.##");
                }
                else
                {
                    total = total - dskn;
                    totalbruto = totalbruto - val;
                    txtNETTO.Text = totalbruto.ToString();
                    txtHRGPKKBELI1.Text = total.ToString();
                    txtHRGPKKBELI2.Text = (total / ISI).ToString("#.##");
                    txtHARGAJUAL1.Text = total.ToString();
                    txtHARGAJUAL2.Text = (total / ISI).ToString("#.##");
                }
            }
            else
            {
                txtDSKNPSN4A.Text = "0";
            }
            #endregion
            #region DISKON PS 5
            if (txtDSKNPSN5.Text != "0")
            {
                if (string.IsNullOrEmpty(txtDSKNPSN5.Text))
                {
                    txtDSKNPSN5.Text = "0";
                }

                decimal dskn = ((decimal.Parse(txtDSKNPSN5.Text) / 100) * hargabeli);
                decimal val = dskn * QTY;
                txtDSKNPSN5A.Text = val.ToString();

                if (total == 0)
                {
                    total = hargabeli - dskn;
                    totalbruto = brutto - val;
                    txtNETTO.Text = totalbruto.ToString();
                    txtHRGPKKBELI1.Text = total.ToString();
                    txtHRGPKKBELI2.Text = (total / ISI).ToString("#.##");
                    txtHARGAJUAL1.Text = total.ToString();
                    txtHARGAJUAL2.Text = (total / ISI).ToString("#.##");
                }
                else
                {
                    total = total - dskn;
                    totalbruto = totalbruto - val;
                    txtNETTO.Text = totalbruto.ToString();
                    txtHRGPKKBELI1.Text = total.ToString();
                    txtHRGPKKBELI2.Text = (total / ISI).ToString("#.##");
                    txtHARGAJUAL1.Text = total.ToString();
                    txtHARGAJUAL2.Text = (total / ISI).ToString("#.##");
                }
            }
            else
            {
                txtDSKNPSN5A.Text = "0";
            }
            #endregion
            #region PPN
            if (txtPPN.Text != "0")
            {
                if (string.IsNullOrEmpty(txtPPN.Text))
                {
                    txtPPN.Text = "0";
                }

                decimal dskn = ((decimal.Parse(txtPPN.Text) / 100) * hargabeli);
                decimal val = dskn * QTY;
                txtPPNA.Text = val.ToString();

                if (total == 0)
                {
                    total = hargabeli + dskn;
                    totalbruto = brutto + val;
                    txtNETTO.Text = totalbruto.ToString();
                    txtHRGPKKBELI1.Text = total.ToString();
                    txtHRGPKKBELI2.Text = (total / ISI).ToString("#.##");
                    txtHARGAJUAL1.Text = total.ToString();
                    txtHARGAJUAL2.Text = (total / ISI).ToString("#.##");
                }
                else
                {
                    total = total + dskn;
                    totalbruto = totalbruto + val;
                    txtNETTO.Text = totalbruto.ToString();
                    txtHRGPKKBELI1.Text = total.ToString();
                    txtHRGPKKBELI2.Text = (total / ISI).ToString("#.##");
                    txtHARGAJUAL1.Text = total.ToString();
                    txtHARGAJUAL2.Text = (total / ISI).ToString("#.##");
                }

            }
            else
            {
                txtPPNA.Text = "0";
            }
            #endregion
        }
        private void txtPPN_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                KALKULASI_DISKON();
            }
        }
        private void txtQTY1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtMGN1.Focus();
            }
        }
        private void txtQTY2_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtMGN2.Focus();
            }
        }
        private void txtQTY3_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtMGN3.Focus();
            }
        }
        private void txtQTY4_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtMGN4.Focus();
            }
        }
        private void txtQTY5_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtMGN5.Focus();
            }
        }

        private void txtMGN1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (string.IsNullOrEmpty(txtBTSMGN1.Text)) return;
                if (string.IsNullOrEmpty(txtHARGAJUAL2.Text)) return;

                float btsmrgn1 = float.Parse(txtBTSMGN1.Text);
                float btsmrgn2 = float.Parse(txtBTSMGN2.Text);
                float mrgnprft = float.Parse(txtMGN1.Text);

                if ((mrgnprft >= btsmrgn1) && (mrgnprft <= btsmrgn2))
                {
                    decimal hargajual = decimal.Parse(txtHARGAJUAL2.Text);
                    decimal mrgn = (decimal.Parse(txtMGN1.Text) / 100) * hargajual;
                    txtHARGA1.Text = (hargajual + mrgn).ToString("#.##");
                }

                if (mrgnprft < btsmrgn1)
                {
                    MessageBox.Show("MARGIN PROFIT LEBIH KECIL DARI BATAS MARGIN YANG TELAH DITENTUKAN", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }

                if (mrgnprft > btsmrgn2)
                {
                    MessageBox.Show("MARGIN PROFIT LEBIH BESAR DARI BATAS MARGIN YANG TELAH DITENTUKAN", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }
            }
        }

        private void txtMGN2_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (string.IsNullOrEmpty(txtBTSMGN1.Text)) return;
                if (string.IsNullOrEmpty(txtHARGAJUAL2.Text)) return;

                float btsmrgn1 = float.Parse(txtBTSMGN1.Text);
                float btsmrgn2 = float.Parse(txtBTSMGN2.Text);
                float mrgnprft = float.Parse(txtMGN2.Text);

                if ((mrgnprft >= btsmrgn1) && (mrgnprft <= btsmrgn2))
                {
                    decimal hargajual = decimal.Parse(txtHARGAJUAL2.Text);
                    decimal mrgn = (decimal.Parse(txtMGN2.Text) / 100) * hargajual;
                    txtHARGA2.Text = (hargajual + mrgn).ToString("#.##");
                }

                if (mrgnprft < btsmrgn1)
                {
                    MessageBox.Show("MARGIN PROFIT LEBIH KECIL DARI BATAS MARGIN YANG TELAH DITENTUKAN", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }

                if (mrgnprft > btsmrgn2)
                {
                    MessageBox.Show("MARGIN PROFIT LEBIH BESAR DARI BATAS MARGIN YANG TELAH DITENTUKAN", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }
            }
        }

        private void txtMGN3_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (string.IsNullOrEmpty(txtBTSMGN1.Text)) return;
                if (string.IsNullOrEmpty(txtHARGAJUAL2.Text)) return;

                float btsmrgn1 = float.Parse(txtBTSMGN1.Text);
                float btsmrgn2 = float.Parse(txtBTSMGN2.Text);
                float mrgnprft = float.Parse(txtMGN3.Text);

                if ((mrgnprft >= btsmrgn1) && (mrgnprft <= btsmrgn2))
                {
                    decimal hargajual = decimal.Parse(txtHARGAJUAL2.Text);
                    decimal mrgn = (decimal.Parse(txtMGN3.Text) / 100) * hargajual;
                    txtHARGA3.Text = (hargajual + mrgn).ToString("#.##");
                }

                if (mrgnprft < btsmrgn1)
                {
                    MessageBox.Show("MARGIN PROFIT LEBIH KECIL DARI BATAS MARGIN YANG TELAH DITENTUKAN", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }

                if (mrgnprft > btsmrgn2)
                {
                    MessageBox.Show("MARGIN PROFIT LEBIH BESAR DARI BATAS MARGIN YANG TELAH DITENTUKAN", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }
            }
        }

        private void txtMGN4_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (string.IsNullOrEmpty(txtBTSMGN1.Text)) return;
                if (string.IsNullOrEmpty(txtHARGAJUAL2.Text)) return;

                float btsmrgn1 = float.Parse(txtBTSMGN1.Text);
                float btsmrgn2 = float.Parse(txtBTSMGN2.Text);
                float mrgnprft = float.Parse(txtMGN4.Text);

                if ((mrgnprft >= btsmrgn1) && (mrgnprft <= btsmrgn2))
                {
                    decimal hargajual = decimal.Parse(txtHARGAJUAL2.Text);
                    decimal mrgn = (decimal.Parse(txtMGN4.Text) / 100) * hargajual;
                    txtHARGA4.Text = (hargajual + mrgn).ToString("#.##");
                }

                if (mrgnprft < btsmrgn1)
                {
                    MessageBox.Show("MARGIN PROFIT LEBIH KECIL DARI BATAS MARGIN YANG TELAH DITENTUKAN", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }

                if (mrgnprft > btsmrgn2)
                {
                    MessageBox.Show("MARGIN PROFIT LEBIH BESAR DARI BATAS MARGIN YANG TELAH DITENTUKAN", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }
            }
        }

        private void txtMGN5_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (string.IsNullOrEmpty(txtBTSMGN1.Text)) return;
                if (string.IsNullOrEmpty(txtHARGAJUAL2.Text)) return;

                float btsmrgn1 = float.Parse(txtBTSMGN1.Text);
                float btsmrgn2 = float.Parse(txtBTSMGN2.Text);
                float mrgnprft = float.Parse(txtMGN5.Text);

                if ((mrgnprft >= btsmrgn1) && (mrgnprft <= btsmrgn2))
                {
                    decimal hargajual = decimal.Parse(txtHARGAJUAL2.Text);
                    decimal mrgn = (decimal.Parse(txtMGN5.Text) / 100) * hargajual;
                    txtHARGA5.Text = (hargajual + mrgn).ToString("#.##");
                }

                if (mrgnprft < btsmrgn1)
                {
                    MessageBox.Show("MARGIN PROFIT LEBIH KECIL DARI BATAS MARGIN YANG TELAH DITENTUKAN", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }

                if (mrgnprft > btsmrgn2)
                {
                    MessageBox.Show("MARGIN PROFIT LEBIH BESAR DARI BATAS MARGIN YANG TELAH DITENTUKAN", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }
            }
        }
    }
}

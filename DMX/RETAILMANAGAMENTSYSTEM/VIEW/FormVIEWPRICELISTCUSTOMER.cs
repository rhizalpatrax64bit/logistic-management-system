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
    public partial class FormVIEWPRICELISTCUSTOMER : Form
    {
        protected RMS.BUSSINES.MASTER.RMS_PRICELIST b = new RMS.BUSSINES.MASTER.RMS_PRICELIST();
        protected RMS.COMMON.MASTER.RMS_PRICELIST c = new RMS.COMMON.MASTER.RMS_PRICELIST();
        
        DELIVERYORDER.FormDATAENTRY frm;
        
        int type;

        public FormVIEWPRICELISTCUSTOMER(DELIVERYORDER.FormDATAENTRY _frm, RMS.COMMON.DELIVERYORDER.RMS_DETAILINVOICE obj)
        {
            InitializeComponent();
            this.frm = _frm;
            c.IDCUSTOMER = obj.IDCUSTOMER;
            c.NAMACUSTOMER = obj.NAMACUSTOMER;
            lblCUSTOMER.Text = obj.NAMACUSTOMER;
            LOAD_DATA();
        }
        public void LOAD_DATA()
        {

            dgvPRICELIST.DataSource = null;
            dgvPRICELIST.Rows.Clear();
            DataTable dt;
          
            dt = b.CARI_BYNAME(c);
                    

            bool isTrue = true;
            string kodearea = string.Empty;
            string JENISCOST;
            string BASAL = "";
            string BTUJUAN = "";
            string BKODE = "";
            string BHARGA = "";
            string BWAKTU = "";


            if (dt.Rows.Count > 0)
            {
                int no_urut = 1;
                for (int i = 0; i < dt.Rows.Count; i++)                {

                    string NAMA = dt.Rows[i]["CUSTOMER"].ToString();
                    kodearea = dt.Rows[i]["KODEAREA"].ToString();
                    string IDPRICELIST = dt.Rows[i]["IDPRICELIST"].ToString();
                    string SERVICE = dt.Rows[i]["KODELAYANAN"].ToString();
                    string HANDLING = dt.Rows[i]["HANDLING"].ToString();
                    string ASAL = dt.Rows[i]["ASAL"].ToString();
                    string TUJUAN = dt.Rows[i]["TUJUAN"].ToString();
                    string TERUSAN = dt.Rows[i]["NAMATERUSAN"].ToString();
                    string CHARGE = dt.Rows[i]["CHARGE"].ToString();
                    string REFUND = dt.Rows[i]["REFUND"].ToString();
                    string DURASI = dt.Rows[i]["DURASIWAKTU"].ToString();
                    string IDASAL = dt.Rows[i]["IDASAL"].ToString();
                    string IDTUJUAN = dt.Rows[i]["IDTUJUAN"].ToString();
                    bool ISAKTIF = bool.Parse(dt.Rows[i]["ISAKTIF"].ToString());

                    string kodecust = dt.Rows[i]["KODECUSTOMER"].ToString();
                    string customer = dt.Rows[i]["CUSTOMER"].ToString();
                    string kasal = dt.Rows[i]["KODEASAL"].ToString();
                    string ktujuan = dt.Rows[i]["KODETUJUAN"].ToString();
                    string IDTERUSAN = dt.Rows[i]["IDTERUSAN"].ToString();
                    string IDHANDLING = dt.Rows[i]["IDHANDLING"].ToString();
                    string IDSERVICE = dt.Rows[i]["IDSERVICE"].ToString();

                    dgvPRICELIST.Rows.Add(IDPRICELIST, SERVICE, HANDLING, ASAL, TUJUAN, TERUSAN, CHARGE, REFUND, DURASI, IDASAL, IDTUJUAN, kasal, ktujuan,IDTERUSAN,IDHANDLING,IDSERVICE);
                    if (ISAKTIF)
                    {                        
                    }
                    else
                    {
                        dgvPRICELIST.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                    }
                }
            }
        }

        private void dgvPRICELIST_Click(object sender, EventArgs e)
        {
            if (dgvPRICELIST.SelectedCells.Count > 0)
            {
               // c.ID = Convert.ToInt32(dgvPRICELIST.SelectedCells[0].OwningRow.Cells["ID"].Value.ToString());
                c.KODEAREAASAL = dgvPRICELIST.SelectedCells[0].OwningRow.Cells["KODEASAL"].Value.ToString();
                c.NAMAASAL = dgvPRICELIST.SelectedCells[0].OwningRow.Cells["ASAL"].Value.ToString();
                c.KODEAREATUJUAN = dgvPRICELIST.SelectedCells[0].OwningRow.Cells["KODETUJUAN"].Value.ToString();
                c.NAMATUJUAN = dgvPRICELIST.SelectedCells[0].OwningRow.Cells["KTUJUAN"].Value.ToString();
                c.NAMATERUSAN = dgvPRICELIST.SelectedCells[0].OwningRow.Cells["TERUSAN"].Value.ToString();
                c.IDHANDLING = Convert.ToInt32(dgvPRICELIST.SelectedCells[0].OwningRow.Cells["IDHANDLING"].Value.ToString());
                c.IDSERVICE = Convert.ToInt32(dgvPRICELIST.SelectedCells[0].OwningRow.Cells["IDSERVICE"].Value.ToString());
                c.CHARGE = float.Parse(dgvPRICELIST.SelectedCells[0].OwningRow.Cells["CHARGE"].Value.ToString());
                c.RC = float.Parse(dgvPRICELIST.SelectedCells[0].OwningRow.Cells["RC"].Value.ToString());
                if (!string.IsNullOrEmpty(dgvPRICELIST.SelectedCells[0].OwningRow.Cells["IDTERUSAN"].Value.ToString()))
                {
                    c.IDTERUSAN = Convert.ToInt32(dgvPRICELIST.SelectedCells[0].OwningRow.Cells["IDTERUSAN"].Value.ToString());
                }
               
                 this.frm.GET_DATA_PRICELIST(c);
                 /*
                    txtKODEORIGIN.Text = obj.KODEAREAASAL;
                    txtNAMAORIGIN.Text = obj.NAMAASAL;
                    txtKODEDESTINATION.Text = obj.KODEAREATUJUAN;
                    txtNAMADESTINATION.Text = obj.NAMAASAL;

                   //txtKODETERUSAN.Text = obj.KODEAREA;
                    txtNAMATERUSAN.Text = obj.NAMATERUSAN;
                  */
                Close();
            }
        }
    }
}

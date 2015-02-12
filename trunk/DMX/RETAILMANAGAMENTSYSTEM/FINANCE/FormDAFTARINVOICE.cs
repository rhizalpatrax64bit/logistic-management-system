using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LOGISTICMANAGAMENTSYSTEM.FINANCE
{
    public partial class FormDAFTARINVOICE : Form
    {
        protected RMS.BUSSINES.DELIVERYORDER.RMS_INVOICE b = new RMS.BUSSINES.DELIVERYORDER.RMS_INVOICE();
        protected RMS.COMMON.DELIVERYORDER.RMS_INVOICE c = new RMS.COMMON.DELIVERYORDER.RMS_INVOICE();
        public FormDAFTARINVOICE()
        {
            InitializeComponent();
        }
        public void LOAD_DATA()
        {
            dgvINVOICE.DataSource = null;
            dgvINVOICE.Rows.Clear();
            DataTable dt = b.SELECT();

            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {

                    string ID = dt.Rows[i]["ID"].ToString();
                    string TGL = DateTime.Parse(dt.Rows[i]["TGLINVOICE"].ToString()).ToString("dd-MM-yyyy");
                    string KODE = dt.Rows[i]["KODEINVOICE"].ToString();
                    string NAMACUSTOMER = dt.Rows[i]["NAMACUSTOMER"].ToString();
                    decimal _TCHARGE = decimal.Parse(dt.Rows[i]["REF_TCHARGE"].ToString());
                    string TCHARGE = string.Format("{0:0,0}", _TCHARGE);
                    decimal _TCOST = decimal.Parse(dt.Rows[i]["REF_TCOST"].ToString());
                    string TCOST = string.Format("{0:0,0}", _TCOST);
                    dgvINVOICE.Rows.Add(ID, TGL, KODE, NAMACUSTOMER, TCHARGE, TCOST);

                }
            }


        }
    }
}

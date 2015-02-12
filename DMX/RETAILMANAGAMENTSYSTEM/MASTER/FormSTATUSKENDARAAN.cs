using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LOGISTICMANAGAMENTSYSTEM.MASTER
{
    public partial class FormSTATUSKENDARAAN : Form
    {
    //protected RMS.BUSSINES.MASTER.RMS_MARKETING b = new RMS.BUSSINES.MASTER.RMS_MARKETING();
   //protected RMS.COMMON.MASTER.RMS_MARKETING c = new RMS.COMMON.MASTER.RMS_MARKETING();
   //DataTable dataPrint;
        public FormSTATUSKENDARAAN()
        {
            InitializeComponent();
            SETTING_MANUAL();
           //LOAD_DATA();
        }
        void SETTING_MANUAL()
        {
            this.Size = new Size(1365, 608);
            this.dgvSTATUSKENDARAAN.Size = new Size(1360, 520);
            this.panelBUTTON.Location = new Point(2, 560);
           // this.panelCARI.Location = new Point(790, 4);
        }
    }
}

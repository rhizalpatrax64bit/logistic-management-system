using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LOGISTICMANAGAMENTSYSTEM.UTILITY
{
    public partial class FormSETTING : Form
    {
        public FormSETTING()
        {
            InitializeComponent();
            SETTING_MANUAL();
        }

        void SETTING_MANUAL()
        {
           this.Size = new Size(1365, 608);
           this.tcUTILITY.Size = new Size(1300, 510);
           this.panelBUTTON.Location = new Point(4, 560);
        }

        private void btnKELUAR_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

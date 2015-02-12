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
    public partial class FormDEVELOPMENT : Form
    {
        public FormDEVELOPMENT()
        {
            InitializeComponent();
            SETTING_MANUAL();
        }
        void SETTING_MANUAL()
        {
            this.Size = new Size(1365, 608);

        }
    }
}

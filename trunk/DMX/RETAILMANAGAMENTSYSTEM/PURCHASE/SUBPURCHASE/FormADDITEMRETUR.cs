﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LOGISTICMANAGAMENTSYSTEM.PURCHASE.SUBPURCHASE
{
    public partial class FormADDITEMRETUR : Form
    {
        public FormADDITEMRETUR()
        {
            InitializeComponent();
        }

        private void txtBARANG_KeyUp(object sender, KeyEventArgs e)
        {
            if (!string.IsNullOrEmpty(txtBARANG.Text)) return;
            if (e.KeyCode == Keys.Enter)
            {
                //VIEW.FormVIEWBARANG frm = new RETAILMANAGAMENTSYSTEM.VIEW.FormVIEWBARANG();
                //frm.ShowDialog();
            }
        }

        private void btnBATAL_Click(object sender, EventArgs e)
        {
            Close();
        }

       
    }
}

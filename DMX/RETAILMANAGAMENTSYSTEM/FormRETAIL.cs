using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;

namespace LOGISTICMANAGAMENTSYSTEM
{
    public partial class MainForm : Form
    {
        protected RMS.BUSSINES.MASTER.RMS_USER bUser = new RMS.BUSSINES.MASTER.RMS_USER();
        protected RMS.COMMON.MASTER.RMS_USER cUser = new RMS.COMMON.MASTER.RMS_USER();
        
        public MainForm(RMS.COMMON.MASTER.RMS_USER obj)
        {
            InitializeComponent();
            //cUser = obj;
            cUser = obj;
        
            LOAD_PC();
           // SETTING();
        }
        
        public ToolStripStatusLabel tsUser
        {
            get
            {
                return tsUser;
            }
        }
        private void tmDT_Tick(object sender, EventArgs e)
        {
            tsJAM.Text = DateTime.Now.ToString("HH:mm:ss");
            tsDATE.Text = DateTime.Now.ToString("dd-MM-yyyy");
           
        }
        void SETTING()
        {
            this.panelMENU.Size = new Size(1365, 608);
        }
        void LOAD_PC()
        {
            Microsoft.VisualBasic.Devices.ServerComputer PC = new Microsoft.VisualBasic.Devices.ServerComputer();
            string Komp = PC.Name;
            string strHostName = "";

            strHostName = System.Net.Dns.GetHostName();
            /*
            IPHostEntry ipEntry = System.Net.Dns.GetHostEntry(strHostName);
            IPAddress[] addr = ipEntry.AddressList;

            if (addr.Count() == 4)
            {
                tsPC.Text = Komp +" - "+ addr[2].ToString();
            }
            if (addr.Count() == 2)
            {
                tsPC.Text = Komp + " - " + addr[1].ToString();
            }
             */
            tsPC.Text = Komp + "-" + LocalIPAddress();
        }
        private IPAddress LocalIPAddress()
        {
            if (!System.Net.NetworkInformation.NetworkInterface.GetIsNetworkAvailable())
            {
                return null;
            }

            IPHostEntry host = Dns.GetHostEntry(Dns.GetHostName());

            return host
                .AddressList
                .FirstOrDefault(ip => ip.AddressFamily == AddressFamily.InterNetwork);
        }
        private void CLEAR_PANEL()
        {
            foreach (Control ctrl in panelMENU.Controls)
            {
                ctrl.Visible = false;
            }
        }
        public void SettForm(Form frm)
        {
            frm.TopLevel = false;
            frm.Visible = true;
            panelMENU.Controls.Add(frm);
            panelMENU.Controls[frm.Name].Focus();
            frm.BringToFront();
        }
        private void tsSETTING_Click(object sender, EventArgs e)
        {
            CLEAR_PANEL();
            UTILITY.FormSETTING frm = new LOGISTICMANAGAMENTSYSTEM.UTILITY.FormSETTING();
            SettForm(frm);
           
        }
        private void tsSUPPLIER_Click(object sender, EventArgs e)
        {
            if (cUser.ismasterdata)
            {
                CLEAR_PANEL();
                MASTER.FormSUPPLIER frm = new LOGISTICMANAGAMENTSYSTEM.MASTER.FormSUPPLIER();
                SettForm(frm);
            }
            else
            {
                MessageBox.Show("Maaf anda tidak mempunyai akses ke modul ini, segera hubungi bagian terkait", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                // Application.Exit();
            }
        }
        private void tsSALES_Click(object sender, EventArgs e)
        {
            CLEAR_PANEL();
            MASTER.FormSALES frm = new LOGISTICMANAGAMENTSYSTEM.MASTER.FormSALES();
            SettForm(frm);
        }
        private void tsMEMBER_Click(object sender, EventArgs e)
        {
            CLEAR_PANEL();
            MASTER.FormMEMBER frm = new LOGISTICMANAGAMENTSYSTEM.MASTER.FormMEMBER();
            SettForm(frm);
        }
        private void tsLABEL_Click(object sender, EventArgs e)
        {
            CLEAR_PANEL();
            MASTER.FormLABEL frm = new LOGISTICMANAGAMENTSYSTEM.MASTER.FormLABEL();
            SettForm(frm);
        }
        private void tsDEPARTMENT_Click(object sender, EventArgs e)
        {
            CLEAR_PANEL();
            MASTER.FormDEPARTMENT frm = new LOGISTICMANAGAMENTSYSTEM.MASTER.FormDEPARTMENT();
            SettForm(frm);
        }

        private void tsBANK_Click(object sender, EventArgs e)
        {
            CLEAR_PANEL();
            MASTER.FormBANK frm = new LOGISTICMANAGAMENTSYSTEM.MASTER.FormBANK();
            SettForm(frm);
        }

        private void tsORDER_Click(object sender, EventArgs e)
        {
            CLEAR_PANEL();
            DELIVERYORDER.FormDAFTARINVOICE frm = new LOGISTICMANAGAMENTSYSTEM.DELIVERYORDER.FormDAFTARINVOICE();
            SettForm(frm);
        }

        private void tsRETUR_Click(object sender, EventArgs e)
        {
            CLEAR_PANEL();
            PURCHASE.FormRETURPEMBELIAN frm = new LOGISTICMANAGAMENTSYSTEM.PURCHASE.FormRETURPEMBELIAN();
            SettForm(frm);
        }

        private void tsSATUAN_Click(object sender, EventArgs e)
        {
            CLEAR_PANEL();
            MASTER.FormSATUAN frm = new LOGISTICMANAGAMENTSYSTEM.MASTER.FormSATUAN();
            SettForm(frm);
        }

        private void tsPEMBELIAN_Click(object sender, EventArgs e)
        {
            CLEAR_PANEL();
            DELIVERYORDER.FormDAFTARSTT frm = new LOGISTICMANAGAMENTSYSTEM.DELIVERYORDER.FormDAFTARSTT(cUser);
            SettForm(frm);
        }

        private void tsBARANGPROMO_Click(object sender, EventArgs e)
        {
            CLEAR_PANEL();
            MASTER.FormBARANGPROMO frm = new LOGISTICMANAGAMENTSYSTEM.MASTER.FormBARANGPROMO();
            SettForm(frm);
        }

        private void tsCUSTOMER_Click(object sender, EventArgs e)
        {
            if (cUser.ismasterdata)
            {
                CLEAR_PANEL();
                MASTER.FormCUSTOMER frm = new LOGISTICMANAGAMENTSYSTEM.MASTER.FormCUSTOMER();
                SettForm(frm);
            }
            else
            {
                MessageBox.Show("Maaf anda tidak mempunyai akses ke modul ini, segera hubungi bagian terkait", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                // Application.Exit();
            }
        }

        private void tsGUDANG_Click(object sender, EventArgs e)
        {
            CLEAR_PANEL();
            MASTER.FormGUDANG frm = new LOGISTICMANAGAMENTSYSTEM.MASTER.FormGUDANG();
            SettForm(frm);
        }

        private void tsMarketing_Click(object sender, EventArgs e)
        {
            if (cUser.ismasterdata)
            {
                CLEAR_PANEL();
                MASTER.FormMARKETING frm = new LOGISTICMANAGAMENTSYSTEM.MASTER.FormMARKETING();
                SettForm(frm);
            }
            else
            {
                MessageBox.Show("Maaf anda tidak mempunyai akses ke modul ini, segera hubungi bagian terkait", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                // Application.Exit();
            }
        }

        private void tsDataKota_Click(object sender, EventArgs e)
        {

            if (cUser.ismasterdata)
            {
                CLEAR_PANEL();
                MASTER.FormKOTA frm = new LOGISTICMANAGAMENTSYSTEM.MASTER.FormKOTA();
                SettForm(frm);
            }
            else
            {
                MessageBox.Show("Maaf anda tidak mempunyai akses ke modul ini, segera hubungi bagian terkait", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void tsPricelist_Click(object sender, EventArgs e)
        {
            if (cUser.ispricelist)
            {
                CLEAR_PANEL();
                MASTER.FormPRICELIST frm = new LOGISTICMANAGAMENTSYSTEM.MASTER.FormPRICELIST();
                SettForm(frm);
            }
            else
            {
                MessageBox.Show("Maaf anda tidak mempunyai akses ke modul ini, segera hubungi bagian terkait", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Stop);
               // Application.Exit();
            }
        }

        private void dAFTARINVOICEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CLEAR_PANEL();
            FINANCE.FormDAFTARINVOICE frm = new LOGISTICMANAGAMENTSYSTEM.FINANCE.FormDAFTARINVOICE();
            SettForm(frm);    
 
        }

        private void pEMBAYARANPIUTANGToolStripMenuItem_Click(object sender, EventArgs e)
        {          
            if (cUser.ispiutang)
            {
                CLEAR_PANEL();
                FINANCE.FormDAFTARPEMBAYRANPIUTANG frm = new LOGISTICMANAGAMENTSYSTEM.FINANCE.FormDAFTARPEMBAYRANPIUTANG();
                SettForm(frm);
            }
            else
            {
                MessageBox.Show("Maaf anda tidak mempunyai akses ke modul ini, segera hubungi bagian terkait", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Stop);
              //  Application.Exit();
            }

        }

        private void dAFTARPEMBAYARANPIUTANGToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (cUser.ispiutang)
            {
                CLEAR_PANEL();
                FINANCE.FormDAFTARPEMBAYRANPIUTANG frm = new LOGISTICMANAGAMENTSYSTEM.FINANCE.FormDAFTARPEMBAYRANPIUTANG();
                SettForm(frm);
            }
            else
            {
                MessageBox.Show("Maaf anda tidak mempunyai akses ke modul ini, segera hubungi bagian terkait", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            

        }

        private void DAFTARPEMBARANHUTANGToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (cUser.ispiutang)
            {
                CLEAR_PANEL();
                FINANCE.FormDAFTARPEMBAYARANHUTANG frm = new LOGISTICMANAGAMENTSYSTEM.FINANCE.FormDAFTARPEMBAYARANHUTANG();
                SettForm(frm); 
            }
            else
            {
                MessageBox.Show("Maaf anda tidak mempunyai akses ke modul ini, segera hubungi bagian terkait", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            
        }

        private void dATAUSERToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (cUser.isuser)
            {
                CLEAR_PANEL();
                MASTER.FormUSER frm = new LOGISTICMANAGAMENTSYSTEM.MASTER.FormUSER();
                SettForm(frm);
            }
            else
            {
                MessageBox.Show("Maaf anda tidak mempunyai akses ke modul ini, segera hubungi bagian terkait", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Stop);
              
            }
        }

        private void lOGINToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bUser.UpdateIsLogin(cUser, 0);
            Application.Exit();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            bUser.UpdateIsLogin(cUser, 0);
        }

        private void tsPRICELISTAGENT_Click(object sender, EventArgs e)
        {
            
            if (cUser.isagent)
            {
                CLEAR_PANEL();
                MASTER.FormPRICELISTAGENT frm = new LOGISTICMANAGAMENTSYSTEM.MASTER.FormPRICELISTAGENT();
                SettForm(frm);
            }
            else
            {
                MessageBox.Show("Maaf anda tidak mempunyai akses ke modul ini, segera hubungi bagian terkait", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Stop);
              //  Application.Exit();
            }
        }
        private void tsTENTANGPERUSAHAAN_Click(object sender, EventArgs e)
        {
            CLEAR_PANEL();
            MASTER.FormTENTANGPERUSAHAAN frm = new LOGISTICMANAGAMENTSYSTEM.MASTER.FormTENTANGPERUSAHAAN();
            SettForm(frm);
        }

        private void dATAPENERIMAToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (cUser.ismasterdata)
            {
                CLEAR_PANEL();
                MASTER.FormPENERIMA frm = new LOGISTICMANAGAMENTSYSTEM.MASTER.FormPENERIMA();
                SettForm(frm);
            }
            else
            {
                MessageBox.Show("Maaf anda tidak mempunyai akses ke modul ini, segera hubungi bagian terkait", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lAPORANPIUTANGToolStripMenuItem_Click(object sender, EventArgs e)
        {
      
            if (cUser.islaporan)
            {
                CLEAR_PANEL();
                FINANCE.FormLAPORANPIUTANG frm = new LOGISTICMANAGAMENTSYSTEM.FINANCE.FormLAPORANPIUTANG();
                SettForm(frm);
            }
            else
            {
                MessageBox.Show("Maaf anda tidak mempunyai akses ke modul ini, segera hubungi bagian terkait", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                //  Application.Exit();
            }
            
        }

        private void lAPORANHUTANGToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CLEAR_PANEL();
            MASTER.FormDEVELOPMENT frm = new LOGISTICMANAGAMENTSYSTEM.MASTER.FormDEVELOPMENT();
            SettForm(frm);
        }

        private void bACKUPDATAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CLEAR_PANEL();
            MASTER.SUBMASTER.FormBACKUP frm = new LOGISTICMANAGAMENTSYSTEM.MASTER.SUBMASTER.FormBACKUP();
            SettForm(frm);
        }

        private void rESTOREDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CLEAR_PANEL();
            MASTER.SUBMASTER.FormRESTORE frm = new LOGISTICMANAGAMENTSYSTEM.MASTER.SUBMASTER.FormRESTORE();
            SettForm(frm);
        }

        private void lAPORANBIAYASTTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CLEAR_PANEL();
            FINANCE.FormDAFTARBIAYASTT frm = new LOGISTICMANAGAMENTSYSTEM.FINANCE.FormDAFTARBIAYASTT();
            SettForm(frm);
        }

        private void tsKENDARAAN_Click(object sender, EventArgs e)
        {
            if (cUser.ismasterdata)
            {
                CLEAR_PANEL();
                MASTER.FormKENDARAAN frm = new LOGISTICMANAGAMENTSYSTEM.MASTER.FormKENDARAAN();
                SettForm(frm);
            }
            else
            {
                MessageBox.Show("Maaf anda tidak mempunyai akses ke modul ini, segera hubungi bagian terkait", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }


        }

        private void tsDRIVER_Click(object sender, EventArgs e)
        {
            if (cUser.ismasterdata)
            {
                CLEAR_PANEL();
                MASTER.FormDRIVER frm = new LOGISTICMANAGAMENTSYSTEM.MASTER.FormDRIVER();
                SettForm(frm);
            }
            else
            {
                MessageBox.Show("Maaf anda tidak mempunyai akses ke modul ini, segera hubungi bagian terkait", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void tsSTATUSKENDARAAN_Click(object sender, EventArgs e)
        {
            if (cUser.ismasterdata)
            {
                CLEAR_PANEL();
                MASTER.FormSTATUSKENDARAAN frm = new LOGISTICMANAGAMENTSYSTEM.MASTER.FormSTATUSKENDARAAN();
                SettForm(frm);
            }
            else
            {
                MessageBox.Show("Maaf anda tidak mempunyai akses ke modul ini, segera hubungi bagian terkait", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void bROADCASTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CLEAR_PANEL();
            MASTER.FormBROADCAST frm = new LOGISTICMANAGAMENTSYSTEM.MASTER.FormBROADCAST();
            SettForm(frm);
        }

        private void pESANANToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CLEAR_PANEL();
           // MASTER.FormPESAN frm = new LOGISTICMANAGAMENTSYSTEM.MASTER.FormPESAN();
            //SettForm(frm);
        }

        private void pENERIMAANBARANGToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            CLEAR_PANEL();
            DELIVERYORDER.FormDAFTARSTT frm = new LOGISTICMANAGAMENTSYSTEM.DELIVERYORDER.FormDAFTARSTT(cUser);
            SettForm(frm);
        }

        private void cETAKINVOICEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CLEAR_PANEL();
            DELIVERYORDER.FormDAFTARINVOICE frm = new LOGISTICMANAGAMENTSYSTEM.DELIVERYORDER.FormDAFTARINVOICE();
            SettForm(frm);
        }

        private void jENISPRODUKToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (cUser.ismasterdata)
            {
                CLEAR_PANEL();
                MASTER.FormJENISPRODUK frm = new LOGISTICMANAGAMENTSYSTEM.MASTER.FormJENISPRODUK();
                SettForm(frm);
            }
            else
            {
                MessageBox.Show("Maaf anda tidak mempunyai akses ke modul ini, segera hubungi bagian terkait", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void hARGAPAKETToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (cUser.ismasterdata)
            {
                CLEAR_PANEL();
                MASTER.FormTARIF frm = new LOGISTICMANAGAMENTSYSTEM.MASTER.FormTARIF();
                SettForm(frm);
            }
            else
            {
                MessageBox.Show("Maaf anda tidak mempunyai akses ke modul ini, segera hubungi bagian terkait", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }


        }

        private void sALESORDERToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (cUser.iscourier)
            {
                CLEAR_PANEL();
                EXPRESS.FormDAFTARSO frm = new LOGISTICMANAGAMENTSYSTEM.EXPRESS.FormDAFTARSO(cUser);
                SettForm(frm);
            }
            else
            {
                MessageBox.Show("Maaf anda tidak mempunyai akses ke modul ini, segera hubungi bagian terkait", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }

        }

        private void pENERIMAANBARANGToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (cUser.iscourier)
            {
                CLEAR_PANEL();
                EXPRESS.FormDAFTARPENGIRIMANBARANG frm = new LOGISTICMANAGAMENTSYSTEM.EXPRESS.FormDAFTARPENGIRIMANBARANG();
                SettForm(frm);
            }
            else
            {
                MessageBox.Show("Maaf anda tidak mempunyai akses ke modul ini, segera hubungi bagian terkait", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

       

       
    }
}

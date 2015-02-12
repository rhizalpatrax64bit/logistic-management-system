using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Anovsys.DAL;
using System.Net;
using System.Net.Sockets;
using System.Net.NetworkInformation;
namespace LOGISTICMANAGAMENTSYSTEM
{
    public partial class FormLOGIN : Form
    {
        protected RMS.BUSSINES.MASTER.RMS_USER bUser = new RMS.BUSSINES.MASTER.RMS_USER();
        protected RMS.COMMON.MASTER.RMS_USER cUser = new RMS.COMMON.MASTER.RMS_USER();

        protected RMS.BUSSINES.MASTER.RMS_TENTANGPERUSAHAAN bPerusahaan = new RMS.BUSSINES.MASTER.RMS_TENTANGPERUSAHAAN();
        protected RMS.COMMON.MASTER.RMS_TENTANGPERUSAHAAN cPerusahaan = new RMS.COMMON.MASTER.RMS_TENTANGPERUSAHAAN();

        protected RMS.BUSSINES.MASTER.RMS_LOGIN bLogin = new RMS.BUSSINES.MASTER.RMS_LOGIN();
        protected RMS.COMMON.MASTER.RMS_LOGIN cLogin = new RMS.COMMON.MASTER.RMS_LOGIN();
        public FormLOGIN()
        {
            InitializeComponent();
        }

        private void btnLOGIN_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            if (string.IsNullOrEmpty(txtUSERNAME.Text))
            {
                MessageBox.Show("Mohon Isi Username", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtUSERNAME.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txtPASSWORD.Text))
            {
                MessageBox.Show("Mohon Isi Password", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtPASSWORD.Focus();
                return;
            }
            if (txtUSERNAME.Text.Trim().Length > 0)
            {
                cUser.username = txtUSERNAME.Text;
                cUser.password = EncodePassword(txtPASSWORD.Text);
                cUser.isaktif = true;
                bool isAuthenticate = bUser.IsAuthenticate(cUser);

                if (isAuthenticate)
                {
                  
                   // bUser.UpdateIsLogin(cUser, 1);
                    this.Visible = false;
                     DataTable dt = bUser.SELECTLOGIN(cUser);
                    if (dt.Rows.Count > 0)
                    {
                        for (int i = 0; i < dt.Rows.Count; i++)
                        {
                            // txtKODE.Text = dt.Rows[0]["KODEAGENT"].ToString();

                            cUser.nama = dt.Rows[i]["nama"].ToString();
                            cUser.level = dt.Rows[i]["level"].ToString();
                            cUser.isbiayastt = bool.Parse(dt.Rows[i]["isbiayastt"].ToString());
                            cUser.ispiutang = bool.Parse(dt.Rows[i]["ispiutang"].ToString());
                            cUser.ismasterdata = bool.Parse(dt.Rows[i]["ismasterdata"].ToString());
                            cUser.isagent = bool.Parse(dt.Rows[i]["isagent"].ToString());
                            cUser.ispricelist = bool.Parse(dt.Rows[i]["ispricelist"].ToString());
                            cUser.isuser = bool.Parse(dt.Rows[i]["isuser"].ToString());
                            cUser.iscourier = bool.Parse(dt.Rows[i]["iscourier"].ToString());
                            cUser.islaporan = bool.Parse(dt.Rows[i]["islaporan"].ToString());
                                                                               

                        }

                    }
                    // Panggil data perusahaan
                    DataTable dtPerusahaan = bPerusahaan.SELECT();
                    if (dtPerusahaan.Rows.Count > 0)
                    {
                        for (int i = 0; i < dtPerusahaan.Rows.Count; i++)
                        {
                            cPerusahaan.KODE = dtPerusahaan.Rows[i]["KODE"].ToString();
                            cPerusahaan.NAMA = dtPerusahaan.Rows[i]["NAMA"].ToString();
                            cPerusahaan.ALAMAT = dtPerusahaan.Rows[i]["ALAMAT"].ToString();
                            cPerusahaan.TELP = dtPerusahaan.Rows[i]["TELP"].ToString();
                        }
                    }
                    MainForm ifrmMain = new MainForm(cUser);
                    Program.MainForm = ifrmMain;
                    ifrmMain.Show();
                    
                }
                else
                {
                    this.Enabled = true;
                    MessageBox.Show("Mohon Isi Username / password dengan benar", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    txtUSERNAME.Focus();
                    return;
                   
                  
                }
                 
            }
           // this.Enabled = true;
           
        }
        public static string EncodePassword(string password)
        {
            string result = "";

            password = password.Trim();

            for (int i = 0; i < password.Length; i++)
            {
                int x = (int)password[i];

                result += char.ConvertFromUtf32((x + 5) * 2);
            }
            return result;
        }

        
       
        void LOAD_PC()
        {
            Microsoft.VisualBasic.Devices.ServerComputer PC = new Microsoft.VisualBasic.Devices.ServerComputer();
            string Komp = PC.Name;
            string strHostName = "";

            strHostName = System.Net.Dns.GetHostName();
            txtHOST.Text = Komp + "-" + LocalIPAddress();

            
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
        private void FormLOGIN_Load(object sender, EventArgs e)
        {
            LOAD_PC();
        }

        private void btnEXIT_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
      
    }
}

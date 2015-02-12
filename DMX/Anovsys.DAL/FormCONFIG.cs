using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Anovsys.DAL
{
    public partial class FormCONFIG : Form
    {
        public FormCONFIG()
        {
            InitializeComponent();
        }

        protected Anovsys.Encryption.Encrypt.AE_Encrypt aee = new Anovsys.Encryption.Encrypt.AE_Encrypt("retail1q2w3e");

        private void btnOK_Click(object sender, EventArgs e)
        {
            string host = txtHOST.Text;
            string user = txtUSER.Text;
            string pass = txtPASS.Text;
            string port = txtPORT.Text;
            string database = "dmx_logistic";

            string path = System.IO.Path.GetFullPath(System.IO.Path.GetDirectoryName(Application.ExecutablePath)) + @"\dbconfig.ini";
           
            if(!File.Exists(path))
            {
                File.Create(path);
                TextWriter sw = new StreamWriter(path);
                sw.WriteLine(host);
                sw.WriteLine(user);
                /*
                if (pass != "")
                {
                    string enc = aee.Encrypt(pass, "retail1q2w3e", 128);
                    sw.WriteLine(enc);
                }
                else
                {
                    sw.WriteLine(pass);
                }
                 */
                sw.WriteLine(pass);
                sw.WriteLine(database);
                sw.WriteLine(port);
                sw.Close();
            }
            else if (File.Exists(path))
            {
                TextWriter sw = new StreamWriter(path);
                sw.WriteLine(host);
                sw.WriteLine(user);
                /*
                if (pass != "")
                {
                    string enc = aee.Encrypt(pass, "bengkel1q2w3e", 128);
                    sw.WriteLine(enc);
                }
                else
                {
                    sw.WriteLine(pass);
                }
                 */ 
                sw.WriteLine(pass);
                sw.WriteLine(database);
                sw.WriteLine(port);
                sw.Close();
            }

            MessageBox.Show("SETTING KONEKSI DATABASE BERHASIL");
            txtHOST.Text = "";
            txtPASS.Text = "";
            txtPORT.Text = "";
            txtUSER.Text = "";
            Close();
        }

        private void btnBATAL_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

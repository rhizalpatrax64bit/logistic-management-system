using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO;
 

namespace LOGISTICMANAGAMENTSYSTEM.MASTER
{
    public partial class FormTENTANGPERUSAHAAN : Form
    {
        protected RMS.BUSSINES.MASTER.RMS_TENTANGPERUSAHAAN b = new RMS.BUSSINES.MASTER.RMS_TENTANGPERUSAHAAN();
        protected RMS.COMMON.MASTER.RMS_TENTANGPERUSAHAAN c = new RMS.COMMON.MASTER.RMS_TENTANGPERUSAHAAN();
        
        DBConnect db;
        String fileName;
        int id;
        int type;
        string imageName;
        MySqlDataReader data;
        public FormTENTANGPERUSAHAAN()
        {
            InitializeComponent();
            btnSIMPAN.Enabled = false;
            LOAD_DATA();
            
          
          
        }
        public void LOAD_DATA()
        {
            DataTable dt = b.SELECT();


            if (dt.Rows.Count > 0)
            {
                type = 1;
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    string kode = dt.Rows[i]["KODE"].ToString();
                    string perusahaan = dt.Rows[i]["NAMA"].ToString();
                    string npwp = dt.Rows[i]["NPWP"].ToString(); 
                    string alamat = dt.Rows[i]["ALAMAT"].ToString();
                    string telp = dt.Rows[i]["TELP"].ToString();
                    string fax = dt.Rows[i]["FAX"].ToString();
                    string cabang1 = dt.Rows[i]["CABANGBANK1"].ToString();
                    string cabang2 = dt.Rows[i]["CABANGBANK2"].ToString();
                    string norek1 = dt.Rows[i]["NOREK1"].ToString();
                    string norek2 = dt.Rows[i]["NOREK2"].ToString();
                    string atasnama1 = dt.Rows[i]["ATASNAMA1"].ToString();
                    string atasnama2 = dt.Rows[i]["ATASNAMA2"].ToString();
                    int fileSize = Convert.ToInt32(dt.Rows[i]["SIZE"].ToString()); 

                    //get the value of the name field in the current row and store it in filesize
                    string name = dt.Rows[i]["IMAGE"].ToString();
                    //Create a byte array to read the file in the row which is in bytes
                    byte[] rawData = new byte[fileSize];
                 
                    Bitmap bmp = new Bitmap(name);
                    imgLOGO.SizeMode = PictureBoxSizeMode.StretchImage;
                    imgLOGO.Image = (Image)bmp;
                    txtNAMAFILE.Text = name;

                    // Set in textbox
                    txtIDPERUSAHAAN.Text = kode;
                    txtNAMAPERUSAHAAN.Text = perusahaan;
                    txtNPWP.Text = npwp;
                    txtALAMAT.Text = alamat;
                    txtTELP.Text = telp;
                    txtFAX.Text = fax;
                    txtCABANG1.Text = cabang1;
                    txtCABANG2.Text = cabang2;
                    txtNOREK1.Text = norek1;
                    txtNOREK2.Text = norek2;
                    txtATASNAMA1.Text = atasnama1;
                    txtATASNAMA2.Text = atasnama2;

                }
                
            }
            else
            {
                type = 0;
               //Disabling the next button to stop causing an exception if its clicked again
                CLEAR();
                
            }
                      

        }

       
        void CLEAR()
        {
            txtIDPERUSAHAAN.Text = "";
            txtNAMAPERUSAHAAN.Text = "";
            txtNPWP.Text = "";
            txtALAMAT.Text = "";
            txtTELP.Text = "";
            txtFAX.Text = "";
            txtNAMAFILE.Text = "";
            imgLOGO.Image = null;
            txtCABANG1.Text = "";
            txtNOREK1.Text = "";
            txtATASNAMA1.Text = "";
            txtCABANG2.Text = "";
            txtNOREK2.Text = "";
            txtATASNAMA2.Text = "";
            btnSIMPAN.Enabled = true;
        }

        private void btnSIMPAN_Click(object sender, EventArgs e)
        {
           
            
            if (string.IsNullOrEmpty(txtNAMAPERUSAHAAN.Text))
            {
                MessageBox.Show("ISI NAMA PERUSAHAAN", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtNAMAPERUSAHAAN.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txtNAMAFILE.Text))
            {
                MessageBox.Show("ISI NAMA FILE", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtNAMAFILE.Focus();
                return;
            }
            int n = 0;
            foreach (char a in txtIDPERUSAHAAN.Text)
            {
                if (a >= '0')
                    n++;
            }
            if (n != 3)
            {

                MessageBox.Show("Pengisian Kode Perusahaan harus 3 digit", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtIDPERUSAHAAN.Focus();
                return;
            }
                           
            //Creating a filestream to open the image file  
            FileStream fs = new FileStream(@imageName, FileMode.Open, FileAccess.Read); 
            //Getting the legth of the fil in bytes
            int fileLength = (int)fs.Length;
            //creating an array to store the image as bytes
            byte[] rawdata = new byte[fileLength];
            
            //using the filestream and converting the image to bits and storing it in 
            //an array
            /*
            fs.Read(rawdata, 0, (int)fileLength);
            //Creating a new mysql command object which will be used to store the image
            MySqlCommand cmd = new MySqlCommand();
             * data
            //creating sql command
            String sql = "insert into perusahaan values(@KODE,@NAMA,@FILE,@IMAGE,@SIZE,@NPWP,@ALAMAT,@TELP,@FAX,@CABANGBANK1,@CABANGBANK2,@NOREK1,@NOREK2,@ATASNAMA1,@ATASNAMA2)";
            //Setting the connection of the command
            cmd.Connection = db.getConnection();
            //setting the sql of the command
            cmd.CommandText = sql;
            //Setting up the parameter values to be used when storing the image to a
            //table
             */ 
          //  @NPWP,@ALAMAT,@TELP,@FAX,@CABANGBANK1,@CABANGBANK2,@NOREK1,@NOREK2,@ATASNAMA1,@ATASNAMA2
            c.KODE = txtIDPERUSAHAAN.Text;
            c.NAMA = txtNAMAPERUSAHAAN.Text;
            c.FILE = rawdata;
            c.SIZE = fileLength;
            c.IMAGE = fileName;
            c.NPWP = txtNPWP.Text;
            c.ALAMAT = txtALAMAT.Text;
            c.TELP = txtTELP.Text;
            c.FAX = txtFAX.Text;
            c.CABANGBANK1 = txtCABANG1.Text;
            c.CABANGBANK2 = txtCABANG2.Text;
            c.NOREK1 = txtNOREK1.Text;
            c.NOREK2 = txtNOREK2.Text;
            c.ATASNAMA1 = txtATASNAMA1.Text;
            c.ATASNAMA2 = txtATASNAMA2.Text;
            

            c.KODE = txtIDPERUSAHAAN.Text;
            if (type == 0)
            {
                DataTable dt = b.CARI_BYKODE(c);
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("KODE : " + c.KODE + " SUDAH TERDAFTAR", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }
                b.INSERT(c);
                MessageBox.Show("ANDA BERHASIL INPUT DATA PERUSAHAAN");
                btnSIMPAN.Enabled = false;
                type = 1;
                this.LOAD_DATA();
              
            }           
                       
            
          
            
            
          
        }
        class DBConnect
        {
            //The connection to the database
            private MySqlConnection con;

            //Construtor initialize and create the connection
            public DBConnect()
            {
                //Connection string
                String conString = "SERVER=localhost; DATABASE=dmx_logistic ;UID=root;PASSWORD='';";
                try
                {
                    //new connection
                    con = new MySqlConnection(conString);

                    //open connection
                    con.Open();
                    //MessageBox.Show("Connection Successful");
                }
                catch (Exception e)
                {
                    MessageBox.Show("Connection Failed");
                }
            }

            public MySqlConnection getConnection()
            {
                //Returning the connection object
                return con;
            }

        }
        // load file open
        public Image byteArrayToImage(byte[] byteBLOBData)
        {
            MemoryStream ms = new MemoryStream(byteBLOBData);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }

        private void openFileDialog()
        {
          
            try
            {
             
                FileDialog fldlg = new OpenFileDialog();
                fldlg.InitialDirectory = Environment.SpecialFolder.MyPictures.ToString();
                fldlg.Filter = "Image File (*.jpg;*.bmp;*.gif)|*.jpg;*.bmp;*.gif";
                
            if (fldlg.ShowDialog() == DialogResult.OK)
            {
                imageName = fldlg.FileName;
                Bitmap bmp = new Bitmap(imageName);
                imgLOGO.SizeMode = PictureBoxSizeMode.StretchImage;
                imgLOGO.Image = (Image)bmp;
                txtNAMAFILE.Text = fldlg.FileName;
                fileName = fldlg.FileName;
                
            }
             
            fldlg = null;
            }
            catch (Exception ex)
            {
            MessageBox.Show(ex.Message.ToString());
            }           
                       
        }
        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog();
        }

        private void btnTAMBAH_Click(object sender, EventArgs e)
        {

        }

        private void btnHAPUS_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtIDPERUSAHAAN.Text))
            {
                MessageBox.Show("TIDAK BISA MELAKUKAN DELETE, KODE PERUSAHAAN KOSONG", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            else
            {
               
                c.KODE = txtIDPERUSAHAAN.Text;
                DialogResult dr = MessageBox.Show("APAKAH YAKIN AKAN DELETE DATA : " + c.KODE + " ?", "WARNING", MessageBoxButtons.OKCancel, MessageBoxIcon.Stop);
                if (dr == DialogResult.OK)
                {
                    b.DELETE(c);
                    LOAD_DATA();
                }
            }
        }

        private void btnKELUAR_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

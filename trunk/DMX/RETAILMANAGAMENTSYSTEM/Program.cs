using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace LOGISTICMANAGAMENTSYSTEM
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 
        public static string ConnectionString = "";
        public static string DefaultFolder = "";
        public static string TargetFile = "";
        public static string conn = "";

        public static MainForm _mainForm;
        public static FormLOGIN _loginForm;
        public static FormLOGIN LoginForm
        {
            get
            {
                return _loginForm;
            }
        }

        public static MainForm MainForm
        {
            get
            {
                return _mainForm;
            }
            set
            {
                _mainForm = value;
            }
        }
         
        [STAThread]
        static void Main()
        {
            System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en-US");
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

           //_mainForm = new MainForm();
            _loginForm = new FormLOGIN();
            Application.Run(_loginForm);
        }
        public static bool TargetDirectoryIsValid()
        {
            try
            {
                string dir = System.IO.Path.GetDirectoryName(Program.TargetFile);

                if (!System.IO.Directory.Exists(dir))
                {
                    System.IO.Directory.CreateDirectory(dir);
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Specify path is not valid. Press [Export As] to specify a valid file path." + Environment.NewLine + Environment.NewLine + ex.ToString(), "Invalid Directory", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
        }

        public static bool SourceFileExists()
        {
            if (!System.IO.File.Exists(Program.TargetFile))
            {
                MessageBox.Show("File is not exists. Press [Select File] to choose a SQL Dump file." + Environment.NewLine + Environment.NewLine + Program.TargetFile, "Import", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            return true;
        }
    }
}

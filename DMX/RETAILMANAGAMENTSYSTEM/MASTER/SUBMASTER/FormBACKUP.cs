using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Anovsys.DAL;
using MySql.Data.MySqlClient;




namespace LOGISTICMANAGAMENTSYSTEM.MASTER.SUBMASTER
{
    public partial class FormBACKUP : Form
    {
        MySqlConnection conn;
        MySqlCommand cmd;
        MySqlBackup mb;
        Timer timer1;
        BackgroundWorker bwExport;

        string _currentTableName = "";
        int _totalRowsInCurrentTable = 0;
        int _totalRowsInAllTables = 0;
        int _currentRowIndexInCurrentTable = 0;
        int _currentRowIndexInAllTable = 0;
        int _totalTables = 0;
        int _currentTableIndex = 0;
        string file = string.Empty;
        Database db = new Database();
     
        //string constring = "server=localhost;user=root;pwd='';database=dmx_logistic;";
        
        public FormBACKUP()
        {
            InitializeComponent();
            
            mb = new MySqlBackup();
            mb.ExportProgressChanged += mb_ExportProgressChanged;

            timer1 = new Timer();
            timer1.Interval = 50;
            timer1.Tick += timer1_Tick;

            bwExport = new BackgroundWorker();
            bwExport.DoWork += bwExport_DoWork;
            bwExport.RunWorkerCompleted += bwExport_RunWorkerCompleted;
        }
        public string connString()
        {
            using (Database db = new Database())
            {
                return db.stringCONN();
            }
        }
        void bwExport_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                mb.ExportToFile(Program.TargetFile);
            }
            catch (Exception ex)
            {
                CloseConnection();
                MessageBox.Show(ex.ToString());
            }
        }

        void bwExport_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            CloseConnection();

            System.Threading.Thread.Sleep(100); // Wait for the timer to do the last progressbar update.

            if (mb.LastError == null)
                MessageBox.Show("Completed.");
            else
                MessageBox.Show("Completed with error(s)." + Environment.NewLine + Environment.NewLine + mb.LastError.ToString());

            timer1.Stop();
        }
        void mb_ExportProgressChanged(object sender, ExportProgressArgs e)
        {
            _currentRowIndexInAllTable = (int)e.CurrentRowIndexInAllTables;
            _currentRowIndexInCurrentTable = (int)e.CurrentRowIndexInCurrentTable;
            _currentTableIndex = e.CurrentTableIndex;
            _currentTableName = e.CurrentTableName;
            _totalRowsInAllTables = (int)e.TotalRowsInAllTables;
            _totalRowsInCurrentTable = (int)e.TotalRowsInCurrentTable;
            _totalTables = e.TotalTables;
        }
        void timer1_Tick(object sender, EventArgs e)
        {
            pbTable.Maximum = _totalTables;
            if (_currentTableIndex <= pbTable.Maximum)
                pbTable.Value = _currentTableIndex;

            pbRowInCurTable.Maximum = _totalRowsInCurrentTable;
            if (_currentRowIndexInCurrentTable <= pbRowInCurTable.Maximum)
                pbRowInCurTable.Value = _currentRowIndexInCurrentTable;

            pbRowInAllTable.Maximum = _totalRowsInAllTables;
            if (_currentRowIndexInAllTable <= pbRowInAllTable.Maximum)
                pbRowInAllTable.Value = _currentRowIndexInAllTable;

            lbCurrentTableName.Text = "Current Processing Table = " + _currentTableName;
            lbRowInCurTable.Text = pbRowInCurTable.Value + " of " + pbRowInCurTable.Maximum;
            lbRowInAllTable.Text = pbRowInAllTable.Value + " of " + pbRowInAllTable.Maximum;
            lbTableCount.Text = _currentTableIndex + " of " + _totalTables;
        }

        private void button_ExportAs_Click(object sender, EventArgs e)
        {
            SaveFileDialog f = new SaveFileDialog();
            if (Program.DefaultFolder != "")
                f.InitialDirectory = Program.DefaultFolder;
            f.Filter = "*.sql|*.sql|*.*|*.*";
            f.FileName = "dmx_logistic " + DateTime.Now.ToString("yyyy-MM-dd HHmmss") + ".sql";
            if (DialogResult.OK == f.ShowDialog())
            {
                textBox_File.Text = f.FileName;
                Program.DefaultFolder = System.IO.Path.GetDirectoryName(textBox_File.Text);
                Program.TargetFile = textBox_File.Text;
                file = textBox_File.Text;
            }
        }
        void CloseConnection()
        {
            if (conn != null)
            {
                conn.Close();
                conn.Dispose();
            }

            if (cmd != null)
                cmd.Dispose();

            if (mb != null)
                mb.StopAllProcess();
        }
        private void button1_Click(object sender, EventArgs e)
        {
        
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            if (mb != null)
                mb.StopAllProcess();
        }

        private void btnSIMPAN_Click(object sender, EventArgs e)
        {

            if (!Program.TargetDirectoryIsValid())
                return;

            _currentTableName = "";
            _totalRowsInCurrentTable = 0;
            _totalRowsInAllTables = 0;
            _currentRowIndexInCurrentTable = 0;
            _currentRowIndexInAllTable = 0;
            _totalTables = 0;
            _currentTableIndex = 0;

            conn = new MySqlConnection(connString().ToString());
            cmd = new MySqlCommand();
            cmd.Connection = conn;
            conn.Open();

            timer1.Start();

            mb.ExportInfo.IntervalForProgressReport = (int)nmExInterval.Value;
            mb.ExportInfo.GetTotalRowsBeforeExport = true;
            mb.Command = cmd;

            bwExport.RunWorkerAsync();
        }

        private void btnBATAL_Click(object sender, EventArgs e)
        {
            if (mb != null)
                mb.StopAllProcess();
        }
    }
}

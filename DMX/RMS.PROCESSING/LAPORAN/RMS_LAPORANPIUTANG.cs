using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RMS.COMMON;
using Anovsys.DAL;
using MySql.Data.MySqlClient;
using System.Data;

namespace RMS.PROCESSING.LAPORAN
{
    public class RMS_LAPORANPIUTANG
    {
        Database db = new Database();
        protected string QUERY_SELECT = "SELECT * FROM laporanpiutangall WHERE TGLINVOICESTT BETWEEN @STARTDATE AND @ENDDATE GROUP BY JUMLAHBAYAR order by INVOICESTT,TGLBAYAR";
        public DataTable SELECT(RMS.COMMON.LAPORAN.RMS_LAPORANPIUTANG obj)
        {
            DataTable dt = new DataTable();
            try
            {
                using (Database db = new Database())
                {
                    db.Commands.Add(db.CreateCommand(QUERY_SELECT));
                    db.Commands[0].Parameters.Add(new Parameter("@STARTDATE", MySqlDbType.VarChar, obj.STARTDATE));
                    db.Commands[0].Parameters.Add(new Parameter("@ENDDATE", MySqlDbType.VarChar, obj.ENDDATE));
                    dt = db.Commands[0].ExecuteDataTable();
                }
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

    }
    
}

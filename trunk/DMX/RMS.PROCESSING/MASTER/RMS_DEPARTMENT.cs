using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RMS.COMMON;
using Anovsys.DAL;
using MySql.Data.MySqlClient;
using System.Data;

namespace RMS.PROCESSING.MASTER
{
    public class RMS_DEPARTMENT
    {
        Database db = new Database();
        protected string QUERY_SELECT = "SELECT * FROM DEPARTMENT";
        protected string QUERY_DELETE = "DELETE FROM DEPARTMENT WHERE KODEDEPARTMENT=@KODEDEPARTMENT";
        protected string QUERY_CARI_BYKODE = "SELECT * FROM DEPARTMENT WHERE KODEDEPARTMENT=@KODEDEPARTMENT";
        protected string QUERY_CARI_BYNAME = "SELECT * FROM DEPARTMENT WHERE NAMADEPARTMENT=@NAMADEPARTMENT";
        protected string QUERY_SEARCH_BYKODE = "SELECT * FROM DEPARTMENT WHERE KODEDEPARTMENT LIKE CONCAT('%',@KODEDEPARTMENT,'%')";
        protected string QUERY_SEARCH_BYNAME = "SELECT * FROM DEPARTMENT WHERE NAMADEPARTMENT LIKE CONCAT('%',@NAMADEPARTMENT,'%')";
        protected string QUERY_INSERT = "INSERT INTO DEPARTMENT(KODEDEPARTMENT,NAMADEPARTMENT,MINMARGIN,MAXMARGIN,KETERANGAN) VALUES "
                                        + "(@KODEDEPARTMENT,@NAMADEPARTMENT,@MINMARGIN,@MAXMARGIN,@KETERANGAN)";
        protected string QUERY_UPDATE = "UPDATE DEPARTMENT SET KODEDEPARTMENT=@KODEDEPARTMENT,NAMADEPARTMENT=@NAMADEPARTMENT,MINMARGIN=@MINMARGIN," +
                                        "MAXMARGIN=@MAXMARGIN,KETERANGAN=@KETERANGAN WHERE  KODEDEPARTMENT=@KODEDEPARTMENT";

        public void INSERT(RMS.COMMON.MASTER.RMS_DEPARTMENT obj)
        {
            try
            {
                using (Database db = new Database())
                {
                    DataTable dt = new DataTable();
                    db.Commands.Add(db.CreateCommand(QUERY_INSERT));
                    db.Commands[0].Parameters.Add(new Parameter("@KODEDEPARTMENT", MySqlDbType.VarChar, obj.KODE));
                    db.Commands[0].Parameters.Add(new Parameter("@NAMADEPARTMENT", MySqlDbType.VarChar, obj.NAMA));
                    db.Commands[0].Parameters.Add(new Parameter("@MINMARGIN", MySqlDbType.VarChar, obj.MINMARGIN));
                    db.Commands[0].Parameters.Add(new Parameter("@MAXMARGIN", MySqlDbType.VarChar, obj.MAXMARGIN));
                    db.Commands[0].Parameters.Add(new Parameter("@KETERANGAN", MySqlDbType.VarChar, obj.KETERANGAN));
                    dt = db.Commands[0].ExecuteDataTable();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void UPDATE(RMS.COMMON.MASTER.RMS_DEPARTMENT obj)
        {
            try
            {
                using (Database db = new Database())
                {
                    DataTable dt = new DataTable();
                    db.Commands.Add(db.CreateCommand(QUERY_UPDATE));
                    db.Commands[0].Parameters.Add(new Parameter("@KODEDEPARTMENT", MySqlDbType.VarChar, obj.KODE));
                    db.Commands[0].Parameters.Add(new Parameter("@NAMADEPARTMENT", MySqlDbType.VarChar, obj.NAMA));
                    db.Commands[0].Parameters.Add(new Parameter("@MINMARGIN", MySqlDbType.VarChar, obj.MINMARGIN));
                    db.Commands[0].Parameters.Add(new Parameter("@MAXMARGIN", MySqlDbType.VarChar, obj.MAXMARGIN));
                    db.Commands[0].Parameters.Add(new Parameter("@KETERANGAN", MySqlDbType.VarChar, obj.KETERANGAN));
                    dt = db.Commands[0].ExecuteDataTable();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void DELETE(RMS.COMMON.MASTER.RMS_DEPARTMENT obj)
        {
            try
            {
                using (Database db = new Database())
                {
                    DataTable dt = new DataTable();
                    db.Commands.Add(db.CreateCommand(QUERY_DELETE));
                    db.Commands[0].Parameters.Add(new Parameter("@KODEDEPARTMENT", MySqlDbType.VarChar, obj.KODE));
                    dt = db.Commands[0].ExecuteDataTable();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public DataTable SELECT()
        {
            DataTable dt = new DataTable();
            try
            {
                using (Database db = new Database())
                {
                    db.Commands.Add(db.CreateCommand(QUERY_SELECT));
                    dt = db.Commands[0].ExecuteDataTable();
                }
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public DataTable CARI_BYKODE(RMS.COMMON.MASTER.RMS_DEPARTMENT obj)
        {
            DataTable dt = new DataTable();
            try
            {
                using (Database db = new Database())
                {
                    db.Commands.Add(db.CreateCommand(QUERY_CARI_BYKODE));
                    db.Commands[0].Parameters.Add(new Parameter("@KODEDEPARTMENT", MySqlDbType.VarChar, obj.KODE));
                    dt = db.Commands[0].ExecuteDataTable();
                }
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public DataTable CARI_BYNAMA(RMS.COMMON.MASTER.RMS_DEPARTMENT obj)
        {
            DataTable dt = new DataTable();
            try
            {
                using (Database db = new Database())
                {
                    db.Commands.Add(db.CreateCommand(QUERY_CARI_BYNAME));
                    db.Commands[0].Parameters.Add(new Parameter("@NAMADEPARTMENT", MySqlDbType.VarChar, obj.NAMA));
                    dt = db.Commands[0].ExecuteDataTable();
                }
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public DataTable SEARCH_BYKODE(RMS.COMMON.MASTER.RMS_DEPARTMENT obj)
        {
            DataTable dt = new DataTable();
            try
            {
                using (Database db = new Database())
                {
                    db.Commands.Add(db.CreateCommand(QUERY_SEARCH_BYKODE));
                    db.Commands[0].Parameters.Add(new Parameter("@KODEDEPARTMENT", MySqlDbType.VarChar, obj.KODE));
                    dt = db.Commands[0].ExecuteDataTable();
                }
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public DataTable SEARCH_BYNAMA(RMS.COMMON.MASTER.RMS_DEPARTMENT obj)
        {
            DataTable dt = new DataTable();
            try
            {
                using (Database db = new Database())
                {
                    db.Commands.Add(db.CreateCommand(QUERY_SEARCH_BYNAME));
                    db.Commands[0].Parameters.Add(new Parameter("@NAMADEPARTMENT", MySqlDbType.VarChar, obj.NAMA));
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

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
    public class RMS_MARKETING
    {
        Database db = new Database();
        protected string QUERY_GETKODE = "SELECT ID as LAST_ID FROM marketing ORDER BY ID desc LIMIT 1";
        protected string QUERY_SELECT = "SELECT * FROM marketing WHERE ISAKTIF = 1";
        protected string QUERY_DELETE = "UPDATE marketing SET ISAKTIF = 0 WHERE KODE=@KODE";
        protected string QUERY_CARI_BYKODE = "SELECT * FROM marketing WHERE ISAKTIF = 1 AND KODE=@KODE";
        protected string QUERY_CARI_BYNAME = "SELECT * FROM marketing WHERE ISAKTIF = 1 AND KODE=@NAMA";
        protected string QUERY_SEARCH_BYKODE = "SELECT * FROM marketing WHERE ISAKTIF = 1 AND (KODE LIKE CONCAT('%',@KODE,'%'))";
        protected string QUERY_SEARCH_BYNAME = "SELECT * FROM marketing WHERE ISAKTIF = 1 AND (KODE LIKE CONCAT('%',@KODE,'%') OR NAMA LIKE CONCAT('%',@NAMA,'%'))";
        protected string QUERY_INSERT = "INSERT INTO marketing (KODE,NAMA,ALAMAT,TELEPON,EMAIL) VALUES "
                                        + "(@KODE,@NAMA,@ALAMAT,@TELEPON,@EMAIL)";
        protected string QUERY_UPDATE = "UPDATE marketing SET KODE=@KODE,NAMA=@NAMA,ALAMAT=@ALAMAT,TELEPON=@TELEPON,EMAIL=@EMAIL WHERE KODE=@KODE";

        public void INSERT(RMS.COMMON.MASTER.RMS_MARKETING obj)
        {
            try
            {
                using (Database db = new Database())
                {
                    DataTable dt = new DataTable();
                    db.Commands.Add(db.CreateCommand(QUERY_INSERT));
                    db.Commands[0].Parameters.Add(new Parameter("@KODE", MySqlDbType.VarChar, obj.KODE));
                    db.Commands[0].Parameters.Add(new Parameter("@NAMA", MySqlDbType.VarChar, obj.NAMA));
                    db.Commands[0].Parameters.Add(new Parameter("@ALAMAT", MySqlDbType.VarChar, obj.ALAMAT));
                    db.Commands[0].Parameters.Add(new Parameter("@TELEPON", MySqlDbType.VarChar, obj.TELP));
                    db.Commands[0].Parameters.Add(new Parameter("@EMAIL", MySqlDbType.VarChar, obj.EMAIL));
                    dt = db.Commands[0].ExecuteDataTable();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void UPDATE(RMS.COMMON.MASTER.RMS_MARKETING obj)
        {
            try
            {
                using (Database db = new Database())
                {
                    DataTable dt = new DataTable();
                    db.Commands.Add(db.CreateCommand(QUERY_UPDATE));
                    db.Commands[0].Parameters.Add(new Parameter("@KODE", MySqlDbType.VarChar, obj.KODE));
                    db.Commands[0].Parameters.Add(new Parameter("@NAMA", MySqlDbType.VarChar, obj.NAMA));
                    db.Commands[0].Parameters.Add(new Parameter("@ALAMAT", MySqlDbType.VarChar, obj.ALAMAT));
                    db.Commands[0].Parameters.Add(new Parameter("@TELEPON", MySqlDbType.VarChar, obj.TELP));
                    db.Commands[0].Parameters.Add(new Parameter("@EMAIL", MySqlDbType.VarChar, obj.EMAIL));
                    dt = db.Commands[0].ExecuteDataTable();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void DELETE(RMS.COMMON.MASTER.RMS_MARKETING obj)
        {
            try
            {
                using (Database db = new Database())
                {
                    DataTable dt = new DataTable();
                    db.Commands.Add(db.CreateCommand(QUERY_DELETE));
                    db.Commands[0].Parameters.Add(new Parameter("@KODE", MySqlDbType.VarChar, obj.KODE));
                    dt = db.Commands[0].ExecuteDataTable();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public DataTable GETKODE()
        {
            DataTable dt = new DataTable();
            try
            {
                using (Database db = new Database())
                {
                    db.Commands.Add(db.CreateCommand(QUERY_GETKODE));
                    dt = db.Commands[0].ExecuteDataTable();
                }
                return dt;
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
        public DataTable CARI_BYKODE(RMS.COMMON.MASTER.RMS_MARKETING obj)
        {
            DataTable dt = new DataTable();
            try
            {
                using (Database db = new Database())
                {
                    db.Commands.Add(db.CreateCommand(QUERY_CARI_BYKODE));
                    db.Commands[0].Parameters.Add(new Parameter("@KODE", MySqlDbType.VarChar, obj.KODE));
                    dt = db.Commands[0].ExecuteDataTable();
                }
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public DataTable CARI_BYNAMA(RMS.COMMON.MASTER.RMS_MARKETING obj)
        {
            DataTable dt = new DataTable();
            try
            {
                using (Database db = new Database())
                {
                    db.Commands.Add(db.CreateCommand(QUERY_CARI_BYNAME));
                    db.Commands[0].Parameters.Add(new Parameter("@NAMA", MySqlDbType.VarChar, obj.NAMA));
                    dt = db.Commands[0].ExecuteDataTable();
                }
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public DataTable SEARCH_BYKODE(RMS.COMMON.MASTER.RMS_MARKETING obj)
        {
            DataTable dt = new DataTable();
            try
            {
                using (Database db = new Database())
                {
                    db.Commands.Add(db.CreateCommand(QUERY_SEARCH_BYKODE));
                    db.Commands[0].Parameters.Add(new Parameter("@KODE", MySqlDbType.VarChar, obj.KODE));
                    dt = db.Commands[0].ExecuteDataTable();
                }
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public DataTable SEARCH_BYNAMA(RMS.COMMON.MASTER.RMS_MARKETING obj)
        {
            DataTable dt = new DataTable();
            try
            {
                using (Database db = new Database())
                {
                    db.Commands.Add(db.CreateCommand(QUERY_SEARCH_BYNAME));
                    db.Commands[0].Parameters.Add(new Parameter("@NAMA", MySqlDbType.VarChar, obj.NAMA));
                    db.Commands[0].Parameters.Add(new Parameter("@KODE", MySqlDbType.VarChar, obj.KODE));
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

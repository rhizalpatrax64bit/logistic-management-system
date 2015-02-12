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
    public class RMS_GUDANG
    {
        Database db = new Database();
        protected string QUERY_SELECT = "SELECT * FROM GUDANG";
        protected string QUERY_DELETE = "DELETE FROM GUDANG WHERE KODEGUDANG=@KODEGUDANG";
        protected string QUERY_CARI_BYKODE = "SELECT * FROM GUDANG WHERE KODEGUDANG=@KODEGUDANG";
        protected string QUERY_CARI_BYNAME = "SELECT * FROM GUDANG WHERE NAMAGUDANG=@NAMAGUDANG";
        protected string QUERY_SEARCH_BYKODE = "SELECT * FROM GUDANG WHERE KODEGUDANG LIKE CONCAT('%',@KODEGUDANG,'%')";
        protected string QUERY_SEARCH_BYNAME = "SELECT * FROM GUDANG WHERE NAMAGUDANG LIKE CONCAT('%',@NAMAGUDANG,'%')";
        protected string QUERY_INSERT = "INSERT INTO GUDANG(KODEGUDANG,NAMAGUDANG,KETERANGAN) VALUES (@KODEGUDANG,@NAMAGUDANG,@KETERANGAN)";
        protected string QUERY_UPDATE = "UPDATE GUDANG SET KODEGUDANG=@KODEGUDANG,NAMAGUDANG=@NAMAGUDANG WHERE KODEGUDANG=@KODEGUDANG";

        public void INSERT(RMS.COMMON.MASTER.RMS_GUDANG obj)
        {
            try
            {
                using (Database db = new Database())
                {
                    DataTable dt = new DataTable();
                    db.Commands.Add(db.CreateCommand(QUERY_INSERT));
                    db.Commands[0].Parameters.Add(new Parameter("@KODEGUDANG", MySqlDbType.VarChar, obj.KODE));
                    db.Commands[0].Parameters.Add(new Parameter("@NAMAGUDANG", MySqlDbType.VarChar, obj.NAMA));
                    db.Commands[0].Parameters.Add(new Parameter("@KETERANGAN", MySqlDbType.VarChar, obj.KETERANGAN));
                    dt = db.Commands[0].ExecuteDataTable();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void UPDATE(RMS.COMMON.MASTER.RMS_GUDANG obj)
        {
            try
            {
                using (Database db = new Database())
                {
                    DataTable dt = new DataTable();
                    db.Commands.Add(db.CreateCommand(QUERY_UPDATE));
                    db.Commands[0].Parameters.Add(new Parameter("@KODEGUDANG", MySqlDbType.VarChar, obj.KODE));
                    db.Commands[0].Parameters.Add(new Parameter("@NAMAGUDANG", MySqlDbType.VarChar, obj.NAMA));
                    db.Commands[0].Parameters.Add(new Parameter("@KETERANGAN", MySqlDbType.VarChar, obj.KETERANGAN));
                    dt = db.Commands[0].ExecuteDataTable();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void DELETE(RMS.COMMON.MASTER.RMS_GUDANG obj)
        {
            try
            {
                using (Database db = new Database())
                {
                    DataTable dt = new DataTable();
                    db.Commands.Add(db.CreateCommand(QUERY_DELETE));
                    db.Commands[0].Parameters.Add(new Parameter("@KODEGUDANG", MySqlDbType.VarChar, obj.KODE));
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
        public DataTable CARI_BYKODE(RMS.COMMON.MASTER.RMS_GUDANG obj)
        {
            DataTable dt = new DataTable();
            try
            {
                using (Database db = new Database())
                {
                    db.Commands.Add(db.CreateCommand(QUERY_CARI_BYKODE));
                    db.Commands[0].Parameters.Add(new Parameter("@KODEGUDANG", MySqlDbType.VarChar, obj.KODE));
                    dt = db.Commands[0].ExecuteDataTable();
                }
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public DataTable CARI_BYNAMA(RMS.COMMON.MASTER.RMS_GUDANG obj)
        {
            DataTable dt = new DataTable();
            try
            {
                using (Database db = new Database())
                {
                    db.Commands.Add(db.CreateCommand(QUERY_CARI_BYNAME));
                    db.Commands[0].Parameters.Add(new Parameter("@NAMAGUDANG", MySqlDbType.VarChar, obj.NAMA));
                    dt = db.Commands[0].ExecuteDataTable();
                }
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public DataTable SEARCH_BYKODE(RMS.COMMON.MASTER.RMS_GUDANG obj)
        {
            DataTable dt = new DataTable();
            try
            {
                using (Database db = new Database())
                {
                    db.Commands.Add(db.CreateCommand(QUERY_SEARCH_BYKODE));
                    db.Commands[0].Parameters.Add(new Parameter("@KODEGUDANG", MySqlDbType.VarChar, obj.KODE));
                    dt = db.Commands[0].ExecuteDataTable();
                }
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public DataTable SEARCH_BYNAMA(RMS.COMMON.MASTER.RMS_GUDANG obj)
        {
            DataTable dt = new DataTable();
            try
            {
                using (Database db = new Database())
                {
                    db.Commands.Add(db.CreateCommand(QUERY_SEARCH_BYNAME));
                    db.Commands[0].Parameters.Add(new Parameter("@NAMAGUDANG", MySqlDbType.VarChar, obj.NAMA));
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

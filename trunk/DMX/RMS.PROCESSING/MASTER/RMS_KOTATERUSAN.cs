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
    public class RMS_KOTATERUSAN
    {
        Database db = new Database();

        protected string QUERY_SELECT = "SELECT * FROM v_terusan";
        protected string QUERY_DELETE = "DELETE FROM v_kota WHERE IDKOTA=@IDKOTA";
        protected string QUERY_CARI_BYKODE = "SELECT * FROM v_kota WHERE KODETERUSAN=@KODETERUSAN";
        protected string QUERY_CARI_BYNAME = "SELECT * FROM v_kota WHERE KODETERUSAN=@KODETERUSAN";
        protected string QUERY_SEARCH_BYKODE = "SELECT * FROM v_kota WHERE KODEAREA LIKE CONCAT('%',@KODEAREA,'%')";
        protected string QUERY_SEARCH_BYNAMELIKE = "SELECT * FROM v_terusan WHERE KODEKOTA =@KODEKOTA AND NAMATERUSAN LIKE CONCAT('%',@NAMATERUSAN,'%') ";
        protected string QUERY_SEARCH_BYNAME = "SELECT * FROM v_terusan WHERE KODEKOTA =@KODEKOTA";
        protected string QUERY_INSERT = "INSERT INTO SALES (KODESALES,NAMASALES,ALAMAT,TELEPON,EMAIL) VALUES "
                                        + "(@KODESALES,@NAMASALES,@ALAMAT,@TELEPON,@EMAIL)";
        protected string QUERY_UPDATE = "UPDATE SALES SET KODESALES=@KODESALES,NAMASALES=@NAMASALES,ALAMAT=@ALAMAT,TELEPON=@TELEPON,EMAIL=@EMAIL WHERE KODESALES=@KODESALES";

        public void INSERT(RMS.COMMON.MASTER.RMS_KOTATERUSAN obj)
        {
            try
            {
                using (Database db = new Database())
                {
                    DataTable dt = new DataTable();
                    db.Commands.Add(db.CreateCommand(QUERY_INSERT));
                    /*
                    db.Commands[0].Parameters.Add(new Parameter("@KODESALES", MySqlDbType.VarChar, obj.KODE));
                    db.Commands[0].Parameters.Add(new Parameter("@NAMASALES", MySqlDbType.VarChar, obj.NAMA));
                    db.Commands[0].Parameters.Add(new Parameter("@ALAMAT", MySqlDbType.VarChar, obj.ALAMAT));
                    db.Commands[0].Parameters.Add(new Parameter("@TELEPON", MySqlDbType.VarChar, obj.TELP));
                    db.Commands[0].Parameters.Add(new Parameter("@EMAIL", MySqlDbType.VarChar, obj.EMAIL));
                     */ 
                    dt = db.Commands[0].ExecuteDataTable();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void UPDATE(RMS.COMMON.MASTER.RMS_KOTATERUSAN obj)
        {
            try
            {
                using (Database db = new Database())
                {
                    DataTable dt = new DataTable();
                    db.Commands.Add(db.CreateCommand(QUERY_UPDATE));
                    /*
                    db.Commands[0].Parameters.Add(new Parameter("@KODESALES", MySqlDbType.VarChar, obj.KODE));
                    db.Commands[0].Parameters.Add(new Parameter("@NAMASALES", MySqlDbType.VarChar, obj.NAMA));
                    db.Commands[0].Parameters.Add(new Parameter("@ALAMAT", MySqlDbType.VarChar, obj.ALAMAT));
                    db.Commands[0].Parameters.Add(new Parameter("@TELEPON", MySqlDbType.VarChar, obj.TELP));
                    db.Commands[0].Parameters.Add(new Parameter("@EMAIL", MySqlDbType.VarChar, obj.EMAIL));
                     */ 
                    dt = db.Commands[0].ExecuteDataTable();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void DELETE(RMS.COMMON.MASTER.RMS_KOTATERUSAN obj)
        {
            try
            {
                using (Database db = new Database())
                {
                    DataTable dt = new DataTable();
                    db.Commands.Add(db.CreateCommand(QUERY_DELETE));
                   // db.Commands[0].Parameters.Add(new Parameter("@KODESALES", MySqlDbType.VarChar, obj.KODE));
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
        public DataTable CARI_BYKODE(RMS.COMMON.MASTER.RMS_KOTATERUSAN obj)
        {
            DataTable dt = new DataTable();
            try
            {
                using (Database db = new Database())
                {
                    db.Commands.Add(db.CreateCommand(QUERY_CARI_BYKODE));
                    db.Commands[0].Parameters.Add(new Parameter("@KODAREA", MySqlDbType.VarChar, obj.KODEAREA));
                    dt = db.Commands[0].ExecuteDataTable();
                }
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public DataTable CARI_BYNAMA(RMS.COMMON.MASTER.RMS_KOTATERUSAN obj)
        {
            DataTable dt = new DataTable();
            try
            {
                using (Database db = new Database())
                {
                    db.Commands.Add(db.CreateCommand(QUERY_CARI_BYNAME));
                    db.Commands[0].Parameters.Add(new Parameter("@KODEKOTA", MySqlDbType.VarChar, obj.KODEAREA));
                    db.Commands[0].Parameters.Add(new Parameter("@NAMATERUSAN", MySqlDbType.VarChar, obj.NAMAKOTA));
                    dt = db.Commands[0].ExecuteDataTable();
                }
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public DataTable SEARCH_BYKODE(RMS.COMMON.MASTER.RMS_KOTATERUSAN obj)
        {
            DataTable dt = new DataTable();
            try
            {
                using (Database db = new Database())
                {
                    db.Commands.Add(db.CreateCommand(QUERY_SEARCH_BYKODE));
                    db.Commands[0].Parameters.Add(new Parameter("@KODEAREA", MySqlDbType.VarChar, obj.KODEAREA));
                    dt = db.Commands[0].ExecuteDataTable();
                }
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public DataTable SEARCH_BYNAMA(RMS.COMMON.MASTER.RMS_KOTATERUSAN obj)
        {
            DataTable dt = new DataTable();
            try
            {
                using (Database db = new Database())
                {
                    if (string.IsNullOrEmpty(obj.NAMAKOTA))
                    {
                        db.Commands.Add(db.CreateCommand(QUERY_SEARCH_BYNAME));
                    }
                    else
                    {
                        db.Commands.Add(db.CreateCommand(QUERY_SEARCH_BYNAMELIKE));
                    }


                    
                    db.Commands[0].Parameters.Add(new Parameter("@KODEKOTA", MySqlDbType.VarChar, obj.KODEAREA));
                    db.Commands[0].Parameters.Add(new Parameter("@NAMATERUSAN", MySqlDbType.VarChar, obj.NAMAKOTA));
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

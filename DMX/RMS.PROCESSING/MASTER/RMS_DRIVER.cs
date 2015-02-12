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
    public class RMS_DRIVER
    {
        Database db = new Database();
        protected string QUERY_GETKODE = "SELECT ID as LAST_ID FROM driver_express ORDER BY ID DESC LIMIT 1";
        protected string QUERY_SELECT = "SELECT * FROM v_driver where ISACTIVE = 1";
        protected string QUERY_DELETE = "UPDATE driver_express SET ISACTIVE = 0 WHERE KODE=@KODE";
        protected string QUERY_CARI_BYKODE = "SELECT * FROM driver_express WHERE KODE=@KODE";
        protected string QUERY_CARI_BYNAME = "SELECT * FROM v_customer WHERE NAMACUSTOMER=@NAMACUSTOMER";
        protected string QUERY_SEARCHLIKE = "SELECT * FROM v_driver WHERE ISACTIVE = 1 and (NAMA LIKE CONCAT('%',@NAMA,'%') OR HP LIKE CONCAT('%',@HP,'%'))";
        protected string QUERY_SEARCHLIKEVIEW = "SELECT * FROM v_driver WHERE ISACTIVE = 1 and STATUS=@STATUS and (NAMA LIKE CONCAT('%',@NAMA,'%') OR HP LIKE CONCAT('%',@HP,'%'))";
        protected string QUERY_SEARCH_BYKODE = "SELECT * FROM v_driver WHERE KODE LIKE CONCAT('%',@KODE,'%')";
        protected string QUERY_SEARCH_BYNAME = "SELECT * FROM v_customer WHERE KODECUSTOMER LIKE CONCAT('%',@KODECUSTOMER,'%') OR NAMACUSTOMER LIKE CONCAT('%',@NAMACUSTOMER,'%')";
        protected string QUERY_INSERT = "INSERT INTO driver_express(KODE,NAMA,ALAMAT,TELEPON,HP,EMAIL,STATUS) VALUES "
                                        + "(@KODE,@NAMA,@ALAMAT,@TELEPON,@HP,@EMAIL,@STATUS)";
        protected string QUERY_UPDATE = "UPDATE driver_express SET NAMA=@NAMA,ALAMAT=@ALAMAT,TELEPON=@TELEPON," +
                                        "HP=@HP,EMAIL=@EMAIL,STATUS=@STATUS WHERE KODE=@KODE";


        public void INSERT(RMS.COMMON.MASTER.RMS_DRIVER obj)
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
                    db.Commands[0].Parameters.Add(new Parameter("@TELEPON", MySqlDbType.VarChar, obj.TELEPON));
                    db.Commands[0].Parameters.Add(new Parameter("@HP", MySqlDbType.VarChar, obj.HP));
                    db.Commands[0].Parameters.Add(new Parameter("@EMAIL", MySqlDbType.VarChar, obj.EMAIL));
                    db.Commands[0].Parameters.Add(new Parameter("@STATUS", MySqlDbType.Int32, obj.STATUS));
                    

                    dt = db.Commands[0].ExecuteDataTable();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void UPDATE(RMS.COMMON.MASTER.RMS_DRIVER obj)
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
                    db.Commands[0].Parameters.Add(new Parameter("@TELEPON", MySqlDbType.VarChar, obj.TELEPON));
                    db.Commands[0].Parameters.Add(new Parameter("@HP", MySqlDbType.VarChar, obj.HP));
                    db.Commands[0].Parameters.Add(new Parameter("@EMAIL", MySqlDbType.VarChar, obj.EMAIL));
                    db.Commands[0].Parameters.Add(new Parameter("@STATUS", MySqlDbType.Int32, obj.STATUS));
                    dt = db.Commands[0].ExecuteDataTable();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void DELETE(RMS.COMMON.MASTER.RMS_DRIVER obj)
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
        public DataTable CARI_BYKODE(RMS.COMMON.MASTER.RMS_DRIVER obj)
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
        public DataTable CARI_BYNAMA(RMS.COMMON.MASTER.RMS_DRIVER obj)
        {
            DataTable dt = new DataTable();
            try
            {
                using (Database db = new Database())
                {
                    db.Commands.Add(db.CreateCommand(QUERY_CARI_BYNAME));
                    //db.Commands[0].Parameters.Add(new Parameter("@NAMACUSTOMER", MySqlDbType.VarChar, obj.NAMACUSTOMER));
                    dt = db.Commands[0].ExecuteDataTable();
                }
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public DataTable SEARCHLIKE(RMS.COMMON.MASTER.RMS_DRIVER obj)
        {
            DataTable dt = new DataTable();
            try
            {
                using (Database db = new Database())
                {
                    db.Commands.Add(db.CreateCommand(QUERY_SEARCHLIKE));
                    db.Commands[0].Parameters.Add(new Parameter("@NAMA", MySqlDbType.VarChar, obj.NAMA));
                    db.Commands[0].Parameters.Add(new Parameter("@HP", MySqlDbType.VarChar, obj.HP));
                
                    dt = db.Commands[0].ExecuteDataTable();
                }
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public DataTable SEARCHLIKEVIEW(RMS.COMMON.MASTER.RMS_DRIVER obj)
        {
            DataTable dt = new DataTable();
            try
            {
                using (Database db = new Database())
                {
                    db.Commands.Add(db.CreateCommand(QUERY_SEARCHLIKEVIEW));
                    db.Commands[0].Parameters.Add(new Parameter("@NAMA", MySqlDbType.VarChar, obj.NAMA));
                    db.Commands[0].Parameters.Add(new Parameter("@HP", MySqlDbType.VarChar, obj.HP));
                    db.Commands[0].Parameters.Add(new Parameter("@STATUS", MySqlDbType.Int32, obj.STATUS));

                    dt = db.Commands[0].ExecuteDataTable();
                }
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public DataTable SEARCH_BYKODE(RMS.COMMON.MASTER.RMS_DRIVER obj)
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
        public DataTable SEARCH_BYNAMA(RMS.COMMON.MASTER.RMS_DRIVER obj)
        {
            DataTable dt = new DataTable();
            try
            {
                using (Database db = new Database())
                {
                    db.Commands.Add(db.CreateCommand(QUERY_SEARCH_BYNAME));
                    //db.Commands[0].Parameters.Add(new Parameter("@NAMACUSTOMER", MySqlDbType.VarChar, obj.NAMACUSTOMER));
                    db.Commands[0].Parameters.Add(new Parameter("@KODECUSTOMER", MySqlDbType.VarChar, obj.KODE));
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

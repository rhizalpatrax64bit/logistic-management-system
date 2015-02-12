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
    public class RMS_JENISPRODUK
    {
        Database db = new Database();
        protected string QUERY_GETKODE = "SELECT ID as LAST_ID FROM produk_express ORDER BY ID DESC LIMIT 1";
        protected string QUERY_SELECT = "SELECT * FROM produk_express WHERE ISACTIVE =1";
        protected string QUERY_DELETE = "UPDATE produk_express SET ISACTIVE =@ISACTIVE WHERE ID=@ID";
        protected string QUERY_CARI_BYKODE = "SELECT * FROM v_customer WHERE KODECUSTOMER=@KODECUSTOMER";
        protected string QUERY_CARI_BYNAME = "SELECT * FROM v_customer WHERE NAMACUSTOMER=@NAMACUSTOMER";
        protected string QUERY_SEARCHLIKE = "SELECT * FROM v_customer WHERE KODECUSTOMER LIKE CONCAT('%',@KODECUSTOMER,'%') OR NAMACUSTOMER LIKE CONCAT('%',@NAMACUSTOMER,'%') OR MARKETING LIKE CONCAT('%',@MARKETING,'%')";
        protected string QUERY_SEARCH_BYKODE = "SELECT * FROM v_customer WHERE KODECUSTOMER LIKE CONCAT('%',@KODECUSTOMER,'%')";
        protected string QUERY_SEARCH_BYNAME = "SELECT * FROM v_customer WHERE KODECUSTOMER LIKE CONCAT('%',@KODECUSTOMER,'%') OR NAMACUSTOMER LIKE CONCAT('%',@NAMACUSTOMER,'%')";
        protected string QUERY_INSERT = "INSERT INTO PRODUK_EXPRESS(KODE,PRODUK) VALUES "
                                        + "(@KODE,@PRODUK)";
        protected string QUERY_UPDATE = "UPDATE CUSTOMER SET KODECUSTOMER=@KODECUSTOMER,NAMACUSTOMER=@NAMACUSTOMER,ALAMAT=@ALAMAT,TELEPON=@TELEPON," +
                                        "HP=@HP,EMAIL=@EMAIL,IDMARKETING=@IDMARKETING WHERE KODECUSTOMER=@KODECUSTOMER";


        public void INSERT(RMS.COMMON.MASTER.RMS_JENISPRODUK obj)
        {
            try
            {
                using (Database db = new Database())
                {
                    DataTable dt = new DataTable();
                    db.Commands.Add(db.CreateCommand(QUERY_INSERT));
                    db.Commands[0].Parameters.Add(new Parameter("@KODE", MySqlDbType.VarChar, obj.KODE));
                    db.Commands[0].Parameters.Add(new Parameter("@PRODUK", MySqlDbType.VarChar, obj.PRODUK));
                    db.Commands[0].Parameters.Add(new Parameter("@KETERANGAN", MySqlDbType.VarChar, obj.KETERANGAN));
                    db.Commands[0].Parameters.Add(new Parameter("@ISAKTIVE", MySqlDbType.Int32, obj.ISAKTIVE));

                   
                    

                    dt = db.Commands[0].ExecuteDataTable();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void UPDATE(RMS.COMMON.MASTER.RMS_JENISPRODUK obj)
        {
            try
            {
                using (Database db = new Database())
                {
                    DataTable dt = new DataTable();
                    db.Commands.Add(db.CreateCommand(QUERY_UPDATE));
                    /*
                    db.Commands[0].Parameters.Add(new Parameter("@KODECUSTOMER", MySqlDbType.VarChar, obj.KODE));
                    db.Commands[0].Parameters.Add(new Parameter("@NAMACUSTOMER", MySqlDbType.VarChar, obj.NAMACUSTOMER));
                    db.Commands[0].Parameters.Add(new Parameter("@ALAMAT", MySqlDbType.VarChar, obj.ALAMAT));                    
                    db.Commands[0].Parameters.Add(new Parameter("@TELEPON", MySqlDbType.VarChar, obj.TELEPON));
                    db.Commands[0].Parameters.Add(new Parameter("@HP", MySqlDbType.VarChar, obj.HP));
                    db.Commands[0].Parameters.Add(new Parameter("@EMAIL", MySqlDbType.VarChar, obj.EMAIL));
                    db.Commands[0].Parameters.Add(new Parameter("@IDMARKETING", MySqlDbType.Int32, obj.IDMARKETING));
                    dt = db.Commands[0].ExecuteDataTable();
                     */ 
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void DELETE(RMS.COMMON.MASTER.RMS_JENISPRODUK obj)
        {
            try
            {
                using (Database db = new Database())
                {
                    DataTable dt = new DataTable();

                    db.Commands.Add(db.CreateCommand(QUERY_DELETE));
                    db.Commands[0].Parameters.Add(new Parameter("@ID", MySqlDbType.Int32, obj.ID));
                    db.Commands[0].Parameters.Add(new Parameter("@ISACTIVE", MySqlDbType.Int32, 0));
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
        public DataTable CARI_BYKODE(RMS.COMMON.MASTER.RMS_JENISPRODUK obj)
        {
            DataTable dt = new DataTable();
            try
            {
                using (Database db = new Database())
                {
                    db.Commands.Add(db.CreateCommand(QUERY_CARI_BYKODE));
                    /*
                    db.Commands[0].Parameters.Add(new Parameter("@KODECUSTOMER", MySqlDbType.VarChar, obj.KODE));
                    dt = db.Commands[0].ExecuteDataTable();
                     */ 
                }
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public DataTable CARI_BYNAMA(RMS.COMMON.MASTER.RMS_JENISPRODUK obj)
        {
            DataTable dt = new DataTable();
            try
            {
                using (Database db = new Database())
                {
                    db.Commands.Add(db.CreateCommand(QUERY_CARI_BYNAME));
                    /*
                    db.Commands[0].Parameters.Add(new Parameter("@NAMACUSTOMER", MySqlDbType.VarChar, obj.NAMACUSTOMER));
                    dt = db.Commands[0].ExecuteDataTable();
                     */ 
                }
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public DataTable SEARCHLIKE(RMS.COMMON.MASTER.RMS_JENISPRODUK obj)
        {
            DataTable dt = new DataTable();
            try
            {
                using (Database db = new Database())
                {
                    db.Commands.Add(db.CreateCommand(QUERY_SEARCHLIKE));
                    /*
                    db.Commands[0].Parameters.Add(new Parameter("@KODECUSTOMER", MySqlDbType.VarChar, obj.KODE));
                    db.Commands[0].Parameters.Add(new Parameter("@NAMACUSTOMER", MySqlDbType.VarChar, obj.NAMACUSTOMER));
                    db.Commands[0].Parameters.Add(new Parameter("@MARKETING", MySqlDbType.VarChar, obj.MARKETING));
                    dt = db.Commands[0].ExecuteDataTable();
                     */ 
                }
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public DataTable SEARCH_BYKODE(RMS.COMMON.MASTER.RMS_JENISPRODUK obj)
        {
            DataTable dt = new DataTable();
            try
            {
                using (Database db = new Database())
                {
                    db.Commands.Add(db.CreateCommand(QUERY_SEARCH_BYKODE));
                    /*
                    db.Commands[0].Parameters.Add(new Parameter("@KODECUSTOMER", MySqlDbType.VarChar, obj.KODE));
                    dt = db.Commands[0].ExecuteDataTable();
                     */ 
                }
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public DataTable SEARCH_BYNAMA(RMS.COMMON.MASTER.RMS_JENISPRODUK obj)
        {
            DataTable dt = new DataTable();
            try
            {
                using (Database db = new Database())
                {
                    db.Commands.Add(db.CreateCommand(QUERY_SEARCH_BYNAME));
                    /*
                    db.Commands[0].Parameters.Add(new Parameter("@NAMACUSTOMER", MySqlDbType.VarChar, obj.NAMACUSTOMER));
                    db.Commands[0].Parameters.Add(new Parameter("@KODECUSTOMER", MySqlDbType.VarChar, obj.KODE));
                    dt = db.Commands[0].ExecuteDataTable();
                     */ 
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

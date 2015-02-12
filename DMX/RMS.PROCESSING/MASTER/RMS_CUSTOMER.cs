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
    public class RMS_CUSTOMER
    {
        Database db = new Database();
        protected string QUERY_GETKODE = "SELECT IDCUSTOMER as LAST_ID FROM customer ORDER BY IDCUSTOMER DESC LIMIT 1";
        protected string QUERY_SELECT = "SELECT * FROM v_customer WHERE TYPE = @TYPE AND ISAKTIF = 1";
        protected string QUERY_DELETE = "UPDATE CUSTOMER SET ISAKTIF = 0 WHERE KODECUSTOMER=@KODECUSTOMER";
        protected string QUERY_CARI_BYKODE = "SELECT * FROM v_customer WHERE KODECUSTOMER=@KODECUSTOMER";
        protected string QUERY_CARI_BYNAME = "SELECT * FROM v_customer WHERE NAMACUSTOMER=@NAMACUSTOMER";
        protected string QUERY_SEARCHLIKE = "SELECT * FROM v_customer WHERE TYPE=@TYPE AND (KODECUSTOMER LIKE CONCAT('%',@KODECUSTOMER,'%') OR NAMACUSTOMER LIKE CONCAT('%',@NAMACUSTOMER,'%') OR MARKETING LIKE CONCAT('%',@MARKETING,'%')) AND ISAKTIF = 1";
        protected string QUERY_SEARCH_BYKODE = "SELECT * FROM v_customer WHERE KODECUSTOMER LIKE CONCAT('%',@KODECUSTOMER,'%')";
        protected string QUERY_SEARCH_BYNAME = "SELECT * FROM v_customer WHERE TYPE=@TYPE AND ISAKTIF = 1 AND (KODECUSTOMER LIKE CONCAT('%',@KODECUSTOMER,'%') OR NAMACUSTOMER LIKE CONCAT('%',@NAMACUSTOMER,'%'))";
        protected string QUERY_INSERT = "INSERT INTO CUSTOMER(KODECUSTOMER,NAMACUSTOMER,ALAMAT,TELEPON,HP,EMAIL,IDMARKETING,TYPE) VALUES "
                                        + "(@KODECUSTOMER,@NAMACUSTOMER,@ALAMAT,@TELEPON,@HP,@EMAIL,@IDMARKETING,@TYPE)";
        protected string QUERY_UPDATE = "UPDATE CUSTOMER SET KODECUSTOMER=@KODECUSTOMER,NAMACUSTOMER=@NAMACUSTOMER,ALAMAT=@ALAMAT,TELEPON=@TELEPON," +
                                        "HP=@HP,EMAIL=@EMAIL,IDMARKETING=@IDMARKETING, TYPE=@TYPE WHERE KODECUSTOMER=@KODECUSTOMER";


        public void INSERT(RMS.COMMON.MASTER.RMS_CUSTOMER obj)
        {
            try
            {
                using (Database db = new Database())
                {
                    DataTable dt = new DataTable();
                    db.Commands.Add(db.CreateCommand(QUERY_INSERT));
                    db.Commands[0].Parameters.Add(new Parameter("@KODECUSTOMER", MySqlDbType.VarChar, obj.KODE));
                    db.Commands[0].Parameters.Add(new Parameter("@NAMACUSTOMER", MySqlDbType.VarChar, obj.NAMACUSTOMER));
                    db.Commands[0].Parameters.Add(new Parameter("@ALAMAT", MySqlDbType.VarChar, obj.ALAMAT));
                    db.Commands[0].Parameters.Add(new Parameter("@TELEPON", MySqlDbType.VarChar, obj.TELEPON));
                    db.Commands[0].Parameters.Add(new Parameter("@HP", MySqlDbType.VarChar, obj.HP));
                    db.Commands[0].Parameters.Add(new Parameter("@EMAIL", MySqlDbType.VarChar, obj.EMAIL));
                    db.Commands[0].Parameters.Add(new Parameter("@TYPE", MySqlDbType.Int32, obj.TYPE));
                        if(obj.IDMARKETING != 0)
                        {
                            db.Commands[0].Parameters.Add(new Parameter("@IDMARKETING", MySqlDbType.Int32, obj.IDMARKETING));
                        }
                        else
                        {
                               db.Commands[0].Parameters.Add(new Parameter("@IDMARKETING", MySqlDbType.Int32, null));
                        }

                    dt = db.Commands[0].ExecuteDataTable();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void UPDATE(RMS.COMMON.MASTER.RMS_CUSTOMER obj)
        {
            try
            {
                using (Database db = new Database())
                {
                    DataTable dt = new DataTable();
                    db.Commands.Add(db.CreateCommand(QUERY_UPDATE));
                    db.Commands[0].Parameters.Add(new Parameter("@KODECUSTOMER", MySqlDbType.VarChar, obj.KODE));
                    db.Commands[0].Parameters.Add(new Parameter("@NAMACUSTOMER", MySqlDbType.VarChar, obj.NAMACUSTOMER));
                    db.Commands[0].Parameters.Add(new Parameter("@ALAMAT", MySqlDbType.VarChar, obj.ALAMAT));                    
                    db.Commands[0].Parameters.Add(new Parameter("@TELEPON", MySqlDbType.VarChar, obj.TELEPON));
                    db.Commands[0].Parameters.Add(new Parameter("@HP", MySqlDbType.VarChar, obj.HP));
                    db.Commands[0].Parameters.Add(new Parameter("@EMAIL", MySqlDbType.VarChar, obj.EMAIL));
                    if (obj.IDMARKETING != 0)
                    {
                        db.Commands[0].Parameters.Add(new Parameter("@IDMARKETING", MySqlDbType.Int32, obj.IDMARKETING));
                    }
                    else
                    {
                        db.Commands[0].Parameters.Add(new Parameter("@IDMARKETING", MySqlDbType.Int32, null));
                    }
                    db.Commands[0].Parameters.Add(new Parameter("@TYPE", MySqlDbType.Int32, obj.TYPE));
                    dt = db.Commands[0].ExecuteDataTable();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void DELETE(RMS.COMMON.MASTER.RMS_CUSTOMER obj)
        {
            try
            {
                using (Database db = new Database())
                {
                    DataTable dt = new DataTable();
                    db.Commands.Add(db.CreateCommand(QUERY_DELETE));
                    db.Commands[0].Parameters.Add(new Parameter("@KODECUSTOMER", MySqlDbType.VarChar, obj.KODE));
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
        public DataTable SELECT(RMS.COMMON.MASTER.RMS_CUSTOMER obj)
        {
            DataTable dt = new DataTable();
            try
            {
                using (Database db = new Database())
                {
                    db.Commands.Add(db.CreateCommand(QUERY_SELECT));
                    db.Commands[0].Parameters.Add(new Parameter("@TYPE", MySqlDbType.Int32, obj.TYPE));
                    dt = db.Commands[0].ExecuteDataTable();
                }
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public DataTable CARI_BYKODE(RMS.COMMON.MASTER.RMS_CUSTOMER obj)
        {
            DataTable dt = new DataTable();
            try
            {
                using (Database db = new Database())
                {
                    db.Commands.Add(db.CreateCommand(QUERY_CARI_BYKODE));
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
        public DataTable CARI_BYNAMA(RMS.COMMON.MASTER.RMS_CUSTOMER obj)
        {
            DataTable dt = new DataTable();
            try
            {
                using (Database db = new Database())
                {
                    db.Commands.Add(db.CreateCommand(QUERY_CARI_BYNAME));
                    db.Commands[0].Parameters.Add(new Parameter("@NAMACUSTOMER", MySqlDbType.VarChar, obj.NAMACUSTOMER));
                    dt = db.Commands[0].ExecuteDataTable();
                }
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        
        public DataTable SEARCHLIKE(RMS.COMMON.MASTER.RMS_CUSTOMER obj)
        {
            DataTable dt = new DataTable();
            try
            {
                using (Database db = new Database())
                {
                    db.Commands.Add(db.CreateCommand(QUERY_SEARCHLIKE));
                    db.Commands[0].Parameters.Add(new Parameter("@KODECUSTOMER", MySqlDbType.VarChar, obj.KODE));
                    db.Commands[0].Parameters.Add(new Parameter("@NAMACUSTOMER", MySqlDbType.VarChar, obj.NAMACUSTOMER));
                    db.Commands[0].Parameters.Add(new Parameter("@MARKETING", MySqlDbType.VarChar, obj.MARKETING));
                    db.Commands[0].Parameters.Add(new Parameter("@TYPE", MySqlDbType.Int32, obj.TYPE));
                    dt = db.Commands[0].ExecuteDataTable();
                }
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public DataTable SEARCH_BYKODE(RMS.COMMON.MASTER.RMS_CUSTOMER obj)
        {
            DataTable dt = new DataTable();
            try
            {
                using (Database db = new Database())
                {
                    db.Commands.Add(db.CreateCommand(QUERY_SEARCH_BYKODE));
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
        public DataTable SEARCH_BYNAMA(RMS.COMMON.MASTER.RMS_CUSTOMER obj)
        {
            DataTable dt = new DataTable();
            try
            {
                using (Database db = new Database())
                {
                    db.Commands.Add(db.CreateCommand(QUERY_SEARCH_BYNAME));
                    db.Commands[0].Parameters.Add(new Parameter("@NAMACUSTOMER", MySqlDbType.VarChar, obj.NAMACUSTOMER));
                    db.Commands[0].Parameters.Add(new Parameter("@KODECUSTOMER", MySqlDbType.VarChar, obj.KODE));
                    db.Commands[0].Parameters.Add(new Parameter("@TYPE", MySqlDbType.Int32, obj.TYPE));
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

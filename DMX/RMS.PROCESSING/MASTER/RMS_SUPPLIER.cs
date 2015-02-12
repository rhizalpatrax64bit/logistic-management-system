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
    public class RMS_SUPPLIER
    {
        Database db = new Database();
        protected string QUERY_GETKODE = "SELECT ID_AGENT as LAST_ID FROM agent ORDER BY ID_AGENT DESC LIMIT 1";
        protected string QUERY_SELECT = "SELECT * FROM V_AGENT WHERE ISAKTIF = 1 order by HANDLING";
        protected string QUERY_SELECTUDARA = "SELECT * FROM V_AGENT WHERE ISAKTIF = 1 AND HANDLING = @HANDLING";
        protected string QUERY_SELECTUDARALIKE = "SELECT * FROM V_AGENT WHERE ISAKTIF = 1 AND HANDLING = @HANDLING AND (KODEAGENT LIKE CONCAT('%',@KODEAGENT,'%') OR NAMAAGENT LIKE CONCAT('%',@NAMAAGENT,'%'))";
        protected string QUERY_SELECTPRICELIST = "SELECT * FROM V_PRICELISTAGENT";
        protected string QUERY_DELETE = "UPDATE agent SET ISAKTIF = 0 WHERE KODEAGENT=@KODEAGENT";
        protected string QUERY_CARI_BYKODE = "SELECT * FROM V_AGENT WHERE ISAKTIF = 1 AND KODEAGENT=@KODEAGENT order by HANDLING";
        protected string QUERY_CARI_UPDATE = "SELECT * FROM agent WHERE ISAKTIF = 1 AND KODEAGENT=@KODEAGENT";
        protected string QUERY_CARI_BYNAME = "SELECT * FROM V_AGENT WHERE ISAKTIF =1 AND NAMAAGENT=@NAMAAGENT";
        protected string QUERY_SEARCH_BYKODE = "SELECT * FROM V_AGENT WHERE KODEAGENT LIKE CONCAT('%',@KODEAGENT,'%')";
        protected string QUERY_SEARCH_BYNAME = "SELECT * FROM V_AGENT WHERE ISAKTIF = 1 AND (HANDLING LIKE CONCAT('%',@HANDLING,'%') OR KODEAGENT LIKE CONCAT('%',@KODEAGENT,'%') OR NAMAAGENT LIKE CONCAT('%',@NAMAAGENT,'%'))";
        protected string QUERY_SEARCH_BYNAMEPRICELIST = "SELECT * FROM V_PRICELISTAGENT WHERE JNSCOST = @JNSCOST OR KODEAGENT LIKE CONCAT('%',@KODEAGENT,'%') OR NAMAAGENT LIKE CONCAT('%',@NAMAAGENT,'%')";
        protected string QUERY_INSERT = "INSERT INTO agent(KODEAGENT,HANDLING_ID,NAMAAGENT,ALAMAT,CP,TELEPON,NPWP,BANK,ACCOUNTNUMBER,ATASNAMA,IS_AF,IS_TRUCK,IS_WH,IS_GRDH,IS_SHIPPING,IS_DELIVERY,IS_REGULATEDAGENT) VALUES " +
                                        "(@KODEAGENT,@HANDLING_ID,@NAMAAGENT,@ALAMAT,@CP,@TELEPON,@NPWP,@BANK,@ACCOUNTNUMBER,@ATASNAMA,@IS_AF,@IS_TRUCK,@IS_WH,@IS_GRDH,@IS_SHIPPING,@IS_DELIVERY,@IS_RA)";
        protected string QUERY_UPDATE = "UPDATE agent SET KODEAGENT=@KODEAGENT,HANDLING_ID=@HANDLING_ID,NAMAAGENT=@NAMAAGENT,ALAMAT=@ALAMAT,CP=@CP,TELEPON=@TELEPON," +
                                        "NPWP=@NPWP,BANK=@BANK,ACCOUNTNUMBER=@ACCOUNTNUMBER,ATASNAMA=@ATASNAMA,IS_AF=@IS_AF,IS_TRUCK=@IS_TRUCK,IS_WH=@IS_WH,IS_GRDH=@IS_GRDH,IS_SHIPPING =@IS_SHIPPING,IS_DELIVERY=@IS_DELIVERY,IS_REGULATEDAGENT=@IS_RA WHERE KODEAGENT=@KODEAGENT";

        public void INSERT(RMS.COMMON.MASTER.RMS_SUPPLIER obj)
        {
            try
            {
                using (Database db = new Database())
                {
                    DataTable dt = new DataTable();
                    db.Commands.Add(db.CreateCommand(QUERY_INSERT));
                    db.Commands[0].Parameters.Add(new Parameter("@KODEAGENT", MySqlDbType.VarChar, obj.KODE));
                    db.Commands[0].Parameters.Add(new Parameter("@HANDLING_ID", MySqlDbType.Int32, obj.HANDLING_ID));
                    db.Commands[0].Parameters.Add(new Parameter("@NAMAAGENT", MySqlDbType.VarChar, obj.NAMA));
                    db.Commands[0].Parameters.Add(new Parameter("@ALAMAT", MySqlDbType.VarChar, obj.ALAMAT));
                    db.Commands[0].Parameters.Add(new Parameter("@CP", MySqlDbType.VarChar, obj.CP));
                    db.Commands[0].Parameters.Add(new Parameter("@TELEPON", MySqlDbType.VarChar, obj.TELEPON));
                    db.Commands[0].Parameters.Add(new Parameter("@NPWP", MySqlDbType.VarChar, obj.NPWP));
                    db.Commands[0].Parameters.Add(new Parameter("@BANK", MySqlDbType.VarChar, obj.BANK));
                    db.Commands[0].Parameters.Add(new Parameter("@ACCOUNTNUMBER", MySqlDbType.VarChar, obj.ACCOUNT));
                    db.Commands[0].Parameters.Add(new Parameter("@ATASNAMA", MySqlDbType.VarChar, obj.ATASNAMA));
                    db.Commands[0].Parameters.Add(new Parameter("@IS_AF", MySqlDbType.Bit, obj.IS_AF));
                    db.Commands[0].Parameters.Add(new Parameter("@IS_TRUCK", MySqlDbType.Bit, obj.IS_TRUCK));
                    db.Commands[0].Parameters.Add(new Parameter("@IS_WH", MySqlDbType.Bit, obj.IS_WH));
                    db.Commands[0].Parameters.Add(new Parameter("@IS_GRDH", MySqlDbType.Bit, obj.IS_GRDH));
                    db.Commands[0].Parameters.Add(new Parameter("@IS_SHIPPING", MySqlDbType.Bit, obj.IS_SHIPPING));
                    db.Commands[0].Parameters.Add(new Parameter("@IS_DELIVERY", MySqlDbType.Bit, obj.IS_DELIVERY));
                    db.Commands[0].Parameters.Add(new Parameter("@IS_RA", MySqlDbType.Bit, obj.IS_RA));
              
                    dt = db.Commands[0].ExecuteDataTable();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void UPDATE(RMS.COMMON.MASTER.RMS_SUPPLIER obj)
        {
            try
            {
                using (Database db = new Database())
                {
                    DataTable dt = new DataTable();
                    db.Commands.Add(db.CreateCommand(QUERY_UPDATE));
                    db.Commands[0].Parameters.Add(new Parameter("@KODEAGENT", MySqlDbType.VarChar, obj.KODE));
                    db.Commands[0].Parameters.Add(new Parameter("@HANDLING_ID", MySqlDbType.Int32, obj.HANDLING_ID));
                    db.Commands[0].Parameters.Add(new Parameter("@NAMAAGENT", MySqlDbType.VarChar, obj.NAMA));
                    db.Commands[0].Parameters.Add(new Parameter("@ALAMAT", MySqlDbType.VarChar, obj.ALAMAT));
                    db.Commands[0].Parameters.Add(new Parameter("@CP", MySqlDbType.VarChar, obj.CP));
                    db.Commands[0].Parameters.Add(new Parameter("@TELEPON", MySqlDbType.VarChar, obj.TELEPON));
                    db.Commands[0].Parameters.Add(new Parameter("@NPWP", MySqlDbType.VarChar, obj.NPWP));
                    db.Commands[0].Parameters.Add(new Parameter("@BANK", MySqlDbType.VarChar, obj.BANK));
                    db.Commands[0].Parameters.Add(new Parameter("@ACCOUNTNUMBER", MySqlDbType.VarChar, obj.ACCOUNT));
                    db.Commands[0].Parameters.Add(new Parameter("@ATASNAMA", MySqlDbType.VarChar, obj.ATASNAMA));
                    db.Commands[0].Parameters.Add(new Parameter("@IS_AF", MySqlDbType.Bit, obj.IS_AF));
                    db.Commands[0].Parameters.Add(new Parameter("@IS_TRUCK", MySqlDbType.Bit, obj.IS_TRUCK));
                    db.Commands[0].Parameters.Add(new Parameter("@IS_WH", MySqlDbType.Bit, obj.IS_WH));
                    db.Commands[0].Parameters.Add(new Parameter("@IS_GRDH", MySqlDbType.Bit, obj.IS_GRDH));
                    db.Commands[0].Parameters.Add(new Parameter("@IS_SHIPPING", MySqlDbType.Bit, obj.IS_SHIPPING));
                    db.Commands[0].Parameters.Add(new Parameter("@IS_DELIVERY", MySqlDbType.Bit, obj.IS_DELIVERY));
                    db.Commands[0].Parameters.Add(new Parameter("@IS_RA", MySqlDbType.Bit, obj.IS_RA));
                    
                    dt = db.Commands[0].ExecuteDataTable();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void DELETE(RMS.COMMON.MASTER.RMS_SUPPLIER obj)
        {
            try
            {
                using (Database db = new Database())
                {
                    DataTable dt = new DataTable();
                    db.Commands.Add(db.CreateCommand(QUERY_DELETE));
                    db.Commands[0].Parameters.Add(new Parameter("@KODEAGENT", MySqlDbType.VarChar, obj.KODE));
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
        public DataTable SELECTUDARA(RMS.COMMON.MASTER.RMS_SUPPLIER obj)
        {
            DataTable dt = new DataTable();
            try
            {
                using (Database db = new Database())
                {
                    db.Commands.Add(db.CreateCommand(QUERY_SELECTUDARA));
                    db.Commands[0].Parameters.Add(new Parameter("@HANDLING", MySqlDbType.VarChar, obj.HANDLING));
                    dt = db.Commands[0].ExecuteDataTable();
                }
                return dt;
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
        public DataTable SELECTPRICELISTAGENT()
        {
            DataTable dt = new DataTable();
            try
            {
                using (Database db = new Database())
                {
                    db.Commands.Add(db.CreateCommand(QUERY_SELECTPRICELIST));
                    dt = db.Commands[0].ExecuteDataTable();
                }
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        
        public DataTable CARI_BYKODE_UPDATE(RMS.COMMON.MASTER.RMS_SUPPLIER obj)
        {
            DataTable dt = new DataTable();
            try
            {
                using (Database db = new Database())
                {
                    db.Commands.Add(db.CreateCommand(QUERY_CARI_UPDATE));
                    db.Commands[0].Parameters.Add(new Parameter("@KODEAGENT", MySqlDbType.VarChar, obj.KODE));
                    dt = db.Commands[0].ExecuteDataTable();
                }
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public DataTable CARI_BYKODE(RMS.COMMON.MASTER.RMS_SUPPLIER obj)
        {
            DataTable dt = new DataTable();
            try
            {
                using (Database db = new Database())
                {
                    db.Commands.Add(db.CreateCommand(QUERY_CARI_BYKODE));
                    db.Commands[0].Parameters.Add(new Parameter("@KODEAGENT", MySqlDbType.VarChar, obj.KODE));
                    dt = db.Commands[0].ExecuteDataTable();
                }
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public DataTable CARI_BYNAMA(RMS.COMMON.MASTER.RMS_SUPPLIER obj)
        {
            DataTable dt = new DataTable();
            try
            {
                using (Database db = new Database())
                {
                    db.Commands.Add(db.CreateCommand(QUERY_CARI_BYNAME));
                    db.Commands[0].Parameters.Add(new Parameter("@NAMAAGENT", MySqlDbType.VarChar, obj.NAMA));
                    dt = db.Commands[0].ExecuteDataTable();
                }
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public DataTable SEARCH_BYKODE(RMS.COMMON.MASTER.RMS_SUPPLIER obj)
        {
            DataTable dt = new DataTable();
            try
            {
                using (Database db = new Database())
                {
                    db.Commands.Add(db.CreateCommand(QUERY_SEARCH_BYKODE));
                    db.Commands[0].Parameters.Add(new Parameter("@KODEAGENT", MySqlDbType.VarChar, obj.KODE));
                    dt = db.Commands[0].ExecuteDataTable();
                }
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public DataTable SEARCH_BYNAMAPRICELIST(RMS.COMMON.MASTER.RMS_SUPPLIER obj)
        {
            DataTable dt = new DataTable();
            try
            {
                using (Database db = new Database())
                {
                    db.Commands.Add(db.CreateCommand(QUERY_SEARCH_BYNAMEPRICELIST));
                    db.Commands[0].Parameters.Add(new Parameter("@KODEAGENT", MySqlDbType.VarChar, obj.KODE));
                    db.Commands[0].Parameters.Add(new Parameter("@NAMAAGENT", MySqlDbType.VarChar, obj.NAMA));
                    db.Commands[0].Parameters.Add(new Parameter("@JNSCOST", MySqlDbType.VarChar, obj.JNSCOST));
                    dt = db.Commands[0].ExecuteDataTable();
                }
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public DataTable SEARCH_BYNAMA(RMS.COMMON.MASTER.RMS_SUPPLIER obj)
        {
            DataTable dt = new DataTable();
            try
            {
                using (Database db = new Database())
                {
                    db.Commands.Add(db.CreateCommand(QUERY_SEARCH_BYNAME));
                    db.Commands[0].Parameters.Add(new Parameter("@HANDLING", MySqlDbType.VarChar, obj.HANDLING));
                    db.Commands[0].Parameters.Add(new Parameter("@KODEAGENT", MySqlDbType.VarChar, obj.KODE));
                    db.Commands[0].Parameters.Add(new Parameter("@NAMAAGENT", MySqlDbType.VarChar, obj.NAMA));
                    dt = db.Commands[0].ExecuteDataTable();
                }
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
         public DataTable SELECTUDARALIKE(RMS.COMMON.MASTER.RMS_SUPPLIER obj)
        {
            DataTable dt = new DataTable();
            try
            {
                using (Database db = new Database())
                {
                    db.Commands.Add(db.CreateCommand(QUERY_SELECTUDARALIKE));
                    db.Commands[0].Parameters.Add(new Parameter("@HANDLING", MySqlDbType.VarChar, obj.HANDLING));
                    db.Commands[0].Parameters.Add(new Parameter("@KODEAGENT", MySqlDbType.VarChar, obj.KODE));
                    db.Commands[0].Parameters.Add(new Parameter("@NAMAAGENT", MySqlDbType.VarChar, obj.NAMA));
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

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
    public class RMS_PRICELISTAGENT
    {
        Database db = new Database();
        
        protected string QUERY_SELECT = "SELECT * FROM V_PRICELISTAGENT WHERE IDSERVICE=@IDSERVICE AND IDHANDLING=@IDHANDLING AND IDASAL = @IDASAL AND IDTUJUAN =@IDTUJUAN";
        protected string QUERY_DELETE = "DELETE FROM pricelistagent WHERE IDPRICELIST=@IDPRICELIST";
        protected string QUERY_CARI_BYIDPRICELIST = "SELECT * FROM V_PRICELIST WHERE IDPRICELIST=@IDPRICELIST";
        protected string QUERY_CARI_BYIDPRICELISTAGENT = "SELECT * FROM V_PRICELISTAGENT WHERE IDPRICELIST=@IDPRICELIST";
        protected string QUERY_VSELECT = "SELECT * FROM V_PRICELISTAGENT WHERE KODELAYANAN=@KODELAYANAN AND KODEKOTA=@KODEKOTA AND KODEKOTATUJUAN =@KODEKOTATUJUAN AND JNSCOST=@JNSCOST AND ISAKTIF=@ISAKTIF ";
        protected string QUERY_SELECTVALIDATE; 
        protected string QUERY_VSELECTLIKE = "SELECT * FROM V_PRICELISTAGENT WHERE KODELAYANAN=@KODELAYANAN AND KODEKOTA=@KODEKOTA AND KODEKOTATUJUAN =@KODEKOTATUJUAN AND JNSCOST=@JNSCOST AND ISAKTIF=@ISAKTIF AND NAMAAGENT LIKE CONCAT('%',@NAMAAGENT,'%')";
        //string QUERY_CARI_BYIDPRICELISTAGENT = "SELECT * FROM V_PRICELISTAGENT WHERE IDPRICELIST=@IDPRICELIST";
        
        protected string QUERY_CARI_BYKODE = "SELECT * FROM V_PRICELISTAGENT WHERE KODEAGENT=@KODEAGENT";
        protected string QUERY_CARI_UPDATE = "SELECT * FROM agent WHERE KODEAGENT=@KODEAGENT";
        protected string QUERY_CARI_BYNAME = "SELECT * FROM V_AGENT WHERE NAMAAGENT=@NAMAAGENT";
        protected string QUERY_SEARCH_BYKODE = "SELECT * FROM V_AGENT WHERE KODEAGENT LIKE CONCAT('%',@KODEAGENT,'%')";
        protected string QUERY_SEARCH_BYNAME = "SELECT * FROM V_AGENT WHERE NAMAAGENT LIKE CONCAT('%',@NAMAAGENT,'%')";
        protected string QUERY_INSERT = "INSERT INTO pricelistagent(IDLAYANAN,JNSCOST,KOTAASAL,IDKOTA,IDTERUSAN,IDHANDLING,`CHARGE/KG`,DURASIWAKTU,IDAGENT,KETERANGAN,ISAKTIF) VALUES " +
                                        "(@IDLAYANAN,@JNSCOST,@KOTAASAL,@IDKOTA,@IDTERUSAN,@IDHANDLING,@CHARGE,@DURASIWAKTU,@IDAGENT,@KETERANGAN,@ISAKTIF)";
        protected string QUERY_UPDATE = "UPDATE pricelistagent SET IDLAYANAN=@IDLAYANAN,JNSCOST=@JNSCOST, IDHANDLING =@IDHANDLING, KOTAASAL=@KOTAASAL,IDKOTA=@IDKOTA,IDTERUSAN=@IDTERUSAN,`CHARGE/KG` =@CHARGE,DURASIWAKTU=@DURASIWAKTU,ISAKTIF=@ISAKTIF WHERE IDPRICELIST = @IDPRICELIST";

        public void INSERT(RMS.COMMON.MASTER.RMS_PRICELISTAGENT obj)
        {
            try
            {
                using (Database db = new Database())
                {
                    DataTable dt = new DataTable();
                    db.Commands.Add(db.CreateCommand(QUERY_INSERT));
                    
                    db.Commands[0].Parameters.Add(new Parameter("@IDLAYANAN", MySqlDbType.Int32, obj.IDSERVICE));
                    db.Commands[0].Parameters.Add(new Parameter("@KOTAASAL", MySqlDbType.Int32, obj.IDASAL));
                    db.Commands[0].Parameters.Add(new Parameter("@IDKOTA", MySqlDbType.Int32, obj.IDTUJUAN));
                    if (obj.IDTERUSAN != 0)
                    {
                        db.Commands[0].Parameters.Add(new Parameter("@IDTERUSAN", MySqlDbType.Int32, obj.IDTERUSAN));
                    }
                    else
                    {
                        db.Commands[0].Parameters.Add(new Parameter("@IDTERUSAN", MySqlDbType.Int32, null));
                    }
                    db.Commands[0].Parameters.Add(new Parameter("@IDHANDLING", MySqlDbType.Int32, obj.IDHANDLING));
                    db.Commands[0].Parameters.Add(new Parameter("@JNSCOST", MySqlDbType.VarChar, obj.JNSCOST));
                    db.Commands[0].Parameters.Add(new Parameter("@CHARGE", MySqlDbType.Float, obj.CHARGE));
                    db.Commands[0].Parameters.Add(new Parameter("@DURASIWAKTU", MySqlDbType.VarChar, obj.DURASIWAKTU));
                    db.Commands[0].Parameters.Add(new Parameter("@IDAGENT", MySqlDbType.Int32, obj.IDAGENT));
                    db.Commands[0].Parameters.Add(new Parameter("@KETERANGAN", MySqlDbType.VarChar, obj.KETERANGAN));
                    db.Commands[0].Parameters.Add(new Parameter("@ISAKTIF", MySqlDbType.Int32, obj.ISAKTIF));                
                    dt = db.Commands[0].ExecuteDataTable();
                     
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void UPDATE(RMS.COMMON.MASTER.RMS_PRICELISTAGENT obj)
        {
            try
            {
                using (Database db = new Database())
                {
                    DataTable dt = new DataTable();
                    db.Commands.Add(db.CreateCommand(QUERY_UPDATE));
                    db.Commands[0].Parameters.Add(new Parameter("@IDPRICELIST", MySqlDbType.Int32, obj.IDPRICELIST));
                    db.Commands[0].Parameters.Add(new Parameter("@IDLAYANAN", MySqlDbType.Int32, obj.IDSERVICE));
                    db.Commands[0].Parameters.Add(new Parameter("@KOTAASAL", MySqlDbType.Int32, obj.IDASAL));
                    db.Commands[0].Parameters.Add(new Parameter("@IDKOTA", MySqlDbType.Int32, obj.IDTUJUAN));
                    if (obj.IDTERUSAN != 0)
                    {
                        db.Commands[0].Parameters.Add(new Parameter("@IDTERUSAN", MySqlDbType.Int32, obj.IDTERUSAN));
                    }
                    else
                    {
                        db.Commands[0].Parameters.Add(new Parameter("@IDTERUSAN", MySqlDbType.Int32, null));
                    }
                    db.Commands[0].Parameters.Add(new Parameter("@IDHANDLING", MySqlDbType.Int32, obj.IDHANDLING));
                    db.Commands[0].Parameters.Add(new Parameter("@JNSCOST", MySqlDbType.VarChar, obj.JNSCOST));
                    db.Commands[0].Parameters.Add(new Parameter("@CHARGE", MySqlDbType.Float, obj.CHARGE));
                    db.Commands[0].Parameters.Add(new Parameter("@DURASIWAKTU", MySqlDbType.VarChar, obj.DURASIWAKTU));
                    db.Commands[0].Parameters.Add(new Parameter("@ISAKTIF", MySqlDbType.Int32, obj.ISAKTIF));
                    dt = db.Commands[0].ExecuteDataTable();
                    
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void DELETE(RMS.COMMON.MASTER.RMS_PRICELISTAGENT obj)
        {
            try
            {
                using (Database db = new Database())
                {
                    DataTable dt = new DataTable();
                    db.Commands.Add(db.CreateCommand(QUERY_DELETE));
                    db.Commands[0].Parameters.Add(new Parameter("@IDPRICELIST", MySqlDbType.VarChar, obj.IDPRICELIST));
                    dt = db.Commands[0].ExecuteDataTable();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public DataTable SELECT(RMS.COMMON.MASTER.RMS_PRICELISTAGENT obj)
        {
            DataTable dt = new DataTable();
            try
            {
                using (Database db = new Database())
                {
                    db.Commands.Add(db.CreateCommand(QUERY_SELECT));
                    db.Commands[0].Parameters.Add(new Parameter("@IDSERVICE", MySqlDbType.VarChar, obj.IDSERVICE));
                    db.Commands[0].Parameters.Add(new Parameter("@IDHANDLING", MySqlDbType.VarChar, obj.IDHANDLING));
                    db.Commands[0].Parameters.Add(new Parameter("@IDASAL", MySqlDbType.VarChar, obj.IDASAL));
                    db.Commands[0].Parameters.Add(new Parameter("@IDTUJUAN", MySqlDbType.VarChar, obj.IDTUJUAN));
                   
                    dt = db.Commands[0].ExecuteDataTable();
                }
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        
        public DataTable SELECTVALIDATE(RMS.COMMON.MASTER.RMS_PRICELISTAGENT obj)
        {
            DataTable dt = new DataTable();
            try
            {
                using (Database db = new Database())
                {
                    if (string.IsNullOrEmpty(obj.NAMATERUSAN))
                    {
                        QUERY_SELECTVALIDATE = "SELECT * FROM V_PRICELISTAGENT WHERE ISNULL(NAMATERUSAN) AND IDLAYANAN=@IDLAYANAN AND IDHANDLING=@IDHANDLING AND IDKOTA=@KOTAASAL AND IDKOTATUJUAN=@IDKOTA AND JNSCOST=@JNSCOST AND ISAKTIF=@ISAKTIF ";
                    }
                    else
                    {
                        QUERY_SELECTVALIDATE = "SELECT * FROM V_PRICELISTAGENT WHERE IDLAYANAN=@IDLAYANAN AND IDHANDLING=@IDHANDLING AND IDKOTA=@KOTAASAL AND IDKOTATUJUAN=@IDKOTA AND NAMATERUSAN=@NAMATERUSAN AND JNSCOST=@JNSCOST AND ISAKTIF=@ISAKTIF ";
                    }
                    db.Commands.Add(db.CreateCommand(QUERY_SELECTVALIDATE));
                    db.Commands[0].Parameters.Add(new Parameter("@IDAGENT", MySqlDbType.VarChar, obj.IDAGENT));
                    db.Commands[0].Parameters.Add(new Parameter("@IDLAYANAN", MySqlDbType.VarChar, obj.IDSERVICE));
                    db.Commands[0].Parameters.Add(new Parameter("@IDHANDLING", MySqlDbType.VarChar, obj.IDHANDLING));
                    db.Commands[0].Parameters.Add(new Parameter("@KOTAASAL", MySqlDbType.VarChar, obj.IDASAL));
                    db.Commands[0].Parameters.Add(new Parameter("@IDKOTA", MySqlDbType.VarChar, obj.IDTUJUAN));
                    db.Commands[0].Parameters.Add(new Parameter("@JNSCOST", MySqlDbType.VarChar, obj.JNSCOST));
                    db.Commands[0].Parameters.Add(new Parameter("@NAMATERUSAN", MySqlDbType.VarChar, obj.NAMATERUSAN));
                    db.Commands[0].Parameters.Add(new Parameter("@ISAKTIF", MySqlDbType.Int32, obj.ISAKTIF));
                    dt = db.Commands[0].ExecuteDataTable();
                }
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public DataTable V_SELECT(RMS.COMMON.MASTER.RMS_PRICELISTAGENT obj)
        {
            DataTable dt = new DataTable();
            try
            {
                using (Database db = new Database())
                {

                    db.Commands.Add(db.CreateCommand(QUERY_VSELECT));
                    db.Commands[0].Parameters.Add(new Parameter("@KODELAYANAN", MySqlDbType.VarChar, obj.KODELAYANAN));
                    db.Commands[0].Parameters.Add(new Parameter("@KODEKOTA", MySqlDbType.VarChar, obj.KODEAREAASAL));
                    db.Commands[0].Parameters.Add(new Parameter("@KODEKOTATUJUAN", MySqlDbType.VarChar, obj.KODEAREATUJUAN));
                    db.Commands[0].Parameters.Add(new Parameter("@JNSCOST", MySqlDbType.VarChar, obj.JNSCOST));
                    db.Commands[0].Parameters.Add(new Parameter("@ISAKTIF", MySqlDbType.Int32, obj.ISAKTIF));
                    dt = db.Commands[0].ExecuteDataTable();
                }
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public DataTable V_SELECTLIKE(RMS.COMMON.MASTER.RMS_PRICELISTAGENT obj)
        {
            DataTable dt = new DataTable();
            try
            {
                using (Database db = new Database())
                {

                    db.Commands.Add(db.CreateCommand(QUERY_VSELECTLIKE));
                    db.Commands[0].Parameters.Add(new Parameter("@KODELAYANAN", MySqlDbType.VarChar, obj.KODELAYANAN));
                    db.Commands[0].Parameters.Add(new Parameter("@KODEKOTA", MySqlDbType.VarChar, obj.KODEAREAASAL));
                    db.Commands[0].Parameters.Add(new Parameter("@KODEKOTATUJUAN", MySqlDbType.VarChar, obj.KODEAREATUJUAN));
                    db.Commands[0].Parameters.Add(new Parameter("@JNSCOST", MySqlDbType.VarChar, obj.JNSCOST));
                    db.Commands[0].Parameters.Add(new Parameter("@ISAKTIF", MySqlDbType.Int32, obj.ISAKTIF));
                    db.Commands[0].Parameters.Add(new Parameter("@NAMAAGENT", MySqlDbType.VarChar, obj.NAMAAGENT));
                    dt = db.Commands[0].ExecuteDataTable();
                }
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public DataTable CARI_BYIDPRICELIST(RMS.COMMON.MASTER.RMS_PRICELISTAGENT obj)
        {
            DataTable dt = new DataTable();
            try
            {
                using (Database db = new Database())
                {

                    db.Commands.Add(db.CreateCommand(QUERY_CARI_BYIDPRICELISTAGENT));
                    db.Commands[0].Parameters.Add(new Parameter("@IDPRICELIST", MySqlDbType.VarChar, obj.IDPRICELIST));
                    dt = db.Commands[0].ExecuteDataTable();
                }
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public DataTable CARI_BYKODE_UPDATE(RMS.COMMON.MASTER.RMS_PRICELISTAGENT obj)
        {
            DataTable dt = new DataTable();
            try
            {
                using (Database db = new Database())
                {
                    db.Commands.Add(db.CreateCommand(QUERY_CARI_UPDATE));
                   // db.Commands[0].Parameters.Add(new Parameter("@KODEAGENT", MySqlDbType.VarChar, obj.KODE));
                    dt = db.Commands[0].ExecuteDataTable();
                }
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public DataTable CARI_BYKODE(RMS.COMMON.MASTER.RMS_PRICELISTAGENT obj)
        {
            DataTable dt = new DataTable();
            try
            {
                using (Database db = new Database())
                {
                    db.Commands.Add(db.CreateCommand(QUERY_CARI_BYKODE));
                    db.Commands[0].Parameters.Add(new Parameter("@KODEAGENT", MySqlDbType.VarChar, obj.KODEAGENT));
                    dt = db.Commands[0].ExecuteDataTable();
                }
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public DataTable CARI_BYNAMA(RMS.COMMON.MASTER.RMS_PRICELISTAGENT obj)
        {
            DataTable dt = new DataTable();
            try
            {
                using (Database db = new Database())
                {
                    db.Commands.Add(db.CreateCommand(QUERY_CARI_BYNAME));
                   // db.Commands[0].Parameters.Add(new Parameter("@NAMAAGENT", MySqlDbType.VarChar, obj.NAMA));
                    dt = db.Commands[0].ExecuteDataTable();
                }
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public DataTable SEARCH_BYKODE(RMS.COMMON.MASTER.RMS_PRICELISTAGENT obj)
        {
            DataTable dt = new DataTable();
            try
            {
                using (Database db = new Database())
                {
                    db.Commands.Add(db.CreateCommand(QUERY_SEARCH_BYKODE));
                   // db.Commands[0].Parameters.Add(new Parameter("@KODEAGENT", MySqlDbType.VarChar, obj.KODE));
                    dt = db.Commands[0].ExecuteDataTable();
                }
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public DataTable SEARCH_BYNAMA(RMS.COMMON.MASTER.RMS_PRICELISTAGENT obj)
        {
            DataTable dt = new DataTable();
            try
            {
                using (Database db = new Database())
                {
                    db.Commands.Add(db.CreateCommand(QUERY_SEARCH_BYNAME));
                   // db.Commands[0].Parameters.Add(new Parameter("@NAMAAGENT", MySqlDbType.VarChar, obj.NAMA));
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

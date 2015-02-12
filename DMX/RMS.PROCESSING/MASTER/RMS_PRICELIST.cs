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
    public class RMS_PRICELIST
    {
        Database db = new Database();

        protected string QUERY_SELECT = "SELECT * FROM V_PRICELIST WHERE IDSERVICE=@IDSERVICE AND IDHANDLING=@IDHANDLING AND IDASAL = @IDASAL AND IDTUJUAN =@IDTUJUAN";
        protected string QUERY_SELECTSCANRATE = "SELECT * FROM V_PRICELIST WHERE CUSTOMER=@NAMACUSTOMER AND IDSERVICE=@IDSERVICE AND IDHANDLING=@IDHANDLING AND IDASAL = @IDASAL AND IDTUJUAN =@IDTUJUAN AND ISAKTIF = @ISAKTIF";
        protected string QUERY_SELECTSCANRATETERUSAN = "SELECT * FROM V_PRICELIST WHERE CUSTOMER=@NAMACUSTOMER AND IDSERVICE=@IDSERVICE AND IDHANDLING=@IDHANDLING AND IDASAL = @IDASAL AND IDTUJUAN =@IDTUJUAN AND NAMATERUSAN =@NAMATERUSAN AND ISAKTIF=@ISAKTIF";
        protected string QUERY_SELECTVALIDATE = "SELECT * FROM V_PRICELIST WHERE IDCUSTOMER=@IDCUSTOMER AND IDSERVICE=@IDSERVICE AND IDHANDLING=@IDHANDLING AND IDASAL=@IDASAL AND IDTUJUAN =@IDTUJUAN AND IDTERUSAN=@IDTERUSAN AND ISAKTIF=@ISAKTIF";
        protected string QUERY_DELETE = "DELETE FROM pricelist WHERE IDPRICELIST=@IDPRICELIST";
        protected string QUERY_CARI_BYIDPRICELIST = "SELECT * FROM V_PRICELIST WHERE IDPRICELIST=@IDPRICELIST";
        protected string QUERY_CARI_BYKODE = "SELECT * FROM V_PRICELIST WHERE KODECUSTOMER=@KODECUSTOMER";
        protected string QUERY_CARI_UPDATE = "SELECT * FROM agent WHERE KODEAGENT=@KODEAGENT";
        protected string QUERY_CARI_BYNAME = "SELECT * FROM V_PRICELIST WHERE CUSTOMER=@CUSTOMER AND ISAKTIF=1";
        protected string QUERY_SEARCH_BYKODE = "SELECT * FROM V_AGENT WHERE KODEAGENT LIKE CONCAT('%',@KODEAGENT,'%')";
        protected string QUERY_SEARCH_BYNAME = "SELECT * FROM V_AGENT WHERE NAMAAGENT LIKE CONCAT('%',@NAMAAGENT,'%')";
        protected string QUERY_INSERT = "INSERT INTO pricelist(IDCUSTOMER,IDLAYANAN,KOTAASAL,IDKOTA,IDTERUSAN,IDHANDLING,`CHARGE/KG`,`RC/KG`,DURASIWAKTU,KETERANGAN,ISAKTIF) VALUES " +
                                        "(@IDCUSTOMER,@IDLAYANAN,@KOTAASAL,@IDKOTA,@IDTERUSAN,@IDHANDLING,@CHARGE,@RC,@DURASIWAKTU,@KETERANGAN,@ISAKTIF)";
        protected string QUERY_UPDATE = "UPDATE pricelist SET IDLAYANAN=@IDLAYANAN, IDHANDLING =@IDHANDLING, KOTAASAL=@KOTAASAL,IDKOTA=@IDKOTA,IDTERUSAN=@IDTERUSAN,`CHARGE/KG` =@CHARGE, `RC/KG`=@RC,DURASIWAKTU=@DURASIWAKTU,ISAKTIF=@ISAKTIF WHERE IDPRICELIST = @IDPRICELIST";

        public void INSERT(RMS.COMMON.MASTER.RMS_PRICELIST obj)
        {
            try
            {
                using (Database db = new Database())
                {
                    DataTable dt = new DataTable();
                    db.Commands.Add(db.CreateCommand(QUERY_INSERT));
                    db.Commands[0].Parameters.Add(new Parameter("@IDCUSTOMER", MySqlDbType.Int32, obj.IDCUSTOMER));
                    db.Commands[0].Parameters.Add(new Parameter("@IDLAYANAN", MySqlDbType.Int32, obj.IDSERVICE));
                    db.Commands[0].Parameters.Add(new Parameter("@KOTAASAL", MySqlDbType.Int32, obj.IDASAL));
                    db.Commands[0].Parameters.Add(new Parameter("@IDKOTA", MySqlDbType.Int32, obj.IDTUJUAN));
                    if (obj.IDTERUSAN == 0)
                    {
                        db.Commands[0].Parameters.Add(new Parameter("@IDTERUSAN", MySqlDbType.Int32, null));
                    }
                    else
                    {
                        db.Commands[0].Parameters.Add(new Parameter("@IDTERUSAN", MySqlDbType.Int32, obj.IDTERUSAN));                
                    }
                    db.Commands[0].Parameters.Add(new Parameter("@IDHANDLING", MySqlDbType.Int32, obj.IDHANDLING));
                    db.Commands[0].Parameters.Add(new Parameter("@CHARGE", MySqlDbType.Float, obj.CHARGE));
                    db.Commands[0].Parameters.Add(new Parameter("@RC", MySqlDbType.Float, obj.RC));
                    db.Commands[0].Parameters.Add(new Parameter("@DURASIWAKTU", MySqlDbType.VarChar, obj.DURASIWAKTU));
                    //db.Commands[0].Parameters.Add(new Parameter("@IDAGENT", MySqlDbType.Int32, obj.IDAGENT));
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
        public void UPDATE(RMS.COMMON.MASTER.RMS_PRICELIST obj)
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
                    if (obj.IDTERUSAN == 0)
                    {
                        db.Commands[0].Parameters.Add(new Parameter("@IDTERUSAN", MySqlDbType.Int32, null));
                    }
                    else
                    {
                        db.Commands[0].Parameters.Add(new Parameter("@IDTERUSAN", MySqlDbType.Int32, obj.IDTERUSAN));
                    }
                    db.Commands[0].Parameters.Add(new Parameter("@IDHANDLING", MySqlDbType.Int32, obj.IDHANDLING));
                    db.Commands[0].Parameters.Add(new Parameter("@CHARGE", MySqlDbType.Float, obj.CHARGE));
                    db.Commands[0].Parameters.Add(new Parameter("@RC", MySqlDbType.Float, obj.RC));
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
        public void DELETE(RMS.COMMON.MASTER.RMS_PRICELIST obj)
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
        public DataTable SELECTVALIDATE(RMS.COMMON.MASTER.RMS_PRICELIST obj)
        {
            DataTable dt = new DataTable();
            try
            {
                using (Database db = new Database())
                {
                    db.Commands.Add(db.CreateCommand(QUERY_SELECTVALIDATE));
                    db.Commands[0].Parameters.Add(new Parameter("@IDSERVICE", MySqlDbType.VarChar, obj.IDSERVICE));
                    db.Commands[0].Parameters.Add(new Parameter("@IDHANDLING", MySqlDbType.VarChar, obj.IDHANDLING));
                    db.Commands[0].Parameters.Add(new Parameter("@IDASAL", MySqlDbType.VarChar, obj.IDASAL));
                    db.Commands[0].Parameters.Add(new Parameter("@IDTUJUAN", MySqlDbType.VarChar, obj.IDTUJUAN));
                    db.Commands[0].Parameters.Add(new Parameter("@IDCUSTOMER", MySqlDbType.VarChar, obj.IDCUSTOMER));
                    db.Commands[0].Parameters.Add(new Parameter("@IDTERUSAN", MySqlDbType.VarChar, obj.IDTERUSAN));
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
        public DataTable SELECTSCANRATE(RMS.COMMON.MASTER.RMS_PRICELIST obj)
        {
            DataTable dt = new DataTable();
            try
            {
                using (Database db = new Database())
                {
                    if (!string.IsNullOrEmpty(obj.NAMATERUSAN.ToString()))
                    {
                        db.Commands.Add(db.CreateCommand(QUERY_SELECTSCANRATETERUSAN));
                        db.Commands[0].Parameters.Add(new Parameter("@NAMATERUSAN", MySqlDbType.VarChar, obj.NAMATERUSAN));
                    }
                    else
                    {
                        db.Commands.Add(db.CreateCommand(QUERY_SELECTSCANRATE));
                    }
                    db.Commands[0].Parameters.Add(new Parameter("@IDSERVICE", MySqlDbType.VarChar, obj.IDSERVICE));
                    db.Commands[0].Parameters.Add(new Parameter("@IDHANDLING", MySqlDbType.VarChar, obj.IDHANDLING));
                    db.Commands[0].Parameters.Add(new Parameter("@IDASAL", MySqlDbType.VarChar, obj.IDASAL));
                    db.Commands[0].Parameters.Add(new Parameter("@IDTUJUAN", MySqlDbType.VarChar, obj.IDTUJUAN));
                    db.Commands[0].Parameters.Add(new Parameter("@NAMACUSTOMER", MySqlDbType.VarChar, obj.NAMACUSTOMER));
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
        public DataTable SELECT(RMS.COMMON.MASTER.RMS_PRICELIST obj)
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

        public DataTable CARI_BYIDPRICELIST(RMS.COMMON.MASTER.RMS_PRICELIST obj)
        {
            DataTable dt = new DataTable();
            try
            {
                using (Database db = new Database())
                {

                    db.Commands.Add(db.CreateCommand(QUERY_CARI_BYIDPRICELIST));
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
        public DataTable CARI_BYKODE_UPDATE(RMS.COMMON.MASTER.RMS_PRICELIST obj)
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
        public DataTable CARI_BYKODE(RMS.COMMON.MASTER.RMS_PRICELIST obj)
        {
            DataTable dt = new DataTable();
            try
            {
                using (Database db = new Database())
                {
                    db.Commands.Add(db.CreateCommand(QUERY_CARI_BYKODE));
                    db.Commands[0].Parameters.Add(new Parameter("@KODECUSTOMER", MySqlDbType.VarChar, obj.KODECUSTOMER));
                    dt = db.Commands[0].ExecuteDataTable();
                }
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public DataTable CARI_BYNAME(RMS.COMMON.MASTER.RMS_PRICELIST obj)
        {
            DataTable dt = new DataTable();
            try
            {
                using (Database db = new Database())
                {
                    db.Commands.Add(db.CreateCommand(QUERY_CARI_BYNAME));
                    db.Commands[0].Parameters.Add(new Parameter("@CUSTOMER", MySqlDbType.VarChar, obj.NAMACUSTOMER));
                    dt = db.Commands[0].ExecuteDataTable();
                }
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public DataTable SEARCH_BYKODE(RMS.COMMON.MASTER.RMS_PRICELIST obj)
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
        public DataTable SEARCH_BYNAMA(RMS.COMMON.MASTER.RMS_PRICELIST obj)
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

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
    public class RMS_TARIF
    {
        Database db = new Database();
        protected string QUERY_GETKODE = "SELECT ID as LAST_ID FROM tarif_express ORDER BY ID DESC LIMIT 1";
        protected string QUERY_SELECT = "SELECT * FROM v_tariff WHERE ISACTIVE =1";
        protected string QUERY_DELETE = "UPDATE tarif_express SET ISACTIVE = 0 WHERE ID=@ID";
        protected string QUERY_CARI_BYKODE = "SELECT * FROM v_customer WHERE KODECUSTOMER=@KODECUSTOMER";
        protected string QUERY_CARI_BYID = "SELECT * FROM v_tariff WHERE IDTARIF=@ID";
        protected string QUERY_CARI_BYNAME = "SELECT * FROM v_customer WHERE NAMACUSTOMER=@NAMACUSTOMER";
        protected string QUERY_SEARCHLIKE = "SELECT * FROM v_tariff WHERE ISACTIVE =1 AND (KOTATUJUAN LIKE CONCAT('%',@KOTATUJUAN,'%') OR PRODUK LIKE CONCAT('%',@PRODUK,'%') OR JENISKIRIMAN LIKE CONCAT('%',@JENISKIRIMAN,'%'))";
        protected string QUERY_SEARCH_BYKODE = "SELECT * FROM v_customer WHERE KODECUSTOMER LIKE CONCAT('%',@KODECUSTOMER,'%')";
        protected string QUERY_SEARCH_BYNAME = "SELECT * FROM v_tariff WHERE KOTAASAL LIKE CONCAT('%',@KOTAASAL,'%') AND KOTATUJUAN LIKE CONCAT('%',@KOTATUJUAN,'%') AND ISACTIVE =1";
        protected string QUERY_INSERT = "INSERT INTO tarif_express(KODE,IDKOTAASAL,IDKOTATUJUAN,TARIF,TARIFBERIKUT,ETD,IDJENISKIRIMAN,IDPRODUK,KETERANGAN) VALUES "
                                        + "(@KODE,@IDKOTAASAL,@IDKOTATUJUAN,@TARIF,@TARIFBERIKUT,@ETD,@IDJENISKIRIMAN,@IDPRODUK,@KETERANGAN)";
        protected string QUERY_UPDATE = "UPDATE tarif_express SET IDKOTAASAL=@IDKOTAASAL,IDKOTATUJUAN=@IDKOTATUJUAN,TARIF=@TARIF," +
                                        "TARIFBERIKUT=@TARIFBERIKUT,ETD=@ETD,IDJENISKIRIMAN=@IDJENISKIRIMAN,IDPRODUK=@IDPRODUK,KETERANGAN=@KETERANGAN WHERE ID=@ID";


        public void INSERT(RMS.COMMON.MASTER.RMS_TARIF obj)
        {
            try
            {
                using (Database db = new Database())
                {
                    DataTable dt = new DataTable();
                    db.Commands.Add(db.CreateCommand(QUERY_INSERT));                    
                    db.Commands[0].Parameters.Add(new Parameter("@KODE", MySqlDbType.VarChar, obj.KODE));
                    db.Commands[0].Parameters.Add(new Parameter("@IDKOTAASAL", MySqlDbType.Int32, obj.IDKOTAASAL));
                    db.Commands[0].Parameters.Add(new Parameter("@IDKOTATUJUAN", MySqlDbType.Int32, obj.IDKOTATUJUAN));
                    db.Commands[0].Parameters.Add(new Parameter("@TARIF", MySqlDbType.Float, obj.TARIF));
                    db.Commands[0].Parameters.Add(new Parameter("@TARIFBERIKUT", MySqlDbType.Float, obj.TARIFBERIKUT));
                    db.Commands[0].Parameters.Add(new Parameter("@ETD", MySqlDbType.VarChar, obj.ETD));
                    db.Commands[0].Parameters.Add(new Parameter("@IDJENISKIRIMAN", MySqlDbType.Int32, obj.IDJENISKIRIMAN));
                    db.Commands[0].Parameters.Add(new Parameter("@IDPRODUK", MySqlDbType.Int32, obj.IDPRODUK));
                    db.Commands[0].Parameters.Add(new Parameter("@KETERANGAN", MySqlDbType.VarChar, obj.KETERANGAN));
                                      

                    dt = db.Commands[0].ExecuteDataTable();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void UPDATE(RMS.COMMON.MASTER.RMS_TARIF obj)
        {
            try
            {
                using (Database db = new Database())
                {
                    DataTable dt = new DataTable();
                    db.Commands.Add(db.CreateCommand(QUERY_UPDATE));
                    db.Commands[0].Parameters.Add(new Parameter("@ID", MySqlDbType.VarChar, obj.ID));
                    db.Commands[0].Parameters.Add(new Parameter("@IDKOTAASAL", MySqlDbType.Int32, obj.IDKOTAASAL));
                    db.Commands[0].Parameters.Add(new Parameter("@IDKOTATUJUAN", MySqlDbType.Int32, obj.IDKOTATUJUAN));
                    db.Commands[0].Parameters.Add(new Parameter("@TARIF", MySqlDbType.Float, obj.TARIF));
                    db.Commands[0].Parameters.Add(new Parameter("@TARIFBERIKUT", MySqlDbType.Float, obj.TARIFBERIKUT));
                    db.Commands[0].Parameters.Add(new Parameter("@ETD", MySqlDbType.VarChar, obj.ETD));
                    db.Commands[0].Parameters.Add(new Parameter("@IDJENISKIRIMAN", MySqlDbType.Int32, obj.IDJENISKIRIMAN));
                    db.Commands[0].Parameters.Add(new Parameter("@IDPRODUK", MySqlDbType.Int32, obj.IDPRODUK));
                    db.Commands[0].Parameters.Add(new Parameter("@KETERANGAN", MySqlDbType.VarChar, obj.KETERANGAN));
                    dt = db.Commands[0].ExecuteDataTable();
                     
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void DELETE(RMS.COMMON.MASTER.RMS_TARIF obj)
        {
            try
            {
                using (Database db = new Database())
                {
                    DataTable dt = new DataTable();

                    db.Commands.Add(db.CreateCommand(QUERY_DELETE));
                    db.Commands[0].Parameters.Add(new Parameter("@ID", MySqlDbType.Int32, obj.ID));
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
        public DataTable CARI_BYKODE(RMS.COMMON.MASTER.RMS_TARIF obj)
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
        public DataTable CARI_BYID(RMS.COMMON.MASTER.RMS_TARIF obj)
        {
            DataTable dt = new DataTable();
            try
            {
                using (Database db = new Database())
                {
                    db.Commands.Add(db.CreateCommand(QUERY_CARI_BYID));
                    db.Commands[0].Parameters.Add(new Parameter("@ID", MySqlDbType.VarChar, obj.ID));
                    dt = db.Commands[0].ExecuteDataTable();
                    
                }
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public DataTable CARI_BYNAMA(RMS.COMMON.MASTER.RMS_TARIF obj)
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

        public DataTable SEARCHLIKE(RMS.COMMON.MASTER.RMS_TARIF obj)
        {
            DataTable dt = new DataTable();
            try
            {
                using (Database db = new Database())
                {
                    db.Commands.Add(db.CreateCommand(QUERY_SEARCHLIKE));
                    
                    db.Commands[0].Parameters.Add(new Parameter("@KOTATUJUAN", MySqlDbType.VarChar, obj.KOTATUJUAN));
                    db.Commands[0].Parameters.Add(new Parameter("@PRODUK", MySqlDbType.VarChar, obj.PRODUK));
                    db.Commands[0].Parameters.Add(new Parameter("@JENISKIRIMAN", MySqlDbType.VarChar, obj.JENISKIRIMAN));
                    dt = db.Commands[0].ExecuteDataTable();
                     
                }
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public DataTable SEARCH_BYKODE(RMS.COMMON.MASTER.RMS_TARIF obj)
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
        public DataTable SEARCH_BYNAMA(RMS.COMMON.MASTER.RMS_TARIF obj)
        {
            DataTable dt = new DataTable();
            try
            {
                using (Database db = new Database())
                {
                    db.Commands.Add(db.CreateCommand(QUERY_SEARCH_BYNAME));

                    db.Commands[0].Parameters.Add(new Parameter("@KOTAASAL", MySqlDbType.VarChar, obj.KOTAASAL));
                    db.Commands[0].Parameters.Add(new Parameter("@KOTATUJUAN", MySqlDbType.VarChar, obj.KOTATUJUAN));
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

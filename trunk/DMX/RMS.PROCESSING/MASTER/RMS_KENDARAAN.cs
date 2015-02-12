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
    public class RMS_KENDARAAN
    {
        Database db = new Database();
        protected string QUERY_GETKODE = "SELECT ID as LAST_ID FROM kendaraan_express ORDER BY ID DESC LIMIT 1";
        protected string QUERY_SELECT = "SELECT * FROM v_kendaraan where ISACTIVE = 1";
        protected string QUERY_DELETE = "UPDATE kendaraan_express SET ISACTIVE = 0 WHERE NOPOL=@KODE";
        protected string QUERY_CARI_BYKODE = "SELECT * FROM v_kendaraan WHERE NOPOL=@NOPOL";
        protected string QUERY_CARI_BYNAME = "SELECT * FROM v_customer WHERE NAMACUSTOMER=@NAMACUSTOMER";
        protected string QUERY_SEARCHLIKE = "SELECT * FROM v_kendaraan WHERE ISACTIVE = 1 and (NOPOL LIKE CONCAT('%',@NOPOL,'%') OR NAMADRIVER LIKE CONCAT('%',@NAMADRIVER,'%') OR NAMAHELPER LIKE CONCAT('%',@NAMAHELPER,'%'))";
        protected string QUERY_SEARCH_BYKODE = "SELECT * FROM v_kendaraan WHERE ID =@ID";
        protected string QUERY_SEARCH_BYNAME = "SELECT * FROM v_customer WHERE KODECUSTOMER LIKE CONCAT('%',@KODECUSTOMER,'%') OR NAMACUSTOMER LIKE CONCAT('%',@NAMACUSTOMER,'%')";
        protected string QUERY_INSERT = "INSERT INTO kendaraan_express(NOPOL,IDJENISKENDARAAN,MAXMUATAN,MAXVOLUME,STATUS,IDDRIVER,IDHELPER) VALUES "
                                        + "(@NOPOL,@IDJENISKENDARAAN,@MAXMUATAN,@MAXVOLUME,@STATUS,@IDDRIVER,@IDHELPER)";
        protected string QUERY_UPDATE = "UPDATE kendaraan_express SET NOPOL=@NOPOL,IDJENISKENDARAAN=@IDJENISKENDARAAN,MAXMUATAN=@MAXMUATAN," +
                                        "MAXVOLUME=@MAXVOLUME,STATUS=@STATUS,IDDRIVER=@IDDRIVER,IDHELPER=@IDHELPER  WHERE ID=@ID";


        public void INSERT(RMS.COMMON.MASTER.RMS_KENDARAAN obj)
       {
            try
            {
                using (Database db = new Database())
                {
                    DataTable dt = new DataTable();
                    db.Commands.Add(db.CreateCommand(QUERY_INSERT));

                    db.Commands[0].Parameters.Add(new Parameter("@NOPOL", MySqlDbType.VarChar, obj.NOPOL));
                    db.Commands[0].Parameters.Add(new Parameter("@IDJENISKENDARAAN", MySqlDbType.VarChar, obj.IDJENISKENDARAAN));
                    db.Commands[0].Parameters.Add(new Parameter("@MAXMUATAN", MySqlDbType.VarChar, obj.MAXMUATAN));
                    db.Commands[0].Parameters.Add(new Parameter("@MAXVOLUME", MySqlDbType.VarChar, obj.MAXVOLUME));
                    db.Commands[0].Parameters.Add(new Parameter("@STATUS", MySqlDbType.Int32, obj.STATUS));
                    // mungkin ini bisi jadi exception
                    if (obj.IDDRIVER == 0)
                    {
                        db.Commands[0].Parameters.Add(new Parameter("@IDDRIVER", MySqlDbType.VarChar, null));
                    }
                    else
                    {
                        db.Commands[0].Parameters.Add(new Parameter("@IDDRIVER", MySqlDbType.Int32, obj.IDDRIVER));
                    }
                    if (obj.IDHELPER == 0)
                    {
                        db.Commands[0].Parameters.Add(new Parameter("@IDHELPER", MySqlDbType.VarChar, null));
                    }
                    else
                    {
                        db.Commands[0].Parameters.Add(new Parameter("@IDHELPER", MySqlDbType.Int32, obj.IDHELPER));
                    }
                                      
                    

                    dt = db.Commands[0].ExecuteDataTable();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void UPDATE(RMS.COMMON.MASTER.RMS_KENDARAAN obj)
        {
            try
            {
                using (Database db = new Database())
                {
                    DataTable dt = new DataTable();
                    db.Commands.Add(db.CreateCommand(QUERY_UPDATE));
                    db.Commands[0].Parameters.Add(new Parameter("@ID", MySqlDbType.Int32, obj.ID));
                    db.Commands[0].Parameters.Add(new Parameter("@NOPOL", MySqlDbType.VarChar, obj.NOPOL));
                    db.Commands[0].Parameters.Add(new Parameter("@IDJENISKENDARAAN", MySqlDbType.VarChar, obj.IDJENISKENDARAAN));
                    db.Commands[0].Parameters.Add(new Parameter("@MAXMUATAN", MySqlDbType.VarChar, obj.MAXMUATAN));
                    db.Commands[0].Parameters.Add(new Parameter("@MAXVOLUME", MySqlDbType.VarChar, obj.MAXVOLUME));
                    db.Commands[0].Parameters.Add(new Parameter("@STATUS", MySqlDbType.Int32, obj.STATUS));
                    // mungkin ini bisi jadi exception
                    if (obj.IDDRIVER == 0)
                    {
                        db.Commands[0].Parameters.Add(new Parameter("@IDDRIVER", MySqlDbType.VarChar, null));
                    }
                    else
                    {
                        db.Commands[0].Parameters.Add(new Parameter("@IDDRIVER", MySqlDbType.Int32, obj.IDDRIVER));
                    }
                    if (obj.IDHELPER == 0)
                    {
                        db.Commands[0].Parameters.Add(new Parameter("@IDHELPER", MySqlDbType.VarChar, null));
                    }
                    else
                    {
                        db.Commands[0].Parameters.Add(new Parameter("@IDHELPER", MySqlDbType.Int32, obj.IDHELPER));
                    }
                                      
                    dt = db.Commands[0].ExecuteDataTable();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void DELETE(RMS.COMMON.MASTER.RMS_KENDARAAN obj)
        {
            try
            {
                using (Database db = new Database())
                {
                    DataTable dt = new DataTable();
                    db.Commands.Add(db.CreateCommand(QUERY_DELETE));
                    db.Commands[0].Parameters.Add(new Parameter("@KODE", MySqlDbType.VarChar, obj.NOPOL));
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
        public DataTable CARI_BYKODE(RMS.COMMON.MASTER.RMS_KENDARAAN obj)
        {
            DataTable dt = new DataTable();
            try
            {
                using (Database db = new Database())
                {
                    db.Commands.Add(db.CreateCommand(QUERY_CARI_BYKODE));
                    
                    db.Commands[0].Parameters.Add(new Parameter("@NOPOL", MySqlDbType.VarChar, obj.NOPOL));
                    dt = db.Commands[0].ExecuteDataTable();
                    
                }
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public DataTable CARI_BYNAMA(RMS.COMMON.MASTER.RMS_KENDARAAN obj)
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

        public DataTable SEARCHLIKE(RMS.COMMON.MASTER.RMS_KENDARAAN obj)
        {
            DataTable dt = new DataTable();
            try
            {
                using (Database db = new Database())
                {
                    db.Commands.Add(db.CreateCommand(QUERY_SEARCHLIKE));
                    
                    db.Commands[0].Parameters.Add(new Parameter("@NOPOL", MySqlDbType.VarChar, obj.NOPOL));
                    db.Commands[0].Parameters.Add(new Parameter("@NAMADRIVER", MySqlDbType.VarChar, obj.NAMADRIVER));
                    db.Commands[0].Parameters.Add(new Parameter("@NAMAHELPER", MySqlDbType.VarChar, obj.NAMAHELPER));
                    
                
                    dt = db.Commands[0].ExecuteDataTable();
                }
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public DataTable SEARCH_BYKODE(RMS.COMMON.MASTER.RMS_KENDARAAN obj)
        {
            DataTable dt = new DataTable();
            try
            {
                using (Database db = new Database())
                {
                    db.Commands.Add(db.CreateCommand(QUERY_SEARCH_BYKODE));
                    db.Commands[0].Parameters.Add(new Parameter("@ID", MySqlDbType.Int32, obj.ID));
                     
                    dt = db.Commands[0].ExecuteDataTable();
                    
                }
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public DataTable SEARCH_BYNAMA(RMS.COMMON.MASTER.RMS_KENDARAAN obj)
        {
            DataTable dt = new DataTable();
            try
            {
                using (Database db = new Database())
                {
                    db.Commands.Add(db.CreateCommand(QUERY_SEARCH_BYNAME));
                    //db.Commands[0].Parameters.Add(new Parameter("@NAMACUSTOMER", MySqlDbType.VarChar, obj.NAMACUSTOMER));
                    //db.Commands[0].Parameters.Add(new Parameter("@KODECUSTOMER", MySqlDbType.VarChar, obj.KODE));
                    //dt = db.Commands[0].ExecuteDataTable();
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

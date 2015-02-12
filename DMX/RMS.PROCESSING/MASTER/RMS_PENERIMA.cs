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
    public class RMS_PENERIMA
    {
        Database db = new Database();
        protected string QUERY_SELECT = "SELECT * FROM penerima WHERE TYPE = @TYPE AND ISAKTIF = 1";
        protected string QUERY_DELETE = "UPDATE penerima SET ISAKTIF = 0 WHERE IDPENERIMA=@IDPENERIMA";
        protected string QUERY_CARI_BYKODE = "SELECT * FROM penerima WHERE KODEPENERIMA=@KODEPENERIMA";
        protected string QUERY_CARI_BYNAME = "SELECT * FROM penerima WHERE NAMAPENERIMA=@NAMAPENERIMA";
        protected string QUERY_SEARCHLIKE = "SELECT * FROM penerima WHERE TYPE=@TYPE AND ISAKTIF = 1 AND (KODEPENERIMA LIKE CONCAT('%',@KODEPENERIMA,'%') OR NAMAPENERIMA LIKE CONCAT('%',@NAMAPENERIMA,'%'))";
        protected string QUERY_SEARCH_BYKODE = "SELECT * FROM penerima WHERE IDPENERIMA=@IDPENERIMA";
        protected string QUERY_SEARCH_BYNAME = "SELECT * FROM v_customer WHERE NAMACUSTOMER LIKE CONCAT('%',@NAMACUSTOMER,'%')";
        protected string QUERY_INSERT = "INSERT INTO penerima(KODEPENERIMA,NAMAPENERIMA,ALAMAT,TELEPON,FAX,HP,EMAIL,TYPE) VALUES "
                                        + "(@KODEPENERIMA,@NAMAPENERIMA,@ALAMAT,@TELEPON,@FAX,@HP,@EMAIL,@TYPE)";
        protected string QUERY_UPDATE = "UPDATE penerima SET NAMAPENERIMA=@NAMAPENERIMA,ALAMAT=@ALAMAT,TELEPON=@TELEPON,FAX=@FAX," +
                                        "HP=@HP,EMAIL=@EMAIL,TYPE=@TYPE WHERE IDPENERIMA=@IDPENERIMA";


        public void INSERT(RMS.COMMON.MASTER.RMS_PENERIMA obj)
        {
            try
            {
                using (Database db = new Database())
                {
                    DataTable dt = new DataTable();
                    db.Commands.Add(db.CreateCommand(QUERY_INSERT));
                    db.Commands[0].Parameters.Add(new Parameter("@KODEPENERIMA", MySqlDbType.VarChar, obj.KODEPENERIMA));
                    db.Commands[0].Parameters.Add(new Parameter("@NAMAPENERIMA", MySqlDbType.VarChar, obj.NAMAPENERIMA));
                    db.Commands[0].Parameters.Add(new Parameter("@ALAMAT", MySqlDbType.VarChar, obj.ALAMAT));
                    db.Commands[0].Parameters.Add(new Parameter("@TELEPON", MySqlDbType.VarChar, obj.TELEPON));
                    db.Commands[0].Parameters.Add(new Parameter("@FAX", MySqlDbType.VarChar, obj.FAX));
                    db.Commands[0].Parameters.Add(new Parameter("@HP", MySqlDbType.VarChar, obj.HP));
                    db.Commands[0].Parameters.Add(new Parameter("@EMAIL", MySqlDbType.VarChar, obj.EMAIL));
                    db.Commands[0].Parameters.Add(new Parameter("@TYPE", MySqlDbType.Int32, obj.TYPE));
                    
                    

                    dt = db.Commands[0].ExecuteDataTable();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void UPDATE(RMS.COMMON.MASTER.RMS_PENERIMA obj)
        {
            try
            {
                using (Database db = new Database())
                {
                    DataTable dt = new DataTable();
                    db.Commands.Add(db.CreateCommand(QUERY_UPDATE));
                    db.Commands[0].Parameters.Add(new Parameter("@IDPENERIMA", MySqlDbType.Int32, obj.ID));
                    db.Commands[0].Parameters.Add(new Parameter("@NAMAPENERIMA", MySqlDbType.VarChar, obj.NAMAPENERIMA));
                    db.Commands[0].Parameters.Add(new Parameter("@ALAMAT", MySqlDbType.VarChar, obj.ALAMAT));                    
                    db.Commands[0].Parameters.Add(new Parameter("@TELEPON", MySqlDbType.VarChar, obj.TELEPON));
                    db.Commands[0].Parameters.Add(new Parameter("@FAX", MySqlDbType.VarChar, obj.FAX));
                    db.Commands[0].Parameters.Add(new Parameter("@HP", MySqlDbType.VarChar, obj.HP));
                    db.Commands[0].Parameters.Add(new Parameter("@EMAIL", MySqlDbType.VarChar, obj.EMAIL));
                    db.Commands[0].Parameters.Add(new Parameter("@TYPE", MySqlDbType.Int32, obj.TYPE));
                    dt = db.Commands[0].ExecuteDataTable();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void DELETE(RMS.COMMON.MASTER.RMS_PENERIMA obj)
        {
            try
            {
                using (Database db = new Database())
                {
                    DataTable dt = new DataTable();
                    db.Commands.Add(db.CreateCommand(QUERY_DELETE));
                    db.Commands[0].Parameters.Add(new Parameter("@IDPENERIMA", MySqlDbType.Int32, obj.ID));
                    dt = db.Commands[0].ExecuteDataTable();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public DataTable SELECT(RMS.COMMON.MASTER.RMS_PENERIMA obj)
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
        public DataTable CARI_BYKODE(RMS.COMMON.MASTER.RMS_PENERIMA obj)
        {
            DataTable dt = new DataTable();
            try
            {
                using (Database db = new Database())
                {
                    db.Commands.Add(db.CreateCommand(QUERY_CARI_BYKODE));
                    db.Commands[0].Parameters.Add(new Parameter("@KODEPENERIMA", MySqlDbType.VarChar, obj.KODEPENERIMA));
                    dt = db.Commands[0].ExecuteDataTable();
                }
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public DataTable CARI_BYNAMA(RMS.COMMON.MASTER.RMS_PENERIMA obj)
        {
            DataTable dt = new DataTable();
            try
            {
                using (Database db = new Database())
                {
                    db.Commands.Add(db.CreateCommand(QUERY_CARI_BYNAME));
                    db.Commands[0].Parameters.Add(new Parameter("@NAMAPENERIMA", MySqlDbType.VarChar, obj.NAMAPENERIMA));
                    dt = db.Commands[0].ExecuteDataTable();
                }
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        
        public DataTable SEARCHLIKE(RMS.COMMON.MASTER.RMS_PENERIMA obj)
        {
            DataTable dt = new DataTable();
            try
            {
                using (Database db = new Database())
                {
                    db.Commands.Add(db.CreateCommand(QUERY_SEARCHLIKE));
                    db.Commands[0].Parameters.Add(new Parameter("@KODEPENERIMA", MySqlDbType.VarChar, obj.KODEPENERIMA));
                    db.Commands[0].Parameters.Add(new Parameter("@NAMAPENERIMA", MySqlDbType.VarChar, obj.NAMAPENERIMA));
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
        public DataTable SEARCH_BYKODE(RMS.COMMON.MASTER.RMS_PENERIMA obj)
        {
            DataTable dt = new DataTable();
            try
            {
                using (Database db = new Database())
                {
                    db.Commands.Add(db.CreateCommand(QUERY_SEARCH_BYKODE));
                    db.Commands[0].Parameters.Add(new Parameter("@IDPENERIMA", MySqlDbType.VarChar, obj.ID));
                    dt = db.Commands[0].ExecuteDataTable();
                }
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public DataTable SEARCH_BYNAMA(RMS.COMMON.MASTER.RMS_PENERIMA obj)
        {
            DataTable dt = new DataTable();
            try
            {
                using (Database db = new Database())
                {
                    db.Commands.Add(db.CreateCommand(QUERY_SEARCH_BYNAME));
                    db.Commands[0].Parameters.Add(new Parameter("@NAMAPENERIMA", MySqlDbType.VarChar, obj.NAMAPENERIMA));
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

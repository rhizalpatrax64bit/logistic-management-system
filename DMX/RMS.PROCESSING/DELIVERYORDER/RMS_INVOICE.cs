using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RMS.COMMON;
using Anovsys.DAL;
using MySql.Data.MySqlClient;
using System.Data;

namespace RMS.PROCESSING.DELIVERYORDER
{
    public class RMS_INVOICE
    {
        Database db = new Database();

        protected string QUERY_SELECT = "SELECT * FROM V_INVOICE";
        protected string QUERY_GETNOINVOICE = "SELECT getNOINVOICE(@BEGINDATE,@ENDDATE,@KODECUSTOMER)";
        protected string QUERY_DELETE = "DELETE FROM SALES WHERE KODESALES=@KODESALES";
        protected string QUERY_CARI_BYKODE = "SELECT * FROM SALES WHERE KODESALES=@KODESALES";
        protected string QUERY_CARI_BYNAME = "SELECT * FROM SALES WHERE KODESALES=@NAMASALES";
        protected string QUERY_SEARCH_BYKODE = "SELECT * FROM SALES WHERE KODESALES LIKE CONCAT('%',@KODESALES,'%')";
        protected string QUERY_SEARCH_NOINVOICE = "SELECT ID FROM invoice WHERE KODEINVOICE =@KODEINVOICE";      

        protected string QUERY_SEARCH_BYNAME = "SELECT * FROM SALES WHERE NAMASALES LIKE CONCAT('%',@NAMASALES,'%')";
        protected string QUERY_INSERT = "CALL insertInvoice(@TGLINVOICE,@KODEINVOICE,@KODECUSTOMER,@KETERANGAN)";
        protected string QUERY_UPDATE = "UPDATE SALES SET KODESALES=@KODESALES,NAMASALES=@NAMASALES,ALAMAT=@ALAMAT,TELEPON=@TELEPON,EMAIL=@EMAIL WHERE KODESALES=@KODESALES";

        public DataTable SELECTNOINVOICE(string begin, string end, string kodecustomer)
        {
            DataTable dt = new DataTable();
            try
            {
                using (Database db = new Database())
                {
                    db.Commands.Add(db.CreateCommand(QUERY_GETNOINVOICE));
                    db.Commands[0].Parameters.Add(new Parameter("@BEGINDATE", MySqlDbType.VarChar, begin));
                    db.Commands[0].Parameters.Add(new Parameter("@ENDDATE", MySqlDbType.VarChar, end));
                    db.Commands[0].Parameters.Add(new Parameter("@KODECUSTOMER", MySqlDbType.VarChar, kodecustomer));
                    dt = db.Commands[0].ExecuteDataTable();
                }
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void INSERT(RMS.COMMON.DELIVERYORDER.RMS_INVOICE obj)
        {
            try
            {
                using (Database db = new Database())
                {
                    DataTable dt = new DataTable();
                    
                    db.Commands.Add(db.CreateCommand(QUERY_INSERT));
                    db.Commands[0].Parameters.Add(new Parameter("@TGLINVOICE", MySqlDbType.VarChar, obj.TGLINVOICE));
                    db.Commands[0].Parameters.Add(new Parameter("@KODEINVOICE", MySqlDbType.VarChar, obj.KODEINVOICE));
                    db.Commands[0].Parameters.Add(new Parameter("@KODECUSTOMER", MySqlDbType.VarChar, obj.KODECUSTOMER));
                    db.Commands[0].Parameters.Add(new Parameter("@KETERANGAN", MySqlDbType.VarChar, obj.KETERANGAN));
                    
                    dt = db.Commands[0].ExecuteDataTable();
                
                 }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void UPDATE(RMS.COMMON.DELIVERYORDER.RMS_INVOICE obj)
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
                    dt = db.Commands[0].ExecuteDataTable();
                     */ 
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void DELETE(RMS.COMMON.DELIVERYORDER.RMS_INVOICE obj)
        {
            try
            {
                using (Database db = new Database())
                {
                    DataTable dt = new DataTable();
                    db.Commands.Add(db.CreateCommand(QUERY_DELETE));
                    //db.Commands[0].Parameters.Add(new Parameter("@KODESALES", MySqlDbType.VarChar, obj.KODE));
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
        public DataTable CARI_BYKODE(RMS.COMMON.DELIVERYORDER.RMS_INVOICE obj)
        {
            DataTable dt = new DataTable();
            try
            {
                using (Database db = new Database())
                {
                    db.Commands.Add(db.CreateCommand(QUERY_CARI_BYKODE));
                    //db.Commands[0].Parameters.Add(new Parameter("@KODESALES", MySqlDbType.VarChar, obj.KODE));
                   // dt = db.Commands[0].ExecuteDataTable();
                }
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public DataTable CARI_BYNAMA(RMS.COMMON.DELIVERYORDER.RMS_INVOICE obj)
        {
            DataTable dt = new DataTable();
            try
            {
                using (Database db = new Database())
                {
                    db.Commands.Add(db.CreateCommand(QUERY_CARI_BYNAME));
                    //db.Commands[0].Parameters.Add(new Parameter("@NAMASALES", MySqlDbType.VarChar, obj.NAMA));
                    dt = db.Commands[0].ExecuteDataTable();
                }
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public DataTable SEARCH_NOINVOICE(string _noinvoice)
        {
            DataTable dt = new DataTable();
            try
            {
                using (Database db = new Database())
                {
                    db.Commands.Add(db.CreateCommand(QUERY_SEARCH_NOINVOICE));
                    db.Commands[0].Parameters.Add(new Parameter("@KODEINVOICE", MySqlDbType.VarChar, _noinvoice));
                    dt = db.Commands[0].ExecuteDataTable();
                }
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public DataTable SEARCH_BYKODE(RMS.COMMON.DELIVERYORDER.RMS_INVOICE obj)
        {
            DataTable dt = new DataTable();
            try
            {
                using (Database db = new Database())
                {
                    db.Commands.Add(db.CreateCommand(QUERY_SEARCH_BYKODE));
                    //db.Commands[0].Parameters.Add(new Parameter("@KODESALES", MySqlDbType.VarChar, obj.KODE));
                    dt = db.Commands[0].ExecuteDataTable();
                }
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public DataTable SEARCH_BYNAMA(RMS.COMMON.DELIVERYORDER.RMS_INVOICE obj)
        {
            DataTable dt = new DataTable();
            try
            {
                using (Database db = new Database())
                {
                    db.Commands.Add(db.CreateCommand(QUERY_SEARCH_BYNAME));
                    //db.Commands[0].Parameters.Add(new Parameter("@NAMASALES", MySqlDbType.VarChar, obj.NAMA));
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

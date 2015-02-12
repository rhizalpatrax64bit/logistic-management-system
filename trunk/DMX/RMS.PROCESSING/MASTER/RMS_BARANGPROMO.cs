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
    public class RMS_BARANGPROMO
    {
        Database db = new Database();
        protected string QUERY_SELECT = "SELECT * FROM BARANGPROMO";
        protected string QUERY_DELETE = "DELETE FROM BARANGPROMO WHERE KODEPROMO=@KODEPROMO";
        protected string QUERY_CARI_BYKODE = "SELECT * FROM BARANGPROMO WHERE KODEPROMO=@KODEPROMO";
        protected string QUERY_CARI_BYNAME = "SELECT * FROM BBARANGPROMOANK WHERE NAMAPROMO=@NAMAPROMO";
        protected string QUERY_SEARCH_BYKODE = "SELECT * FROM BARANGPROMO WHERE KODEPROMO LIKE CONCAT('%',@KODEPROMO,'%')";
        protected string QUERY_SEARCH_BYNAME = "SELECT * FROM BARANGPROMO WHERE NAMAPROMO LIKE CONCAT('%',@NAMAPROMO,'%')";
        protected string QUERY_INSERT = "INSERT INTO BARANGPROMO(KODEPROMO,NAMAPROMO,BARCODE,HARGAPOKOK,MARGINPROFIT,HARGAJUAL,QTY)"+
                                        " VALUES (@KODEPROMO,@NAMAPROMO,@BARCODE,@HARGAPOKOK,@MARGINPROFIT,@HARGAJUAL,@QTY)";
        protected string QUERY_UPDATE = "UPDATE BARANGPROMO SET KODEPROMO=@KODEPROMO,NAMAPROMO=@NAMAPROMO,BARCODE=@BARCODE,HARGAPOKOK=@HARGAPOKOK,"+
                                        "MARGINPROFIT=@MARGINPROFIT,HARGAJUAL=@HARGAJUAL,QTY=@QTY WHERE KODEPROMO=@KODEPROMO";

        public void INSERT(RMS.COMMON.MASTER.RMS_BARANGPROMO obj)
        {
            try
            {
                using (Database db = new Database())
                {
                    DataTable dt = new DataTable();
                    db.Commands.Add(db.CreateCommand(QUERY_INSERT));
                    db.Commands[0].Parameters.Add(new Parameter("@KODEPROMO", MySqlDbType.VarChar, obj.KODE));
                    db.Commands[0].Parameters.Add(new Parameter("@NAMAPROMO", MySqlDbType.VarChar, obj.NAMA));
                    db.Commands[0].Parameters.Add(new Parameter("@BARCODE", MySqlDbType.VarChar, obj.BARCODE));
                    db.Commands[0].Parameters.Add(new Parameter("@HARGAPOKOK", MySqlDbType.VarChar, obj.HARGAPOKOK));
                    db.Commands[0].Parameters.Add(new Parameter("@MARGINPROFIT", MySqlDbType.VarChar, obj.PROFIT));
                    db.Commands[0].Parameters.Add(new Parameter("@HARGAJUAL", MySqlDbType.VarChar, obj.HARGAJUAL));
                    db.Commands[0].Parameters.Add(new Parameter("@QTY", MySqlDbType.VarChar, obj.QTY));
                    dt = db.Commands[0].ExecuteDataTable();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void UPDATE(RMS.COMMON.MASTER.RMS_BARANGPROMO obj)
        {
            try
            {
                using (Database db = new Database())
                {
                    DataTable dt = new DataTable();
                    db.Commands.Add(db.CreateCommand(QUERY_UPDATE));
                    db.Commands[0].Parameters.Add(new Parameter("@KODEPROMO", MySqlDbType.VarChar, obj.KODE));
                    db.Commands[0].Parameters.Add(new Parameter("@NAMAPROMO", MySqlDbType.VarChar, obj.NAMA));
                    db.Commands[0].Parameters.Add(new Parameter("@BARCODE", MySqlDbType.VarChar, obj.BARCODE));
                    db.Commands[0].Parameters.Add(new Parameter("@HARGAPOKOK", MySqlDbType.VarChar, obj.HARGAPOKOK));
                    db.Commands[0].Parameters.Add(new Parameter("@MARGINPROFIT", MySqlDbType.VarChar, obj.PROFIT));
                    db.Commands[0].Parameters.Add(new Parameter("@HARGAJUAL", MySqlDbType.VarChar, obj.HARGAJUAL));
                    db.Commands[0].Parameters.Add(new Parameter("@QTY", MySqlDbType.VarChar, obj.QTY));
                    dt = db.Commands[0].ExecuteDataTable();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void DELETE(RMS.COMMON.MASTER.RMS_BARANGPROMO obj)
        {
            try
            {
                using (Database db = new Database())
                {
                    DataTable dt = new DataTable();
                    db.Commands.Add(db.CreateCommand(QUERY_DELETE));
                    db.Commands[0].Parameters.Add(new Parameter("@KODEPROMO", MySqlDbType.VarChar, obj.KODE));
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
        public DataTable CARI_BYKODE(RMS.COMMON.MASTER.RMS_BARANGPROMO obj)
        {
            DataTable dt = new DataTable();
            try
            {
                using (Database db = new Database())
                {
                    db.Commands.Add(db.CreateCommand(QUERY_CARI_BYKODE));
                    db.Commands[0].Parameters.Add(new Parameter("@KODEPROMO", MySqlDbType.VarChar, obj.KODE));
                    dt = db.Commands[0].ExecuteDataTable();
                }
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public DataTable CARI_BYNAMA(RMS.COMMON.MASTER.RMS_BARANGPROMO obj)
        {
            DataTable dt = new DataTable();
            try
            {
                using (Database db = new Database())
                {
                    db.Commands.Add(db.CreateCommand(QUERY_CARI_BYNAME));
                    db.Commands[0].Parameters.Add(new Parameter("@NAMAPROMO", MySqlDbType.VarChar, obj.NAMA));
                    dt = db.Commands[0].ExecuteDataTable();
                }
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public DataTable SEARCH_BYKODE(RMS.COMMON.MASTER.RMS_BARANGPROMO obj)
        {
            DataTable dt = new DataTable();
            try
            {
                using (Database db = new Database())
                {
                    db.Commands.Add(db.CreateCommand(QUERY_SEARCH_BYKODE));
                    db.Commands[0].Parameters.Add(new Parameter("@KODEPROMO", MySqlDbType.VarChar, obj.KODE));
                    dt = db.Commands[0].ExecuteDataTable();
                }
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public DataTable SEARCH_BYNAMA(RMS.COMMON.MASTER.RMS_BARANGPROMO obj)
        {
            DataTable dt = new DataTable();
            try
            {
                using (Database db = new Database())
                {
                    db.Commands.Add(db.CreateCommand(QUERY_SEARCH_BYNAME));
                    db.Commands[0].Parameters.Add(new Parameter("@NAMAPROMO", MySqlDbType.VarChar, obj.NAMA));
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

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
    public class RMS_BARANG
    {
        Database db = new Database();
        protected string QUERY_SELECT = "SELECT * FROM BARANG";
        protected string QUERY_INSERT = "INSERT INTO BARANG(KODEBARANG,BARCODE,NAMABARANG,NAMASATUAN,ISISATUAN,KODEDEPARTMENT,NAMADEPARTMENT,STOK,TOTALBARANG," +
                                        "HARGABELI1,HARGABELI2,BRUTO,DISKONRP1,DISKONRP2,DISKONPS1,DISKONPS2,DISKONPS3,DISKONPS4,DISKONPS5,PPN,NETTO,HARGAPOKOKBELI1," +
                                        "HARGAPOKOKBELI2,MARGINPROFIT,HARGAJUAL1,HARGAJUAL2,MARGINSPESIAL,HARGASPESIAL,QTY1,QTY2,QTY3,QTY4,QTY5,MARGIN1,MARGIN2,MARGIN3," +
                                        "MARGIN4,MARGIN5,HARGA1,HARGA2,HARGA3,HARGA4,HARGA5,GUDANG,RESET,TGLBELI,TGLUPDATE,TGLEXPIRED) VALUES " +
                                        "(@KODEBARANG,@BARCODE,@NAMABARANG,@NAMASATUAN,@ISISATUAN,@KODEDEPARTMENT,@NAMADEPARTMENT,@STOK,@TOTALBARANG," +
                                        "@HARGABELI1,@HARGABELI2,@BRUTO,@DISKONRP1,@DISKONRP2,@DISKONPS1,@DISKONPS2,@DISKONPS3,@DISKONPS4,@DISKONPS5,@PPN,@NETTO,@HARGAPOKOKBELI1," +
                                        "@HARGAPOKOKBELI2,@MARGINPROFIT,@HARGAJUAL1,@HARGAJUAL2,@MARGINSPESIAL,@HARGASPESIAL,@QTY1,@QTY2,@QTY3,@QTY4,@QTY5,@MARGIN1,@MARGIN2,@MARGIN3," +
                                        "@MARGIN4,@MARGIN5,@HARGA1,@HARGA2,@HARGA3,@HARGA4,@HARGA5,@GUDANG,@RESET,@TGLBELI,@TGLUPDATE,@TGLEXPIRED)";
        protected string QUERY_CARI_BYKODE = "SELECT * FROM BARANG WHERE KODEBARANG=@KODEBARANG";
        protected string QUERY_CARI_BYBARCODE = "SELECT * FROM BARANG WHERE BARCODE=@BARCODE";
        protected string QUERY_SEARCH_BYKODE = "SELECT * FROM BARANG WHERE KODEBARANG LIKE CONCAT('%',@KODEBARANG,'%')";
        protected string QUERY_SEARCH_BYNAME = "SELECT * FROM BARANG WHERE NAMABARANG LIKE CONCAT('%',@NAMABARANG,'%')";


        public void INSERT(RMS.COMMON.MASTER.RMS_BARANG obj)
        {
            try
            {
                using (Database db = new Database())
                {
                    DataTable dt = new DataTable();
                    db.Commands.Add(db.CreateCommand(QUERY_INSERT));
                    db.Commands[0].Parameters.Add(new Parameter("@KODEBARANG", MySqlDbType.VarChar, obj.KODEBARANG));
                    db.Commands[0].Parameters.Add(new Parameter("@BARCODE", MySqlDbType.VarChar, obj.BARCODE));
                    db.Commands[0].Parameters.Add(new Parameter("@NAMABARANG", MySqlDbType.VarChar, obj.NAMABARANG));
                    db.Commands[0].Parameters.Add(new Parameter("@NAMASATUAN", MySqlDbType.VarChar, obj.NAMASATUAN));
                    db.Commands[0].Parameters.Add(new Parameter("@ISISATUAN", MySqlDbType.Int32, obj.KODESATUAN));
                    db.Commands[0].Parameters.Add(new Parameter("@KODEDEPARTMENT", MySqlDbType.VarChar, obj.KODEDEPT));
                    db.Commands[0].Parameters.Add(new Parameter("@NAMADEPARTMENT", MySqlDbType.VarChar, obj.NAMADEPT));
                    db.Commands[0].Parameters.Add(new Parameter("@STOK", MySqlDbType.Int32, obj.STOK));
                    db.Commands[0].Parameters.Add(new Parameter("@TOTALBARANG", MySqlDbType.Int32, obj.TOTALPCS));
                    db.Commands[0].Parameters.Add(new Parameter("@HARGABELI1", MySqlDbType.Decimal, obj.HARGABELI1));
                    db.Commands[0].Parameters.Add(new Parameter("@HARGABELI2", MySqlDbType.Decimal, obj.HARGABELI2));
                    db.Commands[0].Parameters.Add(new Parameter("@BRUTO", MySqlDbType.Decimal, obj.BRUTO));
                    db.Commands[0].Parameters.Add(new Parameter("@DISKONRP1", MySqlDbType.Float, obj.DISKONRP1));
                    db.Commands[0].Parameters.Add(new Parameter("@DISKONRP2", MySqlDbType.Float, obj.DISKONRP2));
                    db.Commands[0].Parameters.Add(new Parameter("@DISKONPS1", MySqlDbType.Float, obj.DISKONPSN1));
                    db.Commands[0].Parameters.Add(new Parameter("@DISKONPS2", MySqlDbType.Float, obj.DISKONPSN2));
                    db.Commands[0].Parameters.Add(new Parameter("@DISKONPS3", MySqlDbType.Float, obj.DISKONPSN3));
                    db.Commands[0].Parameters.Add(new Parameter("@DISKONPS4", MySqlDbType.Float, obj.DISKONPSN4));
                    db.Commands[0].Parameters.Add(new Parameter("@DISKONPS5", MySqlDbType.Float, obj.DISKONPSN5));
                    db.Commands[0].Parameters.Add(new Parameter("@PPN", MySqlDbType.Int32, obj.PPN));
                    db.Commands[0].Parameters.Add(new Parameter("@NETTO", MySqlDbType.Decimal, obj.NETTO));
                    db.Commands[0].Parameters.Add(new Parameter("@HARGAPOKOKBELI1", MySqlDbType.Decimal, obj.HARGAPOKOKBELI1));
                    db.Commands[0].Parameters.Add(new Parameter("@HARGAPOKOKBELI2", MySqlDbType.Decimal, obj.HARGAPOKOKBELI2));
                    db.Commands[0].Parameters.Add(new Parameter("@MARGINPROFIT", MySqlDbType.Float, obj.MARGIN1));
                    db.Commands[0].Parameters.Add(new Parameter("@HARGAJUAL1", MySqlDbType.Decimal, obj.HARGAJUAL1));
                    db.Commands[0].Parameters.Add(new Parameter("@HARGAJUAL2", MySqlDbType.Decimal, obj.HARGAJUAL2));
                    db.Commands[0].Parameters.Add(new Parameter("@MARGINSPESIAL", MySqlDbType.Float, obj.MARGINSPESIAL));
                    db.Commands[0].Parameters.Add(new Parameter("@HARGASPESIAL", MySqlDbType.Decimal, obj.HARGASPESIAL));
                    db.Commands[0].Parameters.Add(new Parameter("@QTY1", MySqlDbType.Int32, obj.QTY1));
                    db.Commands[0].Parameters.Add(new Parameter("@QTY2", MySqlDbType.Int32, obj.QTY2));
                    db.Commands[0].Parameters.Add(new Parameter("@QTY3", MySqlDbType.Int32, obj.QTY3));
                    db.Commands[0].Parameters.Add(new Parameter("@QTY4", MySqlDbType.Int32, obj.QTY4));
                    db.Commands[0].Parameters.Add(new Parameter("@QTY5", MySqlDbType.Int32, obj.QTY5));
                    db.Commands[0].Parameters.Add(new Parameter("@MARGIN1", MySqlDbType.Float, obj.MRG1));
                    db.Commands[0].Parameters.Add(new Parameter("@MARGIN2", MySqlDbType.Float, obj.MRG2));
                    db.Commands[0].Parameters.Add(new Parameter("@MARGIN3", MySqlDbType.Float, obj.MRG3));
                    db.Commands[0].Parameters.Add(new Parameter("@MARGIN4", MySqlDbType.Float, obj.MRG4));
                    db.Commands[0].Parameters.Add(new Parameter("@MARGIN5", MySqlDbType.Float, obj.MRG5));
                    db.Commands[0].Parameters.Add(new Parameter("@HARGA1", MySqlDbType.Decimal, obj.HRG1));
                    db.Commands[0].Parameters.Add(new Parameter("@HARGA2", MySqlDbType.Decimal, obj.HRG2));
                    db.Commands[0].Parameters.Add(new Parameter("@HARGA3", MySqlDbType.Decimal, obj.HRG3));
                    db.Commands[0].Parameters.Add(new Parameter("@HARGA4", MySqlDbType.Decimal, obj.HRG4));
                    db.Commands[0].Parameters.Add(new Parameter("@HARGA5", MySqlDbType.Decimal, obj.HRG5));
                    db.Commands[0].Parameters.Add(new Parameter("@GUDANG", MySqlDbType.VarChar, obj.GUDANG));
                    db.Commands[0].Parameters.Add(new Parameter("@RESET", MySqlDbType.Bit, obj.RESET));
                    db.Commands[0].Parameters.Add(new Parameter("@TGLBELI", MySqlDbType.Date, obj.TGLBELI));
                    db.Commands[0].Parameters.Add(new Parameter("@TGLUPDATE", MySqlDbType.Date, obj.TGLUPDATE));
                    db.Commands[0].Parameters.Add(new Parameter("@TGLEXPIRED", MySqlDbType.Date, obj.TGLEXPIRED));
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
        public DataTable CARI_BYKODE(RMS.COMMON.MASTER.RMS_BARANG obj)
        {
            DataTable dt = new DataTable();
            try
            {
                using (Database db = new Database())
                {
                    db.Commands.Add(db.CreateCommand(QUERY_CARI_BYKODE));
                    db.Commands[0].Parameters.Add(new Parameter("@KODEBARANG", MySqlDbType.VarChar, obj.KODEBARANG));
                    dt = db.Commands[0].ExecuteDataTable();
                }
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public DataTable CARI_BYBARCODE(RMS.COMMON.MASTER.RMS_BARANG obj)
        {
            DataTable dt = new DataTable();
            try
            {
                using (Database db = new Database())
                {
                    db.Commands.Add(db.CreateCommand(QUERY_CARI_BYBARCODE));
                    db.Commands[0].Parameters.Add(new Parameter("@BARCODE", MySqlDbType.VarChar, obj.BARCODE));
                    dt = db.Commands[0].ExecuteDataTable();
                }
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public DataTable SEARCH_BYKODE(RMS.COMMON.MASTER.RMS_BARANG obj)
        {
            DataTable dt = new DataTable();
            try
            {
                using (Database db = new Database())
                {
                    db.Commands.Add(db.CreateCommand(QUERY_SEARCH_BYKODE));
                    db.Commands[0].Parameters.Add(new Parameter("@KODEBARANG", MySqlDbType.VarChar, obj.KODEBARANG));
                    dt = db.Commands[0].ExecuteDataTable();
                }
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public DataTable SEARCH_BYNAMA(RMS.COMMON.MASTER.RMS_BARANG obj)
        {
            DataTable dt = new DataTable();
            try
            {
                using (Database db = new Database())
                {
                    db.Commands.Add(db.CreateCommand(QUERY_SEARCH_BYNAME));
                    db.Commands[0].Parameters.Add(new Parameter("@NAMABARANG", MySqlDbType.VarChar, obj.NAMABARANG));
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

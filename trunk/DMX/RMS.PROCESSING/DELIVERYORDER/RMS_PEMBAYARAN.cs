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
    public class RMS_PEMBAYARAN
    {
        Database db = new Database();

        protected string QUERY_SELECT = "SELECT * FROM V_INVOICE";
        protected string QUERY_SELECTHISTORY = "SELECT * FROM v_list_pembayaran WHERE IDSTT=@ID";
        protected string QUERY_SELECTHISTORYTAGIHAN = "SELECT * FROM v_list_historitpembayarantagihan WHERE IDTAGIHAN=@IDTAGIHAN";
        protected string QUERY_SELECTHISTORY_BYID = "SELECT * FROM v_list_pembayaran WHERE IDPEMBAYARAN=@IDPEMBAYARAN";
        protected string QUERY_SELECTHISTORYINV = "SELECT * FROM v_list_pembayaraninvoice WHERE ID=@ID";
        protected string QUERY_SEARCHHISTORYINV_BYID = "SELECT * FROM v_list_pembayaraninvoice WHERE IDPEMBAYARAN=@IDPEMBAYARAN";
        protected string QUERY_SEARCHHISTORYTAGIHAN_BYID = "SELECT * FROM v_list_historitpembayarantagihan WHERE IDPEMBAYARAN=@IDPEMBAYARAN";
        protected string QUERY_GETNOINVOICE = "SELECT getNOINVOICE(@BEGINDATE,@ENDDATE,@KODECUSTOMER)";
        protected string QUERY_DELETE = "DELETE FROM transaksipembayaran WHERE IDPEMBAYARAN=@IDPEMBAYARAN";
        protected string QUERY_CARI_BYKODE = "SELECT * FROM SALES WHERE KODESALES=@KODESALES";
        protected string QUERY_CARI_BYNAME = "SELECT * FROM SALES WHERE KODESALES=@NAMASALES";
        protected string QUERY_SEARCH_BYKODE = "SELECT * FROM SALES WHERE KODESALES LIKE CONCAT('%',@KODESALES,'%')";
        protected string QUERY_SEARCH_NOINVOICE = "SELECT ID FROM invoice WHERE KODEINVOICE =@KODEINVOICE";      

        protected string QUERY_SEARCH_BYNAME = "SELECT * FROM SALES WHERE NAMASALES LIKE CONCAT('%',@NAMASALES,'%')";
        protected string QUERY_INSERTTAGIHAN = "INSERT INTO transaksipembayarantagihan(NOTRANSAKSI,NOTRANSFER,TGLBAYAR,IDTAGIHAN, IDMETODEBAYAR,IDJENISBAYAR,TOTALBAYAR)" +
                                         "VALUES(@NOTRANSAKSI,@NOTRANSFER,@TGLBAYAR,@IDTAGIHAN, @IDMETODEBAYAR,@IDJENISBAYAR,@TOTALBAYAR)";
        protected string QUERY_INSERT = "INSERT INTO transaksipembayaran(NOTRANSAKSI,NOTRANSFER,TGLBAYAR,IDSTT, IDMETODEBAYAR,IDJENISBAYAR,TOTALBAYAR)" +
                                        "VALUES(@NOTRANSAKSI,@NOTRANSFER,@TGLBAYAR,@IDSTT, @IDMETODEBAYAR,@IDJENISBAYAR,@TOTALBAYAR)";
        protected string QUERY_INSERTPMBINV = "INSERT INTO transaksipembayaran(NOTRANSAKSI,NOTRANSFER,TGLBAYAR,IDINVOICE, IDMETODEBAYAR,IDJENISBAYAR,TOTALBAYAR)" +
                                         "VALUES(@NOTRANSAKSI,@NOTRANSFER,@TGLBAYAR,@IDINVOICE, @IDMETODEBAYAR,@IDJENISBAYAR,@TOTALBAYAR)";
        protected string QUERY_UPDATE = "UPDATE transaksipembayaran SET NOTRANSFER=@NOTRANSFER, IDMETODEBAYAR=@IDMETODEBAYAR,IDJENISBAYAR=@IDJENISBAYAR,TOTALBAYAR=@TOTALBAYAR WHERE IDPEMBAYARAN =@IDPEMBAYARAN";
        protected string QUERY_UPDATETAGIHAN = "UPDATE transaksipembayarantagihan SET NOTRANSFER=@NOTRANSFER, IDMETODEBAYAR=@IDMETODEBAYAR,IDJENISBAYAR=@IDJENISBAYAR,TOTALBAYAR=@TOTALBAYAR WHERE IDPEMBAYARAN =@IDPEMBAYARAN";

        public DataTable SELECTHISTORY(RMS.COMMON.DELIVERYORDER.RMS_PEMBAYARAN obj)
        {
            DataTable dt = new DataTable();
            try
            {
                using (Database db = new Database())
                {
                    db.Commands.Add(db.CreateCommand(QUERY_SELECTHISTORY));
                    db.Commands[0].Parameters.Add(new Parameter("@ID", MySqlDbType.VarChar, obj.IDSTT));
                    
                    dt = db.Commands[0].ExecuteDataTable();
                }
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        
        public DataTable SELECTHISTORY_BYID(RMS.COMMON.DELIVERYORDER.RMS_PEMBAYARAN obj)
        {
            DataTable dt = new DataTable();
            try
            {
                using (Database db = new Database())
                {
                    db.Commands.Add(db.CreateCommand(QUERY_SELECTHISTORY_BYID));
                    db.Commands[0].Parameters.Add(new Parameter("@IDPEMBAYARAN", MySqlDbType.VarChar, obj.IDPEMBAYARAN));

                    dt = db.Commands[0].ExecuteDataTable();
                }
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public DataTable SELECTHISTORYTAGIHAN(RMS.COMMON.DELIVERYORDER.RMS_TAGIHAN obj)
        {
            DataTable dt = new DataTable();
            try
            {
                using (Database db = new Database())
                {
                    db.Commands.Add(db.CreateCommand(QUERY_SELECTHISTORYTAGIHAN));
                    db.Commands[0].Parameters.Add(new Parameter("@IDTAGIHAN", MySqlDbType.VarChar, obj.ID));

                    dt = db.Commands[0].ExecuteDataTable();
                }
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public DataTable SEARCHPEMBINV_BYID(RMS.COMMON.DELIVERYORDER.RMS_PEMBAYARAN obj)
        {
            DataTable dt = new DataTable();
            try
            {
                using (Database db = new Database())
                {
                    db.Commands.Add(db.CreateCommand(QUERY_SEARCHHISTORYINV_BYID));
                    db.Commands[0].Parameters.Add(new Parameter("@IDPEMBAYARAN", MySqlDbType.VarChar, obj.IDPEMBAYARAN));

                    dt = db.Commands[0].ExecuteDataTable();
                }
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public DataTable SEARCHPEMBTAGIHAN_BYID(RMS.COMMON.DELIVERYORDER.RMS_PEMBAYARAN obj)
        {
            DataTable dt = new DataTable();
            try
            {
                using (Database db = new Database())
                {
                    db.Commands.Add(db.CreateCommand(QUERY_SEARCHHISTORYTAGIHAN_BYID));
                    db.Commands[0].Parameters.Add(new Parameter("@IDPEMBAYARAN", MySqlDbType.VarChar, obj.IDPEMBAYARAN));

                    dt = db.Commands[0].ExecuteDataTable();
                }
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public DataTable SELECTHISTORYINv(RMS.COMMON.DELIVERYORDER.RMS_PEMBAYARAN obj)
        {
            DataTable dt = new DataTable();
            try
            {
                using (Database db = new Database())
                {
                    db.Commands.Add(db.CreateCommand(QUERY_SELECTHISTORYINV));
                    db.Commands[0].Parameters.Add(new Parameter("@ID", MySqlDbType.VarChar, obj.IDINVOICE));

                    dt = db.Commands[0].ExecuteDataTable();
                }
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
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
        public void INSERTTAGIHAN(RMS.COMMON.DELIVERYORDER.RMS_PEMBAYARAN obj)
        {
            try
            {
                using (Database db = new Database())
                {
                    DataTable dt = new DataTable();

                    db.Commands.Add(db.CreateCommand(QUERY_INSERTTAGIHAN));
                    db.Commands[0].Parameters.Add(new Parameter("@NOTRANSAKSI", MySqlDbType.VarChar, obj.NOTRANSAKSI));
                    db.Commands[0].Parameters.Add(new Parameter("@NOTRANSFER", MySqlDbType.VarChar, obj.NOTRANSFER));
                    db.Commands[0].Parameters.Add(new Parameter("@TGLBAYAR", MySqlDbType.VarChar, obj.TGLBAYAR));
                    db.Commands[0].Parameters.Add(new Parameter("@IDTAGIHAN", MySqlDbType.Int32, obj.IDTAGIHAN));
                    db.Commands[0].Parameters.Add(new Parameter("@IDMETODEBAYAR", MySqlDbType.Int32, obj.IDMETODEBAYAR));
                    db.Commands[0].Parameters.Add(new Parameter("@IDJENISBAYAR", MySqlDbType.Int32, obj.IDJENISBAYAR));
                    db.Commands[0].Parameters.Add(new Parameter("@TOTALBAYAR", MySqlDbType.Float, obj.TOTALBAYAR));

                    dt = db.Commands[0].ExecuteDataTable();

                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void INSERT(RMS.COMMON.DELIVERYORDER.RMS_PEMBAYARAN obj)
        {
            try
            {
                using (Database db = new Database())
                {
                    DataTable dt = new DataTable();
                    
                    db.Commands.Add(db.CreateCommand(QUERY_INSERT));
                    db.Commands[0].Parameters.Add(new Parameter("@NOTRANSAKSI", MySqlDbType.VarChar, obj.NOTRANSAKSI));
                    db.Commands[0].Parameters.Add(new Parameter("@NOTRANSFER", MySqlDbType.VarChar, obj.NOTRANSFER));
                    db.Commands[0].Parameters.Add(new Parameter("@TGLBAYAR", MySqlDbType.VarChar, obj.TGLBAYAR));
                    db.Commands[0].Parameters.Add(new Parameter("@IDSTT", MySqlDbType.Int32, obj.IDSTT));
                    db.Commands[0].Parameters.Add(new Parameter("@IDMETODEBAYAR", MySqlDbType.Int32, obj.IDMETODEBAYAR));
                    db.Commands[0].Parameters.Add(new Parameter("@IDJENISBAYAR", MySqlDbType.Int32, obj.IDJENISBAYAR));
                    db.Commands[0].Parameters.Add(new Parameter("@TOTALBAYAR", MySqlDbType.Float, obj.TOTALBAYAR));
                    
                    dt = db.Commands[0].ExecuteDataTable();
              
                 }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void INSERTPEMBINV(RMS.COMMON.DELIVERYORDER.RMS_PEMBAYARAN obj)
        {
            try
            {
                using (Database db = new Database())
                {
                    DataTable dt = new DataTable();

                    db.Commands.Add(db.CreateCommand(QUERY_INSERTPMBINV));
                    db.Commands[0].Parameters.Add(new Parameter("@NOTRANSAKSI", MySqlDbType.VarChar, obj.NOTRANSAKSI));
                    db.Commands[0].Parameters.Add(new Parameter("@NOTRANSFER", MySqlDbType.VarChar, obj.NOTRANSFER));
                    db.Commands[0].Parameters.Add(new Parameter("@TGLBAYAR", MySqlDbType.VarChar, obj.TGLBAYAR));
                    db.Commands[0].Parameters.Add(new Parameter("@IDINVOICE", MySqlDbType.Int32, obj.IDINVOICE));
                    db.Commands[0].Parameters.Add(new Parameter("@IDMETODEBAYAR", MySqlDbType.Int32, obj.IDMETODEBAYAR));
                    db.Commands[0].Parameters.Add(new Parameter("@IDJENISBAYAR", MySqlDbType.Int32, obj.IDJENISBAYAR));
                    db.Commands[0].Parameters.Add(new Parameter("@TOTALBAYAR", MySqlDbType.Float, obj.TOTALBAYAR));

                    dt = db.Commands[0].ExecuteDataTable();

                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void UPDATE(RMS.COMMON.DELIVERYORDER.RMS_PEMBAYARAN obj)
        {
            try
            {
                using (Database db = new Database())
                {
                    DataTable dt = new DataTable();
                    db.Commands.Add(db.CreateCommand(QUERY_UPDATE));
                  
                    db.Commands[0].Parameters.Add(new Parameter("@IDPEMBAYARAN", MySqlDbType.Int32, obj.IDPEMBAYARAN));
                    db.Commands[0].Parameters.Add(new Parameter("@IDMETODEBAYAR", MySqlDbType.Int32, obj.IDMETODEBAYAR));
                    db.Commands[0].Parameters.Add(new Parameter("@NOTRANSFER", MySqlDbType.VarChar, obj.NOTRANSFER));
                    db.Commands[0].Parameters.Add(new Parameter("@IDJENISBAYAR", MySqlDbType.Int32, obj.IDJENISBAYAR));
                    db.Commands[0].Parameters.Add(new Parameter("@TOTALBAYAR", MySqlDbType.Float, obj.TOTALBAYAR));
                    dt = db.Commands[0].ExecuteDataTable();
                  
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void UPDATETAGIHAN(RMS.COMMON.DELIVERYORDER.RMS_PEMBAYARAN obj)
        {
            try
            {
                using (Database db = new Database())
                {
                    DataTable dt = new DataTable();
                    db.Commands.Add(db.CreateCommand(QUERY_UPDATETAGIHAN));

                    db.Commands[0].Parameters.Add(new Parameter("@IDPEMBAYARAN", MySqlDbType.Int32, obj.IDPEMBAYARAN));
                    db.Commands[0].Parameters.Add(new Parameter("@IDMETODEBAYAR", MySqlDbType.Int32, obj.IDMETODEBAYAR));
                    db.Commands[0].Parameters.Add(new Parameter("@NOTRANSFER", MySqlDbType.VarChar, obj.NOTRANSFER));
                    db.Commands[0].Parameters.Add(new Parameter("@IDJENISBAYAR", MySqlDbType.Int32, obj.IDJENISBAYAR));
                    db.Commands[0].Parameters.Add(new Parameter("@TOTALBAYAR", MySqlDbType.Float, obj.TOTALBAYAR));
                    dt = db.Commands[0].ExecuteDataTable();

                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void DELETE(RMS.COMMON.DELIVERYORDER.RMS_PEMBAYARAN obj)
        {
            try
            {
                using (Database db = new Database())
                {
                    DataTable dt = new DataTable();
                    db.Commands.Add(db.CreateCommand(QUERY_DELETE));
                    db.Commands[0].Parameters.Add(new Parameter("@IDPEMBAYARAN", MySqlDbType.Int32, obj.IDPEMBAYARAN));
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
        public DataTable CARI_BYKODE(RMS.COMMON.DELIVERYORDER.RMS_PEMBAYARAN obj)
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
        public DataTable CARI_BYNAMA(RMS.COMMON.DELIVERYORDER.RMS_PEMBAYARAN obj)
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
        public DataTable SEARCH_BYKODE(RMS.COMMON.DELIVERYORDER.RMS_PEMBAYARAN obj)
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
        public DataTable SEARCH_BYNAMA(RMS.COMMON.DELIVERYORDER.RMS_PEMBAYARAN obj)
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

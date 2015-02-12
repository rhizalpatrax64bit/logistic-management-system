using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RMS.COMMON;
using Anovsys.DAL;
using MySql.Data.MySqlClient;
using System.Data;

namespace RMS.PROCESSING.EXPRESS
{
    public class RMS_TRANSAKSI
    {
        Database db = new Database();

        protected string QUERY_GETKODE = "SELECT getResiNbr()";
        protected string QUERY_SELECTAGENTBYID = "SELECT * IDAGENT,KODEAGENT,NAMAAGENT FROM V_AGENT WHERE IDAGENT = @IDAGENT";
        protected string QUERY_SELECTLIKE = "SELECT * FROM v_sttpembayaran WHERE (DATE BETWEEN @STARTDATE AND @ENDDATE) AND TPAYMENT=@TPAYMENT AND (CUSTOMER LIKE CONCAT('%',@CUSTOMER,'%') OR MARKETING LIKE CONCAT('%',@MARKETING,'%') OR STATUS LIKE CONCAT('%',@STATUS,'%') OR DEST LIKE CONCAT('%',@DEST,'%'))";
        protected string QUERY_SELECTLIKEALL = "SELECT * FROM v_sttpembayaran WHERE (DATE BETWEEN @STARTDATE AND @ENDDATE) AND (CUSTOMER LIKE CONCAT('%',@CUSTOMER,'%') OR MARKETING LIKE CONCAT('%',@MARKETING,'%') OR STATUS LIKE CONCAT('%',@STATUS,'%') OR SERVICE LIKE CONCAT('%',@SERVICE,'%') OR HANDLING LIKE CONCAT('%',@ARMADA,'%') OR DEST LIKE CONCAT('%',@DEST,'%'))";
        protected string QUERY_SELECT = "SELECT * FROM v_transaksi_express WHERE (TGLTERIMA BETWEEN @STARTDATE AND @ENDDATE) AND STATUS=@STATUSORDER ORDER BY TGLTERIMA desc";
        protected string QUERY_SELECTGENEREATEINVOICE = "SELECT * FROM v_sttpembayaran WHERE (DATE BETWEEN @STARTDATE AND @ENDDATE) AND STATUS=@STATUSORDER AND NAMACUSTOMER =@CUSTOMER";
        protected string QUERY_SELECTINVOICECETAK = "SELECT * FROM v_sttpembayaran WHERE (DATE BETWEEN @STARTDATE AND @ENDDATE) AND TPAYMENT=@TPAYMENT GROUP BY CUSTOMER";

        protected string QUERY_SELECTALL = "SELECT * FROM v_transaksi_express WHERE (TGLTERIMA BETWEEN @STARTDATE AND @ENDDATE) ORDER BY TGLTERIMA desc";
       
        
        protected string QUERY_SELECTPMB = "SELECT * FROM V_STTPEMBAYARAN WHERE (DATE BETWEEN @STARTDATE AND @ENDDATE) AND TPAYMENT=@TPAYMENT AND STATUS = @STATUS";
        protected string QUERY_SELECTPMBALL = "SELECT * FROM V_STTPEMBAYARAN WHERE (DATE BETWEEN @STARTDATE AND @ENDDATE) AND TPAYMENT=@TPAYMENT";
        protected string QUERY_SELECTPMBINV = "SELECT * FROM V_STATUSINVOICE WHERE (TGLINVOICE BETWEEN @STARTDATE AND @ENDDATE)";
        protected string QUERY_SELECTPMBINVALL = "SELECT * FROM V_STATUSINVOICE WHERE (TGLINVOICE BETWEEN @STARTDATE AND @ENDDATE)";
        protected string QUERY_SELECTFILTER = "SELECT * FROM v_stt inner join invoice on v_stt.IDINVOICE = invoice.ID WHERE (v_stt.TGLCONNOTE BETWEEN @STARTDATE AND @ENDDATE) AND v_stt.TYPEOFPAYMENT=@TYPEOFPAYMENT AND v_stt.KODECUSTOMER = @KODECUSTOMER";
        protected string QUERY_SELECTINVOICE = "SELECT * FROM v_sttpembayaran where KODEINVOICE = @KODEINVOICE";
        protected string QUERY_SELECTIDSTT = "SELECT * FROM V_STTPEMBAYARAN WHERE ID =@IDSTT";
        protected string QUERY_SELECTKODEINVOICE = "SELECT * FROM V_STATUSINVOICE WHERE KODEINVOICE =@KODEINVOICE";
        protected string QUERY_CARI_TYPEOFPAYMENT = "SELECT * FROM v_stt WHERE TYPEOFPAYMENT=@TYPEOFPAYMENT";
        protected string QUERY_DELETE = "DELETE FROM SALES WHERE KODESALES=@KODESALES";
        protected string QUERY_CARI_BYID = "SELECT * FROM v_transaksi_express WHERE ID =@ID";
        protected string QUERY_CARI_BYKODE = "SELECT * FROM detailstt WHERE NOCONNOTE=@NOCONNOTE";
        protected string QUERY_CARI_BYNAME = "SELECT * FROM SALES WHERE KODESALES=@NAMASALES";
        protected string QUERY_SEARCH_BYKODE = "SELECT * FROM v_stt WHERE (TGLCONNOTE BETWEEN @STARTDATE AND @ENDDATE) AND TYPEOFPAYMENT=@TYPEOFPAYMENT AND KODECUSTOMER LIKE CONCAT('%',@KODECUSTOMER,'%')";
        protected string QUERY_SEARCH_BYNAME = "SELECT * FROM v_stt WHERE (TGLCONNOTE BETWEEN @STARTDATE AND @ENDDATE) AND TYPEOFPAYMENT=@TYPEOFPAYMENT AND NAMACUSTOMER LIKE CONCAT('%',@NAMACUSTOMER,'%')";
        protected string QUERY_INSERT = "INSERT INTO transaksi_express value ('',@NORESI,@IDCUSTOMER,@IDTARIF,@IDPENERIMA,@TGLTERIMA," +
                          "@TGLESTIMASI,@JUMLAH,@BERAT,@DIM_P,@DIM_L,@DIM_T,@RATE_KIRIM,@CHARGE_KIRIM,@PPNPERCENT,@PPN," +
                          "@CHARGE_PACKING,@OTHER_CHARGE,@DISCPERCENT,@DISC,@INSURANCE,@INCURANCEPERCENT,@NBARANGINSURANCE,@TGLPENGIRIMAN,@TGLPENGAMBILAN,@TOTAL," +
                          "@BAYAR,@SISA,@VOID,@STATUS,@PENERIMABARANG,@INSTRUKSIKHUSUS,@KETERANGANISI,@CREATED_BY,CURRENT_DATE(),@UPDATED_BY,@UPDATED_AT)";
        protected string QUERY_UPDATE = "UPDATE transaksi_express set IDCUSTOMER=@IDCUSTOMER,IDTARIF=@IDTARIF,IDPENERIMA=@IDPENERIMA,TGLTERIMA=@TGLTERIMA," +
                          "TGLESTIMASI=@TGLESTIMASI,JUMLAH=@JUMLAH,BERAT=@BERAT,DIM_P=@DIM_P,DIM_L=@DIM_L,DIM_T=@DIM_T,RATE_KIRIM=@RATE_KIRIM,CHARGE_KIRIM=@CHARGE_KIRIM,PPNPERCENT=@PPNPERCENT,PPN=@PPN," +
                          "CHARGE_PACKING=@CHARGE_PACKING,OTHER_CHARGE=@OTHER_CHARGE,DISCPERCENT=@DISCPERCENT,DISC=@DISC,INSURANCE=@INSURANCE,INCURANCEPERCENT=@INCURANCEPERCENT,NBARANGINSURANCE=@NBARANGINSURANCE,INSTRUKSIKHUSUS=@INSTRUKSIKHUSUS,KETERANGANISI=@KETERANGANISI,TGLPENGIRIMAN=@TGLPENGIRIMAN,TGLPENGAMBILAN=@TGLPENGAMBILAN,TOTAL=@TOTAL," +
                          "BAYAR=@BAYAR,SISA=@SISA,VOID=@VOID,UPDATED_BY=@UPDATED_BY WHERE NORESI = @NORESI";
        
        protected string QUERY_SETINVOICE = "UPDATE detailstt SET IDINVOICE=@IDINVOICE,IDSTATUSSTT=@IDSTATUSSTT WHERE NOCONNOTE =@NOCONNOTE";
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
        public void INSERT(RMS.COMMON.EXPRESS.RMS_TRANSAKSI obj)
        {
            try
            {
                using (Database db = new Database())
                {
                    DataTable dt = new DataTable();
                    
                    db.Commands.Add(db.CreateCommand(QUERY_INSERT));
                    db.Commands[0].Parameters.Add(new Parameter("@NORESI", MySqlDbType.VarChar, obj.NORESI));
                    db.Commands[0].Parameters.Add(new Parameter("@IDCUSTOMER", MySqlDbType.Int32, obj.IDCUSTOMER));
                    db.Commands[0].Parameters.Add(new Parameter("@IDTARIF", MySqlDbType.Int32, obj.IDTARIF));
                    db.Commands[0].Parameters.Add(new Parameter("@IDPENERIMA", MySqlDbType.Int32, obj.IDPENERIMA));
                    db.Commands[0].Parameters.Add(new Parameter("@TGLTERIMA", MySqlDbType.VarChar, obj.TGLTERIMA));
                    db.Commands[0].Parameters.Add(new Parameter("@TGLESTIMASI", MySqlDbType.VarChar, obj.TGLESTIMASI));
                    db.Commands[0].Parameters.Add(new Parameter("@JUMLAH", MySqlDbType.Int32, obj.JUMLAH));
                    db.Commands[0].Parameters.Add(new Parameter("@BERAT", MySqlDbType.Float, obj.BERAT));
                    db.Commands[0].Parameters.Add(new Parameter("@KETERANGANISI", MySqlDbType.VarChar, obj.KETERANGANISI));
                    db.Commands[0].Parameters.Add(new Parameter("@INSTRUKSIKHUSUS", MySqlDbType.VarChar, obj.INSTRUKSIKHUSUS));
                    db.Commands[0].Parameters.Add(new Parameter("@DIM_P", MySqlDbType.Float, obj.DIM_P));
                    db.Commands[0].Parameters.Add(new Parameter("@DIM_L", MySqlDbType.Float, obj.DIM_L));
                    db.Commands[0].Parameters.Add(new Parameter("@DIM_T", MySqlDbType.Float, obj.DIM_T));
                    db.Commands[0].Parameters.Add(new Parameter("@RATE_KIRIM", MySqlDbType.Float, obj.RATE_KIRIM));
                    db.Commands[0].Parameters.Add(new Parameter("@CHARGE_KIRIM", MySqlDbType.Float, obj.CHARGE_KIRIM));
                    db.Commands[0].Parameters.Add(new Parameter("@PPNPERCENT", MySqlDbType.Float, obj.PPNPERCENT));
                    db.Commands[0].Parameters.Add(new Parameter("@PPN", MySqlDbType.Float, obj.PPN));
                    db.Commands[0].Parameters.Add(new Parameter("@CHARGE_PACKING", MySqlDbType.Float, obj.CHARGE_PACKING));
                    db.Commands[0].Parameters.Add(new Parameter("@OTHER_CHARGE", MySqlDbType.Float, obj.OTHER_CHARGE));
                    db.Commands[0].Parameters.Add(new Parameter("@DISCPERCENT", MySqlDbType.Float, obj.DISCPERCENT));
                    db.Commands[0].Parameters.Add(new Parameter("@DISC", MySqlDbType.Float, obj.DISC));
                    db.Commands[0].Parameters.Add(new Parameter("@INSURANCE", MySqlDbType.Float, obj.INCURANCE));
                    db.Commands[0].Parameters.Add(new Parameter("@INCURANCEPERCENT", MySqlDbType.Float, obj.INCURANCEPERCENT));
                    db.Commands[0].Parameters.Add(new Parameter("@NBARANGINSURANCE", MySqlDbType.Float, obj.NBARANGINSURANCE));
                    db.Commands[0].Parameters.Add(new Parameter("@TGLPENGIRIMAN", MySqlDbType.VarChar, obj.TGLPENGIRIMAN));
                    db.Commands[0].Parameters.Add(new Parameter("@TGLPENGAMBILAN", MySqlDbType.VarChar, obj.TGLPENGAMBILAN));
                    db.Commands[0].Parameters.Add(new Parameter("@TOTAL", MySqlDbType.Float, obj.TOTAL));
                    db.Commands[0].Parameters.Add(new Parameter("@BAYAR", MySqlDbType.Float, obj.BAYAR));
                    db.Commands[0].Parameters.Add(new Parameter("@SISA", MySqlDbType.Float, obj.SISA));
                    db.Commands[0].Parameters.Add(new Parameter("@VOID", MySqlDbType.Float, obj.VOID));
                    db.Commands[0].Parameters.Add(new Parameter("@STATUS", MySqlDbType.Int32, obj.STATUS));
                    db.Commands[0].Parameters.Add(new Parameter("@PENERIMABARANG", MySqlDbType.VarChar, obj.PENERIMABARANG));
                    db.Commands[0].Parameters.Add(new Parameter("@CREATED_BY", MySqlDbType.VarChar, "admin development"));
                    db.Commands[0].Parameters.Add(new Parameter("@CREATED_AT", MySqlDbType.VarChar, null));
                    db.Commands[0].Parameters.Add(new Parameter("@UPDATED_BY", MySqlDbType.VarChar, null));
                    db.Commands[0].Parameters.Add(new Parameter("@UPDATED_AT", MySqlDbType.VarChar, null));

                    dt = db.Commands[0].ExecuteDataTable();
                    // http://www.c-sharpcorner.com/UploadFile/krishnasarala/generating-barcode-in-C-Sharp/
                    // ini referesi qr barcode
                
                 }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void UPDATE(RMS.COMMON.EXPRESS.RMS_TRANSAKSI obj)
        {
            try
            {
                using (Database db = new Database())
                {
                    DataTable dt = new DataTable();

                    db.Commands.Add(db.CreateCommand(QUERY_UPDATE));
                    db.Commands[0].Parameters.Add(new Parameter("@ID", MySqlDbType.Int32, obj.ID));
                    db.Commands[0].Parameters.Add(new Parameter("@NORESI", MySqlDbType.VarChar, obj.NORESI));
                    db.Commands[0].Parameters.Add(new Parameter("@IDCUSTOMER", MySqlDbType.Int32, obj.IDCUSTOMER));
                    db.Commands[0].Parameters.Add(new Parameter("@IDTARIF", MySqlDbType.Int32, obj.IDTARIF));
                    db.Commands[0].Parameters.Add(new Parameter("@IDPENERIMA", MySqlDbType.Int32, obj.IDPENERIMA));
                    db.Commands[0].Parameters.Add(new Parameter("@TGLTERIMA", MySqlDbType.VarChar, obj.TGLTERIMA));
                    db.Commands[0].Parameters.Add(new Parameter("@TGLESTIMASI", MySqlDbType.VarChar, obj.TGLESTIMASI));
                    db.Commands[0].Parameters.Add(new Parameter("@JUMLAH", MySqlDbType.Int32, obj.JUMLAH));
                    db.Commands[0].Parameters.Add(new Parameter("@BERAT", MySqlDbType.Float, obj.BERAT));
                    db.Commands[0].Parameters.Add(new Parameter("@KETERANGANISI", MySqlDbType.VarChar, obj.KETERANGANISI));
                    db.Commands[0].Parameters.Add(new Parameter("@INSTRUKSIKHUSUS", MySqlDbType.VarChar, obj.INSTRUKSIKHUSUS));
                    db.Commands[0].Parameters.Add(new Parameter("@DIM_P", MySqlDbType.Float, obj.DIM_P));
                    db.Commands[0].Parameters.Add(new Parameter("@DIM_L", MySqlDbType.Float, obj.DIM_L));
                    db.Commands[0].Parameters.Add(new Parameter("@DIM_T", MySqlDbType.Float, obj.DIM_T));
                    db.Commands[0].Parameters.Add(new Parameter("@RATE_KIRIM", MySqlDbType.Float, obj.RATE_KIRIM));
                    db.Commands[0].Parameters.Add(new Parameter("@CHARGE_KIRIM", MySqlDbType.Float, obj.CHARGE_KIRIM));
                    db.Commands[0].Parameters.Add(new Parameter("@PPNPERCENT", MySqlDbType.Float, obj.PPNPERCENT));
                    db.Commands[0].Parameters.Add(new Parameter("@PPN", MySqlDbType.Float, obj.PPN));
                    db.Commands[0].Parameters.Add(new Parameter("@CHARGE_PACKING", MySqlDbType.Float, obj.CHARGE_PACKING));
                    db.Commands[0].Parameters.Add(new Parameter("@OTHER_CHARGE", MySqlDbType.Float, obj.OTHER_CHARGE));
                    db.Commands[0].Parameters.Add(new Parameter("@DISCPERCENT", MySqlDbType.Float, obj.DISCPERCENT));
                    db.Commands[0].Parameters.Add(new Parameter("@DISC", MySqlDbType.Float, obj.DISC));
                    db.Commands[0].Parameters.Add(new Parameter("@INSURANCE", MySqlDbType.Float, obj.INCURANCE));
                    db.Commands[0].Parameters.Add(new Parameter("@INCURANCEPERCENT", MySqlDbType.Float, obj.INCURANCEPERCENT));
                    db.Commands[0].Parameters.Add(new Parameter("@NBARANGINSURANCE", MySqlDbType.Float, obj.NBARANGINSURANCE));
                    db.Commands[0].Parameters.Add(new Parameter("@TGLPENGIRIMAN", MySqlDbType.VarChar, obj.TGLPENGIRIMAN));
                    db.Commands[0].Parameters.Add(new Parameter("@TGLPENGAMBILAN", MySqlDbType.VarChar, obj.TGLPENGAMBILAN));
                    db.Commands[0].Parameters.Add(new Parameter("@TOTAL", MySqlDbType.Float, obj.TOTAL));
                    db.Commands[0].Parameters.Add(new Parameter("@BAYAR", MySqlDbType.Float, obj.BAYAR));
                    db.Commands[0].Parameters.Add(new Parameter("@SISA", MySqlDbType.Float, obj.SISA));
                    db.Commands[0].Parameters.Add(new Parameter("@VOID", MySqlDbType.Float, obj.VOID));                                                                             
                    db.Commands[0].Parameters.Add(new Parameter("@UPDATED_BY", MySqlDbType.VarChar, "admin development"));
                   // db.Commands[0].Parameters.Add(new Parameter("@UPDATED_AT", MySqlDbType.VarChar, null));
                    
                    dt = db.Commands[0].ExecuteDataTable();
                
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void UPDATESETINVOICE(int _NOINV,string _NOCONNOTE)
        {
            try
            {
                using (Database db = new Database())
                {
                    DataTable dt = new DataTable();
                    db.Commands.Add(db.CreateCommand(QUERY_SETINVOICE));                    
                    db.Commands[0].Parameters.Add(new Parameter("@IDINVOICE", MySqlDbType.Int32, _NOINV));
                    db.Commands[0].Parameters.Add(new Parameter("@IDSTATUSSTT", MySqlDbType.Int32, 2));
                    db.Commands[0].Parameters.Add(new Parameter("@NOCONNOTE", MySqlDbType.VarChar, _NOCONNOTE));  
                    dt = db.Commands[0].ExecuteDataTable();
                     
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void DELETE(RMS.COMMON.EXPRESS.RMS_TRANSAKSI obj)
        {
            try
            {
                using (Database db = new Database())
                {
                    DataTable dt = new DataTable();
                    db.Commands.Add(db.CreateCommand(QUERY_DELETE));
                   
                    dt = db.Commands[0].ExecuteDataTable();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public DataTable SELECTAGENTBYID(RMS.COMMON.EXPRESS.RMS_TRANSAKSI obj)
        {
            DataTable dt = new DataTable();
            try
            {
                using (Database db = new Database())
                {
                    db.Commands.Add(db.CreateCommand(QUERY_SELECTAGENTBYID));
                    //db.Commands[0].Parameters.Add(new Parameter("@IDAGENT", MySqlDbType.Int32, obj.IDAGENT));
                    dt = db.Commands[0].ExecuteDataTable();
                }
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public DataTable SELECTIDSTT(RMS.COMMON.EXPRESS.RMS_TRANSAKSI obj)
        {
            DataTable dt = new DataTable();
            try
            {
                using (Database db = new Database())
                {
                    db.Commands.Add(db.CreateCommand(QUERY_SELECTIDSTT));
                   // db.Commands[0].Parameters.Add(new Parameter("@IDSTT", MySqlDbType.Int32, obj.ID));
                    dt = db.Commands[0].ExecuteDataTable();
                }
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public DataTable SELECTKODEIVOICE(RMS.COMMON.EXPRESS.RMS_TRANSAKSI obj)
        {
            DataTable dt = new DataTable();
            try
            {
                using (Database db = new Database())
                {
                    db.Commands.Add(db.CreateCommand(QUERY_SELECTKODEINVOICE));
                   // db.Commands[0].Parameters.Add(new Parameter("@KODEINVOICE", MySqlDbType.VarChar, obj.KODEIVOICE));
                    dt = db.Commands[0].ExecuteDataTable();
                }
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public DataTable SELECTPMBINV(RMS.COMMON.EXPRESS.RMS_TRANSAKSI obj)
        {
            DataTable dt = new DataTable();
            try
            {
                using (Database db = new Database())
                {
                    db.Commands.Add(db.CreateCommand(QUERY_SELECTPMBINV));
                   // db.Commands[0].Parameters.Add(new Parameter("@STARTDATE", MySqlDbType.Date, obj.STARTDATE));
                    //db.Commands[0].Parameters.Add(new Parameter("@ENDDATE", MySqlDbType.Date, obj.ENDDATE));                    
                    dt = db.Commands[0].ExecuteDataTable();
                }
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public DataTable SELECTPEMB(RMS.COMMON.EXPRESS.RMS_TRANSAKSI obj)
        {
            DataTable dt = new DataTable();
            try
            {
                using (Database db = new Database())
                {
                    /*
                    if (obj.STATUS == "SEMUA")
                    { 
                       db.Commands.Add(db.CreateCommand(QUERY_SELECTPMBALL)); }
                    else
                    {
                        db.Commands.Add(db.CreateCommand(QUERY_SELECTPMB));
                    }
                    db.Commands[0].Parameters.Add(new Parameter("@STARTDATE", MySqlDbType.Date, obj.STARTDATE));
                    db.Commands[0].Parameters.Add(new Parameter("@ENDDATE", MySqlDbType.Date, obj.ENDDATE));
                    db.Commands[0].Parameters.Add(new Parameter("@TPAYMENT", MySqlDbType.VarChar, obj.STATUSSTT));
                    db.Commands[0].Parameters.Add(new Parameter("@STATUS", MySqlDbType.VarChar, obj.STATUS));
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
        public DataTable SELECT(RMS.COMMON.EXPRESS.RMS_TRANSAKSI obj)
        {
            DataTable dt = new DataTable();
            try
            {
                
                using (Database db = new Database())
                {
                    if (obj.STATUSORDER != "SEMUA")
                    {
                        db.Commands.Add(db.CreateCommand(QUERY_SELECT));
                    }
                    else
                    {
                        db.Commands.Add(db.CreateCommand(QUERY_SELECTALL));
                    }
                    db.Commands[0].Parameters.Add(new Parameter("@STARTDATE", MySqlDbType.Date, obj.STARTDATE));
                    db.Commands[0].Parameters.Add(new Parameter("@ENDDATE", MySqlDbType.Date, obj.ENDDATE));
                    db.Commands[0].Parameters.Add(new Parameter("@STATUSORDER", MySqlDbType.VarChar, obj.STATUSORDER));
                   
                    dt = db.Commands[0].ExecuteDataTable();
                }
                 
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public DataTable SELECTGENERATEINVOICE(RMS.COMMON.EXPRESS.RMS_TRANSAKSI obj)
        {
            DataTable dt = new DataTable();
            try
            {
                /*
                using (Database db = new Database())
                {
                    
                    db.Commands.Add(db.CreateCommand(QUERY_SELECTGENEREATEINVOICE));                   
                    db.Commands[0].Parameters.Add(new Parameter("@STARTDATE", MySqlDbType.Date, obj.STARTDATE));
                    db.Commands[0].Parameters.Add(new Parameter("@ENDDATE", MySqlDbType.Date, obj.ENDDATE));
                    db.Commands[0].Parameters.Add(new Parameter("@TPAYMENT", MySqlDbType.VarChar, obj.STATUSSTT));
                    db.Commands[0].Parameters.Add(new Parameter("@CUSTOMER", MySqlDbType.VarChar, obj.NAMACUSTOMER));

                    dt = db.Commands[0].ExecuteDataTable();
                }
                 *  */
                return dt;
                
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public DataTable SELECTINVOICECETAK(RMS.COMMON.EXPRESS.RMS_TRANSAKSI obj)
        {
            DataTable dt = new DataTable();
            try
            {
                using (Database db = new Database())
                {

                    db.Commands.Add(db.CreateCommand(QUERY_SELECTINVOICECETAK));
                    /*
                    db.Commands[0].Parameters.Add(new Parameter("@STARTDATE", MySqlDbType.Date, obj.STARTDATE));
                    db.Commands[0].Parameters.Add(new Parameter("@ENDDATE", MySqlDbType.Date, obj.ENDDATE));
                    db.Commands[0].Parameters.Add(new Parameter("@TPAYMENT", MySqlDbType.VarChar, obj.STATUSSTT));
                    

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
        public DataTable SELECTLIKE(RMS.COMMON.EXPRESS.RMS_TRANSAKSI obj)
        {
            DataTable dt = new DataTable();
            try
            {
                using (Database db = new Database())
                {
                    
                    if (obj.STATUSORDER != "SEMUA")
                    {
                        db.Commands.Add(db.CreateCommand(QUERY_SELECTLIKE));
                    }
                    else
                    {
                        db.Commands.Add(db.CreateCommand(QUERY_SELECTLIKEALL));
                    }
                    /*                    
                    db.Commands[0].Parameters.Add(new Parameter("@STARTDATE", MySqlDbType.Date, obj.STARTDATE));
                    db.Commands[0].Parameters.Add(new Parameter("@ENDDATE", MySqlDbType.Date, obj.ENDDATE));
                    db.Commands[0].Parameters.Add(new Parameter("@TPAYMENT", MySqlDbType.VarChar, obj.STATUSSTT));
                    db.Commands[0].Parameters.Add(new Parameter("@CUSTOMER", MySqlDbType.VarChar, obj.NAMACUSTOMER));
                    db.Commands[0].Parameters.Add(new Parameter("@MARKETING", MySqlDbType.VarChar, obj.MARKETING));
                    db.Commands[0].Parameters.Add(new Parameter("@STATUS", MySqlDbType.VarChar, obj.STATUSPEMBAYARAN));
                    db.Commands[0].Parameters.Add(new Parameter("@SERVICE", MySqlDbType.VarChar, obj.SERVICE));
                    db.Commands[0].Parameters.Add(new Parameter("@ARMADA", MySqlDbType.VarChar, obj.ARMADA));
                    db.Commands[0].Parameters.Add(new Parameter("@DEST", MySqlDbType.VarChar, obj.NAMAKOTADEST));
                    */
                    dt = db.Commands[0].ExecuteDataTable();
                     
                }
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public DataTable SELECTINVOICE(RMS.COMMON.EXPRESS.RMS_TRANSAKSI obj)
        {
            DataTable dt = new DataTable();
            try
            {
                using (Database db = new Database())
                {
                    db.Commands.Add(db.CreateCommand(QUERY_SELECTINVOICE));
                    
                    //db.Commands[0].Parameters.Add(new Parameter("@KODEINVOICE", MySqlDbType.VarChar, obj.KODEIVOICE));
                    dt = db.Commands[0].ExecuteDataTable();
                }
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public DataTable SELECTFILTER(RMS.COMMON.EXPRESS.RMS_TRANSAKSI obj)
        {
            DataTable dt = new DataTable();
            try
            {
                using (Database db = new Database())
                {
                    db.Commands.Add(db.CreateCommand(QUERY_SELECTFILTER));
                    /*
                    db.Commands[0].Parameters.Add(new Parameter("@STARTDATE", MySqlDbType.Date, obj.STARTDATE));
                    db.Commands[0].Parameters.Add(new Parameter("@ENDDATE", MySqlDbType.Date, obj.ENDDATE));
                    db.Commands[0].Parameters.Add(new Parameter("@TYPEOFPAYMENT", MySqlDbType.VarChar, obj.STATUSSTT));
                    db.Commands[0].Parameters.Add(new Parameter("@KODECUSTOMER", MySqlDbType.VarChar, obj._KODECUSTOMER));
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
        public DataTable CARI_TYPEOFPAYMENT(string _TOP)
        {
            DataTable dt = new DataTable();
            try
            {
                using (Database db = new Database())
                {
                    db.Commands.Add(db.CreateCommand(QUERY_CARI_TYPEOFPAYMENT));
                    db.Commands[0].Parameters.Add(new Parameter("@TYPEOFPAYMENT", MySqlDbType.VarChar, _TOP.Trim()));
                    dt = db.Commands[0].ExecuteDataTable();
                }
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public DataTable CARI_BYKODE(RMS.COMMON.EXPRESS.RMS_TRANSAKSI obj)
        {
            DataTable dt = new DataTable();
            try
            {
                using (Database db = new Database())
                {
                    db.Commands.Add(db.CreateCommand(QUERY_CARI_BYKODE));
                  //  db.Commands[0].Parameters.Add(new Parameter("@NOCONNOTE", MySqlDbType.VarChar, obj.NOCONNOTE));
                    dt = db.Commands[0].ExecuteDataTable();
                }
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public DataTable CARI_BYID(RMS.COMMON.EXPRESS.RMS_TRANSAKSI obj)
        {
            DataTable dt = new DataTable();
            try
            {
                using (Database db = new Database())
                {
                    db.Commands.Add(db.CreateCommand(QUERY_CARI_BYID));
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
        public DataTable CARI_BYNAMA(RMS.COMMON.EXPRESS.RMS_TRANSAKSI obj)
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
        public DataTable SEARCH_BYKODE(RMS.COMMON.EXPRESS.RMS_TRANSAKSI obj)
        {
            DataTable dt = new DataTable();
            try
            {
                using (Database db = new Database())
                {
                    db.Commands.Add(db.CreateCommand(QUERY_SEARCH_BYKODE));
                   //db.Commands[0].Parameters.Add(new Parameter("@KODECUSTOMER", MySqlDbType.VarChar, obj._KODECUSTOMER));
                   //db.Commands[0].Parameters.Add(new Parameter("@STARTDATE", MySqlDbType.Date, obj.STARTDATE));
                   //db.Commands[0].Parameters.Add(new Parameter("@ENDDATE", MySqlDbType.Date, obj.ENDDATE));
                   //db.Commands[0].Parameters.Add(new Parameter("@TYPEOFPAYMENT", MySqlDbType.VarChar, obj.STATUSSTT));
                    dt = db.Commands[0].ExecuteDataTable();
                }
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public DataTable SEARCH_BYNAMA(RMS.COMMON.EXPRESS.RMS_TRANSAKSI obj)
        {
            DataTable dt = new DataTable();
            try
            {
                using (Database db = new Database())
                {
                    db.Commands.Add(db.CreateCommand(QUERY_SEARCH_BYNAME));
                    /*
                    db.Commands[0].Parameters.Add(new Parameter("@NAMACUSTOMER", MySqlDbType.VarChar, obj.NAMACUSTOMER));
                    db.Commands[0].Parameters.Add(new Parameter("@STARTDATE", MySqlDbType.Date, obj.STARTDATE));
                    db.Commands[0].Parameters.Add(new Parameter("@ENDDATE", MySqlDbType.Date, obj.ENDDATE));
                    db.Commands[0].Parameters.Add(new Parameter("@TYPEOFPAYMENT", MySqlDbType.VarChar, obj.STATUSSTT));
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

    }
}

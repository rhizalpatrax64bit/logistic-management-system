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
    public class RMS_DETAILINVOICE
    {
        Database db = new Database();

        protected string QUERY_GETKODE = "SELECT getResiNbrCargo()";
        protected string QUERY_SELECTAGENTBYID = "SELECT * IDAGENT,KODEAGENT,NAMAAGENT FROM V_AGENT WHERE IDAGENT = @IDAGENT";
        protected string QUERY_SELECTLIKE = "SELECT * FROM v_sttpembayaran WHERE (DATE BETWEEN @STARTDATE AND @ENDDATE) AND TPAYMENT=@TPAYMENT AND (CUSTOMER LIKE CONCAT('%',@CUSTOMER,'%') OR MARKETING LIKE CONCAT('%',@MARKETING,'%') OR STATUS LIKE CONCAT('%',@STATUS,'%') OR DEST LIKE CONCAT('%',@DEST,'%'))";
        protected string QUERY_SELECTLIKEALL = "SELECT * FROM v_sttpembayaran WHERE (DATE BETWEEN @STARTDATE AND @ENDDATE) AND (CUSTOMER LIKE CONCAT('%',@CUSTOMER,'%') OR MARKETING LIKE CONCAT('%',@MARKETING,'%') OR STATUS LIKE CONCAT('%',@STATUS,'%') OR SERVICE LIKE CONCAT('%',@SERVICE,'%') OR HANDLING LIKE CONCAT('%',@ARMADA,'%') OR DEST LIKE CONCAT('%',@DEST,'%'))";
        protected string QUERY_SELECT = "SELECT * FROM v_sttpembayaran WHERE (DATE BETWEEN @STARTDATE AND @ENDDATE) AND TPAYMENT=@TPAYMENT";
        protected string QUERY_SELECTGENEREATEINVOICE = "SELECT * FROM v_sttpembayaran WHERE (DATE BETWEEN @STARTDATE AND @ENDDATE) AND ISINVOICE=0 AND CUSTOMER =@CUSTOMER";
        protected string QUERY_SELECTINVOICECETAK = "SELECT * FROM v_sttpembayaran WHERE (DATE BETWEEN @STARTDATE AND @ENDDATE) AND ISINVOICE = 1 order by KODEINVOICE";

        protected string QUERY_SELECTALL = "SELECT * FROM v_sttpembayaran WHERE (DATE BETWEEN @STARTDATE AND @ENDDATE)";
       
        
        protected string QUERY_SELECTPMB = "SELECT * FROM V_STTPEMBAYARAN WHERE (DATE BETWEEN @STARTDATE AND @ENDDATE) AND STATUS = @STATUS";
        protected string QUERY_SELECTPMBALL = "SELECT * FROM V_STTPEMBAYARAN WHERE (DATE BETWEEN @STARTDATE AND @ENDDATE)";
        protected string QUERY_SELECTPMBINV = "SELECT * FROM V_STATUSINVOICE WHERE (TGLINVOICE BETWEEN @STARTDATE AND @ENDDATE)";
        protected string QUERY_SELECTPMBINVALL = "SELECT * FROM V_STATUSINVOICE WHERE (TGLINVOICE BETWEEN @STARTDATE AND @ENDDATE)";
        protected string QUERY_SELECTFILTER = "SELECT * FROM v_stt inner join invoice on v_stt.IDINVOICE = invoice.ID WHERE (v_stt.TGLCONNOTE BETWEEN @STARTDATE AND @ENDDATE) AND v_stt.TYPEOFPAYMENT=@TYPEOFPAYMENT AND v_stt.KODECUSTOMER = @KODECUSTOMER";
        protected string QUERY_SELECTINVOICE = "SELECT * FROM v_sttpembayaran where KODEINVOICE = @KODEINVOICE";
        protected string QUERY_SELECTIDSTT = "SELECT * FROM V_STTPEMBAYARAN WHERE ID =@IDSTT";
        protected string QUERY_SELECTKODEINVOICE = "SELECT * FROM V_STATUSINVOICE WHERE KODEINVOICE =@KODEINVOICE";
        protected string QUERY_CARI_TYPEOFPAYMENT = "SELECT * FROM v_stt WHERE TYPEOFPAYMENT=@TYPEOFPAYMENT";
        protected string QUERY_DELETE = "DELETE FROM SALES WHERE KODESALES=@KODESALES";
        protected string QUERY_CARI_BYID = "SELECT * FROM v_stt WHERE ID =@ID";
        protected string QUERY_CARI_BYKODE = "SELECT * FROM detailstt WHERE NOCONNOTE=@NOCONNOTE";
        protected string QUERY_CARI_BYNAME = "SELECT * FROM SALES WHERE KODESALES=@NAMASALES";
        protected string QUERY_SEARCH_BYKODE = "SELECT * FROM v_stt WHERE (TGLCONNOTE BETWEEN @STARTDATE AND @ENDDATE) AND TYPEOFPAYMENT=@TYPEOFPAYMENT AND KODECUSTOMER LIKE CONCAT('%',@KODECUSTOMER,'%')";
        protected string QUERY_SEARCH_BYNAME = "SELECT * FROM v_stt WHERE (TGLCONNOTE BETWEEN @STARTDATE AND @ENDDATE) AND TYPEOFPAYMENT=@TYPEOFPAYMENT AND NAMACUSTOMER LIKE CONCAT('%',@NAMACUSTOMER,'%')";
        protected string QUERY_INSERT = "CALL insertSTT(@_KODECUSTOMER,@NOCONNOTE,@TGLCONNOTE,@TGLMANIFEST,@NOACCOUNT,"+
                          "@NOREFERENSI,@CONSIGNEE,@PHONE,@FAX,@ALAMAT,@MARKETING,@IDSTATUSSTT,@IDSERVICE,@IDHANDLING,@NAMAKOTAORIGIN,"+
                          "@NAMAKOTADEST,@PCS,@WEIGHT,@WEIGHTDIM,@DIM_P,@DIM_L,@DIM_T,@RATE_KIRIM,@CHARGE_KIRIM,@CHARGE_DIM," +
                          "@PPN,@INSURANCE,@PACKING,@CHARGE_TERUSAN,@_KAGENT_SHIPPING,@_KAGENT_DELIVERY,@_KAGENT_WAREHOUSE,"+
                          "@_KOTATERUSAN,@_KAGENT_RA,@_KAGENT_TRUCKING,@_KAGENT_SMU,@NOSMU,@_KAGENT_GRDH,@COST_SHIPPING,@COST_DELIVERY,@COST_TRUCKING," +
                          "@COST_WAREHOUSE,@COST_RA,@COST_SMU,@COST_GRDH,@COST_FEEMARKETING,@COST_REFUNDCUST,@IDSTATUSBAYAR,@TOTAL_CHARGE,@TOTAL_COST,@TOTAL_PROFIT,@KETERANGANISI,@INSTRUKSIKHUSUS,"+
                          "@NBARANGINSURANCE,@PPNPERCENT,@INCURANCEPERCENT)";
        protected string QUERY_UPDATE = "CALL updateSTT(@ISINVOICE,@ID,@_KODECUSTOMER,@NOCONNOTE,@TGLCONNOTE,@TGLMANIFEST,@NOACCOUNT," +
                        "@NOREFERENSI,@CONSIGNEE,@PHONE,@FAX,@ALAMAT,@MARKETING,@IDSTATUSSTT,@IDSERVICE,@IDHANDLING,@NAMAKOTAORIGIN," +
                        "@NAMAKOTADEST,@PCS,@WEIGHT,@WEIGHTDIM,@DIM_P,@DIM_L,@DIM_T,@RATE_KIRIM,@CHARGE_KIRIM,@CHARGE_DIM," +
                        "@PPN,@INSURANCE,@PACKING,@CHARGE_TERUSAN,@_KAGENT_SHIPPING,@_KAGENT_DELIVERY,@_KAGENT_WAREHOUSE," +
                        "@_KOTATERUSAN,@_KAGENT_RA,@_KAGENT_TRUCKING,@_KAGENT_SMU,@NOSMU,@_KAGENT_GRDH,@COST_SHIPPING,@COST_DELIVERY,@COST_TRUCKING," +
                        "@COST_WAREHOUSE,@COST_RA,@COST_SMU,@COST_GRDH,@COST_FEEMARKETING,@COST_REFUNDCUST,@IDSTATUSBAYAR,@TOTAL_CHARGE,@TOTAL_COST,@TOTAL_PROFIT," +
                        "@NBARANGINSURANCE,@PPNPERCENT,@INCURANCEPERCENT)";
        
        protected string QUERY_SETINVOICE = "UPDATE detailstt SET IDINVOICE=@IDINVOICE,IDSTATUSSTT=@IDSTATUSSTT, ISINVOICE=1 WHERE NOCONNOTE =@NOCONNOTE";

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
        public void INSERT(RMS.COMMON.DELIVERYORDER.RMS_DETAILINVOICE obj)
        {
            try
            {
                using (Database db = new Database())
                {
                    DataTable dt = new DataTable();
                    
                    db.Commands.Add(db.CreateCommand(QUERY_INSERT));
                                   
                    db.Commands[0].Parameters.Add(new Parameter("@_KODECUSTOMER",MySqlDbType.VarChar, obj._KODECUSTOMER));
                    db.Commands[0].Parameters.Add(new Parameter("@NOCONNOTE",MySqlDbType.VarChar, obj.NOCONNOTE));
                    db.Commands[0].Parameters.Add(new Parameter("@TGLCONNOTE",MySqlDbType.VarChar,obj.TGLCONNOTE));
                    db.Commands[0].Parameters.Add(new Parameter("@TGLMANIFEST",MySqlDbType.VarChar,obj.TGLMANIFEST));
                    db.Commands[0].Parameters.Add(new Parameter("@NOACCOUNT",MySqlDbType.VarChar,obj.NOACCOUNT));
                    db.Commands[0].Parameters.Add(new Parameter("@NOREFERENSI",MySqlDbType.VarChar,obj.NOREFERENSI));
                    db.Commands[0].Parameters.Add(new Parameter("@CONSIGNEE",MySqlDbType.VarChar,obj.CONSIGNEE));
                    db.Commands[0].Parameters.Add(new Parameter("@PHONE",MySqlDbType.VarChar,obj.PHONE));
                    db.Commands[0].Parameters.Add(new Parameter("@FAX",MySqlDbType.VarChar,obj.FAX));
                    db.Commands[0].Parameters.Add(new Parameter("@ALAMAT",MySqlDbType.VarChar,obj.ALAMAT));
                    db.Commands[0].Parameters.Add(new Parameter("@MARKETING", MySqlDbType.VarChar, obj.MARKETING));
                    db.Commands[0].Parameters.Add(new Parameter("@IDSTATUSSTT",MySqlDbType.Int32,obj.IDSTATUSSTT));
                    db.Commands[0].Parameters.Add(new Parameter("@IDSERVICE",MySqlDbType.Int32,obj.IDSERVICE));
                    db.Commands[0].Parameters.Add(new Parameter("@IDHANDLING",MySqlDbType.Int32,obj.IDHANDLING));
                    db.Commands[0].Parameters.Add(new Parameter("@NAMAKOTAORIGIN",MySqlDbType.VarChar,obj.NAMAKOTAORIGIN));
                    db.Commands[0].Parameters.Add(new Parameter("@NAMAKOTADEST",MySqlDbType.VarChar,obj.NAMAKOTADEST));
                    db.Commands[0].Parameters.Add(new Parameter("@PCS",MySqlDbType.Int32,obj.PCS));
                    db.Commands[0].Parameters.Add(new Parameter("@WEIGHT",MySqlDbType.Float,obj.WEIGHT));
                    db.Commands[0].Parameters.Add(new Parameter("@WEIGHTDIM", MySqlDbType.Float, obj.WEIGHTDIM));
                    db.Commands[0].Parameters.Add(new Parameter("@DIM_P",MySqlDbType.Float,obj.DIM_P));
                    db.Commands[0].Parameters.Add(new Parameter("@DIM_L",MySqlDbType.Float,obj.DIM_L));
                    db.Commands[0].Parameters.Add(new Parameter("@DIM_T",MySqlDbType.Float,obj.DIM_T));
                    db.Commands[0].Parameters.Add(new Parameter("@RATE_KIRIM",MySqlDbType.Float,obj.RATE_KIRIM));
                    db.Commands[0].Parameters.Add(new Parameter("@CHARGE_KIRIM",MySqlDbType.Float,obj.CHARGE_KIRIM));
                    db.Commands[0].Parameters.Add(new Parameter("@CHARGE_DIM", MySqlDbType.Float, obj.CHARGE_DIM));
                    db.Commands[0].Parameters.Add(new Parameter("@PPN",MySqlDbType.Float,obj.PPN));
                    db.Commands[0].Parameters.Add(new Parameter("@INSURANCE",MySqlDbType.Float,obj.INSURANCE));
                    db.Commands[0].Parameters.Add(new Parameter("@PACKING",MySqlDbType.Float,obj.PACKING));
                    db.Commands[0].Parameters.Add(new Parameter("@CHARGE_TERUSAN",MySqlDbType.Float,obj.CHARGE_TERUSAN));
                    db.Commands[0].Parameters.Add(new Parameter("@_KAGENT_SHIPPING",MySqlDbType.VarChar,obj._KAGENT_SHIPPING));
                    db.Commands[0].Parameters.Add(new Parameter("@_KAGENT_DELIVERY",MySqlDbType.VarChar,obj._KAGENT_DELIVERY));
                    db.Commands[0].Parameters.Add(new Parameter("@_KAGENT_WAREHOUSE",MySqlDbType.VarChar,obj._KAGENT_WAREHOUSE));
                    db.Commands[0].Parameters.Add(new Parameter("@_KOTATERUSAN",MySqlDbType.VarChar,obj._KOTATERUSAN));
                    db.Commands[0].Parameters.Add(new Parameter("@_KAGENT_RA",MySqlDbType.VarChar,obj._KAGENT_RA));
                    db.Commands[0].Parameters.Add(new Parameter("@_KAGENT_TRUCKING",MySqlDbType.VarChar,obj._KAGENT_TRUCKING));
                    db.Commands[0].Parameters.Add(new Parameter("@_KAGENT_SMU",MySqlDbType.VarChar,obj._KAGENT_SMU));
                    db.Commands[0].Parameters.Add(new Parameter("@NOSMU", MySqlDbType.VarChar, obj.NOSMU));
                    db.Commands[0].Parameters.Add(new Parameter("@_KAGENT_GRDH",MySqlDbType.VarChar,obj._KAGENT_GRDH));
                    db.Commands[0].Parameters.Add(new Parameter("@COST_SHIPPING",MySqlDbType.Float,obj.COST_SHIPPING));
                    db.Commands[0].Parameters.Add(new Parameter("@COST_DELIVERY",MySqlDbType.Float,obj.COST_DELIVERY));
                    db.Commands[0].Parameters.Add(new Parameter("@COST_TRUCKING", MySqlDbType.Float, obj.COST_TRUCKING));
                    db.Commands[0].Parameters.Add(new Parameter("@COST_WAREHOUSE",MySqlDbType.Float,obj.COST_WAREHOUSE));
                    db.Commands[0].Parameters.Add(new Parameter("@COST_RA",MySqlDbType.Float,obj.COST_RA));
                    db.Commands[0].Parameters.Add(new Parameter("@COST_SMU",MySqlDbType.Float,obj.COST_SMU));
                    db.Commands[0].Parameters.Add(new Parameter("@COST_GRDH",MySqlDbType.Float,obj.COST_GRDH));
                    db.Commands[0].Parameters.Add(new Parameter("@COST_FEEMARKETING",MySqlDbType.Float,obj.COST_FEEMARKETING));
                    db.Commands[0].Parameters.Add(new Parameter("@COST_REFUNDCUST",MySqlDbType.Float,obj.COST_REFUNDCUST));
                    db.Commands[0].Parameters.Add(new Parameter("@IDSTATUSBAYAR",MySqlDbType.Int32,obj.IDSTATUSBAYAR));
                    db.Commands[0].Parameters.Add(new Parameter("@TOTAL_CHARGE",MySqlDbType.Float,obj.TOTAL_CHARGE));
                    db.Commands[0].Parameters.Add(new Parameter("@TOTAL_COST",MySqlDbType.Float,obj.TOTAL_COST));
                    db.Commands[0].Parameters.Add(new Parameter("@TOTAL_PROFIT", MySqlDbType.Float, obj.TOTAL_PROFIT));
                    db.Commands[0].Parameters.Add(new Parameter("@NBARANGINSURANCE", MySqlDbType.Int32, obj.NBARANGINSURANCE));
                    db.Commands[0].Parameters.Add(new Parameter("@PPNPERCENT", MySqlDbType.Float, obj.PPNPERCENT));
                    db.Commands[0].Parameters.Add(new Parameter("@INCURANCEPERCENT", MySqlDbType.Float, obj.INCURANCEPERCENT ));

                    db.Commands[0].Parameters.Add(new Parameter("@KETERANGANISI", MySqlDbType.VarChar, obj.KETERANGANISI));
                    db.Commands[0].Parameters.Add(new Parameter("@INSTRUKSIKHUSUS", MySqlDbType.VarChar, obj.INSTRUKSIKHUSUS));

//                    db.Commands[0].Parameters.Add(new Parameter("@IDMARKETING", MySqlDbType.Float, obj.IDMARKETING));

                    dt = db.Commands[0].ExecuteDataTable();
                
                 }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void UPDATE(RMS.COMMON.DELIVERYORDER.RMS_DETAILINVOICE obj)
        {
            try
            {
                using (Database db = new Database())
                {
                    DataTable dt = new DataTable();
                    db.Commands.Add(db.CreateCommand(QUERY_UPDATE));
                    db.Commands[0].Parameters.Add(new Parameter("@ID", MySqlDbType.Int32, obj.ID));
                    db.Commands[0].Parameters.Add(new Parameter("@_KODECUSTOMER",MySqlDbType.VarChar, obj._KODECUSTOMER));
                    db.Commands[0].Parameters.Add(new Parameter("@NOCONNOTE",MySqlDbType.VarChar, obj.NOCONNOTE));
                    db.Commands[0].Parameters.Add(new Parameter("@TGLCONNOTE",MySqlDbType.VarChar,obj.TGLCONNOTE));
                    db.Commands[0].Parameters.Add(new Parameter("@TGLMANIFEST",MySqlDbType.VarChar,obj.TGLMANIFEST));
                    db.Commands[0].Parameters.Add(new Parameter("@NOACCOUNT",MySqlDbType.VarChar,obj.NOACCOUNT));
                    db.Commands[0].Parameters.Add(new Parameter("@NOREFERENSI",MySqlDbType.VarChar,obj.NOREFERENSI));
                    db.Commands[0].Parameters.Add(new Parameter("@CONSIGNEE",MySqlDbType.VarChar,obj.CONSIGNEE));
                    db.Commands[0].Parameters.Add(new Parameter("@PHONE",MySqlDbType.VarChar,obj.PHONE));
                    db.Commands[0].Parameters.Add(new Parameter("@FAX",MySqlDbType.VarChar,obj.FAX));
                    db.Commands[0].Parameters.Add(new Parameter("@ALAMAT",MySqlDbType.VarChar,obj.ALAMAT));
                    db.Commands[0].Parameters.Add(new Parameter("@MARKETING", MySqlDbType.VarChar, obj.MARKETING));
                    db.Commands[0].Parameters.Add(new Parameter("@IDSTATUSSTT",MySqlDbType.Int32,obj.IDSTATUSSTT));
                    db.Commands[0].Parameters.Add(new Parameter("@IDSERVICE",MySqlDbType.Int32,obj.IDSERVICE));
                    db.Commands[0].Parameters.Add(new Parameter("@IDHANDLING",MySqlDbType.Int32,obj.IDHANDLING));
                    db.Commands[0].Parameters.Add(new Parameter("@NAMAKOTAORIGIN",MySqlDbType.VarChar,obj.NAMAKOTAORIGIN));
                    db.Commands[0].Parameters.Add(new Parameter("@NAMAKOTADEST",MySqlDbType.VarChar,obj.NAMAKOTADEST));
                    db.Commands[0].Parameters.Add(new Parameter("@PCS",MySqlDbType.Int32,obj.PCS));
                    db.Commands[0].Parameters.Add(new Parameter("@WEIGHT",MySqlDbType.Float,obj.WEIGHT));
                    db.Commands[0].Parameters.Add(new Parameter("@WEIGHTDIM", MySqlDbType.Float, obj.WEIGHTDIM));
                    db.Commands[0].Parameters.Add(new Parameter("@DIM_P",MySqlDbType.Float,obj.DIM_P));
                    db.Commands[0].Parameters.Add(new Parameter("@DIM_L",MySqlDbType.Float,obj.DIM_L));
                    db.Commands[0].Parameters.Add(new Parameter("@DIM_T",MySqlDbType.Float,obj.DIM_T));
                    db.Commands[0].Parameters.Add(new Parameter("@RATE_KIRIM",MySqlDbType.Float,obj.RATE_KIRIM));
                    db.Commands[0].Parameters.Add(new Parameter("@CHARGE_KIRIM",MySqlDbType.Float,obj.CHARGE_KIRIM));
                    db.Commands[0].Parameters.Add(new Parameter("@CHARGE_DIM", MySqlDbType.Float, obj.CHARGE_DIM));
                    db.Commands[0].Parameters.Add(new Parameter("@PPN",MySqlDbType.Float,obj.PPN));
                    db.Commands[0].Parameters.Add(new Parameter("@INSURANCE",MySqlDbType.Float,obj.INSURANCE));
                    db.Commands[0].Parameters.Add(new Parameter("@PACKING",MySqlDbType.Float,obj.PACKING));
                    db.Commands[0].Parameters.Add(new Parameter("@CHARGE_TERUSAN",MySqlDbType.Float,obj.CHARGE_TERUSAN));
                    db.Commands[0].Parameters.Add(new Parameter("@_KAGENT_SHIPPING",MySqlDbType.VarChar,obj._KAGENT_SHIPPING));
                    db.Commands[0].Parameters.Add(new Parameter("@_KAGENT_DELIVERY",MySqlDbType.VarChar,obj._KAGENT_DELIVERY));
                    db.Commands[0].Parameters.Add(new Parameter("@_KAGENT_WAREHOUSE",MySqlDbType.VarChar,obj._KAGENT_WAREHOUSE));
                    db.Commands[0].Parameters.Add(new Parameter("@_KOTATERUSAN",MySqlDbType.VarChar,obj._KOTATERUSAN));
                    db.Commands[0].Parameters.Add(new Parameter("@_KAGENT_RA",MySqlDbType.VarChar,obj._KAGENT_RA));
                    db.Commands[0].Parameters.Add(new Parameter("@_KAGENT_TRUCKING",MySqlDbType.VarChar,obj._KAGENT_TRUCKING));
                    db.Commands[0].Parameters.Add(new Parameter("@_KAGENT_SMU",MySqlDbType.VarChar,obj._KAGENT_SMU));
                    db.Commands[0].Parameters.Add(new Parameter("@NOSMU", MySqlDbType.VarChar, obj.NOSMU));
                    db.Commands[0].Parameters.Add(new Parameter("@_KAGENT_GRDH",MySqlDbType.VarChar,obj._KAGENT_GRDH));
                    db.Commands[0].Parameters.Add(new Parameter("@COST_SHIPPING",MySqlDbType.Float,obj.COST_SHIPPING));
                    db.Commands[0].Parameters.Add(new Parameter("@COST_DELIVERY",MySqlDbType.Float,obj.COST_DELIVERY));
                    db.Commands[0].Parameters.Add(new Parameter("@COST_TRUCKING", MySqlDbType.Float, obj.COST_TRUCKING));
                    db.Commands[0].Parameters.Add(new Parameter("@COST_WAREHOUSE",MySqlDbType.Float,obj.COST_WAREHOUSE));
                    db.Commands[0].Parameters.Add(new Parameter("@COST_RA",MySqlDbType.Float,obj.COST_RA));
                    db.Commands[0].Parameters.Add(new Parameter("@COST_SMU",MySqlDbType.Float,obj.COST_SMU));
                    db.Commands[0].Parameters.Add(new Parameter("@COST_GRDH",MySqlDbType.Float,obj.COST_GRDH));
                    db.Commands[0].Parameters.Add(new Parameter("@COST_FEEMARKETING",MySqlDbType.Float,obj.COST_FEEMARKETING));
                    db.Commands[0].Parameters.Add(new Parameter("@COST_REFUNDCUST",MySqlDbType.Float,obj.COST_REFUNDCUST));
                    db.Commands[0].Parameters.Add(new Parameter("@IDSTATUSBAYAR",MySqlDbType.Int32,obj.IDSTATUSBAYAR));
                    db.Commands[0].Parameters.Add(new Parameter("@TOTAL_CHARGE",MySqlDbType.Float,obj.TOTAL_CHARGE));
                    db.Commands[0].Parameters.Add(new Parameter("@TOTAL_COST",MySqlDbType.Float,obj.TOTAL_COST));
                    db.Commands[0].Parameters.Add(new Parameter("@TOTAL_PROFIT", MySqlDbType.Float, obj.TOTAL_PROFIT));
                    db.Commands[0].Parameters.Add(new Parameter("@NBARANGINSURANCE", MySqlDbType.Int32, obj.NBARANGINSURANCE));
                    db.Commands[0].Parameters.Add(new Parameter("@PPNPERCENT", MySqlDbType.Float, obj.PPNPERCENT));
                    db.Commands[0].Parameters.Add(new Parameter("@INCURANCEPERCENT", MySqlDbType.Float, obj.INCURANCEPERCENT));
                    db.Commands[0].Parameters.Add(new Parameter("@ISINVOICE", MySqlDbType.Int32, obj.ISINVOICE));
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
        public void DELETE(RMS.COMMON.DELIVERYORDER.RMS_DETAILINVOICE obj)
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
        public DataTable SELECTAGENTBYID(RMS.COMMON.DELIVERYORDER.RMS_DETAILINVOICE obj)
        {
            DataTable dt = new DataTable();
            try
            {
                using (Database db = new Database())
                {
                    db.Commands.Add(db.CreateCommand(QUERY_SELECTAGENTBYID));
                    db.Commands[0].Parameters.Add(new Parameter("@IDAGENT", MySqlDbType.Int32, obj.IDAGENT));
                    dt = db.Commands[0].ExecuteDataTable();
                }
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public DataTable SELECTIDSTT(RMS.COMMON.DELIVERYORDER.RMS_DETAILINVOICE obj)
        {
            DataTable dt = new DataTable();
            try
            {
                using (Database db = new Database())
                {
                    db.Commands.Add(db.CreateCommand(QUERY_SELECTIDSTT));
                    db.Commands[0].Parameters.Add(new Parameter("@IDSTT", MySqlDbType.Int32, obj.ID));
                    dt = db.Commands[0].ExecuteDataTable();
                }
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public DataTable SELECTKODEIVOICE(RMS.COMMON.DELIVERYORDER.RMS_DETAILINVOICE obj)
        {
            DataTable dt = new DataTable();
            try
            {
                using (Database db = new Database())
                {
                    db.Commands.Add(db.CreateCommand(QUERY_SELECTKODEINVOICE));
                    db.Commands[0].Parameters.Add(new Parameter("@KODEINVOICE", MySqlDbType.VarChar, obj.KODEIVOICE));
                    dt = db.Commands[0].ExecuteDataTable();
                }
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public DataTable SELECTPMBINV(RMS.COMMON.DELIVERYORDER.RMS_DETAILINVOICE obj)
        {
            DataTable dt = new DataTable();
            try
            {
                using (Database db = new Database())
                {
                    db.Commands.Add(db.CreateCommand(QUERY_SELECTPMBINV));
                    db.Commands[0].Parameters.Add(new Parameter("@STARTDATE", MySqlDbType.Date, obj.STARTDATE));
                    db.Commands[0].Parameters.Add(new Parameter("@ENDDATE", MySqlDbType.Date, obj.ENDDATE));                    
                    dt = db.Commands[0].ExecuteDataTable();
                }
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public DataTable SELECTPEMB(RMS.COMMON.DELIVERYORDER.RMS_DETAILINVOICE obj)
        {
            DataTable dt = new DataTable();
            try
            {
                using (Database db = new Database())
                {
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
                }
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public DataTable SELECT(RMS.COMMON.DELIVERYORDER.RMS_DETAILINVOICE obj)
        {
            DataTable dt = new DataTable();
            try
            {
                using (Database db = new Database())
                {
                    if (obj.STATUSSTT != "SEMUA")
                    {
                        db.Commands.Add(db.CreateCommand(QUERY_SELECT));
                    }
                    else
                    {
                        db.Commands.Add(db.CreateCommand(QUERY_SELECTALL));
                    }
                    db.Commands[0].Parameters.Add(new Parameter("@STARTDATE", MySqlDbType.Date, obj.STARTDATE));
                    db.Commands[0].Parameters.Add(new Parameter("@ENDDATE", MySqlDbType.Date, obj.ENDDATE));
                    db.Commands[0].Parameters.Add(new Parameter("@TPAYMENT", MySqlDbType.VarChar, obj.STATUSSTT));
                   
                    dt = db.Commands[0].ExecuteDataTable();
                }
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public DataTable SELECTGENERATEINVOICE(RMS.COMMON.DELIVERYORDER.RMS_DETAILINVOICE obj)
        {
            DataTable dt = new DataTable();
            try
            {
                using (Database db = new Database())
                {
                    
                    db.Commands.Add(db.CreateCommand(QUERY_SELECTGENEREATEINVOICE));                   
                    db.Commands[0].Parameters.Add(new Parameter("@STARTDATE", MySqlDbType.Date, obj.STARTDATE));
                    db.Commands[0].Parameters.Add(new Parameter("@ENDDATE", MySqlDbType.Date, obj.ENDDATE));
                    db.Commands[0].Parameters.Add(new Parameter("@TPAYMENT", MySqlDbType.VarChar, obj.STATUSSTT));
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
        public DataTable SELECTINVOICECETAK(RMS.COMMON.DELIVERYORDER.RMS_DETAILINVOICE obj)
        {
            DataTable dt = new DataTable();
            try
            {
                using (Database db = new Database())
                {

                    db.Commands.Add(db.CreateCommand(QUERY_SELECTINVOICECETAK));
                    db.Commands[0].Parameters.Add(new Parameter("@STARTDATE", MySqlDbType.Date, obj.STARTDATE));
                    db.Commands[0].Parameters.Add(new Parameter("@ENDDATE", MySqlDbType.Date, obj.ENDDATE));
                    db.Commands[0].Parameters.Add(new Parameter("@TPAYMENT", MySqlDbType.VarChar, obj.STATUSSTT));
                    

                    dt = db.Commands[0].ExecuteDataTable();
                }
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public DataTable SELECTLIKE(RMS.COMMON.DELIVERYORDER.RMS_DETAILINVOICE obj)
        {
            DataTable dt = new DataTable();
            try
            {
                using (Database db = new Database())
                {
                    if (obj.STATUSSTT != "SEMUA")
                    {
                        db.Commands.Add(db.CreateCommand(QUERY_SELECTLIKE));
                    }
                    else
                    {
                        db.Commands.Add(db.CreateCommand(QUERY_SELECTLIKEALL));
                    }
                                        
                    db.Commands[0].Parameters.Add(new Parameter("@STARTDATE", MySqlDbType.Date, obj.STARTDATE));
                    db.Commands[0].Parameters.Add(new Parameter("@ENDDATE", MySqlDbType.Date, obj.ENDDATE));
                    db.Commands[0].Parameters.Add(new Parameter("@TPAYMENT", MySqlDbType.VarChar, obj.STATUSSTT));
                    db.Commands[0].Parameters.Add(new Parameter("@CUSTOMER", MySqlDbType.VarChar, obj.NAMACUSTOMER));
                    db.Commands[0].Parameters.Add(new Parameter("@MARKETING", MySqlDbType.VarChar, obj.MARKETING));
                    db.Commands[0].Parameters.Add(new Parameter("@STATUS", MySqlDbType.VarChar, obj.STATUSPEMBAYARAN));
                    db.Commands[0].Parameters.Add(new Parameter("@SERVICE", MySqlDbType.VarChar, obj.SERVICE));
                    db.Commands[0].Parameters.Add(new Parameter("@ARMADA", MySqlDbType.VarChar, obj.ARMADA));
                    db.Commands[0].Parameters.Add(new Parameter("@DEST", MySqlDbType.VarChar, obj.NAMAKOTADEST));
                    dt = db.Commands[0].ExecuteDataTable();
                }
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public DataTable SELECTINVOICE(RMS.COMMON.DELIVERYORDER.RMS_DETAILINVOICE obj)
        {
            DataTable dt = new DataTable();
            try
            {
                using (Database db = new Database())
                {
                    db.Commands.Add(db.CreateCommand(QUERY_SELECTINVOICE));
                    
                    db.Commands[0].Parameters.Add(new Parameter("@KODEINVOICE", MySqlDbType.VarChar, obj.KODEIVOICE));
                    dt = db.Commands[0].ExecuteDataTable();
                }
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public DataTable SELECTFILTER(RMS.COMMON.DELIVERYORDER.RMS_DETAILINVOICE obj)
        {
            DataTable dt = new DataTable();
            try
            {
                using (Database db = new Database())
                {
                    db.Commands.Add(db.CreateCommand(QUERY_SELECTFILTER));
                    db.Commands[0].Parameters.Add(new Parameter("@STARTDATE", MySqlDbType.Date, obj.STARTDATE));
                    db.Commands[0].Parameters.Add(new Parameter("@ENDDATE", MySqlDbType.Date, obj.ENDDATE));
                    db.Commands[0].Parameters.Add(new Parameter("@TYPEOFPAYMENT", MySqlDbType.VarChar, obj.STATUSSTT));
                    db.Commands[0].Parameters.Add(new Parameter("@KODECUSTOMER", MySqlDbType.VarChar, obj._KODECUSTOMER));
                    dt = db.Commands[0].ExecuteDataTable();
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
        public DataTable CARI_BYKODE(RMS.COMMON.DELIVERYORDER.RMS_DETAILINVOICE obj)
        {
            DataTable dt = new DataTable();
            try
            {
                using (Database db = new Database())
                {
                    db.Commands.Add(db.CreateCommand(QUERY_CARI_BYKODE));
                    db.Commands[0].Parameters.Add(new Parameter("@NOCONNOTE", MySqlDbType.VarChar, obj.NOCONNOTE));
                    dt = db.Commands[0].ExecuteDataTable();
                }
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public DataTable CARI_BYID(RMS.COMMON.DELIVERYORDER.RMS_DETAILINVOICE obj)
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
        public DataTable CARI_BYNAMA(RMS.COMMON.DELIVERYORDER.RMS_DETAILINVOICE obj)
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
        public DataTable SEARCH_BYKODE(RMS.COMMON.DELIVERYORDER.RMS_DETAILINVOICE obj)
        {
            DataTable dt = new DataTable();
            try
            {
                using (Database db = new Database())
                {
                    db.Commands.Add(db.CreateCommand(QUERY_SEARCH_BYKODE));
                    db.Commands[0].Parameters.Add(new Parameter("@KODECUSTOMER", MySqlDbType.VarChar, obj._KODECUSTOMER));
                    db.Commands[0].Parameters.Add(new Parameter("@STARTDATE", MySqlDbType.Date, obj.STARTDATE));
                    db.Commands[0].Parameters.Add(new Parameter("@ENDDATE", MySqlDbType.Date, obj.ENDDATE));
                    db.Commands[0].Parameters.Add(new Parameter("@TYPEOFPAYMENT", MySqlDbType.VarChar, obj.STATUSSTT));
                    dt = db.Commands[0].ExecuteDataTable();
                }
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public DataTable SEARCH_BYNAMA(RMS.COMMON.DELIVERYORDER.RMS_DETAILINVOICE obj)
        {
            DataTable dt = new DataTable();
            try
            {
                using (Database db = new Database())
                {
                    db.Commands.Add(db.CreateCommand(QUERY_SEARCH_BYNAME));
                    db.Commands[0].Parameters.Add(new Parameter("@NAMACUSTOMER", MySqlDbType.VarChar, obj.NAMACUSTOMER));
                    db.Commands[0].Parameters.Add(new Parameter("@STARTDATE", MySqlDbType.Date, obj.STARTDATE));
                    db.Commands[0].Parameters.Add(new Parameter("@ENDDATE", MySqlDbType.Date, obj.ENDDATE));
                    db.Commands[0].Parameters.Add(new Parameter("@TYPEOFPAYMENT", MySqlDbType.VarChar, obj.STATUSSTT));
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

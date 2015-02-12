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
    public class RMS_SPJ
    {
        Database db = new Database();

        protected string QUERY_GETKODE = "SELECT getSpjNbr()";
        protected string QUERY_SELECTAGENTBYID = "SELECT * IDAGENT,KODEAGENT,NAMAAGENT FROM V_AGENT WHERE IDAGENT = @IDAGENT";
        protected string QUERY_SELECTLIKE = "SELECT * FROM v_sttpembayaran WHERE (DATE BETWEEN @STARTDATE AND @ENDDATE) AND TPAYMENT=@TPAYMENT AND (CUSTOMER LIKE CONCAT('%',@CUSTOMER,'%') OR MARKETING LIKE CONCAT('%',@MARKETING,'%') OR STATUS LIKE CONCAT('%',@STATUS,'%') OR DEST LIKE CONCAT('%',@DEST,'%'))";
        protected string QUERY_SELECTLIKEALL = "SELECT * FROM v_sttpembayaran WHERE (DATE BETWEEN @STARTDATE AND @ENDDATE) AND (CUSTOMER LIKE CONCAT('%',@CUSTOMER,'%') OR MARKETING LIKE CONCAT('%',@MARKETING,'%') OR STATUS LIKE CONCAT('%',@STATUS,'%') OR SERVICE LIKE CONCAT('%',@SERVICE,'%') OR HANDLING LIKE CONCAT('%',@ARMADA,'%') OR DEST LIKE CONCAT('%',@DEST,'%'))";
        protected string QUERY_SELECT = "SELECT * FROM v_transaksi_express WHERE (TGLTERIMA BETWEEN @STARTDATE AND @ENDDATE) AND STATUS=@STATUSORDER ORDER BY TGLTERIMA desc";
        protected string QUERY_SELECTGENEREATEINVOICE = "SELECT * FROM v_sttpembayaran WHERE (DATE BETWEEN @STARTDATE AND @ENDDATE) AND STATUS=@STATUSORDER AND NAMACUSTOMER =@CUSTOMER";
        protected string QUERY_SELECTINVOICECETAK = "SELECT * FROM v_sttpembayaran WHERE (DATE BETWEEN @STARTDATE AND @ENDDATE) AND TPAYMENT=@TPAYMENT GROUP BY CUSTOMER";
        protected string QUERY_SELECTALL = "SELECT * FROM v_spj WHERE (TGLPENGIRIMAN BETWEEN @STARTDATE AND @ENDDATE) ORDER BY TGLPENGIRIMAN desc";
        protected string QUERY_SELECTFILTERSPJ = "SELECT * FROM v_spj WHERE (TGLPENGIRIMAN BETWEEN @STARTDATE AND @ENDDATE) AND (NOSPJ LIKE CONCAT('%',@NOSPJ,'%') OR NOPOL LIKE CONCAT('%',@NOPOL,'%'))";
        protected string QUERY_SELECTRESI = "SELECT * FROM v_spjdetail WHERE NOSPJ =@NOSPJ";      
        
        protected string QUERY_SELECTPMB = "SELECT * FROM V_STTPEMBAYARAN WHERE (DATE BETWEEN @STARTDATE AND @ENDDATE) AND TPAYMENT=@TPAYMENT AND STATUS = @STATUS";
        protected string QUERY_SELECTPMBALL = "SELECT * FROM V_STTPEMBAYARAN WHERE (DATE BETWEEN @STARTDATE AND @ENDDATE) AND TPAYMENT=@TPAYMENT";
        protected string QUERY_SELECTPMBINV = "SELECT * FROM V_STATUSINVOICE WHERE (TGLINVOICE BETWEEN @STARTDATE AND @ENDDATE)";
        protected string QUERY_SELECTPMBINVALL = "SELECT * FROM V_STATUSINVOICE WHERE (TGLINVOICE BETWEEN @STARTDATE AND @ENDDATE)";
        protected string QUERY_SELECTFILTER = "SELECT * FROM v_stt inner join invoice on v_stt.IDINVOICE = invoice.ID WHERE (v_stt.TGLCONNOTE BETWEEN @STARTDATE AND @ENDDATE) AND v_stt.TYPEOFPAYMENT=@TYPEOFPAYMENT AND v_stt.KODECUSTOMER = @KODECUSTOMER";
        protected string QUERY_SELECTINVOICE = "SELECT * FROM v_sttpembayaran where KODEINVOICE = @KODEINVOICE";
        protected string QUERY_SELECTIDSTT = "SELECT * FROM V_STTPEMBAYARAN WHERE ID =@IDSTT";
        protected string QUERY_SELECTKODEINVOICE = "SELECT * FROM V_STATUSINVOICE WHERE KODEINVOICE =@KODEINVOICE";
        protected string QUERY_CARI_TYPEOFPAYMENT = "SELECT * FROM v_stt WHERE TYPEOFPAYMENT=@TYPEOFPAYMENT";
        protected string QUERY_DELETE = "UPDATE spjdetail_express SET ISACTIVE = 0 WHERE ID = @IDDETAIL";
        protected string QUERY_CARI_BYID = "SELECT * FROM v_spj WHERE ID =@ID";
        protected string QUERY_CARI_BYNORESI = "SELECT noresi,status FROM transaksi_express WHERE NORESI =@NORESI";
        protected string QUERY_CARI_BYKODE = "SELECT * FROM detailstt WHERE NOCONNOTE=@NOCONNOTE";
        protected string QUERY_CARI_BYNAME = "SELECT * FROM SALES WHERE KODESALES=@NAMASALES";
        protected string QUERY_SEARCH_BYKODE = "SELECT * FROM v_stt WHERE (TGLCONNOTE BETWEEN @STARTDATE AND @ENDDATE) AND TYPEOFPAYMENT=@TYPEOFPAYMENT AND KODECUSTOMER LIKE CONCAT('%',@KODECUSTOMER,'%')";
        protected string QUERY_SEARCH_BYNAME = "SELECT * FROM v_stt WHERE (TGLCONNOTE BETWEEN @STARTDATE AND @ENDDATE) AND TYPEOFPAYMENT=@TYPEOFPAYMENT AND NAMACUSTOMER LIKE CONCAT('%',@NAMACUSTOMER,'%')";
        protected string QUERY_INSERT = "INSERT INTO spj_express value ('',@NOSPJ,@IDKENDARAAN,@IDDRIVER,@IDCODRIVER,@TGLPENGIRIMAN,@CREATED_BY,CURRENT_DATE(),@UPDATED_BY,@UPDATED_AT)";
        protected string QUERY_INSERTRESI = "INSERT INTO spjdetail_express value ('',@NORESI,@NOSPJ,ISACTIVE=1)";

        protected string QUERY_UPDATE = "UPDATE spj_express set IDKENDARAAN=@IDKENDARAAN,IDDRIVER=@IDDRIVER,IDCODRIVER=@IDCODRIVER,TGLPENGIRIMAN=@TGLPENGIRIMAN WHERE NOSPJ =@NOSPJ";
        protected string QUERY_UPDATESTATUSPENGIRIMAN = "UPDATE transaksi_express set STATUS =@STATUS WHERE NORESI=@NORESI";
        
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
        public void INSERT(RMS.COMMON.EXPRESS.RMS_SPJ obj)
        {
            try
            {
                using (Database db = new Database())
                {
                    DataTable dt = new DataTable();
                    
                    db.Commands.Add(db.CreateCommand(QUERY_INSERT));
                    db.Commands[0].Parameters.Add(new Parameter("@NOSPJ", MySqlDbType.VarChar, obj.NOSPJ));
                    db.Commands[0].Parameters.Add(new Parameter("@IDKENDARAAN", MySqlDbType.Int32, obj.IDKENDARAAN));
                    if (obj.IDDRIVER != 0)
                    {
                        db.Commands[0].Parameters.Add(new Parameter("@IDDRIVER", MySqlDbType.Int32, obj.IDDRIVER));
                    }
                    else { 
                        db.Commands[0].Parameters.Add(new Parameter("@IDDRIVER", MySqlDbType.Int32, null)); 
                    }
                    if (obj.IDCODRIVER != 0)
                    {
                        db.Commands[0].Parameters.Add(new Parameter("@IDCODRIVER", MySqlDbType.Int32, obj.IDCODRIVER));
                    }
                    else
                    {
                        db.Commands[0].Parameters.Add(new Parameter("@IDCODRIVER", MySqlDbType.Int32, null));
                    }
                    db.Commands[0].Parameters.Add(new Parameter("@TGLPENGIRIMAN", MySqlDbType.VarChar, obj.TGLPENGIRIMAN));
                    db.Commands[0].Parameters.Add(new Parameter("@CREATED_BY", MySqlDbType.VarChar, "admin development"));
                    db.Commands[0].Parameters.Add(new Parameter("@CREATED_AT", MySqlDbType.VarChar, null));
                    db.Commands[0].Parameters.Add(new Parameter("@UPDATED_BY", MySqlDbType.VarChar, null));
                    db.Commands[0].Parameters.Add(new Parameter("@UPDATED_AT", MySqlDbType.VarChar, null));
                    dt = db.Commands[0].ExecuteDataTable();
                   
                
                 }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void INSERTRESI(RMS.COMMON.EXPRESS.RMS_SPJ obj)
        {
            try
            {
                using (Database db = new Database())
                {
                    DataTable dt = new DataTable();

                    db.Commands.Add(db.CreateCommand(QUERY_INSERTRESI));
                    db.Commands[0].Parameters.Add(new Parameter("@NOSPJ", MySqlDbType.VarChar, obj.NOSPJ));
                    db.Commands[0].Parameters.Add(new Parameter("@NORESI", MySqlDbType.VarChar, obj.NORESI));
                 
                    dt = db.Commands[0].ExecuteDataTable();


                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void UPDATE(RMS.COMMON.EXPRESS.RMS_SPJ obj)
        {
            try
            {
                using (Database db = new Database())
                {
                    DataTable dt = new DataTable();

                    db.Commands.Add(db.CreateCommand(QUERY_UPDATE));
                    db.Commands[0].Parameters.Add(new Parameter("@NOSPJ", MySqlDbType.VarChar, obj.NOSPJ));
                    db.Commands[0].Parameters.Add(new Parameter("@IDKENDARAAN", MySqlDbType.Int32, obj.IDKENDARAAN));
                    if (obj.IDDRIVER != 0)
                    {
                        db.Commands[0].Parameters.Add(new Parameter("@IDDRIVER", MySqlDbType.Int32, obj.IDDRIVER));
                    }
                    else
                    {
                        db.Commands[0].Parameters.Add(new Parameter("@IDDRIVER", MySqlDbType.Int32, null));
                    }
                    if (obj.IDCODRIVER != 0)
                    {
                        db.Commands[0].Parameters.Add(new Parameter("@IDCODRIVER", MySqlDbType.Int32, obj.IDCODRIVER));
                    }
                    else
                    {
                        db.Commands[0].Parameters.Add(new Parameter("@IDCODRIVER", MySqlDbType.Int32, null));
                    }
                    db.Commands[0].Parameters.Add(new Parameter("@TGLPENGIRIMAN", MySqlDbType.VarChar, obj.TGLPENGIRIMAN));
                    db.Commands[0].Parameters.Add(new Parameter("@CREATED_BY", MySqlDbType.VarChar, "admin development"));
                    db.Commands[0].Parameters.Add(new Parameter("@CREATED_AT", MySqlDbType.VarChar, null));
                    db.Commands[0].Parameters.Add(new Parameter("@UPDATED_BY", MySqlDbType.VarChar, null));
                    db.Commands[0].Parameters.Add(new Parameter("@UPDATED_AT", MySqlDbType.VarChar, null));
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
        public void UPDATESTATUSPENGIRIMAN(RMS.COMMON.EXPRESS.RMS_SPJ obj)
        {
            try
            {
                using (Database db = new Database())
                {
                    DataTable dt = new DataTable();
                    db.Commands.Add(db.CreateCommand(QUERY_UPDATESTATUSPENGIRIMAN));
                    db.Commands[0].Parameters.Add(new Parameter("@NORESI", MySqlDbType.VarChar, obj.NORESI));
                    db.Commands[0].Parameters.Add(new Parameter("@STATUS", MySqlDbType.Int32, obj.STATUS));
                    dt = db.Commands[0].ExecuteDataTable();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void DELETE(RMS.COMMON.EXPRESS.RMS_SPJ obj)
        {
            try
            {
                using (Database db = new Database())
                {
                    DataTable dt = new DataTable();
                    db.Commands.Add(db.CreateCommand(QUERY_DELETE));
                    db.Commands[0].Parameters.Add(new Parameter("@IDDETAIL", MySqlDbType.Int32, obj.IDDETAIL));
                    dt = db.Commands[0].ExecuteDataTable();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public DataTable SELECTFILTER(RMS.COMMON.EXPRESS.RMS_SPJ obj)
        {
            DataTable dt = new DataTable();
            try
            {
                using (Database db = new Database())
                {

                    db.Commands.Add(db.CreateCommand(QUERY_SELECTFILTER));
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
        public DataTable SELECTFILTERSPJ(RMS.COMMON.EXPRESS.RMS_SPJ obj)
        {
            DataTable dt = new DataTable();
            try
            {
                using (Database db = new Database())
                {

                    db.Commands.Add(db.CreateCommand(QUERY_SELECTFILTERSPJ));
                    db.Commands[0].Parameters.Add(new Parameter("@STARTDATE", MySqlDbType.Date, obj.STARTDATE));
                    db.Commands[0].Parameters.Add(new Parameter("@ENDDATE", MySqlDbType.Date, obj.ENDDATE));
                    db.Commands[0].Parameters.Add(new Parameter("@NOSPJ", MySqlDbType.VarChar, obj.NOSPJ));
                    db.Commands[0].Parameters.Add(new Parameter("@NOPOL", MySqlDbType.VarChar, obj.NOPOLISI));

                    dt = db.Commands[0].ExecuteDataTable();
                }
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public DataTable SELECTAGENTBYID(RMS.COMMON.EXPRESS.RMS_SPJ obj)
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
        public DataTable SELECTIDSTT(RMS.COMMON.EXPRESS.RMS_SPJ obj)
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
        public DataTable SELECTKODEIVOICE(RMS.COMMON.EXPRESS.RMS_SPJ obj)
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
        public DataTable SELECTPMBINV(RMS.COMMON.EXPRESS.RMS_SPJ obj)
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
        public DataTable SELECTPEMB(RMS.COMMON.EXPRESS.RMS_SPJ obj)
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
        public DataTable SELECTRESI(RMS.COMMON.EXPRESS.RMS_SPJ obj)
        {
            DataTable dt = new DataTable();
            try
            {

                using (Database db = new Database())
                {
                    
                    db.Commands.Add(db.CreateCommand(QUERY_SELECTRESI));
                    db.Commands[0].Parameters.Add(new Parameter("@NOSPJ", MySqlDbType.VarChar, obj.NOSPJ));                   
                    dt = db.Commands[0].ExecuteDataTable();

                }

                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public DataTable SELECT(RMS.COMMON.EXPRESS.RMS_SPJ obj)
        {
            DataTable dt = new DataTable();
            try
            {
                
                using (Database db = new Database())
                {                  
                    db.Commands.Add(db.CreateCommand(QUERY_SELECTALL));
                    db.Commands[0].Parameters.Add(new Parameter("@STARTDATE", MySqlDbType.Date, obj.STARTDATE));
                    db.Commands[0].Parameters.Add(new Parameter("@ENDDATE", MySqlDbType.Date, obj.ENDDATE));                  
                   
                    dt = db.Commands[0].ExecuteDataTable();
                      
                }
                 
                return dt;
            }
            catch (Exception ex)
            {
               // throw new Exception(ex.Message);
                throw new Exception(ex.Message);
            }
        }
        public DataTable SELECTGENERATEINVOICE(RMS.COMMON.EXPRESS.RMS_SPJ obj)
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
        public DataTable SELECTINVOICECETAK(RMS.COMMON.EXPRESS.RMS_SPJ obj)
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
        public DataTable SELECTLIKE(RMS.COMMON.EXPRESS.RMS_SPJ obj)
        {
            DataTable dt = new DataTable();
            try
            {
                using (Database db = new Database())
                {
                    db.Commands.Add(db.CreateCommand(QUERY_SELECTRESI));
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
        public DataTable SELECTINVOICE(RMS.COMMON.EXPRESS.RMS_SPJ obj)
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
        public DataTable CARI_BYKODE(RMS.COMMON.EXPRESS.RMS_SPJ obj)
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
        public DataTable CARI_BYID(RMS.COMMON.EXPRESS.RMS_SPJ obj)
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
        public DataTable CARI_BYNORESI(RMS.COMMON.EXPRESS.RMS_SPJ obj)
        {
            DataTable dt = new DataTable();
            try
            {
                using (Database db = new Database())
                {
                    db.Commands.Add(db.CreateCommand(QUERY_CARI_BYNORESI));
                    db.Commands[0].Parameters.Add(new Parameter("@NORESI", MySqlDbType.VarChar, obj.NORESI));
                    dt = db.Commands[0].ExecuteDataTable();
                }
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public DataTable CARI_BYNAMA(RMS.COMMON.EXPRESS.RMS_SPJ obj)
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
        public DataTable SEARCH_BYKODE(RMS.COMMON.EXPRESS.RMS_SPJ obj)
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
        public DataTable SEARCH_BYNAMA(RMS.COMMON.EXPRESS.RMS_SPJ obj)
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

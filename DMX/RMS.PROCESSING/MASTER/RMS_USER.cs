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
    public class RMS_USER
    {
        Database db = new Database();
        protected string QUERY_SELECT = "SELECT * FROM user where isaktif = 1";
        protected string QUERY_SELECTLOGIN = "SELECT * FROM user where username = @USERNAME and password = @PASSWORD and isaktif =@ISAKTIF";
        protected string QUERY_DELETE = "UPDATE user set isaktif = 0 WHERE id=@id";
        protected string QUERY_CARI_BYKODE = "SELECT * from user where id = @ID and isaktif = 1";
        protected string QUERY_CARI_BYNAME = "SELECT * FROM user WHERE username = @USERNAME and isaktif = 1 ";
        protected string QUERY_SEARCH_BYKODE = "SELECT * FROM BANK WHERE KODEBANK LIKE CONCAT('%',@KODEBANK,'%')";
        protected string QUERY_SEARCH_BYNAME = "SELECT * FROM BANK WHERE NAMABANK LIKE CONCAT('%',@NAMABANK,'%')";
        protected string QUERY_INSERT = "INSERT INTO user(nama,level,username,password,hp,alamat,isaktif,isbiayastt,ispiutang,ismasterdata,isagent,ispricelist,isuser,islaporan,iscourier,isLogin) " +
                                        "VALUES (@nama,@level,@username,@password,@hp,@alamat,@isaktif,@isbiayastt,@ispiutang,@ismasterdata,@isagent,@ispricelist,@isuser,@islaporan,@iscourier,@isLogin)";
        protected string QUERY_UPDATE = "UPDATE user SET nama=@nama,level=@level,username=@username,password=@password,hp=@hp,alamat=@alamat,isaktif=@isaktif,isbiayastt=@isbiayastt, " +
                        "ispiutang=@ispiutang,ismasterdata=@ismasterdata,isagent=@isagent,ispricelist=@ispricelist,isuser=@isuser,islaporan=@islaporan,iscourier=@iscourier WHERE id = @id";

        public void INSERT(RMS.COMMON.MASTER.RMS_USER obj)
        {
            try
            {
                using (Database db = new Database())
                {
                    DataTable dt = new DataTable();
                    db.Commands.Add(db.CreateCommand(QUERY_INSERT));
                    db.Commands[0].Parameters.Add(new Parameter("@nama", MySqlDbType.VarChar, obj.nama));
                    db.Commands[0].Parameters.Add(new Parameter("@level", MySqlDbType.VarChar, obj.level));
                    db.Commands[0].Parameters.Add(new Parameter("@username", MySqlDbType.VarChar, obj.username));
                    db.Commands[0].Parameters.Add(new Parameter("@password", MySqlDbType.VarChar, obj.password));
                    db.Commands[0].Parameters.Add(new Parameter("@hp", MySqlDbType.VarChar, obj.hp));
                    db.Commands[0].Parameters.Add(new Parameter("@alamat", MySqlDbType.VarChar, obj.alamat));
                    db.Commands[0].Parameters.Add(new Parameter("@isaktif", MySqlDbType.Int32, obj.isaktif));
                    db.Commands[0].Parameters.Add(new Parameter("@isbiayastt", MySqlDbType.Int32, obj.isbiayastt));
                    db.Commands[0].Parameters.Add(new Parameter("@ispiutang", MySqlDbType.Int32, obj.ispiutang));
                    db.Commands[0].Parameters.Add(new Parameter("@ismasterdata", MySqlDbType.Int32, obj.ismasterdata));
                    db.Commands[0].Parameters.Add(new Parameter("@isagent", MySqlDbType.Int32, obj.isagent));
                    db.Commands[0].Parameters.Add(new Parameter("@ispricelist", MySqlDbType.Int32, obj.ispricelist));
                    db.Commands[0].Parameters.Add(new Parameter("@isuser", MySqlDbType.Int32, obj.isuser));
                    db.Commands[0].Parameters.Add(new Parameter("@islaporan", MySqlDbType.Int32, obj.islaporan));
                    db.Commands[0].Parameters.Add(new Parameter("@iscourier", MySqlDbType.Int32, obj.iscourier));
                    db.Commands[0].Parameters.Add(new Parameter("@isLogin", MySqlDbType.Int32, obj.isLogin));
                    dt = db.Commands[0].ExecuteDataTable();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void UpdateIsLogin(RMS.COMMON.MASTER.RMS_USER obj,int islogin)
        {
            try
            {
                using (Database db = new Database())
                {
                    DataTable dt = new DataTable();
                    db.Commands.Add(db.CreateCommand("UPDATE user set isLogin = @islogin WHERE id = @ID"));
                    db.Commands[0].Parameters.Add(new Parameter("@isLogin", MySqlDbType.Int32, islogin));
                    db.Commands[0].Parameters.Add(new Parameter("@ID", MySqlDbType.Int32, obj.id));
                    dt = db.Commands[0].ExecuteDataTable();

                }
            }
            catch (Exception ex)
            {
                // Error.LogError(ex);
            }
        }
        public string DecodePassword(RMS.COMMON.MASTER.RMS_USER obj)
        {
            string decode;
            using (Database db = new Database())
            {
                decode = db.DecodePassword(obj.password);

            }
            return decode;
        }
        public string EncodePassword(RMS.COMMON.MASTER.RMS_USER obj)
        {
            string encode;
            using (Database db = new Database())
            {
                encode = db.EncodePassword(obj.password);

            }
            return encode;
        }



        public void RecordLoginHistory()
        {
            try
            {
                using (Database db = new Database())
                {
                    string query = "INSERT INTO (username, tgllogin,ipaddress, islogin, tgllogout) VALUES" +
                                   "(@username, @tgllogin,@ipaddress, @islogin, @tgllogout)";
                    db.Commands.Add(db.CreateCommand("usp_SecurityLoginHistory_INSERT"));
                    /*
                    db.Commands[0].Parameters.Add(new Parameter("@userID", SqlDbType.VarChar, SecurityManager.UserID));
                    db.Commands[0].Parameters.Add(new Parameter("@tglLogin", SqlDbType.DateTime, DateTime.Now));

                    db.Commands[0].Parameters.Add(new Parameter("@ipAddress", SqlDbType.VarChar, SecurityManager.ClientIPAddress));
                    db.Commands[0].ExecuteNonQuery();
                     */
                }
            }
            catch (Exception ex)
            {
                // Error.LogError(ex);
            }
        }
        public bool IsAuthenticate(RMS.COMMON.MASTER.RMS_USER obj)
        {
            bool valid = false;

            DataTable dt;
            Database db = new Database();

            db.Commands.Add(db.CreateCommand("SELECT * FROM user where username = @USERNAME and password = @PASSWORD and isaktif =@ISAKTIF"));
            db.Commands[0].Parameters.Add(new Parameter("@USERNAME", MySqlDbType.VarChar, obj.username));
            db.Commands[0].Parameters.Add(new Parameter("@PASSWORD", MySqlDbType.VarChar, obj.password));
            db.Commands[0].Parameters.Add(new Parameter("@ISAKTIF", MySqlDbType.Int32, obj.isaktif));
            dt = db.Commands[0].ExecuteDataTable();

            if (dt.Rows.Count > 0)
            {

                obj.id = int.Parse(dt.Rows[0]["id"].ToString());
                string _userame = dt.Rows[0]["username"].ToString();
                string _password = dt.Rows[0]["password"].ToString();
                string _level = dt.Rows[0]["level"].ToString();
                bool _active = bool.Parse(dt.Rows[0]["isaktif"].ToString());


                if (_active)
                {
                    valid = true;
                }
                else
                {
                    valid = false;
                }
                
            }

            return valid;
        }
        public void UPDATE(RMS.COMMON.MASTER.RMS_USER obj)
        {
            try
            {
                using (Database db = new Database())
                {
                    DataTable dt = new DataTable();
                    db.Commands.Add(db.CreateCommand(QUERY_UPDATE));
                    db.Commands[0].Parameters.Add(new Parameter("@id", MySqlDbType.Int32, obj.id));
                    db.Commands[0].Parameters.Add(new Parameter("@nama", MySqlDbType.VarChar, obj.nama));
                    db.Commands[0].Parameters.Add(new Parameter("@level", MySqlDbType.VarChar, obj.level));
                    db.Commands[0].Parameters.Add(new Parameter("@username", MySqlDbType.VarChar, obj.username));
                    db.Commands[0].Parameters.Add(new Parameter("@password", MySqlDbType.VarChar, obj.password));
                    db.Commands[0].Parameters.Add(new Parameter("@hp", MySqlDbType.VarChar, obj.hp));
                    db.Commands[0].Parameters.Add(new Parameter("@alamat", MySqlDbType.VarChar, obj.alamat));
                    db.Commands[0].Parameters.Add(new Parameter("@isaktif", MySqlDbType.Int32, obj.isaktif));
                    db.Commands[0].Parameters.Add(new Parameter("@isbiayastt", MySqlDbType.Int32, obj.isbiayastt));
                    db.Commands[0].Parameters.Add(new Parameter("@ispiutang", MySqlDbType.Int32, obj.ispiutang));
                    db.Commands[0].Parameters.Add(new Parameter("@ismasterdata", MySqlDbType.Int32, obj.ismasterdata));
                    db.Commands[0].Parameters.Add(new Parameter("@isagent", MySqlDbType.Int32, obj.isagent));
                    db.Commands[0].Parameters.Add(new Parameter("@ispricelist", MySqlDbType.Int32, obj.ispricelist));
                    db.Commands[0].Parameters.Add(new Parameter("@isuser", MySqlDbType.Int32, obj.isuser));
                    db.Commands[0].Parameters.Add(new Parameter("@islaporan", MySqlDbType.Int32, obj.islaporan));
                    db.Commands[0].Parameters.Add(new Parameter("@iscourier", MySqlDbType.Int32, obj.iscourier));
                    dt = db.Commands[0].ExecuteDataTable();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void DELETE(RMS.COMMON.MASTER.RMS_USER obj)
        {
            try
            {
                using (Database db = new Database())
                {
                    DataTable dt = new DataTable();
                    db.Commands.Add(db.CreateCommand(QUERY_DELETE));
                    db.Commands[0].Parameters.Add(new Parameter("@id", MySqlDbType.Int32, obj.id));
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
        public DataTable SELECTLOGIN(RMS.COMMON.MASTER.RMS_USER obj)
        {
            DataTable dt = new DataTable();
            try
            {
                using (Database db = new Database())
                {
                    db.Commands.Add(db.CreateCommand(QUERY_SELECTLOGIN));
                    db.Commands[0].Parameters.Add(new Parameter("@USERNAME", MySqlDbType.VarChar, obj.username));
                    db.Commands[0].Parameters.Add(new Parameter("@PASSWORD", MySqlDbType.VarChar, obj.password));
                    db.Commands[0].Parameters.Add(new Parameter("@ISAKTIF", MySqlDbType.Int32, obj.isaktif));
                    dt = db.Commands[0].ExecuteDataTable();

                }
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public DataTable CARI_BYKODE(RMS.COMMON.MASTER.RMS_USER obj)
        {
            DataTable dt = new DataTable();
            try
            {
                using (Database db = new Database())
                {
                    db.Commands.Add(db.CreateCommand(QUERY_CARI_BYKODE));
                   db.Commands[0].Parameters.Add(new Parameter("@ID", MySqlDbType.Int32, obj.id));
                    dt = db.Commands[0].ExecuteDataTable();
                }
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public DataTable CARI_BYNAMA(RMS.COMMON.MASTER.RMS_USER obj)
        {
            DataTable dt = new DataTable();
            try
            {
                using (Database db = new Database())
                {
                    db.Commands.Add(db.CreateCommand(QUERY_CARI_BYNAME));
                    db.Commands[0].Parameters.Add(new Parameter("@USERNAME", MySqlDbType.VarChar, obj.username));
                    dt = db.Commands[0].ExecuteDataTable();
                }
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public DataTable SEARCH_BYKODE(RMS.COMMON.MASTER.RMS_USER obj)
        {
            DataTable dt = new DataTable();
            try
            {
                using (Database db = new Database())
                {
                    db.Commands.Add(db.CreateCommand(QUERY_SEARCH_BYKODE));
                    //db.Commands[0].Parameters.Add(new Parameter("@KODEBANK", MySqlDbType.VarChar, obj.KODE));
                    dt = db.Commands[0].ExecuteDataTable();
                }
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public DataTable SEARCH_BYNAMA(RMS.COMMON.MASTER.RMS_USER obj)
        {
            DataTable dt = new DataTable();
            try
            {
                using (Database db = new Database())
                {
                    db.Commands.Add(db.CreateCommand(QUERY_SEARCH_BYNAME));
                    //db.Commands[0].Parameters.Add(new Parameter("@NAMABANK", MySqlDbType.VarChar, obj.NAMA));
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

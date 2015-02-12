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
    public class RMS_KOTA
    {
        Database db = new Database();

        protected string QUERY_SELECT = "SELECT * FROM area";
        protected string QUERY_SELECTTERUSAN = "SELECT * FROM terusan";
        protected string QUERY_SELECTKOTA = "SELECT * FROM kota";
        protected string QUERY_DELETE = "DELETE FROM kota WHERE IDKOTA=@IDKOTA";
        protected string QUERY_DELETETERUSAN = "DELETE FROM terusan WHERE ID=@ID";
        protected string QUERY_TERUSAN = "DELETE FROM kota WHERE IDKOTA=@IDKOTA";
        protected string QUERY_GETAREA_BYKODE = "SELECT * FROM area WHERE KODEAREA LIKE CONCAT('%',@KODEAREA,'%')";
        protected string QUERY_GETTERUSAN_BYNAMA = "SELECT * FROM terusan WHERE ISAKTIF = 1 AND NAMATERUSAN =@NAMATERUSAN";
        protected string QUERY_GETTERUSAN_BYID = "SELECT * FROM v_terusan WHERE IDKOTA =@IDKOTA";
        protected string QUERY_GETKOTA = "SELECT * FROM kota where ISAKTIF = 1 AND (NAMAKOTA  LIKE CONCAT('%',@NAMAKOTA,'%') OR KODEKOTA  LIKE CONCAT('%',@KODEKOTA,'%'))";
        protected string QUERY_CARI_BYIDAREA = "SELECT * FROM area WHERE IDAREA=@IDAREA";
        protected string QUERY_CARI_BYIDKOTA = "SELECT * FROM v_kota WHERE IDKOTA=@IDKOTA";
        protected string QUERY_CARI_BYKODEKOTA = "SELECT * FROM v_kota WHERE KODEKOTA=@KODEKOTA";
    
        protected string QUERY_CARI_BYKODE = "SELECT * FROM v_kota WHERE KODEAREA=@KODEAREA";
        protected string QUERY_CARI_BYNAME = "SELECT * FROM v_kota WHERE KODEAREA=@NAMAAREA";
        // AREA
        protected string QUERY_SEARCH_BYKODEAREA = "SELECT * FROM area WHERE KODEAREA LIKE CONCAT('%',@KODEAREA,'%')";
        protected string QUERY_SEARCH_BYNAMEAREA = "SELECT * FROM area WHERE NAMAAREA LIKE CONCAT('%',@NAMAAREA,'%')";
        // KOTA
        protected string QUERY_SEARCH_BYKODE = "SELECT * FROM v_kota WHERE KODEAREA LIKE CONCAT('%',@KODEAREA,'%')";
        protected string QUERY_SEARCH_BYNAME = "SELECT * FROM v_kota WHERE NAMAKOTA LIKE CONCAT('%',@NAMAKOTA,'%')";
        protected string QUERY_SEARCH_BYNAMEAREAKOTA = "SELECT * FROM v_kota WHERE NAMAAREA LIKE CONCAT('%',@NAMAAREA,'%')";
        protected string QUERY_INSERT = "INSERT INTO area (KODEAREA,NAMAAREA) VALUES "
                                        + "(@KODEAREA,@NAMAAREA)";

        protected string QUERY_INSERTKOTA = "INSERT INTO kota (IDAREA,KODEKOTA,NAMAKOTA) VALUES "
                                       + "(@IDAREA,@KODEKOTA,@NAMAKOTA)";

        protected string QUERY_INSERTTERUSAN = "INSERT INTO terusan (IDKOTA,NAMATERUSAN) VALUES "
                                       + "(@IDKOTA,@NAMATERUSAN)";
        protected string QUERY_UPDATE = "UPDATE area SET KODEAREA=@KODEAREA, NAMAAREA = @NAMAAREA WHERE IDAREA=@IDAREA";
        protected string QUERY_UPDATEKOTA = "UPDATE kota SET IDAREA=@IDAREA, KODEKOTA = @KODEKOTA, NAMAKOTA = @NAMAKOTA WHERE IDKOTA=@IDKOTA";

        public void INSERT(RMS.COMMON.MASTER.RMS_KOTA obj)
        {
            try
            {
                using (Database db = new Database())
                {
                    DataTable dt = new DataTable();
                    db.Commands.Add(db.CreateCommand(QUERY_INSERT));
                    
                    db.Commands[0].Parameters.Add(new Parameter("@KODEAREA", MySqlDbType.VarChar, obj.KODEAREA));
                    db.Commands[0].Parameters.Add(new Parameter("@NAMAAREA", MySqlDbType.VarChar, obj.NAMAAREA));
                                         
                    dt = db.Commands[0].ExecuteDataTable();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void INSERTKOTA(RMS.COMMON.MASTER.RMS_KOTA obj)
        {
            try
            {
                using (Database db = new Database())
                {
                    DataTable dt = new DataTable();
                    db.Commands.Add(db.CreateCommand(QUERY_INSERTKOTA));
                    db.Commands[0].Parameters.Add(new Parameter("@IDAREA", MySqlDbType.Int32, obj.IDAREA));
                    db.Commands[0].Parameters.Add(new Parameter("@KODEKOTA", MySqlDbType.VarChar, obj.KODEKOTA));
                    db.Commands[0].Parameters.Add(new Parameter("@NAMAKOTA", MySqlDbType.VarChar, obj.NAMAKOTA));

                    dt = db.Commands[0].ExecuteDataTable();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void INSERTTERUSAN(RMS.COMMON.MASTER.RMS_KOTA obj)
        {
            try
            {
                using (Database db = new Database())
                {
                    DataTable dt = new DataTable();
                    db.Commands.Add(db.CreateCommand(QUERY_INSERTTERUSAN));
                    db.Commands[0].Parameters.Add(new Parameter("@IDKOTA", MySqlDbType.Int32, obj.IDKOTA));
                    db.Commands[0].Parameters.Add(new Parameter("@NAMATERUSAN", MySqlDbType.VarChar, obj.NAMATERUSAN));
                    

                    dt = db.Commands[0].ExecuteDataTable();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void UPDATE(RMS.COMMON.MASTER.RMS_KOTA obj)
        {
            try
            {
                using (Database db = new Database())
                {
                    DataTable dt = new DataTable();
                    db.Commands.Add(db.CreateCommand(QUERY_UPDATE));                    
                    db.Commands[0].Parameters.Add(new Parameter("@IDAREA", MySqlDbType.VarChar, obj.IDAREA));
                    db.Commands[0].Parameters.Add(new Parameter("@KODEAREA", MySqlDbType.VarChar, obj.KODEAREA));
                    db.Commands[0].Parameters.Add(new Parameter("@NAMAAREA", MySqlDbType.VarChar, obj.NAMAAREA));
                 
                    
                    dt = db.Commands[0].ExecuteDataTable();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void UPDATEKOTA(RMS.COMMON.MASTER.RMS_KOTA obj)
        {
            try
            {
                using (Database db = new Database())
                {
                    DataTable dt = new DataTable();
                    db.Commands.Add(db.CreateCommand(QUERY_UPDATEKOTA));
                    db.Commands[0].Parameters.Add(new Parameter("@IDKOTA", MySqlDbType.Int32, obj.IDKOTA));
                    db.Commands[0].Parameters.Add(new Parameter("@IDAREA", MySqlDbType.Int32, obj.IDAREA));
                    db.Commands[0].Parameters.Add(new Parameter("@KODEKOTA", MySqlDbType.VarChar, obj.KODEKOTA));
                    db.Commands[0].Parameters.Add(new Parameter("@NAMAKOTA", MySqlDbType.VarChar, obj.NAMAKOTA));


                    dt = db.Commands[0].ExecuteDataTable();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void DELETETERUSAN(RMS.COMMON.MASTER.RMS_KOTA obj)
        {
            try
            {
                using (Database db = new Database())
                {
                    DataTable dt = new DataTable();
                    db.Commands.Add(db.CreateCommand(QUERY_DELETETERUSAN));
                    db.Commands[0].Parameters.Add(new Parameter("@ID", MySqlDbType.VarChar, obj.IDTERUSAN));
                    dt = db.Commands[0].ExecuteDataTable();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void DELETE(RMS.COMMON.MASTER.RMS_KOTA obj)
        {
            try
            {
                using (Database db = new Database())
                {
                    DataTable dt = new DataTable();
                    db.Commands.Add(db.CreateCommand(QUERY_DELETE));
                   // db.Commands[0].Parameters.Add(new Parameter("@KODESALES", MySqlDbType.VarChar, obj.KODE));
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
        public DataTable SELECTKOTA()
        {
            DataTable dt = new DataTable();
            try
            {
                using (Database db = new Database())
                {
                    db.Commands.Add(db.CreateCommand(QUERY_SELECTKOTA));
                    dt = db.Commands[0].ExecuteDataTable();
                }
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public DataTable GET_TERUSANBYID(RMS.COMMON.MASTER.RMS_KOTA obj)
        {
            DataTable dt = new DataTable();
            try
            {
                using (Database db = new Database())
                {
                    db.Commands.Add(db.CreateCommand(QUERY_GETTERUSAN_BYID));
                    db.Commands[0].Parameters.Add(new Parameter("@IDKOTA", MySqlDbType.VarChar, obj.IDKOTA));
                    dt = db.Commands[0].ExecuteDataTable();
                }
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public DataTable CARI_BYKODEKOTA(RMS.COMMON.MASTER.RMS_KOTA obj)
        {
            DataTable dt = new DataTable();
            try
            {
                using (Database db = new Database())
                {
                    db.Commands.Add(db.CreateCommand(QUERY_CARI_BYKODEKOTA));
                    db.Commands[0].Parameters.Add(new Parameter("@KODEKOTA", MySqlDbType.VarChar, obj.KODEKOTA));
                    dt = db.Commands[0].ExecuteDataTable();
                }
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public DataTable CARI_BYIDAREA(RMS.COMMON.MASTER.RMS_KOTA obj)
        {
            DataTable dt = new DataTable();
            try
            {
                using (Database db = new Database())
                {
                    db.Commands.Add(db.CreateCommand(QUERY_CARI_BYIDAREA));
                    db.Commands[0].Parameters.Add(new Parameter("@IDAREA", MySqlDbType.VarChar, obj.IDAREA));
                    dt = db.Commands[0].ExecuteDataTable();
                }
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public DataTable CARI_BYIDKOTA(RMS.COMMON.MASTER.RMS_KOTA obj)
        {
            DataTable dt = new DataTable();
            try
            {
                using (Database db = new Database())
                {
                    db.Commands.Add(db.CreateCommand(QUERY_CARI_BYIDKOTA));
                    db.Commands[0].Parameters.Add(new Parameter("@IDKOTA", MySqlDbType.VarChar, obj.IDKOTA));
                    dt = db.Commands[0].ExecuteDataTable();
                }
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        public DataTable CARI_BYKODE(RMS.COMMON.MASTER.RMS_KOTA obj)
        {
            DataTable dt = new DataTable();
            try
            {
                using (Database db = new Database())
                {
                    db.Commands.Add(db.CreateCommand(QUERY_CARI_BYKODE));
                    db.Commands[0].Parameters.Add(new Parameter("@KODEAREA", MySqlDbType.VarChar, obj.KODEAREA));
                    dt = db.Commands[0].ExecuteDataTable();
                }
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public DataTable GETAREA_BYKODE(RMS.COMMON.MASTER.RMS_KOTA obj)
        {
            DataTable dt = new DataTable();
            try
            {
                using (Database db = new Database())
                {
                    db.Commands.Add(db.CreateCommand(QUERY_GETAREA_BYKODE));
                    db.Commands[0].Parameters.Add(new Parameter("@KODEAREA", MySqlDbType.VarChar, obj.KODEAREA));
                    dt = db.Commands[0].ExecuteDataTable();
                }
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public DataTable GETKOTA(RMS.COMMON.MASTER.RMS_KOTA obj)
        {
            DataTable dt = new DataTable();
            try
            {
                using (Database db = new Database())
                {
                    db.Commands.Add(db.CreateCommand(QUERY_GETKOTA));
                    db.Commands[0].Parameters.Add(new Parameter("@KODEKOTA", MySqlDbType.VarChar, obj.KODEKOTA));
                    db.Commands[0].Parameters.Add(new Parameter("@NAMAKOTA", MySqlDbType.VarChar, obj.NAMAKOTA));
                    dt = db.Commands[0].ExecuteDataTable();
                }
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public DataTable GETTERUSAN_BYNAMA(RMS.COMMON.MASTER.RMS_KOTA obj)
        {
            DataTable dt = new DataTable();
            try
            {
                using (Database db = new Database())
                {
                    db.Commands.Add(db.CreateCommand(QUERY_GETTERUSAN_BYNAMA));
                    db.Commands[0].Parameters.Add(new Parameter("@NAMATERUSAN", MySqlDbType.VarChar, obj.NAMATERUSAN));
                    dt = db.Commands[0].ExecuteDataTable();
                }
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public DataTable GETTERUSAN_AUTO()
        {
            DataTable dt = new DataTable();
            try
            {
                using (Database db = new Database())
                {
                    db.Commands.Add(db.CreateCommand(QUERY_SELECTTERUSAN));
                    dt = db.Commands[0].ExecuteDataTable();
                }
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public DataTable CARI_BYNAMA(RMS.COMMON.MASTER.RMS_KOTA obj)
        {
            DataTable dt = new DataTable();
            try
            {
                using (Database db = new Database())
                {
                    db.Commands.Add(db.CreateCommand(QUERY_CARI_BYNAME));
                    db.Commands[0].Parameters.Add(new Parameter("@NAMAKOTA", MySqlDbType.VarChar, obj.NAMAKOTA));
                    dt = db.Commands[0].ExecuteDataTable();
                }
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public DataTable SEARCH_BYKODE(RMS.COMMON.MASTER.RMS_KOTA obj)
        {
            DataTable dt = new DataTable();
            try
            {
                using (Database db = new Database())
                {
                    db.Commands.Add(db.CreateCommand(QUERY_SEARCH_BYKODE));
                    db.Commands[0].Parameters.Add(new Parameter("@KODEAREA", MySqlDbType.VarChar, obj.KODEAREA));
                    dt = db.Commands[0].ExecuteDataTable();
                }
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public DataTable SEARCH_BYNAMA(RMS.COMMON.MASTER.RMS_KOTA obj)
        {
            DataTable dt = new DataTable();
            try
            {
                using (Database db = new Database())
                {
                    db.Commands.Add(db.CreateCommand(QUERY_SEARCH_BYNAME));
                    db.Commands[0].Parameters.Add(new Parameter("@NAMAKOTA", MySqlDbType.VarChar, obj.NAMAKOTA));
                    dt = db.Commands[0].ExecuteDataTable();
                }
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public DataTable SEARCH_BYNAMAAREAKOTA(RMS.COMMON.MASTER.RMS_KOTA obj)
        {
            DataTable dt = new DataTable();
            try
            {
                using (Database db = new Database())
                {
                    db.Commands.Add(db.CreateCommand(QUERY_SEARCH_BYNAMEAREAKOTA));
                    db.Commands[0].Parameters.Add(new Parameter("@NAMAAREA", MySqlDbType.VarChar, obj.NAMAAREA));
                    dt = db.Commands[0].ExecuteDataTable();
                }
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        // UNTUK PENCARIAN KOTA BY KODE
        public DataTable SEARCH_BYKODEAREA(RMS.COMMON.MASTER.RMS_KOTA obj)
        {
            DataTable dt = new DataTable();
            try
            {
                using (Database db = new Database())
                {
                    db.Commands.Add(db.CreateCommand(QUERY_SEARCH_BYKODEAREA));
                    db.Commands[0].Parameters.Add(new Parameter("@KODEAREA", MySqlDbType.VarChar, obj.KODEAREA));
                    dt = db.Commands[0].ExecuteDataTable();
                }
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        // UNTUK PENCARIAN AREA BY NAMA
        public DataTable SEARCH_BYNAMAAREA(RMS.COMMON.MASTER.RMS_KOTA obj)
        {
            DataTable dt = new DataTable();
            try
            {
                using (Database db = new Database())
                {
                    db.Commands.Add(db.CreateCommand(QUERY_SEARCH_BYNAMEAREA));
                    db.Commands[0].Parameters.Add(new Parameter("@NAMAAREA", MySqlDbType.VarChar, obj.NAMAAREA));
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

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
    public class RMS_TENTANGPERUSAHAAN
    {
        protected string QUERY_SELECT = "SELECT * FROM perusahaan WHERE ISAKTIF = 1";
        protected string QUERY_DELETE = "UPDATE perusahaan set ISAKTIF = 0";
        protected string QUERY_CARI_BYKODE = "SELECT * FROM perusahaan WHERE KODE=@KODE AND ISAKTIF =1";
        protected string QUERY_CARI_BYNAME = "SELECT * FROM SATUAN WHERE NAMASATUAN=@NAMASATUAN";
        protected string QUERY_SEARCH_BYKODE = "SELECT * FROM SATUAN WHERE KODESATUAN LIKE CONCAT('%',@KODESATUAN,'%')";
        protected string QUERY_SEARCH_BYNAME = "SELECT * FROM SATUAN WHERE NAMASATUAN LIKE CONCAT('%',@NAMASATUAN,'%')";
        protected string QUERY_INSERT = "INSERT INTO PERUSAHAAN VALUES (@KODE,@NAMA,@FILE,@IMAGE,@SIZE,@NPWP,@ALAMAT,@TELP,@FAX,@CABANGBANK1,@CABANGBANK2,@NOREK1,@NOREK2,@ATASNAMA1,@ATASNAMA2,1)";        
        protected string QUERY_UPDATE = "UPDATE SATUAN SET KODESATUAN=@KODESATUAN,NAMASATUAN=@NAMASATUAN,ISI=@ISI WHERE KODESATUAN=@KODESATUAN";


        public void INSERT(RMS.COMMON.MASTER.RMS_TENTANGPERUSAHAAN obj)
        {
            try
            {
                using (Database db = new Database())
                {
                   DataTable dt = new DataTable();
                   db.Commands.Add(db.CreateCommand(QUERY_INSERT));
                   db.Commands[0].Parameters.Add(new Parameter("@KODE", MySqlDbType.VarChar, obj.KODE));
                   db.Commands[0].Parameters.Add(new Parameter("@NAMA", MySqlDbType.VarChar, obj.NAMA));
                   db.Commands[0].Parameters.Add(new Parameter("@FILE", MySqlDbType.LongBlob, obj.FILE));
                   db.Commands[0].Parameters.Add(new Parameter("@SIZE", MySqlDbType.Int32, obj.SIZE));
                   db.Commands[0].Parameters.Add(new Parameter("@IMAGE", MySqlDbType.VarChar, obj.IMAGE));
                   db.Commands[0].Parameters.Add(new Parameter("@NPWP", MySqlDbType.VarChar, obj.NPWP));
                   db.Commands[0].Parameters.Add(new Parameter("@ALAMAT", MySqlDbType.VarChar, obj.ALAMAT));
                   db.Commands[0].Parameters.Add(new Parameter("@TELP", MySqlDbType.VarChar, obj.TELP));
                   db.Commands[0].Parameters.Add(new Parameter("@FAX", MySqlDbType.VarChar, obj.FAX));
                   db.Commands[0].Parameters.Add(new Parameter("@CABANGBANK1", MySqlDbType.VarChar, obj.CABANGBANK1));
                   db.Commands[0].Parameters.Add(new Parameter("@CABANGBANK2", MySqlDbType.VarChar, obj.CABANGBANK2));
                   db.Commands[0].Parameters.Add(new Parameter("@NOREK1", MySqlDbType.VarChar, obj.NOREK1));
                   db.Commands[0].Parameters.Add(new Parameter("@NOREK2", MySqlDbType.VarChar, obj.NOREK2));
                   db.Commands[0].Parameters.Add(new Parameter("@ATASNAMA1", MySqlDbType.VarChar, obj.ATASNAMA1));
                   db.Commands[0].Parameters.Add(new Parameter("@ATASNAMA2", MySqlDbType.VarChar, obj.ATASNAMA2));                       
                   dt = db.Commands[0].ExecuteDataTable();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void UPDATE(RMS.COMMON.MASTER.RMS_TENTANGPERUSAHAAN obj)
        {
            try
            {
                using (Database db = new Database())
                {
                    DataTable dt = new DataTable();
                    db.Commands.Add(db.CreateCommand(QUERY_UPDATE));
                   // db.Commands[0].Parameters.Add(new Parameter("@KODESATUAN", MySqlDbType.VarChar, obj.KODE));
                   // db.Commands[0].Parameters.Add(new Parameter("@NAMASATUAN", MySqlDbType.VarChar, obj.NAMA));
                   // db.Commands[0].Parameters.Add(new Parameter("@ISI", MySqlDbType.Int24, obj.ISI));
                   // dt = db.Commands[0].ExecuteDataTable();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void DELETE(RMS.COMMON.MASTER.RMS_TENTANGPERUSAHAAN obj)
        {
            try
            {
                using (Database db = new Database())
                {
                    DataTable dt = new DataTable();
                    db.Commands.Add(db.CreateCommand(QUERY_DELETE));
                    db.Commands[0].Parameters.Add(new Parameter("@KODE", MySqlDbType.VarChar, obj.KODE));
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
        public DataTable CARI_BYKODE(RMS.COMMON.MASTER.RMS_TENTANGPERUSAHAAN obj)
        {
            DataTable dt = new DataTable();
            try
            {
                using (Database db = new Database())
                {
                    db.Commands.Add(db.CreateCommand(QUERY_CARI_BYKODE));
                    db.Commands[0].Parameters.Add(new Parameter("@KODE", MySqlDbType.VarChar, obj.KODE));
                    dt = db.Commands[0].ExecuteDataTable();
                }
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public DataTable CARI_BYNAMA(RMS.COMMON.MASTER.RMS_TENTANGPERUSAHAAN obj)
        {
            DataTable dt = new DataTable();
            try
            {
                using (Database db = new Database())
                {
                    db.Commands.Add(db.CreateCommand(QUERY_CARI_BYNAME));
                    //db.Commands[0].Parameters.Add(new Parameter("@NAMASATUAN", MySqlDbType.VarChar, obj.NAMA));
                    //dt = db.Commands[0].ExecuteDataTable();
                }
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public DataTable SEARCH_BYKODE(RMS.COMMON.MASTER.RMS_TENTANGPERUSAHAAN obj)
        {
            DataTable dt = new DataTable();
            try
            {
                using (Database db = new Database())
                {
                   // db.Commands.Add(db.CreateCommand(QUERY_SEARCH_BYKODE));
                   // db.Commands[0].Parameters.Add(new Parameter("@KODESATUAN", MySqlDbType.VarChar, obj.KODE));
                   // dt = db.Commands[0].ExecuteDataTable();
                }
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public DataTable SEARCH_BYNAMA(RMS.COMMON.MASTER.RMS_TENTANGPERUSAHAAN obj)
        {
            DataTable dt = new DataTable();
            try
            {
                using (Database db = new Database())
                {
                    //db.Commands.Add(db.CreateCommand(QUERY_SEARCH_BYNAME));
                    //db.Commands[0].Parameters.Add(new Parameter("@NAMASATUAN", MySqlDbType.VarChar, obj.NAMA));
                   // dt = db.Commands[0].ExecuteDataTable();
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

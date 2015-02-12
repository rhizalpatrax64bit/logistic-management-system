using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RMS.COMMON;
using Anovsys.DAL;
using MySql.Data.MySqlClient;
using System.Data;

namespace RMS.PROCESSING.GENERAL
{
    public class RMS_COMBO
    {
        Database db = new Database();

        protected string QUERY_JENISBAYAR = "SELECT * FROM jenisbayar";
        protected string QUERY_LAYANAN = "SELECT * FROM layanan";
        protected string QUERY_MODAKIRIM = "SELECT * FROM modakirim";
        protected string QUERY_STATUSBAYAR = "SELECT * FROM statusbayar";
        protected string QUERY_STATUSSTT = "SELECT * FROM statusstt";
        protected string QUERY_STATUSORDER = "SELECT * FROM express_statusorder";
        protected string QUERY_KOTA = "SELECT IDKOTA,NAMAKOTA FROM v_kota";
        protected string QUERY_SEARCH_BYNAME = "SELECT * FROM SALES WHERE NAMASALES LIKE CONCAT('%',@NAMASALES,'%')";

        // QUERY EXPRESS MODULE
        protected string QUERY_JENISKIRIMAN = "SELECT * FROM jeniskiriman_express";
        protected string QUERY_PRODUKEXPRESS = "SELECT * FROM produk_express";
        protected string QUERY_JENISKENDARAAN = "SELECT * FROM jeniskendaraan_express";


        public DataTable SELECTKOTA()
        {
            DataTable dt = new DataTable();
            try
            {
                using (Database db = new Database())
                {
                    db.Commands.Add(db.CreateCommand(QUERY_KOTA));
                    dt = db.Commands[0].ExecuteDataTable();
                }
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }
        public DataTable SELECTJENISBAYAR()
        {
            DataTable dt = new DataTable();
            try
            {
                using (Database db = new Database())
                {
                    db.Commands.Add(db.CreateCommand(QUERY_JENISBAYAR));
                    dt = db.Commands[0].ExecuteDataTable();
                }
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }
        public DataTable SELECTLAYANAN()
        {
            DataTable dt = new DataTable();
            try
            {
                using (Database db = new Database())
                {
                    db.Commands.Add(db.CreateCommand(QUERY_LAYANAN));
                    dt = db.Commands[0].ExecuteDataTable();
                }
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }
        // EXPRESS MODULE 
        public DataTable SELECTJENISKIRIMAN()
        {
            DataTable dt = new DataTable();
            try
            {
                using (Database db = new Database())
                {
                    db.Commands.Add(db.CreateCommand(QUERY_JENISKIRIMAN));
                    dt = db.Commands[0].ExecuteDataTable();
                }
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }

        public DataTable SELECTJENISKENDARAAN()
        {
            DataTable dt = new DataTable();
            try
            {
                using (Database db = new Database())
                {
                    db.Commands.Add(db.CreateCommand(QUERY_JENISKENDARAAN));
                    dt = db.Commands[0].ExecuteDataTable();
                }
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }
        public DataTable SELECTPRODUKEXPRESS()
        {
            DataTable dt = new DataTable();
            try
            {
                using (Database db = new Database())
                {
                    db.Commands.Add(db.CreateCommand(QUERY_PRODUKEXPRESS));
                    dt = db.Commands[0].ExecuteDataTable();
                }
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }
        public DataTable SELECTMODAKIRIM()
        {
            DataTable dt = new DataTable();
            try
            {
                using (Database db = new Database())
                {
                    db.Commands.Add(db.CreateCommand(QUERY_MODAKIRIM));
                    dt = db.Commands[0].ExecuteDataTable();
                }
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }
        public DataTable SELECTAREA()
        {
            DataTable dt = new DataTable();
            try
            {
                using (Database db = new Database())
                {
                    db.Commands.Add(db.CreateCommand("SELECT * FROM area"));
                    dt = db.Commands[0].ExecuteDataTable();
                }
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }
        public DataTable SELECTSTATUSBAYAR()
        {
            DataTable dt = new DataTable();
            try
            {
                using (Database db = new Database())
                {
                    db.Commands.Add(db.CreateCommand(QUERY_STATUSBAYAR));
                    dt = db.Commands[0].ExecuteDataTable();
                }
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }
        public DataTable SELECTSTATUSSTT()
        {
            DataTable dt = new DataTable();
            try
            {
                using (Database db = new Database())
                {
                    db.Commands.Add(db.CreateCommand(QUERY_STATUSSTT));
                    dt = db.Commands[0].ExecuteDataTable();
                }
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }
        public DataTable SELECTSTATUSORDER()
        {
            DataTable dt = new DataTable();
            try
            {
                using (Database db = new Database())
                {
                    db.Commands.Add(db.CreateCommand(QUERY_STATUSORDER));
                    dt = db.Commands[0].ExecuteDataTable();
                }
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }
       
        public DataTable CARI_BYKODE(RMS.COMMON.MASTER.RMS_SALES obj)
        {
            DataTable dt = new DataTable();
            try
            {
                using (Database db = new Database())
                {
                 //   db.Commands.Add(db.CreateCommand(QUERY_CARI_BYKODE));
                    db.Commands[0].Parameters.Add(new Parameter("@KODESALES", MySqlDbType.VarChar, obj.KODE));
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

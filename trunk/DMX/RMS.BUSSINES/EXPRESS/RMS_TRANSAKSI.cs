using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RMS.COMMON;
using RMS.PROCESSING;
using System.Data;

namespace RMS.BUSSINES.EXPRESS
{
    public class RMS_TRANSAKSI
    {
        protected RMS.PROCESSING.EXPRESS.RMS_TRANSAKSI p = new RMS.PROCESSING.EXPRESS.RMS_TRANSAKSI();

        public DataTable GETKODE()
        {
           return p.GETKODE();
        }
        public void INSERT(RMS.COMMON.EXPRESS.RMS_TRANSAKSI obj)
        {
            p.INSERT(obj);
        }
        public void UPDATESETINVOICE(int _IDINV, string _NOCONNOTE)
        {
            p.UPDATESETINVOICE(_IDINV, _NOCONNOTE);
        }
        public void UPDATE(RMS.COMMON.EXPRESS.RMS_TRANSAKSI obj)
        {
            p.UPDATE(obj);
        }

        public void DELETE(RMS.COMMON.EXPRESS.RMS_TRANSAKSI obj)
        {
            p.DELETE(obj);
        }
        public DataTable SELECTPEMB(RMS.COMMON.EXPRESS.RMS_TRANSAKSI obj)
        {
            return p.SELECTPEMB(obj);
        }
        public DataTable SELECTPMBINV(RMS.COMMON.EXPRESS.RMS_TRANSAKSI obj)
        {
            return p.SELECTPMBINV(obj);
        }

        public DataTable SELECT(RMS.COMMON.EXPRESS.RMS_TRANSAKSI obj)
        {
            return p.SELECT(obj);
        }
        public DataTable SELECTGENERATEINVOICE(RMS.COMMON.EXPRESS.RMS_TRANSAKSI obj)
        {
            return p.SELECTGENERATEINVOICE(obj);
        }
        public DataTable SELECTINVOICECETAK(RMS.COMMON.EXPRESS.RMS_TRANSAKSI obj)
        {
            return p.SELECTINVOICECETAK(obj);
        }
        public DataTable SELECTLIKE(RMS.COMMON.EXPRESS.RMS_TRANSAKSI obj)
        {
            return p.SELECTLIKE(obj);
        }
        public DataTable SELECTINVOICE(RMS.COMMON.EXPRESS.RMS_TRANSAKSI obj)
        {
            return p.SELECTINVOICE(obj);
        }


        public DataTable SELECTIDSTT(RMS.COMMON.EXPRESS.RMS_TRANSAKSI obj)
        {
            return p.SELECTIDSTT(obj);
        }
        public DataTable SELECTAGENTBYID(RMS.COMMON.EXPRESS.RMS_TRANSAKSI obj)
        {
            return p.SELECTAGENTBYID(obj);
        }
        public DataTable SELECTKODEINVOICE(RMS.COMMON.EXPRESS.RMS_TRANSAKSI obj)
        {
            return p.SELECTKODEIVOICE(obj);
        }

        public DataTable SELECTFILTER(RMS.COMMON.EXPRESS.RMS_TRANSAKSI obj)
        {
            return p.SELECTFILTER(obj);
        }

        public DataTable CARI_TYPEOFPAYMENT(string _TOP)
        {
            return p.CARI_TYPEOFPAYMENT(_TOP);
        }
        public DataTable CARI_BYKODE(RMS.COMMON.EXPRESS.RMS_TRANSAKSI obj)
        {
            return p.CARI_BYKODE(obj);
        }
        public DataTable CARI_BYID(RMS.COMMON.EXPRESS.RMS_TRANSAKSI obj)
        {
            return p.CARI_BYID(obj);
        }

        public DataTable CARI_BYNAMA(RMS.COMMON.EXPRESS.RMS_TRANSAKSI obj)
        {
            return p.CARI_BYNAMA(obj);
        }

        public DataTable SEARCH_BYKODE(RMS.COMMON.EXPRESS.RMS_TRANSAKSI obj)
        {
            return p.SEARCH_BYKODE(obj);
        }

        public DataTable SEARCH_BYNAMA(RMS.COMMON.EXPRESS.RMS_TRANSAKSI obj)
        {
            return p.SEARCH_BYNAMA(obj);
        }
    }
}

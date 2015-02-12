using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RMS.COMMON;
using RMS.PROCESSING;
using System.Data;

namespace RMS.BUSSINES.EXPRESS
{
    public class RMS_SPJ
    {
        protected RMS.PROCESSING.EXPRESS.RMS_SPJ p = new RMS.PROCESSING.EXPRESS.RMS_SPJ();

        public DataTable GETKODE()
        {
           return p.GETKODE();
        }
        public void INSERT(RMS.COMMON.EXPRESS.RMS_SPJ obj)
        {
            p.INSERT(obj);
        }
        public void INSERTRESI(RMS.COMMON.EXPRESS.RMS_SPJ obj)
        {
            p.INSERTRESI(obj);
        }
        public void UPDATESETINVOICE(int _IDINV, string _NOCONNOTE)
        {
            p.UPDATESETINVOICE(_IDINV, _NOCONNOTE);
        }
        public void UPDATE(RMS.COMMON.EXPRESS.RMS_SPJ obj)
        {
            p.UPDATE(obj);
        }

        public void DELETE(RMS.COMMON.EXPRESS.RMS_SPJ obj)
        {
            p.DELETE(obj);
        }
        public void UPDATESTATUSPENGIRIMAN(RMS.COMMON.EXPRESS.RMS_SPJ obj)
        {
            p.UPDATESTATUSPENGIRIMAN(obj);
        }
        public DataTable SELECTPEMB(RMS.COMMON.EXPRESS.RMS_SPJ obj)
        {
            return p.SELECTPEMB(obj);
        }
        public DataTable SELECTPMBINV(RMS.COMMON.EXPRESS.RMS_SPJ obj)
        {
            return p.SELECTPMBINV(obj);
        }

        public DataTable SELECT(RMS.COMMON.EXPRESS.RMS_SPJ obj)
        {
            return p.SELECT(obj);
        }
        public DataTable SELECTRESI(RMS.COMMON.EXPRESS.RMS_SPJ obj)
        {
            return p.SELECTRESI(obj);
        }
        public DataTable SELECTGENERATEINVOICE(RMS.COMMON.EXPRESS.RMS_SPJ obj)
        {
            return p.SELECTGENERATEINVOICE(obj);
        }
        public DataTable SELECTINVOICECETAK(RMS.COMMON.EXPRESS.RMS_SPJ obj)
        {
            return p.SELECTINVOICECETAK(obj);
        }
        public DataTable SELECTLIKE(RMS.COMMON.EXPRESS.RMS_SPJ obj)
        {
            return p.SELECTLIKE(obj);
        }
        public DataTable SELECTFILTER(RMS.COMMON.EXPRESS.RMS_SPJ obj)
        {
            return p.SELECTFILTER(obj);
        }
        public DataTable SELECTINVOICE(RMS.COMMON.EXPRESS.RMS_SPJ obj)
        {
            return p.SELECTINVOICE(obj);
        }


        public DataTable SELECTIDSTT(RMS.COMMON.EXPRESS.RMS_SPJ obj)
        {
            return p.SELECTIDSTT(obj);
        }
        public DataTable SELECTAGENTBYID(RMS.COMMON.EXPRESS.RMS_SPJ obj)
        {
            return p.SELECTAGENTBYID(obj);
        }
        public DataTable SELECTKODEINVOICE(RMS.COMMON.EXPRESS.RMS_SPJ obj)
        {
            return p.SELECTKODEIVOICE(obj);
        }

        public DataTable SELECTFILTERSPJ(RMS.COMMON.EXPRESS.RMS_SPJ obj)
        {
            return p.SELECTFILTERSPJ(obj);
        }

        public DataTable CARI_TYPEOFPAYMENT(string _TOP)
        {
            return p.CARI_TYPEOFPAYMENT(_TOP);
        }
        public DataTable CARI_BYKODE(RMS.COMMON.EXPRESS.RMS_SPJ obj)
        {
            return p.CARI_BYKODE(obj);
        }
        public DataTable CARI_BYID(RMS.COMMON.EXPRESS.RMS_SPJ obj)
        {
            return p.CARI_BYID(obj);
        }
        public DataTable CARI_BYNORESI(RMS.COMMON.EXPRESS.RMS_SPJ obj)
        {
            return p.CARI_BYNORESI(obj);
        }

        public DataTable CARI_BYNAMA(RMS.COMMON.EXPRESS.RMS_SPJ obj)
        {
            return p.CARI_BYNAMA(obj);
        }

        public DataTable SEARCH_BYKODE(RMS.COMMON.EXPRESS.RMS_SPJ obj)
        {
            return p.SEARCH_BYKODE(obj);
        }

        public DataTable SEARCH_BYNAMA(RMS.COMMON.EXPRESS.RMS_SPJ obj)
        {
            return p.SEARCH_BYNAMA(obj);
        }
    }
}

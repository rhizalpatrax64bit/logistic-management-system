using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RMS.COMMON;
using RMS.PROCESSING;
using System.Data;

namespace RMS.BUSSINES.DELIVERYORDER
{
    public class RMS_DETAILINVOICE
    {
        protected RMS.PROCESSING.DELIVERYORDER.RMS_DETAILINVOICE p = new RMS.PROCESSING.DELIVERYORDER.RMS_DETAILINVOICE();

        public DataTable GETKODE()
        {
            return p.GETKODE();
        }
        public void INSERT(RMS.COMMON.DELIVERYORDER.RMS_DETAILINVOICE obj)
        {
            p.INSERT(obj);
        }
        public void UPDATESETINVOICE(int _IDINV, string _NOCONNOTE)
        {
            p.UPDATESETINVOICE(_IDINV, _NOCONNOTE);
        }
        public void UPDATE(RMS.COMMON.DELIVERYORDER.RMS_DETAILINVOICE obj)
        {
            p.UPDATE(obj);
        }

        public void DELETE(RMS.COMMON.DELIVERYORDER.RMS_DETAILINVOICE obj)
        {
            p.DELETE(obj);
        }
        public DataTable SELECTPEMB(RMS.COMMON.DELIVERYORDER.RMS_DETAILINVOICE obj)
        {
            return p.SELECTPEMB(obj);
        }
        public DataTable SELECTPMBINV(RMS.COMMON.DELIVERYORDER.RMS_DETAILINVOICE obj)
        {
            return p.SELECTPMBINV(obj);
        }
        
        public DataTable SELECT(RMS.COMMON.DELIVERYORDER.RMS_DETAILINVOICE obj)
        {
            return p.SELECT(obj);
        }
        public DataTable SELECTGENERATEINVOICE(RMS.COMMON.DELIVERYORDER.RMS_DETAILINVOICE obj)
        {
            return p.SELECTGENERATEINVOICE(obj);
        }
        public DataTable SELECTINVOICECETAK(RMS.COMMON.DELIVERYORDER.RMS_DETAILINVOICE obj)
        {
            return p.SELECTINVOICECETAK(obj);
        }
        public DataTable SELECTLIKE(RMS.COMMON.DELIVERYORDER.RMS_DETAILINVOICE obj)
        {
            return p.SELECTLIKE(obj);
        }
        public DataTable SELECTINVOICE(RMS.COMMON.DELIVERYORDER.RMS_DETAILINVOICE obj)
        {
            return p.SELECTINVOICE(obj);
        }
        
        
        public DataTable SELECTIDSTT(RMS.COMMON.DELIVERYORDER.RMS_DETAILINVOICE obj)
        {
            return p.SELECTIDSTT(obj);
        }
        public DataTable SELECTAGENTBYID(RMS.COMMON.DELIVERYORDER.RMS_DETAILINVOICE obj)
        {
            return p.SELECTAGENTBYID(obj);
        }
        public DataTable SELECTKODEINVOICE(RMS.COMMON.DELIVERYORDER.RMS_DETAILINVOICE obj)
        {
            return p.SELECTKODEIVOICE(obj);
        }

        public DataTable SELECTFILTER(RMS.COMMON.DELIVERYORDER.RMS_DETAILINVOICE obj)
        {
            return p.SELECTFILTER(obj);
        }

        public DataTable CARI_TYPEOFPAYMENT(string _TOP)
        {
            return p.CARI_TYPEOFPAYMENT(_TOP);
        }
        public DataTable CARI_BYKODE(RMS.COMMON.DELIVERYORDER.RMS_DETAILINVOICE obj)
        {
            return p.CARI_BYKODE(obj);
        }
        public DataTable CARI_BYID(RMS.COMMON.DELIVERYORDER.RMS_DETAILINVOICE obj)
        {
            return p.CARI_BYID(obj);
        }

        public DataTable CARI_BYNAMA(RMS.COMMON.DELIVERYORDER.RMS_DETAILINVOICE obj)
        {
            return p.CARI_BYNAMA(obj);
        }

        public DataTable SEARCH_BYKODE(RMS.COMMON.DELIVERYORDER.RMS_DETAILINVOICE obj)
        {
            return p.SEARCH_BYKODE(obj);
        }

        public DataTable SEARCH_BYNAMA(RMS.COMMON.DELIVERYORDER.RMS_DETAILINVOICE obj)
        {
            return p.SEARCH_BYNAMA(obj);
        }
    }
}

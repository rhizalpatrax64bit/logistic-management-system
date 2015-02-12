using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RMS.COMMON;
using RMS.PROCESSING;
using System.Data;

namespace RMS.BUSSINES.DELIVERYORDER
{
    public class RMS_INVOICE
    {
        protected RMS.PROCESSING.DELIVERYORDER.RMS_INVOICE p = new RMS.PROCESSING.DELIVERYORDER.RMS_INVOICE();

        public DataTable SELECTNOINVOICE(string begin, string end, string kodecustomer)
        {
            return p.SELECTNOINVOICE(begin,end,kodecustomer);
        }
        public void INSERT(RMS.COMMON.DELIVERYORDER.RMS_INVOICE obj)
        {
            p.INSERT(obj);
        }

        public void UPDATE(RMS.COMMON.DELIVERYORDER.RMS_INVOICE obj)
        {
            p.UPDATE(obj);
        }

        public void DELETE(RMS.COMMON.DELIVERYORDER.RMS_INVOICE obj)
        {
            p.DELETE(obj);
        }

        public DataTable SELECT()
        {
            return p.SELECT();
        }

        public DataTable SEARCH_NOINVOICE(string _NOINVOICE)
        {
            return p.SEARCH_NOINVOICE(_NOINVOICE);
        }
       
        public DataTable CARI_BYNAMA(RMS.COMMON.DELIVERYORDER.RMS_INVOICE obj)
        {
            return p.CARI_BYNAMA(obj);
        }

        public DataTable SEARCH_BYKODE(RMS.COMMON.DELIVERYORDER.RMS_INVOICE obj)
        {
            return p.SEARCH_BYKODE(obj);
        }

        public DataTable SEARCH_BYNAMA(RMS.COMMON.DELIVERYORDER.RMS_INVOICE obj)
        {
            return p.SEARCH_BYNAMA(obj);
        }
    }
}

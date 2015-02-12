using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RMS.COMMON;
using RMS.PROCESSING;
using System.Data;

namespace RMS.BUSSINES.DELIVERYORDER
{
    public class RMS_PEMBAYARAN
    {
        protected RMS.PROCESSING.DELIVERYORDER.RMS_PEMBAYARAN p = new RMS.PROCESSING.DELIVERYORDER.RMS_PEMBAYARAN();

        public DataTable SELECTNOINVOICE(string begin, string end, string kodecustomer)
        {
            return p.SELECTNOINVOICE(begin,end,kodecustomer);
        }
        public void INSERT(RMS.COMMON.DELIVERYORDER.RMS_PEMBAYARAN obj)
        {
            p.INSERT(obj);
        }
        public void INSERTTAGIHAN(RMS.COMMON.DELIVERYORDER.RMS_PEMBAYARAN obj)
        {
            p.INSERTTAGIHAN(obj);
        }
        public void INSERTPMBINV(RMS.COMMON.DELIVERYORDER.RMS_PEMBAYARAN obj)
        {
            p.INSERTPEMBINV(obj);
        }

        public void UPDATE(RMS.COMMON.DELIVERYORDER.RMS_PEMBAYARAN obj)
        {
            p.UPDATE(obj);
        }
        public void UPDATETAGIHAN(RMS.COMMON.DELIVERYORDER.RMS_PEMBAYARAN obj)
        {
            p.UPDATETAGIHAN(obj);
        }
        public void DELETE(RMS.COMMON.DELIVERYORDER.RMS_PEMBAYARAN obj)
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
        public DataTable SEARCH_HISTORYTAGIHAN(RMS.COMMON.DELIVERYORDER.RMS_TAGIHAN obj)
        {
            return p.SELECTHISTORYTAGIHAN(obj);
        }
        public DataTable SEARCH_HISTORY(RMS.COMMON.DELIVERYORDER.RMS_PEMBAYARAN obj)
        {
            return p.SELECTHISTORY(obj);
        }
        public DataTable SEARCH_HISTORYINV(RMS.COMMON.DELIVERYORDER.RMS_PEMBAYARAN obj)
        {
            return p.SELECTHISTORYINv(obj);
        }
        public DataTable SEARCHPEMBINV_BYID(RMS.COMMON.DELIVERYORDER.RMS_PEMBAYARAN obj)
        {
            return p.SEARCHPEMBINV_BYID(obj);
        }
        public DataTable SEARCHPEMBTAGIHAN_BYID(RMS.COMMON.DELIVERYORDER.RMS_PEMBAYARAN obj)
        {
            return p.SEARCHPEMBTAGIHAN_BYID(obj);
        }
        public DataTable SELECTHISTORY_BYID(RMS.COMMON.DELIVERYORDER.RMS_PEMBAYARAN obj)
        {
            return p.SELECTHISTORY_BYID(obj);
        }

        public DataTable CARI_BYNAMA(RMS.COMMON.DELIVERYORDER.RMS_PEMBAYARAN obj)
        {
            return p.CARI_BYNAMA(obj);
        }

        public DataTable SEARCH_BYKODE(RMS.COMMON.DELIVERYORDER.RMS_PEMBAYARAN obj)
        {
            return p.SEARCH_BYKODE(obj);
        }

        public DataTable SEARCH_BYNAMA(RMS.COMMON.DELIVERYORDER.RMS_PEMBAYARAN obj)
        {
            return p.SEARCH_BYNAMA(obj);
        }
    }
}

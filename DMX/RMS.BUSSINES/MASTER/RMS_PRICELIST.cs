using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RMS.COMMON;
using RMS.PROCESSING;
using System.Data;

namespace RMS.BUSSINES.MASTER
{
    public class RMS_PRICELIST
    {
        protected RMS.PROCESSING.MASTER.RMS_PRICELIST p = new RMS.PROCESSING.MASTER.RMS_PRICELIST();

        public void INSERT(RMS.COMMON.MASTER.RMS_PRICELIST obj)
        {
            p.INSERT(obj);
        }

        public void UPDATE(RMS.COMMON.MASTER.RMS_PRICELIST obj)
        {
            p.UPDATE(obj);
        }

        public void DELETE(RMS.COMMON.MASTER.RMS_PRICELIST obj)
        {
            p.DELETE(obj);
        }

        public DataTable SELECT(RMS.COMMON.MASTER.RMS_PRICELIST obj)
        {
            return p.SELECT(obj);
        }
        public DataTable SELECTVALIDATE(RMS.COMMON.MASTER.RMS_PRICELIST obj)
        {
            return p.SELECTVALIDATE(obj);
        }
        
        public DataTable SELECTSCANRATE(RMS.COMMON.MASTER.RMS_PRICELIST obj)
        {
            return p.SELECTSCANRATE(obj);
        }
        
        public DataTable CARI_BYKODE_UPDATE(RMS.COMMON.MASTER.RMS_PRICELIST obj)
        {
            return p.CARI_BYKODE_UPDATE(obj);
        }
        public DataTable CARI_BYKODE(RMS.COMMON.MASTER.RMS_PRICELIST obj)
        {
            return p.CARI_BYKODE(obj);
        }
        public DataTable CARI_BYNAME(RMS.COMMON.MASTER.RMS_PRICELIST obj)
        {
            return p.CARI_BYNAME(obj);
        }
        public DataTable CARI_BYIDPRICELIST(RMS.COMMON.MASTER.RMS_PRICELIST obj)
        {
            return p.CARI_BYIDPRICELIST(obj);
        }

        public DataTable CARI_BYNAMA(RMS.COMMON.MASTER.RMS_PRICELIST obj)
        {
            return p.CARI_BYNAME(obj);
        }

        public DataTable SEARCH_BYKODE(RMS.COMMON.MASTER.RMS_PRICELIST obj)
        {
            return p.SEARCH_BYKODE(obj);
        }

        public DataTable SEARCH_BYNAMA(RMS.COMMON.MASTER.RMS_PRICELIST obj)
        {
            return p.SEARCH_BYNAMA(obj);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RMS.COMMON;
using RMS.PROCESSING;
using System.Data;

namespace RMS.BUSSINES.MASTER
{
    public class RMS_SUPPLIER
    {
        protected RMS.PROCESSING.MASTER.RMS_SUPPLIER p = new RMS.PROCESSING.MASTER.RMS_SUPPLIER();

        public DataTable GETKODE()
        {
            return p.GETKODE();
        }
        public void INSERT(RMS.COMMON.MASTER.RMS_SUPPLIER obj)
        {
            p.INSERT(obj);
        }

        public void UPDATE(RMS.COMMON.MASTER.RMS_SUPPLIER obj)
        {
            p.UPDATE(obj);
        }

        public void DELETE(RMS.COMMON.MASTER.RMS_SUPPLIER obj)
        {
            p.DELETE(obj);
        }

        public DataTable SELECT()
        {
            return p.SELECT();
        }

        public DataTable SELECTUDARA(RMS.COMMON.MASTER.RMS_SUPPLIER obj)
        {
            return p.SELECTUDARA(obj);
        }

        public DataTable SELECTUDARALIKE(RMS.COMMON.MASTER.RMS_SUPPLIER obj)
        {
            return p.SELECTUDARALIKE(obj);
        }
        public DataTable SELECTPRICELISTAGENT()
        {
            return p.SELECTPRICELISTAGENT();
        }

        public DataTable CARI_BYKODE_UPDATE(RMS.COMMON.MASTER.RMS_SUPPLIER obj)
        {
            return p.CARI_BYKODE_UPDATE(obj);
        }
        public DataTable CARI_BYKODE(RMS.COMMON.MASTER.RMS_SUPPLIER obj)
        {
            return p.CARI_BYKODE(obj);
        }
       
        public DataTable CARI_BYNAMA(RMS.COMMON.MASTER.RMS_SUPPLIER obj)
        {
            return p.CARI_BYNAMA(obj);
        }

        public DataTable SEARCH_BYKODE(RMS.COMMON.MASTER.RMS_SUPPLIER obj)
        {
            return p.SEARCH_BYKODE(obj);
        }

        public DataTable SEARCH_BYNAMA(RMS.COMMON.MASTER.RMS_SUPPLIER obj)
        {
            return p.SEARCH_BYNAMA(obj);
        }
        public DataTable SEARCH_BYNAMAPRICELIST(RMS.COMMON.MASTER.RMS_SUPPLIER obj)
        {
            return p.SEARCH_BYNAMAPRICELIST(obj);
        }
    }
}

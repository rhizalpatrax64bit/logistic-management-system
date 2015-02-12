using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RMS.COMMON;
using RMS.PROCESSING;
using System.Data;

namespace RMS.BUSSINES.MASTER
{
    public class RMS_PRICELISTAGENT
    {
        protected RMS.PROCESSING.MASTER.RMS_PRICELISTAGENT p = new RMS.PROCESSING.MASTER.RMS_PRICELISTAGENT();

        public void INSERT(RMS.COMMON.MASTER.RMS_PRICELISTAGENT obj)
        {
            p.INSERT(obj);
        }

        public void UPDATE(RMS.COMMON.MASTER.RMS_PRICELISTAGENT obj)
        {
            p.UPDATE(obj);
        }

        public void DELETE(RMS.COMMON.MASTER.RMS_PRICELISTAGENT obj)
        {
            p.DELETE(obj);
        }

        public DataTable SELECT(RMS.COMMON.MASTER.RMS_PRICELISTAGENT obj)
        {
            return p.SELECT(obj);
        }
        public DataTable SELECTVALIDATE(RMS.COMMON.MASTER.RMS_PRICELISTAGENT obj)
        {
            return p.SELECTVALIDATE(obj);
        }
        public DataTable VSELECT(RMS.COMMON.MASTER.RMS_PRICELISTAGENT obj)
        {
            return p.V_SELECT(obj);
        }
        public DataTable VSELECTLIKE(RMS.COMMON.MASTER.RMS_PRICELISTAGENT obj)
        {
            return p.V_SELECTLIKE(obj);
        }
        public DataTable CARI_BYKODE_UPDATE(RMS.COMMON.MASTER.RMS_PRICELISTAGENT obj)
        {
            return p.CARI_BYKODE_UPDATE(obj);
        }
        public DataTable CARI_BYKODE(RMS.COMMON.MASTER.RMS_PRICELISTAGENT obj)
        {
            return p.CARI_BYKODE(obj);
        }
        public DataTable CARI_BYIDPRICELIST(RMS.COMMON.MASTER.RMS_PRICELISTAGENT obj)
        {
            return p.CARI_BYIDPRICELIST(obj);
        }

        public DataTable CARI_BYNAMA(RMS.COMMON.MASTER.RMS_PRICELISTAGENT obj)
        {
            return p.CARI_BYNAMA(obj);
        }

        public DataTable SEARCH_BYKODE(RMS.COMMON.MASTER.RMS_PRICELISTAGENT obj)
        {
            return p.SEARCH_BYKODE(obj);
        }

        public DataTable SEARCH_BYNAMA(RMS.COMMON.MASTER.RMS_PRICELISTAGENT obj)
        {
            return p.SEARCH_BYNAMA(obj);
        }
    }
}

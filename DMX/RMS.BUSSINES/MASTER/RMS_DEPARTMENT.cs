using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RMS.COMMON;
using RMS.PROCESSING;
using System.Data;

namespace RMS.BUSSINES.MASTER
{
    public class RMS_DEPARTMENT
    {
        protected RMS.PROCESSING.MASTER.RMS_DEPARTMENT p = new RMS.PROCESSING.MASTER.RMS_DEPARTMENT();

        public void INSERT(RMS.COMMON.MASTER.RMS_DEPARTMENT obj)
        {
            p.INSERT(obj);
        }

        public void UPDATE(RMS.COMMON.MASTER.RMS_DEPARTMENT obj)
        {
            p.UPDATE(obj);
        }

        public void DELETE(RMS.COMMON.MASTER.RMS_DEPARTMENT obj)
        {
            p.DELETE(obj);
        }

        public DataTable SELECT()
        {
           return p.SELECT();
        }

        public DataTable CARI_BYKODE(RMS.COMMON.MASTER.RMS_DEPARTMENT obj)
        {
            return p.CARI_BYKODE(obj);
        }

        public DataTable CARI_BYNAMA(RMS.COMMON.MASTER.RMS_DEPARTMENT obj)
        {
            return p.CARI_BYNAMA(obj);
        }

        public DataTable SEARCH_BYKODE(RMS.COMMON.MASTER.RMS_DEPARTMENT obj)
        {
            return p.SEARCH_BYKODE(obj);
        }

        public DataTable SEARCH_BYNAMA(RMS.COMMON.MASTER.RMS_DEPARTMENT obj)
        {
            return p.SEARCH_BYNAMA(obj);
        }

    }
}

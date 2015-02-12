using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RMS.COMMON;
using RMS.PROCESSING;
using System.Data;

namespace RMS.BUSSINES.MASTER
{
    public class RMS_SATUAN
    {
        protected RMS.PROCESSING.MASTER.RMS_SATUAN p = new RMS.PROCESSING.MASTER.RMS_SATUAN();

        public void INSERT(RMS.COMMON.MASTER.RMS_SATUAN obj)
        {
            p.INSERT(obj);
        }

        public void UPDATE(RMS.COMMON.MASTER.RMS_SATUAN obj)
        {
            p.UPDATE(obj);
        }

        public void DELETE(RMS.COMMON.MASTER.RMS_SATUAN obj)
        {
            p.DELETE(obj);
        }

        public DataTable SELECT()
        {
            return p.SELECT();
        }

        public DataTable CARI_BYKODE(RMS.COMMON.MASTER.RMS_SATUAN obj)
        {
            return p.CARI_BYKODE(obj);
        }

        public DataTable CARI_BYNAMA(RMS.COMMON.MASTER.RMS_SATUAN obj)
        {
            return p.CARI_BYNAMA(obj);
        }

        public DataTable SEARCH_BYKODE(RMS.COMMON.MASTER.RMS_SATUAN obj)
        {
            return p.SEARCH_BYKODE(obj);
        }

        public DataTable SEARCH_BYNAMA(RMS.COMMON.MASTER.RMS_SATUAN obj)
        {
            return p.SEARCH_BYNAMA(obj);
        }
    }
}

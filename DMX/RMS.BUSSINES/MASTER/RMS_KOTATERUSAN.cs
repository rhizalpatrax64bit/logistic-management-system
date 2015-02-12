using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RMS.COMMON;
using RMS.PROCESSING;
using System.Data;

namespace RMS.BUSSINES.MASTER
{
    public class RMS_KOTATERUSAN
    {
        protected RMS.PROCESSING.MASTER.RMS_KOTATERUSAN p = new RMS.PROCESSING.MASTER.RMS_KOTATERUSAN();

        public void INSERT(RMS.COMMON.MASTER.RMS_KOTATERUSAN obj)
        {
            p.INSERT(obj);
        }

        public void UPDATE(RMS.COMMON.MASTER.RMS_KOTATERUSAN obj)
        {
            p.UPDATE(obj);
        }

        public void DELETE(RMS.COMMON.MASTER.RMS_KOTATERUSAN obj)
        {
            p.DELETE(obj);
        }

        public DataTable SELECT()
        {
            return p.SELECT();
        }

        public DataTable CARI_BYKODE(RMS.COMMON.MASTER.RMS_KOTATERUSAN obj)
        {
            return p.CARI_BYKODE(obj);
        }

        public DataTable CARI_BYNAMA(RMS.COMMON.MASTER.RMS_KOTATERUSAN obj)
        {
            return p.CARI_BYNAMA(obj);
        }

        public DataTable SEARCH_BYKODE(RMS.COMMON.MASTER.RMS_KOTATERUSAN obj)
        {
            return p.SEARCH_BYKODE(obj);
        }

        public DataTable SEARCH_BYNAMA(RMS.COMMON.MASTER.RMS_KOTATERUSAN obj)
        {
            return p.SEARCH_BYNAMA(obj);
        }
    }
}

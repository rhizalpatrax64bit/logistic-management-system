using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RMS.COMMON;
using RMS.PROCESSING;
using System.Data;

namespace RMS.BUSSINES.MASTER
{
    public class RMS_BARANG
    {
        protected RMS.PROCESSING.MASTER.RMS_BARANG p = new RMS.PROCESSING.MASTER.RMS_BARANG();
        public void INSERT(RMS.COMMON.MASTER.RMS_BARANG obj)
        {
            p.INSERT(obj);
        }
        public DataTable SELECT()
        {
            return p.SELECT();
        }

        public DataTable CARI_BYKODE(RMS.COMMON.MASTER.RMS_BARANG obj)
        {
            return p.CARI_BYKODE(obj);
        }

        public DataTable CARI_BYBARCODE(RMS.COMMON.MASTER.RMS_BARANG obj)
        {
            return p.CARI_BYBARCODE(obj);
        }

        public DataTable SEARCH_BYKODE(RMS.COMMON.MASTER.RMS_BARANG obj)
        {
            return p.SEARCH_BYKODE(obj);
        }

        public DataTable SEARCH_BYNAMA(RMS.COMMON.MASTER.RMS_BARANG obj)
        {
            return p.SEARCH_BYNAMA(obj);
        }
    }
}

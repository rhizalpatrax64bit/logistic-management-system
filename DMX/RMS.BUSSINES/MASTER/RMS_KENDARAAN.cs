using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RMS.COMMON;
using RMS.PROCESSING;
using System.Data;


namespace RMS.BUSSINES.MASTER
{
    public class RMS_KENDARAAN
    {
        protected RMS.PROCESSING.MASTER.RMS_KENDARAAN p = new RMS.PROCESSING.MASTER.RMS_KENDARAAN();

        public DataTable GETKODE()
        {
            return p.GETKODE();
        }
        public void INSERT(RMS.COMMON.MASTER.RMS_KENDARAAN obj)
        {
            p.INSERT(obj);
        }

        public void UPDATE(RMS.COMMON.MASTER.RMS_KENDARAAN obj)
        {
            p.UPDATE(obj);
        }

        public void DELETE(RMS.COMMON.MASTER.RMS_KENDARAAN obj)
        {
            p.DELETE(obj);
        }

        public DataTable SELECT()
        {
            return p.SELECT();
        }

        public DataTable CARI_BYKODE(RMS.COMMON.MASTER.RMS_KENDARAAN obj)
        {
            return p.CARI_BYKODE(obj);
        }

        public DataTable SEARCHLIKE(RMS.COMMON.MASTER.RMS_KENDARAAN obj)
        {
            return p.SEARCHLIKE(obj);
        }
        public DataTable CARI_BYNAMA(RMS.COMMON.MASTER.RMS_KENDARAAN obj)
        {
            return p.CARI_BYNAMA(obj);
        }

        public DataTable SEARCH_BYKODE(RMS.COMMON.MASTER.RMS_KENDARAAN obj)
        {
            return p.SEARCH_BYKODE(obj);
        }

        public DataTable SEARCH_BYNAMA(RMS.COMMON.MASTER.RMS_KENDARAAN obj)
        {
            return p.SEARCH_BYNAMA(obj);
        }
    }
}

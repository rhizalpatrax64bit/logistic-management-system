using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RMS.COMMON;
using RMS.PROCESSING;
using System.Data;

namespace RMS.BUSSINES.MASTER
{
    public class RMS_KOTA
    {
        protected RMS.PROCESSING.MASTER.RMS_KOTA p = new RMS.PROCESSING.MASTER.RMS_KOTA();

        public void INSERT(RMS.COMMON.MASTER.RMS_KOTA obj)
        {
            p.INSERT(obj);
        }

        public void UPDATE(RMS.COMMON.MASTER.RMS_KOTA obj)
        {
            p.UPDATE(obj);
        }
        public void INSERTKOTA(RMS.COMMON.MASTER.RMS_KOTA obj)
        {
            p.INSERTKOTA(obj);
        }
        public void INSERTTERUSAN(RMS.COMMON.MASTER.RMS_KOTA obj)
        {
            p.INSERTTERUSAN(obj);
        }

        public void UPDATEKOTA(RMS.COMMON.MASTER.RMS_KOTA obj)
        {
            p.UPDATEKOTA(obj);
        }

        public void DELETE(RMS.COMMON.MASTER.RMS_KOTA obj)
        {
            p.DELETE(obj);
        }
        public void DELETETERUSAN(RMS.COMMON.MASTER.RMS_KOTA obj)
        {
            p.DELETETERUSAN(obj);
        }

        public DataTable SELECT()
        {
            return p.SELECT();
        }
        public DataTable SELECTKOTA()
        {
            return p.SELECTKOTA();
        }
        public DataTable GETAREA_BYKODE(RMS.COMMON.MASTER.RMS_KOTA obj)
        {
            return p.GETAREA_BYKODE(obj);
        }
        public DataTable GETKOTA(RMS.COMMON.MASTER.RMS_KOTA obj)
        {
            return p.GETKOTA(obj);
        }
        public DataTable GETTERUSAN_BYNAMA(RMS.COMMON.MASTER.RMS_KOTA obj)
        {
            return p.GETTERUSAN_BYNAMA(obj);
        }
        public DataTable GETTERUSAN_AUTO()
        {
            return p.GETTERUSAN_AUTO();
        }
        public DataTable GET_TERUSANBYID(RMS.COMMON.MASTER.RMS_KOTA obj)
        {
            return p.GET_TERUSANBYID(obj);
        }
        public DataTable CARI_BYKODE(RMS.COMMON.MASTER.RMS_KOTA obj)
        {
            return p.CARI_BYKODE(obj);
        }

        public DataTable CARI_BYNAMA(RMS.COMMON.MASTER.RMS_KOTA obj)
        {
            return p.CARI_BYNAMA(obj);
        }
        public DataTable CARI_BYIDAREA(RMS.COMMON.MASTER.RMS_KOTA obj)
        {
            return p.CARI_BYIDAREA(obj);
        }
        public DataTable CARI_BYKODEKOTA(RMS.COMMON.MASTER.RMS_KOTA obj)
        {
            return p.CARI_BYKODEKOTA(obj);
        }
        public DataTable CARI_BYIDKOTA(RMS.COMMON.MASTER.RMS_KOTA obj)
        {
            return p.CARI_BYIDKOTA(obj);
        }
        // PENCARIAN AREA
        public DataTable SEARCH_BYKODEAREA(RMS.COMMON.MASTER.RMS_KOTA obj)
        {
            return p.SEARCH_BYKODEAREA(obj);
        }

        public DataTable SEARCH_BYNAMAAREA(RMS.COMMON.MASTER.RMS_KOTA obj)
        {
            return p.SEARCH_BYNAMAAREA(obj);
        }
        public DataTable SEARCH_BYKODE(RMS.COMMON.MASTER.RMS_KOTA obj)
        {
            return p.SEARCH_BYKODE(obj);
        }

        public DataTable SEARCH_BYNAMA(RMS.COMMON.MASTER.RMS_KOTA obj)
        {
            return p.SEARCH_BYNAMA(obj);
        }
        public DataTable SEARCH_BYNAMAAREAKOTA(RMS.COMMON.MASTER.RMS_KOTA obj)
        {
            return p.SEARCH_BYNAMAAREAKOTA(obj);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RMS.COMMON;
using RMS.PROCESSING;
using System.Data;

namespace RMS.BUSSINES.MASTER
{
    public class RMS_JENISANGGOTA
    {
        protected RMS.PROCESSING.MASTER.RMS_JENISANGGOTA p = new RMS.PROCESSING.MASTER.RMS_JENISANGGOTA();

        public void INSERT(RMS.COMMON.MASTER.RMS_JENISANGGOTA obj)
        {
            p.INSERT(obj);
        }

        public void DELETE(RMS.COMMON.MASTER.RMS_JENISANGGOTA obj)
        {
            p.DELETE(obj);
        }

        public DataTable SELECT()
        {
            return p.SELECT();
        }

        public DataTable CARI_BYKODE(RMS.COMMON.MASTER.RMS_JENISANGGOTA obj)
        {
            return p.CARI_BYKODE(obj);
        }
    }
}

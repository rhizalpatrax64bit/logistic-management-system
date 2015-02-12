using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RMS.COMMON;
using RMS.PROCESSING;
using System.Data;

namespace RMS.BUSSINES.LAPORAN
{
    public class RMS_LAPORANPIUTANG
    {
        protected RMS.PROCESSING.LAPORAN.RMS_LAPORANPIUTANG p = new RMS.PROCESSING.LAPORAN.RMS_LAPORANPIUTANG();
                      
              

        public DataTable SELECT(RMS.COMMON.LAPORAN.RMS_LAPORANPIUTANG obj)
        {
            return p.SELECT(obj);
        }
        /*
        public DataTable CARI_BYKODE(RMS.COMMON.MASTER.RMS_GUDANG obj)
        {
            return p.CARI_BYKODE(obj);
        }
        */
        
    }
}

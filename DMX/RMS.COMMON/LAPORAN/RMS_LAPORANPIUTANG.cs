using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RMS.COMMON.LAPORAN
{
    public class RMS_LAPORANPIUTANG
    {
        public string STARTDATE { get; set; }
        public string ENDDATE { get; set; }
        public int NO { get; set; }
        public string TGLINV { get; set; }       
        public string NOINV { get; set; }
        public string TGLKONTRABON { get; set; }
        public string KONTRABON { get; set; }
        public string CUSTOMER { get; set; }
        public string MARKETING { get; set; }
        public float JUMLAHINV { get; set; }
        public float TOTALINV { get; set; }
        public string JATUHTEMPO { get; set; }
        public string TGLBAYAR { get; set; }
        public float JUMLAHBAYAR { get; set; }
        public float TOTALBAYAR { get; set; }
        public float SISAPIUTANG { get; set; }
        
    }
}

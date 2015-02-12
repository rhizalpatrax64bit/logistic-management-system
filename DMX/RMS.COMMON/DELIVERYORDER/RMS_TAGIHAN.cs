using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RMS.COMMON.DELIVERYORDER
{
    public class RMS_TAGIHAN
    {
        public int ID { get; set; }
        public int IDAGENT { get; set; }
        public string NAMAAGENT { get; set; }
        public string STARTDATE { get; set; }
        public string ENDDATE { get; set; }
        public string TGLDATANGINV { get; set; }
        public string TGLINV { get; set; }
        public string NOINV { get; set; }
        public float JUMLAHTAGIHAN { get; set; }
        public float JUMLAHBAYAR { get; set; }
        public float SISA { get; set; }
        public string KETERANGAN { get; set; }
        public string STATUS { get; set; }
        
    }
}


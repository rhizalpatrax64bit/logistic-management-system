using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RMS.COMMON.MASTER
{
    public class RMS_KENDARAAN
    {
        public int ID { get; set; }
        public string NOPOL { get; set; }
        public int IDJENISKENDARAAN { get; set; }  
        public float MAXMUATAN { get; set; }
        public float MAXVOLUME { get; set; }
        public bool STATUS { get; set; }
        public int IDDRIVER { get; set; }
        public int IDHELPER { get; set; }
        public bool ISACTIVE { get; set; }

        public string JENISKENDARAAN { get; set; }
        public string KODEDRIVER { get; set; }
        public string KODEHELPER { get; set; }
        public string NAMADRIVER { get; set; }
        public string NAMAHELPER { get; set; }
        public string STATUSKENDARAAN { get; set; }

    }
}

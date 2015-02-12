using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RMS.COMMON.DELIVERYORDER
{
    public class RMS_INVOICE
    {
        public int ID { get; set; }
        public string TGLINVOICE { get; set; }
        public string KODEINVOICE { get; set; }
        public string KODECUSTOMER { get; set; }
        public string NAMACUSTOMER { get; set; }
        public string KETERANGAN { get; set; }
        public float PACKING { get; set; }
        public float INSURANCE { get; set; }
        public float CHARGE { get; set; }
        public float TOTALBAYAR { get; set; }
        public float TOTALKEKURANGAN { get; set; }
        

    }
}

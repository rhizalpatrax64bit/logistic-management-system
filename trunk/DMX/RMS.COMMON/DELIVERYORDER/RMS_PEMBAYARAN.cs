using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RMS.COMMON.DELIVERYORDER
{
    public class RMS_PEMBAYARAN
    {
        public int IDTAGIHAN { get; set; }
        public int IDPEMBAYARAN { get; set; }
        public int IDINVOICE { get; set; }
        public string NOTRANSAKSI { get; set; }
        public string NOTRANSFER { get; set; }
        public string TGLBAYAR { get; set; }
        public int IDSTT { get; set; }
        public int IDMETODEBAYAR { get; set; }
        public int IDJENISBAYAR { get; set; }
        public float TOTALBAYAR { get; set; }
        
    }
}

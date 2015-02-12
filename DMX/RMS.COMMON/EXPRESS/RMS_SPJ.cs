using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RMS.COMMON.EXPRESS
{
    public class RMS_SPJ
    {
        //pure database field
        public int ID { get; set; }
        public string NOSPJ { get; set; }
        public int IDKENDARAAN { get; set; }
        public int IDDRIVER { get; set; }
        public int IDCODRIVER { get; set; }
        public string KODEDRIVER { get; set; }
        public string KODECODRIVER { get; set; }
        public string NAMADRIVER { get; set; }
        public string NAMACODRIVER { get; set; }
        public string TGLPENGIRIMAN { get; set; }        
       
        //optional tambahan untuk retriave form edit
        public int IDDETAIL { get; set; }
        public string NORESI { get; set; }
        public string STARTDATE { get; set; }
        public string ENDDATE { get; set; }
        public string NOPOLISI { get; set; }
        public string JENISKENDARAAN { get; set; }
        public int STATUS { get; set; }   // MANIFESTED TO DELIVERY (Proses Pengiriman)
        public string JENISKIRIMAN { get; set; }
        public string  KODECUSTOMER { get; set; }
        public string  NAMACUSTOMER { get; set; }
        public string PENERIMA { get; set; }
        public string PHONEPENERIMA { get; set; }
        public string FAXPENERIMA { get; set; }
        public string ALAMATPENERIMA { get; set; }
     
                    
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RMS.COMMON.EXPRESS
{
    public class RMS_TRANSAKSI
    {
        // pure database field
         public int ID { get; set;}
         public string NORESI { get; set; }
         public int IDCUSTOMER { get; set; }
         public int IDTARIF { get; set; }
         public int IDPENERIMA { get; set; }
         public string TGLTERIMA { get; set; }
         public string TGLESTIMASI { get; set; }
         public int JUMLAH { get; set; }
         public float BERAT { get; set; }
         public float DIM_P { get; set; }
         public float DIM_L { get; set; }
         public float DIM_T { get; set; }
         public float RATE_KIRIM { get; set; }
         public float CHARGE_KIRIM { get; set; }
         public float PPNPERCENT { get; set; }
         public float PPN { get; set; }
         public float CHARGE_PACKING { get; set; }
         public float OTHER_CHARGE { get; set; }
         public float DISCPERCENT { get; set; }
         public float DISC { get; set; }
         public float INCURANCEPERCENT { get; set; }
         public float INCURANCE { get; set; }
         public float NBARANGINSURANCE { get; set; }
         public string TGLPENGIRIMAN { get; set; }
         public string TGLPENGAMBILAN { get; set; }
         public float TOTAL { get; set; }
         public float BAYAR { get; set; }
         public float SISA { get; set; }
         public float VOID { get; set; }
         public int STATUS { get; set; }
         public string STATUSORDER { get; set; }
         public string PENERIMABARANG { get; set; }
         public string KETERANGANISI { get; set; }
         public string INSTRUKSIKHUSUS { get; set; }
        
       
        // optional tambahan
         public string STARTDATE { get; set; }
         public string ENDDATE { get; set; }
         public string NAMALAYANAN { get; set; }
         public string JENISKIRIMAN { get; set; }
         public string  KODECUSTOMER { get; set; }
         public string  NAMACUSTOMER { get; set; }
         public string PENERIMA { get; set; }
         public string PHONEPENERIMA { get; set; }
         public string FAXPENERIMA { get; set; }
         public string ALAMATPENERIMA { get; set; }
     
                    
    }
}

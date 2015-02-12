using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RMS.COMMON.MASTER
{
    public class RMS_TARIF
    {
        public int ID { get; set; }		
        public float IDTARIF { get; set; } 
        public int IDKOTAASAL { get; set; }
        public int IDKOTATUJUAN { get; set; }
        public int IDJENISKIRIMAN { get; set; }
        public int IDPRODUK { get; set; }
        public string KODEKOTAASAL { get; set; }
        public string KODEKOTA { get; set; }
        public string KOTAASAL { get; set; }
        public string KOTATUJUAN { get; set; }
        public string KODE { get; set; }
        public string PRODUK { get; set; }
        public string KODEJENISKIRIMAN { get; set; }
        public string JENISKIRIMAN { get; set; }
        public float TARIF { get; set; }
        public float TARIFBERIKUT { get; set; }
        public string ETD { get; set; }
        public bool ISACTIVE { get; set; }
        public string KETERANGAN { get; set; }	
      

    }
}

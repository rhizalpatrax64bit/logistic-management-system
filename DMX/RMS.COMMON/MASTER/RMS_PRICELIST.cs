using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RMS.COMMON.MASTER
{
    public class RMS_PRICELIST
    {
        public int IDPRICELIST { get; set; }
        public int IDCUSTOMER { get; set; }
        public string KODECUSTOMER { get; set; }
        public string NAMACUSTOMER { get; set; }
        public int IDSERVICE { get; set; }
        public int IDHANDLING { get; set; }
        public string JNSCOST { get; set; }
        public int IDASAL { get; set; }
        public string KODEAREAASAL { get; set; }
        public string NAMAASAL { get; set; }
        public int IDTUJUAN { get; set; }
        public string KODEAREATUJUAN { get; set; }
        public string NAMATUJUAN { get; set; }
        public int IDTERUSAN { get; set; }
        public string NAMATERUSAN { get; set; }
        public string KODEATERUSAN { get; set; }
        public float CHARGE { get; set; }          
        public float RC { get; set; }
        public string DURASIWAKTU { get; set; }
        public int IDAGENT { get; set; }
        public string KODEAGENT { get; set; }
        public string NAMAAGENT { get; set; }
        public string KETERANGAN { get; set; }
        public bool ISAKTIF { get; set; }
      
    }
}

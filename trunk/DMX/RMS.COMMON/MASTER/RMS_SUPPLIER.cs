using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RMS.COMMON.MASTER
{
    public class RMS_SUPPLIER
    {
        public int IDAGENT { get; set; }
        public int HANDLING_ID { get; set; }
        public string HANDLING { get; set; }
        public string JNSCOST { get; set; }
        public string KODE { get; set; }
        public string NAMA { get; set; }
        public string ALAMAT { get; set; }
        public string CP { get; set; }       
        public string TELEPON { get; set; }  
        public string NPWP { get; set; }
        public string BANK { get; set; }
        public string ACCOUNT { get; set; }
        public string ATASNAMA { get; set; }
        public bool IS_DELIVERY { get; set; }
        public bool IS_AF { get; set; }
        public bool IS_TRUCK { get; set; }
        public bool IS_WH { get; set; }
        public bool IS_GRDH { get; set; }
        public bool IS_SHIPPING { get; set; }
        public bool IS_RA { get; set; }
        public string CHARGE { get; set; }
    }
}

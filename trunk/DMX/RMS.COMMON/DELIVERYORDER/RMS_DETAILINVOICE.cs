using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RMS.COMMON.DELIVERYORDER
{
    public class RMS_DETAILINVOICE
    {
        // pure database field
         public int ID { get; set;}
         public string STARTDATE { get; set;}
         public string ENDDATE { get; set;}
         public string STATUSSTT { get; set; }
         public int IDCUSTOMER { get; set; }
         public string NAMACUSTOMER { get; set; }
         public string NOCONNOTE { get; set;}
         public string TGLCONNOTE { get; set;}
         public string TGLMANIFEST { get; set; }
         public string NOACCOUNT { get; set; }
         public string NOREFERENSI { get; set; }
         public string CONSIGNEE { get; set; }
         public string PHONE { get; set; }
         public string FAX { get; set; }
         public string ALAMAT { get; set; } 	
         public int IDSTATUSSTT { get; set; }
         public int IDSERVICE { get; set; }
         public int IDHANDLING { get; set; }
         public int IDORIGIN { get; set; }
         public int IDDESC { get; set; }
         public int PCS { get; set; }
         public float WEIGHT { get; set;}
         public float WEIGHTDIM { get; set; }
         public float DIM_P { get; set; }
         public float DIM_L { get; set; }
         public float DIM_T { get; set; }
         public float RATE_KIRIM { get; set; }
         public float CHARGE_KIRIM { get; set; }
         public float CHARGE_DIM { get; set; }
         public float PPNPERCENT { get; set; }
         public float PPN { get; set; }
         public float NBARANGINSURANCE { get; set; }
         public float INCURANCEPERCENT { get; set; }
         public float INSURANCE { get; set; }
         public float PACKING { get; set; }
         public int IDTERUSAN { get; set; }
         public float CHARGE_TERUSAN { get; set; }
         public int IDMARKETING {get;set;}
         public int IDAGENT { get; set; }
         public int IDA_SHIPPING { get; set; }
         public int IDA_DELIVERY { get; set;}
         public int IDA_WAREHOUSE { get; set; }
         public int IDA_RA { get; set; }
         public int IDA_TRUCKING { get; set; }
         public int IDA_SMU { get; set; }
         public string NOSMU { get; set; }
         public int IDA_GRDH { get; set; }
         public float COST_SHIPPING { get; set;}
         public float COST_DELIVERY { get; set; }
         public float COST_TRUCKING { get; set; }
         public float COST_WAREHOUSE { get; set; }
         public float COST_RA { get; set; }
         public float COST_SMU { get; set; }
         public float COST_GRDH { get; set; }
         public float COST_FEEMARKETING { get; set; }
         public float COST_REFUNDCUST { get; set; }
         public int IDSTATUSBAYAR { get; set;}
         public float TOTAL_CHARGE { get; set;}
         public float TOTAL_COST { get; set;}
         public float TOTAL_PROFIT { get; set; }
         public string KETERANGANISI { get; set; }
         public string INSTRUKSIKHUSUS { get; set; }

        // tambahan untuk status pembayaran
         public float TBAYAR { get; set; }
         public float SISA { get; set; }
         public string STATUS { get; set; }

        // optional tambahan
         public string SERVICE { get; set; }
         public string ARMADA { get; set; }
         public string  KODEIVOICE { get; set; }
         public string _KOTATERUSAN { get; set; }
         public string _KAGENT_SHIPPING { get; set; }
         public string _KAGENT_DELIVERY { get; set; }
         public string _KAGENT_WAREHOUSE { get; set; }
         public string _KAGENT_RA { get; set; }
         public string _KAGENT_TRUCKING { get; set; }
         public string _KAGENT_SMU { get; set; }
         public string _KAGENT_GRDH { get; set; }
         public string _KODECUSTOMER { get; set; }
         public string NAMAKOTAORIGIN { get; set; }
         public string NAMAKOTADEST { get; set; }
         public string MARKETING { get; set; }
         public string STATUSPEMBAYARAN { get; set; }
         public int ISINVOICE { get; set; }
                    
    }
}

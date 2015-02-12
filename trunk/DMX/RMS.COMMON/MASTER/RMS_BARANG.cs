using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RMS.COMMON.MASTER
{
    public class RMS_BARANG
    {
        public string NAMABARANG { get; set; }
        public string KODEBARANG { get; set; }
        public string BARCODE { get; set; }
        public string KODESATUAN { get; set; }
        public string NAMASATUAN { get; set; }
        public string KODEDEPT { get; set; }
        public string NAMADEPT { get; set; }

        public int QTYBELI1 { get; set; }
        public int QTYBELI2 { get; set; }
        public int QTYBONUS { get; set; }
        public int STOK { get; set; }
        public int TOTALPCS { get; set; }
        public int TOTALPCSBONUS { get; set; }
        public decimal HARGABELI1 { get; set; }
        public decimal HARGABELI2 { get; set; }
        public decimal BRUTO { get; set; }
        // DISKON
        public float DISKONRP1 { get; set; }
        public float DISKONRP1A { get; set; }
        public float DISKONRP2 { get; set; }
        public float DISKONRP2A { get; set; }
        public float DISKONPSN1 { get; set; }
        public float DISKONPSN1A { get; set; }
        public float DISKONPSN2 { get; set; }
        public float DISKONPSN2A { get; set; }
        public float DISKONPSN3 { get; set; }
        public float DISKONPSN3A { get; set; }
        public float DISKONPSN4 { get; set; }
        public float DISKONPSN4A { get; set; }
        public float DISKONPSN5 { get; set; }
        public float DISKONPSN5A { get; set; }

        //PPN
        public float PPN { get; set; }
        public float PPNA { get; set; }

        public decimal NETTO { get; set; }
        public decimal HARGAPOKOKBELI1 { get; set; }
        public decimal HARGAPOKOKBELI2 { get; set; }

        public float MARGIN1 { get; set; }
        public float MARGIN2 { get; set; }
        public float BATASMARGIN1 { get; set; }
        public float BATASMARGIN2 { get; set; }

        public decimal HARGAJUAL1 { get; set; }
        public decimal HARGAJUAL2 { get; set; }

        public float MARGINSPESIAL { get; set; }
        public decimal HARGASPESIAL { get; set; }

        // HARGA BERTINGKAT
        public int QTY1 { get; set; }
        public int QTY2 { get; set; }
        public int QTY3 { get; set; }
        public int QTY4 { get; set; }
        public int QTY5 { get; set; }
        public float MRG1 { get; set; }
        public float MRG2 { get; set; }
        public float MRG3 { get; set; }
        public float MRG4 { get; set; }
        public float MRG5 { get; set; }
        public decimal HRG1 { get; set; }
        public decimal HRG2 { get; set; }
        public decimal HRG3 { get; set; }
        public decimal HRG4 { get; set; }
        public decimal HRG5 { get; set; }

        public DateTime TGLEXPIRED { get; set; }
        public DateTime TGLBELI { get; set; }
        public DateTime TGLUPDATE { get; set; }
        public string GUDANG { get; set; }

        public bool RESET { get; set; }
 
    }
}

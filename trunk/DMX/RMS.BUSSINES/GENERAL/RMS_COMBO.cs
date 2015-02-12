using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RMS.COMMON;
using RMS.PROCESSING;
using System.Data;

namespace RMS.BUSSINES.GENERAL
{
    public class RMS_COMBO
    {
        protected RMS.PROCESSING.GENERAL.RMS_COMBO p = new RMS.PROCESSING.GENERAL.RMS_COMBO();

       
        public DataTable SELECTKOTA()
        {
            return p.SELECTKOTA();           
            
        }
        public DataTable SELECTJENISBAYAR()
        {
            return p.SELECTJENISBAYAR();           
            
        }
        public DataTable SELECTLAYANAN()
        {            
            return p.SELECTLAYANAN();
        }
        public DataTable SELECTMODAKIRIM()
        {
            return p.SELECTMODAKIRIM();
          
        }
        public DataTable SELECTAREA()
        {
            return p.SELECTAREA();

        }
        public DataTable SELECTSTATUSBAYAR()
        {
            return p.SELECTSTATUSBAYAR();           
           
        }
        public DataTable SELECTSTATUSSTT()
        {
            return p.SELECTSTATUSSTT();

        }
        // Express Module
        public DataTable SELECTSTATUSORDER()
        {
            return p.SELECTSTATUSORDER();

        }
        public DataTable SELECTJENISKIRIMAN()
        {
            return p.SELECTJENISKIRIMAN();
        }
        public DataTable SELECTPRODUKEXPRESS()
        {
            return p.SELECTPRODUKEXPRESS();
        }
        public DataTable SELECTJENISKENDARAAN()
        {
            return p.SELECTJENISKENDARAAN();
        }

        
    }
}

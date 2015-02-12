using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RMS.COMMON;
using RMS.PROCESSING;
using System.Data;

namespace RMS.BUSSINES.MASTER
{
    public class RMS_USER
    {
        protected RMS.PROCESSING.MASTER.RMS_USER p = new RMS.PROCESSING.MASTER.RMS_USER();

        public void INSERT(RMS.COMMON.MASTER.RMS_USER obj)
        {
            p.INSERT(obj);
        }
        public void UpdateIsLogin(RMS.COMMON.MASTER.RMS_USER obj, int isLogin)
        {
            p.UpdateIsLogin(obj, isLogin);
        }
        public bool IsAuthenticate(RMS.COMMON.MASTER.RMS_USER obj)
        {
            return p.IsAuthenticate(obj);
        }
        public string EncodePassword(RMS.COMMON.MASTER.RMS_USER obj)
        {
            return p.EncodePassword(obj);
        }
        public string DecodePassword(RMS.COMMON.MASTER.RMS_USER obj)
        {
            return p.DecodePassword(obj);
        }
        public void UPDATE(RMS.COMMON.MASTER.RMS_USER obj)
        {
            p.UPDATE(obj);
        }

        public void DELETE(RMS.COMMON.MASTER.RMS_USER obj)
        {
            p.DELETE(obj);
        }
        public DataTable SELECT()
        {
            return p.SELECT();
        }
        public DataTable SELECTLOGIN(RMS.COMMON.MASTER.RMS_USER obj)
        {
            return p.SELECTLOGIN(obj);
        }

        public DataTable CARI_BYKODE(RMS.COMMON.MASTER.RMS_USER obj)
        {
            return p.CARI_BYKODE(obj);
        }

        public DataTable CARI_BYNAMA(RMS.COMMON.MASTER.RMS_USER obj)
        {
            return p.CARI_BYNAMA(obj);
        }

        public DataTable SEARCH_BYKODE(RMS.COMMON.MASTER.RMS_USER obj)
        {
            return p.SEARCH_BYKODE(obj);
        }

        public DataTable SEARCH_BYNAMA(RMS.COMMON.MASTER.RMS_USER obj)
        {
            return p.SEARCH_BYNAMA(obj);
        }
    }
}

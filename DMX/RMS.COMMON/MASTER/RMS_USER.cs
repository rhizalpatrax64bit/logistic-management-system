using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RMS.COMMON.MASTER
{
    public class RMS_USER
    {
        public int id { get; set; }
        public string nama { get; set; }
        public string level { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string hp { get; set; }
        public string alamat { get; set; }
        public bool isaktif { get; set; }
        public bool isbiayastt { get; set; }
        public bool ispiutang { get; set; }
        public bool ismasterdata { get; set; }
        public bool isagent { get; set; }
        public bool ispricelist { get; set; }
        public bool isuser { get; set; }
        public bool islaporan { get; set; }
        public bool iscourier { get; set; }
        public bool isLogin { get; set; }
    }
}

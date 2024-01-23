using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DoTheNhuan_2021600381.Models
{
    public class CuaHang
    {
        public string mach { get; set; }
        public string tench { get; set; }
        public string diachi { get; set; }

        public List<CuonSach> li { get; set; }

        public CuaHang()
        {

        }

        public CuaHang(string mach, string tench, string diachi, List<CuonSach> li)
        {
            this.mach = mach;
            this.tench = tench;
            this.diachi = diachi;
            this.li = li;
        }
    }
}
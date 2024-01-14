using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace B4._2.Models
{
    public class HoaDon
    {
        public string fullname { get; set; }
        public string loaidien { get; set; }
        public string uutien { get; set; }
        public double chisocu { get; set; }
        public double chisomoi { get; set; }

        public HoaDon()
        {
        }

        public HoaDon(string fullname, string loaidien, string uutien, double chisocu, double chisomoi)
        {
            this.fullname = fullname;
            this.loaidien = loaidien;
            this.uutien = uutien;
            this.chisocu = chisocu;
            this.chisomoi = chisomoi;
        }

        public double dientieuthu
        {
            get
            {
                return chisomoi - chisocu;
            }
        }

        public double tienphaitra
        {
            get
            {
                double res = 0;
                if (dientieuthu > 200) res = 475000 + 4000 * (dientieuthu - 200);
                else if (dientieuthu > 150) res = 325000 + 3000 * (dientieuthu - 150);
                else if (dientieuthu > 100) res = 200000 + 2500 * (dientieuthu - 100);
                if (uutien == "uutien") res *= 0.9;
                if (loaidien.Equals("kinhdoanh")) res *= 1.2;
                else if (loaidien.Equals("sanxuat")) res *= 1.3;
                return res;
            }
        }
    }
}
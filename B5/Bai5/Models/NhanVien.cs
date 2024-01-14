using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bai5.Models
{
    public class NhanVien
    {
        public string id { get; set; }
        public string name { get; set; }
        public DateTime birthday { get; set; }
        public double salary { get; set; }
        public string avatar { get; set; }
    }
}
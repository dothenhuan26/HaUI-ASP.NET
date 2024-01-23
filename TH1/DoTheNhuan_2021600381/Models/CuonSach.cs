using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DoTheNhuan_2021600381.Models
{
    public class CuonSach
    {
        public string TenSach { get; set; }
        public string TheLoai { get; set; }
        public int SoLuong { get; set; }
        public double GiaTien { get; set; }

        public double SoTienThanhToan
        {
            get
            {
                return this.SoLuong * this.GiaTien;
            }
        }

        public string TenTheLoai
        {
            get
            {
                switch (this.TheLoai)
                {
                    case "vh": return "Văn học";
                    case "nn": return "Ngoại ngữ";
                    case "khkt": return "Khoa học kỹ thuật";
                    case "tt": return "Tiểu thuyết";
                    default: return "";
                }
            }
        }

        public CuonSach()
        {

        }

        public CuonSach(string tenSach, string theLoai, int soLuong, double giaTien)
        {
            TenSach = tenSach;
            TheLoai = theLoai;
            SoLuong = soLuong;
            GiaTien = giaTien;
        }
    }
}
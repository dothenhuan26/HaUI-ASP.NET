namespace DoTheNhuan_2021600381.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NhanVien")]
    public partial class NhanVien
    {
        [Key]
        [DisplayName("Mã nhân viên")]
        public int Manv { get; set; }

        [StringLength(30)]
        [DisplayName("Họ tên")]
        public string Hoten { get; set; }

        [StringLength(30)]
        [DisplayName("Mật khẩu")]
        public string Matkhau { get; set; }
        [DisplayName("Tuổi")]
        public int? Tuoi { get; set; }

        [StringLength(30)]
        [DisplayName("Địa chỉ")]
        public string Diachi { get; set; }
        [DisplayName("Lương")]
        public int? Luong { get; set; }
        [DisplayName("Phòng")]
        public int? Maphong { get; set; }

        public virtual Phong Phong { get; set; }
    }
}

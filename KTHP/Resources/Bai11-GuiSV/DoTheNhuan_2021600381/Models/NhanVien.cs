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
        [DisplayName("Họ tên nhân viên")]
        public string Hoten { get; set; }

        [StringLength(30)]
        [DisplayName("Mật khẩu nhân viên")]
        public string Matkhau { get; set; }

        [DisplayName("Tuổi nhân viên")]
        public int? Tuoi { get; set; }

        [StringLength(30)]
        [DisplayName("Địa chỉ nhân viên")]
        public string Diachi { get; set; }

        [DisplayName("Lương nhân viên")]
        public int? Luong { get; set; }
        [DisplayName("Mã phòng")]
        public int? Maphong { get; set; }

        public virtual Phong Phong { get; set; }
    }
}

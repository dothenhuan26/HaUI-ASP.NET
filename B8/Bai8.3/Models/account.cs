namespace Bai8._3.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("account")]
    public partial class account
    {
        [Key]
        [DisplayName("Mã")]
        public int id { get; set; }

        [DisplayName("Tên đăng nhập")]
        [Required(ErrorMessage = "Tên đăng nhập không được để trống!")]
        [StringLength(50)]
        public string username { get; set; }

        [DisplayName("Tên người dùng")]
        [Required(ErrorMessage = "Tên người dùng không được để trống!")]
        [StringLength(30)]
        public string fullname { get; set; }


        [StringLength(20)]
        public string phone { get; set; }

        [DisplayName("Mật khẩu")]
        [Required(ErrorMessage = "Mật khẩu không được để trống!")]
        [StringLength(30)]
        public string password { get; set; }

        [StringLength(50)]
        public string email { get; set; }
    }
}

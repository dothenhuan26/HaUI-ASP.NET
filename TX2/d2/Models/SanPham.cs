namespace d2.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SanPham")]
    public partial class SanPham
    {
        [Key]
        [StringLength(10)]
        public string Masp { get; set; }

        [StringLength(50)]
        public string Tensp { get; set; }

        [StringLength(50)]
        public string Donvitinh { get; set; }

        public int? Soluong { get; set; }
    }
}

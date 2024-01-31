namespace TH_2021600381_DoTheNhuan.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Product")]
    public partial class Product
    {
        [Key]
        public int Pid { get; set; }

        [Required(ErrorMessage = "Mã danh mục không được để trống")]
        [DisplayName("Mã danh mục")]
        public int Categoryid { get; set; }

        [Required(ErrorMessage = "Tên sản phẩm không được để trống")]
        [DisplayName("Tên sản phẩm")]
        [StringLength(250)]
        public string ProdName { get; set; }

        [StringLength(50)]
        [Required(ErrorMessage = "Tiêu đề không được để trống")]
        [DisplayName("Tiêu đề")]
        public string MetaTitle { get; set; }

        [StringLength(250)]
        [Required(ErrorMessage = "Mô tả không được để trống")]
        [DisplayName("Mô tả")]
        public string Description { get; set; }

        [StringLength(550)]
        [Required(ErrorMessage = "Hình ảnh không được để trống")]
        [DisplayName("Hình ảnh")]
        public string ImagePath { get; set; }

        [Required(ErrorMessage = "Gía sản phẩm không được để trống")]
        [DisplayName("Gía sản phẩm")]
        public decimal Price { get; set; }
    }
}

namespace Bai8._3.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("product")]
    public partial class product
    {
        [Key]
        public int proid { get; set; }

        [Required]
        [StringLength(45)]
        public string proname { get; set; }

        public decimal price { get; set; }

        public decimal stock { get; set; }

        [StringLength(100)]
        public string image { get; set; }

        [Column(TypeName = "ntext")]
        public string description { get; set; }

        public int catid { get; set; }

        public virtual category category { get; set; }
    }
}

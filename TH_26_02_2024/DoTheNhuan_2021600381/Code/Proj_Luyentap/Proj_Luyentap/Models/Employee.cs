namespace Proj_Luyentap.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Employee")]
    public partial class Employee
    {
        [Key]
        public int eid { get; set; }

        [StringLength(30)]
        public string name { get; set; }

        public int? age { get; set; }

        [StringLength(30)]
        public string addr { get; set; }

        public int? salary { get; set; }

        [StringLength(50)]
        public string image { get; set; }

        public int? deptid { get; set; }

        public virtual Department Department { get; set; }
    }
}

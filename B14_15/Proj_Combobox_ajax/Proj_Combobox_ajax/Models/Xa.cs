namespace Proj_Combobox_ajax.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Xa")]
    public partial class Xa
    {
        public int XaID { get; set; }

        [StringLength(30)]
        public string TenXa { get; set; }

        public int? HuyenID { get; set; }

        public virtual Huyen Huyen { get; set; }
    }
}

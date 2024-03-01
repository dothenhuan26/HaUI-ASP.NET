using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Proj_Combobox_ajax.Models
{
    public partial class DiaChiDB : DbContext
    {
        public DiaChiDB()
            : base("name=DiaChiDB")
        {
        }

        public virtual DbSet<Huyen> Huyens { get; set; }
        public virtual DbSet<Tinh> Tinhs { get; set; }
        public virtual DbSet<Xa> Xas { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}

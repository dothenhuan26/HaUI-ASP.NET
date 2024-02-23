using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace d2.Models
{
    public partial class De2DB : DbContext
    {
        public De2DB()
            : base("name=De2DB")
        {
        }

        public virtual DbSet<SanPham> SanPhams { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SanPham>()
                .Property(e => e.Masp)
                .IsFixedLength();
        }
    }
}

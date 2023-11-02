using EntityFrameworkCodeFirst.Entity;
using Microsoft.EntityFrameworkCore;

namespace EntityFrameworkCodeFirst.Model
{
    public class EFContext:DbContext
    {
        public EFContext(DbContextOptions<EFContext> options)
       : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Customers>().Property(x => x.Firstname).HasMaxLength(1000);

        }
        public DbSet<Customers> Customers { get; set; } 
        public DbSet<Orders> Orders { get; set; }   



    }
}

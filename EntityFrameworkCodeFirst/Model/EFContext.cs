using EntityFrameworkCodeFirst.Entity;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

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
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());


        }
        public DbSet<Customers> Customers { get; set; } 
        public DbSet<Orders> Orders { get; set; }   



    }
}

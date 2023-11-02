using EntityFrameworkCodeFirst.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EntityFrameworkCodeFirst.EntityConfiguration
{
    public class CustomerConfig : IEntityTypeConfiguration<Customers>
    {
        public void Configure(EntityTypeBuilder<Customers> builder)
        {
            builder.Property(x => x.State).HasMaxLength(50);    
        }
    }
}

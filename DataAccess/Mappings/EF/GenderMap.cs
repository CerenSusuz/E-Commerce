using DataAccess.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Mappings.EF
{
    public class GenderMap : IEntityTypeConfiguration<Gender>
    {
        public void Configure(EntityTypeBuilder<Gender> builder)
        {
            builder.Property(x=>x.Description).HasMaxLength(5);
            
            builder.HasData(new Gender {
                Id=1,
                Description = "Kadın"
            });
            
            builder.HasData(new Gender {
                Id=2,
                Description = "Erkek"
            });
        }
    }
}
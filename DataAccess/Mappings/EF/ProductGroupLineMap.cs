using DataAccess.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Mappings.EF
{
    public class ProductGroupLineMap : IEntityTypeConfiguration<ProductGroupLine>
    {
        public void Configure(EntityTypeBuilder<ProductGroupLine> builder)
        {
            // one to many relation
            builder.HasOne(x => x.ProductGroup)
                .WithMany(x => x.ProductGroupLines)
                .HasForeignKey(x => x.ProductGroupId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
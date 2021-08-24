using DataAccess.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Mappings.EF
{
    public class SettingMap : IEntityTypeConfiguration<Setting>
    {
        public void Configure(EntityTypeBuilder<Setting> builder)
        {
            builder.HasIndex(x => x.Key).IsUnique();
            builder.Property(x => x.Key).HasMaxLength(255);
            builder.Property(x => x.Value).HasMaxLength(255);
        }
    }
}
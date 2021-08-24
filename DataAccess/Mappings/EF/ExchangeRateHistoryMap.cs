using DataAccess.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Mappings.EF
{
    public class ExchangeRateHistoryMap : IEntityTypeConfiguration<ExchangeRateHistory>
    {
        public void Configure(EntityTypeBuilder<ExchangeRateHistory> builder)
        {
            builder.HasOne(x => x.Currency)
                .WithMany(x => x.ExchangeRateHistories)
                .HasForeignKey(x => x.CurrencyId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
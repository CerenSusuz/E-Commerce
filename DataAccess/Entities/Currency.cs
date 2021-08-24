using System.Collections.Generic;
using Core.Signatures;

namespace DataAccess.Entities
{
    public class Currency : BaseEntity
    {
        public string CurrencyCode { get; set; }
        public string Symbol { get; set; }
        public bool IsBlocked { get; set; }
        public decimal CurrencyRate { get; set; }
        public ICollection<ExchangeRateHistory> ExchangeRateHistories { get; set; }
    }
}
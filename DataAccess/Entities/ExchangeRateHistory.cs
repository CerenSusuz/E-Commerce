using System;
using Core.Signatures;

namespace DataAccess.Entities
{
    public class ExchangeRateHistory : BaseEntity
    {
        public int CurrencyId { get; set; }
        public Currency Currency { get; set; }
        public decimal ExchangeRate { get; set; }
        public DateTime Date { get; set; }
    }
}
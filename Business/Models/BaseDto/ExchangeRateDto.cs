using System;
using Core.Signatures;

namespace Business.Models.BaseDto
{
    public class ExchangeRateDto : IBaseDto
    {
        public int CurrencyId { get; set; }
        public decimal ExchangeRate { get; set; }
        public DateTime Date { get; set; }
    }
}
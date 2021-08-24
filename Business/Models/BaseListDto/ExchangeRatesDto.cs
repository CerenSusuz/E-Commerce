using System;
using Core.Signatures;
using DataAccess.Entities;

namespace Business.Models.BaseListDto
{
    public class ExchangeRatesDto : IBaseListDto
    {
        public int Id { get; set; }
        public string Currency { get; set; }
        public decimal ExchangeRate { get; set; }
        public DateTime Date { get; set; }
    }
}
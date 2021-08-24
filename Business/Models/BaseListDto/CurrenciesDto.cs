using Core.Signatures;

namespace Business.Models.BaseListDto
{
    public class CurrenciesDto : IBaseListDto
    {
        public int Id { get; set; }
        public string CurrencyCode { get; set; }
        public string Symbol { get; set; }
        public decimal CurrencyRate { get; set; }
        public bool IsBlocked { get; set; }
    }
}
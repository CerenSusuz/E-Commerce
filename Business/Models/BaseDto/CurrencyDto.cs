using Core.Signatures;

namespace Business.Models.BaseDto
{
    public class CurrencyDto : IBaseDto
    {
        public string CurrencyCode { get; set; }
        public string Symbol { get; set; }
        public bool IsBlocked { get; set; }
        public decimal CurrencyRate { get; set; }
    }
}
using Core.Signatures;

namespace Business.Models.BaseDto
{
    public class ProductDto : IBaseDto
    {
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int VatRate { get; set; }
        public string Url { get; set; }
        public bool IsBlocked { get; set; }

        public int CurrencyId { get; set; }
        public int BrandId { get; set; }
        public int CategoryId { get; set; }
    }
}
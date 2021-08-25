using Core.Signatures;
using DataAccess.Entities;

namespace Business.Models.BaseListDto
{
    public class ProductsDto : IBaseListDto
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int VatRate { get; set; }
        public string Url { get; set; }
        public bool IsBlocked { get; set; }
        
        public string Currency { get; set; }
        public string Brand { get; set; }
        public string Category { get; set; }
    }
}
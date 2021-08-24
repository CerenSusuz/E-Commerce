using System.Collections.Generic;
using Core.Signatures;

namespace DataAccess.Entities
{
    public class Product : BaseEntity
    {
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int VatRate { get; set; }
        public string Url { get; set; }
        public bool IsBlocked { get; set; }
        public ICollection<FavoriteProduct> FavoriteProducts { get; set; }
        public ICollection<RelatedProduct> RelatedProducts { get; set; }
        
        public int CurrencyId { get; set; }
        public Currency Currency { get; set; }
        public int BrandId { get; set; }
        public Brand Brand { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
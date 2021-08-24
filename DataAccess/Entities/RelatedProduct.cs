using Core.Signatures;

namespace DataAccess.Entities
{
    public class RelatedProduct : BaseEntity
    {
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public int RelatedProductId { get; set; }
        public Product SuggestionSelling { get; set; }
    }
}
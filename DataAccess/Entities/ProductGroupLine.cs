using Core.Signatures;

namespace DataAccess.Entities
{
    public class ProductGroupLine : BaseEntity
    {
        public int ProductId { get; set; }
        public Product Product { get; set; }

        public int ProductGroupId { get; set; }
        public ProductGroup ProductGroup { get; set; }
    }
}
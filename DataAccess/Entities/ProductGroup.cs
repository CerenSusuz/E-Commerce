using System.Collections.Generic;
using Core.Signatures;

namespace DataAccess.Entities
{
    public class ProductGroup : BaseEntity
    {
        public string Description { get; set; }
        public ICollection<ProductGroupLine> ProductGroupLines { get; set; }
    }
}
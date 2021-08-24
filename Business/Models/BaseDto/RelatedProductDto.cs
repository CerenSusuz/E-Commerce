using Core.Signatures;

namespace Business.Models.BaseDto
{
    public class RelatedProductDto : IBaseDto
    {
        public int ProductId { get; set; }
        public int RelatedProductId { get; set; }
    }
}
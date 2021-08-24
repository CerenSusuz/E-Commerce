using Core.Signatures;

namespace Business.Models.BaseDto
{
    public class ProductGroupLineDto : IBaseDto
    {
        public int ProductId { get; set; }
        public int ProductGroupId { get; set; }
    }
}
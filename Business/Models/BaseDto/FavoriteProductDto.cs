using Core.Signatures;

namespace Business.Models.BaseDto
{
    public class FavoriteProductDto  : IBaseDto
    {
        public int ProductId { get; set; }
        public int AccountId { get; set; }
    }
}
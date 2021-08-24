using Core.Signatures;

namespace Business.Models.BaseDto
{
    public class BrandDto : IBaseDto
    {
        public string Description { get; set; }
        public bool IsBlocked { get; set; }
        public string Url { get; set; }
    }
}
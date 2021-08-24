using Core.Signatures;

namespace Business.Models.BaseListDto
{
    public class BrandsDto : IBaseListDto
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public string Url { get; set; }
        public bool IsBlocked { get; set; }
    }
}
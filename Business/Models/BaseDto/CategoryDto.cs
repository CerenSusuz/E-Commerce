using Core.Signatures;

namespace Business.Models.BaseDto
{
    public class CategoryDto : IBaseDto
    {
        public string CategoryName { get; set; }
        public string Url { get; set; }
        public bool IsBlocked { get; set; }
        public int? ParentId { get; set; }
    }
}
using Core.Signatures;

namespace Business.Models.BaseListDto
{
    public class ProductGroupsDto : IBaseListDto
    {
        public int Id { get; set; }
        public string Description { get; set; }
    }
}
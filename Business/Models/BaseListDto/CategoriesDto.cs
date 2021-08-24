using Core.Signatures;
using DataAccess.Entities;

namespace Business.Models.BaseListDto
{
    public class CategoriesDto : IBaseListDto
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }
        public string Url { get; set; }
        public bool IsBlocked { get; set; }
        public string Parent { get; set; }
    }
}
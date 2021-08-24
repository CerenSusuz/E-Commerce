using Core.Signatures;
using DataAccess.Entities;

namespace Business.Models.BaseListDto
{
    public class ProductGroupLinesDto : IBaseListDto
    {
        public int Id { get; set; }  
        public string Product { get; set; }
        public string ProductGroup { get; set; }
    }
}
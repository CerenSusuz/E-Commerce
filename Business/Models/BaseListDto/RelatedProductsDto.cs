using Core.Signatures;
using DataAccess.Entities;

namespace Business.Models.BaseListDto
{
    public class RelatedProductsDto :  IBaseListDto
    {
        public int Id { get; set; }
        public string Product { get; set; }
        public string SuggestionSelling { get; set; }
    }
}
using System.Threading.Tasks;
using Business.Models.BaseListDto;
using Core.Models;

namespace Business.Abstract
{
    public interface IRelatedProductService
    {
        Task<PagedList<RelatedProductsDto>> GetAllAsync(int productId);
    }
}
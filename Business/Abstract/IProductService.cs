using System.Threading.Tasks;
using Business.Models.BaseListDto;
using Core.Models;

namespace Business.Abstract
{
    public interface IProductService
    {
        Task<PagedList<ProductsDto>> GetAllAsync(Filter filter);
    }
}
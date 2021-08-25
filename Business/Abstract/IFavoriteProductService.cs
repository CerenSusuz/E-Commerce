using System.Threading.Tasks;
using Business.Models.BaseDto;
using Business.Models.BaseListDto;
using Business.Repositories;
using Core.Models;

namespace Business.Abstract
{
    public interface IFavoriteProductService : IServiceRepository<FavoriteProductDto>
    {
        Task<PagedList<FavoriteProductsDto>> GetAllByAccountAsync(Filter filter, int accountId);
        Task<PagedList<FavoriteProductsDto>> GetAllAsync(Filter filter);
    }
}
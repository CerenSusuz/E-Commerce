using System.Threading.Tasks;
using Business.Models.BaseListDto;
using Core.Models;

namespace Business.Abstract
{
    public interface IFavoriteProductService
    {
        Task<PagedList<FavoriteProductsDto>> GetAllAsync(int accountId);
    }
}
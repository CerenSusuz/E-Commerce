using System.Threading.Tasks;
using Business.Models.BaseDto;
using Business.Models.BaseListDto;
using Business.Repositories;
using Core.Models;

namespace Business.Abstract
{
    public interface IBrandService : IServiceRepository<BrandDto>
    {
        Task<PagedList<BrandsDto>> GetAllAsync(Filter filter);
    }
}
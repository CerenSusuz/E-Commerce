using System.Threading.Tasks;
using Business.Models.BaseDto;
using Business.Models.BaseListDto;
using Business.Repositories;
using Core.Models;

namespace Business.Abstract
{
    public interface IDistrictService : IServiceRepository<DistrictDto>
    {
        Task<PagedList<DistrictsDto>> GetAllAsync(Filter filter, int cityId);
    }
}
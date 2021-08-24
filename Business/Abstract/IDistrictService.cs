using System.Threading.Tasks;
using Business.Models.BaseListDto;
using Core.Models;

namespace Business.Abstract
{
    public interface IDistrictService
    {
        Task<PagedList<DistrictsDto>> GetAllAsync(int cityId);
    }
}
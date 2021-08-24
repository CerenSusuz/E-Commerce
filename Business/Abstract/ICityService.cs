using System.Threading.Tasks;
using Business.Models.BaseListDto;
using Core.Models;

namespace Business.Abstract
{
    public interface ICityService
    {
        Task<PagedList<CitiesDto>> GetAllAsync(int countryId);
    }
}
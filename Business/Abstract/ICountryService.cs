using System.Threading.Tasks;
using Business.Models.BaseListDto;
using Core.Models;

namespace Business.Abstract
{
    public interface ICountryService
    {
        Task<PagedList<CountriesDto>> GetAllAsync(Filter filter);
    }
}
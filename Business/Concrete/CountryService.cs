using System.Threading.Tasks;
using AutoMapper;
using Business.Abstract;
using Business.Models.BaseDto;
using Business.Models.BaseListDto;
using Business.Repositories;
using Core.Aspects.CacheAspect;
using Core.Models;
using DataAccess.Entities;
using DataAccess.Repositories;

namespace Business.Concrete
{
    public class CountryService :ServiceRepository<Country,CountryDto>, ICountryService
    {
        public CountryService(IRepository<Country> repository, IMapper mapper) : base(repository, mapper)
        {
        }
        [CacheAspect()]
        public Task<PagedList<CountriesDto>> GetAllAsync(Filter filter)
        {
            throw new System.NotImplementedException();
        }
    }
}
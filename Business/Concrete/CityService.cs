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
    public class CityService :ServiceRepository<City,CityDto>, ICityService
    {
        public CityService(IRepository<City> repository, IMapper mapper) : base(repository, mapper)
        {
        }
        [CacheAspect()]
        public Task<PagedList<CitiesDto>> GetAllAsync(int countryId)
        {
            throw new System.NotImplementedException();
        }
    }
}
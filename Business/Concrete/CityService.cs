using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Business.Abstract;
using Business.Models.BaseDto;
using Business.Models.BaseListDto;
using Business.Repositories;
using Core.Aspects.CacheAspect;
using Core.Extensions;
using Core.Models;
using DataAccess.Entities;
using DataAccess.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Business.Concrete
{
    public class CityService :ServiceRepository<City,CityDto>, ICityService
    {
        private readonly IRepository<City> _repository;
        private readonly IMapper _mapper;
        public CityService(IRepository<City> repository, IMapper mapper) : base(repository, mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        
        [CacheAspect]
        public async Task<PagedList<CitiesDto>> GetAllAsync(Filter filter, int countryId)
        {
            return await Task.Run(() => _repository.AsNoTracking
                .Where(x=>x.CountryId == countryId)
                .Include(c=>c.Country)
                .Filter(filter)
                .ToPagedList<City, CitiesDto>(filter, _mapper));
        }
    }
}
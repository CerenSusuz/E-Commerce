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
    public class DistrictService :ServiceRepository<District,DistrictDto>, IDistrictService
    {
        private readonly IRepository<District> _repository;
        private readonly IMapper _mapper;
        public DistrictService(IRepository<District> repository, IMapper mapper) : base(repository, mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        
        [CacheAspect]
        public async Task<PagedList<DistrictsDto>> GetAllAsync(Filter filter, int cityId)
        {
            return await Task.Run(() => _repository.AsNoTracking
                .Where(x=>x.CityId == cityId)
                .Include(c=>c.City)
                .Filter(filter)
                .ToPagedList<District, DistrictsDto>(filter, _mapper));
        }
    }
}
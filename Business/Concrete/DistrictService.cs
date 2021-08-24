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
    public class DistrictService :ServiceRepository<District,DistrictDto>, IDistrictService
    {
        public DistrictService(IRepository<District> repository, IMapper mapper) : base(repository, mapper)
        {
        }
        [CacheAspect()]
        public Task<PagedList<DistrictsDto>> GetAllAsync(int cityId)
        {
            throw new System.NotImplementedException();
        }
    }
}
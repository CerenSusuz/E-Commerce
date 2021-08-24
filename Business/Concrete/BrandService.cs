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

namespace Business.Concrete
{
    public class BrandService :ServiceRepository<Brand,BrandDto>, IBrandService
    {
        private readonly IRepository<Brand> _repository;
        private readonly IMapper _mapper;
        public BrandService(IRepository<Brand> repository, IMapper mapper) : base(repository, mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        [CacheAspect]
        public async Task<PagedList<BrandsDto>> GetAllAsync(Filter filter)
        {
            return await Task.Run(() => _repository.AsNoTracking
                .Filter(filter)
                .ToPagedList<Brand, BrandsDto>(filter, _mapper));
        }
    }
}
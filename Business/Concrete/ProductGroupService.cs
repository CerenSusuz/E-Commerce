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
    public class ProductGroupService  :ServiceRepository<ProductGroup,ProductGroupDto>, IProductGroupService
    {
        private readonly IRepository<ProductGroup> _repository;
        private readonly IMapper _mapper;

        public ProductGroupService(IRepository<ProductGroup> repository,IMapper mapper) : base(repository,mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        [CacheAspect()]
        public async Task<PagedList<ProductGroupsDto>> GetAllAsync(Filter filter)
        {
            return await Task.Run(() => _repository.AsNoTracking
                .Filter(filter)
                .ToPagedList<ProductGroup, ProductGroupsDto>(filter, _mapper));
        }
    }
}
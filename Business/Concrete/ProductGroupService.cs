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
        public Task<PagedList<ProductGroupsDto>> GetAllAsync(Filter filter)
        {
            throw new System.NotImplementedException();
        }
    }
}
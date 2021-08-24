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
    public class ProductGroupLineService  :ServiceRepository<ProductGroupLine,ProductGroupLineDto>, IProductGroupLineService
    {
        private readonly IRepository<ProductGroupLine> _repository;
        private readonly IMapper _mapper;

        public ProductGroupLineService(IRepository<ProductGroupLine> repository,IMapper mapper) : base(repository,mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        [CacheAspect()]
        public Task<PagedList<ProductGroupLinesDto>> GetAllAsync(Filter filter)
        {
            throw new System.NotImplementedException();
        }
    }
}
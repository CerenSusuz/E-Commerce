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
    public class RelatedProductService :ServiceRepository<RelatedProduct,RelatedProductDto>, IRelatedProductService
    {
        private readonly IRepository<RelatedProduct> _repository;
        private readonly IMapper _mapper;

        public RelatedProductService(IRepository<RelatedProduct> repository,IMapper mapper) : base(repository,mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        [CacheAspect()]
        public Task<PagedList<RelatedProductsDto>> GetAllAsync(int productId)
        {
            throw new System.NotImplementedException();
        }
    }
}
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
        public async Task<PagedList<RelatedProductsDto>> GetAllAsync(Filter filter, int productId)
        {
            return await Task.Run(() => _repository.Table
                .Where(c=>c.ProductId==productId)
                .Include(c=>c.Product)
                .Include(c=>c.SuggestionSelling)
                .Filter(filter)
                .ToPagedList<RelatedProduct, RelatedProductsDto>(filter, _mapper));
        }
    }
}
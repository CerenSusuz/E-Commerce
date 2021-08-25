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
    public class ProductService :ServiceRepository<Product,ProductDto>, IProductService
    {
        private readonly IRepository<Product> _repository;
        private readonly IMapper _mapper;

        public ProductService(IRepository<Product> repository,IMapper mapper) : base(repository,mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        [CacheAspect()]
        public async Task<PagedList<ProductsDto>> GetAllAsync(Filter filter)
        {
            return await Task.Run(() => _repository.Table
                .Include(c=>c.Currency)
                .Include(c=>c.Brand)
                .Include(c=>c.Category)
                .Filter(filter)
                .ToPagedList<Product, ProductsDto>(filter, _mapper));
        }

        public async Task<PagedList<ProductsDto>> GetAllByCategoryAsync(Filter filter, int categoryId)
        {
            return await Task.Run(() => _repository.Table
                .Where(c=>c.CategoryId==categoryId)
                .Include(c=>c.Currency)
                .Include(c=>c.Brand)
                .Include(c=>c.Category)
                .Filter(filter)
                .ToPagedList<Product, ProductsDto>(filter, _mapper));
        }
    }
}
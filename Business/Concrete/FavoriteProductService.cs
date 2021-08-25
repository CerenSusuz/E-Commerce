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
    public class FavoriteProductService :ServiceRepository<FavoriteProduct,FavoriteProductDto>, IFavoriteProductService
    {
        private readonly IRepository< FavoriteProduct> _repository;
        private readonly IMapper _mapper;

        public FavoriteProductService(IRepository< FavoriteProduct> repository,IMapper mapper) : base(repository,mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        [CacheAspect]
        public async Task<PagedList<FavoriteProductsDto>> GetAllByAccountAsync(Filter filter, int accountId)
        {
            return await Task.Run(() => _repository.AsNoTracking
                .Where(x=>x.AccountId == accountId)
                .Include(c=>c.Account)
                .Include(c=>c.Product)
                .Filter(filter)
                .ToPagedList<FavoriteProduct, FavoriteProductsDto>(filter, _mapper));
        }

        [CacheAspect]
        public async Task<PagedList<FavoriteProductsDto>> GetAllAsync(Filter filter)
        {
            return await Task.Run(() => _repository.AsNoTracking
                .Filter(filter)
                .ToPagedList<FavoriteProduct, FavoriteProductsDto>(filter, _mapper));
        }
    }
}
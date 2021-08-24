﻿using System.Threading.Tasks;
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
    public class ProductService :ServiceRepository<Product,ProductDto>, IProductService
    {
        public ProductService(IRepository<Product> repository, IMapper mapper) : base(repository, mapper)
        {
        }

        [CacheAspect()]
        public Task<PagedList<ProductsDto>> GetAllAsync(Filter filter)
        {
            throw new System.NotImplementedException();
        }
    }
}
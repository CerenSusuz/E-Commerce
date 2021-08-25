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
    public class CategoryService :ServiceRepository<Category,CategoryDto>, ICategoryService
    {
        private readonly IRepository<Category> _repository;
        private readonly IMapper _mapper;
        public CategoryService(IRepository<Category> repository, IMapper mapper) : base(repository, mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        [CacheAspect()]
        public async Task<PagedList<CategoriesDto>> GetAllAsync(Filter filter)
        {
            return await Task.Run(() => _repository.AsNoTracking
                .Include(c=>c.Parent)
                .Filter(filter)
                .ToPagedList<Category, CategoriesDto>(filter, _mapper));
        }
    }
}
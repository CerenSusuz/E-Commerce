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
    public class CategoryService :ServiceRepository<Category,CategoryDto>, ICategoryService
    {
        public CategoryService(IRepository<Category> repository, IMapper mapper) : base(repository, mapper)
        {
        }
        [CacheAspect()]
        public Task<PagedList<CategoriesDto>> GetAllAsync(Filter filter)
        {
            throw new System.NotImplementedException();
        }
    }
}
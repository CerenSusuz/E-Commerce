using System.Threading.Tasks;
using Business.Models.BaseDto;
using Business.Models.BaseListDto;
using Business.Repositories;
using Core.Models;

namespace Business.Abstract
{
    public interface ICategoryService : IServiceRepository<CategoryDto>
    {
        Task<PagedList<CategoriesDto>> GetAllAsync(Filter filter);
    }
}
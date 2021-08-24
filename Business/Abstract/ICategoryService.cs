using System.Threading.Tasks;
using Business.Models.BaseListDto;
using Core.Models;

namespace Business.Abstract
{
    public interface ICategoryService
    {
        Task<PagedList<CategoriesDto>> GetAllAsync(Filter filter);
    }
}
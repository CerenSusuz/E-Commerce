using System.Threading.Tasks;
using Business.Models.BaseListDto;
using Core.Models;

namespace Business.Abstract
{
    public interface IProductGroupService
    {
        Task<PagedList<ProductGroupsDto>> GetAllAsync(Filter filter);
    }
}
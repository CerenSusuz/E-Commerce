using System.Threading.Tasks;
using Business.Models.BaseListDto;
using Core.Models;

namespace Business.Abstract
{
    public interface IProductGroupLineService
    {
        Task<PagedList<ProductGroupLinesDto>> GetAllAsync(Filter filter);
    }
}
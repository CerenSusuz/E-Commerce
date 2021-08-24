using System.Threading.Tasks;
using Business.Models.BaseListDto;
using Core.Models;

namespace Business.Abstract
{
    public interface IRuleService
    {
        Task<PagedList<RulesDto>> GetAllAsync(int roleId);
    }
}
using System.Threading.Tasks;
using Business.Models.BaseDto;
using Business.Models.BaseListDto;
using Business.Repositories;
using Core.Models;

namespace Business.Abstract
{
    public interface IRuleService : IServiceRepository<RuleDto>
    {
        Task<PagedList<RulesDto>> GetAllByRoleAsync(Filter filter, int roleId);
        Task<PagedList<RulesDto>> GetAllAsync(Filter filter);
    }
}
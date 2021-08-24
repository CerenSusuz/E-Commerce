using System.Threading.Tasks;
using Business.Models.BaseListDto;
using Core.Models;

namespace Business.Abstract
{
    public interface IRoleService
    {
        Task<PagedList<RolesDto>> GetAllAsync(int accountId);
    }
}
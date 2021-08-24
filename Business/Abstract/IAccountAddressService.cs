using System.Threading.Tasks;
using Business.Models.BaseListDto;
using Core.Models;

namespace Business.Abstract
{
    public interface IAccountAddressService
    {
        Task<PagedList<AccountAddressesDto>> GetAllAsync(int accountId);
    }
}
using System.Threading.Tasks;
using Business.Models.BaseDto;
using Business.Models.BaseListDto;
using Business.Repositories;
using Core.Models;

namespace Business.Abstract
{
    public interface IAccountAddressService : IServiceRepository<AccountAddressDto>
    {
        Task<PagedList<AccountAddressesDto>> GetAllAsync(Filter filter, int accountId);
    }
}
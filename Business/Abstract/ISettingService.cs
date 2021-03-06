using System.Threading.Tasks;
using Business.Models.BaseDto;
using Business.Models.BaseListDto;
using Business.Repositories;
using Core.Models;

namespace Business.Abstract
{
    public interface ISettingService : IServiceRepository<SettingDto>
    {
        Task<PagedList<SettingsDto>> GetAllAsync(Filter filter);
    }
}
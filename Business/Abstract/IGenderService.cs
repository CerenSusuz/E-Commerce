using System.Collections.Generic;
using System.Threading.Tasks;
using Business.Models.BaseDto;
using Business.Models.BaseListDto;
using Business.Repositories;
using Core.Models;

namespace Business.Abstract
{
    public interface IGenderService : IServiceRepository<GenderDto>
    {
        Task<List<GendersDto>> GetAllAsync();
    }
}
using System.Threading.Tasks;
using AutoMapper;
using Business.Abstract;
using Business.Models.BaseDto;
using Business.Models.BaseListDto;
using Business.Repositories;
using Core.Extensions;
using Core.Models;
using DataAccess.Entities;
using DataAccess.Repositories;

namespace Business.Concrete
{
    public class SettingService :ServiceRepository<Setting,SettingDto>, ISettingService
    {
        private readonly IRepository<Setting> _repository;
        private readonly IMapper _mapper;
        public SettingService(IRepository<Setting> repository, IMapper mapper) : base(repository, mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<PagedList<SettingsDto>> GetAllAsync(Filter filter)
        {
            return await Task.Run(() => _repository.AsNoTracking
                .Filter(filter)
                .ToPagedList<Setting, SettingsDto>(filter, _mapper));
        }
    }
}
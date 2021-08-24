﻿using System.Threading.Tasks;
using AutoMapper;
using Business.Abstract;
using Business.Models.BaseDto;
using Business.Models.BaseListDto;
using Business.Repositories;
using Core.Models;
using DataAccess.Entities;
using DataAccess.Repositories;

namespace Business.Concrete
{
    public class SettingService :ServiceRepository<Setting,SettingDto>, ISettingService
    {
        public SettingService(IRepository<Setting> repository, IMapper mapper) : base(repository, mapper)
        {
        }

        public Task<PagedList<SettingsDto>> GetAllAsync()
        {
            throw new System.NotImplementedException();
        }
    }
}
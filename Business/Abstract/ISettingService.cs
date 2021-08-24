﻿using System.Threading.Tasks;
using Business.Models.BaseListDto;
using Core.Models;

namespace Business.Abstract
{
    public interface ISettingService
    {
        Task<PagedList<SettingsDto>> GetAllAsync();
    }
}
﻿using System.Threading.Tasks;
using Business.Models.BaseListDto;
using Core.Models;

namespace Business.Abstract
{
    public interface IBrandService
    {
        Task<PagedList<BrandsDto>> GetAllAsync(Filter filter);
    }
}
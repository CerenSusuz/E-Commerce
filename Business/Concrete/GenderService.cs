using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Business.Abstract;
using Business.Models.BaseDto;
using Business.Models.BaseListDto;
using Business.Repositories;
using Business.Validators;
using Core.Aspects.CacheAspect;
using Core.Aspects.Validation;
using Core.Extensions;
using Core.Models;
using DataAccess.Entities;
using DataAccess.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Business.Concrete
{
    [ValidationAspect(typeof(GenderValidator))]
    public class GenderService :ServiceRepository<Gender,GenderDto>, IGenderService
    {
        private readonly IRepository<Gender> _repository;
        private readonly IMapper _mapper;

        public GenderService(IRepository<Gender> repository,IMapper mapper) : base(repository,mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        
        [CacheAspect()]
        public async Task<PagedList<GendersDto>> GetAllAsync(Filter filter)
        {
            return await Task.Run(() => _repository.AsNoTracking
                .Filter(filter)
                .ToPagedList<Gender, GendersDto>(filter, _mapper));
        }
    }
}
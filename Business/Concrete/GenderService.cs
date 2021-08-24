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
        public Task<PagedList<GendersDto>> GetAllAsync()
        {
            throw new System.NotImplementedException();
        }
    }
}
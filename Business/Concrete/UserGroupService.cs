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
    [ValidationAspect(typeof(UserGroupValidator))]
    public class UserGroupService :ServiceRepository<UserGroup,UserGroupDto>,  IUserGroupService
    {
        private readonly IRepository<UserGroup> _repository;
        private readonly IMapper _mapper;

        public UserGroupService(IRepository<UserGroup> repository,IMapper mapper)  : base(repository,mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }


        [CacheAspect]
        public async Task<PagedList<UserGroupsDto>> GetAllAsync(Filter filter)
        {
            return await Task.Run(() => _repository.AsNoTracking
                .Filter(filter)
                .ToPagedList<UserGroup, UserGroupsDto>(filter, _mapper));
        }
    }
}
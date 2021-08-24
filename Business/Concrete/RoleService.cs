using System.Threading.Tasks;
using AutoMapper;
using Business.Abstract;
using Business.Models.BaseDto;
using Business.Models.BaseListDto;
using Business.Repositories;
using Core.Aspects.CacheAspect;
using Core.Models;
using DataAccess.Entities;
using DataAccess.Repositories;

namespace Business.Concrete
{
    public class RoleService :ServiceRepository<Role,RoleDto>, IRoleService
    {
        private readonly IRepository<Role> _repository;
        private readonly IMapper _mapper;
        public RoleService(IRepository<Role> repository, IMapper mapper) : base(repository, mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        
        [CacheAspect()]
        public Task<PagedList<RolesDto>> GetAllAsync(int accountId)
        {
            throw new System.NotImplementedException();
        }
    }
}
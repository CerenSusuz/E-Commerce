using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Business.Abstract;
using Business.Models.BaseDto;
using Business.Models.BaseListDto;
using Business.Repositories;
using Core.Aspects.CacheAspect;
using Core.Extensions;
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
        public async Task<PagedList<RolesDto>> GetAllAsync(Filter filter)
        {
            return await Task.Run(() => _repository.AsNoTracking
                .Filter(filter)
                .ToPagedList<Role, RolesDto>(filter, _mapper));
        }
    }
}
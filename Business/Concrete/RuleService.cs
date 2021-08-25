using System.Linq;
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
    public class RuleService :ServiceRepository<Rule,RuleDto>, IRuleService
    {
        private readonly IRepository<Rule> _repository;
        private readonly IMapper _mapper;
        public RuleService(IRepository<Rule> repository, IMapper mapper) : base(repository, mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        
        public async Task<PagedList<RulesDto>> GetAllByRoleAsync(Filter filter, int roleId)
        {
            return await Task.Run(() => _repository.AsNoTracking
                .Where(x=>x.RoleId == roleId)
                .Filter(filter)
                .ToPagedList<Rule, RulesDto>(filter, _mapper));
        }

        public async Task<PagedList<RulesDto>> GetAllAsync(Filter filter)
        {
            return await Task.Run(() => _repository.AsNoTracking
                .Filter(filter)
                .ToPagedList<Rule, RulesDto>(filter, _mapper));
        }
    }
}
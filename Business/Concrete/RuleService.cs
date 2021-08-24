using System.Threading.Tasks;
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
    public class RuleService :ServiceRepository<Rule,RuleDto>, IRuleService
    {
        public RuleService(IRepository<Rule> repository, IMapper mapper) : base(repository, mapper)
        {
        }

        public Task<PagedList<RulesDto>> GetAllAsync(int roleId)
        {
            throw new System.NotImplementedException();
        }
    }
}
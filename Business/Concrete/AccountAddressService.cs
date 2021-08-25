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
    public class AccountAddressService :ServiceRepository<AccountAddress,AccountAddressDto>, IAccountAddressService
    {
        private readonly IRepository<AccountAddress> _repository;
        private readonly IMapper _mapper;
        public AccountAddressService(IRepository<AccountAddress> repository, IMapper mapper) : base(repository, mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        
        [CacheAspect]
        public async Task<PagedList<AccountAddressesDto>> GetAllAsync(Filter filter, int accountId)
        {
            return await Task.Run(() => _repository.AsNoTracking
                .Where(x=>x.AccountId == accountId)
                .Filter(filter)
                .ToPagedList<AccountAddress, AccountAddressesDto>(filter, _mapper));
        }
    }
}
using System.Threading.Tasks;
using AutoMapper;
using Business.Abstract;
using Business.Models;
using Business.Models.BaseDto;
using Business.Models.BaseListDto;
using Business.Repositories;
using Business.Validators;
using Core.Aspects.CacheAspect;
using Core.Aspects.Validation;
using Core.Extensions;
using Core.Helpers;
using Core.Models;
using DataAccess.Entities;
using DataAccess.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Business.Concrete
{
    [ValidationAspect(typeof(AccountValidator))]
    public class AccountService :ServiceRepository<Account,AccountDto>, IAccountService
    {
        private readonly IRepository<Account> _repository;
        private readonly IMapper _mapper;

        public AccountService(IRepository<Account> repository,IMapper mapper) : base(repository,mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        
        [CacheAspect]
        public async Task<PagedList<AccountsDto>> GetAllAsync(Filter filter)
        {
            return await Task.Run(() => _repository.AsNoTracking
                .Include(x=>x.Gender)
                .Include(x=>x.UserGroup)
                .Include(x=>x.Role)
                .Filter(filter)
                .ToPagedList<Account, AccountsDto>(filter, _mapper));
        }

        [RemoveCacheAspect]
        public override async Task<int> InsertAsync(AccountDto dto)
        {
            var entity = _mapper.Map<Account>(dto);
            HashingHelper.CreatePasswordHash("1234",out var passwordHash,out var passwordSalt);
            entity.PasswordHash = passwordHash;
            entity.PasswordSalt = passwordSalt;
            await _repository.InsertAsync(entity);
            return entity.Id;
        }

        [RemoveCacheAspect]
        public override async Task UpdateAsync(int id, AccountDto dto)
        {
            var entity = _mapper.Map<Account>(dto);
            var oldEntity = await _repository.GetAsync(id);
            entity.Id = id;
            entity.PasswordHash = oldEntity.PasswordHash;
            entity.PasswordSalt = oldEntity.PasswordSalt;
            await _repository.UpdateAsync(entity);
        }
    }
}
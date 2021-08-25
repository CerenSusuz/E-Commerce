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
    public class CurrencyService :ServiceRepository<Currency,CurrencyDto>, ICurrencyService
    {
        private readonly IRepository<Currency> _repository;
        private readonly IMapper _mapper;
        public CurrencyService(IRepository<Currency> repository, IMapper mapper) : base(repository, mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public async Task<PagedList<CurrenciesDto>> GetAllAsync(Filter filter)
        {
            return await Task.Run(() => _repository.AsNoTracking
                .Filter(filter)
                .ToPagedList<Currency, CurrenciesDto>(filter, _mapper));
        }
    }
}
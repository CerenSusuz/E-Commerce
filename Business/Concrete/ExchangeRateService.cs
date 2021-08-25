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
using Microsoft.EntityFrameworkCore;

namespace Business.Concrete
{
    public class ExchangeRateService :ServiceRepository<ExchangeRateHistory,ExchangeRateDto>, IExchangeRateHistoryService
    {
        private readonly IRepository<ExchangeRateHistory> _repository;
        private readonly IMapper _mapper;
        public ExchangeRateService(IRepository<ExchangeRateHistory> repository, IMapper mapper) : base(repository, mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        
        [CacheAspect]
        public async Task<PagedList<ExchangeRatesDto>> GetAllAsync(Filter filter, int currencyId)
        {
            return await Task.Run(() => _repository.AsNoTracking
                .Where(x=>x.CurrencyId == currencyId)
                .Include(c=>c.Currency)
                .Filter(filter)
                .ToPagedList<ExchangeRateHistory, ExchangeRatesDto>(filter, _mapper));
        }
    }
}
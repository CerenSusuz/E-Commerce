using AutoMapper;
using Business.Abstract;
using Business.Models.BaseDto;
using Business.Repositories;
using DataAccess.Entities;
using DataAccess.Repositories;

namespace Business.Concrete
{
    public class ExchangeRateService :ServiceRepository<ExchangeRateHistory,ExchangeRateDto>, IExchangeRateHistoryService
    {
        public ExchangeRateService(IRepository<ExchangeRateHistory> repository, IMapper mapper) : base(repository, mapper)
        {
        }
    }
}
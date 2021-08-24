using AutoMapper;
using Business.Abstract;
using Business.Models.BaseDto;
using Business.Repositories;
using DataAccess.Entities;
using DataAccess.Repositories;

namespace Business.Concrete
{
    public class CurrencyService :ServiceRepository<Currency,CurrencyDto>, ICurrencyService
    {
        public CurrencyService(IRepository<Currency> repository, IMapper mapper) : base(repository, mapper)
        {
        }
    }
}
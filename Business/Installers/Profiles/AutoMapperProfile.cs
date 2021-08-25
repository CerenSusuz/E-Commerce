using AutoMapper;
using Business.Models;
using Business.Models.BaseDto;
using Business.Models.BaseListDto;
using DataAccess.Entities;

namespace Business.Installers.Profiles
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Account, AccountsDto>()
                .ForMember(d => d.UserGroup, i => 
                    i.MapFrom(x => x.UserGroup.Description))
                .ForMember(d => d.Role, i => 
                    i.MapFrom(x => x.Role.Description))
                .ForMember(d => d.Gender, i => 
                    i.MapFrom(x => x.Gender.Description ?? ""));
                
            CreateMap<Account, AccountDto>().ReverseMap();

            CreateMap<AccountAddress, AccountAddressesDto>()
                .ForMember(a => a.Account, 
                    x  => 
                        x.MapFrom(d => d.Account.FirstName + " " + d.Account.LastName));
            CreateMap<AccountAddress, AccountAddressDto>().ReverseMap();
            
            CreateMap<Brand, BrandsDto>();
            CreateMap<Brand, BrandDto>().ReverseMap();
            
            CreateMap<Category, CategoriesDto>()
                .ForMember(x => x.Parent, a => 
                    a.MapFrom(d => d.Parent.CategoryName));
            CreateMap<Category, CategoryDto>().ReverseMap();
            
            CreateMap<City, CitiesDto>()
                .ForMember(a => a.Country,
                    x  =>
                        x.MapFrom(d => d.Country.CountryName));
            CreateMap<City, CityDto>().ReverseMap();
            
            CreateMap<Country, CountriesDto>();
            CreateMap<Country, CountryDto>().ReverseMap();
            
            CreateMap<Currency, CurrenciesDto>();
            CreateMap<Currency, CurrencyDto>().ReverseMap();
            
            CreateMap<District, DistrictsDto>()
                .ForMember(a => a.City,
                    x  =>
                        x.MapFrom(d => d.City.CityName));
            CreateMap<District, DistrictDto>().ReverseMap();
            
            CreateMap<ExchangeRateHistory, ExchangeRatesDto>()
                .ForMember(a => a.Currency,
                    x  =>
                        x.MapFrom(d => d.Currency.CurrencyCode));
            CreateMap<ExchangeRateHistory, ExchangeRateDto>().ReverseMap();

            CreateMap<FavoriteProduct, FavoriteProductsDto>()
                .ForMember(f => f.Account,
                    d =>
                        d.MapFrom(x => x.Account.FirstName + " " + x.Account.LastName))
                .ForMember(f => f.Product,
                    d =>
                        d.MapFrom(x => x.Product.Description));
            
            CreateMap<Gender, GendersDto>();
            CreateMap<Gender, GenderDto>().ReverseMap();

            CreateMap<ProductGroup, ProductGroupsDto>();
            CreateMap<ProductGroup, ProductGroupDto>().ReverseMap();
            
            CreateMap<ProductGroupLine, ProductGroupLinesDto>()
                .ForMember(a => a.ProductGroup,
                    x  =>
                        x.MapFrom(d => d.ProductGroup.Description));
            CreateMap<ProductGroupLine, ProductGroupLineDto>().ReverseMap();
            
            CreateMap<Product, ProductsDto>()
                .ForMember(p => p.Currency,
                    c => c.MapFrom(d => d.Currency.Symbol))
                .ForMember(d => d.Brand,
                    x => x.MapFrom(d => d.Brand.Description))
                .ForMember(x=>x.Category,
                    d=>d.MapFrom(c=>c.Category.CategoryName));
            
            CreateMap<RelatedProduct, RelatedProductsDto>()
                .ForMember(a => a.Product,
                    x  =>
                        x.MapFrom(d => d.Product.Description))
                .ForMember(a => a.SuggestionSelling,
                    x  =>
                        x.MapFrom(d => d.Product.Description));
            CreateMap<RelatedProduct, RelatedProductDto>().ReverseMap();
            
            CreateMap<Role, RolesDto>();
            CreateMap<Role, RoleDto>().ReverseMap();
            
            CreateMap<Rule, RulesDto>()
                .ForMember(a => a.Role,
                    x  =>
                        x.MapFrom(d => d.Role.Description));
            CreateMap<Rule, RuleDto>().ReverseMap();
            
            CreateMap<Setting, SettingsDto>();
            CreateMap<Setting, SettingDto>().ReverseMap();
            
            CreateMap<UserGroup, UserGroupsDto>();
            CreateMap<UserGroup, UserGroupDto>().ReverseMap();


            

        }
    }
}
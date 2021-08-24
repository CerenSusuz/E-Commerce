﻿using AutoMapper;
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
            CreateMap<Gender, GendersDto>();
            CreateMap<Gender, GenderDto>().ReverseMap();

            CreateMap<UserGroup, UserGroupsDto>();
            CreateMap<UserGroup, UserGroupDto>().ReverseMap();
            
            CreateMap<Account, AccountsDto>()
                .ForMember(d => d.UserGroup, i => 
                    i.MapFrom(x => x.UserGroup.Description))
                .ForMember(d => d.Role, i => 
                    i.MapFrom(x => x.Role.Description))
                .ForMember(d => d.Gender, i => 
                    i.MapFrom(x => x.Gender.Description ?? ""));
                
            CreateMap<Account, AccountDto>().ReverseMap();

        }
    }
}
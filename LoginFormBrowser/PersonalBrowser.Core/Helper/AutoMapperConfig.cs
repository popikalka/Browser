using AutoMapper;
using PersonalBrowser.Core.BusinessObjects;
using PersonalBrowser.Core.DataAccess;
using System;

namespace PersonalBrowser.Core.Helper
{
    public class AutoMapperConfig
    {
        public static void RegisterMap()
        {
            Mapper.CreateMap<User, UserDto>()
            .ForMember(dest => dest.Id, opt => opt.MapFrom(source => source.Id))
            .ForMember(dest => dest.Name, opt => opt.MapFrom(source => source.Name.Trim()))
            .ForMember(dest => dest.Links, opt => opt.MapFrom(source => source.Links));

            Mapper.CreateMap<Link, LinkDto>()
            .ForMember(dest => dest.Address, opt => opt.MapFrom(source => new Uri(source.Address.Trim())))
            .ForMember(dest => dest.Title, opt => opt.MapFrom(source => source.Title.Trim()));

            Mapper.CreateMap<LinkDto, Link>()
            .ForMember(dest => dest.Address, opt => opt.MapFrom(source => source.Address.ToString()))
            .ForMember(dest => dest.Title, opt => opt.MapFrom(source => source.Title))
            .ForMember(dest => dest.UserId, opt => opt.MapFrom(source => source.UserId));
        }
    }
}

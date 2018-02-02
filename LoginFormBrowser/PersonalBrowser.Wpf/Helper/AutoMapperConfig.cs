using AutoMapper;
using PersonalBrowser.Core.BusinessObjects;
using PersonalBrowser.Wpf.Model;
using PersonalBrowser.Wpf.ViewModel;

namespace PersonalBrowser.Wpf.Helper
{
    public class AutoMapperConfig
    {
        public static void RegisterMap()
        {
            Mapper.CreateMap<MainViewModel, UserDto>()
            .ForMember(dest => dest.Name, opt => opt.MapFrom(source => source.UserName))
            .ForMember(dest => dest.Links, opt => opt.MapFrom(source => source.Links))
            .ForMember(dest => dest.Id, opt => opt.MapFrom(source => source.UserId));

            Mapper.CreateMap<UserDto, MainViewModel>()
            .ForMember(dest => dest.UserName, opt => opt.MapFrom(source => source.Name))
            .ForMember(dest => dest.Links, opt => opt.MapFrom(source => source.Links))
            .ForMember(dest => dest.UserId, opt => opt.MapFrom(source => source.Id));

            Mapper.CreateMap<LinkUi, LinkDto>()
            .ForMember(dest => dest.Address, opt => opt.MapFrom(source => source.Address))
            .ForMember(dest => dest.Title, opt => opt.MapFrom(source => source.Title))
            .ForMember(dest => dest.UserId, opt => opt.MapFrom(source => source.UserId));

            Mapper.CreateMap<LinkDto, LinkUi>()
            .ForMember(dest => dest.Address, opt => opt.MapFrom(source => source.Address))
            .ForMember(dest => dest.Title, opt => opt.MapFrom(source => source.Title))
            .ForMember(dest => dest.UserId, opt => opt.MapFrom(source => source.UserId));
        }
    }
}

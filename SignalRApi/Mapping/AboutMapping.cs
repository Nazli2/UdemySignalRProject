using AutoMapper;
using SignalR.DtoLayer.AboutDto;

namespace SignalRApi.Mapping;

public class AboutMapping : Profile
{
    public AboutMapping()
    {
        CreateMap<AboutMapping, ResultAboutDto>().ReverseMap();
        CreateMap<AboutMapping, GetAboutDto>().ReverseMap();
        CreateMap<AboutMapping, CreateAboutDto>().ReverseMap();
        CreateMap<AboutMapping, UpdateAboutDto>().ReverseMap();
    }
}

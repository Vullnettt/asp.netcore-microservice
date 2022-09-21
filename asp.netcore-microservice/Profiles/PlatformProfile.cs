using asp.netcore_microservice.Dtos;
using asp.netcore_microservice.Models;
using AutoMapper;

namespace asp.netcore_microservice.Profiles
{
    public class PlatformProfile : Profile
    {
        public PlatformProfile()
        {
            CreateMap<PlatformCreateDto, Platform>();
            CreateMap<PlatformUpdateDto, Platform>();
            CreateMap<PlatformNameDto, Platform>();
        }
    }
}

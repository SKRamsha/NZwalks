using AutoMapper;

namespace NZWalks.API1.Profiles
{
    public class RegionsProfile : Profile
    {
        public RegionsProfile()
        {
            CreateMap<Models.Domain.Region, Models.DTO.Region>()
               .ReverseMap();
        }
    }
}

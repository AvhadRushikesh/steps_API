using AutoMapper;
using steps_API.Model;
using steps_API.Users;

namespace steps_API.AutoMapper
{
    public class MapperConfig : Profile
    {
        public MapperConfig()
        {
            CreateMap<ApiUserDto, ApiUser>().ReverseMap();
        }
    }
}

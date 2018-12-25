using AutoMapper;

namespace ReactLabAuthentication.Models
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<User, UserDto>();
            CreateMap<UserDto, User>();            
        }
    }
}

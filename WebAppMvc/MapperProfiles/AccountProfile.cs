using AutoMapper;
using WebAppMvc.Models.Identity;
using WebAppMvc.ViewModels;

namespace WebAppMvc.MapperProfiles
{
    public class AccountProfile : Profile
    {
        public AccountProfile()
        {
            CreateMap<ApplicationUser, UserProfileViewModel>().ReverseMap();
        }
    }
}

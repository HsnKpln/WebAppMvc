using AutoMapper;
using WebAppMvc.Core.Identity;
using WebAppMvc.Core.ViewModels;

namespace WebAppMvc.Business.MapperProfiles
{
    public class AccountProfile : Profile
    {
        public AccountProfile()
        {
            CreateMap<ApplicationUser, UserProfileViewModel>().ReverseMap();
        }
    }
}

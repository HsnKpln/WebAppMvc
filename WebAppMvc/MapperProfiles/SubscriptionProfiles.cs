using AutoMapper;
using WebAppMvc.Models.Entities;
using WebAppMvc.ViewModels;

namespace WebAppMvc.MapperProfiles
{
    public class SubscriptionProfiles : Profile
    {
        public SubscriptionProfiles()
        {
            CreateMap<SubscriptionType, SubscriptionTypeViewModel>().ReverseMap();
            CreateMap<Address, AddressViewModel>().ReverseMap();
        }
    }
}

using AutoMapper;
using WebAppMvc.Core.Entities;
using WebAppMvc.Core.ViewModels;

namespace WebAppMvc.Business.MapperProfiles
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

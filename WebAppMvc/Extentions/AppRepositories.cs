using Microsoft.Extensions.DependencyInjection;
using WebAppMvc.Business.Repository.Abstract;

namespace WebAppMvc.Extentions
{
    public static class AppRepositories
    {
        public static IServiceCollection AddAppRepositories(this IServiceCollection services)
        {
            services.AddScoped<AddressRepo>();
            services.AddScoped<SubscriptionRepo>();
            services.AddScoped<SubscriptionTypeRepo>();
            return services;
        }
    }
}

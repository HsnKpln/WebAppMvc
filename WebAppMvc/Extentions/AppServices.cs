using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using WebAppMvc.injectOrnek;
using WebAppMvc.MapperProfiles;
using WebAppMvc.Services;

namespace WebAppMvc.Extentions
{
    public static class AppServices
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.ConfigureApplicationCookie(options =>
            {
                // Cookie settings
                options.ExpireTimeSpan = TimeSpan.FromMinutes(5);

                options.LoginPath = "/Account/Login";
                options.AccessDeniedPath = "/Account/AccessDenied";
                options.SlidingExpiration = true;
            });

            services.AddAutoMapper(options =>
            {
                options.AddProfile(typeof(AccountProfile));
            });

            services.AddTransient<IEmailSender, EmailSender>();
            services.AddScoped<IPaymentService,IyzicoPaymentService>();
            services.AddScoped<IMyDependency, NewMyDependency>();

            return services;
        }
    }
}

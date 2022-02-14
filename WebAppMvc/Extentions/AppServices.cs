using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using WebAppMvc.Business.MapperProfiles;
using WebAppMvc.Business.Services.Email;
using WebAppMvc.Business.Services.Payment;
using WebAppMvc.injectOrnek;

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
                options.AddProfile(typeof(PaymentProfile));
                options.AddProfile< SubscriptionProfiles > ();
            });

            services.AddTransient<IEmailSender, EmailSender>();
            services.AddScoped<IPaymentService,IyzicoPaymentService>();
            services.AddScoped<IMyDependency, NewMyDependency>();

            return services;
        }
    }
}

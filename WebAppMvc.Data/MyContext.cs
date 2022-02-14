using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WebAppMvc.Core.Entities;
using WebAppMvc.Core.Identity;

namespace WebAppMvc.Data
{
    public class MyContext : IdentityDbContext<ApplicationUser, ApplicationRole, string>
    {
        public MyContext(DbContextOptions<MyContext> options)
            : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<SubscriptionType>()
                .Property(x => x.Price)
                .HasPrecision(8, 2);

            builder.Entity<Subscription>()
                .Property(x => x.Amount)
                .HasPrecision(8, 2);

            builder.Entity<Subscription>()
                .Property(x => x.PaidAmount)
                .HasPrecision(8, 2);

            //builder.Entity<SubscriptionType>()
            //    .Property(x => x.Name).IsRequired();
        }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<State> States { get; set; }
        public DbSet<Subscription> subscriptions { get; set; }
        public DbSet<SubscriptionType> subscriptionTypes { get; set; }


    }
}

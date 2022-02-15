
using System;
using WebAppMvc.Core.Entities;
using WebAppMvc.Data;

namespace WebAppMvc.Business.Repository.Abstract
{
    public class SubscriptionRepo : BaseRepository<Subscription, Guid>
    {
        public SubscriptionRepo(MyContext context) : base(context)
        {
        }
    }
}

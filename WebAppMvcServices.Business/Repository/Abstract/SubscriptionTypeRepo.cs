
using System;
using WebAppMvc.Core.Entities;
using WebAppMvc.Data;

namespace WebAppMvc.Business.Repository.Abstract
{
    public class SubscriptionTypeRepo : BaseRepository<SubscriptionType, Guid>
    {
        public SubscriptionTypeRepo(MyContext context) : base(context)
        {
        }
    }
}

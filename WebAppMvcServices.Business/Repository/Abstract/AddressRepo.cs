
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAppMvc.Core.Entities;
using WebAppMvc.Data;

namespace WebAppMvc.Business.Repository.Abstract
{
    public class AddressRepo : BaseRepository<Address, Guid>
    {
        public AddressRepo(MyContext context) : base(context)
        {
        }
    }
}

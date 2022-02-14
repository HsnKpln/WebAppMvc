using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using WebAppMvc.Core.ViewModels;
using WebAppMvc.Data;

namespace WebAppMvc.Components
{
    public class PricingTableViewComponent : ViewComponent
    {
        private readonly MyContext _dbContext;
        private readonly IMapper _mapper;
        public PricingTableViewComponent (MyContext dbContext,IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }
        public IViewComponentResult Invoke()
        {
            var data = _dbContext.subscriptionTypes
                .ToList()
                .Select(x => _mapper.Map<SubscriptionTypeViewModel>(x))
                .OrderBy(x => x.Price)
                .ToList();

            return View(data);
        }
    }
}

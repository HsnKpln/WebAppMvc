using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WebAppMvc.Data;
using WebAppMvc.injectOrnek;
using WebAppMvc.ViewModels;

namespace WebAppMvc.Controllers
{
    public class HomeController : Controller
    {
        private readonly IMyDependency _myDependency;
        private readonly MyContext _dbContext;
        private readonly IMapper _mapper;

        public HomeController(IMyDependency myDependency,MyContext dbContext,IMapper mapper)
        {
            _myDependency = myDependency;
            _dbContext=dbContext;
            _mapper=mapper;
        }

        public IActionResult Index()
        {
            _myDependency.Log("Home/Index'e girildi");

            //var data = _dbContext.subscriptionTypes
            //    .ToList()
            //    .Select(x=>_mapper.Map<SubscriptionTypeViewModel>(x))
            //    .OrderBy(x => x.Price)
            //    .ToList();

            return View();
        }
    }
}

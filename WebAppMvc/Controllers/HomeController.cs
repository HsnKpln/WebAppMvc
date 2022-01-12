using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WebAppMvc.injectOrnek;

namespace WebAppMvc.Controllers
{
    public class HomeController : Controller
    {
        private readonly IMyDependency _myDependency;

        public HomeController(IMyDependency myDependency)
        {
            _myDependency = myDependency;
        }

        public IActionResult Index()
        {
            _myDependency.Log("Home/Index'e girildi");
            return View();
        }
    }
}

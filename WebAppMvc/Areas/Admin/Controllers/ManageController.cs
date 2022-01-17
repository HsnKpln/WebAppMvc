using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace WebAppMvc.Areas.Admin.Controllers
{
    public class ManageController : AdminBaseController
    {
        public IActionResult Index() 
        {
            return View();
        }
        [AllowAnonymous]
        public IActionResult Login()
        {
            return View();
        }
    }
}

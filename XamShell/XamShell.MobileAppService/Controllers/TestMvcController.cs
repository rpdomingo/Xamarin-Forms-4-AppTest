using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace XamShell.MobileAppService.Controllers
{
    public class TestMvcController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
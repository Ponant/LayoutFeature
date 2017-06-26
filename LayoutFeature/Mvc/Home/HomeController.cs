using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LayoutFeature.Mvc.Home
{
    public class HomeController : Controller
    {
        [HttpGet("myroute")]
        public IActionResult Index() => View();
    }
}

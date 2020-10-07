using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace IHome.Controllers
{
    public class IHomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

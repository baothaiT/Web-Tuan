using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web_Shoes.Controllers
{
    public class AdminPageController : Controller
    {
        [Route("admin")]
        public IActionResult Index()
        {
            return View();
        }
    }
}

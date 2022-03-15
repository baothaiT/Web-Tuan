using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Web_Shoes.Data;
using Web_Shoes.Models;

namespace Web_Shoes.Controllers
{
    public class HomeController : Controller
    {
        

        private readonly ApplicationDbContext _context;



        public HomeController( ApplicationDbContext context)
        {
            
            _context = context;
        }

        public IActionResult Index()
        {

            var HomeProductQuery = from a in _context.Products select a;

            

            return View(HomeProductQuery);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

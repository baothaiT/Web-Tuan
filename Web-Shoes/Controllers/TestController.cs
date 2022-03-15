using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web_Shoes.Data;

namespace Web_Shoes.Controllers
{
    public class TestController : Controller
    {

        private readonly ApplicationDbContext _context;


        public TestController(ApplicationDbContext context)
        {
            _context = context;
        }


        [Route("/test")]
        [HttpGet]
        public IActionResult Index()
        {
            //string search = Request.Form["search"];

            string namePc = Environment.MachineName;

            return View();
        }



    }
}

using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web_Shoes.Data;
using Web_Shoes.Models;

namespace Web_Shoes.Controllers
{
    public class WomenController : Controller
    {

        private readonly ApplicationDbContext _context;

        public WomenController(ApplicationDbContext context)
        {
            _context = context;
        }


        [Route("/women")]
        [HttpGet]
        public IActionResult Index()
        {

            var query = from a in _context.Products
                        join b in _context.ProductsInCategories on a.pd_Id equals b.pic_productId
                        join c in _context.Categories on b.pic_CategoriesId equals c.cg_Id
                        select new { a,c };

            query = query.Where(x => x.c.cg_Name == "women");



            var productModelQuery = query
                .Select(x => new ProductModel()
                {
                    pd_Id = x.a.pd_Id,
                    pd_Img1 = x.a.pd_Img1,
                    pd_Name = x.a.pd_Name,
                    pd_Price = x.a.pd_Price

                });


            return View(productModelQuery);
        }
    }
}

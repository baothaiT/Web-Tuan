using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web_Shoes.Data;
using Web_Shoes.Entity;
using Web_Shoes.Models;

namespace Web_Shoes.Controllers
{
    public class AboutController : Controller
    {

        private readonly ApplicationDbContext _context;


        public AboutController(ApplicationDbContext context)
        {
            _context = context;
        }


        [Route("/about")]
        [HttpGet]
        public IActionResult Index()
        {
            var about = _context.About.FirstOrDefault(a => a.about_id == 1);

            return View(about);
        }

        [Route("/aboutmanagement")]
        [HttpGet]
        public IActionResult IndexAdmin()
        {
            var about = from a in _context.About select a;

            return View(about);
        }


        [HttpGet("/aboutmanagement/edit/{id:int?}")]
        // GET: ProductManagementController/Edit/5
        public ActionResult Edit(int id)
        {
            try
            {

                var aboutQuery = _context.About.FirstOrDefault(x => x.about_id == id);

                return View(aboutQuery);
            }
            catch (Exception)
            {

                ViewBag.thongbao = "Cann't create";
                return View();
            }

        }

        // POST: ProductManagementController/Edit/5
        [HttpPost("/aboutmanagement/edit/{id:int?}")]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, About about)
        {
            try
            {
                var aboutQuery = _context.About.FirstOrDefault(x => x.about_id == id);


                aboutQuery.about_Url = about.about_Url;
                aboutQuery.about_Title = about.about_Title;
                aboutQuery.about_Description = about.about_Description;

                _context.SaveChanges();


                return RedirectToAction(nameof(IndexAdmin));
            }
            catch
            {
                return View();
            }
        }

    }
}

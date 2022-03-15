using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web_Shoes.Data;
using Web_Shoes.Entity;

namespace Web_Shoes.Controllers
{
    public class ContactController : Controller
    {
        private readonly ApplicationDbContext _context;


        public ContactController(ApplicationDbContext context)
        {
            _context = context;
        }

        [Route("/contact")]
        [HttpGet]
        public IActionResult Index()
        {
            //var contact = _context.ContactSystem.FirstOrDefault(a => a.Contact_Id ==1);

            return View();
        }

        [Route("/contactusersmanagement/create")]
        [HttpPost]
        public async Task<ActionResult> create()
        {
            try
            {

                var contactUser = new ContactUsers()
                {
                    cu_FirstName = Request.Form["firstname"],
                    cu_LastName = Request.Form["lastname"],
                    cu_Email = Request.Form["email"],
                    cu_Description = Request.Form["message"],
                    cu_Subject = Request.Form["subject"]
                };


                _context.ContactUsers.Add(contactUser);

                await _context.SaveChangesAsync();

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }


        [Route("/contactusersmanagement")]
        [HttpGet]
        public IActionResult IndexAdminUser()
        {
            var contact = from a in _context.ContactUsers select a;

            return View(contact);
        }


        [Route("/contactmanagement")]
        [HttpGet]
        public IActionResult IndexAdmin()
        {
            var contact = from a in _context.ContactSystem select a;
            return View(contact);
        }



        [HttpGet("/contactmanagement/edit/{id:int?}/")]
        // GET: ProductManagementController/Edit/5
        public ActionResult Edit(int id)
        {
            try
            {

                var contactQuery = _context.ContactSystem.FirstOrDefault(x => x.Contact_Id == id);

                return View(contactQuery);
            }
            catch (Exception)
            {

                ViewBag.thongbao = "Cann't create";
                return View();
            }

        }

        // POST: ProductManagementController/Edit/5
        [HttpPost("/contactmanagement/edit/{id:int?}/")]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, ContactSystem contactSystem)
        {
            try
            {

                var contactQuery = _context.ContactSystem.FirstOrDefault(x => x.Contact_Id == id);

                contactQuery.Contact_Address = contactSystem.Contact_Address;
                contactQuery.Contact_Phone = contactSystem.Contact_Phone;
                contactQuery.Contact_Email = contactSystem.Contact_Email;
                contactQuery.Contact_Website = contactSystem.Contact_Website;



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

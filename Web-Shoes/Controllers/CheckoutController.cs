using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Web_Shoes.Data;
using Web_Shoes.Entity;
using Web_Shoes.Models;

namespace Web_Shoes.Controllers
{
    public class CheckoutController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly SignInManager<AppUser> _SignInManager;
        private readonly UserManager<AppUser> _UserManager;

        public CheckoutController(ApplicationDbContext context, UserManager<AppUser> UserManager, SignInManager<AppUser> SignInManager)
        {
            _context = context;
            _UserManager = UserManager;
            _SignInManager = SignInManager;
        }


        [Route("/checkout")]
        [HttpGet("{reduceprice}")]
        public IActionResult Index(string reduceprice)
        {
            //try
            //{

            //    var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);

            //    var userName = User.FindFirstValue(ClaimTypes.Name);


            //    var query = from a in _context.Products
            //                join b in _context.ProductInCart on a.pd_Id equals b.pic_ProductId
            //                join c in _context.Cart on b.pic_CartId equals c.cart_Id
            //                join d in _context.AppUser on c.cart_UserID equals d.Id
            //                select new { a, b, c, d };


            //    query = query.Where(x => x.d.Id == userId);



            //    var productInCartModelQuery = query
            //        .Select(x => new ProductInCartModel()
            //        {
            //            ProductId = x.a.pd_Id,
            //            ProductName = x.a.pd_Name,
            //            ProductPrice = x.a.pd_Price,
            //            ProductImg1 = x.a.pd_Img1,
            //            Quantity = x.b.pic_amount,
            //            UserId = x.d.Id,
            //            Color = x.b.pic_color,
            //            Size = x.b.pic_size

            //        });


            //    var cartDetail = query.Select(a => new CheckOutModel()
            //    {
            //        checkout_ProductName = a.a.pd_Name,
            //        checkout_Quantity = a.b.pic_amount,
            //        checkout_Price = a.a.pd_Price
            //    });

            //    var shipingQuery = _context.Shipping.FirstOrDefault(a => a.ship_Name == "ship");



            //    ViewBag.Discount = reduceprice;

            //    int reTotal = 0;
            //    foreach (var item in cartDetail)
            //    {
            //        reTotal += item.checkout_Price;
            //    }

            //    ViewBag.Retotal = reTotal;
            //    ViewBag.Ship = 0;
            //    int ship = 0;

            //    if (shipingQuery!= null)
            //    {

            //        string a = shipingQuery.ship_Price.ToString();
            //        ship = Int32.Parse(a);
            //        ViewBag.Ship = ship;
            //    }



            //    int discount = Int32.Parse(reduceprice);
            //    ViewBag.Total = reTotal + ship - discount;

            //    return View(cartDetail);
            //}
            //catch 
            //{

            //    return View();
            //}




            return View();

        }

        [Route("/checkout/Add")]
        [HttpGet("{reduceprice}")]
        public async Task<IActionResult> AddToBill(String reduceprice)
        {
            var aa = reduceprice;
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);

            var userName = User.FindFirstValue(ClaimTypes.Name);

            string firstName = Request.Form["FirstName"];
            string country = Request.Form["Country"];
            string lastName = Request.Form["LastName"];
            string companyName = Request.Form["CompanyName"];
            string address1 = Request.Form["Address1"];
            string address2 = Request.Form["Address2"];
            string city = Request.Form["City"];
            string state = Request.Form["State"];
            string postal = Request.Form["Postal"];
            string email = Request.Form["Email"];
            string phone = Request.Form["Phone"];
            string reducePrice = Request.Form["Reduceprice"];


            var query = from a in _context.Products
                        join b in _context.ProductInCart on a.pd_Id equals b.pic_ProductId
                        join c in _context.Cart on b.pic_CartId equals c.cart_Id
                        join d in _context.AppUser on c.cart_UserID equals d.Id
                        select new { a, b, c, d };


            query = query.Where(x => x.d.Id == userId);



            var productInCartModelQuery = query
                .Select(x => new ProductInCartModel()
                {
                    ProductId = x.a.pd_Id,
                    ProductName = x.a.pd_Name,
                    ProductPrice = x.a.pd_Price,
                    ProductImg1 = x.a.pd_Img1,
                    Quantity = x.b.pic_amount,
                    UserId = x.d.Id,
                    Color = x.b.pic_color,
                    Size = x.b.pic_size

                });


            var cartDetail = query.Select(a => new CheckOutModel()
            {
                checkout_ProductName = a.a.pd_Name,
                checkout_Quantity = a.b.pic_amount,
                checkout_Price = a.a.pd_Price
            });

            var shipingQuery = _context.Shipping.FirstOrDefault(a => a.ship_Name == "ship");



            ViewBag.Discount = reducePrice;

            int reTotal = 0;
            foreach (var item in cartDetail)
            {
                reTotal += item.checkout_Price;
            }

            ViewBag.Retotal = reTotal;
            ViewBag.Ship = 0;
            int ship = 0;

            if (shipingQuery != null)
            {

                string a = shipingQuery.ship_Price.ToString();
                ship = Int32.Parse(a);
                ViewBag.Ship = ship;
            }



            int discount = Int32.Parse(reducePrice.ToString());
            ViewBag.Total = reTotal + ship - discount;

            string productNameList = "";
            foreach (var item in cartDetail)
            {
                productNameList += "|" + item.checkout_Quantity + "|" + item.checkout_ProductName;
            }


            var bill = new Bills()
            {
                bill_Id = Guid.NewGuid().ToString(),
                bill_UserId = userId,
                bill_Discount = discount,
                bill_Shipping = ship,
                bill_PaidTotal = reTotal + ship - discount,
                bill_ProductNamelist = productNameList


            };

            /// Add
            _context.Bills.Add(bill);


            /// Remove
            var CartQuery = _context.Cart.FirstOrDefault(x => x.cart_UserID == userId);



            var ProductInCartQueryDelete = _context.ProductInCart.Where(a => a.pic_CartId == CartQuery.cart_Id);

            _context.ProductInCart.RemoveRange(ProductInCartQueryDelete);


            await _context.SaveChangesAsync();



            return Redirect("/OrderComplete");
        }



    }
}

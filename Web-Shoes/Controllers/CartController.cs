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
    public class CartController : Controller
    {


        private readonly ApplicationDbContext _context;

        private readonly SignInManager<AppUser> _SignInManager;
        private readonly UserManager<AppUser> _UserManager;

        public CartController(ApplicationDbContext context, UserManager<AppUser> UserManager, SignInManager<AppUser> SignInManager)
        {
            _context = context;
            _UserManager = UserManager;
            _SignInManager = SignInManager;
        }


        [Route("/cart")]
        [HttpGet("{productid}&{quantity}")]
        public IActionResult Index(int productid, int quantity)
        {

            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var userName = User.FindFirstValue(ClaimTypes.Name);

            string namePc = Environment.MachineName;
            bool checkLogin = (User?.Identity.IsAuthenticated).GetValueOrDefault();

            if (checkLogin)
            {
                //login
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

                return View(productInCartModelQuery);
            }
            else
            {
                //No login
                var query = from a in _context.Products
                            join b in _context.ProductInCartDevices on a.pd_Id equals b.picd_ProductId
                            join c in _context.CartsDevice on b.picd_CartId equals c.cartd_Id
                            join d in _context.Devices on c.cartd_DeviceId equals d.deviceId
                            select new { a, b, c, d };

                query = query.Where(x => x.d.deviceName == namePc);

                var productInCartModelQuery = query
                    .Select(x => new ProductInCartModel()
                    {
                        ProductId = x.a.pd_Id,
                        ProductName = x.a.pd_Name,
                        ProductPrice = x.a.pd_Price,
                        ProductImg1 = x.a.pd_Img1,
                        Quantity = x.b.picd_amount,
                        UserId = x.d.deviceId,
                        Color = x.b.picd_color,
                        Size = x.b.picd_size

                    });

                return View(productInCartModelQuery);

            }
            




            
        }



        [Route("/cart/remove")]
        [HttpGet("{productid}&{quantity}")]
        public IActionResult RemoveProduct(int productid, int quantity)
        {

            int aa = productid;

            try
            {
                var productQuery = _context.ProductInCart.FirstOrDefault(a => a.pic_ProductId == productid);
                _context.ProductInCart.Remove(productQuery);
                _context.SaveChanges();



                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return RedirectToAction(nameof(Index));
            }

            ////

        }

        [Route("/cart/paid")]
        [HttpGet("{coupon}&{quantity}")]
        public IActionResult addpaid(string coupon, int quantity)
        {

            try
            {
                int ReducePrice = 0;

                var couponQuery = _context.Coupons.FirstOrDefault(a => a.couponCode == coupon);

                if (couponQuery != null)
                {
                    ReducePrice = couponQuery.couponPrice;
                }




                return Redirect("/checkout?reduceprice="+ ReducePrice);
            }
            catch 
            {

                return RedirectToAction(nameof(Index));
            }
            
        }
    }
}

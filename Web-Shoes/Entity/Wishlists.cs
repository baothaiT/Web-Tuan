using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web_Shoes.Entity
{
    public class Wishlists
    {
        public int wl_Id { set; get; }
        public AppUser UserW { get; set; }
        public string wl_UserId { set; get; }
        public List<ProductInWishlist> ProductInWishlistW { get; set; }

    }
}

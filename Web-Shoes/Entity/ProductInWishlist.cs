using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web_Shoes.Entity
{
    public class ProductInWishlist
    {
        public Wishlists WishlistsPIW { get; set; }
        public int piw_WishlistId { get; set; }
        public Products ProductsPIW { get; set; }
        public int piw_ProductId { get; set; }
        public int piw_amount { get; set; }

    }
}

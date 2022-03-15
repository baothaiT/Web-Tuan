using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web_Shoes.Entity
{
    public class ProductsInCategories
    {
        public Categories CategoriesPIC { get; set; }
        public int pic_CategoriesId { get; set; }
        public Products ProductsPIC { get; set; }
        public int pic_productId { get; set; }
    }
}

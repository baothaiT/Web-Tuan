using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web_Shoes.Entity
{
    public class Categories
    {
        public int cg_Id { set; get; }
        public string cg_Name { set; get; }
        public string cg_Type { set; get; }
        public string cg_Sale { set; get; }
        public List<ProductsInCategories> ProductsInCategoriesC { get; set; }


    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Web_Shoes.Entity;

namespace Web_Shoes.Models
{
    public class ProductModel
    {
        
        public int pd_Id { set; get; }
        public string pd_Name { set; get; }
        public string pd_Description { set; get; }
        public int pd_Price { set; get; }

        public int pd_ReducePrice { set; get; }
        public string pd_Img1 { set; get; }
        public string pd_Img2 { set; get; }

        public string pd_Img3 { set; get; }
        public string pd_Img4 { set; get; }
        public int pd_Rate { set; get; }

        public string pd_MenuFacturer { set; get; }
        public string pd_ShortDescription { set; get; }
        public string pd_Size { set; get; }

        public string pd_Brand { set; get; }
        public string pd_Style { set; get; }
        public string pd_Color { set; get; }

        public string pd_Material { set; get; }
        public string pd_Technologies { set; get; }
     
      

    }
}

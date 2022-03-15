using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web_Shoes.Entity
{
    public class AppRole : IdentityRole
    {
        public string Description { set; get; }

        

    }
}

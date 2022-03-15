using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web_Shoes.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Web_Shoes.Configurations
{
    public class CartConfigurations : IEntityTypeConfiguration<Cart>
    {
        public void Configure(EntityTypeBuilder<Cart> builder)
        {
            builder.ToTable("Carts");
            builder.HasKey(t => new { t.cart_Id });
            builder.HasOne(t => t.AppUserC).WithMany(ur => ur.CartU)
     .HasForeignKey(pc => pc.cart_UserID);
        }
    }
}

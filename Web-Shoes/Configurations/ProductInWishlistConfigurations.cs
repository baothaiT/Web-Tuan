using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web_Shoes.Entity;

namespace Web_Shoes.Configurations
{
    public class ProductInWishlistConfigurations : IEntityTypeConfiguration<ProductInWishlist>
    {
        public void Configure(EntityTypeBuilder<ProductInWishlist> builder)
        {
            builder.ToTable("ProductInWishlist");
            builder.HasKey(t => new { t.piw_WishlistId, t.piw_ProductId });
            builder.HasOne(t => t.ProductsPIW).WithMany(ur => ur.ProductInWishlistP)
     .HasForeignKey(pc => pc.piw_ProductId);
            builder.HasOne(t => t.WishlistsPIW).WithMany(ur => ur.ProductInWishlistW)
     .HasForeignKey(pc => pc.piw_WishlistId);
        }
    }
}

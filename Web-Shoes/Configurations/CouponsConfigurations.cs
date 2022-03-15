using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web_Shoes.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Web_Shoes.Configurations
{
    public class CouponsConfigurations : IEntityTypeConfiguration<Coupons>
    {
        public void Configure(EntityTypeBuilder<Coupons> builder)
        {
            builder.ToTable("Coupons");
            builder.HasKey(t => new { t.couponId });



        }

    }
}

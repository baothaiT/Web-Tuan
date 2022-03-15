using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web_Shoes.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Web_Shoes.Configurations
{
    public class DeviceConfigurations : IEntityTypeConfiguration<Device>
    {

        public void Configure(EntityTypeBuilder<Device> builder)
        {
            builder.ToTable("Device");
            builder.HasKey(t => new { t.deviceId });



        }
    }
}

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UrunYonetimCore6584.Core.Entities;

namespace UrunYonetimCore6584.Data.Configurations
{
    public class BrandConfigurations : IEntityTypeConfiguration<Brand>
    {
        public void Configure(EntityTypeBuilder<Brand> builder)
        {
            builder.Property(x => x.Name).IsRequired().HasMaxLength(50); // marka class ının Name özelliği zorunlu
            builder.Property(x => x.Logo).HasMaxLength(100);
        }
    }
}

using LibeyTechnicalTestDomain.LibeyUserAggregate.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibeyTechnicalTestDomain.EFCore.Configuration
{
    internal class UbigeoConfiguration : IEntityTypeConfiguration<Ubigeo>
    {
        public void Configure(EntityTypeBuilder<Ubigeo> builder)
        {
            builder.ToTable("Ubigeo").HasKey(x => x.UbigeoCode);

            builder.HasOne(ubi => ubi.Province)
            .WithMany(pro => pro.Ubigeos)
            .HasForeignKey(ubi => ubi.ProvinceCode);

            builder.HasOne(ubi => ubi.Region)
            .WithMany(reg => reg.Ubigeos)
            .HasForeignKey(ubi => ubi.RegionCode);
        }
    }
}

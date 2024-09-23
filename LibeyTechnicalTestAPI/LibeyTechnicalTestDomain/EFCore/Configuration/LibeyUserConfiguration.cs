using LibeyTechnicalTestDomain.LibeyUserAggregate.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace LibeyTechnicalTestDomain.EFCore.Configuration
{
    internal class LibeyUserConfiguration : IEntityTypeConfiguration<LibeyUser>
    {
        public void Configure(EntityTypeBuilder<LibeyUser> builder)
        {
            builder.ToTable("LibeyUser")
                .HasKey(x => x.DocumentNumber);

            builder.HasOne(user => user.Ubigeo)
                .WithMany(ubigeo => ubigeo.LibeyUsers)
                .HasForeignKey(user => user.UbigeoCode);

            builder.HasOne(user => user.DocumentType)
                .WithMany(doc => doc.LibeyUsers)
                .HasForeignKey(user => user.DocumentTypeId);
        }
    }
}
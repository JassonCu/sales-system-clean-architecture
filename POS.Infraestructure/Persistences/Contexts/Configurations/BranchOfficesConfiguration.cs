using Microsoft.EntityFrameworkCore;
using POS.Domain.Entities;

namespace POS.Infraestructure.Persistences.Contexts.Configurations
{
    public class BranchOfficesConfiguration : IEntityTypeConfiguration<BranchOffice>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<BranchOffice> builder)
        {
            builder.HasKey(e => e.BranchOfficeId).HasName("PK__BranchOf__27247FF9390F2716");

            builder.Property(e => e.Address).IsUnicode(false);
            builder.Property(e => e.Code)
                .HasMaxLength(100)
                .IsUnicode(false);
            builder.Property(e => e.Description)
                .HasMaxLength(100)
                .IsUnicode(false);
            builder.Property(e => e.Email)
                .HasMaxLength(100)
                .IsUnicode(false);
            builder.Property(e => e.Name)
                .HasMaxLength(100)
                .IsUnicode(false);
            builder.Property(e => e.Phone)
                .HasMaxLength(100)
                .IsUnicode(false);

            builder.HasOne(d => d.Business).WithMany(p => p.BranchOffices)
                .HasForeignKey(d => d.BusinessId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__BranchOff__Busin__34C8D9D1");

            builder.HasOne(d => d.District).WithMany(p => p.BranchOffices)
                .HasForeignKey(d => d.DistrictId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__BranchOff__Distr__35BCFE0A");
        }
    }
}

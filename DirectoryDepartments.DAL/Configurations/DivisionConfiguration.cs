using DirectoryDepartments.Domain.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DirectoryDepartments.DAL.Configurations
{
    public class DivisionConfiguration : IEntityTypeConfiguration<Division>
    {
        public void Configure(EntityTypeBuilder<Division> builder)
        {
            builder.HasKey(d => d.Id);
            builder.Property(d => d.Id).ValueGeneratedOnAdd();
            builder.HasIndex(d => d.Id).IsUnique();
            builder.HasOne(d => d.ParentDivision)
                .WithMany(d => d.SubsidiaryDivisions)
                .HasForeignKey(d => d.ParentId);
            builder.Property(d => d.Name).HasMaxLength(250);
            builder.Property(d => d.Description).HasMaxLength(250);
        }
    }
}

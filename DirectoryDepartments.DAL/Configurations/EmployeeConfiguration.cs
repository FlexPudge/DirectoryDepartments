using DirectoryDepartments.Domain.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DirectoryDepartments.DAL.Configurations
{
    public class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.HasKey(d => d.Id);
            builder.Property(d => d.Id).ValueGeneratedOnAdd();
            builder.HasIndex(d => d.Id).IsUnique();
            builder.Property(d => d.FIO).HasMaxLength(250);

            builder.HasOne(x => x.Division)
                .WithMany(x => x.Employees)
                .HasForeignKey(x => x.Id)
                .IsRequired();

            builder.HasOne(d => d.Position)
                .WithMany(p => p.Employee)
                .HasForeignKey(d => d.Id).IsRequired();
        }
    }
}

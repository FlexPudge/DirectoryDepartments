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
/*            builder.HasOne(p => p.Division)
                .WithMany(b => b.Employees)
                .HasForeignKey(p => p.Id)
                .HasPrincipalKey(b => b.Employees);*/
        }
    }
}

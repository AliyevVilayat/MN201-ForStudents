using AcademyManagementProject.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Reflection.Emit;

namespace AcademyManagementProject.DataAccess.Configurations;

public class StudentConfiguration : IEntityTypeConfiguration<Student>
{
    public void Configure(EntityTypeBuilder<Student> builder)
    {
        builder
            .HasMany(s => s.Groups)
            .WithMany(g => g.Students);

        builder
            .HasIndex(s => s.Email)
            .IsUnique();
    }
}

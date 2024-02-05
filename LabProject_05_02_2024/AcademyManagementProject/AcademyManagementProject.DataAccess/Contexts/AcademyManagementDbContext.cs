using AcademyManagementProject.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace AcademyManagementProject.DataAccess.Contexts;

public class AcademyManagementDbContext:DbContext
{
    private readonly string _connectionStr = @"";

    public DbSet<Student> Students { get; set; } = null!;

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(_connectionStr);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Student>().HasIndex(s => s.Email).IsUnique();

    }
}

using AcademyManagementProject.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace AcademyManagementProject.DataAccess.Contexts;

public class AcademyManagementDbContext:DbContext
{
    private readonly string _connectionStr = @"Server=TITAN00\SQLEXPRESS;Database=AcademyManagementDB;Trusted_Connection=True;";

    public DbSet<Student> Students { get; set; } = null!;
    public DbSet<Group> Groups { get; set; } = null!;

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(_connectionStr);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Student>().HasIndex(s => s.Email).IsUnique();

    }
}

using AcademyManagementProject.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace AcademyManagementProject.DataAccess.Contexts;

public class AcademyManagementDbContext:DbContext
{
    private readonly string _connectionStr = @"Server=localhost;Database=AcademyManagementDB;Trusted_Connection=True;";

    public DbSet<Student> Students { get; set; } = null!;
    public DbSet<Group> Groups { get; set; } = null!;

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(_connectionStr, options => options.EnableRetryOnFailure());
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }
}

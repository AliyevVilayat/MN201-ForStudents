using Microsoft.EntityFrameworkCore;
using Pronia.Core.Entities;

namespace Pronia.DataAccess;

public class ProniaDbContext:DbContext
{
    private readonly string _connectionString = @"Server=localhost;Database=ProniaDB; Trusted_Connection = true;";
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(_connectionString, 
            options => options.EnableRetryOnFailure());
    }

    protected DbSet<Category> Categories { get; set; } = null!;
    protected DbSet<Size> Sizes { get; set; } = null!;
    protected DbSet<Color> Colors { get; set; } = null!;
}

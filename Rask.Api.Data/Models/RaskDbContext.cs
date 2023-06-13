using Microsoft.EntityFrameworkCore;

namespace Rask.Api.Data.Models;

public class RaskDbContext : DbContext
{
    public DbSet<Department> Departments { get; set; } = null!;
    public DbSet<Employee> Employees { get; set; } = null!;
    public DbSet<User> Users { get; set; } = null!;

    public string DbPath { get; }

    public RaskDbContext()
    {
        // build database file path
        var folder = Environment.SpecialFolder.LocalApplicationData;
        var path = Environment.GetFolderPath(folder);
        DbPath = Path.Combine(path, "dev.db");
    }

    // The following configures EF to create a Sqlite database file in the
    // special "local" folder for your platform.
    protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseSqlite($"Data Source={DbPath}");
}

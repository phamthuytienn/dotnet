using BlazorApp1.Data;
using Microsoft.EntityFrameworkCore;

namespace BlazorApp1.db;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }

    public DbSet<Student> Students { get; set; }
}
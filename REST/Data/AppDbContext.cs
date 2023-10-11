using Microsoft.EntityFrameworkCore;
using REST.Entities;

namespace REST.Data;

public class AppDbContext : DbContext 
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
    public DbSet<Users> Users { get; set; }
    public DbSet<Course> Courses { get; set; }
}

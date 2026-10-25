using Auth.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace Auth.DAL.ApplicationDbContext;

public class ApplicationDBContext : DbContext
{
    public ApplicationDBContext(DbContextOptions<ApplicationDBContext > options): base(options)
    {
    }

    public DbSet<User> Users { get; set; } = null!;
}
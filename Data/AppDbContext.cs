using Microsoft.EntityFrameworkCore;
using WebApi.Entities;

namespace WebApi.Data;
public class AppDbContext  : DbContext
{
  public DbSet<University>? universeties { get ; set;}
  public AppDbContext(DbContextOptions<AppDbContext> options) :base (options) { }
}
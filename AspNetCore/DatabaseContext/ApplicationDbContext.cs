using Microsoft.EntityFrameworkCore;
using AspNetCore.Models;

namespace AspNetCore.DatabaseContext
{
  public class ApplicationDbContext : DbContext
  {
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    { }

    public DbSet<FoodRecord> FoodRecords { get; set; }
  }
}
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer;
internal class NorthwindContext : DbContext
{
  public DbSet<Category> Categories { get; set; }

  protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
  {
    optionsBuilder.LogTo(Console.WriteLine, Microsoft.Extensions.Logging.LogLevel.Information);

    string host = "";
    string db = "";
    string uid = "";
    string pwd = "";

    var connectionString = $"Host={host};Database={db};Username={uid};Password={pwd}";

    optionsBuilder.UseNpgsql(connectionString);
  }

  protected override void OnModelCreating(ModelBuilder modelBuilder)
  {
    modelBuilder.Entity<Category>().ToTable("categories");
    modelBuilder.Entity<Category>().Property(x => x.Id).HasColumnName("categoryid");
    modelBuilder.Entity<Category>().Property(x => x.Name).HasColumnName("categoryname");
    modelBuilder.Entity<Category>().Property(x => x.Description).HasColumnName("description");
  }
}
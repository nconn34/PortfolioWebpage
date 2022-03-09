using Microsoft.EntityFrameworkCore;

namespace Portfolio.Models
{
  public class PortfolioContext : DbContext
  {
    public DbSet<Skills> portfolio { get;set; }
    public PortfolioContext(DbContextOptions options) : base(options) { }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      optionsBuilder.UseLazyLoadingProxies();
    }
  }
}
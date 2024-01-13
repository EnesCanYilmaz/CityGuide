namespace LensCity.Infrastructure.Data.Contexts;

public class LensCityContext : DbContext
{
    public LensCityContext(DbContextOptions<LensCityContext> options) : base(options)
    {
    }

    public DbSet<City> Cities { get; set; }
    public DbSet<Photo> Photos { get; set; }
}
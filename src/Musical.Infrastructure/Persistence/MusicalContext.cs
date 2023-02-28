using Microsoft.EntityFrameworkCore;
using Musical.Domain.Entities;
using System.Reflection;

namespace Musical.Infrastructure.Persistence;

public class MusicalContext : DbContext
{
    public DbSet<Artist> Artists { get; set; }
    public DbSet<Album> Albums { get; set; }

    public MusicalContext(DbContextOptions<MusicalContext> options) : base(options) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        base.OnModelCreating(modelBuilder);
    }
}

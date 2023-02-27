using Microsoft.EntityFrameworkCore;
using Musical.Domain.Entities;
using System.Reflection;

namespace Musical.Infrastructure.Persistence;

public class MusicalContext : DbContext
{
    public DbSet<Artist> Artists => Set<Artist>();
    public DbSet<Album> Albums => Set<Album>();

    public MusicalContext(DbContextOptions<MusicalContext> options) : base(options) { }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        base.OnModelCreating(builder);
    }
}

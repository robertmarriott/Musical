using Ardalis.Specification;
using Microsoft.EntityFrameworkCore;
using Musical.Domain.Entities;
using Musical.Domain.Repositories;

namespace Musical.Infrastructure.Persistence.Repositories;

public class ArtistRepository : IArtistRepository
{
    private readonly MusicalContext _context;

    public ArtistRepository(MusicalContext context)
    {
        _context = context;
    }

    public Task<IEnumerable<Artist>> ListAsync(Specification<Artist> specification)
    {
        var queryResult = SpecificationEvaluator.Default.GetQuery(
            query: _context.Artists.AsQueryable(),
            specification: specification);

        return queryResult.ToListAsync();
    }
}

using Ardalis.Specification;

namespace Musical.Domain.Repositories;

public interface IArtistRepository
{
    Task<IEnumerable<Artist>> ListAsync(Specification<Artist> specification);
}

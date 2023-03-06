using Ardalis.Specification.EntityFrameworkCore;
using Musical.Domain.Repositories;

namespace Musical.Infrastructure.Persistence.Repositories;

public class ReadRepository<T> : RepositoryBase<T>, IReadRepository<T> where T : class
{
    public ReadRepository(MusicalContext context) : base(context) { }
}

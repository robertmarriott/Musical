using Ardalis.Specification.EntityFrameworkCore;
using Musical.Domain.Repositories;

namespace Musical.Infrastructure.Persistence.Repositories;

public class Repository<T> : RepositoryBase<T>, IRepository<T> where T : class
{
    public Repository(MusicalContext context) : base(context) { }
}

using Ardalis.Specification;

namespace Musical.Domain.Repositories;

public interface IReadRepository<T> : IReadRepositoryBase<T> where T : class
{
}

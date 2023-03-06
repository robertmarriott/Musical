using Ardalis.Specification;

namespace Musical.Domain.Repositories;

public interface IRepository<T> : IRepositoryBase<T> where T : class
{
}

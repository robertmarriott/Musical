using Ardalis.Specification;

namespace Musical.Domain.Specifications;

public class AlbumsByYearSpecification : Specification<Album>
{
    public AlbumsByYearSpecification(int year)
    {
        Query.Where(a => a.ReleaseDate.Year == year);
    }
}

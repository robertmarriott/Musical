using Ardalis.Specification;

namespace Musical.Domain.Specifications;

public class AlbumsByGenreSpecification : Specification<Album>
{
    public AlbumsByGenreSpecification(string genre)
    {
        Query.Where(a => a.Artist.Genre == genre);
    }
}

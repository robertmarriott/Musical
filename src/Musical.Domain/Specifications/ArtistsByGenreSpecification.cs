using Ardalis.Specification;

namespace Musical.Domain.Specifications;

public class ArtistsByGenreSpecification : Specification<Artist>
{
    public ArtistsByGenreSpecification(string genre)
    {
        Query.Where(a => a.Genre == genre);
    }
}

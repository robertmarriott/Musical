namespace Musical.Domain.Entities;

public class Artist : BaseAuditableEntity
{
    public required string Name { get; set; }
    public required string Genre { get; set; }

    public ICollection<Album> Albums { get; private set; } = new List<Album>();
}

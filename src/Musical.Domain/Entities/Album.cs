namespace Musical.Domain.Entities;

public class Album : AuditableEntity
{
    public required string Title { get; set; }
    public required DateOnly ReleaseDate { get; set; }

    public int ArtistId { get; set; }
    public required Artist Artist { get; set; }
}

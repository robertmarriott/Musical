namespace Musical.Application.Models;

public class AlbumDto
{
    public int Id { get; set; }
    public required string Title { get; set; }
    public DateOnly ReleaseDate { get; set; }
}

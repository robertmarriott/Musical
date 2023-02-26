namespace Musical.Domain.Entities;

public abstract class BaseAuditableEntity : BaseEntity
{
    public required DateTime CreateDate { get; set; }
    public DateTime? LastUpdateDate { get; set; }
}

namespace Musical.Domain.Entities;

public abstract class BaseAuditableEntity : BaseEntity
{
    public DateTime CreateDate { get; private set; } = DateTime.Now;
    public DateTime? LastUpdateDate { get; set; }
}

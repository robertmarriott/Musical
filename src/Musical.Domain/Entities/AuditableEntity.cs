namespace Musical.Domain.Entities;

public abstract class AuditableEntity : Entity
{
    public DateTime CreateDate { get; private set; } = DateTime.Now;
    public DateTime? LastUpdateDate { get; set; }
}

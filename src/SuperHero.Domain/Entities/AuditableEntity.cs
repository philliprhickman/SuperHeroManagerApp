namespace SuperHero.Domain.Entities;

public abstract class AuditableEntity
{
    public int Id { get; set; }
    public DateTime DateCreatedUtc { get; set; } = DateTime.UtcNow;
    public DateTime? DateUpdatedUtc { get; set; }
    public DateTime? DateDeletedUtc { get; set; }
}

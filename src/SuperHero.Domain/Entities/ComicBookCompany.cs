namespace SuperHero.Domain.Entities;

public class ComicBookCompany : AuditableEntity
{
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public DateTime? Founded { get; set; }
    public string WikiPage { get; set; } = string.Empty;
}

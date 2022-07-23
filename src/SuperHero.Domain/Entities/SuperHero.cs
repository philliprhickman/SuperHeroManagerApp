namespace SuperHero.Domain.Entities;

public class SuperHero : AuditableEntity
{
    public string Name { get; set; } = string.Empty;
    public string Alias { get; set; } = string.Empty;
    public string Location { get; set; } = string.Empty;
    public string Notes { get; set; } = string.Empty;
    public string ComicBookCreator { get; set; } = string.Empty;
}

namespace SuperHero.Application.Models;

public class ComicBookCompanyModel
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public DateTime? Founded { get; set; }
    public string WikiPage { get; set; } = string.Empty;
}

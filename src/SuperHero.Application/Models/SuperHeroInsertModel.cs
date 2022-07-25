namespace SuperHero.Application.Models;

public class SuperHeroInsertModel
{
    public string Name { get; set; } = string.Empty;
    public string Alias { get; set; } = string.Empty;
    public string Location { get; set; } = string.Empty;
    public string OriginStory { get; set; } = string.Empty;
    public string Notes { get; set; } = string.Empty;
    public string WikiPage { get; set; } = string.Empty;
    public int ComicBookCompanyId { get; set; }
}

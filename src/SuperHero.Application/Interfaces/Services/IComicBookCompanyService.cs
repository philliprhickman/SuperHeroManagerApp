using SuperHero.Application.Models;

namespace SuperHero.Application.Interfaces.Services;

public interface IComicBookCompanyService
{
    Task<IEnumerable<ComicBookCompanyModel>> GetAllAsync();
    Task<ComicBookCompanyModel> GetByIdAsync(int id);
    Task<ComicBookCompanyModel> CreateAsync(ComicBookCompanyModel comicBookCompanyModel);
    Task UpdateAsync(ComicBookCompanyModel comicBookCompanyModel);
    Task RemoveAsync(int id);
}

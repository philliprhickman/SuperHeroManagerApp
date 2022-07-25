using SuperHero.Application.Interfaces.Repositories;
using SuperHero.Application.Interfaces.Services;
using SuperHero.Application.Models;

namespace SuperHero.Infrastructure.Services;

public class ComicBookCompanyService : IComicBookCompanyService
{
    private readonly IComicBookCompanyRepository _comicBookCompanyRepository;

    public ComicBookCompanyService(IComicBookCompanyRepository comicBookCompanyRepository)
    {
        _comicBookCompanyRepository = comicBookCompanyRepository;
    }

    public async Task<ComicBookCompanyModel> CreateAsync(ComicBookCompanyModel comicBookCompanyModel) =>
        await _comicBookCompanyRepository.CreateAsync(comicBookCompanyModel);

    public async Task<IEnumerable<ComicBookCompanyModel>> GetAllAsync() =>
        await _comicBookCompanyRepository.GetAllAsync();

    public async Task<ComicBookCompanyModel> GetByIdAsync(int id) =>
        await _comicBookCompanyRepository.GetByIdAsync(id);

    public async Task RemoveAsync(int id)
    {
        var company = await _comicBookCompanyRepository.GetByIdAsync(id);

        if (company is not null)
            await _comicBookCompanyRepository.RemoveAsync(company);
    }

    public async Task UpdateAsync(ComicBookCompanyModel comicBookCompanyModel)
    {
        await _comicBookCompanyRepository.UpdateAsync(comicBookCompanyModel);
    }
}

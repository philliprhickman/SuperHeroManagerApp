using SuperHero.Application.Interfaces.Repositories;
using SuperHero.Application.Interfaces.Services;
using SuperHero.Application.Models;

namespace SuperHero.Infrastructure.Services;

public class SuperHeroService : ISuperHeroService
{
    private readonly ISuperHeroRepository _superHeroRepository;

    public SuperHeroService(ISuperHeroRepository superHeroRepository)
    {
        _superHeroRepository = superHeroRepository;
    }

    public async Task<SuperHeroModel> CreateAsync(SuperHeroModel superHeroModel)
    {
        return await _superHeroRepository.CreateAsync(superHeroModel);
    }

    public async Task<IEnumerable<SuperHeroModel>> GetAllAsync()
    {
        return await _superHeroRepository.GetAllAsync();
    }

    public async Task<SuperHeroModel> GetByIdAsync(int id)
    {
        return await _superHeroRepository.GetByIdAsync(id);
    }

    public async Task RemoveAsync(SuperHeroModel superHeroModel)
    {
        await _superHeroRepository.RemoveAsync(superHeroModel);
    }

    public async Task UpdateAsync(SuperHeroModel superHeroModel)
    {
        await _superHeroRepository.UpdateAsync(superHeroModel);
    }
}

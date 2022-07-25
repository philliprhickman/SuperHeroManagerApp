using SuperHero.Application.Models;

namespace SuperHero.Application.Interfaces.Services;

public interface ISuperHeroService
{
    Task<IEnumerable<SuperHeroModel>> GetAllAsync();
    Task<SuperHeroModel> GetByIdAsync(int id);
    Task<SuperHeroModel> CreateAsync(SuperHeroModel superHeroModel);
    Task UpdateAsync(SuperHeroModel superHeroModel);
    Task RemoveAsync(int id);
}

using SuperHero.Application.Models;

namespace SuperHero.Application.Interfaces.Repositories;

public interface ISuperHeroRepository
{
    Task<IEnumerable<SuperHeroModel>> GetAllAsync();
    Task<SuperHeroModel> GetByIdAsync(int id);
    Task<SuperHeroModel> CreateAsync(SuperHeroModel superHeroModel);
    Task UpdateAsync(SuperHeroModel superHeroModel);
    Task RemoveAsync(SuperHeroModel superHeroModel);
}

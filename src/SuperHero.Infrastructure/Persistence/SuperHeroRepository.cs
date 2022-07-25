using SuperHero.Application.Interfaces.Repositories;
using SuperHero.Application.Models;

namespace SuperHero.Infrastructure.Persistence;

public class SuperHeroRepository : ISuperHeroRepository
{
    private readonly ISqlDataAccess _sqlDataAccess;

    public SuperHeroRepository(ISqlDataAccess sqlDataAccess)
    {
        _sqlDataAccess = sqlDataAccess;
    }

    public async Task<SuperHeroModel> CreateAsync(SuperHeroModel entity) =>
        await _sqlDataAccess.QuerySingleAsync("dbo.sp_SuperHeroes_Insert",
            entity);

    public async Task<IEnumerable<SuperHeroModel>> GetAllAsync() =>
        await _sqlDataAccess.LoadData<SuperHeroModel, dynamic>("dbo.sp_SuperHeroes_GetAll",
            new { });

    public async Task<SuperHeroModel> GetByIdAsync(int id)
    {
        var heroes = await _sqlDataAccess.LoadData<SuperHeroModel, dynamic>(
            "dbo.sp_SuperHeroes_GetById", new { id });

        return heroes.FirstOrDefault();
    }

    public async Task RemoveAsync(SuperHeroModel entity)
    {
        await _sqlDataAccess.SaveData("dbo.sp_SuperHeroes_Delete", new { entity.Id });
    }

    public async Task UpdateAsync(SuperHeroModel entity)
    {
        await _sqlDataAccess.SaveData("dbo.sp_SuperHeroes_Update",
            new
            {
                entity.Id,
                entity.Name,
                entity.Alias,
                entity.OriginStory,
                entity.Location,
                entity.WikiPage,
                entity.ComicBookCompanyId
            });
    }
}

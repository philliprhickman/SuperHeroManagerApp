using SuperHero.Application.Interfaces;
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

    public async Task<SuperHeroModel> CreateAsync(SuperHeroModel superHeroModel)
    {
        var result = await _sqlDataAccess.ExecuteAsync("dbo.sp_SuperHeroes_Insert",
            new
            {
                superHeroModel.Name,
                superHeroModel.Alias,
                superHeroModel.Location,
                superHeroModel.Notes,
                superHeroModel.ComicBookCreator
            });

        var superHeroes = await _sqlDataAccess.LoadData<SuperHeroModel, dynamic>("dbo.sp_SuperHeroes_GetById",
            new { Id = result });

        return superHeroes?.FirstOrDefault();
    }

    public async Task<IEnumerable<SuperHeroModel>> GetAllAsync() =>
        await _sqlDataAccess.LoadData<SuperHeroModel, dynamic>("dbo.sp_SuperHeroes_GetAll",
            new { });

    public async Task<SuperHeroModel> GetByIdAsync(int id)
    {
        var superHero = await _sqlDataAccess.LoadData<SuperHeroModel, dynamic>("dbo.sp_SuperHeroes_GetById",
            new { Id = id });

        return superHero?.FirstOrDefault();
    }

    public async Task RemoveAsync(SuperHeroModel superHeroModel) =>
        await _sqlDataAccess.SaveData("dbo.sp_SuperHeroes_Delete",
            new { Id = superHeroModel.Id });

    public async Task UpdateAsync(SuperHeroModel superHeroModel) =>
        await _sqlDataAccess.SaveData("dbo.sp_SuperHeroes_Update",
            new
            {
                superHeroModel.Id,
                superHeroModel.Name,
                superHeroModel.Alias,
                superHeroModel.Location,
                superHeroModel.Notes,
                superHeroModel.ComicBookCreator
            });
}

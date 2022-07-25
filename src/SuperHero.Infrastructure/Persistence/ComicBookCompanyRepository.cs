using SuperHero.Application.Interfaces.Repositories;
using SuperHero.Application.Models;

namespace SuperHero.Infrastructure.Persistence;

public class ComicBookCompanyRepository : IComicBookCompanyRepository
{
    private readonly ISqlDataAccess _sqlDataAccess;

    public ComicBookCompanyRepository(ISqlDataAccess sqlDataAccess)
    {
        _sqlDataAccess = sqlDataAccess;
    }

    public async Task<ComicBookCompanyModel> CreateAsync(ComicBookCompanyModel entity) =>
        await _sqlDataAccess.QuerySingleAsync("dbo.sp_ComicBookCompanies_Insert",
            entity);

    public async Task<IEnumerable<ComicBookCompanyModel>> GetAllAsync() =>
        await _sqlDataAccess.LoadData<ComicBookCompanyModel, dynamic>("dbo.sp_ComicBookCompanies_GetAll",
            new { });

    public async Task<ComicBookCompanyModel> GetByIdAsync(int id)
    {
        var companies = await _sqlDataAccess.LoadData<ComicBookCompanyModel, dynamic>(
            "dbo.sp_ComicBookCompanies_GetById", new { id });

        return companies.FirstOrDefault();
    }

    public async Task RemoveAsync(ComicBookCompanyModel entity)
    {
        await _sqlDataAccess.SaveData("dbo.sp_ComicBookCompanies_Delete",
            new
            {
                entity.Id
            });
    }

    public async Task UpdateAsync(ComicBookCompanyModel entity)
    {
        await _sqlDataAccess.SaveData("dbo.sp_ComicBookCompanies_Update",
            new
            {
                entity.Id,
                entity.Name,
                entity.Description,
                entity.Founded,
                entity.WikiPage
            });
    }
}

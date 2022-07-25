namespace SuperHero.Infrastructure.Persistence;

public interface ISqlDataAccess
{
    Task<int> ExecuteAsync<T>(string storedProcedure, T parameters, string connectionName = "DefaultConnection");
    Task<T> ExecuteScalarAsync<T>(string storedProcedure, T parameters, string connectionName = "DefaultConnection");
    Task<T> QuerySingleAsync<T>(string storedProcedure, T parameters, string connectionName = "DefaultConnection");
    Task<IEnumerable<T>> LoadData<T, U>(string storedProcedure, U parameters, string connectionName = "DefaultConnection");
    Task SaveData<T>(string storedProcedure, T parameters, string connectionName = "DefaultConnection");
}

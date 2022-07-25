using System.Data;
using System.Data.SqlClient;
using Dapper;
using Microsoft.Extensions.Configuration;

namespace SuperHero.Infrastructure.Persistence;

public class SqlDataAccess : ISqlDataAccess
{
    private readonly IConfiguration _configuration;

    public SqlDataAccess(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    public async Task<int> ExecuteAsync<T>(string storedProcedure, T parameters, string connectionName = "DefaultConnection")
    {
        using IDbConnection connection = new SqlConnection(_configuration.GetConnectionString(connectionName));

        return await connection.ExecuteAsync(storedProcedure, parameters, commandType: CommandType.StoredProcedure);
    }

    public async Task<T> ExecuteScalarAsync<T>(string storedProcedure, T parameters, string connectionName = "DefaultConnection")
    {
        using IDbConnection connection = new SqlConnection(_configuration.GetConnectionString(connectionName));

        return await connection.ExecuteScalarAsync<T>(storedProcedure, parameters, commandType: CommandType.StoredProcedure);
    }

    public async Task<IEnumerable<T>> LoadData<T, U>(string storedProcedure, U parameters, string connectionName = "DefaultConnection")
    {
        using IDbConnection connection = new SqlConnection(_configuration.GetConnectionString(connectionName));

        return await connection.QueryAsync<T>(storedProcedure, parameters, commandType: CommandType.StoredProcedure);
    }

    public async Task<T> QuerySingleAsync<T>(string storedProcedure, T parameters, string connectionName = "DefaultConnection")
    {        using IDbConnection connection = new SqlConnection(_configuration.GetConnectionString(connectionName));

        return await connection.QuerySingleAsync<T>(storedProcedure, parameters, commandType: CommandType.StoredProcedure);
    }

    public async Task SaveData<T>(string storedProcedure, T parameters, string connectionName = "DefaultConnection")
    {
        using IDbConnection connection = new SqlConnection(_configuration.GetConnectionString(connectionName));

        await connection.ExecuteAsync(storedProcedure, parameters, commandType: CommandType.StoredProcedure);
    }
}

using Dapper;
using Microsoft.Data.SqlClient;
using System.Data;
using DataLayer.Contracts;
using DataLayer.Entities;
using Microsoft.Extensions.Configuration;

namespace DataLayer.Repositories;

public class VehicleRepository(IConfiguration configuration) : IVehicleRepository
{

    private readonly IConfiguration _configuration = configuration;

    public async Task<Vehicle> GetByIdAsync(int id)
    {
        const string sql = "SELECT * FROM Vehicle WHERE Id = @Id";
        await using var connection = new SqlConnection(configuration.GetConnectionString("DefaultConnection"));
        connection.Open();
        return await connection.QuerySingleOrDefaultAsync<Vehicle>(sql, new { Id = id });
    }

    public async Task<IReadOnlyList<Vehicle>> GetAllAsync()
    {
        const string sql = "SELECT * FROM Vehicle";
        await using var connection = new SqlConnection(configuration.GetConnectionString("DefaultConnection"));
        connection.Open();
        var result = await connection.QueryAsync<Vehicle>(sql);
        return result.ToList();
    }

    public async Task<int> AddAsync(Vehicle entity)
    {
        throw new NotImplementedException();
    }

    public async Task<int> UpdateAsync(Vehicle entity)
    {
        throw new NotImplementedException();
    }

    public async Task<int> DeleteAsync(int id)
    {
        throw new NotImplementedException();
    }
}

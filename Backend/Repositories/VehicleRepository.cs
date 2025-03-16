using Backend.Context;
using Backend.Contracts;
using Backend.Dtos;
using Backend.Entities;
using Dapper;

namespace Backend.Repositories;

public class VehicleRepository(DapperContext context) : IVehicleRepository
{
    public async Task<IEnumerable<Vehicle>> GetVehicles()
    {
        const string query = "SELECT * FROM Vehicles";
        using var connection = context.CreateConnection();
        var vehicles = await connection.QueryAsync<Vehicle>(query);
        return vehicles.ToList();
    }

    public async Task<Vehicle?> GetVehicle(int id)
    {
        const string query = "SELECT * FROM Vehicles WHERE Id = @Id";
        using var connection = context.CreateConnection();
        var vehicle = await connection.QuerySingleOrDefaultAsync(query, new { id });
        return vehicle;
    }

    public async Task<Vehicle> AddVehicle(VehicleAddDto vehicle)
    {
        throw new NotImplementedException();
    }

    public async Task UpdateVehicle(int id, VehicleUpdateDto vehicle)
    {
        throw new NotImplementedException();
    }

    public async Task DeleteVehicle(int id)
    {
        throw new NotImplementedException();
    }
}
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

    public async Task<Vehicle> AddVehicle(VehicleDto vehicle)
    {
        const string query = "INSERT INTO Vehicles (Summary, IsReadyForSale, Model," +
                             "Mileage, RegistrationYear, GearboxType, FuelType," +
                             "Price, NoOfPreviousOwners, ServiceHistory, IsBrandNew, " +
                             "BodyType, NoOfDoors, NoOfSeats, Category, EmissionClass" +
                             "EngineCapacity, BatteryRange, Description, Colour," +
                             "DriveType, NoOfKeys, IsUlezCompliant) " +
                             "VALUES" +
                             "(@Summary, @IsReadyForSale, @Model, " +
                             "@Mileage, @RegistrationYear, @GearboxType, @FuelType," +
                             "@Price, @NoOfPreviousOwners, @ServiceHistory, @IsBrandNew, " +
                             "@BodyType, @NoOfDoors, @NoOfSeats, @Category, @EmissionClass" +
                             "@EngineCapacity, @BatteryRange, @Description, @Colour," +
                             "@DriveType, @NoOfKeys, @IsUlezCompliant)";
    }

    public async Task UpdateVehicle(int id, VehicleDto vehicle)
    {
        throw new NotImplementedException();
    }

    public async Task DeleteVehicle(int id)
    {
        throw new NotImplementedException();
    }
}
using Dapper;
using DataLayer.Contracts;
using DataLayer.Entities;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;

namespace DataLayer.Repositories;

public class VehicleRepository(IConfiguration configuration) : IVehicleRepository
{
    public async Task<Vehicle> GetByIdAsync(int id)
    {
        const string sql = "Select * From Vehicle Where Id = @Id";
        await using var connection = new SqlConnection(configuration.GetConnectionString("DefaultConnection"));
        connection.Open();
        return await connection.QuerySingleOrDefaultAsync<Vehicle>(sql, new { Id = id });
    }

    public async Task<IReadOnlyList<Vehicle>> GetAllAsync()
    {
        const string sql = "Select * From Vehicle";
        await using var connection = new SqlConnection(configuration.GetConnectionString("DefaultConnection"));
        connection.Open();
        var result = await connection.QueryAsync<Vehicle>(sql);
        return result.ToList();
    }

    public async Task<int> AddAsync(Vehicle entity)
    {
        const string sql = "Insert into Vehicle (" +
                           "HeadlineSummary, Status, Model," +
                           "Mileage, RegistrationYear, Gearbox," +
                           "FuelType, Price, PreviousOwners," +
                           "ServiceHistory, BrandNew, BodyType," +
                           "Doors, Seats, Category," +
                           "EmissionClass, EngineCapacity, BatteryRange" +
                           "Description, Colour, DriveType" +
                           "NumberOfKeys, UlezCompliant) " +

                           "Values (" +
                           "@HeadlineSummary, @Status, @Model," +
                           "@Mileage, @RegistrationYear, @Gearbox," +
                           "@FuelType, @Price, @PreviousOwners," +
                           "@ServiceHistory, @BrandNew, @BodyType," +
                           "@Doors, @Seats, @Category," +
                           "@EmissionClass, @EngineCapacity, @BatteryRange" +
                           "@Description, @Colour, @DriveType" +
                           "@NumberOfKeys, @UlezCompliant)";
        await using var connection = new SqlConnection(configuration.GetConnectionString("DefaultConnection"));
        connection.Open();
        var result = await connection.ExecuteAsync(sql, entity);
        return result;
    }

    public async Task<int> UpdateAsync(Vehicle entity)
    {
        const string sql = "Update Vehicle Set " +
                  "HeadlineSummary = @HeadlineSummary, Status = @Status, Model = @Model," +
                  "Mileage = @Mileage, RegistrationYear = @RegistrationYear, Gearbox = @Gearbox," +
                  "FuelType = @FuelType, Price = @Price, PreviousOwners = @PreviousOwners," +
                  "ServiceHistory = @ServiceHistory, BrandNew = @BrandNew, BodyType = @BodyType," +
                  "Doors = @Doors, Seats = @Seats, Category = @Category," +
                  "EmissionClass = @EmissionClass, EngineCapacity = @EngineCapacity, BatteryRange = @BatteryRange" +
                  "Description = @Description, Colour = @Colour, DriveType = @DriveType" +
                  "NumberOfKeys = @NumberOfKeys, UlezCompliant = @UlezCompliant)";
        await using var connection = new SqlConnection(configuration.GetConnectionString("DefaultConnection"));
        connection.Open();
        var result = await connection.ExecuteAsync(sql, entity);
        return result;
    }

    public async Task<int> DeleteAsync(int id)
    {
        const string sql = "Delete From Vehicle Where Id = @Id";
        await using var connection = new SqlConnection(configuration.GetConnectionString("DefaultConnection"));
        connection.Open();
        var result = await connection.ExecuteAsync(sql, new { Id = id });
        return result;
    }
}

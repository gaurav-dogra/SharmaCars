using System.Data;
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
                             "@DriveType, @NoOfKeys, @IsUlezCompliant)" +
                             "SELECT CAST(SCOPE_IDENTITY() as int)";

        var parameters = GetParameters(vehicle); 
            

        using var connection = context.CreateConnection();
        var id = await connection.QuerySingleAsync<int>(query, parameters);

        return GetCreatedVehicle(id, vehicle);
    }

    private static Vehicle GetCreatedVehicle(int id, VehicleDto vehicle)
    {
        var createdVehicle = new Vehicle()
        {
            Id = id,
            Summary = vehicle.Summary,
            IsReadyForSale = vehicle.IsReadyForSale,
            Model = vehicle.Model,
            Mileage = vehicle.Mileage,
            Registration = vehicle.Registration,
            RegistrationYear = vehicle.RegistrationYear,
            GearboxType = vehicle.GearboxType,
            FuelType = vehicle.FuelType,
            Price = vehicle.Price,
            NoOfPreviousOwners = vehicle.NoOfPreviousOwners,
            ServiceHistory = vehicle.ServiceHistory,
            IsBrandNew = vehicle.IsBrandNew,
            BodyType = vehicle.BodyType,
            NoOfDoors = vehicle.NoOfDoors,
            NoOfSeats = vehicle.NoOfSeats,
            Category = vehicle.Category,
            EmissionClass = vehicle.EmissionClass,
            EngineCapacity = vehicle.EngineCapacity,
            BatteryRange = vehicle.BatteryRange,
            Description = vehicle.Description,
            Colour = vehicle.Colour,
            DriveType = vehicle.DriveType,
            NoOfKeys = vehicle.NoOfKeys,
            IsUlezCompliant = vehicle.IsUlezCompliant
        };
        return createdVehicle;
    }

    private static DynamicParameters GetParameters(VehicleDto vehicle)
    {
        var parameters = new DynamicParameters();
        parameters.Add("Summary", vehicle.Summary, DbType.String);
        parameters.Add("IsReadyForSale", vehicle.IsReadyForSale, DbType.Boolean);
        parameters.Add("Model", vehicle.Model, DbType.String);
        parameters.Add("Mileage", vehicle.Mileage, DbType.Int32);
        parameters.Add("RegistrationYear", vehicle.RegistrationYear, DbType.Int16);
        parameters.Add("Registration", vehicle.Registration, DbType.String);
        parameters.Add("GearboxType", vehicle.GearboxType, DbType.Int16);
        parameters.Add("FuelType", vehicle.FuelType, DbType.Int16);
        parameters.Add("Price", vehicle.Price, DbType.Int32);
        parameters.Add("NoOfPreviousOwners", vehicle.NoOfPreviousOwners, DbType.Int16);
        parameters.Add("ServiceHistory", vehicle.ServiceHistory, DbType.Int16);
        parameters.Add("IsBrandNew", vehicle.IsBrandNew, DbType.Boolean);
        parameters.Add("BodyType", vehicle.BodyType, DbType.Int16);
        parameters.Add("NoOfDoors", vehicle.NoOfDoors, DbType.Int16);
        parameters.Add("NoOfSeats", vehicle.NoOfSeats, DbType.Int16);
        parameters.Add("Category", vehicle.Category, DbType.Int16);
        parameters.Add("EmissionClass", vehicle.EmissionClass, DbType.Int16);
        parameters.Add("EngineCapacity", vehicle.EngineCapacity, DbType.Int16);
        parameters.Add("BatteryRange", vehicle.BatteryRange, DbType.Int16);
        parameters.Add("Description", vehicle.Description, DbType.String);
        parameters.Add("Colour", vehicle.Colour, DbType.Int16);
        parameters.Add("DriveType", vehicle.DriveType, DbType.Int16);
        parameters.Add("NoOfKeys", vehicle.NoOfKeys, DbType.Int16);
        parameters.Add("IsUlezCompliant", vehicle.IsUlezCompliant, DbType.Boolean);
        return parameters;
    }

    public async Task UpdateVehicle(int id, VehicleDto vehicle)
    {
        var properties = typeof(VehicleDto).GetProperties()
            .Where(p => p.GetValue(vehicle) != null && p.Name != "Id");
        var setClause = string.Join(", ", properties.Select(p => $"{p.Name} = @{p.Name}"));

        var query = $"UPDATE Vehicle SET {setClause} WHERE Id = @Id";

        var parameters = new DynamicParameters();
        parameters.Add("Id", id, DbType.Int32);

        foreach (var property in properties)
        {
            var value = property.GetValue(vehicle);
            var dbType = GetDbType(property.PropertyType);
            parameters.Add(property.Name, value, dbType);
        }

        using var connection = context.CreateConnection();
        await connection.ExecuteAsync(query, parameters);

    }

    private static DbType? GetDbType(Type type)
    {
        if (type == typeof(string))
        {
            return DbType.String;
        }

        if (type == typeof(int) || type == typeof(int?))
        {
            return DbType.Int16;
        }

        if (type == typeof(bool))
        {
            return DbType.Boolean;
        }

        throw new ArgumentException($"Unsupported property type: {type.Name}");
    }

    public async Task DeleteVehicle(int id)
    {
        const string query = "DELETE FROM Vehicle WHERE Id = @Id";

        using var connection = context.CreateConnection();
        await connection.ExecuteAsync(query, new { id });
    }
}
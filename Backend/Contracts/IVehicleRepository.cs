using Backend.Dtos;
using Backend.Entities;

namespace Backend.Contracts;

public interface IVehicleRepository
{
    public Task<IEnumerable<Vehicle>> GetVehicles();
    public Task<Vehicle?> GetVehicle(int id);
    public Task<Vehicle> AddVehicle(VehicleDto vehicle);
    public Task UpdateVehicle(int id, VehicleDto vehicle);
    public Task DeleteVehicle(int id);

}
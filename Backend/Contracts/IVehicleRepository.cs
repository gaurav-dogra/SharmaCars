using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Backend.Entities;

namespace Backend.Contracts;

public interface IVehicleRepository
{
    public Task<IEnumerable<Vehicle>> GetVehicles();
    public Task<Vehicle?> GetVehicle(int id);
    public Task<Vehicle> AddVehicle(VehicleAdditionDto vehicle);
    public Task UpdateVehicle(int id, VehicleUpdationDto vehicle);
    public Task DeleteVehicle(int id);

}
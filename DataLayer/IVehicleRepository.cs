using DataLayer.Models;

namespace DataLayer
{
    public interface IVehicleRepository
    {
        Task<VehicleModel> GetAsync(int id);
        Task<IEnumerable<VehicleModel>> GetAllAsync();
        Task<VehicleModel> AddAsync(VehicleModel vehicle);
        Task<VehicleModel> UpdateAsync(VehicleModel vehicle);
        void Remove(int id);
    }
}

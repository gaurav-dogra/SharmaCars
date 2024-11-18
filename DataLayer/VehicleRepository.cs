using Dapper;
using DataLayer.Models;
using Microsoft.Data.SqlClient;
using System.Data;

namespace DataLayer
{
    public class VehicleRepository(string connString) : IVehicleRepository
    {
        private IDbConnection _db = new SqlConnection(connString);


        public Task<VehicleModel> GetAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<VehicleModel>> GetAllAsync()
        {
            using (_db)
            {
                const string query = @"Select 
                                        [Id],
                                        [HeadlineSummary], 
                                        [Model], 
                                        [Mileage], 
                                        [RegistrationYear], 
                                        [Gearbox],
                                        [FuelType], 
                                        [Price], 
                                        [PreviousOwners], 
                                        [ServiceHistory], 
                                        [BrandNew], 
                                        [BodyType],
                                        [Doors], 
                                        [Seats], 
                                        [Category], 
                                        [EmissionClass], 
                                        [EngineCapacity], 
                                        [BatteryRange], 
                                        [Description],
                                        [Colour], 
                                        [DriveType] 
                                    From [dbo].Vehicle";
                return await _db.QueryAsync<VehicleModel>(query);
            }

        }

        public Task<VehicleModel> AddAsync(VehicleModel vehicle)
        {
            throw new NotImplementedException();
        }

        public Task<VehicleModel> UpdateAsync(VehicleModel vehicle)
        {
            throw new NotImplementedException();
        }

        public void Remove(int id)
        {
            throw new NotImplementedException();
        }
    }
}

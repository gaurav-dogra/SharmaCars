using Dapper;
using Microsoft.Data.SqlClient;
using System.Data;
using DataLayer.Entity;

namespace DataLayer
{
    public class VehicleRepository(string connString) : IVehicleRepository
    {
        private IDbConnection _db = new SqlConnection(connString);


        public Task<Vehicle> GetAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Vehicle>> GetAllAsync()
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
                return await _db.QueryAsync<Vehicle>(query);
            }

        }

        public Task<Vehicle> AddAsync(Vehicle vehicle)
        {
            throw new NotImplementedException();
        }

        public Task<Vehicle> UpdateAsync(Vehicle vehicle)
        {
            throw new NotImplementedException();
        }

        public void Remove(int id)
        {
            throw new NotImplementedException();
        }
    }
}

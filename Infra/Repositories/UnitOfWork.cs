using DataLayer.Contracts;

namespace Infra.Repositories;

public class UnitOfWork(IVehicleRepository vehicles) : IUnitOfWork
{
    public IVehicleRepository Vehicles { get; } = vehicles;
}
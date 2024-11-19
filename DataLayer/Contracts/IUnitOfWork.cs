namespace DataLayer.Contracts;

public interface IUnitOfWork
{
    IVehicleRepository Vehicles { get; }
}
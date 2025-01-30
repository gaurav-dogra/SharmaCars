using DataLayer.Contracts;
using DataLayer.Repositories;
using Infra.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace Infra;

public static class ServiceRegistration
{
    public static void AddInfrastructure(this IServiceCollection services)
    {
        services.AddTransient<IVehicleRepository, VehicleRepository>();
        services.AddTransient<IUnitOfWork, UnitOfWork>();
    }
}

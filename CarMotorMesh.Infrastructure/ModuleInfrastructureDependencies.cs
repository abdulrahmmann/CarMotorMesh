using CarMotorMesh.Infrastructure.Contacts;
using CarMotorMesh.Infrastructure.Repository.Abstracts;
using CarMotorMesh.Infrastructure.Repository.Implementation;
using Microsoft.Extensions.DependencyInjection;

namespace CarMotorMesh.Infrastructure
{
	public static class ModuleInfrastructureDependencies
	{
		public static IServiceCollection AddInfrastructureDependencies(this IServiceCollection services)
		{
			// Add Generic Repository Dependency.
			services.AddTransient(typeof(IGenericRepositoryAsync<>), typeof(GenericRepositoryAsync<>));

			// Add Vehicle Repository Dependency.
			services.AddTransient<IVehicleRepository, VehicleRepository>();

			return services;
		}
	}
}

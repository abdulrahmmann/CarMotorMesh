using CarMotorMesh.Core.Mapping;
using CarMotorMesh.Core.Services.Abstracts;
using CarMotorMesh.Core.Services.Implementation;
using Mapster;
using Microsoft.Extensions.DependencyInjection;

namespace CarMotorMesh.Core
{
	public static class ModuleCoreDependencies
	{
		public static IServiceCollection AddCoreDependencies(this IServiceCollection services)
		{
			// Register Vehicle Service Repository.
			services.AddTransient<IVehicleService, VehicleService>();

			// Register Mapster.
			services.AddMapster();

			// Configure Mapster.
			MapsterConfig.Configure();

			return services;
		}
	}
}

using CarMotorMesh.Infrastructure.Contacts;
using Microsoft.Extensions.DependencyInjection;

namespace CarMotorMesh.Infrastructure
{
	public static class ModuleInfrastructureDependencies
	{
		public static IServiceCollection AddInfrastructureDependencies(this IServiceCollection services)
		{
			// Add Generic Repository Dependency.
			services.AddTransient(typeof(IGenericRepositoryAsync<>), typeof(GenericRepositoryAsync<>));

			return services;
		}
	}
}

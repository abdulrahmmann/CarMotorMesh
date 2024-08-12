using CarMotorMesh.Infrastructure.Contacts;
using CarMotorMesh.Infrastructure.Entities;

namespace CarMotorMesh.Infrastructure.Repository.Abstracts
{
	public interface IVehicleRepository : IGenericRepositoryAsync<VehicleDetail>
	{
		Task<VehicleDetail> GetVehicleById(int id);

		Task<List<VehicleDetail>> GetVehiclesListAsync();

		Task<List<VehicleDetail>> GetVehiclesByMakeList(int makeId);

		Task<List<VehicleDetail>> GetVehiclesByModelList(int modelId);

		Task<List<VehicleDetail>> GetVehiclesByYearList(short year);

		Task<List<VehicleDetail>> GetVehiclesByBodyTypeList(int bodyId);

		Task<List<VehicleDetail>> GetVehiclesByFuelTypeList(int fuelTypeId);

		Task<List<VehicleDetail>> GetVehiclesByEngineSizeList(decimal engineSize);

		Task<int> GetVehicleCountByMakeAsync(int makeId);
		Task<int> GetVehicleCountByModelAsync(int modelId);
		Task<int> GetVehicleCountByYearAsync(short year);
		Task<int> GetVehicleCountByBodyTypeAsync(int bodyId);
		Task<int> GetVehicleCountByFuelTypeAsync(int fuelTypeId);
		Task<int> GetVehicleCountByEngineSizAsync(decimal engineSize);
	}
}

using CarMotorMesh.Core.DTOs;

namespace CarMotorMesh.Core.Services.Abstracts
{
	public interface IVehicleService
	{
		Task<VehicleDTO> GetVehicleByIdAsync(int id);
		Task<List<VehicleDTO>> GetVehiclesListAsync();
		Task<List<VehicleDTO>> GetVehiclesByMakeAsync(int makeId);
		Task<List<VehicleDTO>> GetVehiclesByModelAsync(int modelId);
		Task<List<VehicleDTO>> GetVehiclesByYearAsync(short year);
		Task<List<VehicleDTO>> GetVehiclesByBodyTypeAsync(int bodyId);
		Task<List<VehicleDTO>> GetVehiclesByFuelTypeAsync(int fuelTypeId);
		Task<List<VehicleDTO>> GetVehiclesByEngineSizeAsync(decimal engineSize);
		Task<int> GetVehicleCountByMakeAsync(int makeId);
		Task<int> GetVehicleCountByModelAsync(int modelId);
		Task<int> GetVehicleCountByYearAsync(short year);
		Task<int> GetVehicleCountByBodyTypeAsync(int bodyId);
		Task<int> GetVehicleCountByFuelTypeAsync(int fuelTypeId);
		Task<int> GetVehicleCountByEngineSizeAsync(decimal engineSize);
	}
}

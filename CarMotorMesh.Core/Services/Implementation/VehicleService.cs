using CarMotorMesh.Core.DTOs;
using CarMotorMesh.Core.Services.Abstracts;
using CarMotorMesh.Infrastructure.Repository.Abstracts;
using MapsterMapper;

namespace CarMotorMesh.Core.Services.Implementation
{
	public class VehicleService : IVehicleService
	{
		#region Data Fields.
		private readonly IVehicleRepository _vehicleRepository;
		private readonly IMapper _mapper;
		#endregion


		#region Constructor.
		public VehicleService(IVehicleRepository vehicleRepository, IMapper mapper)
		{
			_vehicleRepository = vehicleRepository;
			_mapper = mapper;
		}
		#endregion



		#region Functions Handler
		public async Task<VehicleDTO> GetVehicleByIdAsync(int id)
		{
			var vehicle = await _vehicleRepository.GetByIdAsync(id);

			var vehicleDto = _mapper.Map<VehicleDTO>(vehicle);

			return vehicleDto;
		}

		public async Task<List<VehicleDTO>> GetVehiclesListAsync()
		{
			var vehicle = await _vehicleRepository.GetVehiclesListAsync();

			var vehicleDto = _mapper.Map<List<VehicleDTO>>(vehicle);

			return vehicleDto;
		}

		public async Task<List<VehicleDTO>> GetVehiclesByBodyTypeAsync(int bodyId)
		{
			var vehicle = await _vehicleRepository.GetVehiclesByBodyTypeList(bodyId);

			var vehicleDto = _mapper.Map<List<VehicleDTO>>(vehicle);

			return vehicleDto;
		}

		public async Task<List<VehicleDTO>> GetVehiclesByEngineSizeAsync(decimal engineSize)
		{
			var vehicle = await _vehicleRepository.GetVehiclesByEngineSizeList(engineSize);

			var vehicleDto = _mapper.Map<List<VehicleDTO>>(vehicle);

			return vehicleDto;
		}

		public async Task<List<VehicleDTO>> GetVehiclesByFuelTypeAsync(int fuelTypeId)
		{
			var vehicle = await _vehicleRepository.GetVehiclesByFuelTypeList(fuelTypeId);

			var vehicleDto = _mapper.Map<List<VehicleDTO>>(vehicle);

			return vehicleDto;
		}

		public async Task<List<VehicleDTO>> GetVehiclesByMakeAsync(int makeId)
		{
			var vehicle = await _vehicleRepository.GetVehiclesByMakeList(makeId);

			var vehicleDto = _mapper.Map<List<VehicleDTO>>(vehicle);

			return vehicleDto;
		}

		public async Task<List<VehicleDTO>> GetVehiclesByModelAsync(int modelId)
		{
			var vehicle = await _vehicleRepository.GetVehiclesByModelList(modelId);

			var vehicleDto = _mapper.Map<List<VehicleDTO>>(vehicle);

			return vehicleDto;
		}

		public async Task<List<VehicleDTO>> GetVehiclesByYearAsync(short year)
		{
			var vehicle = await _vehicleRepository.GetVehiclesByYearList(year);

			var vehicleDto = _mapper.Map<List<VehicleDTO>>(vehicle);

			return vehicleDto;
		}

		public async Task<int> GetVehicleCountByBodyTypeAsync(int bodyId)
		{
			return await _vehicleRepository.GetVehicleCountByBodyTypeAsync(bodyId);
		}

		public async Task<int> GetVehicleCountByEngineSizeAsync(decimal engineSize)
		{
			return await _vehicleRepository.GetVehicleCountByEngineSizAsync(engineSize);
		}

		public async Task<int> GetVehicleCountByFuelTypeAsync(int fuelTypeId)
		{
			return await _vehicleRepository.GetVehicleCountByFuelTypeAsync(fuelTypeId);
		}

		public async Task<int> GetVehicleCountByMakeAsync(int makeId)
		{
			return await _vehicleRepository.GetVehicleCountByMakeAsync(makeId);
		}

		public async Task<int> GetVehicleCountByModelAsync(int modelId)
		{
			return await _vehicleRepository.GetVehicleCountByModelAsync(modelId);
		}

		public async Task<int> GetVehicleCountByYearAsync(short year)
		{
			return await _vehicleRepository.GetVehicleCountByYearAsync(year);
		}
		#endregion
	}
}

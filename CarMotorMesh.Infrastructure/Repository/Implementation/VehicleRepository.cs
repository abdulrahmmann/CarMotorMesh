using CarMotorMesh.Infrastructure.Contacts;
using CarMotorMesh.Infrastructure.Data;
using CarMotorMesh.Infrastructure.Entities;
using CarMotorMesh.Infrastructure.Repository.Abstracts;
using Microsoft.EntityFrameworkCore;

namespace CarMotorMesh.Infrastructure.Repository.Implementation
{
	public class VehicleRepository : GenericRepositoryAsync<VehicleDetail>, IVehicleRepository
	{
		#region Data Fields
		private readonly DbSet<VehicleDetail> _vehicles;
		#endregion


		#region Constructor
		public VehicleRepository(VehicleContext dbcontext) : base(dbcontext)
		{
			_vehicles = dbcontext.Set<VehicleDetail>();
		}
		#endregion


		#region Includeing Entities Method.
		private IQueryable<VehicleDetail> IncludeEntities()
		{
			return _vehicles
				.Include(v => v.Make)
				.Include(v => v.Model)
				.Include(v => v.SubModel)
				.Include(v => v.Body)
				.Include(v => v.DriveType)
				.Include(v => v.FuelType);
		}
		#endregion


		#region Helper Method For IQueryable.
		private IQueryable<VehicleDetail> GetVehicleByAsQueryable() => IncludeEntities().AsQueryable();
		#endregion


		#region Functions Handler
		public async Task<VehicleDetail> GetVehicleById(int id)
		{
			return await IncludeEntities().FirstOrDefaultAsync(v => v.Id == id);
		}

		public async Task<List<VehicleDetail>> GetVehiclesListAsync()
		{
			return await IncludeEntities().ToListAsync();
		}

		public async Task<List<VehicleDetail>> GetVehiclesByMakeList(int makeId)
		{
			return await GetVehicleByAsQueryable().Where(v => v.MakeId == makeId).ToListAsync();
		}

		public async Task<List<VehicleDetail>> GetVehiclesByModelList(int modelId)
		{
			return await GetVehicleByAsQueryable().Where(v => v.ModelId == modelId).ToListAsync();
		}

		public async Task<List<VehicleDetail>> GetVehiclesByYearList(short year)
		{
			return await GetVehicleByAsQueryable().Where(v => v.Year == year).ToListAsync();
		}

		public async Task<List<VehicleDetail>> GetVehiclesByBodyTypeList(int bodyId)
		{
			return await GetVehicleByAsQueryable().Where(v => v.BodyId == bodyId).ToListAsync();
		}

		public async Task<List<VehicleDetail>> GetVehiclesByFuelTypeList(int fuelTypeId)
		{
			return await GetVehicleByAsQueryable().Where(v => v.FuelTypeId == fuelTypeId).ToListAsync();
		}

		public async Task<List<VehicleDetail>> GetVehiclesByEngineSizeList(decimal engineSize)
		{
			return await GetVehicleByAsQueryable().Where(v => v.EngineLiterDisplay == engineSize).ToListAsync();
		}

		public async Task<int> GetVehicleCountByMakeAsync(int makeId)
		{
			return await _vehicles.Where(v => v.MakeId == makeId).CountAsync();
		}

		public async Task<int> GetVehicleCountByModelAsync(int modelId)
		{
			return await _vehicles.Where(v => v.ModelId == modelId).CountAsync();
		}

		public async Task<int> GetVehicleCountByYearAsync(short year)
		{
			return await _vehicles.Where(v => v.Year == year).CountAsync();
		}

		public async Task<int> GetVehicleCountByBodyTypeAsync(int bodyId)
		{
			return await _vehicles.Where(v => v.BodyId == bodyId).CountAsync();
		}

		public async Task<int> GetVehicleCountByFuelTypeAsync(int fuelTypeId)
		{
			return await _vehicles.Where(v => v.FuelTypeId == fuelTypeId).CountAsync();
		}

		public async Task<int> GetVehicleCountByEngineSizAsync(decimal engineSize)
		{
			return await _vehicles.Where(v => v.EngineLiterDisplay == engineSize).CountAsync();
		}
		#endregion
	}
}

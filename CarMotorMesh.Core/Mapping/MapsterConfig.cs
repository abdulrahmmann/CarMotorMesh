using CarMotorMesh.Core.DTOs;
using CarMotorMesh.Infrastructure.Entities;
using Mapster;

namespace CarMotorMesh.Core.Mapping
{
	public static class MapsterConfig
	{
		public static void Configure()
		{
			TypeAdapterConfig<VehicleDetail, VehicleDTO>.NewConfig()
				.Map(dest => dest.Id, src => src.Id)

				.Map(dest => dest.MakeId, src => src.MakeId.HasValue ? src.MakeId.Value : default(int))

				.Map(dest => dest.ModelId, src => src.ModelId.HasValue ? src.ModelId.Value : default(int))

				.Map(dest => dest.SubModelId, src => src.SubModelId.HasValue ? src.SubModelId.Value : default(int))

				.Map(dest => dest.BodyId, src => src.BodyId.HasValue ? src.BodyId.Value : default(int))

				.Map(dest => dest.DriveTypeId, src => src.DriveTypeId.HasValue ? src.DriveTypeId.Value : default(int))

				.Map(dest => dest.NumDoors, src => src.NumDoors.HasValue ? src.NumDoors.Value : default(int))

				.Map(dest => dest.VehicleDisplayName, src => src.VehicleDisplayName ?? string.Empty)

				.Map(dest => dest.Year, src => src.Year.HasValue ? src.Year.Value : default(short))

				.Map(dest => dest.Engine, src => src.Engine ?? string.Empty)

				.Map(dest => dest.EngineCc, src => src.EngineCc.HasValue ? src.EngineCc.Value : default(short))

				.Map(dest => dest.EngineCylinders, src => src.EngineCylinders.HasValue ? src.EngineCylinders.Value : default(byte))

				.Map(dest => dest.EngineLiterDisplay, src => src.EngineLiterDisplay.HasValue ? src.EngineLiterDisplay.Value : default(decimal));
		}
	}
}

/*
 - dest -> VehicleDTO

 - src -> VehicleDetail
 */
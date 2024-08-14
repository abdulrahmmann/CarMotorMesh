namespace CarMotorMesh.Core.DTOs
{
	public record VehicleDTO
		(
		int Id, int MakeId, int ModelId, int SubModelId, int BodyId, int FuelTypeId, int DriveTypeId, int NumDoors, string VehicleDisplayName,
		short Year, string Engine, short EngineCc, byte EngineCylinders, decimal EngineLiterDisplay
		);
}

/*(
int Id, int MakeId, int ModelId, int SubModelId, int BodyId, string VehicleDisplayName, short Year, int DriveTypeId,
string Engine, short EngineCc, byte EngineCylinders, decimal EngineLiterDisplay, int FuelTypeId, int NumDoors
);*/


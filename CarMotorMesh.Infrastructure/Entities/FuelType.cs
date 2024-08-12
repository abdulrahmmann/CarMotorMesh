namespace CarMotorMesh.Infrastructure.Entities;

public partial class FuelType
{
	public int FuelTypeId { get; set; }

	public string FuelTypeName { get; set; } = null!;

	public virtual ICollection<VehicleDetail> VehicleDetails { get; set; } = new List<VehicleDetail>();
}

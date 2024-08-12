namespace CarMotorMesh.Infrastructure.Entities;

public partial class Body
{
	public int BodyId { get; set; }

	public string BodyName { get; set; } = null!;

	public virtual ICollection<VehicleDetail> VehicleDetails { get; set; } = new List<VehicleDetail>();
}

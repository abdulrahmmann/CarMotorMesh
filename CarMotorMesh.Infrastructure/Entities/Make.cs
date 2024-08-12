namespace CarMotorMesh.Infrastructure.Entities;

public partial class Make
{
	public int MakeId { get; set; }

	public string Make1 { get; set; } = null!;

	public virtual ICollection<MakeModel> MakeModels { get; set; } = new List<MakeModel>();

	public virtual ICollection<VehicleDetail> VehicleDetails { get; set; } = new List<VehicleDetail>();
}

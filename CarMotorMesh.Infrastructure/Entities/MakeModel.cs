namespace CarMotorMesh.Infrastructure.Entities;

public partial class MakeModel
{
	public int ModelId { get; set; }

	public int MakeId { get; set; }

	public string ModelName { get; set; } = null!;

	public virtual Make Make { get; set; } = null!;

	public virtual ICollection<SubModel> SubModels { get; set; } = new List<SubModel>();

	public virtual ICollection<VehicleDetail> VehicleDetails { get; set; } = new List<VehicleDetail>();
}

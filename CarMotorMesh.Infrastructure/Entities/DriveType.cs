﻿namespace CarMotorMesh.Infrastructure.Entities;

public partial class DriveType
{
	public int DriveTypeId { get; set; }

	public string DriveTypeName { get; set; } = null!;

	public virtual ICollection<VehicleDetail> VehicleDetails { get; set; } = new List<VehicleDetail>();
}

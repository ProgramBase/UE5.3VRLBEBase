using Script.CoreUObject;

namespace Script.ChaosCloth
{
	[PathName("/Script/ChaosCloth.EChaosWeightMapTarget")]
	public enum EChaosWeightMapTarget : long
	{
		None = 0,
		MaxDistance = 1,
		BackstopDistance = 2,
		BackstopRadius = 3,
		AnimDriveStiffness = 4,
		AnimDriveDamping = 5,
		TetherStiffness = 6,
		TetherScale = 7,
		Drag = 8,
		Lift = 9,
		EdgeStiffness = 10,
		BendingStiffness = 11,
		AreaStiffness = 12,
		BucklingStiffness = 13,
		Pressure = 14,
	}
}
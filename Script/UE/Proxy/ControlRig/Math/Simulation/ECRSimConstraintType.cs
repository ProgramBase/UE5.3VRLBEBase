using Script.CoreUObject;

namespace Script.ControlRig
{
	[PathName("/Script/ControlRig.ECRSimConstraintType")]
	public enum ECRSimConstraintType : byte
	{
		Distance = 0,
		DistanceFromA = 1,
		DistanceFromB = 2,
		Plane = 3,
	}
}
using Script.CoreUObject;

namespace Script.ControlRig
{
	[PathName("/Script/ControlRig.ECRSimSoftCollisionType")]
	public enum ECRSimSoftCollisionType : byte
	{
		Plane = 0,
		Sphere = 1,
		Cone = 2,
	}
}
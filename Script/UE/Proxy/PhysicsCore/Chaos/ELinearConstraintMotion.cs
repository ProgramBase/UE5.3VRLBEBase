using Script.CoreUObject;

namespace Script.PhysicsCore
{
	[PathName("/Script/PhysicsCore.ELinearConstraintMotion")]
	public enum ELinearConstraintMotion : byte
	{
		LCM_Free = 0,
		LCM_Limited = 1,
		LCM_Locked = 2,
	}
}
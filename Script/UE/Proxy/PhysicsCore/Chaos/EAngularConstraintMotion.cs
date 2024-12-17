using Script.CoreUObject;

namespace Script.PhysicsCore
{
	[PathName("/Script/PhysicsCore.EAngularConstraintMotion")]
	public enum EAngularConstraintMotion : byte
	{
		ACM_Free = 0,
		ACM_Limited = 1,
		ACM_Locked = 2,
	}
}
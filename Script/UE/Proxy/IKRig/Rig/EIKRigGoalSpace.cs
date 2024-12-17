using Script.CoreUObject;

namespace Script.IKRig
{
	[PathName("/Script/IKRig.EIKRigGoalSpace")]
	public enum EIKRigGoalSpace : byte
	{
		Component = 0,
		Additive = 1,
		World = 2,
	}
}
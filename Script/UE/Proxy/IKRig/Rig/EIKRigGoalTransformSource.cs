using Script.CoreUObject;

namespace Script.IKRig
{
	[PathName("/Script/IKRig.EIKRigGoalTransformSource")]
	public enum EIKRigGoalTransformSource : byte
	{
		Manual = 0,
		Bone = 1,
		ActorComponent = 2,
	}
}
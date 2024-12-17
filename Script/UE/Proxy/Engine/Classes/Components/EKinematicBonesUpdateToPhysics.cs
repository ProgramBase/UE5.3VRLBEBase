using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.EKinematicBonesUpdateToPhysics")]
	public enum EKinematicBonesUpdateToPhysics : byte
	{
		SkipSimulatingBones = 0,
		SkipAllBones = 1,
	}
}
using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.EVisibilityBasedAnimTickOption")]
	public enum EVisibilityBasedAnimTickOption : byte
	{
		AlwaysTickPoseAndRefreshBones = 0,
		AlwaysTickPose = 1,
		OnlyTickMontagesWhenNotRendered = 2,
		OnlyTickPoseWhenRendered = 3,
	}
}
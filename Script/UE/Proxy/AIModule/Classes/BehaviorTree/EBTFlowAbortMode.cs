using Script.CoreUObject;

namespace Script.AIModule
{
	[PathName("/Script/AIModule.EBTFlowAbortMode")]
	public enum EBTFlowAbortMode : byte
	{
		None = 0,
		LowerPriority = 1,
		Self = 2,
		Both = 3,
	}
}
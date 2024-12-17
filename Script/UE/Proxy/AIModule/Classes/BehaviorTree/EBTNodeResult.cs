using Script.CoreUObject;

namespace Script.AIModule
{
	[PathName("/Script/AIModule.EBTNodeResult")]
	public enum EBTNodeResult : byte
	{
		Succeeded = 0,
		Failed = 1,
		Aborted = 2,
		InProgress = 3,
	}
}
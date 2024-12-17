using Script.CoreUObject;

namespace Script.AIModule
{
	[PathName("/Script/AIModule.EPawnActionResult")]
	public enum EPawnActionResult : byte
	{
		NotStarted = 0,
		InProgress = 1,
		Success = 2,
		Failed = 3,
		Aborted = 4,
	}
}
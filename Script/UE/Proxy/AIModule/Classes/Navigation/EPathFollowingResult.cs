using Script.CoreUObject;

namespace Script.AIModule
{
	[PathName("/Script/AIModule.EPathFollowingResult")]
	public enum EPathFollowingResult : byte
	{
		Success = 0,
		Blocked = 1,
		OffPath = 2,
		Aborted = 3,
		Skipped_DEPRECATED = 4,
		Invalid = 5,
	}
}
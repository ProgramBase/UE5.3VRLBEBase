using Script.CoreUObject;

namespace Script.AIModule
{
	[PathName("/Script/AIModule.EPathFollowingStatus")]
	public enum EPathFollowingStatus : byte
	{
		Idle = 0,
		Waiting = 1,
		Paused = 2,
		Moving = 3,
	}
}
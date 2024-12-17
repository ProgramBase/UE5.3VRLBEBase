using Script.CoreUObject;

namespace Script.AIModule
{
	[PathName("/Script/AIModule.EPathFollowingRequestResult")]
	public enum EPathFollowingRequestResult : byte
	{
		Failed = 0,
		AlreadyAtGoal = 1,
		RequestSuccessful = 2,
	}
}
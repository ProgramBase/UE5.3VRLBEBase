using Script.CoreUObject;

namespace Script.GameplayTasks
{
	[PathName("/Script/GameplayTasks.EGameplayTaskState")]
	public enum EGameplayTaskState : long
	{
		Uninitialized = 0,
		AwaitingActivation = 1,
		Paused = 2,
		Active = 3,
		Finished = 4,
	}
}
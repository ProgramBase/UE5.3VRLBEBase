using Script.CoreUObject;

namespace Script.GameplayTasks
{
	[PathName("/Script/GameplayTasks.EGameplayTaskRunResult")]
	public enum EGameplayTaskRunResult : byte
	{
		Error = 0,
		Failed = 1,
		Success_Paused = 2,
		Success_Active = 3,
		Success_Finished = 4,
	}
}
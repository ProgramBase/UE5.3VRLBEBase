using Script.CoreUObject;

namespace Script.GameplayTasks
{
	[PathName("/Script/GameplayTasks.ETaskResourceOverlapPolicy")]
	public enum ETaskResourceOverlapPolicy : byte
	{
		StartOnTop = 0,
		StartAtEnd = 1,
		RequestCancelAndStartOnTop = 2,
		RequestCancelAndStartAtEnd = 3,
	}
}
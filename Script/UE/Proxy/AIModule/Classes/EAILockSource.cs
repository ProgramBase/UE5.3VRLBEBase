using Script.CoreUObject;

namespace Script.AIModule
{
	[PathName("/Script/AIModule.EAILockSource")]
	public enum EAILockSource : long
	{
		Animation = 0,
		Logic = 1,
		Script = 2,
		Gameplay = 3,
	}
}
using Script.CoreUObject;

namespace Script.GameplayDebugger
{
	[PathName("/Script/GameplayDebugger.EGameplayDebuggerOverrideMode")]
	public enum EGameplayDebuggerOverrideMode : byte
	{
		Enable = 0,
		Disable = 1,
		UseDefault = 2,
	}
}
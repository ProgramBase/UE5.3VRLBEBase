using Script.CoreUObject;

namespace Script.AIModule
{
	[PathName("/Script/AIModule.EEnvQueryHightlightMode")]
	public enum EEnvQueryHightlightMode : byte
	{
		All = 0,
		Best5Pct = 1,
		Best25Pct = 2,
	}
}
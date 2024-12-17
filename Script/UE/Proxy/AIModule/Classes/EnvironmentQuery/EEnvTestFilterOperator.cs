using Script.CoreUObject;

namespace Script.AIModule
{
	[PathName("/Script/AIModule.EEnvTestFilterOperator")]
	public enum EEnvTestFilterOperator : byte
	{
		AllPass = 0,
		AnyPass = 1,
	}
}
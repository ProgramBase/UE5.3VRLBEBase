using Script.CoreUObject;

namespace Script.AIModule
{
	[PathName("/Script/AIModule.EEnvQueryRunMode")]
	public enum EEnvQueryRunMode : byte
	{
		SingleResult = 0,
		RandomBest5Pct = 1,
		RandomBest25Pct = 2,
		AllMatching = 3,
	}
}
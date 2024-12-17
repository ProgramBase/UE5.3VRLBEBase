using Script.CoreUObject;

namespace Script.AIModule
{
	[PathName("/Script/AIModule.EEnvQueryTestClamping")]
	public enum EEnvQueryTestClamping : byte
	{
		None = 0,
		SpecifiedValue = 1,
		FilterThreshold = 2,
	}
}
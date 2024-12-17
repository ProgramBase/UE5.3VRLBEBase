using Script.CoreUObject;

namespace Script.AIModule
{
	[PathName("/Script/AIModule.EEnvTestPurpose")]
	public enum EEnvTestPurpose : byte
	{
		Filter = 0,
		Score = 1,
		FilterAndScore = 2,
	}
}
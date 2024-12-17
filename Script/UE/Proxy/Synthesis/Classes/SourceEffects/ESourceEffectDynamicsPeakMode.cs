using Script.CoreUObject;

namespace Script.Synthesis
{
	[PathName("/Script/Synthesis.ESourceEffectDynamicsPeakMode")]
	public enum ESourceEffectDynamicsPeakMode : byte
	{
		MeanSquared = 0,
		RootMeanSquared = 1,
		Peak = 2,
		Count = 3,
	}
}
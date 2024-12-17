using Script.CoreUObject;

namespace Script.Synthesis
{
	[PathName("/Script/Synthesis.ESourceEffectMotionFilterModDestination")]
	public enum ESourceEffectMotionFilterModDestination : byte
	{
		FilterACutoffFrequency = 0,
		FilterAResonance = 1,
		FilterAOutputVolumeDB = 2,
		FilterBCutoffFrequency = 3,
		FilterBResonance = 4,
		FilterBOutputVolumeDB = 5,
		FilterMix = 6,
		Count = 7,
	}
}
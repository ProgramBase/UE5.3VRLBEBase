using Script.CoreUObject;

namespace Script.Synthesis
{
	[PathName("/Script/Synthesis.ESourceEffectMotionFilterType")]
	public enum ESourceEffectMotionFilterType : byte
	{
		LowPass = 0,
		HighPass = 1,
		BandPass = 2,
		BandStop = 3,
		Count = 4,
	}
}
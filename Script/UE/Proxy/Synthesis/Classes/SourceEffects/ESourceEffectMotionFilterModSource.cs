using Script.CoreUObject;

namespace Script.Synthesis
{
	[PathName("/Script/Synthesis.ESourceEffectMotionFilterModSource")]
	public enum ESourceEffectMotionFilterModSource : byte
	{
		DistanceFromListener = 0,
		SpeedRelativeToListener = 1,
		SpeedOfSourceEmitter = 2,
		SpeedOfListener = 3,
		SpeedOfAngleDelta = 4,
		Count = 5,
	}
}
using Script.CoreUObject;

namespace Script.AnimGraphRuntime
{
	[PathName("/Script/AnimGraphRuntime.EModifyCurveApplyMode")]
	public enum EModifyCurveApplyMode : byte
	{
		Add = 0,
		Scale = 1,
		Blend = 2,
		WeightedMovingAverage = 3,
		RemapCurve = 4,
	}
}
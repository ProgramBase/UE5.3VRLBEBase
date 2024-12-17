using Script.CoreUObject;

namespace Script.AnimGraphRuntime
{
	[PathName("/Script/AnimGraphRuntime.ERBFNormalizeMethod")]
	public enum ERBFNormalizeMethod : byte
	{
		OnlyNormalizeAboveOne = 0,
		AlwaysNormalize = 1,
		NormalizeWithinMedian = 2,
		NoNormalization = 3,
	}
}
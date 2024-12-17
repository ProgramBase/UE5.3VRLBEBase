using Script.CoreUObject;

namespace Script.AnimGraphRuntime
{
	[PathName("/Script/AnimGraphRuntime.ERBFFunctionType")]
	public enum ERBFFunctionType : byte
	{
		Gaussian = 0,
		Exponential = 1,
		Linear = 2,
		Cubic = 3,
		Quintic = 4,
		DefaultFunction = 5,
	}
}
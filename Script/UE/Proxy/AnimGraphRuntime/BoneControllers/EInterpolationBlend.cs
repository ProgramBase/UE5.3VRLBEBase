using Script.CoreUObject;

namespace Script.AnimGraphRuntime
{
	[PathName("/Script/AnimGraphRuntime.EInterpolationBlend")]
	public enum EInterpolationBlend : byte
	{
		Linear = 0,
		Cubic = 1,
		Sinusoidal = 2,
		EaseInOutExponent2 = 3,
		EaseInOutExponent3 = 4,
		EaseInOutExponent4 = 5,
		EaseInOutExponent5 = 6,
	}
}
using Script.CoreUObject;

namespace Script.GameplayCameras
{
	[PathName("/Script/GameplayCameras.ECameraAnimationEasingType")]
	public enum ECameraAnimationEasingType : byte
	{
		Linear = 0,
		Sinusoidal = 1,
		Quadratic = 2,
		Cubic = 3,
		Quartic = 4,
		Quintic = 5,
		Exponential = 6,
		Circular = 7,
	}
}
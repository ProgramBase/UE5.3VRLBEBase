using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.EMobilePlanarReflectionMode")]
	public enum EMobilePlanarReflectionMode : byte
	{
		Usual = 0,
		MobilePPRExclusive = 1,
		MobilePPR = 2,
	}
}
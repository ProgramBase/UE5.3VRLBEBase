using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.ESoundWaveFFTSize")]
	public enum ESoundWaveFFTSize : byte
	{
		VerySmall_64 = 0,
		Small_256 = 1,
		Medium_512 = 2,
		Large_1024 = 3,
		VeryLarge_2048 = 4,
	}
}
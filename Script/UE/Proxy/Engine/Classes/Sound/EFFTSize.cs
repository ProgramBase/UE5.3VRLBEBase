using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.EFFTSize")]
	public enum EFFTSize : byte
	{
		DefaultSize = 0,
		Min = 1,
		Small = 2,
		Medium = 3,
		Large = 4,
		VeryLarge = 5,
		Max = 6,
	}
}
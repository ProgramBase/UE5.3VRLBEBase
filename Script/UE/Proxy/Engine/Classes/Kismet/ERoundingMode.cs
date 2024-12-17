using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.ERoundingMode")]
	public enum ERoundingMode : byte
	{
		HalfToEven = 0,
		HalfFromZero = 1,
		HalfToZero = 2,
		FromZero = 3,
		ToZero = 4,
		ToNegativeInfinity = 5,
		ToPositiveInfinity = 6,
	}
}
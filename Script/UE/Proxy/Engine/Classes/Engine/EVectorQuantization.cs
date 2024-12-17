using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.EVectorQuantization")]
	public enum EVectorQuantization : byte
	{
		RoundWholeNumber = 0,
		RoundOneDecimal = 1,
		RoundTwoDecimals = 2,
	}
}
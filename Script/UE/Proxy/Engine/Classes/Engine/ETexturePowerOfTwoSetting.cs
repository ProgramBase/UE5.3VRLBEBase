using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.ETexturePowerOfTwoSetting")]
	public enum ETexturePowerOfTwoSetting : byte
	{
		None = 0,
		PadToPowerOfTwo = 1,
		PadToSquarePowerOfTwo = 2,
	}
}
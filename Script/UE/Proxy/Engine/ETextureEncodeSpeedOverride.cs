using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.ETextureEncodeSpeedOverride")]
	public enum ETextureEncodeSpeedOverride : byte
	{
		Disabled = 255,
		Final = 0,
		FinalIfAvailable = 1,
		Fast = 2,
	}
}
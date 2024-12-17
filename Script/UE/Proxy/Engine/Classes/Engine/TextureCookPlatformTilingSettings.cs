using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.TextureCookPlatformTilingSettings")]
	public enum TextureCookPlatformTilingSettings : byte
	{
		TCPTS_FromTextureGroup = 0,
		TCPTS_Tile = 1,
		TCPTS_DoNotTile = 2,
	}
}
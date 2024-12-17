using Script.CoreUObject;

namespace Script.TextureUtilitiesCommon
{
	[PathName("/Script/TextureUtilitiesCommon.ETextureImportPNGInfill")]
	public enum ETextureImportPNGInfill : byte
	{
		Default = 0,
		Never = 1,
		OnlyOnBinaryTransparency = 2,
		Always = 3,
	}
}
using Script.CoreUObject;

namespace Script.TextureUtilitiesCommon
{
	[PathName("/Script/TextureUtilitiesCommon.ETextureImportFloatingPointFormat")]
	public enum ETextureImportFloatingPointFormat : byte
	{
		HDR_F16 = 0,
		HDRCompressed_BC6 = 1,
		HDR_F32_or_F16 = 2,
		PreviousDefault = 0,
	}
}